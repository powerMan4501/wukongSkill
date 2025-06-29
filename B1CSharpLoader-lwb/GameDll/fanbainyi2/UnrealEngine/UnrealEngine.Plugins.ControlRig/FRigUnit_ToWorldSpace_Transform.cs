using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ToWorldSpace_Transform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ToWorldSpace_Transform
{
	private static bool FRigUnit_ToWorldSpace_Transform_IsValid;

	private static int FRigUnit_ToWorldSpace_Transform_StructSize;

	public FRigUnit_ToWorldSpace_Transform Copy()
	{
		return this;
	}

	public static FRigUnit_ToWorldSpace_Transform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ToWorldSpace_Transform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ToWorldSpace_Transform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ToWorldSpace_Transform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ToWorldSpace_Transform(nativeBuffer + arrayIndex * FRigUnit_ToWorldSpace_Transform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ToWorldSpace_Transform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ToWorldSpace_Transform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ToWorldSpace_Transform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ToWorldSpace_Transform");
		}
	}

	public FRigUnit_ToWorldSpace_Transform(IntPtr nativeStruct)
	{
		if (!FRigUnit_ToWorldSpace_Transform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ToWorldSpace_Transform");
		}
	}

	static FRigUnit_ToWorldSpace_Transform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ToWorldSpace_Transform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ToWorldSpace_Transform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ToWorldSpace_Transform");
		FRigUnit_ToWorldSpace_Transform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ToWorldSpace_Transform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ToWorldSpace_Transform", FRigUnit_ToWorldSpace_Transform_IsValid);
	}
}
