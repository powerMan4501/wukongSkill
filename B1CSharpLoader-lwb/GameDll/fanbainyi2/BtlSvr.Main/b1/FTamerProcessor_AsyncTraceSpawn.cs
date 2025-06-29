using System.Collections.Generic;

namespace b1;

public class FTamerProcessor_AsyncTraceSpawn : FTamerProcessorBase
{
	public override EProcessorSequence ProcessorSequence => EProcessorSequence.AsyncTraceSpawn;

	protected override void Process(ref FTamerProcessorContext InContext)
	{
		FTamerRef currentProcessedTamer = InContext.CurrentProcessedTamer;
		Dictionary<int, bool> tamerVisibleDictionary = InContext.TamerVisibleDictionary;
		if (tamerVisibleDictionary.Count <= 0 || !tamerVisibleDictionary.TryGetValue(currentProcessedTamer.RefID, out var value))
		{
			return;
		}
		FTamerStrategyResult result = InContext.Result;
		float x = currentProcessedTamer.LastCalcDistance.X;
		float y = currentProcessedTamer.LastCalcDistance.Y;
		if (value)
		{
			if (x < FTamerStrategyPreDefines.AsyncTraceMaxEffectRange && y < FTamerStrategyPreDefines.ZOffsetUnloadLimitMeter)
			{
				switch (currentProcessedTamer.Phase)
				{
				case ETamerPhase.Loaded:
				case ETamerPhase.Visible:
				case ETamerPhase.PreBegunPlay:
					result.IncrementalSpawnTamers.Add(currentProcessedTamer);
					break;
				case ETamerPhase.Spawned:
					result.RemoveDelayDestroyTamer(currentProcessedTamer);
					break;
				case ETamerPhase.ServerWaitingAuthorityECSBeginPlay:
				case ETamerPhase.ClientWaitingChannelAndAuthRoleReady:
					break;
				}
			}
		}
		else if (x > FTamerStrategyPreDefines.AsyncTraceMinEffectRange)
		{
			ETamerPhase phase = currentProcessedTamer.Phase;
			if ((phase == ETamerPhase.Visible || (uint)(phase - 6) <= 1u) && InContext.bCanBack2Load && currentProcessedTamer.CanTurnBack2Loaded())
			{
				result.Back2LoadTamers.Add(currentProcessedTamer);
			}
		}
	}
}
