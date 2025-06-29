namespace b1;

public class BUABPMonsterLocomotion_Lock_ExplicitTimeForMoveStopSettingData
{
	public float Fwd { get; private set; }

	public float FL { get; private set; }

	public float BL { get; private set; }

	public float FR { get; private set; }

	public float BR { get; private set; }

	public float Bwd { get; private set; }

	public BUABPMonsterLocomotion_Lock_ExplicitTimeForMoveStopSettingData(in FAnimHumanoidSetting_MonsterLocomotion_Lock_ExplicitTimeForMoveStop Setting)
	{
		Fwd = Setting.Fwd;
		FL = Setting.FL;
		BL = Setting.BL;
		FR = Setting.FR;
		BR = Setting.BR;
		Bwd = Setting.Bwd;
	}
}
