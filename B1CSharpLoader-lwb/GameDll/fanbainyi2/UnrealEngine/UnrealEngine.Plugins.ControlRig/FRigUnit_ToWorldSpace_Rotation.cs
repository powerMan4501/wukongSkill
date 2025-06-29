using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ToWorldSpace_Rotation", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ToWorldSpace_Rotation
{
	private static bool FRigUnit_ToWorldSpace_Rotation_IsValid;

	private static int FRigUnit_ToWorldSpace_Rotation_StructSize;

	public FRigUnit_ToWorldSpace_Rotation Copy()
	{
		return this;
	}

	public static FRigUnit_ToWorldSpace_Rotation FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ToWorldSpace_Rotation(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ToWorldSpace_Rotation value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ToWorldSpace_Rotation FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ToWorldSpace_Rotation(nativeBuffer + arrayIndex * FRigUnit_ToWorldSpace_Rotation_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ToWorldSpace_Rotation value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ToWorldSpace_Rotation_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ToWorldSpace_Rotation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ToWorldSpace_Rotation");
		}
	}

	public FRigUnit_ToWorldSpace_Rotation(IntPtr nativeStruct)
	{
		if (!FRigUnit_ToWorldSpace_Rotation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ToWorldSpace_Rotation");
		}
	}

	static FRigUnit_ToWorldSpace_Rotation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ToWorldSpace_Rotation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ToWorldSpace_Rotation));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ToWorldSpace_Rotation");
		FRigUnit_ToWorldSpace_Rotation_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ToWorldSpace_Rotation_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ToWorldSpace_Rotation", FRigUnit_ToWorldSpace_Rotation_IsValid);
	}
}
