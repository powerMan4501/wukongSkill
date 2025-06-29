using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_MoveModeWithRotateBase : BUC_MoveModeBase
{
	protected float RotateSpeed;

	private ERotateDirection RotateDirection;

	private float RotateDeflAngle;

	private float MaxRotateAngle;

	private bool IsWithRotateTarget;

	private bool IsRotateFinished;

	private bool HasOffsetRotationAxis;

	private bool HasSetSpecialAimPoint;

	protected FVector TargetPos;

	protected IBUC_UnitStateData TargetUnitStateData;

	protected IBUC_SimpleStateData TargetSimpleStateData;

	private bool bForceUpdate;

	private bool bStillRotateWhenAboveMaxRotateAngle;

	private float DeadzoneAngle;

	protected UnitLockTargetInfo TargetInfo;

	private string TraceSocket;

	private FVector OffsetRotationAxisPos;

	private USceneComponent AxisComp;

	private bool bShouldIncludeAutoLockPoint;

	private float TotalRotateAngle;

	private bool EnableDebug;

	public override void Init(BUS_MovementSystem Parent)
	{
		base.Init(Parent);
		IsWithRotateTarget = false;
		IsRotateFinished = false;
		HasOffsetRotationAxis = false;
		AxisComp = null;
	}

	public void BeginRotateToTarget(float RotateSpd, UnitLockTargetInfo RotateTargetInfo, float RotateDeflectionAngle = 0f, float MaxRotateAng = 0f, string TraceSocketName = "", bool bIncludeAutoLockPoint = false, ERotateDirection RotateDir = ERotateDirection.Auto, bool IsStillRotateWhenAboveMaxRotateAngle = false, float DeadzoneAng = 0f, bool EnableDebug = false)
	{
		TargetInfo = RotateTargetInfo;
		TraceSocket = TraceSocketName;
		RotateSpeed = RotateSpd;
		RotateDirection = RotateDir;
		RotateDeflAngle = RotateDeflectionAngle;
		MaxRotateAngle = MaxRotateAng;
		IsWithRotateTarget = true;
		IsRotateFinished = false;
		bShouldIncludeAutoLockPoint = bIncludeAutoLockPoint;
		bStillRotateWhenAboveMaxRotateAngle = IsStillRotateWhenAboveMaxRotateAngle;
		DeadzoneAngle = DeadzoneAng;
		this.EnableDebug = EnableDebug;
		TargetUnitStateData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(TargetInfo.LockTargetActor);
		TargetSimpleStateData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(TargetInfo.LockTargetActor);
		TargetPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(TargetInfo.LockTargetActor);
		if (TraceSocket.Length > 0)
		{
			ACharacter aCharacter = TargetInfo.LockTargetActor as ACharacter;
			if (aCharacter != null && aCharacter.Mesh != null)
			{
				TargetPos = aCharacter.Mesh.GetSocketLocation(new FName(TraceSocket));
			}
		}
		TotalRotateAngle = 0f;
	}

	public void BeginRotateToPos(float RotateSpd, FVector RotateTargetPos, bool bForceUpdate = false, float RotateDeflectionAngle = 0f, float MaxRotateAng = 0f, ERotateDirection RotateDir = ERotateDirection.Auto, bool IsStillRotateWhenAboveMaxRotateAngle = false, float DeadzoneAng = 0f, bool EnableDebug = false)
	{
		TargetInfo = null;
		TraceSocket = "";
		RotateSpeed = RotateSpd;
		RotateDirection = RotateDir;
		RotateDeflAngle = RotateDeflectionAngle;
		MaxRotateAngle = MaxRotateAng;
		TargetPos = RotateTargetPos;
		IsWithRotateTarget = true;
		IsRotateFinished = false;
		bStillRotateWhenAboveMaxRotateAngle = IsStillRotateWhenAboveMaxRotateAngle;
		DeadzoneAngle = DeadzoneAng;
		this.EnableDebug = EnableDebug;
		this.bForceUpdate = bForceUpdate;
		TargetUnitStateData = null;
		TotalRotateAngle = 0f;
	}

	public void FinishRotate()
	{
		RotateFinishReset();
	}

	public void PlayerRotDeflectionAngleFixed(float RotateDeflectionAngle)
	{
		RotateDeflAngle = RotateDeflectionAngle;
	}

	public void SetOffsetRotationAxis(FVector RotationAxisPos)
	{
		OffsetRotationAxisPos = RotationAxisPos;
		HasOffsetRotationAxis = true;
	}

	public void SetOffsetRotationAxisComp(USceneComponent RotationAxisComp)
	{
		AxisComp = RotationAxisComp;
		HasOffsetRotationAxis = true;
	}

	protected override void OnUpdate(float DeltaTime)
	{
		if (IsRotateFinished || (!IsWithRotateTarget && !IsRotateFinished))
		{
			return;
		}
		IBUC_UnitStateData unitStateData = GetUnitStateData();
		if (unitStateData == null || !unitStateData.HasState(EBGUUnitState.AttackRotation))
		{
			return;
		}
		FVector fVector = TargetPos;
		if (TargetInfo != null && TargetInfo.LockTargetActor != null)
		{
			if (TargetUnitStateData != null && TargetUnitStateData.HasState(EBGUUnitState.Dead))
			{
				RotateFinishReset();
				return;
			}
			if (TargetSimpleStateData != null && TargetSimpleStateData.HasSimpleState(EBGUSimpleState.RefuseAttackRotation))
			{
				RotateFinishReset();
				return;
			}
			if (TargetInfo != null && TargetInfo.LockTargetActor != null)
			{
				fVector = BGU_SelectTargetUtil.GetTargetPositionByTargetInfo(in TargetInfo, out var _, bShouldIncludeAutoLockPoint, TraceSocket);
			}
		}
		FRotator Current = BGUFuncLibActorTransformCS.BGUGetActorRotation(OwnerCharacter);
		FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter);
		FVector v = Current.Vector();
		FVector fVector3 = v.RotateAngleAxis(MathLib.NormalizeAxis(RotateDeflAngle), new FVector(0.0, 0.0, 1.0));
		FRotator TargetRot = Current;
		FVector2D unitRotateAimDir = new FVector2D(fVector3.X, fVector3.Y);
		FVector2D unit2TargetDir = new FVector2D(fVector.X - fVector2.X, fVector.Y - fVector2.Y);
		float num = BGU_MoveUtil.GetRotateAngle2D(unitRotateAimDir, unit2TargetDir);
		float num2 = num;
		bool flag = BGU_MoveUtil.IsRotateClockwise(unitRotateAimDir, unit2TargetDir);
		if (DeadzoneAngle > 0f && DeadzoneAngle >= num)
		{
			return;
		}
		if ((RotateDirection == ERotateDirection.Clockwise && !flag) || (RotateDirection == ERotateDirection.Counterclockwise && flag))
		{
			num2 = 360f - num;
		}
		if (MaxRotateAngle > 0f && TotalRotateAngle >= MaxRotateAngle)
		{
			return;
		}
		if (MaxRotateAngle > 0f && num2 > MaxRotateAngle - TotalRotateAngle)
		{
			if (!bStillRotateWhenAboveMaxRotateAngle)
			{
				return;
			}
			num = ((num2 == num) ? (MaxRotateAngle - TotalRotateAngle) : (TotalRotateAngle - MaxRotateAngle));
		}
		if (flag)
		{
			TargetRot.Yaw = MathLib.NormalizeAxis(TargetRot.Yaw + num);
		}
		else
		{
			TargetRot.Yaw = MathLib.NormalizeAxis(TargetRot.Yaw - num);
		}
		bool bForceSetRot = true;
		if (!MoveSys.ChrData.MoveAcceleration.IsNearlyZero())
		{
			UpdateTargetRotationForMotionMatching(ref TargetRot, ref bForceSetRot);
		}
		FRotator newRotation = TargetRot;
		if (RotateSpeed > 0f)
		{
			newRotation = ((RotateDirection != ERotateDirection.Auto) ? BGU_MoveUtil.RotateInterpConstantToBySingleDirection(new FVector2D(v), new FVector2D(TargetRot.Vector()), DeltaTime, RotateSpeed, RotateDirection == ERotateDirection.Clockwise) : MathLib.RInterpConstantTo(in Current, in TargetRot, DeltaTime, RotateSpeed));
		}
		newRotation.Pitch = Current.Pitch;
		newRotation.Roll = Current.Roll;
		if (HasOffsetRotationAxis && AxisComp != null)
		{
			float num3 = num;
			if (RotateSpeed > 0f)
			{
				num3 = MathLib.NormalizeAxis(newRotation.Yaw - Current.Yaw);
			}
			OffsetRotationAxisPos = AxisComp.GetWorldLocation();
			FVector offsetRotationAxisPos = OffsetRotationAxisPos;
			offsetRotationAxisPos.Z = fVector2.Z;
			FVector fVector4 = (fVector2 - offsetRotationAxisPos).RotateAngleAxis(num3, FVector.UpVector) + offsetRotationAxisPos;
			OwnerCharacter.CharacterMovement.MoveUpdatedComponent(fVector4 - fVector2, Current, out var _);
		}
		TotalRotateAngle += MathLib.NormalizeAxis(newRotation.Yaw - Current.Yaw);
		if (bForceSetRot)
		{
			BGUFuncLibActorTransformCS.BGUSetActorRotation(OwnerCharacter, newRotation, bTeleportPhysics: false, bImmediateUpdate: false, bForceUpdate);
		}
		if (EnableDebug)
		{
			AActor owner = GetOwner();
			FVector fVector5 = fVector2;
			if (HasOffsetRotationAxis && AxisComp != null)
			{
				fVector5 = OffsetRotationAxisPos;
			}
			USystemLibrary.DrawDebugLine(owner, fVector5, fVector, FLinearColor.Green, 0f, 10f);
			USystemLibrary.DrawDebugSphere(owner, fVector5, 30f, 20, FLinearColor.Red, 0f, 10f);
			USystemLibrary.DrawDebugSphere(owner, fVector, 30f, 20, FLinearColor.Yellow, 0f, 10f);
		}
		if (TargetInfo != null && TargetInfo.LockTargetActor != null)
		{
			if (!unitStateData.HasState(EBGUUnitState.AttackRotation))
			{
				RotateFinishReset();
			}
		}
		else if (!unitStateData.HasState(EBGUUnitState.AttackRotation) && MathLib.IsNearlyEqual(newRotation.Yaw, TargetRot.Yaw, 0.01f))
		{
			RotateFinishReset();
		}
	}

	protected override void OnEnd()
	{
		IsWithRotateTarget = false;
		IsRotateFinished = false;
		HasOffsetRotationAxis = false;
		TotalRotateAngle = 0f;
		TargetInfo = null;
		ResetAllStatus();
	}

	protected void RotateFinishReset()
	{
		IsRotateFinished = true;
		HasOffsetRotationAxis = false;
		TotalRotateAngle = 0f;
		AxisComp = null;
	}

	protected bool GetIsRotateFinished()
	{
		return IsRotateFinished;
	}
}
