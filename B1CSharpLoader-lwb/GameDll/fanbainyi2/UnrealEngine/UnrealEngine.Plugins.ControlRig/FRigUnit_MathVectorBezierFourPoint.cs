using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorBezierFourPoint", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorBezierFourPoint
{
	private static bool FRigUnit_MathVectorBezierFourPoint_IsValid;

	private static int FRigUnit_MathVectorBezierFourPoint_StructSize;

	public FRigUnit_MathVectorBezierFourPoint Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorBezierFourPoint FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorBezierFourPoint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorBezierFourPoint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorBezierFourPoint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorBezierFourPoint(nativeBuffer + arrayIndex * FRigUnit_MathVectorBezierFourPoint_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorBezierFourPoint value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorBezierFourPoint_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorBezierFourPoint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorBezierFourPoint");
		}
	}

	public FRigUnit_MathVectorBezierFourPoint(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorBezierFourPoint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorBezierFourPoint");
		}
	}

	static FRigUnit_MathVectorBezierFourPoint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorBezierFourPoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorBezierFourPoint));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorBezierFourPoint");
		FRigUnit_MathVectorBezierFourPoint_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorBezierFourPoint_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorBezierFourPoint", FRigUnit_MathVectorBezierFourPoint_IsValid);
	}
}
