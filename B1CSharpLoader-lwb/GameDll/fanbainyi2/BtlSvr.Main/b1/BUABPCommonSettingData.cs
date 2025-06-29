using UnrealEngine.Engine;

namespace b1;

public class BUABPCommonSettingData : BUABPSettingDataBase
{
	public bool bDisableABPMove { get; private set; }

	public EABPMoveMode ABPMoveMode { get; private set; }

	public UAnimSequence AnimSeqIdle { get; private set; }

	public UAnimSequence RetargetAnimSeqIdle { get; private set; }

	public bool bLockUseFreeMode { get; private set; }

	public float AnimTurnMinAngle { get; private set; }

	public UAnimSequence AnimTurnLeft90 { get; private set; }

	public UAnimSequence AnimTurnRight90 { get; private set; }

	public UAnimSequence AnimTurnLeft180 { get; private set; }

	public UAnimSequence AnimTurnRight180 { get; private set; }

	public override void InitSettingData(in BGWDataAsset_AbpHumanoidSetting ABPSetting)
	{
		if (!(ABPSetting == null))
		{
			FAnimHumanoidSetting_Common commonSetting = ABPSetting.CommonSetting;
			bDisableABPMove = commonSetting.bDisableABPMove;
			ABPMoveMode = commonSetting.ABPMoveMode;
			AnimSeqIdle = commonSetting.AnimSeqIdle;
			RetargetAnimSeqIdle = commonSetting.RetargetAnimSeqIdle;
			bLockUseFreeMode = commonSetting.bLockUseFreeMode;
			AnimTurnMinAngle = commonSetting.AnimTurnMinAngle;
			AnimTurnLeft90 = commonSetting.AnimTurnLeft90;
			AnimTurnRight90 = commonSetting.AnimTurnRight90;
			AnimTurnLeft180 = commonSetting.AnimTurnLeft180;
			AnimTurnRight180 = commonSetting.AnimTurnRight180;
		}
	}
}
