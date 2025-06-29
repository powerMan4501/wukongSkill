using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_GetTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_GetTransform
{
	private static bool FRigUnit_GetTransform_IsValid;

	private static int FRigUnit_GetTransform_StructSize;

	public FRigUnit_GetTransform Copy()
	{
		return this;
	}

	public static FRigUnit_GetTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_GetTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_GetTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_GetTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_GetTransform(nativeBuffer + arrayIndex * FRigUnit_GetTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_GetTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_GetTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetTransform");
		}
	}

	public FRigUnit_GetTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetTransform");
		}
	}

	static FRigUnit_GetTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_GetTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_GetTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_GetTransform");
		FRigUnit_GetTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_GetTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_GetTransform", FRigUnit_GetTransform_IsValid);
	}
}
