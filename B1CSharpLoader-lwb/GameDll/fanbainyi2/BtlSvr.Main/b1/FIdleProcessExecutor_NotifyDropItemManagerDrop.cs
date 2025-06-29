using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public class FIdleProcessExecutor_NotifyDropItemManagerDrop : FIdleProcessExecutorBase
{
	public override EIdleProcessActionType ActionType => EIdleProcessActionType.NotifyDropItemManagerDrop;

	public string DropItemManageGuid { get; set; }

	public override void Initial(CalliopeCustom_IdleProcessAction InIdleProcessAction, PsmNodeInstance InPsmNodeInstance)
	{
		DropItemManageGuid = InIdleProcessAction.DropItemManageGuid;
	}

	public override void Run(UObject InWorldContext)
	{
		BGW_EventCollection.Get(InWorldContext)?.Evt_SendSceneObjEvent(DropItemManageGuid, BGW_FlowUtils.DroppedItemEventTag.Event_ItemDropped);
	}
}
