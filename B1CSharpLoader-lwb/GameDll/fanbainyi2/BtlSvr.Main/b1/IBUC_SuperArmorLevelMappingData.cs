using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public interface IBUC_SuperArmorLevelMappingData
{
	Dictionary<string, List<GSSuperArmorMappingTargetInfo>> SuperArmorLevelMapping { get; }

	float GetSuperArmorLevelValue(string SuperArmorLevelName, string BlameInfo, string ToBlame, AActor Caster);

	float GetSuperArmorValue(float SuperArmorValue, string BlameInfo, string ToBlame);
}
