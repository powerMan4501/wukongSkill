using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ToRigSpace_Rotation", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ToRigSpace_Rotation
{
	private static bool FRigUnit_ToRigSpace_Rotation_IsValid;

	private static int FRigUnit_ToRigSpace_Rotation_StructSize;

	public FRigUnit_ToRigSpace_Rotation Copy()
	{
		return this;
	}

	public static FRigUnit_ToRigSpace_Rotation FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ToRigSpace_Rotation(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ToRigSpace_Rotation value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ToRigSpace_Rotation FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ToRigSpace_Rotation(nativeBuffer + arrayIndex * FRigUnit_ToRigSpace_Rotation_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ToRigSpace_Rotation value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ToRigSpace_Rotation_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ToRigSpace_Rotation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ToRigSpace_Rotation");
		}
	}

	public FRigUnit_ToRigSpace_Rotation(IntPtr nativeStruct)
	{
		if (!FRigUnit_ToRigSpace_Rotation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ToRigSpace_Rotation");
		}
	}

	static FRigUnit_ToRigSpace_Rotation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ToRigSpace_Rotation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ToRigSpace_Rotation));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ToRigSpace_Rotation");
		FRigUnit_ToRigSpace_Rotation_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ToRigSpace_Rotation_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ToRigSpace_Rotation", FRigUnit_ToRigSpace_Rotation_IsValid);
	}
}
