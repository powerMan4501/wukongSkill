using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_VisualDebugQuat", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_VisualDebugQuat
{
	private static bool FRigUnit_VisualDebugQuat_IsValid;

	private static int FRigUnit_VisualDebugQuat_StructSize;

	public FRigUnit_VisualDebugQuat Copy()
	{
		return this;
	}

	public static FRigUnit_VisualDebugQuat FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_VisualDebugQuat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_VisualDebugQuat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_VisualDebugQuat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_VisualDebugQuat(nativeBuffer + arrayIndex * FRigUnit_VisualDebugQuat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_VisualDebugQuat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_VisualDebugQuat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_VisualDebugQuat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_VisualDebugQuat");
		}
	}

	public FRigUnit_VisualDebugQuat(IntPtr nativeStruct)
	{
		if (!FRigUnit_VisualDebugQuat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_VisualDebugQuat");
		}
	}

	static FRigUnit_VisualDebugQuat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_VisualDebugQuat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_VisualDebugQuat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_VisualDebugQuat");
		FRigUnit_VisualDebugQuat_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_VisualDebugQuat_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_VisualDebugQuat", FRigUnit_VisualDebugQuat_IsValid);
	}
}
