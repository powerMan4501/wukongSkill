using System;
using System.Runtime.CompilerServices;
using UnrealEngine.PhysicsCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.PhysicsConstraintComponent", "Engine", UnrealModuleType.Engine)]
public class UPhysicsConstraintComponent : USceneComponent
{
	private static bool OnConstraintBroken_IsValid;

	private static int OnConstraintBroken_Offset;

	private FConstraintBrokenSignature OnConstraintBroken_DelegateCached;

	private static bool OnPlasticDeformation_IsValid;

	private static int OnPlasticDeformation_Offset;

	private FPlasticDeformationEventSignature OnPlasticDeformation_DelegateCached;

	private static bool SetOrientationDriveTwistAndSwing_IsValid;

	private static IntPtr SetOrientationDriveTwistAndSwing_FunctionAddress;

	private static int SetOrientationDriveTwistAndSwing_ParamsSize;

	private static bool SetOrientationDriveTwistAndSwing_bEnableTwistDrive_IsValid;

	private static FFieldAddress SetOrientationDriveTwistAndSwing_bEnableTwistDrive_PropertyAddress;

	private static int SetOrientationDriveTwistAndSwing_bEnableTwistDrive_Offset;

	private static bool SetOrientationDriveTwistAndSwing_bEnableSwingDrive_IsValid;

	private static FFieldAddress SetOrientationDriveTwistAndSwing_bEnableSwingDrive_PropertyAddress;

	private static int SetOrientationDriveTwistAndSwing_bEnableSwingDrive_Offset;

	private static bool SetOrientationDriveSLERP_IsValid;

	private static IntPtr SetOrientationDriveSLERP_FunctionAddress;

	private static int SetOrientationDriveSLERP_ParamsSize;

	private static bool SetOrientationDriveSLERP_bEnableSLERP_IsValid;

	private static FFieldAddress SetOrientationDriveSLERP_bEnableSLERP_PropertyAddress;

	private static int SetOrientationDriveSLERP_bEnableSLERP_Offset;

	private static bool SetLinearZLimit_IsValid;

	private static IntPtr SetLinearZLimit_FunctionAddress;

	private static int SetLinearZLimit_ParamsSize;

	private static bool SetLinearZLimit_ConstraintType_IsValid;

	private static FFieldAddress SetLinearZLimit_ConstraintType_PropertyAddress;

	private static int SetLinearZLimit_ConstraintType_Offset;

	private static bool SetLinearZLimit_LimitSize_IsValid;

	private static FFieldAddress SetLinearZLimit_LimitSize_PropertyAddress;

	private static int SetLinearZLimit_LimitSize_Offset;

	private static bool SetLinearYLimit_IsValid;

	private static IntPtr SetLinearYLimit_FunctionAddress;

	private static int SetLinearYLimit_ParamsSize;

	private static bool SetLinearYLimit_ConstraintType_IsValid;

	private static FFieldAddress SetLinearYLimit_ConstraintType_PropertyAddress;

	private static int SetLinearYLimit_ConstraintType_Offset;

	private static bool SetLinearYLimit_LimitSize_IsValid;

	private static FFieldAddress SetLinearYLimit_LimitSize_PropertyAddress;

	private static int SetLinearYLimit_LimitSize_Offset;

	private static bool SetLinearXLimit_IsValid;

	private static IntPtr SetLinearXLimit_FunctionAddress;

	private static int SetLinearXLimit_ParamsSize;

	private static bool SetLinearXLimit_ConstraintType_IsValid;

	private static FFieldAddress SetLinearXLimit_ConstraintType_PropertyAddress;

	private static int SetLinearXLimit_ConstraintType_Offset;

	private static bool SetLinearXLimit_LimitSize_IsValid;

	private static FFieldAddress SetLinearXLimit_LimitSize_PropertyAddress;

	private static int SetLinearXLimit_LimitSize_Offset;

	private static bool SetLinearVelocityTarget_IsValid;

	private static IntPtr SetLinearVelocityTarget_FunctionAddress;

	private static int SetLinearVelocityTarget_ParamsSize;

	private static bool SetLinearVelocityTarget_InVelTarget_IsValid;

	private static FFieldAddress SetLinearVelocityTarget_InVelTarget_PropertyAddress;

	private static int SetLinearVelocityTarget_InVelTarget_Offset;

	private static bool SetLinearVelocityDrive_IsValid;

	private static IntPtr SetLinearVelocityDrive_FunctionAddress;

	private static int SetLinearVelocityDrive_ParamsSize;

	private static bool SetLinearVelocityDrive_bEnableDriveX_IsValid;

	private static FFieldAddress SetLinearVelocityDrive_bEnableDriveX_PropertyAddress;

	private static int SetLinearVelocityDrive_bEnableDriveX_Offset;

	private static bool SetLinearVelocityDrive_bEnableDriveY_IsValid;

	private static FFieldAddress SetLinearVelocityDrive_bEnableDriveY_PropertyAddress;

	private static int SetLinearVelocityDrive_bEnableDriveY_Offset;

	private static bool SetLinearVelocityDrive_bEnableDriveZ_IsValid;

	private static FFieldAddress SetLinearVelocityDrive_bEnableDriveZ_PropertyAddress;

	private static int SetLinearVelocityDrive_bEnableDriveZ_Offset;

	private static bool SetLinearPositionTarget_IsValid;

	private static IntPtr SetLinearPositionTarget_FunctionAddress;

	private static int SetLinearPositionTarget_ParamsSize;

	private static bool SetLinearPositionTarget_InPosTarget_IsValid;

	private static FFieldAddress SetLinearPositionTarget_InPosTarget_PropertyAddress;

	private static int SetLinearPositionTarget_InPosTarget_Offset;

	private static bool SetLinearPositionDrive_IsValid;

	private static IntPtr SetLinearPositionDrive_FunctionAddress;

	private static int SetLinearPositionDrive_ParamsSize;

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

	private static bool SetLinearPlasticity_bLinearPlasticity_IsValid;

	private static FFieldAddress SetLinearPlasticity_bLinearPlasticity_PropertyAddress;

	private static int SetLinearPlasticity_bLinearPlasticity_Offset;

	private static bool SetLinearPlasticity_LinearPlasticityThreshold_IsValid;

	private static FFieldAddress SetLinearPlasticity_LinearPlasticityThreshold_PropertyAddress;

	private static int SetLinearPlasticity_LinearPlasticityThreshold_Offset;

	private static bool SetLinearPlasticity_PlasticityType_IsValid;

	private static FFieldAddress SetLinearPlasticity_PlasticityType_PropertyAddress;

	private static int SetLinearPlasticity_PlasticityType_Offset;

	private static bool SetLinearDriveParams_IsValid;

	private static IntPtr SetLinearDriveParams_FunctionAddress;

	private static int SetLinearDriveParams_ParamsSize;

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

	private static bool SetLinearBreakable_bLinearBreakable_IsValid;

	private static FFieldAddress SetLinearBreakable_bLinearBreakable_PropertyAddress;

	private static int SetLinearBreakable_bLinearBreakable_Offset;

	private static bool SetLinearBreakable_LinearBreakThreshold_IsValid;

	private static FFieldAddress SetLinearBreakable_LinearBreakThreshold_PropertyAddress;

	private static int SetLinearBreakable_LinearBreakThreshold_Offset;

	private static bool SetDisableCollision_IsValid;

	private static IntPtr SetDisableCollision_FunctionAddress;

	private static int SetDisableCollision_ParamsSize;

	private static bool SetDisableCollision_bDisableCollision_IsValid;

	private static FFieldAddress SetDisableCollision_bDisableCollision_PropertyAddress;

	private static int SetDisableCollision_bDisableCollision_Offset;

	private static bool SetContactTransferScale_IsValid;

	private static IntPtr SetContactTransferScale_FunctionAddress;

	private static int SetContactTransferScale_ParamsSize;

	private static bool SetContactTransferScale_ContactTransferScale_IsValid;

	private static FFieldAddress SetContactTransferScale_ContactTransferScale_PropertyAddress;

	private static int SetContactTransferScale_ContactTransferScale_Offset;

	private static bool SetConstraintReferencePosition_IsValid;

	private static IntPtr SetConstraintReferencePosition_FunctionAddress;

	private static int SetConstraintReferencePosition_ParamsSize;

	private static bool SetConstraintReferencePosition_Frame_IsValid;

	private static FFieldAddress SetConstraintReferencePosition_Frame_PropertyAddress;

	private static int SetConstraintReferencePosition_Frame_Offset;

	private static bool SetConstraintReferencePosition_RefPosition_IsValid;

	private static FFieldAddress SetConstraintReferencePosition_RefPosition_PropertyAddress;

	private static int SetConstraintReferencePosition_RefPosition_Offset;

	private static bool SetConstraintReferenceOrientation_IsValid;

	private static IntPtr SetConstraintReferenceOrientation_FunctionAddress;

	private static int SetConstraintReferenceOrientation_ParamsSize;

	private static bool SetConstraintReferenceOrientation_Frame_IsValid;

	private static FFieldAddress SetConstraintReferenceOrientation_Frame_PropertyAddress;

	private static int SetConstraintReferenceOrientation_Frame_Offset;

	private static bool SetConstraintReferenceOrientation_PriAxis_IsValid;

	private static FFieldAddress SetConstraintReferenceOrientation_PriAxis_PropertyAddress;

	private static int SetConstraintReferenceOrientation_PriAxis_Offset;

	private static bool SetConstraintReferenceOrientation_SecAxis_IsValid;

	private static FFieldAddress SetConstraintReferenceOrientation_SecAxis_PropertyAddress;

	private static int SetConstraintReferenceOrientation_SecAxis_Offset;

	private static bool SetConstraintReferenceFrame_IsValid;

	private static IntPtr SetConstraintReferenceFrame_FunctionAddress;

	private static int SetConstraintReferenceFrame_ParamsSize;

	private static bool SetConstraintReferenceFrame_Frame_IsValid;

	private static FFieldAddress SetConstraintReferenceFrame_Frame_PropertyAddress;

	private static int SetConstraintReferenceFrame_Frame_Offset;

	private static bool SetConstraintReferenceFrame_RefFrame_IsValid;

	private static FFieldAddress SetConstraintReferenceFrame_RefFrame_PropertyAddress;

	private static int SetConstraintReferenceFrame_RefFrame_Offset;

	private static bool SetConstrainedComponents_IsValid;

	private static IntPtr SetConstrainedComponents_FunctionAddress;

	private static int SetConstrainedComponents_ParamsSize;

	private static bool SetConstrainedComponents_Component1_IsValid;

	private static FFieldAddress SetConstrainedComponents_Component1_PropertyAddress;

	private static int SetConstrainedComponents_Component1_Offset;

	private static bool SetConstrainedComponents_BoneName1_IsValid;

	private static FFieldAddress SetConstrainedComponents_BoneName1_PropertyAddress;

	private static int SetConstrainedComponents_BoneName1_Offset;

	private static bool SetConstrainedComponents_Component2_IsValid;

	private static FFieldAddress SetConstrainedComponents_Component2_PropertyAddress;

	private static int SetConstrainedComponents_Component2_Offset;

	private static bool SetConstrainedComponents_BoneName2_IsValid;

	private static FFieldAddress SetConstrainedComponents_BoneName2_PropertyAddress;

