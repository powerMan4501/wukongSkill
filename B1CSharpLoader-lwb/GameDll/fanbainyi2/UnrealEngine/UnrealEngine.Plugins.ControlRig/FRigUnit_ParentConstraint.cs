using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ParentConstraint", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ParentConstraint
{
	private static bool FRigUnit_ParentConstraint_IsValid;

	private static int FRigUnit_ParentConstraint_StructSize;

	public FRigUnit_ParentConstraint Copy()
	{
		return this;
	}

	public static FRigUnit_ParentConstraint FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ParentConstraint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ParentConstraint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ParentConstraint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ParentConstraint(nativeBuffer + arrayIndex * FRigUnit_ParentConstraint_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ParentConstraint value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ParentConstraint_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ParentConstraint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ParentConstraint");
		}
	}

	public FRigUnit_ParentConstraint(IntPtr nativeStruct)
	{
		if (!FRigUnit_ParentConstraint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ParentConstraint");
		}
	}

	static FRigUnit_ParentConstraint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ParentConstraint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ParentConstraint));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ParentConstraint");
		FRigUnit_ParentConstraint_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ParentConstraint_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ParentConstraint", FRigUnit_ParentConstraint_IsValid);
	}
}
