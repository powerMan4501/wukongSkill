using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_GetJointTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_GetJointTransform
{
	private static bool FRigUnit_GetJointTransform_IsValid;

	private static int FRigUnit_GetJointTransform_StructSize;

	public FRigUnit_GetJointTransform Copy()
	{
		return this;
	}

	public static FRigUnit_GetJointTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_GetJointTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_GetJointTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_GetJointTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_GetJointTransform(nativeBuffer + arrayIndex * FRigUnit_GetJointTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_GetJointTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_GetJointTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetJointTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetJointTransform");
		}
	}

	public FRigUnit_GetJointTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetJointTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetJointTransform");
		}
	}

	static FRigUnit_GetJointTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_GetJointTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_GetJointTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_GetJointTransform");
		FRigUnit_GetJointTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_GetJointTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_GetJointTransform", FRigUnit_GetJointTransform_IsValid);
	}
}
