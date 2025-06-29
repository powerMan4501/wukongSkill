using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatConstHalfPi", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatConstHalfPi
{
	private static bool FRigUnit_MathFloatConstHalfPi_IsValid;

	private static int FRigUnit_MathFloatConstHalfPi_StructSize;

	public FRigUnit_MathFloatConstHalfPi Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatConstHalfPi FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatConstHalfPi(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatConstHalfPi value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatConstHalfPi FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatConstHalfPi(nativeBuffer + arrayIndex * FRigUnit_MathFloatConstHalfPi_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatConstHalfPi value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatConstHalfPi_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatConstHalfPi_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatConstHalfPi");
		}
	}

	public FRigUnit_MathFloatConstHalfPi(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatConstHalfPi_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatConstHalfPi");
		}
	}

	static FRigUnit_MathFloatConstHalfPi()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatConstHalfPi)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatConstHalfPi));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatConstHalfPi");
		FRigUnit_MathFloatConstHalfPi_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatConstHalfPi_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatConstHalfPi", FRigUnit_MathFloatConstHalfPi_IsValid);
	}
}
