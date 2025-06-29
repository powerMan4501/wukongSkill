using System;
using CommB1;

namespace b1;

public class FGuardCondition_AiConversationChainEnd : FGuardConditionBase
{
	private string PsmGuid { get; set; }

	private Guid NodeGuid { get; set; }

	private IBIC_StateMachineData StateMachineData { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.AiConversationChainEnd;

	public override bool Initial(CalliopeCustom_TransitionCondition_Idle IdleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		PsmGuid = InPsmNodeInstance.ParentInstance.PsmGuid;
		NodeGuid = InPsmNodeInstance.Node.NodeGuid;
		return true;
	}

	protected override void Clean()
	{
	}

	protected override void Start()
	{
		base.QueryState = EQueryState.Querying;
		StateMachineData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_StateMachineData, BIC_StateMachineData>(base.Owner);
	}

	protected override void OnTick(float DeltaTime)
	{
		if (StateMachineData.IsAiConversationChainEnd(PsmGuid, NodeGuid))
		{
			base.QueryState = EQueryState.QuerySuccess;
		}
	}
}
