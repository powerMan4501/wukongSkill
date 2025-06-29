using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetRotation", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetRotation
{
	private static bool FRigUnit_SetRotation_IsValid;

	private static int FRigUnit_SetRotation_StructSize;

	public FRigUnit_SetRotation Copy()
	{
		return this;
	}

	public static FRigUnit_SetRotation FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetRotation(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetRotation value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetRotation FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetRotation(nativeBuffer + arrayIndex * FRigUnit_SetRotation_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetRotation value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetRotation_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetRotation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetRotation");
		}
	}

	public FRigUnit_SetRotation(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetRotation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetRotation");
		}
	}

	static FRigUnit_SetRotation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetRotation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetRotation));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetRotation");
		FRigUnit_SetRotation_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetRotation_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetRotation", FRigUnit_SetRotation_IsValid);
	}
}
