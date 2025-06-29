using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_TriggerMagicFieldEffect(AActor Target, bool bIgnoreFilter, int TargetTeamFilter, int TargetTypeFilter, List<MFEffectForData> MFEffectList);
