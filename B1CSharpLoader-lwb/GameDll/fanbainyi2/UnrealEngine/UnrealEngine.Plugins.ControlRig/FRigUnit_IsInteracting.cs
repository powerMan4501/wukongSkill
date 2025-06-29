using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_IsInteracting", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_IsInteracting
{
	private static bool FRigUnit_IsInteracting_IsValid;

	private static int FRigUnit_IsInteracting_StructSize;

	public FRigUnit_IsInteracting Copy()
	{
		return this;
	}

	public static FRigUnit_IsInteracting FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_IsInteracting(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_IsInteracting value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_IsInteracting FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_IsInteracting(nativeBuffer + arrayIndex * FRigUnit_IsInteracting_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_IsInteracting value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_IsInteracting_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_IsInteracting_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_IsInteracting");
		}
	}

	public FRigUnit_IsInteracting(IntPtr nativeStruct)
	{
		if (!FRigUnit_IsInteracting_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_IsInteracting");
		}
	}

	static FRigUnit_IsInteracting()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_IsInteracting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_IsInteracting));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_IsInteracting");
		FRigUnit_IsInteracting_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_IsInteracting_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_IsInteracting", FRigUnit_IsInteracting_IsValid);
	}
}
