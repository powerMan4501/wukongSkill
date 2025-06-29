using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SimBase", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SimBase
{
	private static bool FRigUnit_SimBase_IsValid;

	private static int FRigUnit_SimBase_StructSize;

	public FRigUnit_SimBase Copy()
	{
		return this;
	}

	public static FRigUnit_SimBase FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SimBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SimBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SimBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SimBase(nativeBuffer + arrayIndex * FRigUnit_SimBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SimBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SimBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SimBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SimBase");
		}
	}

	public FRigUnit_SimBase(IntPtr nativeStruct)
	{
		if (!FRigUnit_SimBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SimBase");
		}
	}

	static FRigUnit_SimBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SimBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SimBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SimBase");
		FRigUnit_SimBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SimBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SimBase", FRigUnit_SimBase_IsValid);
	}
}
