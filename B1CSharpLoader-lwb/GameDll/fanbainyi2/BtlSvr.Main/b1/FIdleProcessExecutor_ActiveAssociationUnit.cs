using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public class FIdleProcessExecutor_ActiveAssociationUnit : FIdleProcessExecutorBase
{
	public override EIdleProcessActionType ActionType => EIdleProcessActionType.ActiveAssociationUnit;

	private int AssociationUnitActiveInfoOnfightSkillId { get; set; }

	private string AssociationUnitActiveInfoTargetGuid { get; set; }

	private int AssociationUnitInfoConfigId { get; set; }

	public override void Initial(CalliopeCustom_IdleProcessAction InIdleProcessAction, PsmNodeInstance InPsmNodeInstance)
	{
		AssociationUnitActiveInfoOnfightSkillId = InIdleProcessAction.AssociationUnitActiveInfoOnfightSkillid;
		PsmInstance parentInstance = InPsmNodeInstance.ParentInstance;
		if (parentInstance != null)
		{
			AssociationUnitInfoConfigId = parentInstance.ConvertParamID2IntParam(InIdleProcessAction.AssociationUnitInfoConfigId);
			AssociationUnitActiveInfoTargetGuid = parentInstance.ConvertParamID2StringParam(InIdleProcessAction.AssociationUnitActiveInfoTargetGuid);
		}
	}

	public override void Run(UObject InWorldContext)
	{
		int associationUnitInfoConfigId = AssociationUnitInfoConfigId;
		if (BGW_GameDB.GetAssociationUnitInfoSDesc(associationUnitInfoConfigId) != null)
		{
			string associationUnitActiveInfoTargetGuid = AssociationUnitActiveInfoTargetGuid;
			int associationUnitActiveInfoOnfightSkillId = AssociationUnitActiveInfoOnfightSkillId;
			BGW_EventCollection.Get(InWorldContext).Evt_BGW_ActiveAssociationUnit(associationUnitInfoConfigId, associationUnitActiveInfoTargetGuid, associationUnitActiveInfoOnfightSkillId);
		}
	}
}
