using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGMatchAndSetWeightedByCategoryEntryList", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGMatchAndSetWeightedByCategoryEntryList
{
	private static bool CategoryValue_IsValid;

	private static int CategoryValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGMatchAndSetWeightedByCategoryEntryList:CategoryValue")]
	public FPCGMetadataTypesConstantStruct CategoryValue;

	private static bool IsDefault_IsValid;

	private static FFieldAddress IsDefault_PropertyAddress;

	private static int IsDefault_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMatchAndSetWeightedByCategoryEntryList:bIsDefault")]
	public bool IsDefault;

	private static bool WeightedEntries_IsValid;

	private static FFieldAddress WeightedEntries_PropertyAddress;

	private static int WeightedEntries_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/PCG.PCGMatchAndSetWeightedByCategoryEntryList:WeightedEntries")]
	public List<FPCGMatchAndSetWeightedEntry> WeightedEntries;

	private static bool FPCGMatchAndSetWeightedByCategoryEntryList_IsValid;

	private static int FPCGMatchAndSetWeightedByCategoryEntryList_StructSize;

	public FPCGMatchAndSetWeightedByCategoryEntryList Copy()
	{
		FPCGMatchAndSetWeightedByCategoryEntryList result = this;
		if (WeightedEntries != null)
		{
			result.WeightedEntries = new List<FPCGMatchAndSetWeightedEntry>(WeightedEntries);
		}
		return result;
	}

	public static FPCGMatchAndSetWeightedByCategoryEntryList FromNative(IntPtr nativeBuffer)
	{
		return new FPCGMatchAndSetWeightedByCategoryEntryList(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGMatchAndSetWeightedByCategoryEntryList value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGMatchAndSetWeightedByCategoryEntryList FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGMatchAndSetWeightedByCategoryEntryList(nativeBuffer + arrayIndex * FPCGMatchAndSetWeightedByCategoryEntryList_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGMatchAndSetWeightedByCategoryEntryList value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGMatchAndSetWeightedByCategoryEntryList_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGMatchAndSetWeightedByCategoryEntryList_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGMatchAndSetWeightedByCategoryEntryList");
			return;
		}
		FPCGMetadataTypesConstantStruct.ToNative(IntPtr.Add(nativeStruct, CategoryValue_Offset), CategoryValue);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsDefault_Offset), 0, IsDefault_PropertyAddress.Address, IsDefault);
		new TArrayCopyMarshaler<FPCGMatchAndSetWeightedEntry>(1, WeightedEntries_PropertyAddress, CachedMarshalingDelegates<FPCGMatchAndSetWeightedEntry, FPCGMatchAndSetWeightedEntry>.FromNative, CachedMarshalingDelegates<FPCGMatchAndSetWeightedEntry, FPCGMatchAndSetWeightedEntry>.ToNative).ToNative(IntPtr.Add(nativeStruct, WeightedEntries_Offset), WeightedEntries);
	}

	public FPCGMatchAndSetWeightedByCategoryEntryList(IntPtr nativeStruct)
	{
		if (!FPCGMatchAndSetWeightedByCategoryEntryList_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGMatchAndSetWeightedByCategoryEntryList");
			CategoryValue = default(FPCGMetadataTypesConstantStruct);
			IsDefault = false;
			WeightedEntries = null;
		}
		else
		{
			CategoryValue = FPCGMetadataTypesConstantStruct.FromNative(IntPtr.Add(nativeStruct, CategoryValue_Offset));
			IsDefault = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsDefault_Offset), 0, IsDefault_PropertyAddress.Address);
			WeightedEntries = new TArrayCopyMarshaler<FPCGMatchAndSetWeightedEntry>(1, WeightedEntries_PropertyAddress, CachedMarshalingDelegates<FPCGMatchAndSetWeightedEntry, FPCGMatchAndSetWeightedEntry>.FromNative, CachedMarshalingDelegates<FPCGMatchAndSetWeightedEntry, FPCGMatchAndSetWeightedEntry>.ToNative).FromNative(IntPtr.Add(nativeStruct, WeightedEntries_Offset));
		}
	}

	static FPCGMatchAndSetWeightedByCategoryEntryList()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGMatchAndSetWeightedByCategoryEntryList)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGMatchAndSetWeightedByCategoryEntryList));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGMatchAndSetWeightedByCategoryEntryList");
		FPCGMatchAndSetWeightedByCategoryEntryList_StructSize = NativeReflection.GetStructSize(intPtr);
		CategoryValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CategoryValue");
		CategoryValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CategoryValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDefault_PropertyAddress, intPtr, "bIsDefault");
		IsDefault_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsDefault");
		IsDefault_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsDefault", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref WeightedEntries_PropertyAddress, intPtr, "WeightedEntries");
		WeightedEntries_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WeightedEntries");
		WeightedEntries_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WeightedEntries", Classes.FArrayProperty);
		FPCGMatchAndSetWeightedByCategoryEntryList_IsValid = intPtr != IntPtr.Zero && CategoryValue_IsValid && IsDefault_IsValid && WeightedEntries_IsValid;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGMatchAndSetWeightedByCategoryEntryList", FPCGMatchAndSetWeightedByCategoryEntryList_IsValid);
	}
}
