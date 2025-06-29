using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_FitChainToCurve", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_FitChainToCurve
{
	private static bool FRigUnit_FitChainToCurve_IsValid;

	private static int FRigUnit_FitChainToCurve_StructSize;

	public FRigUnit_FitChainToCurve Copy()
	{
		return this;
	}

	public static FRigUnit_FitChainToCurve FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_FitChainToCurve(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_FitChainToCurve value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_FitChainToCurve FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_FitChainToCurve(nativeBuffer + arrayIndex * FRigUnit_FitChainToCurve_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_FitChainToCurve value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_FitChainToCurve_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_FitChainToCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_FitChainToCurve");
		}
	}

	public FRigUnit_FitChainToCurve(IntPtr nativeStruct)
	{
		if (!FRigUnit_FitChainToCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_FitChainToCurve");
		}
	}

	static FRigUnit_FitChainToCurve()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_FitChainToCurve)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_FitChainToCurve));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_FitChainToCurve");
		FRigUnit_FitChainToCurve_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_FitChainToCurve_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_FitChainToCurve", FRigUnit_FitChainToCurve_IsValid);
	}
}
