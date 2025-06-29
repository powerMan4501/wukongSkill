using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_FitChainToCurveItemArray", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_FitChainToCurveItemArray
{
	private static bool FRigUnit_FitChainToCurveItemArray_IsValid;

	private static int FRigUnit_FitChainToCurveItemArray_StructSize;

	public FRigUnit_FitChainToCurveItemArray Copy()
	{
		return this;
	}

	public static FRigUnit_FitChainToCurveItemArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_FitChainToCurveItemArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_FitChainToCurveItemArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_FitChainToCurveItemArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_FitChainToCurveItemArray(nativeBuffer + arrayIndex * FRigUnit_FitChainToCurveItemArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_FitChainToCurveItemArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_FitChainToCurveItemArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_FitChainToCurveItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_FitChainToCurveItemArray");
		}
	}

	public FRigUnit_FitChainToCurveItemArray(IntPtr nativeStruct)
	{
		if (!FRigUnit_FitChainToCurveItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_FitChainToCurveItemArray");
		}
	}

	static FRigUnit_FitChainToCurveItemArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_FitChainToCurveItemArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_FitChainToCurveItemArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_FitChainToCurveItemArray");
		FRigUnit_FitChainToCurveItemArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_FitChainToCurveItemArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_FitChainToCurveItemArray", FRigUnit_FitChainToCurveItemArray_IsValid);
	}
}
