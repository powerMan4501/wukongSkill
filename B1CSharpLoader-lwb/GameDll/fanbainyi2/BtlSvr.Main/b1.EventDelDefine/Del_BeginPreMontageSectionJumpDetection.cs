using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_BeginPreMontageSectionJumpDetection(MontageSectionJumpType SectionJumpType, EBGUSimpleState IgnoreSimpleState, Dictionary<FName, float> DetectionConfig, float DetectionDuration, EChangeTargetType OverlayDetectTargetType = EChangeTargetType.None, bool bEnableDebugDraw = false);
