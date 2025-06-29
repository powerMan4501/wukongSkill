using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_BGS_ProcessDeathInAnimationSync(AActor Host, Dictionary<int, UAnimMontage> DeathMontageList, float TotalDuration);
