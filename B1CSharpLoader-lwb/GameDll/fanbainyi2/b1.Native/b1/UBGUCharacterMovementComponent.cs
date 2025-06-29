using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)819986596uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGUCharacterMovementComponent", "b1", UnrealModuleType.Game)]
public class UBGUCharacterMovementComponent : UCharacterMovementComponent
{
	private static bool WalkOnDitch_IsValid;

	private static FFieldAddress WalkOnDitch_PropertyAddress;

	private static int WalkOnDitch_Offset;

	private static bool JumpOff_GravityScale_Config_IsValid;

	private static int JumpOff_GravityScale_Config_Offset;

	private static bool JumpOff_GravityScaleResetTime_IsValid;

	private static int JumpOff_GravityScaleResetTime_Offset;

	private static bool JumpOff_TestTickTime_IsValid;

	private static int JumpOff_TestTickTime_Offset;

	private static bool JumpOff_XYMaxSpeed_IsValid;

	private static int JumpOff_XYMaxSpeed_Offset;

	private static bool JumpOff_ZAddtionalVelocity_IsValid;

	private static int JumpOff_ZAddtionalVelocity_Offset;

	private static bool JumpOff_XYMaxSpeedAddtionalScale_IsValid;

	private static int JumpOff_XYMaxSpeedAddtionalScale_Offset;

	private static bool JumpOff_XYBaseCapsuelAddtionalScale_IsValid;

	private static int JumpOff_XYBaseCapsuelAddtionalScale_Offset;

	private static bool ImmediateUpdateRootMotion_IsValid;

	private static FFieldAddress ImmediateUpdateRootMotion_PropertyAddress;

	private static int ImmediateUpdateRootMotion_Offset;

	private static bool OnMovingPlatform_IsValid;

	private static FFieldAddress OnMovingPlatform_PropertyAddress;

	private static int OnMovingPlatform_Offset;

	private static bool EnableSimplifiedMove_IsValid;

	private static FFieldAddress EnableSimplifiedMove_PropertyAddress;

	private static int EnableSimplifiedMove_Offset;

	private static bool CurNavOptFloorNormal_IsValid;

	private static int CurNavOptFloorNormal_Offset;

	private static bool CurHitPoint_IsValid;

	private static int CurHitPoint_Offset;

	private static bool CanSwitchToNavWalkCD_IsValid;

	private static int CanSwitchToNavWalkCD_Offset;

	private static bool CanSwitchToNavWalkMaxCD_IsValid;

	private static int CanSwitchToNavWalkMaxCD_Offset;

	private static bool NavWalkCanStepHeight_IsValid;

	private static int NavWalkCanStepHeight_Offset;

	private static bool NavWalkFallingHight_IsValid;

	private static int NavWalkFallingHight_Offset;

	private static bool LastDesireDeltaFloorZ_IsValid;

	private static int LastDesireDeltaFloorZ_Offset;

	private static bool CapsuleRadiusRayExtraAdditiveScale_IsValid;

	private static int CapsuleRadiusRayExtraAdditiveScale_Offset;

	private static bool NavWalkOptLevel_IsValid;

	private static int NavWalkOptLevel_Offset;

	private static bool XYMoveCenterBlockTriggerRollBackCapsuleScale_IsValid;

	private static int XYMoveCenterBlockTriggerRollBackCapsuleScale_Offset;

	private static bool XYMoveSideBlockTriggerRollBackCapsuleScale_IsValid;

	private static int XYMoveSideBlockTriggerRollBackCapsuleScale_Offset;

	private static bool NavWalkOpt_MassiveOpt_IsValid;

	private static FFieldAddress NavWalkOpt_MassiveOpt_PropertyAddress;

	private static int NavWalkOpt_MassiveOpt_Offset;

	private static bool OverridePhysWalkingParam_IsValid;

	private static FFieldAddress OverridePhysWalkingParam_PropertyAddress;

	private static int OverridePhysWalkingParam_Offset;

	private static bool NavWalkCanStepAngel_IsValid;

	private static int NavWalkCanStepAngel_Offset;

	private static bool JumpOff_IsValid;

	private static FFieldAddress JumpOff_PropertyAddress;

	private static int JumpOff_Offset;

	private static bool NavWalkCanStepCapsuelHeightScale_IsValid;

	private static int NavWalkCanStepCapsuelHeightScale_Offset;

	private static bool NavWalkCapsuelStepLinTraceZOffsetFromCenter_IsValid;

	private static int NavWalkCapsuelStepLinTraceZOffsetFromCenter_Offset;

	private static bool NavWalkDebugEnable_IsValid;

	private static FFieldAddress NavWalkDebugEnable_PropertyAddress;

	private static int NavWalkDebugEnable_Offset;

	private static bool ForceOrgNavWalk_IsValid;

	private static FFieldAddress ForceOrgNavWalk_PropertyAddress;

	private static int ForceOrgNavWalk_Offset;

	private static bool EnableCheckFloor_IsValid;

	private static FFieldAddress EnableCheckFloor_PropertyAddress;

	private static int EnableCheckFloor_Offset;

	private static bool SimplePhysWalkCollisionRadius_IsValid;

	private static int SimplePhysWalkCollisionRadius_Offset;

	private static bool SimplePhysWalkStartPenetratingRollBack_IsValid;

	private static int SimplePhysWalkStartPenetratingRollBack_Offset;

	private static bool SimplePhysWalkStartPenetratingMaxRollBack_IsValid;

	private static int SimplePhysWalkStartPenetratingMaxRollBack_Offset;

	private static bool EnableSimplePhysWalkCollision_IsValid;

	private static FFieldAddress EnableSimplePhysWalkCollision_PropertyAddress;

	private static int EnableSimplePhysWalkCollision_Offset;

	private static bool RootMotionTranslationScale_IsValid;

	private static int RootMotionTranslationScale_Offset;

	private static bool MMRootMotionScale_IsValid;

	private static int MMRootMotionScale_Offset;

	private static bool OptimizeDistanceLevel1_IsValid;

	private static int OptimizeDistanceLevel1_Offset;

	private static bool FinalNavWalkOptDistanceLevel1_IsValid;

	private static int FinalNavWalkOptDistanceLevel1_Offset;

	private static bool OptimizeDistanceLevel2_IsValid;

	private static int OptimizeDistanceLevel2_Offset;

	private static bool FinalNavWalkOptDistanceLevel2_IsValid;

	private static int FinalNavWalkOptDistanceLevel2_Offset;

	private static bool CanOptimizeFromCS_IsValid;

	private static FFieldAddress CanOptimizeFromCS_PropertyAddress;

	private static int CanOptimizeFromCS_Offset;

	private static bool IsPatrolling_IsValid;

	private static FFieldAddress IsPatrolling_PropertyAddress;

	private static int IsPatrolling_Offset;

	private static bool IsInBattle_IsValid;

	private static FFieldAddress IsInBattle_PropertyAddress;

	private static int IsInBattle_Offset;

	private static bool EnableBlendAnimRootMotion_IsValid;

	private static FFieldAddress EnableBlendAnimRootMotion_PropertyAddress;

	private static int EnableBlendAnimRootMotion_Offset;

	private static bool ReplicateRootMotionMove_IsValid;

	private static FFieldAddress ReplicateRootMotionMove_PropertyAddress;

	private static int ReplicateRootMotionMove_Offset;

	private static bool DisableRootMotionFollowMode_IsValid;

	private static FFieldAddress DisableRootMotionFollowMode_PropertyAddress;

	private static int DisableRootMotionFollowMode_Offset;

	private static bool IsInFollowState_IsValid;

	private static FFieldAddress IsInFollowState_PropertyAddress;

	private static int IsInFollowState_Offset;

	private static bool FollowClampDistanceOverride_IsValid;

	private static int FollowClampDistanceOverride_Offset;

	private static bool DefaultFollowClampDistance_IsValid;

	private static int DefaultFollowClampDistance_Offset;

	private static bool EnablePrediction_IsValid;

	private static FFieldAddress EnablePrediction_PropertyAddress;

	private static int EnablePrediction_Offset;

	private static bool PredictionTime_IsValid;

	private static int PredictionTime_Offset;

	private static bool PredictionPointNum_IsValid;

	private static int PredictionPointNum_Offset;

	private static bool HitMoveWeight_IsValid;

	private static int HitMoveWeight_Offset;

	private static bool HitMoveIsEnabled_IsValid;

	private static FFieldAddress HitMoveIsEnabled_PropertyAddress;

	private static int HitMoveIsEnabled_Offset;

	private static bool HitMoveIsUnmovable_IsValid;

	private static FFieldAddress HitMoveIsUnmovable_PropertyAddress;

	private static int HitMoveIsUnmovable_Offset;

	private static bool HitMoveCanUpdate_IsValid;

	private static FFieldAddress HitMoveCanUpdate_PropertyAddress;

	private static int HitMoveCanUpdate_Offset;

	private static bool MoveStartHistoryZDeltaNum_NavWalkOpt_IsValid;

	private static int MoveStartHistoryZDeltaNum_NavWalkOpt_Offset;

	private static bool MoveEndHistoryZDeltaNum_NavWalkOpt_IsValid;

	private static int MoveEndHistoryZDeltaNum_NavWalkOpt_Offset;

	private static bool ZDeltaThrehold_NavWalkOpt_IsValid;

	private static int ZDeltaThrehold_NavWalkOpt_Offset;

	private static bool FloorZSlopeDeltaThrehold_Anisotropy_IsValid;

	private static int FloorZSlopeDeltaThrehold_Anisotropy_Offset;

	private static bool FloorZSlopeDeltaThrehold_Syntropy_IsValid;

	private static int FloorZSlopeDeltaThrehold_Syntropy_Offset;

	private static bool CurFloorZAdditionalWeight_IsValid;

	private static int CurFloorZAdditionalWeight_Offset;

	private static bool FloorZTraceStartScaleShrink_IsValid;

	private static int FloorZTraceStartScaleShrink_Offset;

	private static bool FloorTestCapsuleRadiusScale_IsValid;

	private static int FloorTestCapsuleRadiusScale_Offset;

	private static bool DitchFallDeltaMoveForTest_IsValid;

	private static int DitchFallDeltaMoveForTest_Offset;

	private static bool DebugLength_IsValid;

	private static int DebugLength_Offset;

	private static bool DebugSingleStep_IsValid;

	private static int DebugSingleStep_Offset;

	private static bool DebugZOffset_IsValid;

	private static int DebugZOffset_Offset;

	private static bool TryGetCurSurfaceTypeFromMovement_IsValid;

	private static IntPtr TryGetCurSurfaceTypeFromMovement_FunctionAddress;

	private static int TryGetCurSurfaceTypeFromMovement_ParamsSize;

	private static bool TryGetCurSurfaceTypeFromMovement_ReturnValue_IsValid;

	private static FFieldAddress TryGetCurSurfaceTypeFromMovement_ReturnValue_PropertyAddress;

	private static int TryGetCurSurfaceTypeFromMovement_ReturnValue_Offset;

	private static bool TryGetCurNormalFromMovement_IsValid;

	private static IntPtr TryGetCurNormalFromMovement_FunctionAddress;

	private static int TryGetCurNormalFromMovement_ParamsSize;

	private static bool TryGetCurNormalFromMovement_ReturnValue_IsValid;

	private static FFieldAddress TryGetCurNormalFromMovement_ReturnValue_PropertyAddress;

	private static int TryGetCurNormalFromMovement_ReturnValue_Offset;

	private static bool TryGetCurHitPointFromMovement_IsValid;

	private static IntPtr TryGetCurHitPointFromMovement_FunctionAddress;

	private static int TryGetCurHitPointFromMovement_ParamsSize;

	private static bool TryGetCurHitPointFromMovement_ReturnValue_IsValid;

	private static FFieldAddress TryGetCurHitPointFromMovement_ReturnValue_PropertyAddress;

	private static int TryGetCurHitPointFromMovement_ReturnValue_Offset;

	private static bool SetWalkOnDitch_IsValid;

	private static IntPtr SetWalkOnDitch_FunctionAddress;

	private static int SetWalkOnDitch_ParamsSize;

	private static bool SetWalkOnDitch_bDitch_IsValid;

	private static FFieldAddress SetWalkOnDitch_bDitch_PropertyAddress;

	private static int SetWalkOnDitch_bDitch_Offset;

	private static bool SetUseSeparateBrakingFriction_IsValid;

	private static IntPtr SetUseSeparateBrakingFriction_FunctionAddress;

	private static int SetUseSeparateBrakingFriction_ParamsSize;

	private static bool SetUseSeparateBrakingFriction_bUse_IsValid;

	private static FFieldAddress SetUseSeparateBrakingFriction_bUse_PropertyAddress;

	private static int SetUseSeparateBrakingFriction_bUse_Offset;

	private static bool SetSwitchToNavWalkCumulateTime_IsValid;

	private static IntPtr SetSwitchToNavWalkCumulateTime_FunctionAddress;

	private static int SetSwitchToNavWalkCumulateTime_ParamsSize;

	private static bool SetSwitchToNavWalkCumulateTime_Time_IsValid;

	private static FFieldAddress SetSwitchToNavWalkCumulateTime_Time_PropertyAddress;

	private static int SetSwitchToNavWalkCumulateTime_Time_Offset;

	private static bool SetOnMovingPlatform_IsValid;

	private static IntPtr SetOnMovingPlatform_FunctionAddress;

	private static int SetOnMovingPlatform_ParamsSize;

	private static bool SetOnMovingPlatform_bIsOnMovingPlatform_IsValid;

	private static FFieldAddress SetOnMovingPlatform_bIsOnMovingPlatform_PropertyAddress;

	private static int SetOnMovingPlatform_bIsOnMovingPlatform_Offset;

	private static bool SetNavWalkOptMassiveMode_IsValid;

	private static IntPtr SetNavWalkOptMassiveMode_FunctionAddress;

	private static int SetNavWalkOptMassiveMode_ParamsSize;

	private static bool SetNavWalkOptMassiveMode_bMassiveOpt_IsValid;

	private static FFieldAddress SetNavWalkOptMassiveMode_bMassiveOpt_PropertyAddress;

	private static int SetNavWalkOptMassiveMode_bMassiveOpt_Offset;

	private static bool SetNavWalkOptLevel_IsValid;

	private static IntPtr SetNavWalkOptLevel_FunctionAddress;

	private static int SetNavWalkOptLevel_ParamsSize;

	private static bool SetNavWalkOptLevel_NewLevel_IsValid;

	private static FFieldAddress SetNavWalkOptLevel_NewLevel_PropertyAddress;

