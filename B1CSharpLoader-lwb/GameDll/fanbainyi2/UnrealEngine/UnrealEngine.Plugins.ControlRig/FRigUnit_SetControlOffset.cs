using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetControlOffset", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetControlOffset
{
	private static bool FRigUnit_SetControlOffset_IsValid;

	private static int FRigUnit_SetControlOffset_StructSize;

	public FRigUnit_SetControlOffset Copy()
	{
		return this;
	}

	public static FRigUnit_SetControlOffset FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetControlOffset(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetControlOffset value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetControlOffset FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetControlOffset(nativeBuffer + arrayIndex * FRigUnit_SetControlOffset_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetControlOffset value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetControlOffset_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetControlOffset_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetControlOffset");
		}
	}

	public FRigUnit_SetControlOffset(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetControlOffset_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetControlOffset");
		}
	}

	static FRigUnit_SetControlOffset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetControlOffset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetControlOffset));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetControlOffset");
		FRigUnit_SetControlOffset_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetControlOffset_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetControlOffset", FRigUnit_SetControlOffset_IsValid);
	}
}
