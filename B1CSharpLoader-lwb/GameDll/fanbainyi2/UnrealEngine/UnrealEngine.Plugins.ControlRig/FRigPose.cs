using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigPose", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigPose
{
	private static bool FRigPose_IsValid;

	private static int FRigPose_StructSize;

	public FRigPose Copy()
	{
		return this;
	}

	public static FRigPose FromNative(IntPtr nativeBuffer)
	{
		return new FRigPose(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigPose value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigPose FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigPose(nativeBuffer + arrayIndex * FRigPose_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigPose value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigPose_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigPose_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigPose");
		}
	}

	public FRigPose(IntPtr nativeStruct)
	{
		if (!FRigPose_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigPose");
		}
	}

	static FRigPose()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigPose)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigPose));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigPose");
		FRigPose_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigPose_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigPose", FRigPose_IsValid);
	}
}
