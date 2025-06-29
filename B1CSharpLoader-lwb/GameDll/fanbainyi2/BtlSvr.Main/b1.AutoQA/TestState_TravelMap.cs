using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_TravelMap : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		Begin,
		TravelMap,
		Finish
	}

	private InnerState CurrentState;

	private int TickCounter;

	private string TargetMapName;

	private bool bLoadMapCompleted;

	public TestState_TravelMap(UObject WorldContext, string TargetMapName)
	{
		base.WorldContext = WorldContext;
		this.TargetMapName = TargetMapName;
	}

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		Description = "执行中";
		switch (CurrentState)
		{
		case InnerState.Begin:
		{
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(WorldContext);
			bGW_EventCollection.Evt_PostLoadMapWithWorld = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_PostLoadMapWithWorld, new Del_Void(OnPostLoadMapWithWorld));
			if (GetTargetLevelId(out var TargetLevelId))
			{
				Description = "触发跳转地图(FSMEvent)";
				BGW_EventCollection.Get(WorldContext).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.StartNewGame, new FSMInputData_GI_Global_SubG_GI_Loading_TravelLevel
				{
					TargetId = TargetLevelId
				});
			}
			else if (TargetMapName.Equals("StartUp_V2_P", StringComparison.OrdinalIgnoreCase))
			{
				Description = "触发返回标题界面";
				BGW_EventCollection.Get(WorldContext).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.BackToMainMenu);
			}
			else
			{
				Description = "触发跳转地图(Travel)";
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "travel " + TargetMapName, null);
			}
			TransferState(InnerState.TravelMap);
			break;
		}
		case InnerState.TravelMap:
			if (bLoadMapCompleted)
			{
				Description = "自动进图成功";
				BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(WorldContext);
				bGW_EventCollection2.Evt_PostLoadMapWithWorld = (Del_Void)Delegate.Remove(bGW_EventCollection2.Evt_PostLoadMapWithWorld, new Del_Void(OnPostLoadMapWithWorld));
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "EnableAllScreenMessages", null);
				TransferState(InnerState.Finish);
			}
			else
			{
				Description = "仍在进图中";
			}
			break;
		case InnerState.Finish:
			if (TickCounter >= 5)
			{
				Description = "自动进图完成";
				return AutoTestNodeLib.NodeState.Succeeded;
			}
			break;
		default:
			Description = "进入错误状态";
			return AutoTestNodeLib.NodeState.Failed;
		}
		TickCounter++;
		return AutoTestNodeLib.NodeState.Running;
	}

	public bool GetTargetLevelId(out int TargetLevelId)
	{
		TargetLevelId = -1;
		switch (TargetMapName)
		{
		case "HFS01_PersistentLevel":
			TargetLevelId = 10;
			break;
		case "HFM02_PersistentLevel":
			TargetLevelId = 20;
			break;
		case "HFM_DuJiaoXian_Persist":
			TargetLevelId = 2;
			break;
		case "HYS_PersistentLevel":
			TargetLevelId = 50;
			break;
		case "HFS_WoodDragon_01":
			TargetLevelId = 12;
			break;
		case "PSD_PersistentLevel":
			TargetLevelId = 40;
			break;
		case "DebugRoom_Persistent":
			TargetLevelId = 103;
			break;
		default:
			return false;
		}
		return true;
	}

	private void OnPostLoadMapWithWorld()
	{
		bLoadMapCompleted = true;
	}
}
