using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_GetRelativeBoneTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_GetRelativeBoneTransform
{
	private static bool FRigUnit_GetRelativeBoneTransform_IsValid;

	private static int FRigUnit_GetRelativeBoneTransform_StructSize;

	public FRigUnit_GetRelativeBoneTransform Copy()
	{
		return this;
	}

	public static FRigUnit_GetRelativeBoneTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_GetRelativeBoneTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_GetRelativeBoneTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_GetRelativeBoneTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_GetRelativeBoneTransform(nativeBuffer + arrayIndex * FRigUnit_GetRelativeBoneTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_GetRelativeBoneTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_GetRelativeBoneTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetRelativeBoneTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetRelativeBoneTransform");
		}
	}

	public FRigUnit_GetRelativeBoneTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetRelativeBoneTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetRelativeBoneTransform");
		}
	}

	static FRigUnit_GetRelativeBoneTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_GetRelativeBoneTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_GetRelativeBoneTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_GetRelativeBoneTransform");
		FRigUnit_GetRelativeBoneTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_GetRelativeBoneTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_GetRelativeBoneTransform", FRigUnit_GetRelativeBoneTransform_IsValid);
	}
}
