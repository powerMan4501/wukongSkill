using System;
using System.Collections.Generic;
using b1.ECS;
using b1.Plugins.AkAudio;
using b1.Plugins.AsyncLoadingScreen;
using b1.Profile;
using UnrealEngine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWGameInstanceCS")]
public class BGWGameInstanceCS : UBGWGameInstance
{
	public delegate string Del_PreLoginHandle(string Options, string LoginAddress, string UniqueId);

	public delegate void Del_UnrealPostLoginHandler(APlayerController NewController);

	public static bool EnableCSharpTick;

	public const bool OPEN_CFSMP = true;

	private static bool sTickingGameInstNetModeValid;

	private static EGameInstNetMode sTickingGameInstNetModePrivate;

	private Dictionary<Type, object> ObjDicts = new Dictionary<Type, object>();

	private List<IGameInstObj> ObjList = new List<IGameInstObj>();

	private List<IGameInstObj> TickList = new List<IGameInstObj>();

	private List<IGameInstObj> TickListForTickDisable = new List<IGameInstObj>();

	private List<IGameInstObj> ObjNotInited = new List<IGameInstObj>();

	private List<IGameInstObjCS> ObjListCS = new List<IGameInstObjCS>();

	private List<IGameInstObjCS> TickListCS = new List<IGameInstObjCS>();

	private List<IGameInstObjCS> TickListCSForTickDisable = new List<IGameInstObjCS>();

	private List<IGameInstObjCS> ObjNotInitedCS = new List<IGameInstObjCS>();

	private List<IGameInstObj> TickList_TickEvenWhenPaused = new List<IGameInstObj>();

	public EStartGameInstanceTypeForCS StartType = EStartGameInstanceTypeForCS.StartCS_StandAlone;

	public Del_PreLoginHandle PreLoginHandler;

	public Del_UnrealPostLoginHandler UnrealPostLoginHandler;

	protected static BGWGameInstanceCS s_instance;

	private static bool ObjRefs_IsValid;

	private static int ObjRefs_Offset;

	private static FFieldAddress ObjRefs_PropertyAddress;

	private TArrayReadWriteMarshaler<UObject> ObjRefs_Marshaler;

	private static bool ReceiveTick_IsValid;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static int ReceiveTick_DeltaSeconds_Offset;

	private static bool ReceiveTick_TickGroup_IsValid;

	private static int ReceiveTick_TickGroup_Offset;

	private static bool ReceiveInit_IsValid;

	private static IntPtr ReceiveInit_FunctionAddress;

	private static int ReceiveInit_ParamsSize;

	private static bool ReceiveShutdown_IsValid;

	private static IntPtr ReceiveShutdown_FunctionAddress;

	private static int ReceiveShutdown_ParamsSize;

	private static bool OnWorldChangedCS_IsValid;

	private static IntPtr OnWorldChangedCS_FunctionAddress;

	private static int OnWorldChangedCS_ParamsSize;

	private static bool OnWorldChangedCS_OldWorld_IsValid;

	private static int OnWorldChangedCS_OldWorld_Offset;

	private static bool OnWorldChangedCS_NewWorld_IsValid;

	private static int OnWorldChangedCS_NewWorld_Offset;

	private static bool OnPostActorTickCS_IsValid;

	private static IntPtr OnPostActorTickCS_FunctionAddress;

	private static int OnPostActorTickCS_ParamsSize;

	private static bool OnPostActorTickCS_World_IsValid;

	private static int OnPostActorTickCS_World_Offset;

	private static bool OnWorldTickStartCS_IsValid;

	private static IntPtr OnWorldTickStartCS_FunctionAddress;

	private static int OnWorldTickStartCS_ParamsSize;

	private static bool OnWorldTickStartCS_World_IsValid;

	private static int OnWorldTickStartCS_World_Offset;

	private static bool StartGameInstanceForCS_IsValid;

	private static IntPtr StartGameInstanceForCS_FunctionAddress;

	private static int StartGameInstanceForCS_ParamsSize;

	private static bool StartGameInstanceForCS_StartType_IsValid;

	private static int StartGameInstanceForCS_StartType_Offset;

	private static FFieldAddress StartGameInstanceForCS_StartType_PropertyAddress;

	private static bool GetOnlineSessionClassCS_IsValid;

	private static IntPtr GetOnlineSessionClassCS_FunctionAddress;

	private static int GetOnlineSessionClassCS_ParamsSize;

	private static bool GetOnlineSessionClassCS_ReturnValue_IsValid;

	private static int GetOnlineSessionClassCS_ReturnValue_Offset;

	private static bool ReceiveTickEvenWhenPaused_IsValid;

