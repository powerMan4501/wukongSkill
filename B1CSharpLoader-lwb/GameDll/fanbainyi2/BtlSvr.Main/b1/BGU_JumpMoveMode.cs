using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGU_JumpMoveMode : BUC_MoveModeBase
{
	private bool bIsSavedFirst;

	private FVector StartMoveDirection;

	private float HorMoveFixedSpd;

	private float VerMoveFixedSpd;

	private float HorOffsetAccumulation;

	private float VerOffsetAccumulation;

	private float MaxHorOffsetAccumulation;

	private float MaxVerOffsetAccumulation;

	private IBUC_JumpData JumpData;

	public override void Init(BUS_MovementSystem Parent)
	{
		base.Init(Parent);
		JumpData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_JumpData, b1.BUC_JumpData>(OwnerCharacter);
	}

	public override void MoveForward(float Value)
	{
		if (JumpData.JumpType == EJumpType.StrideJump)
		{
			return;
		}
		bool flag = false;
		if (base.CppCharacterMovementComp != null)
		{
			flag = base.CppCharacterMovementComp.Velocity.Z < 0f;
		}
		if (!flag)
		{
			return;
		}
		AController controller = OwnerCharacter.GetController();
		if (!(controller == null))
		{
			float worldDeltaSeconds = OwnerCharacter.World.GetWorldDeltaSeconds();
			float x = Value * VerMoveFixedSpd * worldDeltaSeconds;
			x = FMath.Clamp(x, VerOffsetAccumulation - MaxHorOffsetAccumulation, MaxVerOffsetAccumulation - VerOffsetAccumulation);
			if (x != 0f)
			{
				FVector actorForwardVector = controller.GetActorForwardVector();
				base.CppCharacterMovementComp.MoveUpdatedComponent(actorForwardVector * x, BGUFuncLibActorTransformCS.BGUGetActorRotation(OwnerCharacter), out var _);
				VerOffsetAccumulation += x;
			}
		}
	}

	public override void MoveRight(float Value)
	{
		if (JumpData.JumpType == EJumpType.StrideJump)
		{
			return;
		}
		bool flag = false;
		if (base.CppCharacterMovementComp != null)
		{
			flag = base.CppCharacterMovementComp.Velocity.Z < 0f;
		}
		if (!flag)
		{
			return;
		}
		AController controller = OwnerCharacter.GetController();
		if (!(controller == null))
		{
			float worldDeltaSeconds = OwnerCharacter.World.GetWorldDeltaSeconds();
			float x = Value * HorMoveFixedSpd * worldDeltaSeconds;
			x = FMath.Clamp(x, HorOffsetAccumulation - MaxHorOffsetAccumulation, MaxHorOffsetAccumulation - HorOffsetAccumulation);
			if (x != 0f)
			{
				FVector actorRightVector = controller.GetActorRightVector();
				base.CppCharacterMovementComp.MoveUpdatedComponent(actorRightVector * x, BGUFuncLibActorTransformCS.BGUGetActorRotation(OwnerCharacter), out var _);
				HorOffsetAccumulation += x;
			}
		}
	}

	public override EBGUMoveMode GetMoveMode()
	{
		return EBGUMoveMode.JumpMove;
	}

	protected override void OnUpdate(float DeltaTime)
	{
		base.OnUpdate(DeltaTime);
		MakeNoise();
		MainMoveThreadUpdate(DeltaTime);
		LockUpdate(DeltaTime);
	}

	protected void MainMoveThreadUpdate(float DeltaTime)
	{
		BGUCharacterCS bGUCharacterCS = OwnerCharacter as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		if (!bIsSavedFirst)
		{
			FUStPlayerCommDesc playerCommDesc = BGW_GameDB.GetPlayerCommDesc(bGUCharacterCS.GetResID(), bGUCharacterCS);
			if (playerCommDesc != null)
			{
				HorMoveFixedSpd = playerCommDesc.JumpHorFixedSpd;
				VerMoveFixedSpd = playerCommDesc.JumpVerFixedSpd;
				MaxHorOffsetAccumulation = playerCommDesc.JumpHorFixedMaxOffset;
				MaxVerOffsetAccumulation = playerCommDesc.JumpVerFixedMaxOffset;
			}
			else
			{
				HorMoveFixedSpd = 0f;
				VerMoveFixedSpd = 0f;
			}
			HorOffsetAccumulation = 0f;
			VerOffsetAccumulation = 0f;
			bIsSavedFirst = true;
		}
		if (bGUCharacterCS.GetController() == null || JumpData == null)
		{
			return;
		}
		if (!JumpData.Jump_with_LookatTarget && JumpData.CurrentJumpDir != ESkillDirection.None && JumpData.JumpType == EJumpType.Normal)
		{
			BGUFuncLibActorTransformCS.BGUSetActorRotation(OwnerCharacter, JumpData.CurrenrJumpMoveDirection.Rotation(), bTeleportPhysics: false);
		}
		StartMoveDirection = JumpData.CurrenrJumpMoveDirection;
		if (BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_SpeedCtrlData, BUC_SpeedCtrlData>(bGUCharacterCS) != null && StartMoveDirection.Size2D() > 0f)
		{
			bool flag = false;
			if (base.CppCharacterMovementComp != null)
			{
				flag = base.CppCharacterMovementComp.Velocity.Z > 1f;
			}
			if (JumpData.IsInJump() && flag)
			{
				EvtCollection.Evt_SetMovementInput.Invoke(StartMoveDirection, 1f, BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(OwnerCharacter));
			}
		}
		else
		{
			bGUCharacterCS.LaunchCharacter(FVector.ZeroVector, bXYOverride: true, bZOverride: false);
		}
	}

	protected void LockUpdate(float DeltaTime)
	{
		if (!JumpData.Jump_with_LookatTarget)
		{
			return;
		}
		AActor ownerCharacter = OwnerCharacter;
		UnitLockTargetInfo targetInfo = GetTargetInfoData().GetTargetInfo();
		ABGUCharacter aBGUCharacter = targetInfo.LockTargetActor as ABGUCharacter;
		if (BGU_DataUtil.GetReadOnlyData<BUC_ActorBasicData>(ownerCharacter).ActorType != BGU_ActorType.CharacterPlayer || ((aBGUCharacter == null || BGUFunctionLibraryCS.BGUIsUnitDead(aBGUCharacter)) && !BGUFunctionLibraryCS.BGUHasUnitState(ownerCharacter, EBGUUnitState.ShooterMode)))
		{
			return;
		}
		float num = 0f;
		if (JumpData != null)
		{
			num = JumpData.JumpRotSpd;
		}
		if (!(num <= 0f))
		{
			float TurnSpeed = 0f;
			GetRotateInfo(out var TargetPos, out TurnSpeed);
			if (aBGUCharacter != null && !BGUFunctionLibraryCS.BGUIsUnitDead(aBGUCharacter))
			{
				TargetPos = ((targetInfo.LockTargetType == ELockTargetType.SkeletonSocket) ? aBGUCharacter.Mesh.GetSocketLocation(new FName(targetInfo.LockTargetSkeletonSocketName)) : BGUFuncLibActorTransformCS.BGUGetActorLocation(aBGUCharacter));
			}
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(ownerCharacter);
			FVector x = TargetPos - fVector;
			x.Normalize();
			FRotator current = BGUFuncLibActorTransformCS.BGUGetActorRotation(ownerCharacter);
			FRotator target = MathLib.MakeRotFromX(x);
			target.Pitch = 0f;
			target.Roll = 0f;
			FRotator newRotation = MathLib.RInterpTo_Constant(current, target, DeltaTime, num);
			newRotation.Pitch = current.Pitch;
			newRotation.Roll = current.Roll;
			BGUFuncLibActorTransformCS.BGUSetActorRotation(ownerCharacter, newRotation, bTeleportPhysics: false);
		}
	}

	private void OnJumpOver()
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
		bIsSavedFirst = false;
	}
}
