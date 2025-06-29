using UnrealEngine.Engine;

namespace b1;

public class BUABPFlyControlSettingData : BUABPSettingDataBase
{
	public UBlendSpace BSFly { get; private set; }

	public UAnimSequence ASFlyUpward { get; private set; }

	public UAnimSequence ASFlyDownward { get; private set; }

	public UAnimSequence ASFlyUpToDown { get; private set; }

	public UAnimSequence ASFlyDownToUp { get; private set; }

	public UBlendSpace BSFlyLean { get; private set; }

	public override void InitSettingData(in BGWDataAsset_AbpHumanoidSetting ABPSetting)
	{
		if (!(ABPSetting == null))
		{
			FAnimHumanoidSetting_FlyControl flyControlSetting = ABPSetting.FlyControlSetting;
			BSFly = flyControlSetting.BSFly;
			ASFlyUpward = flyControlSetting.ASFlyUpward;
			ASFlyDownward = flyControlSetting.ASFlyDownward;
			ASFlyUpToDown = flyControlSetting.ASFlyUpToDown;
			ASFlyDownToUp = flyControlSetting.ASFlyDownToUp;
			BSFlyLean = flyControlSetting.BSFlyLean;
		}
	}
}
