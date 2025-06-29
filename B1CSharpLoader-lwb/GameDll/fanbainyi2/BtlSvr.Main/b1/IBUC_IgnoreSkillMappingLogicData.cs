using System.Collections.Generic;
using BtlShare;

namespace b1;

internal interface IBUC_IgnoreSkillMappingLogicData
{
	Dictionary<ESkillMappingConditionType, bool> IgnoredMappingTypeMap { get; }

	Dictionary<ESkillMappingResultRull, bool> IgnoredMappingResultRullMap { get; }

	Dictionary<ESkillMappingConditionType, bool> IgnoredMappingTypeRemoveMap { get; }

	Dictionary<ESkillMappingResultRull, bool> IgnoredMappingResultRullRemoveMap { get; }
}
