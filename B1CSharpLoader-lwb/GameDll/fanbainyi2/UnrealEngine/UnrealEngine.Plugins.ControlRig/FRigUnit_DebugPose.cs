using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DebugPose", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DebugPose
{
	private static bool FRigUnit_DebugPose_IsValid;

	private static int FRigUnit_DebugPose_StructSize;

	public FRigUnit_DebugPose Copy()
	{
		return this;
	}

	public static FRigUnit_DebugPose FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DebugPose(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DebugPose value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DebugPose FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DebugPose(nativeBuffer + arrayIndex * FRigUnit_DebugPose_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DebugPose value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DebugPose_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugPose_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugPose");
		}
	}

	public FRigUnit_DebugPose(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugPose_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugPose");
		}
	}

	static FRigUnit_DebugPose()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DebugPose)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DebugPose));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DebugPose");
		FRigUnit_DebugPose_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DebugPose_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DebugPose", FRigUnit_DebugPose_IsValid);
	}
}
