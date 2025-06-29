using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[Serializable]
[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.ProcessQueryConditionInfo")]
public struct FProcessQueryConditionInfo
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("检测类型")]
	[USharpPath("/Script/b1-Managed.ProcessQueryConditionInfo:TaskQueryConditionType")]
	public ETaskQueryCompoundConditionType TaskQueryConditionType;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否反转条件")]
	[USharpPath("/Script/b1-Managed.ProcessQueryConditionInfo:bReverseCondition")]
	public bool bReverseCondition;

	[DisplayName("任务阶段ID")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ProcessQueryConditionInfo:TaskStageID")]
	public int TaskStageID;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("任务阶段状态")]
	[USharpPath("/Script/b1-Managed.ProcessQueryConditionInfo:TaskStageStateType")]
	public ETaskStageStateType TaskStageStateType;

	[EditAnywhere]
	[DisplayName("已交互GroupID")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ProcessQueryConditionInfo:InteractionGroupID")]
	public int InteractionGroupID;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("已交互阶段")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ProcessQueryConditionInfo:InteractionStep")]
	public int InteractionStep;

	[DisplayName("选择玩家")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ProcessQueryConditionInfo:IsPlayer")]
	public bool IsPlayer;

	[DisplayName("检测条件")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ProcessQueryConditionInfo:QueryUnitConditions")]
	public List<FDetectCondition> QueryUnitConditions;

	[BlueprintReadWrite]
	[DisplayName("拥有物品ID")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ProcessQueryConditionInfo:OwningItemID")]
	public int OwningItemID;

	[UProperty]
	[EditAnywhere]
	[DisplayName("拥有数量")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ProcessQueryConditionInfo:OwningItemNum")]
	public int OwningItemNum;

	[DisplayName("注释")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ProcessQueryConditionInfo:Comment")]
	public string Comment;

	private static int ProcessQueryConditionInfo_StructSize;

	private static int ProcessQueryConditionInfo_IsValid;

	private static bool TaskQueryConditionType_IsValid;

	private static int TaskQueryConditionType_Offset;

	private static FFieldAddress TaskQueryConditionType_PropertyAddress;

	private static bool bReverseCondition_IsValid;

	private static int bReverseCondition_Offset;

	private static FFieldAddress bReverseCondition_PropertyAddress;

	private static bool TaskStageID_IsValid;

	private static int TaskStageID_Offset;

	private static bool TaskStageStateType_IsValid;

	private static int TaskStageStateType_Offset;

	private static FFieldAddress TaskStageStateType_PropertyAddress;

	private static bool InteractionGroupID_IsValid;

	private static int InteractionGroupID_Offset;

	private static bool InteractionStep_IsValid;

	private static int InteractionStep_Offset;

	private static bool IsPlayer_IsValid;

	private static int IsPlayer_Offset;

	private static FFieldAddress IsPlayer_PropertyAddress;

	private static bool QueryUnitConditions_IsValid;

	private static int QueryUnitConditions_Offset;

	private static FFieldAddress QueryUnitConditions_PropertyAddress;

	private static bool OwningItemID_IsValid;

	private static int OwningItemID_Offset;

	private static bool OwningItemNum_IsValid;

	private static int OwningItemNum_Offset;

	private static bool Comment_IsValid;

	private static int Comment_Offset;

	public FProcessQueryConditionInfo Copy()
	{
		FProcessQueryConditionInfo result = this;
		if (QueryUnitConditions != null)
		{
			result.QueryUnitConditions = new List<FDetectCondition>(QueryUnitConditions);
		}
		return result;
	}

	public static FProcessQueryConditionInfo FromNative(IntPtr nativeBuffer)
	{
		return new FProcessQueryConditionInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FProcessQueryConditionInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FProcessQueryConditionInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FProcessQueryConditionInfo(IntPtr.Add(nativeBuffer, arrayIndex * ProcessQueryConditionInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FProcessQueryConditionInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ProcessQueryConditionInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ProcessQueryConditionInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ProcessQueryConditionInfo");
			return;
		}
		EnumMarshaler<ETaskQueryCompoundConditionType>.ToNative(IntPtr.Add(nativeStruct, TaskQueryConditionType_Offset), 0, TaskQueryConditionType_PropertyAddress.Address, TaskQueryConditionType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address, bReverseCondition);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TaskStageID_Offset), TaskStageID);
		EnumMarshaler<ETaskStageStateType>.ToNative(IntPtr.Add(nativeStruct, TaskStageStateType_Offset), 0, TaskStageStateType_PropertyAddress.Address, TaskStageStateType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, InteractionGroupID_Offset), InteractionGroupID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, InteractionStep_Offset), InteractionStep);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsPlayer_Offset), 0, IsPlayer_PropertyAddress.Address, IsPlayer);
		new TArrayCopyMarshaler<FDetectCondition>(1, QueryUnitConditions_PropertyAddress, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.FromNative, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.ToNative).ToNative(IntPtr.Add(nativeStruct, QueryUnitConditions_Offset), QueryUnitConditions);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OwningItemID_Offset), OwningItemID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OwningItemNum_Offset), OwningItemNum);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Comment_Offset), Comment);
	}

	public FProcessQueryConditionInfo(IntPtr nativeStruct)
	{
		if (ProcessQueryConditionInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ProcessQueryConditionInfo");
			TaskQueryConditionType = ETaskQueryCompoundConditionType.None;
			bReverseCondition = false;
			TaskStageID = 0;
			TaskStageStateType = ETaskStageStateType.NoActive;
			InteractionGroupID = 0;
			InteractionStep = 0;
			IsPlayer = false;
			QueryUnitConditions = null;
			OwningItemID = 0;
			OwningItemNum = 0;
			Comment = null;
		}
		else
		{
			TaskQueryConditionType = EnumMarshaler<ETaskQueryCompoundConditionType>.FromNative(IntPtr.Add(nativeStruct, TaskQueryConditionType_Offset), 0, TaskQueryConditionType_PropertyAddress.Address);
			bReverseCondition = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address);
			TaskStageID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TaskStageID_Offset));
			TaskStageStateType = EnumMarshaler<ETaskStageStateType>.FromNative(IntPtr.Add(nativeStruct, TaskStageStateType_Offset), 0, TaskStageStateType_PropertyAddress.Address);
			InteractionGroupID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, InteractionGroupID_Offset));
			InteractionStep = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, InteractionStep_Offset));
			IsPlayer = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsPlayer_Offset), 0, IsPlayer_PropertyAddress.Address);
			QueryUnitConditions = new TArrayCopyMarshaler<FDetectCondition>(1, QueryUnitConditions_PropertyAddress, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.FromNative, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.ToNative).FromNative(IntPtr.Add(nativeStruct, QueryUnitConditions_Offset));
			OwningItemID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OwningItemID_Offset));
			OwningItemNum = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OwningItemNum_Offset));
			Comment = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Comment_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ProcessQueryConditionInfo");
		ProcessQueryConditionInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref TaskQueryConditionType_PropertyAddress, intPtr, "TaskQueryConditionType");
		TaskQueryConditionType_Offset = NativeReflection.GetPropertyOffset(intPtr, "TaskQueryConditionType");
		TaskQueryConditionType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TaskQueryConditionType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bReverseCondition_PropertyAddress, intPtr, "bReverseCondition");
		bReverseCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "bReverseCondition");
		bReverseCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bReverseCondition", Classes.FBoolProperty);
		TaskStageID_Offset = NativeReflection.GetPropertyOffset(intPtr, "TaskStageID");
		TaskStageID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TaskStageID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref TaskStageStateType_PropertyAddress, intPtr, "TaskStageStateType");
		TaskStageStateType_Offset = NativeReflection.GetPropertyOffset(intPtr, "TaskStageStateType");
		TaskStageStateType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TaskStageStateType", Classes.FEnumProperty);
		InteractionGroupID_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractionGroupID");
		InteractionGroupID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractionGroupID", Classes.FIntProperty);
		InteractionStep_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractionStep");
		InteractionStep_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractionStep", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref IsPlayer_PropertyAddress, intPtr, "IsPlayer");
		IsPlayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsPlayer");
		IsPlayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsPlayer", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref QueryUnitConditions_PropertyAddress, intPtr, "QueryUnitConditions");
		QueryUnitConditions_Offset = NativeReflection.GetPropertyOffset(intPtr, "QueryUnitConditions");
		QueryUnitConditions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "QueryUnitConditions", Classes.FArrayProperty);
		OwningItemID_Offset = NativeReflection.GetPropertyOffset(intPtr, "OwningItemID");
		OwningItemID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OwningItemID", Classes.FIntProperty);
		OwningItemNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "OwningItemNum");
		OwningItemNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OwningItemNum", Classes.FIntProperty);
		Comment_Offset = NativeReflection.GetPropertyOffset(intPtr, "Comment");
		Comment_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Comment", Classes.FStrProperty);
		ProcessQueryConditionInfo_IsValid = ((intPtr != IntPtr.Zero && TaskQueryConditionType_IsValid && bReverseCondition_IsValid && TaskStageID_IsValid && TaskStageStateType_IsValid && InteractionGroupID_IsValid && InteractionStep_IsValid && IsPlayer_IsValid && QueryUnitConditions_IsValid && OwningItemID_IsValid && OwningItemNum_IsValid && Comment_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ProcessQueryConditionInfo", (byte)ProcessQueryConditionInfo_IsValid != 0);
	}

	static FProcessQueryConditionInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FProcessQueryConditionInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FProcessQueryConditionInfo));
	}
}
