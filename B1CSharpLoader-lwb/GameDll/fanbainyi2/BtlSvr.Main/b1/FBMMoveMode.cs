using BtlShare;
using UnrealEngine.Runtime;

namespace b1;

public class FBMMoveMode : ProjectileMoveModeBase
{
	private FVector CenterPos;

	private FVector SpawnPosition;

	private float Age;

	public override void BeginMove()
	{
		base.BeginMove();
		LaunchVelocity(bForceSet: true);
		GetTargetPos(out CenterPos);
		SpawnPosition = BGUFuncLibActorTransformCS.BGUGetActorLocation(base.Owner);
		Age = 0f;
	}

	public override void OnUpdate(float DeltaTime)
	{
		base.OnUpdate(DeltaTime);
		if (bIsActive)
		{
			FVector fBMOffset = GetFBMOffset(FBM_MoveConstraintType.SpawnPosLineToTargetPos);
			BGUFuncLibActorTransformCS.BGUSetActorLocation(base.Owner, SpawnPosition + fBMOffset, bSweep: false, bTeleport: false);
			Age += DeltaTime;
		}
	}

	public FVector GetFBMOffset(FBM_MoveConstraintType _MoveConstraintType)
	{
		FVector result = FVector.ZeroVector;
		switch (_MoveConstraintType)
		{
		case FBM_MoveConstraintType.SpawnPosLineToTargetPos:
		{
			FVector safeNormal = (SpawnPosition - CenterPos).GetSafeNormal();
			result = PerlinNoise.Fbm(SpawnPosition.X, SpawnPosition.Y, Age * i_ObjActorMovementData.SpdScale_FBM, i_ObjActorMovementData.FractalLevel_FBM) * safeNormal * i_ObjActorMovementData.MotionRadius_FBM;
			break;
		}
		case FBM_MoveConstraintType.XYZRandom:
		{
			float num = PerlinNoise.Fbm(SpawnPosition.X + Age * i_ObjActorMovementData.SpdScale_FBM, i_ObjActorMovementData.FractalLevel_FBM);
			float num2 = PerlinNoise.Fbm(SpawnPosition.Y + Age * i_ObjActorMovementData.SpdScale_FBM, i_ObjActorMovementData.FractalLevel_FBM);
			float num3 = PerlinNoise.Fbm(SpawnPosition.Z + Age * i_ObjActorMovementData.SpdScale_FBM, i_ObjActorMovementData.FractalLevel_FBM);
			result = new FVector(num, num2, num3) * i_ObjActorMovementData.MotionRadius_FBM;
			break;
		}
		}
		return result;
	}

	public override EBulletOrMagicFieldMoveModeType GetMoveMode()
	{
		return EBulletOrMagicFieldMoveModeType.FbmMoveMode;
	}
}
