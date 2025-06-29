using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DebugTransformArrayMutable", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DebugTransformArrayMutable
{
	private static bool FRigUnit_DebugTransformArrayMutable_IsValid;

	private static int FRigUnit_DebugTransformArrayMutable_StructSize;

	public FRigUnit_DebugTransformArrayMutable Copy()
	{
		return this;
	}

	public static FRigUnit_DebugTransformArrayMutable FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DebugTransformArrayMutable(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DebugTransformArrayMutable value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DebugTransformArrayMutable FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DebugTransformArrayMutable(nativeBuffer + arrayIndex * FRigUnit_DebugTransformArrayMutable_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DebugTransformArrayMutable value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DebugTransformArrayMutable_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugTransformArrayMutable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugTransformArrayMutable");
		}
	}

	public FRigUnit_DebugTransformArrayMutable(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugTransformArrayMutable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugTransformArrayMutable");
		}
	}

	static FRigUnit_DebugTransformArrayMutable()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DebugTransformArrayMutable)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DebugTransformArrayMutable));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DebugTransformArrayMutable");
		FRigUnit_DebugTransformArrayMutable_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DebugTransformArrayMutable_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DebugTransformArrayMutable", FRigUnit_DebugTransformArrayMutable_IsValid);
	}
}
