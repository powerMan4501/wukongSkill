using BtlShare;
using GUR.Runtime;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

[GSPredictable]
[GSICBRemoveMod]
public delegate void Del_NotifyTriggerBuffWhenConditionMet(EBuffEffectTriggerType TriggerType, in FEffectInstReq EffectInstReq = default(FEffectInstReq), AActor Victim = null);
