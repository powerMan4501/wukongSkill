using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorFloor", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorFloor
{
	private static bool FRigUnit_MathVectorFloor_IsValid;

	private static int FRigUnit_MathVectorFloor_StructSize;

	public FRigUnit_MathVectorFloor Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorFloor FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorFloor(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorFloor value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorFloor FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorFloor(nativeBuffer + arrayIndex * FRigUnit_MathVectorFloor_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorFloor value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorFloor_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorFloor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorFloor");
		}
	}

	public FRigUnit_MathVectorFloor(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorFloor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorFloor");
		}
	}

	static FRigUnit_MathVectorFloor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorFloor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorFloor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorFloor");
		FRigUnit_MathVectorFloor_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorFloor_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorFloor", FRigUnit_MathVectorFloor_IsValid);
	}
}
