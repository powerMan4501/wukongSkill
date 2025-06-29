using System.Collections.Generic;
using BtlShare;

namespace b1;

internal class BUC_IgnoreSkillMappingLogicData : b1.IBUC_IgnoreSkillMappingLogicData
{
	public Dictionary<ESkillMappingConditionType, bool> IgnoredMappingTypeMap { get; set; } = new Dictionary<ESkillMappingConditionType, bool>();

	public Dictionary<ESkillMappingResultRull, bool> IgnoredMappingResultRullMap { get; set; } = new Dictionary<ESkillMappingResultRull, bool>();

	public Dictionary<ESkillMappingConditionType, bool> IgnoredMappingTypeRemoveMap { get; set; } = new Dictionary<ESkillMappingConditionType, bool>();

	public Dictionary<ESkillMappingResultRull, bool> IgnoredMappingResultRullRemoveMap { get; set; } = new Dictionary<ESkillMappingResultRull, bool>();
}