	private static int SetNavWalkOptLevel_NewLevel_Offset;

	private static bool SetJumpOffState_IsValid;

	private static IntPtr SetJumpOffState_FunctionAddress;

	private static int SetJumpOffState_ParamsSize;

	private static bool SetJumpOffState_JumpOff_IsValid;

	private static FFieldAddress SetJumpOffState_JumpOff_PropertyAddress;

	private static int SetJumpOffState_JumpOff_Offset;

	private static bool SetHitMoveIgnoredActor_IsValid;

	private static IntPtr SetHitMoveIgnoredActor_FunctionAddress;

	private static int SetHitMoveIgnoredActor_ParamsSize;

	private static bool SetHitMoveIgnoredActor_Actor_IsValid;

	private static FFieldAddress SetHitMoveIgnoredActor_Actor_PropertyAddress;

	private static int SetHitMoveIgnoredActor_Actor_Offset;

	private static bool SetHitMoveIgnoredActor_RemoveIgnoredActor_IsValid;

	private static FFieldAddress SetHitMoveIgnoredActor_RemoveIgnoredActor_PropertyAddress;

	private static int SetHitMoveIgnoredActor_RemoveIgnoredActor_Offset;

	private static bool SetHitMoveCollisionEnabled_IsValid;

	private static IntPtr SetHitMoveCollisionEnabled_FunctionAddress;

	private static int SetHitMoveCollisionEnabled_ParamsSize;

	private static bool SetHitMoveCollisionEnabled_ShapeComp_IsValid;

	private static FFieldAddress SetHitMoveCollisionEnabled_ShapeComp_PropertyAddress;

	private static int SetHitMoveCollisionEnabled_ShapeComp_Offset;

	private static bool SetHitMoveCollisionEnabled_IsEnabled_IsValid;

	private static FFieldAddress SetHitMoveCollisionEnabled_IsEnabled_PropertyAddress;

	private static int SetHitMoveCollisionEnabled_IsEnabled_Offset;

	private static bool SetHitMoveCollisionDirection_IsValid;

	private static IntPtr SetHitMoveCollisionDirection_FunctionAddress;

	private static int SetHitMoveCollisionDirection_ParamsSize;

	private static bool SetHitMoveCollisionDirection_ShapeComp_IsValid;

	private static FFieldAddress SetHitMoveCollisionDirection_ShapeComp_PropertyAddress;

	private static int SetHitMoveCollisionDirection_ShapeComp_Offset;

	private static bool SetHitMoveCollisionDirection_HitMoveDir_IsValid;

	private static FFieldAddress SetHitMoveCollisionDirection_HitMoveDir_PropertyAddress;

	private static int SetHitMoveCollisionDirection_HitMoveDir_Offset;

	private static bool SetGravityToJumpOffGravity_IsValid;

	private static IntPtr SetGravityToJumpOffGravity_FunctionAddress;

	private static int SetGravityToJumpOffGravity_ParamsSize;

	private static bool SetEnableSimplePhysWalkCollision_IsValid;

	private static IntPtr SetEnableSimplePhysWalkCollision_FunctionAddress;

	private static int SetEnableSimplePhysWalkCollision_ParamsSize;

	private static bool SetEnableSimplePhysWalkCollision_bEnable_IsValid;

	private static FFieldAddress SetEnableSimplePhysWalkCollision_bEnable_PropertyAddress;

	private static int SetEnableSimplePhysWalkCollision_bEnable_Offset;

	private static bool SetDisableNavWalkOptByWhiteList_IsValid;

	private static IntPtr SetDisableNavWalkOptByWhiteList_FunctionAddress;

	private static int SetDisableNavWalkOptByWhiteList_ParamsSize;

	private static bool SetDisableNavWalkOptByWhiteList_bDisable_IsValid;

	private static FFieldAddress SetDisableNavWalkOptByWhiteList_bDisable_PropertyAddress;

	private static int SetDisableNavWalkOptByWhiteList_bDisable_Offset;

	private static bool SetCustomJumpVelocityIncrement_IsValid;

	private static IntPtr SetCustomJumpVelocityIncrement_FunctionAddress;

	private static int SetCustomJumpVelocityIncrement_ParamsSize;

	private static bool SetCustomJumpVelocityIncrement_VelocityIncrement_IsValid;

	private static FFieldAddress SetCustomJumpVelocityIncrement_VelocityIncrement_PropertyAddress;

	private static int SetCustomJumpVelocityIncrement_VelocityIncrement_Offset;

	private static bool ResetGravityToNormalGravity_IsValid;

	private static IntPtr ResetGravityToNormalGravity_FunctionAddress;

	private static int ResetGravityToNormalGravity_ParamsSize;

	private static bool MoveUpdateHitMove_IsValid;

	private static IntPtr MoveUpdateHitMove_FunctionAddress;

	private static int MoveUpdateHitMove_ParamsSize;

	private static bool MoveUpdateHitMove_Delta_IsValid;

	private static FFieldAddress MoveUpdateHitMove_Delta_PropertyAddress;

	private static int MoveUpdateHitMove_Delta_Offset;

	private static bool LaunchVelocityZ_IsValid;

	private static IntPtr LaunchVelocityZ_FunctionAddress;

	private static int LaunchVelocityZ_ParamsSize;

	private static bool LaunchVelocityZ_VelocityZ_IsValid;

	private static FFieldAddress LaunchVelocityZ_VelocityZ_PropertyAddress;

	private static int LaunchVelocityZ_VelocityZ_Offset;

	private static bool IsWalkOnDitch_IsValid;

	private static IntPtr IsWalkOnDitch_FunctionAddress;

	private static int IsWalkOnDitch_ParamsSize;

	private static bool IsWalkOnDitch_ReturnValue_IsValid;

	private static FFieldAddress IsWalkOnDitch_ReturnValue_PropertyAddress;

	private static int IsWalkOnDitch_ReturnValue_Offset;

	private static bool IsUseSeparateBrakingFriction_IsValid;

	private static IntPtr IsUseSeparateBrakingFriction_FunctionAddress;

	private static int IsUseSeparateBrakingFriction_ParamsSize;

	private static bool IsUseSeparateBrakingFriction_ReturnValue_IsValid;

	private static FFieldAddress IsUseSeparateBrakingFriction_ReturnValue_PropertyAddress;

	private static int IsUseSeparateBrakingFriction_ReturnValue_Offset;

	private static bool IsInNavWalkOptMode_IsValid;

	private static IntPtr IsInNavWalkOptMode_FunctionAddress;

	private static int IsInNavWalkOptMode_ParamsSize;

	private static bool IsInNavWalkOptMode_ReturnValue_IsValid;

	private static FFieldAddress IsInNavWalkOptMode_ReturnValue_PropertyAddress;

	private static int IsInNavWalkOptMode_ReturnValue_Offset;

	private static bool IsInJumpOffAdjust_IsValid;

	private static IntPtr IsInJumpOffAdjust_FunctionAddress;

	private static int IsInJumpOffAdjust_ParamsSize;

	private static bool IsInJumpOffAdjust_ReturnValue_IsValid;

	private static FFieldAddress IsInJumpOffAdjust_ReturnValue_PropertyAddress;

	private static int IsInJumpOffAdjust_ReturnValue_Offset;

	private static bool HitMoveUpdate_IsValid;

	private static IntPtr HitMoveUpdate_FunctionAddress;

	private static int HitMoveUpdate_ParamsSize;

	private static bool HasAnimRootMotion_CS_IsValid;

	private static IntPtr HasAnimRootMotion_CS_FunctionAddress;

	private static int HasAnimRootMotion_CS_ParamsSize;

	private static bool HasAnimRootMotion_CS_ReturnValue_IsValid;

	private static FFieldAddress HasAnimRootMotion_CS_ReturnValue_PropertyAddress;

	private static int HasAnimRootMotion_CS_ReturnValue_Offset;

	private static bool GetTopZInFalling_IsValid;

	private static IntPtr GetTopZInFalling_FunctionAddress;

	private static int GetTopZInFalling_ParamsSize;

	private static bool GetTopZInFalling_ReturnValue_IsValid;

	private static FFieldAddress GetTopZInFalling_ReturnValue_PropertyAddress;

	private static int GetTopZInFalling_ReturnValue_Offset;

	private static bool GetHitMoveCollisionIsEnabled_IsValid;

	private static IntPtr GetHitMoveCollisionIsEnabled_FunctionAddress;

	private static int GetHitMoveCollisionIsEnabled_ParamsSize;

	private static bool GetHitMoveCollisionIsEnabled_ShapeComp_IsValid;

	private static FFieldAddress GetHitMoveCollisionIsEnabled_ShapeComp_PropertyAddress;

	private static int GetHitMoveCollisionIsEnabled_ShapeComp_Offset;

	private static bool GetHitMoveCollisionIsEnabled_IsEnabled_IsValid;

	private static FFieldAddress GetHitMoveCollisionIsEnabled_IsEnabled_PropertyAddress;

	private static int GetHitMoveCollisionIsEnabled_IsEnabled_Offset;

	private static bool GetHitMoveCollisionIsEnabled_ReturnValue_IsValid;

	private static FFieldAddress GetHitMoveCollisionIsEnabled_ReturnValue_PropertyAddress;

	private static int GetHitMoveCollisionIsEnabled_ReturnValue_Offset;

	private static bool CustomJumpMoveBreak_IsValid;

	private static IntPtr CustomJumpMoveBreak_FunctionAddress;

	private static int CustomJumpMoveBreak_ParamsSize;

	private static bool ClearTopZInFalling_IsValid;

	private static IntPtr ClearTopZInFalling_FunctionAddress;

	private static int ClearTopZInFalling_ParamsSize;

	private static bool ClearHitMoveCollisions_IsValid;

	private static IntPtr ClearHitMoveCollisions_FunctionAddress;

	private static int ClearHitMoveCollisions_ParamsSize;

	private static bool CanGetNormalAndSurfaceTypeInfoFromMovement_IsValid;

	private static IntPtr CanGetNormalAndSurfaceTypeInfoFromMovement_FunctionAddress;

	private static int CanGetNormalAndSurfaceTypeInfoFromMovement_ParamsSize;

	private static bool CanGetNormalAndSurfaceTypeInfoFromMovement_ReturnValue_IsValid;

	private static FFieldAddress CanGetNormalAndSurfaceTypeInfoFromMovement_ReturnValue_PropertyAddress;

	private static int CanGetNormalAndSurfaceTypeInfoFromMovement_ReturnValue_Offset;

	private static bool AddOrModifyHitMoveCollision_IsValid;

	private static IntPtr AddOrModifyHitMoveCollision_FunctionAddress;

	private static int AddOrModifyHitMoveCollision_ParamsSize;

	private static bool AddOrModifyHitMoveCollision_ShapeComp_IsValid;

	private static FFieldAddress AddOrModifyHitMoveCollision_ShapeComp_PropertyAddress;

	private static int AddOrModifyHitMoveCollision_ShapeComp_Offset;

	private static bool AddOrModifyHitMoveCollision_HitMoveDir_IsValid;

	private static FFieldAddress AddOrModifyHitMoveCollision_HitMoveDir_PropertyAddress;

	private static int AddOrModifyHitMoveCollision_HitMoveDir_Offset;

	private static bool AddOrModifyHitMoveCollision_IsEnabled_IsValid;

	private static FFieldAddress AddOrModifyHitMoveCollision_IsEnabled_PropertyAddress;

