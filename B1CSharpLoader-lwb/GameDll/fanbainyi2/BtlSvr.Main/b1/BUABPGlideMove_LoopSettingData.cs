using UnrealEngine.Engine;

namespace b1;

public class BUABPGlideMove_LoopSettingData
{
	public UAnimSequence ASGlideLoopSteep { get; private set; }

	public UBlendSpace BSGlideLoopSteepAdditive { get; private set; }

	public UAnimSequence ASGlideLoopFlatSlow { get; private set; }

	public UAnimSequence ASGlideLoopFlatFast { get; private set; }

	public UBlendSpace BSGlideLoopFlatSlowDirAdditive { get; private set; }

	public UBlendSpace BSGlideLoopFlatFastDirAdditive { get; private set; }

	public UBlendSpace BSGlideLoopFlatVerticalInputAdditive { get; private set; }

	public UBlendSpace BSGlideLoopFlatHorizonalInputAdditive { get; private set; }

	public UAnimSequence ASGlideLoopFlatRotationLeftAdditive { get; private set; }

	public UAnimSequence ASGlideLoopFlatRotationRightAdditive { get; private set; }

	public BUABPGlideMove_LoopSettingData(in FAnimHumanoidSetting_GlideMove_Loop Setting)
	{
		ASGlideLoopSteep = Setting.ASGlideLoopSteep;
		BSGlideLoopSteepAdditive = Setting.BSGlideLoopSteepAdditive;
		ASGlideLoopFlatSlow = Setting.ASGlideLoopFlatSlow;
		ASGlideLoopFlatFast = Setting.ASGlideLoopFlatFast;
		BSGlideLoopFlatSlowDirAdditive = Setting.BSGlideLoopFlatSlowDirAdditive;
		BSGlideLoopFlatFastDirAdditive = Setting.BSGlideLoopFlatFastDirAdditive;
		BSGlideLoopFlatVerticalInputAdditive = Setting.BSGlideLoopFlatVerticalInputAdditive;
		BSGlideLoopFlatHorizonalInputAdditive = Setting.BSGlideLoopFlatHorizonalInputAdditive;
		ASGlideLoopFlatRotationLeftAdditive = Setting.ASGlideLoopFlatRotationLeftAdditive;
		ASGlideLoopFlatRotationRightAdditive = Setting.ASGlideLoopFlatRotationRightAdditive;
	}
}
