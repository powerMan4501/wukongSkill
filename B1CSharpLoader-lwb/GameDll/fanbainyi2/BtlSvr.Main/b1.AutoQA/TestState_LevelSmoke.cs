using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using b1.Plugins.AsyncLoadingScreen;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_LevelSmoke : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		WaitFor_PlayerBeginPlay,
		WaitFor_LoadingScreenFadeAway,
		Add_Buff,
		Judge_StartPoint,
		TeleportTo_Destination,
		WaitFor_Teleport
	}

	private InnerState CurrentState;

	private int TickCounter;

	private bool TeleportFinish;

	private readonly int MapID;

	private readonly bool IsUseTeleportToLevelPosition;

	public TestState_LevelSmoke(UObject WorldContext, int MapID, bool IsUseTeleportToLevelPosition = false)
	{
		base.WorldContext = WorldContext;
		this.MapID = MapID;
		this.IsUseTeleportToLevelPosition = IsUseTeleportToLevelPosition;
	}

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	private void OnDreamTeleportFinished()
	{
		TeleportFinish = true;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		switch (CurrentState)
		{
		case InnerState.WaitFor_PlayerBeginPlay:
			if (BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_UnitDebugData>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn()) != null)
			{
				Description = "主角已就绪";
				if (BGWGameInstanceCS.Get(WorldContext).GetCurLoadingScreenState() == EGSLoadingScreenState.Idle)
				{
					TransferState(InnerState.Add_Buff);
					break;
				}
				BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(WorldContext);
				bGW_EventCollection2.Evt_LoadingBeginFadeAway = (Del_Void)Delegate.Combine(bGW_EventCollection2.Evt_LoadingBeginFadeAway, new Del_Void(OnDreamTeleportFinished));
				TransferState(InnerState.WaitFor_LoadingScreenFadeAway);
			}
			else
			{
				Description = "等待主角初始化完成中";
			}
			break;
		case InnerState.WaitFor_LoadingScreenFadeAway:
			if (TeleportFinish)
			{
				Description = "LoadingScreen已消失";
				BGW_EventCollection bGW_EventCollection4 = BGW_EventCollection.Get(WorldContext);
				bGW_EventCollection4.Evt_LoadingBeginFadeAway = (Del_Void)Delegate.Remove(bGW_EventCollection4.Evt_LoadingBeginFadeAway, new Del_Void(OnDreamTeleportFinished));
				TeleportFinish = false;
				TransferState(InnerState.Add_Buff);
			}
			else
			{
				Description = "等待LoadingScreen消失中";
			}
			break;
		case InnerState.Add_Buff:
		{
			Description = "输入各种指令";
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "EnableAllScreenMessages", null);
			APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn();
			BGUFunctionLibraryCS.BGUAddBuff(controlledPawn, controlledPawn, 212, EBuffSourceType.AutoTest);
			StateStack.Push(new AutoTestNodeLib.TestState_Wait(WorldContext, 10));
			TransferState(InnerState.Judge_StartPoint);
			break;
		}
		case InnerState.Judge_StartPoint:
			if (AutoTestHelperLib.IsPlayingCameraMovie(WorldContext))
			{
				BGS_EventCollectionCS.Get(WorldContext).Evt_SkipCurrentMovie.Invoke();
				Description = "使用GM跳过Sequence ";
				StateStack.Push(new AutoTestNodeLib.TestState_Wait(WorldContext, 5));
				break;
			}
			if (BGUFuncLibMap.GetCurLevelId(WorldContext) == MapID)
			{
				Description = "已经在指定的地图了：" + BGUFuncLibMap.GetMapName(WorldContext);
				return AutoTestNodeLib.NodeState.Succeeded;
			}
			Description = "准备传送到指定地图：" + MapID;
			TransferState(InnerState.TeleportTo_Destination);
			break;
		case InnerState.TeleportTo_Destination:
		{
			int num = 0;
			num = ((MapID == 103) ? 301 : ((MapID != 11) ? (MapID * 100 + 1) : 1009));
			Description = "使用GM指令直接传到出生点" + num;
			BGW_EventCollection bGW_EventCollection3 = BGW_EventCollection.Get(WorldContext);
			bGW_EventCollection3.Evt_LoadingBeginFadeAway = (Del_Void)Delegate.Combine(bGW_EventCollection3.Evt_LoadingBeginFadeAway, new Del_Void(OnDreamTeleportFinished));
			if (IsUseTeleportToLevelPosition)
			{
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.TeleportToLevelPosition " + MapID, null);
			}
			else
			{
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.TeleToRebirthPoint " + num, null);
			}
			TransferState(InnerState.WaitFor_Teleport);
			break;
		}
		case InnerState.WaitFor_Teleport:
			if (TeleportFinish)
			{
				Description = "传送已完成";
				BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(WorldContext);
				bGW_EventCollection.Evt_LoadingBeginFadeAway = (Del_Void)Delegate.Remove(bGW_EventCollection.Evt_LoadingBeginFadeAway, new Del_Void(OnDreamTeleportFinished));
				StateStack.Push(new AutoTestNodeLib.TestState_Wait(WorldContext, 5));
				TransferState(InnerState.WaitFor_PlayerBeginPlay);
			}
			else
			{
				Description = "等待传送中";
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
