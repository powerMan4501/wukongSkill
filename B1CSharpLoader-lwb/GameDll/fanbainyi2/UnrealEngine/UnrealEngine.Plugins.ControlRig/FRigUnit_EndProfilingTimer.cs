using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_EndProfilingTimer", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_EndProfilingTimer
{
	private static bool FRigUnit_EndProfilingTimer_IsValid;

	private static int FRigUnit_EndProfilingTimer_StructSize;

	public FRigUnit_EndProfilingTimer Copy()
	{
		return this;
	}

	public static FRigUnit_EndProfilingTimer FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_EndProfilingTimer(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_EndProfilingTimer value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_EndProfilingTimer FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_EndProfilingTimer(nativeBuffer + arrayIndex * FRigUnit_EndProfilingTimer_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_EndProfilingTimer value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_EndProfilingTimer_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_EndProfilingTimer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_EndProfilingTimer");
		}
	}

	public FRigUnit_EndProfilingTimer(IntPtr nativeStruct)
	{
		if (!FRigUnit_EndProfilingTimer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_EndProfilingTimer");
		}
	}

	static FRigUnit_EndProfilingTimer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_EndProfilingTimer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_EndProfilingTimer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_EndProfilingTimer");
		FRigUnit_EndProfilingTimer_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_EndProfilingTimer_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_EndProfilingTimer", FRigUnit_EndProfilingTimer_IsValid);
	}
}
