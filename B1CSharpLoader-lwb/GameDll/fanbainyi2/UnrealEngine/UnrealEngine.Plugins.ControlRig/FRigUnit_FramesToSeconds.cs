using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_FramesToSeconds", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_FramesToSeconds
{
	private static bool FRigUnit_FramesToSeconds_IsValid;

	private static int FRigUnit_FramesToSeconds_StructSize;

	public FRigUnit_FramesToSeconds Copy()
	{
		return this;
	}

	public static FRigUnit_FramesToSeconds FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_FramesToSeconds(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_FramesToSeconds value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_FramesToSeconds FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_FramesToSeconds(nativeBuffer + arrayIndex * FRigUnit_FramesToSeconds_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_FramesToSeconds value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_FramesToSeconds_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_FramesToSeconds_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_FramesToSeconds");
		}
	}

	public FRigUnit_FramesToSeconds(IntPtr nativeStruct)
	{
		if (!FRigUnit_FramesToSeconds_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_FramesToSeconds");
		}
	}

	static FRigUnit_FramesToSeconds()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_FramesToSeconds)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_FramesToSeconds));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_FramesToSeconds");
		FRigUnit_FramesToSeconds_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_FramesToSeconds_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_FramesToSeconds", FRigUnit_FramesToSeconds_IsValid);
	}
}
