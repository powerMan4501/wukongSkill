using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_HitDestructible(AActor Attacker, EGSHitDestructibleStrengthLevel HitStrengthLevel, EGSHitDestructibleDirection HitDirectionType, FEffectInstReq EffectInstReq, float ImpulseStrength);
