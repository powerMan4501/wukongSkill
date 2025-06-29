using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_GetWorldTime", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_GetWorldTime
{
	private static bool FRigUnit_GetWorldTime_IsValid;

	private static int FRigUnit_GetWorldTime_StructSize;

	public FRigUnit_GetWorldTime Copy()
	{
		return this;
	}

	public static FRigUnit_GetWorldTime FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_GetWorldTime(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_GetWorldTime value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_GetWorldTime FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_GetWorldTime(nativeBuffer + arrayIndex * FRigUnit_GetWorldTime_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_GetWorldTime value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_GetWorldTime_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetWorldTime_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetWorldTime");
		}
	}

	public FRigUnit_GetWorldTime(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetWorldTime_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetWorldTime");
		}
	}

	static FRigUnit_GetWorldTime()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_GetWorldTime)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_GetWorldTime));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_GetWorldTime");
		FRigUnit_GetWorldTime_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_GetWorldTime_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_GetWorldTime", FRigUnit_GetWorldTime_IsValid);
	}
}
