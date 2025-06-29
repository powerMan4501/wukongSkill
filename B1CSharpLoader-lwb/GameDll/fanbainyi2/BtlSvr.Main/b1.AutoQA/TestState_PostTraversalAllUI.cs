using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_PostTraversalAllUI : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		CloseBag,
		GC,
		Memreport,
		End
	}

	private int TickCounter;

	private InnerState CurrentState;

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public TestState_PostTraversalAllUI(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		Description = "";
		switch (CurrentState)
		{
		case InnerState.CloseBag:
			if (TickCounter > 10)
			{
				Description = "关闭包裹完成";
				TransferState(InnerState.GC);
				return AutoTestNodeLib.NodeState.Running;
			}
			if (TickCounter == 5)
			{
				Description = "关闭包裹";
				AutoTestHelperLib.OpenBag(WorldContext, IsOpen: false);
			}
			break;
		case InnerState.GC:
			if (TickCounter > 10)
			{
				Description = "GC完成";
				TransferState(InnerState.Memreport);
				return AutoTestNodeLib.NodeState.Running;
			}
			if (TickCounter == 5)
			{
				Description = "GC两次";
				UObject.CollectGarbage();
				GC.Collect();
				GC.WaitForPendingFinalizers();
				UGSE_EngineFuncLib.EngineGC(bFullPurge: true);
				UObject.CollectGarbage();
				GC.Collect();
				GC.WaitForPendingFinalizers();
				UGSE_EngineFuncLib.EngineGC(bFullPurge: true);
			}
			break;
		case InnerState.Memreport:
			if (TickCounter > 10)
			{
				Description = "Memreport完成";
				TransferState(InnerState.End);
				return AutoTestNodeLib.NodeState.Running;
			}
			if (TickCounter == 5)
			{
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "memreport -full -name=PostTraversalAllUI", null);
			}
			break;
		case InnerState.End:
			if (TickCounter > 10)
			{
				Description = "全部执行完成";
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
