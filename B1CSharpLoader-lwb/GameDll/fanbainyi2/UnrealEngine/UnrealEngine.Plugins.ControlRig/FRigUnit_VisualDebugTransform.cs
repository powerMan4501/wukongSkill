using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_VisualDebugTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_VisualDebugTransform
{
	private static bool FRigUnit_VisualDebugTransform_IsValid;

	private static int FRigUnit_VisualDebugTransform_StructSize;

	public FRigUnit_VisualDebugTransform Copy()
	{
		return this;
	}

	public static FRigUnit_VisualDebugTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_VisualDebugTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_VisualDebugTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_VisualDebugTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_VisualDebugTransform(nativeBuffer + arrayIndex * FRigUnit_VisualDebugTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_VisualDebugTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_VisualDebugTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_VisualDebugTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_VisualDebugTransform");
		}
	}

	public FRigUnit_VisualDebugTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_VisualDebugTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_VisualDebugTransform");
		}
	}

	static FRigUnit_VisualDebugTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_VisualDebugTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_VisualDebugTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_VisualDebugTransform");
		FRigUnit_VisualDebugTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_VisualDebugTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_VisualDebugTransform", FRigUnit_VisualDebugTransform_IsValid);
	}
}
