using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatClamp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatClamp
{
	private static bool FRigUnit_MathFloatClamp_IsValid;

	private static int FRigUnit_MathFloatClamp_StructSize;

	public FRigUnit_MathFloatClamp Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatClamp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatClamp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatClamp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatClamp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatClamp(nativeBuffer + arrayIndex * FRigUnit_MathFloatClamp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatClamp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatClamp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatClamp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatClamp");
		}
	}

	public FRigUnit_MathFloatClamp(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatClamp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatClamp");
		}
	}

	static FRigUnit_MathFloatClamp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatClamp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatClamp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatClamp");
		FRigUnit_MathFloatClamp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatClamp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatClamp", FRigUnit_MathFloatClamp_IsValid);
	}
}
