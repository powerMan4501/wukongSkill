using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatLessEqual", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatLessEqual
{
	private static bool FRigUnit_MathFloatLessEqual_IsValid;

	private static int FRigUnit_MathFloatLessEqual_StructSize;

	public FRigUnit_MathFloatLessEqual Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatLessEqual FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatLessEqual(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatLessEqual value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatLessEqual FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatLessEqual(nativeBuffer + arrayIndex * FRigUnit_MathFloatLessEqual_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatLessEqual value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatLessEqual_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatLessEqual_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatLessEqual");
		}
	}

	public FRigUnit_MathFloatLessEqual(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatLessEqual_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatLessEqual");
		}
	}

	static FRigUnit_MathFloatLessEqual()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatLessEqual)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatLessEqual));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatLessEqual");
		FRigUnit_MathFloatLessEqual_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatLessEqual_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatLessEqual", FRigUnit_MathFloatLessEqual_IsValid);
	}
}
