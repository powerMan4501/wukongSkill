using b1.Plugins.Calliope;
using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public class FIdleProcessExecutor_SetNPCParamOnlyInEnter : FIdleProcessExecutorBase
{
	public override EIdleProcessActionType ActionType => EIdleProcessActionType.SetNPCParamOnlyInEnter;

	private string UnitGuid { get; set; }

	private int NPCTeamID { get; set; }

	private int NPCIdleAMIdx { get; set; }

	private int NPCLeisureAnimIndex { get; set; }

	private int NPCInteractGroupID { get; set; }

	private EGsNPCShowState NPCShowState { get; set; }

	public override void Initial(CalliopeCustom_IdleProcessAction InIdleProcessAction, PsmNodeInstance InPsmNodeInstance)
	{
		NPCTeamID = InIdleProcessAction.NpcTeamId;
		NPCIdleAMIdx = InIdleProcessAction.NpcIdleAmIdx;
		NPCLeisureAnimIndex = InIdleProcessAction.NpcLeisureAnimIndex;
		NPCInteractGroupID = InIdleProcessAction.NpcInteractGroupId;
		NPCShowState = (EGsNPCShowState)InIdleProcessAction.NpcShowState;
		if (InPsmNodeInstance != null)
		{
			UnitGuid = InPsmNodeInstance.ParentInstance.ConvertParamID2UnitGuid(InIdleProcessAction.UnitGuid);
		}
	}

	public override void Run(UObject InWorldContext)
	{
		BGW_EventCollection.Get(InWorldContext)?.Evt_BGW_CacheNPCInfo(UnitGuid, NPCTeamID, NPCIdleAMIdx, NPCLeisureAnimIndex, NPCInteractGroupID, NPCShowState, null);
	}

	public override void ResetRun(UObject InWorldContext)
	{
	}

	public override void RecoverRun(UObject InWorldContext)
	{
	}
}
