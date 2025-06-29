using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathMatrixFromVectors", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathMatrixFromVectors
{
	private static bool FRigUnit_MathMatrixFromVectors_IsValid;

	private static int FRigUnit_MathMatrixFromVectors_StructSize;

	public FRigUnit_MathMatrixFromVectors Copy()
	{
		return this;
	}

	public static FRigUnit_MathMatrixFromVectors FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathMatrixFromVectors(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathMatrixFromVectors value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathMatrixFromVectors FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathMatrixFromVectors(nativeBuffer + arrayIndex * FRigUnit_MathMatrixFromVectors_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathMatrixFromVectors value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathMatrixFromVectors_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathMatrixFromVectors_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathMatrixFromVectors");
		}
	}

	public FRigUnit_MathMatrixFromVectors(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathMatrixFromVectors_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathMatrixFromVectors");
		}
	}

	static FRigUnit_MathMatrixFromVectors()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathMatrixFromVectors)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathMatrixFromVectors));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathMatrixFromVectors");
		FRigUnit_MathMatrixFromVectors_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathMatrixFromVectors_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathMatrixFromVectors", FRigUnit_MathMatrixFromVectors_IsValid);
	}
}
