using UnrealEngine.Engine;

namespace b1;

public class BUABPPatrolSettingData : BUABPSettingDataBase
{
	public UAnimSequence AnimIdle { get; private set; }

	public UBlendSpace BSWalkFwd { get; private set; }

	public UBlendSpace BSWalkBwd { get; private set; }

	public UBlendSpace BSWalkLeft { get; private set; }

	public UBlendSpace BSWalkRight { get; private set; }

	public UBlendSpace BSRunFwd { get; private set; }

	public UBlendSpace BSRunBwd { get; private set; }

	public UBlendSpace BSRunLeft { get; private set; }

	public UBlendSpace BSRunRight { get; private set; }

	public override void InitSettingData(in BGWDataAsset_AbpHumanoidSetting ABPSetting)
	{
		if (!(ABPSetting == null))
		{
			FAnimHumanoidSetting_Patrol patrolSetting = ABPSetting.PatrolSetting;
			AnimIdle = patrolSetting.AnimIdle;
			BSWalkFwd = patrolSetting.BSWalkFwd;
			BSWalkBwd = patrolSetting.BSWalkBwd;
			BSWalkLeft = patrolSetting.BSWalkLeft;
			BSWalkRight = patrolSetting.BSWalkRight;
			BSRunFwd = patrolSetting.BSRunFwd;
			BSRunBwd = patrolSetting.BSRunBwd;
			BSRunLeft = patrolSetting.BSRunLeft;
			BSRunRight = patrolSetting.BSRunRight;
		}
	}
}
