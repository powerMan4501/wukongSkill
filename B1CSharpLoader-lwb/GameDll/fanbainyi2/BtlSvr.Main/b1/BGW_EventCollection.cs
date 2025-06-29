using System;
using System.Collections.Generic;
using ArchiveB1;
using b1.BGW;
using b1.ECS;
using b1.EventDelDefine;
using b1.Plugins.Calliope;
using BtlB1;
using BtlShare;
using CommB1;
using GurGsPersistent;
using ResB1;
using UnrealEngine;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_EventCollection")]
public class BGW_EventCollection : GameInstanceSystemBaseUObj
{
	public delegate void Del_BGW_OnObserveConditionSatisfying(Guid NodeGuid);

	public delegate void Del_OnFlowObserveRequest(FlowObserveCondition ObserveCondition);

	public delegate void Del_Void_Float2(float P1, float P2);

	public delegate void Del_Void_Float2Bool(float P1, float P2, bool P3);

	public delegate void Del_BGW_Int(int P1);

	public delegate void Del_BGW_Bool(bool P1);

	public delegate void Del_BGW_BoolInt(bool P1, int P2);

	public delegate void Del_BGW_ActorActor(AActor P1, AActor P2);

	public delegate void Del_BGW_PlayerActorDead(FLoadingTipsPlayerDeadInfo PlayerDeadInfo);

	public delegate void Del_BGW_PreFecthLoadingTips(FLoadingTipsInfo LoadingTipsInfo);

	public delegate void Del_BGW_PostPSOStageChanged(EFullCompilationState OldState, EFullCompilationState NewState);

	public delegate void Del_BGW_Void();

	public delegate void Del_BGW_Void_String(string Str);

	public delegate void Del_BGW_UnitRequestPreload(int ResID, int OverrideID, string FinalGUID, EUnitPreloadLevel PreloadLevel);

	public delegate void Del_BGW_UnitRequestUnLoad(int ResID, int OverrideID, string FinalGUID);

	public delegate void Del_BGW_PlayerRequestPreload(Entity PlayerEntity, bool IsOriginPlayer);

	public delegate void Del_BGW_PlayerAbilityChangeRequestPreload(Entity PlayerEntity, EPreloadPlayerAbilityType AbilityType);

	public delegate void Del_BGW_InteractRequestPreload(int InteractID);

	public delegate void Del_Void_TeleportWithRebirthPoint(int RebirthPointConfigID, ETeleportReason Reason);

	public delegate void Del_PlayerState(APlayerState State);

	public delegate void Del_PlayerController(APlayerController PlayerController);

	public delegate void Del_BGW_Void_ArchiveData(FUStBEDArchivesData ArchivesData);

	public delegate void Del_BGW_Void_IntLevelArchiveData(int MapId, LevelArchiveData InLevelArchiveData);

	public delegate void Del_BGW_Void_TaskArchiveData(WorldTaskArchiveData InWorldTaskArchiveData);

	public delegate void Del_BGW_Void_PushTaskStageStateSuccess(int TaskStageID, QuestStage StageState);

	public delegate void Del_BGW_Void_TaskGraphNotifyGraph(string P1, FGameplayTag P2);

	public delegate void Del_BGW_Void_TaskGraphNotifyGraph_ItemChange(int ItemID, int OldNum, int NewNum);

	public delegate void Del_BGW_Void_TaskGraphNotifyGraph_TaskStage(int TaskStageID, QuestStage StageState);

	public delegate void Del_BGW_Void_TaskGraphNotifyGraph_InteractionEnd(int GroupID, int InteractStep);

	public delegate void Del_BGW_Void_TaskGraphIObserveNodeInstanceString(IObserveNodeInstance P1, string P2);

	public delegate void Del_BGW_Void_TaskGraphIObserveNodeInstance(IObserveNodeInstance P1);

	public delegate void Del_BGW_Void_TaskGraphIObserveNodeForTaskInstance(IObserveNodeInstanceForTask P1);

	public delegate void Del_BGW_SaveActorInitData(string UnitGuid, BUC_ActorInitData ActorInitData, EBGUResetType ResetType);

	public delegate void Del_BGW_ResetGameInstanceData(EGameInstanceResetType ResetType);

	public delegate void Del_BGW_UnitCastSkillSuccess(AActor Actor, int SkillID);

	public delegate void Del_BGW_SetActorGuid2Entity(string Guid, Entity Entity);

	public delegate void Del_BGW_GameInstanceStart(EStartGameInstanceTypeForCS StartType);

	public delegate void Del_BGW_TriggerGlobalFSMEvent(EGI_Global Evnet, object InputParams = null);

	public delegate void Del_BGW_AbortFSMInstance(FSMRuntimeInstanceBase InstanceToAbort);

	public delegate void Del_Void_StateMachineArchiveData(StateMachineArchiveData ArchiveData);

	public delegate void Del_Void_SceneObjArchiveData(LevelArchiveSceneObjData SceneObjData);

	public delegate void Del_BGW_OnWorldChanged(UWorld OldWorld, UWorld NewWorld);

	public delegate void Del_BGW_CacheNPCInfo(string UnitGuid, int TeamID, int IdleAMIdx, int LeisureAnimIndex, int InteractGroupID, EGsNPCShowState NPCShowState, List<NPCBuffInfo> NPCBuffInfoList);

	public delegate void Del_BGW_BlockingSpawnAssociationUnit(int ConfigID, EAssociationUnitSpawnType SpawnType);

	public delegate void Del_BGW_SpawnAssociationUnit(int ConfigID, int DelayTime, EAssociationUnitSpawnType SpawnType, EAssociationUnitActiveType ActiveType, string TargetGUID, int OnFightSkillID);

	public delegate void Del_BGW_ActiveAssociationUnit(int ConfigID, string TargetGUID, int OnFightSkillID);

	public delegate void Del_BGW_KillAssociationUnit(int ConfigID);

	public delegate void Del_BGW_GroupUnitDead(string GroupGuidStr);

	public delegate FChoosePlayerStartInfo Del_ChoosePlayerStart();

	public delegate void Del_ReplaceKey(FName ActionMapping, FKey Key, bool IsAxis, int Scale = 0);

	public delegate void Del_ReplacePrefab(int ActionId, int Idx);

	public delegate FSMRuntimeInstanceBase Del_BGW_CFSMGStart(string ResPath, FSMContextBase Context, UObject OwnerUObj, FSMRuntimeInstanceBase ParentRuntimeInstance = null, Action OnGraphFinish = null, Action<FSMException> OnGraphException = null, object InputParams = null, bool IsStart = true);

	public delegate void Del_DisableSetBT(bool bIsDisable);

	public delegate void Del_TriggerResetAllActors(EResetActorReason ResetReason);

