using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_GetRelativeTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_GetRelativeTransform
{
	private static bool FRigUnit_GetRelativeTransform_IsValid;

	private static int FRigUnit_GetRelativeTransform_StructSize;

	public FRigUnit_GetRelativeTransform Copy()
	{
		return this;
	}

	public static FRigUnit_GetRelativeTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_GetRelativeTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_GetRelativeTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_GetRelativeTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_GetRelativeTransform(nativeBuffer + arrayIndex * FRigUnit_GetRelativeTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_GetRelativeTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_GetRelativeTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetRelativeTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetRelativeTransform");
		}
	}

	public FRigUnit_GetRelativeTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetRelativeTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetRelativeTransform");
		}
	}

	static FRigUnit_GetRelativeTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_GetRelativeTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_GetRelativeTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_GetRelativeTransform");
		FRigUnit_GetRelativeTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_GetRelativeTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_GetRelativeTransform", FRigUnit_GetRelativeTransform_IsValid);
	}
}
