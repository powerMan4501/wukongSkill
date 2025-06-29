using System;
using System.Collections.Generic;
using System.Text;
using b1.CppExport;
using b1.ECS;
using BtlShare;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class TaskNodeInstance_ObserveUnitByCondition : QuestNodeInstance, IObserveNodeInstance
{
	private static string Player_Wukong_PlainName = B1GlobalFNames.Player_Wukong.PlainName;

	private static string Enable_PlainName = BGW_FlowUtils.PinName.Enable.PlainName;

	private static string Enabled_PlainName = BGW_FlowUtils.PinName.Enabled.PlainName;

	private static string Disable_PlainName = BGW_FlowUtils.PinName.Disable.PlainName;

	private static string Disabled_PlainName = BGW_FlowUtils.PinName.Disabled.PlainName;

	private static string Success_PlainName = BGW_FlowUtils.PinName.Success.PlainName;

	private static string Completed_PlainName = BGW_FlowUtils.PinName.Completed.PlainName;

	private EObserveConditionType ConditionType { get; set; }

	private int SuccessLimit { get; set; }

	private string ObservedActorGuid { get; set; }

	private EBGUUnitState UnitState { get; set; }

	private EBGUSimpleState SimpleState { get; set; }

	private EBGUAttrFloat AttrFloatType { get; set; }

	private EValueCompareOperations CompareOperation { get; set; }

	private float CompareValue { get; set; }

	private int BuffId { get; set; }

	private GameplayTagContainerRef NotifyTags { get; set; }

	private int SuccessCount { get; set; }

	private bool bEnableObserving { get; set; }

	private TaskCustom_ObserveUnitByCondition CustomData { get; set; }

	public TaskNodeInstance_ObserveUnitByCondition()
	{
		SuccessLimit = 1;
	}

	protected override void PostCreate()
	{
		NotifyTags = new GameplayTagContainerRef();
		CustomData = new TaskCustom_ObserveUnitByCondition();
		CustomData.MergeFrom(base.Node.NodeData);
		ConditionType = (EObserveConditionType)CustomData.ConditionType;
		SuccessLimit = CustomData.SuccessLimit;
		ObservedActorGuid = CustomData.ObserveActorGuid;
		UnitState = (EBGUUnitState)CustomData.UnitState;
		SimpleState = (EBGUSimpleState)CustomData.SimpleState;
		AttrFloatType = (EBGUAttrFloat)CustomData.AttrFloatType;
		CompareOperation = (EValueCompareOperations)CustomData.CompareOperation;
		CompareValue = CustomData.CompareValue;
		BuffId = CustomData.BuffId;
	}

	public override byte[] GetNodeCustomData()
	{
		List<byte> list = new List<byte>();
		list.AddRange(BitConverter.GetBytes(SuccessCount));
		list.AddRange(BitConverter.GetBytes(bEnableObserving));
		NotifyTags.GetAllTagStrList(out var TagStrList);
		list.AddRange(BitConverter.GetBytes(TagStrList.Count));
		foreach (string item in TagStrList)
		{
			list.AddRange(BitConverter.GetBytes(item.Length));
			list.AddRange(Encoding.UTF8.GetBytes(item));
		}
		return list.ToArray();
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
		NotifyTags.RemoveAllTags();
		int num = 0;
		SuccessCount = BitConverter.ToInt32(CustomData, num);
		num += 4;
		bEnableObserving = BitConverter.ToBoolean(CustomData, num);
		num++;
		int num2 = BitConverter.ToInt32(CustomData, num);
		num += 4;
		for (int i = 0; i < num2; i++)
		{
			int num3 = BitConverter.ToInt32(CustomData, num);
			num += 4;
			string str = Encoding.UTF8.GetString(CustomData, num, num3);
			num += num3;
			NotifyTags.AddTag(GameplayTagExtension.MakeGameplayTag(str));
		}
	}

	public override void RecoverActiveState()
	{
		StartObserving();
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (string.IsNullOrEmpty(ObservedActorGuid))
		{
			Finish();
		}
		else if (InputPin.Equals(Enable_PlainName))
		{
			StartObserving();
			TriggerOutput(Enabled_PlainName, bFinish: false);
		}
		else if (InputPin.Equals(Disable_PlainName))
		{
			TriggerOutput(Disabled_PlainName, bFinish: true);
		}
	}

	public override void Tick(float DeltaTime)
	{
		if (bEnableObserving && (int)ConditionType >= 100)
		{
			AActor observeActor = ((!(ObservedActorGuid == Player_Wukong_PlainName)) ? BGU_DataUtil.GetActorByGuid(base.Owner, ObservedActorGuid) : UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner)?.GetControlledPawn());
			switch (ConditionType)
			{
			case EObserveConditionType.UnitDestroy:
				OnCheckUnitDestroy(observeActor);
				break;
			case EObserveConditionType.UnitActive:
				OnCheckUnitActive(observeActor, bActiveOrInactive: true);
				break;
			case EObserveConditionType.UnitInActive:
				OnCheckUnitActive(observeActor, bActiveOrInactive: false);
				break;
			case EObserveConditionType.UnitAttr:
				OnCheckUnitAttr(observeActor);
				break;
			case EObserveConditionType.SimpleState:
				OnCheckSimpleState(observeActor);
				break;
			case EObserveConditionType.UnitState:
				OnCheckUnitState(observeActor);
				break;
			case EObserveConditionType.HasBuff:
				OnCheckBuff(observeActor);
				break;
			}
		}
	}

	private void StartObserving()
	{
		if ((int)ConditionType < 100)
		{
			switch (ConditionType)
			{
			case EObserveConditionType.PlayerEnterArea:
				NotifyTags.AddTag(BGW_FlowUtils.CommonTag.OverlapBegin);
				break;
			case EObserveConditionType.PlayerLeaveArea:
				NotifyTags.AddTag(BGW_FlowUtils.CommonTag.OverlapEnd);
				break;
			case EObserveConditionType.PlayerPenetrateArea:
				NotifyTags.AddTag(BGW_FlowUtils.CommonTag.Penetrate);
				break;
			case EObserveConditionType.PlayerInteractBegin:
				NotifyTags.AddTag(BGW_FlowUtils.CommonTag.InteractionBegin);
				break;
			case EObserveConditionType.PlayerInteractBreak:
				NotifyTags.AddTag(BGW_FlowUtils.CommonTag.InteractionBreak);
				break;
			case EObserveConditionType.PlayerInteractEnd:
				NotifyTags.AddTag(BGW_FlowUtils.CommonTag.InteractionEnd);
				break;
			case EObserveConditionType.PlayerInteractTimeEnd:
				NotifyTags.AddTag(BGW_FlowUtils.CommonTag.InteractionTimeEmpty);
				break;
			case EObserveConditionType.UnitAllDeadInnerRange:
				NotifyTags.AddTag(BGW_FlowUtils.CommonTag.AllDead);
				break;
			case EObserveConditionType.TimeOver:
				NotifyTags.AddTag(BGW_FlowUtils.CommonTag.TimeOver);
				break;
			case EObserveConditionType.TimeOut:
				NotifyTags.AddTag(BGW_FlowUtils.CommonTag.TimeOut);
				break;
			case EObserveConditionType.WakeUp:
				NotifyTags.AddTag(BGW_FlowUtils.CommonTag.WakeUp);
				break;
			case EObserveConditionType.UnitDead:
				NotifyTags.AddTag(BGW_FlowUtils.CommonTag.UnitDead);
				break;
			case EObserveConditionType.Trigger:
				NotifyTags.AddTag(BGW_FlowUtils.CommonTag.Trigger);
				break;
			case EObserveConditionType.SpawnUnitAllDead:
				NotifyTags.AddTag(BGW_FlowUtils.CommonTag.SpawnUnitAllDead);
				break;
			case EObserveConditionType.GateOpen:
				NotifyTags.AddTag(BGW_FlowUtils.CommonTag.GateOpen);
				break;
			case EObserveConditionType.GateClose:
				NotifyTags.AddTag(BGW_FlowUtils.CommonTag.GateClose);
				break;
			}
			BGW_EventCollection.Get(base.Owner).Evt_TaskGraphStartObserve(this, ObservedActorGuid);
		}
		else
		{
			bEnableObserving = true;
		}
		MarkNodeArchiveDataDirty();
	}

	private void StopObserving()
	{
		BGW_EventCollection.Get(base.Owner).Evt_TaskGraphStopObserve(this);
		bEnableObserving = false;
		MarkNodeArchiveDataDirty();
	}

	protected override void Finish()
	{
		StopObserving();
		SuccessCount = 0;
		base.Finish();
	}

	public override void OnNotifyGraph(string Guid, FGameplayTag Tag)
	{
		if ((int)ConditionType < 100 && Guid == ObservedActorGuid && NotifyTags.HasTag(Tag))
		{
			OnConditionSuccess();
		}
	}

	private void OnConditionSuccess()
	{
		TriggerOutput(Success_PlainName, bFinish: false);
		SuccessCount++;
		MarkNodeArchiveDataDirty();
		if (SuccessLimit > 0 && SuccessCount >= SuccessLimit)
		{
			TriggerOutput(Completed_PlainName, bFinish: true);
		}
	}

	private void OnCheckUnitDestroy(AActor ObserveActor)
	{
		if (ObserveActor == null)
		{
			OnConditionSuccess();
		}
	}

	private void OnCheckUnitActive(AActor ObserveActor, bool bActiveOrInactive)
	{
		if (!(ObserveActor == null) && BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(ObserveActor).GetTargetInfo().LockTargetEntity != Entity.Null == bActiveOrInactive)
		{
			OnConditionSuccess();
		}
	}

	private void OnCheckUnitAttr(AActor ObserveActor)
	{
		if (ObserveActor == null)
		{
			return;
		}
		IBUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(ObserveActor);
		if (readOnlyData != null)
		{
			float floatValue = readOnlyData.GetFloatValue(AttrFloatType);
			float floatValMin = readOnlyData.GetFloatValMin(AttrFloatType);
			float floatValMax = readOnlyData.GetFloatValMax(AttrFloatType);
			float num = (floatValue - floatValMin) / (floatValMax - floatValMin) * 100f;
			bool flag;
			switch (CompareOperation)
			{
			default:
				return;
			case EValueCompareOperations.EqualTo:
				flag = Math.Abs(floatValue - CompareValue) < 1E-08f;
				break;
			case EValueCompareOperations.NotEqualTo:
				flag = Math.Abs(floatValue - CompareValue) > 1E-08f;
				break;
			case EValueCompareOperations.LessThan:
				flag = floatValue < CompareValue;
				break;
			case EValueCompareOperations.LessThanOrEqualTo:
				flag = floatValue <= CompareValue;
				break;
			case EValueCompareOperations.GreaterThan:
				flag = floatValue > CompareValue;
				break;
			case EValueCompareOperations.GreaterThanOrEqualTo:
				flag = floatValue >= CompareValue;
				break;
			case EValueCompareOperations.LessThanPercentage:
				flag = num < CompareValue;
				break;
			case EValueCompareOperations.LessThanOrEqualToPercentage:
				flag = num <= CompareValue;
				break;
			case EValueCompareOperations.GreaterThanPercentage:
				flag = num > CompareValue;
				break;
			case EValueCompareOperations.GreaterThanOrEqualToPercentage:
				flag = num >= CompareValue;
				break;
			}
			if (flag)
			{
				OnConditionSuccess();
			}
		}
	}

	private void OnCheckSimpleState(AActor ObserveActor)
	{
		if (!(ObserveActor == null))
		{
			IBUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(ObserveActor);
			if (readOnlyData != null && readOnlyData.HasSimpleState(SimpleState))
			{
				OnConditionSuccess();
			}
		}
	}

	private void OnCheckUnitState(AActor ObserveActor)
	{
		if (!(ObserveActor == null))
		{
			IBUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(ObserveActor);
			if (readOnlyData != null && readOnlyData.HasState(UnitState))
			{
				OnConditionSuccess();
			}
		}
	}

	private void OnCheckBuff(AActor ObserveActor)
	{
		if (!(ObserveActor == null) && BGUFunctionLibraryCS.BGUHasBuffByID(ObserveActor, BuffId))
		{
			OnConditionSuccess();
		}
	}
}
