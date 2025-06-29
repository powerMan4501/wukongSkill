using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetMultiControlVector2D", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetMultiControlVector2D
{
	private static bool FRigUnit_SetMultiControlVector2D_IsValid;

	private static int FRigUnit_SetMultiControlVector2D_StructSize;

	public FRigUnit_SetMultiControlVector2D Copy()
	{
		return this;
	}

	public static FRigUnit_SetMultiControlVector2D FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetMultiControlVector2D(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetMultiControlVector2D value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetMultiControlVector2D FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetMultiControlVector2D(nativeBuffer + arrayIndex * FRigUnit_SetMultiControlVector2D_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetMultiControlVector2D value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetMultiControlVector2D_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetMultiControlVector2D_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetMultiControlVector2D");
		}
	}

	public FRigUnit_SetMultiControlVector2D(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetMultiControlVector2D_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetMultiControlVector2D");
		}
	}

	static FRigUnit_SetMultiControlVector2D()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetMultiControlVector2D)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetMultiControlVector2D));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetMultiControlVector2D");
		FRigUnit_SetMultiControlVector2D_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetMultiControlVector2D_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetMultiControlVector2D", FRigUnit_SetMultiControlVector2D_IsValid);
	}
}
