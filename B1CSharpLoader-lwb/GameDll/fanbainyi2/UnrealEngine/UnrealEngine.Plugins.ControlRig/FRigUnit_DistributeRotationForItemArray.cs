using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DistributeRotationForItemArray", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DistributeRotationForItemArray
{
	private static bool FRigUnit_DistributeRotationForItemArray_IsValid;

	private static int FRigUnit_DistributeRotationForItemArray_StructSize;

	public FRigUnit_DistributeRotationForItemArray Copy()
	{
		return this;
	}

	public static FRigUnit_DistributeRotationForItemArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DistributeRotationForItemArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DistributeRotationForItemArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DistributeRotationForItemArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DistributeRotationForItemArray(nativeBuffer + arrayIndex * FRigUnit_DistributeRotationForItemArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DistributeRotationForItemArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DistributeRotationForItemArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DistributeRotationForItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DistributeRotationForItemArray");
		}
	}

	public FRigUnit_DistributeRotationForItemArray(IntPtr nativeStruct)
	{
		if (!FRigUnit_DistributeRotationForItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DistributeRotationForItemArray");
		}
	}

	static FRigUnit_DistributeRotationForItemArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DistributeRotationForItemArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DistributeRotationForItemArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DistributeRotationForItemArray");
		FRigUnit_DistributeRotationForItemArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DistributeRotationForItemArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DistributeRotationForItemArray", FRigUnit_DistributeRotationForItemArray_IsValid);
	}
}
