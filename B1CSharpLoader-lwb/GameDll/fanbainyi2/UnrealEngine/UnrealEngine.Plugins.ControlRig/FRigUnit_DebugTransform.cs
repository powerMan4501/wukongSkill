using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DebugTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DebugTransform
{
	private static bool FRigUnit_DebugTransform_IsValid;

	private static int FRigUnit_DebugTransform_StructSize;

	public FRigUnit_DebugTransform Copy()
	{
		return this;
	}

	public static FRigUnit_DebugTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DebugTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DebugTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DebugTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DebugTransform(nativeBuffer + arrayIndex * FRigUnit_DebugTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DebugTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DebugTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugTransform");
		}
	}

	public FRigUnit_DebugTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugTransform");
		}
	}

	static FRigUnit_DebugTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DebugTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DebugTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DebugTransform");
		FRigUnit_DebugTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DebugTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DebugTransform", FRigUnit_DebugTransform_IsValid);
	}
}
