namespace b1;

public interface IBUC_PreciseDodgeData
{
	int DefaultAwardsLevel { get; }

	int CurrentAwardsLevel { get; }

	bool InPreciseDodgeWindow();
}
