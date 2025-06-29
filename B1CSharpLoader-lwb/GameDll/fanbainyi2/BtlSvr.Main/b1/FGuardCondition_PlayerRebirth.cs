using b1.EventDelDefine;

namespace b1;

public class FGuardCondition_PlayerRebirth : FGuardConditionBase
{
	public override EGuardConditionType ConditionType => EGuardConditionType.PlayerRebirth;

	protected override void Clean()
	{
	}

	protected override void Start()
	{
		BPS_EventCollectionCS.GetLocal(GetOwner()).Evt_RebirthTeleportEnd += new Del_Void(UnitRebirthFinished);
	}

	protected override void Stop()
	{
		BPS_EventCollectionCS.GetLocal(GetOwner()).Evt_RebirthTeleportEnd -= new Del_Void(UnitRebirthFinished);
	}

	protected override void OnPlayerControllerAttach()
	{
		BPS_EventCollectionCS.GetLocal(GetOwner()).Evt_RebirthTeleportEnd += new Del_Void(UnitRebirthFinished);
	}

	private void UnitRebirthFinished()
	{
		base.QueryState = EQueryState.QuerySuccess;
	}
}
