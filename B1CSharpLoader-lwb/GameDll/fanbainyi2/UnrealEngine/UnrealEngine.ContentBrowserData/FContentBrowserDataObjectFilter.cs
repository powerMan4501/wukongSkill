using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.ContentBrowserData;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ContentBrowserData.ContentBrowserDataObjectFilter", "ContentBrowserData", UnrealModuleType.Engine)]
public struct FContentBrowserDataObjectFilter
{
	private static bool ObjectNamesToInclude_IsValid;

	private static FFieldAddress ObjectNamesToInclude_PropertyAddress;

	private static int ObjectNamesToInclude_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/ContentBrowserData.ContentBrowserDataObjectFilter:ObjectNamesToInclude")]
	public List<FName> ObjectNamesToInclude;

	private static bool ObjectNamesToExclude_IsValid;

	private static FFieldAddress ObjectNamesToExclude_PropertyAddress;

	private static int ObjectNamesToExclude_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/ContentBrowserData.ContentBrowserDataObjectFilter:ObjectNamesToExclude")]
	public List<FName> ObjectNamesToExclude;

	private static bool OnDiskObjectsOnly_IsValid;

	private static FFieldAddress OnDiskObjectsOnly_PropertyAddress;

	private static int OnDiskObjectsOnly_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ContentBrowserData.ContentBrowserDataObjectFilter:bOnDiskObjectsOnly")]
	public bool OnDiskObjectsOnly;

	private static bool FContentBrowserDataObjectFilter_IsValid;

	private static int FContentBrowserDataObjectFilter_StructSize;

	public FContentBrowserDataObjectFilter Copy()
	{
		FContentBrowserDataObjectFilter result = this;
		if (ObjectNamesToInclude != null)
		{
			result.ObjectNamesToInclude = new List<FName>(ObjectNamesToInclude);
		}
		if (ObjectNamesToExclude != null)
		{
			result.ObjectNamesToExclude = new List<FName>(ObjectNamesToExclude);
		}
		return result;
	}

	public static FContentBrowserDataObjectFilter FromNative(IntPtr nativeBuffer)
	{
		return new FContentBrowserDataObjectFilter(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FContentBrowserDataObjectFilter value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FContentBrowserDataObjectFilter FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FContentBrowserDataObjectFilter(nativeBuffer + arrayIndex * FContentBrowserDataObjectFilter_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FContentBrowserDataObjectFilter value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FContentBrowserDataObjectFilter_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FContentBrowserDataObjectFilter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ContentBrowserData.ContentBrowserDataObjectFilter");
			return;
		}
		new TArrayCopyMarshaler<FName>(1, ObjectNamesToInclude_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ObjectNamesToInclude_Offset), ObjectNamesToInclude);
		new TArrayCopyMarshaler<FName>(1, ObjectNamesToExclude_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ObjectNamesToExclude_Offset), ObjectNamesToExclude);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, OnDiskObjectsOnly_Offset), 0, OnDiskObjectsOnly_PropertyAddress.Address, OnDiskObjectsOnly);
	}

	public FContentBrowserDataObjectFilter(IntPtr nativeStruct)
	{
		if (!FContentBrowserDataObjectFilter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ContentBrowserData.ContentBrowserDataObjectFilter");
			ObjectNamesToInclude = null;
			ObjectNamesToExclude = null;
			OnDiskObjectsOnly = false;
		}
		else
		{
			ObjectNamesToInclude = new TArrayCopyMarshaler<FName>(1, ObjectNamesToInclude_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ObjectNamesToInclude_Offset));
			ObjectNamesToExclude = new TArrayCopyMarshaler<FName>(1, ObjectNamesToExclude_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ObjectNamesToExclude_Offset));
			OnDiskObjectsOnly = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, OnDiskObjectsOnly_Offset), 0, OnDiskObjectsOnly_PropertyAddress.Address);
		}
	}

	static FContentBrowserDataObjectFilter()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FContentBrowserDataObjectFilter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FContentBrowserDataObjectFilter));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ContentBrowserData.ContentBrowserDataObjectFilter");
		FContentBrowserDataObjectFilter_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ObjectNamesToInclude_PropertyAddress, intPtr, "ObjectNamesToInclude");
		ObjectNamesToInclude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ObjectNamesToInclude");
		ObjectNamesToInclude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ObjectNamesToInclude", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ObjectNamesToExclude_PropertyAddress, intPtr, "ObjectNamesToExclude");
		ObjectNamesToExclude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ObjectNamesToExclude");
		ObjectNamesToExclude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ObjectNamesToExclude", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref OnDiskObjectsOnly_PropertyAddress, intPtr, "bOnDiskObjectsOnly");
		OnDiskObjectsOnly_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOnDiskObjectsOnly");
		OnDiskObjectsOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOnDiskObjectsOnly", Classes.FBoolProperty);
		FContentBrowserDataObjectFilter_IsValid = intPtr != IntPtr.Zero && ObjectNamesToInclude_IsValid && ObjectNamesToExclude_IsValid && OnDiskObjectsOnly_IsValid;
		NativeReflection.LogStructIsValid("/Script/ContentBrowserData.ContentBrowserDataObjectFilter", FContentBrowserDataObjectFilter_IsValid);
	}
}
