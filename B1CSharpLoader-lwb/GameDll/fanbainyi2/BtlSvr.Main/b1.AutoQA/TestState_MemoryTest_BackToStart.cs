using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_MemoryTest_BackToStart : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		Exec,
		Wait,
		End
	}

	private int TickCounter;

	private string MemReportName;

	private InnerState CurrentState;

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public TestState_MemoryTest_BackToStart(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	private string GetCurLevelName()
	{
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(WorldContext);
		if (worldFromObj != null)
		{
			return worldFromObj.GetName();
		}
		return "";
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		Description = CurrentState.ToString() + " " + TickCounter;
		switch (CurrentState)
		{
		case InnerState.Exec:
			BGW_EventCollection.Get(WorldContext).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.BackToMainMenu);
			TransferState(InnerState.Wait);
			break;
		case InnerState.Wait:
			if (GetCurLevelName() == "Startup_V2_P")
			{
				TransferState(InnerState.End);
			}
			break;
		case InnerState.End:
			if (TickCounter >= 60)
			{
				return AutoTestNodeLib.NodeState.Succeeded;
			}
			break;
		default:
			Description = "进入了异常测试状态，测试脚本有逻辑问题!";
			return AutoTestNodeLib.NodeState.Failed;
		}
		TickCounter++;
		return AutoTestNodeLib.NodeState.Running;
	}
}
