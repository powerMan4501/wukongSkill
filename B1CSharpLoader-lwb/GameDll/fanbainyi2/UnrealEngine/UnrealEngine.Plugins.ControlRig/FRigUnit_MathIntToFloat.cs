using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathIntToFloat", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathIntToFloat
{
	private static bool FRigUnit_MathIntToFloat_IsValid;

	private static int FRigUnit_MathIntToFloat_StructSize;

	public FRigUnit_MathIntToFloat Copy()
	{
		return this;
	}

	public static FRigUnit_MathIntToFloat FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathIntToFloat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathIntToFloat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathIntToFloat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathIntToFloat(nativeBuffer + arrayIndex * FRigUnit_MathIntToFloat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathIntToFloat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathIntToFloat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntToFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntToFloat");
		}
	}

	public FRigUnit_MathIntToFloat(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntToFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntToFloat");
		}
	}

	static FRigUnit_MathIntToFloat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathIntToFloat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathIntToFloat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathIntToFloat");
		FRigUnit_MathIntToFloat_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathIntToFloat_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathIntToFloat", FRigUnit_MathIntToFloat_IsValid);
	}
}
