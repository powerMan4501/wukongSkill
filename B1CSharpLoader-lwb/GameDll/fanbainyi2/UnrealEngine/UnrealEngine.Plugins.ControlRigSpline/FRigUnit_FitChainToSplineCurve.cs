using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigSpline;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRigSpline.RigUnit_FitChainToSplineCurve", "ControlRigSpline", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_FitChainToSplineCurve
{
	private static bool FRigUnit_FitChainToSplineCurve_IsValid;

	private static int FRigUnit_FitChainToSplineCurve_StructSize;

	public FRigUnit_FitChainToSplineCurve Copy()
	{
		return this;
	}

	public static FRigUnit_FitChainToSplineCurve FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_FitChainToSplineCurve(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_FitChainToSplineCurve value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_FitChainToSplineCurve FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_FitChainToSplineCurve(nativeBuffer + arrayIndex * FRigUnit_FitChainToSplineCurve_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_FitChainToSplineCurve value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_FitChainToSplineCurve_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_FitChainToSplineCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_FitChainToSplineCurve");
		}
	}

	public FRigUnit_FitChainToSplineCurve(IntPtr nativeStruct)
	{
		if (!FRigUnit_FitChainToSplineCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_FitChainToSplineCurve");
		}
	}

	static FRigUnit_FitChainToSplineCurve()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_FitChainToSplineCurve)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_FitChainToSplineCurve));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRigSpline.RigUnit_FitChainToSplineCurve");
		FRigUnit_FitChainToSplineCurve_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_FitChainToSplineCurve_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRigSpline.RigUnit_FitChainToSplineCurve", FRigUnit_FitChainToSplineCurve_IsValid);
	}
}
