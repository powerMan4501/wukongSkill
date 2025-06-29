using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.WorldPartitionStreamingQuerySource", "Engine", UnrealModuleType.Engine)]
public struct FWorldPartitionStreamingQuerySource
{
	private static bool Location_IsValid;

	private static int Location_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.WorldPartitionStreamingQuerySource:Location")]
	public FVector Location;

	private static bool Radius_IsValid;

	private static int Radius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.WorldPartitionStreamingQuerySource:Radius")]
	public float Radius;

	private static bool UseGridLoadingRange_IsValid;

	private static FFieldAddress UseGridLoadingRange_PropertyAddress;

	private static int UseGridLoadingRange_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.WorldPartitionStreamingQuerySource:bUseGridLoadingRange")]
	public bool UseGridLoadingRange;

	private static bool DataLayers_IsValid;

	private static FFieldAddress DataLayers_PropertyAddress;

	private static int DataLayers_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.WorldPartitionStreamingQuerySource:DataLayers")]
	public List<FName> DataLayers;

	private static bool DataLayersOnly_IsValid;

	private static FFieldAddress DataLayersOnly_PropertyAddress;

	private static int DataLayersOnly_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.WorldPartitionStreamingQuerySource:bDataLayersOnly")]
	public bool DataLayersOnly;

	private static bool SpatialQuery_IsValid;

	private static FFieldAddress SpatialQuery_PropertyAddress;

	private static int SpatialQuery_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.WorldPartitionStreamingQuerySource:bSpatialQuery")]
	public bool SpatialQuery;

	private static bool FWorldPartitionStreamingQuerySource_IsValid;

	private static int FWorldPartitionStreamingQuerySource_StructSize;

	public FWorldPartitionStreamingQuerySource Copy()
	{
		FWorldPartitionStreamingQuerySource result = this;
		if (DataLayers != null)
		{
			result.DataLayers = new List<FName>(DataLayers);
		}
		return result;
	}

	public static FWorldPartitionStreamingQuerySource FromNative(IntPtr nativeBuffer)
	{
		return new FWorldPartitionStreamingQuerySource(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FWorldPartitionStreamingQuerySource value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FWorldPartitionStreamingQuerySource FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FWorldPartitionStreamingQuerySource(nativeBuffer + arrayIndex * FWorldPartitionStreamingQuerySource_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FWorldPartitionStreamingQuerySource value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FWorldPartitionStreamingQuerySource_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FWorldPartitionStreamingQuerySource_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.WorldPartitionStreamingQuerySource");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Location_Offset), Location);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Radius_Offset), Radius);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseGridLoadingRange_Offset), 0, UseGridLoadingRange_PropertyAddress.Address, UseGridLoadingRange);
		new TArrayCopyMarshaler<FName>(1, DataLayers_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, DataLayers_Offset), DataLayers);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DataLayersOnly_Offset), 0, DataLayersOnly_PropertyAddress.Address, DataLayersOnly);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SpatialQuery_Offset), 0, SpatialQuery_PropertyAddress.Address, SpatialQuery);
	}

	public FWorldPartitionStreamingQuerySource(IntPtr nativeStruct)
	{
		if (!FWorldPartitionStreamingQuerySource_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.WorldPartitionStreamingQuerySource");
			Location = default(FVector);
			Radius = 0f;
			UseGridLoadingRange = false;
			DataLayers = null;
			DataLayersOnly = false;
			SpatialQuery = false;
		}
		else
		{
			Location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Location_Offset));
			Radius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Radius_Offset));
			UseGridLoadingRange = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseGridLoadingRange_Offset), 0, UseGridLoadingRange_PropertyAddress.Address);
			DataLayers = new TArrayCopyMarshaler<FName>(1, DataLayers_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, DataLayers_Offset));
			DataLayersOnly = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DataLayersOnly_Offset), 0, DataLayersOnly_PropertyAddress.Address);
			SpatialQuery = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SpatialQuery_Offset), 0, SpatialQuery_PropertyAddress.Address);
		}
	}

	static FWorldPartitionStreamingQuerySource()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FWorldPartitionStreamingQuerySource)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FWorldPartitionStreamingQuerySource));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.WorldPartitionStreamingQuerySource");
		FWorldPartitionStreamingQuerySource_StructSize = NativeReflection.GetStructSize(intPtr);
		Location_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Location");
		Location_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Location", Classes.FStructProperty);
		Radius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Radius");
		Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref UseGridLoadingRange_PropertyAddress, intPtr, "bUseGridLoadingRange");
		UseGridLoadingRange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseGridLoadingRange");
		UseGridLoadingRange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseGridLoadingRange", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DataLayers_PropertyAddress, intPtr, "DataLayers");
		DataLayers_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DataLayers");
		DataLayers_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DataLayers", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DataLayersOnly_PropertyAddress, intPtr, "bDataLayersOnly");
		DataLayersOnly_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDataLayersOnly");
		DataLayersOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDataLayersOnly", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SpatialQuery_PropertyAddress, intPtr, "bSpatialQuery");
		SpatialQuery_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSpatialQuery");
		SpatialQuery_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSpatialQuery", Classes.FBoolProperty);
		FWorldPartitionStreamingQuerySource_IsValid = intPtr != IntPtr.Zero && Location_IsValid && Radius_IsValid && UseGridLoadingRange_IsValid && DataLayers_IsValid && DataLayersOnly_IsValid && SpatialQuery_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.WorldPartitionStreamingQuerySource", FWorldPartitionStreamingQuerySource_IsValid);
	}
}
