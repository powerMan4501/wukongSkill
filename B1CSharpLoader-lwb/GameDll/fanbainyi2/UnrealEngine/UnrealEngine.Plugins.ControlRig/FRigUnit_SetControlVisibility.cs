using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetControlVisibility", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetControlVisibility
{
	private static bool FRigUnit_SetControlVisibility_IsValid;

	private static int FRigUnit_SetControlVisibility_StructSize;

	public FRigUnit_SetControlVisibility Copy()
	{
		return this;
	}

	public static FRigUnit_SetControlVisibility FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetControlVisibility(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetControlVisibility value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetControlVisibility FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetControlVisibility(nativeBuffer + arrayIndex * FRigUnit_SetControlVisibility_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetControlVisibility value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetControlVisibility_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetControlVisibility_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetControlVisibility");
		}
	}

	public FRigUnit_SetControlVisibility(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetControlVisibility_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetControlVisibility");
		}
	}

	static FRigUnit_SetControlVisibility()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetControlVisibility)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetControlVisibility));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetControlVisibility");
		FRigUnit_SetControlVisibility_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetControlVisibility_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetControlVisibility", FRigUnit_SetControlVisibility_IsValid);
	}
}
