using System.Collections.Generic;
using BtlB1;

namespace b1;

public class FTamerProcessor_DistanceSpawn : FTamerProcessorBase
{
	public override EProcessorSequence ProcessorSequence => EProcessorSequence.DistanceSpawn;

	private static Dictionary<string, FUStTamerStrategyConfigDesc> TamerCustomDistMap { get; } = new Dictionary<string, FUStTamerStrategyConfigDesc>();

	protected override void PostInitial()
	{
		if (!BGW_GameDB.GetAllTamerStrategyConfigDesc(out var TamerStrategyConfigDescList))
		{
			return;
		}
		foreach (FUStTamerStrategyConfigDesc item in TamerStrategyConfigDescList)
		{
			if (!TamerCustomDistMap.ContainsKey(item.UnitGuid))
			{
				TamerCustomDistMap.Add(item.UnitGuid, item);
			}
		}
	}

	protected override void Process(ref FTamerProcessorContext InContext)
	{
		FTamerStrategyResult result = InContext.Result;
		FTamerRef currentProcessedTamer = InContext.CurrentProcessedTamer;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		float num = currentProcessedTamer.LastCalcDistance.X;
		float num2 = currentProcessedTamer.LastCalcDistance.Y;
		if (B1Global.GIsBossRushMode)
		{
			num = 0f;
			num2 = 0f;
		}
		float num3 = (currentProcessedTamer.bPatrolUnit ? FTamerStrategyPreDefines.DistanceForPatrolActorBeginPlayMeter : FTamerStrategyPreDefines.DistanceForActorBeginPlayMeter);
		float num4 = (currentProcessedTamer.bPatrolUnit ? FTamerStrategyPreDefines.DistanceForUnloadPatrolUnitMeter : FTamerStrategyPreDefines.DistanceForUnloadMeter);
		float num5 = FTamerStrategyPreDefines.ZOffsetSpawnLimitMeter;
		float num6 = FTamerStrategyPreDefines.ZOffsetUnloadLimitMeter;
		if (TamerCustomDistMap.TryGetValue(currentProcessedTamer.TamerGuid, out var value))
		{
			num3 = value.BattleDist;
			num4 = value.DestroyDist;
			num5 = value.BattleZOffset;
			num6 = value.DestroyZOffset;
			base.bStopCurrentProcessChain = true;
		}
		switch (currentProcessedTamer.Phase)
		{
		case ETamerPhase.Loaded:
			flag = num <= num3 && num2 <= num5;
			flag3 = num < FTamerStrategyPreDefines.DistanceForForceSpawn && num2 <= num5;
			break;
		case ETamerPhase.Visible:
			flag = num <= num3 && num2 <= num5;
			flag2 = num >= num4 || num2 > num6;
			flag3 = num < FTamerStrategyPreDefines.DistanceForForceSpawn && num2 <= num5;
			break;
		case ETamerPhase.PreBegunPlay:
			flag = num <= num3 && num2 <= num5;
			flag2 = num >= num4 || num2 > num6;
			flag3 = num < FTamerStrategyPreDefines.DistanceForForceSpawn && num2 <= num5;
			break;
		case ETamerPhase.Spawned:
			flag = num <= num3 && num2 <= num5;
			flag2 = num >= num4 || num2 > num6;
			break;
		}
		flag2 = flag2 && InContext.bCanBack2Load;
		if (flag3)
		{
			result.BlockingSpawnTamerList.Add(currentProcessedTamer);
		}
		else if (flag2)
		{
			result.Back2LoadTamers.Add(currentProcessedTamer);
		}
		else if (flag)
		{
			if (currentProcessedTamer.Phase == ETamerPhase.Spawned)
			{
				result.RemoveDelayDestroyTamer(currentProcessedTamer);
			}
			else
			{
				result.IncrementalSpawnTamers.Add(currentProcessedTamer);
			}
		}
	}
}
