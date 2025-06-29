using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorIsNearlyZero", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorIsNearlyZero
{
	private static bool FRigUnit_MathVectorIsNearlyZero_IsValid;

	private static int FRigUnit_MathVectorIsNearlyZero_StructSize;

	public FRigUnit_MathVectorIsNearlyZero Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorIsNearlyZero FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorIsNearlyZero(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorIsNearlyZero value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorIsNearlyZero FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorIsNearlyZero(nativeBuffer + arrayIndex * FRigUnit_MathVectorIsNearlyZero_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorIsNearlyZero value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorIsNearlyZero_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorIsNearlyZero_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorIsNearlyZero");
		}
	}

	public FRigUnit_MathVectorIsNearlyZero(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorIsNearlyZero_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorIsNearlyZero");
		}
	}

	static FRigUnit_MathVectorIsNearlyZero()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorIsNearlyZero)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorIsNearlyZero));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorIsNearlyZero");
		FRigUnit_MathVectorIsNearlyZero_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorIsNearlyZero_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorIsNearlyZero", FRigUnit_MathVectorIsNearlyZero_IsValid);
	}
}
