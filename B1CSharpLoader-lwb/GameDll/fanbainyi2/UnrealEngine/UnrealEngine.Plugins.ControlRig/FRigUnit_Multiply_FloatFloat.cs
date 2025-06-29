using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_Multiply_FloatFloat", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_Multiply_FloatFloat
{
	private static bool FRigUnit_Multiply_FloatFloat_IsValid;

	private static int FRigUnit_Multiply_FloatFloat_StructSize;

	public FRigUnit_Multiply_FloatFloat Copy()
	{
		return this;
	}

	public static FRigUnit_Multiply_FloatFloat FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_Multiply_FloatFloat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_Multiply_FloatFloat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_Multiply_FloatFloat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_Multiply_FloatFloat(nativeBuffer + arrayIndex * FRigUnit_Multiply_FloatFloat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_Multiply_FloatFloat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_Multiply_FloatFloat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_Multiply_FloatFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Multiply_FloatFloat");
		}
	}

	public FRigUnit_Multiply_FloatFloat(IntPtr nativeStruct)
	{
		if (!FRigUnit_Multiply_FloatFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Multiply_FloatFloat");
		}
	}

	static FRigUnit_Multiply_FloatFloat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_Multiply_FloatFloat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_Multiply_FloatFloat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_Multiply_FloatFloat");
		FRigUnit_Multiply_FloatFloat_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_Multiply_FloatFloat_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_Multiply_FloatFloat", FRigUnit_Multiply_FloatFloat_IsValid);
	}
}
