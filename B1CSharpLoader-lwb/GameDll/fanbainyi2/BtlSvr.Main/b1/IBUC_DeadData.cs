namespace b1;

public interface IBUC_DeadData
{
	float DissolveDisplayTimer { get; }

	int GetDeadInfoID();

	FDeadAMWaitingBeAttackedAMInfo Get_DeadAMWaitingBeAttackedAMInfo();
}
