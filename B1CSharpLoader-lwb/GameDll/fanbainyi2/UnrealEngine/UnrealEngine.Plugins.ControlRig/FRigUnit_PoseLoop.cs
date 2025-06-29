using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_PoseLoop", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_PoseLoop
{
	private static bool FRigUnit_PoseLoop_IsValid;

	private static int FRigUnit_PoseLoop_StructSize;

	public FRigUnit_PoseLoop Copy()
	{
		return this;
	}

	public static FRigUnit_PoseLoop FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_PoseLoop(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_PoseLoop value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_PoseLoop FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_PoseLoop(nativeBuffer + arrayIndex * FRigUnit_PoseLoop_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_PoseLoop value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_PoseLoop_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_PoseLoop_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PoseLoop");
		}
	}

	public FRigUnit_PoseLoop(IntPtr nativeStruct)
	{
		if (!FRigUnit_PoseLoop_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PoseLoop");
		}
	}

	static FRigUnit_PoseLoop()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_PoseLoop)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_PoseLoop));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_PoseLoop");
		FRigUnit_PoseLoop_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_PoseLoop_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_PoseLoop", FRigUnit_PoseLoop_IsValid);
	}
}
