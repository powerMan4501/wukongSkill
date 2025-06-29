using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FBMMoveMode_BYMJ : ProjectileMoveModeBase
{
	private FVector CenterPos;

	private FVector SpawnPosition;

	private float Age;

	public float ObjNowSurRadius;

	public float CurAngle_Degree;

	public float StartHeightOffset;

	private float StartRadius;

	public FVector CircleSurroundStepPos;

	public override void BeginMove()
	{
		base.BeginMove();
		LaunchVelocity(bForceSet: true);
		StartHeightOffset = 0f;
		CenterPosUpdate();
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(base.Owner);
		StartRadius = FVector.Dist2D(fVector, CenterPos);
		ObjNowSurRadius = StartRadius;
		StartHeightOffset = fVector.Z - CenterPos.Z;
		float num = 0f;
		FVector2D fVector2D = fVector.Conv_VectorToVector2D() - CenterPos.Conv_VectorToVector2D();
		num = FMath.RadiansToDegrees(FMath.Acos(fVector2D.X / StartRadius));
		if (fVector2D.Y < 0f)
		{
			num *= -1f;
		}
		CurAngle_Degree = num;
		SpawnPosition = BGUFuncLibActorTransformCS.BGUGetActorLocation(base.Owner);
		Age = 0f;
	}

	public override void OnUpdate(float DeltaTime)
	{
		if (bIsActive)
		{
			PendingSpdByType(DeltaTime);
			FVector fVector = default(FVector);
			FVector upAxis = GetUpAxis();
			float value = FMath.DegreesToRadians(CurAngle_Degree);
			fVector = new FVector(ObjNowSurRadius * FMath.Cos(value), ObjNowSurRadius * FMath.Sin(value), i_ObjActorMovementData.CircleHeightOffset + StartHeightOffset);
			FVector fVector2 = CenterPos + fVector;
			float scaledSpdValue = GetScaledSpdValue();
			float num = 0f;
			switch (i_ObjActorMovementData.SpdType)
			{
			case ECircleSurround_SpdType.AngularVelocity:
				num = scaledSpdValue;
				break;
			case ECircleSurround_SpdType.LinearVelocity:
				num = FMath.RadiansToDegrees(scaledSpdValue / ObjNowSurRadius);
				break;
			}
			CurAngle_Degree += num * DeltaTime;
			bool bIsClockwise = num >= 0f;
			RotationUpdate(upAxis, bIsClockwise);
			FVector fBMOffset = GetFBMOffset(FBM_MoveConstraintType.SpawnPosLineToTargetPos);
			BGUFuncLibActorTransformCS.BGUSetActorLocation(base.Owner, fVector2 + fBMOffset, bSweep: false, bTeleport: false);
			Age += DeltaTime;
		}
	}

	private void CenterPosUpdate()
	{
		GetTargetPos(out CenterPos);
	}

	private void RotationUpdate(FVector UpDir, bool bIsClockwise = true)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		FRotator newRotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(owner);
		switch (i_ObjActorMovementData.RotType)
		{
		case ECircleSurround_RotType.LookAtMoveDir:
		{
			FVector safeNormal = UpDir.GetSafeNormal();
			FVector safeNormal2 = (BGUFuncLibActorTransformCS.BGUGetActorLocation(owner) - CenterPos).GetSafeNormal();
			newRotation = FVector.CrossProduct(safeNormal, safeNormal2).Conv_VectorToRotator();
			break;
		}
		case ECircleSurround_RotType.LookAtCenterPos:
			newRotation = MathLib.Conv_VectorToRotator(CenterPos - BGUFuncLibActorTransformCS.BGUGetActorLocation(owner));
			break;
		case ECircleSurround_RotType.LookAlignUpAxis:
			newRotation = MathLib.Conv_VectorToRotator(UpDir);
			break;
		case ECircleSurround_RotType.LookAtCurTarget_Master:
		{
			IBUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_MasterData, BUC_MasterData>(owner);
			if (readOnlyData != null)
			{
				UnitLockTargetInfo targetInfo = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(readOnlyData.GetMasterActor()).GetTargetInfo();
				if (targetInfo != null && targetInfo.LockTargetActor != null)
				{
					AActor lockTargetActor = targetInfo.LockTargetActor;
					newRotation = MathLib.Conv_VectorToRotator(BGUFuncLibActorTransformCS.BGUGetActorLocation(lockTargetActor) - BGUFuncLibActorTransformCS.BGUGetActorLocation(owner));
				}
			}
			break;
		}
		}
		BGUFuncLibActorTransformCS.BGUSetActorRotation(owner, newRotation, bTeleportPhysics: false);
	}

	private FVector GetUpAxis()
	{
		return FVector.UpVector;
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
		return EBulletOrMagicFieldMoveModeType.FbmBymjMoveMode;
	}
}
