using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using b1.Prediction;
using GUR.Runtime;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGS_EventCollectionCS")]
public class BGS_EventCollectionCS : UBUS_EventCollection
{
	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	[UINeedEvent]
	public Del_Void_Int Evt_BGS_TestGameState = delegate
	{
	};

	public Del_Void_Int Evt_BGS_TestGameMode = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_Void_Int Evt_BGS_SwitchTickRateLogic = delegate
	{
	};

	public Del_AllocPredictionKey Evt_BGS_AllocPredictionKey = () => (GSPredictionKey)null;

	public Del_Void_Int Evt_BGS_ConfirmPredictionKey = delegate
	{
	};

	public Del_Void_Int Evt_BGS_RollBackPredictionKey = delegate
	{
	};

	public Del_BeginPredictionScope Evt_BGS_BeginPredictionScope = delegate
	{
	};

	public Del_Void Evt_BGS_EndPredictionScope = delegate
	{
	};

	public Del_GetPredictionKeyById Evt_BGS_GetPredictionKeyById = (int _003Cp0_003E) => (GSPredictionKey)null;

	public Del_Void_Int Evt_BGS_ServerRejectPredictionKey = delegate
	{
	};

	public Del_Bool_Int Evt_BGS_ServerHasPredictionKeyInRejectedSet = (int _003Cp0_003E) => false;

	public Del_Void_Chr Evt_BGS_MasterChangeTeam = delegate
	{
	};

	public Del_Void_IntInt Evt_BGS_AddPartner = delegate
	{
	};

	public Del_Void_IntInt Evt_BGS_RemovePartner = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_Void_StringDeadReason Evt_BGS_UnitDead = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_BGS_OnUnitTransited Evt_BGS_OnUnitTransited = delegate
	{
	};

	public Del_Void_ActorActor Evt_BGS_OnBattlePlayerTransited = delegate
	{
	};

	public Del_BGS_DrawUseMatPainter Evt_BGS_DrawUseMatPainter = delegate
	{
	};

	public Del_BGS_AddOrUpdateEndTickGameTimeForSurfaceType Evt_BGS_AddOrUpdateEndTickGameTimeForSurfaceType = delegate
	{
	};

	public Del_BGS_PushParamsToMaterial Evt_BGS_PushParamsToPainterMaterial = delegate
	{
	};

	public Del_BGS_PushParamsToMaterial Evt_BGS_PushParamsToCanvasMaterial = delegate
	{
	};

	public Del_BGS_AddCameraShakeWithControl Evt_BGS_AddCameraShakeWithControl = delegate
	{
	};

	public Del_BGS_StopCamShakeByReqID Evt_BGS_StopCamShakeByReqID = delegate
	{
	};

	public Del_Void Evt_BGS_IncreaseBuffDispGlobalTriggerCounter = delegate
	{
	};

	public Del_BGS_SubmitFoliageInteractSound Evt_BGS_SubmitFoliageInteractSound = delegate
	{
	};

	public Del_BGS_BeginAnimationSyncPreCheck Evt_BGS_BeginAnimationSyncPreCheck = delegate
	{
	};

	public Del_Void_Actor Evt_BGS_EndAnimationSyncPreCheck = delegate
	{
	};

	public Del_BGS_BeginSyncAnimation Evt_BGS_BeginSyncAnimation = delegate
	{
	};

	public Del_BGS_EndSyncAnimation Evt_BGS_EndSyncAnimation = delegate
	{
	};

	public Del_BGS_BeginInteractSyncAnimation Evt_BGS_BeginInteractSyncAnimation = delegate
	{
	};

	public Del_Void_ActorBool Evt_BGS_EndInteractSyncAnimation = delegate
	{
	};

	public Del_Void_Actor Evt_BGS_NotifyHostToEndInteractSyncAnimation = delegate
	{
	};

	public Del_Void_Actor Evt_BGS_RemoveInteractParticipants = delegate
	{
	};

	public Del_BGS_ProcessDeathInAnimationSync Evt_BGS_ProcessDeathInAnimationSync = delegate
	{
	};

	public Del_Void_Bool Evt_BGS_SetMoveCameraSpringArmRotToNearestAfterAS = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_BGS_NotifySwitchTarget Evt_BGS_NotifySwitchTarget = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_BGS_NotifyCopyHatredInfo Evt_BGS_NotifyCopyHatredInfo = delegate
	{
	};

	public Del_BGS_FightVanished Evt_BGS_FightVanished = delegate
	{
	};

