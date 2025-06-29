using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatRad", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatRad
{
	private static bool FRigUnit_MathFloatRad_IsValid;

	private static int FRigUnit_MathFloatRad_StructSize;

	public FRigUnit_MathFloatRad Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatRad FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatRad(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatRad value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatRad FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatRad(nativeBuffer + arrayIndex * FRigUnit_MathFloatRad_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatRad value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatRad_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatRad_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatRad");
		}
	}

	public FRigUnit_MathFloatRad(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatRad_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatRad");
		}
	}

	static FRigUnit_MathFloatRad()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatRad)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatRad));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatRad");
		FRigUnit_MathFloatRad_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatRad_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatRad", FRigUnit_MathFloatRad_IsValid);
	}
}
