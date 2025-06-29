using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using BtlB1;
using BtlShare;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.GameplayCameras;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp")]
public class BUS_ExtendConfigComp : UActorEditCompBase
{
	private static bool GroupAIBPConfig_IsValid;

	private static int GroupAIBPConfig_Offset;

	private static bool BehaviorGraphTemplateID_IsValid;

	private static int BehaviorGraphTemplateID_Offset;

	private static bool DialogueGraphTemplateID_IsValid;

	private static int DialogueGraphTemplateID_Offset;

	private static bool StateGraphTemplate_IsValid;

	private static int StateGraphTemplate_Offset;

	private static bool StateGraphTemplatePath_IsValid;

	private static int StateGraphTemplatePath_Offset;

	private static bool OtherFsmTemplates_IsValid;

	private static int OtherFsmTemplates_Offset;

	private static FFieldAddress OtherFsmTemplates_PropertyAddress;

	private TArrayReadWriteMarshaler<UCalliopeAsset> OtherFsmTemplates_Marshaler;

	private static bool OtherFsmTemplatesPath_IsValid;

	private static int OtherFsmTemplatesPath_Offset;

	private static FFieldAddress OtherFsmTemplatesPath_PropertyAddress;

	private TArrayReadWriteMarshaler<string> OtherFsmTemplatesPath_Marshaler;

	private static bool FsmSubMachineOverride_IsValid;

	private static int FsmSubMachineOverride_Offset;

	private static FFieldAddress FsmSubMachineOverride_PropertyAddress;

	private TMapReadWriteMarshaler<FGameplayTag, UCalliopeAsset> FsmSubMachineOverride_Marshaler;

	private static bool FsmSubMachinePathOverride_IsValid;

	private static int FsmSubMachinePathOverride_Offset;

	private static FFieldAddress FsmSubMachinePathOverride_PropertyAddress;

	private TMapReadWriteMarshaler<FGameplayTag, string> FsmSubMachinePathOverride_Marshaler;

	private static bool PhaseStateGraphTemplate_IsValid;

	private static int PhaseStateGraphTemplate_Offset;

	private static bool PhaseStateGraphTemplatePath_IsValid;

	private static int PhaseStateGraphTemplatePath_Offset;

	private static bool EventMap_IsValid;

	private static int EventMap_Offset;

	private static FFieldAddress EventMap_PropertyAddress;

	private TMapReadWriteMarshaler<string, FGameplayTag> EventMap_Marshaler;

	private static bool BattleSC_IsValid;

	private static int BattleSC_Offset;

	private static bool SpecificEventListen_BattleSC_IsValid;

	private static int SpecificEventListen_BattleSC_Offset;

	private static FFieldAddress SpecificEventListen_BattleSC_PropertyAddress;

	private TArrayReadWriteMarshaler<EBattleCoopReason> SpecificEventListen_BattleSC_Marshaler;

	private static bool BattleSC_GUID_IsValid;

	private static int BattleSC_GUID_Offset;

	private static bool InterruptAiConversationWhenIntoBattle_IsValid;

	private static int InterruptAiConversationWhenIntoBattle_Offset;

	private static FFieldAddress InterruptAiConversationWhenIntoBattle_PropertyAddress;

	private static bool AIConversationEventIDList_IsValid;

	private static int AIConversationEventIDList_Offset;

	private static FFieldAddress AIConversationEventIDList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> AIConversationEventIDList_Marshaler;

	private static bool AIConversationFacts_IsValid;

	private static int AIConversationFacts_Offset;

	private static FFieldAddress AIConversationFacts_PropertyAddress;

	private TArrayReadWriteMarshaler<FAiConversationFact> AIConversationFacts_Marshaler;

	private static bool IntimidateBPConfig_IsValid;

	private static int IntimidateBPConfig_Offset;

	private static bool GSArmorSettingInBP_IsValid;

	private static int GSArmorSettingInBP_Offset;

	private static bool WakeUpConfig_IsValid;

	private static int WakeUpConfig_Offset;

	private static bool ReplaceLeisureSequenceID_IsValid;

	private static int ReplaceLeisureSequenceID_Offset;

	private static bool LeisureAnimAfterSequence_IsValid;

	private static int LeisureAnimAfterSequence_Offset;

	private static bool OnFightSkillIDAfterSequence_IsValid;

	private static int OnFightSkillIDAfterSequence_Offset;

	private static bool OnFightSkillIDBackAfterSequence_IsValid;

	private static int OnFightSkillIDBackAfterSequence_Offset;

	private static bool OnFightSkillIDLeftAfterSequence_IsValid;

	private static int OnFightSkillIDLeftAfterSequence_Offset;

	private static bool OnFightSkillIDRightAfterSequence_IsValid;

	private static int OnFightSkillIDRightAfterSequence_Offset;

	private static bool AIState_IsValid;

	private static int AIState_Offset;

	private static bool LastSkillBlockReason_IsValid;

	private static int LastSkillBlockReason_Offset;

	private static bool UserHandle_IsValid;

	private static int UserHandle_Offset;

	private static bool bLogVerbose_IsValid;

	private static int bLogVerbose_Offset;

	private static FFieldAddress bLogVerbose_PropertyAddress;

	private static bool bEnablePerceptionPreview_IsValid;

	private static int bEnablePerceptionPreview_Offset;

	private static FFieldAddress bEnablePerceptionPreview_PropertyAddress;

	private static bool bEnablePerceptionPreviewOutlineOnly_IsValid;

	private static int bEnablePerceptionPreviewOutlineOnly_Offset;

	private static FFieldAddress bEnablePerceptionPreviewOutlineOnly_PropertyAddress;

	private static bool bEnableWakeUpLinkRangeDebug_IsValid;

	private static int bEnableWakeUpLinkRangeDebug_Offset;

	private static FFieldAddress bEnableWakeUpLinkRangeDebug_PropertyAddress;

	private static bool bEnableHardMove_IsValid;

	private static int bEnableHardMove_Offset;

	private static FFieldAddress bEnableHardMove_PropertyAddress;

	private static bool WindyMoveAffectedAngleForward_IsValid;

	private static int WindyMoveAffectedAngleForward_Offset;

	private static bool WindyMoveForwardBuffID_IsValid;

	private static int WindyMoveForwardBuffID_Offset;

	private static bool WindyMoveBackwardBuffID_IsValid;

	private static int WindyMoveBackwardBuffID_Offset;

	private static bool WindyMoveEnterSkill_IsValid;

	private static int WindyMoveEnterSkill_Offset;

	private static bool MuddyMoveEnterSkill_IsValid;

	private static int MuddyMoveEnterSkill_Offset;

	private static bool FrozenMoveEnterSkill_IsValid;

	private static int FrozenMoveEnterSkill_Offset;

	private static bool SpiderSilkyMoveEnterSkill_IsValid;

	private static int SpiderSilkyMoveEnterSkill_Offset;

	private static bool WindyMoveForwardBlendAnim_IsValid;

	private static int WindyMoveForwardBlendAnim_Offset;

	private static bool PatrolType_IsValid;

	private static int PatrolType_Offset;

	private static FFieldAddress PatrolType_PropertyAddress;

	private static bool bDisableRestartOnLeaveFight_IsValid;

	private static int bDisableRestartOnLeaveFight_Offset;

	private static FFieldAddress bDisableRestartOnLeaveFight_PropertyAddress;

	private static bool bDisableRestartOnReset_IsValid;

	private static int bDisableRestartOnReset_Offset;

	private static FFieldAddress bDisableRestartOnReset_PropertyAddress;

	private static bool MotionMatchingState_IsValid;

	private static int MotionMatchingState_Offset;

	private static FFieldAddress MotionMatchingState_PropertyAddress;

	private static bool FindPathMoveType_IsValid;

	private static int FindPathMoveType_Offset;

	private static FFieldAddress FindPathMoveType_PropertyAddress;

	private static bool PatrolMoveSpeedType_IsValid;

	private static int PatrolMoveSpeedType_Offset;

	private static FFieldAddress PatrolMoveSpeedType_PropertyAddress;

	private static bool EnablePatrolOnStart_IsValid;

	private static int EnablePatrolOnStart_Offset;

	private static FFieldAddress EnablePatrolOnStart_PropertyAddress;

	private static bool PatrolBuff_IsValid;

	private static int PatrolBuff_Offset;

	private static bool ABPSettingForPatrol_IsValid;

	private static int ABPSettingForPatrol_Offset;

	private static bool MoveAcceptableRadius_IsValid;

	private static int MoveAcceptableRadius_Offset;

	private static bool StartWaitAMProbability_IsValid;

	private static int StartWaitAMProbability_Offset;

	private static bool StartWaitAM_IsValid;

	private static int StartWaitAM_Offset;

	private static FFieldAddress StartWaitAM_PropertyAddress;

	private TArrayReadWriteMarshaler<UAnimMontage> StartWaitAM_Marshaler;

	private static bool TurnSkillConfig_IsValid;

	private static int TurnSkillConfig_Offset;

	private static bool RandomPatrolConfig_IsValid;

	private static int RandomPatrolConfig_Offset;

	private static bool SplinePatrolConfig_IsValid;

	private static int SplinePatrolConfig_Offset;

	private static bool MultiSplinePatrolConfig_IsValid;

	private static int MultiSplinePatrolConfig_Offset;

	private static bool LeisureConfig_IsValid;

	private static int LeisureConfig_Offset;

	private static bool FollowPatrolConfig_IsValid;

	private static int FollowPatrolConfig_Offset;

	private static bool GroupPatrolConfig_IsValid;

	private static int GroupPatrolConfig_Offset;

	private static bool bEnableMovePhysicsTransform_IsValid;

	private static int bEnableMovePhysicsTransform_Offset;

	private static FFieldAddress bEnableMovePhysicsTransform_PropertyAddress;

	private static bool PhysicsTransformGravityAddValue_IsValid;

	private static int PhysicsTransformGravityAddValue_Offset;

	private static bool RotationTypeDurningPhysicsState_IsValid;

	private static int RotationTypeDurningPhysicsState_Offset;

	private static FFieldAddress RotationTypeDurningPhysicsState_PropertyAddress;

	private static bool GlideSlopeEdgeAngle_IsValid;

	private static int GlideSlopeEdgeAngle_Offset;

	private static bool MaxGlideSpeed_IsValid;

	private static int MaxGlideSpeed_Offset;

	private static bool MinGlideSpeed_IsValid;

	private static int MinGlideSpeed_Offset;

	private static bool MaxSpeedAngle_IsValid;

	private static int MaxSpeedAngle_Offset;

	private static bool MinSpeedAngle_IsValid;

	private static int MinSpeedAngle_Offset;

	private static bool MoveControlReactionSpeed_IsValid;

	private static int MoveControlReactionSpeed_Offset;

	private static bool MoveControlAddMaxSpeed_IsValid;

	private static int MoveControlAddMaxSpeed_Offset;

	private static bool PreventGlideSkillID_IsValid;

	private static int PreventGlideSkillID_Offset;

	private static bool bEnablePhysicalMove_IsValid;

	private static int bEnablePhysicalMove_Offset;

	private static FFieldAddress bEnablePhysicalMove_PropertyAddress;

	private static bool PhysicalGravityAddValue_IsValid;

	private static int PhysicalGravityAddValue_Offset;

	private static bool PhysicalMoveBuff_IsValid;

	private static int PhysicalMoveBuff_Offset;

	private static FFieldAddress PhysicalMoveBuff_PropertyAddress;

	private TArrayReadWriteMarshaler<int> PhysicalMoveBuff_Marshaler;

	private static bool PhysicalMoveBuffNeedSpeed_IsValid;

	private static int PhysicalMoveBuffNeedSpeed_Offset;

	private static bool PhysicalMoveBuffProtectTime_IsValid;

	private static int PhysicalMoveBuffProtectTime_Offset;

	private static bool bUseSocketDirection_IsValid;

	private static int bUseSocketDirection_Offset;

	private static FFieldAddress bUseSocketDirection_PropertyAddress;

	private static bool DirectionBaseSocekt_IsValid;

	private static int DirectionBaseSocekt_Offset;

	private static bool ForwardSocket_IsValid;

	private static int ForwardSocket_Offset;

	private static bool AccuratelyMoveDistance_IsValid;

	private static int AccuratelyMoveDistance_Offset;

	private static bool bSimulatePhysicsWhenAttacking_IsValid;

	private static int bSimulatePhysicsWhenAttacking_Offset;

	private static FFieldAddress bSimulatePhysicsWhenAttacking_PropertyAddress;

	private static bool HorizontalMoveSpeed_IsValid;

	private static int HorizontalMoveSpeed_Offset;

	private static bool VerticalMoveSpeed_IsValid;

	private static int VerticalMoveSpeed_Offset;

	private static bool MaxMoveDistance_IsValid;

	private static int MaxMoveDistance_Offset;

	private static bool FlyDownwardSpeedRate_IsValid;

	private static int FlyDownwardSpeedRate_Offset;

	private static bool FlyDownwardJudgeAngle_IsValid;

	private static int FlyDownwardJudgeAngle_Offset;

	private static bool FloatRelativeSpotActor_IsValid;

	private static int FloatRelativeSpotActor_Offset;

	private static bool RelativeFloatHeight_IsValid;

	private static int RelativeFloatHeight_Offset;

	private static bool SplineList_IsValid;

	private static int SplineList_Offset;

	private static FFieldAddress SplineList_PropertyAddress;

	private TArrayReadWriteMarshaler<TSoftObject<AActor>> SplineList_Marshaler;

	private static bool BeginTriggerBox_IsValid;

	private static int BeginTriggerBox_Offset;

	private static bool EndTriggerBox_IsValid;

	private static int EndTriggerBox_Offset;

	private static bool TurnSpeed_IsValid;

	private static int TurnSpeed_Offset;

	private static bool Acceleration_IsValid;

	private static int Acceleration_Offset;

	private static bool MaxSpeed_IsValid;

	private static int MaxSpeed_Offset;

	private static bool MinSpeed_IsValid;

	private static int MinSpeed_Offset;

	private static bool StartSpeed_IsValid;

	private static int StartSpeed_Offset;

	private static bool MultiSplineDefaultIndex_IsValid;

	private static int MultiSplineDefaultIndex_Offset;

	private static bool FirstAccelerationIndex_IsValid;

	private static int FirstAccelerationIndex_Offset;

	private static bool SecondAccelerationIndex_IsValid;

	private static int SecondAccelerationIndex_Offset;

	private static bool SpeedRateParam_IsValid;

	private static int SpeedRateParam_Offset;

	private static bool RotatorWaitTime_IsValid;

	private static int RotatorWaitTime_Offset;

	private static bool SpeedRateParamCurve_IsValid;

	private static int SpeedRateParamCurve_Offset;

	private static bool UseCurveTime_IsValid;

	private static int UseCurveTime_Offset;

	private static bool StartPointIndex_IsValid;

	private static int StartPointIndex_Offset;

	private static bool IsStartForward_IsValid;

	private static int IsStartForward_Offset;

	private static FFieldAddress IsStartForward_PropertyAddress;

	private static bool ForwardBuffID_IsValid;

	private static int ForwardBuffID_Offset;

	private static bool BackBuffID_IsValid;

	private static int BackBuffID_Offset;

	private static bool FollowStateRotationRate_IsValid;

	private static int FollowStateRotationRate_Offset;

	private static bool bEnableTTTBRT_IsValid;

	private static int bEnableTTTBRT_Offset;

	private static FFieldAddress bEnableTTTBRT_PropertyAddress;

	private static bool bEnableEnvInteraction_IsValid;

	private static int bEnableEnvInteraction_Offset;

	private static FFieldAddress bEnableEnvInteraction_PropertyAddress;

	private static bool TraceDelay_IsValid;

	private static int TraceDelay_Offset;

	private static bool TraceLength_IsValid;

	private static int TraceLength_Offset;

	private static bool Size_IsValid;

	private static int Size_Offset;

	private static bool SampleCollectionProtectTime_IsValid;

	private static int SampleCollectionProtectTime_Offset;

	private static bool OverrideSurfaceType_IsValid;

	private static int OverrideSurfaceType_Offset;

	private static FFieldAddress OverrideSurfaceType_PropertyAddress;

	private static bool OverrideSurfacePersistTime_IsValid;

	private static int OverrideSurfacePersistTime_Offset;

	private static bool OverrideSurfaceFXActorTag_IsValid;

	private static int OverrideSurfaceFXActorTag_Offset;

	private static bool bDrawDebug_IsValid;

	private static int bDrawDebug_Offset;

	private static FFieldAddress bDrawDebug_PropertyAddress;

	private static bool DebugDrawOffset_IsValid;

	private static int DebugDrawOffset_Offset;

	private static bool FXComponentName_IsValid;

	private static int FXComponentName_Offset;

	private static FFieldAddress FXComponentName_PropertyAddress;

	private TArrayReadWriteMarshaler<string> FXComponentName_Marshaler;

	private static bool GlobalFXConfigList_IsValid;

	private static int GlobalFXConfigList_Offset;

	private static FFieldAddress GlobalFXConfigList_PropertyAddress;

	private TArrayReadWriteMarshaler<FGlobalFXConfigInfo> GlobalFXConfigList_Marshaler;

	private static bool PointLightTag_IsValid;

	private static int PointLightTag_Offset;

	private static bool LoopEvent_IsValid;

	private static int LoopEvent_Offset;

	private static bool DeadEvent_IsValid;

	private static int DeadEvent_Offset;

	private static bool BtlBGMBPConfig_IsValid;

	private static int BtlBGMBPConfig_Offset;

	private static bool DrawDebugLine_IsValid;

	private static int DrawDebugLine_Offset;

	private static FFieldAddress DrawDebugLine_PropertyAddress;

	private static bool bShowFootSpeed_IsValid;

	private static int bShowFootSpeed_Offset;

	private static FFieldAddress bShowFootSpeed_PropertyAddress;

	private static bool bShowFootHeight_IsValid;

	private static int bShowFootHeight_Offset;

	private static FFieldAddress bShowFootHeight_PropertyAddress;

	private static bool bUseFarStepAudio_IsValid;

	private static int bUseFarStepAudio_Offset;

	private static FFieldAddress bUseFarStepAudio_PropertyAddress;

	private static bool LeftFootSpeedRefBoneName_IsValid;

	private static int LeftFootSpeedRefBoneName_Offset;

	private static bool RightFootSpeedRefBoneName_IsValid;

	private static int RightFootSpeedRefBoneName_Offset;

	private static bool LeftFootLineTraceBoneName_IsValid;

	private static int LeftFootLineTraceBoneName_Offset;

	private static bool RightFootLineTraceBoneName_IsValid;

	private static int RightFootLineTraceBoneName_Offset;

	private static bool LeftFootFrontSocket_IsValid;

	private static int LeftFootFrontSocket_Offset;

	private static bool RightFootFrontSocket_IsValid;

	private static int RightFootFrontSocket_Offset;

	private static bool CameraShake_IsValid;

	private static int CameraShake_Offset;

	private static bool StepAudioPath_IsValid;

	private static int StepAudioPath_Offset;

	private static bool MoveActionTypeID_IsValid;

	private static int MoveActionTypeID_Offset;

	private static bool bPrintStepAudioSwitchState_IsValid;

	private static int bPrintStepAudioSwitchState_Offset;

	private static FFieldAddress bPrintStepAudioSwitchState_PropertyAddress;

	private static bool bMultiSpdForStepAK_IsValid;

	private static int bMultiSpdForStepAK_Offset;

	private static FFieldAddress bMultiSpdForStepAK_PropertyAddress;

	private static bool bMyriapods_IsValid;

	private static int bMyriapods_Offset;

	private static FFieldAddress bMyriapods_PropertyAddress;

	private static bool DecalMaterialPath_IsValid;

	private static int DecalMaterialPath_Offset;

	private static bool FootStepDecalSize_IsValid;

	private static int FootStepDecalSize_Offset;

	private static bool FootStepDecalOffset_IsValid;

	private static int FootStepDecalOffset_Offset;

	private static bool FootStepDecalStartFadeOutTime_IsValid;

	private static int FootStepDecalStartFadeOutTime_Offset;

	private static bool FootStepDecalFadeOutDuration_IsValid;

	private static int FootStepDecalFadeOutDuration_Offset;

	private static bool FoliageInteractSoundPriority_IsValid;

	private static int FoliageInteractSoundPriority_Offset;

	private static FFieldAddress FoliageInteractSoundPriority_PropertyAddress;

	private static bool BeImmobilizedConfig_IsValid;

	private static int BeImmobilizedConfig_Offset;

	private static bool DA_PELevelConfig_IsValid;

	private static int DA_PELevelConfig_Offset;

	private static bool AutoEnablePreciseDodge_IsValid;

	private static int AutoEnablePreciseDodge_Offset;

	private static FFieldAddress AutoEnablePreciseDodge_PropertyAddress;

	private static bool DefaultAwardsLevel_IsValid;

	private static int DefaultAwardsLevel_Offset;

	private static bool TolerantTimeSeconds_IsValid;

	private static int TolerantTimeSeconds_Offset;

	private static bool Awards_IsValid;

	private static int Awards_Offset;

	private static FFieldAddress Awards_PropertyAddress;

	private TArrayReadWriteMarshaler<PreciseDodgeAwards> Awards_Marshaler;

	private static bool bDebugPreciseDodge_IsValid;

	private static int bDebugPreciseDodge_Offset;

	private static FFieldAddress bDebugPreciseDodge_PropertyAddress;

	private static bool TransStageConfigID_IsValid;

	private static int TransStageConfigID_Offset;

	private static bool TransBackSkillID_IsValid;

	private static int TransBackSkillID_Offset;

	private static bool TransBackDurationTime_IsValid;

	private static int TransBackDurationTime_Offset;

	private static bool AbnormalAttrConfig_IsValid;

	private static int AbnormalAttrConfig_Offset;

	private static bool AbnormalStateImmueList_IsValid;

	private static int AbnormalStateImmueList_Offset;

	private static FFieldAddress AbnormalStateImmueList_PropertyAddress;

	private TArrayReadWriteMarshaler<Birth_AbnormalStateImmueType> AbnormalStateImmueList_Marshaler;

	private static bool BirthAbnormalStateList_IsValid;

	private static int BirthAbnormalStateList_Offset;

	private static FFieldAddress BirthAbnormalStateList_PropertyAddress;

	private TArrayReadWriteMarshaler<Birth_AbnomalState> BirthAbnormalStateList_Marshaler;

	private static bool EffectIDList_SwitchWeaponPose_IsValid;

	private static int EffectIDList_SwitchWeaponPose_Offset;

	private static FFieldAddress EffectIDList_SwitchWeaponPose_PropertyAddress;

	private TArrayReadWriteMarshaler<int> EffectIDList_SwitchWeaponPose_Marshaler;

	private static bool TriggerEffectCoolDown_SwitchWeaponPose_IsValid;

	private static int TriggerEffectCoolDown_SwitchWeaponPose_Offset;

	private static bool CostDMG_StartHeight_IsValid;

	private static int CostDMG_StartHeight_Offset;

	private static bool OverHeight_DmgAdditive_INV10000_IsValid;

	private static int OverHeight_DmgAdditive_INV10000_Offset;

	private static bool FallDmg_DmgMax_INV10000_IsValid;

	private static int FallDmg_DmgMax_INV10000_Offset;

	private static bool BaseDmg_INV10000_IsValid;

	private static int BaseDmg_INV10000_Offset;

	private static bool FallingSafeTime_IsValid;

	private static int FallingSafeTime_Offset;

	private static bool LandCamShakeConfig_IsValid;

	private static int LandCamShakeConfig_Offset;

	private static bool EnableDodge_InFalling_IsValid;

	private static int EnableDodge_InFalling_Offset;

	private static FFieldAddress EnableDodge_InFalling_PropertyAddress;

	private static bool CanDodge_Distance_IsValid;

	private static int CanDodge_Distance_Offset;

	private static bool Dodge_DmgMul_IsValid;

	private static int Dodge_DmgMul_Offset;

	private static bool EnableFloorDistanceCheck_IsValid;

	private static int EnableFloorDistanceCheck_Offset;

	private static FFieldAddress EnableFloorDistanceCheck_PropertyAddress;

	private static bool bSaveInitData_IsValid;

	private static int bSaveInitData_Offset;

	private static FFieldAddress bSaveInitData_PropertyAddress;

	private static bool ActorResetType_IsValid;

	private static int ActorResetType_Offset;

	private static FFieldAddress ActorResetType_PropertyAddress;

	private static bool bEnableImpactAction_IsValid;

	private static int bEnableImpactAction_Offset;

	private static FFieldAddress bEnableImpactAction_PropertyAddress;

	private static bool EnableImplactCalculationParameter_IsValid;

	private static int EnableImplactCalculationParameter_Offset;

	private static bool EnableImpactActionHeightDiff_IsValid;

	private static int EnableImpactActionHeightDiff_Offset;

	private static bool EnableImpactAnimThreshold_IsValid;

	private static int EnableImpactAnimThreshold_Offset;

	private static bool LeftAngleSplitLine_IsValid;

	private static int LeftAngleSplitLine_Offset;

	private static bool MiddleLeftAngleSplitLine_IsValid;

	private static int MiddleLeftAngleSplitLine_Offset;

	private static bool MiddleRightAngleSplitLine_IsValid;

	private static int MiddleRightAngleSplitLine_Offset;

	private static bool RightAngleSplitLine_IsValid;

	private static int RightAngleSplitLine_Offset;

	private static bool ForwardImpactActionAnim_IsValid;

	private static int ForwardImpactActionAnim_Offset;

	private static bool LeftSideImpactActionAnim_IsValid;

	private static int LeftSideImpactActionAnim_Offset;

	private static bool RightSideImpactActionAnim_IsValid;

	private static int RightSideImpactActionAnim_Offset;

	private static bool InteractiveUnitID_IsValid;

	private static int InteractiveUnitID_Offset;

	private static bool DefalutInteractiveGroupID_IsValid;

	private static int DefalutInteractiveGroupID_Offset;

	private static bool ShopID_IsValid;

	private static int ShopID_Offset;

	private static bool InteractFuncList_IsValid;

	private static int InteractFuncList_Offset;

	private static FFieldAddress InteractFuncList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> InteractFuncList_Marshaler;

	private static bool RewardDropID_IsValid;

	private static int RewardDropID_Offset;

	private static bool InteractAnchorOverride_IsValid;

	private static int InteractAnchorOverride_Offset;

	private static bool ObjectMaterial_IsValid;

	private static int ObjectMaterial_Offset;

	private static FFieldAddress ObjectMaterial_PropertyAddress;

	private static bool PersistentDataDontResetOnNewGamePlus_IsValid;

	private static int PersistentDataDontResetOnNewGamePlus_Offset;

	private static FFieldAddress PersistentDataDontResetOnNewGamePlus_PropertyAddress;

	private static bool bEnableFlyCtrl_IsValid;

	private static int bEnableFlyCtrl_Offset;

	private static FFieldAddress bEnableFlyCtrl_PropertyAddress;

	private static bool CheckInterval_IsValid;

	private static int CheckInterval_Offset;

	private static bool TraceIgnoreActorTags_IsValid;

	private static int TraceIgnoreActorTags_Offset;

	private static FFieldAddress TraceIgnoreActorTags_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> TraceIgnoreActorTags_Marshaler;

	private static bool FlyHeightMin_IsValid;

	private static int FlyHeightMin_Offset;

	private static bool FlyHeightMax_IsValid;

	private static int FlyHeightMax_Offset;

	private static bool FlyHeightMaxAbs_IsValid;

	private static int FlyHeightMaxAbs_Offset;

	private static bool PushUpImpulse_IsValid;

	private static int PushUpImpulse_Offset;

	private static bool PushDownImpulse_IsValid;

	private static int PushDownImpulse_Offset;

	private static bool bLockZ_IsValid;

	private static int bLockZ_Offset;

	private static FFieldAddress bLockZ_PropertyAddress;

	private static bool bPrintHitActor_IsValid;

	private static int bPrintHitActor_Offset;

	private static FFieldAddress bPrintHitActor_PropertyAddress;

	private static bool DefaultComboGraphIndex_IsValid;

	private static int DefaultComboGraphIndex_Offset;

	private static bool ComboGraphTemplates_IsValid;

	private static int ComboGraphTemplates_Offset;

	private static FFieldAddress ComboGraphTemplates_PropertyAddress;

	private TArrayReadWriteMarshaler<UCalliopeAsset> ComboGraphTemplates_Marshaler;

	private static bool ComboGraphTemplatesPath_IsValid;

	private static int ComboGraphTemplatesPath_Offset;

	private static FFieldAddress ComboGraphTemplatesPath_PropertyAddress;

	private TArrayReadWriteMarshaler<string> ComboGraphTemplatesPath_Marshaler;

	private static bool bEnableDebugComboGraph_IsValid;

	private static int bEnableDebugComboGraph_Offset;

	private static FFieldAddress bEnableDebugComboGraph_PropertyAddress;

	private static bool bEnableTurretControl_IsValid;

	private static int bEnableTurretControl_Offset;

	private static FFieldAddress bEnableTurretControl_PropertyAddress;

	private static bool TurretTurnTriggerYaw_IsValid;

	private static int TurretTurnTriggerYaw_Offset;

	private static bool TurretTurnDelay_IsValid;

	private static int TurretTurnDelay_Offset;

	private static bool TurretTurnBlendTime_IsValid;

	private static int TurretTurnBlendTime_Offset;

	private static bool CameraGraphClass_IsValid;

	private static int CameraGraphClass_Offset;

	private static bool bCanAsPerformer_IsValid;

	private static int bCanAsPerformer_Offset;

	private static FFieldAddress bCanAsPerformer_PropertyAddress;

	private static bool bBowWhenAfterShow_IsValid;

