using System;
using System.Collections.Generic;
using System.Text;
using b1.CppExport;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class QuestNodeInstance_ObserveOnlineCondition : QuestNodeInstance, IObserveNodeInstance
{
	private EObserveOnlineConditionType ConditionType { get; set; }

	private int SuccessLimit { get; set; }

	private string ObservedActorGuid { get; set; }

	private GameplayTagContainerRef NotifyTags { get; set; }

	private int PlayerCount { get; set; }

	private int GainItemCount { get; set; }

	private int KillMonsterCount { get; set; }

	private int SuccessCount { get; set; }

	private bool bEnableObserving { get; set; }

	private int TraceDistance { get; set; }

	private int ItemId { get; set; }

	private int RandomCount { get; set; }

	private int EventId { get; set; }

	private QuestCustom_ObserveOnlineCondition CustomData { get; set; }

	public QuestNodeInstance_ObserveOnlineCondition()
	{
		SuccessLimit = 1;
	}

	protected override void PostCreate()
	{
		NotifyTags = new GameplayTagContainerRef();
		CustomData = new QuestCustom_ObserveOnlineCondition();
		CustomData.MergeFrom(base.Node.NodeData);
		ConditionType = (EObserveOnlineConditionType)CustomData.ConditionType;
		SuccessLimit = CustomData.SuccessLimit;
		ObservedActorGuid = CustomData.ObserveActorGuid;
		PlayerCount = CustomData.PlayerCount;
		GainItemCount = CustomData.GainItemCount;
		KillMonsterCount = CustomData.KillMonsterCount;
		TraceDistance = CustomData.TraceDistance;
		ItemId = CustomData.ItemId;
		EventId = CustomData.EventId;
		RandomCount = CustomData.RandomCount;
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
		int num = 0;
		SuccessCount = BitConverter.ToInt32(CustomData, num);
		num += 4;
		bEnableObserving = BitConverter.ToBoolean(CustomData, num);
		num++;
		NotifyTags.RemoveAllTags();
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
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (string.IsNullOrEmpty(ObservedActorGuid))
		{
			Finish();
		}
		else if (InputPin.Equals(BGW_FlowUtils.PinName.Enable.PlainName))
		{
			StartObserving();
			TriggerOutput(BGW_FlowUtils.PinName.Enabled.PlainName, bFinish: false);
		}
		else if (InputPin.Equals(BGW_FlowUtils.PinName.Disable.PlainName))
		{
			TriggerOutput(BGW_FlowUtils.PinName.Disabled.PlainName, bFinish: true);
		}
	}

	public override void Tick(float DeltaTime)
	{
		if (bEnableObserving)
		{
			AActor observeActor = ((!(ObservedActorGuid == B1GlobalFNames.Player_Wukong.PlainName)) ? BGU_DataUtil.GetActorByGuid(base.Owner, ObservedActorGuid) : UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner).GetControlledPawn());
			switch (ConditionType)
			{
			case EObserveOnlineConditionType.PlayerCountInRange:
				OnCheckPlayerCountInRange(observeActor);
				break;
			case EObserveOnlineConditionType.PlayerEnterBossTraceArea:
				OnCheckPlayerEnterBossTraceArea();
				break;
			case EObserveOnlineConditionType.KillMonsterNumber:
				OnCheckPlayerKillMonsterNumber();
				break;
			case EObserveOnlineConditionType.GainItemCumulative:
				OnCheckPlayerGainItemCumulative();
				break;
			case EObserveOnlineConditionType.AwardCount:
				OnCheckAwardCount();
				break;
			}
		}
	}

	private void StartObserving()
	{
		switch (ConditionType)
		{
		case EObserveOnlineConditionType.PlayerCountInRange:
			NotifyTags.AddTag(BGW_FlowUtils.CommonTag.OverlapBegin);
			break;
		case EObserveOnlineConditionType.PlayerEnterBossTraceArea:
			NotifyTags.AddTag(BGW_FlowUtils.CommonTag.OverlapBegin);
			break;
		}
		bEnableObserving = true;
		BGS_EventCollectionCS.Get(base.Owner).Evt_BGS_StartObserve.Invoke(this, ObservedActorGuid);
		MarkNodeArchiveDataDirty();
	}

	private void StopObserving()
	{
		BGS_EventCollectionCS.Get(base.Owner).Evt_BGS_StopObserve.Invoke(this);
		bEnableObserving = false;
		MarkNodeArchiveDataDirty();
	}

	public override void Shutdown()
	{
		StopObserving();
		SuccessCount = 0;
	}

	protected override void Finish()
	{
		base.Finish();
		StopObserving();
		SuccessCount = 0;
	}

	public override void OnNotifyGraph(string Guid, FGameplayTag Tag)
	{
		if (Guid == ObservedActorGuid && NotifyTags.HasTag(Tag))
		{
			BGS_EventCollectionCS.Get(base.Owner).Evt_BGS_RecordLastNotifyGraph.Invoke(Guid, Tag);
			OnConditionSuccess();
		}
	}

	private void OnConditionSuccess()
	{
		TriggerOutput(BGW_FlowUtils.PinName.Success.PlainName, bFinish: false);
		SuccessCount++;
		MarkNodeArchiveDataDirty();
		if (SuccessLimit > 0 && SuccessCount >= SuccessLimit)
		{
			TriggerOutput(BGW_FlowUtils.PinName.Completed.PlainName, bFinish: true);
		}
	}

	private void OnCheckPlayerCountInRange(AActor ObserveActor)
	{
		if (!(ObserveActor == null))
		{
			BUC_QuestPlayerCheckerData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_QuestPlayerCheckerData>(ObserveActor);
			if (readOnlyData != null && readOnlyData.GetCheckedActorsCount() == PlayerCount)
			{
				OnConditionSuccess();
			}
		}
	}

	private void OnCheckPlayerEnterBossTraceArea()
	{
		APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner).GetControlledPawn();
		if (controlledPawn == null)
		{
			return;
		}
		BGC_BossTraceData readOnlyData = BGU_DataUtil.GetReadOnlyData<BGC_BossTraceData>(UGameplayStatics.GetGameState(base.Owner));
		if (readOnlyData == null || readOnlyData.GetBossTraceList().Count == 0 || readOnlyData.GetBossTraceList().Count == 1)
		{
			return;
		}
		bool flag = false;
		foreach (BossTraceInfo bossTrace in readOnlyData.GetBossTraceList())
		{
			if (FVector.Distance(bossTrace.TraceCenterPoint.GetActorLocation(), controlledPawn.GetActorLocation()) < (float)TraceDistance)
			{
				readOnlyData.SetCurTrace(bossTrace.TraceCenterPoint);
				readOnlyData.ClearButCurTrace(bossTrace.TraceCenterPoint, controlledPawn);
				flag = true;
				break;
			}
		}
		if (flag)
		{
			OnConditionSuccess();
		}
	}

	private void OnCheckPlayerKillMonsterNumber()
	{
		if (!(UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner).GetControlledPawn() == null))
		{
			BGC_LevelBattleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BGC_LevelBattleData>(UGameplayStatics.GetGameState(base.Owner));
			if (readOnlyData != null && readOnlyData.KillMonsterCount >= KillMonsterCount)
			{
				OnConditionSuccess();
			}
		}
	}

	private void OnCheckPlayerGainItemCumulative()
	{
		if (!(UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner).GetControlledPawn() == null))
		{
			BGC_LevelBattleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BGC_LevelBattleData>(UGameplayStatics.GetGameState(base.Owner));
			if (readOnlyData != null && readOnlyData.ItemNumDict != null && (!readOnlyData.ItemNumDict.TryGetValue(ItemId, out var value) || value <= GainItemCount))
			{
				OnConditionSuccess();
			}
		}
	}

	private void OnCheckAwardCount()
	{
		BGC_RandomEventData readOnlyData = BGU_DataUtil.GetReadOnlyData<BGC_RandomEventData>(UGameplayStatics.GetGameState(base.Owner));
		if (readOnlyData == null || readOnlyData.GetAwardRandomCount(EventId) >= RandomCount)
		{
			OnConditionSuccess();
		}
	}
}
