using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathQuaternionFromTwoVectors", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathQuaternionFromTwoVectors
{
	private static bool FRigUnit_MathQuaternionFromTwoVectors_IsValid;

	private static int FRigUnit_MathQuaternionFromTwoVectors_StructSize;

	public FRigUnit_MathQuaternionFromTwoVectors Copy()
	{
		return this;
	}

	public static FRigUnit_MathQuaternionFromTwoVectors FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathQuaternionFromTwoVectors(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathQuaternionFromTwoVectors value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathQuaternionFromTwoVectors FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathQuaternionFromTwoVectors(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionFromTwoVectors_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathQuaternionFromTwoVectors value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionFromTwoVectors_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionFromTwoVectors_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionFromTwoVectors");
		}
	}

	public FRigUnit_MathQuaternionFromTwoVectors(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionFromTwoVectors_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionFromTwoVectors");
		}
	}

	static FRigUnit_MathQuaternionFromTwoVectors()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathQuaternionFromTwoVectors)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathQuaternionFromTwoVectors));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathQuaternionFromTwoVectors");
		FRigUnit_MathQuaternionFromTwoVectors_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathQuaternionFromTwoVectors_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathQuaternionFromTwoVectors", FRigUnit_MathQuaternionFromTwoVectors_IsValid);
	}
}
