using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_Distance_VectorVector", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_Distance_VectorVector
{
	private static bool FRigUnit_Distance_VectorVector_IsValid;

	private static int FRigUnit_Distance_VectorVector_StructSize;

	public FRigUnit_Distance_VectorVector Copy()
	{
		return this;
	}

	public static FRigUnit_Distance_VectorVector FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_Distance_VectorVector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_Distance_VectorVector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_Distance_VectorVector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_Distance_VectorVector(nativeBuffer + arrayIndex * FRigUnit_Distance_VectorVector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_Distance_VectorVector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_Distance_VectorVector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_Distance_VectorVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Distance_VectorVector");
		}
	}

	public FRigUnit_Distance_VectorVector(IntPtr nativeStruct)
	{
		if (!FRigUnit_Distance_VectorVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Distance_VectorVector");
		}
	}

	static FRigUnit_Distance_VectorVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_Distance_VectorVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_Distance_VectorVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_Distance_VectorVector");
		FRigUnit_Distance_VectorVector_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_Distance_VectorVector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_Distance_VectorVector", FRigUnit_Distance_VectorVector_IsValid);
	}
}
