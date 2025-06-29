using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathIntMax", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathIntMax
{
	private static bool FRigUnit_MathIntMax_IsValid;

	private static int FRigUnit_MathIntMax_StructSize;

	public FRigUnit_MathIntMax Copy()
	{
		return this;
	}

	public static FRigUnit_MathIntMax FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathIntMax(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathIntMax value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathIntMax FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathIntMax(nativeBuffer + arrayIndex * FRigUnit_MathIntMax_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathIntMax value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathIntMax_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntMax_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntMax");
		}
	}

	public FRigUnit_MathIntMax(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntMax_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntMax");
		}
	}

	static FRigUnit_MathIntMax()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathIntMax)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathIntMax));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathIntMax");
		FRigUnit_MathIntMax_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathIntMax_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathIntMax", FRigUnit_MathIntMax_IsValid);
	}
}
