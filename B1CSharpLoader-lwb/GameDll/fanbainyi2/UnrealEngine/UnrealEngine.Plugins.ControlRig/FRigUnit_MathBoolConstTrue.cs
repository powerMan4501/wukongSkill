using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathBoolConstTrue", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathBoolConstTrue
{
	private static bool FRigUnit_MathBoolConstTrue_IsValid;

	private static int FRigUnit_MathBoolConstTrue_StructSize;

	public FRigUnit_MathBoolConstTrue Copy()
	{
		return this;
	}

	public static FRigUnit_MathBoolConstTrue FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathBoolConstTrue(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathBoolConstTrue value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathBoolConstTrue FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathBoolConstTrue(nativeBuffer + arrayIndex * FRigUnit_MathBoolConstTrue_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathBoolConstTrue value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathBoolConstTrue_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolConstTrue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolConstTrue");
		}
	}

	public FRigUnit_MathBoolConstTrue(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolConstTrue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolConstTrue");
		}
	}

	static FRigUnit_MathBoolConstTrue()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathBoolConstTrue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathBoolConstTrue));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathBoolConstTrue");
		FRigUnit_MathBoolConstTrue_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathBoolConstTrue_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathBoolConstTrue", FRigUnit_MathBoolConstTrue_IsValid);
	}
}
