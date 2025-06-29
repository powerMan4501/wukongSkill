using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DebugTransformArrayMutableItemSpace", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DebugTransformArrayMutableItemSpace
{
	private static bool FRigUnit_DebugTransformArrayMutableItemSpace_IsValid;

	private static int FRigUnit_DebugTransformArrayMutableItemSpace_StructSize;

	public FRigUnit_DebugTransformArrayMutableItemSpace Copy()
	{
		return this;
	}

	public static FRigUnit_DebugTransformArrayMutableItemSpace FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DebugTransformArrayMutableItemSpace(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DebugTransformArrayMutableItemSpace value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DebugTransformArrayMutableItemSpace FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DebugTransformArrayMutableItemSpace(nativeBuffer + arrayIndex * FRigUnit_DebugTransformArrayMutableItemSpace_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DebugTransformArrayMutableItemSpace value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DebugTransformArrayMutableItemSpace_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugTransformArrayMutableItemSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugTransformArrayMutableItemSpace");
		}
	}

	public FRigUnit_DebugTransformArrayMutableItemSpace(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugTransformArrayMutableItemSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugTransformArrayMutableItemSpace");
		}
	}

	static FRigUnit_DebugTransformArrayMutableItemSpace()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DebugTransformArrayMutableItemSpace)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DebugTransformArrayMutableItemSpace));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DebugTransformArrayMutableItemSpace");
		FRigUnit_DebugTransformArrayMutableItemSpace_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DebugTransformArrayMutableItemSpace_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DebugTransformArrayMutableItemSpace", FRigUnit_DebugTransformArrayMutableItemSpace_IsValid);
	}
}
