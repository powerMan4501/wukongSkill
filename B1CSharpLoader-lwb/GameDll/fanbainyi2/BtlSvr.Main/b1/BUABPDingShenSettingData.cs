using UnrealEngine.Engine;

namespace b1;

public class BUABPDingShenSettingData : BUABPSettingDataBase
{
	public UAnimSequence AnimDingShenStart { get; private set; }

	public UAnimSequence AnimDingShenHold { get; private set; }

	public override void InitSettingData(in BGWDataAsset_AbpHumanoidSetting ABPSetting)
	{
		if (!(ABPSetting == null))
		{
			FAnimHumanoidSetting_DingShen dingShenSetting = ABPSetting.DingShenSetting;
			AnimDingShenStart = dingShenSetting.AnimDingShenStart;
			AnimDingShenHold = dingShenSetting.AnimDingShenHold;
		}
	}
}
