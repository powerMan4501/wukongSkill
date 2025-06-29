using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathBoolOr", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathBoolOr
{
	private static bool FRigUnit_MathBoolOr_IsValid;

	private static int FRigUnit_MathBoolOr_StructSize;

	public FRigUnit_MathBoolOr Copy()
	{
		return this;
	}

	public static FRigUnit_MathBoolOr FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathBoolOr(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathBoolOr value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathBoolOr FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathBoolOr(nativeBuffer + arrayIndex * FRigUnit_MathBoolOr_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathBoolOr value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathBoolOr_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolOr_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolOr");
		}
	}

	public FRigUnit_MathBoolOr(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolOr_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolOr");
		}
	}

	static FRigUnit_MathBoolOr()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathBoolOr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathBoolOr));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathBoolOr");
		FRigUnit_MathBoolOr_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathBoolOr_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathBoolOr", FRigUnit_MathBoolOr_IsValid);
	}
}
