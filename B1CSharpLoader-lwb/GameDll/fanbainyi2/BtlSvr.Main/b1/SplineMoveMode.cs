using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class SplineMoveMode : ProjectileMoveModeBase
{
	private float Timer;

	private float Distance;

	public override void BeginMove()
	{
		base.BeginMove();
		LaunchVelocity(bForceSet: true);
		Timer = 0f;
		Distance = 0f;
		if (i_ObjActorMovementData.SplineCompPtr.IsValid())
		{
			USplineComponent uSplineComponent = i_ObjActorMovementData.SplineCompPtr.Get();
			uSplineComponent.Duration = i_ObjActorMovementData.FlyTime;
			FVector locationAtTime = uSplineComponent.GetLocationAtTime(0f, ESplineCoordinateSpace.World);
			BGUFuncLibActorTransformCS.BGUSetActorLocation(GetOwner(), locationAtTime, bSweep: false, bTeleport: false);
		}
	}

	public override void OnUpdate(float DeltaTime)
	{
		if (!bIsActive)
		{
			return;
		}
		if (!i_ObjActorMovementData.SplineCompPtr.IsValid())
		{
			KillSelf();
			return;
		}
		USplineComponent uSplineComponent = i_ObjActorMovementData.SplineCompPtr.Get();
		FVector fVector = default(FVector);
		FRotator fRotator = default(FRotator);
		switch (i_ObjActorMovementData.SpeedType)
		{
		case EProjectileObjSpdType.ByTime:
			if (i_ObjActorMovementData.TriggerLifeOver_SplineMoveEnd && Timer >= i_ObjActorMovementData.FlyTime)
			{
				KillSelf();
				break;
			}
			Timer += DeltaTime;
			fVector = uSplineComponent.GetLocationAtTime(Timer, ESplineCoordinateSpace.World);
			BGUFuncLibActorTransformCS.BGUSetActorLocation(GetOwner(), fVector, bSweep: false, bTeleport: false);
			if (i_ObjActorMovementData.RotAlignToSpline)
			{
				fRotator = uSplineComponent.GetRotationAtDistanceAlongSpline(Distance, ESplineCoordinateSpace.World);
				BGUFuncLibActorTransformCS.BGUSetActorRotation(GetOwner(), fRotator, bTeleportPhysics: false);
			}
			break;
		case EProjectileObjSpdType.Normal:
		{
			float splineLength = uSplineComponent.GetSplineLength();
			if (i_ObjActorMovementData.TriggerLifeOver_SplineMoveEnd && Distance >= splineLength)
			{
				KillSelf();
				break;
			}
			PendingSpdByType(DeltaTime);
			float scaledSpdValue = GetScaledSpdValue();
			Distance = MathLib.Clamp(Distance + scaledSpdValue * DeltaTime, 0f, splineLength);
			fVector = uSplineComponent.GetLocationAtDistanceAlongSpline(Distance, ESplineCoordinateSpace.World);
			BGUFuncLibActorTransformCS.BGUSetActorLocation(GetOwner(), fVector, bSweep: false, bTeleport: false);
			if (i_ObjActorMovementData.RotAlignToSpline)
			{
				fRotator = uSplineComponent.GetRotationAtDistanceAlongSpline(Distance, ESplineCoordinateSpace.World);
				BGUFuncLibActorTransformCS.BGUSetActorRotation(GetOwner(), fRotator, bTeleportPhysics: false);
			}
			break;
		}
		}
	}

	private void KillSelf()
	{
		bIsActive = false;
		FEffectInstReq EffectInstReq = default(FEffectInstReq);
		BE_Owner?.Evt_BulletTriggerEffectsByReson.Invoke(EBGUBulletTriggerEffectReason.LifeOver, ref EffectInstReq);
	}

	public override EBulletOrMagicFieldMoveModeType GetMoveMode()
	{
		return EBulletOrMagicFieldMoveModeType.SplineMoveMode;
	}
}
