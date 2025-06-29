using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatEquals", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatEquals
{
	private static bool FRigUnit_MathFloatEquals_IsValid;

	private static int FRigUnit_MathFloatEquals_StructSize;

	public FRigUnit_MathFloatEquals Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatEquals FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatEquals(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatEquals value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatEquals FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatEquals(nativeBuffer + arrayIndex * FRigUnit_MathFloatEquals_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatEquals value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatEquals_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatEquals");
		}
	}

	public FRigUnit_MathFloatEquals(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatEquals");
		}
	}

	static FRigUnit_MathFloatEquals()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatEquals)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatEquals));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatEquals");
		FRigUnit_MathFloatEquals_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatEquals_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatEquals", FRigUnit_MathFloatEquals_IsValid);
	}
}
