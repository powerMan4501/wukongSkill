using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetTransform
{
	private static bool FRigUnit_SetTransform_IsValid;

	private static int FRigUnit_SetTransform_StructSize;

	public FRigUnit_SetTransform Copy()
	{
		return this;
	}

	public static FRigUnit_SetTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetTransform(nativeBuffer + arrayIndex * FRigUnit_SetTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetTransform");
		}
	}

	public FRigUnit_SetTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetTransform");
		}
	}

	static FRigUnit_SetTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetTransform");
		FRigUnit_SetTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetTransform", FRigUnit_SetTransform_IsValid);
	}
}
