using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SendEvent", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SendEvent
{
	private static bool FRigUnit_SendEvent_IsValid;

	private static int FRigUnit_SendEvent_StructSize;

	public FRigUnit_SendEvent Copy()
	{
		return this;
	}

	public static FRigUnit_SendEvent FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SendEvent(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SendEvent value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SendEvent FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SendEvent(nativeBuffer + arrayIndex * FRigUnit_SendEvent_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SendEvent value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SendEvent_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SendEvent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SendEvent");
		}
	}

	public FRigUnit_SendEvent(IntPtr nativeStruct)
	{
		if (!FRigUnit_SendEvent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SendEvent");
		}
	}

	static FRigUnit_SendEvent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SendEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SendEvent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SendEvent");
		FRigUnit_SendEvent_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SendEvent_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SendEvent", FRigUnit_SendEvent_IsValid);
	}
}
