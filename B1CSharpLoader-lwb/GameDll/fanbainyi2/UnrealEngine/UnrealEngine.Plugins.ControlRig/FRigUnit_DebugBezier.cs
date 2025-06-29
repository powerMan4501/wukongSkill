using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DebugBezier", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DebugBezier
{
	private static bool FRigUnit_DebugBezier_IsValid;

	private static int FRigUnit_DebugBezier_StructSize;

	public FRigUnit_DebugBezier Copy()
	{
		return this;
	}

	public static FRigUnit_DebugBezier FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DebugBezier(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DebugBezier value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DebugBezier FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DebugBezier(nativeBuffer + arrayIndex * FRigUnit_DebugBezier_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DebugBezier value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DebugBezier_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugBezier_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugBezier");
		}
	}

	public FRigUnit_DebugBezier(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugBezier_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugBezier");
		}
	}

	static FRigUnit_DebugBezier()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DebugBezier)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DebugBezier));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DebugBezier");
		FRigUnit_DebugBezier_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DebugBezier_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DebugBezier", FRigUnit_DebugBezier_IsValid);
	}
}
