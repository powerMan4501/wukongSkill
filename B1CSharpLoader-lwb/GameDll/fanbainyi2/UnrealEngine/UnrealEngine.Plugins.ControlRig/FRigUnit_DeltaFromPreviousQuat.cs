using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DeltaFromPreviousQuat", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DeltaFromPreviousQuat
{
	private static bool FRigUnit_DeltaFromPreviousQuat_IsValid;

	private static int FRigUnit_DeltaFromPreviousQuat_StructSize;

	public FRigUnit_DeltaFromPreviousQuat Copy()
	{
		return this;
	}

	public static FRigUnit_DeltaFromPreviousQuat FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DeltaFromPreviousQuat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DeltaFromPreviousQuat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DeltaFromPreviousQuat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DeltaFromPreviousQuat(nativeBuffer + arrayIndex * FRigUnit_DeltaFromPreviousQuat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DeltaFromPreviousQuat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DeltaFromPreviousQuat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DeltaFromPreviousQuat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DeltaFromPreviousQuat");
		}
	}

	public FRigUnit_DeltaFromPreviousQuat(IntPtr nativeStruct)
	{
		if (!FRigUnit_DeltaFromPreviousQuat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DeltaFromPreviousQuat");
		}
	}

	static FRigUnit_DeltaFromPreviousQuat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DeltaFromPreviousQuat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DeltaFromPreviousQuat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DeltaFromPreviousQuat");
		FRigUnit_DeltaFromPreviousQuat_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DeltaFromPreviousQuat_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DeltaFromPreviousQuat", FRigUnit_DeltaFromPreviousQuat_IsValid);
	}
}
