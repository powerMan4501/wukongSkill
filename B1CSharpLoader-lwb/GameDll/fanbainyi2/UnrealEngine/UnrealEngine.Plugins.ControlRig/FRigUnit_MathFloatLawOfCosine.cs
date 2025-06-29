using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatLawOfCosine", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatLawOfCosine
{
	private static bool FRigUnit_MathFloatLawOfCosine_IsValid;

	private static int FRigUnit_MathFloatLawOfCosine_StructSize;

	public FRigUnit_MathFloatLawOfCosine Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatLawOfCosine FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatLawOfCosine(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatLawOfCosine value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatLawOfCosine FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatLawOfCosine(nativeBuffer + arrayIndex * FRigUnit_MathFloatLawOfCosine_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatLawOfCosine value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatLawOfCosine_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatLawOfCosine_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatLawOfCosine");
		}
	}

	public FRigUnit_MathFloatLawOfCosine(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatLawOfCosine_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatLawOfCosine");
		}
	}

	static FRigUnit_MathFloatLawOfCosine()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatLawOfCosine)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatLawOfCosine));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatLawOfCosine");
		FRigUnit_MathFloatLawOfCosine_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatLawOfCosine_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatLawOfCosine", FRigUnit_MathFloatLawOfCosine_IsValid);
	}
}
