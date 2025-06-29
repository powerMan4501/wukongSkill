using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FGSForceFightTriggerUnitFilter")]
public struct FGSForceFightTriggerUnitFilter
{
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("筛选类型")]
	[Tooltip("筛选单位的类型。")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSForceFightTriggerUnitFilter:FilterType")]
	public EGSForceFightUnitFilterType FilterType;

	[VisibleAnywhere]
	[BlueprintReadWrite]
	[DisplayName("筛选单位")]
	[UProperty]
	[Tooltip("被筛选的单位。")]
	[USharpPath("/Script/b1-Managed.FGSForceFightTriggerUnitFilter:FilterUnits")]
	public List<TSoftObject<BGUCharacterCS>> FilterUnits;

	[VisibleAnywhere]
	[BlueprintReadWrite]
	[DisplayName("筛选单位")]
	[Tooltip("被筛选的单位。")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSForceFightTriggerUnitFilter:FilterTamers")]
	public List<TSoftObject<BUTamerActor>> FilterTamers;

	[UProperty]
	[EditAnywhere]
	[DisplayName("筛选单位")]
	[BlueprintReadWrite]
	[Tooltip("被筛选的单位。")]
	[USharpPath("/Script/b1-Managed.FGSForceFightTriggerUnitFilter:FilterTamerRefs")]
	public List<FGsActorGuidReference> FilterTamerRefs;

	[Tooltip("被筛选的单位类型。")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("筛选单位类型")]
	[USharpPath("/Script/b1-Managed.FGSForceFightTriggerUnitFilter:FilterUnitTypes")]
	public List<EGSForceFightUnitType> FilterUnitTypes;

	private static int FGSForceFightTriggerUnitFilter_StructSize;

	private static int FGSForceFightTriggerUnitFilter_IsValid;

	private static bool FilterType_IsValid;

	private static int FilterType_Offset;

	private static FFieldAddress FilterType_PropertyAddress;

	private static bool FilterUnits_IsValid;

	private static int FilterUnits_Offset;

	private static FFieldAddress FilterUnits_PropertyAddress;

	private static bool FilterTamers_IsValid;

	private static int FilterTamers_Offset;

	private static FFieldAddress FilterTamers_PropertyAddress;

	private static bool FilterTamerRefs_IsValid;

	private static int FilterTamerRefs_Offset;

	private static FFieldAddress FilterTamerRefs_PropertyAddress;

	private static bool FilterUnitTypes_IsValid;

	private static int FilterUnitTypes_Offset;

	private static FFieldAddress FilterUnitTypes_PropertyAddress;

	public FGSForceFightTriggerUnitFilter Copy()
	{
		FGSForceFightTriggerUnitFilter result = this;
		if (FilterUnits != null)
		{
			result.FilterUnits = new List<TSoftObject<BGUCharacterCS>>(FilterUnits);
		}
		if (FilterTamers != null)
		{
			result.FilterTamers = new List<TSoftObject<BUTamerActor>>(FilterTamers);
		}
		if (FilterTamerRefs != null)
		{
			result.FilterTamerRefs = new List<FGsActorGuidReference>(FilterTamerRefs);
		}
		if (FilterUnitTypes != null)
		{
			result.FilterUnitTypes = new List<EGSForceFightUnitType>(FilterUnitTypes);
		}
		return result;
	}

	public static FGSForceFightTriggerUnitFilter FromNative(IntPtr nativeBuffer)
	{
		return new FGSForceFightTriggerUnitFilter(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSForceFightTriggerUnitFilter value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSForceFightTriggerUnitFilter FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSForceFightTriggerUnitFilter(IntPtr.Add(nativeBuffer, arrayIndex * FGSForceFightTriggerUnitFilter_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSForceFightTriggerUnitFilter value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSForceFightTriggerUnitFilter_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSForceFightTriggerUnitFilter_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSForceFightTriggerUnitFilter");
			return;
		}
		EnumMarshaler<EGSForceFightUnitFilterType>.ToNative(IntPtr.Add(nativeStruct, FilterType_Offset), 0, FilterType_PropertyAddress.Address, FilterType);
		new TArrayCopyMarshaler<TSoftObject<BGUCharacterCS>>(1, FilterUnits_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BGUCharacterCS>, TSoftObjectMarshaler<BGUCharacterCS>>.FromNative, CachedMarshalingDelegates<TSoftObject<BGUCharacterCS>, TSoftObjectMarshaler<BGUCharacterCS>>.ToNative).ToNative(IntPtr.Add(nativeStruct, FilterUnits_Offset), FilterUnits);
		new TArrayCopyMarshaler<TSoftObject<BUTamerActor>>(1, FilterTamers_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.ToNative).ToNative(IntPtr.Add(nativeStruct, FilterTamers_Offset), FilterTamers);
		new TArrayCopyMarshaler<FGsActorGuidReference>(1, FilterTamerRefs_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative).ToNative(IntPtr.Add(nativeStruct, FilterTamerRefs_Offset), FilterTamerRefs);
		new TArrayCopyMarshaler<EGSForceFightUnitType>(1, FilterUnitTypes_PropertyAddress, CachedMarshalingDelegates<EGSForceFightUnitType, EnumMarshaler<EGSForceFightUnitType>>.FromNative, CachedMarshalingDelegates<EGSForceFightUnitType, EnumMarshaler<EGSForceFightUnitType>>.ToNative).ToNative(IntPtr.Add(nativeStruct, FilterUnitTypes_Offset), FilterUnitTypes);
	}

	public FGSForceFightTriggerUnitFilter(IntPtr nativeStruct)
	{
		if (FGSForceFightTriggerUnitFilter_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSForceFightTriggerUnitFilter");
			FilterType = EGSForceFightUnitFilterType.None;
			FilterUnits = null;
			FilterTamers = null;
			FilterTamerRefs = null;
			FilterUnitTypes = null;
		}
		else
		{
			FilterType = EnumMarshaler<EGSForceFightUnitFilterType>.FromNative(IntPtr.Add(nativeStruct, FilterType_Offset), 0, FilterType_PropertyAddress.Address);
			FilterUnits = new TArrayCopyMarshaler<TSoftObject<BGUCharacterCS>>(1, FilterUnits_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BGUCharacterCS>, TSoftObjectMarshaler<BGUCharacterCS>>.FromNative, CachedMarshalingDelegates<TSoftObject<BGUCharacterCS>, TSoftObjectMarshaler<BGUCharacterCS>>.ToNative).FromNative(IntPtr.Add(nativeStruct, FilterUnits_Offset));
			FilterTamers = new TArrayCopyMarshaler<TSoftObject<BUTamerActor>>(1, FilterTamers_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.ToNative).FromNative(IntPtr.Add(nativeStruct, FilterTamers_Offset));
			FilterTamerRefs = new TArrayCopyMarshaler<FGsActorGuidReference>(1, FilterTamerRefs_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative).FromNative(IntPtr.Add(nativeStruct, FilterTamerRefs_Offset));
			FilterUnitTypes = new TArrayCopyMarshaler<EGSForceFightUnitType>(1, FilterUnitTypes_PropertyAddress, CachedMarshalingDelegates<EGSForceFightUnitType, EnumMarshaler<EGSForceFightUnitType>>.FromNative, CachedMarshalingDelegates<EGSForceFightUnitType, EnumMarshaler<EGSForceFightUnitType>>.ToNative).FromNative(IntPtr.Add(nativeStruct, FilterUnitTypes_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSForceFightTriggerUnitFilter");
		FGSForceFightTriggerUnitFilter_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref FilterType_PropertyAddress, intPtr, "FilterType");
		FilterType_Offset = NativeReflection.GetPropertyOffset(intPtr, "FilterType");
		FilterType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FilterType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref FilterUnits_PropertyAddress, intPtr, "FilterUnits");
		FilterUnits_Offset = NativeReflection.GetPropertyOffset(intPtr, "FilterUnits");
		FilterUnits_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FilterUnits", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref FilterTamers_PropertyAddress, intPtr, "FilterTamers");
		FilterTamers_Offset = NativeReflection.GetPropertyOffset(intPtr, "FilterTamers");
		FilterTamers_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FilterTamers", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref FilterTamerRefs_PropertyAddress, intPtr, "FilterTamerRefs");
		FilterTamerRefs_Offset = NativeReflection.GetPropertyOffset(intPtr, "FilterTamerRefs");
		FilterTamerRefs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FilterTamerRefs", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref FilterUnitTypes_PropertyAddress, intPtr, "FilterUnitTypes");
		FilterUnitTypes_Offset = NativeReflection.GetPropertyOffset(intPtr, "FilterUnitTypes");
		FilterUnitTypes_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FilterUnitTypes", Classes.FArrayProperty);
		FGSForceFightTriggerUnitFilter_IsValid = ((intPtr != IntPtr.Zero && FilterType_IsValid && FilterUnits_IsValid && FilterTamers_IsValid && FilterTamerRefs_IsValid && FilterUnitTypes_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSForceFightTriggerUnitFilter", (byte)FGSForceFightTriggerUnitFilter_IsValid != 0);
	}

	static FGSForceFightTriggerUnitFilter()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSForceFightTriggerUnitFilter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSForceFightTriggerUnitFilter));
	}
}
