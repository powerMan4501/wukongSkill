using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigSpline;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRigSpline.RigUnit_GetLengthControlRigSpline", "ControlRigSpline", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_GetLengthControlRigSpline
{
	private static bool FRigUnit_GetLengthControlRigSpline_IsValid;

	private static int FRigUnit_GetLengthControlRigSpline_StructSize;

	public FRigUnit_GetLengthControlRigSpline Copy()
	{
		return this;
	}

	public static FRigUnit_GetLengthControlRigSpline FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_GetLengthControlRigSpline(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_GetLengthControlRigSpline value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_GetLengthControlRigSpline FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_GetLengthControlRigSpline(nativeBuffer + arrayIndex * FRigUnit_GetLengthControlRigSpline_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_GetLengthControlRigSpline value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_GetLengthControlRigSpline_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetLengthControlRigSpline_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_GetLengthControlRigSpline");
		}
	}

	public FRigUnit_GetLengthControlRigSpline(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetLengthControlRigSpline_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_GetLengthControlRigSpline");
		}
	}

	static FRigUnit_GetLengthControlRigSpline()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_GetLengthControlRigSpline)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_GetLengthControlRigSpline));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRigSpline.RigUnit_GetLengthControlRigSpline");
		FRigUnit_GetLengthControlRigSpline_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_GetLengthControlRigSpline_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRigSpline.RigUnit_GetLengthControlRigSpline", FRigUnit_GetLengthControlRigSpline_IsValid);
	}
}
