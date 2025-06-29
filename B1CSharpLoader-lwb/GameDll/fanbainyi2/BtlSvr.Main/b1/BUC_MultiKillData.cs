namespace b1;

public class BUC_MultiKillData : IBUC_MultiKillData
{
	public float MultiKillTime { get; set; }

	public bool MultiKillState { get; set; }

	public float UnparalleledValue { get; set; }

	public int UnparalleledRate { get; set; }

	public int MultiKillNumber { get; set; }

	public float UnparalleledValueSpeed { get; set; }

	public bool IsCtrlPlayer { get; set; }

	public bool OnGMSetUnparalleled { get; set; }

	public bool IsPlayerInitComplete { get; set; }

	public float LastTickTime { get; set; }

	public bool UnparalleledValueAddPause { get; set; }
}
