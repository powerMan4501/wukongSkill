using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_GetTransformArray", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_GetTransformArray
{
	private static bool FRigUnit_GetTransformArray_IsValid;

	private static int FRigUnit_GetTransformArray_StructSize;

	public FRigUnit_GetTransformArray Copy()
	{
		return this;
	}

	public static FRigUnit_GetTransformArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_GetTransformArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_GetTransformArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_GetTransformArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_GetTransformArray(nativeBuffer + arrayIndex * FRigUnit_GetTransformArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_GetTransformArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_GetTransformArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetTransformArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetTransformArray");
		}
	}

	public FRigUnit_GetTransformArray(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetTransformArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetTransformArray");
		}
	}

	static FRigUnit_GetTransformArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_GetTransformArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_GetTransformArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_GetTransformArray");
		FRigUnit_GetTransformArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_GetTransformArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_GetTransformArray", FRigUnit_GetTransformArray_IsValid);
	}
}