	private static int bBowWhenAfterShow_Offset;

	private static FFieldAddress bBowWhenAfterShow_PropertyAddress;

	private static bool bWaitingPerformer_IsValid;

	private static int bWaitingPerformer_Offset;

	private static FFieldAddress bWaitingPerformer_PropertyAddress;

	private static bool bWaitingWhenReturnHome_IsValid;

	private static int bWaitingWhenReturnHome_Offset;

	private static FFieldAddress bWaitingWhenReturnHome_PropertyAddress;

	private static bool bStandingWaiting_IsValid;

	private static int bStandingWaiting_Offset;

	private static FFieldAddress bStandingWaiting_PropertyAddress;

	private static bool bUseSceneItemPosition_IsValid;

	private static int bUseSceneItemPosition_Offset;

	private static FFieldAddress bUseSceneItemPosition_PropertyAddress;

	private static bool WaitingLocationItemTag_IsValid;

	private static int WaitingLocationItemTag_Offset;

	private static bool WaitingLocation_IsValid;

	private static int WaitingLocation_Offset;

	private static bool WaitingRotation_IsValid;

	private static int WaitingRotation_Offset;

	private static bool WaitingAnim_IsValid;

	private static int WaitingAnim_Offset;

	private static bool WaitingStateConfig_IsValid;

	private static int WaitingStateConfig_Offset;

	private static bool PreShowStateConfig_IsValid;

	private static int PreShowStateConfig_Offset;

	private static bool ShowingStateConfig_IsValid;

	private static int ShowingStateConfig_Offset;

	private static bool NPCInfoID_IsValid;

	private static int NPCInfoID_Offset;

	private static bool bCanAsNPC_IsValid;

	private static int bCanAsNPC_Offset;

	private static FFieldAddress bCanAsNPC_PropertyAddress;

	private static bool OverrideAnimConfig_IsValid;

	private static int OverrideAnimConfig_Offset;

	private static bool bCanAsFollowPartner_IsValid;

	private static int bCanAsFollowPartner_Offset;

	private static FFieldAddress bCanAsFollowPartner_PropertyAddress;

	private static bool TouchWallFeedBack_EnableDebug_IsValid;

	private static int TouchWallFeedBack_EnableDebug_Offset;

	private static FFieldAddress TouchWallFeedBack_EnableDebug_PropertyAddress;

	private static bool TouchWallFeedBack_TraceLength_IsValid;

	private static int TouchWallFeedBack_TraceLength_Offset;

	private static bool TouchWallFeedBack_SpeedThreshold_IsValid;

	private static int TouchWallFeedBack_SpeedThreshold_Offset;

	private static bool HitDynamicObstacle_ProtectTime_IsValid;

	private static int HitDynamicObstacle_ProtectTime_Offset;

	private static bool CliffUnbalance_SpeedThreshold_IsValid;

	private static int CliffUnbalance_SpeedThreshold_Offset;

	private static bool CliffUnbalanceAMConfig_IsValid;

	private static int CliffUnbalanceAMConfig_Offset;

	private static bool BossBarObserveTamerList_IsValid;

	private static int BossBarObserveTamerList_Offset;

	private static FFieldAddress BossBarObserveTamerList_PropertyAddress;

	private TArrayReadWriteMarshaler<FGsActorGuidReference> BossBarObserveTamerList_Marshaler;

	private static bool HatchConfigInfo_IsValid;

	private static int HatchConfigInfo_Offset;

	private static bool PermanentWindMotorsDataAsset_IsValid;

	private static int PermanentWindMotorsDataAsset_Offset;

	private static bool bDisableDataConvert_IsValid;

	private static int bDisableDataConvert_Offset;

	private static FFieldAddress bDisableDataConvert_PropertyAddress;

	private static bool PreSaveCS_IsValid;

	private static IntPtr PreSaveCS_FunctionAddress;

	private static int PreSaveCS_ParamsSize;

