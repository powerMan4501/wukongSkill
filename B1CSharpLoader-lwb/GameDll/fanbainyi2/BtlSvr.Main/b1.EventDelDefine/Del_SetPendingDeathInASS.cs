using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_SetPendingDeathInASS(AActor Killer = null, int StiffLevel = -1, int DmgID = -1, bool bIsSummon = false, FEffectInstReq EffectInstReq = default(FEffectInstReq));
