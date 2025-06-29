using System.Collections.Generic;

namespace b1.EventDelDefine;

public delegate void Del_AICastBestSkillByScore(List<FOneCBGCastSkillInfoCS> SkillInfoList, bool IsGetTopRandomSkill, int TopRandomSkillPercent, bool NeedTryCastAllSkillUntilSuccess);
