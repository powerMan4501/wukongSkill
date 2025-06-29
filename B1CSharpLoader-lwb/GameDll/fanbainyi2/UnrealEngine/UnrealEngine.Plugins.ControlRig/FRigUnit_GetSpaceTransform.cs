using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_GetSpaceTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_GetSpaceTransform
{
	private static bool FRigUnit_GetSpaceTransform_IsValid;

	private static int FRigUnit_GetSpaceTransform_StructSize;

	public FRigUnit_GetSpaceTransform Copy()
	{
		return this;
	}

	public static FRigUnit_GetSpaceTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_GetSpaceTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_GetSpaceTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_GetSpaceTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_GetSpaceTransform(nativeBuffer + arrayIndex * FRigUnit_GetSpaceTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_GetSpaceTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_GetSpaceTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetSpaceTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetSpaceTransform");
		}
	}

	public FRigUnit_GetSpaceTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetSpaceTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetSpaceTransform");
		}
	}

	static FRigUnit_GetSpaceTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_GetSpaceTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_GetSpaceTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_GetSpaceTransform");
		FRigUnit_GetSpaceTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_GetSpaceTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_GetSpaceTransform", FRigUnit_GetSpaceTransform_IsValid);
	}
}
