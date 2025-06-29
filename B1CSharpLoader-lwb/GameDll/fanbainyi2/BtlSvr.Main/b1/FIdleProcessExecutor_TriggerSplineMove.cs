using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public class FIdleProcessExecutor_TriggerSplineMove : FIdleProcessExecutorBase
{
	public override EIdleProcessActionType ActionType => EIdleProcessActionType.TriggerSplineMove;

	public string SplineMoveGuid { get; set; }

	private BGS_GSEventCollection BGSEventCollection { get; set; }

	public override void Initial(CalliopeCustom_IdleProcessAction InIdleProcessAction, PsmNodeInstance InPsmNodeInstance)
	{
		SplineMoveGuid = InIdleProcessAction.DropItemManageGuid;
	}

	public override void Run(UObject InWorldContext)
	{
		BGW_EventCollection.Get(InWorldContext)?.Evt_SendSceneObjEvent(SplineMoveGuid, BGW_FlowUtils.SplineFlyMoveTag.Event_TriggerSplineFly);
	}

	public override bool IsFinished()
	{
		return false;
	}

	public override void Shutdown(UObject InWorldContext)
	{
	}
}
