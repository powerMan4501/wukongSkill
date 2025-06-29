using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPCharacterData : IBUC_ABPCharacterData
{
	private float MontageDelayTime;

	private float LandingMoveTimer;

	private FName foot_l = B1GlobalFNames.foot_l;

	private FName foot_r = B1GlobalFNames.foot_r;

	public FVector Velocity { get; set; }

	public FVector LastVelocity { get; set; }

	public FVector RealWorldVelocity { get; set; }

	public FVector RealAcceleration { get; set; }

	public FVector MoveAcceleration { get; set; }

	public FVector LastMoveAccelerationNotZero { get; set; }

	public float MaxSpeed { get; set; }

	public float MaxAcceleration { get; set; }

	public float GroundFriction { get; set; }

	public float BrakingFriction { get; set; }

	public float BrakingFrictionFactor { get; set; }

	public float BrakingDecelerationWalking { get; set; }

	public bool bUseSeparateBrakingFriction { get; set; }

	public FVector ActorLocation { get; set; }

	public FVector LastActorLocation { get; set; }

	public FRotator ActorRotation { get; set; }

	public FRotator ControlRotation { get; set; }

	public FVector ForwardVector { get; set; }

	public FVector RightVector { get; set; }

	public FVector UpVector { get; set; }

	public FVector ActorScale3D { get; set; }

	public float ScaledCapsuleHalfHeight { get; set; }

	public float ScaledCapsuleRadius { get; set; }

	public FName AimOffsetEyeSocketName { get; set; }

	public FName AimOffsetBeWatchedSocketName { get; set; }

	public FVector AimOffsetEyeSocketPos { get; set; }

	public FVector AimOffsetBeWatchedSocketPos { get; set; }

	public bool IsFlying { get; set; }

	public bool IsFalling { get; set; }

	public bool IsLastFrameFalling { get; set; }

	public bool IsLandingMove { get; set; }

	public bool IsMontage { get; set; }

	public bool IsMontageRealTime { get; set; }

	public bool IsLocking { get; set; }

	public bool IsFarButInSight { get; set; }

	public FVector LeftFootPos { get; set; }

	public FVector RightFootPos { get; set; }

	public FVector LastFrameLeftFootPos { get; set; }

	public FVector LastFrameRightFootPos { get; set; }

	public UCharacterMovementComponent MovementComp { get; set; }

	public UCharacterMovementComponent AnimMoveComp { get; set; }

	public void Init(AActor Owner)
	{
		AimOffsetEyeSocketName = FName.None;
		AimOffsetBeWatchedSocketName = FName.None;
		AimOffsetEyeSocketPos = FVector.ZeroVector;
		AimOffsetBeWatchedSocketPos = FVector.ZeroVector;
		if (Owner is ACharacter aCharacter)
		{
			MovementComp = aCharacter.CharacterMovement;
		}
		if (!(Owner is BGUCharacterCS bGUCharacterCS))
		{
			return;
		}
		AnimMoveComp = bGUCharacterCS.AnimMoveComp;
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(BGU_DataUtil.GetActorResID(bGUCharacterCS));
		if (unitCommDesc == null)
		{
			return;
		}
		List<FName> list = (list = bGUCharacterCS.Mesh.GetAllSocketNames());
		if (!unitCommDesc.AimOffsetEyeSocketName.Equals(string.Empty) && list != null && list.Count > 0)
		{
			FName SocketName = new FName(unitCommDesc.AimOffsetEyeSocketName);
			if (list.Contains(SocketName))
			{
				AimOffsetEyeSocketPos = BGUFuncLibComponentCS.BGUGetSocketLocation(bGUCharacterCS.Mesh, ref SocketName);
				AimOffsetEyeSocketName = SocketName;
			}
			else
			{
				AimOffsetEyeSocketName = FName.None;
			}
		}
		if (!unitCommDesc.AimOffsetBeWatchedSocketName.Equals(string.Empty) && list != null && list.Count > 0)
		{
			FName SocketName2 = new FName(unitCommDesc.AimOffsetBeWatchedSocketName);
			if (list.Contains(SocketName2))
			{
				AimOffsetBeWatchedSocketPos = BGUFuncLibComponentCS.BGUGetSocketLocation(bGUCharacterCS.Mesh, ref SocketName2);
				AimOffsetBeWatchedSocketName = SocketName2;
			}
			else
			{
				AimOffsetBeWatchedSocketName = FName.None;
			}
		}
	}

	public void Update_GameThread(AActor Owner, IBUC_ABPHelperData HelperData, float DeltaTime)
	{
		ACharacter aCharacter = Owner as ACharacter;
		if (!(aCharacter == null))
		{
			IsMontage = false;
			if (!HelperData.AnimInst.IsNullOrDestroyed())
			{
				IsMontage = HelperData.AnimInst.IsAnyMontagePlaying();
			}
			IsMontageRealTime = IsMontage;
			if (IsMontage)
			{
				MontageDelayTime = 0f;
			}
			else if (MontageDelayTime <= 0.5f)
			{
				MontageDelayTime += DeltaTime;
				IsMontage = true;
			}
			LastVelocity = Velocity;
			BGUCharacterCS bGUCharacterCS = aCharacter as BGUCharacterCS;
			UBGUCharacterMovementComponent uBGUCharacterMovementComponent = MovementComp as UBGUCharacterMovementComponent;
			if (uBGUCharacterMovementComponent.IsInFollowState && AnimMoveComp != null)
			{
				Velocity = AnimMoveComp.Velocity;
			}
			else
			{
				Velocity = MovementComp.Velocity;
			}
			MoveAcceleration = MovementComp.GetCurrentAcceleration();
			MaxSpeed = MovementComp.GetMaxSpeed();
			MaxAcceleration = MovementComp.GetMaxAcceleration();
			GroundFriction = MovementComp.GroundFriction;
			BrakingFriction = MovementComp.BrakingFriction;
			BrakingFrictionFactor = MovementComp.BrakingFrictionFactor;
			BrakingDecelerationWalking = MovementComp.BrakingDecelerationWalking;
			bUseSeparateBrakingFriction = uBGUCharacterMovementComponent.IsUseSeparateBrakingFriction();
			LastActorLocation = ActorLocation;
			ActorLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter);
			ActorRotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(aCharacter);
			ControlRotation = aCharacter.GetControlRotation();
			ForwardVector = aCharacter.GetActorForwardVector();
			RightVector = aCharacter.GetActorRightVector();
			UpVector = aCharacter.GetActorUpVector();
			RealWorldVelocity = (ActorLocation - LastActorLocation) / DeltaTime;
			if (MoveAcceleration.ContainsNaN())
			{
				MoveAcceleration = FVector.ZeroVector;
			}
			if (!MoveAcceleration.IsNearlyZero())
			{
				LastMoveAccelerationNotZero = MoveAcceleration;
			}
			ActorScale3D = aCharacter.Mesh.GetWorldScale();
			ScaledCapsuleHalfHeight = aCharacter.CapsuleComponent.GetScaledCapsuleHalfHeight();
			ScaledCapsuleRadius = aCharacter.CapsuleComponent.GetScaledCapsuleRadius();
			RealAcceleration = (Velocity - LastVelocity) / DeltaTime;
			IsLastFrameFalling = IsFalling;
			IsFalling = MovementComp.IsFalling();
			IsFlying = MovementComp.IsFlying();
			IsLocking = BGUFunctionLibraryCS.BGUGetTarget(aCharacter) != null;
			if (!IsFalling && IsLastFrameFalling)
			{
				IsLandingMove = true;
				LandingMoveTimer = 0.3f;
			}
			if (LandingMoveTimer > 0f)
			{
				LandingMoveTimer -= DeltaTime;
			}
			if (LandingMoveTimer <= 0f)
			{
				IsLandingMove = false;
				LandingMoveTimer = 0f;
			}
			if (IsLandingMove && !MoveAcceleration.IsNearlyZero())
			{
				LandingMoveTimer = 0f;
			}
			FName none = FName.None;
			if (!AimOffsetEyeSocketName.Equals(FName.None))
			{
				none = AimOffsetEyeSocketName;
				AimOffsetEyeSocketPos = BGUFuncLibComponentCS.BGUGetSocketLocation(bGUCharacterCS.Mesh, ref none);
			}
			if (!AimOffsetBeWatchedSocketName.Equals(FName.None))
			{
				none = AimOffsetBeWatchedSocketName;
				AimOffsetBeWatchedSocketPos = BGUFuncLibComponentCS.BGUGetSocketLocation(bGUCharacterCS.Mesh, ref none);
			}
			UpdateFootPosition(aCharacter.Mesh);
		}
	}

	private void UpdateFootPosition(USkeletalMeshComponent Mesh)
	{
		if (!(Mesh == null))
		{
			LastFrameLeftFootPos = LeftFootPos;
			LastFrameRightFootPos = RightFootPos;
			LeftFootPos = BGUFuncLibComponentCS.BGUGetSocketTransform(Mesh, ref foot_l, ERelativeTransformSpace.RTS_Component).GetLocation();
			RightFootPos = BGUFuncLibComponentCS.BGUGetSocketTransform(Mesh, ref foot_r, ERelativeTransformSpace.RTS_Component).GetLocation();
		}
	}

	public bool IsLeftFootFront()
	{
		return LeftFootPos.X >= RightFootPos.X;
	}

	public bool IsLeftFootMoveForward()
	{
		return LeftFootPos.X > LastFrameLeftFootPos.X;
	}

	public bool IsRightFootMoveForward()
	{
		return RightFootPos.X > LastFrameRightFootPos.X;
	}

	public bool IsNextLeftFootStep()
	{
		bool flag = IsLeftFootFront();
		bool flag2 = IsLeftFootMoveForward();
		bool flag3 = IsRightFootMoveForward();
		if (flag2 && flag3)
		{
			return flag;
		}
		if (!flag2 && !flag3)
		{
			return !flag;
		}
		if (flag2)
		{
			return true;
		}
		return false;
	}
}
