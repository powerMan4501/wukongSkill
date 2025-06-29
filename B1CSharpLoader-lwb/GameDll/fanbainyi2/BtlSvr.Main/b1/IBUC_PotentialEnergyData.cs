using System.Collections.Generic;
using GUR.Runtime;
using UnrealEngine.Engine;

namespace b1;

[NeedToUI]
public interface IBUC_PotentialEnergyData
{
	int CurPELevel { get; }

	float PELimit_Normal { get; }

	float PELimit_ByChargeSkill { get; }

	Dictionary<int, PotentialEnergyLevelDetail> LevelMap { get; }

	BGWDataAsset_PELevelConfig Default_Config { get; }

	int GetCurPELevel(AActor Owner);
}
