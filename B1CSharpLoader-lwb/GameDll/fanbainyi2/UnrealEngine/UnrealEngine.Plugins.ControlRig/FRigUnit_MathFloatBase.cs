using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatBase", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatBase
{
	private static bool FRigUnit_MathFloatBase_IsValid;

	private static int FRigUnit_MathFloatBase_StructSize;

	public FRigUnit_MathFloatBase Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatBase FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatBase(nativeBuffer + arrayIndex * FRigUnit_MathFloatBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatBase");
		}
	}

	public FRigUnit_MathFloatBase(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatBase");
		}
	}

	static FRigUnit_MathFloatBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatBase");
		FRigUnit_MathFloatBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatBase", FRigUnit_MathFloatBase_IsValid);
	}
}
