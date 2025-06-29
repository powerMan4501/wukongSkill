using b1.Plugins.Calliope;
using BtlShare;

namespace b1;

public class FTamerProcessor_FilterRule : FTamerProcessorBase
{
	public override EProcessorSequence ProcessorSequence => EProcessorSequence.FilterRule;

	protected override void Process(ref FTamerProcessorContext InContext)
	{
		FTamerRef currentProcessedTamer = InContext.CurrentProcessedTamer;
		if (currentProcessedTamer.Phase == ETamerPhase.Dead)
		{
			base.bStopCurrentProcessChain = true;
			return;
		}
		FTamerStrategyResult result = InContext.Result;
		if (currentProcessedTamer.GetActualResetType() == EBGUResetType.Destroy || currentProcessedTamer.NPCShowState == EGsNPCShowState.Hide)
		{
			ETamerPhase phase = currentProcessedTamer.Phase;
			if (phase == ETamerPhase.Visible || (uint)(phase - 6) <= 1u)
			{
				result.Back2LoadNoDelayTamers.Add(currentProcessedTamer);
			}
			base.bStopCurrentProcessChain = true;
		}
		else if (currentProcessedTamer.HasSpawnRuleFlag(ETamerSpawnRule.BlockingSpawn))
		{
			result.BlockingSpawnTamerList.Add(currentProcessedTamer);
			base.bStopCurrentProcessChain = true;
		}
		else if (InContext.bUseOnlyList)
		{
			if (currentProcessedTamer.HasSpawnRuleFlag(ETamerSpawnRule.OnlySpawn))
			{
				ETamerPhase phase = currentProcessedTamer.Phase;
				if ((uint)(phase - 2) <= 1u || phase == ETamerPhase.PreBegunPlay)
				{
					result.IncrementalSpawnTamers.Add(currentProcessedTamer);
				}
			}
			else
			{
				ETamerPhase phase = currentProcessedTamer.Phase;
				if (phase == ETamerPhase.Visible || (uint)(phase - 6) <= 1u)
				{
					result.Back2LoadNoDelayTamers.Add(currentProcessedTamer);
				}
			}
			base.bStopCurrentProcessChain = true;
		}
		else if (currentProcessedTamer.HasSpawnRuleFlag(ETamerSpawnRule.NeverSpawn))
		{
			ETamerPhase phase = currentProcessedTamer.Phase;
			if (phase == ETamerPhase.Visible || (uint)(phase - 6) <= 1u)
			{
				result.Back2LoadNoDelayTamers.Add(currentProcessedTamer);
			}
			base.bStopCurrentProcessChain = true;
		}
		else if (currentProcessedTamer.HasSpawnRuleFlag(ETamerSpawnRule.AlwaysSpawn))
		{
			ETamerPhase phase = currentProcessedTamer.Phase;
			if ((uint)(phase - 2) <= 1u || phase == ETamerPhase.PreBegunPlay)
			{
				result.IncrementalSpawnTamers.Add(currentProcessedTamer);
			}
			base.bStopCurrentProcessChain = true;
		}
	}
}
