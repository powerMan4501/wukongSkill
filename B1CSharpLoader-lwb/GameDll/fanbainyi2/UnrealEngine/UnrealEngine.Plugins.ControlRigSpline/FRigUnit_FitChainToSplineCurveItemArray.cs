using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigSpline;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRigSpline.RigUnit_FitChainToSplineCurveItemArray", "ControlRigSpline", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_FitChainToSplineCurveItemArray
{
	private static bool FRigUnit_FitChainToSplineCurveItemArray_IsValid;

	private static int FRigUnit_FitChainToSplineCurveItemArray_StructSize;

	public FRigUnit_FitChainToSplineCurveItemArray Copy()
	{
		return this;
	}

	public static FRigUnit_FitChainToSplineCurveItemArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_FitChainToSplineCurveItemArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_FitChainToSplineCurveItemArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_FitChainToSplineCurveItemArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_FitChainToSplineCurveItemArray(nativeBuffer + arrayIndex * FRigUnit_FitChainToSplineCurveItemArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_FitChainToSplineCurveItemArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_FitChainToSplineCurveItemArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_FitChainToSplineCurveItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_FitChainToSplineCurveItemArray");
		}
	}

	public FRigUnit_FitChainToSplineCurveItemArray(IntPtr nativeStruct)
	{
		if (!FRigUnit_FitChainToSplineCurveItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_FitChainToSplineCurveItemArray");
		}
	}

	static FRigUnit_FitChainToSplineCurveItemArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_FitChainToSplineCurveItemArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_FitChainToSplineCurveItemArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRigSpline.RigUnit_FitChainToSplineCurveItemArray");
		FRigUnit_FitChainToSplineCurveItemArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_FitChainToSplineCurveItemArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRigSpline.RigUnit_FitChainToSplineCurveItemArray", FRigUnit_FitChainToSplineCurveItemArray_IsValid);
	}
}
