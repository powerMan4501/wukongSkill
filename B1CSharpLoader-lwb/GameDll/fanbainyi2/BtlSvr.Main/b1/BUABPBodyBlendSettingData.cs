using UnrealEngine.Engine;

namespace b1;

public class BUABPBodyBlendSettingData : BUABPSettingDataBase
{
	public UBlendSpace BSUpperBodyBlendAdditive { get; private set; }

	public override void InitSettingData(in BGWDataAsset_AbpHumanoidSetting ABPSetting)
	{
		if (!(ABPSetting == null))
		{
			BSUpperBodyBlendAdditive = ABPSetting.BodyBlendSetting.BSUpperBodyBlendAdditive;
		}
	}
}
