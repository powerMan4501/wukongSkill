using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_FABRIK", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_FABRIK
{
	private static bool FRigUnit_FABRIK_IsValid;

	private static int FRigUnit_FABRIK_StructSize;

	public FRigUnit_FABRIK Copy()
	{
		return this;
	}

	public static FRigUnit_FABRIK FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_FABRIK(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_FABRIK value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_FABRIK FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_FABRIK(nativeBuffer + arrayIndex * FRigUnit_FABRIK_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_FABRIK value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_FABRIK_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_FABRIK_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_FABRIK");
		}
	}

	public FRigUnit_FABRIK(IntPtr nativeStruct)
	{
		if (!FRigUnit_FABRIK_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_FABRIK");
		}
	}

	static FRigUnit_FABRIK()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_FABRIK)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_FABRIK));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_FABRIK");
		FRigUnit_FABRIK_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_FABRIK_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_FABRIK", FRigUnit_FABRIK_IsValid);
	}
}
