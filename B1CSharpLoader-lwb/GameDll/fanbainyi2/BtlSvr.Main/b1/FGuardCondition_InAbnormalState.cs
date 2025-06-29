using BtlShare;
using CommB1;

namespace b1;

public class FGuardCondition_InAbnormalState : FGuardConditionBase
{
	private EAbnormalStateType AbnormalState { get; set; }

	private IBUC_AbnormalStateHandlers AbnormalStateHandlers => FGuardConditionBase.CommonData.AbnormalStateHandlers;

	private IBPC_PlayerTagData PlayerTagData => FGuardConditionBase.CommonData.PlayerTagData;

	public override EGuardConditionType ConditionType => EGuardConditionType.InAbnormalState;

	protected override void Clean()
	{
		AbnormalState = EAbnormalStateType.None;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		AbnormalState = (EAbnormalStateType)GuideCondition.AbnormalState;
		return true;
	}

	protected override void OnTick(float DeltaTime)
	{
		if (AbnormalStateHandlers != null)
		{
			if (AbnormalState == EAbnormalStateType.None)
			{
				base.QueryState = EQueryState.Error;
			}
			else if (AbnormalStateHandlers.IsInFinalState(AbnormalState) && !PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
			{
				base.QueryState = EQueryState.QuerySuccess;
			}
			else
			{
				base.QueryState = EQueryState.Querying;
			}
		}
	}
}
