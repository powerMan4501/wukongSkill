using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DistributeRotationForCollection", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DistributeRotationForCollection
{
	private static bool FRigUnit_DistributeRotationForCollection_IsValid;

	private static int FRigUnit_DistributeRotationForCollection_StructSize;

	public FRigUnit_DistributeRotationForCollection Copy()
	{
		return this;
	}

	public static FRigUnit_DistributeRotationForCollection FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DistributeRotationForCollection(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DistributeRotationForCollection value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DistributeRotationForCollection FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DistributeRotationForCollection(nativeBuffer + arrayIndex * FRigUnit_DistributeRotationForCollection_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DistributeRotationForCollection value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DistributeRotationForCollection_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DistributeRotationForCollection_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DistributeRotationForCollection");
		}
	}

	public FRigUnit_DistributeRotationForCollection(IntPtr nativeStruct)
	{
		if (!FRigUnit_DistributeRotationForCollection_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DistributeRotationForCollection");
		}
	}

	static FRigUnit_DistributeRotationForCollection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DistributeRotationForCollection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DistributeRotationForCollection));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DistributeRotationForCollection");
		FRigUnit_DistributeRotationForCollection_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DistributeRotationForCollection_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DistributeRotationForCollection", FRigUnit_DistributeRotationForCollection_IsValid);
	}
}
