using System;
using System.Collections.Generic;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_TansSkill_CompleteCoverage : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		WaitForPreload,
		Init_EnterTrans,
		Init_ExitTrans,
		Memreport1,
		EnterTrans,
		LeaveTrans,
		End_EnterTrans,
		End_ExitTrans,
		End,
		Memreport2
	}

	private readonly int WatchTime;

	private bool IsDebug;

	private int TickCounter;

	private List<string> CmdList = new List<string> { "GMTransBySpell IgnoreGmNotify 5001", "GMTransBySpell IgnoreGmNotify 5006", "GMTransBySpell IgnoreGmNotify 5004", "GMTransBySpell IgnoreGmNotify 5019", "GMTransBySpell IgnoreGmNotify 5008", "GMTransBySpell IgnoreGmNotify 5018", "GMTransBySpell IgnoreGmNotify 5014", "GMTransBySpell IgnoreGmNotify 5024", "GMTransBySpell IgnoreGmNotify 5017" };

	private int CurrentIndex = -1;

	private InnerState CurrentState;

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public TestState_TansSkill_CompleteCoverage(UObject WorldContext, int InWatchTime = 5, bool InIsDebug = false)
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
				TransferState(InnerState.Init_EnterTrans);
			}
			break;
		}
		case InnerState.Init_EnterTrans:
			if (TickCounter == 2)
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
			else if (TickCounter > 20)
			{
				TransferState(InnerState.Init_ExitTrans);
			}
			break;
		case InnerState.Init_ExitTrans:
			if (TickCounter == 2)
			{
				QASimulateWindowsOperations.KeyPress(QASimulateWindowsOperations.KeyCode.KEY_4);
			}
			else if (TickCounter > 20)
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
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "memreport -full -name=PreTansSkillCompleteCoverage", null);
			}
			else if (TickCounter >= 15)
			{
				TransferState(InnerState.EnterTrans);
			}
			break;
		case InnerState.EnterTrans:
			if (TickCounter == 2)
			{
				CurrentIndex++;
				if (CurrentIndex >= CmdList.Count)
				{
					TransferState(InnerState.End_EnterTrans);
					return AutoTestNodeLib.NodeState.Running;
				}
				try
				{
					BGUFunctionLibraryManaged.RunScriptGM(CmdList[CurrentIndex], WorldContext);
				}
				catch (Exception arg3)
				{
					BGW_LogUtil.LogError($"EnterTrans Error: {arg3}");
					TransferState(InnerState.EnterTrans);
					return AutoTestNodeLib.NodeState.Running;
				}
			}
			else if (TickCounter > 20)
			{
				TransferState(InnerState.LeaveTrans);
			}
			break;
		case InnerState.LeaveTrans:
			if (TickCounter == 2)
			{
				QASimulateWindowsOperations.KeyPress(QASimulateWindowsOperations.KeyCode.KEY_4);
			}
			else if (TickCounter > 20)
			{
				TransferState(InnerState.EnterTrans);
			}
			break;
		case InnerState.End_EnterTrans:
			if (TickCounter == 2)
			{
				try
				{
					BGUFunctionLibraryManaged.RunScriptGM(CmdList[0], WorldContext);
				}
				catch (Exception arg2)
				{
					BGW_LogUtil.LogError($"EnterTrans Error: {arg2}");
				}
			}
			else if (TickCounter > 20)
			{
				TransferState(InnerState.End_ExitTrans);
			}
			break;
		case InnerState.End_ExitTrans:
			if (TickCounter == 2)
			{
				QASimulateWindowsOperations.KeyPress(QASimulateWindowsOperations.KeyCode.KEY_4);
			}
			else if (TickCounter > 20)
			{
				TransferState(InnerState.End);
			}
			break;
		case InnerState.End:
			TransferState(InnerState.Memreport2);
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
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "memreport -full -name=PostTansSkillCompleteCoverage", null);
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
