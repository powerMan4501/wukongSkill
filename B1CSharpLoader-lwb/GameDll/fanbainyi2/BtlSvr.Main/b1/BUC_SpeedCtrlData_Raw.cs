namespace b1;

public struct BUC_SpeedCtrlData_Raw
{
	public const int SpeedRateMax = 2;

	public float MoveSpeedFast;

	public float MoveSpeedNormal;

	public float MoveSpeedSlow;

	public float MoveSpeedFastBase;

	public float MoveSpeedNormalBase;

	public float MoveSpeedSlowBase;

	public float JumpSpeedNormal;

	public float JumpSpeedFast;

	public float MoveBackSpeedRate;

	public unsafe fixed float SpeedRates[2];
}
