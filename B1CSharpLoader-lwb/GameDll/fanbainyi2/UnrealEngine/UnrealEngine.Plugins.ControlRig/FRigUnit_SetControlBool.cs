using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetControlBool", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetControlBool
{
	private static bool FRigUnit_SetControlBool_IsValid;

	private static int FRigUnit_SetControlBool_StructSize;

	public FRigUnit_SetControlBool Copy()
	{
		return this;
	}

	public static FRigUnit_SetControlBool FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetControlBool(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetControlBool value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetControlBool FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetControlBool(nativeBuffer + arrayIndex * FRigUnit_SetControlBool_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetControlBool value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetControlBool_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetControlBool_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetControlBool");
		}
	}

	public FRigUnit_SetControlBool(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetControlBool_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetControlBool");
		}
	}

	static FRigUnit_SetControlBool()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetControlBool)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetControlBool));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetControlBool");
		FRigUnit_SetControlBool_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetControlBool_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetControlBool", FRigUnit_SetControlBool_IsValid);
	}
}
