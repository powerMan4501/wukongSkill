using System;
using System.Text;
using ArchiveB1;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using ResB1;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("复合条件查询")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_QueryCompoundCondition")]
internal class BED_ProcessStateNode_QueryCompoundCondition : BED_ProcessStateNode
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

	private TArrayReadWriteMarshaler<FProcessQueryConditionInfo> Conditions_Marshaler;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("条件逻辑关系")]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_QueryCompoundCondition:ConditionRelation")]
	public EConditionalRelation ConditionRelation
	{
		get
		{
			CheckDestroyed();
			if (!ConditionRelation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_QueryCompoundCondition:ConditionRelation");
				return EConditionalRelation.And;
			}
			return EnumMarshaler<EConditionalRelation>.FromNative(IntPtr.Add(base.Address, ConditionRelation_Offset), 0, ConditionRelation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ConditionRelation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_QueryCompoundCondition:ConditionRelation");
			}
			else
			{
				EnumMarshaler<EConditionalRelation>.ToNative(IntPtr.Add(base.Address, ConditionRelation_Offset), 0, ConditionRelation_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("是否反转条件")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_QueryCompoundCondition:bReverseCondition")]
	public bool bReverseCondition
	{
		get
		{
			CheckDestroyed();
			if (!bReverseCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_QueryCompoundCondition:bReverseCondition");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bReverseCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_QueryCompoundCondition:bReverseCondition");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("检测条件列表")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_QueryCompoundCondition:Conditions")]
	public TArrayReadWrite<FProcessQueryConditionInfo> Conditions
	{
		get
		{
			CheckDestroyed();
			if (!Conditions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_QueryCompoundCondition:Conditions");
				return null;
			}
			if (Conditions_Marshaler == null)
			{
				Conditions_Marshaler = new TArrayReadWriteMarshaler<FProcessQueryConditionInfo>(1, Conditions_PropertyAddress, CachedMarshalingDelegates<FProcessQueryConditionInfo, FProcessQueryConditionInfo>.FromNative, CachedMarshalingDelegates<FProcessQueryConditionInfo, FProcessQueryConditionInfo>.ToNative);
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

	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_QueryCompoundCondition:GetNodeDescriptionInCS")]
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
		foreach (FProcessQueryConditionInfo condition in Conditions)
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
				flag = true;
				stringBuilder.Append($"{text}查询交互记录，交互组ID是：{condition.InteractionGroupID}，交互步骤大于：{condition.InteractionStep}");
				break;
			case ETaskQueryCompoundConditionType.QueryActorState:
				flag = true;
				stringBuilder.Append(text + "查询单位状态，具体信息请查看Detail面板");
				break;
			case ETaskQueryCompoundConditionType.QueryOwningItem:
				flag = true;
				stringBuilder.Append($"{text}查询任务阶段，阶段ID是：{condition.TaskStageID}, 阶段状态是：{condition.TaskStageStateType}");
				break;
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
		TaskCustom_QueryCompoundCondition taskCustom_QueryCompoundCondition = new TaskCustom_QueryCompoundCondition();
		taskCustom_QueryCompoundCondition.IsReverseCondition = bReverseCondition;
		taskCustom_QueryCompoundCondition.ConditionRelationType = (LogicRelationType)ConditionRelation;
		foreach (FProcessQueryConditionInfo condition in Conditions)
		{
			UnitStatusInfo unitStatusInfo = new UnitStatusInfo();
			unitStatusInfo.UnitIsPlayer = condition.IsPlayer;
			foreach (FDetectCondition queryUnitCondition in condition.QueryUnitConditions)
			{
				unitStatusInfo.Conditions.Add(queryUnitCondition.GetSerializableObject());
			}
			taskCustom_QueryCompoundCondition.ConditionInfoList.Add(new OneQueryCompoundConditionInfo
			{
				IsReverseCondition = condition.bReverseCondition,
				ConditionType = (QueryCompoundConditionType)condition.TaskQueryConditionType,
				QueryTaskStageInfo = new QuestStageOne
				{
					Id = condition.TaskStageID,
					Stage = (QuestStage)condition.TaskStageStateType
				},
				QueryInteractionRecordInfo = new InteractionRecordInfo
				{
					InteractionGroupId = condition.InteractionGroupID,
					InteractionStep = condition.InteractionStep
				},
				QueryUnitStatusInfo = unitStatusInfo,
				QueryOwningItemInfo = new OwningItemInfo
				{
					ItemId = condition.OwningItemID,
					Num = condition.OwningItemNum
				}
			});
		}
		return taskCustom_QueryCompoundCondition.ToByteArray();
	}

	public override string GetNodeName()
	{
		return "Process.State.QueryCompoundCondition";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessStateNode_QueryCompoundCondition:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_ProcessStateNode_QueryCompoundCondition bED_ProcessStateNode_QueryCompoundCondition = GCHelper.Find<b1.BED_ProcessStateNode_QueryCompoundCondition>(obj);
		string nodeDescriptionInCS_Implementation = bED_ProcessStateNode_QueryCompoundCondition.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessStateNode_QueryCompoundCondition");
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessStateNode_QueryCompoundCondition:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_ProcessStateNode_QueryCompoundCondition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_ProcessStateNode_QueryCompoundCondition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_ProcessStateNode_QueryCompoundCondition));
	}
}
