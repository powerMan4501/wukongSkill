using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetMultiControlInteger", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetMultiControlInteger
{
	private static bool FRigUnit_SetMultiControlInteger_IsValid;

	private static int FRigUnit_SetMultiControlInteger_StructSize;

	public FRigUnit_SetMultiControlInteger Copy()
	{
		return this;
	}

	public static FRigUnit_SetMultiControlInteger FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetMultiControlInteger(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetMultiControlInteger value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetMultiControlInteger FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetMultiControlInteger(nativeBuffer + arrayIndex * FRigUnit_SetMultiControlInteger_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetMultiControlInteger value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetMultiControlInteger_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetMultiControlInteger_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetMultiControlInteger");
		}
	}

	public FRigUnit_SetMultiControlInteger(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetMultiControlInteger_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetMultiControlInteger");
		}
	}

	static FRigUnit_SetMultiControlInteger()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetMultiControlInteger)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetMultiControlInteger));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetMultiControlInteger");
		FRigUnit_SetMultiControlInteger_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetMultiControlInteger_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetMultiControlInteger", FRigUnit_SetMultiControlInteger_IsValid);
	}
}
