using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatFloor", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatFloor
{
	private static bool FRigUnit_MathFloatFloor_IsValid;

	private static int FRigUnit_MathFloatFloor_StructSize;

	public FRigUnit_MathFloatFloor Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatFloor FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatFloor(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatFloor value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatFloor FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatFloor(nativeBuffer + arrayIndex * FRigUnit_MathFloatFloor_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatFloor value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatFloor_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatFloor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatFloor");
		}
	}

	public FRigUnit_MathFloatFloor(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatFloor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatFloor");
		}
	}

	static FRigUnit_MathFloatFloor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatFloor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatFloor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatFloor");
		FRigUnit_MathFloatFloor_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatFloor_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatFloor", FRigUnit_MathFloatFloor_IsValid);
	}
}
