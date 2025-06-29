using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_GetTransformItemArray", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_GetTransformItemArray
{
	private static bool FRigUnit_GetTransformItemArray_IsValid;

	private static int FRigUnit_GetTransformItemArray_StructSize;

	public FRigUnit_GetTransformItemArray Copy()
	{
		return this;
	}

	public static FRigUnit_GetTransformItemArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_GetTransformItemArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_GetTransformItemArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_GetTransformItemArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_GetTransformItemArray(nativeBuffer + arrayIndex * FRigUnit_GetTransformItemArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_GetTransformItemArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_GetTransformItemArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetTransformItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetTransformItemArray");
		}
	}

	public FRigUnit_GetTransformItemArray(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetTransformItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetTransformItemArray");
		}
	}

	static FRigUnit_GetTransformItemArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_GetTransformItemArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_GetTransformItemArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_GetTransformItemArray");
		FRigUnit_GetTransformItemArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_GetTransformItemArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_GetTransformItemArray", FRigUnit_GetTransformItemArray_IsValid);
	}
}