	private static int SetConstrainedComponents_BoneName2_Offset;

	private static bool SetAngularVelocityTarget_IsValid;

	private static IntPtr SetAngularVelocityTarget_FunctionAddress;

	private static int SetAngularVelocityTarget_ParamsSize;

	private static bool SetAngularVelocityTarget_InVelTarget_IsValid;

	private static FFieldAddress SetAngularVelocityTarget_InVelTarget_PropertyAddress;

	private static int SetAngularVelocityTarget_InVelTarget_Offset;

	private static bool SetAngularVelocityDriveTwistAndSwing_IsValid;

	private static IntPtr SetAngularVelocityDriveTwistAndSwing_FunctionAddress;

	private static int SetAngularVelocityDriveTwistAndSwing_ParamsSize;

	private static bool SetAngularVelocityDriveTwistAndSwing_bEnableTwistDrive_IsValid;

	private static FFieldAddress SetAngularVelocityDriveTwistAndSwing_bEnableTwistDrive_PropertyAddress;

	private static int SetAngularVelocityDriveTwistAndSwing_bEnableTwistDrive_Offset;

	private static bool SetAngularVelocityDriveTwistAndSwing_bEnableSwingDrive_IsValid;

	private static FFieldAddress SetAngularVelocityDriveTwistAndSwing_bEnableSwingDrive_PropertyAddress;

	private static int SetAngularVelocityDriveTwistAndSwing_bEnableSwingDrive_Offset;

	private static bool SetAngularVelocityDriveSLERP_IsValid;

	private static IntPtr SetAngularVelocityDriveSLERP_FunctionAddress;

	private static int SetAngularVelocityDriveSLERP_ParamsSize;

	private static bool SetAngularVelocityDriveSLERP_bEnableSLERP_IsValid;

	private static FFieldAddress SetAngularVelocityDriveSLERP_bEnableSLERP_PropertyAddress;

	private static int SetAngularVelocityDriveSLERP_bEnableSLERP_Offset;

	private static bool SetAngularTwistLimit_IsValid;

	private static IntPtr SetAngularTwistLimit_FunctionAddress;

	private static int SetAngularTwistLimit_ParamsSize;

	private static bool SetAngularTwistLimit_ConstraintType_IsValid;

	private static FFieldAddress SetAngularTwistLimit_ConstraintType_PropertyAddress;

	private static int SetAngularTwistLimit_ConstraintType_Offset;

	private static bool SetAngularTwistLimit_TwistLimitAngle_IsValid;

	private static FFieldAddress SetAngularTwistLimit_TwistLimitAngle_PropertyAddress;

	private static int SetAngularTwistLimit_TwistLimitAngle_Offset;

	private static bool SetAngularSwing2Limit_IsValid;

	private static IntPtr SetAngularSwing2Limit_FunctionAddress;

	private static int SetAngularSwing2Limit_ParamsSize;

	private static bool SetAngularSwing2Limit_MotionType_IsValid;

	private static FFieldAddress SetAngularSwing2Limit_MotionType_PropertyAddress;

	private static int SetAngularSwing2Limit_MotionType_Offset;

	private static bool SetAngularSwing2Limit_Swing2LimitAngle_IsValid;

	private static FFieldAddress SetAngularSwing2Limit_Swing2LimitAngle_PropertyAddress;

	private static int SetAngularSwing2Limit_Swing2LimitAngle_Offset;

	private static bool SetAngularSwing1Limit_IsValid;

	private static IntPtr SetAngularSwing1Limit_FunctionAddress;

	private static int SetAngularSwing1Limit_ParamsSize;

	private static bool SetAngularSwing1Limit_MotionType_IsValid;

	private static FFieldAddress SetAngularSwing1Limit_MotionType_PropertyAddress;

	private static int SetAngularSwing1Limit_MotionType_Offset;

	private static bool SetAngularSwing1Limit_Swing1LimitAngle_IsValid;

	private static FFieldAddress SetAngularSwing1Limit_Swing1LimitAngle_PropertyAddress;

	private static int SetAngularSwing1Limit_Swing1LimitAngle_Offset;

	private static bool SetAngularPlasticity_IsValid;

	private static IntPtr SetAngularPlasticity_FunctionAddress;

	private static int SetAngularPlasticity_ParamsSize;

	private static bool SetAngularPlasticity_bAngularPlasticity_IsValid;

	private static FFieldAddress SetAngularPlasticity_bAngularPlasticity_PropertyAddress;

	private static int SetAngularPlasticity_bAngularPlasticity_Offset;

	private static bool SetAngularPlasticity_AngularPlasticityThreshold_IsValid;

	private static FFieldAddress SetAngularPlasticity_AngularPlasticityThreshold_PropertyAddress;

	private static int SetAngularPlasticity_AngularPlasticityThreshold_Offset;

	private static bool SetAngularOrientationTarget_IsValid;

	private static IntPtr SetAngularOrientationTarget_FunctionAddress;

	private static int SetAngularOrientationTarget_ParamsSize;

	private static bool SetAngularOrientationTarget_InPosTarget_IsValid;

	private static FFieldAddress SetAngularOrientationTarget_InPosTarget_PropertyAddress;

	private static int SetAngularOrientationTarget_InPosTarget_Offset;

	private static bool SetAngularDriveParams_IsValid;

	private static IntPtr SetAngularDriveParams_FunctionAddress;

	private static int SetAngularDriveParams_ParamsSize;

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

	private static bool SetAngularDriveMode_DriveMode_IsValid;

	private static FFieldAddress SetAngularDriveMode_DriveMode_PropertyAddress;

	private static int SetAngularDriveMode_DriveMode_Offset;

	private static bool SetAngularBreakable_IsValid;

	private static IntPtr SetAngularBreakable_FunctionAddress;

	private static int SetAngularBreakable_ParamsSize;

	private static bool SetAngularBreakable_bAngularBreakable_IsValid;

	private static FFieldAddress SetAngularBreakable_bAngularBreakable_PropertyAddress;

	private static int SetAngularBreakable_bAngularBreakable_Offset;

	private static bool SetAngularBreakable_AngularBreakThreshold_IsValid;

	private static FFieldAddress SetAngularBreakable_AngularBreakThreshold_PropertyAddress;

	private static int SetAngularBreakable_AngularBreakThreshold_Offset;

	private static bool IsBroken_IsValid;

	private static IntPtr IsBroken_FunctionAddress;

	private static int IsBroken_ParamsSize;

	private static bool IsBroken_ReturnValue_IsValid;

	private static FFieldAddress IsBroken_ReturnValue_PropertyAddress;

	private static int IsBroken_ReturnValue_Offset;

	private static bool GetCurrentTwist_IsValid;

	private static IntPtr GetCurrentTwist_FunctionAddress;

	private static int GetCurrentTwist_ParamsSize;

	private static bool GetCurrentTwist_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentTwist_ReturnValue_PropertyAddress;

	private static int GetCurrentTwist_ReturnValue_Offset;

	private static bool GetCurrentSwing2_IsValid;

	private static IntPtr GetCurrentSwing2_FunctionAddress;

	private static int GetCurrentSwing2_ParamsSize;

	private static bool GetCurrentSwing2_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentSwing2_ReturnValue_PropertyAddress;

	private static int GetCurrentSwing2_ReturnValue_Offset;

	private static bool GetCurrentSwing1_IsValid;

	private static IntPtr GetCurrentSwing1_FunctionAddress;

	private static int GetCurrentSwing1_ParamsSize;

	private static bool GetCurrentSwing1_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentSwing1_ReturnValue_PropertyAddress;

	private static int GetCurrentSwing1_ReturnValue_Offset;

	private static bool GetConstraintForce_IsValid;

	private static IntPtr GetConstraintForce_FunctionAddress;

	private static int GetConstraintForce_ParamsSize;

	private static bool GetConstraintForce_OutLinearForce_IsValid;

	private static FFieldAddress GetConstraintForce_OutLinearForce_PropertyAddress;

	private static int GetConstraintForce_OutLinearForce_Offset;

	private static bool GetConstraintForce_OutAngularForce_IsValid;

	private static FFieldAddress GetConstraintForce_OutAngularForce_PropertyAddress;

	private static int GetConstraintForce_OutAngularForce_Offset;

	private static bool GetConstraint_IsValid;

	private static IntPtr GetConstraint_FunctionAddress;

	private static int GetConstraint_ParamsSize;

	private static bool GetConstraint_ReturnValue_IsValid;

	private static FFieldAddress GetConstraint_ReturnValue_PropertyAddress;

	private static int GetConstraint_ReturnValue_Offset;

	private static bool GetConstrainedComponents_IsValid;

	private static IntPtr GetConstrainedComponents_FunctionAddress;

	private static int GetConstrainedComponents_ParamsSize;

	private static bool GetConstrainedComponents_OutComponent1_IsValid;

	private static FFieldAddress GetConstrainedComponents_OutComponent1_PropertyAddress;

	private static int GetConstrainedComponents_OutComponent1_Offset;

	private static bool GetConstrainedComponents_OutBoneName1_IsValid;

	private static FFieldAddress GetConstrainedComponents_OutBoneName1_PropertyAddress;

	private static int GetConstrainedComponents_OutBoneName1_Offset;

	private static bool GetConstrainedComponents_OutComponent2_IsValid;

	private static FFieldAddress GetConstrainedComponents_OutComponent2_PropertyAddress;

	private static int GetConstrainedComponents_OutComponent2_Offset;

	private static bool GetConstrainedComponents_OutBoneName2_IsValid;

	private static FFieldAddress GetConstrainedComponents_OutBoneName2_PropertyAddress;

	private static int GetConstrainedComponents_OutBoneName2_Offset;

	private static bool BreakConstraint_IsValid;

	private static IntPtr BreakConstraint_FunctionAddress;

