using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetControlFloat", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetControlFloat
{
	private static bool FRigUnit_SetControlFloat_IsValid;

	private static int FRigUnit_SetControlFloat_StructSize;

	public FRigUnit_SetControlFloat Copy()
	{
		return this;
	}

	public static FRigUnit_SetControlFloat FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetControlFloat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetControlFloat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetControlFloat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetControlFloat(nativeBuffer + arrayIndex * FRigUnit_SetControlFloat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetControlFloat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetControlFloat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetControlFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetControlFloat");
		}
	}

	public FRigUnit_SetControlFloat(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetControlFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetControlFloat");
		}
	}

	static FRigUnit_SetControlFloat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetControlFloat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetControlFloat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetControlFloat");
		FRigUnit_SetControlFloat_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetControlFloat_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetControlFloat", FRigUnit_SetControlFloat_IsValid);
	}
}
