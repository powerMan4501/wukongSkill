using System;
using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FGSWakeUpConfig")]
public struct FGSWakeUpConfig
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSWakeUpConfig:OnFightSkillID")]
	public int OnFightSkillID;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSWakeUpConfig:DirectionOnFightSkillConfig")]
	public FGSWakeUpDirectionOnFightSkillConfig DirectionOnFightSkillConfig;

	[EditAnywhere]
	[UProperty]
	[DisplayName("仅第一次唤醒使用接战技")]
	[USharpPath("/Script/b1-Managed.FGSWakeUpConfig:bJustUseOnFightSkillFirstTime")]
	public bool bJustUseOnFightSkillFirstTime;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSWakeUpConfig:SurpriseSkillID")]
	public List<int> SurpriseSkillID;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("唤醒链配置")]
	[DisplayName("是否启用唤醒链")]
	[USharpPath("/Script/b1-Managed.FGSWakeUpConfig:WakeUpLinkEnable")]
	public bool WakeUpLinkEnable;

	[Tooltip("勾选上后，会拿攻击者作为目标唤醒【仅限DeadReason为SkillDamage】")]
	[UMeta(MDProp.EditCondition, "WakeUpLinkEnable")]
	[DisplayName("死亡是否也触发唤醒")]
	[Category("唤醒链配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSWakeUpConfig:CanTriggerWakeUpLinkWhenDead")]
	public bool CanTriggerWakeUpLinkWhenDead;

	[UProperty]
	[EditAnywhere]
	[Category("唤醒链配置")]
	[DisplayName("是否使用手动选怪")]
	[UMeta(MDProp.EditCondition, "WakeUpLinkEnable")]
	[Tooltip("和范围筛选可以共存")]
	[USharpPath("/Script/b1-Managed.FGSWakeUpConfig:UseManualSelect")]
	public bool UseManualSelect;

	[VisibleAnywhere]
	[Category("唤醒链配置")]
	[UMeta(MDProp.EditCondition, "WakeUpLinkEnable && UseManualSelect")]
	[UProperty]
	[UMeta(MDFunc.AdvancedDisplay)]
	[DisplayName("指定目标列表")]
	[USharpPath("/Script/b1-Managed.FGSWakeUpConfig:TargetList")]
	public List<ABGUCharacter> TargetList;

	[UProperty]
	[EditAnywhere]
	[Category("唤醒链配置")]
	[DisplayName("指定目标列表")]
	[UMeta(MDProp.EditCondition, "WakeUpLinkEnable && UseManualSelect")]
	[USharpPath("/Script/b1-Managed.FGSWakeUpConfig:TargetTamerList")]
	public List<BUTamerActor> TargetTamerList;

	[UProperty]
	[EditAnywhere]
	[Tooltip("和手动筛选可以共存")]
	[UMeta(MDProp.EditCondition, "WakeUpLinkEnable")]
	[DisplayName("是否选用范围选怪")]
	[Category("唤醒链配置")]
	[USharpPath("/Script/b1-Managed.FGSWakeUpConfig:UseRangeSelect")]
	public bool UseRangeSelect;

	[EditAnywhere]
	[DisplayName("范围类型")]
	[UMeta(MDProp.EditCondition, "WakeUpLinkEnable && UseRangeSelect")]
	[Tooltip("目前只有圆柱")]
	[UProperty]
	[Category("唤醒链配置")]
	[USharpPath("/Script/b1-Managed.FGSWakeUpConfig:RangeType")]
	public ERangeType RangeType;

	[EditAnywhere]
	[Category("唤醒链配置")]
	[DisplayName("范围参数1")]
	[UMeta(MDProp.EditCondition, "WakeUpLinkEnable && UseRangeSelect")]
	[Tooltip("圆柱：半径值")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSWakeUpConfig:RangeParam_1")]
	public float RangeParam_1;

	[UProperty]
	[EditAnywhere]
	[Category("唤醒链配置")]
	[DisplayName("范围参数2")]
	[UMeta(MDProp.EditCondition, "WakeUpLinkEnable && UseRangeSelect")]
	[Tooltip("圆柱：圆柱上高")]
	[USharpPath("/Script/b1-Managed.FGSWakeUpConfig:RangeParam_2")]
	public float RangeParam_2;

	[Tooltip("圆柱：圆柱下高")]
	[UMeta(MDProp.EditCondition, "WakeUpLinkEnable && UseRangeSelect")]
	[DisplayName("范围参数3")]
	[EditAnywhere]
	[UProperty]
	[Category("唤醒链配置")]
	[USharpPath("/Script/b1-Managed.FGSWakeUpConfig:RangeParam_3")]
	public float RangeParam_3;

	[UProperty]
	[EditAnywhere]
	[Category("唤醒链配置")]
	[DisplayName("ResID列表")]
	[UMeta(MDProp.EditCondition, "WakeUpLinkEnable")]
	[USharpPath("/Script/b1-Managed.FGSWakeUpConfig:ResIDList")]
	public List<int> ResIDList;

	[UMeta(MDProp.EditCondition, "WakeUpLinkEnable")]
	[UProperty]
	[Category("唤醒链配置")]
	[EditAnywhere]
	[DisplayName("是否筛选已有目标的单位")]
	[USharpPath("/Script/b1-Managed.FGSWakeUpConfig:bSelectUnitHasTarget")]
	public bool bSelectUnitHasTarget;

	[UProperty]
	[EditAnywhere]
	[Category("唤醒链配置")]
	[DisplayName("是否筛选被动怪")]
	[UMeta(MDProp.EditCondition, "WakeUpLinkEnable")]
	[USharpPath("/Script/b1-Managed.FGSWakeUpConfig:bSelectPassiveUnit")]
	public bool bSelectPassiveUnit;

	private static int FGSWakeUpConfig_StructSize;

	private static int FGSWakeUpConfig_IsValid;

	private static bool OnFightSkillID_IsValid;

	private static int OnFightSkillID_Offset;

	private static bool DirectionOnFightSkillConfig_IsValid;

	private static int DirectionOnFightSkillConfig_Offset;

	private static bool bJustUseOnFightSkillFirstTime_IsValid;

	private static int bJustUseOnFightSkillFirstTime_Offset;

	private static FFieldAddress bJustUseOnFightSkillFirstTime_PropertyAddress;

	private static bool SurpriseSkillID_IsValid;

	private static int SurpriseSkillID_Offset;

	private static FFieldAddress SurpriseSkillID_PropertyAddress;

	private static bool WakeUpLinkEnable_IsValid;

	private static int WakeUpLinkEnable_Offset;

	private static FFieldAddress WakeUpLinkEnable_PropertyAddress;

	private static bool CanTriggerWakeUpLinkWhenDead_IsValid;

	private static int CanTriggerWakeUpLinkWhenDead_Offset;

	private static FFieldAddress CanTriggerWakeUpLinkWhenDead_PropertyAddress;

	private static bool UseManualSelect_IsValid;

	private static int UseManualSelect_Offset;

	private static FFieldAddress UseManualSelect_PropertyAddress;

	private static bool TargetList_IsValid;

	private static int TargetList_Offset;

	private static FFieldAddress TargetList_PropertyAddress;

	private static bool TargetTamerList_IsValid;

	private static int TargetTamerList_Offset;

	private static FFieldAddress TargetTamerList_PropertyAddress;

	private static bool UseRangeSelect_IsValid;

	private static int UseRangeSelect_Offset;

	private static FFieldAddress UseRangeSelect_PropertyAddress;

	private static bool RangeType_IsValid;

	private static int RangeType_Offset;

	private static FFieldAddress RangeType_PropertyAddress;

	private static bool RangeParam_1_IsValid;

	private static int RangeParam_1_Offset;

	private static bool RangeParam_2_IsValid;

	private static int RangeParam_2_Offset;

	private static bool RangeParam_3_IsValid;

	private static int RangeParam_3_Offset;

	private static bool ResIDList_IsValid;

	private static int ResIDList_Offset;

	private static FFieldAddress ResIDList_PropertyAddress;

	private static bool bSelectUnitHasTarget_IsValid;

	private static int bSelectUnitHasTarget_Offset;

	private static FFieldAddress bSelectUnitHasTarget_PropertyAddress;

	private static bool bSelectPassiveUnit_IsValid;

	private static int bSelectPassiveUnit_Offset;

	private static FFieldAddress bSelectPassiveUnit_PropertyAddress;

	public FGSWakeUpConfig Copy()
	{
		FGSWakeUpConfig result = this;
		if (SurpriseSkillID != null)
		{
			result.SurpriseSkillID = new List<int>(SurpriseSkillID);
		}
		if (TargetList != null)
		{
			result.TargetList = new List<ABGUCharacter>(TargetList);
		}
		if (TargetTamerList != null)
		{
			result.TargetTamerList = new List<BUTamerActor>(TargetTamerList);
		}
		if (ResIDList != null)
		{
			result.ResIDList = new List<int>(ResIDList);
		}
		return result;
	}

	public static FGSWakeUpConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGSWakeUpConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSWakeUpConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSWakeUpConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSWakeUpConfig(IntPtr.Add(nativeBuffer, arrayIndex * FGSWakeUpConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSWakeUpConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSWakeUpConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSWakeUpConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSWakeUpConfig");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OnFightSkillID_Offset), OnFightSkillID);
		BlittableTypeMarshaler<FGSWakeUpDirectionOnFightSkillConfig>.ToNative(IntPtr.Add(nativeStruct, DirectionOnFightSkillConfig_Offset), DirectionOnFightSkillConfig);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bJustUseOnFightSkillFirstTime_Offset), 0, bJustUseOnFightSkillFirstTime_PropertyAddress.Address, bJustUseOnFightSkillFirstTime);
		new TArrayCopyMarshaler<int>(1, SurpriseSkillID_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SurpriseSkillID_Offset), SurpriseSkillID);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, WakeUpLinkEnable_Offset), 0, WakeUpLinkEnable_PropertyAddress.Address, WakeUpLinkEnable);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanTriggerWakeUpLinkWhenDead_Offset), 0, CanTriggerWakeUpLinkWhenDead_PropertyAddress.Address, CanTriggerWakeUpLinkWhenDead);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseManualSelect_Offset), 0, UseManualSelect_PropertyAddress.Address, UseManualSelect);
		new TArrayCopyMarshaler<ABGUCharacter>(1, TargetList_PropertyAddress, CachedMarshalingDelegates<ABGUCharacter, UObjectMarshaler<ABGUCharacter>>.FromNative, CachedMarshalingDelegates<ABGUCharacter, UObjectMarshaler<ABGUCharacter>>.ToNative).ToNative(IntPtr.Add(nativeStruct, TargetList_Offset), TargetList);
		new TArrayCopyMarshaler<BUTamerActor>(1, TargetTamerList_PropertyAddress, CachedMarshalingDelegates<BUTamerActor, UObjectMarshaler<BUTamerActor>>.FromNative, CachedMarshalingDelegates<BUTamerActor, UObjectMarshaler<BUTamerActor>>.ToNative).ToNative(IntPtr.Add(nativeStruct, TargetTamerList_Offset), TargetTamerList);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseRangeSelect_Offset), 0, UseRangeSelect_PropertyAddress.Address, UseRangeSelect);
		EnumMarshaler<ERangeType>.ToNative(IntPtr.Add(nativeStruct, RangeType_Offset), 0, RangeType_PropertyAddress.Address, RangeType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RangeParam_1_Offset), RangeParam_1);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RangeParam_2_Offset), RangeParam_2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RangeParam_3_Offset), RangeParam_3);
		new TArrayCopyMarshaler<int>(1, ResIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ResIDList_Offset), ResIDList);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bSelectUnitHasTarget_Offset), 0, bSelectUnitHasTarget_PropertyAddress.Address, bSelectUnitHasTarget);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bSelectPassiveUnit_Offset), 0, bSelectPassiveUnit_PropertyAddress.Address, bSelectPassiveUnit);
	}

	public FGSWakeUpConfig(IntPtr nativeStruct)
	{
		if (FGSWakeUpConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSWakeUpConfig");
			OnFightSkillID = 0;
			DirectionOnFightSkillConfig = default(FGSWakeUpDirectionOnFightSkillConfig);
			bJustUseOnFightSkillFirstTime = false;
			SurpriseSkillID = null;
			WakeUpLinkEnable = false;
			CanTriggerWakeUpLinkWhenDead = false;
			UseManualSelect = false;
			TargetList = null;
			TargetTamerList = null;
			UseRangeSelect = false;
			RangeType = ERangeType.TargetBaseObj;
			RangeParam_1 = 0f;
			RangeParam_2 = 0f;
			RangeParam_3 = 0f;
			ResIDList = null;
			bSelectUnitHasTarget = false;
			bSelectPassiveUnit = false;
		}
		else
		{
			OnFightSkillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OnFightSkillID_Offset));
			DirectionOnFightSkillConfig = BlittableTypeMarshaler<FGSWakeUpDirectionOnFightSkillConfig>.FromNative(IntPtr.Add(nativeStruct, DirectionOnFightSkillConfig_Offset));
			bJustUseOnFightSkillFirstTime = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bJustUseOnFightSkillFirstTime_Offset), 0, bJustUseOnFightSkillFirstTime_PropertyAddress.Address);
			SurpriseSkillID = new TArrayCopyMarshaler<int>(1, SurpriseSkillID_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SurpriseSkillID_Offset));
			WakeUpLinkEnable = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, WakeUpLinkEnable_Offset), 0, WakeUpLinkEnable_PropertyAddress.Address);
			CanTriggerWakeUpLinkWhenDead = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanTriggerWakeUpLinkWhenDead_Offset), 0, CanTriggerWakeUpLinkWhenDead_PropertyAddress.Address);
			UseManualSelect = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseManualSelect_Offset), 0, UseManualSelect_PropertyAddress.Address);
			TargetList = new TArrayCopyMarshaler<ABGUCharacter>(1, TargetList_PropertyAddress, CachedMarshalingDelegates<ABGUCharacter, UObjectMarshaler<ABGUCharacter>>.FromNative, CachedMarshalingDelegates<ABGUCharacter, UObjectMarshaler<ABGUCharacter>>.ToNative).FromNative(IntPtr.Add(nativeStruct, TargetList_Offset));
			TargetTamerList = new TArrayCopyMarshaler<BUTamerActor>(1, TargetTamerList_PropertyAddress, CachedMarshalingDelegates<BUTamerActor, UObjectMarshaler<BUTamerActor>>.FromNative, CachedMarshalingDelegates<BUTamerActor, UObjectMarshaler<BUTamerActor>>.ToNative).FromNative(IntPtr.Add(nativeStruct, TargetTamerList_Offset));
			UseRangeSelect = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseRangeSelect_Offset), 0, UseRangeSelect_PropertyAddress.Address);
			RangeType = EnumMarshaler<ERangeType>.FromNative(IntPtr.Add(nativeStruct, RangeType_Offset), 0, RangeType_PropertyAddress.Address);
			RangeParam_1 = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RangeParam_1_Offset));
			RangeParam_2 = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RangeParam_2_Offset));
			RangeParam_3 = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RangeParam_3_Offset));
			ResIDList = new TArrayCopyMarshaler<int>(1, ResIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ResIDList_Offset));
			bSelectUnitHasTarget = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bSelectUnitHasTarget_Offset), 0, bSelectUnitHasTarget_PropertyAddress.Address);
			bSelectPassiveUnit = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bSelectPassiveUnit_Offset), 0, bSelectPassiveUnit_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSWakeUpConfig");
		FGSWakeUpConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		OnFightSkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "OnFightSkillID");
		OnFightSkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OnFightSkillID", Classes.FIntProperty);
		DirectionOnFightSkillConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "DirectionOnFightSkillConfig");
		DirectionOnFightSkillConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DirectionOnFightSkillConfig", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bJustUseOnFightSkillFirstTime_PropertyAddress, intPtr, "bJustUseOnFightSkillFirstTime");
		bJustUseOnFightSkillFirstTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "bJustUseOnFightSkillFirstTime");
		bJustUseOnFightSkillFirstTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bJustUseOnFightSkillFirstTime", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SurpriseSkillID_PropertyAddress, intPtr, "SurpriseSkillID");
		SurpriseSkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SurpriseSkillID");
		SurpriseSkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SurpriseSkillID", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref WakeUpLinkEnable_PropertyAddress, intPtr, "WakeUpLinkEnable");
		WakeUpLinkEnable_Offset = NativeReflection.GetPropertyOffset(intPtr, "WakeUpLinkEnable");
		WakeUpLinkEnable_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WakeUpLinkEnable", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CanTriggerWakeUpLinkWhenDead_PropertyAddress, intPtr, "CanTriggerWakeUpLinkWhenDead");
		CanTriggerWakeUpLinkWhenDead_Offset = NativeReflection.GetPropertyOffset(intPtr, "CanTriggerWakeUpLinkWhenDead");
		CanTriggerWakeUpLinkWhenDead_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CanTriggerWakeUpLinkWhenDead", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref UseManualSelect_PropertyAddress, intPtr, "UseManualSelect");
		UseManualSelect_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseManualSelect");
		UseManualSelect_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseManualSelect", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref TargetList_PropertyAddress, intPtr, "TargetList");
		TargetList_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetList");
		TargetList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref TargetTamerList_PropertyAddress, intPtr, "TargetTamerList");
		TargetTamerList_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetTamerList");
		TargetTamerList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetTamerList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref UseRangeSelect_PropertyAddress, intPtr, "UseRangeSelect");
		UseRangeSelect_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseRangeSelect");
		UseRangeSelect_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseRangeSelect", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref RangeType_PropertyAddress, intPtr, "RangeType");
		RangeType_Offset = NativeReflection.GetPropertyOffset(intPtr, "RangeType");
		RangeType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RangeType", Classes.FEnumProperty);
		RangeParam_1_Offset = NativeReflection.GetPropertyOffset(intPtr, "RangeParam_1");
		RangeParam_1_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RangeParam_1", Classes.FFloatProperty);
		RangeParam_2_Offset = NativeReflection.GetPropertyOffset(intPtr, "RangeParam_2");
		RangeParam_2_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RangeParam_2", Classes.FFloatProperty);
		RangeParam_3_Offset = NativeReflection.GetPropertyOffset(intPtr, "RangeParam_3");
		RangeParam_3_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RangeParam_3", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref ResIDList_PropertyAddress, intPtr, "ResIDList");
		ResIDList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ResIDList");
		ResIDList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ResIDList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref bSelectUnitHasTarget_PropertyAddress, intPtr, "bSelectUnitHasTarget");
		bSelectUnitHasTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSelectUnitHasTarget");
		bSelectUnitHasTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSelectUnitHasTarget", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bSelectPassiveUnit_PropertyAddress, intPtr, "bSelectPassiveUnit");
		bSelectPassiveUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSelectPassiveUnit");
		bSelectPassiveUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSelectPassiveUnit", Classes.FBoolProperty);
		FGSWakeUpConfig_IsValid = ((intPtr != IntPtr.Zero && OnFightSkillID_IsValid && DirectionOnFightSkillConfig_IsValid && bJustUseOnFightSkillFirstTime_IsValid && SurpriseSkillID_IsValid && WakeUpLinkEnable_IsValid && CanTriggerWakeUpLinkWhenDead_IsValid && UseManualSelect_IsValid && TargetList_IsValid && TargetTamerList_IsValid && UseRangeSelect_IsValid && RangeType_IsValid && RangeParam_1_IsValid && RangeParam_2_IsValid && RangeParam_3_IsValid && ResIDList_IsValid && bSelectUnitHasTarget_IsValid && bSelectPassiveUnit_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSWakeUpConfig", (byte)FGSWakeUpConfig_IsValid != 0);
	}

	static FGSWakeUpConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSWakeUpConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSWakeUpConfig));
	}
}
