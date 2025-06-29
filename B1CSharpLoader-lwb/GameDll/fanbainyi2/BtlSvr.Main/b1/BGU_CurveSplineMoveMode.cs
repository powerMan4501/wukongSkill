using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BGU_CurveSplineMoveMode : BUC_MoveModeWithRotateBase
{
	private float MoveTotalTime;

	private float MoveTimer;

	private FVector MoveDirection;

	private EBGUMoveCurveType MoveCurveType;

	private UCurveFloat MoveCurve { get; set; }

	public override void Init(BUS_MovementSystem Parent)
	{
		base.Init(Parent);
		ResetCachInfo();
	}

	public void BeginMove(UAnimMontage Montage, float PlayTimeRate, float MontagePosOffset, FName StartSectionName, UCurveFloat Curve, EBGUMoveCurveType MoveCurveType, FVector MoveDir)
	{
		bool flag = false;
		USkeletalMeshComponent mesh = OwnerCharacter.Mesh;
		if (mesh != null)
		{
			UAnimInstance animInstance = mesh.GetAnimInstance();
			if (animInstance != null)
			{
				BGUFuncLibAnim.BGUActorTryPlayMontage(OwnerCharacter, Montage, StartSectionName, EMontageBindReason.Default, 1f, PlayTimeRate);
				if (MontagePosOffset != 0f)
				{
					UGSE_AnimFuncLib.AnimInstanceMontageSetPos(animInstance, MontagePosOffset);
				}
				MoveTotalTime = Montage.GetPlayLength();
				MoveTimer = 0f;
				MoveCurve = Curve;
				MoveDirection = MoveDir;
				this.MoveCurveType = MoveCurveType;
				flag = true;
			}
		}
		if (!flag)
		{
			StopMove();
		}
	}

	protected override void OnUpdate(float DeltaTime)
	{
		bool flag = true;
		bool flag2 = false;
		if (OwnerCharacter != null && !OwnerCharacter.HasAnyRootMotion())
		{
			flag = false;
		}
		if (!flag)
		{
			base.OnUpdate(DeltaTime);
			if (MoveCurveType == EBGUMoveCurveType.SpeedCurve)
			{
				float curveScaleTimes = GetCurveScaleTimes();
				float floatValue = MoveCurve.GetFloatValue(MoveTimer / curveScaleTimes);
				FVector newLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter) + MoveDirection * floatValue * DeltaTime;
				BGUFuncLibActorTransformCS.BGUSetActorLocation(OwnerCharacter, newLocation, bSweep: true, bTeleport: false, out var HitResult, NeedReturnHitResult: true);
				if (HitResult.BlockingHit)
				{
					flag2 = true;
				}
			}
			MoveTimer += DeltaTime;
			if (MoveTimer >= MoveTotalTime)
			{
				flag2 = true;
			}
		}
		else
		{
			flag2 = true;
		}
		if (flag2)
		{
			StopMove();
		}
	}

	private float GetCurveScaleTimes()
	{
		MoveCurve.GetTimeRange(out var MinTime, out var MaxTime);
		float num = MaxTime - MinTime;
		float result = 1f;
		if (num > 0f)
		{
			result = MoveTotalTime / num;
			result = ((result > 0f) ? result : 1f);
		}
		return result;
	}

	private void OnMontageBlendingOut(UAnimMontage Montage, bool bInterrupted)
	{
		if (IsActive())
		{
			StopMove();
		}
	}

	protected override void OnEnd()
	{
		base.OnEnd();
		ResetAllStatus();
		ResetCachInfo();
	}

	private void ResetCachInfo()
	{
		MoveTotalTime = 0f;
		MoveTimer = -1f;
		MoveCurve = null;
		MoveDirection = FVector.ZeroVector;
		MoveCurveType = EBGUMoveCurveType.None;
	}
}