	private static IntPtr ReceiveTickEvenWhenPaused_FunctionAddress;

	private static int ReceiveTickEvenWhenPaused_ParamsSize;

	private static bool ReceiveTickEvenWhenPaused_DeltaSeconds_IsValid;

	private static int ReceiveTickEvenWhenPaused_DeltaSeconds_Offset;

	private static bool ReceiveTickEvenWhenPaused_TickGroup_IsValid;

	private static int ReceiveTickEvenWhenPaused_TickGroup_Offset;

	private static bool OnGameModeMatchStateSetCS_IsValid;

	private static IntPtr OnGameModeMatchStateSetCS_FunctionAddress;

	private static int OnGameModeMatchStateSetCS_ParamsSize;

	private static bool OnGameModeMatchStateSetCS_NewMatchState_IsValid;

	private static int OnGameModeMatchStateSetCS_NewMatchState_Offset;

	public static int sGlobalReplicateVersionAlloc { get; private set; }

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWGameInstanceCS:ObjRefs")]
	private TArrayReadWrite<UObject> ObjRefs
	{
		get
		{
			CheckDestroyed();
			if (!ObjRefs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGameInstanceCS:ObjRefs");
				return null;
			}
			if (ObjRefs_Marshaler == null)
			{
				ObjRefs_Marshaler = new TArrayReadWriteMarshaler<UObject>(1, ObjRefs_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative);
			}
			return ObjRefs_Marshaler.FromNative(IntPtr.Add(base.Address, ObjRefs_Offset));
		}
	}

	public bool InitGameInstObjDone { get; private set; }

	public bool InitDebugMgrDone { get; protected set; }

	public static int sPlayTime { get; private set; }

	public static EGameInstNetMode TickingGameInstNetMode(UObject WorldCtx)
	{
		if (!sTickingGameInstNetModeValid)
		{
			if (WorldCtx.IsNullOrDestroyed())
			{
				throw new Exception("TickingGameInstNetMode WorldCtx NullOrDestroyed");
			}
			UWorld worldForCS = Get(WorldCtx).GetWorldForCS();
			if (UGSE_EngineFuncLib.IsStandAlone(worldForCS))
			{
				return EGameInstNetMode.StandAlone;
			}
			if (UGSE_EngineFuncLib.IsListenServer(worldForCS))
			{
				return EGameInstNetMode.ListenServer;
			}
			if (UGSE_EngineFuncLib.IsDedicateServer(worldForCS))
			{
				return EGameInstNetMode.DedicateServer;
			}
			if (UGSE_EngineFuncLib.IsClient(worldForCS))
			{
				return EGameInstNetMode.Client;
			}
			throw new Exception("TickingGameInstNetMode UnKnow!!!");
		}
		return sTickingGameInstNetModePrivate;
	}

	public static bool TickingGameInstNetModeIsServer(UObject WorldCtx)
	{
		EGameInstNetMode eGameInstNetMode = TickingGameInstNetMode(WorldCtx);
		if (eGameInstNetMode != EGameInstNetMode.ListenServer)
		{
			return eGameInstNetMode == EGameInstNetMode.DedicateServer;
		}
		return true;
	}

	public static int AllocGlobalReplicateVersion()
	{
		return ++sGlobalReplicateVersionAlloc;
	}

	[USharpPath("/Script/b1-Managed.BGWGameInstanceCS:OnGameModeMatchStateSetCS")]
	protected override void OnGameModeMatchStateSetCS_Implementation(FName NewMatchState)
	{
		if (NewMatchState.ToString() == "LeavingMap")
		{
			BGW_EventCollection.Get(this).Evt_leavingMap();
		}
	}

	[USharpPath("/Script/b1-Managed.BGWGameInstanceCS:StartGameInstanceForCS")]
	protected override void StartGameInstanceForCS_Implementation(EStartGameInstanceTypeForCS StartType)
	{
		this.StartType = StartType;
		base.StartGameInstanceForCS_Implementation(StartType);
		BGW_EventCollection.Get(this).Evt_BGW_GameInstanceStart(StartType);
		UAkGameplayStatics.SetDummyObjListener();
	}

	[USharpPath("/Script/b1-Managed.BGWGameInstanceCS:OnWorldChangedCS")]
	protected override void OnWorldChangedCS_Implementation(UWorld OldWorld, UWorld NewWorld)
	{
		base.OnWorldChangedCS_Implementation(OldWorld, NewWorld);
		BGW_EventCollection.Get(this)?.Evt_BGW_OnWorldChanged(OldWorld, NewWorld);
		if (UGSE_EngineFuncLib.IsStandAlone(NewWorld))
		{
			UGSE_EngineFuncLib.CreateNamedNetDriver(NewWorld, B1GlobalFNames.GSStandAloneNetDriverHook, new FName("GSStandAloneNetDriverHook"));
		}
	}

