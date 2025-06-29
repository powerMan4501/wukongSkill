using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathBoolConstant", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathBoolConstant
{
	private static bool FRigUnit_MathBoolConstant_IsValid;

	private static int FRigUnit_MathBoolConstant_StructSize;

	public FRigUnit_MathBoolConstant Copy()
	{
		return this;
	}

	public static FRigUnit_MathBoolConstant FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathBoolConstant(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathBoolConstant value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathBoolConstant FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathBoolConstant(nativeBuffer + arrayIndex * FRigUnit_MathBoolConstant_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathBoolConstant value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathBoolConstant_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolConstant_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolConstant");
		}
	}

	public FRigUnit_MathBoolConstant(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolConstant_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolConstant");
		}
	}

	static FRigUnit_MathBoolConstant()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathBoolConstant)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathBoolConstant));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathBoolConstant");
		FRigUnit_MathBoolConstant_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathBoolConstant_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathBoolConstant", FRigUnit_MathBoolConstant_IsValid);
	}
}
