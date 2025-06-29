using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_Divide_VectorVector", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_Divide_VectorVector
{
	private static bool FRigUnit_Divide_VectorVector_IsValid;

	private static int FRigUnit_Divide_VectorVector_StructSize;

	public FRigUnit_Divide_VectorVector Copy()
	{
		return this;
	}

	public static FRigUnit_Divide_VectorVector FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_Divide_VectorVector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_Divide_VectorVector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_Divide_VectorVector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_Divide_VectorVector(nativeBuffer + arrayIndex * FRigUnit_Divide_VectorVector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_Divide_VectorVector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_Divide_VectorVector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_Divide_VectorVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Divide_VectorVector");
		}
	}

	public FRigUnit_Divide_VectorVector(IntPtr nativeStruct)
	{
		if (!FRigUnit_Divide_VectorVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Divide_VectorVector");
		}
	}

	static FRigUnit_Divide_VectorVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_Divide_VectorVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_Divide_VectorVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_Divide_VectorVector");
		FRigUnit_Divide_VectorVector_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_Divide_VectorVector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_Divide_VectorVector", FRigUnit_Divide_VectorVector_IsValid);
	}
}
