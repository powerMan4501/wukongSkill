using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ScaleConstraint", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ScaleConstraint
{
	private static bool FRigUnit_ScaleConstraint_IsValid;

	private static int FRigUnit_ScaleConstraint_StructSize;

	public FRigUnit_ScaleConstraint Copy()
	{
		return this;
	}

	public static FRigUnit_ScaleConstraint FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ScaleConstraint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ScaleConstraint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ScaleConstraint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ScaleConstraint(nativeBuffer + arrayIndex * FRigUnit_ScaleConstraint_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ScaleConstraint value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ScaleConstraint_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ScaleConstraint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ScaleConstraint");
		}
	}

	public FRigUnit_ScaleConstraint(IntPtr nativeStruct)
	{
		if (!FRigUnit_ScaleConstraint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ScaleConstraint");
		}
	}

	static FRigUnit_ScaleConstraint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ScaleConstraint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ScaleConstraint));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ScaleConstraint");
		FRigUnit_ScaleConstraint_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ScaleConstraint_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ScaleConstraint", FRigUnit_ScaleConstraint_IsValid);
	}
}
