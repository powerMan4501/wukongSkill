using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigSpline;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRigSpline.RigUnit_DrawControlRigSpline", "ControlRigSpline", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DrawControlRigSpline
{
	private static bool FRigUnit_DrawControlRigSpline_IsValid;

	private static int FRigUnit_DrawControlRigSpline_StructSize;

	public FRigUnit_DrawControlRigSpline Copy()
	{
		return this;
	}

	public static FRigUnit_DrawControlRigSpline FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DrawControlRigSpline(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DrawControlRigSpline value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DrawControlRigSpline FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DrawControlRigSpline(nativeBuffer + arrayIndex * FRigUnit_DrawControlRigSpline_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DrawControlRigSpline value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DrawControlRigSpline_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DrawControlRigSpline_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_DrawControlRigSpline");
		}
	}

	public FRigUnit_DrawControlRigSpline(IntPtr nativeStruct)
	{
		if (!FRigUnit_DrawControlRigSpline_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_DrawControlRigSpline");
		}
	}

	static FRigUnit_DrawControlRigSpline()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DrawControlRigSpline)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DrawControlRigSpline));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRigSpline.RigUnit_DrawControlRigSpline");
		FRigUnit_DrawControlRigSpline_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DrawControlRigSpline_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRigSpline.RigUnit_DrawControlRigSpline", FRigUnit_DrawControlRigSpline_IsValid);
	}
}
