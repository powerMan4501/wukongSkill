using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DebugPoint", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DebugPoint
{
	private static bool FRigUnit_DebugPoint_IsValid;

	private static int FRigUnit_DebugPoint_StructSize;

	public FRigUnit_DebugPoint Copy()
	{
		return this;
	}

	public static FRigUnit_DebugPoint FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DebugPoint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DebugPoint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DebugPoint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DebugPoint(nativeBuffer + arrayIndex * FRigUnit_DebugPoint_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DebugPoint value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DebugPoint_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugPoint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugPoint");
		}
	}

	public FRigUnit_DebugPoint(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugPoint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugPoint");
		}
	}

	static FRigUnit_DebugPoint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DebugPoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DebugPoint));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DebugPoint");
		FRigUnit_DebugPoint_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DebugPoint_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DebugPoint", FRigUnit_DebugPoint_IsValid);
	}
}
