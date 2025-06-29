using CommB1;
using Google.Protobuf;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class PsmNodeInstance_NPCState : PsmNodeInstance
{
	public override string[] SupportNodeClasses => new string[1] { B1CalliopeDef.ProcessMachineNode.NPCState };

	private ProcessCustom_NPCState CustomData { get; set; }

	private PsmStateInstance StateInstance { get; set; }

	public override void PostCreate()
	{
		CustomData = new ProcessCustom_NPCState();
		CustomData.MergeFrom(base.Node.NodeData);
		base.ParentInstance.RegisterStateNodeInstance(CustomData.StateName, this);
		if (base.ParentInstance.TryGetStateInstance(CustomData.StateName, out var StateInstance))
		{
			this.StateInstance = StateInstance;
		}
	}

	protected override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		StateInstance?.OnEnterAction();
	}

	public override void OnEvent(FGameplayTag EventTag)
	{
	}

	public override void Tick(float DeltaTime)
	{
		base.Tick(DeltaTime);
		TickForCachePlayerData();
		TickForCheckCondition();
		StateInstance?.OnTickAction(DeltaTime);
	}

	private void TickForCachePlayerData()
	{
	}

	private void TickForCheckCondition()
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.ParentInstance.Owner);
		APawn aPawn = firstLocalPlayerController?.GetControlledPawn();
		if (!(aPawn != null) || !(aPawn.PlayerState != null))
		{
			return;
		}
		IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(firstLocalPlayerController);
		if (readOnlyData == null || readOnlyData.RoleData == null || readOnlyData.RoleData.RoleCs == null || readOnlyData.RoleData.RoleCs.Task == null)
		{
			return;
		}
		foreach (ReadOnlyQuestStageOne quest in readOnlyData.RoleData.RoleCs.Task.QuestList)
		{
			foreach (TaskConditionOutpinInfo taskConditionInfo in CustomData.TaskConditionInfoList)
			{
				int id = taskConditionInfo.TaskConditionInfo.Id;
				QuestStage stage = taskConditionInfo.TaskConditionInfo.Stage;
				if (quest.Id == id && quest.Stage == stage)
				{
					TriggerOutput(taskConditionInfo.OutpinName, bFinish: true);
					break;
				}
			}
		}
	}

	protected override void Finish()
	{
		base.Finish();
		if (!base.ParentInstance.IsInReset())
		{
			StateInstance?.OnExitAction();
		}
	}

	public override void Shutdown()
	{
		StateInstance?.Shutdown();
		StateInstance = null;
		base.Shutdown();
	}

	public override void RecoverActiveState()
	{
		StateInstance?.OnResetAction();
	}
}
