using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetCurveValue", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetCurveValue
{
	private static bool FRigUnit_SetCurveValue_IsValid;

	private static int FRigUnit_SetCurveValue_StructSize;

	public FRigUnit_SetCurveValue Copy()
	{
		return this;
	}

	public static FRigUnit_SetCurveValue FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetCurveValue(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetCurveValue value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetCurveValue FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetCurveValue(nativeBuffer + arrayIndex * FRigUnit_SetCurveValue_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetCurveValue value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetCurveValue_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetCurveValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetCurveValue");
		}
	}

	public FRigUnit_SetCurveValue(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetCurveValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetCurveValue");
		}
	}

	static FRigUnit_SetCurveValue()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetCurveValue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetCurveValue));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetCurveValue");
		FRigUnit_SetCurveValue_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetCurveValue_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetCurveValue", FRigUnit_SetCurveValue_IsValid);
	}
}
