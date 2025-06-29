using UnrealEngine.Engine;

namespace b1;

public class BUABPSpecialAdditiveSettingData : BUABPSettingDataBase
{
	public float MinSlopeAngle { get; private set; }

	public float MaxSlopeAngle { get; private set; }

	public UAnimSequence ASSlopeAdditiveLocalSpace { get; private set; }

	public UAnimSequence ASSlopeAdditiveMeshSpace { get; private set; }

	public UBlendSpace BSMoveSpeedAdditive { get; private set; }

	public override void InitSettingData(in BGWDataAsset_AbpHumanoidSetting ABPSetting)
	{
		if (!(ABPSetting == null))
		{
			FAnimHumanoidSetting_SpecialAdditive specialAdditiveSetting = ABPSetting.SpecialAdditiveSetting;
			MinSlopeAngle = specialAdditiveSetting.MinSlopeAngle;
			MaxSlopeAngle = specialAdditiveSetting.MaxSlopeAngle;
			ASSlopeAdditiveLocalSpace = specialAdditiveSetting.ASSlopeAdditiveLocalSpace;
			ASSlopeAdditiveMeshSpace = specialAdditiveSetting.ASSlopeAdditiveMeshSpace;
			BSMoveSpeedAdditive = specialAdditiveSetting.BSMoveSpeedAdditive;
		}
	}
}
