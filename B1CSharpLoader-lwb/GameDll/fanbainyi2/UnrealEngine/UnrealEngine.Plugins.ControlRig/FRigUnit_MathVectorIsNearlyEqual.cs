using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorIsNearlyEqual", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorIsNearlyEqual
{
	private static bool FRigUnit_MathVectorIsNearlyEqual_IsValid;

	private static int FRigUnit_MathVectorIsNearlyEqual_StructSize;

	public FRigUnit_MathVectorIsNearlyEqual Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorIsNearlyEqual FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorIsNearlyEqual(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorIsNearlyEqual value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorIsNearlyEqual FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorIsNearlyEqual(nativeBuffer + arrayIndex * FRigUnit_MathVectorIsNearlyEqual_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorIsNearlyEqual value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorIsNearlyEqual_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorIsNearlyEqual_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorIsNearlyEqual");
		}
	}

	public FRigUnit_MathVectorIsNearlyEqual(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorIsNearlyEqual_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorIsNearlyEqual");
		}
	}

	static FRigUnit_MathVectorIsNearlyEqual()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorIsNearlyEqual)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorIsNearlyEqual));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorIsNearlyEqual");
		FRigUnit_MathVectorIsNearlyEqual_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorIsNearlyEqual_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorIsNearlyEqual", FRigUnit_MathVectorIsNearlyEqual_IsValid);
	}
}
