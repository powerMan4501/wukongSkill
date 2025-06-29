using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DebugBase", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DebugBase
{
	private static bool FRigUnit_DebugBase_IsValid;

	private static int FRigUnit_DebugBase_StructSize;

	public FRigUnit_DebugBase Copy()
	{
		return this;
	}

	public static FRigUnit_DebugBase FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DebugBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DebugBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DebugBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DebugBase(nativeBuffer + arrayIndex * FRigUnit_DebugBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DebugBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DebugBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugBase");
		}
	}

	public FRigUnit_DebugBase(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugBase");
		}
	}

	static FRigUnit_DebugBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DebugBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DebugBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DebugBase");
		FRigUnit_DebugBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DebugBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DebugBase", FRigUnit_DebugBase_IsValid);
	}
}
