using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorLengthSquared", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorLengthSquared
{
	private static bool FRigUnit_MathVectorLengthSquared_IsValid;

	private static int FRigUnit_MathVectorLengthSquared_StructSize;

	public FRigUnit_MathVectorLengthSquared Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorLengthSquared FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorLengthSquared(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorLengthSquared value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorLengthSquared FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorLengthSquared(nativeBuffer + arrayIndex * FRigUnit_MathVectorLengthSquared_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorLengthSquared value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorLengthSquared_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorLengthSquared_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorLengthSquared");
		}
	}

	public FRigUnit_MathVectorLengthSquared(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorLengthSquared_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorLengthSquared");
		}
	}

	static FRigUnit_MathVectorLengthSquared()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorLengthSquared)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorLengthSquared));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorLengthSquared");
		FRigUnit_MathVectorLengthSquared_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorLengthSquared_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorLengthSquared", FRigUnit_MathVectorLengthSquared_IsValid);
	}
}
