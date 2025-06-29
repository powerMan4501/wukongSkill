using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatConstE", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatConstE
{
	private static bool FRigUnit_MathFloatConstE_IsValid;

	private static int FRigUnit_MathFloatConstE_StructSize;

	public FRigUnit_MathFloatConstE Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatConstE FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatConstE(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatConstE value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatConstE FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatConstE(nativeBuffer + arrayIndex * FRigUnit_MathFloatConstE_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatConstE value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatConstE_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatConstE_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatConstE");
		}
	}

	public FRigUnit_MathFloatConstE(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatConstE_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatConstE");
		}
	}

	static FRigUnit_MathFloatConstE()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatConstE)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatConstE));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatConstE");
		FRigUnit_MathFloatConstE_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatConstE_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatConstE", FRigUnit_MathFloatConstE_IsValid);
	}
}
