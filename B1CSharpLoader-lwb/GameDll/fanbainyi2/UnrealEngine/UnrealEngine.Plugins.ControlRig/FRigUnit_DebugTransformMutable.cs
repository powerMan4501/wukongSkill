using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DebugTransformMutable", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DebugTransformMutable
{
	private static bool FRigUnit_DebugTransformMutable_IsValid;

	private static int FRigUnit_DebugTransformMutable_StructSize;

	public FRigUnit_DebugTransformMutable Copy()
	{
		return this;
	}

	public static FRigUnit_DebugTransformMutable FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DebugTransformMutable(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DebugTransformMutable value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DebugTransformMutable FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DebugTransformMutable(nativeBuffer + arrayIndex * FRigUnit_DebugTransformMutable_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DebugTransformMutable value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DebugTransformMutable_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugTransformMutable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugTransformMutable");
		}
	}

	public FRigUnit_DebugTransformMutable(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugTransformMutable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugTransformMutable");
		}
	}

	static FRigUnit_DebugTransformMutable()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DebugTransformMutable)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DebugTransformMutable));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DebugTransformMutable");
		FRigUnit_DebugTransformMutable_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DebugTransformMutable_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DebugTransformMutable", FRigUnit_DebugTransformMutable_IsValid);
	}
}
