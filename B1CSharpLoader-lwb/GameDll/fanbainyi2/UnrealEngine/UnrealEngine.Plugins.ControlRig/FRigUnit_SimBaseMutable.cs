using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SimBaseMutable", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SimBaseMutable
{
	private static bool FRigUnit_SimBaseMutable_IsValid;

	private static int FRigUnit_SimBaseMutable_StructSize;

	public FRigUnit_SimBaseMutable Copy()
	{
		return this;
	}

	public static FRigUnit_SimBaseMutable FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SimBaseMutable(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SimBaseMutable value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SimBaseMutable FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SimBaseMutable(nativeBuffer + arrayIndex * FRigUnit_SimBaseMutable_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SimBaseMutable value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SimBaseMutable_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SimBaseMutable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SimBaseMutable");
		}
	}

	public FRigUnit_SimBaseMutable(IntPtr nativeStruct)
	{
		if (!FRigUnit_SimBaseMutable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SimBaseMutable");
		}
	}

	static FRigUnit_SimBaseMutable()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SimBaseMutable)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SimBaseMutable));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SimBaseMutable");
		FRigUnit_SimBaseMutable_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SimBaseMutable_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SimBaseMutable", FRigUnit_SimBaseMutable_IsValid);
	}
}
