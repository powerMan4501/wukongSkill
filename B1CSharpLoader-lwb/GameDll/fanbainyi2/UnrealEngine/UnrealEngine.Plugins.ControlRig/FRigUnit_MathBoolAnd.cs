using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathBoolAnd", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathBoolAnd
{
	private static bool FRigUnit_MathBoolAnd_IsValid;

	private static int FRigUnit_MathBoolAnd_StructSize;

	public FRigUnit_MathBoolAnd Copy()
	{
		return this;
	}

	public static FRigUnit_MathBoolAnd FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathBoolAnd(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathBoolAnd value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathBoolAnd FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathBoolAnd(nativeBuffer + arrayIndex * FRigUnit_MathBoolAnd_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathBoolAnd value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathBoolAnd_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolAnd_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolAnd");
		}
	}

	public FRigUnit_MathBoolAnd(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolAnd_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolAnd");
		}
	}

	static FRigUnit_MathBoolAnd()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathBoolAnd)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathBoolAnd));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathBoolAnd");
		FRigUnit_MathBoolAnd_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathBoolAnd_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathBoolAnd", FRigUnit_MathBoolAnd_IsValid);
	}
}
