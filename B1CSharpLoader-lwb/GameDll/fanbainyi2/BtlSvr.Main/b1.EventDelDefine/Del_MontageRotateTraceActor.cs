namespace b1.EventDelDefine;

public delegate void Del_MontageRotateTraceActor(UnitLockTargetInfo LockTargetInfo, float TurnSpeed, float RotateDeflectionAngle, float MaxRotateAngle, string TraceSocket = "", bool bIncludeAutoLockPoint = false, ERotateDirection RotateDirection = ERotateDirection.Auto, bool bStillRotateWhenAboveMaxRotateAngle = false, float DeadzoneAngle = 0f, bool EnableDebug = false);
