using System.Collections.Generic;
using System.Globalization;

namespace TestMod;

public class BossConfigData
{
	public static BossConfigData Instance { get; } = new BossConfigData();

	public List<BossConfig> BossConfigs { get; set; }

	private Dictionary<string, BossConfig> BossConfigDict { get; set; }

	public void LoadData()
	{
		BossConfigs = new List<BossConfig>();
		BossConfigDict = new Dictionary<string, BossConfig>();
		BossConfigs.AddRange(JsonResourceReader.LoadBossConfigs());
		foreach (BossConfig bossConfig in BossConfigs)
		{
			BossConfigDict.Add(bossConfig.BossUUID, bossConfig);
		}
		CompareInfo compareInfo = CultureInfo.GetCultureInfo("zh-CN").CompareInfo;
		BossConfigs.Sort((BossConfig x, BossConfig y) => compareInfo.Compare(x.BossName, y.BossName, CompareOptions.StringSort));
	}

	public string GetAssetPathByID(string id)
	{
		if (BossConfigDict.TryGetValue(id, out var value))
		{
			return value.AssetPath;
		}
		return "";
	}
}
