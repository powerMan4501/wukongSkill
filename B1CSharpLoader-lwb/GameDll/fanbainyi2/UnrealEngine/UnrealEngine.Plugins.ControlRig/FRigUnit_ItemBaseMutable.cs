using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ItemBaseMutable", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ItemBaseMutable
{
	private static bool FRigUnit_ItemBaseMutable_IsValid;

	private static int FRigUnit_ItemBaseMutable_StructSize;

	public FRigUnit_ItemBaseMutable Copy()
	{
		return this;
	}

	public static FRigUnit_ItemBaseMutable FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ItemBaseMutable(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ItemBaseMutable value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ItemBaseMutable FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ItemBaseMutable(nativeBuffer + arrayIndex * FRigUnit_ItemBaseMutable_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ItemBaseMutable value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ItemBaseMutable_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ItemBaseMutable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ItemBaseMutable");
		}
	}

	public FRigUnit_ItemBaseMutable(IntPtr nativeStruct)
	{
		if (!FRigUnit_ItemBaseMutable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ItemBaseMutable");
		}
	}

	static FRigUnit_ItemBaseMutable()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ItemBaseMutable)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ItemBaseMutable));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ItemBaseMutable");
		FRigUnit_ItemBaseMutable_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ItemBaseMutable_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ItemBaseMutable", FRigUnit_ItemBaseMutable_IsValid);
	}
}
