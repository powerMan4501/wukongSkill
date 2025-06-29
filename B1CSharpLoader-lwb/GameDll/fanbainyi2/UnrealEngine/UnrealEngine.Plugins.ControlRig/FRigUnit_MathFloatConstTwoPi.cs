using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatConstTwoPi", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatConstTwoPi
{
	private static bool FRigUnit_MathFloatConstTwoPi_IsValid;

	private static int FRigUnit_MathFloatConstTwoPi_StructSize;

	public FRigUnit_MathFloatConstTwoPi Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatConstTwoPi FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatConstTwoPi(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatConstTwoPi value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatConstTwoPi FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatConstTwoPi(nativeBuffer + arrayIndex * FRigUnit_MathFloatConstTwoPi_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatConstTwoPi value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatConstTwoPi_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatConstTwoPi_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatConstTwoPi");
		}
	}

	public FRigUnit_MathFloatConstTwoPi(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatConstTwoPi_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatConstTwoPi");
		}
	}

	static FRigUnit_MathFloatConstTwoPi()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatConstTwoPi)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatConstTwoPi));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatConstTwoPi");
		FRigUnit_MathFloatConstTwoPi_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatConstTwoPi_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatConstTwoPi", FRigUnit_MathFloatConstTwoPi_IsValid);
	}
}
