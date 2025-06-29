using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGU_StandAndRotateMoveMode : BUC_MoveModeBase
{
	private TWeakObject<AActor> mTargetActor;

	private float RotateSpeed;

	private FVector TargetPos;

	private bool bUseTurnAnim;

	private AActor TargetActor
	{
		get
		{
			return mTargetActor.Get();
		}
		set
		{
			mTargetActor.Set(value);
		}
	}

	public void BeginRotateToTarget(float RotateSpd, AActor RotateTargetActor)
	{
		TargetActor = RotateTargetActor;
		RotateSpeed = RotateSpd;
		TargetPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(TargetActor);
		CheckNeedUseTurnAnim();
	}

	public void BeginRotateToPos(float RotateSpd, FVector RotateTargetPos)
	{
		TargetActor = null;
		RotateSpeed = RotateSpd;
		TargetPos = RotateTargetPos;
		CheckNeedUseTurnAnim();
	}

	private void CheckNeedUseTurnAnim()
	{
		if (MoveSys.AnimHumanoidHelperData.ABPSettingData == null)
		{
			bUseTurnAnim = false;
			return;
		}
		float value = FRotator.NormalizeAxis(MathLib.FindLookAtRotation(BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter), TargetPos).Yaw - BGUFuncLibActorTransformCS.BGUGetActorRotation(OwnerCharacter).Yaw);
		bUseTurnAnim = FMath.Abs(value) > MoveSys.AnimHumanoidHelperData.ABPSettingData.CommonSetting.AnimTurnMinAngle;
	}

	public override void Init(BUS_MovementSystem Parent)
	{
		base.Init(Parent);
	}

	protected override void OnUpdate(float DeltaTime)
	{
		if (GetUnitStateData().HasState(EBGUUnitState.Beatback) || GetUnitStateData().HasState(EBGUUnitState.Dead))
		{
			return;
		}
		FRotator Current = BGUFuncLibActorTransformCS.BGUGetActorRotation(OwnerCharacter);
		FRotator Target;
		FRotator newRotation;
		if (bUseTurnAnim)
		{
			Target = (TargetPos - BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter)).Rotation();
			newRotation = MoveSys.BasicData.GetStandRotationTarget(MoveSys.ChrData, MoveSys.AnimHumanoidHelperData, DeltaTime);
		}
		else
		{
			FVector fVector = TargetPos;
			if (TargetActor != null)
			{
				fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(TargetActor);
			}
			FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter);
			FVector actorForwardVector = OwnerCharacter.GetActorForwardVector();
			Target = Current;
			FVector2D unitRotateAimDir = new FVector2D(actorForwardVector.X, actorForwardVector.Y);
			FVector2D unit2TargetDir = new FVector2D(fVector.X - fVector2.X, fVector.Y - fVector2.Y);
			float rotateAngle2D = BGU_MoveUtil.GetRotateAngle2D(unitRotateAimDir, unit2TargetDir);
			if (BGU_MoveUtil.IsRotateClockwise(unitRotateAimDir, unit2TargetDir))
			{
				Target.Yaw = UMathLibrary.NormalizeAxis(Target.Yaw + rotateAngle2D);
			}
			else
			{
				Target.Yaw = UMathLibrary.NormalizeAxis(Target.Yaw - rotateAngle2D);
			}
			newRotation = Target;
			if (RotateSpeed > 0f)
			{
				newRotation = MathLib.RInterpConstantTo(in Current, in Target, DeltaTime, RotateSpeed);
			}
		}
		newRotation.Pitch = Current.Pitch;
		newRotation.Roll = Current.Roll;
		BGUFuncLibActorTransformCS.BGUSetActorRotation(OwnerCharacter, newRotation, bTeleportPhysics: false);
		if (MathLib.IsNearlyEqual(newRotation.Yaw, Target.Yaw, 5f))
		{
			StopMove();
		}
	}

	protected override void OnEnd()
	{
		TargetActor = null;
		RotateSpeed = 0f;
		TargetPos = FVector.ZeroVector;
		ResetAllStatus();
	}

	public override EBGUMoveMode GetMoveMode()
	{
		return EBGUMoveMode.StandRotate;
	}
}
