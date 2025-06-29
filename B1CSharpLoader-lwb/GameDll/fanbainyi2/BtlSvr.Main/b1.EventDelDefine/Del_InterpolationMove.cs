using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_InterpolationMove(FVector TargetLoc, FRotator TargetRot, float TotalTime, bool EnableZAxisMove, bool IgnoreLocation, bool IgnoreLocationRotation, bool ForceUpdate);
