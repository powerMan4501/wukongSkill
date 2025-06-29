using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_GetControlInteger", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_GetControlInteger
{
	private static bool FRigUnit_GetControlInteger_IsValid;

	private static int FRigUnit_GetControlInteger_StructSize;

	public FRigUnit_GetControlInteger Copy()
	{
		return this;
	}

	public static FRigUnit_GetControlInteger FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_GetControlInteger(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_GetControlInteger value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_GetControlInteger FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_GetControlInteger(nativeBuffer + arrayIndex * FRigUnit_GetControlInteger_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_GetControlInteger value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_GetControlInteger_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetControlInteger_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetControlInteger");
		}
	}

	public FRigUnit_GetControlInteger(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetControlInteger_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetControlInteger");
		}
	}

	static FRigUnit_GetControlInteger()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_GetControlInteger)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_GetControlInteger));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_GetControlInteger");
		FRigUnit_GetControlInteger_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_GetControlInteger_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_GetControlInteger", FRigUnit_GetControlInteger_IsValid);
	}
}
