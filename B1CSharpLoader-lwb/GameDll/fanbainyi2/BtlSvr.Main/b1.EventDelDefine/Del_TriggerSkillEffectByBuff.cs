using GUR.Runtime;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

[GSPredictable]
[GSICBRemoveMod]
public delegate void Del_TriggerSkillEffectByBuff(int BuffID, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical);
