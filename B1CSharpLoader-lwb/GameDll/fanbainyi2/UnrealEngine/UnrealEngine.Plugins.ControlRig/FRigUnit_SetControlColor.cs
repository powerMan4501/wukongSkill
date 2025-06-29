using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetControlColor", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetControlColor
{
	private static bool FRigUnit_SetControlColor_IsValid;

	private static int FRigUnit_SetControlColor_StructSize;

	public FRigUnit_SetControlColor Copy()
	{
		return this;
	}

	public static FRigUnit_SetControlColor FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetControlColor(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetControlColor value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetControlColor FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetControlColor(nativeBuffer + arrayIndex * FRigUnit_SetControlColor_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetControlColor value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetControlColor_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetControlColor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetControlColor");
		}
	}

	public FRigUnit_SetControlColor(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetControlColor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetControlColor");
		}
	}

	static FRigUnit_SetControlColor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetControlColor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetControlColor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetControlColor");
		FRigUnit_SetControlColor_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetControlColor_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetControlColor", FRigUnit_SetControlColor_IsValid);
	}
}
