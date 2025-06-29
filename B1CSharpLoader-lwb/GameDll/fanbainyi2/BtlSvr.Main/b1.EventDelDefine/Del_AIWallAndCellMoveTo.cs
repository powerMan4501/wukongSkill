using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_AIWallAndCellMoveTo(FVector TargetLocation, EAIMoveSpeedType SpeedRateType, float TurnSpeed, float AcceptableRadius, bool IncludeSelfRadius);
