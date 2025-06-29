using System;
using System.Collections.Concurrent;
using System.Linq;
using b1.BGW;
using b1.ECS;
using b1.Plugins.Calliope;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FTamerRef : IDisposable
{
	public FTransform TamerTransform;

	private ETamerPhase _phase;

	private const int TamerUnloadBuff = 931;

	private const float TamerUnloadBuffTime = 3f;

	private bool bHasAddUnloadBuff;

	private float _delayDestroyTime = -1f;

	private static int _lastAvailableRefID = 0;

	public FVector2D Location2D { get; private set; }

	public float LocationZ { get; private set; }

	public float CapsuleHalfHeight { get; }

	public float CapsuleRadius { get; }

	public string TamerGuid { get; }

	public string TamerGoupGuid { get; }

	public string TamerName { get; }

	public string LevelName { get; }

	public float FallingCheckThreshold { get; }

	public long ClientMonsterNetGuidCache { get; set; }

	public ETamerPhase Phase
	{
		get
		{
			return _phase;
		}
		private set
		{
			if (value != ETamerPhase.None && value != _phase)
			{
				UObject managed = GCHelper.FindRef(FGlobals.GWorld).Managed;
				BGS_GSEventCollection bGS_GSEventCollection = BGS_GSEventCollection.Get(managed);
				if (bGS_GSEventCollection != null)
				{
					bGS_GSEventCollection?.Evt_TamerPhaseChanged.Invoke(this, _phase, value);
					if (value == ETamerPhase.Loaded)
					{
						TamerCharacterNameAllocator orAllocTamerCharacterNameAllocator = BGU_DataUtil.GetOrAllocTamerCharacterNameAllocator(managed, TamerGuid);
						if (orAllocTamerCharacterNameAllocator != null && !orAllocTamerCharacterNameAllocator.NeverSpawned)
						{
							orAllocTamerCharacterNameAllocator.Realloc();
						}
						DestroyMonsterCommon();
						if (InstancePtr.IsValid())
						{
							InstancePtr.Get().SetActorHiddenInGame(bNewHidden: false);
						}
						else
						{
							BGW_LogUtil.LogError($"Tamer back to load phase，but Instance is not valid，check this error, TamerGuid:{TamerGuid}, PrePhase: {_phase}");
						}
					}
					if (value == ETamerPhase.UnLoaded)
					{
						InstancePtr = TWeakObject<BUTamerActor>.Null;
					}
					if (value == ETamerPhase.ClientWaitingChannelAndAuthRoleReady)
					{
						RecoverClientMonsterNetGuid();
					}
				}
			}
			_phase = value;
		}
	}

	public TWeakObject<BUTamerActor> InstancePtr { get; private set; }

	public TWeakObject<BGUCharacterCS> MonsterInstancePtr { get; private set; }

	private IBIC_GlobalActorData GlobalActorData { get; set; }

	private IBIC_TaskData TaskData { get; set; }

	private IBIC_BossRushBattleData BossRushBattleData { get; set; }

	public ETamerType TamerType { get; private set; }

	private bool bGenerateOverlapEventCapsuleCache { get; set; }

	private bool bGenerateOverlapEventMeshCache { get; set; }

	private EBGUResetType ResetType { get; set; }

	public EBGUResetType? OverrideResetType { get; set; }

	public EBGUResetType? GroupOverrideResetType { get; set; }

	public EGsNPCShowState? NPCShowState { get; set; }

	public int ResID { get; private set; }

	public int OverrideID { get; private set; }

	private EUnitPreloadLevel PreloadLevel { get; set; }

	private ETamerPreloadLevel TamerPreloadLevel { get; set; }

	private EUnitTagType UnitTagType { get; set; }

	public bool bPatrolUnit { get; private set; }

	public bool bHasLODConfig { get; set; }

	public int LODMaxDistance { get; set; }

	public bool bShowingLOD { get; set; }

	public FServantInstanceBase ServantInstance { get; set; }

	public FVector2D LastCalcDistance { get; set; }

	public float LastScore { get; set; }

	public int LastVisibility { get; set; }

	public float DelayDestroyTime
	{
		get
		{
			return _delayDestroyTime;
		}
		set
		{
			if (!(Math.Abs(_delayDestroyTime - value) > 0.0001f))
			{
				return;
			}
			_delayDestroyTime = value;
			if (Phase != ETamerPhase.Spawned)
			{
				return;
			}
			if (_delayDestroyTime > 0.0001f)
			{
				if (!(_delayDestroyTime <= 3f) || bHasAddUnloadBuff || !MonsterInstancePtr.IsValid())
				{
					return;
				}
				BGUCharacterCS bGUCharacterCS = MonsterInstancePtr.Get();
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
				if (bUS_GSEventCollection != null)
				{
					bUS_GSEventCollection.Evt_BuffAdd.Invoke(931, bGUCharacterCS, bGUCharacterCS, FMath.Min(3f, _delayDestroyTime) * 1000f);
					IBUC_BuffData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_BuffData, BUC_BuffData>(bGUCharacterCS);
					if (unPersistentReadOnlyData != null)
					{
						bHasAddUnloadBuff = unPersistentReadOnlyData.HasBuff(931);
					}
				}
				return;
			}
			if (MonsterInstancePtr.IsValid())
			{
				BGUCharacterCS actor = MonsterInstancePtr.Get();
				BUS_GSEventCollection bUS_GSEventCollection2 = BUS_EventCollectionCS.Get(actor);
				if (bUS_GSEventCollection2 != null)
				{
					IBUC_BuffData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_BuffData, BUC_BuffData>(actor);
					if (unPersistentReadOnlyData2 != null)
					{
						bHasAddUnloadBuff = unPersistentReadOnlyData2.HasBuff(931);
						if (bHasAddUnloadBuff)
						{
							bUS_GSEventCollection2.Evt_BuffRemoveImmediately.Invoke(931, EBuffEffectTriggerType.Remove);
						}
					}
				}
			}
			bHasAddUnloadBuff = false;
		}
	}

	public ETamerSpawnRule SpawnRuleFlags { get; private set; }

	private BGW_EventCollection BGWEventCollection { get; set; }

	public int RefID { get; private set; }

	private static ConcurrentQueue<int> RecycleRefIDPool { get; } = new ConcurrentQueue<int>();

	private FTamerRef(string InGuid, string InGroupGuid, BUTamerActor InInstance)
	{
		RefID = NewRefID();
		TamerGuid = InGuid;
		TamerGoupGuid = InGroupGuid;
		TamerName = TamerGuid.Split('-').Last();
		InstancePtr.Set(InInstance);
		GlobalActorData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_GlobalActorData, BIC_GlobalActorData>(InInstance);
		TaskData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_TaskData, BIC_TaskData>(InInstance);
		BossRushBattleData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_BossRushBattleData, BIC_BossRushBattleData>(InInstance);
		BGWEventCollection = BGW_EventCollection.Get(InInstance);
		FVector actorLocation = InInstance.GetActorLocation();
		Location2D = new FVector2D(actorLocation);
		LocationZ = actorLocation.Z;
		TamerTransform = InInstance.GetActorTransform();
		CapsuleHalfHeight = InInstance.CapsuleComponent.GetScaledCapsuleHalfHeight();
		CapsuleRadius = InInstance.CapsuleComponent.GetScaledCapsuleRadius();
		FallingCheckThreshold = InInstance.GetFallingCheckThreshold();
		this.ResetType = InInstance.GetOriginResetType();
		ResID = InInstance.ResID;
		OverrideID = InInstance.ConfigInfoComp.UnitCDesc.OverrideID;
		UnitTagType = InInstance.GetTemplateType();
		bPatrolUnit = InInstance.IsPatrolUnit();
		LevelName = InInstance.GetOuter().GetOuter().GetName();
		if (GlobalActorData.GetActorOverrideResetType(InGuid, out var ResetType))
		{
			OverrideResetType = ResetType;
		}
		if (GlobalActorData.GetGroupOverrideResetType(InGroupGuid, out var ResetType2))
		{
			GroupOverrideResetType = ResetType2;
		}
		if (TaskData.TryGetCacheNPCShowState(InGuid, out var CacheNPCShowState))
		{
			NPCShowState = CacheNPCShowState;
		}
		TamerType = InInstance.TamerType;
	}

	protected void CacheMonsterNetGuid()
	{
		if (MonsterInstancePtr.Get() != null)
		{
			ClientMonsterNetGuidCache = UGSE_OnlineFuncLib.GetObjNetGuid(MonsterInstancePtr.Get());
		}
	}

	public void CacheMonsterNetGuid(long NetGuid)
	{
		ClientMonsterNetGuidCache = NetGuid;
	}

	public void RecoverClientMonsterNetGuid()
	{
		if (!BGWGameInstanceCS.TickingGameInstNetModeIsServer(InstancePtr.Get()) && ClientMonsterNetGuidCache > 1 && MonsterInstancePtr.Get() != null)
		{
			UGSE_OnlineFuncLib.RegisterNetGuid(ClientMonsterNetGuidCache, MonsterInstancePtr.Get());
		}
	}

	public static FTamerRef Load(BUTamerActor InInstance)
	{
		if (InInstance == null)
		{
			return null;
		}
		IBGC_TamerData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<BGC_TamerData>(InInstance);
		string finalGuid = InInstance.GetFinalGuid();
		string groupGuid = InInstance.GetGroupGuid();
		if (gameStateReadonlyData != null && gameStateReadonlyData.TryGetTamerEntityRef(finalGuid, out var OutTamerRef))
		{
			OutTamerRef.OnReload(InInstance);
		}
		else
		{
			OutTamerRef = new FTamerRef(finalGuid, groupGuid, InInstance);
			OutTamerRef.OnCreate(InInstance);
		}
		return OutTamerRef;
	}

	public EBGUResetType GetActualResetType()
	{
		if (OverrideResetType.HasValue)
		{
			return OverrideResetType.Value;
		}
		if (GroupOverrideResetType.HasValue)
		{
			return GroupOverrideResetType.Value;
		}
		return ResetType;
	}

	public bool IncrementalSpawnUnit(AActor InOwner)
	{
		bool result = false;
		switch (Phase)
		{
		case ETamerPhase.Loaded:
			if (IncrementalSpawnUnitDeferred(InOwner))
			{
				Phase = ETamerPhase.Visible;
				if (BGWGameInstanceCS.TickingGameInstNetModeIsServer(InOwner))
				{
					BGS_GSEventCollection.Get(InstancePtr.Get()).Evt_BGS_RegisterTamerAuthInfo.Invoke(TamerGuid, UGSE_EngineFuncLib.GetFirstLocalPlayerController(InstancePtr.Get()));
				}
				result = true;
			}
			break;
		case ETamerPhase.Visible:
			if (IncrementalFinishSpawnUnit())
			{
				if (BGWGameInstanceCS.TickingGameInstNetModeIsServer(InOwner))
				{
					Phase = (BGUFunctionLibraryCS.TamerInLocalStratergy(InOwner, this) ? ETamerPhase.PreBegunPlay : ETamerPhase.ServerWaitingAuthorityECSBeginPlay);
				}
				else if (BGWGameInstanceCS.TickingGameInstNetMode(InOwner) == EGameInstNetMode.Client)
				{
					Phase = ETamerPhase.ClientWaitingChannelAndAuthRoleReady;
				}
				else
				{
					Phase = ETamerPhase.PreBegunPlay;
				}
				result = true;
			}
			break;
		case ETamerPhase.PreBegunPlay:
			if (IncrementalBeginPlayUnit())
			{
				Phase = ETamerPhase.Spawned;
				BGS_GSEventCollection.Get(InstancePtr.Get())?.Evt_NotifyTamerSpawnUnit.Invoke(TamerGuid);
				result = true;
			}
			break;
		}
		return result;
	}

	public void TriggerServantDead()
	{
		if (InstancePtr.IsValid() && MonsterInstancePtr.IsValid())
		{
			BGUCharacterCS bGUCharacterCS = MonsterInstancePtr.Get();
			if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS, EBGUSimpleState.InAnimationSyncing) && BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS, EBGUSimpleState.InAnimationSyncing))
			{
				BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_SetPendingDeathInASS.Invoke(null, -1, -1, bIsSummon: true);
			}
			else
			{
				BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_UnitDead.Invoke(null, EDeadReason.SummonDead);
			}
		}
	}

	public bool OnClientChannelAndNetRoleReady()
	{
		if (Phase != ETamerPhase.ClientWaitingChannelAndAuthRoleReady)
		{
			BGW_LogUtil.LogError($"ClientWaitServerSpawnFinish Phase Error Phase:{Phase}");
			return false;
		}
		Phase = ETamerPhase.PreBegunPlay;
		MonsterInstancePtr.Get().GSNetInitFinish = true;
		return true;
	}

	public bool ClientAuthChannelOpenedOnServer()
	{
		if (Phase != ETamerPhase.ServerWaitingAuthorityECSBeginPlay)
		{
			BGW_LogUtil.LogError($"ServerWaitingClientECSBeginPlayFinish Phase Error Phase:{Phase}");
			return false;
		}
		Phase = ETamerPhase.PreBegunPlay;
		return true;
	}

	public void SetPreloadLevel(EUnitPreloadLevel InPreloadLevel)
	{
		if (PreloadLevel != InPreloadLevel)
		{
			PreloadLevel = InPreloadLevel;
			if (InstancePtr.IsValid())
			{
				BUTamerActor bUTamerActor = InstancePtr.Get();
				BGWEventCollection.Evt_BGW_UnitRequestPreload(ResID, OverrideID, bUTamerActor.GetFinalGuid(), PreloadLevel);
			}
		}
	}

	public void SetTamerPreloadLevel(ETamerPreloadLevel InTamerPreloadLevel)
	{
		if (TamerPreloadLevel == InTamerPreloadLevel)
		{
			return;
		}
		TamerPreloadLevel = InTamerPreloadLevel;
		if (!InstancePtr.IsValid())
		{
			return;
		}
		BUTamerActor bUTamerActor = InstancePtr.Get();
		string monsterClassPath = bUTamerActor.MonsterClassPath;
		if (TamerPreloadLevel == ETamerPreloadLevel.LoadMonsterClass)
		{
			if (!string.IsNullOrEmpty(monsterClassPath))
			{
				bUTamerActor.PreloadMgr?.TryGetCachedResourceObj<UClass>(monsterClassPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Medium);
			}
		}
		else if (TamerPreloadLevel == ETamerPreloadLevel.UnLoadMonsterClass)
		{
			bUTamerActor.PreloadMgr?.TryRecyclingCachedResourceObj(monsterClassPath);
			bUTamerActor.ClearMonsterClassObjCached();
		}
	}

	public void SetLODVisible(bool bInVisible)
	{
		if (InstancePtr.IsValid())
		{
			bShowingLOD = bInVisible;
			InstancePtr.Get().SetLODMeshVisible(bInVisible);
		}
	}

	public T RequireWritableData<T>() where T : class, new()
	{
		if (MonsterInstancePtr.IsValid())
		{
			return BGU_DataUtil.GetUnPersistentReadOnlyData<T>(MonsterInstancePtr.Get());
		}
		return null;
	}

	private bool IncrementalSpawnUnitDeferred(AActor InOwner)
	{
		if (InstancePtr.IsValid())
		{
			BUTamerActor bUTamerActor = InstancePtr.Get();
			if (B1Global.GIsBossRushMode)
			{
				if (TamerType == ETamerType.LevelLoaded)
				{
					if (BossRushBattleData.TamerPropertyOverrideList.TryGetValue(TamerGuid, out var value))
					{
						bUTamerActor.ApplyTamerPropertyOverride(value);
					}
				}
				else
				{
					_ = TamerType;
					_ = 3;
				}
			}
			ULevel level = InOwner.GetLevel();
			string currentNameForSpawn = BGU_DataUtil.GetOrAllocTamerCharacterNameAllocator(InOwner, TamerGuid).GetCurrentNameForSpawn();
			BGUCharacterCS bGUCharacterCS = UBGUFunctionLibrary.BGUBeginDeferredActorSpawnFromClassWithName(bUTamerActor.World, bUTamerActor.GetMonsterClass(), TamerTransform, ESpawnActorCollisionHandlingMethod.AlwaysSpawn, bUTamerActor, new FName(currentNameForSpawn), level) as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				bGUCharacterCS.SetOwner(bUTamerActor);
				bGUCharacterCS.SetTamerOwner(bUTamerActor);
				_ = DebugConfig.DebugGSRepRole;
				MonsterInstancePtr = new TWeakObject<BGUCharacterCS>(bGUCharacterCS);
				BGU_UnrealActorUtil.AttachToActorSimple(bUTamerActor, bGUCharacterCS, EAttachmentTransformRules.KeepWorldTransform);
				bGUCharacterCS.TamerType = TamerType;
				bGUCharacterCS.SetActorHiddenInGame(bNewHidden: true);
				bGenerateOverlapEventCapsuleCache = bGUCharacterCS.CapsuleComponent.GetGenerateOverlapEvents();
				bGenerateOverlapEventMeshCache = bGUCharacterCS.Mesh.GetGenerateOverlapEvents();
				bGUCharacterCS.CapsuleComponent.SetGenerateOverlapEvents(bInGenerateOverlapEvents: false);
				bGUCharacterCS.Mesh.SetGenerateOverlapEvents(bInGenerateOverlapEvents: false);
				UBGUFunctionLibrary.BGUActorUpdateAllTFXComp(bGUCharacterCS);
				GSEUtil.Ensure(bGUCharacterCS.GetName() == currentNameForSpawn, "MonsterName Missmatch MonsterName:" + bGUCharacterCS.GetName() + " ExpectedObjName:" + currentNameForSpawn);
				return true;
			}
		}
		return false;
	}

	private bool IncrementalFinishSpawnUnit()
	{
		if (InstancePtr.IsValid() && MonsterInstancePtr.IsValid())
		{
			InstancePtr.Get();
			BGUCharacterCS bGUCharacterCS = MonsterInstancePtr.Get();
			BGU_UnrealActorUtil.BGUFinishSpawningActor(bGUCharacterCS, TamerTransform);
			if (!BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(bGUCharacterCS))
			{
				bGUCharacterCS.CallPostNetInit();
			}
			if (BGW_ECSWorld.Get(bGUCharacterCS).HasECSWorldBeginPlay)
			{
				BGW_ECSWorld.Get(bGUCharacterCS).BeginPlayEntityForTamerFirstStep(ECSExtension.ToEntity(bGUCharacterCS));
			}
			return true;
		}
		return false;
	}

	private bool IncrementalBeginPlayUnit()
	{
		if (InstancePtr.IsValid() && MonsterInstancePtr.IsValid())
		{
			BGUCharacterCS bGUCharacterCS = MonsterInstancePtr.Get();
			bGUCharacterCS.SetActorHiddenInGame(bNewHidden: false);
			InstancePtr.Get().SetActorHiddenInGame(bNewHidden: true);
			BGW_ECSWorld.Get(bGUCharacterCS).BeginPlayEntityForTamerSecondStep(ECSExtension.ToEntity(bGUCharacterCS));
			bGUCharacterCS.CapsuleComponent.SetGenerateOverlapEvents(bGenerateOverlapEventCapsuleCache);
			bGUCharacterCS.Mesh.SetGenerateOverlapEvents(bGenerateOverlapEventMeshCache);
			UGSE_ActorFuncLib.UpdateActorOverlaps(bGUCharacterCS);
			return true;
		}
		return false;
	}

	private void InitialLODSettings(BUTamerActor InInstance)
	{
		bHasLODConfig = TamerType == ETamerType.LevelLoaded && InInstance.EnableShowLODMesh;
		LODMaxDistance = InInstance.LODMaxDistance;
	}

	private void OnCreate(BUTamerActor InInstance)
	{
		if (TamerType == ETamerType.Summoned)
		{
			ServantInstance = FServantInstanceFactory.Create(InInstance.ExtendConfigComp.ServantReq);
			if (ServantInstance != null)
			{
				ServantInstance.ServantTamerRef = this;
				BGS_GSEventCollection.Get(InInstance)?.Evt_RegisterServantSvr.Invoke(ServantInstance);
			}
		}
		BGS_GSEventCollection.Get(InInstance)?.Evt_RegisterTamer.Invoke(this);
		InitialLODSettings(InInstance);
		InstancePtr = new TWeakObject<BUTamerActor>(InInstance);
		if (Phase != ETamerPhase.Dead)
		{
			Phase = ETamerPhase.Loaded;
		}
	}

	private void OnReload(BUTamerActor InInstance)
	{
		if (!InstancePtr.IsValid())
		{
			InitialLODSettings(InInstance);
			InstancePtr = new TWeakObject<BUTamerActor>(InInstance);
			if (TamerType != ETamerType.LevelLoaded)
			{
				BGS_GSEventCollection.Get(InInstance)?.Evt_UnregisterTamer.Invoke(this);
			}
			else if (Phase != ETamerPhase.Dead)
			{
				Phase = ETamerPhase.Loaded;
			}
		}
	}

	private void ResetTamerTransform()
	{
		if (InstancePtr.IsValid())
		{
			InstancePtr.Get().DetachFromActor();
			InstancePtr.Get().SetActorTransform(TamerTransform, bSweep: false, out var _, bTeleport: false);
			ResetLocationCache();
		}
	}

	private void DestroyMonsterWithUnitDead()
	{
		if (MonsterInstancePtr.IsValid())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(MonsterInstancePtr.Get());
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_DestroyAllCtrableBullet.Invoke();
				if (!BGUFunctionLibraryCS.BGUHasUnitState(MonsterInstancePtr.Get(), EBGUUnitState.Dead))
				{
					bUS_GSEventCollection.Evt_UnitDead.Invoke(null, EDeadReason.OnlyDestroyUnit);
				}
			}
			MonsterInstancePtr.Set(null);
		}
		if (TamerType == ETamerType.Summoned)
		{
			Phase = ETamerPhase.Dead;
		}
	}

	public void SyncMonsterDeadState()
	{
		if (Phase == ETamerPhase.Dead || !GlobalActorData.HasActorAliveState(TamerGuid) || GlobalActorData.GetActorAliveState(TamerGuid))
		{
			return;
		}
		if (MonsterInstancePtr.IsValid())
		{
			BGUCharacterCS bGUCharacterCS = MonsterInstancePtr.Get();
			int num = BGUFunctionLibraryCS.BGUGetWeaponNum(bGUCharacterCS);
			for (int i = 0; i < num; i++)
			{
				AActor aActor = BGUFunctionLibraryCS.BGUGetWeaponByIndex(bGUCharacterCS, i);
				if (aActor != null)
				{
					BGU_UnrealWorldUtil.DestroyActor(aActor);
				}
			}
			BGU_UnrealWorldUtil.DestroyActor(bGUCharacterCS);
			MonsterInstancePtr.Reset();
		}
		Phase = ETamerPhase.Dead;
	}

	public void AfterMonsterDead()
	{
		if (Phase == ETamerPhase.Dead)
		{
			return;
		}
		if (GlobalActorData.HasActorAliveState(TamerGuid) && !GlobalActorData.GetActorAliveState(TamerGuid))
		{
			MonsterInstancePtr.Reset();
			Phase = ETamerPhase.Dead;
		}
		if (B1Global.GIsBossRushMode && BossRushBattleData.TamerPropertyOverrideList.TryGetValue(TamerGuid, out var value))
		{
			BUTamerActor bUTamerActor = InstancePtr.Get();
			if (bUTamerActor != null)
			{
				bUTamerActor.RevertTamerPropertyOverride(value);
			}
		}
	}

	public void TurnBack2Loaded()
	{
		if (InstancePtr.Get().IsNullOrDestroyed())
		{
			return;
		}
		if (BGWGameInstanceCS.TickingGameInstNetMode(InstancePtr.Get()) == EGameInstNetMode.Client)
		{
			if (Phase == ETamerPhase.Spawned || Phase == ETamerPhase.PreBegunPlay)
			{
				Phase = ETamerPhase.ClientBackToLoadWaitChannelClose;
			}
			else
			{
				if (MonsterInstancePtr.IsValid())
				{
					BGU_UnrealWorldUtil.DestroyActor(MonsterInstancePtr.Get());
					MonsterInstancePtr.Set(null);
				}
				Phase = ETamerPhase.Loaded;
			}
		}
		else if (BGWGameInstanceCS.TickingGameInstNetModeIsServer(InstancePtr.Get()))
		{
			bool flag = false;
			if (Phase == ETamerPhase.Spawned)
			{
				flag = BGS_GSEventCollection.Get(InstancePtr.Get()).Evt_BGS_UnRegisterTamerAuthInfo.Invoke(TamerGuid, UGSE_EngineFuncLib.GetFirstLocalPlayerController(InstancePtr.Get()));
			}
			if (!flag)
			{
				DestroyMonsterCommon();
				if (Phase != ETamerPhase.Dead)
				{
					Phase = ETamerPhase.Loaded;
				}
			}
			else
			{
				BGS_GSEventCollection.Get(InstancePtr.Get()).Evt_BGS_RegisterTamerAuthInfo.Invoke(TamerGuid, UGSE_EngineFuncLib.GetFirstLocalPlayerController(InstancePtr.Get()));
			}
		}
		else
		{
			DestroyMonsterCommon();
			if (Phase != ETamerPhase.Dead)
			{
				Phase = ETamerPhase.Loaded;
			}
		}
		ResetTamerTransform();
		bHasAddUnloadBuff = false;
		DelayDestroyTime = -1f;
	}

	public void OnClientMonsterPreDestroyFromReplication()
	{
		_ = DebugConfig.DebugGSRepRole;
		if (MonsterInstancePtr.Get() != null)
		{
			CacheMonsterNetGuid();
			UGSE_OnlineFuncLib.ForceRemoveNetGuid(MonsterInstancePtr.Get());
			SyncMonsterDeadState();
			if (Phase != ETamerPhase.Dead)
			{
				Phase = ETamerPhase.Loaded;
			}
			ResetTamerTransform();
			MonsterInstancePtr.Set(null);
		}
		else
		{
			SyncMonsterDeadState();
			Phase = ETamerPhase.Loaded;
			ResetTamerTransform();
		}
	}

	public void OnClientAuthorityMonsterDeadDestroy()
	{
		Phase = ETamerPhase.ClientAuthorityDeadDestroyWaitChannelClose;
	}

	public bool CanTurnBack2Loaded()
	{
		if (MonsterInstancePtr.IsValid())
		{
			BUC_BattleStateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_BattleStateData>(MonsterInstancePtr.Get());
			if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.IsUnitInBattle())
			{
				return false;
			}
			BUC_PatrolData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PatrolData>(MonsterInstancePtr.Get());
			if (unPersistentReadOnlyData2 != null && unPersistentReadOnlyData2.bIsPatroling)
			{
				return false;
			}
			BUC_UnitStateData unPersistentReadOnlyData3 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_UnitStateData>(MonsterInstancePtr.Get());
			if (unPersistentReadOnlyData3 != null && unPersistentReadOnlyData3.HasState(EBGUUnitState.Dead))
			{
				return false;
			}
		}
		return true;
	}

	private void DestroyMonsterCommon()
	{
		switch (Phase)
		{
		case ETamerPhase.Spawned:
			SyncMonsterDeadState();
			if (Phase == ETamerPhase.Dead)
			{
				if (TamerType == ETamerType.Summoned)
				{
					DestroyMonsterWithUnitDead();
				}
			}
			else
			{
				DestroyMonsterWithUnitDead();
			}
			break;
		case ETamerPhase.Visible:
		case ETamerPhase.PreBegunPlay:
			if (MonsterInstancePtr.IsValid())
			{
				BGU_UnrealWorldUtil.DestroyActor(MonsterInstancePtr.Get());
				MonsterInstancePtr.Set(null);
			}
			break;
		case ETamerPhase.None:
		case ETamerPhase.UnLoaded:
		case ETamerPhase.Loaded:
		case ETamerPhase.ServerWaitingAuthorityECSBeginPlay:
		case ETamerPhase.ClientWaitingChannelAndAuthRoleReady:
		case ETamerPhase.Dead:
			break;
		}
	}

	public void OnUnload()
	{
		DestroyMonsterCommon();
		ResetTamerTransform();
		if (Phase != ETamerPhase.Dead)
		{
			Phase = ETamerPhase.UnLoaded;
		}
	}

	public void DestroyTamer()
	{
		if (InstancePtr.IsValid())
		{
			BGU_UnrealWorldUtil.DestroyActor(InstancePtr.Get());
		}
	}

	public bool IsMonsterValid()
	{
		return MonsterInstancePtr.IsValid();
	}

	public bool IsMonsterDestroyed()
	{
		Entity Entity;
		return !GlobalActorData.GetActorEntity(TamerGuid, out Entity);
	}

	public void DrawDebugString(string DebugString, float Duration, FLinearColor Color)
	{
		if (GSGameplayCVar.CVar_TamerShowDebugInfo.GetValueInGameThread() != 0 && InstancePtr.IsValid())
		{
			BUTamerActor bUTamerActor = InstancePtr.Get();
			UBGUFunctionLibrary.DrawDebugString(bUTamerActor, FVector.UpVector * 100.0, DebugString, bUTamerActor, Color, Duration);
		}
	}

	public void RequestUpdateLocation()
	{
		if (MonsterInstancePtr.IsValid() && Phase == ETamerPhase.Spawned)
		{
			FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(MonsterInstancePtr.Get());
			IBUC_PatrolData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PatrolData, BUC_PatrolData>(MonsterInstancePtr.Get());
			if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.bIsPatroling)
			{
				Location2D = new FVector2D(v);
				LocationZ = v.Z;
			}
		}
	}

	public void ResetLocationCache()
	{
		FVector location = TamerTransform.GetLocation();
		Location2D = new FVector2D(location);
		LocationZ = location.Z;
	}

	public ETamerSpawnRule AddSpawnRuleFlag(ETamerSpawnRule InSpawnRule)
	{
		SpawnRuleFlags |= InSpawnRule;
		return SpawnRuleFlags;
	}

	public ETamerSpawnRule RemoveSpawnRuleFlag(ETamerSpawnRule InSpawnRule)
	{
		SpawnRuleFlags &= ~InSpawnRule;
		return SpawnRuleFlags;
	}

	public bool HasSpawnRuleFlag(ETamerSpawnRule InSpawnRule)
	{
		return (SpawnRuleFlags & InSpawnRule) == InSpawnRule;
	}

	public void OnReset(EResetActorReason ResetReason)
	{
		SyncMonsterDeadState();
		EBGUResetType eBGUResetType = GetActualResetType();
		if (Phase == ETamerPhase.Dead && eBGUResetType != EBGUResetType.Spawn)
		{
			return;
		}
		switch (ResetReason)
		{
		case EResetActorReason.NewSpawn:
		case EResetActorReason.LevelStreaming:
			return;
		case EResetActorReason.Rebirth:
		case EResetActorReason.InteractRebirthPoint:
		case EResetActorReason.GameLevelPass:
			switch (eBGUResetType)
			{
			case EBGUResetType.Destroy:
				BGWEventCollection.Evt_SetActorAliveState(TamerGuid, P2: false);
				break;
			case EBGUResetType.Spawn:
				BGWEventCollection.Evt_SetActorAliveState(TamerGuid, P2: true);
				break;
			}
			break;
		}
		if (!MonsterInstancePtr.IsValid())
		{
			BGWEventCollection.Evt_SetStateMachineNeedReset(TamerGuid, P2: true);
		}
		if (eBGUResetType != EBGUResetType.Destroy && ResetReason == EResetActorReason.ReturnHome)
		{
			eBGUResetType = (OverrideResetType.HasValue ? OverrideResetType.Value : ((!GroupOverrideResetType.HasValue) ? EBGUResetType.Status : GroupOverrideResetType.Value));
		}
		switch (eBGUResetType)
		{
		case EBGUResetType.Destroy:
			ResetTamerDestroy();
			break;
		case EBGUResetType.Status:
		case EBGUResetType.StatusWithoutHp:
			ResetTamerStatus(ResetReason);
			break;
		case EBGUResetType.Spawn:
			BGWEventCollection.Evt_SetActorAliveState(TamerGuid, P2: true);
			ResetTamerSpawn(ResetReason);
			break;
		case EBGUResetType.No:
		case EBGUResetType.None:
			break;
		}
	}

	private void ResetTamerDestroy()
	{
		DestroyMonsterWithUnitDead();
		SyncMonsterDeadState();
		BGS_EventCollectionCS.Get(InstancePtr.Get())?.Evt_BGS_ResetActorDestroy.Invoke(TamerGuid);
	}

	private void ResetTamerSpawn(EResetActorReason InResetReason)
	{
		if (Phase == ETamerPhase.Dead)
		{
			Phase = ETamerPhase.Loaded;
		}
		else if (Phase == ETamerPhase.Spawned)
		{
			ResetMonster(InResetReason);
		}
	}

	private void ResetTamerStatus(EResetActorReason InResetReason)
	{
		if (Phase != ETamerPhase.Dead && Phase == ETamerPhase.Spawned)
		{
			ResetMonster(InResetReason);
		}
	}

	private void ResetMonster(EResetActorReason InResetReason)
	{
		if (!MonsterInstancePtr.IsValid())
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = MonsterInstancePtr.Get();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_ClearActorTransformCache.Invoke();
			UBGUFunctionLibraryForCS.BGUTeleportTo(bGUCharacterCS, TamerTransform.GetLocation(), TamerTransform.GetRotation().Rotator(), bIsATest: false, bNoCheck: true);
			BGUFuncLibActorTransformCS.BGUSetActorTransform(bGUCharacterCS, TamerTransform, bSweep: false, bTeleport: false);
			AController controller = bGUCharacterCS.GetController();
			if (controller != null)
			{
				controller.SetControlRotation(TamerTransform.GetRotation().Quat_Rotator());
			}
			bUS_GSEventCollection.Evt_ResetActorStatusPre.Invoke(InResetReason);
			bUS_GSEventCollection.Evt_ResetActorStatus.Invoke(InResetReason);
			bUS_GSEventCollection.Evt_SceneObjTransitByEvent.Invoke(BGW_FlowUtils.SceneObjCommonEventTag.Reset);
			bUS_GSEventCollection.Evt_ResetActorStatusAfterAll.Invoke(InResetReason);
		}
	}

	private int NewRefID()
	{
		if (RecycleRefIDPool.TryDequeue(out var result))
		{
			return result;
		}
		return _lastAvailableRefID++;
	}

	private void ReturnRefID()
	{
		RecycleRefIDPool.Enqueue(RefID);
		RefID = -1;
	}

	public void Dispose()
	{
		ReturnRefID();
	}
}
