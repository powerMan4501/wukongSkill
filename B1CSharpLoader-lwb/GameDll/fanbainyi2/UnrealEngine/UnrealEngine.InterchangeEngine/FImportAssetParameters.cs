using System;
using System.Collections.Generic;
using UnrealEngine.InterchangeCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.InterchangeEngine;

[UStruct(Flags = 4101)]
[BlueprintType]
[UMetaPath("/Script/InterchangeEngine.ImportAssetParameters", "InterchangeEngine", UnrealModuleType.Engine)]
public struct FImportAssetParameters
{
	private static bool ReimportAsset_IsValid;

	private static int ReimportAsset_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/InterchangeEngine.ImportAssetParameters:ReimportAsset")]
	public UObject ReimportAsset;

	private static bool IsAutomated_IsValid;

	private static FFieldAddress IsAutomated_PropertyAddress;

	private static int IsAutomated_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/InterchangeEngine.ImportAssetParameters:bIsAutomated")]
	public bool IsAutomated;

	private static bool OverridePipelines_IsValid;

	private static FFieldAddress OverridePipelines_PropertyAddress;

	private static int OverridePipelines_Offset;

	[UProperty(Flags = (PropFlags)5629499534213637uL)]
	[UMetaPath("/Script/InterchangeEngine.ImportAssetParameters:OverridePipelines")]
	public List<UInterchangePipelineBase> OverridePipelines;

	private static bool OnAssetDone_IsValid;

	private static int OnAssetDone_Offset;

	[UProperty(Flags = (PropFlags)4503668347372037uL)]
	[UMetaPath("/Script/InterchangeEngine.ImportAssetParameters:OnAssetDone")]
	public FOnObjectImportDoneDynamic OnAssetDone;

	private static bool OnAssetsImportDone_IsValid;

	private static int OnAssetsImportDone_Offset;

	[UProperty(Flags = (PropFlags)4503668347372037uL)]
	[UMetaPath("/Script/InterchangeEngine.ImportAssetParameters:OnAssetsImportDone")]
	public FOnImportDoneDynamic OnAssetsImportDone;

	private static bool OnSceneObjectDone_IsValid;

	private static int OnSceneObjectDone_Offset;

	[UProperty(Flags = (PropFlags)4503668347372037uL)]
	[UMetaPath("/Script/InterchangeEngine.ImportAssetParameters:OnSceneObjectDone")]
	public FOnObjectImportDoneDynamic OnSceneObjectDone;

	private static bool OnSceneImportDone_IsValid;

	private static int OnSceneImportDone_Offset;

	[UProperty(Flags = (PropFlags)4503668347372037uL)]
	[UMetaPath("/Script/InterchangeEngine.ImportAssetParameters:OnSceneImportDone")]
	public FOnImportDoneDynamic OnSceneImportDone;

	private static bool FImportAssetParameters_IsValid;

	private static int FImportAssetParameters_StructSize;

	public FImportAssetParameters Copy()
	{
		FImportAssetParameters result = this;
		if (OverridePipelines != null)
		{
			result.OverridePipelines = new List<UInterchangePipelineBase>(OverridePipelines);
		}
		return result;
	}

