using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_FakeDeadForSkillDamage(AActor Attacker, int StiffLevel, UAnimMontage BeAttackedAM, in FEffectInstReq EffectInstReq, bool bIsDotDmg = false, EAbnormalStateType AbnormalType = EAbnormalStateType.None);
