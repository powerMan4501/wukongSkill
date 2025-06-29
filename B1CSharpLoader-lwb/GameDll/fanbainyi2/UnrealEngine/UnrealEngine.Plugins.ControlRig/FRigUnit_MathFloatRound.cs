using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatRound", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatRound
{
	private static bool FRigUnit_MathFloatRound_IsValid;

	private static int FRigUnit_MathFloatRound_StructSize;

	public FRigUnit_MathFloatRound Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatRound FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatRound(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatRound value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatRound FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatRound(nativeBuffer + arrayIndex * FRigUnit_MathFloatRound_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatRound value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatRound_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatRound_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatRound");
		}
	}

	public FRigUnit_MathFloatRound(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatRound_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatRound");
		}
	}

	static FRigUnit_MathFloatRound()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatRound)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatRound));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatRound");
		FRigUnit_MathFloatRound_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatRound_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatRound", FRigUnit_MathFloatRound_IsValid);
	}
}
