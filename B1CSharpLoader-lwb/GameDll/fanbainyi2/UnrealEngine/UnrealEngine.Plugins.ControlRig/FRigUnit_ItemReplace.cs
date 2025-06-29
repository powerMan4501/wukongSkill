using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ItemReplace", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ItemReplace
{
	private static bool FRigUnit_ItemReplace_IsValid;

	private static int FRigUnit_ItemReplace_StructSize;

	public FRigUnit_ItemReplace Copy()
	{
		return this;
	}

	public static FRigUnit_ItemReplace FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ItemReplace(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ItemReplace value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ItemReplace FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ItemReplace(nativeBuffer + arrayIndex * FRigUnit_ItemReplace_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ItemReplace value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ItemReplace_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ItemReplace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ItemReplace");
		}
	}

	public FRigUnit_ItemReplace(IntPtr nativeStruct)
	{
		if (!FRigUnit_ItemReplace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ItemReplace");
		}
	}

	static FRigUnit_ItemReplace()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ItemReplace)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ItemReplace));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ItemReplace");
		FRigUnit_ItemReplace_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ItemReplace_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ItemReplace", FRigUnit_ItemReplace_IsValid);
	}
}
