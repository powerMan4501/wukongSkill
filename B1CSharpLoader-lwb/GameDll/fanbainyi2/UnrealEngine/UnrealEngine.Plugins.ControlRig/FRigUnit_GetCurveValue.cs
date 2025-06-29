using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_GetCurveValue", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_GetCurveValue
{
	private static bool FRigUnit_GetCurveValue_IsValid;

	private static int FRigUnit_GetCurveValue_StructSize;

	public FRigUnit_GetCurveValue Copy()
	{
		return this;
	}

	public static FRigUnit_GetCurveValue FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_GetCurveValue(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_GetCurveValue value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_GetCurveValue FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_GetCurveValue(nativeBuffer + arrayIndex * FRigUnit_GetCurveValue_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_GetCurveValue value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_GetCurveValue_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetCurveValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetCurveValue");
		}
	}

	public FRigUnit_GetCurveValue(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetCurveValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetCurveValue");
		}
	}

	static FRigUnit_GetCurveValue()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_GetCurveValue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_GetCurveValue));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_GetCurveValue");
		FRigUnit_GetCurveValue_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_GetCurveValue_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_GetCurveValue", FRigUnit_GetCurveValue_IsValid);
	}
}
