using BtlShare;
using GUR.Runtime;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

[GSPredictable]
[GSICBRemoveMod]
public delegate void Del_UnitDead(AActor Attacker, EDeadReason DeadReason, int DmgID = -1, int StiffLevel = -1, UAnimMontage BeAttackedAM = null, FEffectInstReq EffectInstReq = default(FEffectInstReq), bool bIsDotDmg = false, EAbnormalStateType AbnormalStateType = EAbnormalStateType.None);