	public delegate void Del_PlayerTeleportToTriggered(ETeleportTypeV2 TeleportType);

	public delegate void Del_PlayerTeleportToFinished();

	public delegate void Del_TriggerResetOneActor(string UnitGuid, EResetActorReason ResetReason);

	public delegate void Del_Void_CalliopeAsset(UCalliopeAsset InAsset);

	public delegate void Del_Void_CalliopeAssetRequest(FCalliopeAssetRequest InRequest);

	public delegate void Del_Void_CalliopeAssetInfo(ECalliopeAssetType InAssetType, Guid InInstanceID, string InAssetPath, string InstancePrefixName);

	public delegate void Del_ResetOneActorWithType(string UnitGuid, EBGUResetType ResetType);

	public delegate void Del_ReportSkillDamageInfo(AActor Attacker, AActor Victim, int SkillID, int BuffID, int EffectID, float SkillDamageValue);

	public delegate void Del_Void_Exception(Exception Ex);

	public delegate void Del_InteractOpenUI(AActor InteractiveActor, string UIName, int Param);

	public delegate void Del_TriggerSyncEquip(ESeqHiddenHeadType SeqHiddenHeadType);

	public delegate void Del_StorePlayerPerformerEquipConfig(FEquipMeshConfig MeshConfig, FEquipAbpConfig AbpConfig);

	public delegate void Del_RegisterIdleProcessAction(List<CalliopeCustom_IdleProcessAction> InIdleProcessActions, PsmNodeInstance InNodeInstance);

	public delegate void Del_Void_PsmNodeInstance(PsmNodeInstance InNodeInstance);

	public delegate void Del_PostInputMappingContextRegister(EInputMappingContextTagV2 Tag, UInputMappingContext InputMappingContext, List<string> RelatedActions, bool IsRegister);

	public delegate void Del_TriggerPlayerTeleport(APlayerController PlayerController, ETeleportTypeV2 TeleportType, ValueType UserData, EPlayerTeleportReason Reason);

	public delegate void Del_BlockInput(EBlockType BlockType, bool IsBlock);

	public delegate void Del_UpdateBossRushConfig(BossRushCustom_InitialV2 InCustomData);

	public Del_BGW_OnObserveConditionSatisfying Evt_BGW_OnObserveConditionSatisfying = delegate
	{
	};

	public Del_OnFlowObserveRequest Evt_OnRegisterFlowObserve = delegate
	{
	};

	public Del_OnFlowObserveRequest Evt_OnUnregisterFlowObserve = delegate
	{
	};

	public Del_Void Evt_PostPrologueCompleted = delegate
	{
	};

	public Del_Void_Int Evt_NotifyMovieInstanceStarted = delegate
	{
	};

	public Del_Void_Int Evt_NotifyMovieInstanceFinished = delegate
	{
	};

	public Del_Void_Int Evt_MarkMoviePlayed = delegate
	{
	};

	public Del_TriggerSyncEquip Evt_TriggerSyncEquip = delegate
	{
	};

	public Del_BGW_Bool Evt_ActiveSkipMovieUI = delegate
	{
	};

	public Del_BGW_Bool Evt_ActiveSkipInteractUI = delegate
	{
	};

	public Del_BGW_BoolInt Evt_ActiveQTEInteractUI = delegate
	{
	};

	public Del_InteractOpenUI Evt_InteractOpenUI = delegate
	{
	};

	public Del_Void_Int Evt_UICommTips = delegate
	{
	};

	public Del_BGW_UnitRequestPreload Evt_BGW_UnitRequestPreload = delegate
	{
	};

	public Del_BGW_UnitRequestUnLoad Evt_BGW_UnitRequestUnLoad = delegate
	{
	};

	public Del_BGW_PlayerRequestPreload Evt_BGW_PlayerRequestPreload = delegate
	{
	};

	public Del_Void_Entity Evt_BGW_PlayerRequestAllDescByAbilityPreload = delegate
	{
	};

	public Del_BGW_PlayerAbilityChangeRequestPreload Evt_BGW_PlayerAbilityChangeRequestPreload = delegate
	{
	};

	public Del_BGW_InteractRequestPreload Evt_BGW_InteractRequestPreload = delegate
	{
	};

	public Del_Void Evt_BGW_SetIgnorePreload = delegate
	{
	};

	public Del_Void_Int Evt_BGW_DynamicObstaclePreload = delegate
	{
	};

	public Del_Void_TeleportInfoBool Evt_RegisterTeleport = delegate
	{
	};

	public Del_Void_FName Evt_UnregisterTeleport = delegate
	{
	};

	public Del_Void Evt_OnTeleportFinished = delegate
	{
	};

	public Del_Void_DreamTeleport Evt_RequestDreamTeleport = delegate
	{
	};

	public Del_Void Evt_DreamTeleportFinished = delegate
	{
	};

	public Del_BGW_Void_ArchiveData Evt_RecoverArchiveData = delegate
	{
	};

	public Del_Void Evt_RequestUpdateLevelArchiveData = delegate
	{
	};

	public Del_BGW_Void_IntLevelArchiveData Evt_RecoverLevelArchiveData = delegate
	{
	};

	public Del_Void Evt_OpenLevelFinished = delegate
	{
	};

	public Del_Void Evt_PlayerDelayBeginPlayFinished = delegate
	{
	};

	public Del_Void Evt_CreatePsmInstanceAndStart = delegate
	{
	};

	public Del_Void Evt_LoadingBeginFadeAway = delegate
	{
	};

	public Del_Void_Int Evt_OnCurrentLevelChanged = delegate
	{
	};

	public Del_Void Evt_RequestUpdateTaskArchiveData = delegate
	{
	};

	public Del_BGW_Void_TaskArchiveData Evt_RecoverTaskArchiveData = delegate
	{
	};

	public Del_BGW_Void_PushTaskStageStateSuccess Evt_PushTaskStageStateSuccess = delegate
	{
	};

	public Del_Void_IntList Evt_RecoverMovieArchiveData = delegate
	{
	};

	public Del_BGW_Void_TaskGraphNotifyGraph Evt_TaskGraphNotifyGraph = delegate
	{
	};

	public Del_BGW_Void_TaskGraphIObserveNodeInstanceString Evt_TaskGraphStartObserve = delegate
	{
	};

	public Del_BGW_Void_TaskGraphIObserveNodeInstance Evt_TaskGraphStopObserve = delegate
	{
	};

	public Del_BGW_Void_TaskGraphNotifyGraph_ItemChange Evt_TaskGraphNotifyGraph_ItemChange = delegate
	{
	};

	public Del_BGW_Void_TaskGraphNotifyGraph_TaskStage Evt_TaskGraphNotifyGraph_TaskStage = delegate
	{
	};

