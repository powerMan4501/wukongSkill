using UnrealEngine.Engine;

namespace b1;

public class BUABPSimple4DirSettingData : BUABPSettingDataBase
{
	public UBlendSpace BSStart { get; private set; }

	public UBlendSpace BSEnd { get; private set; }

	public float CardinalDirectionBlendTime { get; private set; }

	public UBlendSpace BSWalkFwd { get; private set; }

	public UBlendSpace BSWalkBwd { get; private set; }

	public UBlendSpace BSWalkLeft { get; private set; }

	public UBlendSpace BSWalkRight { get; private set; }

	public UBlendSpace BSRunFwd { get; private set; }

	public UBlendSpace BSRunBwd { get; private set; }

	public UBlendSpace BSRunLeft { get; private set; }

	public UBlendSpace BSRunRight { get; private set; }

	public UBlendSpace BSSprint { get; private set; }

	public override void InitSettingData(in BGWDataAsset_AbpHumanoidSetting ABPSetting)
	{
		if (!(ABPSetting == null))
		{
			FAnimHumanoidSetting_Simple4Dir simple4DirSetting = ABPSetting.Simple4DirSetting;
			BSStart = simple4DirSetting.BSStart;
			BSEnd = simple4DirSetting.BSEnd;
			CardinalDirectionBlendTime = simple4DirSetting.CardinalDirectionBlendTime;
			BSWalkFwd = simple4DirSetting.BSWalkFwd;
			BSWalkBwd = simple4DirSetting.BSWalkBwd;
			BSWalkLeft = simple4DirSetting.BSWalkLeft;
			BSWalkRight = simple4DirSetting.BSWalkRight;
			BSRunFwd = simple4DirSetting.BSRunFwd;
			BSRunBwd = simple4DirSetting.BSRunBwd;
			BSRunLeft = simple4DirSetting.BSRunLeft;
			BSRunRight = simple4DirSetting.BSRunRight;
			BSSprint = simple4DirSetting.BSSprint;
		}
	}
}
