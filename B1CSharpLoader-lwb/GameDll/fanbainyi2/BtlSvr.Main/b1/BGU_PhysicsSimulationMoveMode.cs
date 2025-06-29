using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGU_PhysicsSimulationMoveMode : BUC_MoveModeBase
{
	private float ForwardValue;

	private float RightValue;

	private TWeakObject<AActor> mTargetActor;

	private FVector TargetLocation;

	private float AcceptableRadius;

	private bool bIncludeSelfRadius;

	private bool bIncludeTargetRadius;

	private EAIMoveSpeedType SpeedType;

	private bool bAIMoving;

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

	public override void MoveForward(float Value)
	{
		ForwardValue = Value;
		if (Value != 0f)
		{
			bAIMoving = false;
		}
	}

	public override void MoveRight(float Value)
	{
		RightValue = Value;
		if (Value != 0f)
		{
			bAIMoving = false;
		}
	}

	public void BeginMoveToLocation(in FVector Location, EAIMoveSpeedType MoveSpeedType, float AcceptableRadius, bool IncludeSelfRadius, bool IncludeTargetRadius)
	{
		TargetActor = null;
		TargetLocation = Location;
		SpeedType = MoveSpeedType;
		this.AcceptableRadius = AcceptableRadius;
		bIncludeSelfRadius = IncludeSelfRadius;
		bIncludeTargetRadius = IncludeTargetRadius;
		BeginAIPhysicsSimulationMove();
	}

	public void BeginMoveToActor(AActor Actor, EAIMoveSpeedType MoveSpeedType, float AcceptableRadius, bool IncludeSelfRadius, bool IncludeTargetRadius)
	{
		TargetActor = Actor;
		TargetLocation = FVector.ZeroVector;
		SpeedType = MoveSpeedType;
		this.AcceptableRadius = AcceptableRadius;
		bIncludeSelfRadius = IncludeSelfRadius;
		bIncludeTargetRadius = IncludeTargetRadius;
		BeginAIPhysicsSimulationMove();
	}

	private void BeginAIPhysicsSimulationMove()
	{
		bAIMoving = true;
		float unitSpeedRateByMoveSpeedType = AIFuncLibForCS.GetUnitSpeedRateByMoveSpeedType(OwnerCharacter, SpeedType);
		unitSpeedRateByMoveSpeedType = ((unitSpeedRateByMoveSpeedType > 0f) ? unitSpeedRateByMoveSpeedType : 1f);
		ChangeToTargetSpeed(unitSpeedRateByMoveSpeedType);
		EBUStateTrigger triggerID = EBUStateTrigger.AIInputRun;
		switch (SpeedType)
		{
		case EAIMoveSpeedType.JOG:
			triggerID = EBUStateTrigger.AIInputWalk;
			break;
		case EAIMoveSpeedType.RUN:
			triggerID = EBUStateTrigger.AIInputRun;
			break;
		case EAIMoveSpeedType.SPRINT:
			triggerID = EBUStateTrigger.AIInputSprint;
			break;
		}
		EvtCollection.Evt_UnitStateTrigger.Invoke(triggerID, -1f);
	}

	protected override void OnUpdate(float DeltaTime)
	{
		if (!bAIMoving)
		{
			return;
		}
		MakeNoise();
		float num = AcceptableRadius;
		if (bIncludeSelfRadius)
		{
			UCapsuleComponent uCapsuleComponent = OwnerCharacter.GetRootComponent() as UCapsuleComponent;
			if (uCapsuleComponent != null)
			{
				num += uCapsuleComponent.GetScaledCapsuleRadius();
			}
		}
		if (bIncludeTargetRadius && TargetActor != null)
		{
			UCapsuleComponent uCapsuleComponent2 = TargetActor.GetRootComponent() as UCapsuleComponent;
			if (uCapsuleComponent2 != null)
			{
				num += uCapsuleComponent2.GetScaledCapsuleRadius();
			}
		}
		FVector fVector = ((TargetActor != null) ? BGUFuncLibActorTransformCS.BGUGetActorLocation(TargetActor) : TargetLocation);
		if (new FVector2D(fVector - BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter)).Size() <= num)
		{
			bAIMoving = false;
			StopMove();
			return;
		}
		b1.IBUC_PhysAnimData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_PhysAnimData, b1.BUC_PhysAnimData>(OwnerCharacter);
		if (unPersistentReadOnlyData == null || unPersistentReadOnlyData.CurrentType != EPhysAnimType.PhysicsSimulationMove || !(unPersistentReadOnlyData.TryGetSetting(EPhysAnimType.PhysicsSimulationMove, OwnerCharacter, out var _) is b1.PhysMoveAnimSetting physMoveAnimSetting))
		{
			return;
		}
		IBUC_SpeedCtrlData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_SpeedCtrlData, BUC_SpeedCtrlData>(OwnerCharacter);
		b1.IBUC_PhysicalMoveData unPersistentReadOnlyData3 = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_PhysicalMoveData, b1.BUC_PhysicalMoveData>(OwnerCharacter);
		if (unPersistentReadOnlyData2 == null || unPersistentReadOnlyData3 == null)
		{
			return;
		}
		float num2 = unPersistentReadOnlyData2.GetMoveSpeedFast() * unPersistentReadOnlyData2.GetFinalSpeedCtrlRate();
		FVector socketLocation = OwnerCharacter.Mesh.GetSocketLocation(physMoveAnimSetting.BoneNameToSimulatePhysics);
		FVector fVector2 = fVector - socketLocation;
		FVector fVector3 = fVector2.GetSafeNormal() * unPersistentReadOnlyData2.GetMoveSpeedFast();
		float num3 = FVector.DotProduct(fVector3.GetSafeNormal(), unPersistentReadOnlyData3.PhysicalMoveVelocity.GetSafeNormal());
		if (num3 > 0f && fVector2.Size() <= unPersistentReadOnlyData3.AccuratelyMoveDistance)
		{
			float num4 = FMath.Clamp(MathLib.DegAcos(num3), 0f, 30f);
			FVector axis = FVector.CrossProduct(fVector3.GetSafeNormal(), unPersistentReadOnlyData3.PhysicalMoveVelocity.GetSafeNormal());
			fVector3 = MathLib.RotateAngleAxis(fVector3, 0f - num4, axis);
		}
		if (unPersistentReadOnlyData3.PhysicalMoveVelocity.Size() >= num2)
		{
			if (num3 > 0f)
			{
				fVector3 = FVector.VectorPlaneProject(fVector3, unPersistentReadOnlyData3.PhysicalMoveVelocity.GetSafeNormal());
			}
			fVector3 -= unPersistentReadOnlyData3.PhysicalMoveVelocity.GetSafeNormal() * unPersistentReadOnlyData3.PhysicalMoveVelocity.Size();
		}
		OwnerCharacter.Mesh.AddForce(fVector3, physMoveAnimSetting.BoneNameToSimulatePhysics, bAccelChange: true);
		if (unPersistentReadOnlyData3.GravityAddValue != 0f)
		{
			OwnerCharacter.Mesh.AddForce(FVector.UpVector * unPersistentReadOnlyData3.GravityAddValue, physMoveAnimSetting.BoneNameToSimulatePhysics, bAccelChange: true);
		}
		IBUC_EnvironmentInteractionMgrData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_EnvironmentInteractionMgrData, BUC_EnvironmentInteractionMgrData>(OwnerCharacter);
		if (readOnlyData != null && readOnlyData.bNearGround && MathLib.DegAcos(FVector.DotProduct(readOnlyData.SurfaceNormal_Normalized, FVector.UpVector)) >= 5f && (BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter) - readOnlyData.SurfaceHitPoint).Z <= OwnerCharacter.CapsuleComponent.GetScaledCapsuleHalfHeight() + 200f)
		{
			float num5 = 0f - (unPersistentReadOnlyData3.DefaultGravityZ + unPersistentReadOnlyData3.GravityAddValue);
			FVector safeNormal = FVector.VectorPlaneProject(readOnlyData.SurfaceNormal_Normalized, FVector.UpVector).GetSafeNormal();
			FVector safeNormal2 = FVector.VectorPlaneProject(safeNormal, readOnlyData.SurfaceNormal_Normalized).GetSafeNormal();
			float num6 = num5 * FVector.DotProduct(readOnlyData.SurfaceNormal_Normalized, safeNormal);
			OwnerCharacter.Mesh.AddForce(-safeNormal2 * num6, physMoveAnimSetting.BoneNameToSimulatePhysics, bAccelChange: true);
		}
	}

	protected override void OnEnd()
	{
		TargetActor = null;
		TargetLocation = FVector.ZeroVector;
		bAIMoving = false;
		AcceptableRadius = 0f;
		bIncludeSelfRadius = false;
		bIncludeTargetRadius = false;
	}

	public override EBGUMoveMode GetMoveMode()
	{
		return EBGUMoveMode.PhysicsSimulation;
	}
}
