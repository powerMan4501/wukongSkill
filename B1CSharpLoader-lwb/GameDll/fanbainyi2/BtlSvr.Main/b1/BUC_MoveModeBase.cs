using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_MoveModeBase
{
	public BUS_MovementSystem MoveSys;

	protected ACharacter OwnerCharacter;

	protected BUS_GSEventCollection EvtCollection;

	private bool bIsActive;

	public UBGUCharacterMovementComponent CppCharacterMovementComp { get; set; }

	public virtual void Init(BUS_MovementSystem Parent)
	{
		bIsActive = false;
		MoveSys = Parent;
		OwnerCharacter = MoveSys?.GetOwner() as ACharacter;
		CppCharacterMovementComp = OwnerCharacter?.CharacterMovement as UBGUCharacterMovementComponent;
		EvtCollection = ((MoveSys != null) ? BUS_EventCollectionCS.Get(MoveSys) : null);
	}

	public virtual void Release()
	{
	}

	public virtual void MoveForward(float Value)
	{
	}

	public virtual void MoveRight(float Value)
	{
	}

	protected virtual void OnUpdate(float DeltaTime)
	{
	}

	protected virtual void OnEnd()
	{
	}

	public void DoUpdate(float DeltaTime)
	{
		OnUpdate(DeltaTime);
	}

	public void TriggerOnEnd()
	{
		OnEnd();
	}

	public void SetActive(bool bVal)
	{
		bIsActive = bVal;
	}

	public bool IsActive()
	{
		return bIsActive;
	}

	public void Reset()
	{
		MoveSys.Reset();
	}

	public void StopMove(bool bShouldRestoreLastMoveMode = false)
	{
		if (bIsActive)
		{
			MoveSys.MoveStop(bShouldRestoreLastMoveMode);
			bIsActive = false;
		}
	}

	public int GetLogLvl()
	{
		return 0;
	}

	public AActor GetOwner()
	{
		return MoveSys.GetOwner();
	}

	public virtual EBGUMoveMode GetMoveMode()
	{
		return EBGUMoveMode.None;
	}

	public virtual bool CanOptimizeMoverTick()
	{
		return false;
	}

	protected void ResetAllStatus()
	{
		CppCharacterMovementComp.EnablePhysicsInteraction = true;
	}

	protected void ChangeToTargetSpeed(float SpeedRate)
	{
		EvtCollection.Evt_AISetSpeedRate.Invoke(SpeedRate, EBGUSpeedCtrlID.MoveSpeedRate);
	}

	protected IBUC_ActionRequestData GetActionRequestData()
	{
		return MoveSys.ActionRequestData;
	}

	protected IBUC_UnitStateData GetUnitStateData()
	{
		return MoveSys.UnitStateData;
	}

	protected IBUC_TargetInfoData GetTargetInfoData()
	{
		return MoveSys.TargetInfoData;
	}

	protected BUC_MovementData GetMovementData()
	{
		return MoveSys.MovementData;
	}

	protected IBUC_ActorTransformInfoData GetActorTransformInfoData()
	{
		return MoveSys.ActorTransformInfoData;
	}

	protected UObject GetWorldContext()
	{
		return MoveSys;
	}

	protected bool CheckCanRun()
	{
		return MoveSys.CheckCanRun();
	}

	protected bool CheckCanRotate()
	{
		return MoveSys.CheckCanRotate();
	}

	protected void MakeNoise()
	{
		MoveSys.MakeNoise();
	}

	protected void GetRotateInfo(out FVector TargetPos, out float TurnSpeed)
	{
		MoveSys.MovementData.GetRotateInfo(out TargetPos, out TurnSpeed);
	}

	protected UAnimInstance GetAnimInstance()
	{
		USkeletalMeshComponent mesh = OwnerCharacter.Mesh;
		if (mesh == null)
		{
			return null;
		}
		return mesh.GetAnimInstance();
	}

	protected void UpdateTargetRotationForMotionMatching(ref FRotator TargetRot, ref bool bForceSetRot)
	{
		IBUC_ABPHelperData animHumanoidHelperData = MoveSys.AnimHumanoidHelperData;
		if (animHumanoidHelperData != null && animHumanoidHelperData.ABPSettingData != null && animHumanoidHelperData.ABPSettingData.CommonSetting.ABPMoveMode == EABPMoveMode.MotionMatching && !MoveSys.UnitStateData.HasState(EBGUUnitState.AttackRotation))
		{
			IBUC_ABPMotionMatchingData mMData = MoveSys.MMData;
			IBUC_ABPBasicData basicData = MoveSys.BasicData;
			ACharacter ownerCharacter = MoveSys.CharacterComps.OwnerCharacter;
			bool flag = false;
			if (mMData.MotionMatchingState == EState_MM.None)
			{
				bForceSetRot = true;
			}
			else if (mMData.IsInLockState() && basicData.Speed > mMData.ForceSetRotAnimSpeed && !mMData.bMMLockUseFreeMode)
			{
				bForceSetRot = true;
				flag = true;
			}
			else
			{
				bForceSetRot = false;
			}
			if (flag && mMData.CurrentAA != null && mMData.CurrentAA.IsUseLMAnim())
			{
				FVector lastMovementInputVector = ownerCharacter.GetLastMovementInputVector();
				FVector zeroVector = FVector.ZeroVector;
				FRotator fRotator = MathLib.NormalizedDeltaRotator(lastMovementInputVector.Rotation(), TargetRot);
				zeroVector = ((-135f < fRotator.Yaw && fRotator.Yaw < -45f) ? (-TargetRot.GetRightVector()) : ((-45f <= fRotator.Yaw && fRotator.Yaw <= 45f) ? TargetRot.GetForwardVector() : ((!(45f < fRotator.Yaw) || !(fRotator.Yaw < 135f)) ? (-TargetRot.GetForwardVector()) : TargetRot.GetRightVector())));
				fRotator = MathLib.NormalizedDeltaRotator(lastMovementInputVector.Rotation(), zeroVector.Rotation());
				TargetRot += fRotator;
			}
			MoveSys.MovementData.SetTargetRotforMM(TargetRot);
		}
	}
}
