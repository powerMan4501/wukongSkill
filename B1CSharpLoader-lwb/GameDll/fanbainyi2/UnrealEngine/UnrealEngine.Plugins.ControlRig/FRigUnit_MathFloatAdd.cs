using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatAdd", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatAdd
{
	private static bool FRigUnit_MathFloatAdd_IsValid;

	private static int FRigUnit_MathFloatAdd_StructSize;

	public FRigUnit_MathFloatAdd Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatAdd FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatAdd(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatAdd value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatAdd FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatAdd(nativeBuffer + arrayIndex * FRigUnit_MathFloatAdd_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatAdd value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatAdd_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatAdd_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatAdd");
		}
	}

	public FRigUnit_MathFloatAdd(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatAdd_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatAdd");
		}
	}

	static FRigUnit_MathFloatAdd()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatAdd)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatAdd));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatAdd");
		FRigUnit_MathFloatAdd_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatAdd_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatAdd", FRigUnit_MathFloatAdd_IsValid);
	}
}
