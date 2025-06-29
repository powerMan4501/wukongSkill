using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigSpline;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRigSpline.RigUnit_TransformFromControlRigSpline", "ControlRigSpline", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_TransformFromControlRigSpline
{
	private static bool FRigUnit_TransformFromControlRigSpline_IsValid;

	private static int FRigUnit_TransformFromControlRigSpline_StructSize;

	public FRigUnit_TransformFromControlRigSpline Copy()
	{
		return this;
	}

	public static FRigUnit_TransformFromControlRigSpline FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_TransformFromControlRigSpline(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_TransformFromControlRigSpline value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_TransformFromControlRigSpline FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_TransformFromControlRigSpline(nativeBuffer + arrayIndex * FRigUnit_TransformFromControlRigSpline_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_TransformFromControlRigSpline value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_TransformFromControlRigSpline_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_TransformFromControlRigSpline_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_TransformFromControlRigSpline");
		}
	}

	public FRigUnit_TransformFromControlRigSpline(IntPtr nativeStruct)
	{
		if (!FRigUnit_TransformFromControlRigSpline_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_TransformFromControlRigSpline");
		}
	}

	static FRigUnit_TransformFromControlRigSpline()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_TransformFromControlRigSpline)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_TransformFromControlRigSpline));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRigSpline.RigUnit_TransformFromControlRigSpline");
		FRigUnit_TransformFromControlRigSpline_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_TransformFromControlRigSpline_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRigSpline.RigUnit_TransformFromControlRigSpline", FRigUnit_TransformFromControlRigSpline_IsValid);
	}
}
