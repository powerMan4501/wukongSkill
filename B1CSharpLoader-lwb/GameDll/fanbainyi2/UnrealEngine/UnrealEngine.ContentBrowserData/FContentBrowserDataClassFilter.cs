using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.ContentBrowserData;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ContentBrowserData.ContentBrowserDataClassFilter", "ContentBrowserData", UnrealModuleType.Engine)]
public struct FContentBrowserDataClassFilter
{
	private static bool ClassNamesToInclude_IsValid;

	private static FFieldAddress ClassNamesToInclude_PropertyAddress;

	private static int ClassNamesToInclude_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/ContentBrowserData.ContentBrowserDataClassFilter:ClassNamesToInclude")]
	public List<FName> ClassNamesToInclude;

	private static bool ClassNamesToExclude_IsValid;

	private static FFieldAddress ClassNamesToExclude_PropertyAddress;

	private static int ClassNamesToExclude_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/ContentBrowserData.ContentBrowserDataClassFilter:ClassNamesToExclude")]
	public List<FName> ClassNamesToExclude;

	private static bool RecursiveClassNamesToInclude_IsValid;

	private static FFieldAddress RecursiveClassNamesToInclude_PropertyAddress;

	private static int RecursiveClassNamesToInclude_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ContentBrowserData.ContentBrowserDataClassFilter:bRecursiveClassNamesToInclude")]
	public bool RecursiveClassNamesToInclude;

	private static bool RecursiveClassNamesToExclude_IsValid;

	private static FFieldAddress RecursiveClassNamesToExclude_PropertyAddress;

	private static int RecursiveClassNamesToExclude_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ContentBrowserData.ContentBrowserDataClassFilter:bRecursiveClassNamesToExclude")]
	public bool RecursiveClassNamesToExclude;

	private static bool FContentBrowserDataClassFilter_IsValid;

	private static int FContentBrowserDataClassFilter_StructSize;

	public FContentBrowserDataClassFilter Copy()
	{
		FContentBrowserDataClassFilter result = this;
		if (ClassNamesToInclude != null)
		{
			result.ClassNamesToInclude = new List<FName>(ClassNamesToInclude);
		}
		if (ClassNamesToExclude != null)
		{
			result.ClassNamesToExclude = new List<FName>(ClassNamesToExclude);
		}
		return result;
	}

	public static FContentBrowserDataClassFilter FromNative(IntPtr nativeBuffer)
	{
		return new FContentBrowserDataClassFilter(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FContentBrowserDataClassFilter value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FContentBrowserDataClassFilter FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FContentBrowserDataClassFilter(nativeBuffer + arrayIndex * FContentBrowserDataClassFilter_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FContentBrowserDataClassFilter value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FContentBrowserDataClassFilter_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FContentBrowserDataClassFilter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ContentBrowserData.ContentBrowserDataClassFilter");
			return;
		}
		new TArrayCopyMarshaler<FName>(1, ClassNamesToInclude_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ClassNamesToInclude_Offset), ClassNamesToInclude);
		new TArrayCopyMarshaler<FName>(1, ClassNamesToExclude_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ClassNamesToExclude_Offset), ClassNamesToExclude);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RecursiveClassNamesToInclude_Offset), 0, RecursiveClassNamesToInclude_PropertyAddress.Address, RecursiveClassNamesToInclude);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RecursiveClassNamesToExclude_Offset), 0, RecursiveClassNamesToExclude_PropertyAddress.Address, RecursiveClassNamesToExclude);
	}

	public FContentBrowserDataClassFilter(IntPtr nativeStruct)
	{
		if (!FContentBrowserDataClassFilter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ContentBrowserData.ContentBrowserDataClassFilter");
			ClassNamesToInclude = null;
			ClassNamesToExclude = null;
			RecursiveClassNamesToInclude = false;
			RecursiveClassNamesToExclude = false;
		}
		else
		{
			ClassNamesToInclude = new TArrayCopyMarshaler<FName>(1, ClassNamesToInclude_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ClassNamesToInclude_Offset));
			ClassNamesToExclude = new TArrayCopyMarshaler<FName>(1, ClassNamesToExclude_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ClassNamesToExclude_Offset));
			RecursiveClassNamesToInclude = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RecursiveClassNamesToInclude_Offset), 0, RecursiveClassNamesToInclude_PropertyAddress.Address);
			RecursiveClassNamesToExclude = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RecursiveClassNamesToExclude_Offset), 0, RecursiveClassNamesToExclude_PropertyAddress.Address);
		}
	}

	static FContentBrowserDataClassFilter()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FContentBrowserDataClassFilter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FContentBrowserDataClassFilter));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ContentBrowserData.ContentBrowserDataClassFilter");
		FContentBrowserDataClassFilter_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ClassNamesToInclude_PropertyAddress, intPtr, "ClassNamesToInclude");
		ClassNamesToInclude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ClassNamesToInclude");
		ClassNamesToInclude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ClassNamesToInclude", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ClassNamesToExclude_PropertyAddress, intPtr, "ClassNamesToExclude");
		ClassNamesToExclude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ClassNamesToExclude");
		ClassNamesToExclude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ClassNamesToExclude", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RecursiveClassNamesToInclude_PropertyAddress, intPtr, "bRecursiveClassNamesToInclude");
		RecursiveClassNamesToInclude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRecursiveClassNamesToInclude");
		RecursiveClassNamesToInclude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRecursiveClassNamesToInclude", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RecursiveClassNamesToExclude_PropertyAddress, intPtr, "bRecursiveClassNamesToExclude");
		RecursiveClassNamesToExclude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRecursiveClassNamesToExclude");
		RecursiveClassNamesToExclude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRecursiveClassNamesToExclude", Classes.FBoolProperty);
		FContentBrowserDataClassFilter_IsValid = intPtr != IntPtr.Zero && ClassNamesToInclude_IsValid && ClassNamesToExclude_IsValid && RecursiveClassNamesToInclude_IsValid && RecursiveClassNamesToExclude_IsValid;
		NativeReflection.LogStructIsValid("/Script/ContentBrowserData.ContentBrowserDataClassFilter", FContentBrowserDataClassFilter_IsValid);
	}
}
