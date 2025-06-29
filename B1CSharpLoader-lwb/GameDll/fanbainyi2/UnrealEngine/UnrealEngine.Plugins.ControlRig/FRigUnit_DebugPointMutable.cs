using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DebugPointMutable", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DebugPointMutable
{
	private static bool FRigUnit_DebugPointMutable_IsValid;

	private static int FRigUnit_DebugPointMutable_StructSize;

	public FRigUnit_DebugPointMutable Copy()
	{
		return this;
	}

	public static FRigUnit_DebugPointMutable FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DebugPointMutable(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DebugPointMutable value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DebugPointMutable FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DebugPointMutable(nativeBuffer + arrayIndex * FRigUnit_DebugPointMutable_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DebugPointMutable value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DebugPointMutable_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugPointMutable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugPointMutable");
		}
	}

	public FRigUnit_DebugPointMutable(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugPointMutable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugPointMutable");
		}
	}

	static FRigUnit_DebugPointMutable()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DebugPointMutable)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DebugPointMutable));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DebugPointMutable");
		FRigUnit_DebugPointMutable_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DebugPointMutable_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DebugPointMutable", FRigUnit_DebugPointMutable_IsValid);
	}
}
