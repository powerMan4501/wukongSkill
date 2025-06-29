using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.CharacterMovementComponent", "Engine", UnrealModuleType.Engine)]
public class UCharacterMovementComponent : UPawnMovementComponent, IRVOAvoidanceInterface, IInterface, INetworkPredictionInterface
{
	private static bool GravityScale_IsValid;

	private static int GravityScale_Offset;

	private static bool MaxStepHeight_IsValid;

	private static int MaxStepHeight_Offset;

	private static bool JumpZVelocity_IsValid;

	private static int JumpZVelocity_Offset;

	private static bool JumpOffJumpZFactor_IsValid;

	private static int JumpOffJumpZFactor_Offset;

	private static bool MovementMode_IsValid;

	private static FFieldAddress MovementMode_PropertyAddress;

	private static int MovementMode_Offset;

	private static bool CustomMovementMode_IsValid;

	private static int CustomMovementMode_Offset;

	private static bool NetworkSmoothingMode_IsValid;

	private static FFieldAddress NetworkSmoothingMode_PropertyAddress;

	private static int NetworkSmoothingMode_Offset;

	private static bool GroundFriction_IsValid;

	private static int GroundFriction_Offset;

	private static bool MaxWalkSpeed_IsValid;

	private static int MaxWalkSpeed_Offset;

	private static bool MaxWalkSpeedCrouched_IsValid;

	private static int MaxWalkSpeedCrouched_Offset;

	private static bool MaxSwimSpeed_IsValid;

	private static int MaxSwimSpeed_Offset;

	private static bool MaxFlySpeed_IsValid;

	private static int MaxFlySpeed_Offset;

	private static bool MaxCustomMovementSpeed_IsValid;

	private static int MaxCustomMovementSpeed_Offset;

	private static bool MaxAcceleration_IsValid;

	private static int MaxAcceleration_Offset;

	private static bool MinAnalogWalkSpeed_IsValid;

	private static int MinAnalogWalkSpeed_Offset;

	private static bool BrakingFrictionFactor_IsValid;

	private static int BrakingFrictionFactor_Offset;

	private static bool BrakingFriction_IsValid;

	private static int BrakingFriction_Offset;

	private static bool BrakingSubStepTime_IsValid;

	private static int BrakingSubStepTime_Offset;

	private static bool BrakingDecelerationWalking_IsValid;

	private static int BrakingDecelerationWalking_Offset;

	private static bool BrakingDecelerationFalling_IsValid;

	private static int BrakingDecelerationFalling_Offset;

	private static bool BrakingDecelerationSwimming_IsValid;

	private static int BrakingDecelerationSwimming_Offset;

	private static bool BrakingDecelerationFlying_IsValid;

	private static int BrakingDecelerationFlying_Offset;

	private static bool AirControl_IsValid;

	private static int AirControl_Offset;

	private static bool AirControlBoostMultiplier_IsValid;

	private static int AirControlBoostMultiplier_Offset;

	private static bool AirControlBoostVelocityThreshold_IsValid;

	private static int AirControlBoostVelocityThreshold_Offset;

	private static bool FallingLateralFriction_IsValid;

	private static int FallingLateralFriction_Offset;

	private static bool CrouchedHalfHeight_IsValid;

	private static int CrouchedHalfHeight_Offset;

	private static bool Buoyancy_IsValid;

	private static int Buoyancy_Offset;

	private static bool PerchRadiusThreshold_IsValid;

	private static int PerchRadiusThreshold_Offset;

	private static bool PerchAdditionalHeight_IsValid;

	private static int PerchAdditionalHeight_Offset;

	private static bool RotationRate_IsValid;

	private static int RotationRate_Offset;

	private static bool UseSeparateBrakingFriction_IsValid;

	private static FFieldAddress UseSeparateBrakingFriction_PropertyAddress;

	private static int UseSeparateBrakingFriction_Offset;

	private static bool ApplyGravityWhileJumping_IsValid;

	private static FFieldAddress ApplyGravityWhileJumping_PropertyAddress;

	private static int ApplyGravityWhileJumping_Offset;

	private static bool UseControllerDesiredRotation_IsValid;

	private static FFieldAddress UseControllerDesiredRotation_PropertyAddress;

	private static int UseControllerDesiredRotation_Offset;

	private static bool OrientRotationToMovement_IsValid;

	private static FFieldAddress OrientRotationToMovement_PropertyAddress;

	private static int OrientRotationToMovement_Offset;

	private static bool SweepWhileNavWalking_IsValid;

	private static FFieldAddress SweepWhileNavWalking_PropertyAddress;

	private static int SweepWhileNavWalking_Offset;

	private static bool RunPhysicsWithNoController_IsValid;

	private static FFieldAddress RunPhysicsWithNoController_PropertyAddress;

	private static int RunPhysicsWithNoController_Offset;

	private static bool ForceNextFloorCheck_IsValid;

	private static FFieldAddress ForceNextFloorCheck_PropertyAddress;

	private static int ForceNextFloorCheck_Offset;

	private static bool CanWalkOffLedges_IsValid;

	private static FFieldAddress CanWalkOffLedges_PropertyAddress;

	private static int CanWalkOffLedges_Offset;

	private static bool CanWalkOffLedgesWhenCrouching_IsValid;

	private static FFieldAddress CanWalkOffLedgesWhenCrouching_PropertyAddress;

	private static int CanWalkOffLedgesWhenCrouching_Offset;

	private static bool EnablePhysicsInteraction_IsValid;

	private static FFieldAddress EnablePhysicsInteraction_PropertyAddress;

	private static int EnablePhysicsInteraction_Offset;

	private static bool TouchForceScaledToMass_IsValid;

	private static FFieldAddress TouchForceScaledToMass_PropertyAddress;

	private static int TouchForceScaledToMass_Offset;

	private static bool PushForceScaledToMass_IsValid;

	private static FFieldAddress PushForceScaledToMass_PropertyAddress;

	private static int PushForceScaledToMass_Offset;

	private static bool PushForceUsingZOffset_IsValid;

	private static FFieldAddress PushForceUsingZOffset_PropertyAddress;

	private static int PushForceUsingZOffset_Offset;

	private static bool ScalePushForceToVelocity_IsValid;

	private static FFieldAddress ScalePushForceToVelocity_PropertyAddress;

	private static int ScalePushForceToVelocity_Offset;

	private static bool MaxOutOfWaterStepHeight_IsValid;

	private static int MaxOutOfWaterStepHeight_Offset;

	private static bool OutofWaterZ_IsValid;

	private static int OutofWaterZ_Offset;

	private static bool Mass_IsValid;

	private static int Mass_Offset;

	private static bool StandingDownwardForceScale_IsValid;

	private static int StandingDownwardForceScale_Offset;

	private static bool InitialPushForceFactor_IsValid;

	private static int InitialPushForceFactor_Offset;

	private static bool PushForceFactor_IsValid;

	private static int PushForceFactor_Offset;

	private static bool PushForcePointZOffsetFactor_IsValid;

	private static int PushForcePointZOffsetFactor_Offset;

	private static bool TouchForceFactor_IsValid;

	private static int TouchForceFactor_Offset;

	private static bool MinTouchForce_IsValid;

	private static int MinTouchForce_Offset;

	private static bool MaxTouchForce_IsValid;

	private static int MaxTouchForce_Offset;

	private static bool RepulsionForce_IsValid;

	private static int RepulsionForce_Offset;

	private static bool MaxSimulationTimeStep_IsValid;

	private static int MaxSimulationTimeStep_Offset;

	private static bool MaxSimulationIterations_IsValid;

	private static int MaxSimulationIterations_Offset;

	private static bool MaxJumpApexAttemptsPerSimulation_IsValid;

	private static int MaxJumpApexAttemptsPerSimulation_Offset;

	private static bool MaxDepenetrationWithGeometry_IsValid;

	private static int MaxDepenetrationWithGeometry_Offset;

	private static bool MaxDepenetrationWithGeometryAsProxy_IsValid;

	private static int MaxDepenetrationWithGeometryAsProxy_Offset;

	private static bool MaxDepenetrationWithPawn_IsValid;

	private static int MaxDepenetrationWithPawn_Offset;

	private static bool MaxDepenetrationWithPawnAsProxy_IsValid;

	private static int MaxDepenetrationWithPawnAsProxy_Offset;

	private static bool LedgeCheckThreshold_IsValid;

	private static int LedgeCheckThreshold_Offset;

	private static bool JumpOutOfWaterPitch_IsValid;

	private static int JumpOutOfWaterPitch_Offset;

	private static bool CurrentFloor_IsValid;

	private static int CurrentFloor_Offset;

	private static bool DefaultLandMovementMode_IsValid;

	private static FFieldAddress DefaultLandMovementMode_PropertyAddress;

	private static int DefaultLandMovementMode_Offset;

	private static bool DefaultWaterMovementMode_IsValid;

	private static FFieldAddress DefaultWaterMovementMode_PropertyAddress;

	private static int DefaultWaterMovementMode_Offset;

	private static bool MaintainHorizontalGroundVelocity_IsValid;

	private static FFieldAddress MaintainHorizontalGroundVelocity_PropertyAddress;

	private static int MaintainHorizontalGroundVelocity_Offset;

	private static bool ImpartBaseVelocityX_IsValid;

	private static FFieldAddress ImpartBaseVelocityX_PropertyAddress;

	private static int ImpartBaseVelocityX_Offset;

	private static bool ImpartBaseVelocityY_IsValid;

	private static FFieldAddress ImpartBaseVelocityY_PropertyAddress;

	private static int ImpartBaseVelocityY_Offset;

	private static bool ImpartBaseVelocityZ_IsValid;

	private static FFieldAddress ImpartBaseVelocityZ_PropertyAddress;

	private static int ImpartBaseVelocityZ_Offset;

	private static bool ImpartBaseAngularVelocity_IsValid;

	private static FFieldAddress ImpartBaseAngularVelocity_PropertyAddress;

	private static int ImpartBaseAngularVelocity_Offset;

	private static bool JustTeleported_IsValid;

	private static FFieldAddress JustTeleported_PropertyAddress;

	private static int JustTeleported_Offset;

	private static bool IgnoreClientMovementErrorChecksAndCorrection_IsValid;

	private static FFieldAddress IgnoreClientMovementErrorChecksAndCorrection_PropertyAddress;

	private static int IgnoreClientMovementErrorChecksAndCorrection_Offset;

	private static bool ServerAcceptClientAuthoritativePosition_IsValid;

	private static FFieldAddress ServerAcceptClientAuthoritativePosition_PropertyAddress;

	private static int ServerAcceptClientAuthoritativePosition_Offset;

	private static bool NotifyApex_IsValid;

	private static FFieldAddress NotifyApex_PropertyAddress;

	private static int NotifyApex_Offset;

	private static bool WantsToCrouch_IsValid;

	private static FFieldAddress WantsToCrouch_PropertyAddress;

	private static int WantsToCrouch_Offset;

	private static bool CrouchMaintainsBaseLocation_IsValid;

	private static FFieldAddress CrouchMaintainsBaseLocation_PropertyAddress;

	private static int CrouchMaintainsBaseLocation_Offset;

	private static bool IgnoreBaseRotation_IsValid;

	private static FFieldAddress IgnoreBaseRotation_PropertyAddress;

	private static int IgnoreBaseRotation_Offset;

	private static bool AlwaysCheckFloor_IsValid;

	private static FFieldAddress AlwaysCheckFloor_PropertyAddress;

	private static int AlwaysCheckFloor_Offset;

	private static bool UseFlatBaseForFloorChecks_IsValid;

	private static FFieldAddress UseFlatBaseForFloorChecks_PropertyAddress;

	private static int UseFlatBaseForFloorChecks_Offset;

	private static bool UseRVOAvoidance_IsValid;

	private static FFieldAddress UseRVOAvoidance_PropertyAddress;

	private static int UseRVOAvoidance_Offset;

	private static bool RequestedMoveUseAcceleration_IsValid;

	private static FFieldAddress RequestedMoveUseAcceleration_PropertyAddress;

	private static int RequestedMoveUseAcceleration_Offset;

	private static bool AllowPhysicsRotationDuringAnimRootMotion_IsValid;

	private static FFieldAddress AllowPhysicsRotationDuringAnimRootMotion_PropertyAddress;

	private static int AllowPhysicsRotationDuringAnimRootMotion_Offset;

	private static bool FormerBaseVelocityDecayHalfLife_IsValid;

	private static int FormerBaseVelocityDecayHalfLife_Offset;

	private static bool ProjectNavMeshWalking_IsValid;

	private static FFieldAddress ProjectNavMeshWalking_PropertyAddress;

	private static int ProjectNavMeshWalking_Offset;

	private static bool ProjectNavMeshOnBothWorldChannels_IsValid;

	private static FFieldAddress ProjectNavMeshOnBothWorldChannels_PropertyAddress;

	private static int ProjectNavMeshOnBothWorldChannels_Offset;

	private static bool AvoidanceConsiderationRadius_IsValid;

	private static int AvoidanceConsiderationRadius_Offset;

	private static bool AvoidanceUID_IsValid;

	private static int AvoidanceUID_Offset;

	private static bool AvoidanceGroup_IsValid;

	private static int AvoidanceGroup_Offset;

	private static bool GroupsToAvoid_IsValid;

	private static int GroupsToAvoid_Offset;

	private static bool GroupsToIgnore_IsValid;

	private static int GroupsToIgnore_Offset;

	private static bool AvoidanceWeight_IsValid;

	private static int AvoidanceWeight_Offset;

	private static bool NavMeshProjectionInterval_IsValid;

	private static int NavMeshProjectionInterval_Offset;

	private static bool NavMeshProjectionInterpSpeed_IsValid;

	private static int NavMeshProjectionInterpSpeed_Offset;

	private static bool NavMeshProjectionHeightScaleUp_IsValid;

	private static int NavMeshProjectionHeightScaleUp_Offset;

	private static bool NavMeshProjectionHeightScaleDown_IsValid;

	private static int NavMeshProjectionHeightScaleDown_Offset;

	private static bool NavWalkingFloorDistTolerance_IsValid;

	private static int NavWalkingFloorDistTolerance_Offset;

	private static bool TickRateOptionMask_IsValid;

	private static int TickRateOptionMask_Offset;

	private static bool SetWalkableFloorZ_IsValid;

	private static IntPtr SetWalkableFloorZ_FunctionAddress;

	private static int SetWalkableFloorZ_ParamsSize;

	private static bool SetWalkableFloorZ_InWalkableFloorZ_IsValid;

	private static FFieldAddress SetWalkableFloorZ_InWalkableFloorZ_PropertyAddress;

	private static int SetWalkableFloorZ_InWalkableFloorZ_Offset;

	private static bool SetWalkableFloorAngle_IsValid;

	private static IntPtr SetWalkableFloorAngle_FunctionAddress;

	private static int SetWalkableFloorAngle_ParamsSize;

	private static bool SetWalkableFloorAngle_InWalkableFloorAngle_IsValid;

	private static FFieldAddress SetWalkableFloorAngle_InWalkableFloorAngle_PropertyAddress;

	private static int SetWalkableFloorAngle_InWalkableFloorAngle_Offset;

	private static bool SetMovementMode_IsValid;

	private static IntPtr SetMovementMode_FunctionAddress;

	private static int SetMovementMode_ParamsSize;

	private static bool SetMovementMode_NewMovementMode_IsValid;

	private static FFieldAddress SetMovementMode_NewMovementMode_PropertyAddress;

	private static int SetMovementMode_NewMovementMode_Offset;

	private static bool SetMovementMode_NewCustomMode_IsValid;

	private static FFieldAddress SetMovementMode_NewCustomMode_PropertyAddress;

	private static int SetMovementMode_NewCustomMode_Offset;

	private static bool SetGroupsToIgnoreMask_IsValid;

	private static IntPtr SetGroupsToIgnoreMask_FunctionAddress;

	private static int SetGroupsToIgnoreMask_ParamsSize;

	private static bool SetGroupsToIgnoreMask_GroupMask_IsValid;

	private static FFieldAddress SetGroupsToIgnoreMask_GroupMask_PropertyAddress;

	private static int SetGroupsToIgnoreMask_GroupMask_Offset;

	private static bool SetGroupsToAvoidMask_IsValid;

	private static IntPtr SetGroupsToAvoidMask_FunctionAddress;

	private static int SetGroupsToAvoidMask_ParamsSize;

	private static bool SetGroupsToAvoidMask_GroupMask_IsValid;

	private static FFieldAddress SetGroupsToAvoidMask_GroupMask_PropertyAddress;

	private static int SetGroupsToAvoidMask_GroupMask_Offset;

	private static bool SetCrouchedHalfHeight_IsValid;

