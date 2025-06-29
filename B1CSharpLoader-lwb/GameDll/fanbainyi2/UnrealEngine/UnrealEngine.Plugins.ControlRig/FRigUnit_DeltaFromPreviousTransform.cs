using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DeltaFromPreviousTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DeltaFromPreviousTransform
{
	private static bool FRigUnit_DeltaFromPreviousTransform_IsValid;

	private static int FRigUnit_DeltaFromPreviousTransform_StructSize;

	public FRigUnit_DeltaFromPreviousTransform Copy()
	{
		return this;
	}

	public static FRigUnit_DeltaFromPreviousTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DeltaFromPreviousTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DeltaFromPreviousTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DeltaFromPreviousTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DeltaFromPreviousTransform(nativeBuffer + arrayIndex * FRigUnit_DeltaFromPreviousTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DeltaFromPreviousTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DeltaFromPreviousTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DeltaFromPreviousTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DeltaFromPreviousTransform");
		}
	}

	public FRigUnit_DeltaFromPreviousTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_DeltaFromPreviousTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DeltaFromPreviousTransform");
		}
	}

	static FRigUnit_DeltaFromPreviousTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DeltaFromPreviousTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DeltaFromPreviousTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DeltaFromPreviousTransform");
		FRigUnit_DeltaFromPreviousTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DeltaFromPreviousTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DeltaFromPreviousTransform", FRigUnit_DeltaFromPreviousTransform_IsValid);
	}
}
