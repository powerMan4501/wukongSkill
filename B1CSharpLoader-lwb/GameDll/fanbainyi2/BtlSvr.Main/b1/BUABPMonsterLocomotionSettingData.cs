namespace b1;

public class BUABPMonsterLocomotionSettingData : BUABPSettingDataBase
{
	public BUABPMonsterLocomotion_FreeSettingData Free { get; private set; }

	public BUABPMonsterLocomotion_LockSettingData Lock { get; private set; }

	public override void InitSettingData(in BGWDataAsset_AbpHumanoidSetting ABPSetting)
	{
		if (!(ABPSetting == null))
		{
			FAnimHumanoidSetting_MonsterLocomotion monsterLocomotionSetting = ABPSetting.MonsterLocomotionSetting;
			Free = new BUABPMonsterLocomotion_FreeSettingData(in monsterLocomotionSetting.Free);
			Lock = new BUABPMonsterLocomotion_LockSettingData(in monsterLocomotionSetting.Lock);
		}
	}
}
