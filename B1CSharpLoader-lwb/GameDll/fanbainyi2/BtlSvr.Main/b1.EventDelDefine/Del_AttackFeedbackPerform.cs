using BtlB1;
using BtlShare;
using GUR.Runtime;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

[GSPredictable]
public delegate void Del_AttackFeedbackPerform(AActor Victim, ESkillDamageType SkillDamageType, EHitPerformFXEventType FinalHitPerformFXEventType, FEffectInstReq EffectInstReq, int CasterResID, int SkillEffectID, int HitPartID);
