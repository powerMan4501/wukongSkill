using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_TimeOffsetTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_TimeOffsetTransform
{
	private static bool FRigUnit_TimeOffsetTransform_IsValid;

	private static int FRigUnit_TimeOffsetTransform_StructSize;

	public FRigUnit_TimeOffsetTransform Copy()
	{
		return this;
	}

	public static FRigUnit_TimeOffsetTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_TimeOffsetTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_TimeOffsetTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_TimeOffsetTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_TimeOffsetTransform(nativeBuffer + arrayIndex * FRigUnit_TimeOffsetTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_TimeOffsetTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_TimeOffsetTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_TimeOffsetTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_TimeOffsetTransform");
		}
	}

	public FRigUnit_TimeOffsetTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_TimeOffsetTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_TimeOffsetTransform");
		}
	}

	static FRigUnit_TimeOffsetTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_TimeOffsetTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_TimeOffsetTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_TimeOffsetTransform");
		FRigUnit_TimeOffsetTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_TimeOffsetTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_TimeOffsetTransform", FRigUnit_TimeOffsetTransform_IsValid);
	}
}
