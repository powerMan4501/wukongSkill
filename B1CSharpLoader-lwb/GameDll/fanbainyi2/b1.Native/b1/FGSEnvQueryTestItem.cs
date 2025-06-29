using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/b1.GSEnvQueryTestItem", "b1", UnrealModuleType.Game)]
public struct FGSEnvQueryTestItem
{
	private static bool ItemLocation_IsValid;

	private static int ItemLocation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.GSEnvQueryTestItem:ItemLocation")]
	public FVector ItemLocation;

	private static bool ContextActors_IsValid;

	private static FFieldAddress ContextActors_PropertyAddress;

	private static int ContextActors_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/b1.GSEnvQueryTestItem:ContextActors")]
	public List<AActor> ContextActors;

	private static bool ContextLocations_IsValid;

	private static FFieldAddress ContextLocations_PropertyAddress;

	private static int ContextLocations_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/b1.GSEnvQueryTestItem:ContextLocations")]
	public List<FVector> ContextLocations;

	private static bool ContextPerItem_IsValid;

	private static FFieldAddress ContextPerItem_PropertyAddress;

	private static int ContextPerItem_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.GSEnvQueryTestItem:bContextPerItem")]
	public bool ContextPerItem;

	private static bool FGSEnvQueryTestItem_IsValid;

	private static int FGSEnvQueryTestItem_StructSize;

	public FGSEnvQueryTestItem Copy()
	{
		FGSEnvQueryTestItem result = this;
		if (ContextActors != null)
		{
			result.ContextActors = new List<AActor>(ContextActors);
		}
		if (ContextLocations != null)
		{
			result.ContextLocations = new List<FVector>(ContextLocations);
		}
		return result;
	}

	public static FGSEnvQueryTestItem FromNative(IntPtr nativeBuffer)
	{
		return new FGSEnvQueryTestItem(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSEnvQueryTestItem value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSEnvQueryTestItem FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSEnvQueryTestItem(nativeBuffer + arrayIndex * FGSEnvQueryTestItem_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSEnvQueryTestItem value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSEnvQueryTestItem_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSEnvQueryTestItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.GSEnvQueryTestItem");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, ItemLocation_Offset), ItemLocation);
		new TArrayCopyMarshaler<AActor>(1, ContextActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ContextActors_Offset), ContextActors);
		new TArrayCopyMarshaler<FVector>(1, ContextLocations_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ContextLocations_Offset), ContextLocations);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ContextPerItem_Offset), 0, ContextPerItem_PropertyAddress.Address, ContextPerItem);
	}

	public FGSEnvQueryTestItem(IntPtr nativeStruct)
	{
		if (!FGSEnvQueryTestItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.GSEnvQueryTestItem");
			ItemLocation = default(FVector);
			ContextActors = null;
			ContextLocations = null;
			ContextPerItem = false;
		}
		else
		{
			ItemLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, ItemLocation_Offset));
			ContextActors = new TArrayCopyMarshaler<AActor>(1, ContextActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ContextActors_Offset));
			ContextLocations = new TArrayCopyMarshaler<FVector>(1, ContextLocations_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ContextLocations_Offset));
			ContextPerItem = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ContextPerItem_Offset), 0, ContextPerItem_PropertyAddress.Address);
		}
	}

	static FGSEnvQueryTestItem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSEnvQueryTestItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSEnvQueryTestItem));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.GSEnvQueryTestItem");
		FGSEnvQueryTestItem_StructSize = NativeReflection.GetStructSize(intPtr);
		ItemLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ItemLocation");
		ItemLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ItemLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ContextActors_PropertyAddress, intPtr, "ContextActors");
		ContextActors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ContextActors");
		ContextActors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ContextActors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ContextLocations_PropertyAddress, intPtr, "ContextLocations");
		ContextLocations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ContextLocations");
		ContextLocations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ContextLocations", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ContextPerItem_PropertyAddress, intPtr, "bContextPerItem");
		ContextPerItem_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bContextPerItem");
		ContextPerItem_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bContextPerItem", Classes.FBoolProperty);
		FGSEnvQueryTestItem_IsValid = intPtr != IntPtr.Zero && ItemLocation_IsValid && ContextActors_IsValid && ContextLocations_IsValid && ContextPerItem_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.GSEnvQueryTestItem", FGSEnvQueryTestItem_IsValid);
	}
}
