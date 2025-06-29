using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigSpline;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRigSpline.RigUnit_FitSplineCurveToChain", "ControlRigSpline", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_FitSplineCurveToChain
{
	private static bool FRigUnit_FitSplineCurveToChain_IsValid;

	private static int FRigUnit_FitSplineCurveToChain_StructSize;

	public FRigUnit_FitSplineCurveToChain Copy()
	{
		return this;
	}

	public static FRigUnit_FitSplineCurveToChain FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_FitSplineCurveToChain(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_FitSplineCurveToChain value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_FitSplineCurveToChain FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_FitSplineCurveToChain(nativeBuffer + arrayIndex * FRigUnit_FitSplineCurveToChain_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_FitSplineCurveToChain value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_FitSplineCurveToChain_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_FitSplineCurveToChain_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_FitSplineCurveToChain");
		}
	}

	public FRigUnit_FitSplineCurveToChain(IntPtr nativeStruct)
	{
		if (!FRigUnit_FitSplineCurveToChain_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_FitSplineCurveToChain");
		}
	}

	static FRigUnit_FitSplineCurveToChain()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_FitSplineCurveToChain)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_FitSplineCurveToChain));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRigSpline.RigUnit_FitSplineCurveToChain");
		FRigUnit_FitSplineCurveToChain_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_FitSplineCurveToChain_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRigSpline.RigUnit_FitSplineCurveToChain", FRigUnit_FitSplineCurveToChain_IsValid);
	}
}
