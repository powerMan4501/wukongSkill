using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SwitchParent", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SwitchParent
{
	private static bool FRigUnit_SwitchParent_IsValid;

	private static int FRigUnit_SwitchParent_StructSize;

	public FRigUnit_SwitchParent Copy()
	{
		return this;
	}

	public static FRigUnit_SwitchParent FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SwitchParent(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SwitchParent value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SwitchParent FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SwitchParent(nativeBuffer + arrayIndex * FRigUnit_SwitchParent_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SwitchParent value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SwitchParent_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SwitchParent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SwitchParent");
		}
	}

	public FRigUnit_SwitchParent(IntPtr nativeStruct)
	{
		if (!FRigUnit_SwitchParent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SwitchParent");
		}
	}

	static FRigUnit_SwitchParent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SwitchParent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SwitchParent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SwitchParent");
		FRigUnit_SwitchParent_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SwitchParent_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SwitchParent", FRigUnit_SwitchParent_IsValid);
	}
}
