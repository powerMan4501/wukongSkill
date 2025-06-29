using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ParentSwitchConstraintArray", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ParentSwitchConstraintArray
{
	private static bool FRigUnit_ParentSwitchConstraintArray_IsValid;

	private static int FRigUnit_ParentSwitchConstraintArray_StructSize;

	public FRigUnit_ParentSwitchConstraintArray Copy()
	{
		return this;
	}

	public static FRigUnit_ParentSwitchConstraintArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ParentSwitchConstraintArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ParentSwitchConstraintArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ParentSwitchConstraintArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ParentSwitchConstraintArray(nativeBuffer + arrayIndex * FRigUnit_ParentSwitchConstraintArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ParentSwitchConstraintArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ParentSwitchConstraintArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ParentSwitchConstraintArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ParentSwitchConstraintArray");
		}
	}

	public FRigUnit_ParentSwitchConstraintArray(IntPtr nativeStruct)
	{
		if (!FRigUnit_ParentSwitchConstraintArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ParentSwitchConstraintArray");
		}
	}

	static FRigUnit_ParentSwitchConstraintArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ParentSwitchConstraintArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ParentSwitchConstraintArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ParentSwitchConstraintArray");
		FRigUnit_ParentSwitchConstraintArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ParentSwitchConstraintArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ParentSwitchConstraintArray", FRigUnit_ParentSwitchConstraintArray_IsValid);
	}
}
