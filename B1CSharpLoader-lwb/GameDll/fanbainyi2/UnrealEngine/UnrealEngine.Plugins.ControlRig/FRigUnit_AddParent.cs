using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_AddParent", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_AddParent
{
	private static bool FRigUnit_AddParent_IsValid;

	private static int FRigUnit_AddParent_StructSize;

	public FRigUnit_AddParent Copy()
	{
		return this;
	}

	public static FRigUnit_AddParent FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_AddParent(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_AddParent value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_AddParent FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_AddParent(nativeBuffer + arrayIndex * FRigUnit_AddParent_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_AddParent value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_AddParent_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_AddParent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AddParent");
		}
	}

	public FRigUnit_AddParent(IntPtr nativeStruct)
	{
		if (!FRigUnit_AddParent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AddParent");
		}
	}

	static FRigUnit_AddParent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_AddParent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_AddParent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_AddParent");
		FRigUnit_AddParent_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_AddParent_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_AddParent", FRigUnit_AddParent_IsValid);
	}
}
