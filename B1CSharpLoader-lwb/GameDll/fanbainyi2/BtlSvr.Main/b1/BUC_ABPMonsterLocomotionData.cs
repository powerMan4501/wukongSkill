using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPMonsterLocomotionData : IBUC_ABPMonsterLocomotionData
{
	private IBUC_MovementData MovementData;

	private bool bIsAI;

	public EMoveDirectionEight FreeMoveStartDirection { get; set; }

	public EMoveDirection TargetLockMoveDirection { get; set; }

	public EMoveDirectionEight CurLockMoveDirection { get; set; }

	public float MoveLoopFwdBlendAlpha { get; set; }

	public float FreeLeanAdditiveX { get; set; }

	public float FreeLeanAdditiveY { get; set; }

	public bool bSwitchToLock { get; set; }

	public FVector4 VelocityBlendAlpha { get; set; }

	public bool bTurnBack { get; set; }

	public bool bIdleToMove { get; set; }

	public bool bMoveToBlendStop { get; set; }

	public bool bMoveToStandardFreeStop { get; set; }

	public void Init(IBUC_MovementData InMovementData, bool InIsAI)
	{
		MovementData = InMovementData;
		bIsAI = InIsAI;
	}

	public void Update(AActor Owner, IBUC_ABPCommonSettingData CommonData, IBUC_ABPCharacterData ChrData, IBUC_ABPBGUCharacterData BGUData, IBUC_ABPCommonLocomotionData LocomotionData, float DeltaTime)
	{
		if (CommonData.FinalABPMoveMode != EABPMoveMode.MonsterLocomotion)
		{
			return;
		}
		if (bIsAI)
		{
			if (MovementData != null)
			{
				bSwitchToLock = MovementData.MoveAIType == EBGUMoveAIType.KeepFacingTarget;
			}
		}
		else
		{
			bSwitchToLock = BGUData.bSideWalking;
		}
		if (bSwitchToLock)
		{
			FreeMoveStartDirection = EMoveDirectionEight.None;
			float yaw = MathLib.NormalizedDeltaRotator(ChrData.Velocity.Rotation(), ChrData.ActorRotation).Yaw;
			float num = -70f;
			float num2 = 70f;
			float num3 = -110f;
			float num4 = 110f;
			float num5 = 5f;
			switch (TargetLockMoveDirection)
			{
			case EMoveDirection.Forward:
				num -= num5;
				num2 += num5;
				break;
			case EMoveDirection.Right:
				num2 -= num5;
				num4 += num5;
				break;
			case EMoveDirection.Backward:
				num3 += num5;
				num4 -= num5;
				break;
			case EMoveDirection.Left:
				num += num5;
				num3 -= num5;
				break;
			}
			if (num <= yaw && yaw <= num2)
			{
				TargetLockMoveDirection = EMoveDirection.Forward;
			}
			else if (num3 <= yaw && yaw < num)
			{
				TargetLockMoveDirection = EMoveDirection.Left;
			}
			else if (num2 < yaw && yaw <= num4)
			{
				TargetLockMoveDirection = EMoveDirection.Right;
			}
			else
			{
				TargetLockMoveDirection = EMoveDirection.Backward;
			}
			if (!ChrData.MoveAcceleration.IsNearlyZero())
			{
				FVector4 fVector = BGUFuncLibForMove.BGUCalcRelativeVectorDirectionAlpha(ChrData.Velocity, ChrData.ActorRotation);
				float num6 = FMath.FInterpTo(VelocityBlendAlpha.X, fVector.X, DeltaTime, 12f);
				float num7 = FMath.FInterpTo(VelocityBlendAlpha.Y, fVector.Y, DeltaTime, 12f);
				float num8 = FMath.FInterpTo(VelocityBlendAlpha.Z, fVector.Z, DeltaTime, 12f);
				float num9 = FMath.FInterpTo(VelocityBlendAlpha.W, fVector.W, DeltaTime, 12f);
				VelocityBlendAlpha = new FVector4(num6, num7, num8, num9);
			}
		}
		else
		{
			float yaw2 = MathLib.NormalizedDeltaRotator(ChrData.MoveAcceleration.Rotation(), ChrData.ActorRotation).Yaw;
			if (-180f <= yaw2 && yaw2 < -135f)
			{
				FreeMoveStartDirection = EMoveDirectionEight.BL;
			}
			else if (-135f <= yaw2 && yaw2 < -45f)
			{
				FreeMoveStartDirection = EMoveDirectionEight.FL;
			}
			else if (45f < yaw2 && yaw2 <= 135f)
			{
				FreeMoveStartDirection = EMoveDirectionEight.FR;
			}
			else if (135f < yaw2 && yaw2 <= 180f)
			{
				FreeMoveStartDirection = EMoveDirectionEight.BR;
			}
			else
			{
				FreeMoveStartDirection = EMoveDirectionEight.F;
			}
			TargetLockMoveDirection = EMoveDirection.Forward;
			float num10 = FMath.FInterpTo(VelocityBlendAlpha.X, 1f, DeltaTime, 8f);
			float num11 = FMath.FInterpTo(VelocityBlendAlpha.Y, 0f, DeltaTime, 8f);
			float num12 = FMath.FInterpTo(VelocityBlendAlpha.Z, 0f, DeltaTime, 8f);
			float num13 = FMath.FInterpTo(VelocityBlendAlpha.W, 0f, DeltaTime, 8f);
			VelocityBlendAlpha = new FVector4(num10, num11, num12, num13);
		}
		FreeLeanAdditiveX = FMath.FInterpTo(FreeLeanAdditiveX, LocomotionData.RelativeAcceleration.Y, DeltaTime, 5f);
		FreeLeanAdditiveY = FMath.FInterpTo(FreeLeanAdditiveY, LocomotionData.RelativeAcceleration.X, DeltaTime, 5f);
		bTurnBack = false;
		MoveLoopFwdBlendAlpha = ChrData.MovementComp.GetCurrentAcceleration().Size() / ChrData.MovementComp.GetMaxAcceleration();
		bTurnBack = !bSwitchToLock && FVector.DotProduct(ChrData.Velocity.GetSafeNormal(), ChrData.MoveAcceleration.GetSafeNormal()) < 0.1f;
		float num14 = ChrData.Velocity.Size();
		bool flag = ChrData.MoveAcceleration.Size() > 0.1f;
		bool flag2 = ChrData.IsMontage && !flag;
		bIdleToMove = num14 > 20f && flag && !bTurnBack;
		bMoveToStandardFreeStop = !bSwitchToLock && (!flag || bTurnBack);
		bMoveToBlendStop = num14 < 10f || flag2 || bTurnBack;
	}
}
