using GUR.Runtime;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

[GSICBRemoveMod]
[GSPredictable]
public delegate void Del_TriggerFrozenBreak(in FEffectInstReq EffectInstReq, UAnimMontage FrozenBreakAM, bool bIsNormalStiff);
