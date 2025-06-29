using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatNegate", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatNegate
{
	private static bool FRigUnit_MathFloatNegate_IsValid;

	private static int FRigUnit_MathFloatNegate_StructSize;

	public FRigUnit_MathFloatNegate Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatNegate FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatNegate(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatNegate value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatNegate FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatNegate(nativeBuffer + arrayIndex * FRigUnit_MathFloatNegate_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatNegate value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatNegate_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatNegate_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatNegate");
		}
	}

	public FRigUnit_MathFloatNegate(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatNegate_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatNegate");
		}
	}

	static FRigUnit_MathFloatNegate()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatNegate)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatNegate));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatNegate");
		FRigUnit_MathFloatNegate_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatNegate_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatNegate", FRigUnit_MathFloatNegate_IsValid);
	}
}
