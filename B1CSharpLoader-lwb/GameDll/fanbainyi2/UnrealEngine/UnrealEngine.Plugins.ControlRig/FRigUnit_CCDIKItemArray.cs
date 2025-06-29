using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_CCDIKItemArray", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_CCDIKItemArray
{
	private static bool FRigUnit_CCDIKItemArray_IsValid;

	private static int FRigUnit_CCDIKItemArray_StructSize;

	public FRigUnit_CCDIKItemArray Copy()
	{
		return this;
	}

	public static FRigUnit_CCDIKItemArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_CCDIKItemArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_CCDIKItemArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_CCDIKItemArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_CCDIKItemArray(nativeBuffer + arrayIndex * FRigUnit_CCDIKItemArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_CCDIKItemArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_CCDIKItemArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_CCDIKItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CCDIKItemArray");
		}
	}

	public FRigUnit_CCDIKItemArray(IntPtr nativeStruct)
	{
		if (!FRigUnit_CCDIKItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CCDIKItemArray");
		}
	}

	static FRigUnit_CCDIKItemArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_CCDIKItemArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_CCDIKItemArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_CCDIKItemArray");
		FRigUnit_CCDIKItemArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_CCDIKItemArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_CCDIKItemArray", FRigUnit_CCDIKItemArray_IsValid);
	}
}
