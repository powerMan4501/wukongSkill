using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DebugBaseMutable", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DebugBaseMutable
{
	private static bool FRigUnit_DebugBaseMutable_IsValid;

	private static int FRigUnit_DebugBaseMutable_StructSize;

	public FRigUnit_DebugBaseMutable Copy()
	{
		return this;
	}

	public static FRigUnit_DebugBaseMutable FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DebugBaseMutable(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DebugBaseMutable value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DebugBaseMutable FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DebugBaseMutable(nativeBuffer + arrayIndex * FRigUnit_DebugBaseMutable_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DebugBaseMutable value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DebugBaseMutable_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugBaseMutable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugBaseMutable");
		}
	}

	public FRigUnit_DebugBaseMutable(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugBaseMutable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugBaseMutable");
		}
	}

	static FRigUnit_DebugBaseMutable()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DebugBaseMutable)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DebugBaseMutable));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DebugBaseMutable");
		FRigUnit_DebugBaseMutable_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DebugBaseMutable_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DebugBaseMutable", FRigUnit_DebugBaseMutable_IsValid);
	}
}
