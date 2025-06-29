using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_OnSkillCostDmg(AActor Victim, int SkillID, int FinalDmg, bool bIsCrit = false);
