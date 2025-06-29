using UnrealEngine.Engine;

namespace b1;

public class BUABPAimOffsetSettingData : BUABPSettingDataBase
{
	public int AimOffsetTurnSpeed { get; private set; }

	public int AimOffsetBlindAngle { get; private set; }

	public UAimOffsetBlendSpace DefaultAimOffset { get; private set; }

	public UAimOffsetBlendSpace AttackAimOffset { get; private set; }

	public override void InitSettingData(in BGWDataAsset_AbpHumanoidSetting ABPSetting)
	{
		if (!(ABPSetting == null))
		{
			FAnimHumanoidSetting_AimOffset aimOffsetSetting = ABPSetting.AimOffsetSetting;
			AimOffsetTurnSpeed = aimOffsetSetting.AimOffsetTurnSpeed;
			AimOffsetBlindAngle = aimOffsetSetting.AimOffsetBlindAngle;
			DefaultAimOffset = aimOffsetSetting.DefaultAimOffset;
			AttackAimOffset = aimOffsetSetting.AttackAimOffset;
		}
	}
}
