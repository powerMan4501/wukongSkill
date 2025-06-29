using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathIntSign", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathIntSign
{
	private static bool FRigUnit_MathIntSign_IsValid;

	private static int FRigUnit_MathIntSign_StructSize;

	public FRigUnit_MathIntSign Copy()
	{
		return this;
	}

	public static FRigUnit_MathIntSign FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathIntSign(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathIntSign value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathIntSign FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathIntSign(nativeBuffer + arrayIndex * FRigUnit_MathIntSign_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathIntSign value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathIntSign_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntSign_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntSign");
		}
	}

	public FRigUnit_MathIntSign(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntSign_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntSign");
		}
	}

	static FRigUnit_MathIntSign()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathIntSign)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathIntSign));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathIntSign");
		FRigUnit_MathIntSign_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathIntSign_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathIntSign", FRigUnit_MathIntSign_IsValid);
	}
}
