using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_SaveInitDataCompImpl : UActorCompBaseCS
{
	private BUC_GuidData GuidData;

	private BUC_AiConversationData AiConversationData;

	private BUC_WakeUpData WakeUpData;

	private BUC_ConfigInfoData ConfigInfoData;

	private EBGUResetType FinalResetType;

	private BUC_ActorInitData ActorInitData { get; set; }

	private IBIC_GlobalActorData GlobalActorData { get; set; }

	public override void OnAttach()
	{
		ActorInitData = RequireWritableData<BUC_ActorInitData>();
		GuidData = RequireWritableData<BUC_GuidData>();
		AiConversationData = RequireWritableData<BUC_AiConversationData>();
		WakeUpData = RequireWritableData<BUC_WakeUpData>();
		GlobalActorData = RequireReadonlyGameInstanceData<IBIC_GlobalActorData, BIC_GlobalActorData>();
		ConfigInfoData = RequireWritableData<BUC_ConfigInfoData>();
	}

	public override void PreBeginPlay()
	{
		InitDataMap();
		InitFinalResetType();
		ActorInitData.PersistentDataDontResetOnNewGamePlus = ActorInitData.PersistentDataDontResetOnNewGamePlusFromConfig;
		if (ActorInitData.bSaveInitData && !UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(Owner))
		{
			SaveInitData();
			if (ActorInitData.HasInitialized)
			{
				SendInitData();
			}
		}
	}

	private void TriggerReset()
	{
		bool flag = false;
		if (Owner is BGUCharacterCS bGUCharacterCS)
		{
			flag = bGUCharacterCS.BeginPlayFromLevelStreaming;
		}
		else if (Owner is BGUActorBaseCS bGUActorBaseCS)
		{
			flag = bGUActorBaseCS.BeginPlayFromLevelStreaming;
		}
		string actorGuid = BGU_DataUtil.GetActorGuid(Owner);
		base.BGWEventCollection.Evt_TriggerResetOneActor(actorGuid, flag ? EResetActorReason.LevelStreaming : EResetActorReason.NewSpawn);
	}

	private void InitFinalResetType()
	{
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(BGU_DataUtil.GetActorResID(GetOwner()));
		FinalResetType = ActorInitData.ActorResetType;
		if (FinalResetType == EBGUResetType.None)
		{
			FinalResetType = unitCommDesc?.ResetType ?? ActorInitData.ActorResetType;
		}
	}

	private void InitDataMap()
	{
		if (ActorInitData.bSaveInitData && ActorInitData.InitData.Count <= 0)
		{
			AddResetModuleToInitData<b1.GSDynamicInitDataModule>();
			AddResetModuleToInitData<b1.GSBasicInitDataModule>();
			AddResetModuleToInitData<b1.GSMovementInitDataModule>();
			AddResetModuleToInitData<b1.GSGuidInitDataModule>();
			AddResetModuleToInitData<b1.GSPatrolInitDataModule>();
			AddResetModuleToInitData<b1.GSAiConversationInitDataModule>();
			AddResetModuleToInitData<b1.GSWakeUpInitDataModule>();
			AddResetModuleToInitData<b1.GSConfigInfoInitDataModule>();
		}
	}

	private void AddResetModuleToInitData<ResetModule>() where ResetModule : GSInitDataModuleBase, new()
	{
		ResetModule val = new ResetModule();
		val.Init();
		ActorInitData.InitData.Add(val.ModuleType, val);
	}

	private void SaveInitData()
	{
		string finalGuid = GuidData.GetFinalGuid();
		ActorInitData.HasInitialized = GlobalActorData.IsActorInitDataInitialized(finalGuid);
		AActor owner = GetOwner();
		(ActorInitData.GetInitDataModule(EInitDataModuleType.Dynamic) as b1.GSDynamicInitDataModule).HasInited = true;
		if (ActorInitData.HasInitialized)
		{
			return;
		}
		b1.GSBasicInitDataModule obj = ActorInitData.GetInitDataModule(EInitDataModuleType.Basic) as b1.GSBasicInitDataModule;
		obj.ResID = BGU_DataUtil.GetActorResID(owner);
		obj.ActorClsPath = default(FSoftObjectPath);
		obj.ActorClsPath.SetPath(owner.GetClass().GetPathName());
		obj.ActorTrans = owner.GetActorTransform();
		obj.WorldPackageName = BGU_UnrealWorldUtil.GetActorWorldPackageName(owner);
		obj.HasInited = true;
		if (owner is ACharacter aCharacter)
		{
			b1.GSMovementInitDataModule gSMovementInitDataModule = ActorInitData.GetInitDataModule(EInitDataModuleType.Movement) as b1.GSMovementInitDataModule;
			UBGUCharacterMovementComponent uBGUCharacterMovementComponent = aCharacter.CharacterMovement as UBGUCharacterMovementComponent;
			if (uBGUCharacterMovementComponent != null)
			{
				gSMovementInitDataModule.OptimizeDistanceLevel1 = uBGUCharacterMovementComponent.OptimizeDistanceLevel1;
				gSMovementInitDataModule.OptimizeDistanceLevel2 = uBGUCharacterMovementComponent.OptimizeDistanceLevel2;
			}
			gSMovementInitDataModule.HasInited = true;
		}
		if (GuidData != null)
		{
			b1.GSGuidInitDataModule obj2 = ActorInitData.GetInitDataModule(EInitDataModuleType.Guid) as b1.GSGuidInitDataModule;
			obj2.GuidData = obj2.DuplicateData(GuidData);
			obj2.HasInited = true;
		}
		_ = AiConversationData;
		if (WakeUpData != null)
		{
			b1.GSWakeUpInitDataModule obj3 = ActorInitData.GetInitDataModule(EInitDataModuleType.WakeUp) as b1.GSWakeUpInitDataModule;
			obj3.WakeUpData = obj3.DuplicateData(WakeUpData);
			obj3.HasInited = true;
		}
		if (ConfigInfoData != null)
		{
			b1.GSConfigInfoInitDataModule obj4 = ActorInitData.GetInitDataModule(EInitDataModuleType.ConfigInfo) as b1.GSConfigInfoInitDataModule;
			obj4.UnitAIDesc = new FUnitAIDesc
			{
				bOverrideEnableLoSVisualizationInTable = ConfigInfoData.bOverrideEnableLoSVisualizationInTable,
				bEnableLoSVisualization = ConfigInfoData.bEnableLoSVisualization,
				SightRange = ConfigInfoData.SightRange,
				VisionAngleDegrees = ConfigInfoData.VisionAngleDegrees,
				HearRange = ConfigInfoData.HearRange,
				PursuitRange = ConfigInfoData.PursuitRange,
				AIWatchTimeMin = ConfigInfoData.AIWatchTimeMin,
				AIWatchTimeMax = ConfigInfoData.AIWatchTimeMax,
				bOverrideUnitAIAttackType = ConfigInfoData.bOverrideUnitAIAttackType,
				UnitAIAttackType = ConfigInfoData.UnitAIAttackType,
				StalemateInfoMap = ConfigInfoData.StalemateInfoMap
			};
			obj4.HasInited = true;
		}
		ActorInitData.HasInitialized = true;
	}

	private void SendInitData()
	{
		string finalGuid = GuidData.GetFinalGuid();
		base.BGWEventCollection.Evt_SaveActorInitData(finalGuid, ActorInitData, FinalResetType);
	}
}
