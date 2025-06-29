using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigControlValueStorage", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigControlValueStorage
{
	private static bool FRigControlValueStorage_IsValid;

	private static int FRigControlValueStorage_StructSize;

	public FRigControlValueStorage Copy()
	{
		return this;
	}

	public static FRigControlValueStorage FromNative(IntPtr nativeBuffer)
	{
		return new FRigControlValueStorage(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigControlValueStorage value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigControlValueStorage FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigControlValueStorage(nativeBuffer + arrayIndex * FRigControlValueStorage_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigControlValueStorage value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigControlValueStorage_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigControlValueStorage_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigControlValueStorage");
		}
	}

	public FRigControlValueStorage(IntPtr nativeStruct)
	{
		if (!FRigControlValueStorage_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigControlValueStorage");
		}
	}

	static FRigControlValueStorage()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigControlValueStorage)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigControlValueStorage));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigControlValueStorage");
		FRigControlValueStorage_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigControlValueStorage_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigControlValueStorage", FRigControlValueStorage_IsValid);
	}
}
