using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MultiplyTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MultiplyTransform
{
	private static bool FRigUnit_MultiplyTransform_IsValid;

	private static int FRigUnit_MultiplyTransform_StructSize;

	public FRigUnit_MultiplyTransform Copy()
	{
		return this;
	}

	public static FRigUnit_MultiplyTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MultiplyTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MultiplyTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MultiplyTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MultiplyTransform(nativeBuffer + arrayIndex * FRigUnit_MultiplyTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MultiplyTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MultiplyTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MultiplyTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MultiplyTransform");
		}
	}

	public FRigUnit_MultiplyTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_MultiplyTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MultiplyTransform");
		}
	}

	static FRigUnit_MultiplyTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MultiplyTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MultiplyTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MultiplyTransform");
		FRigUnit_MultiplyTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MultiplyTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MultiplyTransform", FRigUnit_MultiplyTransform_IsValid);
	}
}