	public Del_Void_Actor Evt_BGS_ComeCloseToFollowPartnerInteractiveArea = delegate
	{
	};

	public Del_Void_Actor Evt_BGS_EnterFollowPartnerInteractArea = delegate
	{
	};

	public Del_Void_Actor Evt_BGS_LeaveFollowPartnerInteractArea = delegate
	{
	};

	public Del_Void_Actor Evt_BGS_FollowPartnerFinishInteract = delegate
	{
	};

	public Del_Void_Int Evt_BGS_EliminationCurrentFollowPartner = delegate
	{
	};

	public Del_RemovePerformerInList Evt_BGS_RemovePerformerInList = delegate
	{
	};

	public Del_SetNewConfigDataAsset Evt_BGS_SetNewConfigDataAsset = delegate
	{
	};

	public Del_Void_Actor Evt_BGS_Try2RecoverDefaultConfigDataAsset = delegate
	{
	};

	public Del_RecoverAttackToken Evt_BGS_RecoverAttackToken = delegate
	{
	};

	public Del_InitiatePriorityActionQue Evt_BGS_InitiatePriorityActionQue = delegate
	{
	};

	public Del_Void_Actor Evt_BGS_AddPerformerInfoToList = delegate
	{
	};

	public Del_Void_Bool Evt_BGS_SetCanTriggerGroupAI = delegate
	{
	};

	public Del_ChangeHotZonePointSelectionStatus Evt_BGS_ChangeHotZonePointSelectionStatus = delegate
	{
	};

	public Del_NotifyAiBreakInteractAction Evt_BGS_NotifyAiBreakInteractAction = delegate
	{
	};

	public Del_Void_String Evt_BGS_NotifyTriggerWeakAiInteract = delegate
	{
	};

	public Del_BGS_MarkGroupCastSkill Evt_BGS_MarkGroupCastSkill = delegate
	{
	};

	public Del_BGS_StartTortoiseFakeMove Evt_BGS_StartTortoiseFakeMove = delegate
	{
	};

	public Del_BGS_Void Evt_BGS_StopTortoiseFakeMove = delegate
	{
	};

	public Del_BGS_UnitBattleStateUpdate Evt_BGS_UnitBattleStateUpdate = delegate
	{
	};

	public Del_BGS_UnitEnterFight Evt_BGS_UnitEnterFight = delegate
	{
	};

	public Del_BGS_UnitLeaveFight Evt_BGS_UnitLeaveFight = delegate
	{
	};

	public Del_BGS_Void Evt_BGS_TortoiseStartRotate = delegate
	{
	};

	public Del_BGS_Void Evt_BGS_TortoiseEndRotate = delegate
	{
	};

	public Del_BGS_RegisterSpiderNavMesh Evt_BGS_RegisterSpiderNavMesh = delegate
	{
	};

	public Del_BGS_RegisterSceneInactiveActor Evt_BGS_RegisterSceneInactiveActor = delegate
	{
	};

	public Del_BGS_ReleaseSceneInactiveActor Evt_BGS_ReleaseSceneInactiveActor = delegate
	{
	};

	public Del_BGS_SetSceneInactiveActorForceActivateTicks Evt_BGS_SetSceneInactiveActorForceActivateTicks = delegate
	{
	};

	public Del_BGS_RegisterRuntimeMeshActor Evt_BGS_RegisterRuntimeMeshActor = delegate
	{
	};

	public Del_BGS_TrySliceRuntimeActors Evt_BGS_TrySliceRuntimeActors = delegate
	{
	};

	public Del_BGS_AddUnitToPatrolGroup Evt_BGS_AddUnitToPatrolGroup = delegate
	{
	};

	public Del_BGS_RemoveUnitFromPatrolGroup Evt_BGS_RemoveUnitFromPatrolGroup = delegate
	{
	};

	public Del_BGS_GroupPatrolLeaderPathMoveComplete Evt_BGS_GroupPatrolLeaderPathMoveComplete = delegate
	{
	};

	public Del_BGS_GroupPatrolWaitPointEnd Evt_BGS_GroupPatrolWaitPointEnd = delegate
	{
	};

	public Del_BGS_PlayerEnterBgmVolume Evt_BGS_PlayerEnterBgmVolume = delegate
	{
	};

	public Del_BGS_PlayerLeaveBgmVolume Evt_BGS_PlayerLeaveBgmVolume = delegate
	{
	};

	public Del_BGS_BGMVolumeInfoUpdate Evt_BGS_BGMVolumeInfoUpdate = delegate
	{
	};

