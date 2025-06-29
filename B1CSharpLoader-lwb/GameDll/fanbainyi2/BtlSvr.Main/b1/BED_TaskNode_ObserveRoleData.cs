using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArchiveB1;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using ResB1;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("观察玩家数据")]
[NotBlueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.BED_TaskNode_ObserveRoleData")]
public class BED_TaskNode_ObserveRoleData : BED_TaskNode
{
	private static bool ObserveMinSuccessConditionNum_IsValid;

	private static int ObserveMinSuccessConditionNum_Offset;

	private static bool ObserveRoleDataInfoList_IsValid;

	private static int ObserveRoleDataInfoList_Offset;

	private static FFieldAddress ObserveRoleDataInfoList_PropertyAddress;

	private TArrayReadWriteMarshaler<FObserveRoleDataInfo> ObserveRoleDataInfoList_Marshaler;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("最低达成条件数量")]
	[UMeta(MDProp.ClampMin, "1")]
	[USharpPath("/Script/b1-Managed.BED_TaskNode_ObserveRoleData:ObserveMinSuccessConditionNum")]
	public int ObserveMinSuccessConditionNum
	{
		get
		{
			CheckDestroyed();
			if (!ObserveMinSuccessConditionNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_ObserveRoleData:ObserveMinSuccessConditionNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ObserveMinSuccessConditionNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ObserveMinSuccessConditionNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_ObserveRoleData:ObserveMinSuccessConditionNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ObserveMinSuccessConditionNum_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("观察信息列表")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_TaskNode_ObserveRoleData:ObserveRoleDataInfoList")]
	protected TArrayReadWrite<FObserveRoleDataInfo> ObserveRoleDataInfoList
	{
		get
		{
			CheckDestroyed();
			if (!ObserveRoleDataInfoList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_ObserveRoleData:ObserveRoleDataInfoList");
				return null;
			}
			if (ObserveRoleDataInfoList_Marshaler == null)
			{
				ObserveRoleDataInfoList_Marshaler = new TArrayReadWriteMarshaler<FObserveRoleDataInfo>(1, ObserveRoleDataInfoList_PropertyAddress, CachedMarshalingDelegates<FObserveRoleDataInfo, FObserveRoleDataInfo>.FromNative, CachedMarshalingDelegates<FObserveRoleDataInfo, FObserveRoleDataInfo>.ToNative);
			}
			return ObserveRoleDataInfoList_Marshaler.FromNative(IntPtr.Add(base.Address, ObserveRoleDataInfoList_Offset));
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeCategory("Observe");
		SetNodeStyle(ECalliopeNodeStyle.Condition);
		base.InputPins.Clear();
		base.InputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Enable
		});
		base.InputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Disable
		});
		base.OutputPins.Clear();
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Success
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Enabled
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Disabled
		});
		ObserveMinSuccessConditionNum = 1;
	}

	[USharpPath("/Script/b1-Managed.BED_TaskNode_ObserveRoleData:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine($"达成Success的最低条件满足数量是：{ObserveMinSuccessConditionNum}");
		stringBuilder.Append($"条件数量：{ObserveRoleDataInfoList.Count}");
		string arg = "\n";
		int num = 1;
		foreach (FObserveRoleDataInfo observeRoleDataInfo in ObserveRoleDataInfoList)
		{
			bool flag = false;
			switch (observeRoleDataInfo.ObserveType)
			{
			case ERoleDataType.ConsumedItem:
				flag = true;
				stringBuilder.Append($"{arg}观察消耗物品，物品ID是：{observeRoleDataInfo.ConsumeItemID}，消耗数量大于等于：{observeRoleDataInfo.ConsumptionQuantity}");
				break;
			case ERoleDataType.OwningItem:
				flag = true;
				stringBuilder.Append($"{arg}观察拥有物品，物品ID是：{observeRoleDataInfo.OwningItemID}，拥有数量大于等于：{observeRoleDataInfo.OwningNum}");
				break;
			case ERoleDataType.InteractionRecord:
				flag = true;
				stringBuilder.Append($"{arg}观察交互记录，交互组ID是：{GetAssetInCS().GetInteractorGroupIDBySmartParam(observeRoleDataInfo.InteractorGroupID)}，交互步骤大于：{observeRoleDataInfo.InteractionStep}");
				break;
			case ERoleDataType.TaskStage:
				flag = true;
				stringBuilder.Append($"{arg}观察任务阶段，阶段ID是：{GetAssetInCS().GetTaskStageIDBySmartParam(observeRoleDataInfo.TaskStage)}, 阶段状态是：{observeRoleDataInfo.ObserveTaskStageState}");
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
		BED_CalliopeAssetBase assetInCS = GetAssetInCS();
		if (assetInCS == null)
		{
			return new byte[1];
		}
		TaskCustom_ObserveRoleData taskCustom_ObserveRoleData = new TaskCustom_ObserveRoleData();
		taskCustom_ObserveRoleData.ObserveMinSuccessConditionNum = ObserveMinSuccessConditionNum;
		for (int i = 0; i < ObserveRoleDataInfoList.Count; i++)
		{
			FObserveRoleDataInfo fObserveRoleDataInfo = ObserveRoleDataInfoList[i];
			int num = (int)(fObserveRoleDataInfo.ObserveType - 1);
			if (Enum.IsDefined(typeof(ObserveRoleDataType), num))
			{
				taskCustom_ObserveRoleData.ObserveInfoList.Add(new OneObserveRoleDataInfo
				{
					Index = i,
					ObserveType = (ObserveRoleDataType)num,
					ObserveTaskStageInfo = new QuestStageOne
					{
						Id = assetInCS.GetTaskStageIDBySmartParam(fObserveRoleDataInfo.TaskStage),
						Stage = (QuestStage)fObserveRoleDataInfo.ObserveTaskStageState
					},
					ObserveInteractionRecordInfo = new InteractionRecordInfo
					{
						InteractionGroupId = assetInCS.GetInteractorGroupIDBySmartParam(fObserveRoleDataInfo.InteractorGroupID),
						InteractionStep = fObserveRoleDataInfo.InteractionStep
					},
					ObserveOwningItemInfo = new OwningItemInfo
					{
						ItemId = fObserveRoleDataInfo.OwningItemID,
						Num = fObserveRoleDataInfo.OwningNum
					},
					ObserveComsumedItemInfo = new ConsumedItemInfo
					{
						ItemId = fObserveRoleDataInfo.ConsumeItemID,
						Num = fObserveRoleDataInfo.ConsumptionQuantity
					}
				});
			}
		}
		return taskCustom_ObserveRoleData.ToByteArray();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.TaskNode.ObserveRoleData;
	}

	public override bool CheckNodeQueryable(out string ErrorMassager)
	{
		ErrorMassager = "";
		List<ConsumeDesc> list = GameDBRuntime.GetTBConsumeDesc().List.ToList();
		List<ItemDesc> list2 = GameDBRuntime.GetTBItemDesc().List.ToList();
		foreach (FObserveRoleDataInfo DataInfo in ObserveRoleDataInfoList)
		{
			switch (DataInfo.ObserveType)
			{
			case ERoleDataType.ConsumedItem:
				if (list.Find((ConsumeDesc e) => e.Id == DataInfo.ConsumeItemID) == null)
				{
					ErrorMassager += "不存在的消耗物ID";
				}
				break;
			case ERoleDataType.OwningItem:
				if (list2.Find((ItemDesc e) => e.Id == DataInfo.OwningItemID) == null)
				{
					ErrorMassager += "不存在的Item物品ID";
				}
				break;
			}
		}
		if (ErrorMassager != "")
		{
			return false;
		}
		return true;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskNode_ObserveRoleData:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskNode_ObserveRoleData bED_TaskNode_ObserveRoleData = GCHelper.Find<BED_TaskNode_ObserveRoleData>(obj);
		string nodeDescriptionInCS_Implementation = bED_TaskNode_ObserveRoleData.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_TaskNode_ObserveRoleData");
		ObserveMinSuccessConditionNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveMinSuccessConditionNum");
		ObserveMinSuccessConditionNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveMinSuccessConditionNum", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref ObserveRoleDataInfoList_PropertyAddress, intPtr, "ObserveRoleDataInfoList");
		ObserveRoleDataInfoList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveRoleDataInfoList");
		ObserveRoleDataInfoList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveRoleDataInfoList", Classes.FArrayProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskNode_ObserveRoleData:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_TaskNode_ObserveRoleData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_TaskNode_ObserveRoleData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_TaskNode_ObserveRoleData));
	}
}
