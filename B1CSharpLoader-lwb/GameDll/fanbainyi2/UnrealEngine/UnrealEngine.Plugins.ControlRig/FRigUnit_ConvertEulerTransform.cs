using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ConvertEulerTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ConvertEulerTransform
{
	private static bool FRigUnit_ConvertEulerTransform_IsValid;

	private static int FRigUnit_ConvertEulerTransform_StructSize;

	public FRigUnit_ConvertEulerTransform Copy()
	{
		return this;
	}

	public static FRigUnit_ConvertEulerTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ConvertEulerTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ConvertEulerTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ConvertEulerTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ConvertEulerTransform(nativeBuffer + arrayIndex * FRigUnit_ConvertEulerTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ConvertEulerTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ConvertEulerTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ConvertEulerTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ConvertEulerTransform");
		}
	}

	public FRigUnit_ConvertEulerTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_ConvertEulerTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ConvertEulerTransform");
		}
	}

	static FRigUnit_ConvertEulerTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ConvertEulerTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ConvertEulerTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ConvertEulerTransform");
		FRigUnit_ConvertEulerTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ConvertEulerTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ConvertEulerTransform", FRigUnit_ConvertEulerTransform_IsValid);
	}
}
