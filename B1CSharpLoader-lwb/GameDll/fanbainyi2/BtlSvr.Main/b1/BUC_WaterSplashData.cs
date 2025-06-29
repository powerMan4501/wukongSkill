using System.Collections.Generic;

namespace b1;

internal class BUC_WaterSplashData
{
	public int bFlag_BindSkillBreak;

	public BGWDataAsset_WaterSplashMapping WaterSplashConfig;

	public Dictionary<string, FWaterSplashSweepConfig> SweepConfigDic;

	public BUC_WaterSplashData()
	{
		SweepConfigDic = new Dictionary<string, FWaterSplashSweepConfig>();
	}

	public void CopyBPDataToData(BGWDataAsset_WaterSplashMapping _WaterSplashConfig)
	{
		WaterSplashConfig = _WaterSplashConfig;
	}
}
