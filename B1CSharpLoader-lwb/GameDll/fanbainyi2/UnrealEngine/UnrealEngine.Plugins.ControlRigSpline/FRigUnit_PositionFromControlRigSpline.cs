using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigSpline;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRigSpline.RigUnit_PositionFromControlRigSpline", "ControlRigSpline", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_PositionFromControlRigSpline
{
	private static bool FRigUnit_PositionFromControlRigSpline_IsValid;

	private static int FRigUnit_PositionFromControlRigSpline_StructSize;

	public FRigUnit_PositionFromControlRigSpline Copy()
	{
		return this;
	}

	public static FRigUnit_PositionFromControlRigSpline FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_PositionFromControlRigSpline(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_PositionFromControlRigSpline value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_PositionFromControlRigSpline FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_PositionFromControlRigSpline(nativeBuffer + arrayIndex * FRigUnit_PositionFromControlRigSpline_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_PositionFromControlRigSpline value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_PositionFromControlRigSpline_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_PositionFromControlRigSpline_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_PositionFromControlRigSpline");
		}
	}

	public FRigUnit_PositionFromControlRigSpline(IntPtr nativeStruct)
	{
		if (!FRigUnit_PositionFromControlRigSpline_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_PositionFromControlRigSpline");
		}
	}

	static FRigUnit_PositionFromControlRigSpline()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_PositionFromControlRigSpline)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_PositionFromControlRigSpline));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRigSpline.RigUnit_PositionFromControlRigSpline");
		FRigUnit_PositionFromControlRigSpline_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_PositionFromControlRigSpline_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRigSpline.RigUnit_PositionFromControlRigSpline", FRigUnit_PositionFromControlRigSpline_IsValid);
	}
}