	public Del_BGW_Void_TaskGraphNotifyGraph_InteractionEnd Evt_TaskGraphNotifyGraph_InteractionEnd = delegate
	{
	};

	public Del_Void Evt_TaskGraphNotifyGraph_MonsterCollectionFull = delegate
	{
	};

	public Del_BGW_Void_TaskGraphIObserveNodeForTaskInstance Evt_TaskGraphStartObserveForTask = delegate
	{
	};

	public Del_BGW_Void_TaskGraphIObserveNodeForTaskInstance Evt_TaskGraphStopObserveForTask = delegate
	{
	};

	public Del_Void_String Evt_BGS_PlayerEnterOverlap = delegate
	{
	};

	public Del_Void_String Evt_BGS_PlayerLeaveOverlap = delegate
	{
	};

	public Del_BGW_CacheNPCInfo Evt_BGW_CacheNPCInfo = delegate
	{
	};

	public Del_BGW_BlockingSpawnAssociationUnit Evt_BGW_BlockingSpawnAssociationUnit = delegate
	{
	};

	public Del_BGW_SpawnAssociationUnit Evt_BGW_SpawnAssociationUnit = delegate
	{
	};

	public Del_BGW_ActiveAssociationUnit Evt_BGW_ActiveAssociationUnit = delegate
	{
	};

	public Del_BGW_KillAssociationUnit Evt_BGW_KillAssociationUnit = delegate
	{
	};

	public Del_BGW_GroupUnitDead Evt_BGW_GroupUnitDead = delegate
	{
	};

	public Del_BGW_Int Evt_BGW_NotifyMarkAssociationUnitActive = delegate
	{
	};

	public Del_BGW_Void Evt_BGW_PrintCurrentAssociationUnitInfo = delegate
	{
	};

	public Del_BGW_Void Evt_BGW_PrintCurrentFollowPartnerInfo = delegate
	{
	};

	public Del_BGW_Void Evt_BGW_PrintCurrentWeakAiInteractInfo = delegate
	{
	};

	public Del_PlayerController Evt_OnPlayerStateEndPlay = delegate
	{
	};

	public Del_Void_LevelArchiveDetailDataMap Evt_CacheArchiveData = delegate
	{
	};

	public Del_Void_LevelArchiveBaseDataMap Evt_InitArchiveBaseData = delegate
	{
	};

	public Del_Void Evt_KillAllPlayer = delegate
	{
	};

	public Action<GISCvar> Evt_RegisterAutoResetGISCVar = delegate
	{
	};

	public Action Evt_UpdateCharacterViewEyeAdaptationEnter = delegate
	{
	};

	public Del_Void Evt_PostLoadMapWithWorld = delegate
	{
	};

	public Del_Void_String Evt_PreLoadMap = delegate
	{
	};

	public Del_BGW_Void_String Evt_OnSeamlessTravelStart = delegate
	{
	};

	public Del_BGW_Void Evt_OnSeamlessTravelTransition = delegate
	{
	};

	public Del_BGW_Void Evt_PostSeamlessTravel = delegate
	{
	};

	public Del_BGW_Void_String Evt_ReceiveCloseReason = delegate
	{
	};

	public Del_Void_Int Evt_ReStartByArchiveId = delegate
	{
	};

	public Del_BGW_ResetGameInstanceData Evt_ResetGameInstanceData = delegate
	{
	};

	public Del_Void Evt_ClearAllGameData = delegate
	{
	};

	public Del_Void Evt_PauseAllMovie = delegate
	{
	};

	public Del_Void Evt_ResumeAllMovie = delegate
	{
	};

	public Del_PlayMovieRequest Evt_RequestPlayMovie = delegate
	{
	};

	public Del_StartBossRushChallenge Evt_StartBossRushChallenge = delegate
	{
	};

	public Del_Void Evt_QuitBossRushChallenge = delegate
	{
	};

	public Del_Void Evt_InitBossRushList = delegate
	{
	};

	public Del_Void Evt_BossRushIterationsNext = delegate
	{
	};

	public Del_Void_Int Evt_OnMonsterCollectionAdd = delegate
	{
	};

	public Del_Void_Int Evt_GMSetBossrushIndex = delegate
	{
	};

	public Del_Void_BoolBool Evt_ShowBossRushBattleFinishUI = delegate
	{
	};

	public Del_ReBattleWithCurConfig Evt_ReBattleWithCurConfig = delegate
	{
	};

	public Del_Void Evt_ManualQuitBossRush = delegate
	{
	};

	public Del_Void_Float Evt_ShowBossRushTimeTipsUI = delegate
	{
	};

	public Del_BossRushSetPauseTimeTick Evt_BossRushSetPauseTimeTick = delegate
	{
	};

	public Del_Void Evt_BossRushStopDeadAKEvent = delegate
	{
	};

	public Del_Void Evt_BossRushPreEndBattle = delegate
	{
	};

	public Del_BossRushRecordItemUse Evt_BossRushRecordItemUse = delegate
	{
	};

	public Del_Void_Int Evt_BBC_OnUseSkillByTypeSuccess = delegate
	{
	};

	public Del_Void Evt_BBC_OnUseFaBaoSuccess = delegate
	{
	};

	public Del_Void_IntInt Evt_BBC_OnVigorSkillCastSuccess = delegate
	{
	};

	public Del_Void Evt_BBC_OnUseItemSuccess = delegate
	{
	};

	public Del_Void Evt_BBC_OnTriggerHuluEffectSuccess = delegate
	{
	};

	public Del_Void Evt_BBC_OnPreciseDodgeSuccess = delegate
	{
	};

	public Del_Void Evt_BBC_OnGPSuccess = delegate
	{
	};

	public Del_Void Evt_BBC_OnFourPEAtkSuccess = delegate
	{
	};

	public Del_BBC_OnMonsterBeHurted Evt_BBC_OnMonsterBeHurted = delegate
	{
	};

	public Del_Void_Int Evt_BBC_OnPlayerBeHurted = delegate
	{
	};

	public Del_Void Evt_BBC_OnCastLifeSavingSuccess = delegate
	{
	};

	public Del_Void_StringGameplayTagContainerGameplayTag Evt_SaveSceneObjState = delegate
	{
	};

	public Del_Void_StringGameplayTagContainerGameplayTag Evt_RecordSceneObjState = delegate
	{
	};

	public Del_Void_StringGameplayTagContainerGameplayTagContainer Evt_SaveSceneObjAllStates = delegate
	{
	};

	public Del_Void_StringGameplayTag Evt_SendSceneObjEvent = delegate
	{
	};

	public Del_Void_StringGameplayTag Evt_SetSceneObjState = delegate
	{
	};

	public Del_Void_String Evt_RequestCleanupCachedStates = delegate
	{
	};

	public Del_Void_StringInt Evt_SendUpdateInteractGroup = delegate
	{
	};

