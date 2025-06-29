using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public class FIdleProcessExecutor_DisappearUnit : FIdleProcessExecutorBase
{
	public override EIdleProcessActionType ActionType => EIdleProcessActionType.DisappearUnit;

	public string UnitGuid { get; set; }

	public override void Initial(CalliopeCustom_IdleProcessAction InIdleProcessAction, PsmNodeInstance InPsmNodeInstance)
	{
		if (InPsmNodeInstance != null)
		{
			UnitGuid = InPsmNodeInstance.ParentInstance.ConvertParamID2UnitGuid(InIdleProcessAction.UnitGuid);
		}
	}

	public override void Run(UObject InWorldContext)
	{
		BGW_EventCollection.Get(InWorldContext)?.Evt_SetSceneObjState(UnitGuid, BGW_FlowUtils.PerformerTag.State_Waiting);
	}
}
