using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_QAEnterMap : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		GetTargetLevelID,
		JudgeNeedEnterMap,
		EnterMapAction,
		WaitForEnterComplete,
		JudgeNewMapID
	}

	private int LevelID;

	private int WaitLoopCounter;

	private int TickCounter;

	private bool FirstAppear = true;

	private InnerState CurrentState;

	private bool bLoadMapCompleted;

	public TestState_QAEnterMap(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	public TestState_QAEnterMap(UObject WorldContext, int LevelID)
	{
		base.WorldContext = WorldContext;
		this.LevelID = LevelID;
	}

	private void OnPostLoadMapWithWorld()
	{
		bLoadMapCompleted = true;
	}

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		switch (CurrentState)
		{
		case InnerState.GetTargetLevelID:
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "EnableAllScreenMessages", null);
			if (LevelID == 0)
			{
				if (!BIS_AutoTestManagerV2.Get(WorldContext).LoadATPConfig())
				{
					Description = "无法获取目标关卡ID";
					return AutoTestNodeLib.NodeState.Failed;
				}
				LevelID = BGUFuncLibMap.GetLevelIdByName(BIS_AutoTestManagerV2.Get(WorldContext).GetAtpConfigValues.TargetMap);
			}
			TransferState(InnerState.JudgeNeedEnterMap);
			Description = "目标关卡ID为 " + LevelID;
			break;
		case InnerState.JudgeNeedEnterMap:
		{
			int currentLevelID = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_LevelData, BIC_LevelData>(WorldContext).CurrentLevelID;
			if (currentLevelID == 1)
			{
				Description = "处于选关界面，进行选关";
				TransferState(InnerState.EnterMapAction);
				break;
			}
			if (currentLevelID == LevelID)
			{
				Description = "已经在目标关卡了！";
				return AutoTestNodeLib.NodeState.Succeeded;
			}
			if (WaitLoopCounter < 6)
			{
				Description = "不在选关界面，但也不在目标关卡，等5s";
				StateStack.Push(new AutoTestNodeLib.TestState_Wait(WorldContext, 10));
				WaitLoopCounter++;
				break;
			}
			Description = "不在选关界面，但也不在目标关卡，无法继续执行测试任务！";
			return AutoTestNodeLib.NodeState.Failed;
		}
		case InnerState.EnterMapAction:
			if (BGW_GameLifeTimeMgr.Get(WorldContext).IsInFSMState(SGI_Global.MainMenu))
			{
				BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(WorldContext);
				bGW_EventCollection.Evt_PostLoadMapWithWorld = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_PostLoadMapWithWorld, new Del_Void(OnPostLoadMapWithWorld));
				BGW_EventCollection.Get(WorldContext).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.StartNewGame, new FSMInputData_GI_Global_SubG_GI_Loading_TravelLevel
				{
					TargetId = LevelID
				});
				Description = "发起了一次进图Event，其方法为FSMInputData_GI_Global_SubG_GI_Loading_TravelLevel";
				TransferState(InnerState.WaitForEnterComplete);
			}
			else
			{
				Description = "等待MainMenu的FSM完成初始化";
			}
			break;
		case InnerState.WaitForEnterComplete:
			if (bLoadMapCompleted)
			{
				BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(WorldContext);
				bGW_EventCollection2.Evt_PostLoadMapWithWorld = (Del_Void)Delegate.Remove(bGW_EventCollection2.Evt_PostLoadMapWithWorld, new Del_Void(OnPostLoadMapWithWorld));
				Description = "过图成功";
				TransferState(InnerState.JudgeNewMapID);
			}
			else
			{
				Description = "等待过图中";
			}
			break;
		case InnerState.JudgeNewMapID:
		{
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "EnableAllScreenMessages", null);
			int currentLevelID = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_LevelData, BIC_LevelData>(WorldContext).CurrentLevelID;
			if (currentLevelID == LevelID)
			{
				Description = "到达了目标关卡";
				return AutoTestNodeLib.NodeState.Succeeded;
			}
			Description = "没有到达目标关卡，当前关卡ID为" + currentLevelID;
			return AutoTestNodeLib.NodeState.Failed;
		}
		default:
			Description = "进入了异常测试状态，测试脚本有逻辑问题!";
			return AutoTestNodeLib.NodeState.Failed;
		}
		TickCounter++;
		return AutoTestNodeLib.NodeState.Running;
	}
}
