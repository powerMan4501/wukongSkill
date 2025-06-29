using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_Timeline", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_Timeline
{
	private static bool FRigUnit_Timeline_IsValid;

	private static int FRigUnit_Timeline_StructSize;

	public FRigUnit_Timeline Copy()
	{
		return this;
	}

	public static FRigUnit_Timeline FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_Timeline(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_Timeline value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_Timeline FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_Timeline(nativeBuffer + arrayIndex * FRigUnit_Timeline_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_Timeline value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_Timeline_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_Timeline_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Timeline");
		}
	}

	public FRigUnit_Timeline(IntPtr nativeStruct)
	{
		if (!FRigUnit_Timeline_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Timeline");
		}
	}

	static FRigUnit_Timeline()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_Timeline)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_Timeline));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_Timeline");
		FRigUnit_Timeline_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_Timeline_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_Timeline", FRigUnit_Timeline_IsValid);
	}
}
