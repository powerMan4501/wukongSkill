using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathIntNotEquals", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathIntNotEquals
{
	private static bool FRigUnit_MathIntNotEquals_IsValid;

	private static int FRigUnit_MathIntNotEquals_StructSize;

	public FRigUnit_MathIntNotEquals Copy()
	{
		return this;
	}

	public static FRigUnit_MathIntNotEquals FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathIntNotEquals(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathIntNotEquals value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathIntNotEquals FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathIntNotEquals(nativeBuffer + arrayIndex * FRigUnit_MathIntNotEquals_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathIntNotEquals value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathIntNotEquals_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntNotEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntNotEquals");
		}
	}

	public FRigUnit_MathIntNotEquals(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntNotEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntNotEquals");
		}
	}

	static FRigUnit_MathIntNotEquals()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathIntNotEquals)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathIntNotEquals));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathIntNotEquals");
		FRigUnit_MathIntNotEquals_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathIntNotEquals_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathIntNotEquals", FRigUnit_MathIntNotEquals_IsValid);
	}
}
