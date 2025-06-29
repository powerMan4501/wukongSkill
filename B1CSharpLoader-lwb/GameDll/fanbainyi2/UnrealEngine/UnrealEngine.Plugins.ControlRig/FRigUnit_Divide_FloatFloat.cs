using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_Divide_FloatFloat", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_Divide_FloatFloat
{
	private static bool FRigUnit_Divide_FloatFloat_IsValid;

	private static int FRigUnit_Divide_FloatFloat_StructSize;

	public FRigUnit_Divide_FloatFloat Copy()
	{
		return this;
	}

	public static FRigUnit_Divide_FloatFloat FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_Divide_FloatFloat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_Divide_FloatFloat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_Divide_FloatFloat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_Divide_FloatFloat(nativeBuffer + arrayIndex * FRigUnit_Divide_FloatFloat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_Divide_FloatFloat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_Divide_FloatFloat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_Divide_FloatFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Divide_FloatFloat");
		}
	}

	public FRigUnit_Divide_FloatFloat(IntPtr nativeStruct)
	{
		if (!FRigUnit_Divide_FloatFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Divide_FloatFloat");
		}
	}

	static FRigUnit_Divide_FloatFloat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_Divide_FloatFloat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_Divide_FloatFloat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_Divide_FloatFloat");
		FRigUnit_Divide_FloatFloat_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_Divide_FloatFloat_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_Divide_FloatFloat", FRigUnit_Divide_FloatFloat_IsValid);
	}
}
