using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetRelativeBoneTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetRelativeBoneTransform
{
	private static bool FRigUnit_SetRelativeBoneTransform_IsValid;

	private static int FRigUnit_SetRelativeBoneTransform_StructSize;

	public FRigUnit_SetRelativeBoneTransform Copy()
	{
		return this;
	}

	public static FRigUnit_SetRelativeBoneTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetRelativeBoneTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetRelativeBoneTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetRelativeBoneTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetRelativeBoneTransform(nativeBuffer + arrayIndex * FRigUnit_SetRelativeBoneTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetRelativeBoneTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetRelativeBoneTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetRelativeBoneTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetRelativeBoneTransform");
		}
	}

	public FRigUnit_SetRelativeBoneTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetRelativeBoneTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetRelativeBoneTransform");
		}
	}

	static FRigUnit_SetRelativeBoneTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetRelativeBoneTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetRelativeBoneTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetRelativeBoneTransform");
		FRigUnit_SetRelativeBoneTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetRelativeBoneTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetRelativeBoneTransform", FRigUnit_SetRelativeBoneTransform_IsValid);
	}
}
