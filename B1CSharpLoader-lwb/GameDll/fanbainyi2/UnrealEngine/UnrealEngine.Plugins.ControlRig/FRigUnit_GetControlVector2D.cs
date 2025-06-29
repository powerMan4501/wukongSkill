using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_GetControlVector2D", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_GetControlVector2D
{
	private static bool FRigUnit_GetControlVector2D_IsValid;

	private static int FRigUnit_GetControlVector2D_StructSize;

	public FRigUnit_GetControlVector2D Copy()
	{
		return this;
	}

	public static FRigUnit_GetControlVector2D FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_GetControlVector2D(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_GetControlVector2D value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_GetControlVector2D FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_GetControlVector2D(nativeBuffer + arrayIndex * FRigUnit_GetControlVector2D_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_GetControlVector2D value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_GetControlVector2D_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetControlVector2D_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetControlVector2D");
		}
	}

	public FRigUnit_GetControlVector2D(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetControlVector2D_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetControlVector2D");
		}
	}

	static FRigUnit_GetControlVector2D()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_GetControlVector2D)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_GetControlVector2D));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_GetControlVector2D");
		FRigUnit_GetControlVector2D_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_GetControlVector2D_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_GetControlVector2D", FRigUnit_GetControlVector2D_IsValid);
	}
}
