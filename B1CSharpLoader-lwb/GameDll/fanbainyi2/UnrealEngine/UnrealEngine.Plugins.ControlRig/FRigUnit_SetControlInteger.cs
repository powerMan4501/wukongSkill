using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetControlInteger", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetControlInteger
{
	private static bool FRigUnit_SetControlInteger_IsValid;

	private static int FRigUnit_SetControlInteger_StructSize;

	public FRigUnit_SetControlInteger Copy()
	{
		return this;
	}

	public static FRigUnit_SetControlInteger FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetControlInteger(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetControlInteger value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetControlInteger FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetControlInteger(nativeBuffer + arrayIndex * FRigUnit_SetControlInteger_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetControlInteger value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetControlInteger_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetControlInteger_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetControlInteger");
		}
	}

	public FRigUnit_SetControlInteger(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetControlInteger_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetControlInteger");
		}
	}

	static FRigUnit_SetControlInteger()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetControlInteger)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetControlInteger));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetControlInteger");
		FRigUnit_SetControlInteger_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetControlInteger_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetControlInteger", FRigUnit_SetControlInteger_IsValid);
	}
}
