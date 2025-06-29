using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathTransformInverse", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathTransformInverse
{
	private static bool FRigUnit_MathTransformInverse_IsValid;

	private static int FRigUnit_MathTransformInverse_StructSize;

	public FRigUnit_MathTransformInverse Copy()
	{
		return this;
	}

	public static FRigUnit_MathTransformInverse FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathTransformInverse(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathTransformInverse value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathTransformInverse FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathTransformInverse(nativeBuffer + arrayIndex * FRigUnit_MathTransformInverse_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathTransformInverse value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathTransformInverse_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformInverse_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformInverse");
		}
	}

	public FRigUnit_MathTransformInverse(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformInverse_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformInverse");
		}
	}

	static FRigUnit_MathTransformInverse()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathTransformInverse)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathTransformInverse));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathTransformInverse");
		FRigUnit_MathTransformInverse_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathTransformInverse_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathTransformInverse", FRigUnit_MathTransformInverse_IsValid);
	}
}
