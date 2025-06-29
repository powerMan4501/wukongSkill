using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetMultiControlBool", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetMultiControlBool
{
	private static bool FRigUnit_SetMultiControlBool_IsValid;

	private static int FRigUnit_SetMultiControlBool_StructSize;

	public FRigUnit_SetMultiControlBool Copy()
	{
		return this;
	}

	public static FRigUnit_SetMultiControlBool FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetMultiControlBool(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetMultiControlBool value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetMultiControlBool FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetMultiControlBool(nativeBuffer + arrayIndex * FRigUnit_SetMultiControlBool_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetMultiControlBool value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetMultiControlBool_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetMultiControlBool_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetMultiControlBool");
		}
	}

	public FRigUnit_SetMultiControlBool(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetMultiControlBool_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetMultiControlBool");
		}
	}

	static FRigUnit_SetMultiControlBool()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetMultiControlBool)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetMultiControlBool));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetMultiControlBool");
		FRigUnit_SetMultiControlBool_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetMultiControlBool_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetMultiControlBool", FRigUnit_SetMultiControlBool_IsValid);
	}
}