	[USharpPath("/Script/b1-Managed.BGWGameInstanceCS:GetOnlineSessionClassCS")]
	protected override TSubclassOf<UOnlineSession> GetOnlineSessionClassCS_Implementation()
	{
		return UClass.GetClass<B1OnlineSessionCS>();
	}

	[USharpPath("/Script/b1-Managed.BGWGameInstanceCS:OnPostActorTickCS")]
	protected override void OnPostActorTickCS_Implementation(UWorld World)
	{
		base.OnPostActorTickCS_Implementation(World);
		sTickingGameInstNetModeValid = false;
	}

	[USharpPath("/Script/b1-Managed.BGWGameInstanceCS:OnWorldTickStartCS")]
	protected override void OnWorldTickStartCS_Implementation(UWorld World)
	{
		base.OnWorldTickStartCS_Implementation(World);
		sTickingGameInstNetModeValid = true;
		if (UGSE_EngineFuncLib.IsDedicateServer(World))
		{
			sTickingGameInstNetModePrivate = EGameInstNetMode.DedicateServer;
		}
		else if (UGSE_EngineFuncLib.IsListenServer(World))
		{
			sTickingGameInstNetModePrivate = EGameInstNetMode.ListenServer;
		}
		else if (UGSE_EngineFuncLib.IsClient(World))
		{
			sTickingGameInstNetModePrivate = EGameInstNetMode.Client;
		}
		else
		{
			sTickingGameInstNetModePrivate = EGameInstNetMode.StandAlone;
		}
	}

	[USharpPath("/Script/b1-Managed.BGWGameInstanceCS:ReceiveInit")]
	protected override void ReceiveInit_Implementation()
	{
		try
		{
			if (FGlobals.IsEditor)
			{
				FMessage.OpenDialog("检测到在PIE环境下使用Game的dll, 会触发很多异常, 请使用Debug_Editor重新编译");
				throw new Exception("检测到在PIE环境下使用Game的dll, 会触发很多异常, 请使用Debug_Editor重新编译");
			}
			s_instance = this;
			CreateClassCS<BGW_ECSWorld>();
			InitAllObjNotInited();
			BGWGameInstanceCS bGWGameInstanceCS = Get(this);
			if (bGWGameInstanceCS != null && !bGWGameInstanceCS.InitGameInstObjDone)
			{
				bGWGameInstanceCS.InitGameInstObj();
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.InvokeFunction);
		}
	}

	public virtual void InitGameInstObj()
	{
		sPlayTime++;
		InitAllObjNotInited();
		InitGameInstObjDone = true;
	}

	public virtual void InitAfterGameStateBeginPlay()
	{
	}

	public virtual void InitAfterStartUpGameModeBeginPlay()
	{
	}

	protected void InitAllObjNotInited()
	{
		if (!UGSE_EngineFuncLib.IsEditor())
		{
			for (int i = 0; i < ObjNotInited.Count; i++)
			{
				try
				{
					ObjNotInited[i].OnInit();
				}
				catch (Exception e)
				{
					ExceptionHandle(e);
				}
			}
			for (int j = 0; j < ObjNotInitedCS.Count; j++)
			{
				try
				{
					ObjNotInitedCS[j].OnInit();
				}
				catch (Exception e2)
				{
					ExceptionHandle(e2);
				}
			}
			for (int k = 0; k < ObjNotInited.Count; k++)
			{
				try
				{
					ObjNotInited[k].OnAfterInit();
				}
				catch (Exception e3)
				{
					ExceptionHandle(e3);
				}
			}
			for (int l = 0; l < ObjNotInitedCS.Count; l++)
			{
				try
				{
					ObjNotInitedCS[l].OnAfterInit();
				}
				catch (Exception e4)
				{
					ExceptionHandle(e4);
				}
			}
		}
		else
		{
			for (int m = 0; m < ObjNotInited.Count; m++)
			{
				ObjNotInited[m].OnInit();
			}
			for (int n = 0; n < ObjNotInitedCS.Count; n++)
			{
				ObjNotInitedCS[n].OnInit();
			}
			for (int num = 0; num < ObjNotInited.Count; num++)
			{
				ObjNotInited[num].OnAfterInit();
			}
			for (int num2 = 0; num2 < ObjNotInitedCS.Count; num2++)
			{
				ObjNotInitedCS[num2].OnAfterInit();
			}
		}
		ObjNotInited.Clear();
		ObjNotInitedCS.Clear();
		static void ExceptionHandle(Exception ex)
		{
			BGW_LogUtil.LogError(ex.ToString());
			BGW_LogUtil.LogError(ex.StackTrace.ToString());
			USharpExceptionHandler.HandleException(ex, EUSharpExceptionType.InvokeFunction);
		}
	}

