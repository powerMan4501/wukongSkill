using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetSpaceInitialTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetSpaceInitialTransform
{
	private static bool FRigUnit_SetSpaceInitialTransform_IsValid;

	private static int FRigUnit_SetSpaceInitialTransform_StructSize;

	public FRigUnit_SetSpaceInitialTransform Copy()
	{
		return this;
	}

	public static FRigUnit_SetSpaceInitialTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetSpaceInitialTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetSpaceInitialTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetSpaceInitialTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetSpaceInitialTransform(nativeBuffer + arrayIndex * FRigUnit_SetSpaceInitialTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetSpaceInitialTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetSpaceInitialTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetSpaceInitialTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetSpaceInitialTransform");
		}
	}

	public FRigUnit_SetSpaceInitialTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetSpaceInitialTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetSpaceInitialTransform");
		}
	}

	static FRigUnit_SetSpaceInitialTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetSpaceInitialTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetSpaceInitialTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetSpaceInitialTransform");
		FRigUnit_SetSpaceInitialTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetSpaceInitialTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetSpaceInitialTransform", FRigUnit_SetSpaceInitialTransform_IsValid);
	}
}
