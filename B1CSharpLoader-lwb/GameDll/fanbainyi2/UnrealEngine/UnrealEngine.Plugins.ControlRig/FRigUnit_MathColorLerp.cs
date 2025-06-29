using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathColorLerp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathColorLerp
{
	private static bool FRigUnit_MathColorLerp_IsValid;

	private static int FRigUnit_MathColorLerp_StructSize;

	public FRigUnit_MathColorLerp Copy()
	{
		return this;
	}

	public static FRigUnit_MathColorLerp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathColorLerp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathColorLerp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathColorLerp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathColorLerp(nativeBuffer + arrayIndex * FRigUnit_MathColorLerp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathColorLerp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathColorLerp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathColorLerp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathColorLerp");
		}
	}

	public FRigUnit_MathColorLerp(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathColorLerp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathColorLerp");
		}
	}

	static FRigUnit_MathColorLerp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathColorLerp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathColorLerp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathColorLerp");
		FRigUnit_MathColorLerp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathColorLerp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathColorLerp", FRigUnit_MathColorLerp_IsValid);
	}
}