	private static IntPtr SetCrouchedHalfHeight_FunctionAddress;

	private static int SetCrouchedHalfHeight_ParamsSize;

	private static bool SetCrouchedHalfHeight_NewValue_IsValid;

	private static FFieldAddress SetCrouchedHalfHeight_NewValue_PropertyAddress;

	private static int SetCrouchedHalfHeight_NewValue_Offset;

	private static bool SetAvoidanceGroupMask_IsValid;

	private static IntPtr SetAvoidanceGroupMask_FunctionAddress;

	private static int SetAvoidanceGroupMask_ParamsSize;

	private static bool SetAvoidanceGroupMask_GroupMask_IsValid;

	private static FFieldAddress SetAvoidanceGroupMask_GroupMask_PropertyAddress;

	private static int SetAvoidanceGroupMask_GroupMask_Offset;

	private static bool SetAvoidanceEnabled_IsValid;

	private static IntPtr SetAvoidanceEnabled_FunctionAddress;

	private static int SetAvoidanceEnabled_ParamsSize;

	private static bool SetAvoidanceEnabled_bEnable_IsValid;

	private static FFieldAddress SetAvoidanceEnabled_bEnable_PropertyAddress;

	private static int SetAvoidanceEnabled_bEnable_Offset;

	private static bool GetWalkableFloorZ_IsValid;

	private static IntPtr GetWalkableFloorZ_FunctionAddress;

	private static int GetWalkableFloorZ_ParamsSize;

	private static bool GetWalkableFloorZ_ReturnValue_IsValid;

	private static FFieldAddress GetWalkableFloorZ_ReturnValue_PropertyAddress;

	private static int GetWalkableFloorZ_ReturnValue_Offset;

	private static bool GetWalkableFloorAngle_IsValid;

	private static IntPtr GetWalkableFloorAngle_FunctionAddress;

	private static int GetWalkableFloorAngle_ParamsSize;

	private static bool GetWalkableFloorAngle_ReturnValue_IsValid;

	private static FFieldAddress GetWalkableFloorAngle_ReturnValue_PropertyAddress;

	private static int GetWalkableFloorAngle_ReturnValue_Offset;

	private static bool FindFloor_IsValid;

	private static IntPtr FindFloor_FunctionAddress;

	private static int FindFloor_ParamsSize;

	private static bool FindFloor_CapsuleLocation_IsValid;

	private static FFieldAddress FindFloor_CapsuleLocation_PropertyAddress;

	private static int FindFloor_CapsuleLocation_Offset;

	private static bool FindFloor_FloorResult_IsValid;

	private static FFieldAddress FindFloor_FloorResult_PropertyAddress;

	private static int FindFloor_FloorResult_Offset;

	private static bool ComputeFloorDistance_IsValid;

	private static IntPtr ComputeFloorDistance_FunctionAddress;

	private static int ComputeFloorDistance_ParamsSize;

	private static bool ComputeFloorDistance_CapsuleLocation_IsValid;

	private static FFieldAddress ComputeFloorDistance_CapsuleLocation_PropertyAddress;

	private static int ComputeFloorDistance_CapsuleLocation_Offset;

	private static bool ComputeFloorDistance_LineDistance_IsValid;

	private static FFieldAddress ComputeFloorDistance_LineDistance_PropertyAddress;

	private static int ComputeFloorDistance_LineDistance_Offset;

	private static bool ComputeFloorDistance_SweepDistance_IsValid;

	private static FFieldAddress ComputeFloorDistance_SweepDistance_PropertyAddress;

	private static int ComputeFloorDistance_SweepDistance_Offset;

	private static bool ComputeFloorDistance_SweepRadius_IsValid;

	private static FFieldAddress ComputeFloorDistance_SweepRadius_PropertyAddress;

	private static int ComputeFloorDistance_SweepRadius_Offset;

	private static bool ComputeFloorDistance_FloorResult_IsValid;

	private static FFieldAddress ComputeFloorDistance_FloorResult_PropertyAddress;

	private static int ComputeFloorDistance_FloorResult_Offset;

	private static bool IsWalking_IsValid;

	private static IntPtr IsWalking_FunctionAddress;

	private static int IsWalking_ParamsSize;

	private static bool IsWalking_ReturnValue_IsValid;

	private static FFieldAddress IsWalking_ReturnValue_PropertyAddress;

	private static int IsWalking_ReturnValue_Offset;

	private static bool IsWalkable_IsValid;

	private static IntPtr IsWalkable_FunctionAddress;

	private static int IsWalkable_ParamsSize;

	private static bool IsWalkable_Hit_IsValid;

	private static FFieldAddress IsWalkable_Hit_PropertyAddress;

	private static int IsWalkable_Hit_Offset;

	private static bool IsWalkable_ReturnValue_IsValid;

	private static FFieldAddress IsWalkable_ReturnValue_PropertyAddress;

	private static int IsWalkable_ReturnValue_Offset;

	private static bool GetValidPerchRadius_IsValid;

	private static IntPtr GetValidPerchRadius_FunctionAddress;

	private static int GetValidPerchRadius_ParamsSize;

	private static bool GetValidPerchRadius_ReturnValue_IsValid;

	private static FFieldAddress GetValidPerchRadius_ReturnValue_PropertyAddress;

	private static int GetValidPerchRadius_ReturnValue_Offset;

	private static bool GetPerchRadiusThreshold_IsValid;

	private static IntPtr GetPerchRadiusThreshold_FunctionAddress;

	private static int GetPerchRadiusThreshold_ParamsSize;

	private static bool GetPerchRadiusThreshold_ReturnValue_IsValid;

	private static FFieldAddress GetPerchRadiusThreshold_ReturnValue_PropertyAddress;

	private static int GetPerchRadiusThreshold_ReturnValue_Offset;

	private static bool GetMovementBase_IsValid;

	private static IntPtr GetMovementBase_FunctionAddress;

	private static int GetMovementBase_ParamsSize;

	private static bool GetMovementBase_ReturnValue_IsValid;

	private static FFieldAddress GetMovementBase_ReturnValue_PropertyAddress;

	private static int GetMovementBase_ReturnValue_Offset;

	private static bool GetMinAnalogSpeed_IsValid;

	private static IntPtr GetMinAnalogSpeed_FunctionAddress;

	private static int GetMinAnalogSpeed_ParamsSize;

	private static bool GetMinAnalogSpeed_ReturnValue_IsValid;

	private static FFieldAddress GetMinAnalogSpeed_ReturnValue_PropertyAddress;

	private static int GetMinAnalogSpeed_ReturnValue_Offset;

	private static bool GetMaxJumpHeightWithJumpTime_IsValid;

	private static IntPtr GetMaxJumpHeightWithJumpTime_FunctionAddress;

	private static int GetMaxJumpHeightWithJumpTime_ParamsSize;

	private static bool GetMaxJumpHeightWithJumpTime_ReturnValue_IsValid;

	private static FFieldAddress GetMaxJumpHeightWithJumpTime_ReturnValue_PropertyAddress;

	private static int GetMaxJumpHeightWithJumpTime_ReturnValue_Offset;

	private static bool GetMaxJumpHeight_IsValid;

	private static IntPtr GetMaxJumpHeight_FunctionAddress;

	private static int GetMaxJumpHeight_ParamsSize;

	private static bool GetMaxJumpHeight_ReturnValue_IsValid;

	private static FFieldAddress GetMaxJumpHeight_ReturnValue_PropertyAddress;

	private static int GetMaxJumpHeight_ReturnValue_Offset;

	private static bool GetMaxBrakingDeceleration_IsValid;

	private static IntPtr GetMaxBrakingDeceleration_FunctionAddress;

	private static int GetMaxBrakingDeceleration_ParamsSize;

	private static bool GetMaxBrakingDeceleration_ReturnValue_IsValid;

	private static FFieldAddress GetMaxBrakingDeceleration_ReturnValue_PropertyAddress;

	private static int GetMaxBrakingDeceleration_ReturnValue_Offset;

	private static bool GetMaxAcceleration_IsValid;

	private static IntPtr GetMaxAcceleration_FunctionAddress;

	private static int GetMaxAcceleration_ParamsSize;

	private static bool GetMaxAcceleration_ReturnValue_IsValid;

	private static FFieldAddress GetMaxAcceleration_ReturnValue_PropertyAddress;

	private static int GetMaxAcceleration_ReturnValue_Offset;

	private static bool GetLastUpdateVelocity_IsValid;

	private static IntPtr GetLastUpdateVelocity_FunctionAddress;

	private static int GetLastUpdateVelocity_ParamsSize;

	private static bool GetLastUpdateVelocity_ReturnValue_IsValid;

	private static FFieldAddress GetLastUpdateVelocity_ReturnValue_PropertyAddress;

	private static int GetLastUpdateVelocity_ReturnValue_Offset;

	private static bool GetLastUpdateRotation_IsValid;

	private static IntPtr GetLastUpdateRotation_FunctionAddress;

	private static int GetLastUpdateRotation_ParamsSize;

	private static bool GetLastUpdateRotation_ReturnValue_IsValid;

	private static FFieldAddress GetLastUpdateRotation_ReturnValue_PropertyAddress;

	private static int GetLastUpdateRotation_ReturnValue_Offset;

	private static bool GetLastUpdateLocation_IsValid;

	private static IntPtr GetLastUpdateLocation_FunctionAddress;

	private static int GetLastUpdateLocation_ParamsSize;

	private static bool GetLastUpdateLocation_ReturnValue_IsValid;

	private static FFieldAddress GetLastUpdateLocation_ReturnValue_PropertyAddress;

	private static int GetLastUpdateLocation_ReturnValue_Offset;

	private static bool GetImpartedMovementBaseVelocity_IsValid;

	private static IntPtr GetImpartedMovementBaseVelocity_FunctionAddress;

	private static int GetImpartedMovementBaseVelocity_ParamsSize;

	private static bool GetImpartedMovementBaseVelocity_ReturnValue_IsValid;

	private static FFieldAddress GetImpartedMovementBaseVelocity_ReturnValue_PropertyAddress;

	private static int GetImpartedMovementBaseVelocity_ReturnValue_Offset;

	private static bool GetCurrentAcceleration_IsValid;

	private static IntPtr GetCurrentAcceleration_FunctionAddress;

	private static int GetCurrentAcceleration_ParamsSize;

	private static bool GetCurrentAcceleration_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentAcceleration_ReturnValue_PropertyAddress;

	private static int GetCurrentAcceleration_ReturnValue_Offset;

	private static bool GetCrouchedHalfHeight_IsValid;

	private static IntPtr GetCrouchedHalfHeight_FunctionAddress;

	private static int GetCrouchedHalfHeight_ParamsSize;

	private static bool GetCrouchedHalfHeight_ReturnValue_IsValid;

	private static FFieldAddress GetCrouchedHalfHeight_ReturnValue_PropertyAddress;

	private static int GetCrouchedHalfHeight_ReturnValue_Offset;

	private static bool GetCharacterOwner_IsValid;

	private static IntPtr GetCharacterOwner_FunctionAddress;

	private static int GetCharacterOwner_ParamsSize;

	private static bool GetCharacterOwner_ReturnValue_IsValid;

	private static FFieldAddress GetCharacterOwner_ReturnValue_PropertyAddress;

	private static int GetCharacterOwner_ReturnValue_Offset;

	private static bool GetAnalogInputModifier_IsValid;

	private static IntPtr GetAnalogInputModifier_FunctionAddress;

	private static int GetAnalogInputModifier_ParamsSize;

	private static bool GetAnalogInputModifier_ReturnValue_IsValid;

	private static FFieldAddress GetAnalogInputModifier_ReturnValue_PropertyAddress;

	private static int GetAnalogInputModifier_ReturnValue_Offset;

	private static bool DisableMovement_IsValid;

	private static IntPtr DisableMovement_FunctionAddress;

	private static int DisableMovement_ParamsSize;

	private static bool ClearAccumulatedForces_IsValid;

	private static IntPtr ClearAccumulatedForces_FunctionAddress;

	private static int ClearAccumulatedForces_ParamsSize;

	private static bool CalcVelocity_IsValid;

	private static IntPtr CalcVelocity_FunctionAddress;

	private static int CalcVelocity_ParamsSize;

	private static bool CalcVelocity_DeltaTime_IsValid;

	private static FFieldAddress CalcVelocity_DeltaTime_PropertyAddress;

	private static int CalcVelocity_DeltaTime_Offset;

	private static bool CalcVelocity_Friction_IsValid;

	private static FFieldAddress CalcVelocity_Friction_PropertyAddress;

	private static int CalcVelocity_Friction_Offset;

	private static bool CalcVelocity_bFluid_IsValid;

	private static FFieldAddress CalcVelocity_bFluid_PropertyAddress;

	private static int CalcVelocity_bFluid_Offset;

	private static bool CalcVelocity_BrakingDeceleration_IsValid;

	private static FFieldAddress CalcVelocity_BrakingDeceleration_PropertyAddress;

	private static int CalcVelocity_BrakingDeceleration_Offset;

	private static bool AddImpulse_IsValid;

	private static IntPtr AddImpulse_FunctionAddress;

	private static int AddImpulse_ParamsSize;

	private static bool AddImpulse_Impulse_IsValid;

	private static FFieldAddress AddImpulse_Impulse_PropertyAddress;

	private static int AddImpulse_Impulse_Offset;

	private static bool AddImpulse_bVelocityChange_IsValid;

	private static FFieldAddress AddImpulse_bVelocityChange_PropertyAddress;

	private static int AddImpulse_bVelocityChange_Offset;

	private static bool AddForce_IsValid;

	private static IntPtr AddForce_FunctionAddress;

	private static int AddForce_ParamsSize;

	private static bool AddForce_Force_IsValid;

	private static FFieldAddress AddForce_Force_PropertyAddress;