	public Del_BGS_TryPlayBattleBGM Evt_BGS_TryPlayBattleBGM = delegate
	{
	};

	public Del_BGS_TryStopBattleBGM Evt_BGS_TryStopBattleBGM = delegate
	{
	};

	public Del_BGS_SetBattleBgmCanTick Evt_BGS_SetBattleBgmCanTick = delegate
	{
	};

	public Del_BGS_PauseDefaultBGM Evt_BGS_PauseDefaultBGM = delegate
	{
	};

	public Del_BGS_ResumeDefaultBGM Evt_BGS_ResumeDefaultBGM = delegate
	{
	};

	public Del_BGS_TryPlayTransMusic Evt_BGS_TryPlayTransMusic = delegate
	{
	};

	public Del_BGS_TryStopTransMusic Evt_BGS_TryStopTransMusic = delegate
	{
	};

	public Del_BGS_OnLevelsStateRequestBatchFinished Evt_BGS_OnLevelsStateRequestBatchFinished = delegate
	{
	};

	public Del_BGS_SetEnvironmentSurfaceVolumeEnabled Evt_BGS_SetEnvironmentSurfaceVolumeEnabled = delegate
	{
	};

	public Del_BGS_TriggerTransEffect Evt_TriggerTransEffect = delegate
	{
	};

	public Del_BGS_TransEffectUnitChange Evt_TransEffectUnitChange = delegate
	{
	};

	public Del_BGS_SendZBBCreationInfo Evt_SendZBBCreationInfo = delegate
	{
	};

	public Del_BGS_OnSpawnDropItem Evt_BGS_OnSpawnDropItem = delegate
	{
	};

	public Del_Void Evt_BGS_OnCollectionPendingSoul = delegate
	{
	};

	public Del_BGS_Void Evt_BGS_SwitchHero = delegate
	{
	};

	public Del_BGS_Void Evt_BGS_PlayerInitComplete = delegate
	{
	};

	public Del_Void_Actor Evt_BGS_SeqPlayEnd = delegate
	{
	};

	public Del_BGS_Int Evt_BGS_Meditation = delegate
	{
	};

	public Del_BGS_Int Evt_BGS_ShowMeditationAward = delegate
	{
	};

	public Del_BGS_AttrInsuff Evt_BGS_AttrInsuff = delegate
	{
	};

	public Del_BGS_Int Evt_BGS_ShowRebirthPointUI = delegate
	{
	};