	public Del_Void_StringGameplayTag Evt_SaveSceneObjEvent = delegate
	{
	};

	public Del_Void_StringGameplayTagList Evt_ClearUnhandledSceneObjEvents = delegate
	{
	};

	public Del_Void Evt_ClearAllSceneObjState = delegate
	{
	};

	public Del_Void Evt_ClearOverrideSceneObjStates = delegate
	{
	};

	public Del_Void_IntString Evt_SaveCollectionGroupInfo = delegate
	{
	};

	public Del_Void_InitSpawnActorState Evt_InitCollectionSpawnActorState = delegate
	{
	};

	public Del_Void Evt_leavingMap = delegate
	{
	};

	public Del_Void_ActorString Evt_NotifyActorGuid2EntityOnDataConvert = delegate
	{
	};

	public Del_Void_ActorStringInt Evt_SetActorGuid2Entity = delegate
	{
	};

	public Del_Void_ActorStringInt Evt_RemoveActorGuid2Entity = delegate
	{
	};

	public Del_Void_StringBool Evt_SetActorInitDataInitialized = delegate
	{
	};

	public Del_Void_StringBool Evt_SetActorAliveState = delegate
	{
	};

	public Del_Void_String Evt_RemoveActorData = delegate
	{
	};

	public Del_BGW_SaveActorInitData Evt_SaveActorInitData = delegate
	{
	};

	public Del_Void_StringBool Evt_LoadActorAliveState = delegate
	{
	};

	public Del_Void_StringResetType Evt_SetActorResetTypeOverride = delegate
	{
	};

	public Del_Void_StringResetType Evt_SetGroupResetTypeOverride = delegate
	{
	};

	public Del_Void_String Evt_ClearActorResetTypeOverride = delegate
	{
	};

	public Del_Void_String Evt_ClearGroupResetTypeOverride = delegate
	{
	};

	public Del_Void_String Evt_NotifyUnitTransStage = delegate
	{
	};

	public Del_Void_StringBool Evt_SetStateMachineNeedReset = delegate
	{
	};

	public Del_Void Evt_ClearStateMachineNeedReset = delegate
	{
	};

	public Del_Void_StringResetType Evt_LoadActorResetType = delegate
	{
	};

	public Del_Void_String Evt_RegisterInteractor = delegate
	{
	};

	public Del_Void_String Evt_UnregisterInteractor = delegate
	{
	};

	public Del_BGW_GameInstanceStart Evt_BGW_GameInstanceStart = delegate
	{
	};

	public Del_BGW_TriggerGlobalFSMEvent Evt_BGW_TriggerGlobalFSMEvent = delegate
	{
	};

	public Del_BGW_AbortFSMInstance Evt_BGW_AbortFSMInstance = delegate
	{
	};

	public Del_Void Evt_BGW_AbortAllFSMInstances = delegate
	{
	};

	public Del_BGW_OnWorldChanged Evt_BGW_OnWorldChanged = delegate
	{
	};

	public Del_Void Evt_TriggerWXLoginSuccess = delegate
	{
	};

	public Del_Void Evt_UpdateRoleAttr = delegate
	{
	};

	public Del_BGW_UnitCastSkillSuccess Evt_BGW_UnitCastSkillSuccess = delegate
	{
	};

	public Del_Void Evt_PreChoosePlayerStart = delegate
	{
	};

	public Del_ChoosePlayerStart Evt_ChoosePlayerStart = () => new FChoosePlayerStartInfo
	{
		UseDefaultPos = true
	};

	public Del_Void Evt_OnLoadingStepFinish = delegate
	{
	};

	public Del_BGW_CFSMGStart Evt_BGW_CFSMGStart = (string _003Cp0_003E, FSMContextBase _003Cp1_003E, UObject _003Cp2_003E, FSMRuntimeInstanceBase _003Cp3_003E, Action _003Cp4_003E, Action<FSMException> _003Cp5_003E, object _003Cp6_003E, bool _003Cp7_003E) => (FSMRuntimeInstanceBase)null;

	public Del_ReplaceKey Evt_BPS_ReplaceKey = delegate
	{
	};

	public Del_ReplacePrefab Evt_BPS_ReplacePrefab = delegate
	{
	};

	public Del_Bool_Void Evt_BPS_ConfirmReplace = () => true;

	public Del_Void Evt_BPS_ResetKey = delegate
	{
	};

	public Del_Void Evt_BPS_ClearKey = delegate
	{
	};

	public Del_Void Evt_BPS_ResetDefaultKey = delegate
	{
	};

	public Del_Void Evt_BPS_InitInputData = delegate
	{
	};

	public Del_Void Evt_TestInteract = delegate
	{
	};

	public Del_Void_IntBool Evt_UIActived = delegate
	{
	};

	public Del_Void_IntIntBool Evt_UIBgmActived = delegate
	{
	};

	public Del_Void Evt_RealEnterTakePhotoMode = delegate
	{
	};

	public Del_Void Evt_OpenBattleMap = delegate
	{
	};

	public Del_Void_Bool Evt_UIShrineMain = delegate
	{
	};

	public Del_Void_Int Evt_UIChapterMovie = delegate
	{
	};

	public Del_Void Evt_ShowBattleUIFinish = delegate
	{
	};

	public Del_Void_Int Evt_NextChapterTravelBegin = delegate
	{
	};

	public Del_BGW_PlayerActorDead Evt_BGW_PlayerActorDeadForLoadingTips = delegate
	{
	};

	public Del_BGW_PreFecthLoadingTips Evt_BGW_PreFetchLoadingTips = delegate
	{
	};

	public Del_Void Evt_BGW_PostFecthLoadingTipsFinish = delegate
	{
	};

	public Del_Void Evt_PostLoadingScreenOpen = delegate
	{
	};

	public Del_Void Evt_PostLoadingScreenClose = delegate
	{
	};

	public Del_Void Evt_PostLoadingScreenWaitUserInputBegin = delegate
	{
	};

	public Del_Void Evt_PostLoadingScreenWaitUserInputEnd = delegate
	{
	};

	public Del_Void_IntInt Evt_BGW_InteractGroup_Complete = delegate
	{
	};

	public Del_AcitveBlackOutWithCallback Evt_ActiveBlackOut = delegate
	{
	};

	public Del_Void_IntInt Evt_UI_Interact_Behaviour = delegate
	{
	};

	public Del_Void_Int Evt_Alchemy_Seq_Fin = delegate
	{
	};

	public Del_Void Evt_RefreshShopCommTips = delegate
	{
	};

	public Del_Void_StringGameplayTag Evt_TriggerPsmEvent = delegate
	{
	};

	public Del_Void_StringPsmInstance Evt_RegisterPsmInstance = delegate
	{
	};

	public Del_Void_String Evt_UnregisterPsmInstance = delegate
	{
	};

