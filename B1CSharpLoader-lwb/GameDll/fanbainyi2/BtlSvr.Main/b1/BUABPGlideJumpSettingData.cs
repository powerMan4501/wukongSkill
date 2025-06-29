using UnrealEngine.Engine;

namespace b1;

public class BUABPGlideJumpSettingData
{
	public UAnimSequence ASGlideJumpStart { get; private set; }

	public BUABPGlideJumpSettingData(in FAnimHumanoidSetting_GlideJump Setting)
	{
		ASGlideJumpStart = Setting.ASGlideJumpStart;
	}
}
