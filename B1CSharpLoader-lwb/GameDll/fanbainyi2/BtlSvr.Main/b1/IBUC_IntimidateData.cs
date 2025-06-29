using System.Collections.Generic;

namespace b1;

public interface IBUC_IntimidateData
{
	int IntimidatingProbability { get; }

	int IntimidatingMinStiffLevel { get; }

	float IntimidatingCD { get; }

	int IntimidatingRange { get; }

	int IntimidatingInfluenceMaxNum { get; }

	List<int> IntimidatedSkillList { get; }

	int IntimidatedProbability { get; }

	float IntimidatedCD { get; }
}
