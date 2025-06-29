using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorNegate", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorNegate
{
	private static bool FRigUnit_MathVectorNegate_IsValid;

	private static int FRigUnit_MathVectorNegate_StructSize;

	public FRigUnit_MathVectorNegate Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorNegate FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorNegate(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorNegate value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorNegate FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorNegate(nativeBuffer + arrayIndex * FRigUnit_MathVectorNegate_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorNegate value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorNegate_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorNegate_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorNegate");
		}
	}

	public FRigUnit_MathVectorNegate(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorNegate_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorNegate");
		}
	}

	static FRigUnit_MathVectorNegate()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorNegate)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorNegate));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorNegate");
		FRigUnit_MathVectorNegate_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorNegate_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorNegate", FRigUnit_MathVectorNegate_IsValid);
	}
}
