using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_Subtract_VectorVector", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_Subtract_VectorVector
{
	private static bool FRigUnit_Subtract_VectorVector_IsValid;

	private static int FRigUnit_Subtract_VectorVector_StructSize;

	public FRigUnit_Subtract_VectorVector Copy()
	{
		return this;
	}

	public static FRigUnit_Subtract_VectorVector FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_Subtract_VectorVector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_Subtract_VectorVector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_Subtract_VectorVector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_Subtract_VectorVector(nativeBuffer + arrayIndex * FRigUnit_Subtract_VectorVector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_Subtract_VectorVector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_Subtract_VectorVector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_Subtract_VectorVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Subtract_VectorVector");
		}
	}

	public FRigUnit_Subtract_VectorVector(IntPtr nativeStruct)
	{
		if (!FRigUnit_Subtract_VectorVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Subtract_VectorVector");
		}
	}

	static FRigUnit_Subtract_VectorVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_Subtract_VectorVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_Subtract_VectorVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_Subtract_VectorVector");
		FRigUnit_Subtract_VectorVector_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_Subtract_VectorVector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_Subtract_VectorVector", FRigUnit_Subtract_VectorVector_IsValid);
	}
}
