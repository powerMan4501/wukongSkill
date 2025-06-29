using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FGSBuffTriggerUnitCondition")]
public struct FGSBuffTriggerUnitCondition
{
	[EditAnywhere]
	[DisplayName("检测目标选择")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerUnitCondition:ConditionsTarget")]
	public EConditionsTarget ConditionsTarget;

	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "ConditionsTarget == ConditionsTarget::FindByTag")]
	[BlueprintReadWrite]
	[DisplayName("检测单位Tag")]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerUnitCondition:Tags")]
	public List<FName> Tags;

	[UProperty]
	[VisibleAnywhere]
	[DisplayName("手动选择单位")]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "ConditionsTarget == ConditionsTarget::ManualSelect")]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerUnitCondition:ObservedTamers")]
	public List<TSoftObject<BUTamerActor>> ObservedTamers;

	[UMeta(MDProp.EditCondition, "ConditionsTarget == ConditionsTarget::ManualSelect")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("手动选择单位")]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerUnitCondition:ObservedTamerRefs")]
	public List<FGsActorGuidReference> ObservedTamerRefs;

	[DisplayName("检测某单位存活")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("是否检测某单位存货")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerUnitCondition:ObserveIsActivedUnit")]
	public bool ObserveIsActivedUnit;

	[UMeta(MDProp.EditCondition, "ObserveIsActivedUnit")]
	[DisplayName("需要检测存活的单位")]
	[VisibleAnywhere]
	[UProperty]
	[Tooltip("需要检测全部存货的单位")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerUnitCondition:ObserveActiveTamers")]
	public List<TSoftObject<BUTamerActor>> ObserveActiveTamers;

	[DisplayName("需要检测存活的单位")]
	[Tooltip("需要检测全部存货的单位")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "ObserveIsActivedUnit")]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerUnitCondition:ObserveActiveTamerRefs")]
	public List<FGsActorGuidReference> ObserveActiveTamerRefs;

	[EditAnywhere]
	[UProperty]
	[Tooltip("是否检测某单位死亡")]
	[BlueprintReadWrite]
	[DisplayName("检测某单位死亡")]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerUnitCondition:ObserveIsDeadUnit")]
	public bool ObserveIsDeadUnit;

	[UMeta(MDProp.EditCondition, "ObserveIsDeadUnit")]
	[VisibleAnywhere]
	[UProperty]
	[DisplayName("需要检测死亡的单位")]
	[BlueprintReadWrite]
	[Tooltip("需要检测全部死亡的单位")]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerUnitCondition:ObserveDeadTamers")]
	public List<TSoftObject<BUTamerActor>> ObserveDeadTamers;

	[UMeta(MDProp.EditCondition, "ObserveIsDeadUnit")]
	[DisplayName("需要检测死亡的单位")]
	[Tooltip("需要检测全部死亡的单位")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerUnitCondition:ObserveDeadTamerRefs")]
	public List<FGsActorGuidReference> ObserveDeadTamerRefs;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("检测单位UnitState")]
	[Tooltip("是否检测单位当前是否拥有所指定的UnitState")]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerUnitCondition:ObserveHasUnitState")]
	public bool ObserveHasUnitState;

	[DisplayName("需要检测的UnitState")]
	[UProperty]
	[UMeta(MDProp.EditCondition, "ObserveHasUnitState")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerUnitCondition:ObserveUnitStates")]
	public List<EBGUUnitState> ObserveUnitStates;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("检测单位SimpleState")]
	[Tooltip("是否检测单位当前是否拥有所指定的SimpleState")]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerUnitCondition:ObserveHasSimpleState")]
	public bool ObserveHasSimpleState;

	[DisplayName("需要检测的SimpleState")]
	[UMeta(MDProp.EditCondition, "ObserveHasSimpleState")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerUnitCondition:ObserveSimpleStates")]
	public List<EBGUSimpleState> ObserveSimpleStates;

	[Tooltip("是否检测单位当前是否拥有所指定的Buff")]
	[EditAnywhere]
	[DisplayName("检测单位Buff")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerUnitCondition:ObserveHasBuff")]
	public bool ObserveHasBuff;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "ObserveHasBuff")]
	[DisplayName("需要检测的BuffID")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerUnitCondition:ObserveBuffIDs")]
	public List<int> ObserveBuffIDs;

	[DisplayName("检测单位Attr")]
	[BlueprintReadWrite]
	[Tooltip("是否检测单位Attr")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerUnitCondition:ObserveHasUnitAttr")]
	public bool ObserveHasUnitAttr;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("需要检测的UnitAttr")]
	[Tooltip("需要检测的属性")]
	[UMeta(MDProp.EditCondition, "ObserveHasUnitAttr")]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerUnitCondition:ObserveUnitAttrs")]
	public List<FUnitAttrCondition> ObserveUnitAttrs;

	[DisplayName("Buff的触发配置")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerUnitCondition:BuffTriggerConfig")]
	public FGSBuffTriggerConfig BuffTriggerConfig;

	[BlueprintReadWrite]
	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerUnitCondition:ObservedUnits")]
	public List<BGUCharacterCS> ObservedUnits;

	[VisibleAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerUnitCondition:ObserveActiveUnits")]
	public List<BGUCharacterCS> ObserveActiveUnits;

	[BlueprintReadWrite]
	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerUnitCondition:ObserveDeadUnits")]
	public List<BGUCharacterCS> ObserveDeadUnits;

	private static int FGSBuffTriggerUnitCondition_StructSize;

	private static int FGSBuffTriggerUnitCondition_IsValid;

	private static bool ConditionsTarget_IsValid;

	private static int ConditionsTarget_Offset;

	private static FFieldAddress ConditionsTarget_PropertyAddress;

	private static bool Tags_IsValid;

	private static int Tags_Offset;

	private static FFieldAddress Tags_PropertyAddress;

	private static bool ObservedTamers_IsValid;

	private static int ObservedTamers_Offset;

	private static FFieldAddress ObservedTamers_PropertyAddress;

	private static bool ObservedTamerRefs_IsValid;

	private static int ObservedTamerRefs_Offset;

	private static FFieldAddress ObservedTamerRefs_PropertyAddress;

	private static bool ObserveIsActivedUnit_IsValid;

	private static int ObserveIsActivedUnit_Offset;

	private static FFieldAddress ObserveIsActivedUnit_PropertyAddress;

	private static bool ObserveActiveTamers_IsValid;

	private static int ObserveActiveTamers_Offset;

	private static FFieldAddress ObserveActiveTamers_PropertyAddress;

	private static bool ObserveActiveTamerRefs_IsValid;

	private static int ObserveActiveTamerRefs_Offset;

	private static FFieldAddress ObserveActiveTamerRefs_PropertyAddress;

	private static bool ObserveIsDeadUnit_IsValid;

	private static int ObserveIsDeadUnit_Offset;

	private static FFieldAddress ObserveIsDeadUnit_PropertyAddress;

	private static bool ObserveDeadTamers_IsValid;

	private static int ObserveDeadTamers_Offset;

	private static FFieldAddress ObserveDeadTamers_PropertyAddress;

	private static bool ObserveDeadTamerRefs_IsValid;

	private static int ObserveDeadTamerRefs_Offset;

	private static FFieldAddress ObserveDeadTamerRefs_PropertyAddress;

	private static bool ObserveHasUnitState_IsValid;

	private static int ObserveHasUnitState_Offset;

	private static FFieldAddress ObserveHasUnitState_PropertyAddress;

	private static bool ObserveUnitStates_IsValid;

	private static int ObserveUnitStates_Offset;

	private static FFieldAddress ObserveUnitStates_PropertyAddress;

	private static bool ObserveHasSimpleState_IsValid;

	private static int ObserveHasSimpleState_Offset;

	private static FFieldAddress ObserveHasSimpleState_PropertyAddress;

	private static bool ObserveSimpleStates_IsValid;

	private static int ObserveSimpleStates_Offset;

	private static FFieldAddress ObserveSimpleStates_PropertyAddress;

	private static bool ObserveHasBuff_IsValid;

	private static int ObserveHasBuff_Offset;

	private static FFieldAddress ObserveHasBuff_PropertyAddress;

	private static bool ObserveBuffIDs_IsValid;

	private static int ObserveBuffIDs_Offset;

	private static FFieldAddress ObserveBuffIDs_PropertyAddress;

	private static bool ObserveHasUnitAttr_IsValid;

	private static int ObserveHasUnitAttr_Offset;

	private static FFieldAddress ObserveHasUnitAttr_PropertyAddress;

	private static bool ObserveUnitAttrs_IsValid;

	private static int ObserveUnitAttrs_Offset;

	private static FFieldAddress ObserveUnitAttrs_PropertyAddress;

	private static bool BuffTriggerConfig_IsValid;

	private static int BuffTriggerConfig_Offset;

	private static bool ObservedUnits_IsValid;

	private static int ObservedUnits_Offset;

	private static FFieldAddress ObservedUnits_PropertyAddress;

	private static bool ObserveActiveUnits_IsValid;

	private static int ObserveActiveUnits_Offset;

	private static FFieldAddress ObserveActiveUnits_PropertyAddress;

	private static bool ObserveDeadUnits_IsValid;

	private static int ObserveDeadUnits_Offset;

	private static FFieldAddress ObserveDeadUnits_PropertyAddress;

	public FGSBuffTriggerUnitCondition Copy()
	{
		FGSBuffTriggerUnitCondition result = this;
		if (Tags != null)
		{
			result.Tags = new List<FName>(Tags);
		}
		if (ObservedTamers != null)
		{
			result.ObservedTamers = new List<TSoftObject<BUTamerActor>>(ObservedTamers);
		}
		if (ObservedTamerRefs != null)
		{
			result.ObservedTamerRefs = new List<FGsActorGuidReference>(ObservedTamerRefs);
		}
		if (ObserveActiveTamers != null)
		{
			result.ObserveActiveTamers = new List<TSoftObject<BUTamerActor>>(ObserveActiveTamers);
		}
		if (ObserveActiveTamerRefs != null)
		{
			result.ObserveActiveTamerRefs = new List<FGsActorGuidReference>(ObserveActiveTamerRefs);
		}
		if (ObserveDeadTamers != null)
		{
			result.ObserveDeadTamers = new List<TSoftObject<BUTamerActor>>(ObserveDeadTamers);
		}
		if (ObserveDeadTamerRefs != null)
		{
			result.ObserveDeadTamerRefs = new List<FGsActorGuidReference>(ObserveDeadTamerRefs);
		}
		if (ObserveUnitStates != null)
		{
			result.ObserveUnitStates = new List<EBGUUnitState>(ObserveUnitStates);
		}
		if (ObserveSimpleStates != null)
		{
			result.ObserveSimpleStates = new List<EBGUSimpleState>(ObserveSimpleStates);
		}
		if (ObserveBuffIDs != null)
		{
			result.ObserveBuffIDs = new List<int>(ObserveBuffIDs);
		}
		if (ObserveUnitAttrs != null)
		{
			result.ObserveUnitAttrs = new List<FUnitAttrCondition>(ObserveUnitAttrs);
		}
		if (ObservedUnits != null)
		{
			result.ObservedUnits = new List<BGUCharacterCS>(ObservedUnits);
		}
		if (ObserveActiveUnits != null)
		{
			result.ObserveActiveUnits = new List<BGUCharacterCS>(ObserveActiveUnits);
		}
		if (ObserveDeadUnits != null)
		{
			result.ObserveDeadUnits = new List<BGUCharacterCS>(ObserveDeadUnits);
		}
		return result;
	}

	public static FGSBuffTriggerUnitCondition FromNative(IntPtr nativeBuffer)
	{
		return new FGSBuffTriggerUnitCondition(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSBuffTriggerUnitCondition value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSBuffTriggerUnitCondition FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSBuffTriggerUnitCondition(IntPtr.Add(nativeBuffer, arrayIndex * FGSBuffTriggerUnitCondition_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSBuffTriggerUnitCondition value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSBuffTriggerUnitCondition_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSBuffTriggerUnitCondition_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSBuffTriggerUnitCondition");
			return;
		}
		EnumMarshaler<EConditionsTarget>.ToNative(IntPtr.Add(nativeStruct, ConditionsTarget_Offset), 0, ConditionsTarget_PropertyAddress.Address, ConditionsTarget);
		new TArrayCopyMarshaler<FName>(1, Tags_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Tags_Offset), Tags);
		new TArrayCopyMarshaler<TSoftObject<BUTamerActor>>(1, ObservedTamers_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ObservedTamers_Offset), ObservedTamers);
		new TArrayCopyMarshaler<FGsActorGuidReference>(1, ObservedTamerRefs_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative).ToNative(IntPtr.Add(nativeStruct, ObservedTamerRefs_Offset), ObservedTamerRefs);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ObserveIsActivedUnit_Offset), 0, ObserveIsActivedUnit_PropertyAddress.Address, ObserveIsActivedUnit);
		new TArrayCopyMarshaler<TSoftObject<BUTamerActor>>(1, ObserveActiveTamers_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ObserveActiveTamers_Offset), ObserveActiveTamers);
		new TArrayCopyMarshaler<FGsActorGuidReference>(1, ObserveActiveTamerRefs_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative).ToNative(IntPtr.Add(nativeStruct, ObserveActiveTamerRefs_Offset), ObserveActiveTamerRefs);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ObserveIsDeadUnit_Offset), 0, ObserveIsDeadUnit_PropertyAddress.Address, ObserveIsDeadUnit);
		new TArrayCopyMarshaler<TSoftObject<BUTamerActor>>(1, ObserveDeadTamers_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ObserveDeadTamers_Offset), ObserveDeadTamers);
		new TArrayCopyMarshaler<FGsActorGuidReference>(1, ObserveDeadTamerRefs_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative).ToNative(IntPtr.Add(nativeStruct, ObserveDeadTamerRefs_Offset), ObserveDeadTamerRefs);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ObserveHasUnitState_Offset), 0, ObserveHasUnitState_PropertyAddress.Address, ObserveHasUnitState);
		new TArrayCopyMarshaler<EBGUUnitState>(1, ObserveUnitStates_PropertyAddress, CachedMarshalingDelegates<EBGUUnitState, EnumMarshaler<EBGUUnitState>>.FromNative, CachedMarshalingDelegates<EBGUUnitState, EnumMarshaler<EBGUUnitState>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ObserveUnitStates_Offset), ObserveUnitStates);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ObserveHasSimpleState_Offset), 0, ObserveHasSimpleState_PropertyAddress.Address, ObserveHasSimpleState);
		new TArrayCopyMarshaler<EBGUSimpleState>(1, ObserveSimpleStates_PropertyAddress, CachedMarshalingDelegates<EBGUSimpleState, EnumMarshaler<EBGUSimpleState>>.FromNative, CachedMarshalingDelegates<EBGUSimpleState, EnumMarshaler<EBGUSimpleState>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ObserveSimpleStates_Offset), ObserveSimpleStates);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ObserveHasBuff_Offset), 0, ObserveHasBuff_PropertyAddress.Address, ObserveHasBuff);
		new TArrayCopyMarshaler<int>(1, ObserveBuffIDs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ObserveBuffIDs_Offset), ObserveBuffIDs);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ObserveHasUnitAttr_Offset), 0, ObserveHasUnitAttr_PropertyAddress.Address, ObserveHasUnitAttr);
		new TArrayCopyMarshaler<FUnitAttrCondition>(1, ObserveUnitAttrs_PropertyAddress, CachedMarshalingDelegates<FUnitAttrCondition, FUnitAttrCondition>.FromNative, CachedMarshalingDelegates<FUnitAttrCondition, FUnitAttrCondition>.ToNative).ToNative(IntPtr.Add(nativeStruct, ObserveUnitAttrs_Offset), ObserveUnitAttrs);
		FGSBuffTriggerConfig.ToNative(IntPtr.Add(nativeStruct, BuffTriggerConfig_Offset), BuffTriggerConfig);
		new TArrayCopyMarshaler<BGUCharacterCS>(1, ObservedUnits_PropertyAddress, CachedMarshalingDelegates<BGUCharacterCS, UObjectMarshaler<BGUCharacterCS>>.FromNative, CachedMarshalingDelegates<BGUCharacterCS, UObjectMarshaler<BGUCharacterCS>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ObservedUnits_Offset), ObservedUnits);
		new TArrayCopyMarshaler<BGUCharacterCS>(1, ObserveActiveUnits_PropertyAddress, CachedMarshalingDelegates<BGUCharacterCS, UObjectMarshaler<BGUCharacterCS>>.FromNative, CachedMarshalingDelegates<BGUCharacterCS, UObjectMarshaler<BGUCharacterCS>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ObserveActiveUnits_Offset), ObserveActiveUnits);
		new TArrayCopyMarshaler<BGUCharacterCS>(1, ObserveDeadUnits_PropertyAddress, CachedMarshalingDelegates<BGUCharacterCS, UObjectMarshaler<BGUCharacterCS>>.FromNative, CachedMarshalingDelegates<BGUCharacterCS, UObjectMarshaler<BGUCharacterCS>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ObserveDeadUnits_Offset), ObserveDeadUnits);
	}

	public FGSBuffTriggerUnitCondition(IntPtr nativeStruct)
	{
		if (FGSBuffTriggerUnitCondition_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSBuffTriggerUnitCondition");
			ConditionsTarget = EConditionsTarget.Player;
			Tags = null;
			ObservedTamers = null;
			ObservedTamerRefs = null;
			ObserveIsActivedUnit = false;
			ObserveActiveTamers = null;
			ObserveActiveTamerRefs = null;
			ObserveIsDeadUnit = false;
			ObserveDeadTamers = null;
			ObserveDeadTamerRefs = null;
			ObserveHasUnitState = false;
			ObserveUnitStates = null;
			ObserveHasSimpleState = false;
			ObserveSimpleStates = null;
			ObserveHasBuff = false;
			ObserveBuffIDs = null;
			ObserveHasUnitAttr = false;
			ObserveUnitAttrs = null;
			BuffTriggerConfig = default(FGSBuffTriggerConfig);
			ObservedUnits = null;
			ObserveActiveUnits = null;
			ObserveDeadUnits = null;
		}
		else
		{
			ConditionsTarget = EnumMarshaler<EConditionsTarget>.FromNative(IntPtr.Add(nativeStruct, ConditionsTarget_Offset), 0, ConditionsTarget_PropertyAddress.Address);
			Tags = new TArrayCopyMarshaler<FName>(1, Tags_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Tags_Offset));
			ObservedTamers = new TArrayCopyMarshaler<TSoftObject<BUTamerActor>>(1, ObservedTamers_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ObservedTamers_Offset));
			ObservedTamerRefs = new TArrayCopyMarshaler<FGsActorGuidReference>(1, ObservedTamerRefs_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative).FromNative(IntPtr.Add(nativeStruct, ObservedTamerRefs_Offset));
			ObserveIsActivedUnit = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ObserveIsActivedUnit_Offset), 0, ObserveIsActivedUnit_PropertyAddress.Address);
			ObserveActiveTamers = new TArrayCopyMarshaler<TSoftObject<BUTamerActor>>(1, ObserveActiveTamers_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ObserveActiveTamers_Offset));
			ObserveActiveTamerRefs = new TArrayCopyMarshaler<FGsActorGuidReference>(1, ObserveActiveTamerRefs_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative).FromNative(IntPtr.Add(nativeStruct, ObserveActiveTamerRefs_Offset));
			ObserveIsDeadUnit = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ObserveIsDeadUnit_Offset), 0, ObserveIsDeadUnit_PropertyAddress.Address);
			ObserveDeadTamers = new TArrayCopyMarshaler<TSoftObject<BUTamerActor>>(1, ObserveDeadTamers_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ObserveDeadTamers_Offset));
			ObserveDeadTamerRefs = new TArrayCopyMarshaler<FGsActorGuidReference>(1, ObserveDeadTamerRefs_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative).FromNative(IntPtr.Add(nativeStruct, ObserveDeadTamerRefs_Offset));
			ObserveHasUnitState = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ObserveHasUnitState_Offset), 0, ObserveHasUnitState_PropertyAddress.Address);
			ObserveUnitStates = new TArrayCopyMarshaler<EBGUUnitState>(1, ObserveUnitStates_PropertyAddress, CachedMarshalingDelegates<EBGUUnitState, EnumMarshaler<EBGUUnitState>>.FromNative, CachedMarshalingDelegates<EBGUUnitState, EnumMarshaler<EBGUUnitState>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ObserveUnitStates_Offset));
			ObserveHasSimpleState = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ObserveHasSimpleState_Offset), 0, ObserveHasSimpleState_PropertyAddress.Address);
			ObserveSimpleStates = new TArrayCopyMarshaler<EBGUSimpleState>(1, ObserveSimpleStates_PropertyAddress, CachedMarshalingDelegates<EBGUSimpleState, EnumMarshaler<EBGUSimpleState>>.FromNative, CachedMarshalingDelegates<EBGUSimpleState, EnumMarshaler<EBGUSimpleState>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ObserveSimpleStates_Offset));
			ObserveHasBuff = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ObserveHasBuff_Offset), 0, ObserveHasBuff_PropertyAddress.Address);
			ObserveBuffIDs = new TArrayCopyMarshaler<int>(1, ObserveBuffIDs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ObserveBuffIDs_Offset));
			ObserveHasUnitAttr = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ObserveHasUnitAttr_Offset), 0, ObserveHasUnitAttr_PropertyAddress.Address);
			ObserveUnitAttrs = new TArrayCopyMarshaler<FUnitAttrCondition>(1, ObserveUnitAttrs_PropertyAddress, CachedMarshalingDelegates<FUnitAttrCondition, FUnitAttrCondition>.FromNative, CachedMarshalingDelegates<FUnitAttrCondition, FUnitAttrCondition>.ToNative).FromNative(IntPtr.Add(nativeStruct, ObserveUnitAttrs_Offset));
			BuffTriggerConfig = FGSBuffTriggerConfig.FromNative(IntPtr.Add(nativeStruct, BuffTriggerConfig_Offset));
			ObservedUnits = new TArrayCopyMarshaler<BGUCharacterCS>(1, ObservedUnits_PropertyAddress, CachedMarshalingDelegates<BGUCharacterCS, UObjectMarshaler<BGUCharacterCS>>.FromNative, CachedMarshalingDelegates<BGUCharacterCS, UObjectMarshaler<BGUCharacterCS>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ObservedUnits_Offset));
			ObserveActiveUnits = new TArrayCopyMarshaler<BGUCharacterCS>(1, ObserveActiveUnits_PropertyAddress, CachedMarshalingDelegates<BGUCharacterCS, UObjectMarshaler<BGUCharacterCS>>.FromNative, CachedMarshalingDelegates<BGUCharacterCS, UObjectMarshaler<BGUCharacterCS>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ObserveActiveUnits_Offset));
			ObserveDeadUnits = new TArrayCopyMarshaler<BGUCharacterCS>(1, ObserveDeadUnits_PropertyAddress, CachedMarshalingDelegates<BGUCharacterCS, UObjectMarshaler<BGUCharacterCS>>.FromNative, CachedMarshalingDelegates<BGUCharacterCS, UObjectMarshaler<BGUCharacterCS>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ObserveDeadUnits_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSBuffTriggerUnitCondition");
		FGSBuffTriggerUnitCondition_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ConditionsTarget_PropertyAddress, intPtr, "ConditionsTarget");
		ConditionsTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConditionsTarget");
		ConditionsTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConditionsTarget", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref Tags_PropertyAddress, intPtr, "Tags");
		Tags_Offset = NativeReflection.GetPropertyOffset(intPtr, "Tags");
		Tags_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Tags", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ObservedTamers_PropertyAddress, intPtr, "ObservedTamers");
		ObservedTamers_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObservedTamers");
		ObservedTamers_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObservedTamers", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ObservedTamerRefs_PropertyAddress, intPtr, "ObservedTamerRefs");
		ObservedTamerRefs_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObservedTamerRefs");
		ObservedTamerRefs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObservedTamerRefs", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ObserveIsActivedUnit_PropertyAddress, intPtr, "ObserveIsActivedUnit");
		ObserveIsActivedUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveIsActivedUnit");
		ObserveIsActivedUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveIsActivedUnit", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ObserveActiveTamers_PropertyAddress, intPtr, "ObserveActiveTamers");
		ObserveActiveTamers_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveActiveTamers");
		ObserveActiveTamers_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveActiveTamers", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ObserveActiveTamerRefs_PropertyAddress, intPtr, "ObserveActiveTamerRefs");
		ObserveActiveTamerRefs_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveActiveTamerRefs");
		ObserveActiveTamerRefs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveActiveTamerRefs", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ObserveIsDeadUnit_PropertyAddress, intPtr, "ObserveIsDeadUnit");
		ObserveIsDeadUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveIsDeadUnit");
		ObserveIsDeadUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveIsDeadUnit", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ObserveDeadTamers_PropertyAddress, intPtr, "ObserveDeadTamers");
		ObserveDeadTamers_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveDeadTamers");
		ObserveDeadTamers_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveDeadTamers", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ObserveDeadTamerRefs_PropertyAddress, intPtr, "ObserveDeadTamerRefs");
		ObserveDeadTamerRefs_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveDeadTamerRefs");
		ObserveDeadTamerRefs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveDeadTamerRefs", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ObserveHasUnitState_PropertyAddress, intPtr, "ObserveHasUnitState");
		ObserveHasUnitState_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveHasUnitState");
		ObserveHasUnitState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveHasUnitState", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ObserveUnitStates_PropertyAddress, intPtr, "ObserveUnitStates");
		ObserveUnitStates_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveUnitStates");
		ObserveUnitStates_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveUnitStates", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ObserveHasSimpleState_PropertyAddress, intPtr, "ObserveHasSimpleState");
		ObserveHasSimpleState_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveHasSimpleState");
		ObserveHasSimpleState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveHasSimpleState", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ObserveSimpleStates_PropertyAddress, intPtr, "ObserveSimpleStates");
		ObserveSimpleStates_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveSimpleStates");
		ObserveSimpleStates_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveSimpleStates", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ObserveHasBuff_PropertyAddress, intPtr, "ObserveHasBuff");
		ObserveHasBuff_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveHasBuff");
		ObserveHasBuff_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveHasBuff", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ObserveBuffIDs_PropertyAddress, intPtr, "ObserveBuffIDs");
		ObserveBuffIDs_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveBuffIDs");
		ObserveBuffIDs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveBuffIDs", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ObserveHasUnitAttr_PropertyAddress, intPtr, "ObserveHasUnitAttr");
		ObserveHasUnitAttr_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveHasUnitAttr");
		ObserveHasUnitAttr_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveHasUnitAttr", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ObserveUnitAttrs_PropertyAddress, intPtr, "ObserveUnitAttrs");
		ObserveUnitAttrs_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveUnitAttrs");
		ObserveUnitAttrs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveUnitAttrs", Classes.FArrayProperty);
		BuffTriggerConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffTriggerConfig");
		BuffTriggerConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffTriggerConfig", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref ObservedUnits_PropertyAddress, intPtr, "ObservedUnits");
		ObservedUnits_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObservedUnits");
		ObservedUnits_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObservedUnits", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ObserveActiveUnits_PropertyAddress, intPtr, "ObserveActiveUnits");
		ObserveActiveUnits_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveActiveUnits");
		ObserveActiveUnits_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveActiveUnits", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ObserveDeadUnits_PropertyAddress, intPtr, "ObserveDeadUnits");
		ObserveDeadUnits_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveDeadUnits");
		ObserveDeadUnits_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveDeadUnits", Classes.FArrayProperty);
		FGSBuffTriggerUnitCondition_IsValid = ((intPtr != IntPtr.Zero && ConditionsTarget_IsValid && Tags_IsValid && ObservedTamers_IsValid && ObservedTamerRefs_IsValid && ObserveIsActivedUnit_IsValid && ObserveActiveTamers_IsValid && ObserveActiveTamerRefs_IsValid && ObserveIsDeadUnit_IsValid && ObserveDeadTamers_IsValid && ObserveDeadTamerRefs_IsValid && ObserveHasUnitState_IsValid && ObserveUnitStates_IsValid && ObserveHasSimpleState_IsValid && ObserveSimpleStates_IsValid && ObserveHasBuff_IsValid && ObserveBuffIDs_IsValid && ObserveHasUnitAttr_IsValid && ObserveUnitAttrs_IsValid && BuffTriggerConfig_IsValid && ObservedUnits_IsValid && ObserveActiveUnits_IsValid && ObserveDeadUnits_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSBuffTriggerUnitCondition", (byte)FGSBuffTriggerUnitCondition_IsValid != 0);
	}

	static FGSBuffTriggerUnitCondition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSBuffTriggerUnitCondition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSBuffTriggerUnitCondition));
	}
}