	public static FImportAssetParameters FromNative(IntPtr nativeBuffer)
	{
		return new FImportAssetParameters(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FImportAssetParameters value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FImportAssetParameters FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FImportAssetParameters(nativeBuffer + arrayIndex * FImportAssetParameters_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FImportAssetParameters value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FImportAssetParameters_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FImportAssetParameters_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/InterchangeEngine.ImportAssetParameters");
			return;
		}
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(nativeStruct, ReimportAsset_Offset), ReimportAsset);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsAutomated_Offset), 0, IsAutomated_PropertyAddress.Address, IsAutomated);
		new TArrayCopyMarshaler<UInterchangePipelineBase>(1, OverridePipelines_PropertyAddress, CachedMarshalingDelegates<UInterchangePipelineBase, UObjectMarshaler<UInterchangePipelineBase>>.FromNative, CachedMarshalingDelegates<UInterchangePipelineBase, UObjectMarshaler<UInterchangePipelineBase>>.ToNative).ToNative(IntPtr.Add(nativeStruct, OverridePipelines_Offset), OverridePipelines);
		FDelegateMarshaler<FOnObjectImportDoneDynamic>.ToNative(IntPtr.Add(nativeStruct, OnAssetDone_Offset), OnAssetDone);
		FDelegateMarshaler<FOnImportDoneDynamic>.ToNative(IntPtr.Add(nativeStruct, OnAssetsImportDone_Offset), OnAssetsImportDone);
		FDelegateMarshaler<FOnObjectImportDoneDynamic>.ToNative(IntPtr.Add(nativeStruct, OnSceneObjectDone_Offset), OnSceneObjectDone);
		FDelegateMarshaler<FOnImportDoneDynamic>.ToNative(IntPtr.Add(nativeStruct, OnSceneImportDone_Offset), OnSceneImportDone);
	}

	public FImportAssetParameters(IntPtr nativeStruct)
	{
		if (!FImportAssetParameters_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/InterchangeEngine.ImportAssetParameters");
			ReimportAsset = null;
			IsAutomated = false;
			OverridePipelines = null;
			OnAssetDone = new FOnObjectImportDoneDynamic();
			OnAssetsImportDone = new FOnImportDoneDynamic();
			OnSceneObjectDone = new FOnObjectImportDoneDynamic();
			OnSceneImportDone = new FOnImportDoneDynamic();
		}
		else
		{
			ReimportAsset = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(nativeStruct, ReimportAsset_Offset));
			IsAutomated = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsAutomated_Offset), 0, IsAutomated_PropertyAddress.Address);
			OverridePipelines = new TArrayCopyMarshaler<UInterchangePipelineBase>(1, OverridePipelines_PropertyAddress, CachedMarshalingDelegates<UInterchangePipelineBase, UObjectMarshaler<UInterchangePipelineBase>>.FromNative, CachedMarshalingDelegates<UInterchangePipelineBase, UObjectMarshaler<UInterchangePipelineBase>>.ToNative).FromNative(IntPtr.Add(nativeStruct, OverridePipelines_Offset));
			OnAssetDone = FDelegateMarshaler<FOnObjectImportDoneDynamic>.FromNative(IntPtr.Add(nativeStruct, OnAssetDone_Offset));
			OnAssetsImportDone = FDelegateMarshaler<FOnImportDoneDynamic>.FromNative(IntPtr.Add(nativeStruct, OnAssetsImportDone_Offset));
			OnSceneObjectDone = FDelegateMarshaler<FOnObjectImportDoneDynamic>.FromNative(IntPtr.Add(nativeStruct, OnSceneObjectDone_Offset));
			OnSceneImportDone = FDelegateMarshaler<FOnImportDoneDynamic>.FromNative(IntPtr.Add(nativeStruct, OnSceneImportDone_Offset));
		}
	}

	static FImportAssetParameters()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FImportAssetParameters)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FImportAssetParameters));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/InterchangeEngine.ImportAssetParameters");
		FImportAssetParameters_StructSize = NativeReflection.GetStructSize(intPtr);
		ReimportAsset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReimportAsset");
		ReimportAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReimportAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsAutomated_PropertyAddress, intPtr, "bIsAutomated");
		IsAutomated_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsAutomated");
		IsAutomated_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsAutomated", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OverridePipelines_PropertyAddress, intPtr, "OverridePipelines");
		OverridePipelines_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OverridePipelines");
		OverridePipelines_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OverridePipelines", Classes.FArrayProperty);
		OnAssetDone_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnAssetDone");
		OnAssetDone_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnAssetDone", Classes.FDelegateProperty);
		OnAssetsImportDone_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnAssetsImportDone");
		OnAssetsImportDone_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnAssetsImportDone", Classes.FDelegateProperty);
		OnSceneObjectDone_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnSceneObjectDone");
		OnSceneObjectDone_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnSceneObjectDone", Classes.FDelegateProperty);
		OnSceneImportDone_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnSceneImportDone");
		OnSceneImportDone_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnSceneImportDone", Classes.FDelegateProperty);
		FImportAssetParameters_IsValid = intPtr != IntPtr.Zero && ReimportAsset_IsValid && IsAutomated_IsValid && OverridePipelines_IsValid && OnAssetDone_IsValid && OnAssetsImportDone_IsValid && OnSceneObjectDone_IsValid && OnSceneImportDone_IsValid;
		NativeReflection.LogStructIsValid("/Script/InterchangeEngine.ImportAssetParameters", FImportAssetParameters_IsValid);
	}
}
