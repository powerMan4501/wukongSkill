using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TransitionCondition_Guide")]
public struct FTransitionCondition_Guide
{
	[DisplayName("跳转条件类型")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Guide:ConditionType")]
	public ETransitionConditionType_Guide ConditionType;

	[EditAnywhere]
	[UProperty]
	[DisplayName("触发盒")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Guide:Overlap")]
	public FGsSmartParam Overlap;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("异常状态")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Guide:AbnormalState")]
	public EAbnormalStateType AbnormalState;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("复活点Id")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Guide:RebirthPointId")]
	public int RebirthPointId;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("指定怪物")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Guide:Unit")]
	public FGsSmartParam Unit;

	[EditAnywhere]
	[UProperty]
	[DisplayName("物品Id")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Guide:ItemId")]
	public int ItemId;

	[DisplayName("检测范围")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Guide:CheckRange")]
	public int CheckRange;

	[DisplayName("检测怪物ResID")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Guide:CheckResIdList")]
	public List<int> CheckResIdList;

	[EditAnywhere]
	[DisplayName("属性类型")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Guide:AttrFloatType")]
	public EBGUAttrFloat AttrFloatType;

	[DisplayName("属性比较方式")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Guide:CompareOperation")]
	public EValueCompareOperations CompareOperation;

	[UProperty]
	[DisplayName("属性比较值")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Guide:CompareValue")]
	public float CompareValue;

	[BlueprintReadWrite]
	[DisplayName("任务阶段ID")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Guide:TaskStage")]
	public FGsSmartParam TaskStage;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("任务阶段状态")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Guide:TaskStageStatus")]
	public EStageStatus TaskStageStatus;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("地图Id")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Guide:MapId")]
	public int MapId;

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("天赋Id")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Guide:TalentId")]
	public int TalentId;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("界面类型")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Guide:UIPageType")]
	public EUIPageType UIPageType;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("教学组Id")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Guide:GuideGroupId")]
	public int GuideGroupId;

	[DisplayName("Sequence Id")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Guide:SequenceId")]
	public int SequenceId;

	[DisplayName("播放阶段")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Guide:SequencePhase")]
	public ESequencePhase SequencePhase;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("物品数量")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Guide:ItemNum")]
	public int ItemNum;

	private static int TransitionCondition_Guide_StructSize;

	private static int TransitionCondition_Guide_IsValid;

	private static bool ConditionType_IsValid;

	private static int ConditionType_Offset;

	private static FFieldAddress ConditionType_PropertyAddress;

	private static bool Overlap_IsValid;

	private static int Overlap_Offset;

	private static bool AbnormalState_IsValid;

	private static int AbnormalState_Offset;

	private static FFieldAddress AbnormalState_PropertyAddress;

	private static bool RebirthPointId_IsValid;

	private static int RebirthPointId_Offset;

	private static bool Unit_IsValid;

	private static int Unit_Offset;

	private static bool ItemId_IsValid;

	private static int ItemId_Offset;

	private static bool CheckRange_IsValid;

	private static int CheckRange_Offset;

	private static bool CheckResIdList_IsValid;

	private static int CheckResIdList_Offset;

	private static FFieldAddress CheckResIdList_PropertyAddress;

	private static bool AttrFloatType_IsValid;

	private static int AttrFloatType_Offset;

	private static FFieldAddress AttrFloatType_PropertyAddress;

	private static bool CompareOperation_IsValid;

	private static int CompareOperation_Offset;

	private static FFieldAddress CompareOperation_PropertyAddress;

	private static bool CompareValue_IsValid;

	private static int CompareValue_Offset;

	private static bool TaskStage_IsValid;

	private static int TaskStage_Offset;

	private static bool TaskStageStatus_IsValid;

	private static int TaskStageStatus_Offset;

	private static FFieldAddress TaskStageStatus_PropertyAddress;

	private static bool MapId_IsValid;

	private static int MapId_Offset;

	private static bool TalentId_IsValid;

	private static int TalentId_Offset;

	private static bool UIPageType_IsValid;

	private static int UIPageType_Offset;

	private static FFieldAddress UIPageType_PropertyAddress;

	private static bool GuideGroupId_IsValid;

	private static int GuideGroupId_Offset;

	private static bool SequenceId_IsValid;

	private static int SequenceId_Offset;

	private static bool SequencePhase_IsValid;

	private static int SequencePhase_Offset;

	private static FFieldAddress SequencePhase_PropertyAddress;

	private static bool ItemNum_IsValid;

	private static int ItemNum_Offset;

	public FTransitionCondition_Guide Copy()
	{
		FTransitionCondition_Guide result = this;
		if (CheckResIdList != null)
		{
			result.CheckResIdList = new List<int>(CheckResIdList);
		}
		return result;
	}

	public static FTransitionCondition_Guide FromNative(IntPtr nativeBuffer)
	{
		return new FTransitionCondition_Guide(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTransitionCondition_Guide value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTransitionCondition_Guide FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTransitionCondition_Guide(IntPtr.Add(nativeBuffer, arrayIndex * TransitionCondition_Guide_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTransitionCondition_Guide value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TransitionCondition_Guide_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TransitionCondition_Guide_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TransitionCondition_Guide");
			return;
		}
		EnumMarshaler<ETransitionConditionType_Guide>.ToNative(IntPtr.Add(nativeStruct, ConditionType_Offset), 0, ConditionType_PropertyAddress.Address, ConditionType);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Overlap_Offset), Overlap);
		EnumMarshaler<EAbnormalStateType>.ToNative(IntPtr.Add(nativeStruct, AbnormalState_Offset), 0, AbnormalState_PropertyAddress.Address, AbnormalState);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, RebirthPointId_Offset), RebirthPointId);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Unit_Offset), Unit);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ItemId_Offset), ItemId);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CheckRange_Offset), CheckRange);
		new TArrayCopyMarshaler<int>(1, CheckResIdList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, CheckResIdList_Offset), CheckResIdList);
		EnumMarshaler<EBGUAttrFloat>.ToNative(IntPtr.Add(nativeStruct, AttrFloatType_Offset), 0, AttrFloatType_PropertyAddress.Address, AttrFloatType);
		EnumMarshaler<EValueCompareOperations>.ToNative(IntPtr.Add(nativeStruct, CompareOperation_Offset), 0, CompareOperation_PropertyAddress.Address, CompareOperation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CompareValue_Offset), CompareValue);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, TaskStage_Offset), TaskStage);
		EnumMarshaler<EStageStatus>.ToNative(IntPtr.Add(nativeStruct, TaskStageStatus_Offset), 0, TaskStageStatus_PropertyAddress.Address, TaskStageStatus);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MapId_Offset), MapId);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TalentId_Offset), TalentId);
		EnumMarshaler<EUIPageType>.ToNative(IntPtr.Add(nativeStruct, UIPageType_Offset), 0, UIPageType_PropertyAddress.Address, UIPageType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, GuideGroupId_Offset), GuideGroupId);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SequenceId_Offset), SequenceId);
		EnumMarshaler<ESequencePhase>.ToNative(IntPtr.Add(nativeStruct, SequencePhase_Offset), 0, SequencePhase_PropertyAddress.Address, SequencePhase);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ItemNum_Offset), ItemNum);
	}

	public FTransitionCondition_Guide(IntPtr nativeStruct)
	{
		if (TransitionCondition_Guide_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TransitionCondition_Guide");
			ConditionType = ETransitionConditionType_Guide.None;
			Overlap = default(FGsSmartParam);
			AbnormalState = EAbnormalStateType.None;
			RebirthPointId = 0;
			Unit = default(FGsSmartParam);
			ItemId = 0;
			CheckRange = 0;
			CheckResIdList = null;
			AttrFloatType = EBGUAttrFloat.None;
			CompareOperation = EValueCompareOperations.EqualTo;
			CompareValue = 0f;
			TaskStage = default(FGsSmartParam);
			TaskStageStatus = EStageStatus.Default;
			MapId = 0;
			TalentId = 0;
			UIPageType = EUIPageType.None;
			GuideGroupId = 0;
			SequenceId = 0;
			SequencePhase = ESequencePhase.None;
			ItemNum = 0;
		}
		else
		{
			ConditionType = EnumMarshaler<ETransitionConditionType_Guide>.FromNative(IntPtr.Add(nativeStruct, ConditionType_Offset), 0, ConditionType_PropertyAddress.Address);
			Overlap = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Overlap_Offset));
			AbnormalState = EnumMarshaler<EAbnormalStateType>.FromNative(IntPtr.Add(nativeStruct, AbnormalState_Offset), 0, AbnormalState_PropertyAddress.Address);
			RebirthPointId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, RebirthPointId_Offset));
			Unit = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Unit_Offset));
			ItemId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ItemId_Offset));
			CheckRange = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CheckRange_Offset));
			CheckResIdList = new TArrayCopyMarshaler<int>(1, CheckResIdList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, CheckResIdList_Offset));
			AttrFloatType = EnumMarshaler<EBGUAttrFloat>.FromNative(IntPtr.Add(nativeStruct, AttrFloatType_Offset), 0, AttrFloatType_PropertyAddress.Address);
			CompareOperation = EnumMarshaler<EValueCompareOperations>.FromNative(IntPtr.Add(nativeStruct, CompareOperation_Offset), 0, CompareOperation_PropertyAddress.Address);
			CompareValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CompareValue_Offset));
			TaskStage = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, TaskStage_Offset));
			TaskStageStatus = EnumMarshaler<EStageStatus>.FromNative(IntPtr.Add(nativeStruct, TaskStageStatus_Offset), 0, TaskStageStatus_PropertyAddress.Address);
			MapId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MapId_Offset));
			TalentId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TalentId_Offset));
			UIPageType = EnumMarshaler<EUIPageType>.FromNative(IntPtr.Add(nativeStruct, UIPageType_Offset), 0, UIPageType_PropertyAddress.Address);
			GuideGroupId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, GuideGroupId_Offset));
			SequenceId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SequenceId_Offset));
			SequencePhase = EnumMarshaler<ESequencePhase>.FromNative(IntPtr.Add(nativeStruct, SequencePhase_Offset), 0, SequencePhase_PropertyAddress.Address);
			ItemNum = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ItemNum_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TransitionCondition_Guide");
		TransitionCondition_Guide_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ConditionType_PropertyAddress, intPtr, "ConditionType");
		ConditionType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConditionType");
		ConditionType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConditionType", Classes.FEnumProperty);
		Overlap_Offset = NativeReflection.GetPropertyOffset(intPtr, "Overlap");
		Overlap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Overlap", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref AbnormalState_PropertyAddress, intPtr, "AbnormalState");
		AbnormalState_Offset = NativeReflection.GetPropertyOffset(intPtr, "AbnormalState");
		AbnormalState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AbnormalState", Classes.FEnumProperty);
		RebirthPointId_Offset = NativeReflection.GetPropertyOffset(intPtr, "RebirthPointId");
		RebirthPointId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RebirthPointId", Classes.FIntProperty);
		Unit_Offset = NativeReflection.GetPropertyOffset(intPtr, "Unit");
		Unit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Unit", Classes.FStructProperty);
		ItemId_Offset = NativeReflection.GetPropertyOffset(intPtr, "ItemId");
		ItemId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ItemId", Classes.FIntProperty);
		CheckRange_Offset = NativeReflection.GetPropertyOffset(intPtr, "CheckRange");
		CheckRange_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CheckRange", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref CheckResIdList_PropertyAddress, intPtr, "CheckResIdList");
		CheckResIdList_Offset = NativeReflection.GetPropertyOffset(intPtr, "CheckResIdList");
		CheckResIdList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CheckResIdList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref AttrFloatType_PropertyAddress, intPtr, "AttrFloatType");
		AttrFloatType_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttrFloatType");
		AttrFloatType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttrFloatType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref CompareOperation_PropertyAddress, intPtr, "CompareOperation");
		CompareOperation_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareOperation");
		CompareOperation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareOperation", Classes.FEnumProperty);
		CompareValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareValue");
		CompareValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareValue", Classes.FFloatProperty);
		TaskStage_Offset = NativeReflection.GetPropertyOffset(intPtr, "TaskStage");
		TaskStage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TaskStage", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref TaskStageStatus_PropertyAddress, intPtr, "TaskStageStatus");
		TaskStageStatus_Offset = NativeReflection.GetPropertyOffset(intPtr, "TaskStageStatus");
		TaskStageStatus_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TaskStageStatus", Classes.FEnumProperty);
		MapId_Offset = NativeReflection.GetPropertyOffset(intPtr, "MapId");
		MapId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MapId", Classes.FIntProperty);
		TalentId_Offset = NativeReflection.GetPropertyOffset(intPtr, "TalentId");
		TalentId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TalentId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref UIPageType_PropertyAddress, intPtr, "UIPageType");
		UIPageType_Offset = NativeReflection.GetPropertyOffset(intPtr, "UIPageType");
		UIPageType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UIPageType", Classes.FEnumProperty);
		GuideGroupId_Offset = NativeReflection.GetPropertyOffset(intPtr, "GuideGroupId");
		GuideGroupId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GuideGroupId", Classes.FIntProperty);
		SequenceId_Offset = NativeReflection.GetPropertyOffset(intPtr, "SequenceId");
		SequenceId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SequenceId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref SequencePhase_PropertyAddress, intPtr, "SequencePhase");
		SequencePhase_Offset = NativeReflection.GetPropertyOffset(intPtr, "SequencePhase");
		SequencePhase_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SequencePhase", Classes.FEnumProperty);
		ItemNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "ItemNum");
		ItemNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ItemNum", Classes.FIntProperty);
		TransitionCondition_Guide_IsValid = ((intPtr != IntPtr.Zero && ConditionType_IsValid && Overlap_IsValid && AbnormalState_IsValid && RebirthPointId_IsValid && Unit_IsValid && ItemId_IsValid && CheckRange_IsValid && CheckResIdList_IsValid && AttrFloatType_IsValid && CompareOperation_IsValid && CompareValue_IsValid && TaskStage_IsValid && TaskStageStatus_IsValid && MapId_IsValid && TalentId_IsValid && UIPageType_IsValid && GuideGroupId_IsValid && SequenceId_IsValid && SequencePhase_IsValid && ItemNum_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TransitionCondition_Guide", (byte)TransitionCondition_Guide_IsValid != 0);
	}

	static FTransitionCondition_Guide()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTransitionCondition_Guide)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTransitionCondition_Guide));
	}
}
