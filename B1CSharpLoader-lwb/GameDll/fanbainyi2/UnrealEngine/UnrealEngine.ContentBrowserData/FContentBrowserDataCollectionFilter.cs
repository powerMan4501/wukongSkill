using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.ContentBrowserData;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ContentBrowserData.ContentBrowserDataCollectionFilter", "ContentBrowserData", UnrealModuleType.Engine)]
public struct FContentBrowserDataCollectionFilter
{
	private static bool IncludeChildCollections_IsValid;

	private static FFieldAddress IncludeChildCollections_PropertyAddress;

	private static int IncludeChildCollections_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ContentBrowserData.ContentBrowserDataCollectionFilter:bIncludeChildCollections")]
	public bool IncludeChildCollections;

	private static bool FContentBrowserDataCollectionFilter_IsValid;

	private static int FContentBrowserDataCollectionFilter_StructSize;

	public FContentBrowserDataCollectionFilter Copy()
	{
		return this;
	}

	public static FContentBrowserDataCollectionFilter FromNative(IntPtr nativeBuffer)
	{
		return new FContentBrowserDataCollectionFilter(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FContentBrowserDataCollectionFilter value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FContentBrowserDataCollectionFilter FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FContentBrowserDataCollectionFilter(nativeBuffer + arrayIndex * FContentBrowserDataCollectionFilter_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FContentBrowserDataCollectionFilter value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FContentBrowserDataCollectionFilter_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FContentBrowserDataCollectionFilter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ContentBrowserData.ContentBrowserDataCollectionFilter");
		}
		else
		{
			BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IncludeChildCollections_Offset), 0, IncludeChildCollections_PropertyAddress.Address, IncludeChildCollections);
		}
	}

	public FContentBrowserDataCollectionFilter(IntPtr nativeStruct)
	{
		if (!FContentBrowserDataCollectionFilter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ContentBrowserData.ContentBrowserDataCollectionFilter");
			IncludeChildCollections = false;
		}
		else
		{
			IncludeChildCollections = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IncludeChildCollections_Offset), 0, IncludeChildCollections_PropertyAddress.Address);
		}
	}

	static FContentBrowserDataCollectionFilter()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FContentBrowserDataCollectionFilter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FContentBrowserDataCollectionFilter));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ContentBrowserData.ContentBrowserDataCollectionFilter");
		FContentBrowserDataCollectionFilter_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref IncludeChildCollections_PropertyAddress, intPtr, "bIncludeChildCollections");
		IncludeChildCollections_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIncludeChildCollections");
		IncludeChildCollections_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIncludeChildCollections", Classes.FBoolProperty);
		FContentBrowserDataCollectionFilter_IsValid = intPtr != IntPtr.Zero && IncludeChildCollections_IsValid;
		NativeReflection.LogStructIsValid("/Script/ContentBrowserData.ContentBrowserDataCollectionFilter", FContentBrowserDataCollectionFilter_IsValid);
	}
}
