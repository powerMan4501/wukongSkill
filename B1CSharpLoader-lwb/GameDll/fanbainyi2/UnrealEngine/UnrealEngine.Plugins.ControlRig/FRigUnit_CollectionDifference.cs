using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_CollectionDifference", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_CollectionDifference
{
	private static bool FRigUnit_CollectionDifference_IsValid;

	private static int FRigUnit_CollectionDifference_StructSize;

	public FRigUnit_CollectionDifference Copy()
	{
		return this;
	}

	public static FRigUnit_CollectionDifference FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_CollectionDifference(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_CollectionDifference value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_CollectionDifference FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_CollectionDifference(nativeBuffer + arrayIndex * FRigUnit_CollectionDifference_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_CollectionDifference value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_CollectionDifference_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionDifference_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionDifference");
		}
	}

	public FRigUnit_CollectionDifference(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionDifference_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionDifference");
		}
	}

	static FRigUnit_CollectionDifference()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_CollectionDifference)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_CollectionDifference));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_CollectionDifference");
		FRigUnit_CollectionDifference_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_CollectionDifference_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_CollectionDifference", FRigUnit_CollectionDifference_IsValid);
	}
}
