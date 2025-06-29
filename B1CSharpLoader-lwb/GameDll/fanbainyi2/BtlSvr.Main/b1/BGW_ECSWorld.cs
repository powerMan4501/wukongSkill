using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using AOT;
using b1.ECS;
using b1.Plugins.GSReplaySystem;
using b1.Profile;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BGW_ECSWorld : GameInstanceSystemBase, IGIOForTickDisable
{
	private class TmpECSWorldObj : IECSWorldObj
	{
		public UActorCompContainerCS ActorCompContainerCS
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public UActorDataContainer DataComp
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public Entity ECSEntity { get; set; }

		public Chunk ECSChunk { get; set; }

		public int ECSIndexInChunk { get; set; }

		public int ECSArcheType => ECSEntity.ArchIndex;

		public void AfterInitAllComp()
		{
			throw new NotImplementedException();
		}

		public object GetEventCollection()
		{
			return null;
		}

		public void InitAllComp()
		{
			throw new NotImplementedException();
		}

		public bool IsBeginPlayFinished()
		{
			return ActorCompContainerCS.HasLateBeginPlay;
		}

		public object GetDataByChunk(int TypeIndex)
		{
			return null;
		}
	}

	private class EntityRef : IEntityRef
	{
		private WeakReference<IECSWorldObj> _WorldObj;

		internal bool NeedDestroy;

		internal float ForceDestroyCountDown = 180f;

		internal bool HasLeakLoged;

		public IECSWorldObj WorldObj
		{
			get
			{
				if (_WorldObj.TryGetTarget(out var target))
				{
					return target;
				}
				return null;
			}
			set
			{
				_WorldObj = new WeakReference<IECSWorldObj>(value);
			}
		}

		public Entity Entity
		{
			get
			{
				if (WorldObj == null)
				{
					return Entity.Null;
				}
				return WorldObj.ECSEntity;
			}
		}

		public int RefCount { get; protected set; }

		public void Retain()
		{
			RefCount++;
		}

		public void Release()
		{
			RefCount--;
		}

		internal EntityRef(IECSWorldObj WorldObj)
		{
			this.WorldObj = WorldObj;
		}

		internal void SetNull()
		{
			WorldObj = null;
			RefCount = 0;
		}
	}

	public struct EntityRefState
	{
		public bool NeedDestroy;

		public bool HasLeakLoged;

		public EntityRefState(bool InNeedDestroy, bool InHasLeakLoged)
		{
			NeedDestroy = InNeedDestroy;
			HasLeakLoged = InHasLeakLoged;
		}
	}

	private delegate int Del_ECSNetSerializationCallBack(IntPtr ConnectionPtr, int OldVersion, IntPtr param);

	private delegate int Del_ECSNetDeSerializationCallBack(IntPtr ConnectionPtr, IntPtr param);

	private List<AActor> ActorDestroyQueue = new List<AActor>();

	private UnorderedDict<Entity, EntityRef> DicEntityRef = new UnorderedDict<Entity, EntityRef>();

	private static Dictionary<IntPtr, IActorGSReplicateableDataComp> sDataContainerMap;

	private static NativeList<byte> sGSRepSwap;

	public static BGW_NativeFuncs.ECSNetSerializationCallBack sECSNetSerializationCallBack;

	public static BGW_NativeFuncs.ECSNetDeSerializationCallBack sECSNetDeSerializationCallBack;

	protected Dictionary<IntPtr, Dictionary<Entity, uint>> EntityNetGuidMap = new Dictionary<IntPtr, Dictionary<Entity, uint>>();

	protected Dictionary<IntPtr, Dictionary<uint, Entity>> NetGuidEntityMap = new Dictionary<IntPtr, Dictionary<uint, Entity>>();

	protected Dictionary<int, List<Entity>> EntitiesNotBeginPlay = new Dictionary<int, List<Entity>>();

	protected Stopwatch SWBeginPlay = new Stopwatch();

	private const int BEGIN_PLAY_TIME_LIMIT_MS = 3;

	private const int BEGIN_PLAY_WARNING_MS = 10;

	private Stopwatch EntityBeginStopWatch = new Stopwatch();

	public bool WorldPause;

	public float WorldTimeDilation = 1f;

	protected EntityManager EntMgr;

	public float GSTimeAfterBeginPlay;

	protected int TickStatId = -1;

	protected int TickWithGroupStatId = -1;

	protected int RequireLockStatId = -1;

	protected Dictionary<ReportFrameMapKey, int> FrameMap;

	protected List<long> ReocrdTickTimeList;

	protected float RecordLimitTime;

	protected double[] sampleBuckets = new double[4] { 2.0, 10.0, 20.0, 100.0 };

	private static BGW_ECSWorld[] s_instance;

	private ThreadTickDispatcher TTDispatcher = new ThreadTickDispatcher();

	private static BGW_ECSWorld SelfTmp;

	private static float DeltaTimeTmp;

	private static int ThreadTickGroup;

	private Dictionary<int, Task[]> ThreadTasksByGroup = new Dictionary<int, Task[]>();

	public static int ThreadCount;

	public bool HasECSWorldBeginPlay { get; private set; }

	public override bool bTickEnabled => true;

	internal IEntityRef GetOrAllocEntityRef(IECSWorldObj Obj)
	{
		if (!DicEntityRef.Find(Obj.ECSEntity, out var output))
		{
			output = new EntityRef(Obj);
			DicEntityRef[Obj.ECSEntity] = output;
		}
		return output;
	}

	public bool GetEntityRefState(Entity Entity, out EntityRefState State)
	{
		if (DicEntityRef.Find(Entity, out var output))
		{
			State = new EntityRefState(output.NeedDestroy, output.HasLeakLoged);
			return true;
		}
		State = new EntityRefState(InNeedDestroy: true, InHasLeakLoged: false);
		return false;
	}

	public void DestroyActor(AActor Actor)
	{
		ActorDestroyQueue.Add(Actor);
	}

	protected void ClearECSObjRef()
	{
		DicEntityRef.BeginItr();
		Entity oKey;
		EntityRef oVal;
		while (DicEntityRef.NextItr(out oKey, out oVal))
		{
			if (oVal.NeedDestroy)
			{
				EntMgr.DestroyEntity(oKey);
				oVal.WorldObj.ECSEntity = Entity.Null;
				oVal.WorldObj.ECSChunk = null;
				oVal.WorldObj.ECSIndexInChunk = 0;
			}
			oVal.SetNull();
			DicEntityRef.Remove();
		}
	}

	public void DestroyEntity(IECSWorldObj WorldObj)
	{
		EntitiesNotBeginPlay[WorldObj.ECSEntity.ArchIndex].Remove(WorldObj.ECSEntity);
		if (DicEntityRef.Find(WorldObj.ECSEntity, out var output))
		{
			output.NeedDestroy = true;
			EntMgr.DestroyEntityUnPersistentPart(WorldObj.ECSEntity);
			return;
		}
		EntMgr.DestroyEntity(WorldObj.ECSEntity);
		WorldObj.ECSEntity = Entity.Null;
		WorldObj.ECSChunk = null;
		WorldObj.ECSIndexInChunk = 0;
	}

	public void OnActorReUse(Entity Entity)
	{
		if (DicEntityRef.Find(Entity, out var output))
		{
			output.WorldObj.ECSEntity = Entity.Null;
			output.WorldObj = new TmpECSWorldObj();
			output.WorldObj.ECSEntity = Entity;
			output.WorldObj.ECSChunk = EntMgr.GetChunk(Entity);
			output.WorldObj.ECSIndexInChunk = Entity.IndexInChunk;
			DicEntityRef.Remove(Entity);
		}
	}

	public void TickEntityDestroy(float DeltaTime)
	{
		for (int num = ActorDestroyQueue.Count - 1; num >= 0; num--)
		{
			AActor aActor = ActorDestroyQueue[num];
			if (!aActor.IsNullOrDestroyed())
			{
				aActor.DestroyActor();
			}
			ActorDestroyQueue.RemoveAt(num);
		}
		DicEntityRef.BeginItr();
		Entity oKey;
		EntityRef oVal;
		while (DicEntityRef.NextItr(out oKey, out oVal))
		{
			if (oVal.NeedDestroy)
			{
				oVal.ForceDestroyCountDown -= DeltaTime;
			}
			if (oVal.ForceDestroyCountDown <= 0f && !oVal.HasLeakLoged)
			{
				_ = $"ObjRef.ForceDestroyCountDown Passed!!! May Crash On NonEditor Version!!! {oKey}";
				oVal.HasLeakLoged = true;
			}
			if (oVal.RefCount <= 0 || oVal.ForceDestroyCountDown <= 0f)
			{
				if (oVal.NeedDestroy)
				{
					EntMgr.DestroyEntity(oKey);
					oVal.WorldObj.ECSEntity = Entity.Null;
					oVal.WorldObj.ECSChunk = null;
					oVal.WorldObj.ECSIndexInChunk = 0;
				}
				oVal.SetNull();
				DicEntityRef.Remove();
			}
		}
	}

	public bool GetNetGUIDForEntity(IntPtr ConnectionPtr, Entity Entity, out uint NetGuid)
	{
		bool flag = false;
		if (!EntityNetGuidMap.TryGetValue(ConnectionPtr, out var value))
		{
			value = new Dictionary<Entity, uint>();
			EntityNetGuidMap[ConnectionPtr] = value;
		}
		flag = value.TryGetValue(Entity, out NetGuid);
		if (!flag)
		{
			AActor aActor = ECSExtension.ToActor(Entity);
			if (aActor != null)
			{
				NetGuid = BGW_NativeFuncs.GSRep_GetGUIDForActor(ConnectionPtr, aActor.Address);
				flag = NetGuid != 0;
				if (flag)
				{
					value[Entity] = NetGuid;
				}
			}
		}
		return flag;
	}

	public bool GetEntityForNetGUID(IntPtr ConnectionPtr, uint NetGuid, out Entity Entity)
	{
		bool flag = false;
		if (!NetGuidEntityMap.TryGetValue(ConnectionPtr, out var value))
		{
			value = new Dictionary<uint, Entity>();
			NetGuidEntityMap[ConnectionPtr] = value;
		}
		flag = value.TryGetValue(NetGuid, out Entity);
		if (!flag)
		{
			IntPtr intPtr = BGW_NativeFuncs.GSRep_GetActorForGUID(ConnectionPtr, NetGuid);
			if (intPtr != IntPtr.Zero)
			{
				AActor aActor = GCHelper.Find<AActor>(intPtr);
				if (aActor != null)
				{
					Entity = ECSExtension.ToEntity(aActor);
					flag = Entity != Entity.Null;
				}
			}
		}
		return flag;
	}

	static BGW_ECSWorld()
	{
		sDataContainerMap = new Dictionary<IntPtr, IActorGSReplicateableDataComp>();
		sGSRepSwap = new NativeList<byte>(64);
		s_instance = new BGW_ECSWorld[16];
		ThreadCount = 4;
		sECSNetSerializationCallBack = ECSNetSerializationCallBack;
		sECSNetDeSerializationCallBack = ECSNetDeSerializationCallBack;
		BGW_NativeFuncs.GSRep_Init(sECSNetSerializationCallBack, sECSNetDeSerializationCallBack);
	}

	[MonoPInvokeCallback(typeof(Del_ECSNetSerializationCallBack))]
	private static int ECSNetSerializationCallBack(IntPtr ConnectionPtr, int OldVersion, IntPtr param)
	{
		try
		{
			if (sDataContainerMap.TryGetValue(param, out var value))
			{
				return value.DeltaSerilize(ConnectionPtr, OldVersion, sGSRepSwap);
			}
			return -1;
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			return -1;
		}
	}

	[MonoPInvokeCallback(typeof(Del_ECSNetDeSerializationCallBack))]
	private static int ECSNetDeSerializationCallBack(IntPtr ConnectionPtr, IntPtr param)
	{
		try
		{
			if (sDataContainerMap.TryGetValue(param, out var value))
			{
				return value.DeltaDeSerilize(ConnectionPtr, sGSRepSwap);
			}
			return -2;
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			return -2;
		}
	}

	public static void RegisterDataComp(UActorDataContainer DataContainer)
	{
		if (DataContainer is IActorGSReplicateableDataComp)
		{
			BGW_NativeFuncs.GSRep_SwapRepData(DataContainer.GetOwner().Address, DataContainer.Address, sGSRepSwap.Address);
			sDataContainerMap[DataContainer.Address] = DataContainer as IActorGSReplicateableDataComp;
		}
	}

	public static void UnRegisterDataComp(UActorDataContainer DataContainer)
	{
		sDataContainerMap.Remove(DataContainer.Address);
	}

	protected void InitEntitiesNotBeginPlay()
	{
		for (int i = 0; i < 13; i++)
		{
			EntitiesNotBeginPlay.Add(i, new List<Entity>());
		}
	}

	public void ECSWorldBeginPlay(bool ThrowExWithErrorGameState = true)
	{
		HasECSWorldBeginPlay = true;
		BGWGameInstanceCS byEntityMgrIdx = BGWGameInstanceCS.GetByEntityMgrIdx(GetEntityMgrIdx());
		BGW_EventCollection.Get(byEntityMgrIdx).Evt_PreECSWorldBeginPlay();
		CallFirstEntityBeginPlayByArchType(BGU_ArcheTypes.AT_BGG_GameState, ThrowExWithErrorGameState);
		if (!UGSE_EngineFuncLib.IsClient(BGWGameInstanceCS.GetByEntityMgrIdx(EntMgr.ManagerIdx).GetWorldForCS()))
		{
			CallFirstEntityBeginPlayByArchType(BGU_ArcheTypes.AT_BGG_GameMode, ThrowExWithErrorGameState);
		}
		if (!UGSE_EngineFuncLib.IsDedicateServer(BGWGameInstanceCS.GetByEntityMgrIdx(EntMgr.ManagerIdx).GetWorldForCS()))
		{
			CallFirstEntityBeginPlayByArchType(BGU_ArcheTypes.AT_DispLibWorld, ThrowExWithErrorGameState);
			CallFirstEntityBeginPlayByArchType(BGU_ArcheTypes.AT_DispLibWorldB1X2, ThrowExWithErrorGameState);
		}
		if (!UGSReplayFuncLib.IsPlayingReplay(byEntityMgrIdx))
		{
			APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(byEntityMgrIdx);
			BeginPlayEntity(ECSUtil.ToEntity(firstLocalPlayerController.PlayerState));
			BeginPlayEntity(ECSUtil.ToEntity(firstLocalPlayerController));
			if (ThrowExWithErrorGameState)
			{
				BeginPlayEntity(ECSUtil.ToEntity(firstLocalPlayerController.GetControlledPawn()));
			}
		}
		foreach (KeyValuePair<int, List<Entity>> item in EntitiesNotBeginPlay)
		{
			int num;
			for (num = item.Value.Count - 1; num >= 0; num--)
			{
				num = Math.Min(num, item.Value.Count - 1);
				BeginPlayEntity(item.Value[num]);
			}
		}
		BGW_EventCollection.Get(byEntityMgrIdx).Evt_TamerStratergyInitFinish();
	}

	public void ECSWorldReset()
	{
		HasECSWorldBeginPlay = false;
		ActorDestroyQueue.Clear();
		ClearECSObjRef();
	}

	protected void TickECSEntityBeginPlayNormal()
	{
		BGGGameStateCS bGGGameStateCS = UGameplayStatics.GetGameState(BGWGameInstanceCS.GetByEntityMgrIdx(GetEntityMgrIdx())) as BGGGameStateCS;
		if (bGGGameStateCS == null || !bGGGameStateCS.HasMatchStarted() || !HasECSWorldBeginPlay)
		{
			return;
		}
		foreach (KeyValuePair<int, List<Entity>> item in EntitiesNotBeginPlay)
		{
			while (item.Value.Count > 0)
			{
				BeginPlayEntity(item.Value[0]);
			}
		}
	}

	protected void TickECSEntityBeginPlaySeperateFrame()
	{
		EntityBeginStopWatch.Reset();
		EntityBeginStopWatch.Start();
		int num = 0;
		while (EntitiesNotBeginPlay.Count > num)
		{
			List<Entity> list = EntitiesNotBeginPlay[num];
			if (list.Count <= 0)
			{
				num++;
			}
			else
			{
				Entity entity = list[0];
				BeginPlayEntity(entity);
			}
			if (EntityBeginStopWatch.ElapsedMilliseconds >= 3)
			{
				break;
			}
		}
	}

	public void TickECSEntityBeginPlay()
	{
		BGGGameStateCS bGGGameStateCS = UGameplayStatics.GetGameState(BGWGameInstanceCS.GetByEntityMgrIdx(GetEntityMgrIdx())) as BGGGameStateCS;
		if (!(bGGGameStateCS == null) && bGGGameStateCS.HasMatchStarted() && HasECSWorldBeginPlay)
		{
			BGWGameInstanceCS.GetByEntityMgrIdx(GetEntityMgrIdx()).GetCurLoadingScreenState();
			if (DebugConfig.OpenSeparateFrameEntityBeginPlay)
			{
				TickECSEntityBeginPlaySeperateFrame();
			}
			else
			{
				TickECSEntityBeginPlayNormal();
			}
		}
	}

	public Entity CreateEntity(int ArchType)
	{
		Entity entity = EntMgr.CreateEntity(ArchType);
		EntitiesNotBeginPlay[ArchType].Add(entity);
		return entity;
	}

	protected void CallFirstEntityBeginPlayByArchType(BGU_ArcheTypes ArchType, bool ThrowExWithErrorGameState)
	{
		if (ThrowExWithErrorGameState || EntitiesNotBeginPlay.TryGetValue((int)ArchType, out var _))
		{
			if (EntitiesNotBeginPlay[(int)ArchType].Count != 1 && ThrowExWithErrorGameState)
			{
				throw new Exception($"InitECSWorldAfterMatchStart EntitiesNotBeginPlay[ArchType].Count != 1 ArchType:{ArchType} EntityCount:{EntitiesNotBeginPlay[(int)ArchType].Count}");
			}
			if (EntitiesNotBeginPlay[(int)ArchType].Count > 0)
			{
				BeginPlayEntity(EntitiesNotBeginPlay[(int)ArchType][0]);
			}
		}
	}

	public void BeginPlayEntity(Entity Entity)
	{
		if (!HasECSWorldBeginPlay)
		{
			throw new Exception($"Trying BeginPlayEntity Before HasECSWorldBeginPlay {Entity}");
		}
		IECSWorldObj obj = ECSUtil.ToActor(Entity) as IECSWorldObj;
		EntitiesNotBeginPlay[Entity.ArchIndex].Remove(Entity);
		obj.ActorCompContainerCS.PreCallECSCompBeginPlay();
		obj.InitAllComp();
		obj.AfterInitAllComp();
		obj.ActorCompContainerCS.CallECSCompPreBeginPlay();
		obj.DataComp.PreECSBeginPlay();
		obj.ActorCompContainerCS.CallECSCompBeginPlay();
		obj.DataComp.LateECSBeginPlay();
		obj.ActorCompContainerCS.CallECSCompLateBeginPlay();
	}

	public void BeginPlayEntityForTamerFirstStep(Entity Entity)
	{
		if (!HasECSWorldBeginPlay)
		{
			throw new Exception($"Trying BeginPlayEntity Before HasECSWorldBeginPlay {Entity}");
		}
		EntitiesNotBeginPlay[Entity.ArchIndex].Remove(Entity);
		IECSWorldObj obj = ECSUtil.ToActor(Entity) as IECSWorldObj;
		obj.ActorCompContainerCS.PreCallECSCompBeginPlay();
		obj.InitAllComp();
		obj.AfterInitAllComp();
	}

	public void BeginPlayEntityForTamerSecondStep(Entity Entity)
	{
		if (!HasECSWorldBeginPlay)
		{
			throw new Exception($"Trying BeginPlayEntity Before HasECSWorldBeginPlay {Entity}");
		}
		IECSWorldObj obj = ECSUtil.ToActor(Entity) as IECSWorldObj;
		obj.ActorCompContainerCS.CallECSCompPreBeginPlay();
		obj.DataComp.PreECSBeginPlay();
		obj.ActorCompContainerCS.CallECSCompBeginPlay();
		obj.DataComp.LateECSBeginPlay();
		obj.ActorCompContainerCS.CallECSCompLateBeginPlay();
	}

	public int GetEntityMgrIdx()
	{
		return EntMgr.ManagerIdx;
	}

	public override void OnInit()
	{
		InitEntitiesNotBeginPlay();
		EntMgr = new EntityManager();
		BGU_ECSArchTypes.CreateAll(EntMgr);
		s_instance[EntMgr.ManagerIdx] = this;
		FrameMap = new Dictionary<ReportFrameMapKey, int>();
		ReocrdTickTimeList = new List<long>();
		RegisterProfileTickGroupConfig();
	}

	public void RecalculateAllActorCanTick()
	{
		EntMgr.ForEachComponents(delegate(IEntityComponent Comp)
		{
			if (Comp is IActorCompBase actorCompBase)
			{
				actorCompBase.RecalculateCanTick();
			}
		});
	}

	private void RegisterProfileTickGroupConfig()
	{
		foreach (object value in Enum.GetValues(typeof(BGW_TickGroupMask)))
		{
			GSE_ProfileUtil.RegisterTickGroupMaskDic((int)value, value.ToString());
		}
	}

	public static BGW_ECSWorld Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_ECSWorld>(WorldContext);
	}

	public static BGW_ECSWorld Get(Entity Ent)
	{
		if (!Ent.IsNull())
		{
			return s_instance[Ent.EntityMgrIdx];
		}
		return null;
	}

	public SafeDataType GetDataSafe<SafeDataType>(Entity Ent) where SafeDataType : IEntitySafeData, new()
	{
		return EntMgr.GetDataSafe<SafeDataType>(Ent);
	}

	public object GetDataSafe(Entity Ent, int TypeIndex)
	{
		return EntMgr.GetDataSafe(Ent, TypeIndex);
	}

	public T GetDataSafe<T>(Entity Ent, int TypeIndex) where T : new()
	{
		return EntMgr.GetDataSafe<T>(Ent, TypeIndex);
	}

	public void SetObject<T>(Entity Entity, T Data) where T : class
	{
		EntMgr.SetObject(Entity, Data);
	}

	public void SetObject(Entity InEntity, int TypeIndex, object Data)
	{
		EntMgr.SetObject(InEntity, TypeIndex, Data);
	}

	public T GetObject<T>(Entity Ent) where T : class
	{
		return EntMgr.GetObject(Ent, TypeManager.GetTypeIndex<T>()) as T;
	}

	public object GetObject(Entity InEntity, int TypeIndex)
	{
		return EntMgr?.GetObject(InEntity, TypeIndex);
	}

	public Chunk GetEntityChunk(Entity Ent)
	{
		Ent.GetChunkIndices(out var _, out var OutArchIndex, out var OutChunkIndex, out var OutIndexInChunk, out var OutVersion);
		return EntMgr.GetChunk(OutArchIndex, OutChunkIndex, OutIndexInChunk, OutVersion);
	}

	public void AddMask(Entity Entity, int Mask)
	{
		EntMgr?.AddMask(Entity, Mask);
	}

	public void RemoveMask(Entity Entity, int Mask)
	{
		EntMgr?.RemoveMask(Entity, Mask);
	}

	public int GetMask(Entity Entity)
	{
		return (EntMgr?.GetMask(Entity)).Value;
	}

	public virtual void OpenProfiler()
	{
		GSE_ProfileUtil.sOpenProfiler = true;
		TickStatId = ProfilerFuncLib.CreateStatID(GetType().FullName + ":Tick");
		TickWithGroupStatId = ProfilerFuncLib.CreateStatID(GetType().FullName + ":TickWithGroup");
		RequireLockStatId = ProfilerFuncLib.CreateStatID(GetType().FullName + ":TickWithLock");
	}

	[MonoPInvokeCallback(typeof(Del_VoidInt))]
	[HandleProcessCorruptedStateExceptions]
	private static void ThreadTickFunc(int Arg1)
	{
		try
		{
			SelfTmp.EntMgr.TickAllComponentsWithGroup(DeltaTimeTmp, ThreadTickGroup, Arg1, ThreadCount);
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			throw;
		}
	}

	private void OnTick(float DeltaTime)
	{
		RecordLimitTime += DeltaTime;
		if (WorldPause || !HasECSWorldBeginPlay)
		{
			return;
		}
		SelfTmp = this;
		DeltaTimeTmp = DeltaTime;
		TickEntityDestroy(DeltaTime);
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		try
		{
			if (TickStatId >= 0)
			{
				ProfilerFuncLib.BeginSampleWithStatID(TickStatId);
			}
			float num = DeltaTime * WorldTimeDilation;
			GSTimeAfterBeginPlay += num;
			EntMgr.TickAllComponentsWithGroup(num, 1);
			EntMgr.TickAllComponentsWithGroup(num, 1024);
			ThreadTick_Begin(16);
			EntMgr.TickAllComponentsWithGroup(num, 2);
			ThreadTick_End(16);
			if (TickStatId >= 0)
			{
				ProfilerFuncLib.EndSample();
			}
		}
		catch (Exception)
		{
			WorldPause = true;
			throw;
		}
		stopwatch.Stop();
		lock (ReocrdTickTimeList)
		{
			ReocrdTickTimeList.Add(stopwatch.ElapsedMilliseconds);
		}
		OnReport();
	}

	public override int GetTickGroupMask()
	{
		return int.MaxValue;
	}

	private void ThreadTick_Begin(int TickGroup)
	{
		ThreadTickGroup = TickGroup;
		EntMgr.BeginThreadCheck();
		if (ThreadCount > 0)
		{
			TTDispatcher.BeginThreadGroup(ThreadTickFunc);
		}
		else
		{
			EntMgr.TickAllComponentsWithGroup(DeltaTimeTmp, ThreadTickGroup, 0, 1);
		}
	}

	private void ThreadTick_End(int TickGroup)
	{
		if (ThreadCount > 0)
		{
			TTDispatcher.EndThreadGroup();
		}
		EntMgr.EndThreadCheck();
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (WorldPause || !HasECSWorldBeginPlay)
		{
			if (!WorldPause)
			{
				TickEntityDestroy(DeltaTime);
			}
			return;
		}
		if (TickGroup == 1024)
		{
			OnTick(DeltaTime);
			return;
		}
		SelfTmp = this;
		int num = 0;
		switch (TickGroup)
		{
		case 32:
		case 64:
		case 128:
		case 256:
		case 2048:
		case 4096:
			num = TickGroup;
			break;
		}
		if (TickGroup == 8)
		{
			TickECSEntityBeginPlay();
			num = 8;
		}
		if (num > 0)
		{
			float deltaTime = DeltaTime * WorldTimeDilation;
			if (TickWithGroupStatId > 0)
			{
				ProfilerFuncLib.BeginSampleWithStatID(TickWithGroupStatId);
			}
			EntMgr.TickAllComponentsWithGroup(deltaTime, num);
			if (TickWithGroupStatId > 0)
			{
				ProfilerFuncLib.EndSample();
			}
		}
	}

	public override void OnShutdown()
	{
		TTDispatcher.OnDestroy();
		ClearECSObjRef();
		s_instance[EntMgr.ManagerIdx] = null;
		EntMgr.Dispose();
		EntMgr = null;
	}

	public void OnReport(bool IsServer = false)
	{
		if (!(RecordLimitTime >= 10f))
		{
			return;
		}
		lock (ReocrdTickTimeList)
		{
			for (int i = 0; i < ReocrdTickTimeList.Count; i++)
			{
				_ = ReocrdTickTimeList[i];
			}
		}
		ReocrdTickTimeList.Clear();
		FrameMap.Clear();
		RecordLimitTime = 0f;
	}
}