	private static int AddForce_Force_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:GravityScale")]
	public float GravityScale
	{
		get
		{
			CheckDestroyed();
			if (!GravityScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:GravityScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GravityScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GravityScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:GravityScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GravityScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:MaxStepHeight")]
	public float MaxStepHeight
	{
		get
		{
			CheckDestroyed();
			if (!MaxStepHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxStepHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxStepHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxStepHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxStepHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxStepHeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:JumpZVelocity")]
	public float JumpZVelocity
	{
		get
		{
			CheckDestroyed();
			if (!JumpZVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:JumpZVelocity");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, JumpZVelocity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpZVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:JumpZVelocity");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, JumpZVelocity_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:JumpOffJumpZFactor")]
	public float JumpOffJumpZFactor
	{
		get
		{
			CheckDestroyed();
			if (!JumpOffJumpZFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:JumpOffJumpZFactor");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, JumpOffJumpZFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpOffJumpZFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:JumpOffJumpZFactor");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, JumpOffJumpZFactor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:MovementMode")]
	public EMovementMode MovementMode
	{
		get
		{
			CheckDestroyed();
			if (!MovementMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MovementMode");
				return EMovementMode.MOVE_None;
			}
			return EnumMarshaler<EMovementMode>.FromNative(IntPtr.Add(base.Address, MovementMode_Offset), 0, MovementMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MovementMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MovementMode");
			}
			else
			{
				EnumMarshaler<EMovementMode>.ToNative(IntPtr.Add(base.Address, MovementMode_Offset), 0, MovementMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:CustomMovementMode")]
	public byte CustomMovementMode
	{
		get
		{
			CheckDestroyed();
			if (!CustomMovementMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:CustomMovementMode");
				return 0;
			}
			return BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(base.Address, CustomMovementMode_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomMovementMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:CustomMovementMode");
			}
			else
			{
				BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(base.Address, CustomMovementMode_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:NetworkSmoothingMode")]
	public ENetworkSmoothingMode NetworkSmoothingMode
	{
		get
		{
			CheckDestroyed();
			if (!NetworkSmoothingMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:NetworkSmoothingMode");
				return ENetworkSmoothingMode.Disabled;
			}
			return EnumMarshaler<ENetworkSmoothingMode>.FromNative(IntPtr.Add(base.Address, NetworkSmoothingMode_Offset), 0, NetworkSmoothingMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NetworkSmoothingMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:NetworkSmoothingMode");
			}
			else
			{
				EnumMarshaler<ENetworkSmoothingMode>.ToNative(IntPtr.Add(base.Address, NetworkSmoothingMode_Offset), 0, NetworkSmoothingMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:GroundFriction")]
	public float GroundFriction
	{
		get
		{
			CheckDestroyed();
			if (!GroundFriction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:GroundFriction");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GroundFriction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GroundFriction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:GroundFriction");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GroundFriction_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:MaxWalkSpeed")]
	public float MaxWalkSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MaxWalkSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxWalkSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxWalkSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxWalkSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxWalkSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxWalkSpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:MaxWalkSpeedCrouched")]
	public float MaxWalkSpeedCrouched
	{
		get
		{
			CheckDestroyed();
			if (!MaxWalkSpeedCrouched_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxWalkSpeedCrouched");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxWalkSpeedCrouched_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxWalkSpeedCrouched_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxWalkSpeedCrouched");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxWalkSpeedCrouched_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:MaxSwimSpeed")]
	public float MaxSwimSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MaxSwimSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxSwimSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxSwimSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxSwimSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxSwimSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxSwimSpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:MaxFlySpeed")]
	public float MaxFlySpeed
	{
		get
		{
			CheckDestroyed();
			if (!MaxFlySpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxFlySpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxFlySpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxFlySpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxFlySpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxFlySpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:MaxCustomMovementSpeed")]
	public float MaxCustomMovementSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MaxCustomMovementSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxCustomMovementSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxCustomMovementSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxCustomMovementSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxCustomMovementSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxCustomMovementSpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:MaxAcceleration")]
	public float MaxAcceleration
	{
		get
		{
			CheckDestroyed();
			if (!MaxAcceleration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxAcceleration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxAcceleration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxAcceleration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxAcceleration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxAcceleration_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:MinAnalogWalkSpeed")]
	public float MinAnalogWalkSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MinAnalogWalkSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MinAnalogWalkSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinAnalogWalkSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinAnalogWalkSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MinAnalogWalkSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinAnalogWalkSpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:BrakingFrictionFactor")]
	public float BrakingFrictionFactor
	{
		get
		{
			CheckDestroyed();
			if (!BrakingFrictionFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:BrakingFrictionFactor");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BrakingFrictionFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrakingFrictionFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:BrakingFrictionFactor");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BrakingFrictionFactor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:BrakingFriction")]
	public float BrakingFriction
	{
		get
		{
			CheckDestroyed();
			if (!BrakingFriction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:BrakingFriction");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BrakingFriction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrakingFriction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:BrakingFriction");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BrakingFriction_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:BrakingSubStepTime")]
	public float BrakingSubStepTime
	{
		get
		{
			CheckDestroyed();
			if (!BrakingSubStepTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:BrakingSubStepTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BrakingSubStepTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrakingSubStepTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:BrakingSubStepTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BrakingSubStepTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:BrakingDecelerationWalking")]
	public float BrakingDecelerationWalking
	{
		get
		{
			CheckDestroyed();
			if (!BrakingDecelerationWalking_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:BrakingDecelerationWalking");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BrakingDecelerationWalking_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrakingDecelerationWalking_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:BrakingDecelerationWalking");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BrakingDecelerationWalking_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:BrakingDecelerationFalling")]
	public float BrakingDecelerationFalling
	{
		get
		{
			CheckDestroyed();
			if (!BrakingDecelerationFalling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:BrakingDecelerationFalling");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BrakingDecelerationFalling_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrakingDecelerationFalling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:BrakingDecelerationFalling");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BrakingDecelerationFalling_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:BrakingDecelerationSwimming")]
	public float BrakingDecelerationSwimming
	{
		get
		{
			CheckDestroyed();
			if (!BrakingDecelerationSwimming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:BrakingDecelerationSwimming");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BrakingDecelerationSwimming_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrakingDecelerationSwimming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:BrakingDecelerationSwimming");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BrakingDecelerationSwimming_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:BrakingDecelerationFlying")]
	public float BrakingDecelerationFlying
	{
		get
		{
			CheckDestroyed();
			if (!BrakingDecelerationFlying_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:BrakingDecelerationFlying");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BrakingDecelerationFlying_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrakingDecelerationFlying_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:BrakingDecelerationFlying");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BrakingDecelerationFlying_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:AirControl")]
	public float AirControl
	{
		get
		{
			CheckDestroyed();
			if (!AirControl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:AirControl");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AirControl_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AirControl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:AirControl");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AirControl_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:AirControlBoostMultiplier")]
	public float AirControlBoostMultiplier
	{
		get
		{
			CheckDestroyed();
			if (!AirControlBoostMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:AirControlBoostMultiplier");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AirControlBoostMultiplier_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AirControlBoostMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:AirControlBoostMultiplier");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AirControlBoostMultiplier_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:AirControlBoostVelocityThreshold")]
	public float AirControlBoostVelocityThreshold
	{
		get
		{
			CheckDestroyed();
			if (!AirControlBoostVelocityThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:AirControlBoostVelocityThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AirControlBoostVelocityThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AirControlBoostVelocityThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:AirControlBoostVelocityThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AirControlBoostVelocityThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:FallingLateralFriction")]
	public float FallingLateralFriction
	{
		get
		{
			CheckDestroyed();
			if (!FallingLateralFriction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:FallingLateralFriction");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FallingLateralFriction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FallingLateralFriction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:FallingLateralFriction");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FallingLateralFriction_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:CrouchedHalfHeight")]
	public float CrouchedHalfHeight
	{
		get
		{
			CheckDestroyed();
			if (!CrouchedHalfHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:CrouchedHalfHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CrouchedHalfHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CrouchedHalfHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:CrouchedHalfHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CrouchedHalfHeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:Buoyancy")]
	public float Buoyancy
	{
		get
		{
			CheckDestroyed();
			if (!Buoyancy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:Buoyancy");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Buoyancy_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Buoyancy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:Buoyancy");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Buoyancy_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:PerchRadiusThreshold")]
	public float PerchRadiusThreshold
	{
		get
		{
			CheckDestroyed();
			if (!PerchRadiusThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:PerchRadiusThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PerchRadiusThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PerchRadiusThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:PerchRadiusThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PerchRadiusThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:PerchAdditionalHeight")]
	public float PerchAdditionalHeight
	{
		get
		{
			CheckDestroyed();
			if (!PerchAdditionalHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:PerchAdditionalHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PerchAdditionalHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PerchAdditionalHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:PerchAdditionalHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PerchAdditionalHeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:RotationRate")]
	public FRotator RotationRate
	{
		get
		{
			CheckDestroyed();
			if (!RotationRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:RotationRate");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, RotationRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotationRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:RotationRate");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, RotationRate_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160598021uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bUseSeparateBrakingFriction")]
	protected bool UseSeparateBrakingFriction
	{
		get
		{
			CheckDestroyed();
			if (!UseSeparateBrakingFriction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bUseSeparateBrakingFriction");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseSeparateBrakingFriction_Offset), 0, UseSeparateBrakingFriction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseSeparateBrakingFriction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bUseSeparateBrakingFriction");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseSeparateBrakingFriction_Offset), 0, UseSeparateBrakingFriction_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bApplyGravityWhileJumping")]
	public bool ApplyGravityWhileJumping
	{
		get
		{
			CheckDestroyed();
			if (!ApplyGravityWhileJumping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bApplyGravityWhileJumping");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ApplyGravityWhileJumping_Offset), 0, ApplyGravityWhileJumping_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ApplyGravityWhileJumping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bApplyGravityWhileJumping");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ApplyGravityWhileJumping_Offset), 0, ApplyGravityWhileJumping_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bUseControllerDesiredRotation")]
	public bool UseControllerDesiredRotation
	{
		get
		{
			CheckDestroyed();
			if (!UseControllerDesiredRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bUseControllerDesiredRotation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseControllerDesiredRotation_Offset), 0, UseControllerDesiredRotation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseControllerDesiredRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bUseControllerDesiredRotation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseControllerDesiredRotation_Offset), 0, UseControllerDesiredRotation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bOrientRotationToMovement")]
	public bool OrientRotationToMovement
	{
		get
		{
			CheckDestroyed();
			if (!OrientRotationToMovement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bOrientRotationToMovement");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OrientRotationToMovement_Offset), 0, OrientRotationToMovement_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OrientRotationToMovement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bOrientRotationToMovement");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OrientRotationToMovement_Offset), 0, OrientRotationToMovement_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bSweepWhileNavWalking")]
	public bool SweepWhileNavWalking
	{
		get
		{
			CheckDestroyed();
			if (!SweepWhileNavWalking_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bSweepWhileNavWalking");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SweepWhileNavWalking_Offset), 0, SweepWhileNavWalking_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SweepWhileNavWalking_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bSweepWhileNavWalking");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SweepWhileNavWalking_Offset), 0, SweepWhileNavWalking_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bRunPhysicsWithNoController")]
	public bool RunPhysicsWithNoController
	{
		get
		{
			CheckDestroyed();
			if (!RunPhysicsWithNoController_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bRunPhysicsWithNoController");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RunPhysicsWithNoController_Offset), 0, RunPhysicsWithNoController_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RunPhysicsWithNoController_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bRunPhysicsWithNoController");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RunPhysicsWithNoController_Offset), 0, RunPhysicsWithNoController_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207176709uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bForceNextFloorCheck")]
	public bool ForceNextFloorCheck
	{
		get
		{
			CheckDestroyed();
			if (!ForceNextFloorCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bForceNextFloorCheck");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForceNextFloorCheck_Offset), 0, ForceNextFloorCheck_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceNextFloorCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bForceNextFloorCheck");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForceNextFloorCheck_Offset), 0, ForceNextFloorCheck_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bCanWalkOffLedges")]
	public bool CanWalkOffLedges
	{
		get
		{
			CheckDestroyed();
			if (!CanWalkOffLedges_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bCanWalkOffLedges");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CanWalkOffLedges_Offset), 0, CanWalkOffLedges_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CanWalkOffLedges_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bCanWalkOffLedges");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CanWalkOffLedges_Offset), 0, CanWalkOffLedges_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bCanWalkOffLedgesWhenCrouching")]
	public bool CanWalkOffLedgesWhenCrouching
	{
		get
		{
			CheckDestroyed();
			if (!CanWalkOffLedgesWhenCrouching_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bCanWalkOffLedgesWhenCrouching");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CanWalkOffLedgesWhenCrouching_Offset), 0, CanWalkOffLedgesWhenCrouching_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CanWalkOffLedgesWhenCrouching_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bCanWalkOffLedgesWhenCrouching");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CanWalkOffLedgesWhenCrouching_Offset), 0, CanWalkOffLedgesWhenCrouching_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bEnablePhysicsInteraction")]
	public bool EnablePhysicsInteraction
	{
		get
		{
			CheckDestroyed();
			if (!EnablePhysicsInteraction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bEnablePhysicsInteraction");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnablePhysicsInteraction_Offset), 0, EnablePhysicsInteraction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnablePhysicsInteraction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bEnablePhysicsInteraction");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnablePhysicsInteraction_Offset), 0, EnablePhysicsInteraction_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bTouchForceScaledToMass")]
	public bool TouchForceScaledToMass
	{
		get
		{
			CheckDestroyed();
			if (!TouchForceScaledToMass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bTouchForceScaledToMass");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TouchForceScaledToMass_Offset), 0, TouchForceScaledToMass_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TouchForceScaledToMass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bTouchForceScaledToMass");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TouchForceScaledToMass_Offset), 0, TouchForceScaledToMass_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bPushForceScaledToMass")]
	public bool PushForceScaledToMass
	{
		get
		{
			CheckDestroyed();
			if (!PushForceScaledToMass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bPushForceScaledToMass");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PushForceScaledToMass_Offset), 0, PushForceScaledToMass_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PushForceScaledToMass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bPushForceScaledToMass");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PushForceScaledToMass_Offset), 0, PushForceScaledToMass_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bPushForceUsingZOffset")]
	public bool PushForceUsingZOffset
	{
		get
		{
			CheckDestroyed();
			if (!PushForceUsingZOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bPushForceUsingZOffset");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PushForceUsingZOffset_Offset), 0, PushForceUsingZOffset_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PushForceUsingZOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bPushForceUsingZOffset");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PushForceUsingZOffset_Offset), 0, PushForceUsingZOffset_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bScalePushForceToVelocity")]
	public bool ScalePushForceToVelocity
	{
		get
		{
			CheckDestroyed();
			if (!ScalePushForceToVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bScalePushForceToVelocity");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ScalePushForceToVelocity_Offset), 0, ScalePushForceToVelocity_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ScalePushForceToVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bScalePushForceToVelocity");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ScalePushForceToVelocity_Offset), 0, ScalePushForceToVelocity_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:MaxOutOfWaterStepHeight")]
	public float MaxOutOfWaterStepHeight
	{
		get
		{
			CheckDestroyed();
			if (!MaxOutOfWaterStepHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxOutOfWaterStepHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxOutOfWaterStepHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxOutOfWaterStepHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxOutOfWaterStepHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxOutOfWaterStepHeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:OutofWaterZ")]
	public float OutofWaterZ
	{
		get
		{
			CheckDestroyed();
			if (!OutofWaterZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:OutofWaterZ");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OutofWaterZ_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutofWaterZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:OutofWaterZ");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OutofWaterZ_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:Mass")]
	public float Mass
	{
		get
		{
			CheckDestroyed();
			if (!Mass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:Mass");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Mass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Mass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:Mass");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Mass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:StandingDownwardForceScale")]
	public float StandingDownwardForceScale
	{
		get
		{
			CheckDestroyed();
			if (!StandingDownwardForceScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:StandingDownwardForceScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StandingDownwardForceScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StandingDownwardForceScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:StandingDownwardForceScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StandingDownwardForceScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:InitialPushForceFactor")]
	public float InitialPushForceFactor
	{
		get
		{
			CheckDestroyed();
			if (!InitialPushForceFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:InitialPushForceFactor");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InitialPushForceFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InitialPushForceFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:InitialPushForceFactor");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InitialPushForceFactor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:PushForceFactor")]
	public float PushForceFactor
	{
		get
		{
			CheckDestroyed();
			if (!PushForceFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:PushForceFactor");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PushForceFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PushForceFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:PushForceFactor");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PushForceFactor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:PushForcePointZOffsetFactor")]
	public float PushForcePointZOffsetFactor
	{
		get
		{
			CheckDestroyed();
			if (!PushForcePointZOffsetFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:PushForcePointZOffsetFactor");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PushForcePointZOffsetFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PushForcePointZOffsetFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:PushForcePointZOffsetFactor");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PushForcePointZOffsetFactor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:TouchForceFactor")]
	public float TouchForceFactor
	{
		get
		{
			CheckDestroyed();
			if (!TouchForceFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:TouchForceFactor");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TouchForceFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TouchForceFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:TouchForceFactor");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TouchForceFactor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:MinTouchForce")]
	public float MinTouchForce
	{
		get
		{
			CheckDestroyed();
			if (!MinTouchForce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MinTouchForce");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinTouchForce_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinTouchForce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MinTouchForce");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinTouchForce_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:MaxTouchForce")]
	public float MaxTouchForce
	{
		get
		{
			CheckDestroyed();
			if (!MaxTouchForce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxTouchForce");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxTouchForce_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxTouchForce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxTouchForce");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxTouchForce_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:RepulsionForce")]
	public float RepulsionForce
	{
		get
		{
			CheckDestroyed();
			if (!RepulsionForce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:RepulsionForce");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RepulsionForce_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RepulsionForce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:RepulsionForce");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RepulsionForce_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:MaxSimulationTimeStep")]
	public float MaxSimulationTimeStep
	{
		get
		{
			CheckDestroyed();
			if (!MaxSimulationTimeStep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxSimulationTimeStep");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxSimulationTimeStep_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxSimulationTimeStep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxSimulationTimeStep");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxSimulationTimeStep_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:MaxSimulationIterations")]
	public int MaxSimulationIterations
	{
		get
		{
			CheckDestroyed();
			if (!MaxSimulationIterations_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxSimulationIterations");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxSimulationIterations_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxSimulationIterations_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxSimulationIterations");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxSimulationIterations_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:MaxJumpApexAttemptsPerSimulation")]
	public int MaxJumpApexAttemptsPerSimulation
	{
		get
		{
			CheckDestroyed();
			if (!MaxJumpApexAttemptsPerSimulation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxJumpApexAttemptsPerSimulation");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxJumpApexAttemptsPerSimulation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxJumpApexAttemptsPerSimulation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxJumpApexAttemptsPerSimulation");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxJumpApexAttemptsPerSimulation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:MaxDepenetrationWithGeometry")]
	public float MaxDepenetrationWithGeometry
	{
		get
		{
			CheckDestroyed();
			if (!MaxDepenetrationWithGeometry_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxDepenetrationWithGeometry");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxDepenetrationWithGeometry_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxDepenetrationWithGeometry_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxDepenetrationWithGeometry");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxDepenetrationWithGeometry_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:MaxDepenetrationWithGeometryAsProxy")]
	public float MaxDepenetrationWithGeometryAsProxy
	{
		get
		{
			CheckDestroyed();
			if (!MaxDepenetrationWithGeometryAsProxy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxDepenetrationWithGeometryAsProxy");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxDepenetrationWithGeometryAsProxy_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxDepenetrationWithGeometryAsProxy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxDepenetrationWithGeometryAsProxy");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxDepenetrationWithGeometryAsProxy_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:MaxDepenetrationWithPawn")]
	public float MaxDepenetrationWithPawn
	{
		get
		{
			CheckDestroyed();
			if (!MaxDepenetrationWithPawn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxDepenetrationWithPawn");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxDepenetrationWithPawn_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxDepenetrationWithPawn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxDepenetrationWithPawn");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxDepenetrationWithPawn_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:MaxDepenetrationWithPawnAsProxy")]
	public float MaxDepenetrationWithPawnAsProxy
	{
		get
		{
			CheckDestroyed();
			if (!MaxDepenetrationWithPawnAsProxy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxDepenetrationWithPawnAsProxy");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxDepenetrationWithPawnAsProxy_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxDepenetrationWithPawnAsProxy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:MaxDepenetrationWithPawnAsProxy");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxDepenetrationWithPawnAsProxy_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:LedgeCheckThreshold")]
	public float LedgeCheckThreshold
	{
		get
		{
			CheckDestroyed();
			if (!LedgeCheckThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:LedgeCheckThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LedgeCheckThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LedgeCheckThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:LedgeCheckThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LedgeCheckThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:JumpOutOfWaterPitch")]
	public float JumpOutOfWaterPitch
	{
		get
		{
			CheckDestroyed();
			if (!JumpOutOfWaterPitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:JumpOutOfWaterPitch");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, JumpOutOfWaterPitch_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpOutOfWaterPitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:JumpOutOfWaterPitch");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, JumpOutOfWaterPitch_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4504218102794261uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:CurrentFloor")]
	public FFindFloorResult CurrentFloor
	{
		get
		{
			CheckDestroyed();
			if (!CurrentFloor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:CurrentFloor");
				return default(FFindFloorResult);
			}
			return FFindFloorResult.FromNative(IntPtr.Add(base.Address, CurrentFloor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurrentFloor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:CurrentFloor");
			}
			else
			{
				FFindFloorResult.ToNative(IntPtr.Add(base.Address, CurrentFloor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:DefaultLandMovementMode")]
	public EMovementMode DefaultLandMovementMode
	{
		get
		{
			CheckDestroyed();
			if (!DefaultLandMovementMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:DefaultLandMovementMode");
				return EMovementMode.MOVE_None;
			}
			return EnumMarshaler<EMovementMode>.FromNative(IntPtr.Add(base.Address, DefaultLandMovementMode_Offset), 0, DefaultLandMovementMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DefaultLandMovementMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:DefaultLandMovementMode");
			}
			else
			{
				EnumMarshaler<EMovementMode>.ToNative(IntPtr.Add(base.Address, DefaultLandMovementMode_Offset), 0, DefaultLandMovementMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:DefaultWaterMovementMode")]
	public EMovementMode DefaultWaterMovementMode
	{
		get
		{
			CheckDestroyed();
			if (!DefaultWaterMovementMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:DefaultWaterMovementMode");
				return EMovementMode.MOVE_None;
			}
			return EnumMarshaler<EMovementMode>.FromNative(IntPtr.Add(base.Address, DefaultWaterMovementMode_Offset), 0, DefaultWaterMovementMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DefaultWaterMovementMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:DefaultWaterMovementMode");
			}
			else
			{
				EnumMarshaler<EMovementMode>.ToNative(IntPtr.Add(base.Address, DefaultWaterMovementMode_Offset), 0, DefaultWaterMovementMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bMaintainHorizontalGroundVelocity")]
	public bool MaintainHorizontalGroundVelocity
	{
		get
		{
			CheckDestroyed();
			if (!MaintainHorizontalGroundVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bMaintainHorizontalGroundVelocity");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, MaintainHorizontalGroundVelocity_Offset), 0, MaintainHorizontalGroundVelocity_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MaintainHorizontalGroundVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bMaintainHorizontalGroundVelocity");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, MaintainHorizontalGroundVelocity_Offset), 0, MaintainHorizontalGroundVelocity_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bImpartBaseVelocityX")]
	public bool ImpartBaseVelocityX
	{
		get
		{
			CheckDestroyed();
			if (!ImpartBaseVelocityX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bImpartBaseVelocityX");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ImpartBaseVelocityX_Offset), 0, ImpartBaseVelocityX_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ImpartBaseVelocityX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bImpartBaseVelocityX");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ImpartBaseVelocityX_Offset), 0, ImpartBaseVelocityX_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bImpartBaseVelocityY")]
	public bool ImpartBaseVelocityY
	{
		get
		{
			CheckDestroyed();
			if (!ImpartBaseVelocityY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bImpartBaseVelocityY");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ImpartBaseVelocityY_Offset), 0, ImpartBaseVelocityY_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ImpartBaseVelocityY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bImpartBaseVelocityY");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ImpartBaseVelocityY_Offset), 0, ImpartBaseVelocityY_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bImpartBaseVelocityZ")]
	public bool ImpartBaseVelocityZ
	{
		get
		{
			CheckDestroyed();
			if (!ImpartBaseVelocityZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bImpartBaseVelocityZ");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ImpartBaseVelocityZ_Offset), 0, ImpartBaseVelocityZ_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ImpartBaseVelocityZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bImpartBaseVelocityZ");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ImpartBaseVelocityZ_Offset), 0, ImpartBaseVelocityZ_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bImpartBaseAngularVelocity")]
	public bool ImpartBaseAngularVelocity
	{
		get
		{
			CheckDestroyed();
			if (!ImpartBaseAngularVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bImpartBaseAngularVelocity");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ImpartBaseAngularVelocity_Offset), 0, ImpartBaseAngularVelocity_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ImpartBaseAngularVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bImpartBaseAngularVelocity");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ImpartBaseAngularVelocity_Offset), 0, ImpartBaseAngularVelocity_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160673797uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bJustTeleported")]
	public bool JustTeleported
	{
		get
		{
			CheckDestroyed();
			if (!JustTeleported_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bJustTeleported");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, JustTeleported_Offset), 0, JustTeleported_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!JustTeleported_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bJustTeleported");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, JustTeleported_Offset), 0, JustTeleported_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160540677uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bIgnoreClientMovementErrorChecksAndCorrection")]
	public bool IgnoreClientMovementErrorChecksAndCorrection
	{
		get
		{
			CheckDestroyed();
			if (!IgnoreClientMovementErrorChecksAndCorrection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bIgnoreClientMovementErrorChecksAndCorrection");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IgnoreClientMovementErrorChecksAndCorrection_Offset), 0, IgnoreClientMovementErrorChecksAndCorrection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IgnoreClientMovementErrorChecksAndCorrection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bIgnoreClientMovementErrorChecksAndCorrection");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IgnoreClientMovementErrorChecksAndCorrection_Offset), 0, IgnoreClientMovementErrorChecksAndCorrection_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160540677uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bServerAcceptClientAuthoritativePosition")]
	public bool ServerAcceptClientAuthoritativePosition
	{
		get
		{
			CheckDestroyed();
			if (!ServerAcceptClientAuthoritativePosition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bServerAcceptClientAuthoritativePosition");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ServerAcceptClientAuthoritativePosition_Offset), 0, ServerAcceptClientAuthoritativePosition_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ServerAcceptClientAuthoritativePosition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bServerAcceptClientAuthoritativePosition");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ServerAcceptClientAuthoritativePosition_Offset), 0, ServerAcceptClientAuthoritativePosition_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160663557uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bNotifyApex")]
	public bool NotifyApex
	{
		get
		{
			CheckDestroyed();
			if (!NotifyApex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bNotifyApex");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NotifyApex_Offset), 0, NotifyApex_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NotifyApex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bNotifyApex");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NotifyApex_Offset), 0, NotifyApex_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160665621uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bWantsToCrouch")]
	public bool WantsToCrouch
	{
		get
		{
			CheckDestroyed();
			if (!WantsToCrouch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bWantsToCrouch");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, WantsToCrouch_Offset), 0, WantsToCrouch_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WantsToCrouch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bWantsToCrouch");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, WantsToCrouch_Offset), 0, WantsToCrouch_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207176709uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bCrouchMaintainsBaseLocation")]
	public bool CrouchMaintainsBaseLocation
	{
		get
		{
			CheckDestroyed();
			if (!CrouchMaintainsBaseLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bCrouchMaintainsBaseLocation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CrouchMaintainsBaseLocation_Offset), 0, CrouchMaintainsBaseLocation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CrouchMaintainsBaseLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bCrouchMaintainsBaseLocation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CrouchMaintainsBaseLocation_Offset), 0, CrouchMaintainsBaseLocation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bIgnoreBaseRotation")]
	public bool IgnoreBaseRotation
	{
		get
		{
			CheckDestroyed();
			if (!IgnoreBaseRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bIgnoreBaseRotation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IgnoreBaseRotation_Offset), 0, IgnoreBaseRotation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IgnoreBaseRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bIgnoreBaseRotation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IgnoreBaseRotation_Offset), 0, IgnoreBaseRotation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bAlwaysCheckFloor")]
	public bool AlwaysCheckFloor
	{
		get
		{
			CheckDestroyed();
			if (!AlwaysCheckFloor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bAlwaysCheckFloor");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AlwaysCheckFloor_Offset), 0, AlwaysCheckFloor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AlwaysCheckFloor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bAlwaysCheckFloor");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AlwaysCheckFloor_Offset), 0, AlwaysCheckFloor_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bUseFlatBaseForFloorChecks")]
	public bool UseFlatBaseForFloorChecks
	{
		get
		{
			CheckDestroyed();
			if (!UseFlatBaseForFloorChecks_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bUseFlatBaseForFloorChecks");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseFlatBaseForFloorChecks_Offset), 0, UseFlatBaseForFloorChecks_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseFlatBaseForFloorChecks_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bUseFlatBaseForFloorChecks");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseFlatBaseForFloorChecks_Offset), 0, UseFlatBaseForFloorChecks_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bUseRVOAvoidance")]
	public bool UseRVOAvoidance
	{
		get
		{
			CheckDestroyed();
			if (!UseRVOAvoidance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bUseRVOAvoidance");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseRVOAvoidance_Offset), 0, UseRVOAvoidance_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseRVOAvoidance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bUseRVOAvoidance");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseRVOAvoidance_Offset), 0, UseRVOAvoidance_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bRequestedMoveUseAcceleration")]
	public bool RequestedMoveUseAcceleration
	{
		get
		{
			CheckDestroyed();
			if (!RequestedMoveUseAcceleration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bRequestedMoveUseAcceleration");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RequestedMoveUseAcceleration_Offset), 0, RequestedMoveUseAcceleration_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RequestedMoveUseAcceleration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bRequestedMoveUseAcceleration");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RequestedMoveUseAcceleration_Offset), 0, RequestedMoveUseAcceleration_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bAllowPhysicsRotationDuringAnimRootMotion")]
	public bool AllowPhysicsRotationDuringAnimRootMotion
	{
		get
		{
			CheckDestroyed();
			if (!AllowPhysicsRotationDuringAnimRootMotion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bAllowPhysicsRotationDuringAnimRootMotion");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AllowPhysicsRotationDuringAnimRootMotion_Offset), 0, AllowPhysicsRotationDuringAnimRootMotion_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AllowPhysicsRotationDuringAnimRootMotion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bAllowPhysicsRotationDuringAnimRootMotion");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AllowPhysicsRotationDuringAnimRootMotion_Offset), 0, AllowPhysicsRotationDuringAnimRootMotion_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:FormerBaseVelocityDecayHalfLife")]
	public float FormerBaseVelocityDecayHalfLife
	{
		get
		{
			CheckDestroyed();
			if (!FormerBaseVelocityDecayHalfLife_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:FormerBaseVelocityDecayHalfLife");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FormerBaseVelocityDecayHalfLife_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FormerBaseVelocityDecayHalfLife_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:FormerBaseVelocityDecayHalfLife");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FormerBaseVelocityDecayHalfLife_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267863880925205uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bProjectNavMeshWalking")]
	protected bool ProjectNavMeshWalking
	{
		get
		{
			CheckDestroyed();
			if (!ProjectNavMeshWalking_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bProjectNavMeshWalking");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ProjectNavMeshWalking_Offset), 0, ProjectNavMeshWalking_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ProjectNavMeshWalking_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bProjectNavMeshWalking");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ProjectNavMeshWalking_Offset), 0, ProjectNavMeshWalking_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11272261927436309uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:bProjectNavMeshOnBothWorldChannels")]
	protected bool ProjectNavMeshOnBothWorldChannels
	{
		get
		{
			CheckDestroyed();
			if (!ProjectNavMeshOnBothWorldChannels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bProjectNavMeshOnBothWorldChannels");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ProjectNavMeshOnBothWorldChannels_Offset), 0, ProjectNavMeshOnBothWorldChannels_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ProjectNavMeshOnBothWorldChannels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:bProjectNavMeshOnBothWorldChannels");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ProjectNavMeshOnBothWorldChannels_Offset), 0, ProjectNavMeshOnBothWorldChannels_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:AvoidanceConsiderationRadius")]
	public float AvoidanceConsiderationRadius
	{
		get
		{
			CheckDestroyed();
			if (!AvoidanceConsiderationRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:AvoidanceConsiderationRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AvoidanceConsiderationRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AvoidanceConsiderationRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:AvoidanceConsiderationRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AvoidanceConsiderationRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280917013uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:AvoidanceUID")]
	public int AvoidanceUID
	{
		get
		{
			CheckDestroyed();
			if (!AvoidanceUID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:AvoidanceUID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AvoidanceUID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AvoidanceUID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:AvoidanceUID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AvoidanceUID_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4508066393358357uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:AvoidanceGroup")]
	public FNavAvoidanceMask AvoidanceGroup
	{
		get
		{
			CheckDestroyed();
			if (!AvoidanceGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:AvoidanceGroup");
				return default(FNavAvoidanceMask);
			}
			return FNavAvoidanceMask.FromNative(IntPtr.Add(base.Address, AvoidanceGroup_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AvoidanceGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:AvoidanceGroup");
			}
			else
			{
				FNavAvoidanceMask.ToNative(IntPtr.Add(base.Address, AvoidanceGroup_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4508066393358357uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:GroupsToAvoid")]
	public FNavAvoidanceMask GroupsToAvoid
	{
		get
		{
			CheckDestroyed();
			if (!GroupsToAvoid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:GroupsToAvoid");
				return default(FNavAvoidanceMask);
			}
			return FNavAvoidanceMask.FromNative(IntPtr.Add(base.Address, GroupsToAvoid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GroupsToAvoid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:GroupsToAvoid");
			}
			else
			{
				FNavAvoidanceMask.ToNative(IntPtr.Add(base.Address, GroupsToAvoid_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4508066393358357uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:GroupsToIgnore")]
	public FNavAvoidanceMask GroupsToIgnore
	{
		get
		{
			CheckDestroyed();
			if (!GroupsToIgnore_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:GroupsToIgnore");
				return default(FNavAvoidanceMask);
			}
			return FNavAvoidanceMask.FromNative(IntPtr.Add(base.Address, GroupsToIgnore_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GroupsToIgnore_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:GroupsToIgnore");
			}
			else
			{
				FNavAvoidanceMask.ToNative(IntPtr.Add(base.Address, GroupsToIgnore_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:AvoidanceWeight")]
	public float AvoidanceWeight
	{
		get
		{
			CheckDestroyed();
			if (!AvoidanceWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:AvoidanceWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AvoidanceWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AvoidanceWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:AvoidanceWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AvoidanceWeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:NavMeshProjectionInterval")]
	public float NavMeshProjectionInterval
	{
		get
		{
			CheckDestroyed();
			if (!NavMeshProjectionInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:NavMeshProjectionInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NavMeshProjectionInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NavMeshProjectionInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:NavMeshProjectionInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NavMeshProjectionInterval_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:NavMeshProjectionInterpSpeed")]
	public float NavMeshProjectionInterpSpeed
	{
		get
		{
			CheckDestroyed();
			if (!NavMeshProjectionInterpSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:NavMeshProjectionInterpSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NavMeshProjectionInterpSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NavMeshProjectionInterpSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:NavMeshProjectionInterpSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NavMeshProjectionInterpSpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:NavMeshProjectionHeightScaleUp")]
	public float NavMeshProjectionHeightScaleUp
	{
		get
		{
			CheckDestroyed();
			if (!NavMeshProjectionHeightScaleUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:NavMeshProjectionHeightScaleUp");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NavMeshProjectionHeightScaleUp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NavMeshProjectionHeightScaleUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:NavMeshProjectionHeightScaleUp");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NavMeshProjectionHeightScaleUp_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:NavMeshProjectionHeightScaleDown")]
	public float NavMeshProjectionHeightScaleDown
	{
		get
		{
			CheckDestroyed();
			if (!NavMeshProjectionHeightScaleDown_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:NavMeshProjectionHeightScaleDown");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NavMeshProjectionHeightScaleDown_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NavMeshProjectionHeightScaleDown_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:NavMeshProjectionHeightScaleDown");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NavMeshProjectionHeightScaleDown_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:NavWalkingFloorDistTolerance")]
	public float NavWalkingFloorDistTolerance
	{
		get
		{
			CheckDestroyed();
			if (!NavWalkingFloorDistTolerance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:NavWalkingFloorDistTolerance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NavWalkingFloorDistTolerance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NavWalkingFloorDistTolerance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:NavWalkingFloorDistTolerance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NavWalkingFloorDistTolerance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283012uL)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:TickRateOptionMask")]
	public int TickRateOptionMask
	{
		get
		{
			CheckDestroyed();
			if (!TickRateOptionMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:TickRateOptionMask");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TickRateOptionMask_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TickRateOptionMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CharacterMovementComponent:TickRateOptionMask");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TickRateOptionMask_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:SetWalkableFloorZ")]
	public unsafe void SetWalkableFloorZ(float InWalkableFloorZ)
	{
		CheckDestroyed();
		if (!SetWalkableFloorZ_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:SetWalkableFloorZ");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWalkableFloorZ_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWalkableFloorZ_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetWalkableFloorZ_InWalkableFloorZ_Offset), 0, SetWalkableFloorZ_InWalkableFloorZ_PropertyAddress.Address, InWalkableFloorZ);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWalkableFloorZ_FunctionAddress, intPtr, SetWalkableFloorZ_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:SetWalkableFloorAngle")]
	public unsafe void SetWalkableFloorAngle(float InWalkableFloorAngle)
	{
		CheckDestroyed();
		if (!SetWalkableFloorAngle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:SetWalkableFloorAngle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWalkableFloorAngle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWalkableFloorAngle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetWalkableFloorAngle_InWalkableFloorAngle_Offset), 0, SetWalkableFloorAngle_InWalkableFloorAngle_PropertyAddress.Address, InWalkableFloorAngle);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWalkableFloorAngle_FunctionAddress, intPtr, SetWalkableFloorAngle_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:SetMovementMode")]
	public unsafe void SetMovementMode(EMovementMode NewMovementMode, byte NewCustomMode = 0)
	{
		CheckDestroyed();
		if (!SetMovementMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:SetMovementMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMovementMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMovementMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EMovementMode>.ToNative(IntPtr.Add(intPtr, SetMovementMode_NewMovementMode_Offset), 0, SetMovementMode_NewMovementMode_PropertyAddress.Address, NewMovementMode);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, SetMovementMode_NewCustomMode_Offset), 0, SetMovementMode_NewCustomMode_PropertyAddress.Address, NewCustomMode);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMovementMode_FunctionAddress, intPtr, SetMovementMode_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:SetGroupsToIgnoreMask")]
	public unsafe void SetGroupsToIgnoreMask(FNavAvoidanceMask GroupMask)
	{
		CheckDestroyed();
		if (!SetGroupsToIgnoreMask_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:SetGroupsToIgnoreMask");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGroupsToIgnoreMask_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGroupsToIgnoreMask_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetGroupsToIgnoreMask_GroupMask_PropertyAddress.Address, intPtr);
		FNavAvoidanceMask.ToNative(IntPtr.Add(intPtr, SetGroupsToIgnoreMask_GroupMask_Offset), 0, SetGroupsToIgnoreMask_GroupMask_PropertyAddress.Address, GroupMask);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGroupsToIgnoreMask_FunctionAddress, intPtr, SetGroupsToIgnoreMask_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:SetGroupsToAvoidMask")]
	public unsafe void SetGroupsToAvoidMask(FNavAvoidanceMask GroupMask)
	{
		CheckDestroyed();
		if (!SetGroupsToAvoidMask_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:SetGroupsToAvoidMask");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGroupsToAvoidMask_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGroupsToAvoidMask_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetGroupsToAvoidMask_GroupMask_PropertyAddress.Address, intPtr);
		FNavAvoidanceMask.ToNative(IntPtr.Add(intPtr, SetGroupsToAvoidMask_GroupMask_Offset), 0, SetGroupsToAvoidMask_GroupMask_PropertyAddress.Address, GroupMask);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGroupsToAvoidMask_FunctionAddress, intPtr, SetGroupsToAvoidMask_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:SetCrouchedHalfHeight")]
	public unsafe void SetCrouchedHalfHeight(float NewValue)
	{
		CheckDestroyed();
		if (!SetCrouchedHalfHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:SetCrouchedHalfHeight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCrouchedHalfHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCrouchedHalfHeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCrouchedHalfHeight_NewValue_Offset), 0, SetCrouchedHalfHeight_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCrouchedHalfHeight_FunctionAddress, intPtr, SetCrouchedHalfHeight_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:SetAvoidanceGroupMask")]
	public unsafe void SetAvoidanceGroupMask(FNavAvoidanceMask GroupMask)
	{
		CheckDestroyed();
		if (!SetAvoidanceGroupMask_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:SetAvoidanceGroupMask");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAvoidanceGroupMask_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAvoidanceGroupMask_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetAvoidanceGroupMask_GroupMask_PropertyAddress.Address, intPtr);
		FNavAvoidanceMask.ToNative(IntPtr.Add(intPtr, SetAvoidanceGroupMask_GroupMask_Offset), 0, SetAvoidanceGroupMask_GroupMask_PropertyAddress.Address, GroupMask);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAvoidanceGroupMask_FunctionAddress, intPtr, SetAvoidanceGroupMask_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:SetAvoidanceEnabled")]
	public unsafe void SetAvoidanceEnabled(bool bEnable)
	{
		CheckDestroyed();
		if (!SetAvoidanceEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:SetAvoidanceEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAvoidanceEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAvoidanceEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAvoidanceEnabled_bEnable_Offset), 0, SetAvoidanceEnabled_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAvoidanceEnabled_FunctionAddress, intPtr, SetAvoidanceEnabled_ParamsSize);
	}

	[UFunction(Flags = 1409418241u, OriginalName = "K2_GetWalkableFloorZ")]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:K2_GetWalkableFloorZ")]
	public unsafe float GetWalkableFloorZ()
	{
		CheckDestroyed();
		if (!GetWalkableFloorZ_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:K2_GetWalkableFloorZ");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWalkableFloorZ_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWalkableFloorZ_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWalkableFloorZ_FunctionAddress, intPtr, GetWalkableFloorZ_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetWalkableFloorZ_ReturnValue_Offset), 0, GetWalkableFloorZ_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u, OriginalName = "K2_GetWalkableFloorAngle")]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:K2_GetWalkableFloorAngle")]
	public unsafe float GetWalkableFloorAngle()
	{
		CheckDestroyed();
		if (!GetWalkableFloorAngle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:K2_GetWalkableFloorAngle");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWalkableFloorAngle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWalkableFloorAngle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWalkableFloorAngle_FunctionAddress, intPtr, GetWalkableFloorAngle_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetWalkableFloorAngle_ReturnValue_Offset), 0, GetWalkableFloorAngle_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001152u, OriginalName = "K2_FindFloor")]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:K2_FindFloor")]
	public unsafe void FindFloor(FVector CapsuleLocation, out FFindFloorResult FloorResult)
	{
		CheckDestroyed();
		if (!FindFloor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:K2_FindFloor");
			FloorResult = default(FFindFloorResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindFloor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindFloor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, FindFloor_CapsuleLocation_Offset), 0, FindFloor_CapsuleLocation_PropertyAddress.Address, CapsuleLocation);
		NativeReflection.InitializeValue_InContainer(FindFloor_FloorResult_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindFloor_FunctionAddress, intPtr, FindFloor_ParamsSize);
		FloorResult = FFindFloorResult.FromNative(IntPtr.Add(intPtr, FindFloor_FloorResult_Offset), 0, FindFloor_FloorResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001152u, OriginalName = "K2_ComputeFloorDist")]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:K2_ComputeFloorDist")]
	public unsafe void ComputeFloorDistance(FVector CapsuleLocation, float LineDistance, float SweepDistance, float SweepRadius, out FFindFloorResult FloorResult)
	{
		CheckDestroyed();
		if (!ComputeFloorDistance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:K2_ComputeFloorDist");
			FloorResult = default(FFindFloorResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ComputeFloorDistance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ComputeFloorDistance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ComputeFloorDistance_CapsuleLocation_Offset), 0, ComputeFloorDistance_CapsuleLocation_PropertyAddress.Address, CapsuleLocation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ComputeFloorDistance_LineDistance_Offset), 0, ComputeFloorDistance_LineDistance_PropertyAddress.Address, LineDistance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ComputeFloorDistance_SweepDistance_Offset), 0, ComputeFloorDistance_SweepDistance_PropertyAddress.Address, SweepDistance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ComputeFloorDistance_SweepRadius_Offset), 0, ComputeFloorDistance_SweepRadius_PropertyAddress.Address, SweepRadius);
		NativeReflection.InitializeValue_InContainer(ComputeFloorDistance_FloorResult_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, ComputeFloorDistance_FunctionAddress, intPtr, ComputeFloorDistance_ParamsSize);
		FloorResult = FFindFloorResult.FromNative(IntPtr.Add(intPtr, ComputeFloorDistance_FloorResult_Offset), 0, ComputeFloorDistance_FloorResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:IsWalking")]
	public unsafe bool IsWalking()
	{
		CheckDestroyed();
		if (!IsWalking_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:IsWalking");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsWalking_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsWalking_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsWalking_FunctionAddress, intPtr, IsWalking_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsWalking_ReturnValue_Offset), 0, IsWalking_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612544u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:IsWalkable")]
	public unsafe bool IsWalkable(FHitResult Hit)
	{
		CheckDestroyed();
		if (!IsWalkable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:IsWalkable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsWalkable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsWalkable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsWalkable_Hit_PropertyAddress.Address, intPtr);
		FHitResult.ToNative(IntPtr.Add(intPtr, IsWalkable_Hit_Offset), 0, IsWalkable_Hit_PropertyAddress.Address, Hit);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsWalkable_FunctionAddress, intPtr, IsWalkable_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsWalkable_ReturnValue_Offset), 0, IsWalkable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:GetValidPerchRadius")]
	public unsafe float GetValidPerchRadius()
	{
		CheckDestroyed();
		if (!GetValidPerchRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:GetValidPerchRadius");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetValidPerchRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetValidPerchRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetValidPerchRadius_FunctionAddress, intPtr, GetValidPerchRadius_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetValidPerchRadius_ReturnValue_Offset), 0, GetValidPerchRadius_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:GetPerchRadiusThreshold")]
	public unsafe float GetPerchRadiusThreshold()
	{
		CheckDestroyed();
		if (!GetPerchRadiusThreshold_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:GetPerchRadiusThreshold");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPerchRadiusThreshold_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPerchRadiusThreshold_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPerchRadiusThreshold_FunctionAddress, intPtr, GetPerchRadiusThreshold_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPerchRadiusThreshold_ReturnValue_Offset), 0, GetPerchRadiusThreshold_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:GetMovementBase")]
	public unsafe UPrimitiveComponent GetMovementBase()
	{
		CheckDestroyed();
		if (!GetMovementBase_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:GetMovementBase");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMovementBase_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMovementBase_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMovementBase_FunctionAddress, intPtr, GetMovementBase_ParamsSize);
		return UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(intPtr, GetMovementBase_ReturnValue_Offset), 0, GetMovementBase_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:GetMinAnalogSpeed")]
	public unsafe float GetMinAnalogSpeed()
	{
		CheckDestroyed();
		if (!GetMinAnalogSpeed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:GetMinAnalogSpeed");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMinAnalogSpeed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMinAnalogSpeed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMinAnalogSpeed_FunctionAddress, intPtr, GetMinAnalogSpeed_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetMinAnalogSpeed_ReturnValue_Offset), 0, GetMinAnalogSpeed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:GetMaxJumpHeightWithJumpTime")]
	public unsafe float GetMaxJumpHeightWithJumpTime()
	{
		CheckDestroyed();
		if (!GetMaxJumpHeightWithJumpTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:GetMaxJumpHeightWithJumpTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaxJumpHeightWithJumpTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaxJumpHeightWithJumpTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaxJumpHeightWithJumpTime_FunctionAddress, intPtr, GetMaxJumpHeightWithJumpTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetMaxJumpHeightWithJumpTime_ReturnValue_Offset), 0, GetMaxJumpHeightWithJumpTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:GetMaxJumpHeight")]
	public unsafe float GetMaxJumpHeight()
	{
		CheckDestroyed();
		if (!GetMaxJumpHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:GetMaxJumpHeight");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaxJumpHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaxJumpHeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaxJumpHeight_FunctionAddress, intPtr, GetMaxJumpHeight_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetMaxJumpHeight_ReturnValue_Offset), 0, GetMaxJumpHeight_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:GetMaxBrakingDeceleration")]
	public unsafe float GetMaxBrakingDeceleration()
	{
		CheckDestroyed();
		if (!GetMaxBrakingDeceleration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:GetMaxBrakingDeceleration");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaxBrakingDeceleration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaxBrakingDeceleration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaxBrakingDeceleration_FunctionAddress, intPtr, GetMaxBrakingDeceleration_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetMaxBrakingDeceleration_ReturnValue_Offset), 0, GetMaxBrakingDeceleration_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:GetMaxAcceleration")]
	public unsafe float GetMaxAcceleration()
	{
		CheckDestroyed();
		if (!GetMaxAcceleration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:GetMaxAcceleration");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaxAcceleration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaxAcceleration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaxAcceleration_FunctionAddress, intPtr, GetMaxAcceleration_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetMaxAcceleration_ReturnValue_Offset), 0, GetMaxAcceleration_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:GetLastUpdateVelocity")]
	public unsafe FVector GetLastUpdateVelocity()
	{
		CheckDestroyed();
		if (!GetLastUpdateVelocity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:GetLastUpdateVelocity");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLastUpdateVelocity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLastUpdateVelocity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLastUpdateVelocity_FunctionAddress, intPtr, GetLastUpdateVelocity_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLastUpdateVelocity_ReturnValue_Offset), 0, GetLastUpdateVelocity_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:GetLastUpdateRotation")]
	public unsafe FRotator GetLastUpdateRotation()
	{
		CheckDestroyed();
		if (!GetLastUpdateRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:GetLastUpdateRotation");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLastUpdateRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLastUpdateRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLastUpdateRotation_FunctionAddress, intPtr, GetLastUpdateRotation_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetLastUpdateRotation_ReturnValue_Offset), 0, GetLastUpdateRotation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:GetLastUpdateLocation")]
	public unsafe FVector GetLastUpdateLocation()
	{
		CheckDestroyed();
		if (!GetLastUpdateLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:GetLastUpdateLocation");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLastUpdateLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLastUpdateLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLastUpdateLocation_FunctionAddress, intPtr, GetLastUpdateLocation_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLastUpdateLocation_ReturnValue_Offset), 0, GetLastUpdateLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:GetImpartedMovementBaseVelocity")]
	public unsafe FVector GetImpartedMovementBaseVelocity()
	{
		CheckDestroyed();
		if (!GetImpartedMovementBaseVelocity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:GetImpartedMovementBaseVelocity");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetImpartedMovementBaseVelocity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetImpartedMovementBaseVelocity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetImpartedMovementBaseVelocity_FunctionAddress, intPtr, GetImpartedMovementBaseVelocity_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetImpartedMovementBaseVelocity_ReturnValue_Offset), 0, GetImpartedMovementBaseVelocity_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:GetCurrentAcceleration")]
	public unsafe FVector GetCurrentAcceleration()
	{
		CheckDestroyed();
		if (!GetCurrentAcceleration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:GetCurrentAcceleration");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentAcceleration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentAcceleration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentAcceleration_FunctionAddress, intPtr, GetCurrentAcceleration_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetCurrentAcceleration_ReturnValue_Offset), 0, GetCurrentAcceleration_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:GetCrouchedHalfHeight")]
	public unsafe float GetCrouchedHalfHeight()
	{
		CheckDestroyed();
		if (!GetCrouchedHalfHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:GetCrouchedHalfHeight");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCrouchedHalfHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCrouchedHalfHeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCrouchedHalfHeight_FunctionAddress, intPtr, GetCrouchedHalfHeight_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCrouchedHalfHeight_ReturnValue_Offset), 0, GetCrouchedHalfHeight_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:GetCharacterOwner")]
	public unsafe ACharacter GetCharacterOwner()
	{
		CheckDestroyed();
		if (!GetCharacterOwner_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:GetCharacterOwner");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCharacterOwner_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCharacterOwner_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCharacterOwner_FunctionAddress, intPtr, GetCharacterOwner_ParamsSize);
		return UObjectMarshaler<ACharacter>.FromNative(IntPtr.Add(intPtr, GetCharacterOwner_ReturnValue_Offset), 0, GetCharacterOwner_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:GetAnalogInputModifier")]
	public unsafe float GetAnalogInputModifier()
	{
		CheckDestroyed();
		if (!GetAnalogInputModifier_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:GetAnalogInputModifier");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnalogInputModifier_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnalogInputModifier_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAnalogInputModifier_FunctionAddress, intPtr, GetAnalogInputModifier_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAnalogInputModifier_ReturnValue_Offset), 0, GetAnalogInputModifier_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:DisableMovement")]
	public unsafe void DisableMovement()
	{
		CheckDestroyed();
		if (!DisableMovement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:DisableMovement");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisableMovement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisableMovement_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: DisableMovement_FunctionAddress, argsSize: DisableMovement_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:ClearAccumulatedForces")]
	public unsafe void ClearAccumulatedForces()
	{
		CheckDestroyed();
		if (!ClearAccumulatedForces_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:ClearAccumulatedForces");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearAccumulatedForces_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearAccumulatedForces_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearAccumulatedForces_FunctionAddress, argsSize: ClearAccumulatedForces_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:CalcVelocity")]
	public unsafe void CalcVelocity(float DeltaTime, float Friction, bool bFluid, float BrakingDeceleration)
	{
		CheckDestroyed();
		if (!CalcVelocity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:CalcVelocity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalcVelocity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalcVelocity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CalcVelocity_DeltaTime_Offset), 0, CalcVelocity_DeltaTime_PropertyAddress.Address, DeltaTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CalcVelocity_Friction_Offset), 0, CalcVelocity_Friction_PropertyAddress.Address, Friction);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CalcVelocity_bFluid_Offset), 0, CalcVelocity_bFluid_PropertyAddress.Address, bFluid);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CalcVelocity_BrakingDeceleration_Offset), 0, CalcVelocity_BrakingDeceleration_PropertyAddress.Address, BrakingDeceleration);
		NativeReflection.InvokeFunctionOptimized(base.Address, CalcVelocity_FunctionAddress, intPtr, CalcVelocity_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:AddImpulse")]
	public unsafe void AddImpulse(FVector Impulse, bool bVelocityChange = false)
	{
		CheckDestroyed();
		if (!AddImpulse_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:AddImpulse");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddImpulse_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddImpulse_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddImpulse_Impulse_Offset), 0, AddImpulse_Impulse_PropertyAddress.Address, Impulse);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddImpulse_bVelocityChange_Offset), 0, AddImpulse_bVelocityChange_PropertyAddress.Address, bVelocityChange);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddImpulse_FunctionAddress, intPtr, AddImpulse_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.CharacterMovementComponent:AddForce")]
	public unsafe void AddForce(FVector Force)
	{
		CheckDestroyed();
		if (!AddForce_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementComponent:AddForce");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddForce_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddForce_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddForce_Force_Offset), 0, AddForce_Force_PropertyAddress.Address, Force);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddForce_FunctionAddress, intPtr, AddForce_ParamsSize);
	}

	static UCharacterMovementComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCharacterMovementComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCharacterMovementComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.CharacterMovementComponent");
		GravityScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GravityScale");
		GravityScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GravityScale", Classes.FFloatProperty);
		MaxStepHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxStepHeight");
		MaxStepHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxStepHeight", Classes.FFloatProperty);
		JumpZVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JumpZVelocity");
		JumpZVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JumpZVelocity", Classes.FFloatProperty);
		JumpOffJumpZFactor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JumpOffJumpZFactor");
		JumpOffJumpZFactor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JumpOffJumpZFactor", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MovementMode_PropertyAddress, intPtr, "MovementMode");
		MovementMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MovementMode");
		MovementMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MovementMode", Classes.FByteProperty);
		CustomMovementMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomMovementMode");
		CustomMovementMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomMovementMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref NetworkSmoothingMode_PropertyAddress, intPtr, "NetworkSmoothingMode");
		NetworkSmoothingMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NetworkSmoothingMode");
		NetworkSmoothingMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NetworkSmoothingMode", Classes.FEnumProperty);
		GroundFriction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroundFriction");
		GroundFriction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroundFriction", Classes.FFloatProperty);
		MaxWalkSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxWalkSpeed");
		MaxWalkSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxWalkSpeed", Classes.FFloatProperty);
		MaxWalkSpeedCrouched_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxWalkSpeedCrouched");
		MaxWalkSpeedCrouched_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxWalkSpeedCrouched", Classes.FFloatProperty);
		MaxSwimSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxSwimSpeed");
		MaxSwimSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxSwimSpeed", Classes.FFloatProperty);
		MaxFlySpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxFlySpeed");
		MaxFlySpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxFlySpeed", Classes.FFloatProperty);
		MaxCustomMovementSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxCustomMovementSpeed");
		MaxCustomMovementSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxCustomMovementSpeed", Classes.FFloatProperty);
		MaxAcceleration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxAcceleration");
		MaxAcceleration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxAcceleration", Classes.FFloatProperty);
		MinAnalogWalkSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinAnalogWalkSpeed");
		MinAnalogWalkSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinAnalogWalkSpeed", Classes.FFloatProperty);
		BrakingFrictionFactor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BrakingFrictionFactor");
		BrakingFrictionFactor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BrakingFrictionFactor", Classes.FFloatProperty);
		BrakingFriction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BrakingFriction");
		BrakingFriction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BrakingFriction", Classes.FFloatProperty);
		BrakingSubStepTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BrakingSubStepTime");
		BrakingSubStepTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BrakingSubStepTime", Classes.FFloatProperty);
		BrakingDecelerationWalking_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BrakingDecelerationWalking");
		BrakingDecelerationWalking_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BrakingDecelerationWalking", Classes.FFloatProperty);
		BrakingDecelerationFalling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BrakingDecelerationFalling");
		BrakingDecelerationFalling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BrakingDecelerationFalling", Classes.FFloatProperty);
		BrakingDecelerationSwimming_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BrakingDecelerationSwimming");
		BrakingDecelerationSwimming_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BrakingDecelerationSwimming", Classes.FFloatProperty);
		BrakingDecelerationFlying_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BrakingDecelerationFlying");
		BrakingDecelerationFlying_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BrakingDecelerationFlying", Classes.FFloatProperty);
		AirControl_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AirControl");
		AirControl_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AirControl", Classes.FFloatProperty);
		AirControlBoostMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AirControlBoostMultiplier");
		AirControlBoostMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AirControlBoostMultiplier", Classes.FFloatProperty);
		AirControlBoostVelocityThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AirControlBoostVelocityThreshold");
		AirControlBoostVelocityThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AirControlBoostVelocityThreshold", Classes.FFloatProperty);
		FallingLateralFriction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FallingLateralFriction");
		FallingLateralFriction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FallingLateralFriction", Classes.FFloatProperty);
		CrouchedHalfHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CrouchedHalfHeight");
		CrouchedHalfHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CrouchedHalfHeight", Classes.FFloatProperty);
		Buoyancy_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Buoyancy");
		Buoyancy_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Buoyancy", Classes.FFloatProperty);
		PerchRadiusThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PerchRadiusThreshold");
		PerchRadiusThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PerchRadiusThreshold", Classes.FFloatProperty);
		PerchAdditionalHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PerchAdditionalHeight");
		PerchAdditionalHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PerchAdditionalHeight", Classes.FFloatProperty);
		RotationRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RotationRate");
		RotationRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RotationRate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UseSeparateBrakingFriction_PropertyAddress, intPtr, "bUseSeparateBrakingFriction");
		UseSeparateBrakingFriction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseSeparateBrakingFriction");
		UseSeparateBrakingFriction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseSeparateBrakingFriction", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyGravityWhileJumping_PropertyAddress, intPtr, "bApplyGravityWhileJumping");
		ApplyGravityWhileJumping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bApplyGravityWhileJumping");
		ApplyGravityWhileJumping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bApplyGravityWhileJumping", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseControllerDesiredRotation_PropertyAddress, intPtr, "bUseControllerDesiredRotation");
		UseControllerDesiredRotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseControllerDesiredRotation");
		UseControllerDesiredRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseControllerDesiredRotation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OrientRotationToMovement_PropertyAddress, intPtr, "bOrientRotationToMovement");
		OrientRotationToMovement_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOrientRotationToMovement");
		OrientRotationToMovement_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOrientRotationToMovement", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SweepWhileNavWalking_PropertyAddress, intPtr, "bSweepWhileNavWalking");
		SweepWhileNavWalking_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSweepWhileNavWalking");
		SweepWhileNavWalking_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSweepWhileNavWalking", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RunPhysicsWithNoController_PropertyAddress, intPtr, "bRunPhysicsWithNoController");
		RunPhysicsWithNoController_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRunPhysicsWithNoController");
		RunPhysicsWithNoController_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRunPhysicsWithNoController", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceNextFloorCheck_PropertyAddress, intPtr, "bForceNextFloorCheck");
		ForceNextFloorCheck_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bForceNextFloorCheck");
		ForceNextFloorCheck_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bForceNextFloorCheck", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanWalkOffLedges_PropertyAddress, intPtr, "bCanWalkOffLedges");
		CanWalkOffLedges_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanWalkOffLedges");
		CanWalkOffLedges_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanWalkOffLedges", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanWalkOffLedgesWhenCrouching_PropertyAddress, intPtr, "bCanWalkOffLedgesWhenCrouching");
		CanWalkOffLedgesWhenCrouching_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanWalkOffLedgesWhenCrouching");
		CanWalkOffLedgesWhenCrouching_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanWalkOffLedgesWhenCrouching", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnablePhysicsInteraction_PropertyAddress, intPtr, "bEnablePhysicsInteraction");
		EnablePhysicsInteraction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnablePhysicsInteraction");
		EnablePhysicsInteraction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnablePhysicsInteraction", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TouchForceScaledToMass_PropertyAddress, intPtr, "bTouchForceScaledToMass");
		TouchForceScaledToMass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bTouchForceScaledToMass");
		TouchForceScaledToMass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bTouchForceScaledToMass", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PushForceScaledToMass_PropertyAddress, intPtr, "bPushForceScaledToMass");
		PushForceScaledToMass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPushForceScaledToMass");
		PushForceScaledToMass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPushForceScaledToMass", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PushForceUsingZOffset_PropertyAddress, intPtr, "bPushForceUsingZOffset");
		PushForceUsingZOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPushForceUsingZOffset");
		PushForceUsingZOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPushForceUsingZOffset", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ScalePushForceToVelocity_PropertyAddress, intPtr, "bScalePushForceToVelocity");
		ScalePushForceToVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bScalePushForceToVelocity");
		ScalePushForceToVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bScalePushForceToVelocity", Classes.FBoolProperty);
		MaxOutOfWaterStepHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxOutOfWaterStepHeight");
		MaxOutOfWaterStepHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxOutOfWaterStepHeight", Classes.FFloatProperty);
		OutofWaterZ_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutofWaterZ");
		OutofWaterZ_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutofWaterZ", Classes.FFloatProperty);
		Mass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Mass");
		Mass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Mass", Classes.FFloatProperty);
		StandingDownwardForceScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StandingDownwardForceScale");
		StandingDownwardForceScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StandingDownwardForceScale", Classes.FFloatProperty);
		InitialPushForceFactor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InitialPushForceFactor");
		InitialPushForceFactor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InitialPushForceFactor", Classes.FFloatProperty);
		PushForceFactor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PushForceFactor");
		PushForceFactor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PushForceFactor", Classes.FFloatProperty);
		PushForcePointZOffsetFactor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PushForcePointZOffsetFactor");
		PushForcePointZOffsetFactor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PushForcePointZOffsetFactor", Classes.FFloatProperty);
		TouchForceFactor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TouchForceFactor");
		TouchForceFactor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TouchForceFactor", Classes.FFloatProperty);
		MinTouchForce_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinTouchForce");
		MinTouchForce_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinTouchForce", Classes.FFloatProperty);
		MaxTouchForce_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxTouchForce");
		MaxTouchForce_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxTouchForce", Classes.FFloatProperty);
		RepulsionForce_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RepulsionForce");
		RepulsionForce_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RepulsionForce", Classes.FFloatProperty);
		MaxSimulationTimeStep_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxSimulationTimeStep");
		MaxSimulationTimeStep_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxSimulationTimeStep", Classes.FFloatProperty);
		MaxSimulationIterations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxSimulationIterations");
		MaxSimulationIterations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxSimulationIterations", Classes.FIntProperty);
		MaxJumpApexAttemptsPerSimulation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxJumpApexAttemptsPerSimulation");
		MaxJumpApexAttemptsPerSimulation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxJumpApexAttemptsPerSimulation", Classes.FIntProperty);
		MaxDepenetrationWithGeometry_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxDepenetrationWithGeometry");
		MaxDepenetrationWithGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxDepenetrationWithGeometry", Classes.FFloatProperty);
		MaxDepenetrationWithGeometryAsProxy_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxDepenetrationWithGeometryAsProxy");
		MaxDepenetrationWithGeometryAsProxy_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxDepenetrationWithGeometryAsProxy", Classes.FFloatProperty);
		MaxDepenetrationWithPawn_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxDepenetrationWithPawn");
		MaxDepenetrationWithPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxDepenetrationWithPawn", Classes.FFloatProperty);
		MaxDepenetrationWithPawnAsProxy_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxDepenetrationWithPawnAsProxy");
		MaxDepenetrationWithPawnAsProxy_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxDepenetrationWithPawnAsProxy", Classes.FFloatProperty);
		LedgeCheckThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LedgeCheckThreshold");
		LedgeCheckThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LedgeCheckThreshold", Classes.FFloatProperty);
		JumpOutOfWaterPitch_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JumpOutOfWaterPitch");
		JumpOutOfWaterPitch_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JumpOutOfWaterPitch", Classes.FFloatProperty);
		CurrentFloor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurrentFloor");
		CurrentFloor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurrentFloor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DefaultLandMovementMode_PropertyAddress, intPtr, "DefaultLandMovementMode");
		DefaultLandMovementMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultLandMovementMode");
		DefaultLandMovementMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultLandMovementMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DefaultWaterMovementMode_PropertyAddress, intPtr, "DefaultWaterMovementMode");
		DefaultWaterMovementMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultWaterMovementMode");
		DefaultWaterMovementMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultWaterMovementMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref MaintainHorizontalGroundVelocity_PropertyAddress, intPtr, "bMaintainHorizontalGroundVelocity");
		MaintainHorizontalGroundVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMaintainHorizontalGroundVelocity");
		MaintainHorizontalGroundVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMaintainHorizontalGroundVelocity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImpartBaseVelocityX_PropertyAddress, intPtr, "bImpartBaseVelocityX");
		ImpartBaseVelocityX_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bImpartBaseVelocityX");
		ImpartBaseVelocityX_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bImpartBaseVelocityX", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImpartBaseVelocityY_PropertyAddress, intPtr, "bImpartBaseVelocityY");
		ImpartBaseVelocityY_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bImpartBaseVelocityY");
		ImpartBaseVelocityY_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bImpartBaseVelocityY", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImpartBaseVelocityZ_PropertyAddress, intPtr, "bImpartBaseVelocityZ");
		ImpartBaseVelocityZ_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bImpartBaseVelocityZ");
		ImpartBaseVelocityZ_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bImpartBaseVelocityZ", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImpartBaseAngularVelocity_PropertyAddress, intPtr, "bImpartBaseAngularVelocity");
		ImpartBaseAngularVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bImpartBaseAngularVelocity");
		ImpartBaseAngularVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bImpartBaseAngularVelocity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref JustTeleported_PropertyAddress, intPtr, "bJustTeleported");
		JustTeleported_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bJustTeleported");
		JustTeleported_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bJustTeleported", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnoreClientMovementErrorChecksAndCorrection_PropertyAddress, intPtr, "bIgnoreClientMovementErrorChecksAndCorrection");
		IgnoreClientMovementErrorChecksAndCorrection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIgnoreClientMovementErrorChecksAndCorrection");
		IgnoreClientMovementErrorChecksAndCorrection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIgnoreClientMovementErrorChecksAndCorrection", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ServerAcceptClientAuthoritativePosition_PropertyAddress, intPtr, "bServerAcceptClientAuthoritativePosition");
		ServerAcceptClientAuthoritativePosition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bServerAcceptClientAuthoritativePosition");
		ServerAcceptClientAuthoritativePosition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bServerAcceptClientAuthoritativePosition", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref NotifyApex_PropertyAddress, intPtr, "bNotifyApex");
		NotifyApex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bNotifyApex");
		NotifyApex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bNotifyApex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref WantsToCrouch_PropertyAddress, intPtr, "bWantsToCrouch");
		WantsToCrouch_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bWantsToCrouch");
		WantsToCrouch_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bWantsToCrouch", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CrouchMaintainsBaseLocation_PropertyAddress, intPtr, "bCrouchMaintainsBaseLocation");
		CrouchMaintainsBaseLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCrouchMaintainsBaseLocation");
		CrouchMaintainsBaseLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCrouchMaintainsBaseLocation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnoreBaseRotation_PropertyAddress, intPtr, "bIgnoreBaseRotation");
		IgnoreBaseRotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIgnoreBaseRotation");
		IgnoreBaseRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIgnoreBaseRotation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AlwaysCheckFloor_PropertyAddress, intPtr, "bAlwaysCheckFloor");
		AlwaysCheckFloor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAlwaysCheckFloor");
		AlwaysCheckFloor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAlwaysCheckFloor", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseFlatBaseForFloorChecks_PropertyAddress, intPtr, "bUseFlatBaseForFloorChecks");
		UseFlatBaseForFloorChecks_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseFlatBaseForFloorChecks");
		UseFlatBaseForFloorChecks_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseFlatBaseForFloorChecks", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseRVOAvoidance_PropertyAddress, intPtr, "bUseRVOAvoidance");
		UseRVOAvoidance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseRVOAvoidance");
		UseRVOAvoidance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseRVOAvoidance", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestedMoveUseAcceleration_PropertyAddress, intPtr, "bRequestedMoveUseAcceleration");
		RequestedMoveUseAcceleration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRequestedMoveUseAcceleration");
		RequestedMoveUseAcceleration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRequestedMoveUseAcceleration", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowPhysicsRotationDuringAnimRootMotion_PropertyAddress, intPtr, "bAllowPhysicsRotationDuringAnimRootMotion");
		AllowPhysicsRotationDuringAnimRootMotion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowPhysicsRotationDuringAnimRootMotion");
		AllowPhysicsRotationDuringAnimRootMotion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowPhysicsRotationDuringAnimRootMotion", Classes.FBoolProperty);
		FormerBaseVelocityDecayHalfLife_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FormerBaseVelocityDecayHalfLife");
		FormerBaseVelocityDecayHalfLife_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FormerBaseVelocityDecayHalfLife", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectNavMeshWalking_PropertyAddress, intPtr, "bProjectNavMeshWalking");
		ProjectNavMeshWalking_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bProjectNavMeshWalking");
		ProjectNavMeshWalking_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bProjectNavMeshWalking", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectNavMeshOnBothWorldChannels_PropertyAddress, intPtr, "bProjectNavMeshOnBothWorldChannels");
		ProjectNavMeshOnBothWorldChannels_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bProjectNavMeshOnBothWorldChannels");
		ProjectNavMeshOnBothWorldChannels_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bProjectNavMeshOnBothWorldChannels", Classes.FBoolProperty);
		AvoidanceConsiderationRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AvoidanceConsiderationRadius");
		AvoidanceConsiderationRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AvoidanceConsiderationRadius", Classes.FFloatProperty);
		AvoidanceUID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AvoidanceUID");
		AvoidanceUID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AvoidanceUID", Classes.FIntProperty);
		AvoidanceGroup_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AvoidanceGroup");
		AvoidanceGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AvoidanceGroup", Classes.FStructProperty);
		GroupsToAvoid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroupsToAvoid");
		GroupsToAvoid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroupsToAvoid", Classes.FStructProperty);
		GroupsToIgnore_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroupsToIgnore");
		GroupsToIgnore_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroupsToIgnore", Classes.FStructProperty);
		AvoidanceWeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AvoidanceWeight");
		AvoidanceWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AvoidanceWeight", Classes.FFloatProperty);
		NavMeshProjectionInterval_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NavMeshProjectionInterval");
		NavMeshProjectionInterval_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NavMeshProjectionInterval", Classes.FFloatProperty);
		NavMeshProjectionInterpSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NavMeshProjectionInterpSpeed");
		NavMeshProjectionInterpSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NavMeshProjectionInterpSpeed", Classes.FFloatProperty);
		NavMeshProjectionHeightScaleUp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NavMeshProjectionHeightScaleUp");
		NavMeshProjectionHeightScaleUp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NavMeshProjectionHeightScaleUp", Classes.FFloatProperty);
		NavMeshProjectionHeightScaleDown_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NavMeshProjectionHeightScaleDown");
		NavMeshProjectionHeightScaleDown_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NavMeshProjectionHeightScaleDown", Classes.FFloatProperty);
		NavWalkingFloorDistTolerance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NavWalkingFloorDistTolerance");
		NavWalkingFloorDistTolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NavWalkingFloorDistTolerance", Classes.FFloatProperty);
		TickRateOptionMask_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TickRateOptionMask");
		TickRateOptionMask_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TickRateOptionMask", Classes.FIntProperty);
		SetWalkableFloorZ_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetWalkableFloorZ");
		SetWalkableFloorZ_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWalkableFloorZ_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWalkableFloorZ_InWalkableFloorZ_PropertyAddress, SetWalkableFloorZ_FunctionAddress, "InWalkableFloorZ");
		SetWalkableFloorZ_InWalkableFloorZ_Offset = NativeReflectionCached.GetPropertyOffset(SetWalkableFloorZ_FunctionAddress, "InWalkableFloorZ");
		SetWalkableFloorZ_InWalkableFloorZ_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWalkableFloorZ_FunctionAddress, "InWalkableFloorZ", Classes.FFloatProperty);
		SetWalkableFloorZ_IsValid = SetWalkableFloorZ_FunctionAddress != IntPtr.Zero && SetWalkableFloorZ_InWalkableFloorZ_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:SetWalkableFloorZ", SetWalkableFloorZ_IsValid);
		SetWalkableFloorAngle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetWalkableFloorAngle");
		SetWalkableFloorAngle_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWalkableFloorAngle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWalkableFloorAngle_InWalkableFloorAngle_PropertyAddress, SetWalkableFloorAngle_FunctionAddress, "InWalkableFloorAngle");
		SetWalkableFloorAngle_InWalkableFloorAngle_Offset = NativeReflectionCached.GetPropertyOffset(SetWalkableFloorAngle_FunctionAddress, "InWalkableFloorAngle");
		SetWalkableFloorAngle_InWalkableFloorAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWalkableFloorAngle_FunctionAddress, "InWalkableFloorAngle", Classes.FFloatProperty);
		SetWalkableFloorAngle_IsValid = SetWalkableFloorAngle_FunctionAddress != IntPtr.Zero && SetWalkableFloorAngle_InWalkableFloorAngle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:SetWalkableFloorAngle", SetWalkableFloorAngle_IsValid);
		SetMovementMode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMovementMode");
		SetMovementMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMovementMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMovementMode_NewMovementMode_PropertyAddress, SetMovementMode_FunctionAddress, "NewMovementMode");
		SetMovementMode_NewMovementMode_Offset = NativeReflectionCached.GetPropertyOffset(SetMovementMode_FunctionAddress, "NewMovementMode");
		SetMovementMode_NewMovementMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMovementMode_FunctionAddress, "NewMovementMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMovementMode_NewCustomMode_PropertyAddress, SetMovementMode_FunctionAddress, "NewCustomMode");
		SetMovementMode_NewCustomMode_Offset = NativeReflectionCached.GetPropertyOffset(SetMovementMode_FunctionAddress, "NewCustomMode");
		SetMovementMode_NewCustomMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMovementMode_FunctionAddress, "NewCustomMode", Classes.FByteProperty);
		SetMovementMode_IsValid = SetMovementMode_FunctionAddress != IntPtr.Zero && SetMovementMode_NewMovementMode_IsValid && SetMovementMode_NewCustomMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:SetMovementMode", SetMovementMode_IsValid);
		SetGroupsToIgnoreMask_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGroupsToIgnoreMask");
		SetGroupsToIgnoreMask_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGroupsToIgnoreMask_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGroupsToIgnoreMask_GroupMask_PropertyAddress, SetGroupsToIgnoreMask_FunctionAddress, "GroupMask");
		SetGroupsToIgnoreMask_GroupMask_Offset = NativeReflectionCached.GetPropertyOffset(SetGroupsToIgnoreMask_FunctionAddress, "GroupMask");
		SetGroupsToIgnoreMask_GroupMask_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGroupsToIgnoreMask_FunctionAddress, "GroupMask", Classes.FStructProperty);
		SetGroupsToIgnoreMask_IsValid = SetGroupsToIgnoreMask_FunctionAddress != IntPtr.Zero && SetGroupsToIgnoreMask_GroupMask_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:SetGroupsToIgnoreMask", SetGroupsToIgnoreMask_IsValid);
		SetGroupsToAvoidMask_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGroupsToAvoidMask");
		SetGroupsToAvoidMask_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGroupsToAvoidMask_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGroupsToAvoidMask_GroupMask_PropertyAddress, SetGroupsToAvoidMask_FunctionAddress, "GroupMask");
		SetGroupsToAvoidMask_GroupMask_Offset = NativeReflectionCached.GetPropertyOffset(SetGroupsToAvoidMask_FunctionAddress, "GroupMask");
		SetGroupsToAvoidMask_GroupMask_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGroupsToAvoidMask_FunctionAddress, "GroupMask", Classes.FStructProperty);
		SetGroupsToAvoidMask_IsValid = SetGroupsToAvoidMask_FunctionAddress != IntPtr.Zero && SetGroupsToAvoidMask_GroupMask_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:SetGroupsToAvoidMask", SetGroupsToAvoidMask_IsValid);
		SetCrouchedHalfHeight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCrouchedHalfHeight");
		SetCrouchedHalfHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCrouchedHalfHeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCrouchedHalfHeight_NewValue_PropertyAddress, SetCrouchedHalfHeight_FunctionAddress, "NewValue");
		SetCrouchedHalfHeight_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCrouchedHalfHeight_FunctionAddress, "NewValue");
		SetCrouchedHalfHeight_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCrouchedHalfHeight_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetCrouchedHalfHeight_IsValid = SetCrouchedHalfHeight_FunctionAddress != IntPtr.Zero && SetCrouchedHalfHeight_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:SetCrouchedHalfHeight", SetCrouchedHalfHeight_IsValid);
		SetAvoidanceGroupMask_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAvoidanceGroupMask");
		SetAvoidanceGroupMask_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAvoidanceGroupMask_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAvoidanceGroupMask_GroupMask_PropertyAddress, SetAvoidanceGroupMask_FunctionAddress, "GroupMask");
		SetAvoidanceGroupMask_GroupMask_Offset = NativeReflectionCached.GetPropertyOffset(SetAvoidanceGroupMask_FunctionAddress, "GroupMask");
		SetAvoidanceGroupMask_GroupMask_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAvoidanceGroupMask_FunctionAddress, "GroupMask", Classes.FStructProperty);
		SetAvoidanceGroupMask_IsValid = SetAvoidanceGroupMask_FunctionAddress != IntPtr.Zero && SetAvoidanceGroupMask_GroupMask_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:SetAvoidanceGroupMask", SetAvoidanceGroupMask_IsValid);
		SetAvoidanceEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAvoidanceEnabled");
		SetAvoidanceEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAvoidanceEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAvoidanceEnabled_bEnable_PropertyAddress, SetAvoidanceEnabled_FunctionAddress, "bEnable");
		SetAvoidanceEnabled_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(SetAvoidanceEnabled_FunctionAddress, "bEnable");
		SetAvoidanceEnabled_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAvoidanceEnabled_FunctionAddress, "bEnable", Classes.FBoolProperty);
		SetAvoidanceEnabled_IsValid = SetAvoidanceEnabled_FunctionAddress != IntPtr.Zero && SetAvoidanceEnabled_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:SetAvoidanceEnabled", SetAvoidanceEnabled_IsValid);
		GetWalkableFloorZ_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_GetWalkableFloorZ");
		GetWalkableFloorZ_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWalkableFloorZ_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWalkableFloorZ_ReturnValue_PropertyAddress, GetWalkableFloorZ_FunctionAddress, "ReturnValue");
		GetWalkableFloorZ_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWalkableFloorZ_FunctionAddress, "ReturnValue");
		GetWalkableFloorZ_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWalkableFloorZ_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetWalkableFloorZ_IsValid = GetWalkableFloorZ_FunctionAddress != IntPtr.Zero && GetWalkableFloorZ_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:K2_GetWalkableFloorZ", GetWalkableFloorZ_IsValid);
		GetWalkableFloorAngle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_GetWalkableFloorAngle");
		GetWalkableFloorAngle_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWalkableFloorAngle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWalkableFloorAngle_ReturnValue_PropertyAddress, GetWalkableFloorAngle_FunctionAddress, "ReturnValue");
		GetWalkableFloorAngle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWalkableFloorAngle_FunctionAddress, "ReturnValue");
		GetWalkableFloorAngle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWalkableFloorAngle_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetWalkableFloorAngle_IsValid = GetWalkableFloorAngle_FunctionAddress != IntPtr.Zero && GetWalkableFloorAngle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:K2_GetWalkableFloorAngle", GetWalkableFloorAngle_IsValid);
		FindFloor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_FindFloor");
		FindFloor_ParamsSize = NativeReflection.GetFunctionParamsSize(FindFloor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindFloor_CapsuleLocation_PropertyAddress, FindFloor_FunctionAddress, "CapsuleLocation");
		FindFloor_CapsuleLocation_Offset = NativeReflectionCached.GetPropertyOffset(FindFloor_FunctionAddress, "CapsuleLocation");
		FindFloor_CapsuleLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(FindFloor_FunctionAddress, "CapsuleLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindFloor_FloorResult_PropertyAddress, FindFloor_FunctionAddress, "FloorResult");
		FindFloor_FloorResult_Offset = NativeReflectionCached.GetPropertyOffset(FindFloor_FunctionAddress, "FloorResult");
		FindFloor_FloorResult_IsValid = NativeReflectionCached.ValidatePropertyClass(FindFloor_FunctionAddress, "FloorResult", Classes.FStructProperty);
		FindFloor_IsValid = FindFloor_FunctionAddress != IntPtr.Zero && FindFloor_CapsuleLocation_IsValid && FindFloor_FloorResult_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:K2_FindFloor", FindFloor_IsValid);
		ComputeFloorDistance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_ComputeFloorDist");
		ComputeFloorDistance_ParamsSize = NativeReflection.GetFunctionParamsSize(ComputeFloorDistance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ComputeFloorDistance_CapsuleLocation_PropertyAddress, ComputeFloorDistance_FunctionAddress, "CapsuleLocation");
		ComputeFloorDistance_CapsuleLocation_Offset = NativeReflectionCached.GetPropertyOffset(ComputeFloorDistance_FunctionAddress, "CapsuleLocation");
		ComputeFloorDistance_CapsuleLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeFloorDistance_FunctionAddress, "CapsuleLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeFloorDistance_LineDistance_PropertyAddress, ComputeFloorDistance_FunctionAddress, "LineDistance");
		ComputeFloorDistance_LineDistance_Offset = NativeReflectionCached.GetPropertyOffset(ComputeFloorDistance_FunctionAddress, "LineDistance");
		ComputeFloorDistance_LineDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeFloorDistance_FunctionAddress, "LineDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeFloorDistance_SweepDistance_PropertyAddress, ComputeFloorDistance_FunctionAddress, "SweepDistance");
		ComputeFloorDistance_SweepDistance_Offset = NativeReflectionCached.GetPropertyOffset(ComputeFloorDistance_FunctionAddress, "SweepDistance");
		ComputeFloorDistance_SweepDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeFloorDistance_FunctionAddress, "SweepDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeFloorDistance_SweepRadius_PropertyAddress, ComputeFloorDistance_FunctionAddress, "SweepRadius");
		ComputeFloorDistance_SweepRadius_Offset = NativeReflectionCached.GetPropertyOffset(ComputeFloorDistance_FunctionAddress, "SweepRadius");
		ComputeFloorDistance_SweepRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeFloorDistance_FunctionAddress, "SweepRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeFloorDistance_FloorResult_PropertyAddress, ComputeFloorDistance_FunctionAddress, "FloorResult");
		ComputeFloorDistance_FloorResult_Offset = NativeReflectionCached.GetPropertyOffset(ComputeFloorDistance_FunctionAddress, "FloorResult");
		ComputeFloorDistance_FloorResult_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeFloorDistance_FunctionAddress, "FloorResult", Classes.FStructProperty);
		ComputeFloorDistance_IsValid = ComputeFloorDistance_FunctionAddress != IntPtr.Zero && ComputeFloorDistance_CapsuleLocation_IsValid && ComputeFloorDistance_LineDistance_IsValid && ComputeFloorDistance_SweepDistance_IsValid && ComputeFloorDistance_SweepRadius_IsValid && ComputeFloorDistance_FloorResult_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:K2_ComputeFloorDist", ComputeFloorDistance_IsValid);
		IsWalking_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsWalking");
		IsWalking_ParamsSize = NativeReflection.GetFunctionParamsSize(IsWalking_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsWalking_ReturnValue_PropertyAddress, IsWalking_FunctionAddress, "ReturnValue");
		IsWalking_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsWalking_FunctionAddress, "ReturnValue");
		IsWalking_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsWalking_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsWalking_IsValid = IsWalking_FunctionAddress != IntPtr.Zero && IsWalking_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:IsWalking", IsWalking_IsValid);
		IsWalkable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsWalkable");
		IsWalkable_ParamsSize = NativeReflection.GetFunctionParamsSize(IsWalkable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsWalkable_Hit_PropertyAddress, IsWalkable_FunctionAddress, "Hit");
		IsWalkable_Hit_Offset = NativeReflectionCached.GetPropertyOffset(IsWalkable_FunctionAddress, "Hit");
		IsWalkable_Hit_IsValid = NativeReflectionCached.ValidatePropertyClass(IsWalkable_FunctionAddress, "Hit", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsWalkable_ReturnValue_PropertyAddress, IsWalkable_FunctionAddress, "ReturnValue");
		IsWalkable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsWalkable_FunctionAddress, "ReturnValue");
		IsWalkable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsWalkable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsWalkable_IsValid = IsWalkable_FunctionAddress != IntPtr.Zero && IsWalkable_Hit_IsValid && IsWalkable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:IsWalkable", IsWalkable_IsValid);
		GetValidPerchRadius_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetValidPerchRadius");
		GetValidPerchRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(GetValidPerchRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetValidPerchRadius_ReturnValue_PropertyAddress, GetValidPerchRadius_FunctionAddress, "ReturnValue");
		GetValidPerchRadius_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetValidPerchRadius_FunctionAddress, "ReturnValue");
		GetValidPerchRadius_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValidPerchRadius_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetValidPerchRadius_IsValid = GetValidPerchRadius_FunctionAddress != IntPtr.Zero && GetValidPerchRadius_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:GetValidPerchRadius", GetValidPerchRadius_IsValid);
		GetPerchRadiusThreshold_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPerchRadiusThreshold");
		GetPerchRadiusThreshold_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPerchRadiusThreshold_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPerchRadiusThreshold_ReturnValue_PropertyAddress, GetPerchRadiusThreshold_FunctionAddress, "ReturnValue");
		GetPerchRadiusThreshold_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPerchRadiusThreshold_FunctionAddress, "ReturnValue");
		GetPerchRadiusThreshold_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPerchRadiusThreshold_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetPerchRadiusThreshold_IsValid = GetPerchRadiusThreshold_FunctionAddress != IntPtr.Zero && GetPerchRadiusThreshold_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:GetPerchRadiusThreshold", GetPerchRadiusThreshold_IsValid);
		GetMovementBase_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMovementBase");
		GetMovementBase_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMovementBase_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMovementBase_ReturnValue_PropertyAddress, GetMovementBase_FunctionAddress, "ReturnValue");
		GetMovementBase_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMovementBase_FunctionAddress, "ReturnValue");
		GetMovementBase_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMovementBase_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetMovementBase_IsValid = GetMovementBase_FunctionAddress != IntPtr.Zero && GetMovementBase_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:GetMovementBase", GetMovementBase_IsValid);
		GetMinAnalogSpeed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMinAnalogSpeed");
		GetMinAnalogSpeed_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMinAnalogSpeed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMinAnalogSpeed_ReturnValue_PropertyAddress, GetMinAnalogSpeed_FunctionAddress, "ReturnValue");
		GetMinAnalogSpeed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMinAnalogSpeed_FunctionAddress, "ReturnValue");
		GetMinAnalogSpeed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMinAnalogSpeed_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetMinAnalogSpeed_IsValid = GetMinAnalogSpeed_FunctionAddress != IntPtr.Zero && GetMinAnalogSpeed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:GetMinAnalogSpeed", GetMinAnalogSpeed_IsValid);
		GetMaxJumpHeightWithJumpTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMaxJumpHeightWithJumpTime");
		GetMaxJumpHeightWithJumpTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaxJumpHeightWithJumpTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaxJumpHeightWithJumpTime_ReturnValue_PropertyAddress, GetMaxJumpHeightWithJumpTime_FunctionAddress, "ReturnValue");
		GetMaxJumpHeightWithJumpTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaxJumpHeightWithJumpTime_FunctionAddress, "ReturnValue");
		GetMaxJumpHeightWithJumpTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaxJumpHeightWithJumpTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetMaxJumpHeightWithJumpTime_IsValid = GetMaxJumpHeightWithJumpTime_FunctionAddress != IntPtr.Zero && GetMaxJumpHeightWithJumpTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:GetMaxJumpHeightWithJumpTime", GetMaxJumpHeightWithJumpTime_IsValid);
		GetMaxJumpHeight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMaxJumpHeight");
		GetMaxJumpHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaxJumpHeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaxJumpHeight_ReturnValue_PropertyAddress, GetMaxJumpHeight_FunctionAddress, "ReturnValue");
		GetMaxJumpHeight_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaxJumpHeight_FunctionAddress, "ReturnValue");
		GetMaxJumpHeight_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaxJumpHeight_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetMaxJumpHeight_IsValid = GetMaxJumpHeight_FunctionAddress != IntPtr.Zero && GetMaxJumpHeight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:GetMaxJumpHeight", GetMaxJumpHeight_IsValid);
		GetMaxBrakingDeceleration_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMaxBrakingDeceleration");
		GetMaxBrakingDeceleration_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaxBrakingDeceleration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaxBrakingDeceleration_ReturnValue_PropertyAddress, GetMaxBrakingDeceleration_FunctionAddress, "ReturnValue");
		GetMaxBrakingDeceleration_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaxBrakingDeceleration_FunctionAddress, "ReturnValue");
		GetMaxBrakingDeceleration_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaxBrakingDeceleration_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetMaxBrakingDeceleration_IsValid = GetMaxBrakingDeceleration_FunctionAddress != IntPtr.Zero && GetMaxBrakingDeceleration_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:GetMaxBrakingDeceleration", GetMaxBrakingDeceleration_IsValid);
		GetMaxAcceleration_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMaxAcceleration");
		GetMaxAcceleration_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaxAcceleration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaxAcceleration_ReturnValue_PropertyAddress, GetMaxAcceleration_FunctionAddress, "ReturnValue");
		GetMaxAcceleration_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaxAcceleration_FunctionAddress, "ReturnValue");
		GetMaxAcceleration_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaxAcceleration_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetMaxAcceleration_IsValid = GetMaxAcceleration_FunctionAddress != IntPtr.Zero && GetMaxAcceleration_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:GetMaxAcceleration", GetMaxAcceleration_IsValid);
		GetLastUpdateVelocity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLastUpdateVelocity");
		GetLastUpdateVelocity_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLastUpdateVelocity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLastUpdateVelocity_ReturnValue_PropertyAddress, GetLastUpdateVelocity_FunctionAddress, "ReturnValue");
		GetLastUpdateVelocity_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLastUpdateVelocity_FunctionAddress, "ReturnValue");
		GetLastUpdateVelocity_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastUpdateVelocity_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLastUpdateVelocity_IsValid = GetLastUpdateVelocity_FunctionAddress != IntPtr.Zero && GetLastUpdateVelocity_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:GetLastUpdateVelocity", GetLastUpdateVelocity_IsValid);
		GetLastUpdateRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLastUpdateRotation");
		GetLastUpdateRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLastUpdateRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLastUpdateRotation_ReturnValue_PropertyAddress, GetLastUpdateRotation_FunctionAddress, "ReturnValue");
		GetLastUpdateRotation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLastUpdateRotation_FunctionAddress, "ReturnValue");
		GetLastUpdateRotation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastUpdateRotation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLastUpdateRotation_IsValid = GetLastUpdateRotation_FunctionAddress != IntPtr.Zero && GetLastUpdateRotation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:GetLastUpdateRotation", GetLastUpdateRotation_IsValid);
		GetLastUpdateLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLastUpdateLocation");
		GetLastUpdateLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLastUpdateLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLastUpdateLocation_ReturnValue_PropertyAddress, GetLastUpdateLocation_FunctionAddress, "ReturnValue");
		GetLastUpdateLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLastUpdateLocation_FunctionAddress, "ReturnValue");
		GetLastUpdateLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastUpdateLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLastUpdateLocation_IsValid = GetLastUpdateLocation_FunctionAddress != IntPtr.Zero && GetLastUpdateLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:GetLastUpdateLocation", GetLastUpdateLocation_IsValid);
		GetImpartedMovementBaseVelocity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetImpartedMovementBaseVelocity");
		GetImpartedMovementBaseVelocity_ParamsSize = NativeReflection.GetFunctionParamsSize(GetImpartedMovementBaseVelocity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetImpartedMovementBaseVelocity_ReturnValue_PropertyAddress, GetImpartedMovementBaseVelocity_FunctionAddress, "ReturnValue");
		GetImpartedMovementBaseVelocity_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetImpartedMovementBaseVelocity_FunctionAddress, "ReturnValue");
		GetImpartedMovementBaseVelocity_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetImpartedMovementBaseVelocity_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetImpartedMovementBaseVelocity_IsValid = GetImpartedMovementBaseVelocity_FunctionAddress != IntPtr.Zero && GetImpartedMovementBaseVelocity_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:GetImpartedMovementBaseVelocity", GetImpartedMovementBaseVelocity_IsValid);
		GetCurrentAcceleration_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCurrentAcceleration");
		GetCurrentAcceleration_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentAcceleration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentAcceleration_ReturnValue_PropertyAddress, GetCurrentAcceleration_FunctionAddress, "ReturnValue");
		GetCurrentAcceleration_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentAcceleration_FunctionAddress, "ReturnValue");
		GetCurrentAcceleration_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentAcceleration_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetCurrentAcceleration_IsValid = GetCurrentAcceleration_FunctionAddress != IntPtr.Zero && GetCurrentAcceleration_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:GetCurrentAcceleration", GetCurrentAcceleration_IsValid);
		GetCrouchedHalfHeight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCrouchedHalfHeight");
		GetCrouchedHalfHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCrouchedHalfHeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCrouchedHalfHeight_ReturnValue_PropertyAddress, GetCrouchedHalfHeight_FunctionAddress, "ReturnValue");
		GetCrouchedHalfHeight_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCrouchedHalfHeight_FunctionAddress, "ReturnValue");
		GetCrouchedHalfHeight_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCrouchedHalfHeight_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCrouchedHalfHeight_IsValid = GetCrouchedHalfHeight_FunctionAddress != IntPtr.Zero && GetCrouchedHalfHeight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:GetCrouchedHalfHeight", GetCrouchedHalfHeight_IsValid);
		GetCharacterOwner_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCharacterOwner");
		GetCharacterOwner_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCharacterOwner_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCharacterOwner_ReturnValue_PropertyAddress, GetCharacterOwner_FunctionAddress, "ReturnValue");
		GetCharacterOwner_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCharacterOwner_FunctionAddress, "ReturnValue");
		GetCharacterOwner_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCharacterOwner_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCharacterOwner_IsValid = GetCharacterOwner_FunctionAddress != IntPtr.Zero && GetCharacterOwner_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:GetCharacterOwner", GetCharacterOwner_IsValid);
		GetAnalogInputModifier_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAnalogInputModifier");
		GetAnalogInputModifier_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnalogInputModifier_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnalogInputModifier_ReturnValue_PropertyAddress, GetAnalogInputModifier_FunctionAddress, "ReturnValue");
		GetAnalogInputModifier_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnalogInputModifier_FunctionAddress, "ReturnValue");
		GetAnalogInputModifier_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnalogInputModifier_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetAnalogInputModifier_IsValid = GetAnalogInputModifier_FunctionAddress != IntPtr.Zero && GetAnalogInputModifier_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:GetAnalogInputModifier", GetAnalogInputModifier_IsValid);
		DisableMovement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DisableMovement");
		DisableMovement_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableMovement_FunctionAddress);
		DisableMovement_IsValid = DisableMovement_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:DisableMovement", DisableMovement_IsValid);
		ClearAccumulatedForces_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearAccumulatedForces");
		ClearAccumulatedForces_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearAccumulatedForces_FunctionAddress);
		ClearAccumulatedForces_IsValid = ClearAccumulatedForces_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:ClearAccumulatedForces", ClearAccumulatedForces_IsValid);
		CalcVelocity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CalcVelocity");
		CalcVelocity_ParamsSize = NativeReflection.GetFunctionParamsSize(CalcVelocity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CalcVelocity_DeltaTime_PropertyAddress, CalcVelocity_FunctionAddress, "DeltaTime");
		CalcVelocity_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(CalcVelocity_FunctionAddress, "DeltaTime");
		CalcVelocity_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcVelocity_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcVelocity_Friction_PropertyAddress, CalcVelocity_FunctionAddress, "Friction");
		CalcVelocity_Friction_Offset = NativeReflectionCached.GetPropertyOffset(CalcVelocity_FunctionAddress, "Friction");
		CalcVelocity_Friction_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcVelocity_FunctionAddress, "Friction", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcVelocity_bFluid_PropertyAddress, CalcVelocity_FunctionAddress, "bFluid");
		CalcVelocity_bFluid_Offset = NativeReflectionCached.GetPropertyOffset(CalcVelocity_FunctionAddress, "bFluid");
		CalcVelocity_bFluid_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcVelocity_FunctionAddress, "bFluid", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcVelocity_BrakingDeceleration_PropertyAddress, CalcVelocity_FunctionAddress, "BrakingDeceleration");
		CalcVelocity_BrakingDeceleration_Offset = NativeReflectionCached.GetPropertyOffset(CalcVelocity_FunctionAddress, "BrakingDeceleration");
		CalcVelocity_BrakingDeceleration_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcVelocity_FunctionAddress, "BrakingDeceleration", Classes.FFloatProperty);
		CalcVelocity_IsValid = CalcVelocity_FunctionAddress != IntPtr.Zero && CalcVelocity_DeltaTime_IsValid && CalcVelocity_Friction_IsValid && CalcVelocity_bFluid_IsValid && CalcVelocity_BrakingDeceleration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:CalcVelocity", CalcVelocity_IsValid);
		AddImpulse_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddImpulse");
		AddImpulse_ParamsSize = NativeReflection.GetFunctionParamsSize(AddImpulse_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddImpulse_Impulse_PropertyAddress, AddImpulse_FunctionAddress, "Impulse");
		AddImpulse_Impulse_Offset = NativeReflectionCached.GetPropertyOffset(AddImpulse_FunctionAddress, "Impulse");
		AddImpulse_Impulse_IsValid = NativeReflectionCached.ValidatePropertyClass(AddImpulse_FunctionAddress, "Impulse", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddImpulse_bVelocityChange_PropertyAddress, AddImpulse_FunctionAddress, "bVelocityChange");
		AddImpulse_bVelocityChange_Offset = NativeReflectionCached.GetPropertyOffset(AddImpulse_FunctionAddress, "bVelocityChange");
		AddImpulse_bVelocityChange_IsValid = NativeReflectionCached.ValidatePropertyClass(AddImpulse_FunctionAddress, "bVelocityChange", Classes.FBoolProperty);
		AddImpulse_IsValid = AddImpulse_FunctionAddress != IntPtr.Zero && AddImpulse_Impulse_IsValid && AddImpulse_bVelocityChange_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:AddImpulse", AddImpulse_IsValid);
		AddForce_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddForce");
		AddForce_ParamsSize = NativeReflection.GetFunctionParamsSize(AddForce_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddForce_Force_PropertyAddress, AddForce_FunctionAddress, "Force");
		AddForce_Force_Offset = NativeReflectionCached.GetPropertyOffset(AddForce_FunctionAddress, "Force");
		AddForce_Force_IsValid = NativeReflectionCached.ValidatePropertyClass(AddForce_FunctionAddress, "Force", Classes.FStructProperty);
		AddForce_IsValid = AddForce_FunctionAddress != IntPtr.Zero && AddForce_Force_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementComponent:AddForce", AddForce_IsValid);
	}
}
