using System.Collections.Generic;
using GUR.Runtime;

namespace b1.EventDelDefine;

[GSPredictable]
public delegate void Del_SmartCastSkillTry(int ID, List<int> RuleIDList, EMontageBindReason Reason = EMontageBindReason.Default, ESkillDirection SkillDirection = ESkillDirection.None, bool bNeedCheckSkillCanCast = true, ECastSkillSourceType SourceType = ECastSkillSourceType.SmartCastSkill);
