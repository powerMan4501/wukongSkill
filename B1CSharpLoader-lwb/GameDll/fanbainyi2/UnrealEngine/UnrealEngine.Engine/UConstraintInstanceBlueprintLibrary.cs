using System;
using System.Runtime.CompilerServices;
using UnrealEngine.PhysicsCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary", "Engine", UnrealModuleType.Engine)]
public class UConstraintInstanceBlueprintLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetProjectionParams_IsValid;

	private static IntPtr SetProjectionParams_FunctionAddress;

	private static int SetProjectionParams_ParamsSize;

	private static bool SetProjectionParams_Accessor_IsValid;

	private static FFieldAddress SetProjectionParams_Accessor_PropertyAddress;

	private static int SetProjectionParams_Accessor_Offset;

	private static bool SetProjectionParams_bEnableProjection_IsValid;

	private static FFieldAddress SetProjectionParams_bEnableProjection_PropertyAddress;

	private static int SetProjectionParams_bEnableProjection_Offset;

	private static bool SetProjectionParams_ProjectionLinearAlpha_IsValid;

	private static FFieldAddress SetProjectionParams_ProjectionLinearAlpha_PropertyAddress;

	private static int SetProjectionParams_ProjectionLinearAlpha_Offset;

	private static bool SetProjectionParams_ProjectionAngularAlpha_IsValid;

	private static FFieldAddress SetProjectionParams_ProjectionAngularAlpha_PropertyAddress;

	private static int SetProjectionParams_ProjectionAngularAlpha_Offset;

	private static bool SetParentDominates_IsValid;

	private static IntPtr SetParentDominates_FunctionAddress;

	private static int SetParentDominates_ParamsSize;

	private static bool SetParentDominates_Accessor_IsValid;

	private static FFieldAddress SetParentDominates_Accessor_PropertyAddress;

	private static int SetParentDominates_Accessor_Offset;

	private static bool SetParentDominates_bParentDominates_IsValid;

	private static FFieldAddress SetParentDominates_bParentDominates_PropertyAddress;

	private static int SetParentDominates_bParentDominates_Offset;

	private static bool SetOrientationDriveTwistAndSwing_IsValid;

	private static IntPtr SetOrientationDriveTwistAndSwing_FunctionAddress;

	private static int SetOrientationDriveTwistAndSwing_ParamsSize;

	private static bool SetOrientationDriveTwistAndSwing_Accessor_IsValid;

	private static FFieldAddress SetOrientationDriveTwistAndSwing_Accessor_PropertyAddress;

	private static int SetOrientationDriveTwistAndSwing_Accessor_Offset;

	private static bool SetOrientationDriveTwistAndSwing_bEnableTwistDrive_IsValid;

	private static FFieldAddress SetOrientationDriveTwistAndSwing_bEnableTwistDrive_PropertyAddress;

	private static int SetOrientationDriveTwistAndSwing_bEnableTwistDrive_Offset;

	private static bool SetOrientationDriveTwistAndSwing_bEnableSwingDrive_IsValid;

	private static FFieldAddress SetOrientationDriveTwistAndSwing_bEnableSwingDrive_PropertyAddress;

	private static int SetOrientationDriveTwistAndSwing_bEnableSwingDrive_Offset;

	private static bool SetOrientationDriveSLERP_IsValid;

	private static IntPtr SetOrientationDriveSLERP_FunctionAddress;

	private static int SetOrientationDriveSLERP_ParamsSize;

	private static bool SetOrientationDriveSLERP_Accessor_IsValid;

	private static FFieldAddress SetOrientationDriveSLERP_Accessor_PropertyAddress;

	private static int SetOrientationDriveSLERP_Accessor_Offset;

	private static bool SetOrientationDriveSLERP_bEnableSLERP_IsValid;

	private static FFieldAddress SetOrientationDriveSLERP_bEnableSLERP_PropertyAddress;

	private static int SetOrientationDriveSLERP_bEnableSLERP_Offset;

	private static bool SetLinearVelocityTarget_IsValid;

	private static IntPtr SetLinearVelocityTarget_FunctionAddress;

	private static int SetLinearVelocityTarget_ParamsSize;

	private static bool SetLinearVelocityTarget_Accessor_IsValid;

	private static FFieldAddress SetLinearVelocityTarget_Accessor_PropertyAddress;

	private static int SetLinearVelocityTarget_Accessor_Offset;

	private static bool SetLinearVelocityTarget_InVelTarget_IsValid;

	private static FFieldAddress SetLinearVelocityTarget_InVelTarget_PropertyAddress;

	private static int SetLinearVelocityTarget_InVelTarget_Offset;

	private static bool SetLinearVelocityDrive_IsValid;

	private static IntPtr SetLinearVelocityDrive_FunctionAddress;

	private static int SetLinearVelocityDrive_ParamsSize;

	private static bool SetLinearVelocityDrive_Accessor_IsValid;

	private static FFieldAddress SetLinearVelocityDrive_Accessor_PropertyAddress;

	private static int SetLinearVelocityDrive_Accessor_Offset;

	private static bool SetLinearVelocityDrive_bEnableDriveX_IsValid;

	private static FFieldAddress SetLinearVelocityDrive_bEnableDriveX_PropertyAddress;

	private static int SetLinearVelocityDrive_bEnableDriveX_Offset;

	private static bool SetLinearVelocityDrive_bEnableDriveY_IsValid;

	private static FFieldAddress SetLinearVelocityDrive_bEnableDriveY_PropertyAddress;

	private static int SetLinearVelocityDrive_bEnableDriveY_Offset;

	private static bool SetLinearVelocityDrive_bEnableDriveZ_IsValid;

	private static FFieldAddress SetLinearVelocityDrive_bEnableDriveZ_PropertyAddress;

	private static int SetLinearVelocityDrive_bEnableDriveZ_Offset;

	private static bool SetLinearSoftLimitParams_IsValid;

	private static IntPtr SetLinearSoftLimitParams_FunctionAddress;

	private static int SetLinearSoftLimitParams_ParamsSize;

	private static bool SetLinearSoftLimitParams_Accessor_IsValid;

	private static FFieldAddress SetLinearSoftLimitParams_Accessor_PropertyAddress;

	private static int SetLinearSoftLimitParams_Accessor_Offset;

	private static bool SetLinearSoftLimitParams_bSoftLinearLimit_IsValid;

	private static FFieldAddress SetLinearSoftLimitParams_bSoftLinearLimit_PropertyAddress;

	private static int SetLinearSoftLimitParams_bSoftLinearLimit_Offset;

	private static bool SetLinearSoftLimitParams_LinearLimitStiffness_IsValid;

	private static FFieldAddress SetLinearSoftLimitParams_LinearLimitStiffness_PropertyAddress;

	private static int SetLinearSoftLimitParams_LinearLimitStiffness_Offset;

	private static bool SetLinearSoftLimitParams_LinearLimitDamping_IsValid;

	private static FFieldAddress SetLinearSoftLimitParams_LinearLimitDamping_PropertyAddress;

	private static int SetLinearSoftLimitParams_LinearLimitDamping_Offset;

	private static bool SetLinearSoftLimitParams_LinearLimitRestitution_IsValid;

	private static FFieldAddress SetLinearSoftLimitParams_LinearLimitRestitution_PropertyAddress;

	private static int SetLinearSoftLimitParams_LinearLimitRestitution_Offset;

	private static bool SetLinearSoftLimitParams_LinearLimitContactDistance_IsValid;

	private static FFieldAddress SetLinearSoftLimitParams_LinearLimitContactDistance_PropertyAddress;

	private static int SetLinearSoftLimitParams_LinearLimitContactDistance_Offset;

	private static bool SetLinearPositionTarget_IsValid;

	private static IntPtr SetLinearPositionTarget_FunctionAddress;

	private static int SetLinearPositionTarget_ParamsSize;

	private static bool SetLinearPositionTarget_Accessor_IsValid;

	private static FFieldAddress SetLinearPositionTarget_Accessor_PropertyAddress;

	private static int SetLinearPositionTarget_Accessor_Offset;

	private static bool SetLinearPositionTarget_InPosTarget_IsValid;

	private static FFieldAddress SetLinearPositionTarget_InPosTarget_PropertyAddress;

	private static int SetLinearPositionTarget_InPosTarget_Offset;

	private static bool SetLinearPositionDrive_IsValid;

	private static IntPtr SetLinearPositionDrive_FunctionAddress;

	private static int SetLinearPositionDrive_ParamsSize;

	private static bool SetLinearPositionDrive_Accessor_IsValid;

	private static FFieldAddress SetLinearPositionDrive_Accessor_PropertyAddress;

	private static int SetLinearPositionDrive_Accessor_Offset;

	private static bool SetLinearPositionDrive_bEnableDriveX_IsValid;

	private static FFieldAddress SetLinearPositionDrive_bEnableDriveX_PropertyAddress;

	private static int SetLinearPositionDrive_bEnableDriveX_Offset;

	private static bool SetLinearPositionDrive_bEnableDriveY_IsValid;

	private static FFieldAddress SetLinearPositionDrive_bEnableDriveY_PropertyAddress;

	private static int SetLinearPositionDrive_bEnableDriveY_Offset;

	private static bool SetLinearPositionDrive_bEnableDriveZ_IsValid;

	private static FFieldAddress SetLinearPositionDrive_bEnableDriveZ_PropertyAddress;

	private static int SetLinearPositionDrive_bEnableDriveZ_Offset;

	private static bool SetLinearPlasticity_IsValid;

	private static IntPtr SetLinearPlasticity_FunctionAddress;

	private static int SetLinearPlasticity_ParamsSize;

	private static bool SetLinearPlasticity_Accessor_IsValid;

	private static FFieldAddress SetLinearPlasticity_Accessor_PropertyAddress;

	private static int SetLinearPlasticity_Accessor_Offset;

	private static bool SetLinearPlasticity_bLinearPlasticity_IsValid;

	private static FFieldAddress SetLinearPlasticity_bLinearPlasticity_PropertyAddress;

	private static int SetLinearPlasticity_bLinearPlasticity_Offset;

	private static bool SetLinearPlasticity_LinearPlasticityThreshold_IsValid;

	private static FFieldAddress SetLinearPlasticity_LinearPlasticityThreshold_PropertyAddress;

	private static int SetLinearPlasticity_LinearPlasticityThreshold_Offset;

	private static bool SetLinearPlasticity_PlasticityType_IsValid;

	private static FFieldAddress SetLinearPlasticity_PlasticityType_PropertyAddress;

	private static int SetLinearPlasticity_PlasticityType_Offset;

	private static bool SetLinearLimits_IsValid;

	private static IntPtr SetLinearLimits_FunctionAddress;

	private static int SetLinearLimits_ParamsSize;

	private static bool SetLinearLimits_Accessor_IsValid;

	private static FFieldAddress SetLinearLimits_Accessor_PropertyAddress;

	private static int SetLinearLimits_Accessor_Offset;

	private static bool SetLinearLimits_XMotion_IsValid;

	private static FFieldAddress SetLinearLimits_XMotion_PropertyAddress;

	private static int SetLinearLimits_XMotion_Offset;

	private static bool SetLinearLimits_YMotion_IsValid;

	private static FFieldAddress SetLinearLimits_YMotion_PropertyAddress;

	private static int SetLinearLimits_YMotion_Offset;

	private static bool SetLinearLimits_ZMotion_IsValid;

	private static FFieldAddress SetLinearLimits_ZMotion_PropertyAddress;

	private static int SetLinearLimits_ZMotion_Offset;

	private static bool SetLinearLimits_Limit_IsValid;

	private static FFieldAddress SetLinearLimits_Limit_PropertyAddress;

	private static int SetLinearLimits_Limit_Offset;

	private static bool SetLinearDriveParams_IsValid;

	private static IntPtr SetLinearDriveParams_FunctionAddress;

	private static int SetLinearDriveParams_ParamsSize;

	private static bool SetLinearDriveParams_Accessor_IsValid;

	private static FFieldAddress SetLinearDriveParams_Accessor_PropertyAddress;

	private static int SetLinearDriveParams_Accessor_Offset;

	private static bool SetLinearDriveParams_PositionStrength_IsValid;

	private static FFieldAddress SetLinearDriveParams_PositionStrength_PropertyAddress;

	private static int SetLinearDriveParams_PositionStrength_Offset;

	private static bool SetLinearDriveParams_VelocityStrength_IsValid;

	private static FFieldAddress SetLinearDriveParams_VelocityStrength_PropertyAddress;

	private static int SetLinearDriveParams_VelocityStrength_Offset;

	private static bool SetLinearDriveParams_InForceLimit_IsValid;

	private static FFieldAddress SetLinearDriveParams_InForceLimit_PropertyAddress;

	private static int SetLinearDriveParams_InForceLimit_Offset;

	private static bool SetLinearBreakable_IsValid;

	private static IntPtr SetLinearBreakable_FunctionAddress;

	private static int SetLinearBreakable_ParamsSize;

	private static bool SetLinearBreakable_Accessor_IsValid;

	private static FFieldAddress SetLinearBreakable_Accessor_PropertyAddress;

	private static int SetLinearBreakable_Accessor_Offset;

	private static bool SetLinearBreakable_bLinearBreakable_IsValid;

	private static FFieldAddress SetLinearBreakable_bLinearBreakable_PropertyAddress;

	private static int SetLinearBreakable_bLinearBreakable_Offset;

	private static bool SetLinearBreakable_LinearBreakThreshold_IsValid;

	private static FFieldAddress SetLinearBreakable_LinearBreakThreshold_PropertyAddress;

	private static int SetLinearBreakable_LinearBreakThreshold_Offset;

	private static bool SetDisableCollision_IsValid;

	private static IntPtr SetDisableCollision_FunctionAddress;

	private static int SetDisableCollision_ParamsSize;

	private static bool SetDisableCollision_Accessor_IsValid;

	private static FFieldAddress SetDisableCollision_Accessor_PropertyAddress;

	private static int SetDisableCollision_Accessor_Offset;

	private static bool SetDisableCollision_bDisableCollision_IsValid;

	private static FFieldAddress SetDisableCollision_bDisableCollision_PropertyAddress;

	private static int SetDisableCollision_bDisableCollision_Offset;

	private static bool SetContactTransferScale_IsValid;

	private static IntPtr SetContactTransferScale_FunctionAddress;

	private static int SetContactTransferScale_ParamsSize;

	private static bool SetContactTransferScale_Accessor_IsValid;

	private static FFieldAddress SetContactTransferScale_Accessor_PropertyAddress;

	private static int SetContactTransferScale_Accessor_Offset;

	private static bool SetContactTransferScale_ContactTransferScale_IsValid;

	private static FFieldAddress SetContactTransferScale_ContactTransferScale_PropertyAddress;

	private static int SetContactTransferScale_ContactTransferScale_Offset;

	private static bool SetAngularVelocityTarget_IsValid;

	private static IntPtr SetAngularVelocityTarget_FunctionAddress;

	private static int SetAngularVelocityTarget_ParamsSize;

	private static bool SetAngularVelocityTarget_Accessor_IsValid;

	private static FFieldAddress SetAngularVelocityTarget_Accessor_PropertyAddress;

	private static int SetAngularVelocityTarget_Accessor_Offset;

	private static bool SetAngularVelocityTarget_InVelTarget_IsValid;

	private static FFieldAddress SetAngularVelocityTarget_InVelTarget_PropertyAddress;

	private static int SetAngularVelocityTarget_InVelTarget_Offset;

	private static bool SetAngularVelocityDriveTwistAndSwing_IsValid;

	private static IntPtr SetAngularVelocityDriveTwistAndSwing_FunctionAddress;

	private static int SetAngularVelocityDriveTwistAndSwing_ParamsSize;

	private static bool SetAngularVelocityDriveTwistAndSwing_Accessor_IsValid;

	private static FFieldAddress SetAngularVelocityDriveTwistAndSwing_Accessor_PropertyAddress;

	private static int SetAngularVelocityDriveTwistAndSwing_Accessor_Offset;

	private static bool SetAngularVelocityDriveTwistAndSwing_bEnableTwistDrive_IsValid;

	private static FFieldAddress SetAngularVelocityDriveTwistAndSwing_bEnableTwistDrive_PropertyAddress;

	private static int SetAngularVelocityDriveTwistAndSwing_bEnableTwistDrive_Offset;

	private static bool SetAngularVelocityDriveTwistAndSwing_bEnableSwingDrive_IsValid;

	private static FFieldAddress SetAngularVelocityDriveTwistAndSwing_bEnableSwingDrive_PropertyAddress;

	private static int SetAngularVelocityDriveTwistAndSwing_bEnableSwingDrive_Offset;

	private static bool SetAngularVelocityDriveSLERP_IsValid;

	private static IntPtr SetAngularVelocityDriveSLERP_FunctionAddress;

	private static int SetAngularVelocityDriveSLERP_ParamsSize;

	private static bool SetAngularVelocityDriveSLERP_Accessor_IsValid;

	private static FFieldAddress SetAngularVelocityDriveSLERP_Accessor_PropertyAddress;

	private static int SetAngularVelocityDriveSLERP_Accessor_Offset;

	private static bool SetAngularVelocityDriveSLERP_bEnableSLERP_IsValid;

	private static FFieldAddress SetAngularVelocityDriveSLERP_bEnableSLERP_PropertyAddress;

	private static int SetAngularVelocityDriveSLERP_bEnableSLERP_Offset;

	private static bool SetAngularSoftTwistLimitParams_IsValid;

	private static IntPtr SetAngularSoftTwistLimitParams_FunctionAddress;

	private static int SetAngularSoftTwistLimitParams_ParamsSize;

	private static bool SetAngularSoftTwistLimitParams_Accessor_IsValid;

	private static FFieldAddress SetAngularSoftTwistLimitParams_Accessor_PropertyAddress;

	private static int SetAngularSoftTwistLimitParams_Accessor_Offset;

	private static bool SetAngularSoftTwistLimitParams_bSoftTwistLimit_IsValid;

	private static FFieldAddress SetAngularSoftTwistLimitParams_bSoftTwistLimit_PropertyAddress;

	private static int SetAngularSoftTwistLimitParams_bSoftTwistLimit_Offset;

	private static bool SetAngularSoftTwistLimitParams_TwistLimitStiffness_IsValid;

	private static FFieldAddress SetAngularSoftTwistLimitParams_TwistLimitStiffness_PropertyAddress;

	private static int SetAngularSoftTwistLimitParams_TwistLimitStiffness_Offset;

	private static bool SetAngularSoftTwistLimitParams_TwistLimitDamping_IsValid;

	private static FFieldAddress SetAngularSoftTwistLimitParams_TwistLimitDamping_PropertyAddress;

	private static int SetAngularSoftTwistLimitParams_TwistLimitDamping_Offset;

	private static bool SetAngularSoftTwistLimitParams_TwistLimitRestitution_IsValid;

	private static FFieldAddress SetAngularSoftTwistLimitParams_TwistLimitRestitution_PropertyAddress;

	private static int SetAngularSoftTwistLimitParams_TwistLimitRestitution_Offset;

	private static bool SetAngularSoftTwistLimitParams_TwistLimitContactDistance_IsValid;

	private static FFieldAddress SetAngularSoftTwistLimitParams_TwistLimitContactDistance_PropertyAddress;

	private static int SetAngularSoftTwistLimitParams_TwistLimitContactDistance_Offset;

	private static bool SetAngularSoftSwingLimitParams_IsValid;

	private static IntPtr SetAngularSoftSwingLimitParams_FunctionAddress;

	private static int SetAngularSoftSwingLimitParams_ParamsSize;

	private static bool SetAngularSoftSwingLimitParams_Accessor_IsValid;

	private static FFieldAddress SetAngularSoftSwingLimitParams_Accessor_PropertyAddress;

	private static int SetAngularSoftSwingLimitParams_Accessor_Offset;

	private static bool SetAngularSoftSwingLimitParams_bSoftSwingLimit_IsValid;

	private static FFieldAddress SetAngularSoftSwingLimitParams_bSoftSwingLimit_PropertyAddress;

	private static int SetAngularSoftSwingLimitParams_bSoftSwingLimit_Offset;

	private static bool SetAngularSoftSwingLimitParams_SwingLimitStiffness_IsValid;

	private static FFieldAddress SetAngularSoftSwingLimitParams_SwingLimitStiffness_PropertyAddress;

	private static int SetAngularSoftSwingLimitParams_SwingLimitStiffness_Offset;

	private static bool SetAngularSoftSwingLimitParams_SwingLimitDamping_IsValid;

	private static FFieldAddress SetAngularSoftSwingLimitParams_SwingLimitDamping_PropertyAddress;

	private static int SetAngularSoftSwingLimitParams_SwingLimitDamping_Offset;

	private static bool SetAngularSoftSwingLimitParams_SwingLimitRestitution_IsValid;

	private static FFieldAddress SetAngularSoftSwingLimitParams_SwingLimitRestitution_PropertyAddress;

	private static int SetAngularSoftSwingLimitParams_SwingLimitRestitution_Offset;

	private static bool SetAngularSoftSwingLimitParams_SwingLimitContactDistance_IsValid;

	private static FFieldAddress SetAngularSoftSwingLimitParams_SwingLimitContactDistance_PropertyAddress;

	private static int SetAngularSoftSwingLimitParams_SwingLimitContactDistance_Offset;

	private static bool SetAngularPlasticity_IsValid;

	private static IntPtr SetAngularPlasticity_FunctionAddress;

	private static int SetAngularPlasticity_ParamsSize;

	private static bool SetAngularPlasticity_Accessor_IsValid;

	private static FFieldAddress SetAngularPlasticity_Accessor_PropertyAddress;

	private static int SetAngularPlasticity_Accessor_Offset;

	private static bool SetAngularPlasticity_bAngularPlasticity_IsValid;

	private static FFieldAddress SetAngularPlasticity_bAngularPlasticity_PropertyAddress;

	private static int SetAngularPlasticity_bAngularPlasticity_Offset;

	private static bool SetAngularPlasticity_AngularPlasticityThreshold_IsValid;

	private static FFieldAddress SetAngularPlasticity_AngularPlasticityThreshold_PropertyAddress;

	private static int SetAngularPlasticity_AngularPlasticityThreshold_Offset;

	private static bool SetAngularOrientationTarget_IsValid;

	private static IntPtr SetAngularOrientationTarget_FunctionAddress;

	private static int SetAngularOrientationTarget_ParamsSize;

	private static bool SetAngularOrientationTarget_Accessor_IsValid;

	private static FFieldAddress SetAngularOrientationTarget_Accessor_PropertyAddress;

	private static int SetAngularOrientationTarget_Accessor_Offset;

	private static bool SetAngularOrientationTarget_InPosTarget_IsValid;

	private static FFieldAddress SetAngularOrientationTarget_InPosTarget_PropertyAddress;

	private static int SetAngularOrientationTarget_InPosTarget_Offset;

	private static bool SetAngularLimits_IsValid;

	private static IntPtr SetAngularLimits_FunctionAddress;

	private static int SetAngularLimits_ParamsSize;

	private static bool SetAngularLimits_Accessor_IsValid;

	private static FFieldAddress SetAngularLimits_Accessor_PropertyAddress;

	private static int SetAngularLimits_Accessor_Offset;

	private static bool SetAngularLimits_Swing1MotionType_IsValid;

	private static FFieldAddress SetAngularLimits_Swing1MotionType_PropertyAddress;

	private static int SetAngularLimits_Swing1MotionType_Offset;

	private static bool SetAngularLimits_Swing1LimitAngle_IsValid;

	private static FFieldAddress SetAngularLimits_Swing1LimitAngle_PropertyAddress;

	private static int SetAngularLimits_Swing1LimitAngle_Offset;

	private static bool SetAngularLimits_Swing2MotionType_IsValid;

	private static FFieldAddress SetAngularLimits_Swing2MotionType_PropertyAddress;

	private static int SetAngularLimits_Swing2MotionType_Offset;

	private static bool SetAngularLimits_Swing2LimitAngle_IsValid;

	private static FFieldAddress SetAngularLimits_Swing2LimitAngle_PropertyAddress;

	private static int SetAngularLimits_Swing2LimitAngle_Offset;

	private static bool SetAngularLimits_TwistMotionType_IsValid;

	private static FFieldAddress SetAngularLimits_TwistMotionType_PropertyAddress;

	private static int SetAngularLimits_TwistMotionType_Offset;

	private static bool SetAngularLimits_TwistLimitAngle_IsValid;

	private static FFieldAddress SetAngularLimits_TwistLimitAngle_PropertyAddress;

	private static int SetAngularLimits_TwistLimitAngle_Offset;

	private static bool SetAngularDriveParams_IsValid;

	private static IntPtr SetAngularDriveParams_FunctionAddress;

	private static int SetAngularDriveParams_ParamsSize;

	private static bool SetAngularDriveParams_Accessor_IsValid;

	private static FFieldAddress SetAngularDriveParams_Accessor_PropertyAddress;

	private static int SetAngularDriveParams_Accessor_Offset;

	private static bool SetAngularDriveParams_PositionStrength_IsValid;

	private static FFieldAddress SetAngularDriveParams_PositionStrength_PropertyAddress;

	private static int SetAngularDriveParams_PositionStrength_Offset;

	private static bool SetAngularDriveParams_VelocityStrength_IsValid;

	private static FFieldAddress SetAngularDriveParams_VelocityStrength_PropertyAddress;

	private static int SetAngularDriveParams_VelocityStrength_Offset;

	private static bool SetAngularDriveParams_InForceLimit_IsValid;

	private static FFieldAddress SetAngularDriveParams_InForceLimit_PropertyAddress;

	private static int SetAngularDriveParams_InForceLimit_Offset;

	private static bool SetAngularDriveMode_IsValid;

	private static IntPtr SetAngularDriveMode_FunctionAddress;

	private static int SetAngularDriveMode_ParamsSize;

	private static bool SetAngularDriveMode_Accessor_IsValid;

	private static FFieldAddress SetAngularDriveMode_Accessor_PropertyAddress;

	private static int SetAngularDriveMode_Accessor_Offset;

	private static bool SetAngularDriveMode_DriveMode_IsValid;

	private static FFieldAddress SetAngularDriveMode_DriveMode_PropertyAddress;

	private static int SetAngularDriveMode_DriveMode_Offset;

	private static bool SetAngularBreakable_IsValid;

	private static IntPtr SetAngularBreakable_FunctionAddress;

	private static int SetAngularBreakable_ParamsSize;

	private static bool SetAngularBreakable_Accessor_IsValid;

	private static FFieldAddress SetAngularBreakable_Accessor_PropertyAddress;

	private static int SetAngularBreakable_Accessor_Offset;

	private static bool SetAngularBreakable_bAngularBreakable_IsValid;

	private static FFieldAddress SetAngularBreakable_bAngularBreakable_PropertyAddress;

	private static int SetAngularBreakable_bAngularBreakable_Offset;

	private static bool SetAngularBreakable_AngularBreakThreshold_IsValid;

	private static FFieldAddress SetAngularBreakable_AngularBreakThreshold_PropertyAddress;

	private static int SetAngularBreakable_AngularBreakThreshold_Offset;

	private static bool GetProjectionParams_IsValid;

	private static IntPtr GetProjectionParams_FunctionAddress;

	private static int GetProjectionParams_ParamsSize;

	private static bool GetProjectionParams_Accessor_IsValid;

	private static FFieldAddress GetProjectionParams_Accessor_PropertyAddress;

	private static int GetProjectionParams_Accessor_Offset;

	private static bool GetProjectionParams_bEnableProjection_IsValid;

	private static FFieldAddress GetProjectionParams_bEnableProjection_PropertyAddress;

	private static int GetProjectionParams_bEnableProjection_Offset;

	private static bool GetProjectionParams_ProjectionLinearAlpha_IsValid;

	private static FFieldAddress GetProjectionParams_ProjectionLinearAlpha_PropertyAddress;

	private static int GetProjectionParams_ProjectionLinearAlpha_Offset;

	private static bool GetProjectionParams_ProjectionAngularAlpha_IsValid;

	private static FFieldAddress GetProjectionParams_ProjectionAngularAlpha_PropertyAddress;

	private static int GetProjectionParams_ProjectionAngularAlpha_Offset;

	private static bool GetParentDominates_IsValid;

	private static IntPtr GetParentDominates_FunctionAddress;

	private static int GetParentDominates_ParamsSize;

	private static bool GetParentDominates_Accessor_IsValid;

	private static FFieldAddress GetParentDominates_Accessor_PropertyAddress;

	private static int GetParentDominates_Accessor_Offset;

	private static bool GetParentDominates_ReturnValue_IsValid;

	private static FFieldAddress GetParentDominates_ReturnValue_PropertyAddress;

	private static int GetParentDominates_ReturnValue_Offset;

	private static bool GetOrientationDriveTwistAndSwing_IsValid;

	private static IntPtr GetOrientationDriveTwistAndSwing_FunctionAddress;

	private static int GetOrientationDriveTwistAndSwing_ParamsSize;

	private static bool GetOrientationDriveTwistAndSwing_Accessor_IsValid;

	private static FFieldAddress GetOrientationDriveTwistAndSwing_Accessor_PropertyAddress;

	private static int GetOrientationDriveTwistAndSwing_Accessor_Offset;

	private static bool GetOrientationDriveTwistAndSwing_bOutEnableTwistDrive_IsValid;

	private static FFieldAddress GetOrientationDriveTwistAndSwing_bOutEnableTwistDrive_PropertyAddress;

	private static int GetOrientationDriveTwistAndSwing_bOutEnableTwistDrive_Offset;

	private static bool GetOrientationDriveTwistAndSwing_bOutEnableSwingDrive_IsValid;

	private static FFieldAddress GetOrientationDriveTwistAndSwing_bOutEnableSwingDrive_PropertyAddress;

	private static int GetOrientationDriveTwistAndSwing_bOutEnableSwingDrive_Offset;

	private static bool GetOrientationDriveSLERP_IsValid;

	private static IntPtr GetOrientationDriveSLERP_FunctionAddress;

	private static int GetOrientationDriveSLERP_ParamsSize;

	private static bool GetOrientationDriveSLERP_Accessor_IsValid;

	private static FFieldAddress GetOrientationDriveSLERP_Accessor_PropertyAddress;

	private static int GetOrientationDriveSLERP_Accessor_Offset;

	private static bool GetOrientationDriveSLERP_bOutEnableSLERP_IsValid;

	private static FFieldAddress GetOrientationDriveSLERP_bOutEnableSLERP_PropertyAddress;

	private static int GetOrientationDriveSLERP_bOutEnableSLERP_Offset;

	private static bool GetLinearVelocityTarget_IsValid;

	private static IntPtr GetLinearVelocityTarget_FunctionAddress;

	private static int GetLinearVelocityTarget_ParamsSize;

	private static bool GetLinearVelocityTarget_Accessor_IsValid;

	private static FFieldAddress GetLinearVelocityTarget_Accessor_PropertyAddress;

	private static int GetLinearVelocityTarget_Accessor_Offset;

	private static bool GetLinearVelocityTarget_OutVelTarget_IsValid;

	private static FFieldAddress GetLinearVelocityTarget_OutVelTarget_PropertyAddress;

	private static int GetLinearVelocityTarget_OutVelTarget_Offset;

	private static bool GetLinearVelocityDrive_IsValid;

	private static IntPtr GetLinearVelocityDrive_FunctionAddress;

	private static int GetLinearVelocityDrive_ParamsSize;

	private static bool GetLinearVelocityDrive_Accessor_IsValid;

	private static FFieldAddress GetLinearVelocityDrive_Accessor_PropertyAddress;

	private static int GetLinearVelocityDrive_Accessor_Offset;

	private static bool GetLinearVelocityDrive_bOutEnableDriveX_IsValid;

	private static FFieldAddress GetLinearVelocityDrive_bOutEnableDriveX_PropertyAddress;

	private static int GetLinearVelocityDrive_bOutEnableDriveX_Offset;

	private static bool GetLinearVelocityDrive_bOutEnableDriveY_IsValid;

	private static FFieldAddress GetLinearVelocityDrive_bOutEnableDriveY_PropertyAddress;

	private static int GetLinearVelocityDrive_bOutEnableDriveY_Offset;

	private static bool GetLinearVelocityDrive_bOutEnableDriveZ_IsValid;

	private static FFieldAddress GetLinearVelocityDrive_bOutEnableDriveZ_PropertyAddress;

	private static int GetLinearVelocityDrive_bOutEnableDriveZ_Offset;

	private static bool GetLinearSoftLimitParams_IsValid;

	private static IntPtr GetLinearSoftLimitParams_FunctionAddress;

	private static int GetLinearSoftLimitParams_ParamsSize;

	private static bool GetLinearSoftLimitParams_Accessor_IsValid;

	private static FFieldAddress GetLinearSoftLimitParams_Accessor_PropertyAddress;

	private static int GetLinearSoftLimitParams_Accessor_Offset;

	private static bool GetLinearSoftLimitParams_bSoftLinearLimit_IsValid;

	private static FFieldAddress GetLinearSoftLimitParams_bSoftLinearLimit_PropertyAddress;

	private static int GetLinearSoftLimitParams_bSoftLinearLimit_Offset;

	private static bool GetLinearSoftLimitParams_LinearLimitStiffness_IsValid;

	private static FFieldAddress GetLinearSoftLimitParams_LinearLimitStiffness_PropertyAddress;

	private static int GetLinearSoftLimitParams_LinearLimitStiffness_Offset;

	private static bool GetLinearSoftLimitParams_LinearLimitDamping_IsValid;

	private static FFieldAddress GetLinearSoftLimitParams_LinearLimitDamping_PropertyAddress;

	private static int GetLinearSoftLimitParams_LinearLimitDamping_Offset;

	private static bool GetLinearSoftLimitParams_LinearLimitRestitution_IsValid;

	private static FFieldAddress GetLinearSoftLimitParams_LinearLimitRestitution_PropertyAddress;

	private static int GetLinearSoftLimitParams_LinearLimitRestitution_Offset;

	private static bool GetLinearSoftLimitParams_LinearLimitContactDistance_IsValid;

	private static FFieldAddress GetLinearSoftLimitParams_LinearLimitContactDistance_PropertyAddress;

	private static int GetLinearSoftLimitParams_LinearLimitContactDistance_Offset;

	private static bool GetLinearPositionTarget_IsValid;

	private static IntPtr GetLinearPositionTarget_FunctionAddress;

	private static int GetLinearPositionTarget_ParamsSize;

	private static bool GetLinearPositionTarget_Accessor_IsValid;

	private static FFieldAddress GetLinearPositionTarget_Accessor_PropertyAddress;

	private static int GetLinearPositionTarget_Accessor_Offset;

	private static bool GetLinearPositionTarget_OutPosTarget_IsValid;

	private static FFieldAddress GetLinearPositionTarget_OutPosTarget_PropertyAddress;

	private static int GetLinearPositionTarget_OutPosTarget_Offset;

	private static bool GetLinearPositionDrive_IsValid;

	private static IntPtr GetLinearPositionDrive_FunctionAddress;

	private static int GetLinearPositionDrive_ParamsSize;

	private static bool GetLinearPositionDrive_Accessor_IsValid;

	private static FFieldAddress GetLinearPositionDrive_Accessor_PropertyAddress;

	private static int GetLinearPositionDrive_Accessor_Offset;

	private static bool GetLinearPositionDrive_bOutEnableDriveX_IsValid;

	private static FFieldAddress GetLinearPositionDrive_bOutEnableDriveX_PropertyAddress;

	private static int GetLinearPositionDrive_bOutEnableDriveX_Offset;

	private static bool GetLinearPositionDrive_bOutEnableDriveY_IsValid;

	private static FFieldAddress GetLinearPositionDrive_bOutEnableDriveY_PropertyAddress;

	private static int GetLinearPositionDrive_bOutEnableDriveY_Offset;

	private static bool GetLinearPositionDrive_bOutEnableDriveZ_IsValid;

	private static FFieldAddress GetLinearPositionDrive_bOutEnableDriveZ_PropertyAddress;

	private static int GetLinearPositionDrive_bOutEnableDriveZ_Offset;

	private static bool GetLinearPlasticity_IsValid;

	private static IntPtr GetLinearPlasticity_FunctionAddress;

	private static int GetLinearPlasticity_ParamsSize;

	private static bool GetLinearPlasticity_Accessor_IsValid;

	private static FFieldAddress GetLinearPlasticity_Accessor_PropertyAddress;

	private static int GetLinearPlasticity_Accessor_Offset;

	private static bool GetLinearPlasticity_bLinearPlasticity_IsValid;

	private static FFieldAddress GetLinearPlasticity_bLinearPlasticity_PropertyAddress;

	private static int GetLinearPlasticity_bLinearPlasticity_Offset;

	private static bool GetLinearPlasticity_LinearPlasticityThreshold_IsValid;

	private static FFieldAddress GetLinearPlasticity_LinearPlasticityThreshold_PropertyAddress;

	private static int GetLinearPlasticity_LinearPlasticityThreshold_Offset;

	private static bool GetLinearPlasticity_PlasticityType_IsValid;

	private static FFieldAddress GetLinearPlasticity_PlasticityType_PropertyAddress;

	private static int GetLinearPlasticity_PlasticityType_Offset;

	private static bool GetLinearLimits_IsValid;

	private static IntPtr GetLinearLimits_FunctionAddress;

	private static int GetLinearLimits_ParamsSize;

	private static bool GetLinearLimits_Accessor_IsValid;

	private static FFieldAddress GetLinearLimits_Accessor_PropertyAddress;

	private static int GetLinearLimits_Accessor_Offset;

	private static bool GetLinearLimits_XMotion_IsValid;

	private static FFieldAddress GetLinearLimits_XMotion_PropertyAddress;

	private static int GetLinearLimits_XMotion_Offset;

	private static bool GetLinearLimits_YMotion_IsValid;

	private static FFieldAddress GetLinearLimits_YMotion_PropertyAddress;

	private static int GetLinearLimits_YMotion_Offset;

	private static bool GetLinearLimits_ZMotion_IsValid;

	private static FFieldAddress GetLinearLimits_ZMotion_PropertyAddress;

	private static int GetLinearLimits_ZMotion_Offset;

	private static bool GetLinearLimits_Limit_IsValid;

	private static FFieldAddress GetLinearLimits_Limit_PropertyAddress;

	private static int GetLinearLimits_Limit_Offset;

	private static bool GetLinearDriveParams_IsValid;

	private static IntPtr GetLinearDriveParams_FunctionAddress;

	private static int GetLinearDriveParams_ParamsSize;

	private static bool GetLinearDriveParams_Accessor_IsValid;

	private static FFieldAddress GetLinearDriveParams_Accessor_PropertyAddress;

	private static int GetLinearDriveParams_Accessor_Offset;

	private static bool GetLinearDriveParams_OutPositionStrength_IsValid;

	private static FFieldAddress GetLinearDriveParams_OutPositionStrength_PropertyAddress;

	private static int GetLinearDriveParams_OutPositionStrength_Offset;

	private static bool GetLinearDriveParams_OutVelocityStrength_IsValid;

	private static FFieldAddress GetLinearDriveParams_OutVelocityStrength_PropertyAddress;

	private static int GetLinearDriveParams_OutVelocityStrength_Offset;

	private static bool GetLinearDriveParams_OutForceLimit_IsValid;

	private static FFieldAddress GetLinearDriveParams_OutForceLimit_PropertyAddress;

	private static int GetLinearDriveParams_OutForceLimit_Offset;

	private static bool GetLinearBreakable_IsValid;

	private static IntPtr GetLinearBreakable_FunctionAddress;

	private static int GetLinearBreakable_ParamsSize;

	private static bool GetLinearBreakable_Accessor_IsValid;

	private static FFieldAddress GetLinearBreakable_Accessor_PropertyAddress;

	private static int GetLinearBreakable_Accessor_Offset;

	private static bool GetLinearBreakable_bLinearBreakable_IsValid;

	private static FFieldAddress GetLinearBreakable_bLinearBreakable_PropertyAddress;

	private static int GetLinearBreakable_bLinearBreakable_Offset;

	private static bool GetLinearBreakable_LinearBreakThreshold_IsValid;

	private static FFieldAddress GetLinearBreakable_LinearBreakThreshold_PropertyAddress;

	private static int GetLinearBreakable_LinearBreakThreshold_Offset;

	private static bool GetDisableCollsion_IsValid;

	private static IntPtr GetDisableCollsion_FunctionAddress;

	private static int GetDisableCollsion_ParamsSize;

	private static bool GetDisableCollsion_Accessor_IsValid;

	private static FFieldAddress GetDisableCollsion_Accessor_PropertyAddress;

	private static int GetDisableCollsion_Accessor_Offset;

	private static bool GetDisableCollsion_ReturnValue_IsValid;

	private static FFieldAddress GetDisableCollsion_ReturnValue_PropertyAddress;

	private static int GetDisableCollsion_ReturnValue_Offset;

	private static bool GetContactTransferScale_IsValid;

	private static IntPtr GetContactTransferScale_FunctionAddress;

	private static int GetContactTransferScale_ParamsSize;

	private static bool GetContactTransferScale_Accessor_IsValid;

	private static FFieldAddress GetContactTransferScale_Accessor_PropertyAddress;

	private static int GetContactTransferScale_Accessor_Offset;

	private static bool GetContactTransferScale_ContactTransferScale_IsValid;

	private static FFieldAddress GetContactTransferScale_ContactTransferScale_PropertyAddress;

	private static int GetContactTransferScale_ContactTransferScale_Offset;

	private static bool GetAttachedBodyNames_IsValid;

	private static IntPtr GetAttachedBodyNames_FunctionAddress;

	private static int GetAttachedBodyNames_ParamsSize;

	private static bool GetAttachedBodyNames_Accessor_IsValid;

	private static FFieldAddress GetAttachedBodyNames_Accessor_PropertyAddress;

	private static int GetAttachedBodyNames_Accessor_Offset;

	private static bool GetAttachedBodyNames_ParentBody_IsValid;

	private static FFieldAddress GetAttachedBodyNames_ParentBody_PropertyAddress;

	private static int GetAttachedBodyNames_ParentBody_Offset;

	private static bool GetAttachedBodyNames_ChildBody_IsValid;

	private static FFieldAddress GetAttachedBodyNames_ChildBody_PropertyAddress;

	private static int GetAttachedBodyNames_ChildBody_Offset;

	private static bool GetAngularVelocityTarget_IsValid;

	private static IntPtr GetAngularVelocityTarget_FunctionAddress;

	private static int GetAngularVelocityTarget_ParamsSize;

	private static bool GetAngularVelocityTarget_Accessor_IsValid;

	private static FFieldAddress GetAngularVelocityTarget_Accessor_PropertyAddress;

	private static int GetAngularVelocityTarget_Accessor_Offset;

	private static bool GetAngularVelocityTarget_OutVelTarget_IsValid;

	private static FFieldAddress GetAngularVelocityTarget_OutVelTarget_PropertyAddress;

	private static int GetAngularVelocityTarget_OutVelTarget_Offset;

	private static bool GetAngularVelocityDriveTwistAndSwing_IsValid;

	private static IntPtr GetAngularVelocityDriveTwistAndSwing_FunctionAddress;

	private static int GetAngularVelocityDriveTwistAndSwing_ParamsSize;

	private static bool GetAngularVelocityDriveTwistAndSwing_Accessor_IsValid;

	private static FFieldAddress GetAngularVelocityDriveTwistAndSwing_Accessor_PropertyAddress;

	private static int GetAngularVelocityDriveTwistAndSwing_Accessor_Offset;

	private static bool GetAngularVelocityDriveTwistAndSwing_bOutEnableTwistDrive_IsValid;

	private static FFieldAddress GetAngularVelocityDriveTwistAndSwing_bOutEnableTwistDrive_PropertyAddress;

	private static int GetAngularVelocityDriveTwistAndSwing_bOutEnableTwistDrive_Offset;

	private static bool GetAngularVelocityDriveTwistAndSwing_bOutEnableSwingDrive_IsValid;

	private static FFieldAddress GetAngularVelocityDriveTwistAndSwing_bOutEnableSwingDrive_PropertyAddress;

	private static int GetAngularVelocityDriveTwistAndSwing_bOutEnableSwingDrive_Offset;

	private static bool GetAngularVelocityDriveSLERP_IsValid;

	private static IntPtr GetAngularVelocityDriveSLERP_FunctionAddress;

	private static int GetAngularVelocityDriveSLERP_ParamsSize;

	private static bool GetAngularVelocityDriveSLERP_Accessor_IsValid;

	private static FFieldAddress GetAngularVelocityDriveSLERP_Accessor_PropertyAddress;

	private static int GetAngularVelocityDriveSLERP_Accessor_Offset;

	private static bool GetAngularVelocityDriveSLERP_bOutEnableSLERP_IsValid;

	private static FFieldAddress GetAngularVelocityDriveSLERP_bOutEnableSLERP_PropertyAddress;

	private static int GetAngularVelocityDriveSLERP_bOutEnableSLERP_Offset;

	private static bool GetAngularSoftTwistLimitParams_IsValid;

	private static IntPtr GetAngularSoftTwistLimitParams_FunctionAddress;

	private static int GetAngularSoftTwistLimitParams_ParamsSize;

	private static bool GetAngularSoftTwistLimitParams_Accessor_IsValid;

	private static FFieldAddress GetAngularSoftTwistLimitParams_Accessor_PropertyAddress;

	private static int GetAngularSoftTwistLimitParams_Accessor_Offset;

	private static bool GetAngularSoftTwistLimitParams_bSoftTwistLimit_IsValid;

	private static FFieldAddress GetAngularSoftTwistLimitParams_bSoftTwistLimit_PropertyAddress;

	private static int GetAngularSoftTwistLimitParams_bSoftTwistLimit_Offset;

	private static bool GetAngularSoftTwistLimitParams_TwistLimitStiffness_IsValid;

	private static FFieldAddress GetAngularSoftTwistLimitParams_TwistLimitStiffness_PropertyAddress;

	private static int GetAngularSoftTwistLimitParams_TwistLimitStiffness_Offset;

	private static bool GetAngularSoftTwistLimitParams_TwistLimitDamping_IsValid;

	private static FFieldAddress GetAngularSoftTwistLimitParams_TwistLimitDamping_PropertyAddress;

	private static int GetAngularSoftTwistLimitParams_TwistLimitDamping_Offset;

	private static bool GetAngularSoftTwistLimitParams_TwistLimitRestitution_IsValid;

	private static FFieldAddress GetAngularSoftTwistLimitParams_TwistLimitRestitution_PropertyAddress;

	private static int GetAngularSoftTwistLimitParams_TwistLimitRestitution_Offset;

	private static bool GetAngularSoftTwistLimitParams_TwistLimitContactDistance_IsValid;

	private static FFieldAddress GetAngularSoftTwistLimitParams_TwistLimitContactDistance_PropertyAddress;

	private static int GetAngularSoftTwistLimitParams_TwistLimitContactDistance_Offset;

	private static bool GetAngularSoftSwingLimitParams_IsValid;

	private static IntPtr GetAngularSoftSwingLimitParams_FunctionAddress;

	private static int GetAngularSoftSwingLimitParams_ParamsSize;

	private static bool GetAngularSoftSwingLimitParams_Accessor_IsValid;

	private static FFieldAddress GetAngularSoftSwingLimitParams_Accessor_PropertyAddress;

	private static int GetAngularSoftSwingLimitParams_Accessor_Offset;

	private static bool GetAngularSoftSwingLimitParams_bSoftSwingLimit_IsValid;

	private static FFieldAddress GetAngularSoftSwingLimitParams_bSoftSwingLimit_PropertyAddress;

	private static int GetAngularSoftSwingLimitParams_bSoftSwingLimit_Offset;

	private static bool GetAngularSoftSwingLimitParams_SwingLimitStiffness_IsValid;

	private static FFieldAddress GetAngularSoftSwingLimitParams_SwingLimitStiffness_PropertyAddress;

	private static int GetAngularSoftSwingLimitParams_SwingLimitStiffness_Offset;

	private static bool GetAngularSoftSwingLimitParams_SwingLimitDamping_IsValid;

	private static FFieldAddress GetAngularSoftSwingLimitParams_SwingLimitDamping_PropertyAddress;

	private static int GetAngularSoftSwingLimitParams_SwingLimitDamping_Offset;

	private static bool GetAngularSoftSwingLimitParams_SwingLimitRestitution_IsValid;

	private static FFieldAddress GetAngularSoftSwingLimitParams_SwingLimitRestitution_PropertyAddress;

	private static int GetAngularSoftSwingLimitParams_SwingLimitRestitution_Offset;

	private static bool GetAngularSoftSwingLimitParams_SwingLimitContactDistance_IsValid;

	private static FFieldAddress GetAngularSoftSwingLimitParams_SwingLimitContactDistance_PropertyAddress;

	private static int GetAngularSoftSwingLimitParams_SwingLimitContactDistance_Offset;

	private static bool GetAngularPlasticity_IsValid;

	private static IntPtr GetAngularPlasticity_FunctionAddress;

	private static int GetAngularPlasticity_ParamsSize;

	private static bool GetAngularPlasticity_Accessor_IsValid;

	private static FFieldAddress GetAngularPlasticity_Accessor_PropertyAddress;

	private static int GetAngularPlasticity_Accessor_Offset;

	private static bool GetAngularPlasticity_bAngularPlasticity_IsValid;

	private static FFieldAddress GetAngularPlasticity_bAngularPlasticity_PropertyAddress;

	private static int GetAngularPlasticity_bAngularPlasticity_Offset;

	private static bool GetAngularPlasticity_AngularPlasticityThreshold_IsValid;

	private static FFieldAddress GetAngularPlasticity_AngularPlasticityThreshold_PropertyAddress;

	private static int GetAngularPlasticity_AngularPlasticityThreshold_Offset;

	private static bool GetAngularOrientationTarget_IsValid;

	private static IntPtr GetAngularOrientationTarget_FunctionAddress;

	private static int GetAngularOrientationTarget_ParamsSize;

	private static bool GetAngularOrientationTarget_Accessor_IsValid;

	private static FFieldAddress GetAngularOrientationTarget_Accessor_PropertyAddress;

	private static int GetAngularOrientationTarget_Accessor_Offset;

	private static bool GetAngularOrientationTarget_OutPosTarget_IsValid;

	private static FFieldAddress GetAngularOrientationTarget_OutPosTarget_PropertyAddress;

	private static int GetAngularOrientationTarget_OutPosTarget_Offset;

	private static bool GetAngularLimits_IsValid;

	private static IntPtr GetAngularLimits_FunctionAddress;

	private static int GetAngularLimits_ParamsSize;

	private static bool GetAngularLimits_Accessor_IsValid;

	private static FFieldAddress GetAngularLimits_Accessor_PropertyAddress;

	private static int GetAngularLimits_Accessor_Offset;

	private static bool GetAngularLimits_Swing1MotionType_IsValid;

	private static FFieldAddress GetAngularLimits_Swing1MotionType_PropertyAddress;

	private static int GetAngularLimits_Swing1MotionType_Offset;

	private static bool GetAngularLimits_Swing1LimitAngle_IsValid;

	private static FFieldAddress GetAngularLimits_Swing1LimitAngle_PropertyAddress;

	private static int GetAngularLimits_Swing1LimitAngle_Offset;

	private static bool GetAngularLimits_Swing2MotionType_IsValid;

	private static FFieldAddress GetAngularLimits_Swing2MotionType_PropertyAddress;

	private static int GetAngularLimits_Swing2MotionType_Offset;

	private static bool GetAngularLimits_Swing2LimitAngle_IsValid;

	private static FFieldAddress GetAngularLimits_Swing2LimitAngle_PropertyAddress;

	private static int GetAngularLimits_Swing2LimitAngle_Offset;

	private static bool GetAngularLimits_TwistMotionType_IsValid;

	private static FFieldAddress GetAngularLimits_TwistMotionType_PropertyAddress;

	private static int GetAngularLimits_TwistMotionType_Offset;

	private static bool GetAngularLimits_TwistLimitAngle_IsValid;

	private static FFieldAddress GetAngularLimits_TwistLimitAngle_PropertyAddress;

	private static int GetAngularLimits_TwistLimitAngle_Offset;

	private static bool GetAngularDriveParams_IsValid;

	private static IntPtr GetAngularDriveParams_FunctionAddress;

	private static int GetAngularDriveParams_ParamsSize;

	private static bool GetAngularDriveParams_Accessor_IsValid;

	private static FFieldAddress GetAngularDriveParams_Accessor_PropertyAddress;

	private static int GetAngularDriveParams_Accessor_Offset;

	private static bool GetAngularDriveParams_OutPositionStrength_IsValid;

	private static FFieldAddress GetAngularDriveParams_OutPositionStrength_PropertyAddress;

	private static int GetAngularDriveParams_OutPositionStrength_Offset;

	private static bool GetAngularDriveParams_OutVelocityStrength_IsValid;

	private static FFieldAddress GetAngularDriveParams_OutVelocityStrength_PropertyAddress;

	private static int GetAngularDriveParams_OutVelocityStrength_Offset;

	private static bool GetAngularDriveParams_OutForceLimit_IsValid;

	private static FFieldAddress GetAngularDriveParams_OutForceLimit_PropertyAddress;

	private static int GetAngularDriveParams_OutForceLimit_Offset;

	private static bool GetAngularDriveMode_IsValid;

	private static IntPtr GetAngularDriveMode_FunctionAddress;

	private static int GetAngularDriveMode_ParamsSize;

	private static bool GetAngularDriveMode_Accessor_IsValid;

	private static FFieldAddress GetAngularDriveMode_Accessor_PropertyAddress;

	private static int GetAngularDriveMode_Accessor_Offset;

	private static bool GetAngularDriveMode_OutDriveMode_IsValid;

	private static FFieldAddress GetAngularDriveMode_OutDriveMode_PropertyAddress;

	private static int GetAngularDriveMode_OutDriveMode_Offset;

	private static bool GetAngularBreakable_IsValid;

	private static IntPtr GetAngularBreakable_FunctionAddress;

	private static int GetAngularBreakable_ParamsSize;

	private static bool GetAngularBreakable_Accessor_IsValid;

	private static FFieldAddress GetAngularBreakable_Accessor_PropertyAddress;

	private static int GetAngularBreakable_Accessor_Offset;

	private static bool GetAngularBreakable_bAngularBreakable_IsValid;

	private static FFieldAddress GetAngularBreakable_bAngularBreakable_PropertyAddress;

	private static int GetAngularBreakable_bAngularBreakable_Offset;

	private static bool GetAngularBreakable_AngularBreakThreshold_IsValid;

	private static FFieldAddress GetAngularBreakable_AngularBreakThreshold_PropertyAddress;

	private static int GetAngularBreakable_AngularBreakThreshold_Offset;

	private static bool CopyParams_IsValid;

	private static IntPtr CopyParams_FunctionAddress;

	private static int CopyParams_ParamsSize;

	private static bool CopyParams_Accessor_IsValid;

	private static FFieldAddress CopyParams_Accessor_PropertyAddress;

	private static int CopyParams_Accessor_Offset;

	private static bool CopyParams_SourceAccessor_IsValid;

	private static FFieldAddress CopyParams_SourceAccessor_PropertyAddress;

	private static int CopyParams_SourceAccessor_Offset;

	private static bool CopyParams_bKeepPosition_IsValid;

	private static FFieldAddress CopyParams_bKeepPosition_PropertyAddress;

	private static int CopyParams_bKeepPosition_Offset;

	private static bool CopyParams_bKeepRotation_IsValid;

	private static FFieldAddress CopyParams_bKeepRotation_PropertyAddress;

	private static int CopyParams_bKeepRotation_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetProjectionParams")]
	public unsafe static void SetProjectionParams(ref FConstraintInstanceAccessor Accessor, bool bEnableProjection, float ProjectionLinearAlpha, float ProjectionAngularAlpha)
	{
		if (!SetProjectionParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetProjectionParams");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetProjectionParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetProjectionParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetProjectionParams_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetProjectionParams_Accessor_Offset), 0, SetProjectionParams_Accessor_PropertyAddress.Address, Accessor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetProjectionParams_bEnableProjection_Offset), 0, SetProjectionParams_bEnableProjection_PropertyAddress.Address, bEnableProjection);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetProjectionParams_ProjectionLinearAlpha_Offset), 0, SetProjectionParams_ProjectionLinearAlpha_PropertyAddress.Address, ProjectionLinearAlpha);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetProjectionParams_ProjectionAngularAlpha_Offset), 0, SetProjectionParams_ProjectionAngularAlpha_PropertyAddress.Address, ProjectionAngularAlpha);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetProjectionParams_FunctionAddress, intPtr, SetProjectionParams_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetProjectionParams_Accessor_Offset), 0, SetProjectionParams_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetProjectionParams_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetParentDominates")]
	public unsafe static void SetParentDominates(ref FConstraintInstanceAccessor Accessor, bool bParentDominates)
	{
		if (!SetParentDominates_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetParentDominates");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetParentDominates_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetParentDominates_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetParentDominates_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetParentDominates_Accessor_Offset), 0, SetParentDominates_Accessor_PropertyAddress.Address, Accessor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetParentDominates_bParentDominates_Offset), 0, SetParentDominates_bParentDominates_PropertyAddress.Address, bParentDominates);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetParentDominates_FunctionAddress, intPtr, SetParentDominates_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetParentDominates_Accessor_Offset), 0, SetParentDominates_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetParentDominates_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetOrientationDriveTwistAndSwing")]
	public unsafe static void SetOrientationDriveTwistAndSwing(ref FConstraintInstanceAccessor Accessor, bool bEnableTwistDrive, bool bEnableSwingDrive)
	{
		if (!SetOrientationDriveTwistAndSwing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetOrientationDriveTwistAndSwing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOrientationDriveTwistAndSwing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOrientationDriveTwistAndSwing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetOrientationDriveTwistAndSwing_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetOrientationDriveTwistAndSwing_Accessor_Offset), 0, SetOrientationDriveTwistAndSwing_Accessor_PropertyAddress.Address, Accessor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetOrientationDriveTwistAndSwing_bEnableTwistDrive_Offset), 0, SetOrientationDriveTwistAndSwing_bEnableTwistDrive_PropertyAddress.Address, bEnableTwistDrive);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetOrientationDriveTwistAndSwing_bEnableSwingDrive_Offset), 0, SetOrientationDriveTwistAndSwing_bEnableSwingDrive_PropertyAddress.Address, bEnableSwingDrive);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetOrientationDriveTwistAndSwing_FunctionAddress, intPtr, SetOrientationDriveTwistAndSwing_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetOrientationDriveTwistAndSwing_Accessor_Offset), 0, SetOrientationDriveTwistAndSwing_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetOrientationDriveTwistAndSwing_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetOrientationDriveSLERP")]
	public unsafe static void SetOrientationDriveSLERP(ref FConstraintInstanceAccessor Accessor, bool bEnableSLERP)
	{
		if (!SetOrientationDriveSLERP_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetOrientationDriveSLERP");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOrientationDriveSLERP_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOrientationDriveSLERP_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetOrientationDriveSLERP_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetOrientationDriveSLERP_Accessor_Offset), 0, SetOrientationDriveSLERP_Accessor_PropertyAddress.Address, Accessor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetOrientationDriveSLERP_bEnableSLERP_Offset), 0, SetOrientationDriveSLERP_bEnableSLERP_PropertyAddress.Address, bEnableSLERP);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetOrientationDriveSLERP_FunctionAddress, intPtr, SetOrientationDriveSLERP_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetOrientationDriveSLERP_Accessor_Offset), 0, SetOrientationDriveSLERP_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetOrientationDriveSLERP_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearVelocityTarget")]
	public unsafe static void SetLinearVelocityTarget(ref FConstraintInstanceAccessor Accessor, FVector InVelTarget)
	{
		if (!SetLinearVelocityTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearVelocityTarget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLinearVelocityTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLinearVelocityTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetLinearVelocityTarget_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetLinearVelocityTarget_Accessor_Offset), 0, SetLinearVelocityTarget_Accessor_PropertyAddress.Address, Accessor);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetLinearVelocityTarget_InVelTarget_Offset), 0, SetLinearVelocityTarget_InVelTarget_PropertyAddress.Address, InVelTarget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLinearVelocityTarget_FunctionAddress, intPtr, SetLinearVelocityTarget_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetLinearVelocityTarget_Accessor_Offset), 0, SetLinearVelocityTarget_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetLinearVelocityTarget_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearVelocityDrive")]
	public unsafe static void SetLinearVelocityDrive(ref FConstraintInstanceAccessor Accessor, bool bEnableDriveX, bool bEnableDriveY, bool bEnableDriveZ)
	{
		if (!SetLinearVelocityDrive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearVelocityDrive");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLinearVelocityDrive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLinearVelocityDrive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetLinearVelocityDrive_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetLinearVelocityDrive_Accessor_Offset), 0, SetLinearVelocityDrive_Accessor_PropertyAddress.Address, Accessor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLinearVelocityDrive_bEnableDriveX_Offset), 0, SetLinearVelocityDrive_bEnableDriveX_PropertyAddress.Address, bEnableDriveX);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLinearVelocityDrive_bEnableDriveY_Offset), 0, SetLinearVelocityDrive_bEnableDriveY_PropertyAddress.Address, bEnableDriveY);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLinearVelocityDrive_bEnableDriveZ_Offset), 0, SetLinearVelocityDrive_bEnableDriveZ_PropertyAddress.Address, bEnableDriveZ);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLinearVelocityDrive_FunctionAddress, intPtr, SetLinearVelocityDrive_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetLinearVelocityDrive_Accessor_Offset), 0, SetLinearVelocityDrive_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetLinearVelocityDrive_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearSoftLimitParams")]
	public unsafe static void SetLinearSoftLimitParams(ref FConstraintInstanceAccessor Accessor, bool bSoftLinearLimit, float LinearLimitStiffness, float LinearLimitDamping, float LinearLimitRestitution, float LinearLimitContactDistance)
	{
		if (!SetLinearSoftLimitParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearSoftLimitParams");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLinearSoftLimitParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLinearSoftLimitParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetLinearSoftLimitParams_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetLinearSoftLimitParams_Accessor_Offset), 0, SetLinearSoftLimitParams_Accessor_PropertyAddress.Address, Accessor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLinearSoftLimitParams_bSoftLinearLimit_Offset), 0, SetLinearSoftLimitParams_bSoftLinearLimit_PropertyAddress.Address, bSoftLinearLimit);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLinearSoftLimitParams_LinearLimitStiffness_Offset), 0, SetLinearSoftLimitParams_LinearLimitStiffness_PropertyAddress.Address, LinearLimitStiffness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLinearSoftLimitParams_LinearLimitDamping_Offset), 0, SetLinearSoftLimitParams_LinearLimitDamping_PropertyAddress.Address, LinearLimitDamping);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLinearSoftLimitParams_LinearLimitRestitution_Offset), 0, SetLinearSoftLimitParams_LinearLimitRestitution_PropertyAddress.Address, LinearLimitRestitution);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLinearSoftLimitParams_LinearLimitContactDistance_Offset), 0, SetLinearSoftLimitParams_LinearLimitContactDistance_PropertyAddress.Address, LinearLimitContactDistance);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLinearSoftLimitParams_FunctionAddress, intPtr, SetLinearSoftLimitParams_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetLinearSoftLimitParams_Accessor_Offset), 0, SetLinearSoftLimitParams_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetLinearSoftLimitParams_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearPositionTarget")]
	public unsafe static void SetLinearPositionTarget(ref FConstraintInstanceAccessor Accessor, FVector InPosTarget)
	{
		if (!SetLinearPositionTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearPositionTarget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLinearPositionTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLinearPositionTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetLinearPositionTarget_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetLinearPositionTarget_Accessor_Offset), 0, SetLinearPositionTarget_Accessor_PropertyAddress.Address, Accessor);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetLinearPositionTarget_InPosTarget_Offset), 0, SetLinearPositionTarget_InPosTarget_PropertyAddress.Address, InPosTarget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLinearPositionTarget_FunctionAddress, intPtr, SetLinearPositionTarget_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetLinearPositionTarget_Accessor_Offset), 0, SetLinearPositionTarget_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetLinearPositionTarget_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearPositionDrive")]
	public unsafe static void SetLinearPositionDrive(ref FConstraintInstanceAccessor Accessor, bool bEnableDriveX, bool bEnableDriveY, bool bEnableDriveZ)
	{
		if (!SetLinearPositionDrive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearPositionDrive");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLinearPositionDrive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLinearPositionDrive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetLinearPositionDrive_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetLinearPositionDrive_Accessor_Offset), 0, SetLinearPositionDrive_Accessor_PropertyAddress.Address, Accessor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLinearPositionDrive_bEnableDriveX_Offset), 0, SetLinearPositionDrive_bEnableDriveX_PropertyAddress.Address, bEnableDriveX);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLinearPositionDrive_bEnableDriveY_Offset), 0, SetLinearPositionDrive_bEnableDriveY_PropertyAddress.Address, bEnableDriveY);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLinearPositionDrive_bEnableDriveZ_Offset), 0, SetLinearPositionDrive_bEnableDriveZ_PropertyAddress.Address, bEnableDriveZ);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLinearPositionDrive_FunctionAddress, intPtr, SetLinearPositionDrive_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetLinearPositionDrive_Accessor_Offset), 0, SetLinearPositionDrive_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetLinearPositionDrive_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearPlasticity")]
	public unsafe static void SetLinearPlasticity(ref FConstraintInstanceAccessor Accessor, bool bLinearPlasticity, float LinearPlasticityThreshold, EConstraintPlasticityType PlasticityType)
	{
		if (!SetLinearPlasticity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearPlasticity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLinearPlasticity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLinearPlasticity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetLinearPlasticity_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetLinearPlasticity_Accessor_Offset), 0, SetLinearPlasticity_Accessor_PropertyAddress.Address, Accessor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLinearPlasticity_bLinearPlasticity_Offset), 0, SetLinearPlasticity_bLinearPlasticity_PropertyAddress.Address, bLinearPlasticity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLinearPlasticity_LinearPlasticityThreshold_Offset), 0, SetLinearPlasticity_LinearPlasticityThreshold_PropertyAddress.Address, LinearPlasticityThreshold);
		EnumMarshaler<EConstraintPlasticityType>.ToNative(IntPtr.Add(intPtr, SetLinearPlasticity_PlasticityType_Offset), 0, SetLinearPlasticity_PlasticityType_PropertyAddress.Address, PlasticityType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLinearPlasticity_FunctionAddress, intPtr, SetLinearPlasticity_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetLinearPlasticity_Accessor_Offset), 0, SetLinearPlasticity_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetLinearPlasticity_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearLimits")]
	public unsafe static void SetLinearLimits(ref FConstraintInstanceAccessor Accessor, ELinearConstraintMotion XMotion, ELinearConstraintMotion YMotion, ELinearConstraintMotion ZMotion, float Limit)
	{
		if (!SetLinearLimits_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearLimits");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLinearLimits_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLinearLimits_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetLinearLimits_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetLinearLimits_Accessor_Offset), 0, SetLinearLimits_Accessor_PropertyAddress.Address, Accessor);
		EnumMarshaler<ELinearConstraintMotion>.ToNative(IntPtr.Add(intPtr, SetLinearLimits_XMotion_Offset), 0, SetLinearLimits_XMotion_PropertyAddress.Address, XMotion);
		EnumMarshaler<ELinearConstraintMotion>.ToNative(IntPtr.Add(intPtr, SetLinearLimits_YMotion_Offset), 0, SetLinearLimits_YMotion_PropertyAddress.Address, YMotion);
		EnumMarshaler<ELinearConstraintMotion>.ToNative(IntPtr.Add(intPtr, SetLinearLimits_ZMotion_Offset), 0, SetLinearLimits_ZMotion_PropertyAddress.Address, ZMotion);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLinearLimits_Limit_Offset), 0, SetLinearLimits_Limit_PropertyAddress.Address, Limit);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLinearLimits_FunctionAddress, intPtr, SetLinearLimits_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetLinearLimits_Accessor_Offset), 0, SetLinearLimits_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetLinearLimits_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearDriveParams")]
	public unsafe static void SetLinearDriveParams(ref FConstraintInstanceAccessor Accessor, float PositionStrength, float VelocityStrength, float InForceLimit)
	{
		if (!SetLinearDriveParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearDriveParams");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLinearDriveParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLinearDriveParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetLinearDriveParams_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetLinearDriveParams_Accessor_Offset), 0, SetLinearDriveParams_Accessor_PropertyAddress.Address, Accessor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLinearDriveParams_PositionStrength_Offset), 0, SetLinearDriveParams_PositionStrength_PropertyAddress.Address, PositionStrength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLinearDriveParams_VelocityStrength_Offset), 0, SetLinearDriveParams_VelocityStrength_PropertyAddress.Address, VelocityStrength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLinearDriveParams_InForceLimit_Offset), 0, SetLinearDriveParams_InForceLimit_PropertyAddress.Address, InForceLimit);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLinearDriveParams_FunctionAddress, intPtr, SetLinearDriveParams_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetLinearDriveParams_Accessor_Offset), 0, SetLinearDriveParams_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetLinearDriveParams_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearBreakable")]
	public unsafe static void SetLinearBreakable(ref FConstraintInstanceAccessor Accessor, bool bLinearBreakable, float LinearBreakThreshold)
	{
		if (!SetLinearBreakable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearBreakable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLinearBreakable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLinearBreakable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetLinearBreakable_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetLinearBreakable_Accessor_Offset), 0, SetLinearBreakable_Accessor_PropertyAddress.Address, Accessor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLinearBreakable_bLinearBreakable_Offset), 0, SetLinearBreakable_bLinearBreakable_PropertyAddress.Address, bLinearBreakable);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLinearBreakable_LinearBreakThreshold_Offset), 0, SetLinearBreakable_LinearBreakThreshold_PropertyAddress.Address, LinearBreakThreshold);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLinearBreakable_FunctionAddress, intPtr, SetLinearBreakable_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetLinearBreakable_Accessor_Offset), 0, SetLinearBreakable_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetLinearBreakable_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetDisableCollision")]
	public unsafe static void SetDisableCollision(ref FConstraintInstanceAccessor Accessor, bool bDisableCollision)
	{
		if (!SetDisableCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetDisableCollision");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDisableCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDisableCollision_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetDisableCollision_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetDisableCollision_Accessor_Offset), 0, SetDisableCollision_Accessor_PropertyAddress.Address, Accessor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetDisableCollision_bDisableCollision_Offset), 0, SetDisableCollision_bDisableCollision_PropertyAddress.Address, bDisableCollision);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetDisableCollision_FunctionAddress, intPtr, SetDisableCollision_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetDisableCollision_Accessor_Offset), 0, SetDisableCollision_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetDisableCollision_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetContactTransferScale")]
	public unsafe static void SetContactTransferScale(ref FConstraintInstanceAccessor Accessor, float ContactTransferScale)
	{
		if (!SetContactTransferScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetContactTransferScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetContactTransferScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetContactTransferScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetContactTransferScale_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetContactTransferScale_Accessor_Offset), 0, SetContactTransferScale_Accessor_PropertyAddress.Address, Accessor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetContactTransferScale_ContactTransferScale_Offset), 0, SetContactTransferScale_ContactTransferScale_PropertyAddress.Address, ContactTransferScale);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetContactTransferScale_FunctionAddress, intPtr, SetContactTransferScale_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetContactTransferScale_Accessor_Offset), 0, SetContactTransferScale_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetContactTransferScale_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularVelocityTarget")]
	public unsafe static void SetAngularVelocityTarget(ref FConstraintInstanceAccessor Accessor, FVector InVelTarget)
	{
		if (!SetAngularVelocityTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularVelocityTarget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAngularVelocityTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAngularVelocityTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetAngularVelocityTarget_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetAngularVelocityTarget_Accessor_Offset), 0, SetAngularVelocityTarget_Accessor_PropertyAddress.Address, Accessor);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetAngularVelocityTarget_InVelTarget_Offset), 0, SetAngularVelocityTarget_InVelTarget_PropertyAddress.Address, InVelTarget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAngularVelocityTarget_FunctionAddress, intPtr, SetAngularVelocityTarget_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetAngularVelocityTarget_Accessor_Offset), 0, SetAngularVelocityTarget_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetAngularVelocityTarget_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularVelocityDriveTwistAndSwing")]
	public unsafe static void SetAngularVelocityDriveTwistAndSwing(ref FConstraintInstanceAccessor Accessor, bool bEnableTwistDrive, bool bEnableSwingDrive)
	{
		if (!SetAngularVelocityDriveTwistAndSwing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularVelocityDriveTwistAndSwing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAngularVelocityDriveTwistAndSwing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAngularVelocityDriveTwistAndSwing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetAngularVelocityDriveTwistAndSwing_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetAngularVelocityDriveTwistAndSwing_Accessor_Offset), 0, SetAngularVelocityDriveTwistAndSwing_Accessor_PropertyAddress.Address, Accessor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAngularVelocityDriveTwistAndSwing_bEnableTwistDrive_Offset), 0, SetAngularVelocityDriveTwistAndSwing_bEnableTwistDrive_PropertyAddress.Address, bEnableTwistDrive);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAngularVelocityDriveTwistAndSwing_bEnableSwingDrive_Offset), 0, SetAngularVelocityDriveTwistAndSwing_bEnableSwingDrive_PropertyAddress.Address, bEnableSwingDrive);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAngularVelocityDriveTwistAndSwing_FunctionAddress, intPtr, SetAngularVelocityDriveTwistAndSwing_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetAngularVelocityDriveTwistAndSwing_Accessor_Offset), 0, SetAngularVelocityDriveTwistAndSwing_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetAngularVelocityDriveTwistAndSwing_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularVelocityDriveSLERP")]
	public unsafe static void SetAngularVelocityDriveSLERP(ref FConstraintInstanceAccessor Accessor, bool bEnableSLERP)
	{
		if (!SetAngularVelocityDriveSLERP_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularVelocityDriveSLERP");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAngularVelocityDriveSLERP_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAngularVelocityDriveSLERP_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetAngularVelocityDriveSLERP_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetAngularVelocityDriveSLERP_Accessor_Offset), 0, SetAngularVelocityDriveSLERP_Accessor_PropertyAddress.Address, Accessor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAngularVelocityDriveSLERP_bEnableSLERP_Offset), 0, SetAngularVelocityDriveSLERP_bEnableSLERP_PropertyAddress.Address, bEnableSLERP);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAngularVelocityDriveSLERP_FunctionAddress, intPtr, SetAngularVelocityDriveSLERP_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetAngularVelocityDriveSLERP_Accessor_Offset), 0, SetAngularVelocityDriveSLERP_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetAngularVelocityDriveSLERP_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularSoftTwistLimitParams")]
	public unsafe static void SetAngularSoftTwistLimitParams(ref FConstraintInstanceAccessor Accessor, bool bSoftTwistLimit, float TwistLimitStiffness, float TwistLimitDamping, float TwistLimitRestitution, float TwistLimitContactDistance)
	{
		if (!SetAngularSoftTwistLimitParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularSoftTwistLimitParams");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAngularSoftTwistLimitParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAngularSoftTwistLimitParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetAngularSoftTwistLimitParams_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetAngularSoftTwistLimitParams_Accessor_Offset), 0, SetAngularSoftTwistLimitParams_Accessor_PropertyAddress.Address, Accessor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAngularSoftTwistLimitParams_bSoftTwistLimit_Offset), 0, SetAngularSoftTwistLimitParams_bSoftTwistLimit_PropertyAddress.Address, bSoftTwistLimit);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularSoftTwistLimitParams_TwistLimitStiffness_Offset), 0, SetAngularSoftTwistLimitParams_TwistLimitStiffness_PropertyAddress.Address, TwistLimitStiffness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularSoftTwistLimitParams_TwistLimitDamping_Offset), 0, SetAngularSoftTwistLimitParams_TwistLimitDamping_PropertyAddress.Address, TwistLimitDamping);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularSoftTwistLimitParams_TwistLimitRestitution_Offset), 0, SetAngularSoftTwistLimitParams_TwistLimitRestitution_PropertyAddress.Address, TwistLimitRestitution);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularSoftTwistLimitParams_TwistLimitContactDistance_Offset), 0, SetAngularSoftTwistLimitParams_TwistLimitContactDistance_PropertyAddress.Address, TwistLimitContactDistance);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAngularSoftTwistLimitParams_FunctionAddress, intPtr, SetAngularSoftTwistLimitParams_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetAngularSoftTwistLimitParams_Accessor_Offset), 0, SetAngularSoftTwistLimitParams_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetAngularSoftTwistLimitParams_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularSoftSwingLimitParams")]
	public unsafe static void SetAngularSoftSwingLimitParams(ref FConstraintInstanceAccessor Accessor, bool bSoftSwingLimit, float SwingLimitStiffness, float SwingLimitDamping, float SwingLimitRestitution, float SwingLimitContactDistance)
	{
		if (!SetAngularSoftSwingLimitParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularSoftSwingLimitParams");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAngularSoftSwingLimitParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAngularSoftSwingLimitParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetAngularSoftSwingLimitParams_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetAngularSoftSwingLimitParams_Accessor_Offset), 0, SetAngularSoftSwingLimitParams_Accessor_PropertyAddress.Address, Accessor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAngularSoftSwingLimitParams_bSoftSwingLimit_Offset), 0, SetAngularSoftSwingLimitParams_bSoftSwingLimit_PropertyAddress.Address, bSoftSwingLimit);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularSoftSwingLimitParams_SwingLimitStiffness_Offset), 0, SetAngularSoftSwingLimitParams_SwingLimitStiffness_PropertyAddress.Address, SwingLimitStiffness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularSoftSwingLimitParams_SwingLimitDamping_Offset), 0, SetAngularSoftSwingLimitParams_SwingLimitDamping_PropertyAddress.Address, SwingLimitDamping);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularSoftSwingLimitParams_SwingLimitRestitution_Offset), 0, SetAngularSoftSwingLimitParams_SwingLimitRestitution_PropertyAddress.Address, SwingLimitRestitution);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularSoftSwingLimitParams_SwingLimitContactDistance_Offset), 0, SetAngularSoftSwingLimitParams_SwingLimitContactDistance_PropertyAddress.Address, SwingLimitContactDistance);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAngularSoftSwingLimitParams_FunctionAddress, intPtr, SetAngularSoftSwingLimitParams_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetAngularSoftSwingLimitParams_Accessor_Offset), 0, SetAngularSoftSwingLimitParams_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetAngularSoftSwingLimitParams_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularPlasticity")]
	public unsafe static void SetAngularPlasticity(ref FConstraintInstanceAccessor Accessor, bool bAngularPlasticity, float AngularPlasticityThreshold)
	{
		if (!SetAngularPlasticity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularPlasticity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAngularPlasticity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAngularPlasticity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetAngularPlasticity_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetAngularPlasticity_Accessor_Offset), 0, SetAngularPlasticity_Accessor_PropertyAddress.Address, Accessor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAngularPlasticity_bAngularPlasticity_Offset), 0, SetAngularPlasticity_bAngularPlasticity_PropertyAddress.Address, bAngularPlasticity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularPlasticity_AngularPlasticityThreshold_Offset), 0, SetAngularPlasticity_AngularPlasticityThreshold_PropertyAddress.Address, AngularPlasticityThreshold);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAngularPlasticity_FunctionAddress, intPtr, SetAngularPlasticity_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetAngularPlasticity_Accessor_Offset), 0, SetAngularPlasticity_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetAngularPlasticity_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularOrientationTarget")]
	public unsafe static void SetAngularOrientationTarget(ref FConstraintInstanceAccessor Accessor, FRotator InPosTarget)
	{
		if (!SetAngularOrientationTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularOrientationTarget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAngularOrientationTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAngularOrientationTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetAngularOrientationTarget_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetAngularOrientationTarget_Accessor_Offset), 0, SetAngularOrientationTarget_Accessor_PropertyAddress.Address, Accessor);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetAngularOrientationTarget_InPosTarget_Offset), 0, SetAngularOrientationTarget_InPosTarget_PropertyAddress.Address, InPosTarget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAngularOrientationTarget_FunctionAddress, intPtr, SetAngularOrientationTarget_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetAngularOrientationTarget_Accessor_Offset), 0, SetAngularOrientationTarget_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetAngularOrientationTarget_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularLimits")]
	public unsafe static void SetAngularLimits(ref FConstraintInstanceAccessor Accessor, EAngularConstraintMotion Swing1MotionType, float Swing1LimitAngle, EAngularConstraintMotion Swing2MotionType, float Swing2LimitAngle, EAngularConstraintMotion TwistMotionType, float TwistLimitAngle)
	{
		if (!SetAngularLimits_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularLimits");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAngularLimits_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAngularLimits_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetAngularLimits_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetAngularLimits_Accessor_Offset), 0, SetAngularLimits_Accessor_PropertyAddress.Address, Accessor);
		EnumMarshaler<EAngularConstraintMotion>.ToNative(IntPtr.Add(intPtr, SetAngularLimits_Swing1MotionType_Offset), 0, SetAngularLimits_Swing1MotionType_PropertyAddress.Address, Swing1MotionType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularLimits_Swing1LimitAngle_Offset), 0, SetAngularLimits_Swing1LimitAngle_PropertyAddress.Address, Swing1LimitAngle);
		EnumMarshaler<EAngularConstraintMotion>.ToNative(IntPtr.Add(intPtr, SetAngularLimits_Swing2MotionType_Offset), 0, SetAngularLimits_Swing2MotionType_PropertyAddress.Address, Swing2MotionType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularLimits_Swing2LimitAngle_Offset), 0, SetAngularLimits_Swing2LimitAngle_PropertyAddress.Address, Swing2LimitAngle);
		EnumMarshaler<EAngularConstraintMotion>.ToNative(IntPtr.Add(intPtr, SetAngularLimits_TwistMotionType_Offset), 0, SetAngularLimits_TwistMotionType_PropertyAddress.Address, TwistMotionType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularLimits_TwistLimitAngle_Offset), 0, SetAngularLimits_TwistLimitAngle_PropertyAddress.Address, TwistLimitAngle);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAngularLimits_FunctionAddress, intPtr, SetAngularLimits_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetAngularLimits_Accessor_Offset), 0, SetAngularLimits_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetAngularLimits_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularDriveParams")]
	public unsafe static void SetAngularDriveParams(ref FConstraintInstanceAccessor Accessor, float PositionStrength, float VelocityStrength, float InForceLimit)
	{
		if (!SetAngularDriveParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularDriveParams");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAngularDriveParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAngularDriveParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetAngularDriveParams_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetAngularDriveParams_Accessor_Offset), 0, SetAngularDriveParams_Accessor_PropertyAddress.Address, Accessor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularDriveParams_PositionStrength_Offset), 0, SetAngularDriveParams_PositionStrength_PropertyAddress.Address, PositionStrength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularDriveParams_VelocityStrength_Offset), 0, SetAngularDriveParams_VelocityStrength_PropertyAddress.Address, VelocityStrength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularDriveParams_InForceLimit_Offset), 0, SetAngularDriveParams_InForceLimit_PropertyAddress.Address, InForceLimit);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAngularDriveParams_FunctionAddress, intPtr, SetAngularDriveParams_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetAngularDriveParams_Accessor_Offset), 0, SetAngularDriveParams_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetAngularDriveParams_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularDriveMode")]
	public unsafe static void SetAngularDriveMode(ref FConstraintInstanceAccessor Accessor, EAngularDriveMode DriveMode)
	{
		if (!SetAngularDriveMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularDriveMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAngularDriveMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAngularDriveMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetAngularDriveMode_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetAngularDriveMode_Accessor_Offset), 0, SetAngularDriveMode_Accessor_PropertyAddress.Address, Accessor);
		EnumMarshaler<EAngularDriveMode>.ToNative(IntPtr.Add(intPtr, SetAngularDriveMode_DriveMode_Offset), 0, SetAngularDriveMode_DriveMode_PropertyAddress.Address, DriveMode);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAngularDriveMode_FunctionAddress, intPtr, SetAngularDriveMode_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetAngularDriveMode_Accessor_Offset), 0, SetAngularDriveMode_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetAngularDriveMode_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularBreakable")]
	public unsafe static void SetAngularBreakable(ref FConstraintInstanceAccessor Accessor, bool bAngularBreakable, float AngularBreakThreshold)
	{
		if (!SetAngularBreakable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularBreakable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAngularBreakable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAngularBreakable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetAngularBreakable_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, SetAngularBreakable_Accessor_Offset), 0, SetAngularBreakable_Accessor_PropertyAddress.Address, Accessor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAngularBreakable_bAngularBreakable_Offset), 0, SetAngularBreakable_bAngularBreakable_PropertyAddress.Address, bAngularBreakable);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularBreakable_AngularBreakThreshold_Offset), 0, SetAngularBreakable_AngularBreakThreshold_PropertyAddress.Address, AngularBreakThreshold);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAngularBreakable_FunctionAddress, intPtr, SetAngularBreakable_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, SetAngularBreakable_Accessor_Offset), 0, SetAngularBreakable_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetAngularBreakable_Accessor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetProjectionParams")]
	public unsafe static void GetProjectionParams(ref FConstraintInstanceAccessor Accessor, out bool bEnableProjection, out float ProjectionLinearAlpha, out float ProjectionAngularAlpha)
	{
		if (!GetProjectionParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetProjectionParams");
			bEnableProjection = false;
			ProjectionLinearAlpha = 0f;
			ProjectionAngularAlpha = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetProjectionParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetProjectionParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetProjectionParams_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetProjectionParams_Accessor_Offset), 0, GetProjectionParams_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetProjectionParams_FunctionAddress, intPtr, GetProjectionParams_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetProjectionParams_Accessor_Offset), 0, GetProjectionParams_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetProjectionParams_Accessor_PropertyAddress.Address, intPtr);
		bEnableProjection = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetProjectionParams_bEnableProjection_Offset), 0, GetProjectionParams_bEnableProjection_PropertyAddress.Address);
		ProjectionLinearAlpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetProjectionParams_ProjectionLinearAlpha_Offset), 0, GetProjectionParams_ProjectionLinearAlpha_PropertyAddress.Address);
		ProjectionAngularAlpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetProjectionParams_ProjectionAngularAlpha_Offset), 0, GetProjectionParams_ProjectionAngularAlpha_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetParentDominates")]
	public unsafe static bool GetParentDominates(ref FConstraintInstanceAccessor Accessor)
	{
		if (!GetParentDominates_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetParentDominates");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParentDominates_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParentDominates_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetParentDominates_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetParentDominates_Accessor_Offset), 0, GetParentDominates_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetParentDominates_FunctionAddress, intPtr, GetParentDominates_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetParentDominates_Accessor_Offset), 0, GetParentDominates_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetParentDominates_Accessor_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetParentDominates_ReturnValue_Offset), 0, GetParentDominates_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetOrientationDriveTwistAndSwing")]
	public unsafe static void GetOrientationDriveTwistAndSwing(ref FConstraintInstanceAccessor Accessor, out bool bOutEnableTwistDrive, out bool bOutEnableSwingDrive)
	{
		if (!GetOrientationDriveTwistAndSwing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetOrientationDriveTwistAndSwing");
			bOutEnableTwistDrive = false;
			bOutEnableSwingDrive = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOrientationDriveTwistAndSwing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOrientationDriveTwistAndSwing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetOrientationDriveTwistAndSwing_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetOrientationDriveTwistAndSwing_Accessor_Offset), 0, GetOrientationDriveTwistAndSwing_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetOrientationDriveTwistAndSwing_FunctionAddress, intPtr, GetOrientationDriveTwistAndSwing_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetOrientationDriveTwistAndSwing_Accessor_Offset), 0, GetOrientationDriveTwistAndSwing_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetOrientationDriveTwistAndSwing_Accessor_PropertyAddress.Address, intPtr);
		bOutEnableTwistDrive = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetOrientationDriveTwistAndSwing_bOutEnableTwistDrive_Offset), 0, GetOrientationDriveTwistAndSwing_bOutEnableTwistDrive_PropertyAddress.Address);
		bOutEnableSwingDrive = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetOrientationDriveTwistAndSwing_bOutEnableSwingDrive_Offset), 0, GetOrientationDriveTwistAndSwing_bOutEnableSwingDrive_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetOrientationDriveSLERP")]
	public unsafe static void GetOrientationDriveSLERP(ref FConstraintInstanceAccessor Accessor, out bool bOutEnableSLERP)
	{
		if (!GetOrientationDriveSLERP_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetOrientationDriveSLERP");
			bOutEnableSLERP = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOrientationDriveSLERP_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOrientationDriveSLERP_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetOrientationDriveSLERP_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetOrientationDriveSLERP_Accessor_Offset), 0, GetOrientationDriveSLERP_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetOrientationDriveSLERP_FunctionAddress, intPtr, GetOrientationDriveSLERP_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetOrientationDriveSLERP_Accessor_Offset), 0, GetOrientationDriveSLERP_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetOrientationDriveSLERP_Accessor_PropertyAddress.Address, intPtr);
		bOutEnableSLERP = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetOrientationDriveSLERP_bOutEnableSLERP_Offset), 0, GetOrientationDriveSLERP_bOutEnableSLERP_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearVelocityTarget")]
	public unsafe static void GetLinearVelocityTarget(ref FConstraintInstanceAccessor Accessor, out FVector OutVelTarget)
	{
		if (!GetLinearVelocityTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearVelocityTarget");
			OutVelTarget = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLinearVelocityTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLinearVelocityTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetLinearVelocityTarget_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetLinearVelocityTarget_Accessor_Offset), 0, GetLinearVelocityTarget_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLinearVelocityTarget_FunctionAddress, intPtr, GetLinearVelocityTarget_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetLinearVelocityTarget_Accessor_Offset), 0, GetLinearVelocityTarget_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetLinearVelocityTarget_Accessor_PropertyAddress.Address, intPtr);
		OutVelTarget = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLinearVelocityTarget_OutVelTarget_Offset), 0, GetLinearVelocityTarget_OutVelTarget_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearVelocityDrive")]
	public unsafe static void GetLinearVelocityDrive(ref FConstraintInstanceAccessor Accessor, out bool bOutEnableDriveX, out bool bOutEnableDriveY, out bool bOutEnableDriveZ)
	{
		if (!GetLinearVelocityDrive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearVelocityDrive");
			bOutEnableDriveX = false;
			bOutEnableDriveY = false;
			bOutEnableDriveZ = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLinearVelocityDrive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLinearVelocityDrive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetLinearVelocityDrive_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetLinearVelocityDrive_Accessor_Offset), 0, GetLinearVelocityDrive_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLinearVelocityDrive_FunctionAddress, intPtr, GetLinearVelocityDrive_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetLinearVelocityDrive_Accessor_Offset), 0, GetLinearVelocityDrive_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetLinearVelocityDrive_Accessor_PropertyAddress.Address, intPtr);
		bOutEnableDriveX = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetLinearVelocityDrive_bOutEnableDriveX_Offset), 0, GetLinearVelocityDrive_bOutEnableDriveX_PropertyAddress.Address);
		bOutEnableDriveY = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetLinearVelocityDrive_bOutEnableDriveY_Offset), 0, GetLinearVelocityDrive_bOutEnableDriveY_PropertyAddress.Address);
		bOutEnableDriveZ = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetLinearVelocityDrive_bOutEnableDriveZ_Offset), 0, GetLinearVelocityDrive_bOutEnableDriveZ_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearSoftLimitParams")]
	public unsafe static void GetLinearSoftLimitParams(ref FConstraintInstanceAccessor Accessor, out bool bSoftLinearLimit, out float LinearLimitStiffness, out float LinearLimitDamping, out float LinearLimitRestitution, out float LinearLimitContactDistance)
	{
		if (!GetLinearSoftLimitParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearSoftLimitParams");
			bSoftLinearLimit = false;
			LinearLimitStiffness = 0f;
			LinearLimitDamping = 0f;
			LinearLimitRestitution = 0f;
			LinearLimitContactDistance = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLinearSoftLimitParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLinearSoftLimitParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetLinearSoftLimitParams_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetLinearSoftLimitParams_Accessor_Offset), 0, GetLinearSoftLimitParams_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLinearSoftLimitParams_FunctionAddress, intPtr, GetLinearSoftLimitParams_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetLinearSoftLimitParams_Accessor_Offset), 0, GetLinearSoftLimitParams_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetLinearSoftLimitParams_Accessor_PropertyAddress.Address, intPtr);
		bSoftLinearLimit = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetLinearSoftLimitParams_bSoftLinearLimit_Offset), 0, GetLinearSoftLimitParams_bSoftLinearLimit_PropertyAddress.Address);
		LinearLimitStiffness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetLinearSoftLimitParams_LinearLimitStiffness_Offset), 0, GetLinearSoftLimitParams_LinearLimitStiffness_PropertyAddress.Address);
		LinearLimitDamping = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetLinearSoftLimitParams_LinearLimitDamping_Offset), 0, GetLinearSoftLimitParams_LinearLimitDamping_PropertyAddress.Address);
		LinearLimitRestitution = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetLinearSoftLimitParams_LinearLimitRestitution_Offset), 0, GetLinearSoftLimitParams_LinearLimitRestitution_PropertyAddress.Address);
		LinearLimitContactDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetLinearSoftLimitParams_LinearLimitContactDistance_Offset), 0, GetLinearSoftLimitParams_LinearLimitContactDistance_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearPositionTarget")]
	public unsafe static void GetLinearPositionTarget(ref FConstraintInstanceAccessor Accessor, out FVector OutPosTarget)
	{
		if (!GetLinearPositionTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearPositionTarget");
			OutPosTarget = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLinearPositionTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLinearPositionTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetLinearPositionTarget_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetLinearPositionTarget_Accessor_Offset), 0, GetLinearPositionTarget_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLinearPositionTarget_FunctionAddress, intPtr, GetLinearPositionTarget_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetLinearPositionTarget_Accessor_Offset), 0, GetLinearPositionTarget_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetLinearPositionTarget_Accessor_PropertyAddress.Address, intPtr);
		OutPosTarget = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLinearPositionTarget_OutPosTarget_Offset), 0, GetLinearPositionTarget_OutPosTarget_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearPositionDrive")]
	public unsafe static void GetLinearPositionDrive(ref FConstraintInstanceAccessor Accessor, out bool bOutEnableDriveX, out bool bOutEnableDriveY, out bool bOutEnableDriveZ)
	{
		if (!GetLinearPositionDrive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearPositionDrive");
			bOutEnableDriveX = false;
			bOutEnableDriveY = false;
			bOutEnableDriveZ = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLinearPositionDrive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLinearPositionDrive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetLinearPositionDrive_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetLinearPositionDrive_Accessor_Offset), 0, GetLinearPositionDrive_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLinearPositionDrive_FunctionAddress, intPtr, GetLinearPositionDrive_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetLinearPositionDrive_Accessor_Offset), 0, GetLinearPositionDrive_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetLinearPositionDrive_Accessor_PropertyAddress.Address, intPtr);
		bOutEnableDriveX = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetLinearPositionDrive_bOutEnableDriveX_Offset), 0, GetLinearPositionDrive_bOutEnableDriveX_PropertyAddress.Address);
		bOutEnableDriveY = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetLinearPositionDrive_bOutEnableDriveY_Offset), 0, GetLinearPositionDrive_bOutEnableDriveY_PropertyAddress.Address);
		bOutEnableDriveZ = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetLinearPositionDrive_bOutEnableDriveZ_Offset), 0, GetLinearPositionDrive_bOutEnableDriveZ_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearPlasticity")]
	public unsafe static void GetLinearPlasticity(ref FConstraintInstanceAccessor Accessor, out bool bLinearPlasticity, out float LinearPlasticityThreshold, out EConstraintPlasticityType PlasticityType)
	{
		if (!GetLinearPlasticity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearPlasticity");
			bLinearPlasticity = false;
			LinearPlasticityThreshold = 0f;
			PlasticityType = EConstraintPlasticityType.CCPT_Free;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLinearPlasticity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLinearPlasticity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetLinearPlasticity_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetLinearPlasticity_Accessor_Offset), 0, GetLinearPlasticity_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLinearPlasticity_FunctionAddress, intPtr, GetLinearPlasticity_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetLinearPlasticity_Accessor_Offset), 0, GetLinearPlasticity_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetLinearPlasticity_Accessor_PropertyAddress.Address, intPtr);
		bLinearPlasticity = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetLinearPlasticity_bLinearPlasticity_Offset), 0, GetLinearPlasticity_bLinearPlasticity_PropertyAddress.Address);
		LinearPlasticityThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetLinearPlasticity_LinearPlasticityThreshold_Offset), 0, GetLinearPlasticity_LinearPlasticityThreshold_PropertyAddress.Address);
		PlasticityType = EnumMarshaler<EConstraintPlasticityType>.FromNative(IntPtr.Add(intPtr, GetLinearPlasticity_PlasticityType_Offset), 0, GetLinearPlasticity_PlasticityType_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearLimits")]
	public unsafe static void GetLinearLimits(ref FConstraintInstanceAccessor Accessor, out ELinearConstraintMotion XMotion, out ELinearConstraintMotion YMotion, out ELinearConstraintMotion ZMotion, out float Limit)
	{
		if (!GetLinearLimits_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearLimits");
			XMotion = ELinearConstraintMotion.LCM_Free;
			YMotion = ELinearConstraintMotion.LCM_Free;
			ZMotion = ELinearConstraintMotion.LCM_Free;
			Limit = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLinearLimits_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLinearLimits_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetLinearLimits_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetLinearLimits_Accessor_Offset), 0, GetLinearLimits_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLinearLimits_FunctionAddress, intPtr, GetLinearLimits_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetLinearLimits_Accessor_Offset), 0, GetLinearLimits_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetLinearLimits_Accessor_PropertyAddress.Address, intPtr);
		XMotion = EnumMarshaler<ELinearConstraintMotion>.FromNative(IntPtr.Add(intPtr, GetLinearLimits_XMotion_Offset), 0, GetLinearLimits_XMotion_PropertyAddress.Address);
		YMotion = EnumMarshaler<ELinearConstraintMotion>.FromNative(IntPtr.Add(intPtr, GetLinearLimits_YMotion_Offset), 0, GetLinearLimits_YMotion_PropertyAddress.Address);
		ZMotion = EnumMarshaler<ELinearConstraintMotion>.FromNative(IntPtr.Add(intPtr, GetLinearLimits_ZMotion_Offset), 0, GetLinearLimits_ZMotion_PropertyAddress.Address);
		Limit = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetLinearLimits_Limit_Offset), 0, GetLinearLimits_Limit_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearDriveParams")]
	public unsafe static void GetLinearDriveParams(ref FConstraintInstanceAccessor Accessor, out float OutPositionStrength, out float OutVelocityStrength, out float OutForceLimit)
	{
		if (!GetLinearDriveParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearDriveParams");
			OutPositionStrength = 0f;
			OutVelocityStrength = 0f;
			OutForceLimit = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLinearDriveParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLinearDriveParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetLinearDriveParams_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetLinearDriveParams_Accessor_Offset), 0, GetLinearDriveParams_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLinearDriveParams_FunctionAddress, intPtr, GetLinearDriveParams_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetLinearDriveParams_Accessor_Offset), 0, GetLinearDriveParams_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetLinearDriveParams_Accessor_PropertyAddress.Address, intPtr);
		OutPositionStrength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetLinearDriveParams_OutPositionStrength_Offset), 0, GetLinearDriveParams_OutPositionStrength_PropertyAddress.Address);
		OutVelocityStrength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetLinearDriveParams_OutVelocityStrength_Offset), 0, GetLinearDriveParams_OutVelocityStrength_PropertyAddress.Address);
		OutForceLimit = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetLinearDriveParams_OutForceLimit_Offset), 0, GetLinearDriveParams_OutForceLimit_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearBreakable")]
	public unsafe static void GetLinearBreakable(ref FConstraintInstanceAccessor Accessor, out bool bLinearBreakable, out float LinearBreakThreshold)
	{
		if (!GetLinearBreakable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearBreakable");
			bLinearBreakable = false;
			LinearBreakThreshold = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLinearBreakable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLinearBreakable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetLinearBreakable_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetLinearBreakable_Accessor_Offset), 0, GetLinearBreakable_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLinearBreakable_FunctionAddress, intPtr, GetLinearBreakable_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetLinearBreakable_Accessor_Offset), 0, GetLinearBreakable_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetLinearBreakable_Accessor_PropertyAddress.Address, intPtr);
		bLinearBreakable = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetLinearBreakable_bLinearBreakable_Offset), 0, GetLinearBreakable_bLinearBreakable_PropertyAddress.Address);
		LinearBreakThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetLinearBreakable_LinearBreakThreshold_Offset), 0, GetLinearBreakable_LinearBreakThreshold_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetDisableCollsion")]
	public unsafe static bool GetDisableCollsion(ref FConstraintInstanceAccessor Accessor)
	{
		if (!GetDisableCollsion_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetDisableCollsion");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisableCollsion_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisableCollsion_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetDisableCollsion_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetDisableCollsion_Accessor_Offset), 0, GetDisableCollsion_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDisableCollsion_FunctionAddress, intPtr, GetDisableCollsion_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetDisableCollsion_Accessor_Offset), 0, GetDisableCollsion_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDisableCollsion_Accessor_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetDisableCollsion_ReturnValue_Offset), 0, GetDisableCollsion_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetContactTransferScale")]
	public unsafe static void GetContactTransferScale(ref FConstraintInstanceAccessor Accessor, out float ContactTransferScale)
	{
		if (!GetContactTransferScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetContactTransferScale");
			ContactTransferScale = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetContactTransferScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetContactTransferScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetContactTransferScale_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetContactTransferScale_Accessor_Offset), 0, GetContactTransferScale_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetContactTransferScale_FunctionAddress, intPtr, GetContactTransferScale_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetContactTransferScale_Accessor_Offset), 0, GetContactTransferScale_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetContactTransferScale_Accessor_PropertyAddress.Address, intPtr);
		ContactTransferScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetContactTransferScale_ContactTransferScale_Offset), 0, GetContactTransferScale_ContactTransferScale_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAttachedBodyNames")]
	public unsafe static void GetAttachedBodyNames(ref FConstraintInstanceAccessor Accessor, out FName ParentBody, out FName ChildBody)
	{
		if (!GetAttachedBodyNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAttachedBodyNames");
			ParentBody = default(FName);
			ChildBody = default(FName);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAttachedBodyNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAttachedBodyNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAttachedBodyNames_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetAttachedBodyNames_Accessor_Offset), 0, GetAttachedBodyNames_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAttachedBodyNames_FunctionAddress, intPtr, GetAttachedBodyNames_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetAttachedBodyNames_Accessor_Offset), 0, GetAttachedBodyNames_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAttachedBodyNames_Accessor_PropertyAddress.Address, intPtr);
		ParentBody = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetAttachedBodyNames_ParentBody_Offset), 0, GetAttachedBodyNames_ParentBody_PropertyAddress.Address);
		ChildBody = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetAttachedBodyNames_ChildBody_Offset), 0, GetAttachedBodyNames_ChildBody_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularVelocityTarget")]
	public unsafe static void GetAngularVelocityTarget(ref FConstraintInstanceAccessor Accessor, out FVector OutVelTarget)
	{
		if (!GetAngularVelocityTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularVelocityTarget");
			OutVelTarget = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAngularVelocityTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAngularVelocityTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAngularVelocityTarget_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetAngularVelocityTarget_Accessor_Offset), 0, GetAngularVelocityTarget_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAngularVelocityTarget_FunctionAddress, intPtr, GetAngularVelocityTarget_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetAngularVelocityTarget_Accessor_Offset), 0, GetAngularVelocityTarget_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAngularVelocityTarget_Accessor_PropertyAddress.Address, intPtr);
		OutVelTarget = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetAngularVelocityTarget_OutVelTarget_Offset), 0, GetAngularVelocityTarget_OutVelTarget_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularVelocityDriveTwistAndSwing")]
	public unsafe static void GetAngularVelocityDriveTwistAndSwing(ref FConstraintInstanceAccessor Accessor, out bool bOutEnableTwistDrive, out bool bOutEnableSwingDrive)
	{
		if (!GetAngularVelocityDriveTwistAndSwing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularVelocityDriveTwistAndSwing");
			bOutEnableTwistDrive = false;
			bOutEnableSwingDrive = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAngularVelocityDriveTwistAndSwing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAngularVelocityDriveTwistAndSwing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAngularVelocityDriveTwistAndSwing_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetAngularVelocityDriveTwistAndSwing_Accessor_Offset), 0, GetAngularVelocityDriveTwistAndSwing_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAngularVelocityDriveTwistAndSwing_FunctionAddress, intPtr, GetAngularVelocityDriveTwistAndSwing_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetAngularVelocityDriveTwistAndSwing_Accessor_Offset), 0, GetAngularVelocityDriveTwistAndSwing_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAngularVelocityDriveTwistAndSwing_Accessor_PropertyAddress.Address, intPtr);
		bOutEnableTwistDrive = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAngularVelocityDriveTwistAndSwing_bOutEnableTwistDrive_Offset), 0, GetAngularVelocityDriveTwistAndSwing_bOutEnableTwistDrive_PropertyAddress.Address);
		bOutEnableSwingDrive = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAngularVelocityDriveTwistAndSwing_bOutEnableSwingDrive_Offset), 0, GetAngularVelocityDriveTwistAndSwing_bOutEnableSwingDrive_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularVelocityDriveSLERP")]
	public unsafe static void GetAngularVelocityDriveSLERP(ref FConstraintInstanceAccessor Accessor, out bool bOutEnableSLERP)
	{
		if (!GetAngularVelocityDriveSLERP_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularVelocityDriveSLERP");
			bOutEnableSLERP = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAngularVelocityDriveSLERP_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAngularVelocityDriveSLERP_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAngularVelocityDriveSLERP_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetAngularVelocityDriveSLERP_Accessor_Offset), 0, GetAngularVelocityDriveSLERP_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAngularVelocityDriveSLERP_FunctionAddress, intPtr, GetAngularVelocityDriveSLERP_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetAngularVelocityDriveSLERP_Accessor_Offset), 0, GetAngularVelocityDriveSLERP_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAngularVelocityDriveSLERP_Accessor_PropertyAddress.Address, intPtr);
		bOutEnableSLERP = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAngularVelocityDriveSLERP_bOutEnableSLERP_Offset), 0, GetAngularVelocityDriveSLERP_bOutEnableSLERP_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularSoftTwistLimitParams")]
	public unsafe static void GetAngularSoftTwistLimitParams(ref FConstraintInstanceAccessor Accessor, out bool bSoftTwistLimit, out float TwistLimitStiffness, out float TwistLimitDamping, out float TwistLimitRestitution, out float TwistLimitContactDistance)
	{
		if (!GetAngularSoftTwistLimitParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularSoftTwistLimitParams");
			bSoftTwistLimit = false;
			TwistLimitStiffness = 0f;
			TwistLimitDamping = 0f;
			TwistLimitRestitution = 0f;
			TwistLimitContactDistance = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAngularSoftTwistLimitParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAngularSoftTwistLimitParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAngularSoftTwistLimitParams_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetAngularSoftTwistLimitParams_Accessor_Offset), 0, GetAngularSoftTwistLimitParams_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAngularSoftTwistLimitParams_FunctionAddress, intPtr, GetAngularSoftTwistLimitParams_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetAngularSoftTwistLimitParams_Accessor_Offset), 0, GetAngularSoftTwistLimitParams_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAngularSoftTwistLimitParams_Accessor_PropertyAddress.Address, intPtr);
		bSoftTwistLimit = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAngularSoftTwistLimitParams_bSoftTwistLimit_Offset), 0, GetAngularSoftTwistLimitParams_bSoftTwistLimit_PropertyAddress.Address);
		TwistLimitStiffness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAngularSoftTwistLimitParams_TwistLimitStiffness_Offset), 0, GetAngularSoftTwistLimitParams_TwistLimitStiffness_PropertyAddress.Address);
		TwistLimitDamping = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAngularSoftTwistLimitParams_TwistLimitDamping_Offset), 0, GetAngularSoftTwistLimitParams_TwistLimitDamping_PropertyAddress.Address);
		TwistLimitRestitution = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAngularSoftTwistLimitParams_TwistLimitRestitution_Offset), 0, GetAngularSoftTwistLimitParams_TwistLimitRestitution_PropertyAddress.Address);
		TwistLimitContactDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAngularSoftTwistLimitParams_TwistLimitContactDistance_Offset), 0, GetAngularSoftTwistLimitParams_TwistLimitContactDistance_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularSoftSwingLimitParams")]
	public unsafe static void GetAngularSoftSwingLimitParams(ref FConstraintInstanceAccessor Accessor, out bool bSoftSwingLimit, out float SwingLimitStiffness, out float SwingLimitDamping, out float SwingLimitRestitution, out float SwingLimitContactDistance)
	{
		if (!GetAngularSoftSwingLimitParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularSoftSwingLimitParams");
			bSoftSwingLimit = false;
			SwingLimitStiffness = 0f;
			SwingLimitDamping = 0f;
			SwingLimitRestitution = 0f;
			SwingLimitContactDistance = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAngularSoftSwingLimitParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAngularSoftSwingLimitParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAngularSoftSwingLimitParams_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetAngularSoftSwingLimitParams_Accessor_Offset), 0, GetAngularSoftSwingLimitParams_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAngularSoftSwingLimitParams_FunctionAddress, intPtr, GetAngularSoftSwingLimitParams_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetAngularSoftSwingLimitParams_Accessor_Offset), 0, GetAngularSoftSwingLimitParams_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAngularSoftSwingLimitParams_Accessor_PropertyAddress.Address, intPtr);
		bSoftSwingLimit = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAngularSoftSwingLimitParams_bSoftSwingLimit_Offset), 0, GetAngularSoftSwingLimitParams_bSoftSwingLimit_PropertyAddress.Address);
		SwingLimitStiffness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAngularSoftSwingLimitParams_SwingLimitStiffness_Offset), 0, GetAngularSoftSwingLimitParams_SwingLimitStiffness_PropertyAddress.Address);
		SwingLimitDamping = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAngularSoftSwingLimitParams_SwingLimitDamping_Offset), 0, GetAngularSoftSwingLimitParams_SwingLimitDamping_PropertyAddress.Address);
		SwingLimitRestitution = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAngularSoftSwingLimitParams_SwingLimitRestitution_Offset), 0, GetAngularSoftSwingLimitParams_SwingLimitRestitution_PropertyAddress.Address);
		SwingLimitContactDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAngularSoftSwingLimitParams_SwingLimitContactDistance_Offset), 0, GetAngularSoftSwingLimitParams_SwingLimitContactDistance_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularPlasticity")]
	public unsafe static void GetAngularPlasticity(ref FConstraintInstanceAccessor Accessor, out bool bAngularPlasticity, out float AngularPlasticityThreshold)
	{
		if (!GetAngularPlasticity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularPlasticity");
			bAngularPlasticity = false;
			AngularPlasticityThreshold = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAngularPlasticity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAngularPlasticity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAngularPlasticity_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetAngularPlasticity_Accessor_Offset), 0, GetAngularPlasticity_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAngularPlasticity_FunctionAddress, intPtr, GetAngularPlasticity_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetAngularPlasticity_Accessor_Offset), 0, GetAngularPlasticity_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAngularPlasticity_Accessor_PropertyAddress.Address, intPtr);
		bAngularPlasticity = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAngularPlasticity_bAngularPlasticity_Offset), 0, GetAngularPlasticity_bAngularPlasticity_PropertyAddress.Address);
		AngularPlasticityThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAngularPlasticity_AngularPlasticityThreshold_Offset), 0, GetAngularPlasticity_AngularPlasticityThreshold_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularOrientationTarget")]
	public unsafe static void GetAngularOrientationTarget(ref FConstraintInstanceAccessor Accessor, out FRotator OutPosTarget)
	{
		if (!GetAngularOrientationTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularOrientationTarget");
			OutPosTarget = default(FRotator);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAngularOrientationTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAngularOrientationTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAngularOrientationTarget_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetAngularOrientationTarget_Accessor_Offset), 0, GetAngularOrientationTarget_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAngularOrientationTarget_FunctionAddress, intPtr, GetAngularOrientationTarget_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetAngularOrientationTarget_Accessor_Offset), 0, GetAngularOrientationTarget_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAngularOrientationTarget_Accessor_PropertyAddress.Address, intPtr);
		OutPosTarget = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetAngularOrientationTarget_OutPosTarget_Offset), 0, GetAngularOrientationTarget_OutPosTarget_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularLimits")]
	public unsafe static void GetAngularLimits(ref FConstraintInstanceAccessor Accessor, out EAngularConstraintMotion Swing1MotionType, out float Swing1LimitAngle, out EAngularConstraintMotion Swing2MotionType, out float Swing2LimitAngle, out EAngularConstraintMotion TwistMotionType, out float TwistLimitAngle)
	{
		if (!GetAngularLimits_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularLimits");
			Swing1MotionType = EAngularConstraintMotion.ACM_Free;
			Swing1LimitAngle = 0f;
			Swing2MotionType = EAngularConstraintMotion.ACM_Free;
			Swing2LimitAngle = 0f;
			TwistMotionType = EAngularConstraintMotion.ACM_Free;
			TwistLimitAngle = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAngularLimits_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAngularLimits_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAngularLimits_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetAngularLimits_Accessor_Offset), 0, GetAngularLimits_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAngularLimits_FunctionAddress, intPtr, GetAngularLimits_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetAngularLimits_Accessor_Offset), 0, GetAngularLimits_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAngularLimits_Accessor_PropertyAddress.Address, intPtr);
		Swing1MotionType = EnumMarshaler<EAngularConstraintMotion>.FromNative(IntPtr.Add(intPtr, GetAngularLimits_Swing1MotionType_Offset), 0, GetAngularLimits_Swing1MotionType_PropertyAddress.Address);
		Swing1LimitAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAngularLimits_Swing1LimitAngle_Offset), 0, GetAngularLimits_Swing1LimitAngle_PropertyAddress.Address);
		Swing2MotionType = EnumMarshaler<EAngularConstraintMotion>.FromNative(IntPtr.Add(intPtr, GetAngularLimits_Swing2MotionType_Offset), 0, GetAngularLimits_Swing2MotionType_PropertyAddress.Address);
		Swing2LimitAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAngularLimits_Swing2LimitAngle_Offset), 0, GetAngularLimits_Swing2LimitAngle_PropertyAddress.Address);
		TwistMotionType = EnumMarshaler<EAngularConstraintMotion>.FromNative(IntPtr.Add(intPtr, GetAngularLimits_TwistMotionType_Offset), 0, GetAngularLimits_TwistMotionType_PropertyAddress.Address);
		TwistLimitAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAngularLimits_TwistLimitAngle_Offset), 0, GetAngularLimits_TwistLimitAngle_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularDriveParams")]
	public unsafe static void GetAngularDriveParams(ref FConstraintInstanceAccessor Accessor, out float OutPositionStrength, out float OutVelocityStrength, out float OutForceLimit)
	{
		if (!GetAngularDriveParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularDriveParams");
			OutPositionStrength = 0f;
			OutVelocityStrength = 0f;
			OutForceLimit = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAngularDriveParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAngularDriveParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAngularDriveParams_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetAngularDriveParams_Accessor_Offset), 0, GetAngularDriveParams_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAngularDriveParams_FunctionAddress, intPtr, GetAngularDriveParams_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetAngularDriveParams_Accessor_Offset), 0, GetAngularDriveParams_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAngularDriveParams_Accessor_PropertyAddress.Address, intPtr);
		OutPositionStrength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAngularDriveParams_OutPositionStrength_Offset), 0, GetAngularDriveParams_OutPositionStrength_PropertyAddress.Address);
		OutVelocityStrength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAngularDriveParams_OutVelocityStrength_Offset), 0, GetAngularDriveParams_OutVelocityStrength_PropertyAddress.Address);
		OutForceLimit = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAngularDriveParams_OutForceLimit_Offset), 0, GetAngularDriveParams_OutForceLimit_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularDriveMode")]
	public unsafe static void GetAngularDriveMode(ref FConstraintInstanceAccessor Accessor, out EAngularDriveMode OutDriveMode)
	{
		if (!GetAngularDriveMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularDriveMode");
			OutDriveMode = EAngularDriveMode.SLERP;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAngularDriveMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAngularDriveMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAngularDriveMode_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetAngularDriveMode_Accessor_Offset), 0, GetAngularDriveMode_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAngularDriveMode_FunctionAddress, intPtr, GetAngularDriveMode_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetAngularDriveMode_Accessor_Offset), 0, GetAngularDriveMode_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAngularDriveMode_Accessor_PropertyAddress.Address, intPtr);
		OutDriveMode = EnumMarshaler<EAngularDriveMode>.FromNative(IntPtr.Add(intPtr, GetAngularDriveMode_OutDriveMode_Offset), 0, GetAngularDriveMode_OutDriveMode_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularBreakable")]
	public unsafe static void GetAngularBreakable(ref FConstraintInstanceAccessor Accessor, out bool bAngularBreakable, out float AngularBreakThreshold)
	{
		if (!GetAngularBreakable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularBreakable");
			bAngularBreakable = false;
			AngularBreakThreshold = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAngularBreakable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAngularBreakable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAngularBreakable_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, GetAngularBreakable_Accessor_Offset), 0, GetAngularBreakable_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAngularBreakable_FunctionAddress, intPtr, GetAngularBreakable_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetAngularBreakable_Accessor_Offset), 0, GetAngularBreakable_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAngularBreakable_Accessor_PropertyAddress.Address, intPtr);
		bAngularBreakable = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAngularBreakable_bAngularBreakable_Offset), 0, GetAngularBreakable_bAngularBreakable_PropertyAddress.Address);
		AngularBreakThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAngularBreakable_AngularBreakThreshold_Offset), 0, GetAngularBreakable_AngularBreakThreshold_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.ConstraintInstanceBlueprintLibrary:CopyParams")]
	public unsafe static void CopyParams(ref FConstraintInstanceAccessor Accessor, ref FConstraintInstanceAccessor SourceAccessor, bool bKeepPosition = true, bool bKeepRotation = true)
	{
		if (!CopyParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintInstanceBlueprintLibrary:CopyParams");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CopyParams_Accessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, CopyParams_Accessor_Offset), 0, CopyParams_Accessor_PropertyAddress.Address, Accessor);
		NativeReflection.InitializeValue_InContainer(CopyParams_SourceAccessor_PropertyAddress.Address, intPtr);
		FConstraintInstanceAccessor.ToNative(IntPtr.Add(intPtr, CopyParams_SourceAccessor_Offset), 0, CopyParams_SourceAccessor_PropertyAddress.Address, SourceAccessor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CopyParams_bKeepPosition_Offset), 0, CopyParams_bKeepPosition_PropertyAddress.Address, bKeepPosition);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CopyParams_bKeepRotation_Offset), 0, CopyParams_bKeepRotation_PropertyAddress.Address, bKeepRotation);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyParams_FunctionAddress, intPtr, CopyParams_ParamsSize);
		Accessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, CopyParams_Accessor_Offset), 0, CopyParams_Accessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CopyParams_Accessor_PropertyAddress.Address, intPtr);
		SourceAccessor = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, CopyParams_SourceAccessor_Offset), 0, CopyParams_SourceAccessor_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CopyParams_SourceAccessor_PropertyAddress.Address, intPtr);
	}

	static UConstraintInstanceBlueprintLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UConstraintInstanceBlueprintLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UConstraintInstanceBlueprintLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.ConstraintInstanceBlueprintLibrary");
		SetProjectionParams_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetProjectionParams");
		SetProjectionParams_ParamsSize = NativeReflection.GetFunctionParamsSize(SetProjectionParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetProjectionParams_Accessor_PropertyAddress, SetProjectionParams_FunctionAddress, "Accessor");
		SetProjectionParams_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetProjectionParams_FunctionAddress, "Accessor");
		SetProjectionParams_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetProjectionParams_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetProjectionParams_bEnableProjection_PropertyAddress, SetProjectionParams_FunctionAddress, "bEnableProjection");
		SetProjectionParams_bEnableProjection_Offset = NativeReflectionCached.GetPropertyOffset(SetProjectionParams_FunctionAddress, "bEnableProjection");
		SetProjectionParams_bEnableProjection_IsValid = NativeReflectionCached.ValidatePropertyClass(SetProjectionParams_FunctionAddress, "bEnableProjection", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetProjectionParams_ProjectionLinearAlpha_PropertyAddress, SetProjectionParams_FunctionAddress, "ProjectionLinearAlpha");
		SetProjectionParams_ProjectionLinearAlpha_Offset = NativeReflectionCached.GetPropertyOffset(SetProjectionParams_FunctionAddress, "ProjectionLinearAlpha");
		SetProjectionParams_ProjectionLinearAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(SetProjectionParams_FunctionAddress, "ProjectionLinearAlpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetProjectionParams_ProjectionAngularAlpha_PropertyAddress, SetProjectionParams_FunctionAddress, "ProjectionAngularAlpha");
		SetProjectionParams_ProjectionAngularAlpha_Offset = NativeReflectionCached.GetPropertyOffset(SetProjectionParams_FunctionAddress, "ProjectionAngularAlpha");
		SetProjectionParams_ProjectionAngularAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(SetProjectionParams_FunctionAddress, "ProjectionAngularAlpha", Classes.FFloatProperty);
		SetProjectionParams_IsValid = SetProjectionParams_FunctionAddress != IntPtr.Zero && SetProjectionParams_Accessor_IsValid && SetProjectionParams_bEnableProjection_IsValid && SetProjectionParams_ProjectionLinearAlpha_IsValid && SetProjectionParams_ProjectionAngularAlpha_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetProjectionParams", SetProjectionParams_IsValid);
		SetParentDominates_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetParentDominates");
		SetParentDominates_ParamsSize = NativeReflection.GetFunctionParamsSize(SetParentDominates_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetParentDominates_Accessor_PropertyAddress, SetParentDominates_FunctionAddress, "Accessor");
		SetParentDominates_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetParentDominates_FunctionAddress, "Accessor");
		SetParentDominates_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParentDominates_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParentDominates_bParentDominates_PropertyAddress, SetParentDominates_FunctionAddress, "bParentDominates");
		SetParentDominates_bParentDominates_Offset = NativeReflectionCached.GetPropertyOffset(SetParentDominates_FunctionAddress, "bParentDominates");
		SetParentDominates_bParentDominates_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParentDominates_FunctionAddress, "bParentDominates", Classes.FBoolProperty);
		SetParentDominates_IsValid = SetParentDominates_FunctionAddress != IntPtr.Zero && SetParentDominates_Accessor_IsValid && SetParentDominates_bParentDominates_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetParentDominates", SetParentDominates_IsValid);
		SetOrientationDriveTwistAndSwing_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetOrientationDriveTwistAndSwing");
		SetOrientationDriveTwistAndSwing_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOrientationDriveTwistAndSwing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOrientationDriveTwistAndSwing_Accessor_PropertyAddress, SetOrientationDriveTwistAndSwing_FunctionAddress, "Accessor");
		SetOrientationDriveTwistAndSwing_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetOrientationDriveTwistAndSwing_FunctionAddress, "Accessor");
		SetOrientationDriveTwistAndSwing_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOrientationDriveTwistAndSwing_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOrientationDriveTwistAndSwing_bEnableTwistDrive_PropertyAddress, SetOrientationDriveTwistAndSwing_FunctionAddress, "bEnableTwistDrive");
		SetOrientationDriveTwistAndSwing_bEnableTwistDrive_Offset = NativeReflectionCached.GetPropertyOffset(SetOrientationDriveTwistAndSwing_FunctionAddress, "bEnableTwistDrive");
		SetOrientationDriveTwistAndSwing_bEnableTwistDrive_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOrientationDriveTwistAndSwing_FunctionAddress, "bEnableTwistDrive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOrientationDriveTwistAndSwing_bEnableSwingDrive_PropertyAddress, SetOrientationDriveTwistAndSwing_FunctionAddress, "bEnableSwingDrive");
		SetOrientationDriveTwistAndSwing_bEnableSwingDrive_Offset = NativeReflectionCached.GetPropertyOffset(SetOrientationDriveTwistAndSwing_FunctionAddress, "bEnableSwingDrive");
		SetOrientationDriveTwistAndSwing_bEnableSwingDrive_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOrientationDriveTwistAndSwing_FunctionAddress, "bEnableSwingDrive", Classes.FBoolProperty);
		SetOrientationDriveTwistAndSwing_IsValid = SetOrientationDriveTwistAndSwing_FunctionAddress != IntPtr.Zero && SetOrientationDriveTwistAndSwing_Accessor_IsValid && SetOrientationDriveTwistAndSwing_bEnableTwistDrive_IsValid && SetOrientationDriveTwistAndSwing_bEnableSwingDrive_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetOrientationDriveTwistAndSwing", SetOrientationDriveTwistAndSwing_IsValid);
		SetOrientationDriveSLERP_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetOrientationDriveSLERP");
		SetOrientationDriveSLERP_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOrientationDriveSLERP_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOrientationDriveSLERP_Accessor_PropertyAddress, SetOrientationDriveSLERP_FunctionAddress, "Accessor");
		SetOrientationDriveSLERP_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetOrientationDriveSLERP_FunctionAddress, "Accessor");
		SetOrientationDriveSLERP_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOrientationDriveSLERP_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOrientationDriveSLERP_bEnableSLERP_PropertyAddress, SetOrientationDriveSLERP_FunctionAddress, "bEnableSLERP");
		SetOrientationDriveSLERP_bEnableSLERP_Offset = NativeReflectionCached.GetPropertyOffset(SetOrientationDriveSLERP_FunctionAddress, "bEnableSLERP");
		SetOrientationDriveSLERP_bEnableSLERP_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOrientationDriveSLERP_FunctionAddress, "bEnableSLERP", Classes.FBoolProperty);
		SetOrientationDriveSLERP_IsValid = SetOrientationDriveSLERP_FunctionAddress != IntPtr.Zero && SetOrientationDriveSLERP_Accessor_IsValid && SetOrientationDriveSLERP_bEnableSLERP_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetOrientationDriveSLERP", SetOrientationDriveSLERP_IsValid);
		SetLinearVelocityTarget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLinearVelocityTarget");
		SetLinearVelocityTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLinearVelocityTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLinearVelocityTarget_Accessor_PropertyAddress, SetLinearVelocityTarget_FunctionAddress, "Accessor");
		SetLinearVelocityTarget_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearVelocityTarget_FunctionAddress, "Accessor");
		SetLinearVelocityTarget_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearVelocityTarget_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearVelocityTarget_InVelTarget_PropertyAddress, SetLinearVelocityTarget_FunctionAddress, "InVelTarget");
		SetLinearVelocityTarget_InVelTarget_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearVelocityTarget_FunctionAddress, "InVelTarget");
		SetLinearVelocityTarget_InVelTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearVelocityTarget_FunctionAddress, "InVelTarget", Classes.FStructProperty);
		SetLinearVelocityTarget_IsValid = SetLinearVelocityTarget_FunctionAddress != IntPtr.Zero && SetLinearVelocityTarget_Accessor_IsValid && SetLinearVelocityTarget_InVelTarget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearVelocityTarget", SetLinearVelocityTarget_IsValid);
		SetLinearVelocityDrive_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLinearVelocityDrive");
		SetLinearVelocityDrive_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLinearVelocityDrive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLinearVelocityDrive_Accessor_PropertyAddress, SetLinearVelocityDrive_FunctionAddress, "Accessor");
		SetLinearVelocityDrive_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearVelocityDrive_FunctionAddress, "Accessor");
		SetLinearVelocityDrive_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearVelocityDrive_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearVelocityDrive_bEnableDriveX_PropertyAddress, SetLinearVelocityDrive_FunctionAddress, "bEnableDriveX");
		SetLinearVelocityDrive_bEnableDriveX_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearVelocityDrive_FunctionAddress, "bEnableDriveX");
		SetLinearVelocityDrive_bEnableDriveX_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearVelocityDrive_FunctionAddress, "bEnableDriveX", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearVelocityDrive_bEnableDriveY_PropertyAddress, SetLinearVelocityDrive_FunctionAddress, "bEnableDriveY");
		SetLinearVelocityDrive_bEnableDriveY_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearVelocityDrive_FunctionAddress, "bEnableDriveY");
		SetLinearVelocityDrive_bEnableDriveY_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearVelocityDrive_FunctionAddress, "bEnableDriveY", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearVelocityDrive_bEnableDriveZ_PropertyAddress, SetLinearVelocityDrive_FunctionAddress, "bEnableDriveZ");
		SetLinearVelocityDrive_bEnableDriveZ_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearVelocityDrive_FunctionAddress, "bEnableDriveZ");
		SetLinearVelocityDrive_bEnableDriveZ_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearVelocityDrive_FunctionAddress, "bEnableDriveZ", Classes.FBoolProperty);
		SetLinearVelocityDrive_IsValid = SetLinearVelocityDrive_FunctionAddress != IntPtr.Zero && SetLinearVelocityDrive_Accessor_IsValid && SetLinearVelocityDrive_bEnableDriveX_IsValid && SetLinearVelocityDrive_bEnableDriveY_IsValid && SetLinearVelocityDrive_bEnableDriveZ_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearVelocityDrive", SetLinearVelocityDrive_IsValid);
		SetLinearSoftLimitParams_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLinearSoftLimitParams");
		SetLinearSoftLimitParams_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLinearSoftLimitParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLinearSoftLimitParams_Accessor_PropertyAddress, SetLinearSoftLimitParams_FunctionAddress, "Accessor");
		SetLinearSoftLimitParams_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearSoftLimitParams_FunctionAddress, "Accessor");
		SetLinearSoftLimitParams_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearSoftLimitParams_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearSoftLimitParams_bSoftLinearLimit_PropertyAddress, SetLinearSoftLimitParams_FunctionAddress, "bSoftLinearLimit");
		SetLinearSoftLimitParams_bSoftLinearLimit_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearSoftLimitParams_FunctionAddress, "bSoftLinearLimit");
		SetLinearSoftLimitParams_bSoftLinearLimit_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearSoftLimitParams_FunctionAddress, "bSoftLinearLimit", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearSoftLimitParams_LinearLimitStiffness_PropertyAddress, SetLinearSoftLimitParams_FunctionAddress, "LinearLimitStiffness");
		SetLinearSoftLimitParams_LinearLimitStiffness_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearSoftLimitParams_FunctionAddress, "LinearLimitStiffness");
		SetLinearSoftLimitParams_LinearLimitStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearSoftLimitParams_FunctionAddress, "LinearLimitStiffness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearSoftLimitParams_LinearLimitDamping_PropertyAddress, SetLinearSoftLimitParams_FunctionAddress, "LinearLimitDamping");
		SetLinearSoftLimitParams_LinearLimitDamping_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearSoftLimitParams_FunctionAddress, "LinearLimitDamping");
		SetLinearSoftLimitParams_LinearLimitDamping_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearSoftLimitParams_FunctionAddress, "LinearLimitDamping", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearSoftLimitParams_LinearLimitRestitution_PropertyAddress, SetLinearSoftLimitParams_FunctionAddress, "LinearLimitRestitution");
		SetLinearSoftLimitParams_LinearLimitRestitution_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearSoftLimitParams_FunctionAddress, "LinearLimitRestitution");
		SetLinearSoftLimitParams_LinearLimitRestitution_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearSoftLimitParams_FunctionAddress, "LinearLimitRestitution", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearSoftLimitParams_LinearLimitContactDistance_PropertyAddress, SetLinearSoftLimitParams_FunctionAddress, "LinearLimitContactDistance");
		SetLinearSoftLimitParams_LinearLimitContactDistance_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearSoftLimitParams_FunctionAddress, "LinearLimitContactDistance");
		SetLinearSoftLimitParams_LinearLimitContactDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearSoftLimitParams_FunctionAddress, "LinearLimitContactDistance", Classes.FFloatProperty);
		SetLinearSoftLimitParams_IsValid = SetLinearSoftLimitParams_FunctionAddress != IntPtr.Zero && SetLinearSoftLimitParams_Accessor_IsValid && SetLinearSoftLimitParams_bSoftLinearLimit_IsValid && SetLinearSoftLimitParams_LinearLimitStiffness_IsValid && SetLinearSoftLimitParams_LinearLimitDamping_IsValid && SetLinearSoftLimitParams_LinearLimitRestitution_IsValid && SetLinearSoftLimitParams_LinearLimitContactDistance_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearSoftLimitParams", SetLinearSoftLimitParams_IsValid);
		SetLinearPositionTarget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLinearPositionTarget");
		SetLinearPositionTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLinearPositionTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLinearPositionTarget_Accessor_PropertyAddress, SetLinearPositionTarget_FunctionAddress, "Accessor");
		SetLinearPositionTarget_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearPositionTarget_FunctionAddress, "Accessor");
		SetLinearPositionTarget_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearPositionTarget_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearPositionTarget_InPosTarget_PropertyAddress, SetLinearPositionTarget_FunctionAddress, "InPosTarget");
		SetLinearPositionTarget_InPosTarget_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearPositionTarget_FunctionAddress, "InPosTarget");
		SetLinearPositionTarget_InPosTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearPositionTarget_FunctionAddress, "InPosTarget", Classes.FStructProperty);
		SetLinearPositionTarget_IsValid = SetLinearPositionTarget_FunctionAddress != IntPtr.Zero && SetLinearPositionTarget_Accessor_IsValid && SetLinearPositionTarget_InPosTarget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearPositionTarget", SetLinearPositionTarget_IsValid);
		SetLinearPositionDrive_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLinearPositionDrive");
		SetLinearPositionDrive_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLinearPositionDrive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLinearPositionDrive_Accessor_PropertyAddress, SetLinearPositionDrive_FunctionAddress, "Accessor");
		SetLinearPositionDrive_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearPositionDrive_FunctionAddress, "Accessor");
		SetLinearPositionDrive_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearPositionDrive_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearPositionDrive_bEnableDriveX_PropertyAddress, SetLinearPositionDrive_FunctionAddress, "bEnableDriveX");
		SetLinearPositionDrive_bEnableDriveX_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearPositionDrive_FunctionAddress, "bEnableDriveX");
		SetLinearPositionDrive_bEnableDriveX_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearPositionDrive_FunctionAddress, "bEnableDriveX", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearPositionDrive_bEnableDriveY_PropertyAddress, SetLinearPositionDrive_FunctionAddress, "bEnableDriveY");
		SetLinearPositionDrive_bEnableDriveY_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearPositionDrive_FunctionAddress, "bEnableDriveY");
		SetLinearPositionDrive_bEnableDriveY_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearPositionDrive_FunctionAddress, "bEnableDriveY", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearPositionDrive_bEnableDriveZ_PropertyAddress, SetLinearPositionDrive_FunctionAddress, "bEnableDriveZ");
		SetLinearPositionDrive_bEnableDriveZ_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearPositionDrive_FunctionAddress, "bEnableDriveZ");
		SetLinearPositionDrive_bEnableDriveZ_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearPositionDrive_FunctionAddress, "bEnableDriveZ", Classes.FBoolProperty);
		SetLinearPositionDrive_IsValid = SetLinearPositionDrive_FunctionAddress != IntPtr.Zero && SetLinearPositionDrive_Accessor_IsValid && SetLinearPositionDrive_bEnableDriveX_IsValid && SetLinearPositionDrive_bEnableDriveY_IsValid && SetLinearPositionDrive_bEnableDriveZ_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearPositionDrive", SetLinearPositionDrive_IsValid);
		SetLinearPlasticity_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLinearPlasticity");
		SetLinearPlasticity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLinearPlasticity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLinearPlasticity_Accessor_PropertyAddress, SetLinearPlasticity_FunctionAddress, "Accessor");
		SetLinearPlasticity_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearPlasticity_FunctionAddress, "Accessor");
		SetLinearPlasticity_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearPlasticity_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearPlasticity_bLinearPlasticity_PropertyAddress, SetLinearPlasticity_FunctionAddress, "bLinearPlasticity");
		SetLinearPlasticity_bLinearPlasticity_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearPlasticity_FunctionAddress, "bLinearPlasticity");
		SetLinearPlasticity_bLinearPlasticity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearPlasticity_FunctionAddress, "bLinearPlasticity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearPlasticity_LinearPlasticityThreshold_PropertyAddress, SetLinearPlasticity_FunctionAddress, "LinearPlasticityThreshold");
		SetLinearPlasticity_LinearPlasticityThreshold_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearPlasticity_FunctionAddress, "LinearPlasticityThreshold");
		SetLinearPlasticity_LinearPlasticityThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearPlasticity_FunctionAddress, "LinearPlasticityThreshold", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearPlasticity_PlasticityType_PropertyAddress, SetLinearPlasticity_FunctionAddress, "PlasticityType");
		SetLinearPlasticity_PlasticityType_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearPlasticity_FunctionAddress, "PlasticityType");
		SetLinearPlasticity_PlasticityType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearPlasticity_FunctionAddress, "PlasticityType", Classes.FByteProperty);
		SetLinearPlasticity_IsValid = SetLinearPlasticity_FunctionAddress != IntPtr.Zero && SetLinearPlasticity_Accessor_IsValid && SetLinearPlasticity_bLinearPlasticity_IsValid && SetLinearPlasticity_LinearPlasticityThreshold_IsValid && SetLinearPlasticity_PlasticityType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearPlasticity", SetLinearPlasticity_IsValid);
		SetLinearLimits_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLinearLimits");
		SetLinearLimits_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLinearLimits_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLinearLimits_Accessor_PropertyAddress, SetLinearLimits_FunctionAddress, "Accessor");
		SetLinearLimits_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearLimits_FunctionAddress, "Accessor");
		SetLinearLimits_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearLimits_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearLimits_XMotion_PropertyAddress, SetLinearLimits_FunctionAddress, "XMotion");
		SetLinearLimits_XMotion_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearLimits_FunctionAddress, "XMotion");
		SetLinearLimits_XMotion_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearLimits_FunctionAddress, "XMotion", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearLimits_YMotion_PropertyAddress, SetLinearLimits_FunctionAddress, "YMotion");
		SetLinearLimits_YMotion_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearLimits_FunctionAddress, "YMotion");
		SetLinearLimits_YMotion_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearLimits_FunctionAddress, "YMotion", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearLimits_ZMotion_PropertyAddress, SetLinearLimits_FunctionAddress, "ZMotion");
		SetLinearLimits_ZMotion_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearLimits_FunctionAddress, "ZMotion");
		SetLinearLimits_ZMotion_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearLimits_FunctionAddress, "ZMotion", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearLimits_Limit_PropertyAddress, SetLinearLimits_FunctionAddress, "Limit");
		SetLinearLimits_Limit_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearLimits_FunctionAddress, "Limit");
		SetLinearLimits_Limit_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearLimits_FunctionAddress, "Limit", Classes.FFloatProperty);
		SetLinearLimits_IsValid = SetLinearLimits_FunctionAddress != IntPtr.Zero && SetLinearLimits_Accessor_IsValid && SetLinearLimits_XMotion_IsValid && SetLinearLimits_YMotion_IsValid && SetLinearLimits_ZMotion_IsValid && SetLinearLimits_Limit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearLimits", SetLinearLimits_IsValid);
		SetLinearDriveParams_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLinearDriveParams");
		SetLinearDriveParams_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLinearDriveParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLinearDriveParams_Accessor_PropertyAddress, SetLinearDriveParams_FunctionAddress, "Accessor");
		SetLinearDriveParams_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearDriveParams_FunctionAddress, "Accessor");
		SetLinearDriveParams_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearDriveParams_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearDriveParams_PositionStrength_PropertyAddress, SetLinearDriveParams_FunctionAddress, "PositionStrength");
		SetLinearDriveParams_PositionStrength_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearDriveParams_FunctionAddress, "PositionStrength");
		SetLinearDriveParams_PositionStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearDriveParams_FunctionAddress, "PositionStrength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearDriveParams_VelocityStrength_PropertyAddress, SetLinearDriveParams_FunctionAddress, "VelocityStrength");
		SetLinearDriveParams_VelocityStrength_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearDriveParams_FunctionAddress, "VelocityStrength");
		SetLinearDriveParams_VelocityStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearDriveParams_FunctionAddress, "VelocityStrength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearDriveParams_InForceLimit_PropertyAddress, SetLinearDriveParams_FunctionAddress, "InForceLimit");
		SetLinearDriveParams_InForceLimit_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearDriveParams_FunctionAddress, "InForceLimit");
		SetLinearDriveParams_InForceLimit_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearDriveParams_FunctionAddress, "InForceLimit", Classes.FFloatProperty);
		SetLinearDriveParams_IsValid = SetLinearDriveParams_FunctionAddress != IntPtr.Zero && SetLinearDriveParams_Accessor_IsValid && SetLinearDriveParams_PositionStrength_IsValid && SetLinearDriveParams_VelocityStrength_IsValid && SetLinearDriveParams_InForceLimit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearDriveParams", SetLinearDriveParams_IsValid);
		SetLinearBreakable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLinearBreakable");
		SetLinearBreakable_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLinearBreakable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLinearBreakable_Accessor_PropertyAddress, SetLinearBreakable_FunctionAddress, "Accessor");
		SetLinearBreakable_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearBreakable_FunctionAddress, "Accessor");
		SetLinearBreakable_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearBreakable_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearBreakable_bLinearBreakable_PropertyAddress, SetLinearBreakable_FunctionAddress, "bLinearBreakable");
		SetLinearBreakable_bLinearBreakable_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearBreakable_FunctionAddress, "bLinearBreakable");
		SetLinearBreakable_bLinearBreakable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearBreakable_FunctionAddress, "bLinearBreakable", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearBreakable_LinearBreakThreshold_PropertyAddress, SetLinearBreakable_FunctionAddress, "LinearBreakThreshold");
		SetLinearBreakable_LinearBreakThreshold_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearBreakable_FunctionAddress, "LinearBreakThreshold");
		SetLinearBreakable_LinearBreakThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearBreakable_FunctionAddress, "LinearBreakThreshold", Classes.FFloatProperty);
		SetLinearBreakable_IsValid = SetLinearBreakable_FunctionAddress != IntPtr.Zero && SetLinearBreakable_Accessor_IsValid && SetLinearBreakable_bLinearBreakable_IsValid && SetLinearBreakable_LinearBreakThreshold_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetLinearBreakable", SetLinearBreakable_IsValid);
		SetDisableCollision_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetDisableCollision");
		SetDisableCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDisableCollision_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDisableCollision_Accessor_PropertyAddress, SetDisableCollision_FunctionAddress, "Accessor");
		SetDisableCollision_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetDisableCollision_FunctionAddress, "Accessor");
		SetDisableCollision_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDisableCollision_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDisableCollision_bDisableCollision_PropertyAddress, SetDisableCollision_FunctionAddress, "bDisableCollision");
		SetDisableCollision_bDisableCollision_Offset = NativeReflectionCached.GetPropertyOffset(SetDisableCollision_FunctionAddress, "bDisableCollision");
		SetDisableCollision_bDisableCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDisableCollision_FunctionAddress, "bDisableCollision", Classes.FBoolProperty);
		SetDisableCollision_IsValid = SetDisableCollision_FunctionAddress != IntPtr.Zero && SetDisableCollision_Accessor_IsValid && SetDisableCollision_bDisableCollision_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetDisableCollision", SetDisableCollision_IsValid);
		SetContactTransferScale_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetContactTransferScale");
		SetContactTransferScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetContactTransferScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetContactTransferScale_Accessor_PropertyAddress, SetContactTransferScale_FunctionAddress, "Accessor");
		SetContactTransferScale_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetContactTransferScale_FunctionAddress, "Accessor");
		SetContactTransferScale_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetContactTransferScale_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetContactTransferScale_ContactTransferScale_PropertyAddress, SetContactTransferScale_FunctionAddress, "ContactTransferScale");
		SetContactTransferScale_ContactTransferScale_Offset = NativeReflectionCached.GetPropertyOffset(SetContactTransferScale_FunctionAddress, "ContactTransferScale");
		SetContactTransferScale_ContactTransferScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetContactTransferScale_FunctionAddress, "ContactTransferScale", Classes.FFloatProperty);
		SetContactTransferScale_IsValid = SetContactTransferScale_FunctionAddress != IntPtr.Zero && SetContactTransferScale_Accessor_IsValid && SetContactTransferScale_ContactTransferScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetContactTransferScale", SetContactTransferScale_IsValid);
		SetAngularVelocityTarget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAngularVelocityTarget");
		SetAngularVelocityTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAngularVelocityTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAngularVelocityTarget_Accessor_PropertyAddress, SetAngularVelocityTarget_FunctionAddress, "Accessor");
		SetAngularVelocityTarget_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularVelocityTarget_FunctionAddress, "Accessor");
		SetAngularVelocityTarget_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularVelocityTarget_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularVelocityTarget_InVelTarget_PropertyAddress, SetAngularVelocityTarget_FunctionAddress, "InVelTarget");
		SetAngularVelocityTarget_InVelTarget_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularVelocityTarget_FunctionAddress, "InVelTarget");
		SetAngularVelocityTarget_InVelTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularVelocityTarget_FunctionAddress, "InVelTarget", Classes.FStructProperty);
		SetAngularVelocityTarget_IsValid = SetAngularVelocityTarget_FunctionAddress != IntPtr.Zero && SetAngularVelocityTarget_Accessor_IsValid && SetAngularVelocityTarget_InVelTarget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularVelocityTarget", SetAngularVelocityTarget_IsValid);
		SetAngularVelocityDriveTwistAndSwing_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAngularVelocityDriveTwistAndSwing");
		SetAngularVelocityDriveTwistAndSwing_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAngularVelocityDriveTwistAndSwing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAngularVelocityDriveTwistAndSwing_Accessor_PropertyAddress, SetAngularVelocityDriveTwistAndSwing_FunctionAddress, "Accessor");
		SetAngularVelocityDriveTwistAndSwing_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularVelocityDriveTwistAndSwing_FunctionAddress, "Accessor");
		SetAngularVelocityDriveTwistAndSwing_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularVelocityDriveTwistAndSwing_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularVelocityDriveTwistAndSwing_bEnableTwistDrive_PropertyAddress, SetAngularVelocityDriveTwistAndSwing_FunctionAddress, "bEnableTwistDrive");
		SetAngularVelocityDriveTwistAndSwing_bEnableTwistDrive_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularVelocityDriveTwistAndSwing_FunctionAddress, "bEnableTwistDrive");
		SetAngularVelocityDriveTwistAndSwing_bEnableTwistDrive_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularVelocityDriveTwistAndSwing_FunctionAddress, "bEnableTwistDrive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularVelocityDriveTwistAndSwing_bEnableSwingDrive_PropertyAddress, SetAngularVelocityDriveTwistAndSwing_FunctionAddress, "bEnableSwingDrive");
		SetAngularVelocityDriveTwistAndSwing_bEnableSwingDrive_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularVelocityDriveTwistAndSwing_FunctionAddress, "bEnableSwingDrive");
		SetAngularVelocityDriveTwistAndSwing_bEnableSwingDrive_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularVelocityDriveTwistAndSwing_FunctionAddress, "bEnableSwingDrive", Classes.FBoolProperty);
		SetAngularVelocityDriveTwistAndSwing_IsValid = SetAngularVelocityDriveTwistAndSwing_FunctionAddress != IntPtr.Zero && SetAngularVelocityDriveTwistAndSwing_Accessor_IsValid && SetAngularVelocityDriveTwistAndSwing_bEnableTwistDrive_IsValid && SetAngularVelocityDriveTwistAndSwing_bEnableSwingDrive_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularVelocityDriveTwistAndSwing", SetAngularVelocityDriveTwistAndSwing_IsValid);
		SetAngularVelocityDriveSLERP_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAngularVelocityDriveSLERP");
		SetAngularVelocityDriveSLERP_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAngularVelocityDriveSLERP_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAngularVelocityDriveSLERP_Accessor_PropertyAddress, SetAngularVelocityDriveSLERP_FunctionAddress, "Accessor");
		SetAngularVelocityDriveSLERP_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularVelocityDriveSLERP_FunctionAddress, "Accessor");
		SetAngularVelocityDriveSLERP_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularVelocityDriveSLERP_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularVelocityDriveSLERP_bEnableSLERP_PropertyAddress, SetAngularVelocityDriveSLERP_FunctionAddress, "bEnableSLERP");
		SetAngularVelocityDriveSLERP_bEnableSLERP_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularVelocityDriveSLERP_FunctionAddress, "bEnableSLERP");
		SetAngularVelocityDriveSLERP_bEnableSLERP_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularVelocityDriveSLERP_FunctionAddress, "bEnableSLERP", Classes.FBoolProperty);
		SetAngularVelocityDriveSLERP_IsValid = SetAngularVelocityDriveSLERP_FunctionAddress != IntPtr.Zero && SetAngularVelocityDriveSLERP_Accessor_IsValid && SetAngularVelocityDriveSLERP_bEnableSLERP_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularVelocityDriveSLERP", SetAngularVelocityDriveSLERP_IsValid);
		SetAngularSoftTwistLimitParams_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAngularSoftTwistLimitParams");
		SetAngularSoftTwistLimitParams_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAngularSoftTwistLimitParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAngularSoftTwistLimitParams_Accessor_PropertyAddress, SetAngularSoftTwistLimitParams_FunctionAddress, "Accessor");
		SetAngularSoftTwistLimitParams_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularSoftTwistLimitParams_FunctionAddress, "Accessor");
		SetAngularSoftTwistLimitParams_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularSoftTwistLimitParams_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularSoftTwistLimitParams_bSoftTwistLimit_PropertyAddress, SetAngularSoftTwistLimitParams_FunctionAddress, "bSoftTwistLimit");
		SetAngularSoftTwistLimitParams_bSoftTwistLimit_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularSoftTwistLimitParams_FunctionAddress, "bSoftTwistLimit");
		SetAngularSoftTwistLimitParams_bSoftTwistLimit_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularSoftTwistLimitParams_FunctionAddress, "bSoftTwistLimit", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularSoftTwistLimitParams_TwistLimitStiffness_PropertyAddress, SetAngularSoftTwistLimitParams_FunctionAddress, "TwistLimitStiffness");
		SetAngularSoftTwistLimitParams_TwistLimitStiffness_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularSoftTwistLimitParams_FunctionAddress, "TwistLimitStiffness");
		SetAngularSoftTwistLimitParams_TwistLimitStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularSoftTwistLimitParams_FunctionAddress, "TwistLimitStiffness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularSoftTwistLimitParams_TwistLimitDamping_PropertyAddress, SetAngularSoftTwistLimitParams_FunctionAddress, "TwistLimitDamping");
		SetAngularSoftTwistLimitParams_TwistLimitDamping_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularSoftTwistLimitParams_FunctionAddress, "TwistLimitDamping");
		SetAngularSoftTwistLimitParams_TwistLimitDamping_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularSoftTwistLimitParams_FunctionAddress, "TwistLimitDamping", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularSoftTwistLimitParams_TwistLimitRestitution_PropertyAddress, SetAngularSoftTwistLimitParams_FunctionAddress, "TwistLimitRestitution");
		SetAngularSoftTwistLimitParams_TwistLimitRestitution_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularSoftTwistLimitParams_FunctionAddress, "TwistLimitRestitution");
		SetAngularSoftTwistLimitParams_TwistLimitRestitution_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularSoftTwistLimitParams_FunctionAddress, "TwistLimitRestitution", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularSoftTwistLimitParams_TwistLimitContactDistance_PropertyAddress, SetAngularSoftTwistLimitParams_FunctionAddress, "TwistLimitContactDistance");
		SetAngularSoftTwistLimitParams_TwistLimitContactDistance_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularSoftTwistLimitParams_FunctionAddress, "TwistLimitContactDistance");
		SetAngularSoftTwistLimitParams_TwistLimitContactDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularSoftTwistLimitParams_FunctionAddress, "TwistLimitContactDistance", Classes.FFloatProperty);
		SetAngularSoftTwistLimitParams_IsValid = SetAngularSoftTwistLimitParams_FunctionAddress != IntPtr.Zero && SetAngularSoftTwistLimitParams_Accessor_IsValid && SetAngularSoftTwistLimitParams_bSoftTwistLimit_IsValid && SetAngularSoftTwistLimitParams_TwistLimitStiffness_IsValid && SetAngularSoftTwistLimitParams_TwistLimitDamping_IsValid && SetAngularSoftTwistLimitParams_TwistLimitRestitution_IsValid && SetAngularSoftTwistLimitParams_TwistLimitContactDistance_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularSoftTwistLimitParams", SetAngularSoftTwistLimitParams_IsValid);
		SetAngularSoftSwingLimitParams_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAngularSoftSwingLimitParams");
		SetAngularSoftSwingLimitParams_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAngularSoftSwingLimitParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAngularSoftSwingLimitParams_Accessor_PropertyAddress, SetAngularSoftSwingLimitParams_FunctionAddress, "Accessor");
		SetAngularSoftSwingLimitParams_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularSoftSwingLimitParams_FunctionAddress, "Accessor");
		SetAngularSoftSwingLimitParams_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularSoftSwingLimitParams_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularSoftSwingLimitParams_bSoftSwingLimit_PropertyAddress, SetAngularSoftSwingLimitParams_FunctionAddress, "bSoftSwingLimit");
		SetAngularSoftSwingLimitParams_bSoftSwingLimit_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularSoftSwingLimitParams_FunctionAddress, "bSoftSwingLimit");
		SetAngularSoftSwingLimitParams_bSoftSwingLimit_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularSoftSwingLimitParams_FunctionAddress, "bSoftSwingLimit", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularSoftSwingLimitParams_SwingLimitStiffness_PropertyAddress, SetAngularSoftSwingLimitParams_FunctionAddress, "SwingLimitStiffness");
		SetAngularSoftSwingLimitParams_SwingLimitStiffness_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularSoftSwingLimitParams_FunctionAddress, "SwingLimitStiffness");
		SetAngularSoftSwingLimitParams_SwingLimitStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularSoftSwingLimitParams_FunctionAddress, "SwingLimitStiffness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularSoftSwingLimitParams_SwingLimitDamping_PropertyAddress, SetAngularSoftSwingLimitParams_FunctionAddress, "SwingLimitDamping");
		SetAngularSoftSwingLimitParams_SwingLimitDamping_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularSoftSwingLimitParams_FunctionAddress, "SwingLimitDamping");
		SetAngularSoftSwingLimitParams_SwingLimitDamping_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularSoftSwingLimitParams_FunctionAddress, "SwingLimitDamping", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularSoftSwingLimitParams_SwingLimitRestitution_PropertyAddress, SetAngularSoftSwingLimitParams_FunctionAddress, "SwingLimitRestitution");
		SetAngularSoftSwingLimitParams_SwingLimitRestitution_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularSoftSwingLimitParams_FunctionAddress, "SwingLimitRestitution");
		SetAngularSoftSwingLimitParams_SwingLimitRestitution_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularSoftSwingLimitParams_FunctionAddress, "SwingLimitRestitution", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularSoftSwingLimitParams_SwingLimitContactDistance_PropertyAddress, SetAngularSoftSwingLimitParams_FunctionAddress, "SwingLimitContactDistance");
		SetAngularSoftSwingLimitParams_SwingLimitContactDistance_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularSoftSwingLimitParams_FunctionAddress, "SwingLimitContactDistance");
		SetAngularSoftSwingLimitParams_SwingLimitContactDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularSoftSwingLimitParams_FunctionAddress, "SwingLimitContactDistance", Classes.FFloatProperty);
		SetAngularSoftSwingLimitParams_IsValid = SetAngularSoftSwingLimitParams_FunctionAddress != IntPtr.Zero && SetAngularSoftSwingLimitParams_Accessor_IsValid && SetAngularSoftSwingLimitParams_bSoftSwingLimit_IsValid && SetAngularSoftSwingLimitParams_SwingLimitStiffness_IsValid && SetAngularSoftSwingLimitParams_SwingLimitDamping_IsValid && SetAngularSoftSwingLimitParams_SwingLimitRestitution_IsValid && SetAngularSoftSwingLimitParams_SwingLimitContactDistance_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularSoftSwingLimitParams", SetAngularSoftSwingLimitParams_IsValid);
		SetAngularPlasticity_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAngularPlasticity");
		SetAngularPlasticity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAngularPlasticity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAngularPlasticity_Accessor_PropertyAddress, SetAngularPlasticity_FunctionAddress, "Accessor");
		SetAngularPlasticity_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularPlasticity_FunctionAddress, "Accessor");
		SetAngularPlasticity_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularPlasticity_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularPlasticity_bAngularPlasticity_PropertyAddress, SetAngularPlasticity_FunctionAddress, "bAngularPlasticity");
		SetAngularPlasticity_bAngularPlasticity_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularPlasticity_FunctionAddress, "bAngularPlasticity");
		SetAngularPlasticity_bAngularPlasticity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularPlasticity_FunctionAddress, "bAngularPlasticity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularPlasticity_AngularPlasticityThreshold_PropertyAddress, SetAngularPlasticity_FunctionAddress, "AngularPlasticityThreshold");
		SetAngularPlasticity_AngularPlasticityThreshold_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularPlasticity_FunctionAddress, "AngularPlasticityThreshold");
		SetAngularPlasticity_AngularPlasticityThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularPlasticity_FunctionAddress, "AngularPlasticityThreshold", Classes.FFloatProperty);
		SetAngularPlasticity_IsValid = SetAngularPlasticity_FunctionAddress != IntPtr.Zero && SetAngularPlasticity_Accessor_IsValid && SetAngularPlasticity_bAngularPlasticity_IsValid && SetAngularPlasticity_AngularPlasticityThreshold_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularPlasticity", SetAngularPlasticity_IsValid);
		SetAngularOrientationTarget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAngularOrientationTarget");
		SetAngularOrientationTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAngularOrientationTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAngularOrientationTarget_Accessor_PropertyAddress, SetAngularOrientationTarget_FunctionAddress, "Accessor");
		SetAngularOrientationTarget_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularOrientationTarget_FunctionAddress, "Accessor");
		SetAngularOrientationTarget_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularOrientationTarget_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularOrientationTarget_InPosTarget_PropertyAddress, SetAngularOrientationTarget_FunctionAddress, "InPosTarget");
		SetAngularOrientationTarget_InPosTarget_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularOrientationTarget_FunctionAddress, "InPosTarget");
		SetAngularOrientationTarget_InPosTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularOrientationTarget_FunctionAddress, "InPosTarget", Classes.FStructProperty);
		SetAngularOrientationTarget_IsValid = SetAngularOrientationTarget_FunctionAddress != IntPtr.Zero && SetAngularOrientationTarget_Accessor_IsValid && SetAngularOrientationTarget_InPosTarget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularOrientationTarget", SetAngularOrientationTarget_IsValid);
		SetAngularLimits_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAngularLimits");
		SetAngularLimits_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAngularLimits_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAngularLimits_Accessor_PropertyAddress, SetAngularLimits_FunctionAddress, "Accessor");
		SetAngularLimits_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularLimits_FunctionAddress, "Accessor");
		SetAngularLimits_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularLimits_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularLimits_Swing1MotionType_PropertyAddress, SetAngularLimits_FunctionAddress, "Swing1MotionType");
		SetAngularLimits_Swing1MotionType_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularLimits_FunctionAddress, "Swing1MotionType");
		SetAngularLimits_Swing1MotionType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularLimits_FunctionAddress, "Swing1MotionType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularLimits_Swing1LimitAngle_PropertyAddress, SetAngularLimits_FunctionAddress, "Swing1LimitAngle");
		SetAngularLimits_Swing1LimitAngle_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularLimits_FunctionAddress, "Swing1LimitAngle");
		SetAngularLimits_Swing1LimitAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularLimits_FunctionAddress, "Swing1LimitAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularLimits_Swing2MotionType_PropertyAddress, SetAngularLimits_FunctionAddress, "Swing2MotionType");
		SetAngularLimits_Swing2MotionType_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularLimits_FunctionAddress, "Swing2MotionType");
		SetAngularLimits_Swing2MotionType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularLimits_FunctionAddress, "Swing2MotionType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularLimits_Swing2LimitAngle_PropertyAddress, SetAngularLimits_FunctionAddress, "Swing2LimitAngle");
		SetAngularLimits_Swing2LimitAngle_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularLimits_FunctionAddress, "Swing2LimitAngle");
		SetAngularLimits_Swing2LimitAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularLimits_FunctionAddress, "Swing2LimitAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularLimits_TwistMotionType_PropertyAddress, SetAngularLimits_FunctionAddress, "TwistMotionType");
		SetAngularLimits_TwistMotionType_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularLimits_FunctionAddress, "TwistMotionType");
		SetAngularLimits_TwistMotionType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularLimits_FunctionAddress, "TwistMotionType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularLimits_TwistLimitAngle_PropertyAddress, SetAngularLimits_FunctionAddress, "TwistLimitAngle");
		SetAngularLimits_TwistLimitAngle_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularLimits_FunctionAddress, "TwistLimitAngle");
		SetAngularLimits_TwistLimitAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularLimits_FunctionAddress, "TwistLimitAngle", Classes.FFloatProperty);
		SetAngularLimits_IsValid = SetAngularLimits_FunctionAddress != IntPtr.Zero && SetAngularLimits_Accessor_IsValid && SetAngularLimits_Swing1MotionType_IsValid && SetAngularLimits_Swing1LimitAngle_IsValid && SetAngularLimits_Swing2MotionType_IsValid && SetAngularLimits_Swing2LimitAngle_IsValid && SetAngularLimits_TwistMotionType_IsValid && SetAngularLimits_TwistLimitAngle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularLimits", SetAngularLimits_IsValid);
		SetAngularDriveParams_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAngularDriveParams");
		SetAngularDriveParams_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAngularDriveParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAngularDriveParams_Accessor_PropertyAddress, SetAngularDriveParams_FunctionAddress, "Accessor");
		SetAngularDriveParams_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularDriveParams_FunctionAddress, "Accessor");
		SetAngularDriveParams_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularDriveParams_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularDriveParams_PositionStrength_PropertyAddress, SetAngularDriveParams_FunctionAddress, "PositionStrength");
		SetAngularDriveParams_PositionStrength_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularDriveParams_FunctionAddress, "PositionStrength");
		SetAngularDriveParams_PositionStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularDriveParams_FunctionAddress, "PositionStrength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularDriveParams_VelocityStrength_PropertyAddress, SetAngularDriveParams_FunctionAddress, "VelocityStrength");
		SetAngularDriveParams_VelocityStrength_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularDriveParams_FunctionAddress, "VelocityStrength");
		SetAngularDriveParams_VelocityStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularDriveParams_FunctionAddress, "VelocityStrength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularDriveParams_InForceLimit_PropertyAddress, SetAngularDriveParams_FunctionAddress, "InForceLimit");
		SetAngularDriveParams_InForceLimit_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularDriveParams_FunctionAddress, "InForceLimit");
		SetAngularDriveParams_InForceLimit_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularDriveParams_FunctionAddress, "InForceLimit", Classes.FFloatProperty);
		SetAngularDriveParams_IsValid = SetAngularDriveParams_FunctionAddress != IntPtr.Zero && SetAngularDriveParams_Accessor_IsValid && SetAngularDriveParams_PositionStrength_IsValid && SetAngularDriveParams_VelocityStrength_IsValid && SetAngularDriveParams_InForceLimit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularDriveParams", SetAngularDriveParams_IsValid);
		SetAngularDriveMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAngularDriveMode");
		SetAngularDriveMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAngularDriveMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAngularDriveMode_Accessor_PropertyAddress, SetAngularDriveMode_FunctionAddress, "Accessor");
		SetAngularDriveMode_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularDriveMode_FunctionAddress, "Accessor");
		SetAngularDriveMode_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularDriveMode_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularDriveMode_DriveMode_PropertyAddress, SetAngularDriveMode_FunctionAddress, "DriveMode");
		SetAngularDriveMode_DriveMode_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularDriveMode_FunctionAddress, "DriveMode");
		SetAngularDriveMode_DriveMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularDriveMode_FunctionAddress, "DriveMode", Classes.FByteProperty);
		SetAngularDriveMode_IsValid = SetAngularDriveMode_FunctionAddress != IntPtr.Zero && SetAngularDriveMode_Accessor_IsValid && SetAngularDriveMode_DriveMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularDriveMode", SetAngularDriveMode_IsValid);
		SetAngularBreakable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAngularBreakable");
		SetAngularBreakable_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAngularBreakable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAngularBreakable_Accessor_PropertyAddress, SetAngularBreakable_FunctionAddress, "Accessor");
		SetAngularBreakable_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularBreakable_FunctionAddress, "Accessor");
		SetAngularBreakable_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularBreakable_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularBreakable_bAngularBreakable_PropertyAddress, SetAngularBreakable_FunctionAddress, "bAngularBreakable");
		SetAngularBreakable_bAngularBreakable_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularBreakable_FunctionAddress, "bAngularBreakable");
		SetAngularBreakable_bAngularBreakable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularBreakable_FunctionAddress, "bAngularBreakable", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularBreakable_AngularBreakThreshold_PropertyAddress, SetAngularBreakable_FunctionAddress, "AngularBreakThreshold");
		SetAngularBreakable_AngularBreakThreshold_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularBreakable_FunctionAddress, "AngularBreakThreshold");
		SetAngularBreakable_AngularBreakThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularBreakable_FunctionAddress, "AngularBreakThreshold", Classes.FFloatProperty);
		SetAngularBreakable_IsValid = SetAngularBreakable_FunctionAddress != IntPtr.Zero && SetAngularBreakable_Accessor_IsValid && SetAngularBreakable_bAngularBreakable_IsValid && SetAngularBreakable_AngularBreakThreshold_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:SetAngularBreakable", SetAngularBreakable_IsValid);
		GetProjectionParams_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetProjectionParams");
		GetProjectionParams_ParamsSize = NativeReflection.GetFunctionParamsSize(GetProjectionParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetProjectionParams_Accessor_PropertyAddress, GetProjectionParams_FunctionAddress, "Accessor");
		GetProjectionParams_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetProjectionParams_FunctionAddress, "Accessor");
		GetProjectionParams_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetProjectionParams_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetProjectionParams_bEnableProjection_PropertyAddress, GetProjectionParams_FunctionAddress, "bEnableProjection");
		GetProjectionParams_bEnableProjection_Offset = NativeReflectionCached.GetPropertyOffset(GetProjectionParams_FunctionAddress, "bEnableProjection");
		GetProjectionParams_bEnableProjection_IsValid = NativeReflectionCached.ValidatePropertyClass(GetProjectionParams_FunctionAddress, "bEnableProjection", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetProjectionParams_ProjectionLinearAlpha_PropertyAddress, GetProjectionParams_FunctionAddress, "ProjectionLinearAlpha");
		GetProjectionParams_ProjectionLinearAlpha_Offset = NativeReflectionCached.GetPropertyOffset(GetProjectionParams_FunctionAddress, "ProjectionLinearAlpha");
		GetProjectionParams_ProjectionLinearAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(GetProjectionParams_FunctionAddress, "ProjectionLinearAlpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetProjectionParams_ProjectionAngularAlpha_PropertyAddress, GetProjectionParams_FunctionAddress, "ProjectionAngularAlpha");
		GetProjectionParams_ProjectionAngularAlpha_Offset = NativeReflectionCached.GetPropertyOffset(GetProjectionParams_FunctionAddress, "ProjectionAngularAlpha");
		GetProjectionParams_ProjectionAngularAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(GetProjectionParams_FunctionAddress, "ProjectionAngularAlpha", Classes.FFloatProperty);
		GetProjectionParams_IsValid = GetProjectionParams_FunctionAddress != IntPtr.Zero && GetProjectionParams_Accessor_IsValid && GetProjectionParams_bEnableProjection_IsValid && GetProjectionParams_ProjectionLinearAlpha_IsValid && GetProjectionParams_ProjectionAngularAlpha_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetProjectionParams", GetProjectionParams_IsValid);
		GetParentDominates_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetParentDominates");
		GetParentDominates_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParentDominates_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParentDominates_Accessor_PropertyAddress, GetParentDominates_FunctionAddress, "Accessor");
		GetParentDominates_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetParentDominates_FunctionAddress, "Accessor");
		GetParentDominates_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentDominates_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParentDominates_ReturnValue_PropertyAddress, GetParentDominates_FunctionAddress, "ReturnValue");
		GetParentDominates_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParentDominates_FunctionAddress, "ReturnValue");
		GetParentDominates_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentDominates_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetParentDominates_IsValid = GetParentDominates_FunctionAddress != IntPtr.Zero && GetParentDominates_Accessor_IsValid && GetParentDominates_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetParentDominates", GetParentDominates_IsValid);
		GetOrientationDriveTwistAndSwing_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetOrientationDriveTwistAndSwing");
		GetOrientationDriveTwistAndSwing_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOrientationDriveTwistAndSwing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOrientationDriveTwistAndSwing_Accessor_PropertyAddress, GetOrientationDriveTwistAndSwing_FunctionAddress, "Accessor");
		GetOrientationDriveTwistAndSwing_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetOrientationDriveTwistAndSwing_FunctionAddress, "Accessor");
		GetOrientationDriveTwistAndSwing_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOrientationDriveTwistAndSwing_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOrientationDriveTwistAndSwing_bOutEnableTwistDrive_PropertyAddress, GetOrientationDriveTwistAndSwing_FunctionAddress, "bOutEnableTwistDrive");
		GetOrientationDriveTwistAndSwing_bOutEnableTwistDrive_Offset = NativeReflectionCached.GetPropertyOffset(GetOrientationDriveTwistAndSwing_FunctionAddress, "bOutEnableTwistDrive");
		GetOrientationDriveTwistAndSwing_bOutEnableTwistDrive_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOrientationDriveTwistAndSwing_FunctionAddress, "bOutEnableTwistDrive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOrientationDriveTwistAndSwing_bOutEnableSwingDrive_PropertyAddress, GetOrientationDriveTwistAndSwing_FunctionAddress, "bOutEnableSwingDrive");
		GetOrientationDriveTwistAndSwing_bOutEnableSwingDrive_Offset = NativeReflectionCached.GetPropertyOffset(GetOrientationDriveTwistAndSwing_FunctionAddress, "bOutEnableSwingDrive");
		GetOrientationDriveTwistAndSwing_bOutEnableSwingDrive_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOrientationDriveTwistAndSwing_FunctionAddress, "bOutEnableSwingDrive", Classes.FBoolProperty);
		GetOrientationDriveTwistAndSwing_IsValid = GetOrientationDriveTwistAndSwing_FunctionAddress != IntPtr.Zero && GetOrientationDriveTwistAndSwing_Accessor_IsValid && GetOrientationDriveTwistAndSwing_bOutEnableTwistDrive_IsValid && GetOrientationDriveTwistAndSwing_bOutEnableSwingDrive_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetOrientationDriveTwistAndSwing", GetOrientationDriveTwistAndSwing_IsValid);
		GetOrientationDriveSLERP_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetOrientationDriveSLERP");
		GetOrientationDriveSLERP_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOrientationDriveSLERP_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOrientationDriveSLERP_Accessor_PropertyAddress, GetOrientationDriveSLERP_FunctionAddress, "Accessor");
		GetOrientationDriveSLERP_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetOrientationDriveSLERP_FunctionAddress, "Accessor");
		GetOrientationDriveSLERP_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOrientationDriveSLERP_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOrientationDriveSLERP_bOutEnableSLERP_PropertyAddress, GetOrientationDriveSLERP_FunctionAddress, "bOutEnableSLERP");
		GetOrientationDriveSLERP_bOutEnableSLERP_Offset = NativeReflectionCached.GetPropertyOffset(GetOrientationDriveSLERP_FunctionAddress, "bOutEnableSLERP");
		GetOrientationDriveSLERP_bOutEnableSLERP_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOrientationDriveSLERP_FunctionAddress, "bOutEnableSLERP", Classes.FBoolProperty);
		GetOrientationDriveSLERP_IsValid = GetOrientationDriveSLERP_FunctionAddress != IntPtr.Zero && GetOrientationDriveSLERP_Accessor_IsValid && GetOrientationDriveSLERP_bOutEnableSLERP_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetOrientationDriveSLERP", GetOrientationDriveSLERP_IsValid);
		GetLinearVelocityTarget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLinearVelocityTarget");
		GetLinearVelocityTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLinearVelocityTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLinearVelocityTarget_Accessor_PropertyAddress, GetLinearVelocityTarget_FunctionAddress, "Accessor");
		GetLinearVelocityTarget_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearVelocityTarget_FunctionAddress, "Accessor");
		GetLinearVelocityTarget_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearVelocityTarget_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearVelocityTarget_OutVelTarget_PropertyAddress, GetLinearVelocityTarget_FunctionAddress, "OutVelTarget");
		GetLinearVelocityTarget_OutVelTarget_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearVelocityTarget_FunctionAddress, "OutVelTarget");
		GetLinearVelocityTarget_OutVelTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearVelocityTarget_FunctionAddress, "OutVelTarget", Classes.FStructProperty);
		GetLinearVelocityTarget_IsValid = GetLinearVelocityTarget_FunctionAddress != IntPtr.Zero && GetLinearVelocityTarget_Accessor_IsValid && GetLinearVelocityTarget_OutVelTarget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearVelocityTarget", GetLinearVelocityTarget_IsValid);
		GetLinearVelocityDrive_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLinearVelocityDrive");
		GetLinearVelocityDrive_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLinearVelocityDrive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLinearVelocityDrive_Accessor_PropertyAddress, GetLinearVelocityDrive_FunctionAddress, "Accessor");
		GetLinearVelocityDrive_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearVelocityDrive_FunctionAddress, "Accessor");
		GetLinearVelocityDrive_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearVelocityDrive_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearVelocityDrive_bOutEnableDriveX_PropertyAddress, GetLinearVelocityDrive_FunctionAddress, "bOutEnableDriveX");
		GetLinearVelocityDrive_bOutEnableDriveX_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearVelocityDrive_FunctionAddress, "bOutEnableDriveX");
		GetLinearVelocityDrive_bOutEnableDriveX_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearVelocityDrive_FunctionAddress, "bOutEnableDriveX", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearVelocityDrive_bOutEnableDriveY_PropertyAddress, GetLinearVelocityDrive_FunctionAddress, "bOutEnableDriveY");
		GetLinearVelocityDrive_bOutEnableDriveY_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearVelocityDrive_FunctionAddress, "bOutEnableDriveY");
		GetLinearVelocityDrive_bOutEnableDriveY_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearVelocityDrive_FunctionAddress, "bOutEnableDriveY", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearVelocityDrive_bOutEnableDriveZ_PropertyAddress, GetLinearVelocityDrive_FunctionAddress, "bOutEnableDriveZ");
		GetLinearVelocityDrive_bOutEnableDriveZ_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearVelocityDrive_FunctionAddress, "bOutEnableDriveZ");
		GetLinearVelocityDrive_bOutEnableDriveZ_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearVelocityDrive_FunctionAddress, "bOutEnableDriveZ", Classes.FBoolProperty);
		GetLinearVelocityDrive_IsValid = GetLinearVelocityDrive_FunctionAddress != IntPtr.Zero && GetLinearVelocityDrive_Accessor_IsValid && GetLinearVelocityDrive_bOutEnableDriveX_IsValid && GetLinearVelocityDrive_bOutEnableDriveY_IsValid && GetLinearVelocityDrive_bOutEnableDriveZ_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearVelocityDrive", GetLinearVelocityDrive_IsValid);
		GetLinearSoftLimitParams_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLinearSoftLimitParams");
		GetLinearSoftLimitParams_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLinearSoftLimitParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLinearSoftLimitParams_Accessor_PropertyAddress, GetLinearSoftLimitParams_FunctionAddress, "Accessor");
		GetLinearSoftLimitParams_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearSoftLimitParams_FunctionAddress, "Accessor");
		GetLinearSoftLimitParams_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearSoftLimitParams_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearSoftLimitParams_bSoftLinearLimit_PropertyAddress, GetLinearSoftLimitParams_FunctionAddress, "bSoftLinearLimit");
		GetLinearSoftLimitParams_bSoftLinearLimit_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearSoftLimitParams_FunctionAddress, "bSoftLinearLimit");
		GetLinearSoftLimitParams_bSoftLinearLimit_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearSoftLimitParams_FunctionAddress, "bSoftLinearLimit", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearSoftLimitParams_LinearLimitStiffness_PropertyAddress, GetLinearSoftLimitParams_FunctionAddress, "LinearLimitStiffness");
		GetLinearSoftLimitParams_LinearLimitStiffness_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearSoftLimitParams_FunctionAddress, "LinearLimitStiffness");
		GetLinearSoftLimitParams_LinearLimitStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearSoftLimitParams_FunctionAddress, "LinearLimitStiffness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearSoftLimitParams_LinearLimitDamping_PropertyAddress, GetLinearSoftLimitParams_FunctionAddress, "LinearLimitDamping");
		GetLinearSoftLimitParams_LinearLimitDamping_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearSoftLimitParams_FunctionAddress, "LinearLimitDamping");
		GetLinearSoftLimitParams_LinearLimitDamping_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearSoftLimitParams_FunctionAddress, "LinearLimitDamping", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearSoftLimitParams_LinearLimitRestitution_PropertyAddress, GetLinearSoftLimitParams_FunctionAddress, "LinearLimitRestitution");
		GetLinearSoftLimitParams_LinearLimitRestitution_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearSoftLimitParams_FunctionAddress, "LinearLimitRestitution");
		GetLinearSoftLimitParams_LinearLimitRestitution_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearSoftLimitParams_FunctionAddress, "LinearLimitRestitution", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearSoftLimitParams_LinearLimitContactDistance_PropertyAddress, GetLinearSoftLimitParams_FunctionAddress, "LinearLimitContactDistance");
		GetLinearSoftLimitParams_LinearLimitContactDistance_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearSoftLimitParams_FunctionAddress, "LinearLimitContactDistance");
		GetLinearSoftLimitParams_LinearLimitContactDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearSoftLimitParams_FunctionAddress, "LinearLimitContactDistance", Classes.FFloatProperty);
		GetLinearSoftLimitParams_IsValid = GetLinearSoftLimitParams_FunctionAddress != IntPtr.Zero && GetLinearSoftLimitParams_Accessor_IsValid && GetLinearSoftLimitParams_bSoftLinearLimit_IsValid && GetLinearSoftLimitParams_LinearLimitStiffness_IsValid && GetLinearSoftLimitParams_LinearLimitDamping_IsValid && GetLinearSoftLimitParams_LinearLimitRestitution_IsValid && GetLinearSoftLimitParams_LinearLimitContactDistance_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearSoftLimitParams", GetLinearSoftLimitParams_IsValid);
		GetLinearPositionTarget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLinearPositionTarget");
		GetLinearPositionTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLinearPositionTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLinearPositionTarget_Accessor_PropertyAddress, GetLinearPositionTarget_FunctionAddress, "Accessor");
		GetLinearPositionTarget_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearPositionTarget_FunctionAddress, "Accessor");
		GetLinearPositionTarget_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearPositionTarget_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearPositionTarget_OutPosTarget_PropertyAddress, GetLinearPositionTarget_FunctionAddress, "OutPosTarget");
		GetLinearPositionTarget_OutPosTarget_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearPositionTarget_FunctionAddress, "OutPosTarget");
		GetLinearPositionTarget_OutPosTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearPositionTarget_FunctionAddress, "OutPosTarget", Classes.FStructProperty);
		GetLinearPositionTarget_IsValid = GetLinearPositionTarget_FunctionAddress != IntPtr.Zero && GetLinearPositionTarget_Accessor_IsValid && GetLinearPositionTarget_OutPosTarget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearPositionTarget", GetLinearPositionTarget_IsValid);
		GetLinearPositionDrive_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLinearPositionDrive");
		GetLinearPositionDrive_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLinearPositionDrive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLinearPositionDrive_Accessor_PropertyAddress, GetLinearPositionDrive_FunctionAddress, "Accessor");
		GetLinearPositionDrive_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearPositionDrive_FunctionAddress, "Accessor");
		GetLinearPositionDrive_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearPositionDrive_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearPositionDrive_bOutEnableDriveX_PropertyAddress, GetLinearPositionDrive_FunctionAddress, "bOutEnableDriveX");
		GetLinearPositionDrive_bOutEnableDriveX_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearPositionDrive_FunctionAddress, "bOutEnableDriveX");
		GetLinearPositionDrive_bOutEnableDriveX_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearPositionDrive_FunctionAddress, "bOutEnableDriveX", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearPositionDrive_bOutEnableDriveY_PropertyAddress, GetLinearPositionDrive_FunctionAddress, "bOutEnableDriveY");
		GetLinearPositionDrive_bOutEnableDriveY_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearPositionDrive_FunctionAddress, "bOutEnableDriveY");
		GetLinearPositionDrive_bOutEnableDriveY_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearPositionDrive_FunctionAddress, "bOutEnableDriveY", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearPositionDrive_bOutEnableDriveZ_PropertyAddress, GetLinearPositionDrive_FunctionAddress, "bOutEnableDriveZ");
		GetLinearPositionDrive_bOutEnableDriveZ_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearPositionDrive_FunctionAddress, "bOutEnableDriveZ");
		GetLinearPositionDrive_bOutEnableDriveZ_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearPositionDrive_FunctionAddress, "bOutEnableDriveZ", Classes.FBoolProperty);
		GetLinearPositionDrive_IsValid = GetLinearPositionDrive_FunctionAddress != IntPtr.Zero && GetLinearPositionDrive_Accessor_IsValid && GetLinearPositionDrive_bOutEnableDriveX_IsValid && GetLinearPositionDrive_bOutEnableDriveY_IsValid && GetLinearPositionDrive_bOutEnableDriveZ_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearPositionDrive", GetLinearPositionDrive_IsValid);
		GetLinearPlasticity_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLinearPlasticity");
		GetLinearPlasticity_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLinearPlasticity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLinearPlasticity_Accessor_PropertyAddress, GetLinearPlasticity_FunctionAddress, "Accessor");
		GetLinearPlasticity_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearPlasticity_FunctionAddress, "Accessor");
		GetLinearPlasticity_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearPlasticity_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearPlasticity_bLinearPlasticity_PropertyAddress, GetLinearPlasticity_FunctionAddress, "bLinearPlasticity");
		GetLinearPlasticity_bLinearPlasticity_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearPlasticity_FunctionAddress, "bLinearPlasticity");
		GetLinearPlasticity_bLinearPlasticity_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearPlasticity_FunctionAddress, "bLinearPlasticity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearPlasticity_LinearPlasticityThreshold_PropertyAddress, GetLinearPlasticity_FunctionAddress, "LinearPlasticityThreshold");
		GetLinearPlasticity_LinearPlasticityThreshold_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearPlasticity_FunctionAddress, "LinearPlasticityThreshold");
		GetLinearPlasticity_LinearPlasticityThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearPlasticity_FunctionAddress, "LinearPlasticityThreshold", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearPlasticity_PlasticityType_PropertyAddress, GetLinearPlasticity_FunctionAddress, "PlasticityType");
		GetLinearPlasticity_PlasticityType_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearPlasticity_FunctionAddress, "PlasticityType");
		GetLinearPlasticity_PlasticityType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearPlasticity_FunctionAddress, "PlasticityType", Classes.FByteProperty);
		GetLinearPlasticity_IsValid = GetLinearPlasticity_FunctionAddress != IntPtr.Zero && GetLinearPlasticity_Accessor_IsValid && GetLinearPlasticity_bLinearPlasticity_IsValid && GetLinearPlasticity_LinearPlasticityThreshold_IsValid && GetLinearPlasticity_PlasticityType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearPlasticity", GetLinearPlasticity_IsValid);
		GetLinearLimits_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLinearLimits");
		GetLinearLimits_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLinearLimits_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLinearLimits_Accessor_PropertyAddress, GetLinearLimits_FunctionAddress, "Accessor");
		GetLinearLimits_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearLimits_FunctionAddress, "Accessor");
		GetLinearLimits_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearLimits_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearLimits_XMotion_PropertyAddress, GetLinearLimits_FunctionAddress, "XMotion");
		GetLinearLimits_XMotion_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearLimits_FunctionAddress, "XMotion");
		GetLinearLimits_XMotion_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearLimits_FunctionAddress, "XMotion", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearLimits_YMotion_PropertyAddress, GetLinearLimits_FunctionAddress, "YMotion");
		GetLinearLimits_YMotion_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearLimits_FunctionAddress, "YMotion");
		GetLinearLimits_YMotion_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearLimits_FunctionAddress, "YMotion", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearLimits_ZMotion_PropertyAddress, GetLinearLimits_FunctionAddress, "ZMotion");
		GetLinearLimits_ZMotion_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearLimits_FunctionAddress, "ZMotion");
		GetLinearLimits_ZMotion_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearLimits_FunctionAddress, "ZMotion", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearLimits_Limit_PropertyAddress, GetLinearLimits_FunctionAddress, "Limit");
		GetLinearLimits_Limit_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearLimits_FunctionAddress, "Limit");
		GetLinearLimits_Limit_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearLimits_FunctionAddress, "Limit", Classes.FFloatProperty);
		GetLinearLimits_IsValid = GetLinearLimits_FunctionAddress != IntPtr.Zero && GetLinearLimits_Accessor_IsValid && GetLinearLimits_XMotion_IsValid && GetLinearLimits_YMotion_IsValid && GetLinearLimits_ZMotion_IsValid && GetLinearLimits_Limit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearLimits", GetLinearLimits_IsValid);
		GetLinearDriveParams_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLinearDriveParams");
		GetLinearDriveParams_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLinearDriveParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLinearDriveParams_Accessor_PropertyAddress, GetLinearDriveParams_FunctionAddress, "Accessor");
		GetLinearDriveParams_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearDriveParams_FunctionAddress, "Accessor");
		GetLinearDriveParams_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearDriveParams_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearDriveParams_OutPositionStrength_PropertyAddress, GetLinearDriveParams_FunctionAddress, "OutPositionStrength");
		GetLinearDriveParams_OutPositionStrength_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearDriveParams_FunctionAddress, "OutPositionStrength");
		GetLinearDriveParams_OutPositionStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearDriveParams_FunctionAddress, "OutPositionStrength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearDriveParams_OutVelocityStrength_PropertyAddress, GetLinearDriveParams_FunctionAddress, "OutVelocityStrength");
		GetLinearDriveParams_OutVelocityStrength_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearDriveParams_FunctionAddress, "OutVelocityStrength");
		GetLinearDriveParams_OutVelocityStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearDriveParams_FunctionAddress, "OutVelocityStrength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearDriveParams_OutForceLimit_PropertyAddress, GetLinearDriveParams_FunctionAddress, "OutForceLimit");
		GetLinearDriveParams_OutForceLimit_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearDriveParams_FunctionAddress, "OutForceLimit");
		GetLinearDriveParams_OutForceLimit_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearDriveParams_FunctionAddress, "OutForceLimit", Classes.FFloatProperty);
		GetLinearDriveParams_IsValid = GetLinearDriveParams_FunctionAddress != IntPtr.Zero && GetLinearDriveParams_Accessor_IsValid && GetLinearDriveParams_OutPositionStrength_IsValid && GetLinearDriveParams_OutVelocityStrength_IsValid && GetLinearDriveParams_OutForceLimit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearDriveParams", GetLinearDriveParams_IsValid);
		GetLinearBreakable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLinearBreakable");
		GetLinearBreakable_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLinearBreakable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLinearBreakable_Accessor_PropertyAddress, GetLinearBreakable_FunctionAddress, "Accessor");
		GetLinearBreakable_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearBreakable_FunctionAddress, "Accessor");
		GetLinearBreakable_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearBreakable_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearBreakable_bLinearBreakable_PropertyAddress, GetLinearBreakable_FunctionAddress, "bLinearBreakable");
		GetLinearBreakable_bLinearBreakable_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearBreakable_FunctionAddress, "bLinearBreakable");
		GetLinearBreakable_bLinearBreakable_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearBreakable_FunctionAddress, "bLinearBreakable", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearBreakable_LinearBreakThreshold_PropertyAddress, GetLinearBreakable_FunctionAddress, "LinearBreakThreshold");
		GetLinearBreakable_LinearBreakThreshold_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearBreakable_FunctionAddress, "LinearBreakThreshold");
		GetLinearBreakable_LinearBreakThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearBreakable_FunctionAddress, "LinearBreakThreshold", Classes.FFloatProperty);
		GetLinearBreakable_IsValid = GetLinearBreakable_FunctionAddress != IntPtr.Zero && GetLinearBreakable_Accessor_IsValid && GetLinearBreakable_bLinearBreakable_IsValid && GetLinearBreakable_LinearBreakThreshold_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetLinearBreakable", GetLinearBreakable_IsValid);
		GetDisableCollsion_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDisableCollsion");
		GetDisableCollsion_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisableCollsion_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDisableCollsion_Accessor_PropertyAddress, GetDisableCollsion_FunctionAddress, "Accessor");
		GetDisableCollsion_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetDisableCollsion_FunctionAddress, "Accessor");
		GetDisableCollsion_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisableCollsion_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDisableCollsion_ReturnValue_PropertyAddress, GetDisableCollsion_FunctionAddress, "ReturnValue");
		GetDisableCollsion_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDisableCollsion_FunctionAddress, "ReturnValue");
		GetDisableCollsion_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisableCollsion_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetDisableCollsion_IsValid = GetDisableCollsion_FunctionAddress != IntPtr.Zero && GetDisableCollsion_Accessor_IsValid && GetDisableCollsion_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetDisableCollsion", GetDisableCollsion_IsValid);
		GetContactTransferScale_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetContactTransferScale");
		GetContactTransferScale_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContactTransferScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetContactTransferScale_Accessor_PropertyAddress, GetContactTransferScale_FunctionAddress, "Accessor");
		GetContactTransferScale_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetContactTransferScale_FunctionAddress, "Accessor");
		GetContactTransferScale_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetContactTransferScale_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetContactTransferScale_ContactTransferScale_PropertyAddress, GetContactTransferScale_FunctionAddress, "ContactTransferScale");
		GetContactTransferScale_ContactTransferScale_Offset = NativeReflectionCached.GetPropertyOffset(GetContactTransferScale_FunctionAddress, "ContactTransferScale");
		GetContactTransferScale_ContactTransferScale_IsValid = NativeReflectionCached.ValidatePropertyClass(GetContactTransferScale_FunctionAddress, "ContactTransferScale", Classes.FFloatProperty);
		GetContactTransferScale_IsValid = GetContactTransferScale_FunctionAddress != IntPtr.Zero && GetContactTransferScale_Accessor_IsValid && GetContactTransferScale_ContactTransferScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetContactTransferScale", GetContactTransferScale_IsValid);
		GetAttachedBodyNames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAttachedBodyNames");
		GetAttachedBodyNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAttachedBodyNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAttachedBodyNames_Accessor_PropertyAddress, GetAttachedBodyNames_FunctionAddress, "Accessor");
		GetAttachedBodyNames_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetAttachedBodyNames_FunctionAddress, "Accessor");
		GetAttachedBodyNames_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttachedBodyNames_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAttachedBodyNames_ParentBody_PropertyAddress, GetAttachedBodyNames_FunctionAddress, "ParentBody");
		GetAttachedBodyNames_ParentBody_Offset = NativeReflectionCached.GetPropertyOffset(GetAttachedBodyNames_FunctionAddress, "ParentBody");
		GetAttachedBodyNames_ParentBody_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttachedBodyNames_FunctionAddress, "ParentBody", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAttachedBodyNames_ChildBody_PropertyAddress, GetAttachedBodyNames_FunctionAddress, "ChildBody");
		GetAttachedBodyNames_ChildBody_Offset = NativeReflectionCached.GetPropertyOffset(GetAttachedBodyNames_FunctionAddress, "ChildBody");
		GetAttachedBodyNames_ChildBody_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttachedBodyNames_FunctionAddress, "ChildBody", Classes.FNameProperty);
		GetAttachedBodyNames_IsValid = GetAttachedBodyNames_FunctionAddress != IntPtr.Zero && GetAttachedBodyNames_Accessor_IsValid && GetAttachedBodyNames_ParentBody_IsValid && GetAttachedBodyNames_ChildBody_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAttachedBodyNames", GetAttachedBodyNames_IsValid);
		GetAngularVelocityTarget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAngularVelocityTarget");
		GetAngularVelocityTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAngularVelocityTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAngularVelocityTarget_Accessor_PropertyAddress, GetAngularVelocityTarget_FunctionAddress, "Accessor");
		GetAngularVelocityTarget_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularVelocityTarget_FunctionAddress, "Accessor");
		GetAngularVelocityTarget_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularVelocityTarget_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularVelocityTarget_OutVelTarget_PropertyAddress, GetAngularVelocityTarget_FunctionAddress, "OutVelTarget");
		GetAngularVelocityTarget_OutVelTarget_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularVelocityTarget_FunctionAddress, "OutVelTarget");
		GetAngularVelocityTarget_OutVelTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularVelocityTarget_FunctionAddress, "OutVelTarget", Classes.FStructProperty);
		GetAngularVelocityTarget_IsValid = GetAngularVelocityTarget_FunctionAddress != IntPtr.Zero && GetAngularVelocityTarget_Accessor_IsValid && GetAngularVelocityTarget_OutVelTarget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularVelocityTarget", GetAngularVelocityTarget_IsValid);
		GetAngularVelocityDriveTwistAndSwing_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAngularVelocityDriveTwistAndSwing");
		GetAngularVelocityDriveTwistAndSwing_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAngularVelocityDriveTwistAndSwing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAngularVelocityDriveTwistAndSwing_Accessor_PropertyAddress, GetAngularVelocityDriveTwistAndSwing_FunctionAddress, "Accessor");
		GetAngularVelocityDriveTwistAndSwing_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularVelocityDriveTwistAndSwing_FunctionAddress, "Accessor");
		GetAngularVelocityDriveTwistAndSwing_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularVelocityDriveTwistAndSwing_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularVelocityDriveTwistAndSwing_bOutEnableTwistDrive_PropertyAddress, GetAngularVelocityDriveTwistAndSwing_FunctionAddress, "bOutEnableTwistDrive");
		GetAngularVelocityDriveTwistAndSwing_bOutEnableTwistDrive_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularVelocityDriveTwistAndSwing_FunctionAddress, "bOutEnableTwistDrive");
		GetAngularVelocityDriveTwistAndSwing_bOutEnableTwistDrive_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularVelocityDriveTwistAndSwing_FunctionAddress, "bOutEnableTwistDrive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularVelocityDriveTwistAndSwing_bOutEnableSwingDrive_PropertyAddress, GetAngularVelocityDriveTwistAndSwing_FunctionAddress, "bOutEnableSwingDrive");
		GetAngularVelocityDriveTwistAndSwing_bOutEnableSwingDrive_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularVelocityDriveTwistAndSwing_FunctionAddress, "bOutEnableSwingDrive");
		GetAngularVelocityDriveTwistAndSwing_bOutEnableSwingDrive_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularVelocityDriveTwistAndSwing_FunctionAddress, "bOutEnableSwingDrive", Classes.FBoolProperty);
		GetAngularVelocityDriveTwistAndSwing_IsValid = GetAngularVelocityDriveTwistAndSwing_FunctionAddress != IntPtr.Zero && GetAngularVelocityDriveTwistAndSwing_Accessor_IsValid && GetAngularVelocityDriveTwistAndSwing_bOutEnableTwistDrive_IsValid && GetAngularVelocityDriveTwistAndSwing_bOutEnableSwingDrive_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularVelocityDriveTwistAndSwing", GetAngularVelocityDriveTwistAndSwing_IsValid);
		GetAngularVelocityDriveSLERP_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAngularVelocityDriveSLERP");
		GetAngularVelocityDriveSLERP_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAngularVelocityDriveSLERP_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAngularVelocityDriveSLERP_Accessor_PropertyAddress, GetAngularVelocityDriveSLERP_FunctionAddress, "Accessor");
		GetAngularVelocityDriveSLERP_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularVelocityDriveSLERP_FunctionAddress, "Accessor");
		GetAngularVelocityDriveSLERP_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularVelocityDriveSLERP_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularVelocityDriveSLERP_bOutEnableSLERP_PropertyAddress, GetAngularVelocityDriveSLERP_FunctionAddress, "bOutEnableSLERP");
		GetAngularVelocityDriveSLERP_bOutEnableSLERP_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularVelocityDriveSLERP_FunctionAddress, "bOutEnableSLERP");
		GetAngularVelocityDriveSLERP_bOutEnableSLERP_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularVelocityDriveSLERP_FunctionAddress, "bOutEnableSLERP", Classes.FBoolProperty);
		GetAngularVelocityDriveSLERP_IsValid = GetAngularVelocityDriveSLERP_FunctionAddress != IntPtr.Zero && GetAngularVelocityDriveSLERP_Accessor_IsValid && GetAngularVelocityDriveSLERP_bOutEnableSLERP_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularVelocityDriveSLERP", GetAngularVelocityDriveSLERP_IsValid);
		GetAngularSoftTwistLimitParams_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAngularSoftTwistLimitParams");
		GetAngularSoftTwistLimitParams_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAngularSoftTwistLimitParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAngularSoftTwistLimitParams_Accessor_PropertyAddress, GetAngularSoftTwistLimitParams_FunctionAddress, "Accessor");
		GetAngularSoftTwistLimitParams_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularSoftTwistLimitParams_FunctionAddress, "Accessor");
		GetAngularSoftTwistLimitParams_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularSoftTwistLimitParams_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularSoftTwistLimitParams_bSoftTwistLimit_PropertyAddress, GetAngularSoftTwistLimitParams_FunctionAddress, "bSoftTwistLimit");
		GetAngularSoftTwistLimitParams_bSoftTwistLimit_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularSoftTwistLimitParams_FunctionAddress, "bSoftTwistLimit");
		GetAngularSoftTwistLimitParams_bSoftTwistLimit_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularSoftTwistLimitParams_FunctionAddress, "bSoftTwistLimit", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularSoftTwistLimitParams_TwistLimitStiffness_PropertyAddress, GetAngularSoftTwistLimitParams_FunctionAddress, "TwistLimitStiffness");
		GetAngularSoftTwistLimitParams_TwistLimitStiffness_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularSoftTwistLimitParams_FunctionAddress, "TwistLimitStiffness");
		GetAngularSoftTwistLimitParams_TwistLimitStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularSoftTwistLimitParams_FunctionAddress, "TwistLimitStiffness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularSoftTwistLimitParams_TwistLimitDamping_PropertyAddress, GetAngularSoftTwistLimitParams_FunctionAddress, "TwistLimitDamping");
		GetAngularSoftTwistLimitParams_TwistLimitDamping_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularSoftTwistLimitParams_FunctionAddress, "TwistLimitDamping");
		GetAngularSoftTwistLimitParams_TwistLimitDamping_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularSoftTwistLimitParams_FunctionAddress, "TwistLimitDamping", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularSoftTwistLimitParams_TwistLimitRestitution_PropertyAddress, GetAngularSoftTwistLimitParams_FunctionAddress, "TwistLimitRestitution");
		GetAngularSoftTwistLimitParams_TwistLimitRestitution_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularSoftTwistLimitParams_FunctionAddress, "TwistLimitRestitution");
		GetAngularSoftTwistLimitParams_TwistLimitRestitution_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularSoftTwistLimitParams_FunctionAddress, "TwistLimitRestitution", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularSoftTwistLimitParams_TwistLimitContactDistance_PropertyAddress, GetAngularSoftTwistLimitParams_FunctionAddress, "TwistLimitContactDistance");
		GetAngularSoftTwistLimitParams_TwistLimitContactDistance_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularSoftTwistLimitParams_FunctionAddress, "TwistLimitContactDistance");
		GetAngularSoftTwistLimitParams_TwistLimitContactDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularSoftTwistLimitParams_FunctionAddress, "TwistLimitContactDistance", Classes.FFloatProperty);
		GetAngularSoftTwistLimitParams_IsValid = GetAngularSoftTwistLimitParams_FunctionAddress != IntPtr.Zero && GetAngularSoftTwistLimitParams_Accessor_IsValid && GetAngularSoftTwistLimitParams_bSoftTwistLimit_IsValid && GetAngularSoftTwistLimitParams_TwistLimitStiffness_IsValid && GetAngularSoftTwistLimitParams_TwistLimitDamping_IsValid && GetAngularSoftTwistLimitParams_TwistLimitRestitution_IsValid && GetAngularSoftTwistLimitParams_TwistLimitContactDistance_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularSoftTwistLimitParams", GetAngularSoftTwistLimitParams_IsValid);
		GetAngularSoftSwingLimitParams_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAngularSoftSwingLimitParams");
		GetAngularSoftSwingLimitParams_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAngularSoftSwingLimitParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAngularSoftSwingLimitParams_Accessor_PropertyAddress, GetAngularSoftSwingLimitParams_FunctionAddress, "Accessor");
		GetAngularSoftSwingLimitParams_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularSoftSwingLimitParams_FunctionAddress, "Accessor");
		GetAngularSoftSwingLimitParams_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularSoftSwingLimitParams_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularSoftSwingLimitParams_bSoftSwingLimit_PropertyAddress, GetAngularSoftSwingLimitParams_FunctionAddress, "bSoftSwingLimit");
		GetAngularSoftSwingLimitParams_bSoftSwingLimit_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularSoftSwingLimitParams_FunctionAddress, "bSoftSwingLimit");
		GetAngularSoftSwingLimitParams_bSoftSwingLimit_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularSoftSwingLimitParams_FunctionAddress, "bSoftSwingLimit", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularSoftSwingLimitParams_SwingLimitStiffness_PropertyAddress, GetAngularSoftSwingLimitParams_FunctionAddress, "SwingLimitStiffness");
		GetAngularSoftSwingLimitParams_SwingLimitStiffness_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularSoftSwingLimitParams_FunctionAddress, "SwingLimitStiffness");
		GetAngularSoftSwingLimitParams_SwingLimitStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularSoftSwingLimitParams_FunctionAddress, "SwingLimitStiffness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularSoftSwingLimitParams_SwingLimitDamping_PropertyAddress, GetAngularSoftSwingLimitParams_FunctionAddress, "SwingLimitDamping");
		GetAngularSoftSwingLimitParams_SwingLimitDamping_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularSoftSwingLimitParams_FunctionAddress, "SwingLimitDamping");
		GetAngularSoftSwingLimitParams_SwingLimitDamping_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularSoftSwingLimitParams_FunctionAddress, "SwingLimitDamping", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularSoftSwingLimitParams_SwingLimitRestitution_PropertyAddress, GetAngularSoftSwingLimitParams_FunctionAddress, "SwingLimitRestitution");
		GetAngularSoftSwingLimitParams_SwingLimitRestitution_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularSoftSwingLimitParams_FunctionAddress, "SwingLimitRestitution");
		GetAngularSoftSwingLimitParams_SwingLimitRestitution_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularSoftSwingLimitParams_FunctionAddress, "SwingLimitRestitution", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularSoftSwingLimitParams_SwingLimitContactDistance_PropertyAddress, GetAngularSoftSwingLimitParams_FunctionAddress, "SwingLimitContactDistance");
		GetAngularSoftSwingLimitParams_SwingLimitContactDistance_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularSoftSwingLimitParams_FunctionAddress, "SwingLimitContactDistance");
		GetAngularSoftSwingLimitParams_SwingLimitContactDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularSoftSwingLimitParams_FunctionAddress, "SwingLimitContactDistance", Classes.FFloatProperty);
		GetAngularSoftSwingLimitParams_IsValid = GetAngularSoftSwingLimitParams_FunctionAddress != IntPtr.Zero && GetAngularSoftSwingLimitParams_Accessor_IsValid && GetAngularSoftSwingLimitParams_bSoftSwingLimit_IsValid && GetAngularSoftSwingLimitParams_SwingLimitStiffness_IsValid && GetAngularSoftSwingLimitParams_SwingLimitDamping_IsValid && GetAngularSoftSwingLimitParams_SwingLimitRestitution_IsValid && GetAngularSoftSwingLimitParams_SwingLimitContactDistance_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularSoftSwingLimitParams", GetAngularSoftSwingLimitParams_IsValid);
		GetAngularPlasticity_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAngularPlasticity");
		GetAngularPlasticity_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAngularPlasticity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAngularPlasticity_Accessor_PropertyAddress, GetAngularPlasticity_FunctionAddress, "Accessor");
		GetAngularPlasticity_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularPlasticity_FunctionAddress, "Accessor");
		GetAngularPlasticity_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularPlasticity_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularPlasticity_bAngularPlasticity_PropertyAddress, GetAngularPlasticity_FunctionAddress, "bAngularPlasticity");
		GetAngularPlasticity_bAngularPlasticity_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularPlasticity_FunctionAddress, "bAngularPlasticity");
		GetAngularPlasticity_bAngularPlasticity_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularPlasticity_FunctionAddress, "bAngularPlasticity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularPlasticity_AngularPlasticityThreshold_PropertyAddress, GetAngularPlasticity_FunctionAddress, "AngularPlasticityThreshold");
		GetAngularPlasticity_AngularPlasticityThreshold_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularPlasticity_FunctionAddress, "AngularPlasticityThreshold");
		GetAngularPlasticity_AngularPlasticityThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularPlasticity_FunctionAddress, "AngularPlasticityThreshold", Classes.FFloatProperty);
		GetAngularPlasticity_IsValid = GetAngularPlasticity_FunctionAddress != IntPtr.Zero && GetAngularPlasticity_Accessor_IsValid && GetAngularPlasticity_bAngularPlasticity_IsValid && GetAngularPlasticity_AngularPlasticityThreshold_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularPlasticity", GetAngularPlasticity_IsValid);
		GetAngularOrientationTarget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAngularOrientationTarget");
		GetAngularOrientationTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAngularOrientationTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAngularOrientationTarget_Accessor_PropertyAddress, GetAngularOrientationTarget_FunctionAddress, "Accessor");
		GetAngularOrientationTarget_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularOrientationTarget_FunctionAddress, "Accessor");
		GetAngularOrientationTarget_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularOrientationTarget_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularOrientationTarget_OutPosTarget_PropertyAddress, GetAngularOrientationTarget_FunctionAddress, "OutPosTarget");
		GetAngularOrientationTarget_OutPosTarget_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularOrientationTarget_FunctionAddress, "OutPosTarget");
		GetAngularOrientationTarget_OutPosTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularOrientationTarget_FunctionAddress, "OutPosTarget", Classes.FStructProperty);
		GetAngularOrientationTarget_IsValid = GetAngularOrientationTarget_FunctionAddress != IntPtr.Zero && GetAngularOrientationTarget_Accessor_IsValid && GetAngularOrientationTarget_OutPosTarget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularOrientationTarget", GetAngularOrientationTarget_IsValid);
		GetAngularLimits_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAngularLimits");
		GetAngularLimits_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAngularLimits_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAngularLimits_Accessor_PropertyAddress, GetAngularLimits_FunctionAddress, "Accessor");
		GetAngularLimits_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularLimits_FunctionAddress, "Accessor");
		GetAngularLimits_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularLimits_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularLimits_Swing1MotionType_PropertyAddress, GetAngularLimits_FunctionAddress, "Swing1MotionType");
		GetAngularLimits_Swing1MotionType_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularLimits_FunctionAddress, "Swing1MotionType");
		GetAngularLimits_Swing1MotionType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularLimits_FunctionAddress, "Swing1MotionType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularLimits_Swing1LimitAngle_PropertyAddress, GetAngularLimits_FunctionAddress, "Swing1LimitAngle");
		GetAngularLimits_Swing1LimitAngle_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularLimits_FunctionAddress, "Swing1LimitAngle");
		GetAngularLimits_Swing1LimitAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularLimits_FunctionAddress, "Swing1LimitAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularLimits_Swing2MotionType_PropertyAddress, GetAngularLimits_FunctionAddress, "Swing2MotionType");
		GetAngularLimits_Swing2MotionType_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularLimits_FunctionAddress, "Swing2MotionType");
		GetAngularLimits_Swing2MotionType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularLimits_FunctionAddress, "Swing2MotionType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularLimits_Swing2LimitAngle_PropertyAddress, GetAngularLimits_FunctionAddress, "Swing2LimitAngle");
		GetAngularLimits_Swing2LimitAngle_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularLimits_FunctionAddress, "Swing2LimitAngle");
		GetAngularLimits_Swing2LimitAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularLimits_FunctionAddress, "Swing2LimitAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularLimits_TwistMotionType_PropertyAddress, GetAngularLimits_FunctionAddress, "TwistMotionType");
		GetAngularLimits_TwistMotionType_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularLimits_FunctionAddress, "TwistMotionType");
		GetAngularLimits_TwistMotionType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularLimits_FunctionAddress, "TwistMotionType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularLimits_TwistLimitAngle_PropertyAddress, GetAngularLimits_FunctionAddress, "TwistLimitAngle");
		GetAngularLimits_TwistLimitAngle_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularLimits_FunctionAddress, "TwistLimitAngle");
		GetAngularLimits_TwistLimitAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularLimits_FunctionAddress, "TwistLimitAngle", Classes.FFloatProperty);
		GetAngularLimits_IsValid = GetAngularLimits_FunctionAddress != IntPtr.Zero && GetAngularLimits_Accessor_IsValid && GetAngularLimits_Swing1MotionType_IsValid && GetAngularLimits_Swing1LimitAngle_IsValid && GetAngularLimits_Swing2MotionType_IsValid && GetAngularLimits_Swing2LimitAngle_IsValid && GetAngularLimits_TwistMotionType_IsValid && GetAngularLimits_TwistLimitAngle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularLimits", GetAngularLimits_IsValid);
		GetAngularDriveParams_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAngularDriveParams");
		GetAngularDriveParams_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAngularDriveParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAngularDriveParams_Accessor_PropertyAddress, GetAngularDriveParams_FunctionAddress, "Accessor");
		GetAngularDriveParams_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularDriveParams_FunctionAddress, "Accessor");
		GetAngularDriveParams_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularDriveParams_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularDriveParams_OutPositionStrength_PropertyAddress, GetAngularDriveParams_FunctionAddress, "OutPositionStrength");
		GetAngularDriveParams_OutPositionStrength_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularDriveParams_FunctionAddress, "OutPositionStrength");
		GetAngularDriveParams_OutPositionStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularDriveParams_FunctionAddress, "OutPositionStrength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularDriveParams_OutVelocityStrength_PropertyAddress, GetAngularDriveParams_FunctionAddress, "OutVelocityStrength");
		GetAngularDriveParams_OutVelocityStrength_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularDriveParams_FunctionAddress, "OutVelocityStrength");
		GetAngularDriveParams_OutVelocityStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularDriveParams_FunctionAddress, "OutVelocityStrength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularDriveParams_OutForceLimit_PropertyAddress, GetAngularDriveParams_FunctionAddress, "OutForceLimit");
		GetAngularDriveParams_OutForceLimit_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularDriveParams_FunctionAddress, "OutForceLimit");
		GetAngularDriveParams_OutForceLimit_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularDriveParams_FunctionAddress, "OutForceLimit", Classes.FFloatProperty);
		GetAngularDriveParams_IsValid = GetAngularDriveParams_FunctionAddress != IntPtr.Zero && GetAngularDriveParams_Accessor_IsValid && GetAngularDriveParams_OutPositionStrength_IsValid && GetAngularDriveParams_OutVelocityStrength_IsValid && GetAngularDriveParams_OutForceLimit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularDriveParams", GetAngularDriveParams_IsValid);
		GetAngularDriveMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAngularDriveMode");
		GetAngularDriveMode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAngularDriveMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAngularDriveMode_Accessor_PropertyAddress, GetAngularDriveMode_FunctionAddress, "Accessor");
		GetAngularDriveMode_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularDriveMode_FunctionAddress, "Accessor");
		GetAngularDriveMode_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularDriveMode_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularDriveMode_OutDriveMode_PropertyAddress, GetAngularDriveMode_FunctionAddress, "OutDriveMode");
		GetAngularDriveMode_OutDriveMode_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularDriveMode_FunctionAddress, "OutDriveMode");
		GetAngularDriveMode_OutDriveMode_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularDriveMode_FunctionAddress, "OutDriveMode", Classes.FByteProperty);
		GetAngularDriveMode_IsValid = GetAngularDriveMode_FunctionAddress != IntPtr.Zero && GetAngularDriveMode_Accessor_IsValid && GetAngularDriveMode_OutDriveMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularDriveMode", GetAngularDriveMode_IsValid);
		GetAngularBreakable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAngularBreakable");
		GetAngularBreakable_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAngularBreakable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAngularBreakable_Accessor_PropertyAddress, GetAngularBreakable_FunctionAddress, "Accessor");
		GetAngularBreakable_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularBreakable_FunctionAddress, "Accessor");
		GetAngularBreakable_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularBreakable_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularBreakable_bAngularBreakable_PropertyAddress, GetAngularBreakable_FunctionAddress, "bAngularBreakable");
		GetAngularBreakable_bAngularBreakable_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularBreakable_FunctionAddress, "bAngularBreakable");
		GetAngularBreakable_bAngularBreakable_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularBreakable_FunctionAddress, "bAngularBreakable", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAngularBreakable_AngularBreakThreshold_PropertyAddress, GetAngularBreakable_FunctionAddress, "AngularBreakThreshold");
		GetAngularBreakable_AngularBreakThreshold_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularBreakable_FunctionAddress, "AngularBreakThreshold");
		GetAngularBreakable_AngularBreakThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularBreakable_FunctionAddress, "AngularBreakThreshold", Classes.FFloatProperty);
		GetAngularBreakable_IsValid = GetAngularBreakable_FunctionAddress != IntPtr.Zero && GetAngularBreakable_Accessor_IsValid && GetAngularBreakable_bAngularBreakable_IsValid && GetAngularBreakable_AngularBreakThreshold_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:GetAngularBreakable", GetAngularBreakable_IsValid);
		CopyParams_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyParams");
		CopyParams_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyParams_Accessor_PropertyAddress, CopyParams_FunctionAddress, "Accessor");
		CopyParams_Accessor_Offset = NativeReflectionCached.GetPropertyOffset(CopyParams_FunctionAddress, "Accessor");
		CopyParams_Accessor_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyParams_FunctionAddress, "Accessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyParams_SourceAccessor_PropertyAddress, CopyParams_FunctionAddress, "SourceAccessor");
		CopyParams_SourceAccessor_Offset = NativeReflectionCached.GetPropertyOffset(CopyParams_FunctionAddress, "SourceAccessor");
		CopyParams_SourceAccessor_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyParams_FunctionAddress, "SourceAccessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyParams_bKeepPosition_PropertyAddress, CopyParams_FunctionAddress, "bKeepPosition");
		CopyParams_bKeepPosition_Offset = NativeReflectionCached.GetPropertyOffset(CopyParams_FunctionAddress, "bKeepPosition");
		CopyParams_bKeepPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyParams_FunctionAddress, "bKeepPosition", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyParams_bKeepRotation_PropertyAddress, CopyParams_FunctionAddress, "bKeepRotation");
		CopyParams_bKeepRotation_Offset = NativeReflectionCached.GetPropertyOffset(CopyParams_FunctionAddress, "bKeepRotation");
		CopyParams_bKeepRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyParams_FunctionAddress, "bKeepRotation", Classes.FBoolProperty);
		CopyParams_IsValid = CopyParams_FunctionAddress != IntPtr.Zero && CopyParams_Accessor_IsValid && CopyParams_SourceAccessor_IsValid && CopyParams_bKeepPosition_IsValid && CopyParams_bKeepRotation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintInstanceBlueprintLibrary:CopyParams", CopyParams_IsValid);
	}
}
