using UnrealEngine.Engine;

namespace b1;

public class BUABPGlideMove_EndSettingData
{
	public UAnimSequence ASGlideEndSlow { get; private set; }

	public UAnimSequence ASGlideEndFast { get; private set; }

	public BUABPGlideMove_EndSettingData(in FAnimHumanoidSetting_GlideMove_End Setting)
	{
		ASGlideEndSlow = Setting.ASGlideEndSlow;
		ASGlideEndFast = Setting.ASGlideEndFast;
	}
}
