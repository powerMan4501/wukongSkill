using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_SetHitCollisionUpdateInfo(string CollisionCompName, EHitMoveDir HitMoveDir, UCurveVector UpdateCurve, float TotalScaleTime, bool NeedUpdateScale, bool NeedUpdateRadius, bool NeedSetRelaLocForScale);
