using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathBoolConstFalse", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathBoolConstFalse
{
	private static bool FRigUnit_MathBoolConstFalse_IsValid;

	private static int FRigUnit_MathBoolConstFalse_StructSize;

	public FRigUnit_MathBoolConstFalse Copy()
	{
		return this;
	}

	public static FRigUnit_MathBoolConstFalse FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathBoolConstFalse(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathBoolConstFalse value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathBoolConstFalse FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathBoolConstFalse(nativeBuffer + arrayIndex * FRigUnit_MathBoolConstFalse_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathBoolConstFalse value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathBoolConstFalse_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolConstFalse_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolConstFalse");
		}
	}

	public FRigUnit_MathBoolConstFalse(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolConstFalse_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolConstFalse");
		}
	}

	static FRigUnit_MathBoolConstFalse()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathBoolConstFalse)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathBoolConstFalse));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathBoolConstFalse");
		FRigUnit_MathBoolConstFalse_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathBoolConstFalse_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathBoolConstFalse", FRigUnit_MathBoolConstFalse_IsValid);
	}
}
