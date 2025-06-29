using System;
using b1.EventDelDefine;
using CommB1;
using Google.Protobuf;

namespace b1;

public class TaskNodeInstance_ObserveSequence : QuestNodeInstance
{
	private ESequencePhase SequencePhase { get; set; }

	private int SequenceID { get; set; }

	private int SuccessCount { get; set; }

	private int SuccessLimit { get; set; }

	private IBIC_MovieData MovieData { get; set; }

	public TaskNodeInstance_ObserveSequence()
	{
		SuccessLimit = 1;
	}

	protected override void PostCreate()
	{
		switch (base.Node.CustomDataVersion)
		{
		case 0u:
		{
			ProcessStateCustom_ObserveSequence processStateCustom_ObserveSequence = new ProcessStateCustom_ObserveSequence();
			processStateCustom_ObserveSequence.MergeFrom(base.Node.NodeData);
			SuccessLimit = processStateCustom_ObserveSequence.SuccessLimit;
			SequenceID = processStateCustom_ObserveSequence.SequenceId;
			SequencePhase = ESequencePhase.Finished;
			break;
		}
		case 1u:
		{
			TaskCustom_ObserveSequence taskCustom_ObserveSequence = new TaskCustom_ObserveSequence();
			taskCustom_ObserveSequence.MergeFrom(base.Node.NodeData);
			SuccessLimit = taskCustom_ObserveSequence.SuccessLimit;
			SequenceID = taskCustom_ObserveSequence.SequenceId;
			SequencePhase = (ESequencePhase)taskCustom_ObserveSequence.SequencePhase;
			break;
		}
		}
		MovieData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_MovieData, BIC_MovieData>(base.Owner);
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
		if (MovieData.IsSequencePlayed(SequenceID))
		{
			OnConditionSuccess();
			return;
		}
		switch (SequencePhase)
		{
		case ESequencePhase.Started:
		{
			BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(base.Owner);
			bGW_EventCollection2.Evt_NotifyMovieInstanceStarted = (Del_Void_Int)Delegate.Combine(bGW_EventCollection2.Evt_NotifyMovieInstanceStarted, new Del_Void_Int(CheckSequenceInCurrentPhase));
			break;
		}
		case ESequencePhase.Finished:
		{
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
			bGW_EventCollection.Evt_NotifyMovieInstanceFinished = (Del_Void_Int)Delegate.Combine(bGW_EventCollection.Evt_NotifyMovieInstanceFinished, new Del_Void_Int(CheckSequenceInCurrentPhase));
			break;
		}
		case ESequencePhase.None:
			break;
		}
	}

	private void StopObserving()
	{
		switch (SequencePhase)
		{
		case ESequencePhase.Started:
		{
			BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(base.Owner);
			bGW_EventCollection2.Evt_NotifyMovieInstanceStarted = (Del_Void_Int)Delegate.Remove(bGW_EventCollection2.Evt_NotifyMovieInstanceStarted, new Del_Void_Int(CheckSequenceInCurrentPhase));
			break;
		}
		case ESequencePhase.Finished:
		{
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
			bGW_EventCollection.Evt_NotifyMovieInstanceFinished = (Del_Void_Int)Delegate.Remove(bGW_EventCollection.Evt_NotifyMovieInstanceFinished, new Del_Void_Int(CheckSequenceInCurrentPhase));
			break;
		}
		case ESequencePhase.None:
			break;
		}
	}

	private void CheckSequenceInCurrentPhase(int MovieSequenceID)
	{
		if (SequenceID == MovieSequenceID)
		{
			OnConditionSuccess();
		}
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

	public override bool CheckNodeQueryable(out string ErrorMassager)
	{
		if (BGW_GameDB.GetMovieSequenceDesc(SequenceID) == null)
		{
			ErrorMassager = "不存在的SequenceID";
			return false;
		}
		ErrorMassager = "";
		return true;
	}

	public override byte[] GetNodeCustomData()
	{
		return BitConverter.GetBytes(SuccessCount);
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
		if (CustomData.Length >= 4)
		{
			SuccessCount = BitConverter.ToInt32(CustomData, 0);
		}
	}

	public override void RecoverActiveState()
	{
		StartObserving();
	}
}
