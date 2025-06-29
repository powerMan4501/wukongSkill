using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.ContentBrowserData;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ContentBrowserData.ContentBrowserDataPackageFilter", "ContentBrowserData", UnrealModuleType.Engine)]
public struct FContentBrowserDataPackageFilter
{
	private static bool PackageNamesToInclude_IsValid;

	private static FFieldAddress PackageNamesToInclude_PropertyAddress;

	private static int PackageNamesToInclude_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/ContentBrowserData.ContentBrowserDataPackageFilter:PackageNamesToInclude")]
	public List<FName> PackageNamesToInclude;

	private static bool PackageNamesToExclude_IsValid;

	private static FFieldAddress PackageNamesToExclude_PropertyAddress;

	private static int PackageNamesToExclude_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/ContentBrowserData.ContentBrowserDataPackageFilter:PackageNamesToExclude")]
	public List<FName> PackageNamesToExclude;

	private static bool PackagePathsToInclude_IsValid;

	private static FFieldAddress PackagePathsToInclude_PropertyAddress;

	private static int PackagePathsToInclude_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/ContentBrowserData.ContentBrowserDataPackageFilter:PackagePathsToInclude")]
	public List<FName> PackagePathsToInclude;

	private static bool PackagePathsToExclude_IsValid;

	private static FFieldAddress PackagePathsToExclude_PropertyAddress;

	private static int PackagePathsToExclude_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/ContentBrowserData.ContentBrowserDataPackageFilter:PackagePathsToExclude")]
	public List<FName> PackagePathsToExclude;

	private static bool RecursivePackagePathsToInclude_IsValid;

	private static FFieldAddress RecursivePackagePathsToInclude_PropertyAddress;

	private static int RecursivePackagePathsToInclude_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ContentBrowserData.ContentBrowserDataPackageFilter:bRecursivePackagePathsToInclude")]
	public bool RecursivePackagePathsToInclude;

	private static bool RecursivePackagePathsToExclude_IsValid;

	private static FFieldAddress RecursivePackagePathsToExclude_PropertyAddress;

	private static int RecursivePackagePathsToExclude_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ContentBrowserData.ContentBrowserDataPackageFilter:bRecursivePackagePathsToExclude")]
	public bool RecursivePackagePathsToExclude;

	private static bool FContentBrowserDataPackageFilter_IsValid;

	private static int FContentBrowserDataPackageFilter_StructSize;

	public FContentBrowserDataPackageFilter Copy()
	{
		FContentBrowserDataPackageFilter result = this;
		if (PackageNamesToInclude != null)
		{
			result.PackageNamesToInclude = new List<FName>(PackageNamesToInclude);
		}
		if (PackageNamesToExclude != null)
		{
			result.PackageNamesToExclude = new List<FName>(PackageNamesToExclude);
		}
		if (PackagePathsToInclude != null)
		{
			result.PackagePathsToInclude = new List<FName>(PackagePathsToInclude);
		}
		if (PackagePathsToExclude != null)
		{
			result.PackagePathsToExclude = new List<FName>(PackagePathsToExclude);
		}
		return result;
	}

