using System.Collections.Generic;

namespace b1.EventDelDefine;

public delegate void Del_AICastBestComboSkill(UnitLockTargetInfo ComboTargetData, List<int> SkillIDList, bool IsFirstSkill, int CurComboSkillNum, int CurComboStage, bool IsGetTopRange, int TopPercent, bool EnableForceComboRelation, bool UseComboCondition, bool UsePursuitAnyWhere, bool NeedCheckSkillCanCast, bool CastFakeComboSkill, int LastCastSkillID);