	public virtual void InitAfterResUpdateFinish()
	{
		InitAllObjNotInited();
	}

	public object GetObject(Type InType)
	{
		if (ObjDicts.TryGetValue(InType, out var value))
		{
			return value;
		}
		return null;
	}

	public T GetObject<T>()
	{
		return (T)GetObject(typeof(T));
	}

	public static T GetObject<T>(UObject WorldCtx)
	{
		BGWGameInstanceCS bGWGameInstanceCS = Get(WorldCtx);
		if (bGWGameInstanceCS != null)
		{
			return (T)bGWGameInstanceCS.GetObject(typeof(T));
		}
		return default(T);
	}

	public static T GetObject<T>(Entity Ent)
	{
		if (Ent.IsNull())
		{
			return default(T);
		}
		return (T)GetByEntity(Ent).GetObject(typeof(T));
	}

	public static T GetObject<T>(int EntityMgrIdx)
	{
		BGWGameInstanceCS byEntityMgrIdx = GetByEntityMgrIdx(EntityMgrIdx);
		if (byEntityMgrIdx != null)
		{
			return (T)byEntityMgrIdx.GetObject(typeof(T));
		}
		return default(T);
	}

	protected T CreateUObj<T>() where T : UObject, IGameInstObj
	{
		T val = UObject.NewObject<T>(this);
		ObjRefs.Add(val);
		ObjDicts[typeof(T)] = val;
		IGameInstObj gameInstObj = val;
		if (gameInstObj != null)
		{
			if (gameInstObj.bTickEnabled)
			{
				TickList.Add(gameInstObj);
				if (val is IGIOForTickDisable)
				{
					TickListForTickDisable.Add(gameInstObj);
				}
			}
			ObjList.Add(gameInstObj);
			ObjNotInited.Add(gameInstObj);
			gameInstObj.OnAttach();
		}
		return val;
	}

	protected T CreateClass<T>() where T : IGameInstObj, new()
	{
		T val = new T();
		ObjDicts[typeof(T)] = val;
		IGameInstObj gameInstObj = val;
		if (gameInstObj.bTickEnabled)
		{
			TickList.Add(gameInstObj);
			if (val is IGIOForTickDisable)
			{
				TickListForTickDisable.Add(gameInstObj);
			}
		}
		ObjList.Add(gameInstObj);
		ObjNotInited.Add(gameInstObj);
		gameInstObj.OnAttach();
		return val;
	}

	protected T CreateClassCS<T>() where T : class, IGameInstObjCS, new()
	{
		T val = new T();
		ObjDicts[typeof(T)] = val;
		IGameInstObjCS gameInstObjCS = val;
		if (gameInstObjCS.bTickEnabled)
		{
			TickListCS.Add(gameInstObjCS);
			if (val is IGIOForTickDisable)
			{
				TickListCSForTickDisable.Add(gameInstObjCS);
			}
		}
		gameInstObjCS.Owner = this;
		ObjListCS.Add(gameInstObjCS);
		ObjNotInitedCS.Add(gameInstObjCS);
		gameInstObjCS.OnAttach();
		return val;
	}

	protected T CreateUObjCS<T>() where T : UObject, IGameInstObjCS
	{
		T val = UObject.NewObject<T>(this);
		ObjRefs.Add(val);
		ObjDicts[typeof(T)] = val;
		IGameInstObjCS gameInstObjCS = val;
		if (gameInstObjCS != null)
		{
			if (gameInstObjCS.bTickEnabled)
			{
				if (val is IGIOForTickDisable)
				{
					TickListCSForTickDisable.Add(gameInstObjCS);
				}
				TickListCS.Add(gameInstObjCS);
			}
			ObjListCS.Add(gameInstObjCS);
			ObjNotInitedCS.Add(gameInstObjCS);
			gameInstObjCS.Owner = this;
			gameInstObjCS.OnAttach();
		}
		return val;
	}

