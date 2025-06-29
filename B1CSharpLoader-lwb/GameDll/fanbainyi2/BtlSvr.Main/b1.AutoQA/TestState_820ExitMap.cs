using System;
using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_820ExitMap : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		Open_Bag,
		Click_Setting,
		Click_LeaveLevel,
		Click_Ok,
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

	public TestState_820ExitMap(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
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
		case InnerState.Open_Bag:
			AutoTestHelperLib.OpenBag(WorldContext, IsOpen: true);
			StateStack.Push(new AutoTestNodeLib.TestState_Wait(WorldContext, 6));
			TransferState(InnerState.Click_Setting);
			Description = "打开背包";
			break;
		case InnerState.Click_Setting:
			AutoTestHelperLib.FindText(WorldContext, "设置", bNeedClick: true);
			StateStack.Push(new AutoTestNodeLib.TestState_Wait(WorldContext, 6));
			TransferState(InnerState.Click_LeaveLevel);
			Description = "打开背包";
			break;
		case InnerState.Click_LeaveLevel:
			AutoTestHelperLib.FindText(WorldContext, "退出当前关卡", bNeedClick: true);
			AutoTestHelperLib.FindText(WorldContext, "退出游戏", bNeedClick: true);
			StateStack.Push(new AutoTestNodeLib.TestState_Wait(WorldContext, 6));
			TransferState(InnerState.Click_Ok);
			Description = "退出当前关卡";
			break;
		case InnerState.Click_Ok:
			AutoTestHelperLib.FindText(WorldContext, "确定", bNeedClick: true);
			StateStack.Push(new AutoTestNodeLib.TestState_Wait(WorldContext, 6));
			TransferState(InnerState.WaitFor_PlayerBeginPlay);
			Description = "确定";
			break;
		case InnerState.WaitFor_PlayerBeginPlay:
		{
			UClass uClass = BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UClass>("WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/820/BI_BtnLevels.BI_BtnLevels_C'", ELoadResourceType.SyncLoadAndCache);
			Description = "等待选关界面出现";
			if (!(uClass == null))
			{
				Description = "已经回到选关界面";
				return AutoTestNodeLib.NodeState.Succeeded;
			}
			break;
		}
		case InnerState.WaitFor_LoadingScreenFadeAway:
			if (TeleportFinish)
			{
				Description = "LoadingScreen已消失";
				BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(WorldContext);
				bGW_EventCollection2.Evt_LoadingBeginFadeAway = (Del_Void)Delegate.Remove(bGW_EventCollection2.Evt_LoadingBeginFadeAway, new Del_Void(OnDreamTeleportFinished));
				TeleportFinish = false;
				return AutoTestNodeLib.NodeState.Succeeded;
			}
			Description = "等待LoadingScreen消失中";
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
			int num = MapID * 100 + 1;
			Description = "使用GM指令直接传到出生点" + num;
			BGW_EventCollection bGW_EventCollection3 = BGW_EventCollection.Get(WorldContext);
			bGW_EventCollection3.Evt_LoadingBeginFadeAway = (Del_Void)Delegate.Combine(bGW_EventCollection3.Evt_LoadingBeginFadeAway, new Del_Void(OnDreamTeleportFinished));
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.TeleToRebirthPoint " + num, null);
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
