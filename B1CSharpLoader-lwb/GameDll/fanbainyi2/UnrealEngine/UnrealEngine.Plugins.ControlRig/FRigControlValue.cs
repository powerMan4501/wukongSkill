using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigControlValue", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigControlValue
{
	private static bool FRigControlValue_IsValid;

	private static int FRigControlValue_StructSize;

	public FRigControlValue Copy()
	{
		return this;
	}

	public static FRigControlValue FromNative(IntPtr nativeBuffer)
	{
		return new FRigControlValue(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigControlValue value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigControlValue FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigControlValue(nativeBuffer + arrayIndex * FRigControlValue_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigControlValue value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigControlValue_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigControlValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigControlValue");
		}
	}

	public FRigControlValue(IntPtr nativeStruct)
	{
		if (!FRigControlValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigControlValue");
		}
	}

	static FRigControlValue()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigControlValue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigControlValue));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigControlValue");
		FRigControlValue_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigControlValue_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigControlValue", FRigControlValue_IsValid);
	}
}
