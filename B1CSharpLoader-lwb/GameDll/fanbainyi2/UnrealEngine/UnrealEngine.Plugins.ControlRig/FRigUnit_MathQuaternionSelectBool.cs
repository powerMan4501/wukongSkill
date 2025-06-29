using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathQuaternionSelectBool", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathQuaternionSelectBool
{
	private static bool FRigUnit_MathQuaternionSelectBool_IsValid;

	private static int FRigUnit_MathQuaternionSelectBool_StructSize;

	public FRigUnit_MathQuaternionSelectBool Copy()
	{
		return this;
	}

	public static FRigUnit_MathQuaternionSelectBool FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathQuaternionSelectBool(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathQuaternionSelectBool value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathQuaternionSelectBool FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathQuaternionSelectBool(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionSelectBool_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathQuaternionSelectBool value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionSelectBool_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionSelectBool_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionSelectBool");
		}
	}

	public FRigUnit_MathQuaternionSelectBool(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionSelectBool_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionSelectBool");
		}
	}

	static FRigUnit_MathQuaternionSelectBool()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathQuaternionSelectBool)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathQuaternionSelectBool));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathQuaternionSelectBool");
		FRigUnit_MathQuaternionSelectBool_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathQuaternionSelectBool_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathQuaternionSelectBool", FRigUnit_MathQuaternionSelectBool_IsValid);
	}
}