	public Del_BGS_Void Evt_BGS_HideRebirthPointUI = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast)]
	public Del_BGS_BoolInt Evt_BGS_TriggerShortcut = delegate
	{
	};

	public Del_BGS_Void Evt_BGS_GMInitTeam = delegate
	{
	};

	public Del_BGS_Void Evt_BGS_GMInitTopBar = delegate
	{
	};

	public Del_Void_String Evt_BGS_ResetActorDestroy;

	public Del_Void Evt_BGS_EnterSeqMove;

	public Del_Void Evt_BGS_LeftSeqMove;

	public Del_BGS_Int Evt_BGS_TriggerSaveData = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_RequestDropSpecialItem Evt_RequestDropSpecialItem = delegate
	{
	};

	public Del_RegisterFamilyTree Evt_RegisterFamilyTree = delegate
	{
	};

	public Del_String_Actor Evt_OnTriggerWakeBroadCastToFamily = delegate
	{
	};

	public Del_Void Evt_InteractGroup_Refresh;

	public Del_Void_StringGameplayTag Evt_BGS_RecordLastNotifyGraph = delegate
	{
	};

	public Del_Void_StringGameplayTag Evt_BGS_NotifyGraph = delegate
	{
	};

	public Del_Void_IObserveNodeInstanceString Evt_BGS_StartObserve = delegate
	{
	};

	public Del_Void_IObserveNodeInstance Evt_BGS_StopObserve = delegate
	{
	};

	public Del_Void Evt_BGS_SerializeQuestArchiveData = delegate
	{
	};

	public Del_Void_Bool Evt_BGS_PauseQuestSystem = delegate
	{
	};

	public Del_Void_String Evt_BGS_SwitchRootQuestGraph = delegate
	{
	};

	public Del_BattleMonsterData Evt_BGS_SetOSSAiPartnerInfo = delegate
	{
	};

	public Del_BattleMonsterData Evt_BGS_SetOSSMonstInfo = delegate
	{
	};

	public Del_Void_IntActor Evt_BGS_OnPlayerIntoBattle = delegate
	{
	};

	public Del_OnPlayerLeaveBattle Evt_BGS_OnPlayerLeaveBattle = delegate
	{
	};

	public Del_OnTaskStageChange Evt_BGS_OnTaskStageChange = delegate
	{
	};

	public Del_Void Evt_BGS_Demo820OSSEndLevel = delegate
	{
	};

	public Del_Void Evt_BGS_EarlyTerminateAiUnitBattleRecord = delegate
	{
	};

	public Del_Void Evt_BGS_LocalPlayerDead_ForOSS = delegate
	{
	};

	public Del_RegisterTamer Evt_RegisterTamer = delegate
	{
	};

	public Del_Void_Tamer Evt_UnregisterTamer = delegate
	{
	};

	public Del_TamerPhaseChanged Evt_TamerPhaseChanged = delegate
	{
	};

	public Del_Void_String Evt_NotifyTamerSpawnUnit = delegate
	{
	};

	public Del_Void_String Evt_RequestDestroyUnit = delegate
	{
	};

	public Del_Void_Tamer Evt_MarkTamerNeverSpawn = delegate
	{
	};

	public Del_Void_Tamer Evt_UnMarkTamerNeverSpawn = delegate
	{
	};

	public Del_Void_String Evt_MarkTamerAlwaysSpawn = delegate
	{
	};

	public Del_Void_String Evt_UnMarkTamerAlwaysSpawn = delegate
	{
	};

	public Del_Void_String Evt_MarkTamerBlockingSpawn = delegate
	{
	};

	public Del_Void_String Evt_UnMarkTamerBlockingSpawn = delegate
	{
	};

	public Del_Void_String Evt_TamerBlockingSpawnImmediately = delegate
	{
	};

	public Del_Void_StringList Evt_EnableTamerOnlyMode = delegate
	{
	};

	public Del_Void_StringList Evt_DisableTamerOnlyMode = delegate
	{
	};

	public Del_Void_ResetActorReason Evt_TriggerResetAllTamers = delegate
	{
	};

	public Del_Void_Bool Evt_EnableTamerBack2Load = delegate
	{
	};

	public Del_UnMarkSocketTamerNeverSpawn Evt_UnMarkSocketTamerNeverSpawn = delegate
	{
	};

	public Del_Void_SetTamerStrategyArea Evt_SetTamerStrategyArea = delegate
	{
	};

	public Del_Void_Bool Evt_SetBossRushSpawnUnitAllowable = delegate
	{
	};

	public Del_Void_SummonRequest Evt_RequestSummonSvr = delegate
	{
	};

	public Del_Void Evt_ClearAllSummon = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.ServerInternal)]
	public Del_Void_ServantInstance Evt_RegisterServantSvr = delegate
	{
	};

	public Del_Void_ServantReq Evt_SendServantReq = delegate
	{
	};

	public Del_Void_ServantReq Evt_NotifyReceiveServantReq = delegate
	{
	};

	public Del_Void_FNameFNameFloat Evt_RequestSetGlobalFXFloatParam;

	public Del_Int_FNameFNameVector Evt_RequestAddGlobalFXVectorParam;

	public Del_Void_FNameFNameInt Evt_RequestRemoveGlobalFXVectorParam;

	public Del_Void_FNameActorFloatVector Evt_AddMFSphereInfo2GlobalFX;

	public Del_Void_FNameActor Evt_RemoveMFSphereInfo2GlobalFX;

	public Del_Void_FNameActorFloatVector Evt_AddMFAvoidanceSphereInfo2GlobalFX;

	public Del_Void_FNameActor Evt_RemoveMFAvoidanceSphereInfo2GlobalFX;

	public Del_Void_FNameActorVector Evt_AddOrUpdateBulletPosition2GlobalFX;

	public Del_Void_FNameActor Evt_RemoveBulletPosition2GlobalFX;

	public Del_StreamingLevelStateChanged Evt_UpdateStreamingLevelState;

	public Del_Void_IntAction Evt_PreviewMovie = delegate
	{
	};

	public Del_Void_PlayMovieInstance Evt_PlayMovieInstance = delegate
	{
	};

	public Del_Void Evt_OnSequenceFinished = delegate
	{
	};

	public Del_Void_IntInt Evt_MovieInstanceFinish = delegate
	{
	};

	public Del_Void Evt_PauseCurrentMovie = delegate
	{
	};

	public Del_Void Evt_ResumeCurrentMovie = delegate
	{
	};

	public Del_Void_Int Evt_CurrentMovieNotifyEnd = delegate
	{
	};

	public Del_Void Evt_MarkCanFinishLoopMovie = delegate
	{
	};

	public Del_Void Evt_MovieGraphFlowFinish = delegate
	{
	};

	public Del_Void Evt_SkipCurrentMovie = delegate
	{
	};

	public Del_Void_ICamera Evt_RegisterCameraObj = delegate
	{
	};

	public Del_Void_ICamera Evt_UnregisterCameraObj = delegate
	{
	};

	public Del_Void_IntGameplayTag Evt_TriggerCustomMovieEvent = delegate
	{
	};

	public Del_Void_IntBool Evt_MarkMovieCanBeSkipped = delegate
	{
	};

	public Del_Void_ConvertToNoCameraMovie Evt_ConvertToNoCameraMovie = delegate
	{
	};

	public Del_Void_GiveBackControlRightForMonster Evt_GiveBackControlRightForMonster = delegate
	{
	};

	public Del_Void Evt_TerminateAllMovies = delegate
	{
	};

	public Del_Void Evt_DetachCameraInSkillSeq = delegate
	{
	};

	public Del_BeginDefeatSlowTime Evt_BeginDefeatSlowTime = delegate
	{
	};

	public Del_Void_Int Evt_EndDefeatSlowTime = delegate
	{
	};

	public Del_Void_IntInt Evt_NotifyMovieBegin = delegate
	{
	};

	public Del_Void_IntInt Evt_NotifyMovieEnd = delegate
	{
	};

	public Del_Void Evt_ReliveAllImmobilized = delegate
	{
	};

	public Del_SpawnStaticMeshActor Evt_OnSpawnStaticMeshActor = delegate
	{
	};

	public Del_Void_Actor Evt_RegisterSceneItem = delegate
	{
	};

	public Del_Void_Actor Evt_UnregisterSceneItem = delegate
	{
	};

	public Del_Void_Actor Evt_OnProjectileBeginAttach = delegate
	{
	};

	public Del_Void_Actor Evt_OnProjectileDestroyed = delegate
	{
	};

	public Del_RequestSpawnAProjectile Evt_RequestSpawnAProjectile = delegate
	{
	};

	public Del_Void Evt_ClearAllAttachedProjectiles = delegate
	{
	};

	public Del_Void_Actor Evt_BGS_ClearAttachedProjectiles_OnUnit = delegate
	{
	};

	public Del_RequestAsyncLineTrace_ByObjectTypeSingle Evt_RequestAsyncLineTrace_ByObjectTypeSingle = delegate
	{
	};

	public Del_RequestAsyncLineTrace_ByChannelSingle Evt_RequestAsyncLineTrace_ByChannelSingle = delegate
	{
	};

	public Del_RequestAsyncLineTrace_ByObjectTypeSingle_Batch Evt_RequestAsyncLineTrace_ByObjectTypeSingle_Batch = delegate
	{
	};

	public Del_RequestAsyncLineTrace_ByChannelSingle_Batch Evt_RequestAsyncLineTrace_ByChannelSingle_Batch = delegate
	{
	};

	public Del_OnAiConversationCastSuccess Evt_OnAiConversationCastSuccess = delegate
	{
	};

	public Del_Void_Uint Evt_OnConversationChainEnd = delegate
	{
	};

	public Del_Void_Uint Evt_OnConversationChainInterrupt = delegate
	{
	};

	public Del_PocessEventByContentIDList Evt_PocessEventByContentIDList = delegate
	{
	};

	public Del_PocessEventByContentIDList_ByGuid Evt_PocessEventByContentIDList_ByGuid = delegate
	{
	};

	public Del_OnAiConversationEnded Evt_OnAiConversationEnded = delegate
	{
	};

	public Del_StopAiConversation Evt_BGS_StopAiConversation = delegate
	{
	};

	public Del_StopAiConversation_ByGUID Evt_BGS_StopAiConversation_ByGUID = delegate
	{
	};

	public Del_StopAllAiConversation Evt_BGS_StopAllAiConversation = delegate
	{
	};

	public Del_Void_String Evt_BGS_UnregisterAiConversationProxy = delegate
	{
	};

	public Del_Void_Actor Evt_BGS_JumpToNextSubtitleMarkerPos = delegate
	{
	};

	public Del_Void_String Evt_PlayPigsyStory = delegate
	{
	};

	public Del_InterruptPigsyStory Evt_InterruptPigsyStory = delegate
	{
	};

	public Del_IntoSpecificStoryArea Evt_IntoSpecificStoryArea = delegate
	{
	};

	public Del_Void_String Evt_ExitSpecificStoryArea = delegate
	{
	};

	public Del_Void Evt_OnCurStoryFinished = delegate
	{
	};

	public Del_Void_OnActorIntoField Evt_OnActorIntoField = delegate
	{
	};

	public Del_Void_ActorActor Evt_OnActorLeaveField = delegate
	{
	};

	public Del_Void_IntFloat Evt_BGS_HandleSpawnWaveGroupCD = delegate
	{
	};

	public Del_Void_EntityEntity Evt_NotifyPossessEntityChanged = delegate
	{
	};

	public Del_Void_Actor Evt_BGS_BattleFieldPerformanceOptUnit = delegate
	{
	};

	public Del_Void_StringString Evt_AkRoomSetSwitch = delegate
	{
	};

	public Del_Void_StringAudioEmitter Evt_RegisterAudioEmitter = delegate
	{
	};

	public Del_Void_String Evt_UnRegisterAudioEmitter = delegate
	{
	};

	public Del_Bool_Void Evt_QueryIsPlayingCameraMovie = () => false;

	public Del_Int_Void Evt_QueryPlayingSequenceID = () => 0;

	public Del_OnRegistTreeFXAnimalInfo Evt_OnRegistTreeFXAnimalInfo = delegate
	{
	};

	public Del_Void_Actor Evt_BGS_OnFXAnimalDisappear = delegate
	{
	};

	public Del_Void_ReqSpawnAnimals Evt_BGS_ReqSpawnAnimals = delegate
	{
	};

	public Del_Void Evt_BGS_OnCloudMoveBegin = delegate
	{
	};

	public Del_Void Evt_BGS_OnCloudMoveEnded = delegate
	{
	};

	public Del_Void_StringString Evt_RegisterWeaponInfo = delegate
	{
	};

	public Del_Void_StringString Evt_UnRegisterWeaponInfo = delegate
	{
	};

	public Del_Void_String Evt_ClearWeaponInfo = delegate
	{
	};

	public Del_Void Evt_BGS_OnLocalPlayerCostDmg = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast)]
	public Del_Void_AkEvent Evt_PostMulticastAkEvent = delegate
	{
	};

	public Del_TriggerEnhancedInputAction Evt_TriggerEnhancedInputAction = delegate
	{
	};

	public Del_Void_IntString Evt_RegisterCrusadeMonsterInfo = delegate
	{
	};

	public Del_Void_String Evt_UpdateCrusadeMonsterInfo = delegate
	{
	};

	public Del_Void_String Evt_EncounterUnit = delegate
	{
	};

	public Del_Void_EAssistEvent Evt_TriggerAssistEvent = delegate
	{
	};

	public Del_Void_Bool Evt_EnterCrusadeArea = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_Void Evt_TeamWipeOut = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_Void Evt_CrusadeSuccess = delegate
	{
	};

	public Del_Void_OutIntInt Evt_FetchTeleportInfoBeforeAssist = delegate(out int P1, out int P2)
	{
		P1 = 0;
		P2 = 0;
	};

	public Del_Void_Int Evt_PlayerTriggerGuideGroup = delegate
	{
	};

	public Del_Void_Int Evt_PlayerFinishGuideGroup = delegate
	{
	};

	public Del_TriggerGuideNodeFinishEvent Evt_TriggerGuideNodeFinishEvent = delegate
	{
	};

	public Del_TriggerGuideNodeFinishEvent_WithIntParam Evt_TriggerGuideNodeFinishEvent_WithIntParam = delegate
	{
	};

	public Del_Void_Int Evt_TriggerConfirmGuideGroupEvent = delegate
	{
	};

	public Del_Void_Int Evt_ShrineMainUIFadeInFinish = delegate
	{
	};

	public Del_Void Evt_BGS_OnPlayerRoleDataInit = delegate
	{
	};

	public Del_UnitDeadDropItem Evt_BGS_UnitDeadDropItem = delegate
	{
	};

	[UINeedEvent]
	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_SendOnlineScreenMsg Evt_BGS_SendOnlineScreenMsg = delegate
	{
	};

	public Del_Void_Int Evt_BGS_LevelEventScreenMsg = delegate
	{
	};

	public Del_Void_UseItemScreenMsg Evt_BGS_UseItemScreenMsg = delegate
	{
	};

	public Del_Void_String Evt_BGS_PlayerDeadScreenMsg = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_OnPlayerLogOut Evt_BGS_OnPlayerLogOut = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_OnPlayerPostLogin Evt_BGS_OnPlayerPostLogin = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_Void Evt_OnlineDebugInfoEnd = delegate
	{
	};

	[UINeedEvent]
	public Del_ItemDropToUI Evt_OnItemDropToUI = delegate
	{
	};

	public Del_PlayerCollected Evt_BGS_PlayerCollected = delegate
	{
	};

	public Del_UnitInBattle Evt_BGS_UnitInBattle = delegate
	{
	};

	public Del_Void_StringInt Evt_BGS_UnitLeaveBattle = delegate
	{
	};

	public Del_Void_String Evt_BGS_RemoveForceLeaveBattleUnit = delegate
	{
	};

	public Del_StandardObjFinishInteract Evt_BGS_StandardObjFinishInteract = delegate
	{
	};

	public Del_Void Evt_BGS_PlayerKillMonster = delegate
	{
	};

	public Del_Void_IntInt Evt_BGS_PlayerGainItem = delegate
	{
	};

	[UINeedEvent]
	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_Void_Int Evt_BGS_ItemFullOnline = delegate
	{
	};

	[UINeedEvent]
	public Del_Void Evt_BGS_HideLevelUI = delegate
	{
	};

	[UINeedEvent]
	public Del_Void Evt_BGS_ShowPartyRoomUI = delegate
	{
	};

	[UINeedEvent]
	public Del_Void Evt_BGS_OnlineTeleport = delegate
	{
	};

	public Del_Void_IntInt Evt_BGS_OnlineChallengeBegin = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_Void_IntInt Evt_BGS_OnlineChallengeStateTrigger = delegate
	{
	};

	public Del_Void_Int Evt_BGS_OnlineChallengeFailed = delegate
	{
	};

	public Del_ChallengeSuccessDropItem Evt_BGS_ChallengeSuccessDropItem = delegate
	{
	};

	public Del_OnlineOnePlayerDead Evt_BGS_OnlineOnePlayerDead = delegate
	{
	};

	public Del_OnlineOnePlayerDead Evt_BGS_OnlineOnePlayerFaildying = delegate
	{
	};

	public Del_OnlineChallengeSpawn Evt_BGS_OnlineChallengeSpawn = delegate
	{
	};

	public Del_Void_Actor Evt_BGS_WaveSpawnEventClear = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_PlayerState Evt_BGS_PlayerJoin = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_PlayerState Evt_BGS_PlayerLogOut = delegate
	{
	};

	public Del_PlayerState Evt_PlayerActorLateBeginPlayFinish = delegate
	{
	};

	public Del_RegisterTaskCollectiont Evt_BGS_RegisterTaskCollectiont = delegate
	{
	};

	public Del_Void_String Evt_BGS_UnRegisterTaskCollectiont = delegate
	{
	};

	public Del_Void_Int Evt_BGS_GMCGTest = delegate
	{
	};

	public Del_Void_BoolString Evt_BGS_DLDWorld_SetWEFMSystemPaused = delegate
	{
	};

	public Del_Void_BoolIntString Evt_BGS_DLDWorld_SetDBCEffectsPaused = delegate
	{
	};

	public Del_Void_BoolString Evt_BGS_DLDWorld_SetCameraEnvFXPaused = delegate
	{
	};

	public Del_ActorTransformInfoData Evt_BGS_RegisterBGUEntityInfo = (AActor _003Cp0_003E, IBUC_ActorTransformInfoData _003Cp1_003E) => false;

	public Del_Void_Entity Evt_BGS_DeregisterBGUEntityInfo = delegate
	{
	};

	public Del_Void_Actor Evt_BGS_RemoveGridInfo = delegate
	{
	};

	public Del_Void_ActorFloat Evt_BGS_SimpleOverlapSetRadius = delegate
	{
	};

	public Del_MarkUnitControl Evt_BGS_BattleTriggerMarkUnitControl = delegate
	{
	};

	public Del_Void_String Evt_BGS_BattleTriggerUnMarkUnitControl = delegate
	{
	};

	public Del_Void_ActorInt Evt_BGS_SetNeedShowDebugChr = delegate
	{
	};

	public Del_Void Evt_BGS_CleanTargetInfos = delegate
	{
	};

	public Del_EQSObjRun Evt_BGS_EQSObjRun = (UEnvQuery _003Cp0_003E, AActor _003Cp1_003E, EBGURunEQSObjReason _003Cp2_003E, FGSEQSExParam _003Cp3_003E, Action<List<FVector>, List<float>, FGSEQSExParam, int> _003Cp4_003E) => -1;

	public Del_EQSObjRunInstant Evt_BGS_EQSObjRunInstant = delegate(UEnvQuery Obj, AActor Querier, out List<FVector> Locations, out List<float> Scores)
	{
		Scores = null;
		Locations = null;
	};

	public Del_EQSObjRunWithCustomParams Evt_BGS_EQSObjRunWithCustomParams = (UEnvQuery _003Cp0_003E, AActor _003Cp1_003E, EBGURunEQSObjReason _003Cp2_003E, List<FGSEnvNamedValue> _003Cp3_003E, Action<List<FVector>, List<float>, FGSEQSExParam, int> _003Cp4_003E) => -1;

	public Del_EQSObjRunInstantWithCustomParams Evt_BGS_EQSObjRunInstantWithCustomParams = delegate(UEnvQuery Obj, AActor Querier, List<FGSEnvNamedValue> Params, out List<FVector> Locations, out List<float> Scores)
	{
		Locations = null;
		Scores = null;
	};

	public Del_Void_UObject Evt_BGS_CollectEQSFunctionBinder = delegate
	{
	};

	public Del_CreatePlayMontageProxy Evt_BGS_CreateBGUPlayMontageCallbackProxy = (EMontageBindReason _003Cp0_003E, USkeletalMeshComponent _003Cp1_003E, UAnimMontage _003Cp2_003E, float _003Cp3_003E, float _003Cp4_003E, FName _003Cp5_003E) => false;

	public Del_CleanPlayMontageCallbackProxy Evt_BGS_CleanBGUPlayMontageCallbackProxy = delegate
	{
	};

	public Del_CollectReplicateData Evt_BGS_CollectReplicateData;

	public Del_DoReplicateData Evt_BGS_DoReplicateData;

	public Del_Void_Actor Evt_BGS_PreBGUCharacterDeadDestroy;

	public Del_Void_Actor Evt_BGS_PostBGUCharacterDeadDestroy;

	public Del_RegisterTamerAuthInfo Evt_BGS_RegisterTamerAuthInfo;

	public Del_UnRegisterTamerAuthInfo Evt_BGS_UnRegisterTamerAuthInfo;

	public Del_ActorChannelClose Evt_BGS_ActorChannelClose;

	public Del_ActorChannelCleanUp Evt_BGS_ActorChannelCleanUp;

	public Del_ActorChannelOpen Evt_BGS_ActorChannelOpen;

	public Del_DestructionDropItem Evt_BGS_DestructionDropItem = delegate
	{
	};

	public Del_Void Evt_PlayerEnterInteractWindow = delegate
	{
	};

	public Del_Void Evt_MeditationRecoverAttrRecord = delegate
	{
	};

	public Del_Void_ActorInt Evt_BGS_OnNavWalkOptLevelChange = delegate
	{
	};

	public Del_Void_Bool Evt_BGS_OnNavWalkOptMassiveModeChange = delegate
	{
	};

	public Del_Actor_Bool Evt_BGS_OnPauseCameraShakeByActor = delegate
	{
	};

	public Del_Bool_Void Evt_BGS_CanEnvironmentInteractLineTrace = () => true;

	public Del_OnSyncPlayGroupLeisureMontage Evt_BGS_OnSyncPlayGroupLeisureMontage = (AActor _003Cp0_003E, UAnimMontage _003Cp1_003E) => -1f;

	public Del_Void Evt_BGS_OnEnterLevelSequenceClearBattleItem = delegate
	{
	};

	public Del_Actor Evt_BGS_OnRegisterAllowUseSpecialItemArea = delegate
	{
	};

	public Del_Actor Evt_BGS_OnUnregisterAllowUseSpecialItemArea = delegate
	{
	};

	public Del_Void_ActorString Evt_BGS_RegisterBattleSCMember;

	public Del_Void_ActorString Evt_BGS_UnRegistBattleSCMember;

	public Del_BattleSCReceiveMessage Evt_BGS_BattleSCReceiveMessage;

	public Del_BattleSCReceiveMessageByReason Evt_BGS_BattleSCReceiveMessageByReason;

	public Del_BattleSCMulticastCachedPointSet Evt_BGS_BattleSCMulticastCachedPointSet;

	public static BGS_GSEventCollection Get(UObject WorldCtx)
	{
		return (UGameplayStatics.GetGameState(WorldCtx) as BGGGameStateCS)?.GameEventCollection;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGS_EventCollectionCS");
	}

	static BGS_EventCollectionCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGS_EventCollectionCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGS_EventCollectionCS));
	}
}
