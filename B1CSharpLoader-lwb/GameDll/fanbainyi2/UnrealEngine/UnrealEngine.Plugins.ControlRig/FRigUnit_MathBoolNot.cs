using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathBoolNot", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathBoolNot
{
	private static bool FRigUnit_MathBoolNot_IsValid;

	private static int FRigUnit_MathBoolNot_StructSize;

	public FRigUnit_MathBoolNot Copy()
	{
		return this;
	}

	public static FRigUnit_MathBoolNot FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathBoolNot(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathBoolNot value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathBoolNot FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathBoolNot(nativeBuffer + arrayIndex * FRigUnit_MathBoolNot_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathBoolNot value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathBoolNot_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolNot_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolNot");
		}
	}

	public FRigUnit_MathBoolNot(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolNot_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolNot");
		}
	}

	static FRigUnit_MathBoolNot()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathBoolNot)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathBoolNot));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathBoolNot");
		FRigUnit_MathBoolNot_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathBoolNot_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathBoolNot", FRigUnit_MathBoolNot_IsValid);
	}
}
