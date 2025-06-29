using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatMin", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatMin
{
	private static bool FRigUnit_MathFloatMin_IsValid;

	private static int FRigUnit_MathFloatMin_StructSize;

	public FRigUnit_MathFloatMin Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatMin FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatMin(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatMin value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatMin FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatMin(nativeBuffer + arrayIndex * FRigUnit_MathFloatMin_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatMin value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatMin_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatMin_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatMin");
		}
	}

	public FRigUnit_MathFloatMin(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatMin_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatMin");
		}
	}

	static FRigUnit_MathFloatMin()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatMin)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatMin));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatMin");
		FRigUnit_MathFloatMin_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatMin_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatMin", FRigUnit_MathFloatMin_IsValid);
	}
}
