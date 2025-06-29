using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.ContentBrowserData;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ContentBrowserData.ContentBrowserDataFilter", "ContentBrowserData", UnrealModuleType.Engine)]
public struct FContentBrowserDataFilter
{
	private static bool RecursivePaths_IsValid;

	private static FFieldAddress RecursivePaths_PropertyAddress;

	private static int RecursivePaths_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ContentBrowserData.ContentBrowserDataFilter:bRecursivePaths")]
	public bool RecursivePaths;

	private static bool ItemTypeFilter_IsValid;

	private static FFieldAddress ItemTypeFilter_PropertyAddress;

	private static int ItemTypeFilter_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ContentBrowserData.ContentBrowserDataFilter:ItemTypeFilter")]
	public EContentBrowserItemTypeFilter ItemTypeFilter;

	private static bool ItemCategoryFilter_IsValid;

	private static FFieldAddress ItemCategoryFilter_PropertyAddress;

	private static int ItemCategoryFilter_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ContentBrowserData.ContentBrowserDataFilter:ItemCategoryFilter")]
	public EContentBrowserItemCategoryFilter ItemCategoryFilter;

	private static bool ItemAttributeFilter_IsValid;

	private static FFieldAddress ItemAttributeFilter_PropertyAddress;

	private static int ItemAttributeFilter_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ContentBrowserData.ContentBrowserDataFilter:ItemAttributeFilter")]
	public EContentBrowserItemAttributeFilter ItemAttributeFilter;

	private static bool FContentBrowserDataFilter_IsValid;

	private static int FContentBrowserDataFilter_StructSize;

	public FContentBrowserDataFilter Copy()
	{
		return this;
	}

	public static FContentBrowserDataFilter FromNative(IntPtr nativeBuffer)
	{
		return new FContentBrowserDataFilter(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FContentBrowserDataFilter value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FContentBrowserDataFilter FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FContentBrowserDataFilter(nativeBuffer + arrayIndex * FContentBrowserDataFilter_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FContentBrowserDataFilter value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FContentBrowserDataFilter_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FContentBrowserDataFilter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ContentBrowserData.ContentBrowserDataFilter");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RecursivePaths_Offset), 0, RecursivePaths_PropertyAddress.Address, RecursivePaths);
		EnumMarshaler<EContentBrowserItemTypeFilter>.ToNative(IntPtr.Add(nativeStruct, ItemTypeFilter_Offset), 0, ItemTypeFilter_PropertyAddress.Address, ItemTypeFilter);
		EnumMarshaler<EContentBrowserItemCategoryFilter>.ToNative(IntPtr.Add(nativeStruct, ItemCategoryFilter_Offset), 0, ItemCategoryFilter_PropertyAddress.Address, ItemCategoryFilter);
		EnumMarshaler<EContentBrowserItemAttributeFilter>.ToNative(IntPtr.Add(nativeStruct, ItemAttributeFilter_Offset), 0, ItemAttributeFilter_PropertyAddress.Address, ItemAttributeFilter);
	}

	public FContentBrowserDataFilter(IntPtr nativeStruct)
	{
		if (!FContentBrowserDataFilter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ContentBrowserData.ContentBrowserDataFilter");
			RecursivePaths = false;
			ItemTypeFilter = EContentBrowserItemTypeFilter.IncludeNone;
			ItemCategoryFilter = EContentBrowserItemCategoryFilter.IncludeNone;
			ItemAttributeFilter = EContentBrowserItemAttributeFilter.IncludeNone;
		}
		else
		{
			RecursivePaths = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RecursivePaths_Offset), 0, RecursivePaths_PropertyAddress.Address);
			ItemTypeFilter = EnumMarshaler<EContentBrowserItemTypeFilter>.FromNative(IntPtr.Add(nativeStruct, ItemTypeFilter_Offset), 0, ItemTypeFilter_PropertyAddress.Address);
			ItemCategoryFilter = EnumMarshaler<EContentBrowserItemCategoryFilter>.FromNative(IntPtr.Add(nativeStruct, ItemCategoryFilter_Offset), 0, ItemCategoryFilter_PropertyAddress.Address);
			ItemAttributeFilter = EnumMarshaler<EContentBrowserItemAttributeFilter>.FromNative(IntPtr.Add(nativeStruct, ItemAttributeFilter_Offset), 0, ItemAttributeFilter_PropertyAddress.Address);
		}
	}

	static FContentBrowserDataFilter()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FContentBrowserDataFilter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FContentBrowserDataFilter));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ContentBrowserData.ContentBrowserDataFilter");
		FContentBrowserDataFilter_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref RecursivePaths_PropertyAddress, intPtr, "bRecursivePaths");
		RecursivePaths_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRecursivePaths");
		RecursivePaths_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRecursivePaths", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ItemTypeFilter_PropertyAddress, intPtr, "ItemTypeFilter");
		ItemTypeFilter_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ItemTypeFilter");
		ItemTypeFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ItemTypeFilter", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ItemCategoryFilter_PropertyAddress, intPtr, "ItemCategoryFilter");
		ItemCategoryFilter_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ItemCategoryFilter");
		ItemCategoryFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ItemCategoryFilter", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ItemAttributeFilter_PropertyAddress, intPtr, "ItemAttributeFilter");
		ItemAttributeFilter_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ItemAttributeFilter");
		ItemAttributeFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ItemAttributeFilter", Classes.FEnumProperty);
		FContentBrowserDataFilter_IsValid = intPtr != IntPtr.Zero && RecursivePaths_IsValid && ItemTypeFilter_IsValid && ItemCategoryFilter_IsValid && ItemAttributeFilter_IsValid;
		NativeReflection.LogStructIsValid("/Script/ContentBrowserData.ContentBrowserDataFilter", FContentBrowserDataFilter_IsValid);
	}
}
