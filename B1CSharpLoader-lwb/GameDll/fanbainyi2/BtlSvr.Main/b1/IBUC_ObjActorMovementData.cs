using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_ObjActorMovementData
{
	FVector CurVelocity { get; }

	EBulletOrMagicFieldMoveModeType MoveMode { get; }

	bool UseSimpleMove { get; }

	EProjectileObjSpdType SpeedType { get; }

	float SpdScaleValue { get; }

	int TotalNumInAWave { get; }

	int SelfIndexInAWave { get; }

	AActor TargetActor { get; }

	bool bUseSocket_Target { get; }

	string TargetSocketName { get; }

	bool UseRangeTargetOffset { get; }

	FVector TargetPos { get; }

	FGSTargetOffsetInfo TargetOffsetInfo { get; }

	bool UseSocketAsNest { get; }

	FName NestName { get; }

	float RadiusSurCurveTimer { get; }

	UCurveFloat RadiusCurve { get; }

	float StaticRadius { get; }

	float CircleHeightOffset { get; }

	UCurveFloat SelfRotCurve { get; }

	ECircleSurround_CenterType CenterType { get; }

	ECircleSurround_RadiusType RadiusType { get; }

	ECircleSurround_UpAxisType UpAxisType { get; }

	ECircleSurround_SpdType SpdType { get; }

	ECircleSurround_RotType RotType { get; }

	float FlyTime { get; }

	FSpawnBulletSpeed BulletFlySpd { get; set; }

	FSpawnBulletSpeed BulletRotSpd { get; set; }

	float ProjectileFlySpdCurveTimer { get; }

	float ProjectileRotSpdCurveTimer { get; }

	bool TraceOverTriggerLifeOverEffect { get; }

	bool TraceOverSwitchToStraightMode { get; }

	EBGUBulletTraceType TraceType { get; }

	float TraceTime { get; }

	bool CloseZTrace { get; }

	float BulletNowRotSpd { get; }

	EInertialState InertialState { get; }

	float InertialTraceTime { get; }

	float InertialDecreaseTime { get; }

	float InertialAdjustTransTime { get; }

	UCurveFloat InertialRotSpdCurve { get; }

	UCurveFloat InertialTraceSpdCurve { get; }

	float InertialTraceRadius { get; }

	UCurveVector ManualMoveCurve { get; }

	FVector TargetVector { get; set; }

	FVector BulletOriPos { get; set; }

	float ManualMoveCurveTimer { get; set; }

	bool ByTimeOrDis { get; }

	float MaxCurveLen { get; }

	float CurDis { get; set; }

	float OriDis { get; set; }

	float DefaultOriDis { get; set; }

	FVector LastBulletPos { get; set; }

	FVector OriTargetPos { get; set; }

	bool IsFaceTarget { get; }

	float Top_X { get; }

	float Top_Y { get; }

	float TargetShortestDist_Hor { get; }

	float TargetFurthestDist_Hor { get; }

	TWeakObject<USplineComponent> SplineCompPtr { get; }

	bool TriggerLifeOver_SplineMoveEnd { get; }

	bool RotAlignToSpline { get; }

	FBM_MoveConstraintType MoveConstraintType_FBM { get; }

	float MotionRadius_FBM { get; }

	int FractalLevel_FBM { get; }

	float SpdScale_FBM { get; }

	void InitBulletNowRotSpd();

	void UpdateRotSpd(float DeltaTime);
}