	public static FContentBrowserDataPackageFilter FromNative(IntPtr nativeBuffer)
	{
		return new FContentBrowserDataPackageFilter(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FContentBrowserDataPackageFilter value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FContentBrowserDataPackageFilter FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FContentBrowserDataPackageFilter(nativeBuffer + arrayIndex * FContentBrowserDataPackageFilter_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FContentBrowserDataPackageFilter value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FContentBrowserDataPackageFilter_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FContentBrowserDataPackageFilter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ContentBrowserData.ContentBrowserDataPackageFilter");
			return;
		}
		new TArrayCopyMarshaler<FName>(1, PackageNamesToInclude_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, PackageNamesToInclude_Offset), PackageNamesToInclude);
		new TArrayCopyMarshaler<FName>(1, PackageNamesToExclude_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, PackageNamesToExclude_Offset), PackageNamesToExclude);
		new TArrayCopyMarshaler<FName>(1, PackagePathsToInclude_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, PackagePathsToInclude_Offset), PackagePathsToInclude);
		new TArrayCopyMarshaler<FName>(1, PackagePathsToExclude_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, PackagePathsToExclude_Offset), PackagePathsToExclude);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RecursivePackagePathsToInclude_Offset), 0, RecursivePackagePathsToInclude_PropertyAddress.Address, RecursivePackagePathsToInclude);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RecursivePackagePathsToExclude_Offset), 0, RecursivePackagePathsToExclude_PropertyAddress.Address, RecursivePackagePathsToExclude);
	}

	public FContentBrowserDataPackageFilter(IntPtr nativeStruct)
	{
		if (!FContentBrowserDataPackageFilter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ContentBrowserData.ContentBrowserDataPackageFilter");
			PackageNamesToInclude = null;
			PackageNamesToExclude = null;
			PackagePathsToInclude = null;
			PackagePathsToExclude = null;
			RecursivePackagePathsToInclude = false;
			RecursivePackagePathsToExclude = false;
		}
		else
		{
			PackageNamesToInclude = new TArrayCopyMarshaler<FName>(1, PackageNamesToInclude_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, PackageNamesToInclude_Offset));
			PackageNamesToExclude = new TArrayCopyMarshaler<FName>(1, PackageNamesToExclude_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, PackageNamesToExclude_Offset));
			PackagePathsToInclude = new TArrayCopyMarshaler<FName>(1, PackagePathsToInclude_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, PackagePathsToInclude_Offset));
			PackagePathsToExclude = new TArrayCopyMarshaler<FName>(1, PackagePathsToExclude_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, PackagePathsToExclude_Offset));
			RecursivePackagePathsToInclude = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RecursivePackagePathsToInclude_Offset), 0, RecursivePackagePathsToInclude_PropertyAddress.Address);
			RecursivePackagePathsToExclude = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RecursivePackagePathsToExclude_Offset), 0, RecursivePackagePathsToExclude_PropertyAddress.Address);
		}
	}

	static FContentBrowserDataPackageFilter()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FContentBrowserDataPackageFilter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FContentBrowserDataPackageFilter));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ContentBrowserData.ContentBrowserDataPackageFilter");
		FContentBrowserDataPackageFilter_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref PackageNamesToInclude_PropertyAddress, intPtr, "PackageNamesToInclude");
		PackageNamesToInclude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PackageNamesToInclude");
		PackageNamesToInclude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PackageNamesToInclude", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref PackageNamesToExclude_PropertyAddress, intPtr, "PackageNamesToExclude");
		PackageNamesToExclude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PackageNamesToExclude");
		PackageNamesToExclude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PackageNamesToExclude", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref PackagePathsToInclude_PropertyAddress, intPtr, "PackagePathsToInclude");
		PackagePathsToInclude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PackagePathsToInclude");
		PackagePathsToInclude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PackagePathsToInclude", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref PackagePathsToExclude_PropertyAddress, intPtr, "PackagePathsToExclude");
		PackagePathsToExclude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PackagePathsToExclude");
		PackagePathsToExclude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PackagePathsToExclude", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RecursivePackagePathsToInclude_PropertyAddress, intPtr, "bRecursivePackagePathsToInclude");
		RecursivePackagePathsToInclude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRecursivePackagePathsToInclude");
		RecursivePackagePathsToInclude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRecursivePackagePathsToInclude", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RecursivePackagePathsToExclude_PropertyAddress, intPtr, "bRecursivePackagePathsToExclude");
		RecursivePackagePathsToExclude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRecursivePackagePathsToExclude");
		RecursivePackagePathsToExclude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRecursivePackagePathsToExclude", Classes.FBoolProperty);
		FContentBrowserDataPackageFilter_IsValid = intPtr != IntPtr.Zero && PackageNamesToInclude_IsValid && PackageNamesToExclude_IsValid && PackagePathsToInclude_IsValid && PackagePathsToExclude_IsValid && RecursivePackagePathsToInclude_IsValid && RecursivePackagePathsToExclude_IsValid;
		NativeReflection.LogStructIsValid("/Script/ContentBrowserData.ContentBrowserDataPackageFilter", FContentBrowserDataPackageFilter_IsValid);
	}
}
