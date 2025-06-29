using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatExponential", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatExponential
{
	private static bool FRigUnit_MathFloatExponential_IsValid;

	private static int FRigUnit_MathFloatExponential_StructSize;

	public FRigUnit_MathFloatExponential Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatExponential FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatExponential(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatExponential value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatExponential FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatExponential(nativeBuffer + arrayIndex * FRigUnit_MathFloatExponential_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatExponential value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatExponential_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatExponential_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatExponential");
		}
	}

	public FRigUnit_MathFloatExponential(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatExponential_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatExponential");
		}
	}

	static FRigUnit_MathFloatExponential()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatExponential)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatExponential));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatExponential");
		FRigUnit_MathFloatExponential_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatExponential_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatExponential", FRigUnit_MathFloatExponential_IsValid);
	}
}
