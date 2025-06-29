using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_NameBase", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_NameBase
{
	private static bool FRigUnit_NameBase_IsValid;

	private static int FRigUnit_NameBase_StructSize;

	public FRigUnit_NameBase Copy()
	{
		return this;
	}

	public static FRigUnit_NameBase FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_NameBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_NameBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_NameBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_NameBase(nativeBuffer + arrayIndex * FRigUnit_NameBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_NameBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_NameBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_NameBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_NameBase");
		}
	}

	public FRigUnit_NameBase(IntPtr nativeStruct)
	{
		if (!FRigUnit_NameBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_NameBase");
		}
	}

	static FRigUnit_NameBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_NameBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_NameBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_NameBase");
		FRigUnit_NameBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_NameBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_NameBase", FRigUnit_NameBase_IsValid);
	}
}
