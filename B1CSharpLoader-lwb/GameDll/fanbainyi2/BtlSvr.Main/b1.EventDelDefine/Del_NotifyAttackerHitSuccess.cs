using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_NotifyAttackerHitSuccess(AActor VictimActor, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq, bool IsVictimDead);
