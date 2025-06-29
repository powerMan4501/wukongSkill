using UnrealEngine.Engine;

namespace b1;

public class BUABPGlideMoveSettingData : BUABPSettingDataBase
{
	public bool bEnableGlideAnim { get; private set; }

	public UCurveVector MoveParamCurve { get; private set; }

	public BUABPGlideMove_StartSettingData Start { get; private set; }

	public BUABPGlideMove_LoopSettingData Loop { get; private set; }

	public BUABPGlideMove_EndSettingData End { get; private set; }

	public override void InitSettingData(in BGWDataAsset_AbpHumanoidSetting ABPSetting)
	{
		if (!(ABPSetting == null))
		{
			FAnimHumanoidSetting_GlideMove glideMoveSetting = ABPSetting.GlideMoveSetting;
			bEnableGlideAnim = glideMoveSetting.bEnableGlideAnim;
			MoveParamCurve = glideMoveSetting.MoveParamCurve;
			Start = new BUABPGlideMove_StartSettingData(in glideMoveSetting.Start);
			Loop = new BUABPGlideMove_LoopSettingData(in glideMoveSetting.Loop);
			End = new BUABPGlideMove_EndSettingData(in glideMoveSetting.End);
		}
	}
}
