using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FGSForceFightUnitGroupConfig")]
public struct FGSForceFightUnitGroupConfig
{
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("触发条件")]
	[Tooltip("触发条件")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSForceFightUnitGroupConfig:TriggerCondition")]
	public EGSForceFightCondition TriggerCondition;

	[UMeta(MDProp.EditCondition, "TriggerCondition != EGSForceFightCondition::ObserveUnitsConditions")]
	[Tooltip("触发单位筛选器。管理哪些单位可作为触发单位。")]
	[DisplayName("触发单位筛选器")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSForceFightUnitGroupConfig:TriggerUnitFilter")]
	public FGSForceFightTriggerUnitFilter TriggerUnitFilter;

	[Tooltip("需要检测的单位状态配置")]
	[DisplayName("检测单位状态配置")]
	[UMeta(MDProp.EditCondition, "TriggerCondition == EGSForceFightCondition::ObserveUnitsConditions")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSForceFightUnitGroupConfig:ObserveUnitsConditions")]
	public List<FGSForceFightUnitCondition> ObserveUnitsConditions;

	[DisplayName("目标选择类型")]
	[BlueprintReadWrite]
	[Tooltip("目标选择类型")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSForceFightUnitGroupConfig:ForceFightTargetType")]
	public EGSForceFightTargetType ForceFightTargetType;

	[VisibleAnywhere]
	[Tooltip("手动选择目标单位")]
	[BlueprintReadWrite]
	[DisplayName("手动选择目标单位")]
	[UMeta(MDProp.EditCondition, "ForceFightTargetType == EGSForceFightTargetType::SelectedTargetUnit")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSForceFightUnitGroupConfig:TargetUnit")]
	public TSoftObject<BGUCharacterCS> TargetUnit;

	[UProperty]
	[UMeta(MDProp.EditCondition, "ForceFightTargetType == EGSForceFightTargetType::SelectedTargetUnit")]
	[DisplayName("手动选择目标单位")]
	[Tooltip("手动选择目标单位")]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSForceFightUnitGroupConfig:TargetTamer")]
	public TSoftObject<BUTamerActor> TargetTamer;

	[UProperty]
	[Tooltip("手动选择目标单位")]
	[DisplayName("手动选择目标单位")]
	[UMeta(MDProp.EditCondition, "ForceFightTargetType == EGSForceFightTargetType::SelectedTargetUnit")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSForceFightUnitGroupConfig:TargetTamerRef")]
	public FGsActorGuidReference TargetTamerRef;

	[Tooltip("类型选择被触发的单位列表")]
	[UProperty]
	[EditAnywhere]
	[DisplayName("类型选择被触发单位")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSForceFightUnitGroupConfig:TriggerUnitsType")]
	public List<EGSForceFightTriggerUnitType> TriggerUnitsType;

	[VisibleAnywhere]
	[UProperty]
	[DisplayName("被触发的单位")]
	[Tooltip("被触发的单位列表")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSForceFightUnitGroupConfig:TriggerUnits")]
	public List<TSoftObject<BGUCharacterCS>> TriggerUnits;

	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[Tooltip("被触发的单位列表")]
	[DisplayName("被触发的单位")]
	[USharpPath("/Script/b1-Managed.FGSForceFightUnitGroupConfig:TriggerTamers")]
	public List<TSoftObject<BUTamerActor>> TriggerTamers;

	[DisplayName("被触发的单位")]
	[Tooltip("被触发的单位列表")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSForceFightUnitGroupConfig:TriggerTamerRefs")]
	public List<FGsActorGuidReference> TriggerTamerRefs;

	[DisplayName("被触发者白名单")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("被触发者白名单配置")]
	[USharpPath("/Script/b1-Managed.FGSForceFightUnitGroupConfig:TriggerUnitsWhiteList")]
	public FGSForceFightWhiteListConfig TriggerUnitsWhiteList;

	[DisplayName("可重复触发")]
	[EditAnywhere]
	[UProperty]
	[Tooltip("是否可重复触发")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSForceFightUnitGroupConfig:CanRepeat")]
	public bool CanRepeat;

	private static int FGSForceFightUnitGroupConfig_StructSize;

	private static int FGSForceFightUnitGroupConfig_IsValid;

	private static bool TriggerCondition_IsValid;

	private static int TriggerCondition_Offset;

	private static FFieldAddress TriggerCondition_PropertyAddress;

	private static bool TriggerUnitFilter_IsValid;

	private static int TriggerUnitFilter_Offset;

	private static bool ObserveUnitsConditions_IsValid;

	private static int ObserveUnitsConditions_Offset;

	private static FFieldAddress ObserveUnitsConditions_PropertyAddress;

	private static bool ForceFightTargetType_IsValid;

	private static int ForceFightTargetType_Offset;

	private static FFieldAddress ForceFightTargetType_PropertyAddress;

	private static bool TargetUnit_IsValid;

	private static int TargetUnit_Offset;

	private static bool TargetTamer_IsValid;

	private static int TargetTamer_Offset;

	private static bool TargetTamerRef_IsValid;

	private static int TargetTamerRef_Offset;

	private static bool TriggerUnitsType_IsValid;

	private static int TriggerUnitsType_Offset;

	private static FFieldAddress TriggerUnitsType_PropertyAddress;

	private static bool TriggerUnits_IsValid;

	private static int TriggerUnits_Offset;

	private static FFieldAddress TriggerUnits_PropertyAddress;

	private static bool TriggerTamers_IsValid;

	private static int TriggerTamers_Offset;

	private static FFieldAddress TriggerTamers_PropertyAddress;

	private static bool TriggerTamerRefs_IsValid;

	private static int TriggerTamerRefs_Offset;

	private static FFieldAddress TriggerTamerRefs_PropertyAddress;

	private static bool TriggerUnitsWhiteList_IsValid;

	private static int TriggerUnitsWhiteList_Offset;

	private static bool CanRepeat_IsValid;

	private static int CanRepeat_Offset;

	private static FFieldAddress CanRepeat_PropertyAddress;

	public FGSForceFightUnitGroupConfig Copy()
	{
		FGSForceFightUnitGroupConfig result = this;
		if (ObserveUnitsConditions != null)
		{
			result.ObserveUnitsConditions = new List<FGSForceFightUnitCondition>(ObserveUnitsConditions);
		}
		if (TriggerUnitsType != null)
		{
			result.TriggerUnitsType = new List<EGSForceFightTriggerUnitType>(TriggerUnitsType);
		}
		if (TriggerUnits != null)
		{
			result.TriggerUnits = new List<TSoftObject<BGUCharacterCS>>(TriggerUnits);
		}
		if (TriggerTamers != null)
		{
			result.TriggerTamers = new List<TSoftObject<BUTamerActor>>(TriggerTamers);
		}
		if (TriggerTamerRefs != null)
		{
			result.TriggerTamerRefs = new List<FGsActorGuidReference>(TriggerTamerRefs);
		}
		return result;
	}

	public static FGSForceFightUnitGroupConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGSForceFightUnitGroupConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSForceFightUnitGroupConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSForceFightUnitGroupConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSForceFightUnitGroupConfig(IntPtr.Add(nativeBuffer, arrayIndex * FGSForceFightUnitGroupConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSForceFightUnitGroupConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSForceFightUnitGroupConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSForceFightUnitGroupConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSForceFightUnitGroupConfig");
			return;
		}
		EnumMarshaler<EGSForceFightCondition>.ToNative(IntPtr.Add(nativeStruct, TriggerCondition_Offset), 0, TriggerCondition_PropertyAddress.Address, TriggerCondition);
		FGSForceFightTriggerUnitFilter.ToNative(IntPtr.Add(nativeStruct, TriggerUnitFilter_Offset), TriggerUnitFilter);
		new TArrayCopyMarshaler<FGSForceFightUnitCondition>(1, ObserveUnitsConditions_PropertyAddress, CachedMarshalingDelegates<FGSForceFightUnitCondition, FGSForceFightUnitCondition>.FromNative, CachedMarshalingDelegates<FGSForceFightUnitCondition, FGSForceFightUnitCondition>.ToNative).ToNative(IntPtr.Add(nativeStruct, ObserveUnitsConditions_Offset), ObserveUnitsConditions);
		EnumMarshaler<EGSForceFightTargetType>.ToNative(IntPtr.Add(nativeStruct, ForceFightTargetType_Offset), 0, ForceFightTargetType_PropertyAddress.Address, ForceFightTargetType);
		TSoftObjectMarshaler<BGUCharacterCS>.ToNative(IntPtr.Add(nativeStruct, TargetUnit_Offset), TargetUnit);
		TSoftObjectMarshaler<BUTamerActor>.ToNative(IntPtr.Add(nativeStruct, TargetTamer_Offset), TargetTamer);
		FGsActorGuidReference.ToNative(IntPtr.Add(nativeStruct, TargetTamerRef_Offset), TargetTamerRef);
		new TArrayCopyMarshaler<EGSForceFightTriggerUnitType>(1, TriggerUnitsType_PropertyAddress, CachedMarshalingDelegates<EGSForceFightTriggerUnitType, EnumMarshaler<EGSForceFightTriggerUnitType>>.FromNative, CachedMarshalingDelegates<EGSForceFightTriggerUnitType, EnumMarshaler<EGSForceFightTriggerUnitType>>.ToNative).ToNative(IntPtr.Add(nativeStruct, TriggerUnitsType_Offset), TriggerUnitsType);
		new TArrayCopyMarshaler<TSoftObject<BGUCharacterCS>>(1, TriggerUnits_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BGUCharacterCS>, TSoftObjectMarshaler<BGUCharacterCS>>.FromNative, CachedMarshalingDelegates<TSoftObject<BGUCharacterCS>, TSoftObjectMarshaler<BGUCharacterCS>>.ToNative).ToNative(IntPtr.Add(nativeStruct, TriggerUnits_Offset), TriggerUnits);
		new TArrayCopyMarshaler<TSoftObject<BUTamerActor>>(1, TriggerTamers_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.ToNative).ToNative(IntPtr.Add(nativeStruct, TriggerTamers_Offset), TriggerTamers);
		new TArrayCopyMarshaler<FGsActorGuidReference>(1, TriggerTamerRefs_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative).ToNative(IntPtr.Add(nativeStruct, TriggerTamerRefs_Offset), TriggerTamerRefs);
		FGSForceFightWhiteListConfig.ToNative(IntPtr.Add(nativeStruct, TriggerUnitsWhiteList_Offset), TriggerUnitsWhiteList);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanRepeat_Offset), 0, CanRepeat_PropertyAddress.Address, CanRepeat);
	}

	public FGSForceFightUnitGroupConfig(IntPtr nativeStruct)
	{
		if (FGSForceFightUnitGroupConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSForceFightUnitGroupConfig");
			TriggerCondition = EGSForceFightCondition.EnterCollisionArea;
			TriggerUnitFilter = default(FGSForceFightTriggerUnitFilter);
			ObserveUnitsConditions = null;
			ForceFightTargetType = EGSForceFightTargetType.None;
			TargetUnit = default(TSoftObject<BGUCharacterCS>);
			TargetTamer = default(TSoftObject<BUTamerActor>);
			TargetTamerRef = default(FGsActorGuidReference);
			TriggerUnitsType = null;
			TriggerUnits = null;
			TriggerTamers = null;
			TriggerTamerRefs = null;
			TriggerUnitsWhiteList = default(FGSForceFightWhiteListConfig);
			CanRepeat = false;
		}
		else
		{
			TriggerCondition = EnumMarshaler<EGSForceFightCondition>.FromNative(IntPtr.Add(nativeStruct, TriggerCondition_Offset), 0, TriggerCondition_PropertyAddress.Address);
			TriggerUnitFilter = FGSForceFightTriggerUnitFilter.FromNative(IntPtr.Add(nativeStruct, TriggerUnitFilter_Offset));
			ObserveUnitsConditions = new TArrayCopyMarshaler<FGSForceFightUnitCondition>(1, ObserveUnitsConditions_PropertyAddress, CachedMarshalingDelegates<FGSForceFightUnitCondition, FGSForceFightUnitCondition>.FromNative, CachedMarshalingDelegates<FGSForceFightUnitCondition, FGSForceFightUnitCondition>.ToNative).FromNative(IntPtr.Add(nativeStruct, ObserveUnitsConditions_Offset));
			ForceFightTargetType = EnumMarshaler<EGSForceFightTargetType>.FromNative(IntPtr.Add(nativeStruct, ForceFightTargetType_Offset), 0, ForceFightTargetType_PropertyAddress.Address);
			TargetUnit = TSoftObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(nativeStruct, TargetUnit_Offset));
			TargetTamer = TSoftObjectMarshaler<BUTamerActor>.FromNative(IntPtr.Add(nativeStruct, TargetTamer_Offset));
			TargetTamerRef = FGsActorGuidReference.FromNative(IntPtr.Add(nativeStruct, TargetTamerRef_Offset));
			TriggerUnitsType = new TArrayCopyMarshaler<EGSForceFightTriggerUnitType>(1, TriggerUnitsType_PropertyAddress, CachedMarshalingDelegates<EGSForceFightTriggerUnitType, EnumMarshaler<EGSForceFightTriggerUnitType>>.FromNative, CachedMarshalingDelegates<EGSForceFightTriggerUnitType, EnumMarshaler<EGSForceFightTriggerUnitType>>.ToNative).FromNative(IntPtr.Add(nativeStruct, TriggerUnitsType_Offset));
			TriggerUnits = new TArrayCopyMarshaler<TSoftObject<BGUCharacterCS>>(1, TriggerUnits_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BGUCharacterCS>, TSoftObjectMarshaler<BGUCharacterCS>>.FromNative, CachedMarshalingDelegates<TSoftObject<BGUCharacterCS>, TSoftObjectMarshaler<BGUCharacterCS>>.ToNative).FromNative(IntPtr.Add(nativeStruct, TriggerUnits_Offset));
			TriggerTamers = new TArrayCopyMarshaler<TSoftObject<BUTamerActor>>(1, TriggerTamers_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.ToNative).FromNative(IntPtr.Add(nativeStruct, TriggerTamers_Offset));
			TriggerTamerRefs = new TArrayCopyMarshaler<FGsActorGuidReference>(1, TriggerTamerRefs_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative).FromNative(IntPtr.Add(nativeStruct, TriggerTamerRefs_Offset));
			TriggerUnitsWhiteList = FGSForceFightWhiteListConfig.FromNative(IntPtr.Add(nativeStruct, TriggerUnitsWhiteList_Offset));
			CanRepeat = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanRepeat_Offset), 0, CanRepeat_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSForceFightUnitGroupConfig");
		FGSForceFightUnitGroupConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref TriggerCondition_PropertyAddress, intPtr, "TriggerCondition");
		TriggerCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerCondition");
		TriggerCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerCondition", Classes.FEnumProperty);
		TriggerUnitFilter_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerUnitFilter");
		TriggerUnitFilter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerUnitFilter", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref ObserveUnitsConditions_PropertyAddress, intPtr, "ObserveUnitsConditions");
		ObserveUnitsConditions_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveUnitsConditions");
		ObserveUnitsConditions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveUnitsConditions", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ForceFightTargetType_PropertyAddress, intPtr, "ForceFightTargetType");
		ForceFightTargetType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForceFightTargetType");
		ForceFightTargetType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForceFightTargetType", Classes.FEnumProperty);
		TargetUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetUnit");
		TargetUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetUnit", Classes.FSoftObjectProperty);
		TargetTamer_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetTamer");
		TargetTamer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetTamer", Classes.FSoftObjectProperty);
		TargetTamerRef_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetTamerRef");
		TargetTamerRef_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetTamerRef", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref TriggerUnitsType_PropertyAddress, intPtr, "TriggerUnitsType");
		TriggerUnitsType_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerUnitsType");
		TriggerUnitsType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerUnitsType", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref TriggerUnits_PropertyAddress, intPtr, "TriggerUnits");
		TriggerUnits_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerUnits");
		TriggerUnits_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerUnits", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref TriggerTamers_PropertyAddress, intPtr, "TriggerTamers");
		TriggerTamers_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerTamers");
		TriggerTamers_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerTamers", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref TriggerTamerRefs_PropertyAddress, intPtr, "TriggerTamerRefs");
		TriggerTamerRefs_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerTamerRefs");
		TriggerTamerRefs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerTamerRefs", Classes.FArrayProperty);
		TriggerUnitsWhiteList_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerUnitsWhiteList");
		TriggerUnitsWhiteList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerUnitsWhiteList", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref CanRepeat_PropertyAddress, intPtr, "CanRepeat");
		CanRepeat_Offset = NativeReflection.GetPropertyOffset(intPtr, "CanRepeat");
		CanRepeat_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CanRepeat", Classes.FBoolProperty);
		FGSForceFightUnitGroupConfig_IsValid = ((intPtr != IntPtr.Zero && TriggerCondition_IsValid && TriggerUnitFilter_IsValid && ObserveUnitsConditions_IsValid && ForceFightTargetType_IsValid && TargetUnit_IsValid && TargetTamer_IsValid && TargetTamerRef_IsValid && TriggerUnitsType_IsValid && TriggerUnits_IsValid && TriggerTamers_IsValid && TriggerTamerRefs_IsValid && TriggerUnitsWhiteList_IsValid && CanRepeat_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSForceFightUnitGroupConfig", (byte)FGSForceFightUnitGroupConfig_IsValid != 0);
	}

	static FGSForceFightUnitGroupConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSForceFightUnitGroupConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSForceFightUnitGroupConfig));
	}
}
