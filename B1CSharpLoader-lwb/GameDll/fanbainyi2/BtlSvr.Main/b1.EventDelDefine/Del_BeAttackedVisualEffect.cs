using BtlB1;
using BtlShare;
using GUR.Runtime;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

[GSPredictable]
public delegate void Del_BeAttackedVisualEffect(AActor Attacker, ESkillDamageType SkillDamageType, EHitPerformFXEventType ExtraAkCheck, FEffectInstReq HitReq, int SkillEffectID, int HitPartID, bool bCostDmg = true);
