using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ApplyFK", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ApplyFK
{
	private static bool FRigUnit_ApplyFK_IsValid;

	private static int FRigUnit_ApplyFK_StructSize;

	public FRigUnit_ApplyFK Copy()
	{
		return this;
	}

	public static FRigUnit_ApplyFK FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ApplyFK(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ApplyFK value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ApplyFK FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ApplyFK(nativeBuffer + arrayIndex * FRigUnit_ApplyFK_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ApplyFK value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ApplyFK_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ApplyFK_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ApplyFK");
		}
	}

	public FRigUnit_ApplyFK(IntPtr nativeStruct)
	{
		if (!FRigUnit_ApplyFK_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ApplyFK");
		}
	}

	static FRigUnit_ApplyFK()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ApplyFK)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ApplyFK));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ApplyFK");
		FRigUnit_ApplyFK_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ApplyFK_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ApplyFK", FRigUnit_ApplyFK_IsValid);
	}
}
