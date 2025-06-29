using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathMatrixToVectors", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathMatrixToVectors
{
	private static bool FRigUnit_MathMatrixToVectors_IsValid;

	private static int FRigUnit_MathMatrixToVectors_StructSize;

	public FRigUnit_MathMatrixToVectors Copy()
	{
		return this;
	}

	public static FRigUnit_MathMatrixToVectors FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathMatrixToVectors(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathMatrixToVectors value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathMatrixToVectors FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathMatrixToVectors(nativeBuffer + arrayIndex * FRigUnit_MathMatrixToVectors_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathMatrixToVectors value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathMatrixToVectors_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathMatrixToVectors_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathMatrixToVectors");
		}
	}

	public FRigUnit_MathMatrixToVectors(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathMatrixToVectors_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathMatrixToVectors");
		}
	}

	static FRigUnit_MathMatrixToVectors()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathMatrixToVectors)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathMatrixToVectors));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathMatrixToVectors");
		FRigUnit_MathMatrixToVectors_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathMatrixToVectors_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathMatrixToVectors", FRigUnit_MathMatrixToVectors_IsValid);
	}
}
