using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGWeightedByCategoryEntryList", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGWeightedByCategoryEntryList
{
	private static bool CategoryEntry_IsValid;

	private static int CategoryEntry_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/PCG.PCGWeightedByCategoryEntryList:CategoryEntry")]
	public string CategoryEntry;

	private static bool IsDefault_IsValid;

	private static FFieldAddress IsDefault_PropertyAddress;

	private static int IsDefault_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGWeightedByCategoryEntryList:IsDefault")]
	public bool IsDefault;

	private static bool WeightedMeshEntries_IsValid;

	private static FFieldAddress WeightedMeshEntries_PropertyAddress;

	private static int WeightedMeshEntries_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/PCG.PCGWeightedByCategoryEntryList:WeightedMeshEntries")]
	public List<FPCGMeshSelectorWeightedEntry> WeightedMeshEntries;

	private static bool FPCGWeightedByCategoryEntryList_IsValid;

	private static int FPCGWeightedByCategoryEntryList_StructSize;

	public FPCGWeightedByCategoryEntryList Copy()
	{
		FPCGWeightedByCategoryEntryList result = this;
		if (WeightedMeshEntries != null)
		{
			result.WeightedMeshEntries = new List<FPCGMeshSelectorWeightedEntry>(WeightedMeshEntries);
		}
		return result;
	}

	public static FPCGWeightedByCategoryEntryList FromNative(IntPtr nativeBuffer)
	{
		return new FPCGWeightedByCategoryEntryList(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGWeightedByCategoryEntryList value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGWeightedByCategoryEntryList FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGWeightedByCategoryEntryList(nativeBuffer + arrayIndex * FPCGWeightedByCategoryEntryList_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGWeightedByCategoryEntryList value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGWeightedByCategoryEntryList_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGWeightedByCategoryEntryList_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGWeightedByCategoryEntryList");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, CategoryEntry_Offset), CategoryEntry);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsDefault_Offset), 0, IsDefault_PropertyAddress.Address, IsDefault);
		new TArrayCopyMarshaler<FPCGMeshSelectorWeightedEntry>(1, WeightedMeshEntries_PropertyAddress, CachedMarshalingDelegates<FPCGMeshSelectorWeightedEntry, FPCGMeshSelectorWeightedEntry>.FromNative, CachedMarshalingDelegates<FPCGMeshSelectorWeightedEntry, FPCGMeshSelectorWeightedEntry>.ToNative).ToNative(IntPtr.Add(nativeStruct, WeightedMeshEntries_Offset), WeightedMeshEntries);
	}

	public FPCGWeightedByCategoryEntryList(IntPtr nativeStruct)
	{
		if (!FPCGWeightedByCategoryEntryList_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGWeightedByCategoryEntryList");
			CategoryEntry = FStringMarshaler.DefaultString;
			IsDefault = false;
			WeightedMeshEntries = null;
		}
		else
		{
			CategoryEntry = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, CategoryEntry_Offset));
			IsDefault = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsDefault_Offset), 0, IsDefault_PropertyAddress.Address);
			WeightedMeshEntries = new TArrayCopyMarshaler<FPCGMeshSelectorWeightedEntry>(1, WeightedMeshEntries_PropertyAddress, CachedMarshalingDelegates<FPCGMeshSelectorWeightedEntry, FPCGMeshSelectorWeightedEntry>.FromNative, CachedMarshalingDelegates<FPCGMeshSelectorWeightedEntry, FPCGMeshSelectorWeightedEntry>.ToNative).FromNative(IntPtr.Add(nativeStruct, WeightedMeshEntries_Offset));
		}
	}

	static FPCGWeightedByCategoryEntryList()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGWeightedByCategoryEntryList)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGWeightedByCategoryEntryList));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGWeightedByCategoryEntryList");
		FPCGWeightedByCategoryEntryList_StructSize = NativeReflection.GetStructSize(intPtr);
		CategoryEntry_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CategoryEntry");
		CategoryEntry_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CategoryEntry", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDefault_PropertyAddress, intPtr, "IsDefault");
		IsDefault_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IsDefault");
		IsDefault_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IsDefault", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref WeightedMeshEntries_PropertyAddress, intPtr, "WeightedMeshEntries");
		WeightedMeshEntries_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WeightedMeshEntries");
		WeightedMeshEntries_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WeightedMeshEntries", Classes.FArrayProperty);
		FPCGWeightedByCategoryEntryList_IsValid = intPtr != IntPtr.Zero && CategoryEntry_IsValid && IsDefault_IsValid && WeightedMeshEntries_IsValid;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGWeightedByCategoryEntryList", FPCGWeightedByCategoryEntryList_IsValid);
	}
}
