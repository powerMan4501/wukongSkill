using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathIntAbs", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathIntAbs
{
	private static bool FRigUnit_MathIntAbs_IsValid;

	private static int FRigUnit_MathIntAbs_StructSize;

	public FRigUnit_MathIntAbs Copy()
	{
		return this;
	}

	public static FRigUnit_MathIntAbs FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathIntAbs(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathIntAbs value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathIntAbs FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathIntAbs(nativeBuffer + arrayIndex * FRigUnit_MathIntAbs_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathIntAbs value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathIntAbs_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntAbs_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntAbs");
		}
	}

	public FRigUnit_MathIntAbs(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntAbs_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntAbs");
		}
	}

	static FRigUnit_MathIntAbs()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathIntAbs)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathIntAbs));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathIntAbs");
		FRigUnit_MathIntAbs_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathIntAbs_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathIntAbs", FRigUnit_MathIntAbs_IsValid);
	}
}
