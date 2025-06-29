using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathColorFromFloat", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathColorFromFloat
{
	private static bool FRigUnit_MathColorFromFloat_IsValid;

	private static int FRigUnit_MathColorFromFloat_StructSize;

	public FRigUnit_MathColorFromFloat Copy()
	{
		return this;
	}

	public static FRigUnit_MathColorFromFloat FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathColorFromFloat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathColorFromFloat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathColorFromFloat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathColorFromFloat(nativeBuffer + arrayIndex * FRigUnit_MathColorFromFloat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathColorFromFloat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathColorFromFloat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathColorFromFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathColorFromFloat");
		}
	}

	public FRigUnit_MathColorFromFloat(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathColorFromFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathColorFromFloat");
		}
	}

	static FRigUnit_MathColorFromFloat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathColorFromFloat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathColorFromFloat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathColorFromFloat");
		FRigUnit_MathColorFromFloat_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathColorFromFloat_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathColorFromFloat", FRigUnit_MathColorFromFloat_IsValid);
	}
}
