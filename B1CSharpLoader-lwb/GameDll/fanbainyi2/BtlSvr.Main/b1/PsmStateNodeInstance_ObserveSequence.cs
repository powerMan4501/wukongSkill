using System;
using b1.EventDelDefine;
using CommB1;
using Google.Protobuf;

namespace b1;

public class PsmStateNodeInstance_ObserveSequence : PsmStateNodeInstance
{
	public override string NodeClass => "Process.State.ObserveSequence";

	private int SequenceID { get; set; }

	private int SuccessCount { get; set; }

	private int SuccessLimit { get; set; }

	private ProcessStateCustom_ObserveSequence CustomData { get; set; }

	private IBIC_MovieData MovieData { get; set; }

	public PsmStateNodeInstance_ObserveSequence()
	{
		SuccessLimit = 1;
	}

	public override void PostCreate()
	{
		CustomData = new ProcessStateCustom_ObserveSequence();
		CustomData.MergeFrom(base.Node.NodeData);
		SuccessLimit = CustomData.SuccessLimit;
		SequenceID = CustomData.SequenceId;
		MovieData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_MovieData, BIC_MovieData>(GetOwner());
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
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(GetOwner());
		bGW_EventCollection.Evt_NotifyMovieInstanceFinished = (Del_Void_Int)Delegate.Combine(bGW_EventCollection.Evt_NotifyMovieInstanceFinished, new Del_Void_Int(CheckSequenceFinish));
	}

	private void StopObserving()
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(GetOwner());
		bGW_EventCollection.Evt_NotifyMovieInstanceFinished = (Del_Void_Int)Delegate.Remove(bGW_EventCollection.Evt_NotifyMovieInstanceFinished, new Del_Void_Int(CheckSequenceFinish));
	}

	private void CheckSequenceFinish(int MovieSequenceID)
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
}
