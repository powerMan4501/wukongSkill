using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SpaceName", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SpaceName
{
	private static bool FRigUnit_SpaceName_IsValid;

	private static int FRigUnit_SpaceName_StructSize;

	public FRigUnit_SpaceName Copy()
	{
		return this;
	}

	public static FRigUnit_SpaceName FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SpaceName(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SpaceName value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SpaceName FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SpaceName(nativeBuffer + arrayIndex * FRigUnit_SpaceName_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SpaceName value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SpaceName_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SpaceName_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SpaceName");
		}
	}

	public FRigUnit_SpaceName(IntPtr nativeStruct)
	{
		if (!FRigUnit_SpaceName_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SpaceName");
		}
	}

	static FRigUnit_SpaceName()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SpaceName)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SpaceName));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SpaceName");
		FRigUnit_SpaceName_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SpaceName_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SpaceName", FRigUnit_SpaceName_IsValid);
	}
}
