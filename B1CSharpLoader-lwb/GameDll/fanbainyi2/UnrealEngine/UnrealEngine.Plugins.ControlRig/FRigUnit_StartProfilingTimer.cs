using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_StartProfilingTimer", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_StartProfilingTimer
{
	private static bool FRigUnit_StartProfilingTimer_IsValid;

	private static int FRigUnit_StartProfilingTimer_StructSize;

	public FRigUnit_StartProfilingTimer Copy()
	{
		return this;
	}

	public static FRigUnit_StartProfilingTimer FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_StartProfilingTimer(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_StartProfilingTimer value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_StartProfilingTimer FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_StartProfilingTimer(nativeBuffer + arrayIndex * FRigUnit_StartProfilingTimer_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_StartProfilingTimer value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_StartProfilingTimer_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_StartProfilingTimer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_StartProfilingTimer");
		}
	}

	public FRigUnit_StartProfilingTimer(IntPtr nativeStruct)
	{
		if (!FRigUnit_StartProfilingTimer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_StartProfilingTimer");
		}
	}

	static FRigUnit_StartProfilingTimer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_StartProfilingTimer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_StartProfilingTimer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_StartProfilingTimer");
		FRigUnit_StartProfilingTimer_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_StartProfilingTimer_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_StartProfilingTimer", FRigUnit_StartProfilingTimer_IsValid);
	}
}
