using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ConvertTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ConvertTransform
{
	private static bool FRigUnit_ConvertTransform_IsValid;

	private static int FRigUnit_ConvertTransform_StructSize;

	public FRigUnit_ConvertTransform Copy()
	{
		return this;
	}

	public static FRigUnit_ConvertTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ConvertTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ConvertTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ConvertTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ConvertTransform(nativeBuffer + arrayIndex * FRigUnit_ConvertTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ConvertTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ConvertTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ConvertTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ConvertTransform");
		}
	}

	public FRigUnit_ConvertTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_ConvertTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ConvertTransform");
		}
	}

	static FRigUnit_ConvertTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ConvertTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ConvertTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ConvertTransform");
		FRigUnit_ConvertTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ConvertTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ConvertTransform", FRigUnit_ConvertTransform_IsValid);
	}
}
