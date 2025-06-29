using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathTransformClampSpatially", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathTransformClampSpatially
{
	private static bool FRigUnit_MathTransformClampSpatially_IsValid;

	private static int FRigUnit_MathTransformClampSpatially_StructSize;

	public FRigUnit_MathTransformClampSpatially Copy()
	{
		return this;
	}

	public static FRigUnit_MathTransformClampSpatially FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathTransformClampSpatially(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathTransformClampSpatially value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathTransformClampSpatially FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathTransformClampSpatially(nativeBuffer + arrayIndex * FRigUnit_MathTransformClampSpatially_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathTransformClampSpatially value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathTransformClampSpatially_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformClampSpatially_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformClampSpatially");
		}
	}

	public FRigUnit_MathTransformClampSpatially(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformClampSpatially_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformClampSpatially");
		}
	}

	static FRigUnit_MathTransformClampSpatially()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathTransformClampSpatially)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathTransformClampSpatially));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathTransformClampSpatially");
		FRigUnit_MathTransformClampSpatially_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathTransformClampSpatially_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathTransformClampSpatially", FRigUnit_MathTransformClampSpatially_IsValid);
	}
}
