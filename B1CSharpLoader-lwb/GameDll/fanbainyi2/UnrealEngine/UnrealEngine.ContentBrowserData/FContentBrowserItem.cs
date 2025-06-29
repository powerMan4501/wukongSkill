using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.ContentBrowserData;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ContentBrowserData.ContentBrowserItem", "ContentBrowserData", UnrealModuleType.Engine)]
public struct FContentBrowserItem
{
	private static bool FContentBrowserItem_IsValid;

	private static int FContentBrowserItem_StructSize;

	public FContentBrowserItem Copy()
	{
		return this;
	}

	public static FContentBrowserItem FromNative(IntPtr nativeBuffer)
	{
		return new FContentBrowserItem(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FContentBrowserItem value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FContentBrowserItem FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FContentBrowserItem(nativeBuffer + arrayIndex * FContentBrowserItem_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FContentBrowserItem value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FContentBrowserItem_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FContentBrowserItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ContentBrowserData.ContentBrowserItem");
		}
	}

	public FContentBrowserItem(IntPtr nativeStruct)
	{
		if (!FContentBrowserItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ContentBrowserData.ContentBrowserItem");
		}
	}

	static FContentBrowserItem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FContentBrowserItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FContentBrowserItem));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ContentBrowserData.ContentBrowserItem");
		FContentBrowserItem_StructSize = NativeReflection.GetStructSize(intPtr);
		FContentBrowserItem_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ContentBrowserData.ContentBrowserItem", FContentBrowserItem_IsValid);
	}
}
