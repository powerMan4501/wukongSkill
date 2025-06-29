namespace b1;

public interface IBUC_MultiKillData
{
	float MultiKillTime { get; }

	bool MultiKillState { get; }

	float UnparalleledValue { get; }

	int UnparalleledRate { get; }

	int MultiKillNumber { get; }

	float UnparalleledValueSpeed { get; }

	bool IsCtrlPlayer { get; }
}
