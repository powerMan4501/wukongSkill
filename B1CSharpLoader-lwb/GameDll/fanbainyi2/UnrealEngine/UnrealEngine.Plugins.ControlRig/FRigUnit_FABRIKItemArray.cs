using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_FABRIKItemArray", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_FABRIKItemArray
{
	private static bool FRigUnit_FABRIKItemArray_IsValid;

	private static int FRigUnit_FABRIKItemArray_StructSize;

	public FRigUnit_FABRIKItemArray Copy()
	{
		return this;
	}

	public static FRigUnit_FABRIKItemArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_FABRIKItemArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_FABRIKItemArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_FABRIKItemArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_FABRIKItemArray(nativeBuffer + arrayIndex * FRigUnit_FABRIKItemArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_FABRIKItemArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_FABRIKItemArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_FABRIKItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_FABRIKItemArray");
		}
	}

	public FRigUnit_FABRIKItemArray(IntPtr nativeStruct)
	{
		if (!FRigUnit_FABRIKItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_FABRIKItemArray");
		}
	}

	static FRigUnit_FABRIKItemArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_FABRIKItemArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_FABRIKItemArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_FABRIKItemArray");
		FRigUnit_FABRIKItemArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_FABRIKItemArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_FABRIKItemArray", FRigUnit_FABRIKItemArray_IsValid);
	}
}
