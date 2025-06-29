using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ItemExists", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ItemExists
{
	private static bool FRigUnit_ItemExists_IsValid;

	private static int FRigUnit_ItemExists_StructSize;

	public FRigUnit_ItemExists Copy()
	{
		return this;
	}

	public static FRigUnit_ItemExists FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ItemExists(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ItemExists value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ItemExists FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ItemExists(nativeBuffer + arrayIndex * FRigUnit_ItemExists_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ItemExists value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ItemExists_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ItemExists_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ItemExists");
		}
	}

	public FRigUnit_ItemExists(IntPtr nativeStruct)
	{
		if (!FRigUnit_ItemExists_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ItemExists");
		}
	}

	static FRigUnit_ItemExists()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ItemExists)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ItemExists));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ItemExists");
		FRigUnit_ItemExists_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ItemExists_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ItemExists", FRigUnit_ItemExists_IsValid);
	}
}
