using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatSign", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatSign
{
	private static bool FRigUnit_MathFloatSign_IsValid;

	private static int FRigUnit_MathFloatSign_StructSize;

	public FRigUnit_MathFloatSign Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatSign FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatSign(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatSign value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatSign FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatSign(nativeBuffer + arrayIndex * FRigUnit_MathFloatSign_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatSign value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatSign_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatSign_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatSign");
		}
	}

	public FRigUnit_MathFloatSign(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatSign_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatSign");
		}
	}

	static FRigUnit_MathFloatSign()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatSign)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatSign));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatSign");
		FRigUnit_MathFloatSign_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatSign_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatSign", FRigUnit_MathFloatSign_IsValid);
	}
}