	private static int BreakConstraint_ParamsSize;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:OnConstraintBroken")]
	public FConstraintBrokenSignature OnConstraintBroken
	{
		get
		{
			CheckDestroyed();
			if (!OnConstraintBroken_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsConstraintComponent:OnConstraintBroken");
				return new FConstraintBrokenSignature();
			}
			if (OnConstraintBroken_DelegateCached == null)
			{
				OnConstraintBroken_DelegateCached = new FConstraintBrokenSignature();
				OnConstraintBroken_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnConstraintBroken_Offset));
			}
			return OnConstraintBroken_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:OnPlasticDeformation")]
	public FPlasticDeformationEventSignature OnPlasticDeformation
	{
		get
		{
			CheckDestroyed();
			if (!OnPlasticDeformation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsConstraintComponent:OnPlasticDeformation");
				return new FPlasticDeformationEventSignature();
			}
			if (OnPlasticDeformation_DelegateCached == null)
			{
				OnPlasticDeformation_DelegateCached = new FPlasticDeformationEventSignature();
				OnPlasticDeformation_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPlasticDeformation_Offset));
			}
			return OnPlasticDeformation_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetOrientationDriveTwistAndSwing")]
	public unsafe void SetOrientationDriveTwistAndSwing(bool bEnableTwistDrive, bool bEnableSwingDrive)
	{
		CheckDestroyed();
		if (!SetOrientationDriveTwistAndSwing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetOrientationDriveTwistAndSwing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOrientationDriveTwistAndSwing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOrientationDriveTwistAndSwing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetOrientationDriveTwistAndSwing_bEnableTwistDrive_Offset), 0, SetOrientationDriveTwistAndSwing_bEnableTwistDrive_PropertyAddress.Address, bEnableTwistDrive);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetOrientationDriveTwistAndSwing_bEnableSwingDrive_Offset), 0, SetOrientationDriveTwistAndSwing_bEnableSwingDrive_PropertyAddress.Address, bEnableSwingDrive);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOrientationDriveTwistAndSwing_FunctionAddress, intPtr, SetOrientationDriveTwistAndSwing_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetOrientationDriveSLERP")]
	public unsafe void SetOrientationDriveSLERP(bool bEnableSLERP)
	{
		CheckDestroyed();
		if (!SetOrientationDriveSLERP_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetOrientationDriveSLERP");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOrientationDriveSLERP_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOrientationDriveSLERP_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetOrientationDriveSLERP_bEnableSLERP_Offset), 0, SetOrientationDriveSLERP_bEnableSLERP_PropertyAddress.Address, bEnableSLERP);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOrientationDriveSLERP_FunctionAddress, intPtr, SetOrientationDriveSLERP_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetLinearZLimit")]
	public unsafe void SetLinearZLimit(ELinearConstraintMotion ConstraintType, float LimitSize)
	{
		CheckDestroyed();
		if (!SetLinearZLimit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetLinearZLimit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLinearZLimit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLinearZLimit_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ELinearConstraintMotion>.ToNative(IntPtr.Add(intPtr, SetLinearZLimit_ConstraintType_Offset), 0, SetLinearZLimit_ConstraintType_PropertyAddress.Address, ConstraintType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLinearZLimit_LimitSize_Offset), 0, SetLinearZLimit_LimitSize_PropertyAddress.Address, LimitSize);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLinearZLimit_FunctionAddress, intPtr, SetLinearZLimit_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetLinearYLimit")]
	public unsafe void SetLinearYLimit(ELinearConstraintMotion ConstraintType, float LimitSize)
	{
		CheckDestroyed();
		if (!SetLinearYLimit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetLinearYLimit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLinearYLimit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLinearYLimit_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ELinearConstraintMotion>.ToNative(IntPtr.Add(intPtr, SetLinearYLimit_ConstraintType_Offset), 0, SetLinearYLimit_ConstraintType_PropertyAddress.Address, ConstraintType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLinearYLimit_LimitSize_Offset), 0, SetLinearYLimit_LimitSize_PropertyAddress.Address, LimitSize);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLinearYLimit_FunctionAddress, intPtr, SetLinearYLimit_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetLinearXLimit")]
	public unsafe void SetLinearXLimit(ELinearConstraintMotion ConstraintType, float LimitSize)
	{
		CheckDestroyed();
		if (!SetLinearXLimit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetLinearXLimit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLinearXLimit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLinearXLimit_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ELinearConstraintMotion>.ToNative(IntPtr.Add(intPtr, SetLinearXLimit_ConstraintType_Offset), 0, SetLinearXLimit_ConstraintType_PropertyAddress.Address, ConstraintType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLinearXLimit_LimitSize_Offset), 0, SetLinearXLimit_LimitSize_PropertyAddress.Address, LimitSize);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLinearXLimit_FunctionAddress, intPtr, SetLinearXLimit_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetLinearVelocityTarget")]
	public unsafe void SetLinearVelocityTarget(FVector InVelTarget)
	{
		CheckDestroyed();
		if (!SetLinearVelocityTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetLinearVelocityTarget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLinearVelocityTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLinearVelocityTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetLinearVelocityTarget_InVelTarget_Offset), 0, SetLinearVelocityTarget_InVelTarget_PropertyAddress.Address, InVelTarget);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLinearVelocityTarget_FunctionAddress, intPtr, SetLinearVelocityTarget_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetLinearVelocityDrive")]
	public unsafe void SetLinearVelocityDrive(bool bEnableDriveX, bool bEnableDriveY, bool bEnableDriveZ)
	{
		CheckDestroyed();
		if (!SetLinearVelocityDrive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetLinearVelocityDrive");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLinearVelocityDrive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLinearVelocityDrive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLinearVelocityDrive_bEnableDriveX_Offset), 0, SetLinearVelocityDrive_bEnableDriveX_PropertyAddress.Address, bEnableDriveX);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLinearVelocityDrive_bEnableDriveY_Offset), 0, SetLinearVelocityDrive_bEnableDriveY_PropertyAddress.Address, bEnableDriveY);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLinearVelocityDrive_bEnableDriveZ_Offset), 0, SetLinearVelocityDrive_bEnableDriveZ_PropertyAddress.Address, bEnableDriveZ);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLinearVelocityDrive_FunctionAddress, intPtr, SetLinearVelocityDrive_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetLinearPositionTarget")]
	public unsafe void SetLinearPositionTarget(FVector InPosTarget)
	{
		CheckDestroyed();
		if (!SetLinearPositionTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetLinearPositionTarget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLinearPositionTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLinearPositionTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetLinearPositionTarget_InPosTarget_Offset), 0, SetLinearPositionTarget_InPosTarget_PropertyAddress.Address, InPosTarget);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLinearPositionTarget_FunctionAddress, intPtr, SetLinearPositionTarget_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetLinearPositionDrive")]
	public unsafe void SetLinearPositionDrive(bool bEnableDriveX, bool bEnableDriveY, bool bEnableDriveZ)
	{
		CheckDestroyed();
		if (!SetLinearPositionDrive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetLinearPositionDrive");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLinearPositionDrive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLinearPositionDrive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLinearPositionDrive_bEnableDriveX_Offset), 0, SetLinearPositionDrive_bEnableDriveX_PropertyAddress.Address, bEnableDriveX);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLinearPositionDrive_bEnableDriveY_Offset), 0, SetLinearPositionDrive_bEnableDriveY_PropertyAddress.Address, bEnableDriveY);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLinearPositionDrive_bEnableDriveZ_Offset), 0, SetLinearPositionDrive_bEnableDriveZ_PropertyAddress.Address, bEnableDriveZ);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLinearPositionDrive_FunctionAddress, intPtr, SetLinearPositionDrive_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetLinearPlasticity")]
	public unsafe void SetLinearPlasticity(bool bLinearPlasticity, float LinearPlasticityThreshold, EConstraintPlasticityType PlasticityType)
	{
		CheckDestroyed();
		if (!SetLinearPlasticity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetLinearPlasticity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLinearPlasticity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLinearPlasticity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLinearPlasticity_bLinearPlasticity_Offset), 0, SetLinearPlasticity_bLinearPlasticity_PropertyAddress.Address, bLinearPlasticity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLinearPlasticity_LinearPlasticityThreshold_Offset), 0, SetLinearPlasticity_LinearPlasticityThreshold_PropertyAddress.Address, LinearPlasticityThreshold);
		EnumMarshaler<EConstraintPlasticityType>.ToNative(IntPtr.Add(intPtr, SetLinearPlasticity_PlasticityType_Offset), 0, SetLinearPlasticity_PlasticityType_PropertyAddress.Address, PlasticityType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLinearPlasticity_FunctionAddress, intPtr, SetLinearPlasticity_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetLinearDriveParams")]
	public unsafe void SetLinearDriveParams(float PositionStrength, float VelocityStrength, float InForceLimit)
	{
		CheckDestroyed();
		if (!SetLinearDriveParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetLinearDriveParams");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLinearDriveParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLinearDriveParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLinearDriveParams_PositionStrength_Offset), 0, SetLinearDriveParams_PositionStrength_PropertyAddress.Address, PositionStrength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLinearDriveParams_VelocityStrength_Offset), 0, SetLinearDriveParams_VelocityStrength_PropertyAddress.Address, VelocityStrength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLinearDriveParams_InForceLimit_Offset), 0, SetLinearDriveParams_InForceLimit_PropertyAddress.Address, InForceLimit);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLinearDriveParams_FunctionAddress, intPtr, SetLinearDriveParams_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetLinearBreakable")]
	public unsafe void SetLinearBreakable(bool bLinearBreakable, float LinearBreakThreshold)
	{
		CheckDestroyed();
		if (!SetLinearBreakable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetLinearBreakable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLinearBreakable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLinearBreakable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLinearBreakable_bLinearBreakable_Offset), 0, SetLinearBreakable_bLinearBreakable_PropertyAddress.Address, bLinearBreakable);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLinearBreakable_LinearBreakThreshold_Offset), 0, SetLinearBreakable_LinearBreakThreshold_PropertyAddress.Address, LinearBreakThreshold);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLinearBreakable_FunctionAddress, intPtr, SetLinearBreakable_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetDisableCollision")]
	public unsafe void SetDisableCollision(bool bDisableCollision)
	{
		CheckDestroyed();
		if (!SetDisableCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetDisableCollision");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDisableCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDisableCollision_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetDisableCollision_bDisableCollision_Offset), 0, SetDisableCollision_bDisableCollision_PropertyAddress.Address, bDisableCollision);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDisableCollision_FunctionAddress, intPtr, SetDisableCollision_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetContactTransferScale")]
	public unsafe void SetContactTransferScale(float ContactTransferScale)
	{
		CheckDestroyed();
		if (!SetContactTransferScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetContactTransferScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetContactTransferScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetContactTransferScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetContactTransferScale_ContactTransferScale_Offset), 0, SetContactTransferScale_ContactTransferScale_PropertyAddress.Address, ContactTransferScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetContactTransferScale_FunctionAddress, intPtr, SetContactTransferScale_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetConstraintReferencePosition")]
	public unsafe void SetConstraintReferencePosition(EConstraintFrame Frame, FVector RefPosition)
	{
		CheckDestroyed();
		if (!SetConstraintReferencePosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetConstraintReferencePosition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetConstraintReferencePosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetConstraintReferencePosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConstraintFrame>.ToNative(IntPtr.Add(intPtr, SetConstraintReferencePosition_Frame_Offset), 0, SetConstraintReferencePosition_Frame_PropertyAddress.Address, Frame);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetConstraintReferencePosition_RefPosition_Offset), 0, SetConstraintReferencePosition_RefPosition_PropertyAddress.Address, RefPosition);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetConstraintReferencePosition_FunctionAddress, intPtr, SetConstraintReferencePosition_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetConstraintReferenceOrientation")]
	public unsafe void SetConstraintReferenceOrientation(EConstraintFrame Frame, FVector PriAxis, FVector SecAxis)
	{
		CheckDestroyed();
		if (!SetConstraintReferenceOrientation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetConstraintReferenceOrientation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetConstraintReferenceOrientation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetConstraintReferenceOrientation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConstraintFrame>.ToNative(IntPtr.Add(intPtr, SetConstraintReferenceOrientation_Frame_Offset), 0, SetConstraintReferenceOrientation_Frame_PropertyAddress.Address, Frame);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetConstraintReferenceOrientation_PriAxis_Offset), 0, SetConstraintReferenceOrientation_PriAxis_PropertyAddress.Address, PriAxis);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetConstraintReferenceOrientation_SecAxis_Offset), 0, SetConstraintReferenceOrientation_SecAxis_PropertyAddress.Address, SecAxis);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetConstraintReferenceOrientation_FunctionAddress, intPtr, SetConstraintReferenceOrientation_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetConstraintReferenceFrame")]
	public unsafe void SetConstraintReferenceFrame(EConstraintFrame Frame, FTransform RefFrame)
	{
		CheckDestroyed();
		if (!SetConstraintReferenceFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetConstraintReferenceFrame");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetConstraintReferenceFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetConstraintReferenceFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConstraintFrame>.ToNative(IntPtr.Add(intPtr, SetConstraintReferenceFrame_Frame_Offset), 0, SetConstraintReferenceFrame_Frame_PropertyAddress.Address, Frame);
		NativeReflection.InitializeValue_InContainer(SetConstraintReferenceFrame_RefFrame_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetConstraintReferenceFrame_RefFrame_Offset), 0, SetConstraintReferenceFrame_RefFrame_PropertyAddress.Address, RefFrame);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetConstraintReferenceFrame_FunctionAddress, intPtr, SetConstraintReferenceFrame_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetConstrainedComponents")]
	public unsafe void SetConstrainedComponents(UPrimitiveComponent Component1, FName BoneName1, UPrimitiveComponent Component2, FName BoneName2)
	{
		CheckDestroyed();
		if (!SetConstrainedComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetConstrainedComponents");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetConstrainedComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetConstrainedComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, SetConstrainedComponents_Component1_Offset), 0, SetConstrainedComponents_Component1_PropertyAddress.Address, Component1);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetConstrainedComponents_BoneName1_Offset), 0, SetConstrainedComponents_BoneName1_PropertyAddress.Address, BoneName1);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, SetConstrainedComponents_Component2_Offset), 0, SetConstrainedComponents_Component2_PropertyAddress.Address, Component2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetConstrainedComponents_BoneName2_Offset), 0, SetConstrainedComponents_BoneName2_PropertyAddress.Address, BoneName2);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetConstrainedComponents_FunctionAddress, intPtr, SetConstrainedComponents_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetAngularVelocityTarget")]
	public unsafe void SetAngularVelocityTarget(FVector InVelTarget)
	{
		CheckDestroyed();
		if (!SetAngularVelocityTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetAngularVelocityTarget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAngularVelocityTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAngularVelocityTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetAngularVelocityTarget_InVelTarget_Offset), 0, SetAngularVelocityTarget_InVelTarget_PropertyAddress.Address, InVelTarget);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAngularVelocityTarget_FunctionAddress, intPtr, SetAngularVelocityTarget_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetAngularVelocityDriveTwistAndSwing")]
	public unsafe void SetAngularVelocityDriveTwistAndSwing(bool bEnableTwistDrive, bool bEnableSwingDrive)
	{
		CheckDestroyed();
		if (!SetAngularVelocityDriveTwistAndSwing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetAngularVelocityDriveTwistAndSwing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAngularVelocityDriveTwistAndSwing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAngularVelocityDriveTwistAndSwing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAngularVelocityDriveTwistAndSwing_bEnableTwistDrive_Offset), 0, SetAngularVelocityDriveTwistAndSwing_bEnableTwistDrive_PropertyAddress.Address, bEnableTwistDrive);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAngularVelocityDriveTwistAndSwing_bEnableSwingDrive_Offset), 0, SetAngularVelocityDriveTwistAndSwing_bEnableSwingDrive_PropertyAddress.Address, bEnableSwingDrive);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAngularVelocityDriveTwistAndSwing_FunctionAddress, intPtr, SetAngularVelocityDriveTwistAndSwing_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetAngularVelocityDriveSLERP")]
	public unsafe void SetAngularVelocityDriveSLERP(bool bEnableSLERP)
	{
		CheckDestroyed();
		if (!SetAngularVelocityDriveSLERP_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetAngularVelocityDriveSLERP");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAngularVelocityDriveSLERP_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAngularVelocityDriveSLERP_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAngularVelocityDriveSLERP_bEnableSLERP_Offset), 0, SetAngularVelocityDriveSLERP_bEnableSLERP_PropertyAddress.Address, bEnableSLERP);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAngularVelocityDriveSLERP_FunctionAddress, intPtr, SetAngularVelocityDriveSLERP_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetAngularTwistLimit")]
	public unsafe void SetAngularTwistLimit(EAngularConstraintMotion ConstraintType, float TwistLimitAngle)
	{
		CheckDestroyed();
		if (!SetAngularTwistLimit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetAngularTwistLimit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAngularTwistLimit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAngularTwistLimit_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EAngularConstraintMotion>.ToNative(IntPtr.Add(intPtr, SetAngularTwistLimit_ConstraintType_Offset), 0, SetAngularTwistLimit_ConstraintType_PropertyAddress.Address, ConstraintType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularTwistLimit_TwistLimitAngle_Offset), 0, SetAngularTwistLimit_TwistLimitAngle_PropertyAddress.Address, TwistLimitAngle);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAngularTwistLimit_FunctionAddress, intPtr, SetAngularTwistLimit_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetAngularSwing2Limit")]
	public unsafe void SetAngularSwing2Limit(EAngularConstraintMotion MotionType, float Swing2LimitAngle)
	{
		CheckDestroyed();
		if (!SetAngularSwing2Limit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetAngularSwing2Limit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAngularSwing2Limit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAngularSwing2Limit_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EAngularConstraintMotion>.ToNative(IntPtr.Add(intPtr, SetAngularSwing2Limit_MotionType_Offset), 0, SetAngularSwing2Limit_MotionType_PropertyAddress.Address, MotionType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularSwing2Limit_Swing2LimitAngle_Offset), 0, SetAngularSwing2Limit_Swing2LimitAngle_PropertyAddress.Address, Swing2LimitAngle);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAngularSwing2Limit_FunctionAddress, intPtr, SetAngularSwing2Limit_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetAngularSwing1Limit")]
	public unsafe void SetAngularSwing1Limit(EAngularConstraintMotion MotionType, float Swing1LimitAngle)
	{
		CheckDestroyed();
		if (!SetAngularSwing1Limit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetAngularSwing1Limit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAngularSwing1Limit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAngularSwing1Limit_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EAngularConstraintMotion>.ToNative(IntPtr.Add(intPtr, SetAngularSwing1Limit_MotionType_Offset), 0, SetAngularSwing1Limit_MotionType_PropertyAddress.Address, MotionType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularSwing1Limit_Swing1LimitAngle_Offset), 0, SetAngularSwing1Limit_Swing1LimitAngle_PropertyAddress.Address, Swing1LimitAngle);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAngularSwing1Limit_FunctionAddress, intPtr, SetAngularSwing1Limit_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetAngularPlasticity")]
	public unsafe void SetAngularPlasticity(bool bAngularPlasticity, float AngularPlasticityThreshold)
	{
		CheckDestroyed();
		if (!SetAngularPlasticity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetAngularPlasticity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAngularPlasticity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAngularPlasticity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAngularPlasticity_bAngularPlasticity_Offset), 0, SetAngularPlasticity_bAngularPlasticity_PropertyAddress.Address, bAngularPlasticity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularPlasticity_AngularPlasticityThreshold_Offset), 0, SetAngularPlasticity_AngularPlasticityThreshold_PropertyAddress.Address, AngularPlasticityThreshold);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAngularPlasticity_FunctionAddress, intPtr, SetAngularPlasticity_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetAngularOrientationTarget")]
	public unsafe void SetAngularOrientationTarget(FRotator InPosTarget)
	{
		CheckDestroyed();
		if (!SetAngularOrientationTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetAngularOrientationTarget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAngularOrientationTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAngularOrientationTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetAngularOrientationTarget_InPosTarget_Offset), 0, SetAngularOrientationTarget_InPosTarget_PropertyAddress.Address, InPosTarget);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAngularOrientationTarget_FunctionAddress, intPtr, SetAngularOrientationTarget_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetAngularDriveParams")]
	public unsafe void SetAngularDriveParams(float PositionStrength, float VelocityStrength, float InForceLimit)
	{
		CheckDestroyed();
		if (!SetAngularDriveParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetAngularDriveParams");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAngularDriveParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAngularDriveParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularDriveParams_PositionStrength_Offset), 0, SetAngularDriveParams_PositionStrength_PropertyAddress.Address, PositionStrength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularDriveParams_VelocityStrength_Offset), 0, SetAngularDriveParams_VelocityStrength_PropertyAddress.Address, VelocityStrength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularDriveParams_InForceLimit_Offset), 0, SetAngularDriveParams_InForceLimit_PropertyAddress.Address, InForceLimit);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAngularDriveParams_FunctionAddress, intPtr, SetAngularDriveParams_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetAngularDriveMode")]
	public unsafe void SetAngularDriveMode(EAngularDriveMode DriveMode)
	{
		CheckDestroyed();
		if (!SetAngularDriveMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetAngularDriveMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAngularDriveMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAngularDriveMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EAngularDriveMode>.ToNative(IntPtr.Add(intPtr, SetAngularDriveMode_DriveMode_Offset), 0, SetAngularDriveMode_DriveMode_PropertyAddress.Address, DriveMode);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAngularDriveMode_FunctionAddress, intPtr, SetAngularDriveMode_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:SetAngularBreakable")]
	public unsafe void SetAngularBreakable(bool bAngularBreakable, float AngularBreakThreshold)
	{
		CheckDestroyed();
		if (!SetAngularBreakable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:SetAngularBreakable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAngularBreakable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAngularBreakable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAngularBreakable_bAngularBreakable_Offset), 0, SetAngularBreakable_bAngularBreakable_PropertyAddress.Address, bAngularBreakable);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularBreakable_AngularBreakThreshold_Offset), 0, SetAngularBreakable_AngularBreakThreshold_PropertyAddress.Address, AngularBreakThreshold);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAngularBreakable_FunctionAddress, intPtr, SetAngularBreakable_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:IsBroken")]
	public unsafe bool IsBroken()
	{
		CheckDestroyed();
		if (!IsBroken_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:IsBroken");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsBroken_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsBroken_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsBroken_FunctionAddress, intPtr, IsBroken_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsBroken_ReturnValue_Offset), 0, IsBroken_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:GetCurrentTwist")]
	public unsafe float GetCurrentTwist()
	{
		CheckDestroyed();
		if (!GetCurrentTwist_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:GetCurrentTwist");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentTwist_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentTwist_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentTwist_FunctionAddress, intPtr, GetCurrentTwist_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCurrentTwist_ReturnValue_Offset), 0, GetCurrentTwist_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:GetCurrentSwing2")]
	public unsafe float GetCurrentSwing2()
	{
		CheckDestroyed();
		if (!GetCurrentSwing2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:GetCurrentSwing2");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentSwing2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentSwing2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentSwing2_FunctionAddress, intPtr, GetCurrentSwing2_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCurrentSwing2_ReturnValue_Offset), 0, GetCurrentSwing2_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:GetCurrentSwing1")]
	public unsafe float GetCurrentSwing1()
	{
		CheckDestroyed();
		if (!GetCurrentSwing1_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:GetCurrentSwing1");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentSwing1_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentSwing1_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentSwing1_FunctionAddress, intPtr, GetCurrentSwing1_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCurrentSwing1_ReturnValue_Offset), 0, GetCurrentSwing1_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:GetConstraintForce")]
	public unsafe void GetConstraintForce(out FVector OutLinearForce, out FVector OutAngularForce)
	{
		CheckDestroyed();
		if (!GetConstraintForce_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:GetConstraintForce");
			OutLinearForce = default(FVector);
			OutAngularForce = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetConstraintForce_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetConstraintForce_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetConstraintForce_FunctionAddress, intPtr, GetConstraintForce_ParamsSize);
		OutLinearForce = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetConstraintForce_OutLinearForce_Offset), 0, GetConstraintForce_OutLinearForce_PropertyAddress.Address);
		OutAngularForce = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetConstraintForce_OutAngularForce_Offset), 0, GetConstraintForce_OutAngularForce_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:GetConstraint")]
	public unsafe FConstraintInstanceAccessor GetConstraint()
	{
		CheckDestroyed();
		if (!GetConstraint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:GetConstraint");
			return default(FConstraintInstanceAccessor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetConstraint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetConstraint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetConstraint_FunctionAddress, intPtr, GetConstraint_ParamsSize);
		FConstraintInstanceAccessor result = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetConstraint_ReturnValue_Offset), 0, GetConstraint_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetConstraint_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:GetConstrainedComponents")]
	public unsafe void GetConstrainedComponents(out UPrimitiveComponent OutComponent1, out FName OutBoneName1, out UPrimitiveComponent OutComponent2, out FName OutBoneName2)
	{
		CheckDestroyed();
		if (!GetConstrainedComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:GetConstrainedComponents");
			OutComponent1 = null;
			OutBoneName1 = default(FName);
			OutComponent2 = null;
			OutBoneName2 = default(FName);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetConstrainedComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetConstrainedComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetConstrainedComponents_FunctionAddress, intPtr, GetConstrainedComponents_ParamsSize);
		OutComponent1 = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(intPtr, GetConstrainedComponents_OutComponent1_Offset), 0, GetConstrainedComponents_OutComponent1_PropertyAddress.Address);
		OutBoneName1 = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetConstrainedComponents_OutBoneName1_Offset), 0, GetConstrainedComponents_OutBoneName1_PropertyAddress.Address);
		OutComponent2 = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(intPtr, GetConstrainedComponents_OutComponent2_Offset), 0, GetConstrainedComponents_OutComponent2_PropertyAddress.Address);
		OutBoneName2 = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetConstrainedComponents_OutBoneName2_Offset), 0, GetConstrainedComponents_OutBoneName2_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsConstraintComponent:BreakConstraint")]
	public unsafe void BreakConstraint()
	{
		CheckDestroyed();
		if (!BreakConstraint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsConstraintComponent:BreakConstraint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BreakConstraint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BreakConstraint_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BreakConstraint_FunctionAddress, argsSize: BreakConstraint_ParamsSize);
	}

	static UPhysicsConstraintComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPhysicsConstraintComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPhysicsConstraintComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.PhysicsConstraintComponent");
		OnConstraintBroken_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnConstraintBroken");
		OnConstraintBroken_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnConstraintBroken", Classes.FMulticastDelegateProperty);
		OnPlasticDeformation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPlasticDeformation");
		OnPlasticDeformation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPlasticDeformation", Classes.FMulticastDelegateProperty);
		SetOrientationDriveTwistAndSwing_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOrientationDriveTwistAndSwing");
		SetOrientationDriveTwistAndSwing_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOrientationDriveTwistAndSwing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOrientationDriveTwistAndSwing_bEnableTwistDrive_PropertyAddress, SetOrientationDriveTwistAndSwing_FunctionAddress, "bEnableTwistDrive");
		SetOrientationDriveTwistAndSwing_bEnableTwistDrive_Offset = NativeReflectionCached.GetPropertyOffset(SetOrientationDriveTwistAndSwing_FunctionAddress, "bEnableTwistDrive");
		SetOrientationDriveTwistAndSwing_bEnableTwistDrive_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOrientationDriveTwistAndSwing_FunctionAddress, "bEnableTwistDrive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOrientationDriveTwistAndSwing_bEnableSwingDrive_PropertyAddress, SetOrientationDriveTwistAndSwing_FunctionAddress, "bEnableSwingDrive");
		SetOrientationDriveTwistAndSwing_bEnableSwingDrive_Offset = NativeReflectionCached.GetPropertyOffset(SetOrientationDriveTwistAndSwing_FunctionAddress, "bEnableSwingDrive");
		SetOrientationDriveTwistAndSwing_bEnableSwingDrive_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOrientationDriveTwistAndSwing_FunctionAddress, "bEnableSwingDrive", Classes.FBoolProperty);
		SetOrientationDriveTwistAndSwing_IsValid = SetOrientationDriveTwistAndSwing_FunctionAddress != IntPtr.Zero && SetOrientationDriveTwistAndSwing_bEnableTwistDrive_IsValid && SetOrientationDriveTwistAndSwing_bEnableSwingDrive_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetOrientationDriveTwistAndSwing", SetOrientationDriveTwistAndSwing_IsValid);
		SetOrientationDriveSLERP_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOrientationDriveSLERP");
		SetOrientationDriveSLERP_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOrientationDriveSLERP_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOrientationDriveSLERP_bEnableSLERP_PropertyAddress, SetOrientationDriveSLERP_FunctionAddress, "bEnableSLERP");
		SetOrientationDriveSLERP_bEnableSLERP_Offset = NativeReflectionCached.GetPropertyOffset(SetOrientationDriveSLERP_FunctionAddress, "bEnableSLERP");
		SetOrientationDriveSLERP_bEnableSLERP_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOrientationDriveSLERP_FunctionAddress, "bEnableSLERP", Classes.FBoolProperty);
		SetOrientationDriveSLERP_IsValid = SetOrientationDriveSLERP_FunctionAddress != IntPtr.Zero && SetOrientationDriveSLERP_bEnableSLERP_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetOrientationDriveSLERP", SetOrientationDriveSLERP_IsValid);
		SetLinearZLimit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLinearZLimit");
		SetLinearZLimit_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLinearZLimit_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLinearZLimit_ConstraintType_PropertyAddress, SetLinearZLimit_FunctionAddress, "ConstraintType");
		SetLinearZLimit_ConstraintType_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearZLimit_FunctionAddress, "ConstraintType");
		SetLinearZLimit_ConstraintType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearZLimit_FunctionAddress, "ConstraintType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearZLimit_LimitSize_PropertyAddress, SetLinearZLimit_FunctionAddress, "LimitSize");
		SetLinearZLimit_LimitSize_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearZLimit_FunctionAddress, "LimitSize");
		SetLinearZLimit_LimitSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearZLimit_FunctionAddress, "LimitSize", Classes.FFloatProperty);
		SetLinearZLimit_IsValid = SetLinearZLimit_FunctionAddress != IntPtr.Zero && SetLinearZLimit_ConstraintType_IsValid && SetLinearZLimit_LimitSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetLinearZLimit", SetLinearZLimit_IsValid);
		SetLinearYLimit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLinearYLimit");
		SetLinearYLimit_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLinearYLimit_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLinearYLimit_ConstraintType_PropertyAddress, SetLinearYLimit_FunctionAddress, "ConstraintType");
		SetLinearYLimit_ConstraintType_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearYLimit_FunctionAddress, "ConstraintType");
		SetLinearYLimit_ConstraintType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearYLimit_FunctionAddress, "ConstraintType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearYLimit_LimitSize_PropertyAddress, SetLinearYLimit_FunctionAddress, "LimitSize");
		SetLinearYLimit_LimitSize_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearYLimit_FunctionAddress, "LimitSize");
		SetLinearYLimit_LimitSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearYLimit_FunctionAddress, "LimitSize", Classes.FFloatProperty);
		SetLinearYLimit_IsValid = SetLinearYLimit_FunctionAddress != IntPtr.Zero && SetLinearYLimit_ConstraintType_IsValid && SetLinearYLimit_LimitSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetLinearYLimit", SetLinearYLimit_IsValid);
		SetLinearXLimit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLinearXLimit");
		SetLinearXLimit_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLinearXLimit_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLinearXLimit_ConstraintType_PropertyAddress, SetLinearXLimit_FunctionAddress, "ConstraintType");
		SetLinearXLimit_ConstraintType_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearXLimit_FunctionAddress, "ConstraintType");
		SetLinearXLimit_ConstraintType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearXLimit_FunctionAddress, "ConstraintType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearXLimit_LimitSize_PropertyAddress, SetLinearXLimit_FunctionAddress, "LimitSize");
		SetLinearXLimit_LimitSize_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearXLimit_FunctionAddress, "LimitSize");
		SetLinearXLimit_LimitSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearXLimit_FunctionAddress, "LimitSize", Classes.FFloatProperty);
		SetLinearXLimit_IsValid = SetLinearXLimit_FunctionAddress != IntPtr.Zero && SetLinearXLimit_ConstraintType_IsValid && SetLinearXLimit_LimitSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetLinearXLimit", SetLinearXLimit_IsValid);
		SetLinearVelocityTarget_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLinearVelocityTarget");
		SetLinearVelocityTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLinearVelocityTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLinearVelocityTarget_InVelTarget_PropertyAddress, SetLinearVelocityTarget_FunctionAddress, "InVelTarget");
		SetLinearVelocityTarget_InVelTarget_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearVelocityTarget_FunctionAddress, "InVelTarget");
		SetLinearVelocityTarget_InVelTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearVelocityTarget_FunctionAddress, "InVelTarget", Classes.FStructProperty);
		SetLinearVelocityTarget_IsValid = SetLinearVelocityTarget_FunctionAddress != IntPtr.Zero && SetLinearVelocityTarget_InVelTarget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetLinearVelocityTarget", SetLinearVelocityTarget_IsValid);
		SetLinearVelocityDrive_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLinearVelocityDrive");
		SetLinearVelocityDrive_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLinearVelocityDrive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLinearVelocityDrive_bEnableDriveX_PropertyAddress, SetLinearVelocityDrive_FunctionAddress, "bEnableDriveX");
		SetLinearVelocityDrive_bEnableDriveX_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearVelocityDrive_FunctionAddress, "bEnableDriveX");
		SetLinearVelocityDrive_bEnableDriveX_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearVelocityDrive_FunctionAddress, "bEnableDriveX", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearVelocityDrive_bEnableDriveY_PropertyAddress, SetLinearVelocityDrive_FunctionAddress, "bEnableDriveY");
		SetLinearVelocityDrive_bEnableDriveY_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearVelocityDrive_FunctionAddress, "bEnableDriveY");
		SetLinearVelocityDrive_bEnableDriveY_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearVelocityDrive_FunctionAddress, "bEnableDriveY", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearVelocityDrive_bEnableDriveZ_PropertyAddress, SetLinearVelocityDrive_FunctionAddress, "bEnableDriveZ");
		SetLinearVelocityDrive_bEnableDriveZ_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearVelocityDrive_FunctionAddress, "bEnableDriveZ");
		SetLinearVelocityDrive_bEnableDriveZ_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearVelocityDrive_FunctionAddress, "bEnableDriveZ", Classes.FBoolProperty);
		SetLinearVelocityDrive_IsValid = SetLinearVelocityDrive_FunctionAddress != IntPtr.Zero && SetLinearVelocityDrive_bEnableDriveX_IsValid && SetLinearVelocityDrive_bEnableDriveY_IsValid && SetLinearVelocityDrive_bEnableDriveZ_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetLinearVelocityDrive", SetLinearVelocityDrive_IsValid);
		SetLinearPositionTarget_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLinearPositionTarget");
		SetLinearPositionTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLinearPositionTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLinearPositionTarget_InPosTarget_PropertyAddress, SetLinearPositionTarget_FunctionAddress, "InPosTarget");
		SetLinearPositionTarget_InPosTarget_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearPositionTarget_FunctionAddress, "InPosTarget");
		SetLinearPositionTarget_InPosTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearPositionTarget_FunctionAddress, "InPosTarget", Classes.FStructProperty);
		SetLinearPositionTarget_IsValid = SetLinearPositionTarget_FunctionAddress != IntPtr.Zero && SetLinearPositionTarget_InPosTarget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetLinearPositionTarget", SetLinearPositionTarget_IsValid);
		SetLinearPositionDrive_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLinearPositionDrive");
		SetLinearPositionDrive_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLinearPositionDrive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLinearPositionDrive_bEnableDriveX_PropertyAddress, SetLinearPositionDrive_FunctionAddress, "bEnableDriveX");
		SetLinearPositionDrive_bEnableDriveX_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearPositionDrive_FunctionAddress, "bEnableDriveX");
		SetLinearPositionDrive_bEnableDriveX_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearPositionDrive_FunctionAddress, "bEnableDriveX", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearPositionDrive_bEnableDriveY_PropertyAddress, SetLinearPositionDrive_FunctionAddress, "bEnableDriveY");
		SetLinearPositionDrive_bEnableDriveY_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearPositionDrive_FunctionAddress, "bEnableDriveY");
		SetLinearPositionDrive_bEnableDriveY_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearPositionDrive_FunctionAddress, "bEnableDriveY", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearPositionDrive_bEnableDriveZ_PropertyAddress, SetLinearPositionDrive_FunctionAddress, "bEnableDriveZ");
		SetLinearPositionDrive_bEnableDriveZ_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearPositionDrive_FunctionAddress, "bEnableDriveZ");
		SetLinearPositionDrive_bEnableDriveZ_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearPositionDrive_FunctionAddress, "bEnableDriveZ", Classes.FBoolProperty);
		SetLinearPositionDrive_IsValid = SetLinearPositionDrive_FunctionAddress != IntPtr.Zero && SetLinearPositionDrive_bEnableDriveX_IsValid && SetLinearPositionDrive_bEnableDriveY_IsValid && SetLinearPositionDrive_bEnableDriveZ_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetLinearPositionDrive", SetLinearPositionDrive_IsValid);
		SetLinearPlasticity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLinearPlasticity");
		SetLinearPlasticity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLinearPlasticity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLinearPlasticity_bLinearPlasticity_PropertyAddress, SetLinearPlasticity_FunctionAddress, "bLinearPlasticity");
		SetLinearPlasticity_bLinearPlasticity_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearPlasticity_FunctionAddress, "bLinearPlasticity");
		SetLinearPlasticity_bLinearPlasticity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearPlasticity_FunctionAddress, "bLinearPlasticity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearPlasticity_LinearPlasticityThreshold_PropertyAddress, SetLinearPlasticity_FunctionAddress, "LinearPlasticityThreshold");
		SetLinearPlasticity_LinearPlasticityThreshold_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearPlasticity_FunctionAddress, "LinearPlasticityThreshold");
		SetLinearPlasticity_LinearPlasticityThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearPlasticity_FunctionAddress, "LinearPlasticityThreshold", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearPlasticity_PlasticityType_PropertyAddress, SetLinearPlasticity_FunctionAddress, "PlasticityType");
		SetLinearPlasticity_PlasticityType_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearPlasticity_FunctionAddress, "PlasticityType");
		SetLinearPlasticity_PlasticityType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearPlasticity_FunctionAddress, "PlasticityType", Classes.FByteProperty);
		SetLinearPlasticity_IsValid = SetLinearPlasticity_FunctionAddress != IntPtr.Zero && SetLinearPlasticity_bLinearPlasticity_IsValid && SetLinearPlasticity_LinearPlasticityThreshold_IsValid && SetLinearPlasticity_PlasticityType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetLinearPlasticity", SetLinearPlasticity_IsValid);
		SetLinearDriveParams_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLinearDriveParams");
		SetLinearDriveParams_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLinearDriveParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLinearDriveParams_PositionStrength_PropertyAddress, SetLinearDriveParams_FunctionAddress, "PositionStrength");
		SetLinearDriveParams_PositionStrength_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearDriveParams_FunctionAddress, "PositionStrength");
		SetLinearDriveParams_PositionStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearDriveParams_FunctionAddress, "PositionStrength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearDriveParams_VelocityStrength_PropertyAddress, SetLinearDriveParams_FunctionAddress, "VelocityStrength");
		SetLinearDriveParams_VelocityStrength_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearDriveParams_FunctionAddress, "VelocityStrength");
		SetLinearDriveParams_VelocityStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearDriveParams_FunctionAddress, "VelocityStrength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearDriveParams_InForceLimit_PropertyAddress, SetLinearDriveParams_FunctionAddress, "InForceLimit");
		SetLinearDriveParams_InForceLimit_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearDriveParams_FunctionAddress, "InForceLimit");
		SetLinearDriveParams_InForceLimit_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearDriveParams_FunctionAddress, "InForceLimit", Classes.FFloatProperty);
		SetLinearDriveParams_IsValid = SetLinearDriveParams_FunctionAddress != IntPtr.Zero && SetLinearDriveParams_PositionStrength_IsValid && SetLinearDriveParams_VelocityStrength_IsValid && SetLinearDriveParams_InForceLimit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetLinearDriveParams", SetLinearDriveParams_IsValid);
		SetLinearBreakable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLinearBreakable");
		SetLinearBreakable_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLinearBreakable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLinearBreakable_bLinearBreakable_PropertyAddress, SetLinearBreakable_FunctionAddress, "bLinearBreakable");
		SetLinearBreakable_bLinearBreakable_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearBreakable_FunctionAddress, "bLinearBreakable");
		SetLinearBreakable_bLinearBreakable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearBreakable_FunctionAddress, "bLinearBreakable", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearBreakable_LinearBreakThreshold_PropertyAddress, SetLinearBreakable_FunctionAddress, "LinearBreakThreshold");
		SetLinearBreakable_LinearBreakThreshold_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearBreakable_FunctionAddress, "LinearBreakThreshold");
		SetLinearBreakable_LinearBreakThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearBreakable_FunctionAddress, "LinearBreakThreshold", Classes.FFloatProperty);
		SetLinearBreakable_IsValid = SetLinearBreakable_FunctionAddress != IntPtr.Zero && SetLinearBreakable_bLinearBreakable_IsValid && SetLinearBreakable_LinearBreakThreshold_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetLinearBreakable", SetLinearBreakable_IsValid);
		SetDisableCollision_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDisableCollision");
		SetDisableCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDisableCollision_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDisableCollision_bDisableCollision_PropertyAddress, SetDisableCollision_FunctionAddress, "bDisableCollision");
		SetDisableCollision_bDisableCollision_Offset = NativeReflectionCached.GetPropertyOffset(SetDisableCollision_FunctionAddress, "bDisableCollision");
		SetDisableCollision_bDisableCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDisableCollision_FunctionAddress, "bDisableCollision", Classes.FBoolProperty);
		SetDisableCollision_IsValid = SetDisableCollision_FunctionAddress != IntPtr.Zero && SetDisableCollision_bDisableCollision_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetDisableCollision", SetDisableCollision_IsValid);
		SetContactTransferScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetContactTransferScale");
		SetContactTransferScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetContactTransferScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetContactTransferScale_ContactTransferScale_PropertyAddress, SetContactTransferScale_FunctionAddress, "ContactTransferScale");
		SetContactTransferScale_ContactTransferScale_Offset = NativeReflectionCached.GetPropertyOffset(SetContactTransferScale_FunctionAddress, "ContactTransferScale");
		SetContactTransferScale_ContactTransferScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetContactTransferScale_FunctionAddress, "ContactTransferScale", Classes.FFloatProperty);
		SetContactTransferScale_IsValid = SetContactTransferScale_FunctionAddress != IntPtr.Zero && SetContactTransferScale_ContactTransferScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetContactTransferScale", SetContactTransferScale_IsValid);
		SetConstraintReferencePosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetConstraintReferencePosition");
		SetConstraintReferencePosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetConstraintReferencePosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetConstraintReferencePosition_Frame_PropertyAddress, SetConstraintReferencePosition_FunctionAddress, "Frame");
		SetConstraintReferencePosition_Frame_Offset = NativeReflectionCached.GetPropertyOffset(SetConstraintReferencePosition_FunctionAddress, "Frame");
		SetConstraintReferencePosition_Frame_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConstraintReferencePosition_FunctionAddress, "Frame", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConstraintReferencePosition_RefPosition_PropertyAddress, SetConstraintReferencePosition_FunctionAddress, "RefPosition");
		SetConstraintReferencePosition_RefPosition_Offset = NativeReflectionCached.GetPropertyOffset(SetConstraintReferencePosition_FunctionAddress, "RefPosition");
		SetConstraintReferencePosition_RefPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConstraintReferencePosition_FunctionAddress, "RefPosition", Classes.FStructProperty);
		SetConstraintReferencePosition_IsValid = SetConstraintReferencePosition_FunctionAddress != IntPtr.Zero && SetConstraintReferencePosition_Frame_IsValid && SetConstraintReferencePosition_RefPosition_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetConstraintReferencePosition", SetConstraintReferencePosition_IsValid);
		SetConstraintReferenceOrientation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetConstraintReferenceOrientation");
		SetConstraintReferenceOrientation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetConstraintReferenceOrientation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetConstraintReferenceOrientation_Frame_PropertyAddress, SetConstraintReferenceOrientation_FunctionAddress, "Frame");
		SetConstraintReferenceOrientation_Frame_Offset = NativeReflectionCached.GetPropertyOffset(SetConstraintReferenceOrientation_FunctionAddress, "Frame");
		SetConstraintReferenceOrientation_Frame_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConstraintReferenceOrientation_FunctionAddress, "Frame", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConstraintReferenceOrientation_PriAxis_PropertyAddress, SetConstraintReferenceOrientation_FunctionAddress, "PriAxis");
		SetConstraintReferenceOrientation_PriAxis_Offset = NativeReflectionCached.GetPropertyOffset(SetConstraintReferenceOrientation_FunctionAddress, "PriAxis");
		SetConstraintReferenceOrientation_PriAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConstraintReferenceOrientation_FunctionAddress, "PriAxis", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConstraintReferenceOrientation_SecAxis_PropertyAddress, SetConstraintReferenceOrientation_FunctionAddress, "SecAxis");
		SetConstraintReferenceOrientation_SecAxis_Offset = NativeReflectionCached.GetPropertyOffset(SetConstraintReferenceOrientation_FunctionAddress, "SecAxis");
		SetConstraintReferenceOrientation_SecAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConstraintReferenceOrientation_FunctionAddress, "SecAxis", Classes.FStructProperty);
		SetConstraintReferenceOrientation_IsValid = SetConstraintReferenceOrientation_FunctionAddress != IntPtr.Zero && SetConstraintReferenceOrientation_Frame_IsValid && SetConstraintReferenceOrientation_PriAxis_IsValid && SetConstraintReferenceOrientation_SecAxis_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetConstraintReferenceOrientation", SetConstraintReferenceOrientation_IsValid);
		SetConstraintReferenceFrame_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetConstraintReferenceFrame");
		SetConstraintReferenceFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(SetConstraintReferenceFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetConstraintReferenceFrame_Frame_PropertyAddress, SetConstraintReferenceFrame_FunctionAddress, "Frame");
		SetConstraintReferenceFrame_Frame_Offset = NativeReflectionCached.GetPropertyOffset(SetConstraintReferenceFrame_FunctionAddress, "Frame");
		SetConstraintReferenceFrame_Frame_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConstraintReferenceFrame_FunctionAddress, "Frame", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConstraintReferenceFrame_RefFrame_PropertyAddress, SetConstraintReferenceFrame_FunctionAddress, "RefFrame");
		SetConstraintReferenceFrame_RefFrame_Offset = NativeReflectionCached.GetPropertyOffset(SetConstraintReferenceFrame_FunctionAddress, "RefFrame");
		SetConstraintReferenceFrame_RefFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConstraintReferenceFrame_FunctionAddress, "RefFrame", Classes.FStructProperty);
		SetConstraintReferenceFrame_IsValid = SetConstraintReferenceFrame_FunctionAddress != IntPtr.Zero && SetConstraintReferenceFrame_Frame_IsValid && SetConstraintReferenceFrame_RefFrame_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetConstraintReferenceFrame", SetConstraintReferenceFrame_IsValid);
		SetConstrainedComponents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetConstrainedComponents");
		SetConstrainedComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(SetConstrainedComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetConstrainedComponents_Component1_PropertyAddress, SetConstrainedComponents_FunctionAddress, "Component1");
		SetConstrainedComponents_Component1_Offset = NativeReflectionCached.GetPropertyOffset(SetConstrainedComponents_FunctionAddress, "Component1");
		SetConstrainedComponents_Component1_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConstrainedComponents_FunctionAddress, "Component1", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConstrainedComponents_BoneName1_PropertyAddress, SetConstrainedComponents_FunctionAddress, "BoneName1");
		SetConstrainedComponents_BoneName1_Offset = NativeReflectionCached.GetPropertyOffset(SetConstrainedComponents_FunctionAddress, "BoneName1");
		SetConstrainedComponents_BoneName1_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConstrainedComponents_FunctionAddress, "BoneName1", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConstrainedComponents_Component2_PropertyAddress, SetConstrainedComponents_FunctionAddress, "Component2");
		SetConstrainedComponents_Component2_Offset = NativeReflectionCached.GetPropertyOffset(SetConstrainedComponents_FunctionAddress, "Component2");
		SetConstrainedComponents_Component2_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConstrainedComponents_FunctionAddress, "Component2", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConstrainedComponents_BoneName2_PropertyAddress, SetConstrainedComponents_FunctionAddress, "BoneName2");
		SetConstrainedComponents_BoneName2_Offset = NativeReflectionCached.GetPropertyOffset(SetConstrainedComponents_FunctionAddress, "BoneName2");
		SetConstrainedComponents_BoneName2_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConstrainedComponents_FunctionAddress, "BoneName2", Classes.FNameProperty);
		SetConstrainedComponents_IsValid = SetConstrainedComponents_FunctionAddress != IntPtr.Zero && SetConstrainedComponents_Component1_IsValid && SetConstrainedComponents_BoneName1_IsValid && SetConstrainedComponents_Component2_IsValid && SetConstrainedComponents_BoneName2_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetConstrainedComponents", SetConstrainedComponents_IsValid);
		SetAngularVelocityTarget_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAngularVelocityTarget");
		SetAngularVelocityTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAngularVelocityTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAngularVelocityTarget_InVelTarget_PropertyAddress, SetAngularVelocityTarget_FunctionAddress, "InVelTarget");
		SetAngularVelocityTarget_InVelTarget_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularVelocityTarget_FunctionAddress, "InVelTarget");
		SetAngularVelocityTarget_InVelTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularVelocityTarget_FunctionAddress, "InVelTarget", Classes.FStructProperty);
		SetAngularVelocityTarget_IsValid = SetAngularVelocityTarget_FunctionAddress != IntPtr.Zero && SetAngularVelocityTarget_InVelTarget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetAngularVelocityTarget", SetAngularVelocityTarget_IsValid);
		SetAngularVelocityDriveTwistAndSwing_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAngularVelocityDriveTwistAndSwing");
		SetAngularVelocityDriveTwistAndSwing_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAngularVelocityDriveTwistAndSwing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAngularVelocityDriveTwistAndSwing_bEnableTwistDrive_PropertyAddress, SetAngularVelocityDriveTwistAndSwing_FunctionAddress, "bEnableTwistDrive");
		SetAngularVelocityDriveTwistAndSwing_bEnableTwistDrive_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularVelocityDriveTwistAndSwing_FunctionAddress, "bEnableTwistDrive");
		SetAngularVelocityDriveTwistAndSwing_bEnableTwistDrive_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularVelocityDriveTwistAndSwing_FunctionAddress, "bEnableTwistDrive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularVelocityDriveTwistAndSwing_bEnableSwingDrive_PropertyAddress, SetAngularVelocityDriveTwistAndSwing_FunctionAddress, "bEnableSwingDrive");
		SetAngularVelocityDriveTwistAndSwing_bEnableSwingDrive_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularVelocityDriveTwistAndSwing_FunctionAddress, "bEnableSwingDrive");
		SetAngularVelocityDriveTwistAndSwing_bEnableSwingDrive_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularVelocityDriveTwistAndSwing_FunctionAddress, "bEnableSwingDrive", Classes.FBoolProperty);
		SetAngularVelocityDriveTwistAndSwing_IsValid = SetAngularVelocityDriveTwistAndSwing_FunctionAddress != IntPtr.Zero && SetAngularVelocityDriveTwistAndSwing_bEnableTwistDrive_IsValid && SetAngularVelocityDriveTwistAndSwing_bEnableSwingDrive_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetAngularVelocityDriveTwistAndSwing", SetAngularVelocityDriveTwistAndSwing_IsValid);
		SetAngularVelocityDriveSLERP_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAngularVelocityDriveSLERP");
		SetAngularVelocityDriveSLERP_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAngularVelocityDriveSLERP_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAngularVelocityDriveSLERP_bEnableSLERP_PropertyAddress, SetAngularVelocityDriveSLERP_FunctionAddress, "bEnableSLERP");
		SetAngularVelocityDriveSLERP_bEnableSLERP_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularVelocityDriveSLERP_FunctionAddress, "bEnableSLERP");
		SetAngularVelocityDriveSLERP_bEnableSLERP_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularVelocityDriveSLERP_FunctionAddress, "bEnableSLERP", Classes.FBoolProperty);
		SetAngularVelocityDriveSLERP_IsValid = SetAngularVelocityDriveSLERP_FunctionAddress != IntPtr.Zero && SetAngularVelocityDriveSLERP_bEnableSLERP_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetAngularVelocityDriveSLERP", SetAngularVelocityDriveSLERP_IsValid);
		SetAngularTwistLimit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAngularTwistLimit");
		SetAngularTwistLimit_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAngularTwistLimit_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAngularTwistLimit_ConstraintType_PropertyAddress, SetAngularTwistLimit_FunctionAddress, "ConstraintType");
		SetAngularTwistLimit_ConstraintType_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularTwistLimit_FunctionAddress, "ConstraintType");
		SetAngularTwistLimit_ConstraintType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularTwistLimit_FunctionAddress, "ConstraintType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularTwistLimit_TwistLimitAngle_PropertyAddress, SetAngularTwistLimit_FunctionAddress, "TwistLimitAngle");
		SetAngularTwistLimit_TwistLimitAngle_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularTwistLimit_FunctionAddress, "TwistLimitAngle");
		SetAngularTwistLimit_TwistLimitAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularTwistLimit_FunctionAddress, "TwistLimitAngle", Classes.FFloatProperty);
		SetAngularTwistLimit_IsValid = SetAngularTwistLimit_FunctionAddress != IntPtr.Zero && SetAngularTwistLimit_ConstraintType_IsValid && SetAngularTwistLimit_TwistLimitAngle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetAngularTwistLimit", SetAngularTwistLimit_IsValid);
		SetAngularSwing2Limit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAngularSwing2Limit");
		SetAngularSwing2Limit_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAngularSwing2Limit_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAngularSwing2Limit_MotionType_PropertyAddress, SetAngularSwing2Limit_FunctionAddress, "MotionType");
		SetAngularSwing2Limit_MotionType_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularSwing2Limit_FunctionAddress, "MotionType");
		SetAngularSwing2Limit_MotionType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularSwing2Limit_FunctionAddress, "MotionType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularSwing2Limit_Swing2LimitAngle_PropertyAddress, SetAngularSwing2Limit_FunctionAddress, "Swing2LimitAngle");
		SetAngularSwing2Limit_Swing2LimitAngle_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularSwing2Limit_FunctionAddress, "Swing2LimitAngle");
		SetAngularSwing2Limit_Swing2LimitAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularSwing2Limit_FunctionAddress, "Swing2LimitAngle", Classes.FFloatProperty);
		SetAngularSwing2Limit_IsValid = SetAngularSwing2Limit_FunctionAddress != IntPtr.Zero && SetAngularSwing2Limit_MotionType_IsValid && SetAngularSwing2Limit_Swing2LimitAngle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetAngularSwing2Limit", SetAngularSwing2Limit_IsValid);
		SetAngularSwing1Limit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAngularSwing1Limit");
		SetAngularSwing1Limit_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAngularSwing1Limit_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAngularSwing1Limit_MotionType_PropertyAddress, SetAngularSwing1Limit_FunctionAddress, "MotionType");
		SetAngularSwing1Limit_MotionType_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularSwing1Limit_FunctionAddress, "MotionType");
		SetAngularSwing1Limit_MotionType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularSwing1Limit_FunctionAddress, "MotionType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularSwing1Limit_Swing1LimitAngle_PropertyAddress, SetAngularSwing1Limit_FunctionAddress, "Swing1LimitAngle");
		SetAngularSwing1Limit_Swing1LimitAngle_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularSwing1Limit_FunctionAddress, "Swing1LimitAngle");
		SetAngularSwing1Limit_Swing1LimitAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularSwing1Limit_FunctionAddress, "Swing1LimitAngle", Classes.FFloatProperty);
		SetAngularSwing1Limit_IsValid = SetAngularSwing1Limit_FunctionAddress != IntPtr.Zero && SetAngularSwing1Limit_MotionType_IsValid && SetAngularSwing1Limit_Swing1LimitAngle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetAngularSwing1Limit", SetAngularSwing1Limit_IsValid);
		SetAngularPlasticity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAngularPlasticity");
		SetAngularPlasticity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAngularPlasticity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAngularPlasticity_bAngularPlasticity_PropertyAddress, SetAngularPlasticity_FunctionAddress, "bAngularPlasticity");
		SetAngularPlasticity_bAngularPlasticity_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularPlasticity_FunctionAddress, "bAngularPlasticity");
		SetAngularPlasticity_bAngularPlasticity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularPlasticity_FunctionAddress, "bAngularPlasticity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularPlasticity_AngularPlasticityThreshold_PropertyAddress, SetAngularPlasticity_FunctionAddress, "AngularPlasticityThreshold");
		SetAngularPlasticity_AngularPlasticityThreshold_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularPlasticity_FunctionAddress, "AngularPlasticityThreshold");
		SetAngularPlasticity_AngularPlasticityThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularPlasticity_FunctionAddress, "AngularPlasticityThreshold", Classes.FFloatProperty);
		SetAngularPlasticity_IsValid = SetAngularPlasticity_FunctionAddress != IntPtr.Zero && SetAngularPlasticity_bAngularPlasticity_IsValid && SetAngularPlasticity_AngularPlasticityThreshold_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetAngularPlasticity", SetAngularPlasticity_IsValid);
		SetAngularOrientationTarget_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAngularOrientationTarget");
		SetAngularOrientationTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAngularOrientationTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAngularOrientationTarget_InPosTarget_PropertyAddress, SetAngularOrientationTarget_FunctionAddress, "InPosTarget");
		SetAngularOrientationTarget_InPosTarget_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularOrientationTarget_FunctionAddress, "InPosTarget");
		SetAngularOrientationTarget_InPosTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularOrientationTarget_FunctionAddress, "InPosTarget", Classes.FStructProperty);
		SetAngularOrientationTarget_IsValid = SetAngularOrientationTarget_FunctionAddress != IntPtr.Zero && SetAngularOrientationTarget_InPosTarget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetAngularOrientationTarget", SetAngularOrientationTarget_IsValid);
		SetAngularDriveParams_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAngularDriveParams");
		SetAngularDriveParams_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAngularDriveParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAngularDriveParams_PositionStrength_PropertyAddress, SetAngularDriveParams_FunctionAddress, "PositionStrength");
		SetAngularDriveParams_PositionStrength_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularDriveParams_FunctionAddress, "PositionStrength");
		SetAngularDriveParams_PositionStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularDriveParams_FunctionAddress, "PositionStrength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularDriveParams_VelocityStrength_PropertyAddress, SetAngularDriveParams_FunctionAddress, "VelocityStrength");
		SetAngularDriveParams_VelocityStrength_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularDriveParams_FunctionAddress, "VelocityStrength");
		SetAngularDriveParams_VelocityStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularDriveParams_FunctionAddress, "VelocityStrength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularDriveParams_InForceLimit_PropertyAddress, SetAngularDriveParams_FunctionAddress, "InForceLimit");
		SetAngularDriveParams_InForceLimit_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularDriveParams_FunctionAddress, "InForceLimit");
		SetAngularDriveParams_InForceLimit_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularDriveParams_FunctionAddress, "InForceLimit", Classes.FFloatProperty);
		SetAngularDriveParams_IsValid = SetAngularDriveParams_FunctionAddress != IntPtr.Zero && SetAngularDriveParams_PositionStrength_IsValid && SetAngularDriveParams_VelocityStrength_IsValid && SetAngularDriveParams_InForceLimit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetAngularDriveParams", SetAngularDriveParams_IsValid);
		SetAngularDriveMode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAngularDriveMode");
		SetAngularDriveMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAngularDriveMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAngularDriveMode_DriveMode_PropertyAddress, SetAngularDriveMode_FunctionAddress, "DriveMode");
		SetAngularDriveMode_DriveMode_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularDriveMode_FunctionAddress, "DriveMode");
		SetAngularDriveMode_DriveMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularDriveMode_FunctionAddress, "DriveMode", Classes.FByteProperty);
		SetAngularDriveMode_IsValid = SetAngularDriveMode_FunctionAddress != IntPtr.Zero && SetAngularDriveMode_DriveMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetAngularDriveMode", SetAngularDriveMode_IsValid);
		SetAngularBreakable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAngularBreakable");
		SetAngularBreakable_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAngularBreakable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAngularBreakable_bAngularBreakable_PropertyAddress, SetAngularBreakable_FunctionAddress, "bAngularBreakable");
		SetAngularBreakable_bAngularBreakable_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularBreakable_FunctionAddress, "bAngularBreakable");
		SetAngularBreakable_bAngularBreakable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularBreakable_FunctionAddress, "bAngularBreakable", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAngularBreakable_AngularBreakThreshold_PropertyAddress, SetAngularBreakable_FunctionAddress, "AngularBreakThreshold");
		SetAngularBreakable_AngularBreakThreshold_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularBreakable_FunctionAddress, "AngularBreakThreshold");
		SetAngularBreakable_AngularBreakThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularBreakable_FunctionAddress, "AngularBreakThreshold", Classes.FFloatProperty);
		SetAngularBreakable_IsValid = SetAngularBreakable_FunctionAddress != IntPtr.Zero && SetAngularBreakable_bAngularBreakable_IsValid && SetAngularBreakable_AngularBreakThreshold_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:SetAngularBreakable", SetAngularBreakable_IsValid);
		IsBroken_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsBroken");
		IsBroken_ParamsSize = NativeReflection.GetFunctionParamsSize(IsBroken_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsBroken_ReturnValue_PropertyAddress, IsBroken_FunctionAddress, "ReturnValue");
		IsBroken_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsBroken_FunctionAddress, "ReturnValue");
		IsBroken_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsBroken_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsBroken_IsValid = IsBroken_FunctionAddress != IntPtr.Zero && IsBroken_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:IsBroken", IsBroken_IsValid);
		GetCurrentTwist_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCurrentTwist");
		GetCurrentTwist_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentTwist_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentTwist_ReturnValue_PropertyAddress, GetCurrentTwist_FunctionAddress, "ReturnValue");
		GetCurrentTwist_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentTwist_FunctionAddress, "ReturnValue");
		GetCurrentTwist_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentTwist_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCurrentTwist_IsValid = GetCurrentTwist_FunctionAddress != IntPtr.Zero && GetCurrentTwist_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:GetCurrentTwist", GetCurrentTwist_IsValid);
		GetCurrentSwing2_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCurrentSwing2");
		GetCurrentSwing2_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentSwing2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentSwing2_ReturnValue_PropertyAddress, GetCurrentSwing2_FunctionAddress, "ReturnValue");
		GetCurrentSwing2_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentSwing2_FunctionAddress, "ReturnValue");
		GetCurrentSwing2_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentSwing2_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCurrentSwing2_IsValid = GetCurrentSwing2_FunctionAddress != IntPtr.Zero && GetCurrentSwing2_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:GetCurrentSwing2", GetCurrentSwing2_IsValid);
		GetCurrentSwing1_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCurrentSwing1");
		GetCurrentSwing1_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentSwing1_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentSwing1_ReturnValue_PropertyAddress, GetCurrentSwing1_FunctionAddress, "ReturnValue");
		GetCurrentSwing1_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentSwing1_FunctionAddress, "ReturnValue");
		GetCurrentSwing1_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentSwing1_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCurrentSwing1_IsValid = GetCurrentSwing1_FunctionAddress != IntPtr.Zero && GetCurrentSwing1_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:GetCurrentSwing1", GetCurrentSwing1_IsValid);
		GetConstraintForce_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetConstraintForce");
		GetConstraintForce_ParamsSize = NativeReflection.GetFunctionParamsSize(GetConstraintForce_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetConstraintForce_OutLinearForce_PropertyAddress, GetConstraintForce_FunctionAddress, "OutLinearForce");
		GetConstraintForce_OutLinearForce_Offset = NativeReflectionCached.GetPropertyOffset(GetConstraintForce_FunctionAddress, "OutLinearForce");
		GetConstraintForce_OutLinearForce_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConstraintForce_FunctionAddress, "OutLinearForce", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetConstraintForce_OutAngularForce_PropertyAddress, GetConstraintForce_FunctionAddress, "OutAngularForce");
		GetConstraintForce_OutAngularForce_Offset = NativeReflectionCached.GetPropertyOffset(GetConstraintForce_FunctionAddress, "OutAngularForce");
		GetConstraintForce_OutAngularForce_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConstraintForce_FunctionAddress, "OutAngularForce", Classes.FStructProperty);
		GetConstraintForce_IsValid = GetConstraintForce_FunctionAddress != IntPtr.Zero && GetConstraintForce_OutLinearForce_IsValid && GetConstraintForce_OutAngularForce_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:GetConstraintForce", GetConstraintForce_IsValid);
		GetConstraint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetConstraint");
		GetConstraint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetConstraint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetConstraint_ReturnValue_PropertyAddress, GetConstraint_FunctionAddress, "ReturnValue");
		GetConstraint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetConstraint_FunctionAddress, "ReturnValue");
		GetConstraint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConstraint_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetConstraint_IsValid = GetConstraint_FunctionAddress != IntPtr.Zero && GetConstraint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:GetConstraint", GetConstraint_IsValid);
		GetConstrainedComponents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetConstrainedComponents");
		GetConstrainedComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetConstrainedComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetConstrainedComponents_OutComponent1_PropertyAddress, GetConstrainedComponents_FunctionAddress, "OutComponent1");
		GetConstrainedComponents_OutComponent1_Offset = NativeReflectionCached.GetPropertyOffset(GetConstrainedComponents_FunctionAddress, "OutComponent1");
		GetConstrainedComponents_OutComponent1_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConstrainedComponents_FunctionAddress, "OutComponent1", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetConstrainedComponents_OutBoneName1_PropertyAddress, GetConstrainedComponents_FunctionAddress, "OutBoneName1");
		GetConstrainedComponents_OutBoneName1_Offset = NativeReflectionCached.GetPropertyOffset(GetConstrainedComponents_FunctionAddress, "OutBoneName1");
		GetConstrainedComponents_OutBoneName1_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConstrainedComponents_FunctionAddress, "OutBoneName1", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetConstrainedComponents_OutComponent2_PropertyAddress, GetConstrainedComponents_FunctionAddress, "OutComponent2");
		GetConstrainedComponents_OutComponent2_Offset = NativeReflectionCached.GetPropertyOffset(GetConstrainedComponents_FunctionAddress, "OutComponent2");
		GetConstrainedComponents_OutComponent2_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConstrainedComponents_FunctionAddress, "OutComponent2", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetConstrainedComponents_OutBoneName2_PropertyAddress, GetConstrainedComponents_FunctionAddress, "OutBoneName2");
		GetConstrainedComponents_OutBoneName2_Offset = NativeReflectionCached.GetPropertyOffset(GetConstrainedComponents_FunctionAddress, "OutBoneName2");
		GetConstrainedComponents_OutBoneName2_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConstrainedComponents_FunctionAddress, "OutBoneName2", Classes.FNameProperty);
		GetConstrainedComponents_IsValid = GetConstrainedComponents_FunctionAddress != IntPtr.Zero && GetConstrainedComponents_OutComponent1_IsValid && GetConstrainedComponents_OutBoneName1_IsValid && GetConstrainedComponents_OutComponent2_IsValid && GetConstrainedComponents_OutBoneName2_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:GetConstrainedComponents", GetConstrainedComponents_IsValid);
		BreakConstraint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BreakConstraint");
		BreakConstraint_ParamsSize = NativeReflection.GetFunctionParamsSize(BreakConstraint_FunctionAddress);
		BreakConstraint_IsValid = BreakConstraint_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsConstraintComponent:BreakConstraint", BreakConstraint_IsValid);
	}
}
