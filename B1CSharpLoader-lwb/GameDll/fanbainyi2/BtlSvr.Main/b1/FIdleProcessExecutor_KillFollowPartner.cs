using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public class FIdleProcessExecutor_KillFollowPartner : FIdleProcessExecutorBase
{
	public override EIdleProcessActionType ActionType => EIdleProcessActionType.KillFollowPartner;

	private int FollowPartnerConfigId { get; set; }

	public override void Initial(CalliopeCustom_IdleProcessAction InIdleProcessAction, PsmNodeInstance InPsmNodeInstance)
	{
		PsmInstance parentInstance = InPsmNodeInstance.ParentInstance;
		if (parentInstance != null)
		{
			FollowPartnerConfigId = parentInstance.ConvertParamID2IntParam(InIdleProcessAction.FollowPartnerConfigId);
		}
	}

	public override void Run(UObject InWorldContext)
	{
		if (BGS_EventCollectionCS.Get(InWorldContext) != null)
		{
			BGS_EventCollectionCS.Get(InWorldContext).Evt_BGS_EliminationCurrentFollowPartner.Invoke(FollowPartnerConfigId);
		}
	}
}
