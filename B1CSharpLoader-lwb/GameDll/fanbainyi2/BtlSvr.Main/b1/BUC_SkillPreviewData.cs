using System.Collections.Generic;

namespace b1;

public class BUC_SkillPreviewData
{
	public bool LowDensityTestOver;

	public bool ZBBTestOver;

	public bool ZBBConfigSaveOver;

	public int CurSpawnIdx;

	public float CurSkillStartTime;

	public List<UnitZBBInfo> AllZBBInfos;

	public List<UnitZBBInfo> LowerDensityZBBInfos;

	public Dictionary<int, List<UnitZBBInfo>> ZBBInfos;

	public OneZBBConfig ZBBDataForXml;

	public BUC_SkillPreviewData()
	{
		ZBBTestOver = false;
		ZBBConfigSaveOver = false;
		CurSpawnIdx = 0;
		CurSkillStartTime = 0f;
		AllZBBInfos = new List<UnitZBBInfo>();
		LowerDensityZBBInfos = new List<UnitZBBInfo>();
		ZBBInfos = new Dictionary<int, List<UnitZBBInfo>>();
		ZBBDataForXml = default(OneZBBConfig);
	}
}
