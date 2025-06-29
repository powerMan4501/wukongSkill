using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.TimeManagement;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/TimeManagement.TimedDataChannelSampleTime", "TimeManagement", UnrealModuleType.Engine)]
public struct FTimedDataChannelSampleTime
{
	private static bool FTimedDataChannelSampleTime_IsValid;

	private static int FTimedDataChannelSampleTime_StructSize;

	public FTimedDataChannelSampleTime Copy()
	{
		return this;
	}

	public static FTimedDataChannelSampleTime FromNative(IntPtr nativeBuffer)
	{
		return new FTimedDataChannelSampleTime(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTimedDataChannelSampleTime value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTimedDataChannelSampleTime FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTimedDataChannelSampleTime(nativeBuffer + arrayIndex * FTimedDataChannelSampleTime_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTimedDataChannelSampleTime value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTimedDataChannelSampleTime_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTimedDataChannelSampleTime_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TimeManagement.TimedDataChannelSampleTime");
		}
	}

	public FTimedDataChannelSampleTime(IntPtr nativeStruct)
	{
		if (!FTimedDataChannelSampleTime_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TimeManagement.TimedDataChannelSampleTime");
		}
	}

	static FTimedDataChannelSampleTime()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTimedDataChannelSampleTime)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTimedDataChannelSampleTime));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/TimeManagement.TimedDataChannelSampleTime");
		FTimedDataChannelSampleTime_StructSize = NativeReflection.GetStructSize(intPtr);
		FTimedDataChannelSampleTime_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/TimeManagement.TimedDataChannelSampleTime", FTimedDataChannelSampleTime_IsValid);
	}
}
