using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatMod", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatMod
{
	private static bool FRigUnit_MathFloatMod_IsValid;

	private static int FRigUnit_MathFloatMod_StructSize;

	public FRigUnit_MathFloatMod Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatMod FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatMod(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatMod value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatMod FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatMod(nativeBuffer + arrayIndex * FRigUnit_MathFloatMod_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatMod value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatMod_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatMod_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatMod");
		}
	}

	public FRigUnit_MathFloatMod(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatMod_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatMod");
		}
	}

	static FRigUnit_MathFloatMod()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatMod)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatMod));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatMod");
		FRigUnit_MathFloatMod_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatMod_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatMod", FRigUnit_MathFloatMod_IsValid);
	}
}
