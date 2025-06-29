using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_AITransformBySplineChange(float _RemainTime, ETransformBySplineRotateType _RotateType, in AActor _Target, in FGameplayTag SplineGuid, bool bShowDebug, in BAIT_Base _BAITRef, in BANS_GSBase _BANSRef);
