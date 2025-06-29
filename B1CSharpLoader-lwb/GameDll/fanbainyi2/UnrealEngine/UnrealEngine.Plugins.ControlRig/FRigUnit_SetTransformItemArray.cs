using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetTransformItemArray", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetTransformItemArray
{
	private static bool FRigUnit_SetTransformItemArray_IsValid;

	private static int FRigUnit_SetTransformItemArray_StructSize;

	public FRigUnit_SetTransformItemArray Copy()
	{
		return this;
	}

	public static FRigUnit_SetTransformItemArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetTransformItemArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetTransformItemArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetTransformItemArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetTransformItemArray(nativeBuffer + arrayIndex * FRigUnit_SetTransformItemArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetTransformItemArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetTransformItemArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetTransformItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetTransformItemArray");
		}
	}

	public FRigUnit_SetTransformItemArray(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetTransformItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetTransformItemArray");
		}
	}

	static FRigUnit_SetTransformItemArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetTransformItemArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetTransformItemArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetTransformItemArray");
		FRigUnit_SetTransformItemArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetTransformItemArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetTransformItemArray", FRigUnit_SetTransformItemArray_IsValid);
	}
}
