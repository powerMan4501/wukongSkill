using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_Add_VectorVector", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_Add_VectorVector
{
	private static bool FRigUnit_Add_VectorVector_IsValid;

	private static int FRigUnit_Add_VectorVector_StructSize;

	public FRigUnit_Add_VectorVector Copy()
	{
		return this;
	}

	public static FRigUnit_Add_VectorVector FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_Add_VectorVector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_Add_VectorVector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_Add_VectorVector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_Add_VectorVector(nativeBuffer + arrayIndex * FRigUnit_Add_VectorVector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_Add_VectorVector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_Add_VectorVector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_Add_VectorVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Add_VectorVector");
		}
	}

	public FRigUnit_Add_VectorVector(IntPtr nativeStruct)
	{
		if (!FRigUnit_Add_VectorVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Add_VectorVector");
		}
	}

	static FRigUnit_Add_VectorVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_Add_VectorVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_Add_VectorVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_Add_VectorVector");
		FRigUnit_Add_VectorVector_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_Add_VectorVector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_Add_VectorVector", FRigUnit_Add_VectorVector_IsValid);
	}
}
