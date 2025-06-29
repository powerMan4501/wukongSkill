using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public class FIdleProcessExecutor_KillAssociationUnit : FIdleProcessExecutorBase
{
	public override EIdleProcessActionType ActionType => EIdleProcessActionType.KillAssociationUnit;

	private int AssociationUnitInfoConfigId { get; set; }

	public override void Initial(CalliopeCustom_IdleProcessAction InIdleProcessAction, PsmNodeInstance InPsmNodeInstance)
	{
		PsmInstance parentInstance = InPsmNodeInstance.ParentInstance;
		if (parentInstance != null)
		{
			AssociationUnitInfoConfigId = parentInstance.ConvertParamID2IntParam(InIdleProcessAction.AssociationUnitInfoConfigId);
		}
	}

	public override void Run(UObject InWorldContext)
	{
		int associationUnitInfoConfigId = AssociationUnitInfoConfigId;
		if (BGW_GameDB.GetAssociationUnitInfoSDesc(associationUnitInfoConfigId) != null)
		{
			BGW_EventCollection.Get(InWorldContext).Evt_BGW_KillAssociationUnit(associationUnitInfoConfigId);
		}
	}
}
