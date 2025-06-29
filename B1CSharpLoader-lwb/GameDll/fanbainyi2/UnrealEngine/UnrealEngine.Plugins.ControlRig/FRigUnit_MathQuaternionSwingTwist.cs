using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathQuaternionSwingTwist", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathQuaternionSwingTwist
{
	private static bool FRigUnit_MathQuaternionSwingTwist_IsValid;

	private static int FRigUnit_MathQuaternionSwingTwist_StructSize;

	public FRigUnit_MathQuaternionSwingTwist Copy()
	{
		return this;
	}

	public static FRigUnit_MathQuaternionSwingTwist FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathQuaternionSwingTwist(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathQuaternionSwingTwist value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathQuaternionSwingTwist FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathQuaternionSwingTwist(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionSwingTwist_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathQuaternionSwingTwist value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionSwingTwist_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionSwingTwist_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionSwingTwist");
		}
	}

	public FRigUnit_MathQuaternionSwingTwist(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionSwingTwist_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionSwingTwist");
		}
	}

	static FRigUnit_MathQuaternionSwingTwist()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathQuaternionSwingTwist)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathQuaternionSwingTwist));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathQuaternionSwingTwist");
		FRigUnit_MathQuaternionSwingTwist_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathQuaternionSwingTwist_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathQuaternionSwingTwist", FRigUnit_MathQuaternionSwingTwist_IsValid);
	}
}
