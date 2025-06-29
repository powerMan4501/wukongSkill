using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public class FIdleProcessExecutor_SpawnAssociationUnit : FIdleProcessExecutorBase
{
	public override EIdleProcessActionType ActionType => EIdleProcessActionType.SpawnAssociationUnit;

	private int AssociationUnitActiveInfoOnfightSkillId { get; set; }

	private string AssociationUnitActiveInfoTargetGuid { get; set; }

	private EAssociationUnitActiveType AssociationUnitSpawnInfoActiveType { get; set; }

	private EAssociationUnitSpawnType AssociationUnitSpawnInfoSpawnType { get; set; }

	private int AssociationUnitSpawnInfoDelayExecuteTime { get; set; }

	private int AssociationUnitInfoConfigId { get; set; }

	public override void Initial(CalliopeCustom_IdleProcessAction InIdleProcessAction, PsmNodeInstance InPsmNodeInstance)
	{
		AssociationUnitSpawnInfoDelayExecuteTime = InIdleProcessAction.AssociationUnitSpawnInfoDelayExecuteTime;
		AssociationUnitSpawnInfoSpawnType = (EAssociationUnitSpawnType)InIdleProcessAction.AssociationUnitSpawnInfoSpawnType;
		AssociationUnitSpawnInfoActiveType = (EAssociationUnitActiveType)InIdleProcessAction.AssociationUnitSpawnInfoActiveType;
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
			int associationUnitSpawnInfoDelayExecuteTime = AssociationUnitSpawnInfoDelayExecuteTime;
			EAssociationUnitSpawnType associationUnitSpawnInfoSpawnType = AssociationUnitSpawnInfoSpawnType;
			EAssociationUnitActiveType associationUnitSpawnInfoActiveType = AssociationUnitSpawnInfoActiveType;
			string associationUnitActiveInfoTargetGuid = AssociationUnitActiveInfoTargetGuid;
			int associationUnitActiveInfoOnfightSkillId = AssociationUnitActiveInfoOnfightSkillId;
			BGW_EventCollection.Get(InWorldContext).Evt_BGW_SpawnAssociationUnit(associationUnitInfoConfigId, associationUnitSpawnInfoDelayExecuteTime, associationUnitSpawnInfoSpawnType, associationUnitSpawnInfoActiveType, associationUnitActiveInfoTargetGuid, associationUnitActiveInfoOnfightSkillId);
		}
	}
}
