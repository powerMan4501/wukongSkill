using System;
using System.Collections.Generic;
using b1.BGW;
using CommB1;
using CsB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_NormalSkill_CompleteCoverage : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		WaitForPreload,
		ExecGM,
		Init,
		Memreport1,
		GetNormalSkill,
		ExecSkill,
		GetNormalSkill_FaBao,
		ExecSkill_FaBao,
		End,
		Memreport2
	}

	private readonly int WatchTime;

	private bool IsDebug;

	private int TickCounter;

	private readonly List<int> SpellIDList = new List<int>();

	private readonly List<int> WaitTimeList = new List<int>();

	private readonly List<int> KeyList = new List<int>();

	private readonly List<int> FaBaoIDList = new List<int> { 19001, 19002, 19004, 19005 };

	private readonly List<int> FaBaoWaitTimeList = new List<int> { 300, 300, 300, 300 };

	private int CurrentIndex = -1;

	private int CurrentIndex_FB = -1;

	private InnerState CurrentState;

	private void AddSpellInfo(int ID, int WaitTime, int Key)
	{
		SpellIDList.Add(ID);
		WaitTimeList.Add(WaitTime);
		KeyList.Add(Key);
	}

	private void SetSpell(int SpellID)
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext);
		if (firstLocalPlayerController.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("[TestState_NormalSkill_CompleteCoverage] CurPC.IsNullOrDestroyed!");
			return;
		}
		BTF_EventCollectionCS bTF_EventCollectionCS = BTF_EventCollectionCS.Get(firstLocalPlayerController.PlayerState);
		if (bTF_EventCollectionCS == null)
		{
			BGW_LogUtil.LogError("[TestState_NormalSkill_CompleteCoverage] BTFEventCollection == null!");
			return;
		}
		CSMsgActorSetSpellReq actorSetSpell = new CSMsgActorSetSpellReq
		{
			SpellId = SpellID
		};
		bTF_EventCollectionCS.Evt_ActorSetSpellReq(actorSetSpell, delegate
		{
		});
	}

	private void SetFaBao(int EquipID)
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext);
		if (firstLocalPlayerController.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("[TestState_NormalSkill_CompleteCoverage] CurPC.IsNullOrDestroyed!");
			return;
		}
		BTF_EventCollectionCS bTF_EventCollectionCS = BTF_EventCollectionCS.Get(firstLocalPlayerController.PlayerState);
		if (bTF_EventCollectionCS == null)
		{
			BGW_LogUtil.LogError("[TestState_NormalSkill_CompleteCoverage] BTFEventCollection == null!");
			return;
		}
		ulong num = 0uL;
		foreach (ReadOnlyRoleEquip equip in BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(firstLocalPlayerController).RoleData.RoleCs.Bag.EquipList)
		{
			if (equip.EquipId == EquipID)
			{
				num = equip.Uid;
				break;
			}
		}
		if (num != 0)
		{
			CSMsgActorWearEquipReq actorWearEquip = new CSMsgActorWearEquipReq
			{
				EquipUid = num
			};
			bTF_EventCollectionCS.Evt_ActorWearEquipReq(actorWearEquip, delegate
			{
			});
		}
	}

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public TestState_NormalSkill_CompleteCoverage(UObject WorldContext, int InWatchTime = 5, bool InIsDebug = false)
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
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "UISetting.PlayerGuide 0", null);
			BGUFunctionLibraryManaged.RunScriptGM("AllSpell IgnoreGmNotify", WorldContext);
			AddSpellInfo(5101, 240, 1);
			AddSpellInfo(5102, 240, 1);
			AddSpellInfo(5103, 400, 1);
			AddSpellInfo(5201, 140, 2);
			AddSpellInfo(5202, 120, 2);
			AddSpellInfo(5301, 360, 3);
			foreach (int faBaoID in FaBaoIDList)
			{
				BGUFunctionLibraryManaged.RunScriptGM($"AddItem {faBaoID} IgnoreGmNotify", WorldContext);
			}
			TransferState(InnerState.Init);
			break;
		case InnerState.Init:
			if (TickCounter == 1)
			{
				SetSpell(SpellIDList[0]);
			}
			else if (TickCounter == 3)
			{
				SetSpell(SpellIDList[3]);
			}
			else if (TickCounter == 5)
			{
				SetSpell(SpellIDList[5]);
			}
			else if (TickCounter == 7)
			{
				SetFaBao(FaBaoIDList[0]);
			}
			else if (TickCounter > 10)
			{
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.fullMP", null);
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.CancelCD", null);
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.FullFaBaoEnergy", null);
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
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "memreport -full -name=PreNormalSkillCompleteCoverage", null);
			}
			else if (TickCounter >= 15)
			{
				TransferState(InnerState.GetNormalSkill);
			}
			break;
		case InnerState.GetNormalSkill:
			if (TickCounter == 2)
			{
				CurrentIndex++;
				if (CurrentIndex >= SpellIDList.Count)
				{
					TransferState(InnerState.GetNormalSkill_FaBao);
					return AutoTestNodeLib.NodeState.Running;
				}
				SetSpell(SpellIDList[CurrentIndex]);
			}
			else if (TickCounter > 5)
			{
				TransferState(InnerState.ExecSkill);
			}
			break;
		case InnerState.ExecSkill:
			if (TickCounter == 1)
			{
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.fullMP", null);
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.CancelCD", null);
			}
			if (TickCounter == 3)
			{
				if (KeyList[CurrentIndex] == 1)
				{
					QASimulateWindowsOperations.KeyPress(QASimulateWindowsOperations.KeyCode.KEY_1);
				}
				else if (KeyList[CurrentIndex] == 2)
				{
					QASimulateWindowsOperations.KeyPress(QASimulateWindowsOperations.KeyCode.KEY_2);
				}
				else if (KeyList[CurrentIndex] == 3)
				{
					QASimulateWindowsOperations.KeyPress(QASimulateWindowsOperations.KeyCode.KEY_3);
				}
			}
			else if (TickCounter > WaitTimeList[CurrentIndex])
			{
				TransferState(InnerState.GetNormalSkill);
			}
			break;
		case InnerState.GetNormalSkill_FaBao:
			if (TickCounter == 2)
			{
				CurrentIndex_FB++;
				if (CurrentIndex_FB >= FaBaoIDList.Count)
				{
					TransferState(InnerState.End);
					return AutoTestNodeLib.NodeState.Running;
				}
				SetFaBao(FaBaoIDList[CurrentIndex_FB]);
			}
			else if (TickCounter > 5)
			{
				TransferState(InnerState.ExecSkill_FaBao);
			}
			break;
		case InnerState.ExecSkill_FaBao:
			if (TickCounter == 1)
			{
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.FullFaBaoEnergy", null);
			}
			if (TickCounter == 3)
			{
				QASimulateWindowsOperations.KeyPress(QASimulateWindowsOperations.KeyCode.KEY_T);
			}
			else if (TickCounter > FaBaoWaitTimeList[CurrentIndex_FB])
			{
				TransferState(InnerState.GetNormalSkill_FaBao);
			}
			break;
		case InnerState.End:
			if (TickCounter == 1)
			{
				SetSpell(SpellIDList[0]);
			}
			else if (TickCounter == 3)
			{
				SetSpell(SpellIDList[3]);
			}
			else if (TickCounter == 5)
			{
				SetSpell(SpellIDList[5]);
			}
			else if (TickCounter == 7)
			{
				SetFaBao(FaBaoIDList[0]);
			}
			else if (TickCounter > 10)
			{
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.fullMP", null);
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.CancelCD", null);
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.FullFaBaoEnergy", null);
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
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "memreport -full -name=PostNormalSkillCompleteCoverage", null);
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
