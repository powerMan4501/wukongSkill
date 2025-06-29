using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_NoiseFloat", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_NoiseFloat
{
	private static bool FRigUnit_NoiseFloat_IsValid;

	private static int FRigUnit_NoiseFloat_StructSize;

	public FRigUnit_NoiseFloat Copy()
	{
		return this;
	}

	public static FRigUnit_NoiseFloat FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_NoiseFloat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_NoiseFloat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_NoiseFloat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_NoiseFloat(nativeBuffer + arrayIndex * FRigUnit_NoiseFloat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_NoiseFloat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_NoiseFloat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_NoiseFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_NoiseFloat");
		}
	}

	public FRigUnit_NoiseFloat(IntPtr nativeStruct)
	{
		if (!FRigUnit_NoiseFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_NoiseFloat");
		}
	}

	static FRigUnit_NoiseFloat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_NoiseFloat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_NoiseFloat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_NoiseFloat");
		FRigUnit_NoiseFloat_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_NoiseFloat_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_NoiseFloat", FRigUnit_NoiseFloat_IsValid);
	}
}
