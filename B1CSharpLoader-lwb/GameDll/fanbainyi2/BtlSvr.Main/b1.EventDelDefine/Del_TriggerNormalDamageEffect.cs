using GUR.Runtime;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

[GSPredictable]
[GSICBRemoveMod]
public delegate void Del_TriggerNormalDamageEffect(AActor Attacker, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq, in FBattleAttrSnapShot Attacker_AttrMemData);
