using GUR.Runtime;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

[GSPredictable]
[GSICBRemoveMod]
public delegate void Del_TriggerSkillEffect(int EffectID, FEffectInstReq EffectInstReq, AActor InnerTarget = null, bool bWithRPCEvent = true);
