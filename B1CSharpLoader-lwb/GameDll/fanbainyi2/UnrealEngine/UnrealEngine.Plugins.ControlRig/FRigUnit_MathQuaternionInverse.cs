using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathQuaternionInverse", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathQuaternionInverse
{
	private static bool FRigUnit_MathQuaternionInverse_IsValid;

	private static int FRigUnit_MathQuaternionInverse_StructSize;

	public FRigUnit_MathQuaternionInverse Copy()
	{
		return this;
	}

	public static FRigUnit_MathQuaternionInverse FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathQuaternionInverse(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathQuaternionInverse value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathQuaternionInverse FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathQuaternionInverse(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionInverse_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathQuaternionInverse value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionInverse_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionInverse_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionInverse");
		}
	}

	public FRigUnit_MathQuaternionInverse(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionInverse_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionInverse");
		}
	}

	static FRigUnit_MathQuaternionInverse()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathQuaternionInverse)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathQuaternionInverse));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathQuaternionInverse");
		FRigUnit_MathQuaternionInverse_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathQuaternionInverse_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathQuaternionInverse", FRigUnit_MathQuaternionInverse_IsValid);
	}
}
