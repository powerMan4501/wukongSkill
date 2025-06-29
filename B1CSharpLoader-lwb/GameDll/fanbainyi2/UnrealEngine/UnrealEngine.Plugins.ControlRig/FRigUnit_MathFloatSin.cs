using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatSin", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatSin
{
	private static bool FRigUnit_MathFloatSin_IsValid;

	private static int FRigUnit_MathFloatSin_StructSize;

	public FRigUnit_MathFloatSin Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatSin FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatSin(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatSin value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatSin FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatSin(nativeBuffer + arrayIndex * FRigUnit_MathFloatSin_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatSin value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatSin_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatSin_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatSin");
		}
	}

	public FRigUnit_MathFloatSin(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatSin_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatSin");
		}
	}

	static FRigUnit_MathFloatSin()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatSin)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatSin));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatSin");
		FRigUnit_MathFloatSin_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatSin_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatSin", FRigUnit_MathFloatSin_IsValid);
	}
}
