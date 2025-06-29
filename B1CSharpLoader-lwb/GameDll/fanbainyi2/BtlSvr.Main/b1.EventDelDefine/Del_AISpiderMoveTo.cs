using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_AISpiderMoveTo(FVector TargetPos, FVector TargetNormal, ESpiderNavPositionType TargetPosType, float AcceptableRadius, EAIMoveSpeedType SplineMoveSpeed);
