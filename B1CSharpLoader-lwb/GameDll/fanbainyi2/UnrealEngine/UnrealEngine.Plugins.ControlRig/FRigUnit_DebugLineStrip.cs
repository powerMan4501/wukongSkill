using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DebugLineStrip", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DebugLineStrip
{
	private static bool FRigUnit_DebugLineStrip_IsValid;

	private static int FRigUnit_DebugLineStrip_StructSize;

	public FRigUnit_DebugLineStrip Copy()
	{
		return this;
	}

	public static FRigUnit_DebugLineStrip FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DebugLineStrip(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DebugLineStrip value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DebugLineStrip FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DebugLineStrip(nativeBuffer + arrayIndex * FRigUnit_DebugLineStrip_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DebugLineStrip value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DebugLineStrip_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugLineStrip_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugLineStrip");
		}
	}

	public FRigUnit_DebugLineStrip(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugLineStrip_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugLineStrip");
		}
	}

	static FRigUnit_DebugLineStrip()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DebugLineStrip)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DebugLineStrip));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DebugLineStrip");
		FRigUnit_DebugLineStrip_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DebugLineStrip_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DebugLineStrip", FRigUnit_DebugLineStrip_IsValid);
	}
}
