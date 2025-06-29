using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigSpline;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRigSpline.RigUnit_FitSplineCurveToChainItemArray", "ControlRigSpline", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_FitSplineCurveToChainItemArray
{
	private static bool FRigUnit_FitSplineCurveToChainItemArray_IsValid;

	private static int FRigUnit_FitSplineCurveToChainItemArray_StructSize;

	public FRigUnit_FitSplineCurveToChainItemArray Copy()
	{
		return this;
	}

	public static FRigUnit_FitSplineCurveToChainItemArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_FitSplineCurveToChainItemArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_FitSplineCurveToChainItemArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_FitSplineCurveToChainItemArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_FitSplineCurveToChainItemArray(nativeBuffer + arrayIndex * FRigUnit_FitSplineCurveToChainItemArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_FitSplineCurveToChainItemArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_FitSplineCurveToChainItemArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_FitSplineCurveToChainItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_FitSplineCurveToChainItemArray");
		}
	}

	public FRigUnit_FitSplineCurveToChainItemArray(IntPtr nativeStruct)
	{
		if (!FRigUnit_FitSplineCurveToChainItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_FitSplineCurveToChainItemArray");
		}
	}

	static FRigUnit_FitSplineCurveToChainItemArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_FitSplineCurveToChainItemArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_FitSplineCurveToChainItemArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRigSpline.RigUnit_FitSplineCurveToChainItemArray");
		FRigUnit_FitSplineCurveToChainItemArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_FitSplineCurveToChainItemArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRigSpline.RigUnit_FitSplineCurveToChainItemArray", FRigUnit_FitSplineCurveToChainItemArray_IsValid);
	}
}
