using System.Collections.Generic;

namespace b1.EventDelDefine;

public delegate void Del_RequestSmartCastSkill(int ID, List<int> RuleIDList, EMontageBindReason Reason = EMontageBindReason.Default, bool bNeedCheckSkillCanCast = true, ECastSkillSourceType SourceType = ECastSkillSourceType.SmartCastSkill);
