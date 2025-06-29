using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatConstant", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatConstant
{
	private static bool FRigUnit_MathFloatConstant_IsValid;

	private static int FRigUnit_MathFloatConstant_StructSize;

	public FRigUnit_MathFloatConstant Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatConstant FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatConstant(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatConstant value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatConstant FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatConstant(nativeBuffer + arrayIndex * FRigUnit_MathFloatConstant_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatConstant value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatConstant_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatConstant_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatConstant");
		}
	}

	public FRigUnit_MathFloatConstant(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatConstant_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatConstant");
		}
	}

	static FRigUnit_MathFloatConstant()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatConstant)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatConstant));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatConstant");
		FRigUnit_MathFloatConstant_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatConstant_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatConstant", FRigUnit_MathFloatConstant_IsValid);
	}
}
