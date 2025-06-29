using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPBGUCharacterData : IBUC_ABPBGUCharacterData
{
	private IBUC_UnitStateData UnitStateData;

	private IBUC_MovementData MovementData;

	private float SideWalkingTimer;

	public bool IsDead { get; set; }

	public bool IsAttacking { get; set; }

	public bool IsStandRotate { get; set; }

	public float TurnInplaceRemainAngle { get; set; }

	public FRotator TurnInplaceTargetRotation { get; set; }

	public bool bOrientRotationToMovement { get; set; }

	public bool bSideWalking { get; set; }

	public bool bTargetSideWalking { get; set; }

	public float BSStartMode { get; set; }

	public int BSEndMode { get; set; }

	public float InputMoveForward { get; set; }

	public float InputMoveSideways { get; set; }

	public float SprintSpeed { get; set; }

	public float RunSpeed { get; set; }

	public float JogBaseSpeed { get; set; }

	public bool IsAiming { get; set; }

	public bool IsShooting { get; set; }

	public void Init(AActor Owner, IBUC_UnitStateData InUnitStateData, IBUC_MovementData InMovementData, IBUC_SpeedCtrlData InSpeedCtrlData)
	{
		UnitStateData = InUnitStateData;
		MovementData = InMovementData;
		JogBaseSpeed = InSpeedCtrlData.GetMoveSpeedSlow();
		RunSpeed = InSpeedCtrlData.GetMoveSpeedNormal();
		SprintSpeed = InSpeedCtrlData.GetMoveSpeedFast();
	}

	public void Update_GameThread(AActor Owner, IBUC_ABPCharacterData ChrData, IBUC_SpeedCtrlData SpeedCtrlData, float DeltaTime)
	{
		if (Owner as ABGUCharacter == null)
		{
			return;
		}
		if (SpeedCtrlData != null)
		{
			JogBaseSpeed = SpeedCtrlData.GetMoveSpeedSlow();
			RunSpeed = SpeedCtrlData.GetMoveSpeedNormal();
			SprintSpeed = SpeedCtrlData.GetMoveSpeedFast();
		}
		bOrientRotationToMovement = ChrData.MovementComp.OrientRotationToMovement;
		IsStandRotate = false;
		TurnInplaceRemainAngle = 0f;
		if (MovementData != null)
		{
			EBGUMoveMode moveType = MovementData.GetMoveType();
			if (moveType == EBGUMoveMode.AttackRotate || moveType == EBGUMoveMode.StandRotate)
			{
				IsStandRotate = !IsAttacking && ChrData.MoveAcceleration.IsNearlyZero();
				MovementData.GetRotateInfo(out var TargetPos, out var _);
				TurnInplaceTargetRotation = MathLib.FindLookAtRotation(ChrData.ActorLocation, TargetPos);
				TurnInplaceRemainAngle = FRotator.NormalizeAxis(TurnInplaceTargetRotation.Yaw - ChrData.ActorRotation.Yaw);
			}
		}
		if (UnitStateData != null)
		{
			IsAttacking = UnitStateData.HasState(EBGUUnitState.Attacking);
			IsDead = UnitStateData.HasState(EBGUUnitState.Dead);
			bTargetSideWalking = UnitStateData.HasState(EBGUUnitState.SideWalking) && !UnitStateData.HasState(EBGUUnitState.Sprinting);
		}
		if (bTargetSideWalking && !bSideWalking)
		{
			if (SideWalkingTimer > 0f)
			{
				SideWalkingTimer -= DeltaTime;
				if (SideWalkingTimer <= 0f)
				{
					SideWalkingTimer = 0f;
					bSideWalking = bTargetSideWalking;
				}
			}
			else
			{
				SideWalkingTimer = 0.1f;
			}
		}
		if (!bTargetSideWalking)
		{
			bSideWalking = bTargetSideWalking;
			SideWalkingTimer = 0f;
		}
		InputMoveForward = ChrData.MoveAcceleration.Size() / ChrData.MaxAcceleration;
		InputMoveSideways = ChrData.MoveAcceleration.Size() / ChrData.MaxAcceleration;
		float maxSpeed = ChrData.MaxSpeed;
		if (maxSpeed >= (SprintSpeed + RunSpeed) / 2f)
		{
			if ((double)InputMoveForward < 0.01)
			{
				BSStartMode = 2f;
			}
			else
			{
				BSStartMode = MathLib.Lerp(BSStartMode, 2f, DeltaTime * 2f);
			}
			if ((double)InputMoveForward > 0.01)
			{
				BSEndMode = 2;
			}
		}
		else if (maxSpeed < (RunSpeed + JogBaseSpeed) / 2f)
		{
			if ((double)InputMoveForward < 0.01)
			{
				BSStartMode = 0f;
			}
			else
			{
				BSStartMode = MathLib.Lerp(BSStartMode, 0f, DeltaTime * 2f);
			}
			if ((double)InputMoveForward > 0.01)
			{
				BSEndMode = 0;
			}
		}
		else
		{
			if ((double)InputMoveForward < 0.01)
			{
				BSStartMode = 1f;
			}
			else
			{
				BSStartMode = MathLib.Lerp(BSStartMode, 1f, DeltaTime * 2f);
			}
			if ((double)InputMoveForward > 0.01)
			{
				BSEndMode = 1;
			}
		}
	}
}
