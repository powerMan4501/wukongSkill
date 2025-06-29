using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.LiveLinkSourceHandle", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FLiveLinkSourceHandle
{
	private static bool FLiveLinkSourceHandle_IsValid;

	private static int FLiveLinkSourceHandle_StructSize;

	public FLiveLinkSourceHandle Copy()
	{
		return this;
	}

	public static FLiveLinkSourceHandle FromNative(IntPtr nativeBuffer)
	{
		return new FLiveLinkSourceHandle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLiveLinkSourceHandle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLiveLinkSourceHandle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLiveLinkSourceHandle(nativeBuffer + arrayIndex * FLiveLinkSourceHandle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLiveLinkSourceHandle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLiveLinkSourceHandle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLiveLinkSourceHandle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkSourceHandle");
		}
	}

	public FLiveLinkSourceHandle(IntPtr nativeStruct)
	{
		if (!FLiveLinkSourceHandle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkSourceHandle");
		}
	}

	static FLiveLinkSourceHandle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLiveLinkSourceHandle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLiveLinkSourceHandle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.LiveLinkSourceHandle");
		FLiveLinkSourceHandle_StructSize = NativeReflection.GetStructSize(intPtr);
		FLiveLinkSourceHandle_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.LiveLinkSourceHandle", FLiveLinkSourceHandle_IsValid);
	}
}
