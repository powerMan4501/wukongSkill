using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatRemap", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatRemap
{
	private static bool FRigUnit_MathFloatRemap_IsValid;

	private static int FRigUnit_MathFloatRemap_StructSize;

	public FRigUnit_MathFloatRemap Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatRemap FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatRemap(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatRemap value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatRemap FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatRemap(nativeBuffer + arrayIndex * FRigUnit_MathFloatRemap_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatRemap value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatRemap_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatRemap_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatRemap");
		}
	}

	public FRigUnit_MathFloatRemap(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatRemap_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatRemap");
		}
	}

	static FRigUnit_MathFloatRemap()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatRemap)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatRemap));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatRemap");
		FRigUnit_MathFloatRemap_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatRemap_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatRemap", FRigUnit_MathFloatRemap_IsValid);
	}
}
