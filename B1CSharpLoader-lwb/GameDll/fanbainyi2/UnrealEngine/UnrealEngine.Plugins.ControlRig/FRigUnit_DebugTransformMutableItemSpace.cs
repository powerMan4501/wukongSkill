using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DebugTransformMutableItemSpace", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DebugTransformMutableItemSpace
{
	private static bool FRigUnit_DebugTransformMutableItemSpace_IsValid;

	private static int FRigUnit_DebugTransformMutableItemSpace_StructSize;

	public FRigUnit_DebugTransformMutableItemSpace Copy()
	{
		return this;
	}

	public static FRigUnit_DebugTransformMutableItemSpace FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DebugTransformMutableItemSpace(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DebugTransformMutableItemSpace value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DebugTransformMutableItemSpace FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DebugTransformMutableItemSpace(nativeBuffer + arrayIndex * FRigUnit_DebugTransformMutableItemSpace_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DebugTransformMutableItemSpace value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DebugTransformMutableItemSpace_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugTransformMutableItemSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugTransformMutableItemSpace");
		}
	}

	public FRigUnit_DebugTransformMutableItemSpace(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugTransformMutableItemSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugTransformMutableItemSpace");
		}
	}

	static FRigUnit_DebugTransformMutableItemSpace()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DebugTransformMutableItemSpace)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DebugTransformMutableItemSpace));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DebugTransformMutableItemSpace");
		FRigUnit_DebugTransformMutableItemSpace_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DebugTransformMutableItemSpace_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DebugTransformMutableItemSpace", FRigUnit_DebugTransformMutableItemSpace_IsValid);
	}
}
