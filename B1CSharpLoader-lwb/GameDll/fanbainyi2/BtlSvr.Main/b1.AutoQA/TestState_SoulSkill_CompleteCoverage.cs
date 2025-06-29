using System;
using System.Collections.Generic;
using b1.BGW;
using BtlB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.AutoQA;

public class TestState_SoulSkill_CompleteCoverage : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		WaitForPreload,
		ExecGM,
		Init,
		Memreport1,
		GetSoulSkill,
		ExecSkill,
		End,
		Memreport2
	}

	private readonly int WatchTime;

	private bool IsDebug;

	private int TickCounter;

	private List<string> CmdList = new List<string>();

	private int CurrentIndex = -1;

	private InnerState CurrentState;

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public TestState_SoulSkill_CompleteCoverage(UObject WorldContext, int InWatchTime = 5, bool InIsDebug = false)
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
				TransferState(InnerState.ExecGM);
			}
			break;
		}
		case InnerState.ExecGM:
		{
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "UISetting.PlayerGuide 0", null);
			BGUFunctionLibraryManaged.RunScriptGM("AddItem 1997 IgnoreGmNotify", WorldContext);
			BGUFunctionLibraryManaged.RunScriptGM("AddItem 4025 IgnoreGmNotify", WorldContext);
			Dictionary<int, FUStSoulSkillMimicryDesc>.ValueCollection values = GameDBRuntime.GetTBFUStSoulSkillMimicryDesc().Values;
			List<int> list = new List<int>();
			foreach (FUStSoulSkillMimicryDesc item in values)
			{
				if (!list.Contains(item.SoulSkillID))
				{
					list.Add(item.SoulSkillID);
				}
			}
			foreach (ItemDesc item2 in GameDBRuntime.GetTBItemDesc().List)
			{
				if (item2.ItemType == ItemType.SoulSkill && !list.Contains(item2.Id))
				{
					CmdList.Add($"SetSoulSkill {item2.Id}");
				}
			}
			TransferState(InnerState.Init);
			break;
		}
		case InnerState.Init:
			if (TickCounter == 1)
			{
				QASimulateWindowsOperations.SetCursorPosition(100, 100);
				QASimulateWindowsOperations.MouseEvent(QASimulateWindowsOperations.MouseEventFlags.LeftDown);
				QASimulateWindowsOperations.MouseEvent(QASimulateWindowsOperations.MouseEventFlags.LeftUp);
				UWidgetLibrary.SetFocusToGameViewport();
			}
			if (TickCounter == 5)
			{
				try
				{
					BGUFunctionLibraryManaged.RunScriptGM(CmdList[0], WorldContext);
				}
				catch (Exception arg)
				{
					BGW_LogUtil.LogError($"EnterTrans Error: {arg}");
				}
			}
			else if (TickCounter == 8)
			{
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.FullVigorEnergy", null);
			}
			else if (TickCounter == 15)
			{
				QASimulateWindowsOperations.KeyPress(QASimulateWindowsOperations.KeyCode.KEY_F);
			}
			else if (TickCounter > 30)
			{
				TransferState(InnerState.Memreport1);
			}
			break;
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
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "memreport -full -name=PreSoulSkillCompleteCoverage", null);
			}
			else if (TickCounter >= 15)
			{
				TransferState(InnerState.GetSoulSkill);
			}
			break;
		case InnerState.GetSoulSkill:
			if (TickCounter == 2)
			{
				CurrentIndex++;
				if (CurrentIndex >= CmdList.Count)
				{
					TransferState(InnerState.End);
					return AutoTestNodeLib.NodeState.Running;
				}
				try
				{
					BGUFunctionLibraryManaged.RunScriptGM(CmdList[CurrentIndex], WorldContext);
				}
				catch (Exception arg2)
				{
					BGW_LogUtil.LogError($"EnterTrans Error: {arg2}");
					TransferState(InnerState.GetSoulSkill);
					return AutoTestNodeLib.NodeState.Running;
				}
			}
			else if (TickCounter > 5)
			{
				TransferState(InnerState.ExecSkill);
			}
			break;
		case InnerState.ExecSkill:
			if (TickCounter == 1)
			{
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.FullVigorEnergy", null);
			}
			if (TickCounter == 3)
			{
				QASimulateWindowsOperations.KeyPress(QASimulateWindowsOperations.KeyCode.KEY_F);
			}
			else if (TickCounter > 30)
			{
				TransferState(InnerState.GetSoulSkill);
			}
			break;
		case InnerState.End:
			if (TickCounter == 2)
			{
				try
				{
					BGUFunctionLibraryManaged.RunScriptGM(CmdList[0], WorldContext);
				}
				catch (Exception arg3)
				{
					BGW_LogUtil.LogError($"EnterTrans Error: {arg3}");
				}
			}
			else if (TickCounter == 5)
			{
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.FullVigorEnergy", null);
			}
			else if (TickCounter == 7)
			{
				QASimulateWindowsOperations.KeyPress(QASimulateWindowsOperations.KeyCode.KEY_F);
			}
			else if (TickCounter > 30)
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
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "memreport -full -name=PostSoulSkillCompleteCoverage", null);
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
