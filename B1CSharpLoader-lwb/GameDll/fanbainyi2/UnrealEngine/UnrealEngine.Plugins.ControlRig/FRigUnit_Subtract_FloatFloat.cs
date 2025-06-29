using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_Subtract_FloatFloat", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_Subtract_FloatFloat
{
	private static bool FRigUnit_Subtract_FloatFloat_IsValid;

	private static int FRigUnit_Subtract_FloatFloat_StructSize;

	public FRigUnit_Subtract_FloatFloat Copy()
	{
		return this;
	}

	public static FRigUnit_Subtract_FloatFloat FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_Subtract_FloatFloat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_Subtract_FloatFloat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_Subtract_FloatFloat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_Subtract_FloatFloat(nativeBuffer + arrayIndex * FRigUnit_Subtract_FloatFloat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_Subtract_FloatFloat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_Subtract_FloatFloat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_Subtract_FloatFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Subtract_FloatFloat");
		}
	}

	public FRigUnit_Subtract_FloatFloat(IntPtr nativeStruct)
	{
		if (!FRigUnit_Subtract_FloatFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Subtract_FloatFloat");
		}
	}

	static FRigUnit_Subtract_FloatFloat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_Subtract_FloatFloat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_Subtract_FloatFloat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_Subtract_FloatFloat");
		FRigUnit_Subtract_FloatFloat_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_Subtract_FloatFloat_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_Subtract_FloatFloat", FRigUnit_Subtract_FloatFloat_IsValid);
	}
}
