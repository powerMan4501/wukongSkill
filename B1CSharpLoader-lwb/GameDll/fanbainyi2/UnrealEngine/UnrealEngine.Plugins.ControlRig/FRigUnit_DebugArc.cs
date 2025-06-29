using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DebugArc", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DebugArc
{
	private static bool FRigUnit_DebugArc_IsValid;

	private static int FRigUnit_DebugArc_StructSize;

	public FRigUnit_DebugArc Copy()
	{
		return this;
	}

	public static FRigUnit_DebugArc FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DebugArc(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DebugArc value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DebugArc FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DebugArc(nativeBuffer + arrayIndex * FRigUnit_DebugArc_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DebugArc value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DebugArc_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugArc_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugArc");
		}
	}

	public FRigUnit_DebugArc(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugArc_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugArc");
		}
	}

	static FRigUnit_DebugArc()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DebugArc)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DebugArc));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DebugArc");
		FRigUnit_DebugArc_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DebugArc_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DebugArc", FRigUnit_DebugArc_IsValid);
	}
}
