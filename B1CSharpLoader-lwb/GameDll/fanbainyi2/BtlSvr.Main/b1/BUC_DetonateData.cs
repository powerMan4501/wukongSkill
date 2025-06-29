using System.Collections.Generic;
using BtlB1;
using GSDispLib;

namespace b1;

public class BUC_DetonateData
{
	public List<FUStDelayPlayerGainConfig> DelayPlayerGainConfigList = new List<FUStDelayPlayerGainConfig>();

	public int DetonateBuff { get; set; }

	public float TriggerExplosiveRadius { get; set; }

	public string ExplosiveDBCPath { get; set; }

	public bool IsActived { get; set; }

	public BUC_DispLibDispBaseConfigDataAsset DBCConfig { get; set; }

	public List<BGUAdsortLevelConfigInfo> AdsortLevelConfigInfoList { get; set; } = new List<BGUAdsortLevelConfigInfo>();

	public void Init(FUStDetonateConfigDesc Desc)
	{
		DetonateBuff = Desc.BuffID;
		TriggerExplosiveRadius = Desc.Explosive;
		ExplosiveDBCPath = Desc.ExplosiveDBCPath;
		foreach (FUStExplosiveInfo adsortLevelDamage in Desc.AdsortLevelDamageList)
		{
			AdsortLevelConfigInfoList.Add(new BGUAdsortLevelConfigInfo(adsortLevelDamage.ExplosiveDamageBuff, adsortLevelDamage.ExplosiveRadius, adsortLevelDamage.ExplosiveLevel, adsortLevelDamage.PlayerGainBuff, adsortLevelDamage.PlayerGainRadius));
		}
		foreach (FUStDelayPlayerGainConfig item in Desc.DelayPlayerGainConfig)
		{
			DelayPlayerGainConfigList.Add(item);
		}
	}
}
