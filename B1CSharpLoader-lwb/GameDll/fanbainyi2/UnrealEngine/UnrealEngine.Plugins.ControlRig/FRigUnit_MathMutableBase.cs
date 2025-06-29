using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathMutableBase", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathMutableBase
{
	private static bool FRigUnit_MathMutableBase_IsValid;

	private static int FRigUnit_MathMutableBase_StructSize;

	public FRigUnit_MathMutableBase Copy()
	{
		return this;
	}

	public static FRigUnit_MathMutableBase FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathMutableBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathMutableBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathMutableBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathMutableBase(nativeBuffer + arrayIndex * FRigUnit_MathMutableBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathMutableBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathMutableBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathMutableBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathMutableBase");
		}
	}

	public FRigUnit_MathMutableBase(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathMutableBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathMutableBase");
		}
	}

	static FRigUnit_MathMutableBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathMutableBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathMutableBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathMutableBase");
		FRigUnit_MathMutableBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathMutableBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathMutableBase", FRigUnit_MathMutableBase_IsValid);
	}
}