	[BlueprintReadWrite]
	[Category("AI")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:GroupAIBPConfig")]
	public FGroupAIBPConfig GroupAIBPConfig
	{
		get
		{
			CheckDestroyed();
			if (!GroupAIBPConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:GroupAIBPConfig");
				return default(FGroupAIBPConfig);
			}
			return FGroupAIBPConfig.FromNative(IntPtr.Add(base.Address, GroupAIBPConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GroupAIBPConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:GroupAIBPConfig");
			}
			else
			{
				FGroupAIBPConfig.ToNative(IntPtr.Add(base.Address, GroupAIBPConfig_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("AI")]
	[UProperty]
	[DisplayName("CBG模板ID")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:BehaviorGraphTemplateID")]
	public int BehaviorGraphTemplateID
	{
		get
		{
			CheckDestroyed();
			if (!BehaviorGraphTemplateID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:BehaviorGraphTemplateID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BehaviorGraphTemplateID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BehaviorGraphTemplateID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:BehaviorGraphTemplateID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BehaviorGraphTemplateID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("AI")]
	[DisplayName("CDG模板ID")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:DialogueGraphTemplateID")]
	public int DialogueGraphTemplateID
	{
		get
		{
			CheckDestroyed();
			if (!DialogueGraphTemplateID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:DialogueGraphTemplateID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DialogueGraphTemplateID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DialogueGraphTemplateID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:DialogueGraphTemplateID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DialogueGraphTemplateID_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("AI CSG模板")]
	[Category("AI|FSM")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:StateGraphTemplate")]
	public UCalliopeAsset StateGraphTemplate
	{
		get
		{
			CheckDestroyed();
			if (!StateGraphTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:StateGraphTemplate");
				return null;
			}
			return UObjectMarshaler<UCalliopeAsset>.FromNative(IntPtr.Add(base.Address, StateGraphTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StateGraphTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:StateGraphTemplate");
			}
			else
			{
				UObjectMarshaler<UCalliopeAsset>.ToNative(IntPtr.Add(base.Address, StateGraphTemplate_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:StateGraphTemplatePath")]
	public string StateGraphTemplatePath
	{
		get
		{
			CheckDestroyed();
			if (!StateGraphTemplatePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:StateGraphTemplatePath");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, StateGraphTemplatePath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StateGraphTemplatePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:StateGraphTemplatePath");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, StateGraphTemplatePath_Offset), value);
			}
		}
	}

	[Category("AI|FSM")]
	[DisplayName("其他CSG模板")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:OtherFsmTemplates")]
	public TArrayReadWrite<UCalliopeAsset> OtherFsmTemplates
	{
		get
		{
			CheckDestroyed();
			if (!OtherFsmTemplates_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:OtherFsmTemplates");
				return null;
			}
			if (OtherFsmTemplates_Marshaler == null)
			{
				OtherFsmTemplates_Marshaler = new TArrayReadWriteMarshaler<UCalliopeAsset>(1, OtherFsmTemplates_PropertyAddress, CachedMarshalingDelegates<UCalliopeAsset, UObjectMarshaler<UCalliopeAsset>>.FromNative, CachedMarshalingDelegates<UCalliopeAsset, UObjectMarshaler<UCalliopeAsset>>.ToNative);
			}
			return OtherFsmTemplates_Marshaler.FromNative(IntPtr.Add(base.Address, OtherFsmTemplates_Offset));
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:OtherFsmTemplatesPath")]
	public TArrayReadWrite<string> OtherFsmTemplatesPath
	{
		get
		{
			CheckDestroyed();
			if (!OtherFsmTemplatesPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:OtherFsmTemplatesPath");
				return null;
			}
			if (OtherFsmTemplatesPath_Marshaler == null)
			{
				OtherFsmTemplatesPath_Marshaler = new TArrayReadWriteMarshaler<string>(1, OtherFsmTemplatesPath_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return OtherFsmTemplatesPath_Marshaler.FromNative(IntPtr.Add(base.Address, OtherFsmTemplatesPath_Offset));
		}
	}

	[DisplayName("CSG子状态机替换")]
	[EditAnywhere]
	[UProperty]
	[Category("AI|FSM")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:FsmSubMachineOverride")]
	public TMapReadWrite<FGameplayTag, UCalliopeAsset> FsmSubMachineOverride
	{
		get
		{
			CheckDestroyed();
			if (!FsmSubMachineOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FsmSubMachineOverride");
				return null;
			}
			if (FsmSubMachineOverride_Marshaler == null)
			{
				FsmSubMachineOverride_Marshaler = new TMapReadWriteMarshaler<FGameplayTag, UCalliopeAsset>(1, FsmSubMachineOverride_PropertyAddress, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.FromNative, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.ToNative, CachedMarshalingDelegates<UCalliopeAsset, UObjectMarshaler<UCalliopeAsset>>.FromNative, CachedMarshalingDelegates<UCalliopeAsset, UObjectMarshaler<UCalliopeAsset>>.ToNative);
			}
			return FsmSubMachineOverride_Marshaler.FromNative(IntPtr.Add(base.Address, FsmSubMachineOverride_Offset));
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:FsmSubMachinePathOverride")]
	public TMapReadWrite<FGameplayTag, string> FsmSubMachinePathOverride
	{
		get
		{
			CheckDestroyed();
			if (!FsmSubMachinePathOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FsmSubMachinePathOverride");
				return null;
			}
			if (FsmSubMachinePathOverride_Marshaler == null)
			{
				FsmSubMachinePathOverride_Marshaler = new TMapReadWriteMarshaler<FGameplayTag, string>(1, FsmSubMachinePathOverride_PropertyAddress, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.FromNative, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return FsmSubMachinePathOverride_Marshaler.FromNative(IntPtr.Add(base.Address, FsmSubMachinePathOverride_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("转阶段CSG模板")]
	[Category("AI|FSM")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:PhaseStateGraphTemplate")]
	public UCalliopeAsset PhaseStateGraphTemplate
	{
		get
		{
			CheckDestroyed();
			if (!PhaseStateGraphTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PhaseStateGraphTemplate");
				return null;
			}
			return UObjectMarshaler<UCalliopeAsset>.FromNative(IntPtr.Add(base.Address, PhaseStateGraphTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PhaseStateGraphTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PhaseStateGraphTemplate");
			}
			else
			{
				UObjectMarshaler<UCalliopeAsset>.ToNative(IntPtr.Add(base.Address, PhaseStateGraphTemplate_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:PhaseStateGraphTemplatePath")]
	public string PhaseStateGraphTemplatePath
	{
		get
		{
			CheckDestroyed();
			if (!PhaseStateGraphTemplatePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PhaseStateGraphTemplatePath");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, PhaseStateGraphTemplatePath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PhaseStateGraphTemplatePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PhaseStateGraphTemplatePath");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, PhaseStateGraphTemplatePath_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("废弃|Cooperative")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:EventMap")]
	public TMapReadWrite<string, FGameplayTag> EventMap
	{
		get
		{
			CheckDestroyed();
			if (!EventMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:EventMap");
				return null;
			}
			if (EventMap_Marshaler == null)
			{
				EventMap_Marshaler = new TMapReadWriteMarshaler<string, FGameplayTag>(1, EventMap_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.FromNative, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.ToNative);
			}
			return EventMap_Marshaler.FromNative(IntPtr.Add(base.Address, EventMap_Offset));
		}
	}

	[EditAnywhere]
	[Category("废弃|Cooperative")]
	[DisplayName("协作消息互通管理器")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:BattleSC")]
	public BGUBattleSC BattleSC
	{
		get
		{
			CheckDestroyed();
			if (!BattleSC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:BattleSC");
				return null;
			}
			return UObjectMarshaler<BGUBattleSC>.FromNative(IntPtr.Add(base.Address, BattleSC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BattleSC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:BattleSC");
			}
			else
			{
				UObjectMarshaler<BGUBattleSC>.ToNative(IntPtr.Add(base.Address, BattleSC_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("AI|Cooperative")]
	[DisplayName("监听特定事件")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:SpecificEventListen_BattleSC")]
	public TArrayReadWrite<EBattleCoopReason> SpecificEventListen_BattleSC
	{
		get
		{
			CheckDestroyed();
			if (!SpecificEventListen_BattleSC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:SpecificEventListen_BattleSC");
				return null;
			}
			if (SpecificEventListen_BattleSC_Marshaler == null)
			{
				SpecificEventListen_BattleSC_Marshaler = new TArrayReadWriteMarshaler<EBattleCoopReason>(1, SpecificEventListen_BattleSC_PropertyAddress, CachedMarshalingDelegates<EBattleCoopReason, EnumMarshaler<EBattleCoopReason>>.FromNative, CachedMarshalingDelegates<EBattleCoopReason, EnumMarshaler<EBattleCoopReason>>.ToNative);
			}
			return SpecificEventListen_BattleSC_Marshaler.FromNative(IntPtr.Add(base.Address, SpecificEventListen_BattleSC_Offset));
		}
	}

	[UProperty]
	[Category("AI|Cooperative")]
	[DisplayName("协作消息互通管理器的GUID")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:BattleSC_GUID")]
	public FGameplayTag BattleSC_GUID
	{
		get
		{
			CheckDestroyed();
			if (!BattleSC_GUID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:BattleSC_GUID");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, BattleSC_GUID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BattleSC_GUID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:BattleSC_GUID");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, BattleSC_GUID_Offset), value);
			}
		}
	}

	[Category("AI|Conversation")]
	[UProperty]
	[DisplayName("进战打断在播的AiConversation")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:InterruptAiConversationWhenIntoBattle")]
	public bool InterruptAiConversationWhenIntoBattle
	{
		get
		{
			CheckDestroyed();
			if (!InterruptAiConversationWhenIntoBattle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:InterruptAiConversationWhenIntoBattle");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InterruptAiConversationWhenIntoBattle_Offset), 0, InterruptAiConversationWhenIntoBattle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InterruptAiConversationWhenIntoBattle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:InterruptAiConversationWhenIntoBattle");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InterruptAiConversationWhenIntoBattle_Offset), 0, InterruptAiConversationWhenIntoBattle_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("AI|Conversation")]
	[UProperty]
	[DisplayName("可能触发的Ai对话事件ID列表")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:AIConversationEventIDList")]
	public TArrayReadWrite<int> AIConversationEventIDList
	{
		get
		{
			CheckDestroyed();
			if (!AIConversationEventIDList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:AIConversationEventIDList");
				return null;
			}
			if (AIConversationEventIDList_Marshaler == null)
			{
				AIConversationEventIDList_Marshaler = new TArrayReadWriteMarshaler<int>(1, AIConversationEventIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return AIConversationEventIDList_Marshaler.FromNative(IntPtr.Add(base.Address, AIConversationEventIDList_Offset));
		}
	}

	[BlueprintReadWrite]
	[Category("AI|Conversation")]
	[DisplayName("事实数据注册")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:AIConversationFacts")]
	public TArrayReadWrite<FAiConversationFact> AIConversationFacts
	{
		get
		{
			CheckDestroyed();
			if (!AIConversationFacts_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:AIConversationFacts");
				return null;
			}
			if (AIConversationFacts_Marshaler == null)
			{
				AIConversationFacts_Marshaler = new TArrayReadWriteMarshaler<FAiConversationFact>(1, AIConversationFacts_PropertyAddress, CachedMarshalingDelegates<FAiConversationFact, FAiConversationFact>.FromNative, CachedMarshalingDelegates<FAiConversationFact, FAiConversationFact>.ToNative);
			}
			return AIConversationFacts_Marshaler.FromNative(IntPtr.Add(base.Address, AIConversationFacts_Offset));
		}
	}

	[Category("AI")]
	[DisplayName("恐吓相关配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:IntimidateBPConfig")]
	public FIntimidateBPConfig IntimidateBPConfig
	{
		get
		{
			CheckDestroyed();
			if (!IntimidateBPConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:IntimidateBPConfig");
				return default(FIntimidateBPConfig);
			}
			return FIntimidateBPConfig.FromNative(IntPtr.Add(base.Address, IntimidateBPConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IntimidateBPConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:IntimidateBPConfig");
			}
			else
			{
				FIntimidateBPConfig.ToNative(IntPtr.Add(base.Address, IntimidateBPConfig_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("AI")]
	[DisplayName("反击格挡配置")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:GSArmorSettingInBP")]
	public FGSArmorSettingInBP GSArmorSettingInBP
	{
		get
		{
			CheckDestroyed();
			if (!GSArmorSettingInBP_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:GSArmorSettingInBP");
				return default(FGSArmorSettingInBP);
			}
			return FGSArmorSettingInBP.FromNative(IntPtr.Add(base.Address, GSArmorSettingInBP_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSArmorSettingInBP_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:GSArmorSettingInBP");
			}
			else
			{
				FGSArmorSettingInBP.ToNative(IntPtr.Add(base.Address, GSArmorSettingInBP_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("唤醒相关配置")]
	[Category("AI")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:WakeUpConfig")]
	public FGSWakeUpConfig WakeUpConfig
	{
		get
		{
			CheckDestroyed();
			if (!WakeUpConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:WakeUpConfig");
				return default(FGSWakeUpConfig);
			}
			return FGSWakeUpConfig.FromNative(IntPtr.Add(base.Address, WakeUpConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WakeUpConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:WakeUpConfig");
			}
			else
			{
				FGSWakeUpConfig.ToNative(IntPtr.Add(base.Address, WakeUpConfig_Offset), value);
			}
		}
	}

	[DisplayName("SequenceID")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("AI|Sequence后切换Leisure")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:ReplaceLeisureSequenceID")]
	public int ReplaceLeisureSequenceID
	{
		get
		{
			CheckDestroyed();
			if (!ReplaceLeisureSequenceID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:ReplaceLeisureSequenceID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ReplaceLeisureSequenceID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ReplaceLeisureSequenceID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:ReplaceLeisureSequenceID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ReplaceLeisureSequenceID_Offset), value);
			}
		}
	}

	[DisplayName("Leisure动画")]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "ReplaceLeisureSequenceID > 0")]
	[Category("AI|Sequence后切换Leisure")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:LeisureAnimAfterSequence")]
	public UAnimMontage LeisureAnimAfterSequence
	{
		get
		{
			CheckDestroyed();
			if (!LeisureAnimAfterSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:LeisureAnimAfterSequence");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, LeisureAnimAfterSequence_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeisureAnimAfterSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:LeisureAnimAfterSequence");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, LeisureAnimAfterSequence_Offset), value);
			}
		}
	}

	[Category("AI|Sequence后切换Leisure")]
	[UProperty]
	[UMeta(MDProp.EditCondition, "ReplaceLeisureSequenceID > 0")]
	[DisplayName("OnFightSkillID")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:OnFightSkillIDAfterSequence")]
	public int OnFightSkillIDAfterSequence
	{
		get
		{
			CheckDestroyed();
			if (!OnFightSkillIDAfterSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:OnFightSkillIDAfterSequence");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, OnFightSkillIDAfterSequence_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OnFightSkillIDAfterSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:OnFightSkillIDAfterSequence");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, OnFightSkillIDAfterSequence_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("AI|Sequence后切换Leisure")]
	[DisplayName("后侧OnFightSkillID")]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "ReplaceLeisureSequenceID > 0")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:OnFightSkillIDBackAfterSequence")]
	public int OnFightSkillIDBackAfterSequence
	{
		get
		{
			CheckDestroyed();
			if (!OnFightSkillIDBackAfterSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:OnFightSkillIDBackAfterSequence");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, OnFightSkillIDBackAfterSequence_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OnFightSkillIDBackAfterSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:OnFightSkillIDBackAfterSequence");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, OnFightSkillIDBackAfterSequence_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Category("AI|Sequence后切换Leisure")]
	[UMeta(MDProp.EditCondition, "ReplaceLeisureSequenceID > 0")]
	[DisplayName("左侧OnFightSkillID")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:OnFightSkillIDLeftAfterSequence")]
	public int OnFightSkillIDLeftAfterSequence
	{
		get
		{
			CheckDestroyed();
			if (!OnFightSkillIDLeftAfterSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:OnFightSkillIDLeftAfterSequence");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, OnFightSkillIDLeftAfterSequence_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OnFightSkillIDLeftAfterSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:OnFightSkillIDLeftAfterSequence");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, OnFightSkillIDLeftAfterSequence_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("右侧OnFightSkillID")]
	[Category("AI|Sequence后切换Leisure")]
	[UMeta(MDProp.EditCondition, "ReplaceLeisureSequenceID > 0")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:OnFightSkillIDRightAfterSequence")]
	public int OnFightSkillIDRightAfterSequence
	{
		get
		{
			CheckDestroyed();
			if (!OnFightSkillIDRightAfterSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:OnFightSkillIDRightAfterSequence");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, OnFightSkillIDRightAfterSequence_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OnFightSkillIDRightAfterSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:OnFightSkillIDRightAfterSequence");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, OnFightSkillIDRightAfterSequence_Offset), value);
			}
		}
	}

	[VisibleAnywhere]
	[Category("AI|Debug")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:AIState")]
	public int AIState
	{
		get
		{
			CheckDestroyed();
			if (!AIState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:AIState");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AIState_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AIState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:AIState");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AIState_Offset), value);
			}
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[Category("AI|Debug")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:LastSkillBlockReason")]
	public int LastSkillBlockReason
	{
		get
		{
			CheckDestroyed();
			if (!LastSkillBlockReason_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:LastSkillBlockReason");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LastSkillBlockReason_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LastSkillBlockReason_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:LastSkillBlockReason");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LastSkillBlockReason_Offset), value);
			}
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[Category("AI|Debug")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:UserHandle")]
	public int UserHandle
	{
		get
		{
			CheckDestroyed();
			if (!UserHandle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:UserHandle");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, UserHandle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UserHandle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:UserHandle");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, UserHandle_Offset), value);
			}
		}
	}

	[Category("AI|Debug")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bLogVerbose")]
	public bool bLogVerbose
	{
		get
		{
			CheckDestroyed();
			if (!bLogVerbose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bLogVerbose");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLogVerbose_Offset), 0, bLogVerbose_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLogVerbose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bLogVerbose");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLogVerbose_Offset), 0, bLogVerbose_PropertyAddress.Address, value);
			}
		}
	}

	[Category("AI|Debug")]
	[EditAnywhere]
	[UProperty]
	[DisplayName("是否启用感知预览")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bEnablePerceptionPreview")]
	public bool bEnablePerceptionPreview
	{
		get
		{
			CheckDestroyed();
			if (!bEnablePerceptionPreview_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bEnablePerceptionPreview");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnablePerceptionPreview_Offset), 0, bEnablePerceptionPreview_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnablePerceptionPreview_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bEnablePerceptionPreview");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnablePerceptionPreview_Offset), 0, bEnablePerceptionPreview_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("AI|Debug")]
	[DisplayName("是否显示预览贴花")]
	[Tooltip("若为false，则只会显示预览线框")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bEnablePerceptionPreviewOutlineOnly")]
	public bool bEnablePerceptionPreviewOutlineOnly
	{
		get
		{
			CheckDestroyed();
			if (!bEnablePerceptionPreviewOutlineOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bEnablePerceptionPreviewOutlineOnly");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnablePerceptionPreviewOutlineOnly_Offset), 0, bEnablePerceptionPreviewOutlineOnly_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnablePerceptionPreviewOutlineOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bEnablePerceptionPreviewOutlineOnly");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnablePerceptionPreviewOutlineOnly_Offset), 0, bEnablePerceptionPreviewOutlineOnly_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("AI|Debug")]
	[DisplayName("是否显示唤醒链范围")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableWakeUpLinkRangeDebug")]
	public bool bEnableWakeUpLinkRangeDebug
	{
		get
		{
			CheckDestroyed();
			if (!bEnableWakeUpLinkRangeDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableWakeUpLinkRangeDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableWakeUpLinkRangeDebug_Offset), 0, bEnableWakeUpLinkRangeDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableWakeUpLinkRangeDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableWakeUpLinkRangeDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableWakeUpLinkRangeDebug_Offset), 0, bEnableWakeUpLinkRangeDebug_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("Move|Hard Move")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableHardMove")]
	public bool bEnableHardMove
	{
		get
		{
			CheckDestroyed();
			if (!bEnableHardMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableHardMove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableHardMove_Offset), 0, bEnableHardMove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableHardMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableHardMove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableHardMove_Offset), 0, bEnableHardMove_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Move|Hard Move")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:WindyMoveAffectedAngleForward")]
	public float WindyMoveAffectedAngleForward
	{
		get
		{
			CheckDestroyed();
			if (!WindyMoveAffectedAngleForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:WindyMoveAffectedAngleForward");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WindyMoveAffectedAngleForward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WindyMoveAffectedAngleForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:WindyMoveAffectedAngleForward");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WindyMoveAffectedAngleForward_Offset), value);
			}
		}
	}

	[Category("Move|Hard Move")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:WindyMoveForwardBuffID")]
	public int WindyMoveForwardBuffID
	{
		get
		{
			CheckDestroyed();
			if (!WindyMoveForwardBuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:WindyMoveForwardBuffID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, WindyMoveForwardBuffID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WindyMoveForwardBuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:WindyMoveForwardBuffID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, WindyMoveForwardBuffID_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Move|Hard Move")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:WindyMoveBackwardBuffID")]
	public int WindyMoveBackwardBuffID
	{
		get
		{
			CheckDestroyed();
			if (!WindyMoveBackwardBuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:WindyMoveBackwardBuffID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, WindyMoveBackwardBuffID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WindyMoveBackwardBuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:WindyMoveBackwardBuffID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, WindyMoveBackwardBuffID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Move|Hard Move")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:WindyMoveEnterSkill")]
	public int WindyMoveEnterSkill
	{
		get
		{
			CheckDestroyed();
			if (!WindyMoveEnterSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:WindyMoveEnterSkill");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, WindyMoveEnterSkill_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WindyMoveEnterSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:WindyMoveEnterSkill");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, WindyMoveEnterSkill_Offset), value);
			}
		}
	}

	[Category("Move|Hard Move")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:MuddyMoveEnterSkill")]
	public int MuddyMoveEnterSkill
	{
		get
		{
			CheckDestroyed();
			if (!MuddyMoveEnterSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MuddyMoveEnterSkill");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MuddyMoveEnterSkill_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MuddyMoveEnterSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MuddyMoveEnterSkill");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MuddyMoveEnterSkill_Offset), value);
			}
		}
	}

	[Category("Move|Hard Move")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:FrozenMoveEnterSkill")]
	public int FrozenMoveEnterSkill
	{
		get
		{
			CheckDestroyed();
			if (!FrozenMoveEnterSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FrozenMoveEnterSkill");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, FrozenMoveEnterSkill_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FrozenMoveEnterSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FrozenMoveEnterSkill");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, FrozenMoveEnterSkill_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Move|Hard Move")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:SpiderSilkyMoveEnterSkill")]
	public int SpiderSilkyMoveEnterSkill
	{
		get
		{
			CheckDestroyed();
			if (!SpiderSilkyMoveEnterSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:SpiderSilkyMoveEnterSkill");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SpiderSilkyMoveEnterSkill_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpiderSilkyMoveEnterSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:SpiderSilkyMoveEnterSkill");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SpiderSilkyMoveEnterSkill_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Move|Hard Move")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:WindyMoveForwardBlendAnim")]
	public UAnimSequenceBase WindyMoveForwardBlendAnim
	{
		get
		{
			CheckDestroyed();
			if (!WindyMoveForwardBlendAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:WindyMoveForwardBlendAnim");
				return null;
			}
			return UObjectMarshaler<UAnimSequenceBase>.FromNative(IntPtr.Add(base.Address, WindyMoveForwardBlendAnim_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WindyMoveForwardBlendAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:WindyMoveForwardBlendAnim");
			}
			else
			{
				UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(base.Address, WindyMoveForwardBlendAnim_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Move|Patrol")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:PatrolType")]
	public EPatrolType PatrolType
	{
		get
		{
			CheckDestroyed();
			if (!PatrolType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PatrolType");
				return EPatrolType.None;
			}
			return EnumMarshaler<EPatrolType>.FromNative(IntPtr.Add(base.Address, PatrolType_Offset), 0, PatrolType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PatrolType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PatrolType");
			}
			else
			{
				EnumMarshaler<EPatrolType>.ToNative(IntPtr.Add(base.Address, PatrolType_Offset), 0, PatrolType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Move|Patrol")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bDisableRestartOnLeaveFight")]
	public bool bDisableRestartOnLeaveFight
	{
		get
		{
			CheckDestroyed();
			if (!bDisableRestartOnLeaveFight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bDisableRestartOnLeaveFight");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDisableRestartOnLeaveFight_Offset), 0, bDisableRestartOnLeaveFight_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDisableRestartOnLeaveFight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bDisableRestartOnLeaveFight");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDisableRestartOnLeaveFight_Offset), 0, bDisableRestartOnLeaveFight_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Move|Patrol")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bDisableRestartOnReset")]
	public bool bDisableRestartOnReset
	{
		get
		{
			CheckDestroyed();
			if (!bDisableRestartOnReset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bDisableRestartOnReset");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDisableRestartOnReset_Offset), 0, bDisableRestartOnReset_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDisableRestartOnReset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bDisableRestartOnReset");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDisableRestartOnReset_Offset), 0, bDisableRestartOnReset_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Move|Patrol")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:MotionMatchingState")]
	public EState_MM MotionMatchingState
	{
		get
		{
			CheckDestroyed();
			if (!MotionMatchingState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MotionMatchingState");
				return EState_MM.None;
			}
			return EnumMarshaler<EState_MM>.FromNative(IntPtr.Add(base.Address, MotionMatchingState_Offset), 0, MotionMatchingState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MotionMatchingState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MotionMatchingState");
			}
			else
			{
				EnumMarshaler<EState_MM>.ToNative(IntPtr.Add(base.Address, MotionMatchingState_Offset), 0, MotionMatchingState_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Move|Patrol")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:FindPathMoveType")]
	public EBGUMoveAIType FindPathMoveType
	{
		get
		{
			CheckDestroyed();
			if (!FindPathMoveType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FindPathMoveType");
				return EBGUMoveAIType.None;
			}
			return EnumMarshaler<EBGUMoveAIType>.FromNative(IntPtr.Add(base.Address, FindPathMoveType_Offset), 0, FindPathMoveType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FindPathMoveType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FindPathMoveType");
			}
			else
			{
				EnumMarshaler<EBGUMoveAIType>.ToNative(IntPtr.Add(base.Address, FindPathMoveType_Offset), 0, FindPathMoveType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Move|Patrol")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:PatrolMoveSpeedType")]
	public EAIMoveSpeedType PatrolMoveSpeedType
	{
		get
		{
			CheckDestroyed();
			if (!PatrolMoveSpeedType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PatrolMoveSpeedType");
				return EAIMoveSpeedType.JOG;
			}
			return EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(base.Address, PatrolMoveSpeedType_Offset), 0, PatrolMoveSpeedType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PatrolMoveSpeedType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PatrolMoveSpeedType");
			}
			else
			{
				EnumMarshaler<EAIMoveSpeedType>.ToNative(IntPtr.Add(base.Address, PatrolMoveSpeedType_Offset), 0, PatrolMoveSpeedType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Move|Patrol")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:EnablePatrolOnStart")]
	public bool EnablePatrolOnStart
	{
		get
		{
			CheckDestroyed();
			if (!EnablePatrolOnStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:EnablePatrolOnStart");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnablePatrolOnStart_Offset), 0, EnablePatrolOnStart_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnablePatrolOnStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:EnablePatrolOnStart");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnablePatrolOnStart_Offset), 0, EnablePatrolOnStart_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Move|Patrol")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:PatrolBuff")]
	public int PatrolBuff
	{
		get
		{
			CheckDestroyed();
			if (!PatrolBuff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PatrolBuff");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PatrolBuff_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PatrolBuff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PatrolBuff");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PatrolBuff_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Move|Patrol")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:ABPSettingForPatrol")]
	public BGWDataAsset_AbpHumanoidSetting ABPSettingForPatrol
	{
		get
		{
			CheckDestroyed();
			if (!ABPSettingForPatrol_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:ABPSettingForPatrol");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_AbpHumanoidSetting>.FromNative(IntPtr.Add(base.Address, ABPSettingForPatrol_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ABPSettingForPatrol_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:ABPSettingForPatrol");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_AbpHumanoidSetting>.ToNative(IntPtr.Add(base.Address, ABPSettingForPatrol_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Move|Patrol")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:MoveAcceptableRadius")]
	public float MoveAcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!MoveAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MoveAcceptableRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MoveAcceptableRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MoveAcceptableRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MoveAcceptableRadius_Offset), value);
			}
		}
	}

	[Tooltip("在第一次开始巡逻前播放AM的概率百分比，填1~100以内的数")]
	[UProperty]
	[EditAnywhere]
	[Category("Move|Patrol")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:StartWaitAMProbability")]
	public float StartWaitAMProbability
	{
		get
		{
			CheckDestroyed();
			if (!StartWaitAMProbability_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:StartWaitAMProbability");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StartWaitAMProbability_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartWaitAMProbability_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:StartWaitAMProbability");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StartWaitAMProbability_Offset), value);
			}
		}
	}

	[UProperty]
	[Tooltip("在第一次开始巡逻前播放的AM，随机选择")]
	[Category("Move|Patrol")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:StartWaitAM")]
	public TArrayReadWrite<UAnimMontage> StartWaitAM
	{
		get
		{
			CheckDestroyed();
			if (!StartWaitAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:StartWaitAM");
				return null;
			}
			if (StartWaitAM_Marshaler == null)
			{
				StartWaitAM_Marshaler = new TArrayReadWriteMarshaler<UAnimMontage>(1, StartWaitAM_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative);
			}
			return StartWaitAM_Marshaler.FromNative(IntPtr.Add(base.Address, StartWaitAM_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Move|Patrol")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:TurnSkillConfig")]
	public FGSTurnSkillConfig TurnSkillConfig
	{
		get
		{
			CheckDestroyed();
			if (!TurnSkillConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TurnSkillConfig");
				return default(FGSTurnSkillConfig);
			}
			return FGSTurnSkillConfig.FromNative(IntPtr.Add(base.Address, TurnSkillConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TurnSkillConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TurnSkillConfig");
			}
			else
			{
				FGSTurnSkillConfig.ToNative(IntPtr.Add(base.Address, TurnSkillConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Move|Patrol")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:RandomPatrolConfig")]
	public FRandomPatrolConfig RandomPatrolConfig
	{
		get
		{
			CheckDestroyed();
			if (!RandomPatrolConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:RandomPatrolConfig");
				return default(FRandomPatrolConfig);
			}
			return FRandomPatrolConfig.FromNative(IntPtr.Add(base.Address, RandomPatrolConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RandomPatrolConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:RandomPatrolConfig");
			}
			else
			{
				FRandomPatrolConfig.ToNative(IntPtr.Add(base.Address, RandomPatrolConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Move|Patrol")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:SplinePatrolConfig")]
	public FGSSplinePatrolConfig SplinePatrolConfig
	{
		get
		{
			CheckDestroyed();
			if (!SplinePatrolConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:SplinePatrolConfig");
				return default(FGSSplinePatrolConfig);
			}
			return FGSSplinePatrolConfig.FromNative(IntPtr.Add(base.Address, SplinePatrolConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SplinePatrolConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:SplinePatrolConfig");
			}
			else
			{
				FGSSplinePatrolConfig.ToNative(IntPtr.Add(base.Address, SplinePatrolConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Move|Patrol")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:MultiSplinePatrolConfig")]
	public FGSMultiSplinePatrolConfig MultiSplinePatrolConfig
	{
		get
		{
			CheckDestroyed();
			if (!MultiSplinePatrolConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MultiSplinePatrolConfig");
				return default(FGSMultiSplinePatrolConfig);
			}
			return FGSMultiSplinePatrolConfig.FromNative(IntPtr.Add(base.Address, MultiSplinePatrolConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MultiSplinePatrolConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MultiSplinePatrolConfig");
			}
			else
			{
				FGSMultiSplinePatrolConfig.ToNative(IntPtr.Add(base.Address, MultiSplinePatrolConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Move|Patrol")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:LeisureConfig")]
	public FGSLeisureConfig LeisureConfig
	{
		get
		{
			CheckDestroyed();
			if (!LeisureConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:LeisureConfig");
				return default(FGSLeisureConfig);
			}
			return FGSLeisureConfig.FromNative(IntPtr.Add(base.Address, LeisureConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeisureConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:LeisureConfig");
			}
			else
			{
				FGSLeisureConfig.ToNative(IntPtr.Add(base.Address, LeisureConfig_Offset), value);
			}
		}
	}

	[Category("Move|Patrol")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:FollowPatrolConfig")]
	public FFollowPatrolConfig FollowPatrolConfig
	{
		get
		{
			CheckDestroyed();
			if (!FollowPatrolConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FollowPatrolConfig");
				return default(FFollowPatrolConfig);
			}
			return FFollowPatrolConfig.FromNative(IntPtr.Add(base.Address, FollowPatrolConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FollowPatrolConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FollowPatrolConfig");
			}
			else
			{
				FFollowPatrolConfig.ToNative(IntPtr.Add(base.Address, FollowPatrolConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Move|Patrol")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:GroupPatrolConfig")]
	public FGSGroupPatrolConfig GroupPatrolConfig
	{
		get
		{
			CheckDestroyed();
			if (!GroupPatrolConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:GroupPatrolConfig");
				return default(FGSGroupPatrolConfig);
			}
			return FGSGroupPatrolConfig.FromNative(IntPtr.Add(base.Address, GroupPatrolConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GroupPatrolConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:GroupPatrolConfig");
			}
			else
			{
				FGSGroupPatrolConfig.ToNative(IntPtr.Add(base.Address, GroupPatrolConfig_Offset), value);
			}
		}
	}

	[Category("Move|PhysicsTransform")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableMovePhysicsTransform")]
	public bool bEnableMovePhysicsTransform
	{
		get
		{
			CheckDestroyed();
			if (!bEnableMovePhysicsTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableMovePhysicsTransform");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableMovePhysicsTransform_Offset), 0, bEnableMovePhysicsTransform_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableMovePhysicsTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableMovePhysicsTransform");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableMovePhysicsTransform_Offset), 0, bEnableMovePhysicsTransform_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Move|PhysicsTransform")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:PhysicsTransformGravityAddValue")]
	public float PhysicsTransformGravityAddValue
	{
		get
		{
			CheckDestroyed();
			if (!PhysicsTransformGravityAddValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PhysicsTransformGravityAddValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PhysicsTransformGravityAddValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PhysicsTransformGravityAddValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PhysicsTransformGravityAddValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PhysicsTransformGravityAddValue_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Move|PhysicsTransform")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:RotationTypeDurningPhysicsState")]
	public EMovePhysicsRotationType RotationTypeDurningPhysicsState
	{
		get
		{
			CheckDestroyed();
			if (!RotationTypeDurningPhysicsState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:RotationTypeDurningPhysicsState");
				return EMovePhysicsRotationType.None;
			}
			return EnumMarshaler<EMovePhysicsRotationType>.FromNative(IntPtr.Add(base.Address, RotationTypeDurningPhysicsState_Offset), 0, RotationTypeDurningPhysicsState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RotationTypeDurningPhysicsState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:RotationTypeDurningPhysicsState");
			}
			else
			{
				EnumMarshaler<EMovePhysicsRotationType>.ToNative(IntPtr.Add(base.Address, RotationTypeDurningPhysicsState_Offset), 0, RotationTypeDurningPhysicsState_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Move|Glide")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:GlideSlopeEdgeAngle")]
	public float GlideSlopeEdgeAngle
	{
		get
		{
			CheckDestroyed();
			if (!GlideSlopeEdgeAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:GlideSlopeEdgeAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GlideSlopeEdgeAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GlideSlopeEdgeAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:GlideSlopeEdgeAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GlideSlopeEdgeAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Move|Glide")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:MaxGlideSpeed")]
	public float MaxGlideSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MaxGlideSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MaxGlideSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxGlideSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxGlideSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MaxGlideSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxGlideSpeed_Offset), value);
			}
		}
	}

	[Category("Move|Glide")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:MinGlideSpeed")]
	public float MinGlideSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MinGlideSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MinGlideSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinGlideSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinGlideSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MinGlideSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinGlideSpeed_Offset), value);
			}
		}
	}

	[Category("Move|Glide")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:MaxSpeedAngle")]
	public float MaxSpeedAngle
	{
		get
		{
			CheckDestroyed();
			if (!MaxSpeedAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MaxSpeedAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxSpeedAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxSpeedAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MaxSpeedAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxSpeedAngle_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Move|Glide")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:MinSpeedAngle")]
	public float MinSpeedAngle
	{
		get
		{
			CheckDestroyed();
			if (!MinSpeedAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MinSpeedAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinSpeedAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinSpeedAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MinSpeedAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinSpeedAngle_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Move|Glide")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:MoveControlReactionSpeed")]
	public float MoveControlReactionSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MoveControlReactionSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MoveControlReactionSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MoveControlReactionSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveControlReactionSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MoveControlReactionSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MoveControlReactionSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Move|Glide")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:MoveControlAddMaxSpeed")]
	public float MoveControlAddMaxSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MoveControlAddMaxSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MoveControlAddMaxSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MoveControlAddMaxSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveControlAddMaxSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MoveControlAddMaxSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MoveControlAddMaxSpeed_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Move|Glide")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:PreventGlideSkillID")]
	public int PreventGlideSkillID
	{
		get
		{
			CheckDestroyed();
			if (!PreventGlideSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PreventGlideSkillID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PreventGlideSkillID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PreventGlideSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PreventGlideSkillID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PreventGlideSkillID_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("Move|Physical")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bEnablePhysicalMove")]
	public bool bEnablePhysicalMove
	{
		get
		{
			CheckDestroyed();
			if (!bEnablePhysicalMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bEnablePhysicalMove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnablePhysicalMove_Offset), 0, bEnablePhysicalMove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnablePhysicalMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bEnablePhysicalMove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnablePhysicalMove_Offset), 0, bEnablePhysicalMove_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Move|Physical")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:PhysicalGravityAddValue")]
	public float PhysicalGravityAddValue
	{
		get
		{
			CheckDestroyed();
			if (!PhysicalGravityAddValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PhysicalGravityAddValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PhysicalGravityAddValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PhysicalGravityAddValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PhysicalGravityAddValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PhysicalGravityAddValue_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Move|Physical")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:PhysicalMoveBuff")]
	public TArrayReadWrite<int> PhysicalMoveBuff
	{
		get
		{
			CheckDestroyed();
			if (!PhysicalMoveBuff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PhysicalMoveBuff");
				return null;
			}
			if (PhysicalMoveBuff_Marshaler == null)
			{
				PhysicalMoveBuff_Marshaler = new TArrayReadWriteMarshaler<int>(1, PhysicalMoveBuff_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return PhysicalMoveBuff_Marshaler.FromNative(IntPtr.Add(base.Address, PhysicalMoveBuff_Offset));
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Move|Physical")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:PhysicalMoveBuffNeedSpeed")]
	public float PhysicalMoveBuffNeedSpeed
	{
		get
		{
			CheckDestroyed();
			if (!PhysicalMoveBuffNeedSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PhysicalMoveBuffNeedSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PhysicalMoveBuffNeedSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PhysicalMoveBuffNeedSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PhysicalMoveBuffNeedSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PhysicalMoveBuffNeedSpeed_Offset), value);
			}
		}
	}

	[Category("Move|Physical")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:PhysicalMoveBuffProtectTime")]
	public float PhysicalMoveBuffProtectTime
	{
		get
		{
			CheckDestroyed();
			if (!PhysicalMoveBuffProtectTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PhysicalMoveBuffProtectTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PhysicalMoveBuffProtectTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PhysicalMoveBuffProtectTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PhysicalMoveBuffProtectTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PhysicalMoveBuffProtectTime_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Move|Physical")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bUseSocketDirection")]
	public bool bUseSocketDirection
	{
		get
		{
			CheckDestroyed();
			if (!bUseSocketDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bUseSocketDirection");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseSocketDirection_Offset), 0, bUseSocketDirection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseSocketDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bUseSocketDirection");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseSocketDirection_Offset), 0, bUseSocketDirection_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "UseSocketDirection")]
	[EditAnywhere]
	[UProperty]
	[Category("Move|Physical")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:DirectionBaseSocekt")]
	public FName DirectionBaseSocekt
	{
		get
		{
			CheckDestroyed();
			if (!DirectionBaseSocekt_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:DirectionBaseSocekt");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, DirectionBaseSocekt_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DirectionBaseSocekt_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:DirectionBaseSocekt");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, DirectionBaseSocekt_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "UseSocketDirection")]
	[Category("Move|Physical")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:ForwardSocket")]
	public FName ForwardSocket
	{
		get
		{
			CheckDestroyed();
			if (!ForwardSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:ForwardSocket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ForwardSocket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForwardSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:ForwardSocket");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ForwardSocket_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Move|Physical")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:AccuratelyMoveDistance")]
	public float AccuratelyMoveDistance
	{
		get
		{
			CheckDestroyed();
			if (!AccuratelyMoveDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:AccuratelyMoveDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AccuratelyMoveDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AccuratelyMoveDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:AccuratelyMoveDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AccuratelyMoveDistance_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Move|Physical")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bSimulatePhysicsWhenAttacking")]
	public bool bSimulatePhysicsWhenAttacking
	{
		get
		{
			CheckDestroyed();
			if (!bSimulatePhysicsWhenAttacking_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bSimulatePhysicsWhenAttacking");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSimulatePhysicsWhenAttacking_Offset), 0, bSimulatePhysicsWhenAttacking_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSimulatePhysicsWhenAttacking_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bSimulatePhysicsWhenAttacking");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSimulatePhysicsWhenAttacking_Offset), 0, bSimulatePhysicsWhenAttacking_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Move|Spline Fly")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:HorizontalMoveSpeed")]
	public float HorizontalMoveSpeed
	{
		get
		{
			CheckDestroyed();
			if (!HorizontalMoveSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:HorizontalMoveSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HorizontalMoveSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HorizontalMoveSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:HorizontalMoveSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HorizontalMoveSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Move|Spline Fly")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:VerticalMoveSpeed")]
	public float VerticalMoveSpeed
	{
		get
		{
			CheckDestroyed();
			if (!VerticalMoveSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:VerticalMoveSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VerticalMoveSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VerticalMoveSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:VerticalMoveSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VerticalMoveSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Move|Spline Fly")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:MaxMoveDistance")]
	public float MaxMoveDistance
	{
		get
		{
			CheckDestroyed();
			if (!MaxMoveDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MaxMoveDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxMoveDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxMoveDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MaxMoveDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxMoveDistance_Offset), value);
			}
		}
	}

	[Category("Move|Spline Fly")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:FlyDownwardSpeedRate")]
	public float FlyDownwardSpeedRate
	{
		get
		{
			CheckDestroyed();
			if (!FlyDownwardSpeedRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FlyDownwardSpeedRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FlyDownwardSpeedRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FlyDownwardSpeedRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FlyDownwardSpeedRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FlyDownwardSpeedRate_Offset), value);
			}
		}
	}

	[Category("Move|Spline Fly")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:FlyDownwardJudgeAngle")]
	public float FlyDownwardJudgeAngle
	{
		get
		{
			CheckDestroyed();
			if (!FlyDownwardJudgeAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FlyDownwardJudgeAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FlyDownwardJudgeAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FlyDownwardJudgeAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FlyDownwardJudgeAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FlyDownwardJudgeAngle_Offset), value);
			}
		}
	}

	[Category("Move|Relative Float")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:FloatRelativeSpotActor")]
	public TWeakObject<AActor> FloatRelativeSpotActor
	{
		get
		{
			CheckDestroyed();
			if (!FloatRelativeSpotActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FloatRelativeSpotActor");
				return default(TWeakObject<AActor>);
			}
			return TWeakObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, FloatRelativeSpotActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FloatRelativeSpotActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FloatRelativeSpotActor");
			}
			else
			{
				TWeakObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, FloatRelativeSpotActor_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Move|Relative Float")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:RelativeFloatHeight")]
	public float RelativeFloatHeight
	{
		get
		{
			CheckDestroyed();
			if (!RelativeFloatHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:RelativeFloatHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RelativeFloatHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RelativeFloatHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:RelativeFloatHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RelativeFloatHeight_Offset), value);
			}
		}
	}

	[UProperty]
	[Tooltip("寻路轨迹")]
	[Category("Move|DumperTruck")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:SplineList")]
	public TArrayReadWrite<TSoftObject<AActor>> SplineList
	{
		get
		{
			CheckDestroyed();
			if (!SplineList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:SplineList");
				return null;
			}
			if (SplineList_Marshaler == null)
			{
				SplineList_Marshaler = new TArrayReadWriteMarshaler<TSoftObject<AActor>>(1, SplineList_PropertyAddress, CachedMarshalingDelegates<TSoftObject<AActor>, TSoftObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<AActor>, TSoftObjectMarshaler<AActor>>.ToNative);
			}
			return SplineList_Marshaler.FromNative(IntPtr.Add(base.Address, SplineList_Offset));
		}
	}

	[Tooltip("开始触发盒")]
	[Category("Move|DumperTruck")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:BeginTriggerBox")]
	public TSoftObject<ATriggerBase> BeginTriggerBox
	{
		get
		{
			CheckDestroyed();
			if (!BeginTriggerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:BeginTriggerBox");
				return default(TSoftObject<ATriggerBase>);
			}
			return TSoftObjectMarshaler<ATriggerBase>.FromNative(IntPtr.Add(base.Address, BeginTriggerBox_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeginTriggerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:BeginTriggerBox");
			}
			else
			{
				TSoftObjectMarshaler<ATriggerBase>.ToNative(IntPtr.Add(base.Address, BeginTriggerBox_Offset), value);
			}
		}
	}

	[Tooltip("结束触发盒")]
	[UProperty]
	[EditAnywhere]
	[Category("Move|DumperTruck")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:EndTriggerBox")]
	public TSoftObject<ATriggerBase> EndTriggerBox
	{
		get
		{
			CheckDestroyed();
			if (!EndTriggerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:EndTriggerBox");
				return default(TSoftObject<ATriggerBase>);
			}
			return TSoftObjectMarshaler<ATriggerBase>.FromNative(IntPtr.Add(base.Address, EndTriggerBox_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EndTriggerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:EndTriggerBox");
			}
			else
			{
				TSoftObjectMarshaler<ATriggerBase>.ToNative(IntPtr.Add(base.Address, EndTriggerBox_Offset), value);
			}
		}
	}

	[Category("Move|DumperTruck")]
	[EditAnywhere]
	[Tooltip("旋转速度")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:TurnSpeed")]
	public int TurnSpeed
	{
		get
		{
			CheckDestroyed();
			if (!TurnSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TurnSpeed");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TurnSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TurnSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TurnSpeed");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TurnSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Tooltip("加速度")]
	[Category("Move|DumperTruck")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:Acceleration")]
	public float Acceleration
	{
		get
		{
			CheckDestroyed();
			if (!Acceleration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:Acceleration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Acceleration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Acceleration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:Acceleration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Acceleration_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Move|DumperTruck")]
	[Tooltip("最大速度")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:MaxSpeed")]
	public float MaxSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MaxSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MaxSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MaxSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxSpeed_Offset), value);
			}
		}
	}

	[Tooltip("最小速度")]
	[Category("Move|DumperTruck")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:MinSpeed")]
	public float MinSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MinSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MinSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MinSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinSpeed_Offset), value);
			}
		}
	}

	[Tooltip("开始速度")]
	[EditAnywhere]
	[Category("Move|DumperTruck")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:StartSpeed")]
	public float StartSpeed
	{
		get
		{
			CheckDestroyed();
			if (!StartSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:StartSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StartSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:StartSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StartSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Move|DumperTruck")]
	[Tooltip("默认寻路轨迹Index")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:MultiSplineDefaultIndex")]
	public int MultiSplineDefaultIndex
	{
		get
		{
			CheckDestroyed();
			if (!MultiSplineDefaultIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MultiSplineDefaultIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MultiSplineDefaultIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MultiSplineDefaultIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MultiSplineDefaultIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MultiSplineDefaultIndex_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Move|DumperTruck")]
	[Tooltip("第一个加速带结束位置，开始位置为起始端")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:FirstAccelerationIndex")]
	public int FirstAccelerationIndex
	{
		get
		{
			CheckDestroyed();
			if (!FirstAccelerationIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FirstAccelerationIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, FirstAccelerationIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FirstAccelerationIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FirstAccelerationIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, FirstAccelerationIndex_Offset), value);
			}
		}
	}

	[Tooltip("第二个加速带结束位置，开始位置为结束端")]
	[Category("Move|DumperTruck")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:SecondAccelerationIndex")]
	public int SecondAccelerationIndex
	{
		get
		{
			CheckDestroyed();
			if (!SecondAccelerationIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:SecondAccelerationIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SecondAccelerationIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SecondAccelerationIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:SecondAccelerationIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SecondAccelerationIndex_Offset), value);
			}
		}
	}

	[Tooltip("速度动画缩放参数")]
	[UProperty]
	[EditAnywhere]
	[Category("Move|DumperTruck")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:SpeedRateParam")]
	public float SpeedRateParam
	{
		get
		{
			CheckDestroyed();
			if (!SpeedRateParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:SpeedRateParam");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpeedRateParam_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpeedRateParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:SpeedRateParam");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpeedRateParam_Offset), value);
			}
		}
	}

	[Tooltip("转向等待时间")]
	[Category("Move|DumperTruck")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:RotatorWaitTime")]
	public float RotatorWaitTime
	{
		get
		{
			CheckDestroyed();
			if (!RotatorWaitTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:RotatorWaitTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RotatorWaitTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotatorWaitTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:RotatorWaitTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RotatorWaitTime_Offset), value);
			}
		}
	}

	[Tooltip("转向表现曲线")]
	[Category("Move|DumperTruck")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:SpeedRateParamCurve")]
	public UCurveFloat SpeedRateParamCurve
	{
		get
		{
			CheckDestroyed();
			if (!SpeedRateParamCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:SpeedRateParamCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, SpeedRateParamCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpeedRateParamCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:SpeedRateParamCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, SpeedRateParamCurve_Offset), value);
			}
		}
	}

	[Tooltip("转向时使用曲线控制时间")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Move|DumperTruck")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:UseCurveTime")]
	public float UseCurveTime
	{
		get
		{
			CheckDestroyed();
			if (!UseCurveTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:UseCurveTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UseCurveTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UseCurveTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:UseCurveTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UseCurveTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Move|DumperTruck")]
	[Tooltip("转向表现曲线")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:StartPointIndex")]
	public int StartPointIndex
	{
		get
		{
			CheckDestroyed();
			if (!StartPointIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:StartPointIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, StartPointIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartPointIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:StartPointIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, StartPointIndex_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Move|DumperTruck")]
	[Tooltip("转向表现曲线")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:IsStartForward")]
	public bool IsStartForward
	{
		get
		{
			CheckDestroyed();
			if (!IsStartForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:IsStartForward");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsStartForward_Offset), 0, IsStartForward_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsStartForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:IsStartForward");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsStartForward_Offset), 0, IsStartForward_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Move|DumperTruck")]
	[Tooltip("正向移动特效BuffID")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:ForwardBuffID")]
	public int ForwardBuffID
	{
		get
		{
			CheckDestroyed();
			if (!ForwardBuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:ForwardBuffID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ForwardBuffID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForwardBuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:ForwardBuffID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ForwardBuffID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Move|DumperTruck")]
	[Tooltip("反向移动特效BuffID")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:BackBuffID")]
	public int BackBuffID
	{
		get
		{
			CheckDestroyed();
			if (!BackBuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:BackBuffID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BackBuffID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BackBuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:BackBuffID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BackBuffID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Move|RootMotion Follow")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:FollowStateRotationRate")]
	public float FollowStateRotationRate
	{
		get
		{
			CheckDestroyed();
			if (!FollowStateRotationRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FollowStateRotationRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FollowStateRotationRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FollowStateRotationRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FollowStateRotationRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FollowStateRotationRate_Offset), value);
			}
		}
	}

	[Category("Disp")]
	[DisplayName("是否启用铜头铁臂RT")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableTTTBRT")]
	public bool bEnableTTTBRT
	{
		get
		{
			CheckDestroyed();
			if (!bEnableTTTBRT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableTTTBRT");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableTTTBRT_Offset), 0, bEnableTTTBRT_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableTTTBRT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableTTTBRT");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableTTTBRT_Offset), 0, bEnableTTTBRT_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("启用\ud83d\ude4f")]
	[Category("Disp|EnvInteraction")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableEnvInteraction")]
	public bool bEnableEnvInteraction
	{
		get
		{
			CheckDestroyed();
			if (!bEnableEnvInteraction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableEnvInteraction");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableEnvInteraction_Offset), 0, bEnableEnvInteraction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableEnvInteraction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableEnvInteraction");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableEnvInteraction_Offset), 0, bEnableEnvInteraction_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("检测延迟\ud83d\ude32")]
	[Category("Disp|EnvInteraction")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:TraceDelay")]
	public float TraceDelay
	{
		get
		{
			CheckDestroyed();
			if (!TraceDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TraceDelay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TraceDelay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TraceDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TraceDelay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TraceDelay_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("检测射线长度\ud83d\ude33")]
	[Category("Disp|EnvInteraction")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:TraceLength")]
	public float TraceLength
	{
		get
		{
			CheckDestroyed();
			if (!TraceLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TraceLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TraceLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TraceLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TraceLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TraceLength_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Disp|EnvInteraction")]
	[DisplayName("大小\ud83d\ude31")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:Size")]
	public float Size
	{
		get
		{
			CheckDestroyed();
			if (!Size_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:Size");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Size_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Size_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:Size");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Size_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("样本获取保护时间\ud83d\ude31")]
	[Category("Disp|EnvInteraction")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:SampleCollectionProtectTime")]
	public float SampleCollectionProtectTime
	{
		get
		{
			CheckDestroyed();
			if (!SampleCollectionProtectTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:SampleCollectionProtectTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SampleCollectionProtectTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SampleCollectionProtectTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:SampleCollectionProtectTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SampleCollectionProtectTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("覆盖表面类型\ud83d\ude30")]
	[Category("Disp|EnvInteraction")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:OverrideSurfaceType")]
	public ESceneItemSurfaceType OverrideSurfaceType
	{
		get
		{
			CheckDestroyed();
			if (!OverrideSurfaceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:OverrideSurfaceType");
				return ESceneItemSurfaceType.DefaultSurface;
			}
			return EnumMarshaler<ESceneItemSurfaceType>.FromNative(IntPtr.Add(base.Address, OverrideSurfaceType_Offset), 0, OverrideSurfaceType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideSurfaceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:OverrideSurfaceType");
			}
			else
			{
				EnumMarshaler<ESceneItemSurfaceType>.ToNative(IntPtr.Add(base.Address, OverrideSurfaceType_Offset), 0, OverrideSurfaceType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[DisplayName("覆盖表面持续时间\ud83d\ude22")]
	[EditAnywhere]
	[Category("Disp|EnvInteraction")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:OverrideSurfacePersistTime")]
	public float OverrideSurfacePersistTime
	{
		get
		{
			CheckDestroyed();
			if (!OverrideSurfacePersistTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:OverrideSurfacePersistTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OverrideSurfacePersistTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverrideSurfacePersistTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:OverrideSurfacePersistTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OverrideSurfacePersistTime_Offset), value);
			}
		}
	}

	[Category("Disp|EnvInteraction")]
	[DisplayName("覆盖表面特效ActorTag\ud83d\ude22")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:OverrideSurfaceFXActorTag")]
	public FName OverrideSurfaceFXActorTag
	{
		get
		{
			CheckDestroyed();
			if (!OverrideSurfaceFXActorTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:OverrideSurfaceFXActorTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, OverrideSurfaceFXActorTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverrideSurfaceFXActorTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:OverrideSurfaceFXActorTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, OverrideSurfaceFXActorTag_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("Disp|EnvInteraction")]
	[UProperty]
	[DisplayName("debug画出来\ud83d\ude4f")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bDrawDebug")]
	public bool bDrawDebug
	{
		get
		{
			CheckDestroyed();
			if (!bDrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bDrawDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDrawDebug_Offset), 0, bDrawDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bDrawDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDrawDebug_Offset), 0, bDrawDebug_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Disp|EnvInteraction")]
	[DisplayName("debug画的偏移\ud83d\ude4f")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:DebugDrawOffset")]
	public float DebugDrawOffset
	{
		get
		{
			CheckDestroyed();
			if (!DebugDrawOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:DebugDrawOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DebugDrawOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugDrawOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:DebugDrawOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DebugDrawOffset_Offset), value);
			}
		}
	}

	[Category("Disp|FXDetach")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:FXComponentName")]
	public TArrayReadWrite<string> FXComponentName
	{
		get
		{
			CheckDestroyed();
			if (!FXComponentName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FXComponentName");
				return null;
			}
			if (FXComponentName_Marshaler == null)
			{
				FXComponentName_Marshaler = new TArrayReadWriteMarshaler<string>(1, FXComponentName_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return FXComponentName_Marshaler.FromNative(IntPtr.Add(base.Address, FXComponentName_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Disp|GlobalFX")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:GlobalFXConfigList")]
	public TArrayReadWrite<FGlobalFXConfigInfo> GlobalFXConfigList
	{
		get
		{
			CheckDestroyed();
			if (!GlobalFXConfigList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:GlobalFXConfigList");
				return null;
			}
			if (GlobalFXConfigList_Marshaler == null)
			{
				GlobalFXConfigList_Marshaler = new TArrayReadWriteMarshaler<FGlobalFXConfigInfo>(1, GlobalFXConfigList_PropertyAddress, CachedMarshalingDelegates<FGlobalFXConfigInfo, FGlobalFXConfigInfo>.FromNative, CachedMarshalingDelegates<FGlobalFXConfigInfo, FGlobalFXConfigInfo>.ToNative);
			}
			return GlobalFXConfigList_Marshaler.FromNative(IntPtr.Add(base.Address, GlobalFXConfigList_Offset));
		}
	}

	[DisplayName("头顶灯启用标识")]
	[Category("Disp|PointLight")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:PointLightTag")]
	public FGameplayTag PointLightTag
	{
		get
		{
			CheckDestroyed();
			if (!PointLightTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PointLightTag");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, PointLightTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PointLightTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PointLightTag");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, PointLightTag_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("Audio")]
	[Tooltip("出生时开始播放的音效")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:LoopEvent")]
	public UAkEventConfig LoopEvent
	{
		get
		{
			CheckDestroyed();
			if (!LoopEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:LoopEvent");
				return default(UAkEventConfig);
			}
			return UAkEventConfig.FromNative(IntPtr.Add(base.Address, LoopEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LoopEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:LoopEvent");
			}
			else
			{
				UAkEventConfig.ToNative(IntPtr.Add(base.Address, LoopEvent_Offset), value);
			}
		}
	}

	[Tooltip("死亡时开始播放的音效")]
	[Category("Audio")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:DeadEvent")]
	public UAkEventConfig DeadEvent
	{
		get
		{
			CheckDestroyed();
			if (!DeadEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:DeadEvent");
				return default(UAkEventConfig);
			}
			return UAkEventConfig.FromNative(IntPtr.Add(base.Address, DeadEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DeadEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:DeadEvent");
			}
			else
			{
				UAkEventConfig.ToNative(IntPtr.Add(base.Address, DeadEvent_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Audio")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:BtlBGMBPConfig")]
	public FBtlBGMBPConfig BtlBGMBPConfig
	{
		get
		{
			CheckDestroyed();
			if (!BtlBGMBPConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:BtlBGMBPConfig");
				return default(FBtlBGMBPConfig);
			}
			return FBtlBGMBPConfig.FromNative(IntPtr.Add(base.Address, BtlBGMBPConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BtlBGMBPConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:BtlBGMBPConfig");
			}
			else
			{
				FBtlBGMBPConfig.ToNative(IntPtr.Add(base.Address, BtlBGMBPConfig_Offset), value);
			}
		}
	}

	[Category("Audio|FootStep")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:DrawDebugLine")]
	public bool DrawDebugLine
	{
		get
		{
			CheckDestroyed();
			if (!DrawDebugLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:DrawDebugLine");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DrawDebugLine_Offset), 0, DrawDebugLine_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DrawDebugLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:DrawDebugLine");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DrawDebugLine_Offset), 0, DrawDebugLine_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Audio|FootStep")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bShowFootSpeed")]
	public bool bShowFootSpeed
	{
		get
		{
			CheckDestroyed();
			if (!bShowFootSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bShowFootSpeed");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bShowFootSpeed_Offset), 0, bShowFootSpeed_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bShowFootSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bShowFootSpeed");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bShowFootSpeed_Offset), 0, bShowFootSpeed_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("Audio|FootStep")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bShowFootHeight")]
	public bool bShowFootHeight
	{
		get
		{
			CheckDestroyed();
			if (!bShowFootHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bShowFootHeight");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bShowFootHeight_Offset), 0, bShowFootHeight_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bShowFootHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bShowFootHeight");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bShowFootHeight_Offset), 0, bShowFootHeight_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Audio|FootStep")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bUseFarStepAudio")]
	public bool bUseFarStepAudio
	{
		get
		{
			CheckDestroyed();
			if (!bUseFarStepAudio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bUseFarStepAudio");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseFarStepAudio_Offset), 0, bUseFarStepAudio_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseFarStepAudio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bUseFarStepAudio");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseFarStepAudio_Offset), 0, bUseFarStepAudio_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Audio|FootStep")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:LeftFootSpeedRefBoneName")]
	public FName LeftFootSpeedRefBoneName
	{
		get
		{
			CheckDestroyed();
			if (!LeftFootSpeedRefBoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:LeftFootSpeedRefBoneName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, LeftFootSpeedRefBoneName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeftFootSpeedRefBoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:LeftFootSpeedRefBoneName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, LeftFootSpeedRefBoneName_Offset), value);
			}
		}
	}

	[Category("Audio|FootStep")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:RightFootSpeedRefBoneName")]
	public FName RightFootSpeedRefBoneName
	{
		get
		{
			CheckDestroyed();
			if (!RightFootSpeedRefBoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:RightFootSpeedRefBoneName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, RightFootSpeedRefBoneName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RightFootSpeedRefBoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:RightFootSpeedRefBoneName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, RightFootSpeedRefBoneName_Offset), value);
			}
		}
	}

	[Category("Audio|FootStep")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:LeftFootLineTraceBoneName")]
	public FName LeftFootLineTraceBoneName
	{
		get
		{
			CheckDestroyed();
			if (!LeftFootLineTraceBoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:LeftFootLineTraceBoneName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, LeftFootLineTraceBoneName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeftFootLineTraceBoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:LeftFootLineTraceBoneName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, LeftFootLineTraceBoneName_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Audio|FootStep")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:RightFootLineTraceBoneName")]
	public FName RightFootLineTraceBoneName
	{
		get
		{
			CheckDestroyed();
			if (!RightFootLineTraceBoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:RightFootLineTraceBoneName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, RightFootLineTraceBoneName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RightFootLineTraceBoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:RightFootLineTraceBoneName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, RightFootLineTraceBoneName_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Audio|FootStep")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:LeftFootFrontSocket")]
	public FName LeftFootFrontSocket
	{
		get
		{
			CheckDestroyed();
			if (!LeftFootFrontSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:LeftFootFrontSocket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, LeftFootFrontSocket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeftFootFrontSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:LeftFootFrontSocket");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, LeftFootFrontSocket_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Audio|FootStep")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:RightFootFrontSocket")]
	public FName RightFootFrontSocket
	{
		get
		{
			CheckDestroyed();
			if (!RightFootFrontSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:RightFootFrontSocket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, RightFootFrontSocket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RightFootFrontSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:RightFootFrontSocket");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, RightFootFrontSocket_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Audio|FootStep")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:CameraShake")]
	public TSubclassOf<UMatineeCameraShake> CameraShake
	{
		get
		{
			CheckDestroyed();
			if (!CameraShake_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:CameraShake");
				return default(TSubclassOf<UMatineeCameraShake>);
			}
			return TSubclassOfMarshaler<UMatineeCameraShake>.FromNative(IntPtr.Add(base.Address, CameraShake_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraShake_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:CameraShake");
			}
			else
			{
				TSubclassOfMarshaler<UMatineeCameraShake>.ToNative(IntPtr.Add(base.Address, CameraShake_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Audio|FootStep")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:StepAudioPath")]
	public FSoftObjectPath StepAudioPath
	{
		get
		{
			CheckDestroyed();
			if (!StepAudioPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:StepAudioPath");
				return default(FSoftObjectPath);
			}
			return FSoftObjectPath.FromNative(IntPtr.Add(base.Address, StepAudioPath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StepAudioPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:StepAudioPath");
			}
			else
			{
				FSoftObjectPath.ToNative(IntPtr.Add(base.Address, StepAudioPath_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Audio|FootStep")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:MoveActionTypeID")]
	public int MoveActionTypeID
	{
		get
		{
			CheckDestroyed();
			if (!MoveActionTypeID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MoveActionTypeID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MoveActionTypeID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveActionTypeID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MoveActionTypeID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MoveActionTypeID_Offset), value);
			}
		}
	}

	[Category("Audio|FootStep")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bPrintStepAudioSwitchState")]
	public bool bPrintStepAudioSwitchState
	{
		get
		{
			CheckDestroyed();
			if (!bPrintStepAudioSwitchState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bPrintStepAudioSwitchState");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bPrintStepAudioSwitchState_Offset), 0, bPrintStepAudioSwitchState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bPrintStepAudioSwitchState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bPrintStepAudioSwitchState");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bPrintStepAudioSwitchState_Offset), 0, bPrintStepAudioSwitchState_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("是否开启脚步声随速度切换功能")]
	[Category("Audio|FootStep")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bMultiSpdForStepAK")]
	public bool bMultiSpdForStepAK
	{
		get
		{
			CheckDestroyed();
			if (!bMultiSpdForStepAK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bMultiSpdForStepAK");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bMultiSpdForStepAK_Offset), 0, bMultiSpdForStepAK_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bMultiSpdForStepAK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bMultiSpdForStepAK");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bMultiSpdForStepAK_Offset), 0, bMultiSpdForStepAK_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("是否多足类单位")]
	[Category("Audio|FootStep")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bMyriapods")]
	public bool bMyriapods
	{
		get
		{
			CheckDestroyed();
			if (!bMyriapods_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bMyriapods");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bMyriapods_Offset), 0, bMyriapods_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bMyriapods_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bMyriapods");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bMyriapods_Offset), 0, bMyriapods_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("Audio|FootStep")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:DecalMaterialPath")]
	public FSoftObjectPath DecalMaterialPath
	{
		get
		{
			CheckDestroyed();
			if (!DecalMaterialPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:DecalMaterialPath");
				return default(FSoftObjectPath);
			}
			return FSoftObjectPath.FromNative(IntPtr.Add(base.Address, DecalMaterialPath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DecalMaterialPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:DecalMaterialPath");
			}
			else
			{
				FSoftObjectPath.ToNative(IntPtr.Add(base.Address, DecalMaterialPath_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Audio|FootStep")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:FootStepDecalSize")]
	public FVector FootStepDecalSize
	{
		get
		{
			CheckDestroyed();
			if (!FootStepDecalSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FootStepDecalSize");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, FootStepDecalSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FootStepDecalSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FootStepDecalSize");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, FootStepDecalSize_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("Audio|FootStep")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:FootStepDecalOffset")]
	public FVector FootStepDecalOffset
	{
		get
		{
			CheckDestroyed();
			if (!FootStepDecalOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FootStepDecalOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, FootStepDecalOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FootStepDecalOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FootStepDecalOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, FootStepDecalOffset_Offset), value);
			}
		}
	}

	[Category("Audio|FootStep")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:FootStepDecalStartFadeOutTime")]
	public float FootStepDecalStartFadeOutTime
	{
		get
		{
			CheckDestroyed();
			if (!FootStepDecalStartFadeOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FootStepDecalStartFadeOutTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FootStepDecalStartFadeOutTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FootStepDecalStartFadeOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FootStepDecalStartFadeOutTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FootStepDecalStartFadeOutTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Audio|FootStep")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:FootStepDecalFadeOutDuration")]
	public float FootStepDecalFadeOutDuration
	{
		get
		{
			CheckDestroyed();
			if (!FootStepDecalFadeOutDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FootStepDecalFadeOutDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FootStepDecalFadeOutDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FootStepDecalFadeOutDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FootStepDecalFadeOutDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FootStepDecalFadeOutDuration_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("植被交互音效优先级")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:FoliageInteractSoundPriority")]
	public EFoliageInteractSoundPriority FoliageInteractSoundPriority
	{
		get
		{
			CheckDestroyed();
			if (!FoliageInteractSoundPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FoliageInteractSoundPriority");
				return EFoliageInteractSoundPriority.Default;
			}
			return EnumMarshaler<EFoliageInteractSoundPriority>.FromNative(IntPtr.Add(base.Address, FoliageInteractSoundPriority_Offset), 0, FoliageInteractSoundPriority_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FoliageInteractSoundPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FoliageInteractSoundPriority");
			}
			else
			{
				EnumMarshaler<EFoliageInteractSoundPriority>.ToNative(IntPtr.Add(base.Address, FoliageInteractSoundPriority_Offset), 0, FoliageInteractSoundPriority_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("被定身配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Skill|BeImmobilize")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:BeImmobilizedConfig")]
	public BGWDataAsset_BeImmobilizedConfig BeImmobilizedConfig
	{
		get
		{
			CheckDestroyed();
			if (!BeImmobilizedConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:BeImmobilizedConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_BeImmobilizedConfig>.FromNative(IntPtr.Add(base.Address, BeImmobilizedConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeImmobilizedConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:BeImmobilizedConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_BeImmobilizedConfig>.ToNative(IntPtr.Add(base.Address, BeImmobilizedConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("势能配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Skill|Potential Energy")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:DA_PELevelConfig")]
	public BGWDataAsset_PELevelConfig DA_PELevelConfig
	{
		get
		{
			CheckDestroyed();
			if (!DA_PELevelConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:DA_PELevelConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_PELevelConfig>.FromNative(IntPtr.Add(base.Address, DA_PELevelConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DA_PELevelConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:DA_PELevelConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_PELevelConfig>.ToNative(IntPtr.Add(base.Address, DA_PELevelConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[EditDefaultsOnly]
	[Category("Skill|Precise Dodge")]
	[DisplayName("默认允许精准闪避")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:AutoEnablePreciseDodge")]
	public bool AutoEnablePreciseDodge
	{
		get
		{
			CheckDestroyed();
			if (!AutoEnablePreciseDodge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:AutoEnablePreciseDodge");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoEnablePreciseDodge_Offset), 0, AutoEnablePreciseDodge_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoEnablePreciseDodge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:AutoEnablePreciseDodge");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoEnablePreciseDodge_Offset), 0, AutoEnablePreciseDodge_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("默认奖励等级")]
	[BlueprintReadWrite]
	[EditDefaultsOnly]
	[UProperty]
	[Category("Skill|Precise Dodge")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:DefaultAwardsLevel")]
	public int DefaultAwardsLevel
	{
		get
		{
			CheckDestroyed();
			if (!DefaultAwardsLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:DefaultAwardsLevel");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DefaultAwardsLevel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultAwardsLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:DefaultAwardsLevel");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DefaultAwardsLevel_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("判定时长")]
	[Category("Skill|Precise Dodge")]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:TolerantTimeSeconds")]
	public float TolerantTimeSeconds
	{
		get
		{
			CheckDestroyed();
			if (!TolerantTimeSeconds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TolerantTimeSeconds");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TolerantTimeSeconds_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TolerantTimeSeconds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TolerantTimeSeconds");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TolerantTimeSeconds_Offset), value);
			}
		}
	}

	[DisplayName("奖励列表")]
	[EditDefaultsOnly]
	[UProperty]
	[Category("Skill|Precise Dodge")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:Awards")]
	public TArrayReadWrite<PreciseDodgeAwards> Awards
	{
		get
		{
			CheckDestroyed();
			if (!Awards_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:Awards");
				return null;
			}
			if (Awards_Marshaler == null)
			{
				Awards_Marshaler = new TArrayReadWriteMarshaler<PreciseDodgeAwards>(1, Awards_PropertyAddress, CachedMarshalingDelegates<PreciseDodgeAwards, PreciseDodgeAwards>.FromNative, CachedMarshalingDelegates<PreciseDodgeAwards, PreciseDodgeAwards>.ToNative);
			}
			return Awards_Marshaler.FromNative(IntPtr.Add(base.Address, Awards_Offset));
		}
	}

	[Category("Skill|Precise Dodge")]
	[DisplayName("开启调试")]
	[BlueprintReadWrite]
	[EditDefaultsOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bDebugPreciseDodge")]
	public bool bDebugPreciseDodge
	{
		get
		{
			CheckDestroyed();
			if (!bDebugPreciseDodge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bDebugPreciseDodge");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDebugPreciseDodge_Offset), 0, bDebugPreciseDodge_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDebugPreciseDodge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bDebugPreciseDodge");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDebugPreciseDodge_Offset), 0, bDebugPreciseDodge_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Skill|Unit Trans")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:TransStageConfigID")]
	public int TransStageConfigID
	{
		get
		{
			CheckDestroyed();
			if (!TransStageConfigID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TransStageConfigID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TransStageConfigID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TransStageConfigID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TransStageConfigID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TransStageConfigID_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("Skill|Unit Trans")]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("姿态回归技能ID")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:TransBackSkillID")]
	public int TransBackSkillID
	{
		get
		{
			CheckDestroyed();
			if (!TransBackSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TransBackSkillID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TransBackSkillID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TransBackSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TransBackSkillID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TransBackSkillID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("姿态回归等待时长")]
	[Category("Skill|Unit Trans")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:TransBackDurationTime")]
	public float TransBackDurationTime
	{
		get
		{
			CheckDestroyed();
			if (!TransBackDurationTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TransBackDurationTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TransBackDurationTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TransBackDurationTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TransBackDurationTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TransBackDurationTime_Offset), value);
			}
		}
	}

	[Category("Abnormal State")]
	[DisplayName("异常状态属性配置")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:AbnormalAttrConfig")]
	public BGWDataAsset_AbnormalAttrConfig AbnormalAttrConfig
	{
		get
		{
			CheckDestroyed();
			if (!AbnormalAttrConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:AbnormalAttrConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_AbnormalAttrConfig>.FromNative(IntPtr.Add(base.Address, AbnormalAttrConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AbnormalAttrConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:AbnormalAttrConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_AbnormalAttrConfig>.ToNative(IntPtr.Add(base.Address, AbnormalAttrConfig_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("异常状态免疫")]
	[Category("Abnormal State")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:AbnormalStateImmueList")]
	public TArrayReadWrite<Birth_AbnormalStateImmueType> AbnormalStateImmueList
	{
		get
		{
			CheckDestroyed();
			if (!AbnormalStateImmueList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:AbnormalStateImmueList");
				return null;
			}
			if (AbnormalStateImmueList_Marshaler == null)
			{
				AbnormalStateImmueList_Marshaler = new TArrayReadWriteMarshaler<Birth_AbnormalStateImmueType>(1, AbnormalStateImmueList_PropertyAddress, CachedMarshalingDelegates<Birth_AbnormalStateImmueType, EnumMarshaler<Birth_AbnormalStateImmueType>>.FromNative, CachedMarshalingDelegates<Birth_AbnormalStateImmueType, EnumMarshaler<Birth_AbnormalStateImmueType>>.ToNative);
			}
			return AbnormalStateImmueList_Marshaler.FromNative(IntPtr.Add(base.Address, AbnormalStateImmueList_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("出生自带异常状态")]
	[Category("Abnormal State")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:BirthAbnormalStateList")]
	public TArrayReadWrite<Birth_AbnomalState> BirthAbnormalStateList
	{
		get
		{
			CheckDestroyed();
			if (!BirthAbnormalStateList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:BirthAbnormalStateList");
				return null;
			}
			if (BirthAbnormalStateList_Marshaler == null)
			{
				BirthAbnormalStateList_Marshaler = new TArrayReadWriteMarshaler<Birth_AbnomalState>(1, BirthAbnormalStateList_PropertyAddress, CachedMarshalingDelegates<Birth_AbnomalState, Birth_AbnomalState>.FromNative, CachedMarshalingDelegates<Birth_AbnomalState, Birth_AbnomalState>.ToNative);
			}
			return BirthAbnormalStateList_Marshaler.FromNative(IntPtr.Add(base.Address, BirthAbnormalStateList_Offset));
		}
	}

	[Category("Skill|架势")]
	[DisplayName("切棍势触发效果列表")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:EffectIDList_SwitchWeaponPose")]
	public TArrayReadWrite<int> EffectIDList_SwitchWeaponPose
	{
		get
		{
			CheckDestroyed();
			if (!EffectIDList_SwitchWeaponPose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:EffectIDList_SwitchWeaponPose");
				return null;
			}
			if (EffectIDList_SwitchWeaponPose_Marshaler == null)
			{
				EffectIDList_SwitchWeaponPose_Marshaler = new TArrayReadWriteMarshaler<int>(1, EffectIDList_SwitchWeaponPose_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return EffectIDList_SwitchWeaponPose_Marshaler.FromNative(IntPtr.Add(base.Address, EffectIDList_SwitchWeaponPose_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("切棍势触发效果冷却时间(秒)")]
	[Category("Skill|架势")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:TriggerEffectCoolDown_SwitchWeaponPose")]
	public float TriggerEffectCoolDown_SwitchWeaponPose
	{
		get
		{
			CheckDestroyed();
			if (!TriggerEffectCoolDown_SwitchWeaponPose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TriggerEffectCoolDown_SwitchWeaponPose");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TriggerEffectCoolDown_SwitchWeaponPose_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TriggerEffectCoolDown_SwitchWeaponPose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TriggerEffectCoolDown_SwitchWeaponPose");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TriggerEffectCoolDown_SwitchWeaponPose_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("受到伤害所需最低坠落高度")]
	[Category("Falling")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:CostDMG_StartHeight")]
	public float CostDMG_StartHeight
	{
		get
		{
			CheckDestroyed();
			if (!CostDMG_StartHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:CostDMG_StartHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CostDMG_StartHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CostDMG_StartHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:CostDMG_StartHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CostDMG_StartHeight_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("每100单位高度受到伤害万分比")]
	[Category("Falling")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:OverHeight_DmgAdditive_INV10000")]
	public int OverHeight_DmgAdditive_INV10000
	{
		get
		{
			CheckDestroyed();
			if (!OverHeight_DmgAdditive_INV10000_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:OverHeight_DmgAdditive_INV10000");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, OverHeight_DmgAdditive_INV10000_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverHeight_DmgAdditive_INV10000_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:OverHeight_DmgAdditive_INV10000");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, OverHeight_DmgAdditive_INV10000_Offset), value);
			}
		}
	}

	[DisplayName("伤害最高值万分比")]
	[Category("Falling")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:FallDmg_DmgMax_INV10000")]
	public int FallDmg_DmgMax_INV10000
	{
		get
		{
			CheckDestroyed();
			if (!FallDmg_DmgMax_INV10000_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FallDmg_DmgMax_INV10000");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, FallDmg_DmgMax_INV10000_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FallDmg_DmgMax_INV10000_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FallDmg_DmgMax_INV10000");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, FallDmg_DmgMax_INV10000_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Falling")]
	[BlueprintReadWrite]
	[DisplayName("保底伤害万分比")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:BaseDmg_INV10000")]
	public int BaseDmg_INV10000
	{
		get
		{
			CheckDestroyed();
			if (!BaseDmg_INV10000_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:BaseDmg_INV10000");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BaseDmg_INV10000_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BaseDmg_INV10000_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:BaseDmg_INV10000");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BaseDmg_INV10000_Offset), value);
			}
		}
	}

	[Category("Falling")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("安全下落时间")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:FallingSafeTime")]
	public float FallingSafeTime
	{
		get
		{
			CheckDestroyed();
			if (!FallingSafeTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FallingSafeTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FallingSafeTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FallingSafeTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FallingSafeTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FallingSafeTime_Offset), value);
			}
		}
	}

	[Category("Falling")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("落地震屏")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:LandCamShakeConfig")]
	public FLandCamShake LandCamShakeConfig
	{
		get
		{
			CheckDestroyed();
			if (!LandCamShakeConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:LandCamShakeConfig");
				return default(FLandCamShake);
			}
			return FLandCamShake.FromNative(IntPtr.Add(base.Address, LandCamShakeConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LandCamShakeConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:LandCamShakeConfig");
			}
			else
			{
				FLandCamShake.ToNative(IntPtr.Add(base.Address, LandCamShakeConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("落地翻滚开关")]
	[Category("Falling|落地翻滚")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:EnableDodge_InFalling")]
	public bool EnableDodge_InFalling
	{
		get
		{
			CheckDestroyed();
			if (!EnableDodge_InFalling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:EnableDodge_InFalling");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableDodge_InFalling_Offset), 0, EnableDodge_InFalling_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableDodge_InFalling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:EnableDodge_InFalling");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableDodge_InFalling_Offset), 0, EnableDodge_InFalling_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Falling|落地翻滚")]
	[DisplayName("落地翻滚高度")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:CanDodge_Distance")]
	public float CanDodge_Distance
	{
		get
		{
			CheckDestroyed();
			if (!CanDodge_Distance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:CanDodge_Distance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CanDodge_Distance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CanDodge_Distance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:CanDodge_Distance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CanDodge_Distance_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("落地翻滚伤害保护倍率")]
	[Category("Falling|落地翻滚")]
	[Tooltip("落地前成功翻滚，会得到伤害减免，落地伤害*该值")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:Dodge_DmgMul")]
	public float Dodge_DmgMul
	{
		get
		{
			CheckDestroyed();
			if (!Dodge_DmgMul_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:Dodge_DmgMul");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Dodge_DmgMul_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Dodge_DmgMul_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:Dodge_DmgMul");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Dodge_DmgMul_Offset), value);
			}
		}
	}

	[DisplayName("打开地板距离检测")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("现在是从Capsule底部往正下打500的射线距离，没打到的话会给一个float极大值")]
	[Category("Falling")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:EnableFloorDistanceCheck")]
	public bool EnableFloorDistanceCheck
	{
		get
		{
			CheckDestroyed();
			if (!EnableFloorDistanceCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:EnableFloorDistanceCheck");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableFloorDistanceCheck_Offset), 0, EnableFloorDistanceCheck_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableFloorDistanceCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:EnableFloorDistanceCheck");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableFloorDistanceCheck_Offset), 0, EnableFloorDistanceCheck_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Mechanism|ResetConfig")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bSaveInitData")]
	public bool bSaveInitData
	{
		get
		{
			CheckDestroyed();
			if (!bSaveInitData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bSaveInitData");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSaveInitData_Offset), 0, bSaveInitData_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSaveInitData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bSaveInitData");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSaveInitData_Offset), 0, bSaveInitData_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Mechanism|ResetConfig")]
	[UMeta(MDProp.EditCondition, "bSaveInitData")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:ActorResetType")]
	public EBGUResetType ActorResetType
	{
		get
		{
			CheckDestroyed();
			if (!ActorResetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:ActorResetType");
				return EBGUResetType.No;
			}
			return EnumMarshaler<EBGUResetType>.FromNative(IntPtr.Add(base.Address, ActorResetType_Offset), 0, ActorResetType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ActorResetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:ActorResetType");
			}
			else
			{
				EnumMarshaler<EBGUResetType>.ToNative(IntPtr.Add(base.Address, ActorResetType_Offset), 0, ActorResetType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Mechanism|ImpactComm")]
	[DisplayName("是否启用")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableImpactAction")]
	public bool bEnableImpactAction
	{
		get
		{
			CheckDestroyed();
			if (!bEnableImpactAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableImpactAction");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableImpactAction_Offset), 0, bEnableImpactAction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableImpactAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableImpactAction");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableImpactAction_Offset), 0, bEnableImpactAction_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Mechanism|ImpactComm")]
	[DisplayName("碰撞公式常量")]
	[Tooltip("(速度 * 常量 - 物体质量) > 0 时，物体才会破碎")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:EnableImplactCalculationParameter")]
	public float EnableImplactCalculationParameter
	{
		get
		{
			CheckDestroyed();
			if (!EnableImplactCalculationParameter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:EnableImplactCalculationParameter");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EnableImplactCalculationParameter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EnableImplactCalculationParameter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:EnableImplactCalculationParameter");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EnableImplactCalculationParameter_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Mechanism|ImpactDisplay")]
	[DisplayName("触发碰撞动画高度差(cm)")]
	[Tooltip("破碎物高度和角色坐标的差值需要大于这个才会触发动画")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:EnableImpactActionHeightDiff")]
	public float EnableImpactActionHeightDiff
	{
		get
		{
			CheckDestroyed();
			if (!EnableImpactActionHeightDiff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:EnableImpactActionHeightDiff");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EnableImpactActionHeightDiff_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EnableImpactActionHeightDiff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:EnableImpactActionHeightDiff");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EnableImpactActionHeightDiff_Offset), value);
			}
		}
	}

	[Category("Mechanism|ImpactDisplay")]
	[DisplayName("触发动画冲击阈值")]
	[EditAnywhere]
	[UProperty]
	[Tooltip("(速度 * 常量 + 物体质量) 大于该阈值且高度合适时，角色才会触发动画")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:EnableImpactAnimThreshold")]
	public float EnableImpactAnimThreshold
	{
		get
		{
			CheckDestroyed();
			if (!EnableImpactAnimThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:EnableImpactAnimThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EnableImpactAnimThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EnableImpactAnimThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:EnableImpactAnimThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EnableImpactAnimThreshold_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMax, "180")]
	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.ClampMin, "0")]
	[DisplayName("左后角度分割线")]
	[Tooltip("小于等于这个角度是左方")]
	[Category("Mechanism|ImpactDisplay")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:LeftAngleSplitLine")]
	public float LeftAngleSplitLine
	{
		get
		{
			CheckDestroyed();
			if (!LeftAngleSplitLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:LeftAngleSplitLine");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LeftAngleSplitLine_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeftAngleSplitLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:LeftAngleSplitLine");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LeftAngleSplitLine_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.ClampMin, "0")]
	[Category("Mechanism|ImpactDisplay")]
	[UMeta(MDProp.ClampMax, "180")]
	[DisplayName("左前角度分割线")]
	[Tooltip("小于等于这个角度是前方")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:MiddleLeftAngleSplitLine")]
	public float MiddleLeftAngleSplitLine
	{
		get
		{
			CheckDestroyed();
			if (!MiddleLeftAngleSplitLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MiddleLeftAngleSplitLine");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MiddleLeftAngleSplitLine_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MiddleLeftAngleSplitLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MiddleLeftAngleSplitLine");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MiddleLeftAngleSplitLine_Offset), value);
			}
		}
	}

	[DisplayName("右前角度分割线")]
	[UMeta(MDProp.ClampMax, "180")]
	[Tooltip("小于等于这个角度是前方")]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.ClampMin, "0")]
	[Category("Mechanism|ImpactDisplay")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:MiddleRightAngleSplitLine")]
	public float MiddleRightAngleSplitLine
	{
		get
		{
			CheckDestroyed();
			if (!MiddleRightAngleSplitLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MiddleRightAngleSplitLine");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MiddleRightAngleSplitLine_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MiddleRightAngleSplitLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:MiddleRightAngleSplitLine");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MiddleRightAngleSplitLine_Offset), value);
			}
		}
	}

	[Tooltip("小于等于这个角度是右方")]
	[UMeta(MDProp.ClampMax, "180")]
	[DisplayName("右后角度分割线")]
	[Category("Mechanism|ImpactDisplay")]
	[EditAnywhere]
	[UMeta(MDProp.ClampMin, "0")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:RightAngleSplitLine")]
	public float RightAngleSplitLine
	{
		get
		{
			CheckDestroyed();
			if (!RightAngleSplitLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:RightAngleSplitLine");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RightAngleSplitLine_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RightAngleSplitLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:RightAngleSplitLine");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RightAngleSplitLine_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Mechanism|ImpactDisplay")]
	[DisplayName("前方碰撞动画")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:ForwardImpactActionAnim")]
	public UAnimMontage ForwardImpactActionAnim
	{
		get
		{
			CheckDestroyed();
			if (!ForwardImpactActionAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:ForwardImpactActionAnim");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, ForwardImpactActionAnim_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForwardImpactActionAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:ForwardImpactActionAnim");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, ForwardImpactActionAnim_Offset), value);
			}
		}
	}

	[DisplayName("左侧碰撞动画")]
	[Category("Mechanism|ImpactDisplay")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:LeftSideImpactActionAnim")]
	public UAnimMontage LeftSideImpactActionAnim
	{
		get
		{
			CheckDestroyed();
			if (!LeftSideImpactActionAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:LeftSideImpactActionAnim");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, LeftSideImpactActionAnim_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeftSideImpactActionAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:LeftSideImpactActionAnim");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, LeftSideImpactActionAnim_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Mechanism|ImpactDisplay")]
	[DisplayName("右侧碰撞动画")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:RightSideImpactActionAnim")]
	public UAnimMontage RightSideImpactActionAnim
	{
		get
		{
			CheckDestroyed();
			if (!RightSideImpactActionAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:RightSideImpactActionAnim");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, RightSideImpactActionAnim_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RightSideImpactActionAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:RightSideImpactActionAnim");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, RightSideImpactActionAnim_Offset), value);
			}
		}
	}

	[DisplayName("单位交互ID")]
	[Category("Mechanism|Interact")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:InteractiveUnitID")]
	public int InteractiveUnitID
	{
		get
		{
			CheckDestroyed();
			if (!InteractiveUnitID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:InteractiveUnitID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, InteractiveUnitID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractiveUnitID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:InteractiveUnitID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, InteractiveUnitID_Offset), value);
			}
		}
	}

	[Tooltip("为0则使用表格数据")]
	[DisplayName("默认单位交互组ID")]
	[Category("Mechanism|Interact")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:DefalutInteractiveGroupID")]
	public int DefalutInteractiveGroupID
	{
		get
		{
			CheckDestroyed();
			if (!DefalutInteractiveGroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:DefalutInteractiveGroupID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DefalutInteractiveGroupID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefalutInteractiveGroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:DefalutInteractiveGroupID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DefalutInteractiveGroupID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Mechanism|Interact")]
	[DisplayName("商店ID")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:ShopID")]
	public int ShopID
	{
		get
		{
			CheckDestroyed();
			if (!ShopID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:ShopID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ShopID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShopID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:ShopID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ShopID_Offset), value);
			}
		}
	}

	[DisplayName("功能列表")]
	[Category("Mechanism|Interact")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:InteractFuncList")]
	public TArrayReadWrite<int> InteractFuncList
	{
		get
		{
			CheckDestroyed();
			if (!InteractFuncList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:InteractFuncList");
				return null;
			}
			if (InteractFuncList_Marshaler == null)
			{
				InteractFuncList_Marshaler = new TArrayReadWriteMarshaler<int>(1, InteractFuncList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return InteractFuncList_Marshaler.FromNative(IntPtr.Add(base.Address, InteractFuncList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Mechanism|Interact")]
	[DisplayName("交互奖励掉落组ID")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:RewardDropID")]
	public int RewardDropID
	{
		get
		{
			CheckDestroyed();
			if (!RewardDropID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:RewardDropID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RewardDropID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RewardDropID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:RewardDropID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RewardDropID_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[DisplayName("交互锚点Override")]
	[Category("Mechanism|Interact")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:InteractAnchorOverride")]
	public FName InteractAnchorOverride
	{
		get
		{
			CheckDestroyed();
			if (!InteractAnchorOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:InteractAnchorOverride");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, InteractAnchorOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractAnchorOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:InteractAnchorOverride");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, InteractAnchorOverride_Offset), value);
			}
		}
	}

	[DisplayName("材料(声音相关)")]
	[UProperty]
	[Category("InteractConfig")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:ObjectMaterial")]
	public InteractiveObjectMaterial ObjectMaterial
	{
		get
		{
			CheckDestroyed();
			if (!ObjectMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:ObjectMaterial");
				return InteractiveObjectMaterial.Default;
			}
			return EnumMarshaler<InteractiveObjectMaterial>.FromNative(IntPtr.Add(base.Address, ObjectMaterial_Offset), 0, ObjectMaterial_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ObjectMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:ObjectMaterial");
			}
			else
			{
				EnumMarshaler<InteractiveObjectMaterial>.ToNative(IntPtr.Add(base.Address, ObjectMaterial_Offset), 0, ObjectMaterial_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("多周目数据不重置")]
	[UProperty]
	[EditAnywhere]
	[Category("多周目")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:PersistentDataDontResetOnNewGamePlus")]
	public bool PersistentDataDontResetOnNewGamePlus
	{
		get
		{
			CheckDestroyed();
			if (!PersistentDataDontResetOnNewGamePlus_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PersistentDataDontResetOnNewGamePlus");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PersistentDataDontResetOnNewGamePlus_Offset), 0, PersistentDataDontResetOnNewGamePlus_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PersistentDataDontResetOnNewGamePlus_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PersistentDataDontResetOnNewGamePlus");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PersistentDataDontResetOnNewGamePlus_Offset), 0, PersistentDataDontResetOnNewGamePlus_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Control|Flying")]
	[DisplayName("启用飞行高度限制")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableFlyCtrl")]
	public bool bEnableFlyCtrl
	{
		get
		{
			CheckDestroyed();
			if (!bEnableFlyCtrl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableFlyCtrl");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableFlyCtrl_Offset), 0, bEnableFlyCtrl_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableFlyCtrl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableFlyCtrl");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableFlyCtrl_Offset), 0, bEnableFlyCtrl_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("飞行高度限制检测时间间隔（秒）")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Control|Flying")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:CheckInterval")]
	public float CheckInterval
	{
		get
		{
			CheckDestroyed();
			if (!CheckInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:CheckInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CheckInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CheckInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:CheckInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CheckInterval_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("射线忽略ActorTag列表")]
	[Category("Control|Flying")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:TraceIgnoreActorTags")]
	public TArrayReadWrite<FName> TraceIgnoreActorTags
	{
		get
		{
			CheckDestroyed();
			if (!TraceIgnoreActorTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TraceIgnoreActorTags");
				return null;
			}
			if (TraceIgnoreActorTags_Marshaler == null)
			{
				TraceIgnoreActorTags_Marshaler = new TArrayReadWriteMarshaler<FName>(1, TraceIgnoreActorTags_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return TraceIgnoreActorTags_Marshaler.FromNative(IntPtr.Add(base.Address, TraceIgnoreActorTags_Offset));
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Category("Control|Flying")]
	[DisplayName("低空飞行限制高度")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:FlyHeightMin")]
	public float FlyHeightMin
	{
		get
		{
			CheckDestroyed();
			if (!FlyHeightMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FlyHeightMin");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FlyHeightMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FlyHeightMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FlyHeightMin");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FlyHeightMin_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Control|Flying")]
	[DisplayName("高空飞行限制高度")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:FlyHeightMax")]
	public float FlyHeightMax
	{
		get
		{
			CheckDestroyed();
			if (!FlyHeightMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FlyHeightMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FlyHeightMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FlyHeightMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FlyHeightMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FlyHeightMax_Offset), value);
			}
		}
	}

	[Category("Control|Flying")]
	[DisplayName("高空飞行限制绝对高度")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:FlyHeightMaxAbs")]
	public float FlyHeightMaxAbs
	{
		get
		{
			CheckDestroyed();
			if (!FlyHeightMaxAbs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FlyHeightMaxAbs");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FlyHeightMaxAbs_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FlyHeightMaxAbs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:FlyHeightMaxAbs");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FlyHeightMaxAbs_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("低空限制上推冲量")]
	[BlueprintReadWrite]
	[Category("Control|Flying")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:PushUpImpulse")]
	public float PushUpImpulse
	{
		get
		{
			CheckDestroyed();
			if (!PushUpImpulse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PushUpImpulse");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PushUpImpulse_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PushUpImpulse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PushUpImpulse");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PushUpImpulse_Offset), value);
			}
		}
	}

	[Category("Control|Flying")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("高空限制下推冲量（正值）")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:PushDownImpulse")]
	public float PushDownImpulse
	{
		get
		{
			CheckDestroyed();
			if (!PushDownImpulse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PushDownImpulse");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PushDownImpulse_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PushDownImpulse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PushDownImpulse");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PushDownImpulse_Offset), value);
			}
		}
	}

	[Category("Control|Flying")]
	[DisplayName("低空限制锁定Z高度或者加推力")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bLockZ")]
	public bool bLockZ
	{
		get
		{
			CheckDestroyed();
			if (!bLockZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bLockZ");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockZ_Offset), 0, bLockZ_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bLockZ");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockZ_Offset), 0, bLockZ_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("打印HitActor和画射线")]
	[UProperty]
	[Category("Control|Flying")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bPrintHitActor")]
	public bool bPrintHitActor
	{
		get
		{
			CheckDestroyed();
			if (!bPrintHitActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bPrintHitActor");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bPrintHitActor_Offset), 0, bPrintHitActor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bPrintHitActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bPrintHitActor");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bPrintHitActor_Offset), 0, bPrintHitActor_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Control|ComboGraph")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:DefaultComboGraphIndex")]
	public int DefaultComboGraphIndex
	{
		get
		{
			CheckDestroyed();
			if (!DefaultComboGraphIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:DefaultComboGraphIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DefaultComboGraphIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultComboGraphIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:DefaultComboGraphIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DefaultComboGraphIndex_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Control|ComboGraph")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:ComboGraphTemplates")]
	public TArrayReadWrite<UCalliopeAsset> ComboGraphTemplates
	{
		get
		{
			CheckDestroyed();
			if (!ComboGraphTemplates_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:ComboGraphTemplates");
				return null;
			}
			if (ComboGraphTemplates_Marshaler == null)
			{
				ComboGraphTemplates_Marshaler = new TArrayReadWriteMarshaler<UCalliopeAsset>(1, ComboGraphTemplates_PropertyAddress, CachedMarshalingDelegates<UCalliopeAsset, UObjectMarshaler<UCalliopeAsset>>.FromNative, CachedMarshalingDelegates<UCalliopeAsset, UObjectMarshaler<UCalliopeAsset>>.ToNative);
			}
			return ComboGraphTemplates_Marshaler.FromNative(IntPtr.Add(base.Address, ComboGraphTemplates_Offset));
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:ComboGraphTemplatesPath")]
	public TArrayReadWrite<string> ComboGraphTemplatesPath
	{
		get
		{
			CheckDestroyed();
			if (!ComboGraphTemplatesPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:ComboGraphTemplatesPath");
				return null;
			}
			if (ComboGraphTemplatesPath_Marshaler == null)
			{
				ComboGraphTemplatesPath_Marshaler = new TArrayReadWriteMarshaler<string>(1, ComboGraphTemplatesPath_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return ComboGraphTemplatesPath_Marshaler.FromNative(IntPtr.Add(base.Address, ComboGraphTemplatesPath_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Control|ComboGraph")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableDebugComboGraph")]
	public bool bEnableDebugComboGraph
	{
		get
		{
			CheckDestroyed();
			if (!bEnableDebugComboGraph_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableDebugComboGraph");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableDebugComboGraph_Offset), 0, bEnableDebugComboGraph_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableDebugComboGraph_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableDebugComboGraph");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableDebugComboGraph_Offset), 0, bEnableDebugComboGraph_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("启用炮台式转向控制")]
	[Category("Control|Turret")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableTurretControl")]
	public bool bEnableTurretControl
	{
		get
		{
			CheckDestroyed();
			if (!bEnableTurretControl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableTurretControl");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableTurretControl_Offset), 0, bEnableTurretControl_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableTurretControl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bEnableTurretControl");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableTurretControl_Offset), 0, bEnableTurretControl_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Control|Turret")]
	[EditAnywhere]
	[DisplayName("炮台转向最小响应角度")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:TurretTurnTriggerYaw")]
	public float TurretTurnTriggerYaw
	{
		get
		{
			CheckDestroyed();
			if (!TurretTurnTriggerYaw_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TurretTurnTriggerYaw");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TurretTurnTriggerYaw_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TurretTurnTriggerYaw_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TurretTurnTriggerYaw");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TurretTurnTriggerYaw_Offset), value);
			}
		}
	}

	[DisplayName("炮台转向延迟时长")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Control|Turret")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:TurretTurnDelay")]
	public float TurretTurnDelay
	{
		get
		{
			CheckDestroyed();
			if (!TurretTurnDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TurretTurnDelay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TurretTurnDelay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TurretTurnDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TurretTurnDelay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TurretTurnDelay_Offset), value);
			}
		}
	}

	[DisplayName("炮台转向时长")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Control|Turret")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:TurretTurnBlendTime")]
	public float TurretTurnBlendTime
	{
		get
		{
			CheckDestroyed();
			if (!TurretTurnBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TurretTurnBlendTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TurretTurnBlendTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TurretTurnBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TurretTurnBlendTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TurretTurnBlendTime_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Camera|CameraGraph")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:CameraGraphClass")]
	public TSubclassOf<GSCameraGraph> CameraGraphClass
	{
		get
		{
			CheckDestroyed();
			if (!CameraGraphClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:CameraGraphClass");
				return default(TSubclassOf<GSCameraGraph>);
			}
			return TSubclassOfMarshaler<GSCameraGraph>.FromNative(IntPtr.Add(base.Address, CameraGraphClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraGraphClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:CameraGraphClass");
			}
			else
			{
				TSubclassOfMarshaler<GSCameraGraph>.ToNative(IntPtr.Add(base.Address, CameraGraphClass_Offset), value);
			}
		}
	}

	[DisplayName("这个角色是个演员")]
	[Category("Character|Performer")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bCanAsPerformer")]
	public bool bCanAsPerformer
	{
		get
		{
			CheckDestroyed();
			if (!bCanAsPerformer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bCanAsPerformer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCanAsPerformer_Offset), 0, bCanAsPerformer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCanAsPerformer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bCanAsPerformer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCanAsPerformer_Offset), 0, bCanAsPerformer_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("Character|Performer")]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("表演结束自动贴地")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bBowWhenAfterShow")]
	public bool bBowWhenAfterShow
	{
		get
		{
			CheckDestroyed();
			if (!bBowWhenAfterShow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bBowWhenAfterShow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bBowWhenAfterShow_Offset), 0, bBowWhenAfterShow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bBowWhenAfterShow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bBowWhenAfterShow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bBowWhenAfterShow_Offset), 0, bBowWhenAfterShow_PropertyAddress.Address, value);
			}
		}
	}

	[EditInstanceOnly]
	[DisplayName("演员默认候场状态")]
	[Category("Character|Performer")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bWaitingPerformer")]
	public bool bWaitingPerformer
	{
		get
		{
			CheckDestroyed();
			if (!bWaitingPerformer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bWaitingPerformer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bWaitingPerformer_Offset), 0, bWaitingPerformer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bWaitingPerformer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bWaitingPerformer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bWaitingPerformer_Offset), 0, bWaitingPerformer_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditInstanceOnly]
	[UProperty]
	[UMeta(MDProp.EditCondition, "bWaitingPerformer")]
	[DisplayName("回家时自动候场")]
	[Category("Character|Performer")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bWaitingWhenReturnHome")]
	public bool bWaitingWhenReturnHome
	{
		get
		{
			CheckDestroyed();
			if (!bWaitingWhenReturnHome_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bWaitingWhenReturnHome");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bWaitingWhenReturnHome_Offset), 0, bWaitingWhenReturnHome_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bWaitingWhenReturnHome_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bWaitingWhenReturnHome");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bWaitingWhenReturnHome_Offset), 0, bWaitingWhenReturnHome_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditInstanceOnly]
	[Category("Character|Performer")]
	[DisplayName("在原地候场")]
	[UMeta(MDProp.EditCondition, "bWaitingPerformer & !bUseSceneItemPosition")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bStandingWaiting")]
	public bool bStandingWaiting
	{
		get
		{
			CheckDestroyed();
			if (!bStandingWaiting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bStandingWaiting");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bStandingWaiting_Offset), 0, bStandingWaiting_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bStandingWaiting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bStandingWaiting");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bStandingWaiting_Offset), 0, bStandingWaiting_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "bWaitingPerformer & !bStandingWaiting")]
	[DisplayName("使用SceneItem标识候场位置")]
	[Category("Character|Performer")]
	[BlueprintReadWrite]
	[EditInstanceOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bUseSceneItemPosition")]
	public bool bUseSceneItemPosition
	{
		get
		{
			CheckDestroyed();
			if (!bUseSceneItemPosition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bUseSceneItemPosition");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseSceneItemPosition_Offset), 0, bUseSceneItemPosition_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseSceneItemPosition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bUseSceneItemPosition");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseSceneItemPosition_Offset), 0, bUseSceneItemPosition_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("候场位置的SceneItem的Tag")]
	[UMeta(MDProp.EditCondition, "bWaitingPerformer & !bStandingWaiting & bUseSceneItemPosition")]
	[UProperty]
	[EditInstanceOnly]
	[BlueprintReadWrite]
	[Category("Character|Performer")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:WaitingLocationItemTag")]
	public FName WaitingLocationItemTag
	{
		get
		{
			CheckDestroyed();
			if (!WaitingLocationItemTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:WaitingLocationItemTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, WaitingLocationItemTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaitingLocationItemTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:WaitingLocationItemTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, WaitingLocationItemTag_Offset), value);
			}
		}
	}

	[Category("Character|Performer")]
	[UProperty]
	[EditInstanceOnly]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "bWaitingPerformer & !bStandingWaiting & !bUseSceneItemPosition")]
	[DisplayName("候场时位置")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:WaitingLocation")]
	public FVector WaitingLocation
	{
		get
		{
			CheckDestroyed();
			if (!WaitingLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:WaitingLocation");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, WaitingLocation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaitingLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:WaitingLocation");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, WaitingLocation_Offset), value);
			}
		}
	}

	[UProperty]
	[EditInstanceOnly]
	[BlueprintReadWrite]
	[DisplayName("候场时朝向")]
	[Category("Character|Performer")]
	[UMeta(MDProp.EditCondition, "bWaitingPerformer & !bStandingWaiting & !bUseSceneItemPosition")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:WaitingRotation")]
	public FRotator WaitingRotation
	{
		get
		{
			CheckDestroyed();
			if (!WaitingRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:WaitingRotation");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, WaitingRotation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaitingRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:WaitingRotation");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, WaitingRotation_Offset), value);
			}
		}
	}

	[EditInstanceOnly]
	[DisplayName("候场动作")]
	[UProperty]
	[Category("Character|Performer")]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "bWaitingPerformer & !bStandingWaiting & !bUseSceneItemPosition")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:WaitingAnim")]
	public UAnimMontage WaitingAnim
	{
		get
		{
			CheckDestroyed();
			if (!WaitingAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:WaitingAnim");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, WaitingAnim_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaitingAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:WaitingAnim");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, WaitingAnim_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Character|Performer")]
	[DisplayName("候场状态配置")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:WaitingStateConfig")]
	public FPerformerStateConfig WaitingStateConfig
	{
		get
		{
			CheckDestroyed();
			if (!WaitingStateConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:WaitingStateConfig");
				return default(FPerformerStateConfig);
			}
			return FPerformerStateConfig.FromNative(IntPtr.Add(base.Address, WaitingStateConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaitingStateConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:WaitingStateConfig");
			}
			else
			{
				FPerformerStateConfig.ToNative(IntPtr.Add(base.Address, WaitingStateConfig_Offset), value);
			}
		}
	}

	[Category("Character|Performer")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("预表演状态配置")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:PreShowStateConfig")]
	public FPerformerStateConfig PreShowStateConfig
	{
		get
		{
			CheckDestroyed();
			if (!PreShowStateConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PreShowStateConfig");
				return default(FPerformerStateConfig);
			}
			return FPerformerStateConfig.FromNative(IntPtr.Add(base.Address, PreShowStateConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PreShowStateConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PreShowStateConfig");
			}
			else
			{
				FPerformerStateConfig.ToNative(IntPtr.Add(base.Address, PreShowStateConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Character|Performer")]
	[DisplayName("表演状态配置")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:ShowingStateConfig")]
	public FPerformerStateConfig ShowingStateConfig
	{
		get
		{
			CheckDestroyed();
			if (!ShowingStateConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:ShowingStateConfig");
				return default(FPerformerStateConfig);
			}
			return FPerformerStateConfig.FromNative(IntPtr.Add(base.Address, ShowingStateConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShowingStateConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:ShowingStateConfig");
			}
			else
			{
				FPerformerStateConfig.ToNative(IntPtr.Add(base.Address, ShowingStateConfig_Offset), value);
			}
		}
	}

	[EditInstanceOnly]
	[DisplayName("NPC信息ID")]
	[BlueprintReadWrite]
	[Category("Character|NPC")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:NPCInfoID")]
	public int NPCInfoID
	{
		get
		{
			CheckDestroyed();
			if (!NPCInfoID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:NPCInfoID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NPCInfoID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NPCInfoID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:NPCInfoID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NPCInfoID_Offset), value);
			}
		}
	}

	[DisplayName("这个角色是个NPC")]
	[Category("Character|NPC")]
	[BlueprintReadWrite]
	[EditInstanceOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bCanAsNPC")]
	public bool bCanAsNPC
	{
		get
		{
			CheckDestroyed();
			if (!bCanAsNPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bCanAsNPC");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCanAsNPC_Offset), 0, bCanAsNPC_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCanAsNPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bCanAsNPC");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCanAsNPC_Offset), 0, bCanAsNPC_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Character|NPC")]
	[BlueprintReadWrite]
	[EditInstanceOnly]
	[UProperty]
	[DisplayName("NPC实例覆盖AnimConfig")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:OverrideAnimConfig")]
	public BGWDataAsset_NPCAnimInfoConfig OverrideAnimConfig
	{
		get
		{
			CheckDestroyed();
			if (!OverrideAnimConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:OverrideAnimConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_NPCAnimInfoConfig>.FromNative(IntPtr.Add(base.Address, OverrideAnimConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverrideAnimConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:OverrideAnimConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_NPCAnimInfoConfig>.ToNative(IntPtr.Add(base.Address, OverrideAnimConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("Character|Partner")]
	[DisplayName("这个角色是一个跟随伙伴")]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bCanAsFollowPartner")]
	public bool bCanAsFollowPartner
	{
		get
		{
			CheckDestroyed();
			if (!bCanAsFollowPartner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bCanAsFollowPartner");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCanAsFollowPartner_Offset), 0, bCanAsFollowPartner_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCanAsFollowPartner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bCanAsFollowPartner");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCanAsFollowPartner_Offset), 0, bCanAsFollowPartner_PropertyAddress.Address, value);
			}
		}
	}

	public FUnitSpawnInfo SpawnInfo { get; set; }

	public FServantReq ServantReq { get; set; }

	[EditAnywhere]
	[Category("阻挡反馈")]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("阻挡反馈_Debug开关")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:TouchWallFeedBack_EnableDebug")]
	public bool TouchWallFeedBack_EnableDebug
	{
		get
		{
			CheckDestroyed();
			if (!TouchWallFeedBack_EnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TouchWallFeedBack_EnableDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TouchWallFeedBack_EnableDebug_Offset), 0, TouchWallFeedBack_EnableDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TouchWallFeedBack_EnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TouchWallFeedBack_EnableDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TouchWallFeedBack_EnableDebug_Offset), 0, TouchWallFeedBack_EnableDebug_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Tooltip("不填则默认用胶囊体半径+20")]
	[DisplayName("阻挡反馈_射线检测长度")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("阻挡反馈")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:TouchWallFeedBack_TraceLength")]
	public float TouchWallFeedBack_TraceLength
	{
		get
		{
			CheckDestroyed();
			if (!TouchWallFeedBack_TraceLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TouchWallFeedBack_TraceLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TouchWallFeedBack_TraceLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TouchWallFeedBack_TraceLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TouchWallFeedBack_TraceLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TouchWallFeedBack_TraceLength_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("开启阻挡反馈监测的速度阈值")]
	[Category("阻挡反馈")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:TouchWallFeedBack_SpeedThreshold")]
	public float TouchWallFeedBack_SpeedThreshold
	{
		get
		{
			CheckDestroyed();
			if (!TouchWallFeedBack_SpeedThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TouchWallFeedBack_SpeedThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TouchWallFeedBack_SpeedThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TouchWallFeedBack_SpeedThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:TouchWallFeedBack_SpeedThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TouchWallFeedBack_SpeedThreshold_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("触发撞击动态阻挡事件的冷却保护时间")]
	[UProperty]
	[Category("阻挡反馈|动态阻挡")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:HitDynamicObstacle_ProtectTime")]
	public float HitDynamicObstacle_ProtectTime
	{
		get
		{
			CheckDestroyed();
			if (!HitDynamicObstacle_ProtectTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:HitDynamicObstacle_ProtectTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HitDynamicObstacle_ProtectTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitDynamicObstacle_ProtectTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:HitDynamicObstacle_ProtectTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HitDynamicObstacle_ProtectTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("触发悬崖失衡的速度阈值")]
	[Category("阻挡反馈|悬崖失衡")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:CliffUnbalance_SpeedThreshold")]
	public float CliffUnbalance_SpeedThreshold
	{
		get
		{
			CheckDestroyed();
			if (!CliffUnbalance_SpeedThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:CliffUnbalance_SpeedThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CliffUnbalance_SpeedThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CliffUnbalance_SpeedThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:CliffUnbalance_SpeedThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CliffUnbalance_SpeedThreshold_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("阻挡反馈|悬崖失衡")]
	[EditAnywhere]
	[UProperty]
	[DisplayName("悬崖失衡动画配置")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:CliffUnbalanceAMConfig")]
	public FCliffUnbalanceAMConfig CliffUnbalanceAMConfig
	{
		get
		{
			CheckDestroyed();
			if (!CliffUnbalanceAMConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:CliffUnbalanceAMConfig");
				return default(FCliffUnbalanceAMConfig);
			}
			return FCliffUnbalanceAMConfig.FromNative(IntPtr.Add(base.Address, CliffUnbalanceAMConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CliffUnbalanceAMConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:CliffUnbalanceAMConfig");
			}
			else
			{
				FCliffUnbalanceAMConfig.ToNative(IntPtr.Add(base.Address, CliffUnbalanceAMConfig_Offset), value);
			}
		}
	}

	[DisplayName("移除Boss血条的先决检测单位")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:BossBarObserveTamerList")]
	public TArrayReadWrite<FGsActorGuidReference> BossBarObserveTamerList
	{
		get
		{
			CheckDestroyed();
			if (!BossBarObserveTamerList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:BossBarObserveTamerList");
				return null;
			}
			if (BossBarObserveTamerList_Marshaler == null)
			{
				BossBarObserveTamerList_Marshaler = new TArrayReadWriteMarshaler<FGsActorGuidReference>(1, BossBarObserveTamerList_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative);
			}
			return BossBarObserveTamerList_Marshaler.FromNative(IntPtr.Add(base.Address, BossBarObserveTamerList_Offset));
		}
	}

	[Category("卵生怪")]
	[DisplayName("卵生怪配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:HatchConfigInfo")]
	public FHatchConfigInfo HatchConfigInfo
	{
		get
		{
			CheckDestroyed();
			if (!HatchConfigInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:HatchConfigInfo");
				return default(FHatchConfigInfo);
			}
			return FHatchConfigInfo.FromNative(IntPtr.Add(base.Address, HatchConfigInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HatchConfigInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:HatchConfigInfo");
			}
			else
			{
				FHatchConfigInfo.ToNative(IntPtr.Add(base.Address, HatchConfigInfo_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("DBC|WEFM")]
	[EditAnywhere]
	[UProperty]
	[DisplayName("常驻风源DataAsset")]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:PermanentWindMotorsDataAsset")]
	public BUC_DispLibDBCPermanentWEFMMotorDataAsset PermanentWindMotorsDataAsset
	{
		get
		{
			CheckDestroyed();
			if (!PermanentWindMotorsDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PermanentWindMotorsDataAsset");
				return null;
			}
			return UObjectMarshaler<BUC_DispLibDBCPermanentWEFMMotorDataAsset>.FromNative(IntPtr.Add(base.Address, PermanentWindMotorsDataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PermanentWindMotorsDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:PermanentWindMotorsDataAsset");
			}
			else
			{
				UObjectMarshaler<BUC_DispLibDBCPermanentWEFMMotorDataAsset>.ToNative(IntPtr.Add(base.Address, PermanentWindMotorsDataAsset_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:bDisableDataConvert")]
	public bool bDisableDataConvert
	{
		get
		{
			CheckDestroyed();
			if (!bDisableDataConvert_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bDisableDataConvert");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDisableDataConvert_Offset), 0, bDisableDataConvert_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDisableDataConvert_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ExtendConfigComp:bDisableDataConvert");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDisableDataConvert_Offset), 0, bDisableDataConvert_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		bEnablePerceptionPreview = false;
		bEnablePerceptionPreviewOutlineOnly = true;
		bEnableWakeUpLinkRangeDebug = false;
		WindyMoveAffectedAngleForward = 180f;
		PatrolMoveSpeedType = EAIMoveSpeedType.RUN;
		FindPathMoveType = EBGUMoveAIType.Flock;
		MotionMatchingState = EState_MM.None;
		EnablePatrolOnStart = true;
		bEnableMovePhysicsTransform = false;
		bEnablePhysicalMove = false;
		PhysicalGravityAddValue = 0f;
		FlyDownwardSpeedRate = 1f;
		FollowStateRotationRate = 180f;
		DefaultAwardsLevel = 1;
		TransBackDurationTime = 2f;
		ActorResetType = EBGUResetType.None;
		bCanAsPerformer = true;
		bBowWhenAfterShow = true;
		bWaitingPerformer = false;
		bWaitingWhenReturnHome = false;
		bStandingWaiting = false;
		WindyMoveAffectedAngleForward = 180f;
		DefalutInteractiveGroupID = -1;
		WaitingStateConfig = new FPerformerStateConfig
		{
			bPauseAI = true,
			bDisableCollision = true,
			bDisableMeshCollision = true,
			bDisableGravity = true,
			bCannotSelected = true,
			bInvisible = true,
			bInvincible = true,
			bPerforming = false
		};
		PreShowStateConfig = new FPerformerStateConfig
		{
			bPauseAI = true,
			bDisableCollision = false,
			bDisableMeshCollision = false,
			bDisableGravity = false,
			bCannotSelected = true,
			bInvisible = false,
			bInvincible = true,
			bPerforming = true
		};
		ShowingStateConfig = new FPerformerStateConfig
		{
			bPauseAI = true,
			bDisableCollision = true,
			bDisableMeshCollision = true,
			bDisableGravity = true,
			bCannotSelected = false,
			bInvisible = false,
			bInvincible = true,
			bPerforming = true
		};
		bCanAsNPC = false;
		bDisableDataConvert = false;
		bCanAsFollowPartner = false;
		TurnSkillConfig = new FGSTurnSkillConfig
		{
			TurnDegreeThresholdLow = 30,
			TurnDegreeThresholdHigh = 105
		};
		HitDynamicObstacle_ProtectTime = 1f;
		TouchWallFeedBack_SpeedThreshold = 200f;
		InterruptAiConversationWhenIntoBattle = true;
	}

	[USharpPath("/Script/b1-Managed.BUS_ExtendConfigComp:PreSaveCS")]
	protected override void PreSaveCS_Implementation()
	{
		base.PreSaveCS_Implementation();
		SyncCalliopeAssetPath();
	}

	private void SyncCalliopeAssetPath()
	{
		StateGraphTemplatePath = null;
		if (StateGraphTemplate != null)
		{
			StateGraphTemplatePath = StateGraphTemplate.GetPathName();
		}
		OtherFsmTemplatesPath.Clear();
		foreach (UCalliopeAsset otherFsmTemplate in OtherFsmTemplates)
		{
			if (otherFsmTemplate != null)
			{
				OtherFsmTemplatesPath.Add(otherFsmTemplate.GetPathName());
			}
		}
		FsmSubMachinePathOverride.Clear();
		foreach (KeyValuePair<FGameplayTag, UCalliopeAsset> item in FsmSubMachineOverride)
		{
			FsmSubMachinePathOverride[item.Key] = item.Value.GetPathName();
		}
		PhaseStateGraphTemplatePath = null;
		if (PhaseStateGraphTemplate != null)
		{
			PhaseStateGraphTemplatePath = PhaseStateGraphTemplate.GetPathName();
		}
		ComboGraphTemplatesPath.Clear();
		foreach (UCalliopeAsset comboGraphTemplate in ComboGraphTemplates)
		{
			if (comboGraphTemplate != null)
			{
				ComboGraphTemplatesPath.Add(comboGraphTemplate.GetPathName());
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		if (!bDisableDataConvert)
		{
			OnAIDataConvert(Owner);
			OnMoveDataConvert();
			OnDispDataConvert();
			OnAudioDataConvert();
			OnSkillDataConvert();
			OnMechanismDataConvert();
			OnControlDataConvert();
			OnCharacterDataConvert();
			OnBirthDataConvert();
			OnCliffUnbalanceDataConvert();
			OnBossBarGroupDataConvert();
			OnHatchDataConvert();
			OnDBCDataConvert(Owner);
		}
	}

	private void OnAIDataConvert(AActor Owner)
	{
		RequireWritableData<BUC_GroupAIData>()?.SetGroupAIBPConfig(GroupAIBPConfig);
		BUC_BehaviorGraphData bUC_BehaviorGraphData = RequireWritableData<BUC_BehaviorGraphData>();
		if (bUC_BehaviorGraphData != null)
		{
			bUC_BehaviorGraphData.BehaviorGraphTemplateID = BehaviorGraphTemplateID;
			bUC_BehaviorGraphData.DialogueGraphTemplateID = DialogueGraphTemplateID;
		}
		BUC_FsmData bUC_FsmData = RequireWritableData<BUC_FsmData>();
		if (bUC_FsmData != null)
		{
			if (StateGraphTemplatePath != null)
			{
				bUC_FsmData.TemplatePaths.Add(StateGraphTemplatePath);
			}
			foreach (string item in OtherFsmTemplatesPath)
			{
				bUC_FsmData.TemplatePaths.Add(item);
			}
			foreach (KeyValuePair<FGameplayTag, string> item2 in FsmSubMachinePathOverride)
			{
				bUC_FsmData.SubMachineOverrideMap[item2.Key] = item2.Value;
			}
			if (PhaseStateGraphTemplatePath != null)
			{
				bUC_FsmData.PhaseTemplatePath = PhaseStateGraphTemplatePath;
			}
		}
		BUC_BattleAICooperativeData bUC_BattleAICooperativeData = RequireWritableData<BUC_BattleAICooperativeData>();
		if (bUC_BattleAICooperativeData != null)
		{
			bUC_BattleAICooperativeData.BattleSC_GUID = BattleSC_GUID.TagName.PlainName;
			foreach (EBattleCoopReason item3 in SpecificEventListen_BattleSC)
			{
				bUC_BattleAICooperativeData.SpecificEventListen.Add(item3);
			}
		}
		BUC_AiConversationData bUC_AiConversationData = RequireWritableData<BUC_AiConversationData>();
		if (bUC_AiConversationData != null)
		{
			bUC_AiConversationData.AIConversationEvntIDList = AIConversationEventIDList.ToList();
			bUC_AiConversationData.InterruptAiConversationWhenIntoBattle = InterruptAiConversationWhenIntoBattle;
		}
		BUC_AiConversationBlackboard bUC_AiConversationBlackboard = RequireWritableData<BUC_AiConversationBlackboard>();
		if (bUC_AiConversationBlackboard != null)
		{
			foreach (FAiConversationFact aIConversationFact in AIConversationFacts)
			{
				bUC_AiConversationBlackboard.RegistFactData(aIConversationFact);
			}
		}
		RequireWritableData<BUC_IntimidateData>()?.SetGroupAIBPConfig(IntimidateBPConfig);
		RequireWritableData<BUC_ArmorData>()?.SetArmorSetting(GSArmorSettingInBP, Owner, IsSetDefault: true, IsReset: false);
		BUC_WakeUpData bUC_WakeUpData = RequireWritableData<BUC_WakeUpData>();
		if (bUC_WakeUpData != null)
		{
			FGSWakeUpConfig wakeUpConfig = WakeUpConfig;
			bUC_WakeUpData.OnFightSkillID = wakeUpConfig.OnFightSkillID;
			bUC_WakeUpData.OnFightSkillIDBack = wakeUpConfig.DirectionOnFightSkillConfig.OnFightSkillIDBack;
			bUC_WakeUpData.OnFightSkillIDLeft = wakeUpConfig.DirectionOnFightSkillConfig.OnFightSkillIDLeft;
			bUC_WakeUpData.OnFightSkillIDRight = wakeUpConfig.DirectionOnFightSkillConfig.OnFightSkillIDRight;
			bUC_WakeUpData.AfterSequenceOverrideOnFightSkillID = OnFightSkillIDAfterSequence;
			bUC_WakeUpData.AfterSequenceOverrideOnFightSkillIDBack = OnFightSkillIDBackAfterSequence;
			bUC_WakeUpData.AfterSequenceOverrideOnFightSkillIDLeft = OnFightSkillIDLeftAfterSequence;
			bUC_WakeUpData.AfterSequenceOverrideOnFightSkillIDRight = OnFightSkillIDRightAfterSequence;
			bUC_WakeUpData.bJustUseOnFightSkillFirstTime = wakeUpConfig.bJustUseOnFightSkillFirstTime;
			if (wakeUpConfig.SurpriseSkillID == null)
			{
				return;
			}
			bUC_WakeUpData.SurpriseSkillID = new List<int>();
			for (int i = 0; i < wakeUpConfig.SurpriseSkillID.Count; i++)
			{
				bUC_WakeUpData.SurpriseSkillID.Add(wakeUpConfig.SurpriseSkillID[i]);
			}
			bUC_WakeUpData.WakeUpLinkEnable = wakeUpConfig.WakeUpLinkEnable;
			bUC_WakeUpData.CanTriggerWakeUpLinkWhenDead = wakeUpConfig.CanTriggerWakeUpLinkWhenDead;
			bUC_WakeUpData.UseManualSelect = wakeUpConfig.UseManualSelect;
			bUC_WakeUpData.ManualTargetGuidList.Clear();
			foreach (BUTamerActor targetTamer in wakeUpConfig.TargetTamerList)
			{
				bUC_WakeUpData.ManualTargetGuidList.Add(BGU_DataUtil.GetActorGuid(targetTamer, bFindFromComponent: true));
			}
			bUC_WakeUpData.UseRangeSelect = wakeUpConfig.UseRangeSelect;
			bUC_WakeUpData.RangeType = wakeUpConfig.RangeType;
			bUC_WakeUpData.RangeParam_1 = wakeUpConfig.RangeParam_1;
			bUC_WakeUpData.RangeParam_2 = wakeUpConfig.RangeParam_2;
			bUC_WakeUpData.RangeParam_3 = wakeUpConfig.RangeParam_3;
			bUC_WakeUpData.ResIDList = wakeUpConfig.ResIDList;
			bUC_WakeUpData.bSelectUnitHasTarget = wakeUpConfig.bSelectUnitHasTarget;
			bUC_WakeUpData.bSelectPassiveUnit = wakeUpConfig.bSelectPassiveUnit;
		}
		BUC_UnitDebugData bUC_UnitDebugData = RequireWritableData<BUC_UnitDebugData>();
		if (bUC_UnitDebugData != null)
		{
			bUC_UnitDebugData.AIState = AIState;
			bUC_UnitDebugData.LastSkillBlockReason = LastSkillBlockReason;
			bUC_UnitDebugData.UserHandle = UserHandle;
			bUC_UnitDebugData.bLogVerbose = bLogVerbose;
			bUC_UnitDebugData.bEnablePerceptionPreview = bEnablePerceptionPreview;
			bUC_UnitDebugData.bEnablePerceptionPreviewOutlineOnly = bEnablePerceptionPreviewOutlineOnly;
			bUC_UnitDebugData.bEnableWakeUpLinkRangeDebug = bEnableWakeUpLinkRangeDebug;
		}
	}

	private void OnMoveDataConvert()
	{
		b1.BUC_HardMoveData bUC_HardMoveData = RequireWritableData<b1.BUC_HardMoveData>();
		if (bUC_HardMoveData != null)
		{
			bUC_HardMoveData.bEnableHardMove = bEnableHardMove;
			bUC_HardMoveData.WindyMoveAffectedAngleForward = WindyMoveAffectedAngleForward;
			bUC_HardMoveData.WindyMoveForwardBuffID = WindyMoveForwardBuffID;
			bUC_HardMoveData.WindyMoveBackwardBuffID = WindyMoveBackwardBuffID;
			bUC_HardMoveData.WindyMoveEnterSkill = WindyMoveEnterSkill;
			bUC_HardMoveData.MuddyMoveEnterSkill = MuddyMoveEnterSkill;
			bUC_HardMoveData.FrozenMoveEnterSkill = FrozenMoveEnterSkill;
			bUC_HardMoveData.SpiderSilkyMoveEnterSkill = SpiderSilkyMoveEnterSkill;
			bUC_HardMoveData.WindyMoveForwardBlendAnim = WindyMoveForwardBlendAnim;
		}
		BUC_PatrolData bUC_PatrolData = RequireWritableData<BUC_PatrolData>();
		if (bUC_PatrolData != null)
		{
			bUC_PatrolData.CopyBPDataToData(PatrolType, bDisableRestartOnLeaveFight, bDisableRestartOnReset, MotionMatchingState, FindPathMoveType, PatrolMoveSpeedType, EnablePatrolOnStart, PatrolBuff, ABPSettingForPatrol, MoveAcceptableRadius, StartWaitAMProbability, StartWaitAM, TurnSkillConfig, RandomPatrolConfig, SplinePatrolConfig, MultiSplinePatrolConfig, LeisureConfig, FollowPatrolConfig, GroupPatrolConfig);
			bUC_PatrolData.LeisureConfig.ReplaceLeisureSequenceID = ReplaceLeisureSequenceID;
			bUC_PatrolData.LeisureConfig.AfterSequenceOverrideLeisureAnim = LeisureAnimAfterSequence;
		}
		b1.BUC_MovePhysicsTransformData bUC_MovePhysicsTransformData = RequireWritableData<b1.BUC_MovePhysicsTransformData>();
		if (bUC_MovePhysicsTransformData != null)
		{
			bUC_MovePhysicsTransformData.bEnableMovePhysicsTransform = bEnableMovePhysicsTransform;
			bUC_MovePhysicsTransformData.GravityAddValue = PhysicsTransformGravityAddValue;
			bUC_MovePhysicsTransformData.RotationTypeDurningPhysicsState = RotationTypeDurningPhysicsState;
		}
		b1.BUC_GlideMoveData bUC_GlideMoveData = RequireWritableData<b1.BUC_GlideMoveData>();
		if (bUC_GlideMoveData != null)
		{
			bUC_GlideMoveData.GlideSlopeEdgeAngle = GlideSlopeEdgeAngle;
			bUC_GlideMoveData.MaxGlideSpeed = MaxGlideSpeed;
			bUC_GlideMoveData.MinGlideSpeed = MinGlideSpeed;
			bUC_GlideMoveData.MaxSpeedAngle = MaxSpeedAngle;
			bUC_GlideMoveData.MinSpeedAngle = MinSpeedAngle;
			bUC_GlideMoveData.MoveControlReactionSpeed = MoveControlReactionSpeed;
			bUC_GlideMoveData.MoveControlAddMaxSpeed = MoveControlAddMaxSpeed;
			bUC_GlideMoveData.PreventGlideSkillID = PreventGlideSkillID;
		}
		b1.BUC_PhysicalMoveData bUC_PhysicalMoveData = RequireWritableData<b1.BUC_PhysicalMoveData>();
		if (bUC_PhysicalMoveData != null)
		{
			bUC_PhysicalMoveData.bConfigEnablePhysicalMove = bEnablePhysicalMove;
			bUC_PhysicalMoveData.GravityAddValue = PhysicalGravityAddValue;
			bUC_PhysicalMoveData.PhysicalMoveBuff = PhysicalMoveBuff.ToList();
			bUC_PhysicalMoveData.PhysicalMoveBuffNeedSpeed = PhysicalMoveBuffNeedSpeed;
			bUC_PhysicalMoveData.PhysicalMoveBuffProtectTime = PhysicalMoveBuffProtectTime;
			bUC_PhysicalMoveData.bUseSocketDirection = bUseSocketDirection;
			bUC_PhysicalMoveData.DirectionBaseSocekt = DirectionBaseSocekt;
			bUC_PhysicalMoveData.ForwardSocket = ForwardSocket;
			bUC_PhysicalMoveData.AccuratelyMoveDistance = AccuratelyMoveDistance;
			bUC_PhysicalMoveData.bSimulatePhysicsWhenAttacking = bSimulatePhysicsWhenAttacking;
		}
		b1.BUC_SplineFlyMoveData bUC_SplineFlyMoveData = RequireWritableData<b1.BUC_SplineFlyMoveData>();
		if (bUC_SplineFlyMoveData != null)
		{
			bUC_SplineFlyMoveData.HorizontalMoveSpeed = HorizontalMoveSpeed;
			bUC_SplineFlyMoveData.VerticalMoveSpeed = VerticalMoveSpeed;
			bUC_SplineFlyMoveData.MaxMoveDistance = MaxMoveDistance;
			bUC_SplineFlyMoveData.FlyDownwardSpeedRate = FlyDownwardSpeedRate;
			bUC_SplineFlyMoveData.FlyDownwardJudgeAngle = FlyDownwardJudgeAngle;
		}
		b1.BUC_RelativeFloatMoveData bUC_RelativeFloatMoveData = RequireWritableData<b1.BUC_RelativeFloatMoveData>();
		if (bUC_RelativeFloatMoveData != null)
		{
			bUC_RelativeFloatMoveData.FloatRelativeSpotActor = FloatRelativeSpotActor.Value;
			bUC_RelativeFloatMoveData.RelativeFloatHeight = RelativeFloatHeight;
		}
		BUC_DumperTruckData bUC_DumperTruckData = RequireWritableData<BUC_DumperTruckData>();
		if (bUC_DumperTruckData != null)
		{
			bUC_DumperTruckData.SplineList = new List<USplineComponent>();
			for (int i = 0; i < SplineList.Count; i++)
			{
				USplineComponent componentByClass = SplineList[i].Value.GetComponentByClass<USplineComponent>();
				if (componentByClass != null)
				{
					bUC_DumperTruckData.SplineList.Add(componentByClass);
				}
			}
			bUC_DumperTruckData.BeginTriggerBase = BeginTriggerBox.Value;
			bUC_DumperTruckData.EndTriggerBase = EndTriggerBox.Value;
			bUC_DumperTruckData.TurnSpeed = TurnSpeed;
			bUC_DumperTruckData.Acceleration = Acceleration;
			bUC_DumperTruckData.MaxSpeed = MaxSpeed;
			bUC_DumperTruckData.MinSpeed = MinSpeed;
			bUC_DumperTruckData.StartSpeed = StartSpeed;
			bUC_DumperTruckData.MultiSplineDefaultIndex = MultiSplineDefaultIndex;
			bUC_DumperTruckData.FirstAccelerationIndex = FirstAccelerationIndex;
			bUC_DumperTruckData.SecondAccelerationIndex = SecondAccelerationIndex;
			bUC_DumperTruckData.SpeedRateParam = SpeedRateParam;
			bUC_DumperTruckData.RotatorWaitTime = RotatorWaitTime;
			bUC_DumperTruckData.SpeedRateParamCurve = SpeedRateParamCurve;
			bUC_DumperTruckData.StartPointIndex = StartPointIndex;
			bUC_DumperTruckData.IsStartForward = IsStartForward;
			bUC_DumperTruckData.UseCurveTime = UseCurveTime;
			bUC_DumperTruckData.ForwardBuffID = ForwardBuffID;
			bUC_DumperTruckData.BackBuffID = BackBuffID;
		}
		b1.BUC_RootMotionFollowData bUC_RootMotionFollowData = RequireWritableData<b1.BUC_RootMotionFollowData>();
		if (bUC_RootMotionFollowData != null)
		{
			bUC_RootMotionFollowData.FollowStateRotationRate = FollowStateRotationRate;
		}
	}

	private void OnDispDataConvert()
	{
		RequireWritableData<b1.BUC_ProceduralEnvInteractionTriggerData>()?.CopyBPDataToData(bEnableEnvInteraction, TraceDelay, TraceLength, Size, SampleCollectionProtectTime, OverrideSurfaceType, OverrideSurfacePersistTime, OverrideSurfaceFXActorTag, bDrawDebug, DebugDrawOffset);
		b1.BUC_FXDetachData bUC_FXDetachData = RequireWritableData<b1.BUC_FXDetachData>();
		if (bUC_FXDetachData != null)
		{
			bUC_FXDetachData.FXComponentName = FXComponentName.ToList();
		}
		BUC_GlobalFXData bUC_GlobalFXData = RequireWritableData<BUC_GlobalFXData>();
		if (bUC_GlobalFXData != null)
		{
			foreach (FGlobalFXConfigInfo globalFXConfig in GlobalFXConfigList)
			{
				FGlobalFXRef value = new FGlobalFXRef
				{
					FXTemplate = globalFXConfig.FXTemplate,
					BulletPositionParamName = globalFXConfig.BulletPositionParamName,
					MFSpherePosParamName = globalFXConfig.MFSpherePosParamName,
					MFSphereRadiusParamName = globalFXConfig.MFSphereRadiusParamName,
					AvoidanceMFSpherePosParamName = globalFXConfig.AvoidanceMFSpherePosParamName,
					AvoidanceMFSphereRadiusParamName = globalFXConfig.AvoidanceMFSphereRadiusParamName,
					FXStartPointTag = globalFXConfig.FXStartPointTag,
					FXStartPointParamName = globalFXConfig.FXStartPointParamName,
					bMFSphereRadiusParamUseArray = globalFXConfig.bMFSphereUseRadiusArray,
					bAvoidanceMFSphereRadiusParamUseArray = globalFXConfig.bAvoidanceMFSphereUseRadiusArray
				};
				bUC_GlobalFXData.FXTagMap.Add(globalFXConfig.FXTag.TagName, value);
			}
		}
		BUC_PointLightMangerData bUC_PointLightMangerData = RequireWritableData<BUC_PointLightMangerData>();
		if (bUC_PointLightMangerData != null)
		{
			bUC_PointLightMangerData.EnableTag = PointLightTag;
		}
	}

	private void OnAudioDataConvert()
	{
		BUC_AKMgrData bUC_AKMgrData = RequireWritableData<BUC_AKMgrData>();
		if (bUC_AKMgrData != null)
		{
			bUC_AKMgrData.LoopEvent = LoopEvent;
			bUC_AKMgrData.DeadEvent = DeadEvent;
		}
		RequireWritableData<BUC_BattleBGMData>()?.SetBattleBGMBPConfig(BtlBGMBPConfig);
		BUC_FootStepData bUC_FootStepData = RequireWritableData<BUC_FootStepData>();
		if (bUC_FootStepData != null)
		{
			bUC_FootStepData.DrawDebugLine = DrawDebugLine;
			bUC_FootStepData.bShowFootSpeed = bShowFootSpeed;
			bUC_FootStepData.bShowFootHeight = bShowFootHeight;
			bUC_FootStepData.bUseFarStepAudio = bUseFarStepAudio;
			bUC_FootStepData.CameraShake = CameraShake;
			bUC_FootStepData.bMultiSpdForStepAK = bMultiSpdForStepAK;
			bUC_FootStepData.bMyriapods = bMyriapods;
			bUC_FootStepData.StepAudioPath = StepAudioPath;
			bUC_FootStepData.MoveActionTypeID = MoveActionTypeID;
			bUC_FootStepData.bPrintStepAudioSwitchState = bPrintStepAudioSwitchState;
			bUC_FootStepData.DecalMaterialPath = DecalMaterialPath;
			bUC_FootStepData.FootStepDecalSize = FootStepDecalSize;
			bUC_FootStepData.FootStepDecalOffset = FootStepDecalOffset;
			bUC_FootStepData.FootStepDecalStartFadeOutTime = FootStepDecalStartFadeOutTime;
			bUC_FootStepData.FootStepDecalFadeOutDuration = FootStepDecalFadeOutDuration;
		}
		b1.BUC_FoliageInteractSoundData bUC_FoliageInteractSoundData = RequireWritableData<b1.BUC_FoliageInteractSoundData>();
		if (bUC_FoliageInteractSoundData != null)
		{
			bUC_FoliageInteractSoundData.FoliageInteractSoundPriority = FoliageInteractSoundPriority;
		}
	}

	private void OnSkillDataConvert()
	{
		BUC_BeImmobilizedData bUC_BeImmobilizedData = RequireWritableData<BUC_BeImmobilizedData>();
		if (BeImmobilizedConfig != null)
		{
			bUC_BeImmobilizedData.BeImmobilizedConfig = BeImmobilizedConfig;
		}
		BUC_PreciseDodgeData bUC_PreciseDodgeData = RequireWritableData<BUC_PreciseDodgeData>();
		if (bUC_PreciseDodgeData != null)
		{
			bUC_PreciseDodgeData.CanPreciseDodge = AutoEnablePreciseDodge;
			bUC_PreciseDodgeData.bEnableDebugInConfig = bDebugPreciseDodge;
			bUC_PreciseDodgeData.DefaultAwardsLevel = DefaultAwardsLevel;
			bUC_PreciseDodgeData.PreciseDodgeTolerantTimeSeconds = TolerantTimeSeconds;
			foreach (PreciseDodgeAwards item in Awards.ToList())
			{
				bUC_PreciseDodgeData.Awards.Add(new PreciseDodgeAwardsForData(item));
			}
		}
		BUC_PlayerTransData bUC_PlayerTransData = RequireWritableData<BUC_PlayerTransData>();
		if (bUC_PlayerTransData != null)
		{
			bUC_PlayerTransData.TransBackSkillID = TransBackSkillID;
			bUC_PlayerTransData.TransBackDurationTime = TransBackDurationTime;
		}
		BUC_AbnormalStateData bUC_AbnormalStateData = RequireWritableData<BUC_AbnormalStateData>();
		if (bUC_AbnormalStateData != null)
		{
			bUC_AbnormalStateData.DefaultAbnormalAttrConfig = AbnormalAttrConfig;
			bUC_AbnormalStateData.AbnormalStateImmueList = AbnormalStateImmueList.ToList();
			bUC_AbnormalStateData.BirthAbnormalStateList = BirthAbnormalStateList.ToList();
		}
		BUC_FallingData bUC_FallingData = RequireWritableData<BUC_FallingData>();
		if (bUC_FallingData != null)
		{
			bUC_FallingData.FallingSafeTime = FallingSafeTime;
			bUC_FallingData.CostDMG_StartHeight = CostDMG_StartHeight;
			bUC_FallingData.OverHeight_DmgAdditive_INV10000 = OverHeight_DmgAdditive_INV10000;
			bUC_FallingData.FallDmg_DmgMax_INV10000 = FallDmg_DmgMax_INV10000;
			bUC_FallingData.BaseDmg_INV10000 = BaseDmg_INV10000;
			bUC_FallingData.LandCamShakeConfig = LandCamShakeConfig;
			bUC_FallingData.EnableDodge_InFalling = EnableDodge_InFalling;
			bUC_FallingData.CanDodge_Distance = CanDodge_Distance;
			bUC_FallingData.Dodge_DmgMul = Dodge_DmgMul;
			bUC_FallingData.EnableFloorDistanceCheck = EnableFloorDistanceCheck;
		}
		if (EffectIDList_SwitchWeaponPose.Count > 0)
		{
			BUC_PlayerInputActionData bUC_PlayerInputActionData = RequireWritableData<BUC_PlayerInputActionData>();
			if (bUC_PlayerInputActionData != null)
			{
				bUC_PlayerInputActionData.EffectIDList_SwitchWeaponPose = EffectIDList_SwitchWeaponPose.ToList();
				bUC_PlayerInputActionData.TriggerEffectCoolDown_SwitchWeaponPose = TriggerEffectCoolDown_SwitchWeaponPose;
				bUC_PlayerInputActionData.LastTriggerEffectTime_SwitchWeaponPose = 0f - TriggerEffectCoolDown_SwitchWeaponPose;
			}
		}
	}

	private void OnMechanismDataConvert()
	{
		BUC_ActorInitData bUC_ActorInitData = RequireWritableData<BUC_ActorInitData>();
		if (bUC_ActorInitData != null)
		{
			bUC_ActorInitData.ActorResetType = ActorResetType;
			bUC_ActorInitData.bSaveInitData = bSaveInitData;
			bUC_ActorInitData.PersistentDataDontResetOnNewGamePlusFromConfig = PersistentDataDontResetOnNewGamePlus;
		}
		b1.BUC_ImpactActionData bUC_ImpactActionData = RequireWritableData<b1.BUC_ImpactActionData>();
		if (bUC_ImpactActionData != null)
		{
			bUC_ImpactActionData.bEnableImpactAction = bEnableImpactAction;
			bUC_ImpactActionData.EnableImplactCalculationParameter = EnableImplactCalculationParameter;
			bUC_ImpactActionData.EnableImpactActionHeightDiff = EnableImpactActionHeightDiff;
			bUC_ImpactActionData.EnableImpactAnimThreshold = EnableImpactAnimThreshold;
			bUC_ImpactActionData.LeftAngleSplitLine = LeftAngleSplitLine;
			bUC_ImpactActionData.MiddleLeftAngleSplitLine = MiddleLeftAngleSplitLine;
			bUC_ImpactActionData.MiddleRightAngleSplitLine = MiddleRightAngleSplitLine;
			bUC_ImpactActionData.RightAngleSplitLine = RightAngleSplitLine;
			bUC_ImpactActionData.ForwardImpactActionAnim = ForwardImpactActionAnim;
			bUC_ImpactActionData.LeftSideImpactActionAnim = LeftSideImpactActionAnim;
			bUC_ImpactActionData.RightSideImpactActionAnim = RightSideImpactActionAnim;
		}
		BUC_InteractData bUC_InteractData = RequireWritableData<BUC_InteractData>();
		if (bUC_InteractData == null)
		{
			return;
		}
		bUC_InteractData.InteractiveUnitID = InteractiveUnitID;
		bUC_InteractData.InstOverrideInteractiveGroupID = DefalutInteractiveGroupID;
		bUC_InteractData.ShopID = ShopID;
		bUC_InteractData.InteractFuncList = InteractFuncList.ToList();
		bUC_InteractData.RewardDropID = RewardDropID;
		bUC_InteractData.InteractAnchorOverride = InteractAnchorOverride;
		bUC_InteractData.ObjectMaterial = ObjectMaterial;
		bUC_InteractData.InstOverrideActivableDistance = -1f;
		if (bUC_InteractData.InteractiveUnitID <= 0 || !(GetOwner() as BUTamerActor != null))
		{
			return;
		}
		List<UActorComponent> list = GetOwner()?.GetComponentsByClass(UClass.GetClass<USceneComponent>());
		if (list == null)
		{
			return;
		}
		foreach (UActorComponent item in list)
		{
			USceneComponent uSceneComponent = item as USceneComponent;
			if (uSceneComponent == null || uSceneComponent.ComponentTags == null || uSceneComponent.ComponentTags.Count <= 0)
			{
				continue;
			}
			foreach (FName componentTag in uSceneComponent.ComponentTags)
			{
				if (bUC_InteractData.SceneCompTransformDict.ContainsKey(componentTag))
				{
					bUC_InteractData.SceneCompTransformDict[componentTag] = uSceneComponent.GetRelativeTransform();
				}
				else
				{
					bUC_InteractData.SceneCompTransformDict.Add(componentTag, uSceneComponent.GetRelativeTransform());
				}
			}
		}
	}

	private void OnControlDataConvert()
	{
		BUC_FlyCtrlData bUC_FlyCtrlData = RequireWritableData<BUC_FlyCtrlData>();
		if (bUC_FlyCtrlData != null)
		{
			bUC_FlyCtrlData.bEnable = bEnableFlyCtrl;
			bUC_FlyCtrlData.CheckInterval = CheckInterval;
			bUC_FlyCtrlData.TraceIgnoreActorTags = TraceIgnoreActorTags.ToList();
			bUC_FlyCtrlData.FlyHeightMin = FlyHeightMin;
			bUC_FlyCtrlData.FlyHeightMax = FlyHeightMax;
			bUC_FlyCtrlData.FlyHeightMaxAbs = FlyHeightMaxAbs;
			bUC_FlyCtrlData.LineTraceLength = FlyHeightMaxAbs + 1000f;
			bUC_FlyCtrlData.PushUpImpulse = PushUpImpulse;
			bUC_FlyCtrlData.PushDownImpulse = PushDownImpulse;
			bUC_FlyCtrlData.bLockZ = bLockZ;
			bUC_FlyCtrlData.bPrintHitActor = bPrintHitActor;
		}
		BUC_TurretControlData bUC_TurretControlData = RequireWritableData<BUC_TurretControlData>();
		if (bUC_TurretControlData != null)
		{
			bUC_TurretControlData.bEnableTurretControl = bEnableTurretControl;
			bUC_TurretControlData.Turn2CameraOriginTriggerYaw = TurretTurnTriggerYaw;
			bUC_TurretControlData.Turn2CameraOriginDelay = TurretTurnDelay;
			bUC_TurretControlData.Turn2CameraBlendTime = TurretTurnBlendTime;
		}
		BUC_ComboGraphData bUC_ComboGraphData = RequireWritableData<BUC_ComboGraphData>();
		if (bUC_ComboGraphData != null)
		{
			foreach (string item in ComboGraphTemplatesPath)
			{
				bUC_ComboGraphData.Templates.Add(item);
			}
			if (DefaultComboGraphIndex >= 0 && ComboGraphTemplatesPath.Count > DefaultComboGraphIndex)
			{
				bUC_ComboGraphData.DefaultTemplate = ComboGraphTemplatesPath[DefaultComboGraphIndex];
				bUC_ComboGraphData.bEnableDebug = bEnableDebugComboGraph;
				bUC_ComboGraphData.CurrentGraph = GameplayTagExtension.LoadGraph(bUC_ComboGraphData.DefaultTemplate);
			}
		}
		BUC_PlayerCameraData bUC_PlayerCameraData = RequireWritableData<BUC_PlayerCameraData>();
		if (bUC_PlayerCameraData != null)
		{
			GSCameraGraph cameraGraph = UObject.NewObject<GSCameraGraph>(this, CameraGraphClass.Value, default(FName), EObjectFlags.NoFlags, null, copyTransientsFromClassDefaults: false, (IntPtr)0);
			bUC_PlayerCameraData.CameraGraph = cameraGraph;
		}
	}

	private void OnCharacterDataConvert()
	{
		BUC_PerformerData bUC_PerformerData = RequireWritableData<BUC_PerformerData>();
		if (bUC_PerformerData != null)
		{
			bUC_PerformerData.bBowWhenAfterShow = bBowWhenAfterShow;
			bUC_PerformerData.bWaitingPerformer = bWaitingPerformer;
			bUC_PerformerData.bWaitingWhenReturnHome = bWaitingWhenReturnHome;
			bUC_PerformerData.bStandingWaiting = bStandingWaiting;
			bUC_PerformerData.bUseSceneItemPosition = bUseSceneItemPosition;
			bUC_PerformerData.WaitingLocationItemTag = WaitingLocationItemTag;
			bUC_PerformerData.WaitingLocation = WaitingLocation;
			bUC_PerformerData.WaitingRotation = WaitingRotation;
			bUC_PerformerData.WaitingAnim = new TWeakObject<UAnimMontage>(WaitingAnim);
			bUC_PerformerData.WaitingStateConfigData.Update(WaitingStateConfig);
			bUC_PerformerData.PreShowStateConfigData.Update(PreShowStateConfig);
			bUC_PerformerData.ShowingStateConfigData.Update(ShowingStateConfig);
		}
		BUC_NPCConfigInfoData bUC_NPCConfigInfoData = RequireWritableData<BUC_NPCConfigInfoData>();
		if (bUC_NPCConfigInfoData != null)
		{
			bUC_NPCConfigInfoData.NPCInfoID = NPCInfoID;
			bUC_NPCConfigInfoData.OverrideAnimConfig = OverrideAnimConfig;
		}
	}

	private void OnBirthDataConvert()
	{
		BUC_BirthData bUC_BirthData = RequireWritableData<BUC_BirthData>();
		if (bUC_BirthData != null)
		{
			bUC_BirthData.UnitSpawnInfo = SpawnInfo;
		}
	}

	private void OnCliffUnbalanceDataConvert()
	{
		BUC_TouchWallFeedbackData bUC_TouchWallFeedbackData = RequireWritableData<BUC_TouchWallFeedbackData>();
		if (bUC_TouchWallFeedbackData != null)
		{
			bUC_TouchWallFeedbackData.EnableDebug = TouchWallFeedBack_EnableDebug;
			bUC_TouchWallFeedbackData.TraceLength = TouchWallFeedBack_TraceLength;
			bUC_TouchWallFeedbackData.SpeedThreshold = TouchWallFeedBack_SpeedThreshold;
			bUC_TouchWallFeedbackData.HitDynamicObstacle_ProtectTime = HitDynamicObstacle_ProtectTime;
			bUC_TouchWallFeedbackData.CliffUnbalance_SpeedThreshold = CliffUnbalance_SpeedThreshold;
			bUC_TouchWallFeedbackData.UnbalanceAMConfig = CliffUnbalanceAMConfig;
		}
	}

	private void OnBossBarGroupDataConvert()
	{
		BUC_UnitBarInfoData bUC_UnitBarInfoData = RequireWritableData<BUC_UnitBarInfoData>();
		if (bUC_UnitBarInfoData == null)
		{
			return;
		}
		foreach (FGsActorGuidReference bossBarObserveTamer in BossBarObserveTamerList)
		{
			bUC_UnitBarInfoData.ObserveBoss.Add(bossBarObserveTamer.ActorGuid);
		}
	}

	private void OnHatchDataConvert()
	{
		if (HatchConfigInfo.IsValid())
		{
			b1.BUC_HatchData bUC_HatchData = RequireWritableData<b1.BUC_HatchData>();
			if (bUC_HatchData != null)
			{
				bUC_HatchData.ConfigInfo = HatchConfigInfo;
			}
		}
	}

	private void OnDBCDataConvert(AActor RealUnitOwner)
	{
		BUC_DispLibWEFMRequestsQueueData bUC_DispLibWEFMRequestsQueueData = RequireWritableData<BUC_DispLibWEFMRequestsQueueData>();
		if (bUC_DispLibWEFMRequestsQueueData != null)
		{
			USkeletalMeshComponent componentByClass = RealUnitOwner.GetComponentByClass<USkeletalMeshComponent>();
			bUC_DispLibWEFMRequestsQueueData.Init(PermanentWindMotorsDataAsset, componentByClass);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_ExtendConfigComp:PreSaveCS")]
	private static void PreSaveCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_ExtendConfigComp bUS_ExtendConfigComp = GCHelper.Find<BUS_ExtendConfigComp>(obj);
		bUS_ExtendConfigComp.PreSaveCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_ExtendConfigComp");
		GroupAIBPConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "GroupAIBPConfig");
		GroupAIBPConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GroupAIBPConfig", Classes.FStructProperty);
		BehaviorGraphTemplateID_Offset = NativeReflection.GetPropertyOffset(intPtr, "BehaviorGraphTemplateID");
		BehaviorGraphTemplateID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BehaviorGraphTemplateID", Classes.FIntProperty);
		DialogueGraphTemplateID_Offset = NativeReflection.GetPropertyOffset(intPtr, "DialogueGraphTemplateID");
		DialogueGraphTemplateID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DialogueGraphTemplateID", Classes.FIntProperty);
		StateGraphTemplate_Offset = NativeReflection.GetPropertyOffset(intPtr, "StateGraphTemplate");
		StateGraphTemplate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StateGraphTemplate", Classes.FObjectProperty);
		StateGraphTemplatePath_Offset = NativeReflection.GetPropertyOffset(intPtr, "StateGraphTemplatePath");
		StateGraphTemplatePath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StateGraphTemplatePath", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref OtherFsmTemplates_PropertyAddress, intPtr, "OtherFsmTemplates");
		OtherFsmTemplates_Offset = NativeReflection.GetPropertyOffset(intPtr, "OtherFsmTemplates");
		OtherFsmTemplates_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OtherFsmTemplates", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref OtherFsmTemplatesPath_PropertyAddress, intPtr, "OtherFsmTemplatesPath");
		OtherFsmTemplatesPath_Offset = NativeReflection.GetPropertyOffset(intPtr, "OtherFsmTemplatesPath");
		OtherFsmTemplatesPath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OtherFsmTemplatesPath", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref FsmSubMachineOverride_PropertyAddress, intPtr, "FsmSubMachineOverride");
		FsmSubMachineOverride_Offset = NativeReflection.GetPropertyOffset(intPtr, "FsmSubMachineOverride");
		FsmSubMachineOverride_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FsmSubMachineOverride", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref FsmSubMachinePathOverride_PropertyAddress, intPtr, "FsmSubMachinePathOverride");
		FsmSubMachinePathOverride_Offset = NativeReflection.GetPropertyOffset(intPtr, "FsmSubMachinePathOverride");
		FsmSubMachinePathOverride_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FsmSubMachinePathOverride", Classes.FMapProperty);
		PhaseStateGraphTemplate_Offset = NativeReflection.GetPropertyOffset(intPtr, "PhaseStateGraphTemplate");
		PhaseStateGraphTemplate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PhaseStateGraphTemplate", Classes.FObjectProperty);
		PhaseStateGraphTemplatePath_Offset = NativeReflection.GetPropertyOffset(intPtr, "PhaseStateGraphTemplatePath");
		PhaseStateGraphTemplatePath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PhaseStateGraphTemplatePath", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref EventMap_PropertyAddress, intPtr, "EventMap");
		EventMap_Offset = NativeReflection.GetPropertyOffset(intPtr, "EventMap");
		EventMap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EventMap", Classes.FMapProperty);
		BattleSC_Offset = NativeReflection.GetPropertyOffset(intPtr, "BattleSC");
		BattleSC_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BattleSC", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref SpecificEventListen_BattleSC_PropertyAddress, intPtr, "SpecificEventListen_BattleSC");
		SpecificEventListen_BattleSC_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpecificEventListen_BattleSC");
		SpecificEventListen_BattleSC_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpecificEventListen_BattleSC", Classes.FArrayProperty);
		BattleSC_GUID_Offset = NativeReflection.GetPropertyOffset(intPtr, "BattleSC_GUID");
		BattleSC_GUID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BattleSC_GUID", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref InterruptAiConversationWhenIntoBattle_PropertyAddress, intPtr, "InterruptAiConversationWhenIntoBattle");
		InterruptAiConversationWhenIntoBattle_Offset = NativeReflection.GetPropertyOffset(intPtr, "InterruptAiConversationWhenIntoBattle");
		InterruptAiConversationWhenIntoBattle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InterruptAiConversationWhenIntoBattle", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref AIConversationEventIDList_PropertyAddress, intPtr, "AIConversationEventIDList");
		AIConversationEventIDList_Offset = NativeReflection.GetPropertyOffset(intPtr, "AIConversationEventIDList");
		AIConversationEventIDList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AIConversationEventIDList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref AIConversationFacts_PropertyAddress, intPtr, "AIConversationFacts");
		AIConversationFacts_Offset = NativeReflection.GetPropertyOffset(intPtr, "AIConversationFacts");
		AIConversationFacts_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AIConversationFacts", Classes.FArrayProperty);
		IntimidateBPConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "IntimidateBPConfig");
		IntimidateBPConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IntimidateBPConfig", Classes.FStructProperty);
		GSArmorSettingInBP_Offset = NativeReflection.GetPropertyOffset(intPtr, "GSArmorSettingInBP");
		GSArmorSettingInBP_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GSArmorSettingInBP", Classes.FStructProperty);
		WakeUpConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "WakeUpConfig");
		WakeUpConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WakeUpConfig", Classes.FStructProperty);
		ReplaceLeisureSequenceID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ReplaceLeisureSequenceID");
		ReplaceLeisureSequenceID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ReplaceLeisureSequenceID", Classes.FIntProperty);
		LeisureAnimAfterSequence_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeisureAnimAfterSequence");
		LeisureAnimAfterSequence_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeisureAnimAfterSequence", Classes.FObjectProperty);
		OnFightSkillIDAfterSequence_Offset = NativeReflection.GetPropertyOffset(intPtr, "OnFightSkillIDAfterSequence");
		OnFightSkillIDAfterSequence_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OnFightSkillIDAfterSequence", Classes.FIntProperty);
		OnFightSkillIDBackAfterSequence_Offset = NativeReflection.GetPropertyOffset(intPtr, "OnFightSkillIDBackAfterSequence");
		OnFightSkillIDBackAfterSequence_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OnFightSkillIDBackAfterSequence", Classes.FIntProperty);
		OnFightSkillIDLeftAfterSequence_Offset = NativeReflection.GetPropertyOffset(intPtr, "OnFightSkillIDLeftAfterSequence");
		OnFightSkillIDLeftAfterSequence_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OnFightSkillIDLeftAfterSequence", Classes.FIntProperty);
		OnFightSkillIDRightAfterSequence_Offset = NativeReflection.GetPropertyOffset(intPtr, "OnFightSkillIDRightAfterSequence");
		OnFightSkillIDRightAfterSequence_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OnFightSkillIDRightAfterSequence", Classes.FIntProperty);
		AIState_Offset = NativeReflection.GetPropertyOffset(intPtr, "AIState");
		AIState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AIState", Classes.FIntProperty);
		LastSkillBlockReason_Offset = NativeReflection.GetPropertyOffset(intPtr, "LastSkillBlockReason");
		LastSkillBlockReason_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LastSkillBlockReason", Classes.FIntProperty);
		UserHandle_Offset = NativeReflection.GetPropertyOffset(intPtr, "UserHandle");
		UserHandle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UserHandle", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bLogVerbose_PropertyAddress, intPtr, "bLogVerbose");
		bLogVerbose_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLogVerbose");
		bLogVerbose_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLogVerbose", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bEnablePerceptionPreview_PropertyAddress, intPtr, "bEnablePerceptionPreview");
		bEnablePerceptionPreview_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnablePerceptionPreview");
		bEnablePerceptionPreview_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnablePerceptionPreview", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bEnablePerceptionPreviewOutlineOnly_PropertyAddress, intPtr, "bEnablePerceptionPreviewOutlineOnly");
		bEnablePerceptionPreviewOutlineOnly_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnablePerceptionPreviewOutlineOnly");
		bEnablePerceptionPreviewOutlineOnly_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnablePerceptionPreviewOutlineOnly", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bEnableWakeUpLinkRangeDebug_PropertyAddress, intPtr, "bEnableWakeUpLinkRangeDebug");
		bEnableWakeUpLinkRangeDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableWakeUpLinkRangeDebug");
		bEnableWakeUpLinkRangeDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableWakeUpLinkRangeDebug", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bEnableHardMove_PropertyAddress, intPtr, "bEnableHardMove");
		bEnableHardMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableHardMove");
		bEnableHardMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableHardMove", Classes.FBoolProperty);
		WindyMoveAffectedAngleForward_Offset = NativeReflection.GetPropertyOffset(intPtr, "WindyMoveAffectedAngleForward");
		WindyMoveAffectedAngleForward_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WindyMoveAffectedAngleForward", Classes.FFloatProperty);
		WindyMoveForwardBuffID_Offset = NativeReflection.GetPropertyOffset(intPtr, "WindyMoveForwardBuffID");
		WindyMoveForwardBuffID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WindyMoveForwardBuffID", Classes.FIntProperty);
		WindyMoveBackwardBuffID_Offset = NativeReflection.GetPropertyOffset(intPtr, "WindyMoveBackwardBuffID");
		WindyMoveBackwardBuffID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WindyMoveBackwardBuffID", Classes.FIntProperty);
		WindyMoveEnterSkill_Offset = NativeReflection.GetPropertyOffset(intPtr, "WindyMoveEnterSkill");
		WindyMoveEnterSkill_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WindyMoveEnterSkill", Classes.FIntProperty);
		MuddyMoveEnterSkill_Offset = NativeReflection.GetPropertyOffset(intPtr, "MuddyMoveEnterSkill");
		MuddyMoveEnterSkill_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MuddyMoveEnterSkill", Classes.FIntProperty);
		FrozenMoveEnterSkill_Offset = NativeReflection.GetPropertyOffset(intPtr, "FrozenMoveEnterSkill");
		FrozenMoveEnterSkill_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FrozenMoveEnterSkill", Classes.FIntProperty);
		SpiderSilkyMoveEnterSkill_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpiderSilkyMoveEnterSkill");
		SpiderSilkyMoveEnterSkill_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpiderSilkyMoveEnterSkill", Classes.FIntProperty);
		WindyMoveForwardBlendAnim_Offset = NativeReflection.GetPropertyOffset(intPtr, "WindyMoveForwardBlendAnim");
		WindyMoveForwardBlendAnim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WindyMoveForwardBlendAnim", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref PatrolType_PropertyAddress, intPtr, "PatrolType");
		PatrolType_Offset = NativeReflection.GetPropertyOffset(intPtr, "PatrolType");
		PatrolType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PatrolType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bDisableRestartOnLeaveFight_PropertyAddress, intPtr, "bDisableRestartOnLeaveFight");
		bDisableRestartOnLeaveFight_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisableRestartOnLeaveFight");
		bDisableRestartOnLeaveFight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisableRestartOnLeaveFight", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bDisableRestartOnReset_PropertyAddress, intPtr, "bDisableRestartOnReset");
		bDisableRestartOnReset_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisableRestartOnReset");
		bDisableRestartOnReset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisableRestartOnReset", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref MotionMatchingState_PropertyAddress, intPtr, "MotionMatchingState");
		MotionMatchingState_Offset = NativeReflection.GetPropertyOffset(intPtr, "MotionMatchingState");
		MotionMatchingState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MotionMatchingState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref FindPathMoveType_PropertyAddress, intPtr, "FindPathMoveType");
		FindPathMoveType_Offset = NativeReflection.GetPropertyOffset(intPtr, "FindPathMoveType");
		FindPathMoveType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FindPathMoveType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref PatrolMoveSpeedType_PropertyAddress, intPtr, "PatrolMoveSpeedType");
		PatrolMoveSpeedType_Offset = NativeReflection.GetPropertyOffset(intPtr, "PatrolMoveSpeedType");
		PatrolMoveSpeedType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PatrolMoveSpeedType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref EnablePatrolOnStart_PropertyAddress, intPtr, "EnablePatrolOnStart");
		EnablePatrolOnStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnablePatrolOnStart");
		EnablePatrolOnStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnablePatrolOnStart", Classes.FBoolProperty);
		PatrolBuff_Offset = NativeReflection.GetPropertyOffset(intPtr, "PatrolBuff");
		PatrolBuff_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PatrolBuff", Classes.FIntProperty);
		ABPSettingForPatrol_Offset = NativeReflection.GetPropertyOffset(intPtr, "ABPSettingForPatrol");
		ABPSettingForPatrol_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ABPSettingForPatrol", Classes.FObjectProperty);
		MoveAcceptableRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveAcceptableRadius");
		MoveAcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveAcceptableRadius", Classes.FFloatProperty);
		StartWaitAMProbability_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartWaitAMProbability");
		StartWaitAMProbability_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartWaitAMProbability", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref StartWaitAM_PropertyAddress, intPtr, "StartWaitAM");
		StartWaitAM_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartWaitAM");
		StartWaitAM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartWaitAM", Classes.FArrayProperty);
		TurnSkillConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "TurnSkillConfig");
		TurnSkillConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TurnSkillConfig", Classes.FStructProperty);
		RandomPatrolConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "RandomPatrolConfig");
		RandomPatrolConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RandomPatrolConfig", Classes.FStructProperty);
		SplinePatrolConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "SplinePatrolConfig");
		SplinePatrolConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SplinePatrolConfig", Classes.FStructProperty);
		MultiSplinePatrolConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "MultiSplinePatrolConfig");
		MultiSplinePatrolConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MultiSplinePatrolConfig", Classes.FStructProperty);
		LeisureConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeisureConfig");
		LeisureConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeisureConfig", Classes.FStructProperty);
		FollowPatrolConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "FollowPatrolConfig");
		FollowPatrolConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FollowPatrolConfig", Classes.FStructProperty);
		GroupPatrolConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "GroupPatrolConfig");
		GroupPatrolConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GroupPatrolConfig", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bEnableMovePhysicsTransform_PropertyAddress, intPtr, "bEnableMovePhysicsTransform");
		bEnableMovePhysicsTransform_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableMovePhysicsTransform");
		bEnableMovePhysicsTransform_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableMovePhysicsTransform", Classes.FBoolProperty);
		PhysicsTransformGravityAddValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "PhysicsTransformGravityAddValue");
		PhysicsTransformGravityAddValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PhysicsTransformGravityAddValue", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref RotationTypeDurningPhysicsState_PropertyAddress, intPtr, "RotationTypeDurningPhysicsState");
		RotationTypeDurningPhysicsState_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotationTypeDurningPhysicsState");
		RotationTypeDurningPhysicsState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotationTypeDurningPhysicsState", Classes.FEnumProperty);
		GlideSlopeEdgeAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "GlideSlopeEdgeAngle");
		GlideSlopeEdgeAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GlideSlopeEdgeAngle", Classes.FFloatProperty);
		MaxGlideSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxGlideSpeed");
		MaxGlideSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxGlideSpeed", Classes.FFloatProperty);
		MinGlideSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinGlideSpeed");
		MinGlideSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinGlideSpeed", Classes.FFloatProperty);
		MaxSpeedAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxSpeedAngle");
		MaxSpeedAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxSpeedAngle", Classes.FFloatProperty);
		MinSpeedAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinSpeedAngle");
		MinSpeedAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinSpeedAngle", Classes.FFloatProperty);
		MoveControlReactionSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveControlReactionSpeed");
		MoveControlReactionSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveControlReactionSpeed", Classes.FFloatProperty);
		MoveControlAddMaxSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveControlAddMaxSpeed");
		MoveControlAddMaxSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveControlAddMaxSpeed", Classes.FFloatProperty);
		PreventGlideSkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "PreventGlideSkillID");
		PreventGlideSkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PreventGlideSkillID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bEnablePhysicalMove_PropertyAddress, intPtr, "bEnablePhysicalMove");
		bEnablePhysicalMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnablePhysicalMove");
		bEnablePhysicalMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnablePhysicalMove", Classes.FBoolProperty);
		PhysicalGravityAddValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "PhysicalGravityAddValue");
		PhysicalGravityAddValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PhysicalGravityAddValue", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref PhysicalMoveBuff_PropertyAddress, intPtr, "PhysicalMoveBuff");
		PhysicalMoveBuff_Offset = NativeReflection.GetPropertyOffset(intPtr, "PhysicalMoveBuff");
		PhysicalMoveBuff_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PhysicalMoveBuff", Classes.FArrayProperty);
		PhysicalMoveBuffNeedSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "PhysicalMoveBuffNeedSpeed");
		PhysicalMoveBuffNeedSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PhysicalMoveBuffNeedSpeed", Classes.FFloatProperty);
		PhysicalMoveBuffProtectTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "PhysicalMoveBuffProtectTime");
		PhysicalMoveBuffProtectTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PhysicalMoveBuffProtectTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bUseSocketDirection_PropertyAddress, intPtr, "bUseSocketDirection");
		bUseSocketDirection_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseSocketDirection");
		bUseSocketDirection_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseSocketDirection", Classes.FBoolProperty);
		DirectionBaseSocekt_Offset = NativeReflection.GetPropertyOffset(intPtr, "DirectionBaseSocekt");
		DirectionBaseSocekt_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DirectionBaseSocekt", Classes.FNameProperty);
		ForwardSocket_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForwardSocket");
		ForwardSocket_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForwardSocket", Classes.FNameProperty);
		AccuratelyMoveDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "AccuratelyMoveDistance");
		AccuratelyMoveDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AccuratelyMoveDistance", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bSimulatePhysicsWhenAttacking_PropertyAddress, intPtr, "bSimulatePhysicsWhenAttacking");
		bSimulatePhysicsWhenAttacking_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSimulatePhysicsWhenAttacking");
		bSimulatePhysicsWhenAttacking_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSimulatePhysicsWhenAttacking", Classes.FBoolProperty);
		HorizontalMoveSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "HorizontalMoveSpeed");
		HorizontalMoveSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HorizontalMoveSpeed", Classes.FFloatProperty);
		VerticalMoveSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "VerticalMoveSpeed");
		VerticalMoveSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VerticalMoveSpeed", Classes.FFloatProperty);
		MaxMoveDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxMoveDistance");
		MaxMoveDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxMoveDistance", Classes.FFloatProperty);
		FlyDownwardSpeedRate_Offset = NativeReflection.GetPropertyOffset(intPtr, "FlyDownwardSpeedRate");
		FlyDownwardSpeedRate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FlyDownwardSpeedRate", Classes.FFloatProperty);
		FlyDownwardJudgeAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "FlyDownwardJudgeAngle");
		FlyDownwardJudgeAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FlyDownwardJudgeAngle", Classes.FFloatProperty);
		FloatRelativeSpotActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "FloatRelativeSpotActor");
		FloatRelativeSpotActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FloatRelativeSpotActor", Classes.FWeakObjectProperty);
		RelativeFloatHeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "RelativeFloatHeight");
		RelativeFloatHeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RelativeFloatHeight", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref SplineList_PropertyAddress, intPtr, "SplineList");
		SplineList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SplineList");
		SplineList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SplineList", Classes.FArrayProperty);
		BeginTriggerBox_Offset = NativeReflection.GetPropertyOffset(intPtr, "BeginTriggerBox");
		BeginTriggerBox_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BeginTriggerBox", Classes.FSoftObjectProperty);
		EndTriggerBox_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndTriggerBox");
		EndTriggerBox_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndTriggerBox", Classes.FSoftObjectProperty);
		TurnSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "TurnSpeed");
		TurnSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TurnSpeed", Classes.FIntProperty);
		Acceleration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Acceleration");
		Acceleration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Acceleration", Classes.FFloatProperty);
		MaxSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxSpeed");
		MaxSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxSpeed", Classes.FFloatProperty);
		MinSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinSpeed");
		MinSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinSpeed", Classes.FFloatProperty);
		StartSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartSpeed");
		StartSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartSpeed", Classes.FFloatProperty);
		MultiSplineDefaultIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "MultiSplineDefaultIndex");
		MultiSplineDefaultIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MultiSplineDefaultIndex", Classes.FIntProperty);
		FirstAccelerationIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "FirstAccelerationIndex");
		FirstAccelerationIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FirstAccelerationIndex", Classes.FIntProperty);
		SecondAccelerationIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "SecondAccelerationIndex");
		SecondAccelerationIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SecondAccelerationIndex", Classes.FIntProperty);
		SpeedRateParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpeedRateParam");
		SpeedRateParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpeedRateParam", Classes.FFloatProperty);
		RotatorWaitTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotatorWaitTime");
		RotatorWaitTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotatorWaitTime", Classes.FFloatProperty);
		SpeedRateParamCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpeedRateParamCurve");
		SpeedRateParamCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpeedRateParamCurve", Classes.FObjectProperty);
		UseCurveTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseCurveTime");
		UseCurveTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseCurveTime", Classes.FFloatProperty);
		StartPointIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartPointIndex");
		StartPointIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartPointIndex", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref IsStartForward_PropertyAddress, intPtr, "IsStartForward");
		IsStartForward_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsStartForward");
		IsStartForward_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsStartForward", Classes.FBoolProperty);
		ForwardBuffID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForwardBuffID");
		ForwardBuffID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForwardBuffID", Classes.FIntProperty);
		BackBuffID_Offset = NativeReflection.GetPropertyOffset(intPtr, "BackBuffID");
		BackBuffID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BackBuffID", Classes.FIntProperty);
		FollowStateRotationRate_Offset = NativeReflection.GetPropertyOffset(intPtr, "FollowStateRotationRate");
		FollowStateRotationRate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FollowStateRotationRate", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bEnableTTTBRT_PropertyAddress, intPtr, "bEnableTTTBRT");
		bEnableTTTBRT_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableTTTBRT");
		bEnableTTTBRT_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableTTTBRT", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bEnableEnvInteraction_PropertyAddress, intPtr, "bEnableEnvInteraction");
		bEnableEnvInteraction_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableEnvInteraction");
		bEnableEnvInteraction_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableEnvInteraction", Classes.FBoolProperty);
		TraceDelay_Offset = NativeReflection.GetPropertyOffset(intPtr, "TraceDelay");
		TraceDelay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TraceDelay", Classes.FFloatProperty);
		TraceLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "TraceLength");
		TraceLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TraceLength", Classes.FFloatProperty);
		Size_Offset = NativeReflection.GetPropertyOffset(intPtr, "Size");
		Size_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Size", Classes.FFloatProperty);
		SampleCollectionProtectTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "SampleCollectionProtectTime");
		SampleCollectionProtectTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SampleCollectionProtectTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref OverrideSurfaceType_PropertyAddress, intPtr, "OverrideSurfaceType");
		OverrideSurfaceType_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideSurfaceType");
		OverrideSurfaceType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideSurfaceType", Classes.FEnumProperty);
		OverrideSurfacePersistTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideSurfacePersistTime");
		OverrideSurfacePersistTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideSurfacePersistTime", Classes.FFloatProperty);
		OverrideSurfaceFXActorTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideSurfaceFXActorTag");
		OverrideSurfaceFXActorTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideSurfaceFXActorTag", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref bDrawDebug_PropertyAddress, intPtr, "bDrawDebug");
		bDrawDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDrawDebug");
		bDrawDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDrawDebug", Classes.FBoolProperty);
		DebugDrawOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "DebugDrawOffset");
		DebugDrawOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DebugDrawOffset", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref FXComponentName_PropertyAddress, intPtr, "FXComponentName");
		FXComponentName_Offset = NativeReflection.GetPropertyOffset(intPtr, "FXComponentName");
		FXComponentName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FXComponentName", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref GlobalFXConfigList_PropertyAddress, intPtr, "GlobalFXConfigList");
		GlobalFXConfigList_Offset = NativeReflection.GetPropertyOffset(intPtr, "GlobalFXConfigList");
		GlobalFXConfigList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GlobalFXConfigList", Classes.FArrayProperty);
		PointLightTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "PointLightTag");
		PointLightTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PointLightTag", Classes.FStructProperty);
		LoopEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "LoopEvent");
		LoopEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LoopEvent", Classes.FStructProperty);
		DeadEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "DeadEvent");
		DeadEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DeadEvent", Classes.FStructProperty);
		BtlBGMBPConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "BtlBGMBPConfig");
		BtlBGMBPConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BtlBGMBPConfig", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref DrawDebugLine_PropertyAddress, intPtr, "DrawDebugLine");
		DrawDebugLine_Offset = NativeReflection.GetPropertyOffset(intPtr, "DrawDebugLine");
		DrawDebugLine_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DrawDebugLine", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bShowFootSpeed_PropertyAddress, intPtr, "bShowFootSpeed");
		bShowFootSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "bShowFootSpeed");
		bShowFootSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bShowFootSpeed", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bShowFootHeight_PropertyAddress, intPtr, "bShowFootHeight");
		bShowFootHeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "bShowFootHeight");
		bShowFootHeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bShowFootHeight", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUseFarStepAudio_PropertyAddress, intPtr, "bUseFarStepAudio");
		bUseFarStepAudio_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseFarStepAudio");
		bUseFarStepAudio_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseFarStepAudio", Classes.FBoolProperty);
		LeftFootSpeedRefBoneName_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeftFootSpeedRefBoneName");
		LeftFootSpeedRefBoneName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeftFootSpeedRefBoneName", Classes.FNameProperty);
		RightFootSpeedRefBoneName_Offset = NativeReflection.GetPropertyOffset(intPtr, "RightFootSpeedRefBoneName");
		RightFootSpeedRefBoneName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RightFootSpeedRefBoneName", Classes.FNameProperty);
		LeftFootLineTraceBoneName_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeftFootLineTraceBoneName");
		LeftFootLineTraceBoneName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeftFootLineTraceBoneName", Classes.FNameProperty);
		RightFootLineTraceBoneName_Offset = NativeReflection.GetPropertyOffset(intPtr, "RightFootLineTraceBoneName");
		RightFootLineTraceBoneName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RightFootLineTraceBoneName", Classes.FNameProperty);
		LeftFootFrontSocket_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeftFootFrontSocket");
		LeftFootFrontSocket_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeftFootFrontSocket", Classes.FNameProperty);
		RightFootFrontSocket_Offset = NativeReflection.GetPropertyOffset(intPtr, "RightFootFrontSocket");
		RightFootFrontSocket_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RightFootFrontSocket", Classes.FNameProperty);
		CameraShake_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraShake");
		CameraShake_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraShake", Classes.FClassProperty);
		StepAudioPath_Offset = NativeReflection.GetPropertyOffset(intPtr, "StepAudioPath");
		StepAudioPath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StepAudioPath", Classes.FStructProperty);
		MoveActionTypeID_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveActionTypeID");
		MoveActionTypeID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveActionTypeID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bPrintStepAudioSwitchState_PropertyAddress, intPtr, "bPrintStepAudioSwitchState");
		bPrintStepAudioSwitchState_Offset = NativeReflection.GetPropertyOffset(intPtr, "bPrintStepAudioSwitchState");
		bPrintStepAudioSwitchState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bPrintStepAudioSwitchState", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bMultiSpdForStepAK_PropertyAddress, intPtr, "bMultiSpdForStepAK");
		bMultiSpdForStepAK_Offset = NativeReflection.GetPropertyOffset(intPtr, "bMultiSpdForStepAK");
		bMultiSpdForStepAK_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bMultiSpdForStepAK", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bMyriapods_PropertyAddress, intPtr, "bMyriapods");
		bMyriapods_Offset = NativeReflection.GetPropertyOffset(intPtr, "bMyriapods");
		bMyriapods_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bMyriapods", Classes.FBoolProperty);
		DecalMaterialPath_Offset = NativeReflection.GetPropertyOffset(intPtr, "DecalMaterialPath");
		DecalMaterialPath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DecalMaterialPath", Classes.FStructProperty);
		FootStepDecalSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "FootStepDecalSize");
		FootStepDecalSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FootStepDecalSize", Classes.FStructProperty);
		FootStepDecalOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "FootStepDecalOffset");
		FootStepDecalOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FootStepDecalOffset", Classes.FStructProperty);
		FootStepDecalStartFadeOutTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "FootStepDecalStartFadeOutTime");
		FootStepDecalStartFadeOutTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FootStepDecalStartFadeOutTime", Classes.FFloatProperty);
		FootStepDecalFadeOutDuration_Offset = NativeReflection.GetPropertyOffset(intPtr, "FootStepDecalFadeOutDuration");
		FootStepDecalFadeOutDuration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FootStepDecalFadeOutDuration", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref FoliageInteractSoundPriority_PropertyAddress, intPtr, "FoliageInteractSoundPriority");
		FoliageInteractSoundPriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "FoliageInteractSoundPriority");
		FoliageInteractSoundPriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FoliageInteractSoundPriority", Classes.FEnumProperty);
		BeImmobilizedConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "BeImmobilizedConfig");
		BeImmobilizedConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BeImmobilizedConfig", Classes.FObjectProperty);
		DA_PELevelConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "DA_PELevelConfig");
		DA_PELevelConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DA_PELevelConfig", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref AutoEnablePreciseDodge_PropertyAddress, intPtr, "AutoEnablePreciseDodge");
		AutoEnablePreciseDodge_Offset = NativeReflection.GetPropertyOffset(intPtr, "AutoEnablePreciseDodge");
		AutoEnablePreciseDodge_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AutoEnablePreciseDodge", Classes.FBoolProperty);
		DefaultAwardsLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultAwardsLevel");
		DefaultAwardsLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultAwardsLevel", Classes.FIntProperty);
		TolerantTimeSeconds_Offset = NativeReflection.GetPropertyOffset(intPtr, "TolerantTimeSeconds");
		TolerantTimeSeconds_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TolerantTimeSeconds", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref Awards_PropertyAddress, intPtr, "Awards");
		Awards_Offset = NativeReflection.GetPropertyOffset(intPtr, "Awards");
		Awards_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Awards", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref bDebugPreciseDodge_PropertyAddress, intPtr, "bDebugPreciseDodge");
		bDebugPreciseDodge_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDebugPreciseDodge");
		bDebugPreciseDodge_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDebugPreciseDodge", Classes.FBoolProperty);
		TransStageConfigID_Offset = NativeReflection.GetPropertyOffset(intPtr, "TransStageConfigID");
		TransStageConfigID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TransStageConfigID", Classes.FIntProperty);
		TransBackSkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "TransBackSkillID");
		TransBackSkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TransBackSkillID", Classes.FIntProperty);
		TransBackDurationTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "TransBackDurationTime");
		TransBackDurationTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TransBackDurationTime", Classes.FFloatProperty);
		AbnormalAttrConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "AbnormalAttrConfig");
		AbnormalAttrConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AbnormalAttrConfig", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref AbnormalStateImmueList_PropertyAddress, intPtr, "AbnormalStateImmueList");
		AbnormalStateImmueList_Offset = NativeReflection.GetPropertyOffset(intPtr, "AbnormalStateImmueList");
		AbnormalStateImmueList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AbnormalStateImmueList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BirthAbnormalStateList_PropertyAddress, intPtr, "BirthAbnormalStateList");
		BirthAbnormalStateList_Offset = NativeReflection.GetPropertyOffset(intPtr, "BirthAbnormalStateList");
		BirthAbnormalStateList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BirthAbnormalStateList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref EffectIDList_SwitchWeaponPose_PropertyAddress, intPtr, "EffectIDList_SwitchWeaponPose");
		EffectIDList_SwitchWeaponPose_Offset = NativeReflection.GetPropertyOffset(intPtr, "EffectIDList_SwitchWeaponPose");
		EffectIDList_SwitchWeaponPose_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EffectIDList_SwitchWeaponPose", Classes.FArrayProperty);
		TriggerEffectCoolDown_SwitchWeaponPose_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerEffectCoolDown_SwitchWeaponPose");
		TriggerEffectCoolDown_SwitchWeaponPose_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerEffectCoolDown_SwitchWeaponPose", Classes.FFloatProperty);
		CostDMG_StartHeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "CostDMG_StartHeight");
		CostDMG_StartHeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CostDMG_StartHeight", Classes.FFloatProperty);
		OverHeight_DmgAdditive_INV10000_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverHeight_DmgAdditive_INV10000");
		OverHeight_DmgAdditive_INV10000_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverHeight_DmgAdditive_INV10000", Classes.FIntProperty);
		FallDmg_DmgMax_INV10000_Offset = NativeReflection.GetPropertyOffset(intPtr, "FallDmg_DmgMax_INV10000");
		FallDmg_DmgMax_INV10000_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FallDmg_DmgMax_INV10000", Classes.FIntProperty);
		BaseDmg_INV10000_Offset = NativeReflection.GetPropertyOffset(intPtr, "BaseDmg_INV10000");
		BaseDmg_INV10000_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BaseDmg_INV10000", Classes.FIntProperty);
		FallingSafeTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "FallingSafeTime");
		FallingSafeTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FallingSafeTime", Classes.FFloatProperty);
		LandCamShakeConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "LandCamShakeConfig");
		LandCamShakeConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LandCamShakeConfig", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref EnableDodge_InFalling_PropertyAddress, intPtr, "EnableDodge_InFalling");
		EnableDodge_InFalling_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableDodge_InFalling");
		EnableDodge_InFalling_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableDodge_InFalling", Classes.FBoolProperty);
		CanDodge_Distance_Offset = NativeReflection.GetPropertyOffset(intPtr, "CanDodge_Distance");
		CanDodge_Distance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CanDodge_Distance", Classes.FFloatProperty);
		Dodge_DmgMul_Offset = NativeReflection.GetPropertyOffset(intPtr, "Dodge_DmgMul");
		Dodge_DmgMul_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Dodge_DmgMul", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EnableFloorDistanceCheck_PropertyAddress, intPtr, "EnableFloorDistanceCheck");
		EnableFloorDistanceCheck_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableFloorDistanceCheck");
		EnableFloorDistanceCheck_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableFloorDistanceCheck", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bSaveInitData_PropertyAddress, intPtr, "bSaveInitData");
		bSaveInitData_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSaveInitData");
		bSaveInitData_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSaveInitData", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ActorResetType_PropertyAddress, intPtr, "ActorResetType");
		ActorResetType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorResetType");
		ActorResetType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorResetType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bEnableImpactAction_PropertyAddress, intPtr, "bEnableImpactAction");
		bEnableImpactAction_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableImpactAction");
		bEnableImpactAction_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableImpactAction", Classes.FBoolProperty);
		EnableImplactCalculationParameter_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableImplactCalculationParameter");
		EnableImplactCalculationParameter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableImplactCalculationParameter", Classes.FFloatProperty);
		EnableImpactActionHeightDiff_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableImpactActionHeightDiff");
		EnableImpactActionHeightDiff_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableImpactActionHeightDiff", Classes.FFloatProperty);
		EnableImpactAnimThreshold_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableImpactAnimThreshold");
		EnableImpactAnimThreshold_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableImpactAnimThreshold", Classes.FFloatProperty);
		LeftAngleSplitLine_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeftAngleSplitLine");
		LeftAngleSplitLine_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeftAngleSplitLine", Classes.FFloatProperty);
		MiddleLeftAngleSplitLine_Offset = NativeReflection.GetPropertyOffset(intPtr, "MiddleLeftAngleSplitLine");
		MiddleLeftAngleSplitLine_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MiddleLeftAngleSplitLine", Classes.FFloatProperty);
		MiddleRightAngleSplitLine_Offset = NativeReflection.GetPropertyOffset(intPtr, "MiddleRightAngleSplitLine");
		MiddleRightAngleSplitLine_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MiddleRightAngleSplitLine", Classes.FFloatProperty);
		RightAngleSplitLine_Offset = NativeReflection.GetPropertyOffset(intPtr, "RightAngleSplitLine");
		RightAngleSplitLine_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RightAngleSplitLine", Classes.FFloatProperty);
		ForwardImpactActionAnim_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForwardImpactActionAnim");
		ForwardImpactActionAnim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForwardImpactActionAnim", Classes.FObjectProperty);
		LeftSideImpactActionAnim_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeftSideImpactActionAnim");
		LeftSideImpactActionAnim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeftSideImpactActionAnim", Classes.FObjectProperty);
		RightSideImpactActionAnim_Offset = NativeReflection.GetPropertyOffset(intPtr, "RightSideImpactActionAnim");
		RightSideImpactActionAnim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RightSideImpactActionAnim", Classes.FObjectProperty);
		InteractiveUnitID_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractiveUnitID");
		InteractiveUnitID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractiveUnitID", Classes.FIntProperty);
		DefalutInteractiveGroupID_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefalutInteractiveGroupID");
		DefalutInteractiveGroupID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefalutInteractiveGroupID", Classes.FIntProperty);
		ShopID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ShopID");
		ShopID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ShopID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref InteractFuncList_PropertyAddress, intPtr, "InteractFuncList");
		InteractFuncList_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractFuncList");
		InteractFuncList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractFuncList", Classes.FArrayProperty);
		RewardDropID_Offset = NativeReflection.GetPropertyOffset(intPtr, "RewardDropID");
		RewardDropID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RewardDropID", Classes.FIntProperty);
		InteractAnchorOverride_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractAnchorOverride");
		InteractAnchorOverride_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractAnchorOverride", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref ObjectMaterial_PropertyAddress, intPtr, "ObjectMaterial");
		ObjectMaterial_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObjectMaterial");
		ObjectMaterial_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObjectMaterial", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref PersistentDataDontResetOnNewGamePlus_PropertyAddress, intPtr, "PersistentDataDontResetOnNewGamePlus");
		PersistentDataDontResetOnNewGamePlus_Offset = NativeReflection.GetPropertyOffset(intPtr, "PersistentDataDontResetOnNewGamePlus");
		PersistentDataDontResetOnNewGamePlus_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PersistentDataDontResetOnNewGamePlus", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bEnableFlyCtrl_PropertyAddress, intPtr, "bEnableFlyCtrl");
		bEnableFlyCtrl_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableFlyCtrl");
		bEnableFlyCtrl_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableFlyCtrl", Classes.FBoolProperty);
		CheckInterval_Offset = NativeReflection.GetPropertyOffset(intPtr, "CheckInterval");
		CheckInterval_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CheckInterval", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref TraceIgnoreActorTags_PropertyAddress, intPtr, "TraceIgnoreActorTags");
		TraceIgnoreActorTags_Offset = NativeReflection.GetPropertyOffset(intPtr, "TraceIgnoreActorTags");
		TraceIgnoreActorTags_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TraceIgnoreActorTags", Classes.FArrayProperty);
		FlyHeightMin_Offset = NativeReflection.GetPropertyOffset(intPtr, "FlyHeightMin");
		FlyHeightMin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FlyHeightMin", Classes.FFloatProperty);
		FlyHeightMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "FlyHeightMax");
		FlyHeightMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FlyHeightMax", Classes.FFloatProperty);
		FlyHeightMaxAbs_Offset = NativeReflection.GetPropertyOffset(intPtr, "FlyHeightMaxAbs");
		FlyHeightMaxAbs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FlyHeightMaxAbs", Classes.FFloatProperty);
		PushUpImpulse_Offset = NativeReflection.GetPropertyOffset(intPtr, "PushUpImpulse");
		PushUpImpulse_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PushUpImpulse", Classes.FFloatProperty);
		PushDownImpulse_Offset = NativeReflection.GetPropertyOffset(intPtr, "PushDownImpulse");
		PushDownImpulse_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PushDownImpulse", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bLockZ_PropertyAddress, intPtr, "bLockZ");
		bLockZ_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockZ");
		bLockZ_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockZ", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bPrintHitActor_PropertyAddress, intPtr, "bPrintHitActor");
		bPrintHitActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "bPrintHitActor");
		bPrintHitActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bPrintHitActor", Classes.FBoolProperty);
		DefaultComboGraphIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultComboGraphIndex");
		DefaultComboGraphIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultComboGraphIndex", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref ComboGraphTemplates_PropertyAddress, intPtr, "ComboGraphTemplates");
		ComboGraphTemplates_Offset = NativeReflection.GetPropertyOffset(intPtr, "ComboGraphTemplates");
		ComboGraphTemplates_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ComboGraphTemplates", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ComboGraphTemplatesPath_PropertyAddress, intPtr, "ComboGraphTemplatesPath");
		ComboGraphTemplatesPath_Offset = NativeReflection.GetPropertyOffset(intPtr, "ComboGraphTemplatesPath");
		ComboGraphTemplatesPath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ComboGraphTemplatesPath", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref bEnableDebugComboGraph_PropertyAddress, intPtr, "bEnableDebugComboGraph");
		bEnableDebugComboGraph_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableDebugComboGraph");
		bEnableDebugComboGraph_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableDebugComboGraph", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bEnableTurretControl_PropertyAddress, intPtr, "bEnableTurretControl");
		bEnableTurretControl_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableTurretControl");
		bEnableTurretControl_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableTurretControl", Classes.FBoolProperty);
		TurretTurnTriggerYaw_Offset = NativeReflection.GetPropertyOffset(intPtr, "TurretTurnTriggerYaw");
		TurretTurnTriggerYaw_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TurretTurnTriggerYaw", Classes.FFloatProperty);
		TurretTurnDelay_Offset = NativeReflection.GetPropertyOffset(intPtr, "TurretTurnDelay");
		TurretTurnDelay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TurretTurnDelay", Classes.FFloatProperty);
		TurretTurnBlendTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "TurretTurnBlendTime");
		TurretTurnBlendTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TurretTurnBlendTime", Classes.FFloatProperty);
		CameraGraphClass_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraGraphClass");
		CameraGraphClass_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraGraphClass", Classes.FClassProperty);
		NativeReflection.GetPropertyRef(ref bCanAsPerformer_PropertyAddress, intPtr, "bCanAsPerformer");
		bCanAsPerformer_Offset = NativeReflection.GetPropertyOffset(intPtr, "bCanAsPerformer");
		bCanAsPerformer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bCanAsPerformer", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bBowWhenAfterShow_PropertyAddress, intPtr, "bBowWhenAfterShow");
		bBowWhenAfterShow_Offset = NativeReflection.GetPropertyOffset(intPtr, "bBowWhenAfterShow");
		bBowWhenAfterShow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bBowWhenAfterShow", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bWaitingPerformer_PropertyAddress, intPtr, "bWaitingPerformer");
		bWaitingPerformer_Offset = NativeReflection.GetPropertyOffset(intPtr, "bWaitingPerformer");
		bWaitingPerformer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bWaitingPerformer", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bWaitingWhenReturnHome_PropertyAddress, intPtr, "bWaitingWhenReturnHome");
		bWaitingWhenReturnHome_Offset = NativeReflection.GetPropertyOffset(intPtr, "bWaitingWhenReturnHome");
		bWaitingWhenReturnHome_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bWaitingWhenReturnHome", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bStandingWaiting_PropertyAddress, intPtr, "bStandingWaiting");
		bStandingWaiting_Offset = NativeReflection.GetPropertyOffset(intPtr, "bStandingWaiting");
		bStandingWaiting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bStandingWaiting", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUseSceneItemPosition_PropertyAddress, intPtr, "bUseSceneItemPosition");
		bUseSceneItemPosition_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseSceneItemPosition");
		bUseSceneItemPosition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseSceneItemPosition", Classes.FBoolProperty);
		WaitingLocationItemTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "WaitingLocationItemTag");
		WaitingLocationItemTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WaitingLocationItemTag", Classes.FNameProperty);
		WaitingLocation_Offset = NativeReflection.GetPropertyOffset(intPtr, "WaitingLocation");
		WaitingLocation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WaitingLocation", Classes.FStructProperty);
		WaitingRotation_Offset = NativeReflection.GetPropertyOffset(intPtr, "WaitingRotation");
		WaitingRotation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WaitingRotation", Classes.FStructProperty);
		WaitingAnim_Offset = NativeReflection.GetPropertyOffset(intPtr, "WaitingAnim");
		WaitingAnim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WaitingAnim", Classes.FObjectProperty);
		WaitingStateConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "WaitingStateConfig");
		WaitingStateConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WaitingStateConfig", Classes.FStructProperty);
		PreShowStateConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "PreShowStateConfig");
		PreShowStateConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PreShowStateConfig", Classes.FStructProperty);
		ShowingStateConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "ShowingStateConfig");
		ShowingStateConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ShowingStateConfig", Classes.FStructProperty);
		NPCInfoID_Offset = NativeReflection.GetPropertyOffset(intPtr, "NPCInfoID");
		NPCInfoID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NPCInfoID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bCanAsNPC_PropertyAddress, intPtr, "bCanAsNPC");
		bCanAsNPC_Offset = NativeReflection.GetPropertyOffset(intPtr, "bCanAsNPC");
		bCanAsNPC_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bCanAsNPC", Classes.FBoolProperty);
		OverrideAnimConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideAnimConfig");
		OverrideAnimConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideAnimConfig", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bCanAsFollowPartner_PropertyAddress, intPtr, "bCanAsFollowPartner");
		bCanAsFollowPartner_Offset = NativeReflection.GetPropertyOffset(intPtr, "bCanAsFollowPartner");
		bCanAsFollowPartner_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bCanAsFollowPartner", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref TouchWallFeedBack_EnableDebug_PropertyAddress, intPtr, "TouchWallFeedBack_EnableDebug");
		TouchWallFeedBack_EnableDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "TouchWallFeedBack_EnableDebug");
		TouchWallFeedBack_EnableDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TouchWallFeedBack_EnableDebug", Classes.FBoolProperty);
		TouchWallFeedBack_TraceLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "TouchWallFeedBack_TraceLength");
		TouchWallFeedBack_TraceLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TouchWallFeedBack_TraceLength", Classes.FFloatProperty);
		TouchWallFeedBack_SpeedThreshold_Offset = NativeReflection.GetPropertyOffset(intPtr, "TouchWallFeedBack_SpeedThreshold");
		TouchWallFeedBack_SpeedThreshold_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TouchWallFeedBack_SpeedThreshold", Classes.FFloatProperty);
		HitDynamicObstacle_ProtectTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitDynamicObstacle_ProtectTime");
		HitDynamicObstacle_ProtectTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitDynamicObstacle_ProtectTime", Classes.FFloatProperty);
		CliffUnbalance_SpeedThreshold_Offset = NativeReflection.GetPropertyOffset(intPtr, "CliffUnbalance_SpeedThreshold");
		CliffUnbalance_SpeedThreshold_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CliffUnbalance_SpeedThreshold", Classes.FFloatProperty);
		CliffUnbalanceAMConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "CliffUnbalanceAMConfig");
		CliffUnbalanceAMConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CliffUnbalanceAMConfig", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref BossBarObserveTamerList_PropertyAddress, intPtr, "BossBarObserveTamerList");
		BossBarObserveTamerList_Offset = NativeReflection.GetPropertyOffset(intPtr, "BossBarObserveTamerList");
		BossBarObserveTamerList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BossBarObserveTamerList", Classes.FArrayProperty);
		HatchConfigInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "HatchConfigInfo");
		HatchConfigInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HatchConfigInfo", Classes.FStructProperty);
		PermanentWindMotorsDataAsset_Offset = NativeReflection.GetPropertyOffset(intPtr, "PermanentWindMotorsDataAsset");
		PermanentWindMotorsDataAsset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PermanentWindMotorsDataAsset", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bDisableDataConvert_PropertyAddress, intPtr, "bDisableDataConvert");
		bDisableDataConvert_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisableDataConvert");
		bDisableDataConvert_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisableDataConvert", Classes.FBoolProperty);
		PreSaveCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PreSaveCS");
		PreSaveCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PreSaveCS_FunctionAddress);
		PreSaveCS_IsValid = PreSaveCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_ExtendConfigComp:PreSaveCS", PreSaveCS_IsValid);
	}

	static BUS_ExtendConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ExtendConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ExtendConfigComp));
	}
}
