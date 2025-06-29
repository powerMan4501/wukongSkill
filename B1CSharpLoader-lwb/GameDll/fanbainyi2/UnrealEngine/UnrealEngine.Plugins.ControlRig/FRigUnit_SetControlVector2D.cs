using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetControlVector2D", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetControlVector2D
{
	private static bool FRigUnit_SetControlVector2D_IsValid;

	private static int FRigUnit_SetControlVector2D_StructSize;

	public FRigUnit_SetControlVector2D Copy()
	{
		return this;
	}

	public static FRigUnit_SetControlVector2D FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetControlVector2D(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetControlVector2D value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetControlVector2D FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetControlVector2D(nativeBuffer + arrayIndex * FRigUnit_SetControlVector2D_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetControlVector2D value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetControlVector2D_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetControlVector2D_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetControlVector2D");
		}
	}

	public FRigUnit_SetControlVector2D(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetControlVector2D_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetControlVector2D");
		}
	}

	static FRigUnit_SetControlVector2D()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetControlVector2D)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetControlVector2D));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetControlVector2D");
		FRigUnit_SetControlVector2D_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetControlVector2D_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetControlVector2D", FRigUnit_SetControlVector2D_IsValid);
	}
}
