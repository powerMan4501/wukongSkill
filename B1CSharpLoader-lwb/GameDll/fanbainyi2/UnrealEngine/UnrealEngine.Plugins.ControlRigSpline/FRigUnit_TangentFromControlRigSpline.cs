using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigSpline;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRigSpline.RigUnit_TangentFromControlRigSpline", "ControlRigSpline", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_TangentFromControlRigSpline
{
	private static bool FRigUnit_TangentFromControlRigSpline_IsValid;

	private static int FRigUnit_TangentFromControlRigSpline_StructSize;

	public FRigUnit_TangentFromControlRigSpline Copy()
	{
		return this;
	}

	public static FRigUnit_TangentFromControlRigSpline FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_TangentFromControlRigSpline(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_TangentFromControlRigSpline value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_TangentFromControlRigSpline FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_TangentFromControlRigSpline(nativeBuffer + arrayIndex * FRigUnit_TangentFromControlRigSpline_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_TangentFromControlRigSpline value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_TangentFromControlRigSpline_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_TangentFromControlRigSpline_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_TangentFromControlRigSpline");
		}
	}

	public FRigUnit_TangentFromControlRigSpline(IntPtr nativeStruct)
	{
		if (!FRigUnit_TangentFromControlRigSpline_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_TangentFromControlRigSpline");
		}
	}

	static FRigUnit_TangentFromControlRigSpline()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_TangentFromControlRigSpline)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_TangentFromControlRigSpline));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRigSpline.RigUnit_TangentFromControlRigSpline");
		FRigUnit_TangentFromControlRigSpline_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_TangentFromControlRigSpline_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRigSpline.RigUnit_TangentFromControlRigSpline", FRigUnit_TangentFromControlRigSpline_IsValid);
	}
}
