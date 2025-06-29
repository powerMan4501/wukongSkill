using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_AccumulateQuatLerp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_AccumulateQuatLerp
{
	private static bool FRigUnit_AccumulateQuatLerp_IsValid;

	private static int FRigUnit_AccumulateQuatLerp_StructSize;

	public FRigUnit_AccumulateQuatLerp Copy()
	{
		return this;
	}

	public static FRigUnit_AccumulateQuatLerp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_AccumulateQuatLerp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_AccumulateQuatLerp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_AccumulateQuatLerp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_AccumulateQuatLerp(nativeBuffer + arrayIndex * FRigUnit_AccumulateQuatLerp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_AccumulateQuatLerp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_AccumulateQuatLerp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_AccumulateQuatLerp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AccumulateQuatLerp");
		}
	}

	public FRigUnit_AccumulateQuatLerp(IntPtr nativeStruct)
	{
		if (!FRigUnit_AccumulateQuatLerp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AccumulateQuatLerp");
		}
	}

	static FRigUnit_AccumulateQuatLerp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_AccumulateQuatLerp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_AccumulateQuatLerp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_AccumulateQuatLerp");
		FRigUnit_AccumulateQuatLerp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_AccumulateQuatLerp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_AccumulateQuatLerp", FRigUnit_AccumulateQuatLerp_IsValid);
	}
}
