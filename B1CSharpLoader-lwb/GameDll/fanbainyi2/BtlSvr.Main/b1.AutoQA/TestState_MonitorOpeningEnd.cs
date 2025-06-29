using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_MonitorOpeningEnd : AutoTestNodeLib.TestState_Node
{
	private bool PostPrologueCompleted;

	private void OpeningComplete()
	{
		PostPrologueCompleted = true;
	}

	public TestState_MonitorOpeningEnd(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(WorldContext);
		bGW_EventCollection.Evt_PostPrologueCompleted = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_PostPrologueCompleted, new Del_Void(OpeningComplete));
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> _, float DeltaTime)
	{
		if (PostPrologueCompleted)
		{
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(WorldContext);
			bGW_EventCollection.Evt_PostPrologueCompleted = (Del_Void)Delegate.Remove(bGW_EventCollection.Evt_PostPrologueCompleted, new Del_Void(OpeningComplete));
			Description = "已经等到了序章结束信号";
			return AutoTestNodeLib.NodeState.Succeeded;
		}
		Description = "正在等待序章结束信号中";
		return AutoTestNodeLib.NodeState.Running;
	}
}
