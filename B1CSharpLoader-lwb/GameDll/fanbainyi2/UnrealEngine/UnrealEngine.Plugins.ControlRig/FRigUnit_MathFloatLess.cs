using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatLess", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatLess
{
	private static bool FRigUnit_MathFloatLess_IsValid;

	private static int FRigUnit_MathFloatLess_StructSize;

	public FRigUnit_MathFloatLess Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatLess FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatLess(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatLess value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatLess FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatLess(nativeBuffer + arrayIndex * FRigUnit_MathFloatLess_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatLess value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatLess_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatLess_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatLess");
		}
	}

	public FRigUnit_MathFloatLess(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatLess_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatLess");
		}
	}

	static FRigUnit_MathFloatLess()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatLess)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatLess));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatLess");
		FRigUnit_MathFloatLess_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatLess_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatLess", FRigUnit_MathFloatLess_IsValid);
	}
}
