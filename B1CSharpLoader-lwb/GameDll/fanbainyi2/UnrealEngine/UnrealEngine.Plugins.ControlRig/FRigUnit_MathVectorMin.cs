using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorMin", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorMin
{
	private static bool FRigUnit_MathVectorMin_IsValid;

	private static int FRigUnit_MathVectorMin_StructSize;

	public FRigUnit_MathVectorMin Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorMin FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorMin(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorMin value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorMin FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorMin(nativeBuffer + arrayIndex * FRigUnit_MathVectorMin_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorMin value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorMin_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorMin_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorMin");
		}
	}

	public FRigUnit_MathVectorMin(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorMin_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorMin");
		}
	}

	static FRigUnit_MathVectorMin()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorMin)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorMin));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorMin");
		FRigUnit_MathVectorMin_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorMin_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorMin", FRigUnit_MathVectorMin_IsValid);
	}
}
