using System;
using System.Text;
using ArchiveB1;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using ResB1;
using UnrealEngine.Runtime;

namespace b1;

[NotBlueprintable]
[DisplayName("复合条件查询")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_TaskNode_QueryCompoundCondition")]
public class BED_TaskNode_QueryCompoundCondition : BED_TaskNode
{
	private static bool ConditionRelation_IsValid;

	private static int ConditionRelation_Offset;

	private static FFieldAddress ConditionRelation_PropertyAddress;

	private static bool bReverseCondition_IsValid;

	private static int bReverseCondition_Offset;

	private static FFieldAddress bReverseCondition_PropertyAddress;

	private static bool Conditions_IsValid;

	private static int Conditions_Offset;

	private static FFieldAddress Conditions_PropertyAddress;

	private TArrayReadWriteMarshaler<FTaskQueryConditionInfo> Conditions_Marshaler;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("条件逻辑关系")]
	[USharpPath("/Script/b1-Managed.BED_TaskNode_QueryCompoundCondition:ConditionRelation")]
	public EConditionalRelation ConditionRelation
	{
		get
		{
			CheckDestroyed();
			if (!ConditionRelation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_QueryCompoundCondition:ConditionRelation");
				return EConditionalRelation.And;
			}
			return EnumMarshaler<EConditionalRelation>.FromNative(IntPtr.Add(base.Address, ConditionRelation_Offset), 0, ConditionRelation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ConditionRelation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_QueryCompoundCondition:ConditionRelation");
			}
			else
			{
				EnumMarshaler<EConditionalRelation>.ToNative(IntPtr.Add(base.Address, ConditionRelation_Offset), 0, ConditionRelation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[DisplayName("是否反转条件")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_TaskNode_QueryCompoundCondition:bReverseCondition")]
	public bool bReverseCondition
	{
		get
		{
			CheckDestroyed();
			if (!bReverseCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_QueryCompoundCondition:bReverseCondition");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bReverseCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_QueryCompoundCondition:bReverseCondition");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("检测条件列表")]
	[USharpPath("/Script/b1-Managed.BED_TaskNode_QueryCompoundCondition:Conditions")]
	public TArrayReadWrite<FTaskQueryConditionInfo> Conditions
	{
		get
		{
			CheckDestroyed();
			if (!Conditions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_QueryCompoundCondition:Conditions");
				return null;
			}
			if (Conditions_Marshaler == null)
			{
				Conditions_Marshaler = new TArrayReadWriteMarshaler<FTaskQueryConditionInfo>(1, Conditions_PropertyAddress, CachedMarshalingDelegates<FTaskQueryConditionInfo, FTaskQueryConditionInfo>.FromNative, CachedMarshalingDelegates<FTaskQueryConditionInfo, FTaskQueryConditionInfo>.ToNative);
			}
			return Conditions_Marshaler.FromNative(IntPtr.Add(base.Address, Conditions_Offset));
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeCategory("Query");
		SetNodeStyle(ECalliopeNodeStyle.Condition);
		base.OutputPins.Clear();
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Success
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Failed
		});
	}

	[USharpPath("/Script/b1-Managed.BED_TaskNode_QueryCompoundCondition:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		switch (ConditionRelation)
		{
		case EConditionalRelation.And:
			stringBuilder.AppendLine("且条件，同时满足所有条件才算Success");
			break;
		case EConditionalRelation.Or:
			stringBuilder.AppendLine("或条件，满足任意条件就算Success");
			break;
		}
		if (bReverseCondition)
		{
			stringBuilder.AppendLine("【整体条件反转】");
		}
		stringBuilder.Append($"条件数量：{Conditions.Count}");
		int num = 1;
		foreach (FTaskQueryConditionInfo condition in Conditions)
		{
			string text = (condition.bReverseCondition ? $"\n 条件{num}：【条件反转】" : $"\n 条件{num}：");
			bool flag = false;
			switch (condition.TaskQueryConditionType)
			{
			case ETaskQueryCompoundConditionType.QueryTaskStageState:
				flag = true;
				stringBuilder.Append($"{text}查询拥有物品，物品ID是：{condition.OwningItemID}，拥有数量大于：{condition.OwningItemNum}");
				break;
			case ETaskQueryCompoundConditionType.QueryInteractionRecord:
			{
				flag = true;
				GetAssetInCS().GetParameterDisplayNameByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(condition.InteractionGroup.ConfigGuid), "InteractorID", out var OutDisplayName2);
				stringBuilder.Append($"{text}查询交互记录，交互组ID是：{OutDisplayName2}，交互步骤大于：{condition.InteractionStep}");
				break;
			}
			case ETaskQueryCompoundConditionType.QueryActorState:
				flag = true;
				stringBuilder.Append(text + "查询单位状态，具体信息请查看Detail面板");
				break;
			case ETaskQueryCompoundConditionType.QueryOwningItem:
			{
				flag = true;
				GetAssetInCS().GetParameterDisplayNameByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(condition.TaskStage.ConfigGuid), "InteractorID", out var OutDisplayName);
				stringBuilder.Append($"{text}查询任务阶段，阶段ID是：{OutDisplayName}, 阶段状态是：{condition.TaskStageStateType}");
				break;
			}
			}
			if (flag)
			{
				num++;
			}
			if (num > 3)
			{
				stringBuilder.AppendLine("");
				stringBuilder.Append("合法条件数量过多，暂只显示三个，更多请打开Detail面板查看！");
				break;
			}
		}
		return stringBuilder.ToString();
	}

	public override byte[] GetCustomData()
	{
		BED_CalliopeAssetBase assetInCS = GetAssetInCS();
		if (assetInCS == null)
		{
			return new byte[1];
		}
		TaskCustom_QueryCompoundCondition taskCustom_QueryCompoundCondition = new TaskCustom_QueryCompoundCondition();
		taskCustom_QueryCompoundCondition.IsReverseCondition = bReverseCondition;
		taskCustom_QueryCompoundCondition.ConditionRelationType = (LogicRelationType)ConditionRelation;
		foreach (FTaskQueryConditionInfo condition in Conditions)
		{
			UnitStatusInfo unitStatusInfo = new UnitStatusInfo();
			unitStatusInfo.UnitIsPlayer = condition.Unit.ConfigGuid == Guid.Empty;
			unitStatusInfo.UnitGuid = assetInCS.GetUnitGuidBySmartParam(condition.Unit);
			foreach (FDetectCondition queryUnitCondition in condition.QueryUnitConditions)
			{
				unitStatusInfo.Conditions.Add(queryUnitCondition.GetSerializableObject());
			}
			OneQueryCompoundConditionInfo oneQueryCompoundConditionInfo = new OneQueryCompoundConditionInfo();
			oneQueryCompoundConditionInfo.IsReverseCondition = condition.bReverseCondition;
			oneQueryCompoundConditionInfo.ConditionType = (QueryCompoundConditionType)condition.TaskQueryConditionType;
			oneQueryCompoundConditionInfo.QueryTaskStageInfo = new QuestStageOne();
			oneQueryCompoundConditionInfo.QueryTaskStageInfo.Id = assetInCS.GetTaskStageIDBySmartParam(condition.TaskStage);
			oneQueryCompoundConditionInfo.QueryTaskStageInfo.Stage = (QuestStage)condition.TaskStageStateType;
			oneQueryCompoundConditionInfo.QueryInteractionRecordInfo = new InteractionRecordInfo();
			oneQueryCompoundConditionInfo.QueryInteractionRecordInfo.InteractionGroupId = assetInCS.GetInteractorGroupIDBySmartParam(condition.InteractionGroup);
			oneQueryCompoundConditionInfo.QueryInteractionRecordInfo.InteractionStep = condition.InteractionStep;
			oneQueryCompoundConditionInfo.QueryUnitStatusInfo = unitStatusInfo;
			oneQueryCompoundConditionInfo.QueryOwningItemInfo = new OwningItemInfo
			{
				ItemId = condition.OwningItemID,
				Num = condition.OwningItemNum
			};
			taskCustom_QueryCompoundCondition.ConditionInfoList.Add(oneQueryCompoundConditionInfo);
		}
		return taskCustom_QueryCompoundCondition.ToByteArray();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.TaskNode.QueryCompoundCondition;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskNode_QueryCompoundCondition:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskNode_QueryCompoundCondition bED_TaskNode_QueryCompoundCondition = GCHelper.Find<BED_TaskNode_QueryCompoundCondition>(obj);
		string nodeDescriptionInCS_Implementation = bED_TaskNode_QueryCompoundCondition.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_TaskNode_QueryCompoundCondition");
		NativeReflection.GetPropertyRef(ref ConditionRelation_PropertyAddress, intPtr, "ConditionRelation");
		ConditionRelation_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConditionRelation");
		ConditionRelation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConditionRelation", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bReverseCondition_PropertyAddress, intPtr, "bReverseCondition");
		bReverseCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "bReverseCondition");
		bReverseCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bReverseCondition", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Conditions_PropertyAddress, intPtr, "Conditions");
		Conditions_Offset = NativeReflection.GetPropertyOffset(intPtr, "Conditions");
		Conditions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Conditions", Classes.FArrayProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskNode_QueryCompoundCondition:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_TaskNode_QueryCompoundCondition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_TaskNode_QueryCompoundCondition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_TaskNode_QueryCompoundCondition));
	}
}
