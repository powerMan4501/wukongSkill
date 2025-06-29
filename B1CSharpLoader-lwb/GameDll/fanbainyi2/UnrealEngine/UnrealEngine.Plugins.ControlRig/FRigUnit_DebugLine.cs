using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DebugLine", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DebugLine
{
	private static bool FRigUnit_DebugLine_IsValid;

	private static int FRigUnit_DebugLine_StructSize;

	public FRigUnit_DebugLine Copy()
	{
		return this;
	}

	public static FRigUnit_DebugLine FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DebugLine(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DebugLine value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DebugLine FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DebugLine(nativeBuffer + arrayIndex * FRigUnit_DebugLine_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DebugLine value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DebugLine_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugLine_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugLine");
		}
	}

	public FRigUnit_DebugLine(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugLine_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugLine");
		}
	}

	static FRigUnit_DebugLine()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DebugLine)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DebugLine));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DebugLine");
		FRigUnit_DebugLine_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DebugLine_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DebugLine", FRigUnit_DebugLine_IsValid);
	}
}
