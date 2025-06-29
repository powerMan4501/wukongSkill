using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[Serializable]
[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.TaskQueryConditionInfo")]
public struct FTaskQueryConditionInfo
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("检测类型")]
	[USharpPath("/Script/b1-Managed.TaskQueryConditionInfo:TaskQueryConditionType")]
	public ETaskQueryCompoundConditionType TaskQueryConditionType;

	[DisplayName("是否反转条件")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TaskQueryConditionInfo:bReverseCondition")]
	public bool bReverseCondition;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("任务阶段ID")]
	[USharpPath("/Script/b1-Managed.TaskQueryConditionInfo:TaskStage")]
	public FGsSmartParam TaskStage;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("任务阶段状态")]
	[USharpPath("/Script/b1-Managed.TaskQueryConditionInfo:TaskStageStateType")]
	public ETaskStageStateType TaskStageStateType;

	[DisplayName("已交互GroupID")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TaskQueryConditionInfo:InteractionGroup")]
	public FGsSmartParam InteractionGroup;

	[UProperty]
	[DisplayName("已交互阶段")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TaskQueryConditionInfo:InteractionStep")]
	public int InteractionStep;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("单位GUID")]
	[USharpPath("/Script/b1-Managed.TaskQueryConditionInfo:Unit")]
	public FGsSmartParam Unit;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("检测条件")]
	[USharpPath("/Script/b1-Managed.TaskQueryConditionInfo:QueryUnitConditions")]
	public List<FDetectCondition> QueryUnitConditions;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("拥有物品ID")]
	[USharpPath("/Script/b1-Managed.TaskQueryConditionInfo:OwningItemID")]
	public int OwningItemID;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("拥有数量")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TaskQueryConditionInfo:OwningItemNum")]
	public int OwningItemNum;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("注释")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TaskQueryConditionInfo:Comment")]
	public string Comment;

	private static int TaskQueryConditionInfo_StructSize;

	private static int TaskQueryConditionInfo_IsValid;

	private static bool TaskQueryConditionType_IsValid;

	private static int TaskQueryConditionType_Offset;

	private static FFieldAddress TaskQueryConditionType_PropertyAddress;

	private static bool bReverseCondition_IsValid;

	private static int bReverseCondition_Offset;

	private static FFieldAddress bReverseCondition_PropertyAddress;

	private static bool TaskStage_IsValid;

	private static int TaskStage_Offset;

	private static bool TaskStageStateType_IsValid;

	private static int TaskStageStateType_Offset;

	private static FFieldAddress TaskStageStateType_PropertyAddress;

	private static bool InteractionGroup_IsValid;

	private static int InteractionGroup_Offset;

	private static bool InteractionStep_IsValid;

	private static int InteractionStep_Offset;

	private static bool Unit_IsValid;

	private static int Unit_Offset;

	private static bool QueryUnitConditions_IsValid;

	private static int QueryUnitConditions_Offset;

	private static FFieldAddress QueryUnitConditions_PropertyAddress;

	private static bool OwningItemID_IsValid;

	private static int OwningItemID_Offset;

	private static bool OwningItemNum_IsValid;

	private static int OwningItemNum_Offset;

	private static bool Comment_IsValid;

	private static int Comment_Offset;

	public FTaskQueryConditionInfo Copy()
	{
		FTaskQueryConditionInfo result = this;
		if (QueryUnitConditions != null)
		{
			result.QueryUnitConditions = new List<FDetectCondition>(QueryUnitConditions);
		}
		return result;
	}

	public static FTaskQueryConditionInfo FromNative(IntPtr nativeBuffer)
	{
		return new FTaskQueryConditionInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTaskQueryConditionInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTaskQueryConditionInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTaskQueryConditionInfo(IntPtr.Add(nativeBuffer, arrayIndex * TaskQueryConditionInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTaskQueryConditionInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TaskQueryConditionInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TaskQueryConditionInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TaskQueryConditionInfo");
			return;
		}
		EnumMarshaler<ETaskQueryCompoundConditionType>.ToNative(IntPtr.Add(nativeStruct, TaskQueryConditionType_Offset), 0, TaskQueryConditionType_PropertyAddress.Address, TaskQueryConditionType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address, bReverseCondition);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, TaskStage_Offset), TaskStage);
		EnumMarshaler<ETaskStageStateType>.ToNative(IntPtr.Add(nativeStruct, TaskStageStateType_Offset), 0, TaskStageStateType_PropertyAddress.Address, TaskStageStateType);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, InteractionGroup_Offset), InteractionGroup);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, InteractionStep_Offset), InteractionStep);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Unit_Offset), Unit);
		new TArrayCopyMarshaler<FDetectCondition>(1, QueryUnitConditions_PropertyAddress, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.FromNative, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.ToNative).ToNative(IntPtr.Add(nativeStruct, QueryUnitConditions_Offset), QueryUnitConditions);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OwningItemID_Offset), OwningItemID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OwningItemNum_Offset), OwningItemNum);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Comment_Offset), Comment);
	}

	public FTaskQueryConditionInfo(IntPtr nativeStruct)
	{
		if (TaskQueryConditionInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TaskQueryConditionInfo");
			TaskQueryConditionType = ETaskQueryCompoundConditionType.None;
			bReverseCondition = false;
			TaskStage = default(FGsSmartParam);
			TaskStageStateType = ETaskStageStateType.NoActive;
			InteractionGroup = default(FGsSmartParam);
			InteractionStep = 0;
			Unit = default(FGsSmartParam);
			QueryUnitConditions = null;
			OwningItemID = 0;
			OwningItemNum = 0;
			Comment = null;
		}
		else
		{
			TaskQueryConditionType = EnumMarshaler<ETaskQueryCompoundConditionType>.FromNative(IntPtr.Add(nativeStruct, TaskQueryConditionType_Offset), 0, TaskQueryConditionType_PropertyAddress.Address);
			bReverseCondition = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address);
			TaskStage = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, TaskStage_Offset));
			TaskStageStateType = EnumMarshaler<ETaskStageStateType>.FromNative(IntPtr.Add(nativeStruct, TaskStageStateType_Offset), 0, TaskStageStateType_PropertyAddress.Address);
			InteractionGroup = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, InteractionGroup_Offset));
			InteractionStep = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, InteractionStep_Offset));
			Unit = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Unit_Offset));
			QueryUnitConditions = new TArrayCopyMarshaler<FDetectCondition>(1, QueryUnitConditions_PropertyAddress, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.FromNative, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.ToNative).FromNative(IntPtr.Add(nativeStruct, QueryUnitConditions_Offset));
			OwningItemID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OwningItemID_Offset));
			OwningItemNum = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OwningItemNum_Offset));
			Comment = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Comment_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TaskQueryConditionInfo");
		TaskQueryConditionInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref TaskQueryConditionType_PropertyAddress, intPtr, "TaskQueryConditionType");
		TaskQueryConditionType_Offset = NativeReflection.GetPropertyOffset(intPtr, "TaskQueryConditionType");
		TaskQueryConditionType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TaskQueryConditionType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bReverseCondition_PropertyAddress, intPtr, "bReverseCondition");
		bReverseCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "bReverseCondition");
		bReverseCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bReverseCondition", Classes.FBoolProperty);
		TaskStage_Offset = NativeReflection.GetPropertyOffset(intPtr, "TaskStage");
		TaskStage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TaskStage", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref TaskStageStateType_PropertyAddress, intPtr, "TaskStageStateType");
		TaskStageStateType_Offset = NativeReflection.GetPropertyOffset(intPtr, "TaskStageStateType");
		TaskStageStateType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TaskStageStateType", Classes.FEnumProperty);
		InteractionGroup_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractionGroup");
		InteractionGroup_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractionGroup", Classes.FStructProperty);
		InteractionStep_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractionStep");
		InteractionStep_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractionStep", Classes.FIntProperty);
		Unit_Offset = NativeReflection.GetPropertyOffset(intPtr, "Unit");
		Unit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Unit", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref QueryUnitConditions_PropertyAddress, intPtr, "QueryUnitConditions");
		QueryUnitConditions_Offset = NativeReflection.GetPropertyOffset(intPtr, "QueryUnitConditions");
		QueryUnitConditions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "QueryUnitConditions", Classes.FArrayProperty);
		OwningItemID_Offset = NativeReflection.GetPropertyOffset(intPtr, "OwningItemID");
		OwningItemID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OwningItemID", Classes.FIntProperty);
		OwningItemNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "OwningItemNum");
		OwningItemNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OwningItemNum", Classes.FIntProperty);
		Comment_Offset = NativeReflection.GetPropertyOffset(intPtr, "Comment");
		Comment_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Comment", Classes.FStrProperty);
		TaskQueryConditionInfo_IsValid = ((intPtr != IntPtr.Zero && TaskQueryConditionType_IsValid && bReverseCondition_IsValid && TaskStage_IsValid && TaskStageStateType_IsValid && InteractionGroup_IsValid && InteractionStep_IsValid && Unit_IsValid && QueryUnitConditions_IsValid && OwningItemID_IsValid && OwningItemNum_IsValid && Comment_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TaskQueryConditionInfo", (byte)TaskQueryConditionInfo_IsValid != 0);
	}

	static FTaskQueryConditionInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTaskQueryConditionInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTaskQueryConditionInfo));
	}
}
