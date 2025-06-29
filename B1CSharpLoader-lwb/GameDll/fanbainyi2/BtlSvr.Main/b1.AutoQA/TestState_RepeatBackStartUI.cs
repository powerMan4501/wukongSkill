using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.AutoQA;

public class TestState_RepeatBackStartUI : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		Game,
		EquipUI,
		SettingUI,
		ExitPanel,
		Confirm,
		LoadingToStartUI,
		StartUI,
		LoadingToGame
	}

	private InnerState CurrentState;

	private int TickCounter;

	private int LoopNum;

	private int CurLoopNum;

	private bool IsExecAutoSave;

	private bool IsFinishLoad;

	private int LoadFinishWaitTime;

	public TestState_RepeatBackStartUI(UObject WorldContext, int LoopNum)
	{
		base.WorldContext = WorldContext;
		this.LoopNum = LoopNum;
		CurLoopNum = 0;
	}

	private void TransferState(InnerState NextState)
	{
		if (NextState == InnerState.Game)
		{
			CurLoopNum++;
		}
		CurrentState = NextState;
		TickCounter = 0;
	}

	private void SetPlayerInfoEnabled(bool InIsPlayerInfoEnabled)
	{
		if (!IsFinishLoad && InIsPlayerInfoEnabled)
		{
			LoadFinishWaitTime = 0;
		}
		if (InIsPlayerInfoEnabled)
		{
			IsFinishLoad = true;
		}
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		if (CurLoopNum >= LoopNum)
		{
			BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(WorldContext);
			if (bGW_UIEventCollection != null)
			{
				bGW_UIEventCollection.Evt_UI_SetPlayerInfoEnabled = (BGW_UIEventCollection.Del_UI_SetEnabled)Delegate.Remove(bGW_UIEventCollection.Evt_UI_SetPlayerInfoEnabled, new BGW_UIEventCollection.Del_UI_SetEnabled(SetPlayerInfoEnabled));
			}
			Description = "重复返回开始界面 测试完成";
			return AutoTestNodeLib.NodeState.Succeeded;
		}
		TickCounter++;
		switch (CurrentState)
		{
		case InnerState.Game:
			if (!IsExecAutoSave)
			{
				IsExecAutoSave = true;
				BGW_UIEventCollection bGW_UIEventCollection3 = BGW_UIEventCollection.Get(WorldContext);
				if (bGW_UIEventCollection3 != null)
				{
					bGW_UIEventCollection3.Evt_UI_SetPlayerInfoEnabled = (BGW_UIEventCollection.Del_UI_SetEnabled)Delegate.Combine(bGW_UIEventCollection3.Evt_UI_SetPlayerInfoEnabled, new BGW_UIEventCollection.Del_UI_SetEnabled(SetPlayerInfoEnabled));
				}
			}
			Description = "打开装备界面";
			AutoTestHelperLib.OpenBag(WorldContext, IsOpen: true);
			TransferState(InnerState.EquipUI);
			break;
		case InnerState.EquipUI:
		{
			if (TickCounter > 10)
			{
				Description = "打开装备界面失败，重新执行";
				TransferState(InnerState.Game);
				break;
			}
			UGSE_UMGFuncLib.QAGetWidgetWithText(WorldContext, out var FoundWidgets3, "设置");
			if (FoundWidgets3.Count <= 0)
			{
				Description = "等待进入装备界面";
				break;
			}
			foreach (UTextBlock item in FoundWidgets3)
			{
				AutoTestHelperLib.ClickButton(item);
			}
			Description = "点击进入设置界面";
			TransferState(InnerState.SettingUI);
			break;
		}
		case InnerState.SettingUI:
		{
			if (TickCounter > 10)
			{
				Description = "打开设置界面失败，重新执行";
				TransferState(InnerState.EquipUI);
				break;
			}
			UGSE_UMGFuncLib.QAGetWidgetWithText(WorldContext, out var FoundWidgets2, "退出游戏");
			if (FoundWidgets2.Count <= 0)
			{
				Description = "等待进入设置界面";
				break;
			}
			foreach (UTextBlock item2 in FoundWidgets2)
			{
				AutoTestHelperLib.ClickButton(item2);
			}
			Description = "点击进入退出游戏面板";
			TransferState(InnerState.ExitPanel);
			break;
		}
		case InnerState.ExitPanel:
		{
			if (TickCounter > 10)
			{
				Description = "进入退出游戏面板失败，重新执行";
				TransferState(InnerState.SettingUI);
				break;
			}
			UGSE_UMGFuncLib.QAGetWidgetWithText(WorldContext, out var FoundWidgets6, "返回标题界面");
			if (FoundWidgets6.Count <= 0)
			{
				Description = "等待进入退出游戏面板";
				break;
			}
			foreach (UTextBlock item3 in FoundWidgets6)
			{
				AutoTestHelperLib.ClickButton(item3);
			}
			Description = "点击返回标题界面按钮";
			TransferState(InnerState.Confirm);
			break;
		}
		case InnerState.Confirm:
		{
			if (TickCounter > 10)
			{
				Description = "弹出确认弹框失败，重新执行";
				TransferState(InnerState.ExitPanel);
				break;
			}
			UGSE_UMGFuncLib.QAGetWidgetWithText(WorldContext, out var FoundWidgets5, "确定");
			if (FoundWidgets5.Count <= 0)
			{
				Description = "等待弹出确认弹框";
				break;
			}
			foreach (UTextBlock item4 in FoundWidgets5)
			{
				AutoTestHelperLib.ClickButton(item4);
			}
			Description = "点击确定";
			TransferState(InnerState.LoadingToStartUI);
			break;
		}
		case InnerState.LoadingToStartUI:
		{
			if (TickCounter > 500)
			{
				Description = "进入开始界面失败，重新执行";
				TransferState(InnerState.Confirm);
			}
			UGSE_UMGFuncLib.QAGetWidgetWithText(WorldContext, out var FoundWidgets4, "继续游戏");
			if (FoundWidgets4.Count <= 0)
			{
				Description = "返回开始界面中";
				break;
			}
			Description = "进入开始界面";
			TransferState(InnerState.StartUI);
			break;
		}
		case InnerState.StartUI:
		{
			UGSE_UMGFuncLib.QAGetWidgetWithText(WorldContext, out var FoundWidgets, "继续游戏");
			if (FoundWidgets.Count <= 0)
			{
				Description = "进入开始界面失败，继续等待";
				TransferState(InnerState.LoadingToStartUI);
				break;
			}
			foreach (UTextBlock item5 in FoundWidgets)
			{
				AutoTestHelperLib.ClickButton(item5);
			}
			Description = "点击继续游戏";
			TransferState(InnerState.LoadingToGame);
			IsFinishLoad = false;
			break;
		}
		case InnerState.LoadingToGame:
			if (TickCounter > 500)
			{
				Description = "进入游戏失败，重新执行";
				TransferState(InnerState.StartUI);
			}
			Description = "加载游戏中";
			if (IsFinishLoad)
			{
				LoadFinishWaitTime++;
			}
			if (IsFinishLoad && LoadFinishWaitTime > 5)
			{
				Description = "加载游戏完成！";
				TransferState(InnerState.Game);
			}
			break;
		default:
		{
			BGW_UIEventCollection bGW_UIEventCollection2 = BGW_UIEventCollection.Get(WorldContext);
			if (bGW_UIEventCollection2 != null)
			{
				bGW_UIEventCollection2.Evt_UI_SetPlayerInfoEnabled = (BGW_UIEventCollection.Del_UI_SetEnabled)Delegate.Remove(bGW_UIEventCollection2.Evt_UI_SetPlayerInfoEnabled, new BGW_UIEventCollection.Del_UI_SetEnabled(SetPlayerInfoEnabled));
			}
			Description = "进入了异常测试状态，测试脚本有逻辑问题!";
			return AutoTestNodeLib.NodeState.Failed;
		}
		}
		return AutoTestNodeLib.NodeState.Running;
	}
}
