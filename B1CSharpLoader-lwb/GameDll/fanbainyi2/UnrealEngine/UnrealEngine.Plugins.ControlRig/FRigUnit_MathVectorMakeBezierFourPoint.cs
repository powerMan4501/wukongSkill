using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorMakeBezierFourPoint", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorMakeBezierFourPoint
{
	private static bool FRigUnit_MathVectorMakeBezierFourPoint_IsValid;

	private static int FRigUnit_MathVectorMakeBezierFourPoint_StructSize;

	public FRigUnit_MathVectorMakeBezierFourPoint Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorMakeBezierFourPoint FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorMakeBezierFourPoint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorMakeBezierFourPoint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorMakeBezierFourPoint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorMakeBezierFourPoint(nativeBuffer + arrayIndex * FRigUnit_MathVectorMakeBezierFourPoint_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorMakeBezierFourPoint value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorMakeBezierFourPoint_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorMakeBezierFourPoint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorMakeBezierFourPoint");
		}
	}

	public FRigUnit_MathVectorMakeBezierFourPoint(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorMakeBezierFourPoint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorMakeBezierFourPoint");
		}
	}

	static FRigUnit_MathVectorMakeBezierFourPoint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorMakeBezierFourPoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorMakeBezierFourPoint));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorMakeBezierFourPoint");
		FRigUnit_MathVectorMakeBezierFourPoint_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorMakeBezierFourPoint_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorMakeBezierFourPoint", FRigUnit_MathVectorMakeBezierFourPoint_IsValid);
	}
}
