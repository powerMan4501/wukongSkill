using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_AccumulateBase", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_AccumulateBase
{
	private static bool FRigUnit_AccumulateBase_IsValid;

	private static int FRigUnit_AccumulateBase_StructSize;

	public FRigUnit_AccumulateBase Copy()
	{
		return this;
	}

	public static FRigUnit_AccumulateBase FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_AccumulateBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_AccumulateBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_AccumulateBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_AccumulateBase(nativeBuffer + arrayIndex * FRigUnit_AccumulateBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_AccumulateBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_AccumulateBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_AccumulateBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AccumulateBase");
		}
	}

	public FRigUnit_AccumulateBase(IntPtr nativeStruct)
	{
		if (!FRigUnit_AccumulateBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AccumulateBase");
		}
	}

	static FRigUnit_AccumulateBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_AccumulateBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_AccumulateBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_AccumulateBase");
		FRigUnit_AccumulateBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_AccumulateBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_AccumulateBase", FRigUnit_AccumulateBase_IsValid);
	}
}
