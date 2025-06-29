using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ScaleConstraintLocalSpaceOffset", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ScaleConstraintLocalSpaceOffset
{
	private static bool FRigUnit_ScaleConstraintLocalSpaceOffset_IsValid;

	private static int FRigUnit_ScaleConstraintLocalSpaceOffset_StructSize;

	public FRigUnit_ScaleConstraintLocalSpaceOffset Copy()
	{
		return this;
	}

	public static FRigUnit_ScaleConstraintLocalSpaceOffset FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ScaleConstraintLocalSpaceOffset(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ScaleConstraintLocalSpaceOffset value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ScaleConstraintLocalSpaceOffset FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ScaleConstraintLocalSpaceOffset(nativeBuffer + arrayIndex * FRigUnit_ScaleConstraintLocalSpaceOffset_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ScaleConstraintLocalSpaceOffset value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ScaleConstraintLocalSpaceOffset_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ScaleConstraintLocalSpaceOffset_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ScaleConstraintLocalSpaceOffset");
		}
	}

	public FRigUnit_ScaleConstraintLocalSpaceOffset(IntPtr nativeStruct)
	{
		if (!FRigUnit_ScaleConstraintLocalSpaceOffset_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ScaleConstraintLocalSpaceOffset");
		}
	}

	static FRigUnit_ScaleConstraintLocalSpaceOffset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ScaleConstraintLocalSpaceOffset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ScaleConstraintLocalSpaceOffset));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ScaleConstraintLocalSpaceOffset");
		FRigUnit_ScaleConstraintLocalSpaceOffset_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ScaleConstraintLocalSpaceOffset_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ScaleConstraintLocalSpaceOffset", FRigUnit_ScaleConstraintLocalSpaceOffset_IsValid);
	}
}
