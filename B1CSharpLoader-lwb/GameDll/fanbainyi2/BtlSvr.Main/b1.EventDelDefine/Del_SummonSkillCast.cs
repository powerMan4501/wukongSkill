using GUR.Runtime;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

[GSPredictable]
[GSICBRemoveMod]
public delegate void Del_SummonSkillCast(int SummonID, int SummonPointIndex, AActor EffectCaster, in FEffectInstReq EffectInstReq, bool TeleportSelf = false, AActor SelectPointActor = null);
