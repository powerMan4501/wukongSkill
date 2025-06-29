using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathBoolNotEquals", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathBoolNotEquals
{
	private static bool FRigUnit_MathBoolNotEquals_IsValid;

	private static int FRigUnit_MathBoolNotEquals_StructSize;

	public FRigUnit_MathBoolNotEquals Copy()
	{
		return this;
	}

	public static FRigUnit_MathBoolNotEquals FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathBoolNotEquals(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathBoolNotEquals value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathBoolNotEquals FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathBoolNotEquals(nativeBuffer + arrayIndex * FRigUnit_MathBoolNotEquals_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathBoolNotEquals value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathBoolNotEquals_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolNotEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolNotEquals");
		}
	}

	public FRigUnit_MathBoolNotEquals(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolNotEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolNotEquals");
		}
	}

	static FRigUnit_MathBoolNotEquals()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathBoolNotEquals)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathBoolNotEquals));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathBoolNotEquals");
		FRigUnit_MathBoolNotEquals_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathBoolNotEquals_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathBoolNotEquals", FRigUnit_MathBoolNotEquals_IsValid);
	}
}
