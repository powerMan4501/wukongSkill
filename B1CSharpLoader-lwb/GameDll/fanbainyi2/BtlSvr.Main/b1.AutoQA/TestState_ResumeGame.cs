using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using CommB1;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_ResumeGame : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		ResumeGame,
		WaitForResumeGame,
		VerifyResumeState
	}

	private InnerState CurrentState;

	private bool bLoadMapCompleted;

	private int TickCounter;

	public TestState_ResumeGame(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
		CurrentState = InnerState.ResumeGame;
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
		case InnerState.ResumeGame:
			if (BGW_GameLifeTimeMgr.Get(WorldContext).IsInFSMState(SGI_Global.MainMenu) || BGW_GameLifeTimeMgr.Get(WorldContext).IsInFSMState(SGI_Global.SubG_GI_Loading_BackToMainMenu) || BGW_GameLifeTimeMgr.Get(WorldContext).IsInFSMState(SGI_Global.SubG_GI_Loading_PreEnterMainMenu))
			{
				BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(WorldContext);
				bGW_EventCollection2.Evt_PostLoadMapWithWorld = (Del_Void)Delegate.Combine(bGW_EventCollection2.Evt_PostLoadMapWithWorld, new Del_Void(OnPostLoadMapWithWorld));
				ArchiveSummaryData latestArchive = BGW_GameArchiveMgr.Get(WorldContext).GetLatestArchive();
				if (latestArchive != null)
				{
					BGW_EventCollection.Get(WorldContext).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.LoadArchive, new FSMInputData_GI_Global_SubG_GI_Loading_TravelLevel
					{
						ArchiveId = latestArchive.ArchiveId
					});
				}
				Description = "发起了一次继续游戏Event，FSMInputData_GI_Global_SubG_GI_Loading_TravelLevel";
				TransferState(InnerState.WaitForResumeGame);
			}
			else
			{
				Description = "等待MainMenu的FSM完成初始化";
			}
			break;
		case InnerState.WaitForResumeGame:
			if (bLoadMapCompleted)
			{
				BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(WorldContext);
				bGW_EventCollection.Evt_PostLoadMapWithWorld = (Del_Void)Delegate.Remove(bGW_EventCollection.Evt_PostLoadMapWithWorld, new Del_Void(OnPostLoadMapWithWorld));
				Description = "过图成功";
				return AutoTestNodeLib.NodeState.Succeeded;
			}
			Description = "等待过图中";
			break;
		default:
			Description = "进入了异常测试状态，测试脚本有逻辑问题!";
			return AutoTestNodeLib.NodeState.Failed;
		}
		TickCounter++;
		return AutoTestNodeLib.NodeState.Running;
	}
}
