using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatToInt", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatToInt
{
	private static bool FRigUnit_MathFloatToInt_IsValid;

	private static int FRigUnit_MathFloatToInt_StructSize;

	public FRigUnit_MathFloatToInt Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatToInt FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatToInt(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatToInt value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatToInt FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatToInt(nativeBuffer + arrayIndex * FRigUnit_MathFloatToInt_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatToInt value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatToInt_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatToInt_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatToInt");
		}
	}

	public FRigUnit_MathFloatToInt(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatToInt_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatToInt");
		}
	}

	static FRigUnit_MathFloatToInt()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatToInt)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatToInt));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatToInt");
		FRigUnit_MathFloatToInt_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatToInt_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatToInt", FRigUnit_MathFloatToInt_IsValid);
	}
}
