using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathBoolEquals", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathBoolEquals
{
	private static bool FRigUnit_MathBoolEquals_IsValid;

	private static int FRigUnit_MathBoolEquals_StructSize;

	public FRigUnit_MathBoolEquals Copy()
	{
		return this;
	}

	public static FRigUnit_MathBoolEquals FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathBoolEquals(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathBoolEquals value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathBoolEquals FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathBoolEquals(nativeBuffer + arrayIndex * FRigUnit_MathBoolEquals_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathBoolEquals value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathBoolEquals_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolEquals");
		}
	}

	public FRigUnit_MathBoolEquals(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolEquals");
		}
	}

	static FRigUnit_MathBoolEquals()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathBoolEquals)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathBoolEquals));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathBoolEquals");
		FRigUnit_MathBoolEquals_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathBoolEquals_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathBoolEquals", FRigUnit_MathBoolEquals_IsValid);
	}
}
