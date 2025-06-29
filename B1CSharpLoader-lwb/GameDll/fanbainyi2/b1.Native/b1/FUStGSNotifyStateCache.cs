using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4101)]
[BlueprintType]
[UMetaPath("/Script/b1.UStGSNotifyStateCache", "b1", UnrealModuleType.Game)]
public struct FUStGSNotifyStateCache
{
	private static bool FUStGSNotifyStateCache_IsValid;

	private static int FUStGSNotifyStateCache_StructSize;

	public FUStGSNotifyStateCache Copy()
	{
		return this;
	}

	public static FUStGSNotifyStateCache FromNative(IntPtr nativeBuffer)
	{
		return new FUStGSNotifyStateCache(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUStGSNotifyStateCache value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUStGSNotifyStateCache FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUStGSNotifyStateCache(nativeBuffer + arrayIndex * FUStGSNotifyStateCache_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUStGSNotifyStateCache value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FUStGSNotifyStateCache_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FUStGSNotifyStateCache_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.UStGSNotifyStateCache");
		}
	}

	public FUStGSNotifyStateCache(IntPtr nativeStruct)
	{
		if (!FUStGSNotifyStateCache_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.UStGSNotifyStateCache");
		}
	}

	static FUStGSNotifyStateCache()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FUStGSNotifyStateCache)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUStGSNotifyStateCache));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.UStGSNotifyStateCache");
		FUStGSNotifyStateCache_StructSize = NativeReflection.GetStructSize(intPtr);
		FUStGSNotifyStateCache_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/b1.UStGSNotifyStateCache", FUStGSNotifyStateCache_IsValid);
	}
}
