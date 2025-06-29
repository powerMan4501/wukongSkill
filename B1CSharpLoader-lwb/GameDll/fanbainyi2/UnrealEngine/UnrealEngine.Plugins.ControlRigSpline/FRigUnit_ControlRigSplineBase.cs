using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigSpline;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRigSpline.RigUnit_ControlRigSplineBase", "ControlRigSpline", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ControlRigSplineBase
{
	private static bool FRigUnit_ControlRigSplineBase_IsValid;

	private static int FRigUnit_ControlRigSplineBase_StructSize;

	public FRigUnit_ControlRigSplineBase Copy()
	{
		return this;
	}

	public static FRigUnit_ControlRigSplineBase FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ControlRigSplineBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ControlRigSplineBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ControlRigSplineBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ControlRigSplineBase(nativeBuffer + arrayIndex * FRigUnit_ControlRigSplineBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ControlRigSplineBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ControlRigSplineBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ControlRigSplineBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_ControlRigSplineBase");
		}
	}

	public FRigUnit_ControlRigSplineBase(IntPtr nativeStruct)
	{
		if (!FRigUnit_ControlRigSplineBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_ControlRigSplineBase");
		}
	}

	static FRigUnit_ControlRigSplineBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ControlRigSplineBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ControlRigSplineBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRigSpline.RigUnit_ControlRigSplineBase");
		FRigUnit_ControlRigSplineBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ControlRigSplineBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRigSpline.RigUnit_ControlRigSplineBase", FRigUnit_ControlRigSplineBase_IsValid);
	}
}
