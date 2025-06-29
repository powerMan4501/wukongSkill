using CommB1;
using Google.Protobuf;
using OssB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class PsmSubMachine_ReportOSS : PsmSubMachine_TemplateBase
{
	private class State_ReportOSS : PsmSubMachineState
	{
		public override void OnEnterAction()
		{
			if (GetSubMachine<PsmSubMachine_ReportOSS>(out var OutSubMachine))
			{
				OutSubMachine.SetObjStateOnBeginning();
				if (BGW_EventCollection.Get(GetOwner()) != null && BGW_GameDB.GetTaskLineDesc(OutSubMachine.TaskLine) != null)
				{
					APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetOwner());
					APawn aPawn = firstLocalPlayerController?.GetControlledPawn();
					if (aPawn != null && aPawn.PlayerState != null)
					{
						IBPC_RoleBaseData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_RoleBaseData, BPC_RoleBaseData>(firstLocalPlayerController.PlayerState);
						if (readOnlyData != null)
						{
							BGS_GSEventCollection.Get(GetOwner()).Evt_BGS_OnTaskStageChange.Invoke(readOnlyData.RoleId, OutSubMachine.TaskLine, 1, TaskStageState.End, OutSubMachine.StageNote);
						}
					}
				}
			}
			NotifySelfNext();
		}

		public override void OnResetAction()
		{
			NotifySelfNext();
		}

		private void NotifySelfNext()
		{
			NotifySelf(BGW_FlowUtils.SceneObjCommonEventTag.Next);
		}
	}

	public override string NodeClass => B1CalliopeDef.ProcessMachineNode.ReportOSS;

	private ProcessCustom_ReportOSS CustomData { get; set; }

	private int TaskLine { get; set; }

	private string StageNote { get; set; }

	protected override string DefaultTerminatePinName => BGW_FlowUtils.PinName.Out.PlainName;

	protected override void InitialData(byte[] CustomDataBytes)
	{
		base.InitialData(CustomDataBytes);
		CustomData = new ProcessCustom_ReportOSS();
		CustomData.MergeFrom(CustomDataBytes);
		base.ManagedSceneObjs.AddRange(CustomData.ManagedObjs);
		base.ManagedNpcUnits.AddRange(CustomData.ManagedNpcUnits);
		base.ManagedInteractors.AddRange(CustomData.ManagedInteractors);
		base.ManagedStreamingLevelStateConfigs.AddRange(CustomData.ManagedStreamingLevelStateConfigs);
		base.ManagedGroupUnits.AddRange(CustomData.ManagedGroupUnits);
		FGameplayTag state_ReportOSS = BGW_FlowUtils.CommonProcessTag.State_ReportOSS;
		RegisterStateWithClass(state_ReportOSS, typeof(State_ReportOSS));
		RegisterInitialTransition(state_ReportOSS);
		RegisterFinalTransition(state_ReportOSS, BGW_FlowUtils.SceneObjCommonEventTag.Next);
	}

	public override void PreStart()
	{
		base.PreStart();
		StageNote = CustomData.StageNote;
		TaskLine = base.ParentPsmInstance.ConvertParamID2IntParam(CustomData.TaskLine);
	}
}
