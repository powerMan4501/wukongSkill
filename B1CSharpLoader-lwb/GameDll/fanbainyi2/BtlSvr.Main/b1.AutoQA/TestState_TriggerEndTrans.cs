using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_TriggerEndTrans : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		Check_TransState,
		Trigger_EndTrans,
		ReCheck_TransState
	}

	private InnerState CurrentState;

	private int TickCounter;

	public TestState_TriggerEndTrans(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	private bool CheckIsPlayerInTransState(UObject WorldContext)
	{
		APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn();
		if (controlledPawn != null)
		{
			APlayerState playerState = controlledPawn.PlayerState;
			if (playerState != null)
			{
				IBPC_TransData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_TransData, BPC_TransData>(playerState);
				IBPC_PlayerTagData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerTagData, BPC_PlayerTagData>(playerState);
				if (readOnlyData != null && readOnlyData2.HasTag(EBGPPlayerTag.Transforming))
				{
					return true;
				}
			}
		}
		return false;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		switch (CurrentState)
		{
		case InnerState.Check_TransState:
			Description = "等待变身完成中";
			if (TickCounter >= 2)
			{
				if (!CheckIsPlayerInTransState(WorldContext))
				{
					Description = "没能成功变身";
					return AutoTestNodeLib.NodeState.Failed;
				}
				Description = "已经成功变身";
				TransferState(InnerState.Trigger_EndTrans);
			}
			break;
		case InnerState.Trigger_EndTrans:
			BPS_EventCollectionCS.Get(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn().PlayerState)?.Evt_TriggerPlayerTransEnd.Invoke(EPlayerTransEndType.CastSpell, default(PlayerTransParam));
			Description = "Evt_BPS_TriggerEndTrans方式结束变身（待议）";
			TransferState(InnerState.ReCheck_TransState);
			break;
		case InnerState.ReCheck_TransState:
			Description = "等待变身结束";
			if (TickCounter >= 5)
			{
				if (!CheckIsPlayerInTransState(WorldContext))
				{
					Description = "已经变身结束";
					return AutoTestNodeLib.NodeState.Succeeded;
				}
				Description = "没能取消变身";
				return AutoTestNodeLib.NodeState.Failed;
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
