using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ToRigSpace_Transform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ToRigSpace_Transform
{
	private static bool FRigUnit_ToRigSpace_Transform_IsValid;

	private static int FRigUnit_ToRigSpace_Transform_StructSize;

	public FRigUnit_ToRigSpace_Transform Copy()
	{
		return this;
	}

	public static FRigUnit_ToRigSpace_Transform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ToRigSpace_Transform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ToRigSpace_Transform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ToRigSpace_Transform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ToRigSpace_Transform(nativeBuffer + arrayIndex * FRigUnit_ToRigSpace_Transform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ToRigSpace_Transform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ToRigSpace_Transform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ToRigSpace_Transform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ToRigSpace_Transform");
		}
	}

	public FRigUnit_ToRigSpace_Transform(IntPtr nativeStruct)
	{
		if (!FRigUnit_ToRigSpace_Transform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ToRigSpace_Transform");
		}
	}

	static FRigUnit_ToRigSpace_Transform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ToRigSpace_Transform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ToRigSpace_Transform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ToRigSpace_Transform");
		FRigUnit_ToRigSpace_Transform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ToRigSpace_Transform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ToRigSpace_Transform", FRigUnit_ToRigSpace_Transform_IsValid);
	}
}
