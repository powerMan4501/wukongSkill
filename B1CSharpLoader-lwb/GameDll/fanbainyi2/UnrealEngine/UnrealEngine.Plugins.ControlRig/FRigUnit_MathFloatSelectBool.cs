using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatSelectBool", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatSelectBool
{
	private static bool FRigUnit_MathFloatSelectBool_IsValid;

	private static int FRigUnit_MathFloatSelectBool_StructSize;

	public FRigUnit_MathFloatSelectBool Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatSelectBool FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatSelectBool(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatSelectBool value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatSelectBool FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatSelectBool(nativeBuffer + arrayIndex * FRigUnit_MathFloatSelectBool_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatSelectBool value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatSelectBool_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatSelectBool_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatSelectBool");
		}
	}

	public FRigUnit_MathFloatSelectBool(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatSelectBool_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatSelectBool");
		}
	}

	static FRigUnit_MathFloatSelectBool()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatSelectBool)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatSelectBool));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatSelectBool");
		FRigUnit_MathFloatSelectBool_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatSelectBool_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatSelectBool", FRigUnit_MathFloatSelectBool_IsValid);
	}
}
