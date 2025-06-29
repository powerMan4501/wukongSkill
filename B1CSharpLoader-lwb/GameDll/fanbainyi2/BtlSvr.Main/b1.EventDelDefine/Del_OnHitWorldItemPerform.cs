using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_OnHitWorldItemPerform(UObject World, int NotifyInstID, float SweepProtectGap, List<int> SkillEffectIDList, FVector PrePosition, FVector CurPosition, ref FEffectInstReq EffectInstReq);
