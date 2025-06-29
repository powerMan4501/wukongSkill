using System;
using System.Collections.Generic;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_TakePhoto_CompleteCoverage : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		WaitForPreload,
		Memreport1,
		OpenUI,
		SwitchTab,
		ChangeValue,
		End,
		Memreport2
	}

	private readonly int WatchTime;

	private bool IsDebug;

	private int TickCounter;

	private List<int>.Enumerator TabIndex = new List<int> { 1, 2, 3, 4, 5 }.GetEnumerator();

	private InnerState CurrentState;

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public TestState_TakePhoto_CompleteCoverage(UObject WorldContext, int InWatchTime = 5, bool InIsDebug = false)
	{
		base.WorldContext = WorldContext;
		WatchTime = InWatchTime;
		IsDebug = InIsDebug;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		Description = CurrentState.ToString() + " " + TickCounter;
		switch (CurrentState)
		{
		case InnerState.WaitForPreload:
		{
			Description = "等待Preload完成中";
			BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(WorldContext);
			if (bGW_PreloadAssetMgr != null && bGW_PreloadAssetMgr.PreloadCountLeft() < 10)
			{
				Description = "预加载已经完成，可以开始测试";
				TransferState(InnerState.Memreport1);
			}
			break;
		}
		case InnerState.Memreport1:
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
			else if (TickCounter == 10)
			{
				Description = "导出PreMemreport";
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "memreport -full -name=PreTakePhotoCompleteCoverage", null);
			}
			else if (TickCounter >= 15)
			{
				TransferState(InnerState.OpenUI);
			}
			break;
		case InnerState.OpenUI:
			if (TickCounter == 1)
			{
				BGUFunctionLibraryManaged.RunScriptGM("GMEnterTPMode", WorldContext);
				BGWGameInstanceCS.Get(WorldContext).AddTickEvenWhenPausedList(BIS_AutoTestManagerV2.Get(WorldContext));
			}
			else if (TickCounter == 3)
			{
				TransferState(InnerState.SwitchTab);
			}
			break;
		case InnerState.SwitchTab:
			if (TabIndex.MoveNext())
			{
				if (TabIndex.Current != 1)
				{
					QASimulateWindowsOperations.KeyPress(QASimulateWindowsOperations.KeyCode.KEY_C);
				}
				TransferState(InnerState.ChangeValue);
			}
			else
			{
				TransferState(InnerState.End);
			}
			break;
		case InnerState.ChangeValue:
			if (TickCounter > 50)
			{
				TransferState(InnerState.SwitchTab);
			}
			else if (TickCounter != 1 && TickCounter % 10 == 1)
			{
				QASimulateWindowsOperations.KeyPress(QASimulateWindowsOperations.KeyCode.DOWN);
			}
			else
			{
				QASimulateWindowsOperations.KeyPress(QASimulateWindowsOperations.KeyCode.RIGHT);
			}
			break;
		case InnerState.End:
			if (TickCounter == 2)
			{
				QASimulateWindowsOperations.KeyPress(QASimulateWindowsOperations.KeyCode.ESC);
			}
			else if (TickCounter == 5)
			{
				BGWGameInstanceCS.Get(WorldContext).RemoveTickEvenWhenPausedList(BIS_AutoTestManagerV2.Get(WorldContext));
			}
			else if (TickCounter > 10)
			{
				TransferState(InnerState.Memreport2);
			}
			break;
		case InnerState.Memreport2:
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
			else if (TickCounter == 10)
			{
				Description = "导出PostMemreport";
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "memreport -full -name=PostTakePhotoCompleteCoverage", null);
			}
			else if (TickCounter >= 15)
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
