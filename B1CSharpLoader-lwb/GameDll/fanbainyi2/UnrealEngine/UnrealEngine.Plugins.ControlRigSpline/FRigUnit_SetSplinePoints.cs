using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigSpline;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRigSpline.RigUnit_SetSplinePoints", "ControlRigSpline", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetSplinePoints
{
	private static bool FRigUnit_SetSplinePoints_IsValid;

	private static int FRigUnit_SetSplinePoints_StructSize;

	public FRigUnit_SetSplinePoints Copy()
	{
		return this;
	}

	public static FRigUnit_SetSplinePoints FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetSplinePoints(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetSplinePoints value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetSplinePoints FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetSplinePoints(nativeBuffer + arrayIndex * FRigUnit_SetSplinePoints_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetSplinePoints value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetSplinePoints_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetSplinePoints_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_SetSplinePoints");
		}
	}

	public FRigUnit_SetSplinePoints(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetSplinePoints_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_SetSplinePoints");
		}
	}

	static FRigUnit_SetSplinePoints()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetSplinePoints)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetSplinePoints));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRigSpline.RigUnit_SetSplinePoints");
		FRigUnit_SetSplinePoints_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetSplinePoints_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRigSpline.RigUnit_SetSplinePoints", FRigUnit_SetSplinePoints_IsValid);
	}
}
