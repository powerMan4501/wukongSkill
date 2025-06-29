using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigSpline;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRigSpline.RigUnit_ControlRigSplineFromPoints", "ControlRigSpline", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ControlRigSplineFromPoints
{
	private static bool FRigUnit_ControlRigSplineFromPoints_IsValid;

	private static int FRigUnit_ControlRigSplineFromPoints_StructSize;

	public FRigUnit_ControlRigSplineFromPoints Copy()
	{
		return this;
	}

	public static FRigUnit_ControlRigSplineFromPoints FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ControlRigSplineFromPoints(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ControlRigSplineFromPoints value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ControlRigSplineFromPoints FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ControlRigSplineFromPoints(nativeBuffer + arrayIndex * FRigUnit_ControlRigSplineFromPoints_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ControlRigSplineFromPoints value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ControlRigSplineFromPoints_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ControlRigSplineFromPoints_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_ControlRigSplineFromPoints");
		}
	}

	public FRigUnit_ControlRigSplineFromPoints(IntPtr nativeStruct)
	{
		if (!FRigUnit_ControlRigSplineFromPoints_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_ControlRigSplineFromPoints");
		}
	}

	static FRigUnit_ControlRigSplineFromPoints()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ControlRigSplineFromPoints)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ControlRigSplineFromPoints));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRigSpline.RigUnit_ControlRigSplineFromPoints");
		FRigUnit_ControlRigSplineFromPoints_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ControlRigSplineFromPoints_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRigSpline.RigUnit_ControlRigSplineFromPoints", FRigUnit_ControlRigSplineFromPoints_IsValid);
	}
}
