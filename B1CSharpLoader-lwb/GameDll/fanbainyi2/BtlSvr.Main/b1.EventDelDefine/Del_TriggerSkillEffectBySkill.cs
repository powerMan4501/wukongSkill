using GUR.Runtime;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

[GSPredictable]
[GSICBRemoveMod]
public delegate void Del_TriggerSkillEffectBySkill(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq);
