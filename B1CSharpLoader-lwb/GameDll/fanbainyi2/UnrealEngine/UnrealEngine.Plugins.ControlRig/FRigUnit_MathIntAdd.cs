using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathIntAdd", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathIntAdd
{
	private static bool FRigUnit_MathIntAdd_IsValid;

	private static int FRigUnit_MathIntAdd_StructSize;

	public FRigUnit_MathIntAdd Copy()
	{
		return this;
	}

	public static FRigUnit_MathIntAdd FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathIntAdd(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathIntAdd value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathIntAdd FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathIntAdd(nativeBuffer + arrayIndex * FRigUnit_MathIntAdd_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathIntAdd value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathIntAdd_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntAdd_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntAdd");
		}
	}

	public FRigUnit_MathIntAdd(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntAdd_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntAdd");
		}
	}

	static FRigUnit_MathIntAdd()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathIntAdd)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathIntAdd));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathIntAdd");
		FRigUnit_MathIntAdd_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathIntAdd_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathIntAdd", FRigUnit_MathIntAdd_IsValid);
	}
}
