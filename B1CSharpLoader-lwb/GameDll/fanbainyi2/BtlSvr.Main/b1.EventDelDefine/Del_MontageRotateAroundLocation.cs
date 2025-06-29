using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_MontageRotateAroundLocation(FVector TargetPos, float TurnSpeed, float RotateDeflectionAngle, float MaxRotateAngle, ERotateDirection RotateDirection = ERotateDirection.Auto, bool bStillRotateWhenAboveMaxRotateAngle = false, float DeadzoneAngle = 0f, bool EnableDebug = false);
