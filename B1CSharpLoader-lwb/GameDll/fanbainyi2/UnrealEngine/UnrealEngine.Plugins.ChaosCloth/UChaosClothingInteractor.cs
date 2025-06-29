using System;
using System.Runtime.CompilerServices;
using UnrealEngine.ClothingSystemRuntimeInterface;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ChaosCloth;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/ChaosCloth.ChaosClothingInteractor", "ChaosCloth", UnrealModuleType.EnginePlugin)]
public class UChaosClothingInteractor : UClothingInteractor
{
	private static bool SetWind_IsValid;

	private static IntPtr SetWind_FunctionAddress;

	private static int SetWind_ParamsSize;

	private static bool SetWind_Drag_IsValid;

	private static FFieldAddress SetWind_Drag_PropertyAddress;

	private static int SetWind_Drag_Offset;

	private static bool SetWind_Lift_IsValid;

	private static FFieldAddress SetWind_Lift_PropertyAddress;

	private static int SetWind_Lift_Offset;

	private static bool SetWind_AirDensity_IsValid;

	private static FFieldAddress SetWind_AirDensity_PropertyAddress;

	private static int SetWind_AirDensity_Offset;

	private static bool SetWind_WindVelocity_IsValid;

	private static FFieldAddress SetWind_WindVelocity_PropertyAddress;

	private static int SetWind_WindVelocity_Offset;

	private static bool SetVelocityScale_IsValid;

	private static IntPtr SetVelocityScale_FunctionAddress;

	private static int SetVelocityScale_ParamsSize;

	private static bool SetVelocityScale_LinearVelocityScale_IsValid;

	private static FFieldAddress SetVelocityScale_LinearVelocityScale_PropertyAddress;

	private static int SetVelocityScale_LinearVelocityScale_Offset;

	private static bool SetVelocityScale_AngularVelocityScale_IsValid;

	private static FFieldAddress SetVelocityScale_AngularVelocityScale_PropertyAddress;

	private static int SetVelocityScale_AngularVelocityScale_Offset;

	private static bool SetVelocityScale_FictitiousAngularScale_IsValid;

	private static FFieldAddress SetVelocityScale_FictitiousAngularScale_PropertyAddress;

	private static int SetVelocityScale_FictitiousAngularScale_Offset;

	private static bool SetMaterialLinear_IsValid;

	private static IntPtr SetMaterialLinear_FunctionAddress;

	private static int SetMaterialLinear_ParamsSize;

	private static bool SetMaterialLinear_EdgeStiffness_IsValid;

	private static FFieldAddress SetMaterialLinear_EdgeStiffness_PropertyAddress;

	private static int SetMaterialLinear_EdgeStiffness_Offset;

	private static bool SetMaterialLinear_BendingStiffness_IsValid;

	private static FFieldAddress SetMaterialLinear_BendingStiffness_PropertyAddress;

	private static int SetMaterialLinear_BendingStiffness_Offset;

	private static bool SetMaterialLinear_AreaStiffness_IsValid;

	private static FFieldAddress SetMaterialLinear_AreaStiffness_PropertyAddress;

	private static int SetMaterialLinear_AreaStiffness_Offset;

	private static bool SetMaterial_IsValid;

	private static IntPtr SetMaterial_FunctionAddress;

	private static int SetMaterial_ParamsSize;

	private static bool SetMaterial_EdgeStiffness_IsValid;

	private static FFieldAddress SetMaterial_EdgeStiffness_PropertyAddress;

	private static int SetMaterial_EdgeStiffness_Offset;

	private static bool SetMaterial_BendingStiffness_IsValid;

	private static FFieldAddress SetMaterial_BendingStiffness_PropertyAddress;

	private static int SetMaterial_BendingStiffness_Offset;

	private static bool SetMaterial_AreaStiffness_IsValid;

	private static FFieldAddress SetMaterial_AreaStiffness_PropertyAddress;

	private static int SetMaterial_AreaStiffness_Offset;

	private static bool SetLongRangeAttachmentLinear_IsValid;

	private static IntPtr SetLongRangeAttachmentLinear_FunctionAddress;

	private static int SetLongRangeAttachmentLinear_ParamsSize;

	private static bool SetLongRangeAttachmentLinear_TetherStiffness_IsValid;

	private static FFieldAddress SetLongRangeAttachmentLinear_TetherStiffness_PropertyAddress;

	private static int SetLongRangeAttachmentLinear_TetherStiffness_Offset;

	private static bool SetLongRangeAttachmentLinear_TetherScale_IsValid;

	private static FFieldAddress SetLongRangeAttachmentLinear_TetherScale_PropertyAddress;

	private static int SetLongRangeAttachmentLinear_TetherScale_Offset;

	private static bool SetLongRangeAttachment_IsValid;

	private static IntPtr SetLongRangeAttachment_FunctionAddress;

	private static int SetLongRangeAttachment_ParamsSize;

	private static bool SetLongRangeAttachment_TetherStiffness_IsValid;

	private static FFieldAddress SetLongRangeAttachment_TetherStiffness_PropertyAddress;

