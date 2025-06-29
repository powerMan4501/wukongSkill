using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_PropagateTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_PropagateTransform
{
	private static bool FRigUnit_PropagateTransform_IsValid;

	private static int FRigUnit_PropagateTransform_StructSize;

	public FRigUnit_PropagateTransform Copy()
	{
		return this;
	}

	public static FRigUnit_PropagateTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_PropagateTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_PropagateTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_PropagateTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_PropagateTransform(nativeBuffer + arrayIndex * FRigUnit_PropagateTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_PropagateTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_PropagateTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_PropagateTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PropagateTransform");
		}
	}

	public FRigUnit_PropagateTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_PropagateTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PropagateTransform");
		}
	}

	static FRigUnit_PropagateTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_PropagateTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_PropagateTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_PropagateTransform");
		FRigUnit_PropagateTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_PropagateTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_PropagateTransform", FRigUnit_PropagateTransform_IsValid);
	}
}
