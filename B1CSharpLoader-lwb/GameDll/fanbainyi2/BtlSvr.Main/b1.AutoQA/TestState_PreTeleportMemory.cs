using System;
using System.Collections.Generic;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_PreTeleportMemory : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		WaitForPreload,
		GC,
		Memreport,
		Finish
	}

	private int TickCounter;

	private InnerState CurrentState;

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public TestState_PreTeleportMemory(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		Description = "";
		switch (CurrentState)
		{
		case InnerState.WaitForPreload:
		{
			Description = "等待Preload完成中";
			BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(WorldContext);
			if (bGW_PreloadAssetMgr != null && bGW_PreloadAssetMgr.PreloadCountLeft() < 10)
			{
				Description = "预加载已经完成，可以开始测试";
				TransferState(InnerState.GC);
			}
			break;
		}
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
				TransferState(InnerState.Finish);
				return AutoTestNodeLib.NodeState.Running;
			}
			if (TickCounter == 5)
			{
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "memreport -full -name=PreTeleportMemory", null);
			}
			else if (TickCounter == 6)
			{
				TestState_MemReportAnalysis.ExtraCalMemoryData("PreTeleportMemory");
			}
			break;
		case InnerState.Finish:
			if (TickCounter > 10)
			{
				Description = "完成";
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
