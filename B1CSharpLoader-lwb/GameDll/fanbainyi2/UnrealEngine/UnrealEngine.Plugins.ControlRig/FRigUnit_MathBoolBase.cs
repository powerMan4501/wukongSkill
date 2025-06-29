using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathBoolBase", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathBoolBase
{
	private static bool FRigUnit_MathBoolBase_IsValid;

	private static int FRigUnit_MathBoolBase_StructSize;

	public FRigUnit_MathBoolBase Copy()
	{
		return this;
	}

	public static FRigUnit_MathBoolBase FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathBoolBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathBoolBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathBoolBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathBoolBase(nativeBuffer + arrayIndex * FRigUnit_MathBoolBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathBoolBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathBoolBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolBase");
		}
	}

	public FRigUnit_MathBoolBase(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolBase");
		}
	}

	static FRigUnit_MathBoolBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathBoolBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathBoolBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathBoolBase");
		FRigUnit_MathBoolBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathBoolBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathBoolBase", FRigUnit_MathBoolBase_IsValid);
	}
}
