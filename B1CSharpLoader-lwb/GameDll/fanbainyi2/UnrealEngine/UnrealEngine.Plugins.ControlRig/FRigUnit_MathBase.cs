using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathBase", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathBase
{
	private static bool FRigUnit_MathBase_IsValid;

	private static int FRigUnit_MathBase_StructSize;

	public FRigUnit_MathBase Copy()
	{
		return this;
	}

	public static FRigUnit_MathBase FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathBase(nativeBuffer + arrayIndex * FRigUnit_MathBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBase");
		}
	}

	public FRigUnit_MathBase(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBase");
		}
	}

	static FRigUnit_MathBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathBase");
		FRigUnit_MathBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathBase", FRigUnit_MathBase_IsValid);
	}
}
