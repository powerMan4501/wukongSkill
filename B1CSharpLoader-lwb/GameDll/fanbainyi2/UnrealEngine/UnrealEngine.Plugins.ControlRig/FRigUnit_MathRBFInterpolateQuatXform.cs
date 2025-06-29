using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatXform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathRBFInterpolateQuatXform
{
	private static bool FRigUnit_MathRBFInterpolateQuatXform_IsValid;

	private static int FRigUnit_MathRBFInterpolateQuatXform_StructSize;

	public FRigUnit_MathRBFInterpolateQuatXform Copy()
	{
		return this;
	}

	public static FRigUnit_MathRBFInterpolateQuatXform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathRBFInterpolateQuatXform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathRBFInterpolateQuatXform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathRBFInterpolateQuatXform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathRBFInterpolateQuatXform(nativeBuffer + arrayIndex * FRigUnit_MathRBFInterpolateQuatXform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathRBFInterpolateQuatXform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathRBFInterpolateQuatXform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathRBFInterpolateQuatXform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatXform");
		}
	}

	public FRigUnit_MathRBFInterpolateQuatXform(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathRBFInterpolateQuatXform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatXform");
		}
	}

	static FRigUnit_MathRBFInterpolateQuatXform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathRBFInterpolateQuatXform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathRBFInterpolateQuatXform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatXform");
		FRigUnit_MathRBFInterpolateQuatXform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathRBFInterpolateQuatXform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatXform", FRigUnit_MathRBFInterpolateQuatXform_IsValid);
	}
}
