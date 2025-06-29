using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_GetControlBool", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_GetControlBool
{
	private static bool FRigUnit_GetControlBool_IsValid;

	private static int FRigUnit_GetControlBool_StructSize;

	public FRigUnit_GetControlBool Copy()
	{
		return this;
	}

	public static FRigUnit_GetControlBool FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_GetControlBool(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_GetControlBool value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_GetControlBool FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_GetControlBool(nativeBuffer + arrayIndex * FRigUnit_GetControlBool_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_GetControlBool value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_GetControlBool_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetControlBool_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetControlBool");
		}
	}

	public FRigUnit_GetControlBool(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetControlBool_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetControlBool");
		}
	}

	static FRigUnit_GetControlBool()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_GetControlBool)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_GetControlBool));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_GetControlBool");
		FRigUnit_GetControlBool_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_GetControlBool_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_GetControlBool", FRigUnit_GetControlBool_IsValid);
	}
}
