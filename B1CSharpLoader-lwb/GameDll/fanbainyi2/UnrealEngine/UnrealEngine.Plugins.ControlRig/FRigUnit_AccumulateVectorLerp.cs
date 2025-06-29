using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_AccumulateVectorLerp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_AccumulateVectorLerp
{
	private static bool FRigUnit_AccumulateVectorLerp_IsValid;

	private static int FRigUnit_AccumulateVectorLerp_StructSize;

	public FRigUnit_AccumulateVectorLerp Copy()
	{
		return this;
	}

	public static FRigUnit_AccumulateVectorLerp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_AccumulateVectorLerp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_AccumulateVectorLerp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_AccumulateVectorLerp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_AccumulateVectorLerp(nativeBuffer + arrayIndex * FRigUnit_AccumulateVectorLerp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_AccumulateVectorLerp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_AccumulateVectorLerp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_AccumulateVectorLerp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AccumulateVectorLerp");
		}
	}

	public FRigUnit_AccumulateVectorLerp(IntPtr nativeStruct)
	{
		if (!FRigUnit_AccumulateVectorLerp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AccumulateVectorLerp");
		}
	}

	static FRigUnit_AccumulateVectorLerp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_AccumulateVectorLerp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_AccumulateVectorLerp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_AccumulateVectorLerp");
		FRigUnit_AccumulateVectorLerp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_AccumulateVectorLerp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_AccumulateVectorLerp", FRigUnit_AccumulateVectorLerp_IsValid);
	}
}
