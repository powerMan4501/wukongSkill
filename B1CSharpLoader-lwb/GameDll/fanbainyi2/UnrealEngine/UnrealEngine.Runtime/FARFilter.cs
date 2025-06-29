using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 4105)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.ARFilter", "CoreUObject", UnrealModuleType.Engine)]
public struct FARFilter
{
	private static bool PackageNames_IsValid;

	private static FFieldAddress PackageNames_PropertyAddress;

	private static int PackageNames_Offset;

	[UProperty(Flags = (PropFlags)4503599627436549uL)]
	[UMetaPath("/Script/CoreUObject.ARFilter:PackageNames")]
	public List<FName> PackageNames;

	private static bool PackagePaths_IsValid;

	private static FFieldAddress PackagePaths_PropertyAddress;

	private static int PackagePaths_Offset;

	[UProperty(Flags = (PropFlags)4503599627436549uL)]
	[UMetaPath("/Script/CoreUObject.ARFilter:PackagePaths")]
	public List<FName> PackagePaths;

	private static bool ObjectPaths_IsValid;

	private static FFieldAddress ObjectPaths_PropertyAddress;

	private static int ObjectPaths_Offset;

	[UProperty(Flags = (PropFlags)4503599627436549uL)]
	[UMetaPath("/Script/CoreUObject.ARFilter:ObjectPaths")]
	public List<FName> ObjectPaths;

	private static bool ClassNames_IsValid;

	private static FFieldAddress ClassNames_PropertyAddress;

	private static int ClassNames_Offset;

	[UProperty(Flags = (PropFlags)4503599627436549uL)]
	[UMetaPath("/Script/CoreUObject.ARFilter:ClassNames")]
	public List<FName> ClassNames;

	private static bool RecursiveClassesExclusionSet_IsValid;

	private static FFieldAddress RecursiveClassesExclusionSet_PropertyAddress;

	private static int RecursiveClassesExclusionSet_Offset;

	[UProperty(Flags = (PropFlags)4503599627436037uL)]
	[UMetaPath("/Script/CoreUObject.ARFilter:RecursiveClassesExclusionSet")]
	public HashSet<FName> RecursiveClassesExclusionSet;

	private static bool RecursivePaths_IsValid;

	private static FFieldAddress RecursivePaths_PropertyAddress;

	private static int RecursivePaths_Offset;

	[UProperty(Flags = (PropFlags)6755469234340357uL)]
	[UMetaPath("/Script/CoreUObject.ARFilter:bRecursivePaths")]
	public bool RecursivePaths;

	private static bool RecursiveClasses_IsValid;

	private static FFieldAddress RecursiveClasses_PropertyAddress;

	private static int RecursiveClasses_Offset;

	[UProperty(Flags = (PropFlags)6755469234340357uL)]
	[UMetaPath("/Script/CoreUObject.ARFilter:bRecursiveClasses")]
	public bool RecursiveClasses;

	private static bool IncludeOnlyOnDiskAssets_IsValid;

	private static FFieldAddress IncludeOnlyOnDiskAssets_PropertyAddress;

	private static int IncludeOnlyOnDiskAssets_Offset;

	[UProperty(Flags = (PropFlags)6755469234340357uL)]
	[UMetaPath("/Script/CoreUObject.ARFilter:bIncludeOnlyOnDiskAssets")]
	public bool IncludeOnlyOnDiskAssets;

	private static bool FARFilter_IsValid;

	private static int FARFilter_StructSize;

	public FARFilter Copy()
	{
		FARFilter result = this;
		if (PackageNames != null)
		{
			result.PackageNames = new List<FName>(PackageNames);
		}
		if (PackagePaths != null)
		{
			result.PackagePaths = new List<FName>(PackagePaths);
		}
		if (ObjectPaths != null)
		{
			result.ObjectPaths = new List<FName>(ObjectPaths);
		}
		if (ClassNames != null)
		{
			result.ClassNames = new List<FName>(ClassNames);
		}
		if (RecursiveClassesExclusionSet != null)
		{
			result.RecursiveClassesExclusionSet = new HashSet<FName>(RecursiveClassesExclusionSet);
		}
		return result;
	}