	private static int SetLongRangeAttachment_TetherStiffness_Offset;

	private static bool SetLongRangeAttachment_TetherScale_IsValid;

	private static FFieldAddress SetLongRangeAttachment_TetherScale_PropertyAddress;

	private static int SetLongRangeAttachment_TetherScale_Offset;

	private static bool SetGravity_IsValid;

	private static IntPtr SetGravity_FunctionAddress;

	private static int SetGravity_ParamsSize;

	private static bool SetGravity_GravityScale_IsValid;

	private static FFieldAddress SetGravity_GravityScale_PropertyAddress;

	private static int SetGravity_GravityScale_Offset;

	private static bool SetGravity_bIsGravityOverridden_IsValid;

	private static FFieldAddress SetGravity_bIsGravityOverridden_PropertyAddress;

	private static int SetGravity_bIsGravityOverridden_Offset;

	private static bool SetGravity_GravityOverride_IsValid;

	private static FFieldAddress SetGravity_GravityOverride_PropertyAddress;

	private static int SetGravity_GravityOverride_Offset;

	private static bool SetDamping_IsValid;

	private static IntPtr SetDamping_FunctionAddress;

	private static int SetDamping_ParamsSize;

	private static bool SetDamping_DampingCoefficient_IsValid;

	private static FFieldAddress SetDamping_DampingCoefficient_PropertyAddress;

	private static int SetDamping_DampingCoefficient_Offset;

	private static bool SetCollision_IsValid;

	private static IntPtr SetCollision_FunctionAddress;

	private static int SetCollision_ParamsSize;

	private static bool SetCollision_CollisionThickness_IsValid;

	private static FFieldAddress SetCollision_CollisionThickness_PropertyAddress;

	private static int SetCollision_CollisionThickness_Offset;

	private static bool SetCollision_FrictionCoefficient_IsValid;

	private static FFieldAddress SetCollision_FrictionCoefficient_PropertyAddress;

	private static int SetCollision_FrictionCoefficient_Offset;

	private static bool SetCollision_bUseCCD_IsValid;

	private static FFieldAddress SetCollision_bUseCCD_PropertyAddress;

	private static int SetCollision_bUseCCD_Offset;

	private static bool SetCollision_SelfCollisionThickness_IsValid;

	private static FFieldAddress SetCollision_SelfCollisionThickness_PropertyAddress;

	private static int SetCollision_SelfCollisionThickness_Offset;

	private static bool SetBackstop_IsValid;

	private static IntPtr SetBackstop_FunctionAddress;

	private static int SetBackstop_ParamsSize;

	private static bool SetBackstop_bEnabled_IsValid;

	private static FFieldAddress SetBackstop_bEnabled_PropertyAddress;

	private static int SetBackstop_bEnabled_Offset;

	private static bool SetAnimDriveLinear_IsValid;

	private static IntPtr SetAnimDriveLinear_FunctionAddress;

	private static int SetAnimDriveLinear_ParamsSize;

	private static bool SetAnimDriveLinear_AnimDriveStiffness_IsValid;

	private static FFieldAddress SetAnimDriveLinear_AnimDriveStiffness_PropertyAddress;

	private static int SetAnimDriveLinear_AnimDriveStiffness_Offset;

	private static bool SetAnimDrive_IsValid;

	private static IntPtr SetAnimDrive_FunctionAddress;

	private static int SetAnimDrive_ParamsSize;

	private static bool SetAnimDrive_AnimDriveStiffness_IsValid;

	private static FFieldAddress SetAnimDrive_AnimDriveStiffness_PropertyAddress;

	private static int SetAnimDrive_AnimDriveStiffness_Offset;

	private static bool SetAnimDrive_AnimDriveDamping_IsValid;

	private static FFieldAddress SetAnimDrive_AnimDriveDamping_PropertyAddress;

	private static int SetAnimDrive_AnimDriveDamping_Offset;

	private static bool SetAerodynamics_IsValid;

	private static IntPtr SetAerodynamics_FunctionAddress;

	private static int SetAerodynamics_ParamsSize;

	private static bool SetAerodynamics_DragCoefficient_IsValid;

	private static FFieldAddress SetAerodynamics_DragCoefficient_PropertyAddress;

	private static int SetAerodynamics_DragCoefficient_Offset;

	private static bool SetAerodynamics_LiftCoefficient_IsValid;

	private static FFieldAddress SetAerodynamics_LiftCoefficient_PropertyAddress;

	private static int SetAerodynamics_LiftCoefficient_Offset;

	private static bool SetAerodynamics_WindVelocity_IsValid;

	private static FFieldAddress SetAerodynamics_WindVelocity_PropertyAddress;

	private static int SetAerodynamics_WindVelocity_Offset;

	private static bool ResetAndTeleport_IsValid;

	private static IntPtr ResetAndTeleport_FunctionAddress;

	private static int ResetAndTeleport_ParamsSize;

	private static bool ResetAndTeleport_bReset_IsValid;

	private static FFieldAddress ResetAndTeleport_bReset_PropertyAddress;

	private static int ResetAndTeleport_bReset_Offset;

