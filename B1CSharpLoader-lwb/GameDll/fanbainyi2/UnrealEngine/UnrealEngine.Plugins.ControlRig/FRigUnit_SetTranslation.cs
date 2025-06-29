using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetTranslation", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetTranslation
{
	private static bool FRigUnit_SetTranslation_IsValid;

	private static int FRigUnit_SetTranslation_StructSize;

	public FRigUnit_SetTranslation Copy()
	{
		return this;
	}

	public static FRigUnit_SetTranslation FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetTranslation(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetTranslation value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetTranslation FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetTranslation(nativeBuffer + arrayIndex * FRigUnit_SetTranslation_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetTranslation value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetTranslation_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetTranslation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetTranslation");
		}
	}

	public FRigUnit_SetTranslation(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetTranslation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetTranslation");
		}
	}

	static FRigUnit_SetTranslation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetTranslation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetTranslation));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetTranslation");
		FRigUnit_SetTranslation_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetTranslation_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetTranslation", FRigUnit_SetTranslation_IsValid);
	}
}
