using System.Collections.Generic;
using b1.ECS;

namespace b1;

public class BUC_IntimidateData : IBUC_IntimidateData, IPersistentECSData
{
	public float IntimidatingCDTimer;

	public float IntimidatedCDTimer;

	public int IntimidatingProbability { get; set; }

	public int IntimidatingMinStiffLevel { get; set; }

	public float IntimidatingCD { get; set; }

	public int IntimidatingRange { get; set; }

	public int IntimidatingInfluenceMaxNum { get; set; }

	public List<int> IntimidatedSkillList { get; set; }

	public int IntimidatedProbability { get; set; }

	public float IntimidatedCD { get; set; }

	public void SetGroupAIBPConfig(FIntimidateBPConfig IntimidateBPConfig)
	{
		IntimidatingProbability = IntimidateBPConfig.IntimidatingProbability;
		IntimidatingMinStiffLevel = IntimidateBPConfig.IntimidatingMinStiffLevel;
		IntimidatingCD = IntimidateBPConfig.IntimidatingCD;
		IntimidatingRange = IntimidateBPConfig.IntimidatingRange;
		IntimidatingInfluenceMaxNum = IntimidateBPConfig.IntimidatingInfluenceMaxNum;
		IntimidatedSkillList = IntimidateBPConfig.IntimidatedSkillList;
		IntimidatedProbability = IntimidateBPConfig.IntimidatedProbability;
		IntimidatedCD = IntimidateBPConfig.IntimidatedCD;
	}
}
