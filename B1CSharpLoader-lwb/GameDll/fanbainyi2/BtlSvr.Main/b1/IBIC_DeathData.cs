namespace b1;

public interface IBIC_DeathData
{
	bool bAllUnitCannotDead { get; }

	bool bIgnoreAllOverlapEvent { get; }

	bool UnitHasDeadSeq(string InUnitGuid);
}
