using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_AnimBase", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_AnimBase
{
	private static bool FRigUnit_AnimBase_IsValid;

	private static int FRigUnit_AnimBase_StructSize;

	public FRigUnit_AnimBase Copy()
	{
		return this;
	}

	public static FRigUnit_AnimBase FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_AnimBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_AnimBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_AnimBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_AnimBase(nativeBuffer + arrayIndex * FRigUnit_AnimBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_AnimBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_AnimBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_AnimBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AnimBase");
		}
	}

	public FRigUnit_AnimBase(IntPtr nativeStruct)
	{
		if (!FRigUnit_AnimBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AnimBase");
		}
	}

	static FRigUnit_AnimBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_AnimBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_AnimBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_AnimBase");
		FRigUnit_AnimBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_AnimBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_AnimBase", FRigUnit_AnimBase_IsValid);
	}
}