	private static bool ResetAndTeleport_bTeleport_IsValid;

	private static FFieldAddress ResetAndTeleport_bTeleport_PropertyAddress;

	private static int ResetAndTeleport_bTeleport_Offset;

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ChaosCloth.ChaosClothingInteractor:SetWind")]
	public unsafe void SetWind(FVector2D Drag, FVector2D Lift, float AirDensity, FVector WindVelocity)
	{
		CheckDestroyed();
		if (!SetWind_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ChaosCloth.ChaosClothingInteractor:SetWind");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWind_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWind_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetWind_Drag_Offset), 0, SetWind_Drag_PropertyAddress.Address, Drag);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetWind_Lift_Offset), 0, SetWind_Lift_PropertyAddress.Address, Lift);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetWind_AirDensity_Offset), 0, SetWind_AirDensity_PropertyAddress.Address, AirDensity);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetWind_WindVelocity_Offset), 0, SetWind_WindVelocity_PropertyAddress.Address, WindVelocity);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWind_FunctionAddress, intPtr, SetWind_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ChaosCloth.ChaosClothingInteractor:SetVelocityScale")]
	public unsafe void SetVelocityScale(FVector LinearVelocityScale, float AngularVelocityScale, float FictitiousAngularScale)
	{
		CheckDestroyed();
		if (!SetVelocityScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ChaosCloth.ChaosClothingInteractor:SetVelocityScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVelocityScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVelocityScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetVelocityScale_LinearVelocityScale_Offset), 0, SetVelocityScale_LinearVelocityScale_PropertyAddress.Address, LinearVelocityScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetVelocityScale_AngularVelocityScale_Offset), 0, SetVelocityScale_AngularVelocityScale_PropertyAddress.Address, AngularVelocityScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetVelocityScale_FictitiousAngularScale_Offset), 0, SetVelocityScale_FictitiousAngularScale_PropertyAddress.Address, FictitiousAngularScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVelocityScale_FunctionAddress, intPtr, SetVelocityScale_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ChaosCloth.ChaosClothingInteractor:SetMaterialLinear")]
	public unsafe void SetMaterialLinear(float EdgeStiffness = 1f, float BendingStiffness = 1f, float AreaStiffness = 1f)
	{
		CheckDestroyed();
		if (!SetMaterialLinear_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ChaosCloth.ChaosClothingInteractor:SetMaterialLinear");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaterialLinear_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaterialLinear_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMaterialLinear_EdgeStiffness_Offset), 0, SetMaterialLinear_EdgeStiffness_PropertyAddress.Address, EdgeStiffness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMaterialLinear_BendingStiffness_Offset), 0, SetMaterialLinear_BendingStiffness_PropertyAddress.Address, BendingStiffness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMaterialLinear_AreaStiffness_Offset), 0, SetMaterialLinear_AreaStiffness_PropertyAddress.Address, AreaStiffness);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMaterialLinear_FunctionAddress, intPtr, SetMaterialLinear_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ChaosCloth.ChaosClothingInteractor:SetMaterial")]
	public unsafe void SetMaterial(FVector2D EdgeStiffness, FVector2D BendingStiffness, FVector2D AreaStiffness)
	{
		CheckDestroyed();
		if (!SetMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ChaosCloth.ChaosClothingInteractor:SetMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetMaterial_EdgeStiffness_Offset), 0, SetMaterial_EdgeStiffness_PropertyAddress.Address, EdgeStiffness);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetMaterial_BendingStiffness_Offset), 0, SetMaterial_BendingStiffness_PropertyAddress.Address, BendingStiffness);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetMaterial_AreaStiffness_Offset), 0, SetMaterial_AreaStiffness_PropertyAddress.Address, AreaStiffness);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMaterial_FunctionAddress, intPtr, SetMaterial_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ChaosCloth.ChaosClothingInteractor:SetLongRangeAttachmentLinear")]
	public unsafe void SetLongRangeAttachmentLinear(float TetherStiffness = 1f, float TetherScale = 1f)
	{
		CheckDestroyed();
		if (!SetLongRangeAttachmentLinear_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ChaosCloth.ChaosClothingInteractor:SetLongRangeAttachmentLinear");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLongRangeAttachmentLinear_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLongRangeAttachmentLinear_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLongRangeAttachmentLinear_TetherStiffness_Offset), 0, SetLongRangeAttachmentLinear_TetherStiffness_PropertyAddress.Address, TetherStiffness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLongRangeAttachmentLinear_TetherScale_Offset), 0, SetLongRangeAttachmentLinear_TetherScale_PropertyAddress.Address, TetherScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLongRangeAttachmentLinear_FunctionAddress, intPtr, SetLongRangeAttachmentLinear_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ChaosCloth.ChaosClothingInteractor:SetLongRangeAttachment")]
	public unsafe void SetLongRangeAttachment(FVector2D TetherStiffness, FVector2D TetherScale)
	{
		CheckDestroyed();
		if (!SetLongRangeAttachment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ChaosCloth.ChaosClothingInteractor:SetLongRangeAttachment");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLongRangeAttachment_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLongRangeAttachment_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetLongRangeAttachment_TetherStiffness_Offset), 0, SetLongRangeAttachment_TetherStiffness_PropertyAddress.Address, TetherStiffness);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetLongRangeAttachment_TetherScale_Offset), 0, SetLongRangeAttachment_TetherScale_PropertyAddress.Address, TetherScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLongRangeAttachment_FunctionAddress, intPtr, SetLongRangeAttachment_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ChaosCloth.ChaosClothingInteractor:SetGravity")]
	public unsafe void SetGravity(float GravityScale, bool bIsGravityOverridden, FVector GravityOverride)
	{
		CheckDestroyed();
		if (!SetGravity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ChaosCloth.ChaosClothingInteractor:SetGravity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGravity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGravity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetGravity_GravityScale_Offset), 0, SetGravity_GravityScale_PropertyAddress.Address, GravityScale);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetGravity_bIsGravityOverridden_Offset), 0, SetGravity_bIsGravityOverridden_PropertyAddress.Address, bIsGravityOverridden);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetGravity_GravityOverride_Offset), 0, SetGravity_GravityOverride_PropertyAddress.Address, GravityOverride);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGravity_FunctionAddress, intPtr, SetGravity_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ChaosCloth.ChaosClothingInteractor:SetDamping")]
	public unsafe void SetDamping(float DampingCoefficient = 0.01f)
	{
		CheckDestroyed();
		if (!SetDamping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ChaosCloth.ChaosClothingInteractor:SetDamping");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDamping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDamping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDamping_DampingCoefficient_Offset), 0, SetDamping_DampingCoefficient_PropertyAddress.Address, DampingCoefficient);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDamping_FunctionAddress, intPtr, SetDamping_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ChaosCloth.ChaosClothingInteractor:SetCollision")]
	public unsafe void SetCollision(float CollisionThickness = 1f, float FrictionCoefficient = 0.8f, bool bUseCCD = false, float SelfCollisionThickness = 2f)
	{
		CheckDestroyed();
		if (!SetCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ChaosCloth.ChaosClothingInteractor:SetCollision");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCollision_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCollision_CollisionThickness_Offset), 0, SetCollision_CollisionThickness_PropertyAddress.Address, CollisionThickness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCollision_FrictionCoefficient_Offset), 0, SetCollision_FrictionCoefficient_PropertyAddress.Address, FrictionCoefficient);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCollision_bUseCCD_Offset), 0, SetCollision_bUseCCD_PropertyAddress.Address, bUseCCD);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCollision_SelfCollisionThickness_Offset), 0, SetCollision_SelfCollisionThickness_PropertyAddress.Address, SelfCollisionThickness);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCollision_FunctionAddress, intPtr, SetCollision_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ChaosCloth.ChaosClothingInteractor:SetBackstop")]
	public unsafe void SetBackstop(bool bEnabled = true)
	{
		CheckDestroyed();
		if (!SetBackstop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ChaosCloth.ChaosClothingInteractor:SetBackstop");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBackstop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBackstop_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBackstop_bEnabled_Offset), 0, SetBackstop_bEnabled_PropertyAddress.Address, bEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBackstop_FunctionAddress, intPtr, SetBackstop_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ChaosCloth.ChaosClothingInteractor:SetAnimDriveLinear")]
	public unsafe void SetAnimDriveLinear(float AnimDriveStiffness = 0f)
	{
		CheckDestroyed();
		if (!SetAnimDriveLinear_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ChaosCloth.ChaosClothingInteractor:SetAnimDriveLinear");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAnimDriveLinear_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAnimDriveLinear_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAnimDriveLinear_AnimDriveStiffness_Offset), 0, SetAnimDriveLinear_AnimDriveStiffness_PropertyAddress.Address, AnimDriveStiffness);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAnimDriveLinear_FunctionAddress, intPtr, SetAnimDriveLinear_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ChaosCloth.ChaosClothingInteractor:SetAnimDrive")]
	public unsafe void SetAnimDrive(FVector2D AnimDriveStiffness, FVector2D AnimDriveDamping)
	{
		CheckDestroyed();
		if (!SetAnimDrive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ChaosCloth.ChaosClothingInteractor:SetAnimDrive");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAnimDrive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAnimDrive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetAnimDrive_AnimDriveStiffness_Offset), 0, SetAnimDrive_AnimDriveStiffness_PropertyAddress.Address, AnimDriveStiffness);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetAnimDrive_AnimDriveDamping_Offset), 0, SetAnimDrive_AnimDriveDamping_PropertyAddress.Address, AnimDriveDamping);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAnimDrive_FunctionAddress, intPtr, SetAnimDrive_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ChaosCloth.ChaosClothingInteractor:SetAerodynamics")]
	public unsafe void SetAerodynamics(float DragCoefficient, float LiftCoefficient, FVector WindVelocity)
	{
		CheckDestroyed();
		if (!SetAerodynamics_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ChaosCloth.ChaosClothingInteractor:SetAerodynamics");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAerodynamics_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAerodynamics_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAerodynamics_DragCoefficient_Offset), 0, SetAerodynamics_DragCoefficient_PropertyAddress.Address, DragCoefficient);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAerodynamics_LiftCoefficient_Offset), 0, SetAerodynamics_LiftCoefficient_PropertyAddress.Address, LiftCoefficient);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetAerodynamics_WindVelocity_Offset), 0, SetAerodynamics_WindVelocity_PropertyAddress.Address, WindVelocity);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAerodynamics_FunctionAddress, intPtr, SetAerodynamics_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ChaosCloth.ChaosClothingInteractor:ResetAndTeleport")]
	public unsafe void ResetAndTeleport(bool bReset = false, bool bTeleport = false)
	{
		CheckDestroyed();
		if (!ResetAndTeleport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ChaosCloth.ChaosClothingInteractor:ResetAndTeleport");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetAndTeleport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetAndTeleport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ResetAndTeleport_bReset_Offset), 0, ResetAndTeleport_bReset_PropertyAddress.Address, bReset);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ResetAndTeleport_bTeleport_Offset), 0, ResetAndTeleport_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, ResetAndTeleport_FunctionAddress, intPtr, ResetAndTeleport_ParamsSize);
	}

	static UChaosClothingInteractor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UChaosClothingInteractor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UChaosClothingInteractor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/ChaosCloth.ChaosClothingInteractor");
		SetWind_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetWind");
		SetWind_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWind_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWind_Drag_PropertyAddress, SetWind_FunctionAddress, "Drag");
		SetWind_Drag_Offset = NativeReflectionCached.GetPropertyOffset(SetWind_FunctionAddress, "Drag");
		SetWind_Drag_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWind_FunctionAddress, "Drag", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWind_Lift_PropertyAddress, SetWind_FunctionAddress, "Lift");
		SetWind_Lift_Offset = NativeReflectionCached.GetPropertyOffset(SetWind_FunctionAddress, "Lift");
		SetWind_Lift_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWind_FunctionAddress, "Lift", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWind_AirDensity_PropertyAddress, SetWind_FunctionAddress, "AirDensity");
		SetWind_AirDensity_Offset = NativeReflectionCached.GetPropertyOffset(SetWind_FunctionAddress, "AirDensity");
		SetWind_AirDensity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWind_FunctionAddress, "AirDensity", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWind_WindVelocity_PropertyAddress, SetWind_FunctionAddress, "WindVelocity");
		SetWind_WindVelocity_Offset = NativeReflectionCached.GetPropertyOffset(SetWind_FunctionAddress, "WindVelocity");
		SetWind_WindVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWind_FunctionAddress, "WindVelocity", Classes.FStructProperty);
		SetWind_IsValid = SetWind_FunctionAddress != IntPtr.Zero && SetWind_Drag_IsValid && SetWind_Lift_IsValid && SetWind_AirDensity_IsValid && SetWind_WindVelocity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ChaosCloth.ChaosClothingInteractor:SetWind", SetWind_IsValid);
		SetVelocityScale_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetVelocityScale");
		SetVelocityScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVelocityScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVelocityScale_LinearVelocityScale_PropertyAddress, SetVelocityScale_FunctionAddress, "LinearVelocityScale");
		SetVelocityScale_LinearVelocityScale_Offset = NativeReflectionCached.GetPropertyOffset(SetVelocityScale_FunctionAddress, "LinearVelocityScale");
		SetVelocityScale_LinearVelocityScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVelocityScale_FunctionAddress, "LinearVelocityScale", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVelocityScale_AngularVelocityScale_PropertyAddress, SetVelocityScale_FunctionAddress, "AngularVelocityScale");
		SetVelocityScale_AngularVelocityScale_Offset = NativeReflectionCached.GetPropertyOffset(SetVelocityScale_FunctionAddress, "AngularVelocityScale");
		SetVelocityScale_AngularVelocityScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVelocityScale_FunctionAddress, "AngularVelocityScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVelocityScale_FictitiousAngularScale_PropertyAddress, SetVelocityScale_FunctionAddress, "FictitiousAngularScale");
		SetVelocityScale_FictitiousAngularScale_Offset = NativeReflectionCached.GetPropertyOffset(SetVelocityScale_FunctionAddress, "FictitiousAngularScale");
		SetVelocityScale_FictitiousAngularScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVelocityScale_FunctionAddress, "FictitiousAngularScale", Classes.FFloatProperty);
		SetVelocityScale_IsValid = SetVelocityScale_FunctionAddress != IntPtr.Zero && SetVelocityScale_LinearVelocityScale_IsValid && SetVelocityScale_AngularVelocityScale_IsValid && SetVelocityScale_FictitiousAngularScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ChaosCloth.ChaosClothingInteractor:SetVelocityScale", SetVelocityScale_IsValid);
		SetMaterialLinear_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetMaterialLinear");
		SetMaterialLinear_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaterialLinear_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaterialLinear_EdgeStiffness_PropertyAddress, SetMaterialLinear_FunctionAddress, "EdgeStiffness");
		SetMaterialLinear_EdgeStiffness_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterialLinear_FunctionAddress, "EdgeStiffness");
		SetMaterialLinear_EdgeStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterialLinear_FunctionAddress, "EdgeStiffness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaterialLinear_BendingStiffness_PropertyAddress, SetMaterialLinear_FunctionAddress, "BendingStiffness");
		SetMaterialLinear_BendingStiffness_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterialLinear_FunctionAddress, "BendingStiffness");
		SetMaterialLinear_BendingStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterialLinear_FunctionAddress, "BendingStiffness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaterialLinear_AreaStiffness_PropertyAddress, SetMaterialLinear_FunctionAddress, "AreaStiffness");
		SetMaterialLinear_AreaStiffness_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterialLinear_FunctionAddress, "AreaStiffness");
		SetMaterialLinear_AreaStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterialLinear_FunctionAddress, "AreaStiffness", Classes.FFloatProperty);
		SetMaterialLinear_IsValid = SetMaterialLinear_FunctionAddress != IntPtr.Zero && SetMaterialLinear_EdgeStiffness_IsValid && SetMaterialLinear_BendingStiffness_IsValid && SetMaterialLinear_AreaStiffness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ChaosCloth.ChaosClothingInteractor:SetMaterialLinear", SetMaterialLinear_IsValid);
		SetMaterial_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetMaterial");
		SetMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaterial_EdgeStiffness_PropertyAddress, SetMaterial_FunctionAddress, "EdgeStiffness");
		SetMaterial_EdgeStiffness_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterial_FunctionAddress, "EdgeStiffness");
		SetMaterial_EdgeStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterial_FunctionAddress, "EdgeStiffness", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaterial_BendingStiffness_PropertyAddress, SetMaterial_FunctionAddress, "BendingStiffness");
		SetMaterial_BendingStiffness_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterial_FunctionAddress, "BendingStiffness");
		SetMaterial_BendingStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterial_FunctionAddress, "BendingStiffness", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaterial_AreaStiffness_PropertyAddress, SetMaterial_FunctionAddress, "AreaStiffness");
		SetMaterial_AreaStiffness_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterial_FunctionAddress, "AreaStiffness");
		SetMaterial_AreaStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterial_FunctionAddress, "AreaStiffness", Classes.FStructProperty);
		SetMaterial_IsValid = SetMaterial_FunctionAddress != IntPtr.Zero && SetMaterial_EdgeStiffness_IsValid && SetMaterial_BendingStiffness_IsValid && SetMaterial_AreaStiffness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ChaosCloth.ChaosClothingInteractor:SetMaterial", SetMaterial_IsValid);
		SetLongRangeAttachmentLinear_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetLongRangeAttachmentLinear");
		SetLongRangeAttachmentLinear_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLongRangeAttachmentLinear_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLongRangeAttachmentLinear_TetherStiffness_PropertyAddress, SetLongRangeAttachmentLinear_FunctionAddress, "TetherStiffness");
		SetLongRangeAttachmentLinear_TetherStiffness_Offset = NativeReflectionCached.GetPropertyOffset(SetLongRangeAttachmentLinear_FunctionAddress, "TetherStiffness");
		SetLongRangeAttachmentLinear_TetherStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLongRangeAttachmentLinear_FunctionAddress, "TetherStiffness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLongRangeAttachmentLinear_TetherScale_PropertyAddress, SetLongRangeAttachmentLinear_FunctionAddress, "TetherScale");
		SetLongRangeAttachmentLinear_TetherScale_Offset = NativeReflectionCached.GetPropertyOffset(SetLongRangeAttachmentLinear_FunctionAddress, "TetherScale");
		SetLongRangeAttachmentLinear_TetherScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLongRangeAttachmentLinear_FunctionAddress, "TetherScale", Classes.FFloatProperty);
		SetLongRangeAttachmentLinear_IsValid = SetLongRangeAttachmentLinear_FunctionAddress != IntPtr.Zero && SetLongRangeAttachmentLinear_TetherStiffness_IsValid && SetLongRangeAttachmentLinear_TetherScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ChaosCloth.ChaosClothingInteractor:SetLongRangeAttachmentLinear", SetLongRangeAttachmentLinear_IsValid);
		SetLongRangeAttachment_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetLongRangeAttachment");
		SetLongRangeAttachment_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLongRangeAttachment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLongRangeAttachment_TetherStiffness_PropertyAddress, SetLongRangeAttachment_FunctionAddress, "TetherStiffness");
		SetLongRangeAttachment_TetherStiffness_Offset = NativeReflectionCached.GetPropertyOffset(SetLongRangeAttachment_FunctionAddress, "TetherStiffness");
		SetLongRangeAttachment_TetherStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLongRangeAttachment_FunctionAddress, "TetherStiffness", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLongRangeAttachment_TetherScale_PropertyAddress, SetLongRangeAttachment_FunctionAddress, "TetherScale");
		SetLongRangeAttachment_TetherScale_Offset = NativeReflectionCached.GetPropertyOffset(SetLongRangeAttachment_FunctionAddress, "TetherScale");
		SetLongRangeAttachment_TetherScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLongRangeAttachment_FunctionAddress, "TetherScale", Classes.FStructProperty);
		SetLongRangeAttachment_IsValid = SetLongRangeAttachment_FunctionAddress != IntPtr.Zero && SetLongRangeAttachment_TetherStiffness_IsValid && SetLongRangeAttachment_TetherScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ChaosCloth.ChaosClothingInteractor:SetLongRangeAttachment", SetLongRangeAttachment_IsValid);
		SetGravity_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetGravity");
		SetGravity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGravity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGravity_GravityScale_PropertyAddress, SetGravity_FunctionAddress, "GravityScale");
		SetGravity_GravityScale_Offset = NativeReflectionCached.GetPropertyOffset(SetGravity_FunctionAddress, "GravityScale");
		SetGravity_GravityScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGravity_FunctionAddress, "GravityScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetGravity_bIsGravityOverridden_PropertyAddress, SetGravity_FunctionAddress, "bIsGravityOverridden");
		SetGravity_bIsGravityOverridden_Offset = NativeReflectionCached.GetPropertyOffset(SetGravity_FunctionAddress, "bIsGravityOverridden");
		SetGravity_bIsGravityOverridden_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGravity_FunctionAddress, "bIsGravityOverridden", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetGravity_GravityOverride_PropertyAddress, SetGravity_FunctionAddress, "GravityOverride");
		SetGravity_GravityOverride_Offset = NativeReflectionCached.GetPropertyOffset(SetGravity_FunctionAddress, "GravityOverride");
		SetGravity_GravityOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGravity_FunctionAddress, "GravityOverride", Classes.FStructProperty);
		SetGravity_IsValid = SetGravity_FunctionAddress != IntPtr.Zero && SetGravity_GravityScale_IsValid && SetGravity_bIsGravityOverridden_IsValid && SetGravity_GravityOverride_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ChaosCloth.ChaosClothingInteractor:SetGravity", SetGravity_IsValid);
		SetDamping_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetDamping");
		SetDamping_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDamping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDamping_DampingCoefficient_PropertyAddress, SetDamping_FunctionAddress, "DampingCoefficient");
		SetDamping_DampingCoefficient_Offset = NativeReflectionCached.GetPropertyOffset(SetDamping_FunctionAddress, "DampingCoefficient");
		SetDamping_DampingCoefficient_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDamping_FunctionAddress, "DampingCoefficient", Classes.FFloatProperty);
		SetDamping_IsValid = SetDamping_FunctionAddress != IntPtr.Zero && SetDamping_DampingCoefficient_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ChaosCloth.ChaosClothingInteractor:SetDamping", SetDamping_IsValid);
		SetCollision_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCollision");
		SetCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCollision_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCollision_CollisionThickness_PropertyAddress, SetCollision_FunctionAddress, "CollisionThickness");
		SetCollision_CollisionThickness_Offset = NativeReflectionCached.GetPropertyOffset(SetCollision_FunctionAddress, "CollisionThickness");
		SetCollision_CollisionThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollision_FunctionAddress, "CollisionThickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollision_FrictionCoefficient_PropertyAddress, SetCollision_FunctionAddress, "FrictionCoefficient");
		SetCollision_FrictionCoefficient_Offset = NativeReflectionCached.GetPropertyOffset(SetCollision_FunctionAddress, "FrictionCoefficient");
		SetCollision_FrictionCoefficient_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollision_FunctionAddress, "FrictionCoefficient", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollision_bUseCCD_PropertyAddress, SetCollision_FunctionAddress, "bUseCCD");
		SetCollision_bUseCCD_Offset = NativeReflectionCached.GetPropertyOffset(SetCollision_FunctionAddress, "bUseCCD");
		SetCollision_bUseCCD_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollision_FunctionAddress, "bUseCCD", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollision_SelfCollisionThickness_PropertyAddress, SetCollision_FunctionAddress, "SelfCollisionThickness");
		SetCollision_SelfCollisionThickness_Offset = NativeReflectionCached.GetPropertyOffset(SetCollision_FunctionAddress, "SelfCollisionThickness");
		SetCollision_SelfCollisionThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollision_FunctionAddress, "SelfCollisionThickness", Classes.FFloatProperty);
		SetCollision_IsValid = SetCollision_FunctionAddress != IntPtr.Zero && SetCollision_CollisionThickness_IsValid && SetCollision_FrictionCoefficient_IsValid && SetCollision_bUseCCD_IsValid && SetCollision_SelfCollisionThickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ChaosCloth.ChaosClothingInteractor:SetCollision", SetCollision_IsValid);
		SetBackstop_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetBackstop");
		SetBackstop_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBackstop_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBackstop_bEnabled_PropertyAddress, SetBackstop_FunctionAddress, "bEnabled");
		SetBackstop_bEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetBackstop_FunctionAddress, "bEnabled");
		SetBackstop_bEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBackstop_FunctionAddress, "bEnabled", Classes.FBoolProperty);
		SetBackstop_IsValid = SetBackstop_FunctionAddress != IntPtr.Zero && SetBackstop_bEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ChaosCloth.ChaosClothingInteractor:SetBackstop", SetBackstop_IsValid);
		SetAnimDriveLinear_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetAnimDriveLinear");
		SetAnimDriveLinear_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAnimDriveLinear_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAnimDriveLinear_AnimDriveStiffness_PropertyAddress, SetAnimDriveLinear_FunctionAddress, "AnimDriveStiffness");
		SetAnimDriveLinear_AnimDriveStiffness_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimDriveLinear_FunctionAddress, "AnimDriveStiffness");
		SetAnimDriveLinear_AnimDriveStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimDriveLinear_FunctionAddress, "AnimDriveStiffness", Classes.FFloatProperty);
		SetAnimDriveLinear_IsValid = SetAnimDriveLinear_FunctionAddress != IntPtr.Zero && SetAnimDriveLinear_AnimDriveStiffness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ChaosCloth.ChaosClothingInteractor:SetAnimDriveLinear", SetAnimDriveLinear_IsValid);
		SetAnimDrive_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetAnimDrive");
		SetAnimDrive_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAnimDrive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAnimDrive_AnimDriveStiffness_PropertyAddress, SetAnimDrive_FunctionAddress, "AnimDriveStiffness");
		SetAnimDrive_AnimDriveStiffness_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimDrive_FunctionAddress, "AnimDriveStiffness");
		SetAnimDrive_AnimDriveStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimDrive_FunctionAddress, "AnimDriveStiffness", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAnimDrive_AnimDriveDamping_PropertyAddress, SetAnimDrive_FunctionAddress, "AnimDriveDamping");
		SetAnimDrive_AnimDriveDamping_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimDrive_FunctionAddress, "AnimDriveDamping");
		SetAnimDrive_AnimDriveDamping_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimDrive_FunctionAddress, "AnimDriveDamping", Classes.FStructProperty);
		SetAnimDrive_IsValid = SetAnimDrive_FunctionAddress != IntPtr.Zero && SetAnimDrive_AnimDriveStiffness_IsValid && SetAnimDrive_AnimDriveDamping_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ChaosCloth.ChaosClothingInteractor:SetAnimDrive", SetAnimDrive_IsValid);
		SetAerodynamics_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetAerodynamics");
		SetAerodynamics_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAerodynamics_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAerodynamics_DragCoefficient_PropertyAddress, SetAerodynamics_FunctionAddress, "DragCoefficient");
		SetAerodynamics_DragCoefficient_Offset = NativeReflectionCached.GetPropertyOffset(SetAerodynamics_FunctionAddress, "DragCoefficient");
		SetAerodynamics_DragCoefficient_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAerodynamics_FunctionAddress, "DragCoefficient", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAerodynamics_LiftCoefficient_PropertyAddress, SetAerodynamics_FunctionAddress, "LiftCoefficient");
		SetAerodynamics_LiftCoefficient_Offset = NativeReflectionCached.GetPropertyOffset(SetAerodynamics_FunctionAddress, "LiftCoefficient");
		SetAerodynamics_LiftCoefficient_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAerodynamics_FunctionAddress, "LiftCoefficient", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAerodynamics_WindVelocity_PropertyAddress, SetAerodynamics_FunctionAddress, "WindVelocity");
		SetAerodynamics_WindVelocity_Offset = NativeReflectionCached.GetPropertyOffset(SetAerodynamics_FunctionAddress, "WindVelocity");
		SetAerodynamics_WindVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAerodynamics_FunctionAddress, "WindVelocity", Classes.FStructProperty);
		SetAerodynamics_IsValid = SetAerodynamics_FunctionAddress != IntPtr.Zero && SetAerodynamics_DragCoefficient_IsValid && SetAerodynamics_LiftCoefficient_IsValid && SetAerodynamics_WindVelocity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ChaosCloth.ChaosClothingInteractor:SetAerodynamics", SetAerodynamics_IsValid);
		ResetAndTeleport_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ResetAndTeleport");
		ResetAndTeleport_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetAndTeleport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResetAndTeleport_bReset_PropertyAddress, ResetAndTeleport_FunctionAddress, "bReset");
		ResetAndTeleport_bReset_Offset = NativeReflectionCached.GetPropertyOffset(ResetAndTeleport_FunctionAddress, "bReset");
		ResetAndTeleport_bReset_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetAndTeleport_FunctionAddress, "bReset", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ResetAndTeleport_bTeleport_PropertyAddress, ResetAndTeleport_FunctionAddress, "bTeleport");
		ResetAndTeleport_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(ResetAndTeleport_FunctionAddress, "bTeleport");
		ResetAndTeleport_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetAndTeleport_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		ResetAndTeleport_IsValid = ResetAndTeleport_FunctionAddress != IntPtr.Zero && ResetAndTeleport_bReset_IsValid && ResetAndTeleport_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ChaosCloth.ChaosClothingInteractor:ResetAndTeleport", ResetAndTeleport_IsValid);
	}
}
