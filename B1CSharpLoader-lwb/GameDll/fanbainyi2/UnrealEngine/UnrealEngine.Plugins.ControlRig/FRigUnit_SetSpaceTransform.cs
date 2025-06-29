using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetSpaceTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetSpaceTransform
{
	private static bool FRigUnit_SetSpaceTransform_IsValid;

	private static int FRigUnit_SetSpaceTransform_StructSize;

	public FRigUnit_SetSpaceTransform Copy()
	{
		return this;
	}

	public static FRigUnit_SetSpaceTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetSpaceTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetSpaceTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetSpaceTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetSpaceTransform(nativeBuffer + arrayIndex * FRigUnit_SetSpaceTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetSpaceTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetSpaceTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetSpaceTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetSpaceTransform");
		}
	}

	public FRigUnit_SetSpaceTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetSpaceTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetSpaceTransform");
		}
	}

	static FRigUnit_SetSpaceTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetSpaceTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetSpaceTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetSpaceTransform");
		FRigUnit_SetSpaceTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetSpaceTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetSpaceTransform", FRigUnit_SetSpaceTransform_IsValid);
	}
}