	public static FARFilter FromNative(IntPtr nativeBuffer)
	{
		return new FARFilter(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FARFilter value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FARFilter FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FARFilter(nativeBuffer + arrayIndex * FARFilter_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FARFilter value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FARFilter_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FARFilter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.ARFilter");
			return;
		}
		new TArrayCopyMarshaler<FName>(1, PackageNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, PackageNames_Offset), PackageNames);
		new TArrayCopyMarshaler<FName>(1, PackagePaths_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, PackagePaths_Offset), PackagePaths);
		new TArrayCopyMarshaler<FName>(1, ObjectPaths_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ObjectPaths_Offset), ObjectPaths);
		new TArrayCopyMarshaler<FName>(1, ClassNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ClassNames_Offset), ClassNames);
		new TSetCopyMarshaler<FName>(1, RecursiveClassesExclusionSet_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, RecursiveClassesExclusionSet_Offset), RecursiveClassesExclusionSet);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RecursivePaths_Offset), 0, RecursivePaths_PropertyAddress.Address, RecursivePaths);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RecursiveClasses_Offset), 0, RecursiveClasses_PropertyAddress.Address, RecursiveClasses);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IncludeOnlyOnDiskAssets_Offset), 0, IncludeOnlyOnDiskAssets_PropertyAddress.Address, IncludeOnlyOnDiskAssets);
	}

	public FARFilter(IntPtr nativeStruct)
	{
		if (!FARFilter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.ARFilter");
			PackageNames = null;
			PackagePaths = null;
			ObjectPaths = null;
			ClassNames = null;
			RecursiveClassesExclusionSet = null;
			RecursivePaths = false;
			RecursiveClasses = false;
			IncludeOnlyOnDiskAssets = false;
		}
		else
		{
			PackageNames = new TArrayCopyMarshaler<FName>(1, PackageNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, PackageNames_Offset));
			PackagePaths = new TArrayCopyMarshaler<FName>(1, PackagePaths_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, PackagePaths_Offset));
			ObjectPaths = new TArrayCopyMarshaler<FName>(1, ObjectPaths_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ObjectPaths_Offset));
			ClassNames = new TArrayCopyMarshaler<FName>(1, ClassNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ClassNames_Offset));
			RecursiveClassesExclusionSet = new TSetCopyMarshaler<FName>(1, RecursiveClassesExclusionSet_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, RecursiveClassesExclusionSet_Offset));
			RecursivePaths = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RecursivePaths_Offset), 0, RecursivePaths_PropertyAddress.Address);
			RecursiveClasses = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RecursiveClasses_Offset), 0, RecursiveClasses_PropertyAddress.Address);
			IncludeOnlyOnDiskAssets = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IncludeOnlyOnDiskAssets_Offset), 0, IncludeOnlyOnDiskAssets_PropertyAddress.Address);
		}
	}

	static FARFilter()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FARFilter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FARFilter));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.ARFilter");
		FARFilter_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref PackageNames_PropertyAddress, intPtr, "PackageNames");
		PackageNames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PackageNames");
		PackageNames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PackageNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref PackagePaths_PropertyAddress, intPtr, "PackagePaths");
		PackagePaths_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PackagePaths");
		PackagePaths_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PackagePaths", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ObjectPaths_PropertyAddress, intPtr, "ObjectPaths");
		ObjectPaths_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ObjectPaths");
		ObjectPaths_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ObjectPaths", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ClassNames_PropertyAddress, intPtr, "ClassNames");
		ClassNames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ClassNames");
		ClassNames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ClassNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RecursiveClassesExclusionSet_PropertyAddress, intPtr, "RecursiveClassesExclusionSet");
		RecursiveClassesExclusionSet_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RecursiveClassesExclusionSet");
		RecursiveClassesExclusionSet_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RecursiveClassesExclusionSet", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref RecursivePaths_PropertyAddress, intPtr, "bRecursivePaths");
		RecursivePaths_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRecursivePaths");
		RecursivePaths_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRecursivePaths", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RecursiveClasses_PropertyAddress, intPtr, "bRecursiveClasses");
		RecursiveClasses_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRecursiveClasses");
		RecursiveClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRecursiveClasses", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IncludeOnlyOnDiskAssets_PropertyAddress, intPtr, "bIncludeOnlyOnDiskAssets");
		IncludeOnlyOnDiskAssets_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIncludeOnlyOnDiskAssets");
		IncludeOnlyOnDiskAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIncludeOnlyOnDiskAssets", Classes.FBoolProperty);
		FARFilter_IsValid = intPtr != IntPtr.Zero && PackageNames_IsValid && PackagePaths_IsValid && ObjectPaths_IsValid && ClassNames_IsValid && RecursiveClassesExclusionSet_IsValid && RecursivePaths_IsValid && RecursiveClasses_IsValid && IncludeOnlyOnDiskAssets_IsValid;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.ARFilter", FARFilter_IsValid);
	}
}
