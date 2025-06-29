using System.Collections.Generic;

namespace b1;

public class BIC_DeathData : IBIC_DeathData
{
	public bool bAllUnitCannotDead { get; set; }

	public bool bIgnoreAllOverlapEvent { get; set; }

	public HashSet<string> DeadSeqUnitGuidSet { get; } = new HashSet<string>();

	public bool UnitHasDeadSeq(string InUnitGuid)
	{
		return DeadSeqUnitGuidSet.Contains(InUnitGuid);
	}
}