	public Del_Void Evt_ResetPsmInstances = delegate
	{
	};

	public Del_Void Evt_RequestUpdateStateMachineArchiveData = delegate
	{
	};

	public Del_Void Evt_RequestUpdateMovieArchiveData = delegate
	{
	};

	public Del_Void_StateMachineArchiveData Evt_RecoverStateMachineArchiveData = delegate
	{
	};

	public Del_DisableSetBT Evt_BGW_DisableSetBT = delegate
	{
	};

	public Func<PersistentECSData> Evt_SerializePersistentECSData = () => (PersistentECSData)null;

	public Del_RegisterIdleProcessAction Evt_RegisterIdleProcessAction = delegate
	{
	};

	public Del_Void_PsmNodeInstance Evt_RunIdleProcessActions = delegate
	{
	};

	public Del_Void_PsmNodeInstance Evt_ResetRunIdleProcessActions = delegate
	{
	};

	public Del_Void_PsmNodeInstance Evt_RecoverRunIdleProcessActions = delegate
	{
	};

	public Del_Void_PsmNodeInstance Evt_ShutdownIdleProcessActions = delegate
	{
	};

	public Del_Void_Bool Evt_SetProcessGraphPaused = delegate
	{
	};

	public Del_Void_Float Evt_CallTickForMovieSystem = delegate
	{
	};

	public Del_Void Evt_OnPlayerPostLogin = delegate
	{
	};

	public Del_BGPPlayerController Evt_PlayerControllerBeginPlay = delegate
	{
	};

	public Del_Void Evt_PlayerControllerEndPlay = delegate
	{
	};

	public Del_ReportSkillDamageInfo Evt_ReportSkillDamageInfo = delegate
	{
	};

	public Del_Void_String Evt_TrainDummyResultReport = delegate
	{
	};

	public Del_TriggerResetAllActors Evt_TriggerResetAllActors;

	public Del_PlayerTeleportToTriggered Evt_BGW_PlayerTeleportToTriggered;

	public Del_PlayerTeleportToFinished Evt_BGW_PlayerTeleportToFinished;

	public Del_TriggerResetOneActor Evt_TriggerResetOneActor;

	public Del_Void_CalliopeAsset Evt_StartCalliopeInstance;

	public Del_Void_CalliopeAsset Evt_FinishCalliopeInstance;

	public Del_Void_CalliopeAssetRequest Evt_SendCalliopeAssetRequest;

	public Del_Void_CalliopeAssetInfo Evt_RegisterCalliopeAsset;

	public Del_Void_Int Evt_UnregisterCalliopeAsset;

	public Del_Void Evt_PreECSWorldBeginPlay = delegate
	{
	};

	public Del_Void Evt_DestoryWaitSeqOldTransActor = delegate
	{
	};

	public Del_Void_Bool Evt_BlockUIInput = delegate
	{
	};

	public Del_Void_Bool Evt_BlockBattleInput = delegate
	{
	};

	public Del_Void_Bool Evt_BlockAllInput = delegate
	{
	};

	public Del_Void_BoolBoolBool Evt_BeginBlockCinematicInput = delegate
	{
	};

	public Del_Void Evt_EndBlockCinematicInput = delegate
	{
	};

	public Del_Void_EGSInputModeWithChangeReason Evt_SetInputMode = delegate
	{
	};

	public Del_SetSuperUserInputMode Evt_SetSuperUserInputMode = delegate
	{
	};

	public Del_Void_EGSInputMode Evt_ResetInputMode = delegate
	{
	};

	public Del_Void_Bool Evt_ForceHideMouseCursor = delegate
	{
	};

	public Del_Void_Exception Evt_ShowExceptionUI = delegate
	{
	};

	public Del_Void Evt_CloseExceptionUI = delegate
	{
	};

	public Del_SetGSPageToppingEvent Evt_SetPageToppingEvent = delegate
	{
	};

	public Del_Void_EGSInputType Evt_OnInputTypeChangeTrigger = delegate
	{
	};

	public Del_InputTrigger Evt_OnInputTrigger = delegate
	{
	};

	public Del_Void_FKeyEvent Evt_OnKeyDownEvent = delegate
	{
	};

	public Del_Void_FKeyEvent Evt_OnKeyUpEvent = delegate
	{
	};

	public Del_Void_FAnalogInputEvent Evt_OnAnalogInputEvent = delegate
	{
	};

	public Del_Void_FPointerEvent Evt_OnMouseMoveEvent = delegate
	{
	};

	public Del_Void_FPointerEvent Evt_OnMouseButtonDownEvent = delegate
	{
	};

	public Del_Void_FPointerEvent Evt_OnMouseButtonUpEvent = delegate
	{
	};

	public Del_Void_FPointerEvent Evt_OnMouseButtonDoubleClickEvent = delegate
	{
	};

	public Del_Void_FPointerEvent Evt_OnMouseWheelEvent = delegate
	{
	};

	public Del_Void_FKey Evt_OnAnyKeyTrigger = delegate
	{
	};

	public Del_Void_EInputMappingContextTagBool Evt_SetInputMappingContextEnable = delegate
	{
	};

	public Del_Void_Bool Evt_SetAllInputMappingContextEnable = delegate
	{
	};

	public Del_Void_UGSInputWidgetCS Evt_RegisterInputWidget = delegate
	{
	};

	public Del_Void_UGSInputWidgetCS Evt_UnRegisterInputWidget = delegate
	{
	};

	public Del_Void_UGSInputWidgetCS Evt_RegisterGlobalRootWidget = delegate
	{
	};

	public Del_Void_UGSInputWidgetCS Evt_ClearTriggerInputWidget = delegate
	{
	};

	public Del_Void_UGSInputWidgetCSInt Evt_AddTriggerInputWidget = delegate
	{
	};

	public Del_Void_UGSInputWidgetCSInt Evt_RemoveTriggerInputWidget = delegate
	{
	};

	public Del_Void Evt_ClearAllInputDelegates = delegate
	{
	};

	public Del_BlockNavigation Evt_BlockWidgetNavigation = delegate
	{
	};

	public Del_OpenInputLog Evt_OpenInputLog = delegate
	{
	};

	public Del_Void_PlayerController Evt_PostInitPlayerInputFinish = delegate
	{
	};

	public Del_Void Evt_PostPlayerInputDispose = delegate
	{
	};

	public Del_BindInputSettingsPreProcEvent Evt_BindInputSettingsPreProcEvent = delegate
	{
	};

	public Del_Void Evt_UnbindInputSettingsPreProcEvent = delegate
	{
	};

	public Del_Void Evt_ResumeInputSettingsToDefault = delegate
	{
	};

	public Del_Void Evt_ResumeKeyboardSettings = delegate
	{
	};

