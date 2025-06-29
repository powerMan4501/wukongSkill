using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathIntBase", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathIntBase
{
	private static bool FRigUnit_MathIntBase_IsValid;

	private static int FRigUnit_MathIntBase_StructSize;

	public FRigUnit_MathIntBase Copy()
	{
		return this;
	}

	public static FRigUnit_MathIntBase FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathIntBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathIntBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathIntBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathIntBase(nativeBuffer + arrayIndex * FRigUnit_MathIntBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathIntBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathIntBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntBase");
		}
	}

	public FRigUnit_MathIntBase(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntBase");
		}
	}

	static FRigUnit_MathIntBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathIntBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathIntBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathIntBase");
		FRigUnit_MathIntBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathIntBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathIntBase", FRigUnit_MathIntBase_IsValid);
	}
}
