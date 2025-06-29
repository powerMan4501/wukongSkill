using System;
using b1.EventDelDefine;

namespace b1;

public class FSMState_GI_Global_InBenchMark : FSMState_GI_GlobalBase
{
	public override void Init(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
	}

	public override void OnEnter()
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Context.OwnerUObj);
		bGW_EventCollection.Evt_BenchMarkFinishBackToSetting = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_BenchMarkFinishBackToSetting, new Del_Void(OnBenchMarkFinish));
		BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(Context.OwnerUObj);
		bGW_EventCollection2.Evt_BenchMarkFinishReDo = (Del_Void)Delegate.Combine(bGW_EventCollection2.Evt_BenchMarkFinishReDo, new Del_Void(OnBenchMarkRedo));
	}

	private void OnBenchMarkFinish()
	{
		base.OwningInstance.TriggerSubGraphEvent(EGI_Global_SubG_GI_Global_BenchMark_Return.BenchMark);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Context.OwnerUObj);
		bGW_EventCollection.Evt_BenchMarkFinishBackToSetting = (Del_Void)Delegate.Remove(bGW_EventCollection.Evt_BenchMarkFinishBackToSetting, new Del_Void(OnBenchMarkFinish));
		BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(Context.OwnerUObj);
		bGW_EventCollection2.Evt_BenchMarkFinishReDo = (Del_Void)Delegate.Remove(bGW_EventCollection2.Evt_BenchMarkFinishReDo, new Del_Void(OnBenchMarkRedo));
	}

	private void OnBenchMarkRedo()
	{
		BGW_EventCollection.Get(Context.OwnerUObj).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.BenchMark);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Context.OwnerUObj);
		bGW_EventCollection.Evt_BenchMarkFinishBackToSetting = (Del_Void)Delegate.Remove(bGW_EventCollection.Evt_BenchMarkFinishBackToSetting, new Del_Void(OnBenchMarkFinish));
		BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(Context.OwnerUObj);
		bGW_EventCollection2.Evt_BenchMarkFinishReDo = (Del_Void)Delegate.Remove(bGW_EventCollection2.Evt_BenchMarkFinishReDo, new Del_Void(OnBenchMarkRedo));
	}

	public override int OnTick(float Delta)
	{
		return 100;
	}

	public override void OnExit()
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Context.OwnerUObj);
		bGW_EventCollection.Evt_BenchMarkFinishReDo = (Del_Void)Delegate.Remove(bGW_EventCollection.Evt_BenchMarkFinishReDo, new Del_Void(OnBenchMarkRedo));
		BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(Context.OwnerUObj);
		bGW_EventCollection2.Evt_BenchMarkFinishBackToSetting = (Del_Void)Delegate.Remove(bGW_EventCollection2.Evt_BenchMarkFinishBackToSetting, new Del_Void(OnBenchMarkFinish));
	}
}
