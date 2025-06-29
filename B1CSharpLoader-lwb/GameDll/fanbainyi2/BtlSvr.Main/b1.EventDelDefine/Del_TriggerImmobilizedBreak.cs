using GUR.Runtime;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

[GSPredictable]
[GSICBRemoveMod]
public delegate void Del_TriggerImmobilizedBreak(AActor Attacker, int StiffLevel, in FEffectInstReq EffectInstReq, UAnimMontage BreakImmobilizeAM, bool bIsNormalStiff);
