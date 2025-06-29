using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class CircleSurroundMoveMode : ProjectileMoveModeBase
{
	public float ObjNowSurRadius;

	public float CurAngle_Degree;

	public FName CircleCenterSocket;

	public float StartHeightOffset;

	public FVector CenterPos;

	private float StartRadius;

	private float SelfRotTimer;

	public override void BeginMove()
	{
		base.BeginMove();
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		LaunchVelocity(bForceSet: true);
		BUC_ProjectileBasicData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ProjectileBasicData>(owner);
		if (readOnlyData != null)
		{
			CircleCenterSocket = readOnlyData.SpawnPointName;
		}
		StartHeightOffset = 0f;
		CenterPosUpdate();
		if (i_ObjActorMovementData.RadiusType == ECircleSurround_RadiusType.Normal)
		{
			ObjNowSurRadius = i_ObjActorMovementData.StaticRadius;
			float curAngle_Degree = 360f / (float)i_ObjActorMovementData.TotalNumInAWave * (float)i_ObjActorMovementData.SelfIndexInAWave;
			CurAngle_Degree = curAngle_Degree;
		}
		else if (i_ObjActorMovementData.RadiusType == ECircleSurround_RadiusType.DistToCenter)
		{
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(owner);
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
		}
		SelfRotTimer = 0f;
	}

	public override void OnUpdate(float DeltaTime)
	{
		if (!bIsActive)
		{
			return;
		}
		AActor owner = GetOwner();
		if (!(owner == null))
		{
			CenterPosUpdate();
			PendingSpdByType(DeltaTime);
			RadiusUpdate();
			FVector fVector = default(FVector);
			FVector upAxis = GetUpAxis();
			float value = MathLib.DegreesToRadians(CurAngle_Degree);
			fVector = new FVector(ObjNowSurRadius * FMath.Cos(value), ObjNowSurRadius * FMath.Sin(value), i_ObjActorMovementData.CircleHeightOffset + StartHeightOffset);
			FVector newLocation = CenterPos + fVector;
			BGUFuncLibActorTransformCS.BGUSetActorLocation(owner, newLocation, bSweep: false, bTeleport: true);
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
			RotationUpdate(upAxis, DeltaTime, bIsClockwise);
		}
	}

	private void RadiusUpdate()
	{
		if (!(i_ObjActorMovementData.RadiusCurve == null))
		{
			ObjNowSurRadius = i_ObjActorMovementData.RadiusCurve.GetFloatValue(i_ObjActorMovementData.RadiusSurCurveTimer);
		}
	}

	private void CenterPosUpdate()
	{
		GetTargetPos(out CenterPos);
	}

	private void RotationUpdate(FVector UpDir, float DeltaTime, bool bIsClockwise = true)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		SelfRotTimer += DeltaTime;
		FRotator Target = BGUFuncLibActorTransformCS.BGUGetActorRotation(owner);
		switch (i_ObjActorMovementData.RotType)
		{
		case ECircleSurround_RotType.LookAtMoveDir:
		{
			FVector safeNormal = UpDir.GetSafeNormal();
			FVector safeNormal2 = (BGUFuncLibActorTransformCS.BGUGetActorLocation(owner) - CenterPos).GetSafeNormal();
			Target = FVector.CrossProduct(safeNormal, safeNormal2).Conv_VectorToRotator();
			break;
		}
		case ECircleSurround_RotType.LookAtCenterPos:
			Target = MathLib.Conv_VectorToRotator(CenterPos - BGUFuncLibActorTransformCS.BGUGetActorLocation(owner));
			break;
		case ECircleSurround_RotType.LookAlignUpAxis:
			Target = MathLib.Conv_VectorToRotator(UpDir);
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
					Target = MathLib.Conv_VectorToRotator(BGUFuncLibActorTransformCS.BGUGetActorLocation(lockTargetActor) - BGUFuncLibActorTransformCS.BGUGetActorLocation(owner));
				}
			}
			break;
		}
		}
		float interpSpeed = 360f;
		if (i_ObjActorMovementData.SelfRotCurve != null)
		{
			interpSpeed = i_ObjActorMovementData.SelfRotCurve.GetFloatValue(SelfRotTimer);
		}
		Target = MathLib.RInterpConstantTo(BGUFuncLibActorTransformCS.BGUGetActorRotation(owner), in Target, DeltaTime, interpSpeed);
		BGUFuncLibActorTransformCS.BGUSetActorRotation(owner, Target, bTeleportPhysics: false);
	}

	private FVector GetUpAxis()
	{
		FVector upVector = FVector.UpVector;
		if (i_ObjActorMovementData.UpAxisType == ECircleSurround_UpAxisType.Normal)
		{
			upVector = FVector.UpVector;
		}
		return upVector;
	}

	public override EBulletOrMagicFieldMoveModeType GetMoveMode()
	{
		return EBulletOrMagicFieldMoveModeType.CircleSurroundMoveMode;
	}
}
