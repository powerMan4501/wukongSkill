using UnrealEngine.Engine;

namespace b1;

public class BUABPMonsterLocomotion_FreeSettingData
{
	public UAnimSequence ASFreeRunFwd { get; private set; }

	public UAnimSequence ASFreeRunStartFwd { get; private set; }

	public UAnimSequence ASFreeRunStartFR { get; private set; }

	public UAnimSequence ASFreeRunStartBR { get; private set; }

	public UAnimSequence ASFreeRunStartFL { get; private set; }

	public UAnimSequence ASFreeRunStartBL { get; private set; }

	public UBlendSpace BSFreeLeanAdditive { get; private set; }

	public UBlendSpace BSFreeRotAdditive { get; private set; }

	public UAnimSequence ASFreeRunStopLeftFoot { get; private set; }

	public UAnimSequence ASFreeRunStopRightFoot { get; private set; }

	public BUABPMonsterLocomotion_FreeSettingData(in FAnimHumanoidSetting_MonsterLocomotion_Free Setting)
	{
		ASFreeRunFwd = Setting.ASFreeRunFwd;
		ASFreeRunStartFwd = Setting.ASFreeRunStartFwd;
		ASFreeRunStartFR = Setting.ASFreeRunStartFR;
		ASFreeRunStartBR = Setting.ASFreeRunStartBR;
		ASFreeRunStartFL = Setting.ASFreeRunStartFL;
		ASFreeRunStartBL = Setting.ASFreeRunStartBL;
		BSFreeLeanAdditive = Setting.BSFreeLeanAdditive;
		BSFreeRotAdditive = Setting.BSFreeRotAdditive;
		ASFreeRunStopLeftFoot = Setting.ASFreeRunStopLeftFoot;
		ASFreeRunStopRightFoot = Setting.ASFreeRunStopRightFoot;
	}
}
