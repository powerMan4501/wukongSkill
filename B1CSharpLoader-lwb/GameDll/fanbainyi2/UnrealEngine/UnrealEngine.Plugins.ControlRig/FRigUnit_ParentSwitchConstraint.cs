using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ParentSwitchConstraint", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ParentSwitchConstraint
{
	private static bool FRigUnit_ParentSwitchConstraint_IsValid;

	private static int FRigUnit_ParentSwitchConstraint_StructSize;

	public FRigUnit_ParentSwitchConstraint Copy()
	{
		return this;
	}

	public static FRigUnit_ParentSwitchConstraint FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ParentSwitchConstraint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ParentSwitchConstraint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ParentSwitchConstraint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ParentSwitchConstraint(nativeBuffer + arrayIndex * FRigUnit_ParentSwitchConstraint_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ParentSwitchConstraint value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ParentSwitchConstraint_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ParentSwitchConstraint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ParentSwitchConstraint");
		}
	}

	public FRigUnit_ParentSwitchConstraint(IntPtr nativeStruct)
	{
		if (!FRigUnit_ParentSwitchConstraint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ParentSwitchConstraint");
		}
	}

	static FRigUnit_ParentSwitchConstraint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ParentSwitchConstraint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ParentSwitchConstraint));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ParentSwitchConstraint");
		FRigUnit_ParentSwitchConstraint_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ParentSwitchConstraint_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ParentSwitchConstraint", FRigUnit_ParentSwitchConstraint_IsValid);
	}
}
