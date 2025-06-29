using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetTransformArray", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetTransformArray
{
	private static bool FRigUnit_SetTransformArray_IsValid;

	private static int FRigUnit_SetTransformArray_StructSize;

	public FRigUnit_SetTransformArray Copy()
	{
		return this;
	}

	public static FRigUnit_SetTransformArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetTransformArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetTransformArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetTransformArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetTransformArray(nativeBuffer + arrayIndex * FRigUnit_SetTransformArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetTransformArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetTransformArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetTransformArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetTransformArray");
		}
	}

	public FRigUnit_SetTransformArray(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetTransformArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetTransformArray");
		}
	}

	static FRigUnit_SetTransformArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetTransformArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetTransformArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetTransformArray");
		FRigUnit_SetTransformArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetTransformArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetTransformArray", FRigUnit_SetTransformArray_IsValid);
	}
}
