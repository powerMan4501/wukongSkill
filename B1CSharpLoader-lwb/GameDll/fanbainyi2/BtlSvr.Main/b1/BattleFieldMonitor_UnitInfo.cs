using UnrealEngine.Engine;

namespace b1;

public class BattleFieldMonitor_UnitInfo
{
	private IBUC_TickRateData TickRateData;

	private IBUC_BattleStateData BattleStateData;

	public BattleFieldMonitor_UnitInfo(AActor Unit)
	{
		TickRateData = BGU_DataUtil.GetReadOnlyData<IBUC_TickRateData, BUC_TickRateData>(Unit);
		BattleStateData = BGU_DataUtil.GetReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>(Unit);
	}

	public bool bNeedOpenOpt(AActor FirstLocalPlayer, float DistThreshold)
	{
		if (BattleStateData.IsUnitInBattleAssignPlayer(FirstLocalPlayer))
		{
			return false;
		}
		return TickRateData.GetDistanceToPlayer() > DistThreshold;
	}
}
