using System;
using System.Collections.Generic;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class QuestNodeInstance_AwardPrizesRandom : QuestNodeInstance, IObserveNodeInstance
{
	private int EventId { get; set; }

	private int SuccessCount { get; set; }

	private int SuccessLimit { get; set; }

	private bool bEnableObserving { get; set; }

	private float RefreshDelta { get; set; }

	private float CurRefreshDelta { get; set; }

	private float AwardCD { get; set; }

	private bool AwardState { get; set; }

	private int RandomCountMax { get; set; }

	private int NormalProbability { get; set; }

	private int FirstProbability { get; set; }

	private int SecondProbability { get; set; }

	private QuestCustom_AwardPrizesRandom CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_AwardPrizesRandom();
		CustomData.MergeFrom(base.Node.NodeData);
		SuccessLimit = CustomData.SuccessLimit;
		RandomCountMax = CustomData.RandomCount;
		NormalProbability = CustomData.NormalProbability;
		FirstProbability = CustomData.FirstProbability;
		SecondProbability = CustomData.SecondProbability;
		AwardCD = CustomData.AwardCd;
		EventId = CustomData.EventId;
		RefreshDelta = CustomData.RefreshDelta;
		CurRefreshDelta = CustomData.RefreshDelta;
	}

	public override byte[] GetNodeCustomData()
	{
		List<byte> list = new List<byte>();
		list.AddRange(BitConverter.GetBytes(SuccessCount));
		list.AddRange(BitConverter.GetBytes(bEnableObserving));
		return list.ToArray();
	}

	public override void RecoverActiveState()
	{
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
		int num = 0;
		SuccessCount = BitConverter.ToInt32(CustomData, num);
		num += 4;
		bEnableObserving = BitConverter.ToBoolean(CustomData, num);
		num++;
	}

	public override void Tick(float DeltaTime)
	{
		if (!bEnableObserving)
		{
			return;
		}
		if (AwardState)
		{
			BGC_RandomEventData readOnlyData = BGU_DataUtil.GetReadOnlyData<BGC_RandomEventData>(UGameplayStatics.GetGameState(base.Owner));
			if (readOnlyData != null && readOnlyData.GetCanAwardState(EventId))
			{
				AwardState = false;
				CurRefreshDelta = AwardCD;
				OnConditionSuccess();
			}
		}
		else if (CurRefreshDelta > 0f && RefreshDelta > 0f)
		{
			CurRefreshDelta -= DeltaTime;
			if (CurRefreshDelta < 0f)
			{
				CurRefreshDelta = RefreshDelta;
				AwardPrizesRandom();
			}
		}
	}

	private void AwardPrizesRandom()
	{
		BGC_RandomEventData readOnlyData = BGU_DataUtil.GetReadOnlyData<BGC_RandomEventData>(UGameplayStatics.GetGameState(base.Owner));
		if (readOnlyData == null)
		{
			return;
		}
		if (readOnlyData.GetAwardRandomCount(EventId) >= RandomCountMax)
		{
			bEnableObserving = false;
			return;
		}
		int curProbability = readOnlyData.GetRandomProbabilityDict(EventId).CurProbability;
		if (curProbability > 0)
		{
			if (FMath.RandRange(0, 10000) < curProbability)
			{
				AwardState = true;
			}
			else
			{
				CurRefreshDelta = RefreshDelta;
			}
			readOnlyData.SetAwardRandomCount(EventId);
		}
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (InputPin.Equals(BGW_FlowUtils.PinName.Enable.PlainName))
		{
			StartObserving();
			TriggerOutput(BGW_FlowUtils.PinName.Enabled.PlainName, bFinish: false);
		}
		else if (InputPin.Equals(BGW_FlowUtils.PinName.Disable.PlainName))
		{
			TriggerOutput(BGW_FlowUtils.PinName.Disabled.PlainName, bFinish: true);
		}
	}

	private void StartObserving()
	{
		BGU_DataUtil.GetReadOnlyData<BGC_RandomEventData>(UGameplayStatics.GetGameState(base.Owner)).RandomProbabilityDictAdd(NewRandomProbability: new AwardRandomEventInfo
		{
			FirstProbability = FirstProbability,
			SecondProbability = SecondProbability,
			CurProbability = NormalProbability
		}, EventId: EventId);
		bEnableObserving = true;
	}

	private void StopObserving()
	{
		BGS_EventCollectionCS.Get(base.Owner).Evt_BGS_StopObserve.Invoke(this);
		bEnableObserving = false;
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

	private void OnConditionSuccess()
	{
		TriggerOutput(BGW_FlowUtils.PinName.Success.PlainName, bFinish: false);
		SuccessCount++;
		if (SuccessLimit > 0 && SuccessCount >= SuccessLimit)
		{
			TriggerOutput(BGW_FlowUtils.PinName.Completed.PlainName, bFinish: true);
		}
	}
}
