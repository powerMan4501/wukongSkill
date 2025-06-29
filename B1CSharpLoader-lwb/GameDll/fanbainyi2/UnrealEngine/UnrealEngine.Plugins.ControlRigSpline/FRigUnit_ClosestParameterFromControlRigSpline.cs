using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigSpline;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRigSpline.RigUnit_ClosestParameterFromControlRigSpline", "ControlRigSpline", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ClosestParameterFromControlRigSpline
{
	private static bool FRigUnit_ClosestParameterFromControlRigSpline_IsValid;

	private static int FRigUnit_ClosestParameterFromControlRigSpline_StructSize;

	public FRigUnit_ClosestParameterFromControlRigSpline Copy()
	{
		return this;
	}

	public static FRigUnit_ClosestParameterFromControlRigSpline FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ClosestParameterFromControlRigSpline(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ClosestParameterFromControlRigSpline value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ClosestParameterFromControlRigSpline FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ClosestParameterFromControlRigSpline(nativeBuffer + arrayIndex * FRigUnit_ClosestParameterFromControlRigSpline_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ClosestParameterFromControlRigSpline value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ClosestParameterFromControlRigSpline_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ClosestParameterFromControlRigSpline_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_ClosestParameterFromControlRigSpline");
		}
	}

	public FRigUnit_ClosestParameterFromControlRigSpline(IntPtr nativeStruct)
	{
		if (!FRigUnit_ClosestParameterFromControlRigSpline_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_ClosestParameterFromControlRigSpline");
		}
	}

	static FRigUnit_ClosestParameterFromControlRigSpline()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ClosestParameterFromControlRigSpline)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ClosestParameterFromControlRigSpline));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRigSpline.RigUnit_ClosestParameterFromControlRigSpline");
		FRigUnit_ClosestParameterFromControlRigSpline_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ClosestParameterFromControlRigSpline_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRigSpline.RigUnit_ClosestParameterFromControlRigSpline", FRigUnit_ClosestParameterFromControlRigSpline_IsValid);
	}
}
