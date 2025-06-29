using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathTransformSelectBool", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathTransformSelectBool
{
	private static bool FRigUnit_MathTransformSelectBool_IsValid;

	private static int FRigUnit_MathTransformSelectBool_StructSize;

	public FRigUnit_MathTransformSelectBool Copy()
	{
		return this;
	}

	public static FRigUnit_MathTransformSelectBool FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathTransformSelectBool(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathTransformSelectBool value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathTransformSelectBool FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathTransformSelectBool(nativeBuffer + arrayIndex * FRigUnit_MathTransformSelectBool_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathTransformSelectBool value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathTransformSelectBool_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformSelectBool_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformSelectBool");
		}
	}

	public FRigUnit_MathTransformSelectBool(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformSelectBool_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformSelectBool");
		}
	}

	static FRigUnit_MathTransformSelectBool()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathTransformSelectBool)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathTransformSelectBool));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathTransformSelectBool");
		FRigUnit_MathTransformSelectBool_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathTransformSelectBool_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathTransformSelectBool", FRigUnit_MathTransformSelectBool_IsValid);
	}
}
