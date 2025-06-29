using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigSpline;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRigSpline.ControlRigSpline", "ControlRigSpline", UnrealModuleType.EnginePlugin)]
public struct FControlRigSpline
{
	private static bool FControlRigSpline_IsValid;

	private static int FControlRigSpline_StructSize;

	public FControlRigSpline Copy()
	{
		return this;
	}

	public static FControlRigSpline FromNative(IntPtr nativeBuffer)
	{
		return new FControlRigSpline(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FControlRigSpline value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FControlRigSpline FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FControlRigSpline(nativeBuffer + arrayIndex * FControlRigSpline_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FControlRigSpline value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FControlRigSpline_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FControlRigSpline_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.ControlRigSpline");
		}
	}

	public FControlRigSpline(IntPtr nativeStruct)
	{
		if (!FControlRigSpline_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.ControlRigSpline");
		}
	}

	static FControlRigSpline()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FControlRigSpline)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FControlRigSpline));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRigSpline.ControlRigSpline");
		FControlRigSpline_StructSize = NativeReflection.GetStructSize(intPtr);
		FControlRigSpline_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRigSpline.ControlRigSpline", FControlRigSpline_IsValid);
	}
}
