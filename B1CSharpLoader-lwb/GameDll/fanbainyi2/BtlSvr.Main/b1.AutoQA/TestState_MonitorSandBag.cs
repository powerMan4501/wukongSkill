using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_MonitorSandBag : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		BindingTrainDummyMgr,
		Running,
		Finished
	}

	private int TickCounter;

	private int WaitCounter = -1;

	private List<int> PlayerRoleDataConfigIDs = new List<int>();

	private int CurrentRoleDataConfigIndex;

	private float DPSCalTime = -1f;

	private string TrainDummyClassPath = "Blueprint'/Game/00Main/Design/Units/HFM/TAMER_hfm_fuzishu.TAMER_hfm_fuzishu'";

	private string TrainDummyConfigPath = "BGWDataAsset_TrainDummyConfig'/Game/00Main/BPLibrary/Debug/TrainDummyMgrDA/TrainDummyMgrConfig.TrainDummyMgrConfig'";

	private string CqgPath = "BED_QuestAsset'/Game/TestMaps/HongbingTest/TrainDummyTest/CQG_TrainDummyTest.CQG_TrainDummyTest'";

	private InnerState CurrentState;

	public TestState_MonitorSandBag(UObject WorldContext, int WaitCounter)
	{
		base.WorldContext = WorldContext;
		this.WaitCounter = WaitCounter;
		string launchValue = UGSE_EngineFuncLib.GetLaunchValue("PlayerRoleDataConfigID");
		string launchValue2 = UGSE_EngineFuncLib.GetLaunchValue("DPSCalTime");
		if (launchValue != "")
		{
			string[] array = launchValue.Split(',');
			for (int i = 0; i < array.Length; i++)
			{
				if (int.TryParse(array[i], out var result))
				{
					PlayerRoleDataConfigIDs.Add(result);
				}
			}
		}
		if (launchValue2 != "")
		{
			DPSCalTime = int.Parse(launchValue2);
		}
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(WorldContext);
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_TrainDummyResultReport = (Del_Void_String)Delegate.Combine(bGW_EventCollection.Evt_TrainDummyResultReport, new Del_Void_String(OnTrainDummyResultReport));
		}
		CurrentState = InnerState.BindingTrainDummyMgr;
	}

	~TestState_MonitorSandBag()
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(WorldContext);
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_TrainDummyResultReport = (Del_Void_String)Delegate.Remove(bGW_EventCollection.Evt_TrainDummyResultReport, new Del_Void_String(OnTrainDummyResultReport));
		}
	}

	private void OnTrainDummyResultReport(string UnitGuid)
	{
		CurrentRoleDataConfigIndex++;
		CurrentState = InnerState.BindingTrainDummyMgr;
	}

	private void TryBindTrainDummyMgr()
	{
		if (CurrentRoleDataConfigIndex >= PlayerRoleDataConfigIDs.Count)
		{
			CurrentState = InnerState.Finished;
		}
		else if (BGUFunctionLibraryCS.SetTrainDummyInfo(WorldContext, TrainDummyClassPath, PlayerRoleDataConfigIDs[CurrentRoleDataConfigIndex], TrainDummyConfigPath, CqgPath, DPSCalTime))
		{
			CurrentState = InnerState.Running;
		}
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		switch (CurrentState)
		{
		case InnerState.BindingTrainDummyMgr:
			Description = "等待绑定打桩器";
			TryBindTrainDummyMgr();
			break;
		case InnerState.Running:
			Description = $"打桩中，当前套装ID: {PlayerRoleDataConfigIDs[CurrentRoleDataConfigIndex]}";
			break;
		case InnerState.Finished:
			Description = "成功";
			return AutoTestNodeLib.NodeState.Succeeded;
		default:
			Description = "进入了异常测试状态，测试脚本有逻辑问题!";
			return AutoTestNodeLib.NodeState.Failed;
		}
		if (TickCounter > WaitCounter)
		{
			Description = "等待超时";
			return AutoTestNodeLib.NodeState.Failed;
		}
		TickCounter++;
		return AutoTestNodeLib.NodeState.Running;
	}
}
