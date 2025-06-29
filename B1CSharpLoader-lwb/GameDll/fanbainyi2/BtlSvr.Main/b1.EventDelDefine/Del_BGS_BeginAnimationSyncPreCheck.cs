using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_BGS_BeginAnimationSyncPreCheck(AActor Host, bool bForceSuccess, Dictionary<FName, float> DetectionConfig, FName JumpToSectionName, bool bEnableDebugDraw, UAnimMontage AnimationSyncMontage);
