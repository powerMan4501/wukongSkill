using System;
using System.Collections.Generic;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_PreTraversalAllUI : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		WaitForPreload,
		ExecGM,
		FirstOpenBag,
		GC,
		Memreport,
		OpenBag
	}

	private int TickCounter;

	private InnerState CurrentState;

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public TestState_PreTraversalAllUI(UObject WorldContext)
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
				TransferState(InnerState.ExecGM);
			}
			break;
		}
		case InnerState.ExecGM:
			Description = "执行GM";
			BGUFunctionLibraryManaged.RunScriptGM("AllLegacy", WorldContext);
			BGUFunctionLibraryManaged.RunScriptGM("AllCard 1 IgnoreGmNotify", WorldContext);
			BGUFunctionLibraryManaged.RunScriptGM("UnlockMeditation IgnoreGmNotify", WorldContext);
			BGUFunctionLibraryManaged.RunScriptGM("AllEcho IgnoreGmNotify", WorldContext);
			BGUFunctionLibraryManaged.RunScriptGM("AllEquip IgnoreGmNotify", WorldContext);
			BGUFunctionLibraryManaged.RunScriptGM("AllHulu IgnoreGmNotify", WorldContext);
			BGUFunctionLibraryManaged.RunScriptGM("AllWeapon IgnoreGmNotify", WorldContext);
			BGUFunctionLibraryManaged.RunScriptGM("AddItem 1997 IgnoreGmNotify", WorldContext);
			BGUFunctionLibraryManaged.RunScriptGM("AllSoulSkill IgnoreGmNotify", WorldContext);
			BGUFunctionLibraryManaged.RunScriptGM("AllItem IgnoreGmNotify", WorldContext);
			BGUFunctionLibraryManaged.RunScriptGM("AllAttrItem IgnoreGmNotify", WorldContext);
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "UISetting.PlayerGuide 0", null);
			TransferState(InnerState.FirstOpenBag);
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.FirstOpenBag:
			if (TickCounter == 5)
			{
				Description = "第一次打开包裹";
				AutoTestHelperLib.OpenBag(WorldContext, IsOpen: true);
			}
			else if (TickCounter == 10)
			{
				Description = "第一次关闭包裹";
				AutoTestHelperLib.OpenBag(WorldContext, IsOpen: false);
				TransferState(InnerState.GC);
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
				TransferState(InnerState.OpenBag);
				return AutoTestNodeLib.NodeState.Running;
			}
			if (TickCounter == 5)
			{
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "memreport -full -name=PreTraversalAllUI", null);
			}
			break;
		case InnerState.OpenBag:
			if (TickCounter > 10)
			{
				Description = "打开包裹完成";
				return AutoTestNodeLib.NodeState.Succeeded;
			}
			if (TickCounter == 5)
			{
				Description = "打开包裹";
				AutoTestHelperLib.OpenBag(WorldContext, IsOpen: true);
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