	public Del_Void Evt_ResumeGamepadSettings = delegate
	{
	};

	public Del_Void Evt_SwitchPlatformIcon = delegate
	{
	};

	public Del_InjectInputTriggerEvent Evt_InjectInputTriggerEvent = delegate
	{
	};

	public Del_GetAxisInputAction Evt_GetAxisInputAction = () => new List<GSBattleActionEn>();

	public Del_RegisterBattleCallback Evt_RegisterBattleCallback = delegate
	{
	};

	public Del_Void Evt_PostApplyInputSettingFinish = delegate
	{
	};

	public Del_Void_Bool Evt_SetCloudInputEnable = delegate
	{
	};

	public Del_BlockInput Evt_BlockInput = delegate
	{
	};

	public Del_PostInputMappingContextRegister Evt_PostInputMappingContextRegister = delegate
	{
	};

	public Del_Void Evt_GSLoginFinish = delegate
	{
	};

	public Del_Void Evt_GSLogoutFinish = delegate
	{
	};

	public Del_Void Evt_PostPlayerControllerAttach = delegate
	{
	};

	public Del_Void Evt_PostPlayerControllerBeginPlay = delegate
	{
	};

	public Del_Void Evt_PostPlayerControllerEndPlay = delegate
	{
	};

	public Del_Void Evt_PostGameStateAttach = delegate
	{
	};

	public Del_Void Evt_PostGameStateBeginPlay = delegate
	{
	};

	public Del_Void Evt_PostGameStateEndPlay = delegate
	{
	};

	public Del_Void Evt_EndingCreditsFinish = delegate
	{
	};

	public Del_Bool_Void Evt_ReplayBattleWorldLoadFinish = () => false;

	public Del_Void_SetGamePause Evt_SetGamePause = delegate
	{
	};

	public Del_Void_Bool Evt_SetGameAllPause = delegate
	{
	};

	public Del_Void_Bool Evt_OnSetBattlePause = delegate
	{
	};

	public Del_Void Evt_PlayGoDownloadComplete = delegate
	{
	};

	public Del_Void_Int Evt_TriggerMonitorAsPrimaryChange = delegate
	{
	};

	public Del_Void_FIntPoint Evt_TriggerViewportResized = delegate
	{
	};

	public Del_Void Evt_TriggerCultureChanged = delegate
	{
	};

	public Del_Void_Int Evt_GlobalEventTest = delegate
	{
	};

	public Del_Void Evt_RefreshLevelInfo = delegate
	{
	};

	public Del_Void_String Evt_RefreshActorInfo = delegate
	{
	};

	public Del_Void_StringBool Evt_MarkActorInfoRealTime = delegate
	{
	};

	public Del_Void_String Evt_RefreshActorInfoOnce = delegate
	{
	};

	public Del_Void_Bool Evt_LockAllMonsterHP = delegate
	{
	};

	public Del_Void_Bool Evt_CancelAllMonsterSkillCD = delegate
	{
	};

	public Del_Void_Bool Evt_PauseAllMonsterAI = delegate
	{
	};

	public Del_Void_Bool Evt_SetAllUnitCannotDead = delegate
	{
	};

	public Del_Void_Bool Evt_IgnoreAllOverlapEvent = delegate
	{
	};

	public Del_Void_ActorInt Evt_BGW_OnAllSummonBeKilled = delegate
	{
	};

	public Del_Void_SummonInstance Evt_BGW_OnSummonBeKilled = delegate
	{
	};

	public Del_Void_ActorActorInt Evt_BGW_TriggerAttackStiff = delegate
	{
	};

	public Del_Void_ActorActorInt Evt_BGW_TriggerAttackStiff_ListenAttacker = delegate
	{
	};

	public Del_UnitTrans_NotifyWorld Evt_BGW_UnitTrans = delegate
	{
	};

	public Del_Void_ActorInt Evt_BGW_BeAttackedFromSkill = delegate
	{
	};

	public Del_Void_ActorInt Evt_BGW_BeAttackedFromSkillEffect = delegate
	{
	};

	public Del_BGW_OnSkillValidAttackFrameEnded Evt_BGW_OnSkillValidAttackFrameEnded = delegate
	{
	};

	public Del_Void_ActorString Evt_BGW_AMNotifyBehaviorGraph = delegate
	{
	};

	public Del_Void_ActorActor Evt_BGW_BeKilled = delegate
	{
	};

	public Del_Void_ActorActorFloat Evt_BGW_BeHurt = delegate
	{
	};

	public Del_Bool_Void Evt_LeakLogTest = () => false;

	public Del_BGW_PostPSOStageChanged Evt_PostPSOStateChanged = delegate
	{
	};

	public Del_Void Evt_EnterMainMenu = delegate
	{
	};

	public Del_Void Evt_ResetAllTamer = delegate
	{
	};

	public Del_ReplayRemapTamer Evt_RemapTamer = delegate
	{
	};

	public Del_RegisterTamer Evt_ReplayRegisterTamer = delegate
	{
	};

	public Del_ReplaySwitchTamer Evt_OpenTamer = delegate
	{
	};

	public Del_ReplaySwitchTamer Evt_CloseTamer = delegate
	{
	};

	public Del_Void Evt_TamerStratergyInitFinish = delegate
	{
	};

	public Del_StorePlayerPerformerEquipConfig Evt_StorePlayerPerformerEquipConfig = delegate
	{
	};

	public Del_Void_Bool Evt_UpdateMedicineBasketDisplay = delegate
	{
	};

	public Del_SettingValueChanged Evt_SettingValueChanged = delegate
	{
	};

	public Del_SettingValueChanged Evt_SettingUIChanged = delegate
	{
	};

	public Del_Void_String Evt_ComboTest = delegate
	{
	};

	public Del_Void Evt_BenchMarkFinishBackToSetting = delegate
	{
	};

	public Del_Void Evt_BenchMarkFinishReDo = delegate
	{
	};

	public Del_Void Evt_RequestUpdateLevelState = delegate
	{
	};

	public Del_Void Evt_ForceDispatchUpdateLevelStateRequest = delegate
	{
	};

	public Del_Void_StringList Evt_LogLevelStreamingState = delegate
	{
	};

	public Del_Void_StringList Evt_LogCurrentRequestingLevelStateOperations = delegate
	{
	};

	public Del_OnSetLevelsStateFinished Evt_OnSetLevelsStateFinished = delegate
	{
	};

	public Del_Void Evt_SettingEndBattle = delegate
	{
	};

	public Del_TriggerPlayerTeleport Evt_TriggerPlayerTeleport = delegate
	{
	};

	public Del_Void_Bool Evt_TriggerLowMemory = delegate
	{
	};

	public Del_Void_Bool Evt_BGW_TriggerInBattleLevel = delegate
	{
	};

