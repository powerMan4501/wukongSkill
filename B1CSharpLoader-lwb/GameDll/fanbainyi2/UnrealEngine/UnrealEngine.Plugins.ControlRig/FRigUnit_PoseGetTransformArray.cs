using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_PoseGetTransformArray", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_PoseGetTransformArray
{
	private static bool FRigUnit_PoseGetTransformArray_IsValid;

	private static int FRigUnit_PoseGetTransformArray_StructSize;

	public FRigUnit_PoseGetTransformArray Copy()
	{
		return this;
	}

	public static FRigUnit_PoseGetTransformArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_PoseGetTransformArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_PoseGetTransformArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_PoseGetTransformArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_PoseGetTransformArray(nativeBuffer + arrayIndex * FRigUnit_PoseGetTransformArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_PoseGetTransformArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_PoseGetTransformArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_PoseGetTransformArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PoseGetTransformArray");
		}
	}

	public FRigUnit_PoseGetTransformArray(IntPtr nativeStruct)
	{
		if (!FRigUnit_PoseGetTransformArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PoseGetTransformArray");
		}
	}

	static FRigUnit_PoseGetTransformArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_PoseGetTransformArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_PoseGetTransformArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_PoseGetTransformArray");
		FRigUnit_PoseGetTransformArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_PoseGetTransformArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_PoseGetTransformArray", FRigUnit_PoseGetTransformArray_IsValid);
	}
}
