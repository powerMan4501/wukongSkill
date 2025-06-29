using BtlShare;

namespace b1;

public class FGuardCondition_PlayerDead : FGuardConditionBase
{
	private IBUC_UnitStateData UnitStateData => FGuardConditionBase.CommonData.PlayerUnitStateData;

	private IBPC_PlayerTagData PlayerTagData => FGuardConditionBase.CommonData.PlayerTagData;

	public override EGuardConditionType ConditionType => EGuardConditionType.PlayerDead;

	protected override void Clean()
	{
	}

	protected override void OnTick(float DeltaTime)
	{
		if (UnitStateData != null && UnitStateData.HasState(EBGUUnitState.Dead) && !PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
		{
			base.QueryState = EQueryState.QuerySuccess;
		}
		else
		{
			base.QueryState = EQueryState.Querying;
		}
	}
}
