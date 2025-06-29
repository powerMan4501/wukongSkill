using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DeltaFromPreviousFloat", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DeltaFromPreviousFloat
{
	private static bool FRigUnit_DeltaFromPreviousFloat_IsValid;

	private static int FRigUnit_DeltaFromPreviousFloat_StructSize;

	public FRigUnit_DeltaFromPreviousFloat Copy()
	{
		return this;
	}

	public static FRigUnit_DeltaFromPreviousFloat FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DeltaFromPreviousFloat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DeltaFromPreviousFloat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DeltaFromPreviousFloat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DeltaFromPreviousFloat(nativeBuffer + arrayIndex * FRigUnit_DeltaFromPreviousFloat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DeltaFromPreviousFloat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DeltaFromPreviousFloat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DeltaFromPreviousFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DeltaFromPreviousFloat");
		}
	}

	public FRigUnit_DeltaFromPreviousFloat(IntPtr nativeStruct)
	{
		if (!FRigUnit_DeltaFromPreviousFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DeltaFromPreviousFloat");
		}
	}

	static FRigUnit_DeltaFromPreviousFloat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DeltaFromPreviousFloat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DeltaFromPreviousFloat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DeltaFromPreviousFloat");
		FRigUnit_DeltaFromPreviousFloat_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DeltaFromPreviousFloat_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DeltaFromPreviousFloat", FRigUnit_DeltaFromPreviousFloat_IsValid);
	}
}
