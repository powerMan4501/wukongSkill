using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.LiveLinkTime", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FLiveLinkTime
{
	private static bool FLiveLinkTime_IsValid;

	private static int FLiveLinkTime_StructSize;

	public FLiveLinkTime Copy()
	{
		return this;
	}

	public static FLiveLinkTime FromNative(IntPtr nativeBuffer)
	{
		return new FLiveLinkTime(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLiveLinkTime value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLiveLinkTime FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLiveLinkTime(nativeBuffer + arrayIndex * FLiveLinkTime_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLiveLinkTime value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLiveLinkTime_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLiveLinkTime_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkTime");
		}
	}

	public FLiveLinkTime(IntPtr nativeStruct)
	{
		if (!FLiveLinkTime_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkTime");
		}
	}

	static FLiveLinkTime()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLiveLinkTime)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLiveLinkTime));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.LiveLinkTime");
		FLiveLinkTime_StructSize = NativeReflection.GetStructSize(intPtr);
		FLiveLinkTime_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.LiveLinkTime", FLiveLinkTime_IsValid);
	}
}