	private static int AddOrModifyHitMoveCollision_IsEnabled_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:bWalkOnDitch")]
	public bool WalkOnDitch
	{
		get
		{
			CheckDestroyed();
			if (!WalkOnDitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bWalkOnDitch");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, WalkOnDitch_Offset), 0, WalkOnDitch_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WalkOnDitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bWalkOnDitch");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, WalkOnDitch_Offset), 0, WalkOnDitch_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:JumpOff_GravityScale_Config")]
	public float JumpOff_GravityScale_Config
	{
		get
		{
			CheckDestroyed();
			if (!JumpOff_GravityScale_Config_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:JumpOff_GravityScale_Config");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, JumpOff_GravityScale_Config_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpOff_GravityScale_Config_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:JumpOff_GravityScale_Config");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, JumpOff_GravityScale_Config_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:JumpOff_GravityScaleResetTime")]
	public float JumpOff_GravityScaleResetTime
	{
		get
		{
			CheckDestroyed();
			if (!JumpOff_GravityScaleResetTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:JumpOff_GravityScaleResetTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, JumpOff_GravityScaleResetTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpOff_GravityScaleResetTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:JumpOff_GravityScaleResetTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, JumpOff_GravityScaleResetTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:JumpOff_TestTickTime")]
	public float JumpOff_TestTickTime
	{
		get
		{
			CheckDestroyed();
			if (!JumpOff_TestTickTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:JumpOff_TestTickTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, JumpOff_TestTickTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpOff_TestTickTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:JumpOff_TestTickTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, JumpOff_TestTickTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:JumpOff_XYMaxSpeed")]
	public float JumpOff_XYMaxSpeed
	{
		get
		{
			CheckDestroyed();
			if (!JumpOff_XYMaxSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:JumpOff_XYMaxSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, JumpOff_XYMaxSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpOff_XYMaxSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:JumpOff_XYMaxSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, JumpOff_XYMaxSpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:JumpOff_ZAddtionalVelocity")]
	public float JumpOff_ZAddtionalVelocity
	{
		get
		{
			CheckDestroyed();
			if (!JumpOff_ZAddtionalVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:JumpOff_ZAddtionalVelocity");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, JumpOff_ZAddtionalVelocity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpOff_ZAddtionalVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:JumpOff_ZAddtionalVelocity");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, JumpOff_ZAddtionalVelocity_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:JumpOff_XYMaxSpeedAddtionalScale")]
	public float JumpOff_XYMaxSpeedAddtionalScale
	{
		get
		{
			CheckDestroyed();
			if (!JumpOff_XYMaxSpeedAddtionalScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:JumpOff_XYMaxSpeedAddtionalScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, JumpOff_XYMaxSpeedAddtionalScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpOff_XYMaxSpeedAddtionalScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:JumpOff_XYMaxSpeedAddtionalScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, JumpOff_XYMaxSpeedAddtionalScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:JumpOff_XYBaseCapsuelAddtionalScale")]
	public float JumpOff_XYBaseCapsuelAddtionalScale
	{
		get
		{
			CheckDestroyed();
			if (!JumpOff_XYBaseCapsuelAddtionalScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:JumpOff_XYBaseCapsuelAddtionalScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, JumpOff_XYBaseCapsuelAddtionalScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpOff_XYBaseCapsuelAddtionalScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:JumpOff_XYBaseCapsuelAddtionalScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, JumpOff_XYBaseCapsuelAddtionalScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:bImmediateUpdateRootMotion")]
	public bool ImmediateUpdateRootMotion
	{
		get
		{
			CheckDestroyed();
			if (!ImmediateUpdateRootMotion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bImmediateUpdateRootMotion");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ImmediateUpdateRootMotion_Offset), 0, ImmediateUpdateRootMotion_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ImmediateUpdateRootMotion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bImmediateUpdateRootMotion");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ImmediateUpdateRootMotion_Offset), 0, ImmediateUpdateRootMotion_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:bOnMovingPlatform")]
	public bool OnMovingPlatform
	{
		get
		{
			CheckDestroyed();
			if (!OnMovingPlatform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bOnMovingPlatform");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OnMovingPlatform_Offset), 0, OnMovingPlatform_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OnMovingPlatform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bOnMovingPlatform");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OnMovingPlatform_Offset), 0, OnMovingPlatform_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:bEnableSimplifiedMove")]
	public bool EnableSimplifiedMove
	{
		get
		{
			CheckDestroyed();
			if (!EnableSimplifiedMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bEnableSimplifiedMove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableSimplifiedMove_Offset), 0, EnableSimplifiedMove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableSimplifiedMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bEnableSimplifiedMove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableSimplifiedMove_Offset), 0, EnableSimplifiedMove_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283013uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:CurNavOptFloorNormal")]
	public FVector CurNavOptFloorNormal
	{
		get
		{
			CheckDestroyed();
			if (!CurNavOptFloorNormal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:CurNavOptFloorNormal");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, CurNavOptFloorNormal_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurNavOptFloorNormal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:CurNavOptFloorNormal");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, CurNavOptFloorNormal_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283013uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:CurHitPoint")]
	public FVector CurHitPoint
	{
		get
		{
			CheckDestroyed();
			if (!CurHitPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:CurHitPoint");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, CurHitPoint_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurHitPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:CurHitPoint");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, CurHitPoint_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:CanSwitchToNavWalkCD")]
	public int CanSwitchToNavWalkCD
	{
		get
		{
			CheckDestroyed();
			if (!CanSwitchToNavWalkCD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:CanSwitchToNavWalkCD");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CanSwitchToNavWalkCD_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CanSwitchToNavWalkCD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:CanSwitchToNavWalkCD");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CanSwitchToNavWalkCD_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:CanSwitchToNavWalkMaxCD")]
	public int CanSwitchToNavWalkMaxCD
	{
		get
		{
			CheckDestroyed();
			if (!CanSwitchToNavWalkMaxCD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:CanSwitchToNavWalkMaxCD");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CanSwitchToNavWalkMaxCD_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CanSwitchToNavWalkMaxCD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:CanSwitchToNavWalkMaxCD");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CanSwitchToNavWalkMaxCD_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:NavWalkCanStepHeight")]
	public float NavWalkCanStepHeight
	{
		get
		{
			CheckDestroyed();
			if (!NavWalkCanStepHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:NavWalkCanStepHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NavWalkCanStepHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NavWalkCanStepHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:NavWalkCanStepHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NavWalkCanStepHeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:NavWalkFallingHight")]
	public float NavWalkFallingHight
	{
		get
		{
			CheckDestroyed();
			if (!NavWalkFallingHight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:NavWalkFallingHight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NavWalkFallingHight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NavWalkFallingHight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:NavWalkFallingHight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NavWalkFallingHight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283013uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:LastDesireDeltaFloorZ")]
	public float LastDesireDeltaFloorZ
	{
		get
		{
			CheckDestroyed();
			if (!LastDesireDeltaFloorZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:LastDesireDeltaFloorZ");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LastDesireDeltaFloorZ_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LastDesireDeltaFloorZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:LastDesireDeltaFloorZ");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LastDesireDeltaFloorZ_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:CapsuleRadiusRayExtraAdditiveScale")]
	public float CapsuleRadiusRayExtraAdditiveScale
	{
		get
		{
			CheckDestroyed();
			if (!CapsuleRadiusRayExtraAdditiveScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:CapsuleRadiusRayExtraAdditiveScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CapsuleRadiusRayExtraAdditiveScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapsuleRadiusRayExtraAdditiveScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:CapsuleRadiusRayExtraAdditiveScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CapsuleRadiusRayExtraAdditiveScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283013uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:NavWalkOptLevel")]
	public int NavWalkOptLevel
	{
		get
		{
			CheckDestroyed();
			if (!NavWalkOptLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:NavWalkOptLevel");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NavWalkOptLevel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NavWalkOptLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:NavWalkOptLevel");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NavWalkOptLevel_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:XYMoveCenterBlockTriggerRollBackCapsuleScale")]
	public float XYMoveCenterBlockTriggerRollBackCapsuleScale
	{
		get
		{
			CheckDestroyed();
			if (!XYMoveCenterBlockTriggerRollBackCapsuleScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:XYMoveCenterBlockTriggerRollBackCapsuleScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, XYMoveCenterBlockTriggerRollBackCapsuleScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!XYMoveCenterBlockTriggerRollBackCapsuleScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:XYMoveCenterBlockTriggerRollBackCapsuleScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, XYMoveCenterBlockTriggerRollBackCapsuleScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:XYMoveSideBlockTriggerRollBackCapsuleScale")]
	public float XYMoveSideBlockTriggerRollBackCapsuleScale
	{
		get
		{
			CheckDestroyed();
			if (!XYMoveSideBlockTriggerRollBackCapsuleScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:XYMoveSideBlockTriggerRollBackCapsuleScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, XYMoveSideBlockTriggerRollBackCapsuleScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!XYMoveSideBlockTriggerRollBackCapsuleScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:XYMoveSideBlockTriggerRollBackCapsuleScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, XYMoveSideBlockTriggerRollBackCapsuleScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:bNavWalkOpt_MassiveOpt")]
	public bool NavWalkOpt_MassiveOpt
	{
		get
		{
			CheckDestroyed();
			if (!NavWalkOpt_MassiveOpt_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bNavWalkOpt_MassiveOpt");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NavWalkOpt_MassiveOpt_Offset), 0, NavWalkOpt_MassiveOpt_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NavWalkOpt_MassiveOpt_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bNavWalkOpt_MassiveOpt");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NavWalkOpt_MassiveOpt_Offset), 0, NavWalkOpt_MassiveOpt_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:bOverridePhysWalkingParam")]
	public bool OverridePhysWalkingParam
	{
		get
		{
			CheckDestroyed();
			if (!OverridePhysWalkingParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bOverridePhysWalkingParam");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverridePhysWalkingParam_Offset), 0, OverridePhysWalkingParam_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverridePhysWalkingParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bOverridePhysWalkingParam");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverridePhysWalkingParam_Offset), 0, OverridePhysWalkingParam_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:NavWalkCanStepAngel")]
	public float NavWalkCanStepAngel
	{
		get
		{
			CheckDestroyed();
			if (!NavWalkCanStepAngel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:NavWalkCanStepAngel");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NavWalkCanStepAngel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NavWalkCanStepAngel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:NavWalkCanStepAngel");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NavWalkCanStepAngel_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:bJumpOff")]
	public bool JumpOff
	{
		get
		{
			CheckDestroyed();
			if (!JumpOff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bJumpOff");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, JumpOff_Offset), 0, JumpOff_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!JumpOff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bJumpOff");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, JumpOff_Offset), 0, JumpOff_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:NavWalkCanStepCapsuelHeightScale")]
	public float NavWalkCanStepCapsuelHeightScale
	{
		get
		{
			CheckDestroyed();
			if (!NavWalkCanStepCapsuelHeightScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:NavWalkCanStepCapsuelHeightScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NavWalkCanStepCapsuelHeightScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NavWalkCanStepCapsuelHeightScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:NavWalkCanStepCapsuelHeightScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NavWalkCanStepCapsuelHeightScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:NavWalkCapsuelStepLinTraceZOffsetFromCenter")]
	public float NavWalkCapsuelStepLinTraceZOffsetFromCenter
	{
		get
		{
			CheckDestroyed();
			if (!NavWalkCapsuelStepLinTraceZOffsetFromCenter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:NavWalkCapsuelStepLinTraceZOffsetFromCenter");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NavWalkCapsuelStepLinTraceZOffsetFromCenter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NavWalkCapsuelStepLinTraceZOffsetFromCenter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:NavWalkCapsuelStepLinTraceZOffsetFromCenter");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NavWalkCapsuelStepLinTraceZOffsetFromCenter_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:bNavWalkDebugEnable")]
	public bool NavWalkDebugEnable
	{
		get
		{
			CheckDestroyed();
			if (!NavWalkDebugEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bNavWalkDebugEnable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NavWalkDebugEnable_Offset), 0, NavWalkDebugEnable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NavWalkDebugEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bNavWalkDebugEnable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NavWalkDebugEnable_Offset), 0, NavWalkDebugEnable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:bForceOrgNavWalk")]
	public bool ForceOrgNavWalk
	{
		get
		{
			CheckDestroyed();
			if (!ForceOrgNavWalk_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bForceOrgNavWalk");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForceOrgNavWalk_Offset), 0, ForceOrgNavWalk_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceOrgNavWalk_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bForceOrgNavWalk");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForceOrgNavWalk_Offset), 0, ForceOrgNavWalk_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:bEnableCheckFloor")]
	public bool EnableCheckFloor
	{
		get
		{
			CheckDestroyed();
			if (!EnableCheckFloor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bEnableCheckFloor");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableCheckFloor_Offset), 0, EnableCheckFloor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableCheckFloor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bEnableCheckFloor");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableCheckFloor_Offset), 0, EnableCheckFloor_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:SimplePhysWalkCollisionRadius")]
	public float SimplePhysWalkCollisionRadius
	{
		get
		{
			CheckDestroyed();
			if (!SimplePhysWalkCollisionRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:SimplePhysWalkCollisionRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SimplePhysWalkCollisionRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SimplePhysWalkCollisionRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:SimplePhysWalkCollisionRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SimplePhysWalkCollisionRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:SimplePhysWalkStartPenetratingRollBack")]
	public float SimplePhysWalkStartPenetratingRollBack
	{
		get
		{
			CheckDestroyed();
			if (!SimplePhysWalkStartPenetratingRollBack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:SimplePhysWalkStartPenetratingRollBack");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SimplePhysWalkStartPenetratingRollBack_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SimplePhysWalkStartPenetratingRollBack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:SimplePhysWalkStartPenetratingRollBack");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SimplePhysWalkStartPenetratingRollBack_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:SimplePhysWalkStartPenetratingMaxRollBack")]
	public float SimplePhysWalkStartPenetratingMaxRollBack
	{
		get
		{
			CheckDestroyed();
			if (!SimplePhysWalkStartPenetratingMaxRollBack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:SimplePhysWalkStartPenetratingMaxRollBack");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SimplePhysWalkStartPenetratingMaxRollBack_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SimplePhysWalkStartPenetratingMaxRollBack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:SimplePhysWalkStartPenetratingMaxRollBack");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SimplePhysWalkStartPenetratingMaxRollBack_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:bEnableSimplePhysWalkCollision")]
	public bool EnableSimplePhysWalkCollision
	{
		get
		{
			CheckDestroyed();
			if (!EnableSimplePhysWalkCollision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bEnableSimplePhysWalkCollision");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableSimplePhysWalkCollision_Offset), 0, EnableSimplePhysWalkCollision_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableSimplePhysWalkCollision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bEnableSimplePhysWalkCollision");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableSimplePhysWalkCollision_Offset), 0, EnableSimplePhysWalkCollision_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:RootMotionTranslationScale")]
	public FVector RootMotionTranslationScale
	{
		get
		{
			CheckDestroyed();
			if (!RootMotionTranslationScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:RootMotionTranslationScale");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, RootMotionTranslationScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RootMotionTranslationScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:RootMotionTranslationScale");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, RootMotionTranslationScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:MMRootMotionScale")]
	public FVector MMRootMotionScale
	{
		get
		{
			CheckDestroyed();
			if (!MMRootMotionScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:MMRootMotionScale");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, MMRootMotionScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MMRootMotionScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:MMRootMotionScale");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, MMRootMotionScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:OptimizeDistanceLevel1")]
	public float OptimizeDistanceLevel1
	{
		get
		{
			CheckDestroyed();
			if (!OptimizeDistanceLevel1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:OptimizeDistanceLevel1");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OptimizeDistanceLevel1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OptimizeDistanceLevel1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:OptimizeDistanceLevel1");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OptimizeDistanceLevel1_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:FinalNavWalkOptDistanceLevel1")]
	public float FinalNavWalkOptDistanceLevel1
	{
		get
		{
			CheckDestroyed();
			if (!FinalNavWalkOptDistanceLevel1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:FinalNavWalkOptDistanceLevel1");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FinalNavWalkOptDistanceLevel1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FinalNavWalkOptDistanceLevel1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:FinalNavWalkOptDistanceLevel1");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FinalNavWalkOptDistanceLevel1_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:OptimizeDistanceLevel2")]
	public float OptimizeDistanceLevel2
	{
		get
		{
			CheckDestroyed();
			if (!OptimizeDistanceLevel2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:OptimizeDistanceLevel2");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OptimizeDistanceLevel2_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OptimizeDistanceLevel2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:OptimizeDistanceLevel2");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OptimizeDistanceLevel2_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:FinalNavWalkOptDistanceLevel2")]
	public float FinalNavWalkOptDistanceLevel2
	{
		get
		{
			CheckDestroyed();
			if (!FinalNavWalkOptDistanceLevel2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:FinalNavWalkOptDistanceLevel2");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FinalNavWalkOptDistanceLevel2_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FinalNavWalkOptDistanceLevel2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:FinalNavWalkOptDistanceLevel2");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FinalNavWalkOptDistanceLevel2_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:bCanOptimizeFromCS")]
	public bool CanOptimizeFromCS
	{
		get
		{
			CheckDestroyed();
			if (!CanOptimizeFromCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bCanOptimizeFromCS");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CanOptimizeFromCS_Offset), 0, CanOptimizeFromCS_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CanOptimizeFromCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bCanOptimizeFromCS");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CanOptimizeFromCS_Offset), 0, CanOptimizeFromCS_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:bIsPatrolling")]
	public bool IsPatrolling
	{
		get
		{
			CheckDestroyed();
			if (!IsPatrolling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bIsPatrolling");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsPatrolling_Offset), 0, IsPatrolling_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsPatrolling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bIsPatrolling");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsPatrolling_Offset), 0, IsPatrolling_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:bIsInBattle")]
	public bool IsInBattle
	{
		get
		{
			CheckDestroyed();
			if (!IsInBattle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bIsInBattle");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsInBattle_Offset), 0, IsInBattle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsInBattle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bIsInBattle");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsInBattle_Offset), 0, IsInBattle_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:bEnableBlendAnimRootMotion")]
	public bool EnableBlendAnimRootMotion
	{
		get
		{
			CheckDestroyed();
			if (!EnableBlendAnimRootMotion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bEnableBlendAnimRootMotion");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableBlendAnimRootMotion_Offset), 0, EnableBlendAnimRootMotion_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableBlendAnimRootMotion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bEnableBlendAnimRootMotion");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableBlendAnimRootMotion_Offset), 0, EnableBlendAnimRootMotion_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:bReplicateRootMotionMove")]
	public bool ReplicateRootMotionMove
	{
		get
		{
			CheckDestroyed();
			if (!ReplicateRootMotionMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bReplicateRootMotionMove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ReplicateRootMotionMove_Offset), 0, ReplicateRootMotionMove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ReplicateRootMotionMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bReplicateRootMotionMove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ReplicateRootMotionMove_Offset), 0, ReplicateRootMotionMove_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:bDisableRootMotionFollowMode")]
	public bool DisableRootMotionFollowMode
	{
		get
		{
			CheckDestroyed();
			if (!DisableRootMotionFollowMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bDisableRootMotionFollowMode");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisableRootMotionFollowMode_Offset), 0, DisableRootMotionFollowMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisableRootMotionFollowMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bDisableRootMotionFollowMode");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisableRootMotionFollowMode_Offset), 0, DisableRootMotionFollowMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:bIsInFollowState")]
	public bool IsInFollowState
	{
		get
		{
			CheckDestroyed();
			if (!IsInFollowState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bIsInFollowState");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsInFollowState_Offset), 0, IsInFollowState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsInFollowState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bIsInFollowState");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsInFollowState_Offset), 0, IsInFollowState_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:FollowClampDistanceOverride")]
	public float FollowClampDistanceOverride
	{
		get
		{
			CheckDestroyed();
			if (!FollowClampDistanceOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:FollowClampDistanceOverride");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FollowClampDistanceOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FollowClampDistanceOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:FollowClampDistanceOverride");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FollowClampDistanceOverride_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283028uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:DefaultFollowClampDistance")]
	public float DefaultFollowClampDistance
	{
		get
		{
			CheckDestroyed();
			if (!DefaultFollowClampDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:DefaultFollowClampDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DefaultFollowClampDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultFollowClampDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:DefaultFollowClampDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DefaultFollowClampDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:bEnablePrediction")]
	public bool EnablePrediction
	{
		get
		{
			CheckDestroyed();
			if (!EnablePrediction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bEnablePrediction");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnablePrediction_Offset), 0, EnablePrediction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnablePrediction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:bEnablePrediction");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnablePrediction_Offset), 0, EnablePrediction_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:PredictionTime")]
	public float PredictionTime
	{
		get
		{
			CheckDestroyed();
			if (!PredictionTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:PredictionTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PredictionTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PredictionTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:PredictionTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PredictionTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:PredictionPointNum")]
	public int PredictionPointNum
	{
		get
		{
			CheckDestroyed();
			if (!PredictionPointNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:PredictionPointNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PredictionPointNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PredictionPointNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:PredictionPointNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PredictionPointNum_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:HitMoveWeight")]
	public float HitMoveWeight
	{
		get
		{
			CheckDestroyed();
			if (!HitMoveWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:HitMoveWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HitMoveWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitMoveWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:HitMoveWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HitMoveWeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:HitMoveIsEnabled")]
	public bool HitMoveIsEnabled
	{
		get
		{
			CheckDestroyed();
			if (!HitMoveIsEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:HitMoveIsEnabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, HitMoveIsEnabled_Offset), 0, HitMoveIsEnabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HitMoveIsEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:HitMoveIsEnabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, HitMoveIsEnabled_Offset), 0, HitMoveIsEnabled_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:HitMoveIsUnmovable")]
	public bool HitMoveIsUnmovable
	{
		get
		{
			CheckDestroyed();
			if (!HitMoveIsUnmovable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:HitMoveIsUnmovable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, HitMoveIsUnmovable_Offset), 0, HitMoveIsUnmovable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HitMoveIsUnmovable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:HitMoveIsUnmovable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, HitMoveIsUnmovable_Offset), 0, HitMoveIsUnmovable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:HitMoveCanUpdate")]
	public bool HitMoveCanUpdate
	{
		get
		{
			CheckDestroyed();
			if (!HitMoveCanUpdate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:HitMoveCanUpdate");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, HitMoveCanUpdate_Offset), 0, HitMoveCanUpdate_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HitMoveCanUpdate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:HitMoveCanUpdate");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, HitMoveCanUpdate_Offset), 0, HitMoveCanUpdate_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:MoveStartHistoryZDeltaNum_NavWalkOpt")]
	protected int MoveStartHistoryZDeltaNum_NavWalkOpt
	{
		get
		{
			CheckDestroyed();
			if (!MoveStartHistoryZDeltaNum_NavWalkOpt_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:MoveStartHistoryZDeltaNum_NavWalkOpt");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MoveStartHistoryZDeltaNum_NavWalkOpt_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveStartHistoryZDeltaNum_NavWalkOpt_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:MoveStartHistoryZDeltaNum_NavWalkOpt");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MoveStartHistoryZDeltaNum_NavWalkOpt_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:MoveEndHistoryZDeltaNum_NavWalkOpt")]
	protected int MoveEndHistoryZDeltaNum_NavWalkOpt
	{
		get
		{
			CheckDestroyed();
			if (!MoveEndHistoryZDeltaNum_NavWalkOpt_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:MoveEndHistoryZDeltaNum_NavWalkOpt");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MoveEndHistoryZDeltaNum_NavWalkOpt_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveEndHistoryZDeltaNum_NavWalkOpt_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:MoveEndHistoryZDeltaNum_NavWalkOpt");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MoveEndHistoryZDeltaNum_NavWalkOpt_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:ZDeltaThrehold_NavWalkOpt")]
	protected float ZDeltaThrehold_NavWalkOpt
	{
		get
		{
			CheckDestroyed();
			if (!ZDeltaThrehold_NavWalkOpt_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:ZDeltaThrehold_NavWalkOpt");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ZDeltaThrehold_NavWalkOpt_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ZDeltaThrehold_NavWalkOpt_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:ZDeltaThrehold_NavWalkOpt");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ZDeltaThrehold_NavWalkOpt_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:FloorZSlopeDeltaThrehold_Anisotropy")]
	protected float FloorZSlopeDeltaThrehold_Anisotropy
	{
		get
		{
			CheckDestroyed();
			if (!FloorZSlopeDeltaThrehold_Anisotropy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:FloorZSlopeDeltaThrehold_Anisotropy");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FloorZSlopeDeltaThrehold_Anisotropy_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FloorZSlopeDeltaThrehold_Anisotropy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:FloorZSlopeDeltaThrehold_Anisotropy");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FloorZSlopeDeltaThrehold_Anisotropy_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:FloorZSlopeDeltaThrehold_Syntropy")]
	protected float FloorZSlopeDeltaThrehold_Syntropy
	{
		get
		{
			CheckDestroyed();
			if (!FloorZSlopeDeltaThrehold_Syntropy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:FloorZSlopeDeltaThrehold_Syntropy");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FloorZSlopeDeltaThrehold_Syntropy_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FloorZSlopeDeltaThrehold_Syntropy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:FloorZSlopeDeltaThrehold_Syntropy");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FloorZSlopeDeltaThrehold_Syntropy_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:CurFloorZAdditionalWeight")]
	protected int CurFloorZAdditionalWeight
	{
		get
		{
			CheckDestroyed();
			if (!CurFloorZAdditionalWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:CurFloorZAdditionalWeight");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CurFloorZAdditionalWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurFloorZAdditionalWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:CurFloorZAdditionalWeight");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CurFloorZAdditionalWeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:FloorZTraceStartScaleShrink")]
	protected float FloorZTraceStartScaleShrink
	{
		get
		{
			CheckDestroyed();
			if (!FloorZTraceStartScaleShrink_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:FloorZTraceStartScaleShrink");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FloorZTraceStartScaleShrink_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FloorZTraceStartScaleShrink_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:FloorZTraceStartScaleShrink");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FloorZTraceStartScaleShrink_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:FloorTestCapsuleRadiusScale")]
	protected float FloorTestCapsuleRadiusScale
	{
		get
		{
			CheckDestroyed();
			if (!FloorTestCapsuleRadiusScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:FloorTestCapsuleRadiusScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FloorTestCapsuleRadiusScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FloorTestCapsuleRadiusScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:FloorTestCapsuleRadiusScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FloorTestCapsuleRadiusScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:DitchFallDeltaMoveForTest")]
	protected FVector DitchFallDeltaMoveForTest
	{
		get
		{
			CheckDestroyed();
			if (!DitchFallDeltaMoveForTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:DitchFallDeltaMoveForTest");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, DitchFallDeltaMoveForTest_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DitchFallDeltaMoveForTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:DitchFallDeltaMoveForTest");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, DitchFallDeltaMoveForTest_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:DebugLength")]
	protected float DebugLength
	{
		get
		{
			CheckDestroyed();
			if (!DebugLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:DebugLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DebugLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:DebugLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DebugLength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:DebugSingleStep")]
	protected float DebugSingleStep
	{
		get
		{
			CheckDestroyed();
			if (!DebugSingleStep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:DebugSingleStep");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DebugSingleStep_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugSingleStep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:DebugSingleStep");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DebugSingleStep_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:DebugZOffset")]
	protected FVector DebugZOffset
	{
		get
		{
			CheckDestroyed();
			if (!DebugZOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:DebugZOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, DebugZOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugZOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacterMovementComponent:DebugZOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, DebugZOffset_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:TryGetCurSurfaceTypeFromMovement")]
	public unsafe int TryGetCurSurfaceTypeFromMovement()
	{
		CheckDestroyed();
		if (!TryGetCurSurfaceTypeFromMovement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:TryGetCurSurfaceTypeFromMovement");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TryGetCurSurfaceTypeFromMovement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TryGetCurSurfaceTypeFromMovement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, TryGetCurSurfaceTypeFromMovement_FunctionAddress, intPtr, TryGetCurSurfaceTypeFromMovement_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, TryGetCurSurfaceTypeFromMovement_ReturnValue_Offset), 0, TryGetCurSurfaceTypeFromMovement_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:TryGetCurNormalFromMovement")]
	public unsafe FVector TryGetCurNormalFromMovement()
	{
		CheckDestroyed();
		if (!TryGetCurNormalFromMovement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:TryGetCurNormalFromMovement");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(TryGetCurNormalFromMovement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TryGetCurNormalFromMovement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, TryGetCurNormalFromMovement_FunctionAddress, intPtr, TryGetCurNormalFromMovement_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, TryGetCurNormalFromMovement_ReturnValue_Offset), 0, TryGetCurNormalFromMovement_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:TryGetCurHitPointFromMovement")]
	public unsafe FVector TryGetCurHitPointFromMovement()
	{
		CheckDestroyed();
		if (!TryGetCurHitPointFromMovement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:TryGetCurHitPointFromMovement");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(TryGetCurHitPointFromMovement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TryGetCurHitPointFromMovement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, TryGetCurHitPointFromMovement_FunctionAddress, intPtr, TryGetCurHitPointFromMovement_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, TryGetCurHitPointFromMovement_ReturnValue_Offset), 0, TryGetCurHitPointFromMovement_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1140982785u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:SetWalkOnDitch")]
	public unsafe void SetWalkOnDitch(bool bDitch)
	{
		CheckDestroyed();
		if (!SetWalkOnDitch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:SetWalkOnDitch");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWalkOnDitch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWalkOnDitch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetWalkOnDitch_bDitch_Offset), 0, SetWalkOnDitch_bDitch_PropertyAddress.Address, bDitch);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWalkOnDitch_FunctionAddress, intPtr, SetWalkOnDitch_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:SetUseSeparateBrakingFriction")]
	public unsafe void SetUseSeparateBrakingFriction(bool bUse)
	{
		CheckDestroyed();
		if (!SetUseSeparateBrakingFriction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:SetUseSeparateBrakingFriction");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUseSeparateBrakingFriction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUseSeparateBrakingFriction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetUseSeparateBrakingFriction_bUse_Offset), 0, SetUseSeparateBrakingFriction_bUse_PropertyAddress.Address, bUse);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetUseSeparateBrakingFriction_FunctionAddress, intPtr, SetUseSeparateBrakingFriction_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:SetSwitchToNavWalkCumulateTime")]
	public unsafe void SetSwitchToNavWalkCumulateTime(float Time)
	{
		CheckDestroyed();
		if (!SetSwitchToNavWalkCumulateTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:SetSwitchToNavWalkCumulateTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSwitchToNavWalkCumulateTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSwitchToNavWalkCumulateTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSwitchToNavWalkCumulateTime_Time_Offset), 0, SetSwitchToNavWalkCumulateTime_Time_PropertyAddress.Address, Time);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSwitchToNavWalkCumulateTime_FunctionAddress, intPtr, SetSwitchToNavWalkCumulateTime_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:SetOnMovingPlatform")]
	public unsafe void SetOnMovingPlatform(bool bIsOnMovingPlatform)
	{
		CheckDestroyed();
		if (!SetOnMovingPlatform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:SetOnMovingPlatform");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOnMovingPlatform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOnMovingPlatform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetOnMovingPlatform_bIsOnMovingPlatform_Offset), 0, SetOnMovingPlatform_bIsOnMovingPlatform_PropertyAddress.Address, bIsOnMovingPlatform);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOnMovingPlatform_FunctionAddress, intPtr, SetOnMovingPlatform_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:SetNavWalkOptMassiveMode")]
	public unsafe void SetNavWalkOptMassiveMode(bool bMassiveOpt)
	{
		CheckDestroyed();
		if (!SetNavWalkOptMassiveMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:SetNavWalkOptMassiveMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNavWalkOptMassiveMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNavWalkOptMassiveMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNavWalkOptMassiveMode_bMassiveOpt_Offset), 0, SetNavWalkOptMassiveMode_bMassiveOpt_PropertyAddress.Address, bMassiveOpt);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNavWalkOptMassiveMode_FunctionAddress, intPtr, SetNavWalkOptMassiveMode_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:SetNavWalkOptLevel")]
	public unsafe void SetNavWalkOptLevel(int NewLevel)
	{
		CheckDestroyed();
		if (!SetNavWalkOptLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:SetNavWalkOptLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNavWalkOptLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNavWalkOptLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNavWalkOptLevel_NewLevel_Offset), 0, SetNavWalkOptLevel_NewLevel_PropertyAddress.Address, NewLevel);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNavWalkOptLevel_FunctionAddress, intPtr, SetNavWalkOptLevel_ParamsSize);
	}

	[UFunction(Flags = 1140982785u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:SetJumpOffState")]
	public unsafe void SetJumpOffState(bool JumpOff)
	{
		CheckDestroyed();
		if (!SetJumpOffState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:SetJumpOffState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetJumpOffState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetJumpOffState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetJumpOffState_JumpOff_Offset), 0, SetJumpOffState_JumpOff_PropertyAddress.Address, JumpOff);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetJumpOffState_FunctionAddress, intPtr, SetJumpOffState_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:SetHitMoveIgnoredActor")]
	public unsafe void SetHitMoveIgnoredActor(AActor Actor, bool RemoveIgnoredActor = false)
	{
		CheckDestroyed();
		if (!SetHitMoveIgnoredActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:SetHitMoveIgnoredActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHitMoveIgnoredActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHitMoveIgnoredActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetHitMoveIgnoredActor_Actor_Offset), 0, SetHitMoveIgnoredActor_Actor_PropertyAddress.Address, Actor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetHitMoveIgnoredActor_RemoveIgnoredActor_Offset), 0, SetHitMoveIgnoredActor_RemoveIgnoredActor_PropertyAddress.Address, RemoveIgnoredActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHitMoveIgnoredActor_FunctionAddress, intPtr, SetHitMoveIgnoredActor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:SetHitMoveCollisionEnabled")]
	public unsafe void SetHitMoveCollisionEnabled(UShapeComponent ShapeComp, bool IsEnabled)
	{
		CheckDestroyed();
		if (!SetHitMoveCollisionEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:SetHitMoveCollisionEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHitMoveCollisionEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHitMoveCollisionEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UShapeComponent>.ToNative(IntPtr.Add(intPtr, SetHitMoveCollisionEnabled_ShapeComp_Offset), 0, SetHitMoveCollisionEnabled_ShapeComp_PropertyAddress.Address, ShapeComp);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetHitMoveCollisionEnabled_IsEnabled_Offset), 0, SetHitMoveCollisionEnabled_IsEnabled_PropertyAddress.Address, IsEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHitMoveCollisionEnabled_FunctionAddress, intPtr, SetHitMoveCollisionEnabled_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:SetHitMoveCollisionDirection")]
	public unsafe void SetHitMoveCollisionDirection(UShapeComponent ShapeComp, EHitMoveDir HitMoveDir)
	{
		CheckDestroyed();
		if (!SetHitMoveCollisionDirection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:SetHitMoveCollisionDirection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHitMoveCollisionDirection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHitMoveCollisionDirection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UShapeComponent>.ToNative(IntPtr.Add(intPtr, SetHitMoveCollisionDirection_ShapeComp_Offset), 0, SetHitMoveCollisionDirection_ShapeComp_PropertyAddress.Address, ShapeComp);
		EnumMarshaler<EHitMoveDir>.ToNative(IntPtr.Add(intPtr, SetHitMoveCollisionDirection_HitMoveDir_Offset), 0, SetHitMoveCollisionDirection_HitMoveDir_PropertyAddress.Address, HitMoveDir);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHitMoveCollisionDirection_FunctionAddress, intPtr, SetHitMoveCollisionDirection_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:SetGravityToJumpOffGravity")]
	public unsafe void SetGravityToJumpOffGravity()
	{
		CheckDestroyed();
		if (!SetGravityToJumpOffGravity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:SetGravityToJumpOffGravity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGravityToJumpOffGravity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGravityToJumpOffGravity_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SetGravityToJumpOffGravity_FunctionAddress, argsSize: SetGravityToJumpOffGravity_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:SetEnableSimplePhysWalkCollision")]
	public unsafe void SetEnableSimplePhysWalkCollision(bool bEnable)
	{
		CheckDestroyed();
		if (!SetEnableSimplePhysWalkCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:SetEnableSimplePhysWalkCollision");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnableSimplePhysWalkCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnableSimplePhysWalkCollision_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEnableSimplePhysWalkCollision_bEnable_Offset), 0, SetEnableSimplePhysWalkCollision_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEnableSimplePhysWalkCollision_FunctionAddress, intPtr, SetEnableSimplePhysWalkCollision_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:SetDisableNavWalkOptByWhiteList")]
	public unsafe void SetDisableNavWalkOptByWhiteList(bool bDisable)
	{
		CheckDestroyed();
		if (!SetDisableNavWalkOptByWhiteList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:SetDisableNavWalkOptByWhiteList");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDisableNavWalkOptByWhiteList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDisableNavWalkOptByWhiteList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetDisableNavWalkOptByWhiteList_bDisable_Offset), 0, SetDisableNavWalkOptByWhiteList_bDisable_PropertyAddress.Address, bDisable);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDisableNavWalkOptByWhiteList_FunctionAddress, intPtr, SetDisableNavWalkOptByWhiteList_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:SetCustomJumpVelocityIncrement")]
	public unsafe void SetCustomJumpVelocityIncrement(float VelocityIncrement)
	{
		CheckDestroyed();
		if (!SetCustomJumpVelocityIncrement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:SetCustomJumpVelocityIncrement");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomJumpVelocityIncrement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomJumpVelocityIncrement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCustomJumpVelocityIncrement_VelocityIncrement_Offset), 0, SetCustomJumpVelocityIncrement_VelocityIncrement_PropertyAddress.Address, VelocityIncrement);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomJumpVelocityIncrement_FunctionAddress, intPtr, SetCustomJumpVelocityIncrement_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:ResetGravityToNormalGravity")]
	public unsafe void ResetGravityToNormalGravity()
	{
		CheckDestroyed();
		if (!ResetGravityToNormalGravity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:ResetGravityToNormalGravity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetGravityToNormalGravity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetGravityToNormalGravity_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetGravityToNormalGravity_FunctionAddress, argsSize: ResetGravityToNormalGravity_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:MoveUpdateHitMove")]
	public unsafe void MoveUpdateHitMove(FVector Delta)
	{
		CheckDestroyed();
		if (!MoveUpdateHitMove_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:MoveUpdateHitMove");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MoveUpdateHitMove_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MoveUpdateHitMove_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, MoveUpdateHitMove_Delta_Offset), 0, MoveUpdateHitMove_Delta_PropertyAddress.Address, Delta);
		NativeReflection.InvokeFunctionOptimized(base.Address, MoveUpdateHitMove_FunctionAddress, intPtr, MoveUpdateHitMove_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:LaunchVelocityZ")]
	public unsafe void LaunchVelocityZ(float VelocityZ)
	{
		CheckDestroyed();
		if (!LaunchVelocityZ_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:LaunchVelocityZ");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LaunchVelocityZ_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LaunchVelocityZ_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, LaunchVelocityZ_VelocityZ_Offset), 0, LaunchVelocityZ_VelocityZ_PropertyAddress.Address, VelocityZ);
		NativeReflection.InvokeFunctionOptimized(base.Address, LaunchVelocityZ_FunctionAddress, intPtr, LaunchVelocityZ_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:IsWalkOnDitch")]
	public unsafe bool IsWalkOnDitch()
	{
		CheckDestroyed();
		if (!IsWalkOnDitch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:IsWalkOnDitch");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsWalkOnDitch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsWalkOnDitch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsWalkOnDitch_FunctionAddress, intPtr, IsWalkOnDitch_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsWalkOnDitch_ReturnValue_Offset), 0, IsWalkOnDitch_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:IsUseSeparateBrakingFriction")]
	public unsafe bool IsUseSeparateBrakingFriction()
	{
		CheckDestroyed();
		if (!IsUseSeparateBrakingFriction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:IsUseSeparateBrakingFriction");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsUseSeparateBrakingFriction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsUseSeparateBrakingFriction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsUseSeparateBrakingFriction_FunctionAddress, intPtr, IsUseSeparateBrakingFriction_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsUseSeparateBrakingFriction_ReturnValue_Offset), 0, IsUseSeparateBrakingFriction_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:IsInNavWalkOptMode")]
	public unsafe bool IsInNavWalkOptMode()
	{
		CheckDestroyed();
		if (!IsInNavWalkOptMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:IsInNavWalkOptMode");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInNavWalkOptMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInNavWalkOptMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsInNavWalkOptMode_FunctionAddress, intPtr, IsInNavWalkOptMode_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInNavWalkOptMode_ReturnValue_Offset), 0, IsInNavWalkOptMode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:IsInJumpOffAdjust")]
	public unsafe bool IsInJumpOffAdjust()
	{
		CheckDestroyed();
		if (!IsInJumpOffAdjust_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:IsInJumpOffAdjust");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInJumpOffAdjust_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInJumpOffAdjust_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsInJumpOffAdjust_FunctionAddress, intPtr, IsInJumpOffAdjust_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInJumpOffAdjust_ReturnValue_Offset), 0, IsInJumpOffAdjust_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:HitMoveUpdate")]
	public unsafe void HitMoveUpdate()
	{
		CheckDestroyed();
		if (!HitMoveUpdate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:HitMoveUpdate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HitMoveUpdate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HitMoveUpdate_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: HitMoveUpdate_FunctionAddress, argsSize: HitMoveUpdate_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:HasAnimRootMotion_CS")]
	public unsafe bool HasAnimRootMotion_CS()
	{
		CheckDestroyed();
		if (!HasAnimRootMotion_CS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:HasAnimRootMotion_CS");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasAnimRootMotion_CS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasAnimRootMotion_CS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasAnimRootMotion_CS_FunctionAddress, intPtr, HasAnimRootMotion_CS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasAnimRootMotion_CS_ReturnValue_Offset), 0, HasAnimRootMotion_CS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:GetTopZInFalling")]
	public unsafe float GetTopZInFalling()
	{
		CheckDestroyed();
		if (!GetTopZInFalling_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:GetTopZInFalling");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTopZInFalling_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTopZInFalling_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTopZInFalling_FunctionAddress, intPtr, GetTopZInFalling_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetTopZInFalling_ReturnValue_Offset), 0, GetTopZInFalling_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:GetHitMoveCollisionIsEnabled")]
	public unsafe bool GetHitMoveCollisionIsEnabled(UShapeComponent ShapeComp, out bool IsEnabled)
	{
		CheckDestroyed();
		if (!GetHitMoveCollisionIsEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:GetHitMoveCollisionIsEnabled");
			IsEnabled = false;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHitMoveCollisionIsEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHitMoveCollisionIsEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UShapeComponent>.ToNative(IntPtr.Add(intPtr, GetHitMoveCollisionIsEnabled_ShapeComp_Offset), 0, GetHitMoveCollisionIsEnabled_ShapeComp_PropertyAddress.Address, ShapeComp);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetHitMoveCollisionIsEnabled_FunctionAddress, intPtr, GetHitMoveCollisionIsEnabled_ParamsSize);
		IsEnabled = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetHitMoveCollisionIsEnabled_IsEnabled_Offset), 0, GetHitMoveCollisionIsEnabled_IsEnabled_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetHitMoveCollisionIsEnabled_ReturnValue_Offset), 0, GetHitMoveCollisionIsEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:CustomJumpMoveBreak")]
	public unsafe void CustomJumpMoveBreak()
	{
		CheckDestroyed();
		if (!CustomJumpMoveBreak_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:CustomJumpMoveBreak");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CustomJumpMoveBreak_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CustomJumpMoveBreak_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: CustomJumpMoveBreak_FunctionAddress, argsSize: CustomJumpMoveBreak_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:ClearTopZInFalling")]
	public unsafe void ClearTopZInFalling()
	{
		CheckDestroyed();
		if (!ClearTopZInFalling_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:ClearTopZInFalling");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearTopZInFalling_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearTopZInFalling_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearTopZInFalling_FunctionAddress, argsSize: ClearTopZInFalling_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:ClearHitMoveCollisions")]
	public unsafe void ClearHitMoveCollisions()
	{
		CheckDestroyed();
		if (!ClearHitMoveCollisions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:ClearHitMoveCollisions");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearHitMoveCollisions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearHitMoveCollisions_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearHitMoveCollisions_FunctionAddress, argsSize: ClearHitMoveCollisions_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:CanGetNormalAndSurfaceTypeInfoFromMovement")]
	public unsafe bool CanGetNormalAndSurfaceTypeInfoFromMovement()
	{
		CheckDestroyed();
		if (!CanGetNormalAndSurfaceTypeInfoFromMovement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:CanGetNormalAndSurfaceTypeInfoFromMovement");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanGetNormalAndSurfaceTypeInfoFromMovement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanGetNormalAndSurfaceTypeInfoFromMovement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanGetNormalAndSurfaceTypeInfoFromMovement_FunctionAddress, intPtr, CanGetNormalAndSurfaceTypeInfoFromMovement_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanGetNormalAndSurfaceTypeInfoFromMovement_ReturnValue_Offset), 0, CanGetNormalAndSurfaceTypeInfoFromMovement_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacterMovementComponent:AddOrModifyHitMoveCollision")]
	public unsafe void AddOrModifyHitMoveCollision(UShapeComponent ShapeComp, EHitMoveDir HitMoveDir, bool IsEnabled)
	{
		CheckDestroyed();
		if (!AddOrModifyHitMoveCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacterMovementComponent:AddOrModifyHitMoveCollision");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddOrModifyHitMoveCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddOrModifyHitMoveCollision_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UShapeComponent>.ToNative(IntPtr.Add(intPtr, AddOrModifyHitMoveCollision_ShapeComp_Offset), 0, AddOrModifyHitMoveCollision_ShapeComp_PropertyAddress.Address, ShapeComp);
		EnumMarshaler<EHitMoveDir>.ToNative(IntPtr.Add(intPtr, AddOrModifyHitMoveCollision_HitMoveDir_Offset), 0, AddOrModifyHitMoveCollision_HitMoveDir_PropertyAddress.Address, HitMoveDir);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddOrModifyHitMoveCollision_IsEnabled_Offset), 0, AddOrModifyHitMoveCollision_IsEnabled_PropertyAddress.Address, IsEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddOrModifyHitMoveCollision_FunctionAddress, intPtr, AddOrModifyHitMoveCollision_ParamsSize);
	}

	static UBGUCharacterMovementComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUCharacterMovementComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUCharacterMovementComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BGUCharacterMovementComponent");
		NativeReflectionCached.GetPropertyRef(ref WalkOnDitch_PropertyAddress, intPtr, "bWalkOnDitch");
		WalkOnDitch_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bWalkOnDitch");
		WalkOnDitch_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bWalkOnDitch", Classes.FBoolProperty);
		JumpOff_GravityScale_Config_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JumpOff_GravityScale_Config");
		JumpOff_GravityScale_Config_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JumpOff_GravityScale_Config", Classes.FFloatProperty);
		JumpOff_GravityScaleResetTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JumpOff_GravityScaleResetTime");
		JumpOff_GravityScaleResetTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JumpOff_GravityScaleResetTime", Classes.FFloatProperty);
		JumpOff_TestTickTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JumpOff_TestTickTime");
		JumpOff_TestTickTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JumpOff_TestTickTime", Classes.FFloatProperty);
		JumpOff_XYMaxSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JumpOff_XYMaxSpeed");
		JumpOff_XYMaxSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JumpOff_XYMaxSpeed", Classes.FFloatProperty);
		JumpOff_ZAddtionalVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JumpOff_ZAddtionalVelocity");
		JumpOff_ZAddtionalVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JumpOff_ZAddtionalVelocity", Classes.FFloatProperty);
		JumpOff_XYMaxSpeedAddtionalScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JumpOff_XYMaxSpeedAddtionalScale");
		JumpOff_XYMaxSpeedAddtionalScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JumpOff_XYMaxSpeedAddtionalScale", Classes.FFloatProperty);
		JumpOff_XYBaseCapsuelAddtionalScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JumpOff_XYBaseCapsuelAddtionalScale");
		JumpOff_XYBaseCapsuelAddtionalScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JumpOff_XYBaseCapsuelAddtionalScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ImmediateUpdateRootMotion_PropertyAddress, intPtr, "bImmediateUpdateRootMotion");
		ImmediateUpdateRootMotion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bImmediateUpdateRootMotion");
		ImmediateUpdateRootMotion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bImmediateUpdateRootMotion", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OnMovingPlatform_PropertyAddress, intPtr, "bOnMovingPlatform");
		OnMovingPlatform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOnMovingPlatform");
		OnMovingPlatform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOnMovingPlatform", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableSimplifiedMove_PropertyAddress, intPtr, "bEnableSimplifiedMove");
		EnableSimplifiedMove_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableSimplifiedMove");
		EnableSimplifiedMove_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableSimplifiedMove", Classes.FBoolProperty);
		CurNavOptFloorNormal_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurNavOptFloorNormal");
		CurNavOptFloorNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurNavOptFloorNormal", Classes.FStructProperty);
		CurHitPoint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurHitPoint");
		CurHitPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurHitPoint", Classes.FStructProperty);
		CanSwitchToNavWalkCD_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CanSwitchToNavWalkCD");
		CanSwitchToNavWalkCD_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CanSwitchToNavWalkCD", Classes.FIntProperty);
		CanSwitchToNavWalkMaxCD_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CanSwitchToNavWalkMaxCD");
		CanSwitchToNavWalkMaxCD_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CanSwitchToNavWalkMaxCD", Classes.FIntProperty);
		NavWalkCanStepHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NavWalkCanStepHeight");
		NavWalkCanStepHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NavWalkCanStepHeight", Classes.FFloatProperty);
		NavWalkFallingHight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NavWalkFallingHight");
		NavWalkFallingHight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NavWalkFallingHight", Classes.FFloatProperty);
		LastDesireDeltaFloorZ_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LastDesireDeltaFloorZ");
		LastDesireDeltaFloorZ_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LastDesireDeltaFloorZ", Classes.FFloatProperty);
		CapsuleRadiusRayExtraAdditiveScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CapsuleRadiusRayExtraAdditiveScale");
		CapsuleRadiusRayExtraAdditiveScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CapsuleRadiusRayExtraAdditiveScale", Classes.FFloatProperty);
		NavWalkOptLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NavWalkOptLevel");
		NavWalkOptLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NavWalkOptLevel", Classes.FIntProperty);
		XYMoveCenterBlockTriggerRollBackCapsuleScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "XYMoveCenterBlockTriggerRollBackCapsuleScale");
		XYMoveCenterBlockTriggerRollBackCapsuleScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "XYMoveCenterBlockTriggerRollBackCapsuleScale", Classes.FFloatProperty);
		XYMoveSideBlockTriggerRollBackCapsuleScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "XYMoveSideBlockTriggerRollBackCapsuleScale");
		XYMoveSideBlockTriggerRollBackCapsuleScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "XYMoveSideBlockTriggerRollBackCapsuleScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref NavWalkOpt_MassiveOpt_PropertyAddress, intPtr, "bNavWalkOpt_MassiveOpt");
		NavWalkOpt_MassiveOpt_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bNavWalkOpt_MassiveOpt");
		NavWalkOpt_MassiveOpt_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bNavWalkOpt_MassiveOpt", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OverridePhysWalkingParam_PropertyAddress, intPtr, "bOverridePhysWalkingParam");
		OverridePhysWalkingParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverridePhysWalkingParam");
		OverridePhysWalkingParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverridePhysWalkingParam", Classes.FBoolProperty);
		NavWalkCanStepAngel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NavWalkCanStepAngel");
		NavWalkCanStepAngel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NavWalkCanStepAngel", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref JumpOff_PropertyAddress, intPtr, "bJumpOff");
		JumpOff_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bJumpOff");
		JumpOff_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bJumpOff", Classes.FBoolProperty);
		NavWalkCanStepCapsuelHeightScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NavWalkCanStepCapsuelHeightScale");
		NavWalkCanStepCapsuelHeightScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NavWalkCanStepCapsuelHeightScale", Classes.FFloatProperty);
		NavWalkCapsuelStepLinTraceZOffsetFromCenter_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NavWalkCapsuelStepLinTraceZOffsetFromCenter");
		NavWalkCapsuelStepLinTraceZOffsetFromCenter_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NavWalkCapsuelStepLinTraceZOffsetFromCenter", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref NavWalkDebugEnable_PropertyAddress, intPtr, "bNavWalkDebugEnable");
		NavWalkDebugEnable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bNavWalkDebugEnable");
		NavWalkDebugEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bNavWalkDebugEnable", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceOrgNavWalk_PropertyAddress, intPtr, "bForceOrgNavWalk");
		ForceOrgNavWalk_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bForceOrgNavWalk");
		ForceOrgNavWalk_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bForceOrgNavWalk", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableCheckFloor_PropertyAddress, intPtr, "bEnableCheckFloor");
		EnableCheckFloor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableCheckFloor");
		EnableCheckFloor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableCheckFloor", Classes.FBoolProperty);
		SimplePhysWalkCollisionRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SimplePhysWalkCollisionRadius");
		SimplePhysWalkCollisionRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SimplePhysWalkCollisionRadius", Classes.FFloatProperty);
		SimplePhysWalkStartPenetratingRollBack_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SimplePhysWalkStartPenetratingRollBack");
		SimplePhysWalkStartPenetratingRollBack_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SimplePhysWalkStartPenetratingRollBack", Classes.FFloatProperty);
		SimplePhysWalkStartPenetratingMaxRollBack_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SimplePhysWalkStartPenetratingMaxRollBack");
		SimplePhysWalkStartPenetratingMaxRollBack_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SimplePhysWalkStartPenetratingMaxRollBack", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableSimplePhysWalkCollision_PropertyAddress, intPtr, "bEnableSimplePhysWalkCollision");
		EnableSimplePhysWalkCollision_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableSimplePhysWalkCollision");
		EnableSimplePhysWalkCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableSimplePhysWalkCollision", Classes.FBoolProperty);
		RootMotionTranslationScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RootMotionTranslationScale");
		RootMotionTranslationScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RootMotionTranslationScale", Classes.FStructProperty);
		MMRootMotionScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MMRootMotionScale");
		MMRootMotionScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MMRootMotionScale", Classes.FStructProperty);
		OptimizeDistanceLevel1_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OptimizeDistanceLevel1");
		OptimizeDistanceLevel1_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OptimizeDistanceLevel1", Classes.FFloatProperty);
		FinalNavWalkOptDistanceLevel1_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FinalNavWalkOptDistanceLevel1");
		FinalNavWalkOptDistanceLevel1_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FinalNavWalkOptDistanceLevel1", Classes.FFloatProperty);
		OptimizeDistanceLevel2_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OptimizeDistanceLevel2");
		OptimizeDistanceLevel2_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OptimizeDistanceLevel2", Classes.FFloatProperty);
		FinalNavWalkOptDistanceLevel2_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FinalNavWalkOptDistanceLevel2");
		FinalNavWalkOptDistanceLevel2_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FinalNavWalkOptDistanceLevel2", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CanOptimizeFromCS_PropertyAddress, intPtr, "bCanOptimizeFromCS");
		CanOptimizeFromCS_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanOptimizeFromCS");
		CanOptimizeFromCS_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanOptimizeFromCS", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPatrolling_PropertyAddress, intPtr, "bIsPatrolling");
		IsPatrolling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsPatrolling");
		IsPatrolling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsPatrolling", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsInBattle_PropertyAddress, intPtr, "bIsInBattle");
		IsInBattle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsInBattle");
		IsInBattle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsInBattle", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableBlendAnimRootMotion_PropertyAddress, intPtr, "bEnableBlendAnimRootMotion");
		EnableBlendAnimRootMotion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableBlendAnimRootMotion");
		EnableBlendAnimRootMotion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableBlendAnimRootMotion", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplicateRootMotionMove_PropertyAddress, intPtr, "bReplicateRootMotionMove");
		ReplicateRootMotionMove_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bReplicateRootMotionMove");
		ReplicateRootMotionMove_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bReplicateRootMotionMove", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableRootMotionFollowMode_PropertyAddress, intPtr, "bDisableRootMotionFollowMode");
		DisableRootMotionFollowMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDisableRootMotionFollowMode");
		DisableRootMotionFollowMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDisableRootMotionFollowMode", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsInFollowState_PropertyAddress, intPtr, "bIsInFollowState");
		IsInFollowState_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsInFollowState");
		IsInFollowState_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsInFollowState", Classes.FBoolProperty);
		FollowClampDistanceOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FollowClampDistanceOverride");
		FollowClampDistanceOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FollowClampDistanceOverride", Classes.FFloatProperty);
		DefaultFollowClampDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultFollowClampDistance");
		DefaultFollowClampDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultFollowClampDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EnablePrediction_PropertyAddress, intPtr, "bEnablePrediction");
		EnablePrediction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnablePrediction");
		EnablePrediction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnablePrediction", Classes.FBoolProperty);
		PredictionTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PredictionTime");
		PredictionTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PredictionTime", Classes.FFloatProperty);
		PredictionPointNum_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PredictionPointNum");
		PredictionPointNum_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PredictionPointNum", Classes.FIntProperty);
		HitMoveWeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HitMoveWeight");
		HitMoveWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HitMoveWeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref HitMoveIsEnabled_PropertyAddress, intPtr, "HitMoveIsEnabled");
		HitMoveIsEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HitMoveIsEnabled");
		HitMoveIsEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HitMoveIsEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HitMoveIsUnmovable_PropertyAddress, intPtr, "HitMoveIsUnmovable");
		HitMoveIsUnmovable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HitMoveIsUnmovable");
		HitMoveIsUnmovable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HitMoveIsUnmovable", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HitMoveCanUpdate_PropertyAddress, intPtr, "HitMoveCanUpdate");
		HitMoveCanUpdate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HitMoveCanUpdate");
		HitMoveCanUpdate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HitMoveCanUpdate", Classes.FBoolProperty);
		MoveStartHistoryZDeltaNum_NavWalkOpt_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MoveStartHistoryZDeltaNum_NavWalkOpt");
		MoveStartHistoryZDeltaNum_NavWalkOpt_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MoveStartHistoryZDeltaNum_NavWalkOpt", Classes.FIntProperty);
		MoveEndHistoryZDeltaNum_NavWalkOpt_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MoveEndHistoryZDeltaNum_NavWalkOpt");
		MoveEndHistoryZDeltaNum_NavWalkOpt_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MoveEndHistoryZDeltaNum_NavWalkOpt", Classes.FIntProperty);
		ZDeltaThrehold_NavWalkOpt_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ZDeltaThrehold_NavWalkOpt");
		ZDeltaThrehold_NavWalkOpt_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ZDeltaThrehold_NavWalkOpt", Classes.FFloatProperty);
		FloorZSlopeDeltaThrehold_Anisotropy_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FloorZSlopeDeltaThrehold_Anisotropy");
		FloorZSlopeDeltaThrehold_Anisotropy_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FloorZSlopeDeltaThrehold_Anisotropy", Classes.FFloatProperty);
		FloorZSlopeDeltaThrehold_Syntropy_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FloorZSlopeDeltaThrehold_Syntropy");
		FloorZSlopeDeltaThrehold_Syntropy_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FloorZSlopeDeltaThrehold_Syntropy", Classes.FFloatProperty);
		CurFloorZAdditionalWeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurFloorZAdditionalWeight");
		CurFloorZAdditionalWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurFloorZAdditionalWeight", Classes.FIntProperty);
		FloorZTraceStartScaleShrink_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FloorZTraceStartScaleShrink");
		FloorZTraceStartScaleShrink_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FloorZTraceStartScaleShrink", Classes.FFloatProperty);
		FloorTestCapsuleRadiusScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FloorTestCapsuleRadiusScale");
		FloorTestCapsuleRadiusScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FloorTestCapsuleRadiusScale", Classes.FFloatProperty);
		DitchFallDeltaMoveForTest_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DitchFallDeltaMoveForTest");
		DitchFallDeltaMoveForTest_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DitchFallDeltaMoveForTest", Classes.FStructProperty);
		DebugLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DebugLength");
		DebugLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DebugLength", Classes.FFloatProperty);
		DebugSingleStep_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DebugSingleStep");
		DebugSingleStep_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DebugSingleStep", Classes.FFloatProperty);
		DebugZOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DebugZOffset");
		DebugZOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DebugZOffset", Classes.FStructProperty);
		TryGetCurSurfaceTypeFromMovement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TryGetCurSurfaceTypeFromMovement");
		TryGetCurSurfaceTypeFromMovement_ParamsSize = NativeReflection.GetFunctionParamsSize(TryGetCurSurfaceTypeFromMovement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TryGetCurSurfaceTypeFromMovement_ReturnValue_PropertyAddress, TryGetCurSurfaceTypeFromMovement_FunctionAddress, "ReturnValue");
		TryGetCurSurfaceTypeFromMovement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TryGetCurSurfaceTypeFromMovement_FunctionAddress, "ReturnValue");
		TryGetCurSurfaceTypeFromMovement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetCurSurfaceTypeFromMovement_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		TryGetCurSurfaceTypeFromMovement_IsValid = TryGetCurSurfaceTypeFromMovement_FunctionAddress != IntPtr.Zero && TryGetCurSurfaceTypeFromMovement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:TryGetCurSurfaceTypeFromMovement", TryGetCurSurfaceTypeFromMovement_IsValid);
		TryGetCurNormalFromMovement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TryGetCurNormalFromMovement");
		TryGetCurNormalFromMovement_ParamsSize = NativeReflection.GetFunctionParamsSize(TryGetCurNormalFromMovement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TryGetCurNormalFromMovement_ReturnValue_PropertyAddress, TryGetCurNormalFromMovement_FunctionAddress, "ReturnValue");
		TryGetCurNormalFromMovement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TryGetCurNormalFromMovement_FunctionAddress, "ReturnValue");
		TryGetCurNormalFromMovement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetCurNormalFromMovement_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		TryGetCurNormalFromMovement_IsValid = TryGetCurNormalFromMovement_FunctionAddress != IntPtr.Zero && TryGetCurNormalFromMovement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:TryGetCurNormalFromMovement", TryGetCurNormalFromMovement_IsValid);
		TryGetCurHitPointFromMovement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TryGetCurHitPointFromMovement");
		TryGetCurHitPointFromMovement_ParamsSize = NativeReflection.GetFunctionParamsSize(TryGetCurHitPointFromMovement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TryGetCurHitPointFromMovement_ReturnValue_PropertyAddress, TryGetCurHitPointFromMovement_FunctionAddress, "ReturnValue");
		TryGetCurHitPointFromMovement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TryGetCurHitPointFromMovement_FunctionAddress, "ReturnValue");
		TryGetCurHitPointFromMovement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetCurHitPointFromMovement_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		TryGetCurHitPointFromMovement_IsValid = TryGetCurHitPointFromMovement_FunctionAddress != IntPtr.Zero && TryGetCurHitPointFromMovement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:TryGetCurHitPointFromMovement", TryGetCurHitPointFromMovement_IsValid);
		SetWalkOnDitch_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetWalkOnDitch");
		SetWalkOnDitch_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWalkOnDitch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWalkOnDitch_bDitch_PropertyAddress, SetWalkOnDitch_FunctionAddress, "bDitch");
		SetWalkOnDitch_bDitch_Offset = NativeReflectionCached.GetPropertyOffset(SetWalkOnDitch_FunctionAddress, "bDitch");
		SetWalkOnDitch_bDitch_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWalkOnDitch_FunctionAddress, "bDitch", Classes.FBoolProperty);
		SetWalkOnDitch_IsValid = SetWalkOnDitch_FunctionAddress != IntPtr.Zero && SetWalkOnDitch_bDitch_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:SetWalkOnDitch", SetWalkOnDitch_IsValid);
		SetUseSeparateBrakingFriction_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetUseSeparateBrakingFriction");
		SetUseSeparateBrakingFriction_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUseSeparateBrakingFriction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUseSeparateBrakingFriction_bUse_PropertyAddress, SetUseSeparateBrakingFriction_FunctionAddress, "bUse");
		SetUseSeparateBrakingFriction_bUse_Offset = NativeReflectionCached.GetPropertyOffset(SetUseSeparateBrakingFriction_FunctionAddress, "bUse");
		SetUseSeparateBrakingFriction_bUse_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUseSeparateBrakingFriction_FunctionAddress, "bUse", Classes.FBoolProperty);
		SetUseSeparateBrakingFriction_IsValid = SetUseSeparateBrakingFriction_FunctionAddress != IntPtr.Zero && SetUseSeparateBrakingFriction_bUse_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:SetUseSeparateBrakingFriction", SetUseSeparateBrakingFriction_IsValid);
		SetSwitchToNavWalkCumulateTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSwitchToNavWalkCumulateTime");
		SetSwitchToNavWalkCumulateTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSwitchToNavWalkCumulateTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSwitchToNavWalkCumulateTime_Time_PropertyAddress, SetSwitchToNavWalkCumulateTime_FunctionAddress, "Time");
		SetSwitchToNavWalkCumulateTime_Time_Offset = NativeReflectionCached.GetPropertyOffset(SetSwitchToNavWalkCumulateTime_FunctionAddress, "Time");
		SetSwitchToNavWalkCumulateTime_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSwitchToNavWalkCumulateTime_FunctionAddress, "Time", Classes.FFloatProperty);
		SetSwitchToNavWalkCumulateTime_IsValid = SetSwitchToNavWalkCumulateTime_FunctionAddress != IntPtr.Zero && SetSwitchToNavWalkCumulateTime_Time_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:SetSwitchToNavWalkCumulateTime", SetSwitchToNavWalkCumulateTime_IsValid);
		SetOnMovingPlatform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOnMovingPlatform");
		SetOnMovingPlatform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOnMovingPlatform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOnMovingPlatform_bIsOnMovingPlatform_PropertyAddress, SetOnMovingPlatform_FunctionAddress, "bIsOnMovingPlatform");
		SetOnMovingPlatform_bIsOnMovingPlatform_Offset = NativeReflectionCached.GetPropertyOffset(SetOnMovingPlatform_FunctionAddress, "bIsOnMovingPlatform");
		SetOnMovingPlatform_bIsOnMovingPlatform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOnMovingPlatform_FunctionAddress, "bIsOnMovingPlatform", Classes.FBoolProperty);
		SetOnMovingPlatform_IsValid = SetOnMovingPlatform_FunctionAddress != IntPtr.Zero && SetOnMovingPlatform_bIsOnMovingPlatform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:SetOnMovingPlatform", SetOnMovingPlatform_IsValid);
		SetNavWalkOptMassiveMode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNavWalkOptMassiveMode");
		SetNavWalkOptMassiveMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNavWalkOptMassiveMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNavWalkOptMassiveMode_bMassiveOpt_PropertyAddress, SetNavWalkOptMassiveMode_FunctionAddress, "bMassiveOpt");
		SetNavWalkOptMassiveMode_bMassiveOpt_Offset = NativeReflectionCached.GetPropertyOffset(SetNavWalkOptMassiveMode_FunctionAddress, "bMassiveOpt");
		SetNavWalkOptMassiveMode_bMassiveOpt_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNavWalkOptMassiveMode_FunctionAddress, "bMassiveOpt", Classes.FBoolProperty);
		SetNavWalkOptMassiveMode_IsValid = SetNavWalkOptMassiveMode_FunctionAddress != IntPtr.Zero && SetNavWalkOptMassiveMode_bMassiveOpt_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:SetNavWalkOptMassiveMode", SetNavWalkOptMassiveMode_IsValid);
		SetNavWalkOptLevel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNavWalkOptLevel");
		SetNavWalkOptLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNavWalkOptLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNavWalkOptLevel_NewLevel_PropertyAddress, SetNavWalkOptLevel_FunctionAddress, "NewLevel");
		SetNavWalkOptLevel_NewLevel_Offset = NativeReflectionCached.GetPropertyOffset(SetNavWalkOptLevel_FunctionAddress, "NewLevel");
		SetNavWalkOptLevel_NewLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNavWalkOptLevel_FunctionAddress, "NewLevel", Classes.FIntProperty);
		SetNavWalkOptLevel_IsValid = SetNavWalkOptLevel_FunctionAddress != IntPtr.Zero && SetNavWalkOptLevel_NewLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:SetNavWalkOptLevel", SetNavWalkOptLevel_IsValid);
		SetJumpOffState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetJumpOffState");
		SetJumpOffState_ParamsSize = NativeReflection.GetFunctionParamsSize(SetJumpOffState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetJumpOffState_JumpOff_PropertyAddress, SetJumpOffState_FunctionAddress, "JumpOff");
		SetJumpOffState_JumpOff_Offset = NativeReflectionCached.GetPropertyOffset(SetJumpOffState_FunctionAddress, "JumpOff");
		SetJumpOffState_JumpOff_IsValid = NativeReflectionCached.ValidatePropertyClass(SetJumpOffState_FunctionAddress, "JumpOff", Classes.FBoolProperty);
		SetJumpOffState_IsValid = SetJumpOffState_FunctionAddress != IntPtr.Zero && SetJumpOffState_JumpOff_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:SetJumpOffState", SetJumpOffState_IsValid);
		SetHitMoveIgnoredActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHitMoveIgnoredActor");
		SetHitMoveIgnoredActor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHitMoveIgnoredActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHitMoveIgnoredActor_Actor_PropertyAddress, SetHitMoveIgnoredActor_FunctionAddress, "Actor");
		SetHitMoveIgnoredActor_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetHitMoveIgnoredActor_FunctionAddress, "Actor");
		SetHitMoveIgnoredActor_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHitMoveIgnoredActor_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetHitMoveIgnoredActor_RemoveIgnoredActor_PropertyAddress, SetHitMoveIgnoredActor_FunctionAddress, "RemoveIgnoredActor");
		SetHitMoveIgnoredActor_RemoveIgnoredActor_Offset = NativeReflectionCached.GetPropertyOffset(SetHitMoveIgnoredActor_FunctionAddress, "RemoveIgnoredActor");
		SetHitMoveIgnoredActor_RemoveIgnoredActor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHitMoveIgnoredActor_FunctionAddress, "RemoveIgnoredActor", Classes.FBoolProperty);
		SetHitMoveIgnoredActor_IsValid = SetHitMoveIgnoredActor_FunctionAddress != IntPtr.Zero && SetHitMoveIgnoredActor_Actor_IsValid && SetHitMoveIgnoredActor_RemoveIgnoredActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:SetHitMoveIgnoredActor", SetHitMoveIgnoredActor_IsValid);
		SetHitMoveCollisionEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHitMoveCollisionEnabled");
		SetHitMoveCollisionEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHitMoveCollisionEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHitMoveCollisionEnabled_ShapeComp_PropertyAddress, SetHitMoveCollisionEnabled_FunctionAddress, "ShapeComp");
		SetHitMoveCollisionEnabled_ShapeComp_Offset = NativeReflectionCached.GetPropertyOffset(SetHitMoveCollisionEnabled_FunctionAddress, "ShapeComp");
		SetHitMoveCollisionEnabled_ShapeComp_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHitMoveCollisionEnabled_FunctionAddress, "ShapeComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetHitMoveCollisionEnabled_IsEnabled_PropertyAddress, SetHitMoveCollisionEnabled_FunctionAddress, "IsEnabled");
		SetHitMoveCollisionEnabled_IsEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetHitMoveCollisionEnabled_FunctionAddress, "IsEnabled");
		SetHitMoveCollisionEnabled_IsEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHitMoveCollisionEnabled_FunctionAddress, "IsEnabled", Classes.FBoolProperty);
		SetHitMoveCollisionEnabled_IsValid = SetHitMoveCollisionEnabled_FunctionAddress != IntPtr.Zero && SetHitMoveCollisionEnabled_ShapeComp_IsValid && SetHitMoveCollisionEnabled_IsEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:SetHitMoveCollisionEnabled", SetHitMoveCollisionEnabled_IsValid);
		SetHitMoveCollisionDirection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHitMoveCollisionDirection");
		SetHitMoveCollisionDirection_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHitMoveCollisionDirection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHitMoveCollisionDirection_ShapeComp_PropertyAddress, SetHitMoveCollisionDirection_FunctionAddress, "ShapeComp");
		SetHitMoveCollisionDirection_ShapeComp_Offset = NativeReflectionCached.GetPropertyOffset(SetHitMoveCollisionDirection_FunctionAddress, "ShapeComp");
		SetHitMoveCollisionDirection_ShapeComp_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHitMoveCollisionDirection_FunctionAddress, "ShapeComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetHitMoveCollisionDirection_HitMoveDir_PropertyAddress, SetHitMoveCollisionDirection_FunctionAddress, "HitMoveDir");
		SetHitMoveCollisionDirection_HitMoveDir_Offset = NativeReflectionCached.GetPropertyOffset(SetHitMoveCollisionDirection_FunctionAddress, "HitMoveDir");
		SetHitMoveCollisionDirection_HitMoveDir_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHitMoveCollisionDirection_FunctionAddress, "HitMoveDir", Classes.FEnumProperty);
		SetHitMoveCollisionDirection_IsValid = SetHitMoveCollisionDirection_FunctionAddress != IntPtr.Zero && SetHitMoveCollisionDirection_ShapeComp_IsValid && SetHitMoveCollisionDirection_HitMoveDir_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:SetHitMoveCollisionDirection", SetHitMoveCollisionDirection_IsValid);
		SetGravityToJumpOffGravity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGravityToJumpOffGravity");
		SetGravityToJumpOffGravity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGravityToJumpOffGravity_FunctionAddress);
		SetGravityToJumpOffGravity_IsValid = SetGravityToJumpOffGravity_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:SetGravityToJumpOffGravity", SetGravityToJumpOffGravity_IsValid);
		SetEnableSimplePhysWalkCollision_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEnableSimplePhysWalkCollision");
		SetEnableSimplePhysWalkCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnableSimplePhysWalkCollision_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnableSimplePhysWalkCollision_bEnable_PropertyAddress, SetEnableSimplePhysWalkCollision_FunctionAddress, "bEnable");
		SetEnableSimplePhysWalkCollision_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(SetEnableSimplePhysWalkCollision_FunctionAddress, "bEnable");
		SetEnableSimplePhysWalkCollision_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnableSimplePhysWalkCollision_FunctionAddress, "bEnable", Classes.FBoolProperty);
		SetEnableSimplePhysWalkCollision_IsValid = SetEnableSimplePhysWalkCollision_FunctionAddress != IntPtr.Zero && SetEnableSimplePhysWalkCollision_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:SetEnableSimplePhysWalkCollision", SetEnableSimplePhysWalkCollision_IsValid);
		SetDisableNavWalkOptByWhiteList_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDisableNavWalkOptByWhiteList");
		SetDisableNavWalkOptByWhiteList_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDisableNavWalkOptByWhiteList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDisableNavWalkOptByWhiteList_bDisable_PropertyAddress, SetDisableNavWalkOptByWhiteList_FunctionAddress, "bDisable");
		SetDisableNavWalkOptByWhiteList_bDisable_Offset = NativeReflectionCached.GetPropertyOffset(SetDisableNavWalkOptByWhiteList_FunctionAddress, "bDisable");
		SetDisableNavWalkOptByWhiteList_bDisable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDisableNavWalkOptByWhiteList_FunctionAddress, "bDisable", Classes.FBoolProperty);
		SetDisableNavWalkOptByWhiteList_IsValid = SetDisableNavWalkOptByWhiteList_FunctionAddress != IntPtr.Zero && SetDisableNavWalkOptByWhiteList_bDisable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:SetDisableNavWalkOptByWhiteList", SetDisableNavWalkOptByWhiteList_IsValid);
		SetCustomJumpVelocityIncrement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCustomJumpVelocityIncrement");
		SetCustomJumpVelocityIncrement_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomJumpVelocityIncrement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomJumpVelocityIncrement_VelocityIncrement_PropertyAddress, SetCustomJumpVelocityIncrement_FunctionAddress, "VelocityIncrement");
		SetCustomJumpVelocityIncrement_VelocityIncrement_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomJumpVelocityIncrement_FunctionAddress, "VelocityIncrement");
		SetCustomJumpVelocityIncrement_VelocityIncrement_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomJumpVelocityIncrement_FunctionAddress, "VelocityIncrement", Classes.FFloatProperty);
		SetCustomJumpVelocityIncrement_IsValid = SetCustomJumpVelocityIncrement_FunctionAddress != IntPtr.Zero && SetCustomJumpVelocityIncrement_VelocityIncrement_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:SetCustomJumpVelocityIncrement", SetCustomJumpVelocityIncrement_IsValid);
		ResetGravityToNormalGravity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetGravityToNormalGravity");
		ResetGravityToNormalGravity_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetGravityToNormalGravity_FunctionAddress);
		ResetGravityToNormalGravity_IsValid = ResetGravityToNormalGravity_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:ResetGravityToNormalGravity", ResetGravityToNormalGravity_IsValid);
		MoveUpdateHitMove_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MoveUpdateHitMove");
		MoveUpdateHitMove_ParamsSize = NativeReflection.GetFunctionParamsSize(MoveUpdateHitMove_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MoveUpdateHitMove_Delta_PropertyAddress, MoveUpdateHitMove_FunctionAddress, "Delta");
		MoveUpdateHitMove_Delta_Offset = NativeReflectionCached.GetPropertyOffset(MoveUpdateHitMove_FunctionAddress, "Delta");
		MoveUpdateHitMove_Delta_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveUpdateHitMove_FunctionAddress, "Delta", Classes.FStructProperty);
		MoveUpdateHitMove_IsValid = MoveUpdateHitMove_FunctionAddress != IntPtr.Zero && MoveUpdateHitMove_Delta_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:MoveUpdateHitMove", MoveUpdateHitMove_IsValid);
		LaunchVelocityZ_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LaunchVelocityZ");
		LaunchVelocityZ_ParamsSize = NativeReflection.GetFunctionParamsSize(LaunchVelocityZ_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LaunchVelocityZ_VelocityZ_PropertyAddress, LaunchVelocityZ_FunctionAddress, "VelocityZ");
		LaunchVelocityZ_VelocityZ_Offset = NativeReflectionCached.GetPropertyOffset(LaunchVelocityZ_FunctionAddress, "VelocityZ");
		LaunchVelocityZ_VelocityZ_IsValid = NativeReflectionCached.ValidatePropertyClass(LaunchVelocityZ_FunctionAddress, "VelocityZ", Classes.FFloatProperty);
		LaunchVelocityZ_IsValid = LaunchVelocityZ_FunctionAddress != IntPtr.Zero && LaunchVelocityZ_VelocityZ_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:LaunchVelocityZ", LaunchVelocityZ_IsValid);
		IsWalkOnDitch_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsWalkOnDitch");
		IsWalkOnDitch_ParamsSize = NativeReflection.GetFunctionParamsSize(IsWalkOnDitch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsWalkOnDitch_ReturnValue_PropertyAddress, IsWalkOnDitch_FunctionAddress, "ReturnValue");
		IsWalkOnDitch_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsWalkOnDitch_FunctionAddress, "ReturnValue");
		IsWalkOnDitch_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsWalkOnDitch_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsWalkOnDitch_IsValid = IsWalkOnDitch_FunctionAddress != IntPtr.Zero && IsWalkOnDitch_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:IsWalkOnDitch", IsWalkOnDitch_IsValid);
		IsUseSeparateBrakingFriction_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsUseSeparateBrakingFriction");
		IsUseSeparateBrakingFriction_ParamsSize = NativeReflection.GetFunctionParamsSize(IsUseSeparateBrakingFriction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsUseSeparateBrakingFriction_ReturnValue_PropertyAddress, IsUseSeparateBrakingFriction_FunctionAddress, "ReturnValue");
		IsUseSeparateBrakingFriction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsUseSeparateBrakingFriction_FunctionAddress, "ReturnValue");
		IsUseSeparateBrakingFriction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsUseSeparateBrakingFriction_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsUseSeparateBrakingFriction_IsValid = IsUseSeparateBrakingFriction_FunctionAddress != IntPtr.Zero && IsUseSeparateBrakingFriction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:IsUseSeparateBrakingFriction", IsUseSeparateBrakingFriction_IsValid);
		IsInNavWalkOptMode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsInNavWalkOptMode");
		IsInNavWalkOptMode_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInNavWalkOptMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInNavWalkOptMode_ReturnValue_PropertyAddress, IsInNavWalkOptMode_FunctionAddress, "ReturnValue");
		IsInNavWalkOptMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsInNavWalkOptMode_FunctionAddress, "ReturnValue");
		IsInNavWalkOptMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInNavWalkOptMode_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInNavWalkOptMode_IsValid = IsInNavWalkOptMode_FunctionAddress != IntPtr.Zero && IsInNavWalkOptMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:IsInNavWalkOptMode", IsInNavWalkOptMode_IsValid);
		IsInJumpOffAdjust_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsInJumpOffAdjust");
		IsInJumpOffAdjust_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInJumpOffAdjust_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInJumpOffAdjust_ReturnValue_PropertyAddress, IsInJumpOffAdjust_FunctionAddress, "ReturnValue");
		IsInJumpOffAdjust_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsInJumpOffAdjust_FunctionAddress, "ReturnValue");
		IsInJumpOffAdjust_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInJumpOffAdjust_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInJumpOffAdjust_IsValid = IsInJumpOffAdjust_FunctionAddress != IntPtr.Zero && IsInJumpOffAdjust_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:IsInJumpOffAdjust", IsInJumpOffAdjust_IsValid);
		HitMoveUpdate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HitMoveUpdate");
		HitMoveUpdate_ParamsSize = NativeReflection.GetFunctionParamsSize(HitMoveUpdate_FunctionAddress);
		HitMoveUpdate_IsValid = HitMoveUpdate_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:HitMoveUpdate", HitMoveUpdate_IsValid);
		HasAnimRootMotion_CS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasAnimRootMotion_CS");
		HasAnimRootMotion_CS_ParamsSize = NativeReflection.GetFunctionParamsSize(HasAnimRootMotion_CS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasAnimRootMotion_CS_ReturnValue_PropertyAddress, HasAnimRootMotion_CS_FunctionAddress, "ReturnValue");
		HasAnimRootMotion_CS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasAnimRootMotion_CS_FunctionAddress, "ReturnValue");
		HasAnimRootMotion_CS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAnimRootMotion_CS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasAnimRootMotion_CS_IsValid = HasAnimRootMotion_CS_FunctionAddress != IntPtr.Zero && HasAnimRootMotion_CS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:HasAnimRootMotion_CS", HasAnimRootMotion_CS_IsValid);
		GetTopZInFalling_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTopZInFalling");
		GetTopZInFalling_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTopZInFalling_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTopZInFalling_ReturnValue_PropertyAddress, GetTopZInFalling_FunctionAddress, "ReturnValue");
		GetTopZInFalling_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTopZInFalling_FunctionAddress, "ReturnValue");
		GetTopZInFalling_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTopZInFalling_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetTopZInFalling_IsValid = GetTopZInFalling_FunctionAddress != IntPtr.Zero && GetTopZInFalling_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:GetTopZInFalling", GetTopZInFalling_IsValid);
		GetHitMoveCollisionIsEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetHitMoveCollisionIsEnabled");
		GetHitMoveCollisionIsEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHitMoveCollisionIsEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHitMoveCollisionIsEnabled_ShapeComp_PropertyAddress, GetHitMoveCollisionIsEnabled_FunctionAddress, "ShapeComp");
		GetHitMoveCollisionIsEnabled_ShapeComp_Offset = NativeReflectionCached.GetPropertyOffset(GetHitMoveCollisionIsEnabled_FunctionAddress, "ShapeComp");
		GetHitMoveCollisionIsEnabled_ShapeComp_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitMoveCollisionIsEnabled_FunctionAddress, "ShapeComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHitMoveCollisionIsEnabled_IsEnabled_PropertyAddress, GetHitMoveCollisionIsEnabled_FunctionAddress, "IsEnabled");
		GetHitMoveCollisionIsEnabled_IsEnabled_Offset = NativeReflectionCached.GetPropertyOffset(GetHitMoveCollisionIsEnabled_FunctionAddress, "IsEnabled");
		GetHitMoveCollisionIsEnabled_IsEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitMoveCollisionIsEnabled_FunctionAddress, "IsEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHitMoveCollisionIsEnabled_ReturnValue_PropertyAddress, GetHitMoveCollisionIsEnabled_FunctionAddress, "ReturnValue");
		GetHitMoveCollisionIsEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHitMoveCollisionIsEnabled_FunctionAddress, "ReturnValue");
		GetHitMoveCollisionIsEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitMoveCollisionIsEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetHitMoveCollisionIsEnabled_IsValid = GetHitMoveCollisionIsEnabled_FunctionAddress != IntPtr.Zero && GetHitMoveCollisionIsEnabled_ShapeComp_IsValid && GetHitMoveCollisionIsEnabled_IsEnabled_IsValid && GetHitMoveCollisionIsEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:GetHitMoveCollisionIsEnabled", GetHitMoveCollisionIsEnabled_IsValid);
		CustomJumpMoveBreak_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CustomJumpMoveBreak");
		CustomJumpMoveBreak_ParamsSize = NativeReflection.GetFunctionParamsSize(CustomJumpMoveBreak_FunctionAddress);
		CustomJumpMoveBreak_IsValid = CustomJumpMoveBreak_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:CustomJumpMoveBreak", CustomJumpMoveBreak_IsValid);
		ClearTopZInFalling_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearTopZInFalling");
		ClearTopZInFalling_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearTopZInFalling_FunctionAddress);
		ClearTopZInFalling_IsValid = ClearTopZInFalling_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:ClearTopZInFalling", ClearTopZInFalling_IsValid);
		ClearHitMoveCollisions_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearHitMoveCollisions");
		ClearHitMoveCollisions_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearHitMoveCollisions_FunctionAddress);
		ClearHitMoveCollisions_IsValid = ClearHitMoveCollisions_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:ClearHitMoveCollisions", ClearHitMoveCollisions_IsValid);
		CanGetNormalAndSurfaceTypeInfoFromMovement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CanGetNormalAndSurfaceTypeInfoFromMovement");
		CanGetNormalAndSurfaceTypeInfoFromMovement_ParamsSize = NativeReflection.GetFunctionParamsSize(CanGetNormalAndSurfaceTypeInfoFromMovement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanGetNormalAndSurfaceTypeInfoFromMovement_ReturnValue_PropertyAddress, CanGetNormalAndSurfaceTypeInfoFromMovement_FunctionAddress, "ReturnValue");
		CanGetNormalAndSurfaceTypeInfoFromMovement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanGetNormalAndSurfaceTypeInfoFromMovement_FunctionAddress, "ReturnValue");
		CanGetNormalAndSurfaceTypeInfoFromMovement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanGetNormalAndSurfaceTypeInfoFromMovement_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanGetNormalAndSurfaceTypeInfoFromMovement_IsValid = CanGetNormalAndSurfaceTypeInfoFromMovement_FunctionAddress != IntPtr.Zero && CanGetNormalAndSurfaceTypeInfoFromMovement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:CanGetNormalAndSurfaceTypeInfoFromMovement", CanGetNormalAndSurfaceTypeInfoFromMovement_IsValid);
		AddOrModifyHitMoveCollision_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddOrModifyHitMoveCollision");
		AddOrModifyHitMoveCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(AddOrModifyHitMoveCollision_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddOrModifyHitMoveCollision_ShapeComp_PropertyAddress, AddOrModifyHitMoveCollision_FunctionAddress, "ShapeComp");
		AddOrModifyHitMoveCollision_ShapeComp_Offset = NativeReflectionCached.GetPropertyOffset(AddOrModifyHitMoveCollision_FunctionAddress, "ShapeComp");
		AddOrModifyHitMoveCollision_ShapeComp_IsValid = NativeReflectionCached.ValidatePropertyClass(AddOrModifyHitMoveCollision_FunctionAddress, "ShapeComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddOrModifyHitMoveCollision_HitMoveDir_PropertyAddress, AddOrModifyHitMoveCollision_FunctionAddress, "HitMoveDir");
		AddOrModifyHitMoveCollision_HitMoveDir_Offset = NativeReflectionCached.GetPropertyOffset(AddOrModifyHitMoveCollision_FunctionAddress, "HitMoveDir");
		AddOrModifyHitMoveCollision_HitMoveDir_IsValid = NativeReflectionCached.ValidatePropertyClass(AddOrModifyHitMoveCollision_FunctionAddress, "HitMoveDir", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AddOrModifyHitMoveCollision_IsEnabled_PropertyAddress, AddOrModifyHitMoveCollision_FunctionAddress, "IsEnabled");
		AddOrModifyHitMoveCollision_IsEnabled_Offset = NativeReflectionCached.GetPropertyOffset(AddOrModifyHitMoveCollision_FunctionAddress, "IsEnabled");
		AddOrModifyHitMoveCollision_IsEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(AddOrModifyHitMoveCollision_FunctionAddress, "IsEnabled", Classes.FBoolProperty);
		AddOrModifyHitMoveCollision_IsValid = AddOrModifyHitMoveCollision_FunctionAddress != IntPtr.Zero && AddOrModifyHitMoveCollision_ShapeComp_IsValid && AddOrModifyHitMoveCollision_HitMoveDir_IsValid && AddOrModifyHitMoveCollision_IsEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacterMovementComponent:AddOrModifyHitMoveCollision", AddOrModifyHitMoveCollision_IsValid);
	}
}
