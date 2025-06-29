using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathColorBase", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathColorBase
{
	private static bool FRigUnit_MathColorBase_IsValid;

	private static int FRigUnit_MathColorBase_StructSize;

	public FRigUnit_MathColorBase Copy()
	{
		return this;
	}

	public static FRigUnit_MathColorBase FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathColorBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathColorBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathColorBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathColorBase(nativeBuffer + arrayIndex * FRigUnit_MathColorBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathColorBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathColorBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathColorBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathColorBase");
		}
	}

	public FRigUnit_MathColorBase(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathColorBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathColorBase");
		}
	}

	static FRigUnit_MathColorBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathColorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathColorBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathColorBase");
		FRigUnit_MathColorBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathColorBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathColorBase", FRigUnit_MathColorBase_IsValid);
	}
}
