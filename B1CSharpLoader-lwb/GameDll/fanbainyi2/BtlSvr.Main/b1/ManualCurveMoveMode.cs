using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class ManualCurveMoveMode : ProjectileMoveModeBase
{
	public override void BeginMove()
	{
		base.BeginMove();
		LaunchVelocity(bForceSet: true);
		if (i_ObjActorMovementData == null || MasterData == null)
		{
			return;
		}
		AActor masterActor = MasterData.GetMasterActor();
		if (!(masterActor == null))
		{
			FVector fVector = default(FVector);
			AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(masterActor);
			if (aActor.IsNullOrDestroyed())
			{
				fVector = BGUFuncLibActorTransformCS.BGUGetActorForwardVector(masterActor).GetSafeNormal();
				i_ObjActorMovementData.OriDis = i_ObjActorMovementData.DefaultOriDis;
				i_ObjActorMovementData.OriTargetPos = new FVector(0.0, 0.0, 0.0);
			}
			else
			{
				fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor) - BGUFuncLibActorTransformCS.BGUGetActorLocation(BulletItSelf.Get());
				i_ObjActorMovementData.OriDis = fVector.Size();
				i_ObjActorMovementData.OriTargetPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor);
			}
			i_ObjActorMovementData.TargetVector = fVector.GetSafeNormal();
			i_ObjActorMovementData.BulletOriPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(BulletItSelf.Get());
			i_ObjActorMovementData.LastBulletPos = i_ObjActorMovementData.BulletOriPos;
		}
	}

	public override void OnUpdate(float DeltaTime)
	{
		UCurveVector manualMoveCurve = i_ObjActorMovementData.ManualMoveCurve;
		float num = 0f;
		num = ((!i_ObjActorMovementData.ByTimeOrDis) ? (i_ObjActorMovementData.CurDis / i_ObjActorMovementData.OriDis * i_ObjActorMovementData.MaxCurveLen) : i_ObjActorMovementData.ManualMoveCurveTimer);
		FVector vectorValue = manualMoveCurve.GetVectorValue(num);
		float num2 = vectorValue.X * 100f;
		float degVal = vectorValue.Y * 180f;
		float num3 = vectorValue.Z * 100f;
		i_ObjActorMovementData.BulletOriPos += i_ObjActorMovementData.TargetVector * num2 * DeltaTime;
		FVector safeNormal = MathLib.ProjectPointontoPlane(new FVector(new FVector(0.0, 0.0, 1.0)), new FVector(0.0, 0.0, 0.0), i_ObjActorMovementData.TargetVector).GetSafeNormal();
		FRotator rotation = MathLib.MakeRotFromXZ(i_ObjActorMovementData.TargetVector, safeNormal);
		FTransform t = new FTransform(rotation, i_ObjActorMovementData.BulletOriPos);
		FVector location = new FVector(0.0, FMath.Sin(MathLib.DegreesToRadians(degVal)), FMath.Cos(MathLib.DegreesToRadians(degVal))) * num3;
		FVector newLocation = MathLib.TransformLocation(t, location);
		BGUFuncLibActorTransformCS.BGUSetActorLocation(BulletItSelf.Get(), newLocation, bSweep: false, bTeleport: true);
		if (i_ObjActorMovementData.IsFaceTarget)
		{
			if (!i_ObjActorMovementData.OriTargetPos.IsZero())
			{
				BGUFuncLibActorTransformCS.BGUSetActorRotation(BulletItSelf.Get(), MathLib.MakeRotFromX(i_ObjActorMovementData.OriTargetPos - BGUFuncLibActorTransformCS.BGUGetActorLocation(BulletItSelf.Get())), bTeleportPhysics: false);
			}
		}
		else
		{
			BGUFuncLibActorTransformCS.BGUSetActorRotation(BulletItSelf.Get(), MathLib.MakeRotFromX(BGUFuncLibActorTransformCS.BGUGetActorLocation(BulletItSelf.Get()) - i_ObjActorMovementData.LastBulletPos), bTeleportPhysics: false);
			i_ObjActorMovementData.LastBulletPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(BulletItSelf.Get());
		}
		i_ObjActorMovementData.ManualMoveCurveTimer += DeltaTime;
		i_ObjActorMovementData.CurDis += num2 * DeltaTime;
	}
}
