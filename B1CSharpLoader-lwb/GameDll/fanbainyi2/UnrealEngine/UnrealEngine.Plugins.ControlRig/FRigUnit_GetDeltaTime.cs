using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_GetDeltaTime", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_GetDeltaTime
{
	private static bool FRigUnit_GetDeltaTime_IsValid;

	private static int FRigUnit_GetDeltaTime_StructSize;

	public FRigUnit_GetDeltaTime Copy()
	{
		return this;
	}

	public static FRigUnit_GetDeltaTime FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_GetDeltaTime(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_GetDeltaTime value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_GetDeltaTime FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_GetDeltaTime(nativeBuffer + arrayIndex * FRigUnit_GetDeltaTime_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_GetDeltaTime value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_GetDeltaTime_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetDeltaTime_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetDeltaTime");
		}
	}

	public FRigUnit_GetDeltaTime(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetDeltaTime_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetDeltaTime");
		}
	}

	static FRigUnit_GetDeltaTime()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_GetDeltaTime)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_GetDeltaTime));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_GetDeltaTime");
		FRigUnit_GetDeltaTime_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_GetDeltaTime_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_GetDeltaTime", FRigUnit_GetDeltaTime_IsValid);
	}
}