	public Del_RegisterFetchDebugInfoFunc Evt_RegisterFetchDebugInfoFunc = delegate
	{
	};

	public Del_Void_String Evt_UnRegisterFetchDebugInfoFunc = delegate
	{
	};

	public Del_Void_Int Evt_LoadBossRushBattle = delegate
	{
	};

	public Del_Void Evt_ShutdownBossRushBattle = delegate
	{
	};

	public Del_Void Evt_BeginBossRushBattle = delegate
	{
	};

	public Del_Void Evt_FailedBossRushBattle = delegate
	{
	};

	public Del_Void Evt_EndBossRushBattle = delegate
	{
	};

	public Del_Void Evt_FinishBossRushBattle = delegate
	{
	};

	public Del_Void Evt_ReadyBossRushBattle_ShowUI = delegate
	{
	};

	public Del_Void Evt_ReadyBossRushBattle = delegate
	{
	};

	public Del_Void Evt_BossRushBattleWaitFinished = delegate
	{
	};

	public Del_Void Evt_BossRushManualCloseDefeatedUI = delegate
	{
	};

	public Del_UpdateBossRushConfig Evt_UpdateBossRushConfig = delegate
	{
	};

	public Del_Void Evt_StopAllTimeDilation = delegate
	{
	};

	public Del_Void Evt_NotifyPlayerInBattle = delegate
	{
	};

	public Del_Void Evt_NotifyPlayerLeaveBattle = delegate
	{
	};

	public Del_Void_Bool Evt_BossRushBattleTimeSetPaused = delegate
	{
	};

	public static BGW_EventCollection Get(UObject WorldCtx)
	{
		return BGWGameInstanceCS.GetObject<BGW_EventCollection>(WorldCtx);
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		if (SharedRuntimeState.CurrentRuntime == EDotNetRuntime.CoreCLR)
		{
			ResetEvtToNULL();
		}
	}

