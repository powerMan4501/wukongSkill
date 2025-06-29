using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_VisualDebugVector", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_VisualDebugVector
{
	private static bool FRigUnit_VisualDebugVector_IsValid;

	private static int FRigUnit_VisualDebugVector_StructSize;

	public FRigUnit_VisualDebugVector Copy()
	{
		return this;
	}

	public static FRigUnit_VisualDebugVector FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_VisualDebugVector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_VisualDebugVector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_VisualDebugVector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_VisualDebugVector(nativeBuffer + arrayIndex * FRigUnit_VisualDebugVector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_VisualDebugVector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_VisualDebugVector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_VisualDebugVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_VisualDebugVector");
		}
	}

	public FRigUnit_VisualDebugVector(IntPtr nativeStruct)
	{
		if (!FRigUnit_VisualDebugVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_VisualDebugVector");
		}
	}

	static FRigUnit_VisualDebugVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_VisualDebugVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_VisualDebugVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_VisualDebugVector");
		FRigUnit_VisualDebugVector_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_VisualDebugVector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_VisualDebugVector", FRigUnit_VisualDebugVector_IsValid);
	}
}
