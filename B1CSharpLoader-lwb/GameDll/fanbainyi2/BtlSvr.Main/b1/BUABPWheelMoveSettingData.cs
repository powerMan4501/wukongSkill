using UnrealEngine.Engine;

namespace b1;

public class BUABPWheelMoveSettingData : BUABPSettingDataBase
{
	public UCurveVector MoveNearParamCurve { get; private set; }

	public UCurveVector MoveFarParamCurve { get; private set; }

	public UAnimSequence ASIdle { get; private set; }

	public UAnimSequence ASSpeedUp { get; private set; }

	public UAnimSequence ASSpeedDown { get; private set; }

	public UAnimSequence ASMoveLoop { get; private set; }

	public UBlendSpace BSRotationAdditive { get; private set; }

	public override void InitSettingData(in BGWDataAsset_AbpHumanoidSetting ABPSetting)
	{
		if (!(ABPSetting == null))
		{
			FAnimWheelSetting_WheelMove wheelMoveSetting = ABPSetting.WheelMoveSetting;
			MoveNearParamCurve = wheelMoveSetting.MoveNearParamCurve;
			MoveFarParamCurve = wheelMoveSetting.MoveFarParamCurve;
			ASIdle = wheelMoveSetting.ASIdle;
			ASSpeedUp = wheelMoveSetting.ASSpeedUp;
			ASSpeedDown = wheelMoveSetting.ASSpeedDown;
			ASMoveLoop = wheelMoveSetting.ASMoveLoop;
			BSRotationAdditive = wheelMoveSetting.BSRotationAdditive;
		}
	}
}
