using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_GetControlFloat", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_GetControlFloat
{
	private static bool FRigUnit_GetControlFloat_IsValid;

	private static int FRigUnit_GetControlFloat_StructSize;

	public FRigUnit_GetControlFloat Copy()
	{
		return this;
	}

	public static FRigUnit_GetControlFloat FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_GetControlFloat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_GetControlFloat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_GetControlFloat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_GetControlFloat(nativeBuffer + arrayIndex * FRigUnit_GetControlFloat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_GetControlFloat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_GetControlFloat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetControlFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetControlFloat");
		}
	}

	public FRigUnit_GetControlFloat(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetControlFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetControlFloat");
		}
	}

	static FRigUnit_GetControlFloat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_GetControlFloat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_GetControlFloat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_GetControlFloat");
		FRigUnit_GetControlFloat_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_GetControlFloat_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_GetControlFloat", FRigUnit_GetControlFloat_IsValid);
	}
}