	private void ResetEvtToNULL()
	{
		Evt_BGW_OnObserveConditionSatisfying = null;
		Evt_OnRegisterFlowObserve = null;
		Evt_OnUnregisterFlowObserve = null;
		Evt_NotifyMovieInstanceStarted = null;
		Evt_NotifyMovieInstanceFinished = null;
		Evt_MarkMoviePlayed = null;
		Evt_TriggerSyncEquip = null;
		Evt_ActiveSkipMovieUI = null;
		Evt_InteractOpenUI = null;
		Evt_UICommTips = null;
		Evt_BGW_UnitRequestPreload = null;
		Evt_BGW_PlayerRequestPreload = null;
		Evt_BGW_PlayerAbilityChangeRequestPreload = null;
		Evt_BGW_InteractRequestPreload = null;
		Evt_RegisterTeleport = null;
		Evt_UnregisterTeleport = null;
		Evt_OnTeleportFinished = null;
		Evt_RequestDreamTeleport = null;
		Evt_DreamTeleportFinished = null;
		Evt_RecoverArchiveData = null;
		Evt_RequestUpdateLevelArchiveData = null;
		Evt_RecoverLevelArchiveData = null;
		Evt_OpenLevelFinished = null;
		Evt_PlayerDelayBeginPlayFinished = null;
		Evt_LoadingBeginFadeAway = null;
		Evt_OnCurrentLevelChanged = null;
		Evt_RequestUpdateTaskArchiveData = null;
		Evt_RecoverTaskArchiveData = null;
		Evt_PushTaskStageStateSuccess = null;
		Evt_RecoverMovieArchiveData = null;
		Evt_TaskGraphNotifyGraph = null;
		Evt_TaskGraphStartObserve = null;
		Evt_TaskGraphStopObserve = null;
		Evt_TaskGraphNotifyGraph_ItemChange = null;
		Evt_TaskGraphNotifyGraph_TaskStage = null;
		Evt_TaskGraphNotifyGraph_InteractionEnd = null;
		Evt_TaskGraphNotifyGraph_MonsterCollectionFull = null;
		Evt_TaskGraphStartObserveForTask = null;
		Evt_TaskGraphStopObserveForTask = null;
		Evt_BGS_PlayerEnterOverlap = null;
		Evt_BGS_PlayerLeaveOverlap = null;
		Evt_BGW_CacheNPCInfo = null;
		Evt_BGW_SpawnAssociationUnit = null;
		Evt_BGW_ActiveAssociationUnit = null;
		Evt_BGW_KillAssociationUnit = null;
		Evt_BGW_GroupUnitDead = null;
		Evt_BGW_NotifyMarkAssociationUnitActive = null;
		Evt_BGW_PrintCurrentAssociationUnitInfo = null;
		Evt_BGW_PrintCurrentFollowPartnerInfo = null;
		Evt_BGW_PrintCurrentWeakAiInteractInfo = null;
		Evt_OnPlayerStateEndPlay = null;
		Evt_CacheArchiveData = null;
		Evt_InitArchiveBaseData = null;
		Evt_KillAllPlayer = null;
		Evt_PostLoadMapWithWorld = null;
		Evt_PreLoadMap = null;
		Evt_OnSeamlessTravelStart = null;
		Evt_OnSeamlessTravelTransition = null;
		Evt_PostSeamlessTravel = null;
		Evt_ReStartByArchiveId = null;
		Evt_ResetGameInstanceData = null;
		Evt_ClearAllGameData = null;
		Evt_PauseAllMovie = null;
		Evt_ResumeAllMovie = null;
		Evt_SaveSceneObjState = null;
		Evt_RecordSceneObjState = null;
		Evt_SaveSceneObjAllStates = null;
		Evt_SendSceneObjEvent = null;
		Evt_SetSceneObjState = null;
		Evt_RequestCleanupCachedStates = null;
		Evt_SendUpdateInteractGroup = null;
		Evt_SaveSceneObjEvent = null;
		Evt_ClearUnhandledSceneObjEvents = null;
		Evt_ClearAllSceneObjState = null;
		Evt_ClearOverrideSceneObjStates = null;
		Evt_SaveCollectionGroupInfo = null;
		Evt_InitCollectionSpawnActorState = null;
		Evt_leavingMap = null;
		Evt_NotifyActorGuid2EntityOnDataConvert = null;
		Evt_SetActorGuid2Entity = null;
		Evt_RemoveActorGuid2Entity = null;
		Evt_SetActorInitDataInitialized = null;
		Evt_SetActorAliveState = null;
		Evt_RemoveActorData = null;
		Evt_SaveActorInitData = null;
		Evt_LoadActorAliveState = null;
		Evt_SetActorResetTypeOverride = null;
		Evt_ClearActorResetTypeOverride = null;
		Evt_NotifyUnitTransStage = null;
		Evt_SetStateMachineNeedReset = null;
		Evt_ClearStateMachineNeedReset = null;
		Evt_LoadActorResetType = null;
		Evt_BGW_GameInstanceStart = null;
		Evt_BGW_TriggerGlobalFSMEvent = null;
		Evt_BGW_AbortFSMInstance = null;
		Evt_BGW_AbortAllFSMInstances = null;
		Evt_BGW_OnWorldChanged = null;
		Evt_UpdateRoleAttr = null;
		Evt_BGW_UnitCastSkillSuccess = null;
		Evt_PreChoosePlayerStart = null;
		Evt_ChoosePlayerStart = null;
		Evt_OnLoadingStepFinish = null;
		Evt_BGW_CFSMGStart = null;
		Evt_BPS_ReplaceKey = null;
		Evt_BPS_ReplacePrefab = null;
		Evt_BPS_ConfirmReplace = null;
		Evt_BPS_ResetKey = null;
		Evt_BPS_ClearKey = null;
		Evt_BPS_ResetDefaultKey = null;
		Evt_BPS_InitInputData = null;
		Evt_TestInteract = null;
		Evt_UIActived = null;
		Evt_UIShrineMain = null;
		Evt_UIChapterMovie = null;
		Evt_ShowBattleUIFinish = null;
		Evt_NextChapterTravelBegin = null;
		Evt_BGW_PlayerActorDeadForLoadingTips = null;
		Evt_BGW_PreFetchLoadingTips = null;
		Evt_BGW_PostFecthLoadingTipsFinish = null;
		Evt_BGW_InteractGroup_Complete = null;
		Evt_ActiveBlackOut = null;
		Evt_UI_Interact_Behaviour = null;
		Evt_Alchemy_Seq_Fin = null;
		Evt_RefreshShopCommTips = null;
		Evt_StartCalliopeInstance = null;
		Evt_FinishCalliopeInstance = null;
		Evt_SendCalliopeAssetRequest = null;
		Evt_RegisterCalliopeAsset = null;
		Evt_UnregisterCalliopeAsset = null;
		Evt_PreECSWorldBeginPlay = null;
		Evt_BlockUIInput = null;
		Evt_BlockBattleInput = null;
		Evt_BlockAllInput = null;
		Evt_BeginBlockCinematicInput = null;
		Evt_EndBlockCinematicInput = null;
		Evt_SetInputMode = null;
		Evt_SetSuperUserInputMode = null;
		Evt_ResetInputMode = null;
		Evt_ForceHideMouseCursor = null;
		Evt_ShowExceptionUI = null;
		Evt_CloseExceptionUI = null;
		Evt_SetPageToppingEvent = null;
		Evt_OnInputTypeChangeTrigger = null;
		Evt_OnInputTrigger = null;
		Evt_OnKeyDownEvent = null;
		Evt_OnKeyUpEvent = null;
		Evt_OnAnalogInputEvent = null;
		Evt_OnMouseMoveEvent = null;
		Evt_OnMouseButtonDownEvent = null;
		Evt_OnMouseButtonUpEvent = null;
		Evt_OnMouseButtonDoubleClickEvent = null;
		Evt_OnMouseWheelEvent = null;
		Evt_SetInputMappingContextEnable = null;
		Evt_SetAllInputMappingContextEnable = null;
		Evt_RegisterInputWidget = null;
		Evt_UnRegisterInputWidget = null;
		Evt_RegisterGlobalRootWidget = null;
		Evt_ClearTriggerInputWidget = null;
		Evt_AddTriggerInputWidget = null;
		Evt_RemoveTriggerInputWidget = null;
		Evt_ClearAllInputDelegates = null;
		Evt_OpenInputLog = null;
		Evt_PostInitPlayerInputFinish = null;
		Evt_PostPlayerInputDispose = null;
		Evt_BindInputSettingsPreProcEvent = null;
		Evt_UnbindInputSettingsPreProcEvent = null;
		Evt_ResumeInputSettingsToDefault = null;
		Evt_SwitchPlatformIcon = null;
		Evt_InjectInputTriggerEvent = null;
		Evt_PostApplyInputSettingFinish = null;
		Evt_TriggerPsmEvent = null;
		Evt_RegisterPsmInstance = null;
		Evt_UnregisterPsmInstance = null;
		Evt_ResetPsmInstances = null;
		Evt_RequestUpdateStateMachineArchiveData = null;
		Evt_RequestUpdateMovieArchiveData = null;
		Evt_RecoverStateMachineArchiveData = null;
		Evt_BGW_DisableSetBT = null;
		Evt_SerializePersistentECSData = null;
		Evt_OnPlayerPostLogin = null;
		Evt_PlayerControllerBeginPlay = null;
		Evt_PlayerControllerEndPlay = null;
		Evt_ReportSkillDamageInfo = null;
		Evt_TrainDummyResultReport = null;
		Evt_TriggerResetAllActors = null;
		Evt_BGW_PlayerTeleportToTriggered = null;
		Evt_BGW_PlayerTeleportToFinished = null;
		Evt_TriggerResetOneActor = null;
		Evt_ReplayBattleWorldLoadFinish = null;
		Evt_SetGamePause = null;
		Evt_SetGameAllPause = null;
		Evt_OnSetBattlePause = null;
		Evt_TriggerMonitorAsPrimaryChange = null;
		Evt_TriggerViewportResized = null;
		Evt_GlobalEventTest = null;
		Evt_RefreshLevelInfo = null;
		Evt_LockAllMonsterHP = null;
		Evt_CancelAllMonsterSkillCD = null;
		Evt_PauseAllMonsterAI = null;
		Evt_SetAllUnitCannotDead = null;
		Evt_IgnoreAllOverlapEvent = null;
		Evt_BGW_OnAllSummonBeKilled = null;
		Evt_BGW_OnSummonBeKilled = null;
		Evt_BGW_TriggerAttackStiff = null;
		Evt_BGW_TriggerAttackStiff_ListenAttacker = null;
		Evt_BGW_UnitTrans = null;
		Evt_BGW_BeAttackedFromSkill = null;
		Evt_BGW_BeAttackedFromSkillEffect = null;
		Evt_BGW_OnSkillValidAttackFrameEnded = null;
		Evt_BGW_AMNotifyBehaviorGraph = null;
		Evt_BGW_BeKilled = null;
		Evt_BGW_BeHurt = null;
		Evt_LeakLogTest = null;
		Evt_EnterMainMenu = null;
		Evt_ResetAllTamer = null;
		Evt_RemapTamer = null;
		Evt_ReplayRegisterTamer = null;
		Evt_OpenTamer = null;
		Evt_CloseTamer = null;
		Evt_TamerStratergyInitFinish = null;
		Evt_TriggerPlayerTeleport = null;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_EventCollection");
	}

	static BGW_EventCollection()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_EventCollection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_EventCollection));
	}
}
