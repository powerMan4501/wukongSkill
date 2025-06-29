using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_AccumulateFloatLerp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_AccumulateFloatLerp
{
	private static bool FRigUnit_AccumulateFloatLerp_IsValid;

	private static int FRigUnit_AccumulateFloatLerp_StructSize;

	public FRigUnit_AccumulateFloatLerp Copy()
	{
		return this;
	}

	public static FRigUnit_AccumulateFloatLerp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_AccumulateFloatLerp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_AccumulateFloatLerp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_AccumulateFloatLerp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_AccumulateFloatLerp(nativeBuffer + arrayIndex * FRigUnit_AccumulateFloatLerp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_AccumulateFloatLerp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_AccumulateFloatLerp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_AccumulateFloatLerp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AccumulateFloatLerp");
		}
	}

	public FRigUnit_AccumulateFloatLerp(IntPtr nativeStruct)
	{
		if (!FRigUnit_AccumulateFloatLerp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AccumulateFloatLerp");
		}
	}

	static FRigUnit_AccumulateFloatLerp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_AccumulateFloatLerp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_AccumulateFloatLerp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_AccumulateFloatLerp");
		FRigUnit_AccumulateFloatLerp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_AccumulateFloatLerp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_AccumulateFloatLerp", FRigUnit_AccumulateFloatLerp_IsValid);
	}
}