	public void OnPostLoadMap()
	{
		foreach (KeyValuePair<Type, object> objDict in ObjDicts)
		{
			if (objDict.Value is IGameInstObj gameInstObj)
			{
				gameInstObj.OnPostLoadMap();
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BGWGameInstanceCS:ReceiveShutdown")]
	protected override void ReceiveShutdown_Implementation()
	{
		for (int i = 0; i < ObjList.Count; i++)
		{
			try
			{
				ObjList[i].OnShutdown();
			}
			catch (Exception ex)
			{
				BGW_LogUtil.LogError(ex.ToString());
			}
		}
		for (int j = 0; j < ObjListCS.Count; j++)
		{
			try
			{
				ObjListCS[j].OnShutdown();
			}
			catch (Exception ex2)
			{
				BGW_LogUtil.LogError(ex2.ToString());
			}
		}
		if (SharedRuntimeState.CurrentRuntime == EDotNetRuntime.CoreCLR)
		{
			BGW_ManagedReflectMgr.Get(this).ClearAssemblyContext();
		}
		ObjRefs.Clear();
		ObjDicts.Clear();
		TickList.Clear();
		TickListForTickDisable.Clear();
		ObjNotInited.Clear();
		TickListCS.Clear();
		TickListCSForTickDisable.Clear();
		ObjNotInitedCS.Clear();
		TickList_TickEvenWhenPaused.Clear();
		GSEventCollectionBase.s_weakReferences.Clear();
		BGGGameStateCS.s_weakReferences.Clear();
		StrongPtrLeakDetection.s_weakReferences.Clear();
		PreLoginHandler = null;
		UnrealPostLoginHandler = null;
	}

	private BGW_TickGroupMask CustomTickGroup_To_BGWTickGroupMask(int TickGroup)
	{
		return TickGroup switch
		{
			0 => BGW_TickGroupMask.TG_OnTick, 
			1 => BGW_TickGroupMask.TG_None, 
			2 => BGW_TickGroupMask.TG_AfterAnim, 
			3 => BGW_TickGroupMask.TG_None, 
			141 => BGW_TickGroupMask.TG_BeforePostPhsic, 
			4 => BGW_TickGroupMask.TG_PostPhysics, 
			5 => BGW_TickGroupMask.TG_PostUpdateWork, 
			101 => BGW_TickGroupMask.TG_PreAnim, 
			111 => BGW_TickGroupMask.TG_BeforeStartPhsic, 
			151 => BGW_TickGroupMask.TG_BeforePostUpdateWork, 
			_ => throw new NotImplementedException("CustomTickGroup_To_BGWTickGroupMask : unknown tickgroup"), 
		};
	}

	public bool IsInLoading()
	{
		if (GetCurLoadingScreenState() == EGSLoadingScreenState.MainThreadUpdating)
		{
			return !CanFadeAway();
		}
		return false;
	}

	[USharpPath("/Script/b1-Managed.BGWGameInstanceCS:ReceiveTick")]
	protected override void ReceiveTick_Implementation(float DeltaSeconds, int TickGroup)
	{
		GetWorldForCS();
		int num = (int)CustomTickGroup_To_BGWTickGroupMask(TickGroup);
		if (num == 0 || !InitGameInstObjDone)
		{
			return;
		}
		bool flag = false;
		if (flag)
		{
			SwitchLoadingScreenThread(UseSlateThread: true);
		}
		_ = GSE_ProfileUtil.sOpenProfiler;
		List<IGameInstObj> list = TickList;
		List<IGameInstObjCS> list2 = TickListCS;
		if (!EnableCSharpTick)
		{
			list = TickListForTickDisable;
			list2 = TickListCSForTickDisable;
		}
		for (int i = 0; i < list.Count; i++)
		{
			if ((list[i].GetTickGroupMask() & num) != 0)
			{
				int statId = list[i].StatId;
				if (statId > 0)
				{
					ProfilerFuncLib.BeginSampleWithStatID(list[i].StatId);
				}
				list[i].OnTickWithGroup(DeltaSeconds, num);
				if (statId > 0)
				{
					ProfilerFuncLib.EndSample();
				}
			}
		}
		for (int j = 0; j < list2.Count; j++)
		{
			if ((list2[j].GetTickGroupMask() & num) != 0)
			{
				int statId2 = list2[j].StatId;
				if (statId2 > 0)
				{
					ProfilerFuncLib.BeginSampleWithStatID(list2[j].StatId);
				}
				list2[j].OnTickWithGroup(DeltaSeconds, num);
				if (statId2 > 0)
				{
					ProfilerFuncLib.EndSample();
				}
			}
		}
		if (flag)
		{
			SwitchLoadingScreenThread(UseSlateThread: false);
		}
		USharpExceptionHandler.OnTick();
	}

	[USharpPath("/Script/b1-Managed.BGWGameInstanceCS:ReceiveTickEvenWhenPaused")]
	protected override void ReceiveTickEvenWhenPaused_Implementation(float DeltaSeconds, int TickGroup)
	{
		int num = (int)CustomTickGroup_To_BGWTickGroupMask(TickGroup);
		if (num == 0 || !InitGameInstObjDone)
		{
			return;
		}
		List<IGameInstObj> tickList_TickEvenWhenPaused = TickList_TickEvenWhenPaused;
		if (!EnableCSharpTick)
		{
			return;
		}
		for (int i = 0; i < tickList_TickEvenWhenPaused.Count; i++)
		{
			if ((tickList_TickEvenWhenPaused[i].GetTickGroupMask() & num) != 0)
			{
				int statId = tickList_TickEvenWhenPaused[i].StatId;
				if (statId > 0)
				{
					ProfilerFuncLib.BeginSampleWithStatID(tickList_TickEvenWhenPaused[i].StatId);
				}
				tickList_TickEvenWhenPaused[i].OnTickWithGroup(DeltaSeconds, num);
				if (statId > 0)
				{
					ProfilerFuncLib.EndSample();
				}
			}
		}
	}

	public void AddTickEvenWhenPausedList(IGameInstObj TargetGameInstObj)
	{
		if (TargetGameInstObj != null)
		{
			TickList_TickEvenWhenPaused.Add(TargetGameInstObj);
		}
	}

	public void RemoveTickEvenWhenPausedList(IGameInstObj TargetGameInstObj)
	{
		if (TargetGameInstObj != null)
		{
			TickList_TickEvenWhenPaused.Remove(TargetGameInstObj);
		}
	}

	public static BGWGameInstanceCS Get(UObject WorldContext)
	{
		return s_instance;
	}

	public static BGWGameInstanceCS GetByEntity(Entity Entity)
	{
		return s_instance;
	}

	public static List<BGWGameInstanceCS> GetAllAliveInstance()
	{
		return new List<BGWGameInstanceCS> { s_instance };
	}

	public static BGWGameInstanceCS GetByEntityMgrIdx(int EntityMgrIdx)
	{
		return s_instance;
	}

	public bool IsInServer()
	{
		if (!UGSE_EngineFuncLib.IsListenServer(GetWorldForCS()))
		{
			return UGSE_EngineFuncLib.IsDedicateServer(GetWorldForCS());
		}
		return true;
	}

	static BGWGameInstanceCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWGameInstanceCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWGameInstanceCS));
		EnableCSharpTick = true;
		sTickingGameInstNetModeValid = false;
		sTickingGameInstNetModePrivate = EGameInstNetMode.StandAlone;
		sPlayTime = 0;
		s_instance = null;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWGameInstanceCS:ReceiveTick")]
	private static void ReceiveTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWGameInstanceCS bGWGameInstanceCS = GCHelper.Find<BGWGameInstanceCS>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaSeconds_Offset));
		int tickGroup = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, ReceiveTick_TickGroup_Offset));
		bGWGameInstanceCS.ReceiveTick_Implementation(deltaSeconds, tickGroup);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWGameInstanceCS:ReceiveInit")]
	private static void ReceiveInit__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWGameInstanceCS bGWGameInstanceCS = GCHelper.Find<BGWGameInstanceCS>(obj);
		bGWGameInstanceCS.ReceiveInit_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWGameInstanceCS:ReceiveShutdown")]
	private static void ReceiveShutdown__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWGameInstanceCS bGWGameInstanceCS = GCHelper.Find<BGWGameInstanceCS>(obj);
		bGWGameInstanceCS.ReceiveShutdown_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWGameInstanceCS:OnWorldChangedCS")]
	private static void OnWorldChangedCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWGameInstanceCS bGWGameInstanceCS = GCHelper.Find<BGWGameInstanceCS>(obj);
		UWorld oldWorld = UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(buffer, OnWorldChangedCS_OldWorld_Offset));
		UWorld newWorld = UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(buffer, OnWorldChangedCS_NewWorld_Offset));
		bGWGameInstanceCS.OnWorldChangedCS_Implementation(oldWorld, newWorld);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWGameInstanceCS:OnPostActorTickCS")]
	private static void OnPostActorTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWGameInstanceCS bGWGameInstanceCS = GCHelper.Find<BGWGameInstanceCS>(obj);
		UWorld world = UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(buffer, OnPostActorTickCS_World_Offset));
		bGWGameInstanceCS.OnPostActorTickCS_Implementation(world);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWGameInstanceCS:OnWorldTickStartCS")]
	private static void OnWorldTickStartCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWGameInstanceCS bGWGameInstanceCS = GCHelper.Find<BGWGameInstanceCS>(obj);
		UWorld world = UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(buffer, OnWorldTickStartCS_World_Offset));
		bGWGameInstanceCS.OnWorldTickStartCS_Implementation(world);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWGameInstanceCS:StartGameInstanceForCS")]
	private static void StartGameInstanceForCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWGameInstanceCS bGWGameInstanceCS = GCHelper.Find<BGWGameInstanceCS>(obj);
		EStartGameInstanceTypeForCS startType = EnumMarshaler<EStartGameInstanceTypeForCS>.FromNative(IntPtr.Add(buffer, StartGameInstanceForCS_StartType_Offset), 0, StartGameInstanceForCS_StartType_PropertyAddress.Address);
		bGWGameInstanceCS.StartGameInstanceForCS_Implementation(startType);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWGameInstanceCS:GetOnlineSessionClassCS")]
	private static void GetOnlineSessionClassCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWGameInstanceCS bGWGameInstanceCS = GCHelper.Find<BGWGameInstanceCS>(obj);
		TSubclassOf<UOnlineSession> onlineSessionClassCS_Implementation = bGWGameInstanceCS.GetOnlineSessionClassCS_Implementation();
		TSubclassOfMarshaler<UOnlineSession>.ToNative(IntPtr.Add(buffer, GetOnlineSessionClassCS_ReturnValue_Offset), onlineSessionClassCS_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWGameInstanceCS:ReceiveTickEvenWhenPaused")]
	private static void ReceiveTickEvenWhenPaused__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWGameInstanceCS bGWGameInstanceCS = GCHelper.Find<BGWGameInstanceCS>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTickEvenWhenPaused_DeltaSeconds_Offset));
		int tickGroup = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, ReceiveTickEvenWhenPaused_TickGroup_Offset));
		bGWGameInstanceCS.ReceiveTickEvenWhenPaused_Implementation(deltaSeconds, tickGroup);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWGameInstanceCS:OnGameModeMatchStateSetCS")]
	private static void OnGameModeMatchStateSetCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWGameInstanceCS bGWGameInstanceCS = GCHelper.Find<BGWGameInstanceCS>(obj);
		FName newMatchState = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, OnGameModeMatchStateSetCS_NewMatchState_Offset));
		bGWGameInstanceCS.OnGameModeMatchStateSetCS_Implementation(newMatchState);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGWGameInstanceCS");
		NativeReflection.GetPropertyRef(ref ObjRefs_PropertyAddress, intPtr, "ObjRefs");
		ObjRefs_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObjRefs");
		ObjRefs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObjRefs", Classes.FArrayProperty);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		ReceiveTick_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_TickGroup_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "TickGroup");
		ReceiveTick_TickGroup_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "TickGroup", Classes.FIntProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid && ReceiveTick_TickGroup_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWGameInstanceCS:ReceiveTick", ReceiveTick_IsValid);
		ReceiveInit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveInit");
		ReceiveInit_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveInit_FunctionAddress);
		ReceiveInit_IsValid = ReceiveInit_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWGameInstanceCS:ReceiveInit", ReceiveInit_IsValid);
		ReceiveShutdown_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveShutdown");
		ReceiveShutdown_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveShutdown_FunctionAddress);
		ReceiveShutdown_IsValid = ReceiveShutdown_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWGameInstanceCS:ReceiveShutdown", ReceiveShutdown_IsValid);
		OnWorldChangedCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnWorldChangedCS");
		OnWorldChangedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnWorldChangedCS_FunctionAddress);
		OnWorldChangedCS_OldWorld_Offset = NativeReflection.GetPropertyOffset(OnWorldChangedCS_FunctionAddress, "OldWorld");
		OnWorldChangedCS_OldWorld_IsValid = NativeReflection.ValidatePropertyClass(OnWorldChangedCS_FunctionAddress, "OldWorld", Classes.FObjectProperty);
		OnWorldChangedCS_NewWorld_Offset = NativeReflection.GetPropertyOffset(OnWorldChangedCS_FunctionAddress, "NewWorld");
		OnWorldChangedCS_NewWorld_IsValid = NativeReflection.ValidatePropertyClass(OnWorldChangedCS_FunctionAddress, "NewWorld", Classes.FObjectProperty);
		OnWorldChangedCS_IsValid = OnWorldChangedCS_FunctionAddress != IntPtr.Zero && OnWorldChangedCS_OldWorld_IsValid && OnWorldChangedCS_NewWorld_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWGameInstanceCS:OnWorldChangedCS", OnWorldChangedCS_IsValid);
		OnPostActorTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPostActorTickCS");
		OnPostActorTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPostActorTickCS_FunctionAddress);
		OnPostActorTickCS_World_Offset = NativeReflection.GetPropertyOffset(OnPostActorTickCS_FunctionAddress, "World");
		OnPostActorTickCS_World_IsValid = NativeReflection.ValidatePropertyClass(OnPostActorTickCS_FunctionAddress, "World", Classes.FObjectProperty);
		OnPostActorTickCS_IsValid = OnPostActorTickCS_FunctionAddress != IntPtr.Zero && OnPostActorTickCS_World_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWGameInstanceCS:OnPostActorTickCS", OnPostActorTickCS_IsValid);
		OnWorldTickStartCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnWorldTickStartCS");
		OnWorldTickStartCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnWorldTickStartCS_FunctionAddress);
		OnWorldTickStartCS_World_Offset = NativeReflection.GetPropertyOffset(OnWorldTickStartCS_FunctionAddress, "World");
		OnWorldTickStartCS_World_IsValid = NativeReflection.ValidatePropertyClass(OnWorldTickStartCS_FunctionAddress, "World", Classes.FObjectProperty);
		OnWorldTickStartCS_IsValid = OnWorldTickStartCS_FunctionAddress != IntPtr.Zero && OnWorldTickStartCS_World_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWGameInstanceCS:OnWorldTickStartCS", OnWorldTickStartCS_IsValid);
		StartGameInstanceForCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StartGameInstanceForCS");
		StartGameInstanceForCS_ParamsSize = NativeReflection.GetFunctionParamsSize(StartGameInstanceForCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref StartGameInstanceForCS_StartType_PropertyAddress, StartGameInstanceForCS_FunctionAddress, "StartType");
		StartGameInstanceForCS_StartType_Offset = NativeReflection.GetPropertyOffset(StartGameInstanceForCS_FunctionAddress, "StartType");
		StartGameInstanceForCS_StartType_IsValid = NativeReflection.ValidatePropertyClass(StartGameInstanceForCS_FunctionAddress, "StartType", Classes.FEnumProperty);
		StartGameInstanceForCS_IsValid = StartGameInstanceForCS_FunctionAddress != IntPtr.Zero && StartGameInstanceForCS_StartType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWGameInstanceCS:StartGameInstanceForCS", StartGameInstanceForCS_IsValid);
		GetOnlineSessionClassCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOnlineSessionClassCS");
		GetOnlineSessionClassCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOnlineSessionClassCS_FunctionAddress);
		GetOnlineSessionClassCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetOnlineSessionClassCS_FunctionAddress, "ReturnValue");
		GetOnlineSessionClassCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetOnlineSessionClassCS_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetOnlineSessionClassCS_IsValid = GetOnlineSessionClassCS_FunctionAddress != IntPtr.Zero && GetOnlineSessionClassCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWGameInstanceCS:GetOnlineSessionClassCS", GetOnlineSessionClassCS_IsValid);
		ReceiveTickEvenWhenPaused_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTickEvenWhenPaused");
		ReceiveTickEvenWhenPaused_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTickEvenWhenPaused_FunctionAddress);
		ReceiveTickEvenWhenPaused_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(ReceiveTickEvenWhenPaused_FunctionAddress, "DeltaSeconds");
		ReceiveTickEvenWhenPaused_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTickEvenWhenPaused_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTickEvenWhenPaused_TickGroup_Offset = NativeReflection.GetPropertyOffset(ReceiveTickEvenWhenPaused_FunctionAddress, "TickGroup");
		ReceiveTickEvenWhenPaused_TickGroup_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTickEvenWhenPaused_FunctionAddress, "TickGroup", Classes.FIntProperty);
		ReceiveTickEvenWhenPaused_IsValid = ReceiveTickEvenWhenPaused_FunctionAddress != IntPtr.Zero && ReceiveTickEvenWhenPaused_DeltaSeconds_IsValid && ReceiveTickEvenWhenPaused_TickGroup_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWGameInstanceCS:ReceiveTickEvenWhenPaused", ReceiveTickEvenWhenPaused_IsValid);
		OnGameModeMatchStateSetCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnGameModeMatchStateSetCS");
		OnGameModeMatchStateSetCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGameModeMatchStateSetCS_FunctionAddress);
		OnGameModeMatchStateSetCS_NewMatchState_Offset = NativeReflection.GetPropertyOffset(OnGameModeMatchStateSetCS_FunctionAddress, "NewMatchState");
		OnGameModeMatchStateSetCS_NewMatchState_IsValid = NativeReflection.ValidatePropertyClass(OnGameModeMatchStateSetCS_FunctionAddress, "NewMatchState", Classes.FNameProperty);
		OnGameModeMatchStateSetCS_IsValid = OnGameModeMatchStateSetCS_FunctionAddress != IntPtr.Zero && OnGameModeMatchStateSetCS_NewMatchState_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWGameInstanceCS:OnGameModeMatchStateSetCS", OnGameModeMatchStateSetCS_IsValid);
	}
}
