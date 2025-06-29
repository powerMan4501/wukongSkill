using UnrealEngine.Runtime;

namespace b1;

public class BUABPSettingData
{
	private BUABPCommonSettingData mCommonSettingData;

	private BUABPFootIKSettingData mFootIKSettingData;

	private BUABPMotionMatchingSettingData mMotionMatchingSettingData;

	private BUABPSimple4DirSettingData mSimple4DirSettingData;

	private BUABPPlayerLocomotionSettingData mPlayerLocomotionSettingData;

	private BUABPMonsterLocomotionSettingData mMonsterLocomotionSettingData;

	private BUABPAdvancedMonsterLocomotionSettingData mAdvancedMonsterLocomotionSettingData;

	private BUABPFlyControlSettingData mFlyControlSettingData;

	private BUABPAimOffsetSettingData mAimOffsetSettingData;

	private BUABPSpineIKSettingData mSpineIKSettingData;

	private BUABPDingShenSettingData mDingShenSettingData;

	private BUABPJumpSettingData mJumpSettingData;

	private BUABPPatrolSettingData mPatrolSettingData;

	private BUABPGlideMoveSettingData mGlideMoveSettingData;

	private BUABPParkourMoveSettingData mParkourMoveSettingData;

	private BUABPBodyBlendSettingData mBodyBlendSettingData;

	private BUABPCloudLocomotionSettingData mCloudLocomotionSettingData;

	private BUABPSpecialAdditiveSettingData mSpecialAdditiveSettingData;

	private BUABPWheelMoveSettingData mWheelMoveSettingData;

	private BUABPStriderMoveSettingData mStriderMoveSettingData;

	private BUABPQuadrupedLocomotionSettingData mQuadrupedLocomotionSettingData;

	public BUABPCommonSettingData CommonSetting => CacheAndGetSettingData(ref mCommonSettingData);

	public BUABPFootIKSettingData FootIKSetting => CacheAndGetSettingData(ref mFootIKSettingData);

	public BUABPMotionMatchingSettingData MotionMatchingSetting => CacheAndGetSettingData(ref mMotionMatchingSettingData);

	public BUABPSimple4DirSettingData Simple4DirSetting => CacheAndGetSettingData(ref mSimple4DirSettingData);

	public BUABPPlayerLocomotionSettingData PlayerLocomotionSetting => CacheAndGetSettingData(ref mPlayerLocomotionSettingData);

	public BUABPMonsterLocomotionSettingData MonsterLocomotionSetting => CacheAndGetSettingData(ref mMonsterLocomotionSettingData);

	public BUABPAdvancedMonsterLocomotionSettingData AdvancedMonsterLocomotionSetting => CacheAndGetSettingData(ref mAdvancedMonsterLocomotionSettingData);

	public BUABPFlyControlSettingData FlyControlSetting => CacheAndGetSettingData(ref mFlyControlSettingData);

	public BUABPAimOffsetSettingData AimOffsetSetting => CacheAndGetSettingData(ref mAimOffsetSettingData);

	public BUABPSpineIKSettingData SpineIKSetting => CacheAndGetSettingData(ref mSpineIKSettingData);

	public BUABPDingShenSettingData DingShenSetting => CacheAndGetSettingData(ref mDingShenSettingData);

	public BUABPJumpSettingData JumpSetting => CacheAndGetSettingData(ref mJumpSettingData);

	public BUABPPatrolSettingData PatrolSetting => CacheAndGetSettingData(ref mPatrolSettingData);

	public BUABPGlideMoveSettingData GlideMoveSetting => CacheAndGetSettingData(ref mGlideMoveSettingData);

	public BUABPParkourMoveSettingData ParkourMoveSetting => CacheAndGetSettingData(ref mParkourMoveSettingData);

	public BUABPBodyBlendSettingData BodyBlendSetting => CacheAndGetSettingData(ref mBodyBlendSettingData);

	public BUABPCloudLocomotionSettingData CloudLocomotionSetting => CacheAndGetSettingData(ref mCloudLocomotionSettingData);

	public BUABPSpecialAdditiveSettingData SpecialAdditiveSetting => CacheAndGetSettingData(ref mSpecialAdditiveSettingData);

	public BUABPWheelMoveSettingData WheelMoveSetting => CacheAndGetSettingData(ref mWheelMoveSettingData);

	public BUABPStriderMoveSettingData StriderMoveSetting => CacheAndGetSettingData(ref mStriderMoveSettingData);

	public BUABPQuadrupedLocomotionSettingData QuadrupedLocomotionSetting => CacheAndGetSettingData(ref mQuadrupedLocomotionSettingData);

	public string ABPSettingPath { get; private set; }

	private TStrongObjectPtr<BGWDataAsset_AbpHumanoidSetting> ABPSetting { get; set; } = new TStrongObjectPtr<BGWDataAsset_AbpHumanoidSetting>();

	public BUABPSettingData(in BGWDataAsset_AbpHumanoidSetting InABPSetting)
	{
		ABPSetting.Set(InABPSetting);
		ABPSettingPath = InABPSetting.GetPathName();
	}

	~BUABPSettingData()
	{
		ABPSetting.Dispose();
	}

	public void Clear()
	{
		ABPSetting.Set(null);
	}

	private T CacheAndGetSettingData<T>(ref T SettingData) where T : BUABPSettingDataBase, new()
	{
		if (SettingData == null)
		{
			SettingData = new T();
			T val = SettingData;
			val.InitSettingData(ABPSetting.Get());
		}
		return SettingData;
	}
}
