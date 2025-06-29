using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGU_NpcGuideSplineMoveMode : BUC_MoveModeBase
{
	private EAIMoveSpeedType CurrentMoveSpeedType = EAIMoveSpeedType.SPRINT;

	private const float NpcSplineGuaranteeDistance = 5000f;

	private const float NpcStuckGuaranteeTimer = 3f;

	protected override void OnUpdate(float DeltaTime)
	{
		BUS_GSEventCollection evtCollection = EvtCollection;
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(MoveSys, MoveSys.MovementData.NpcGuideSplineGuid);
		if (!(actorByGuid != null))
		{
			return;
		}
		USplineComponent componentByClass = actorByGuid.GetComponentByClass<USplineComponent>();
		if (!(componentByClass != null))
		{
			return;
		}
		FTransform tran = BGUFuncLibActorTransformCS.BGUGetActorTransform(OwnerCharacter);
		FVector location = tran.GetLocation();
		float num = componentByClass.FindInputKeyClosestToWorldLocation(location);
		if (!componentByClass.IsClosedLoop() && num >= (float)(componentByClass.GetNumberOfSplinePoints() - 1))
		{
			evtCollection.Evt_SetMoveModeActive.Invoke(EBGUMoveMode.NpcGuideSplineMove, SetActive: false);
			return;
		}
		EBUStateTrigger triggerID = EBUStateTrigger.AIInputWalk;
		if (MoveSys.MovementData.NeedSwitchSpeedByDistanceToPlayer)
		{
			BGUCharacterCS closestPlayer = BGUFunctionLibraryCS.GetClosestPlayer(OwnerCharacter, tran);
			if (closestPlayer == null)
			{
				return;
			}
			float inKey = componentByClass.FindInputKeyClosestToWorldLocation(BGUFuncLibActorTransformCS.BGUGetActorLocation(closestPlayer));
			float num2 = componentByClass.GetDistanceAlongSplineAtSplineInputKey(num) - componentByClass.GetDistanceAlongSplineAtSplineInputKey(inKey);
			if (num2 < MoveSys.MovementData.MaxDistance_Sprint + ((CurrentMoveSpeedType == EAIMoveSpeedType.SPRINT) ? MoveSys.MovementData.DistanceBuffer : (0f - MoveSys.MovementData.DistanceBuffer)))
			{
				CurrentMoveSpeedType = EAIMoveSpeedType.SPRINT;
				triggerID = EBUStateTrigger.AIInputSprint;
			}
			else if (num2 < MoveSys.MovementData.MaxDistance_Run + ((CurrentMoveSpeedType == EAIMoveSpeedType.RUN) ? MoveSys.MovementData.DistanceBuffer : (0f - MoveSys.MovementData.DistanceBuffer)))
			{
				CurrentMoveSpeedType = EAIMoveSpeedType.RUN;
				triggerID = EBUStateTrigger.AIInputRun;
			}
			else
			{
				if (!(num2 < MoveSys.MovementData.MaxDistance_Jog + ((CurrentMoveSpeedType == EAIMoveSpeedType.JOG) ? MoveSys.MovementData.DistanceBuffer : (0f - MoveSys.MovementData.DistanceBuffer))))
				{
					return;
				}
				CurrentMoveSpeedType = EAIMoveSpeedType.JOG;
				triggerID = EBUStateTrigger.AIInputWalk;
			}
		}
		else
		{
			CurrentMoveSpeedType = MoveSys.MovementData.SplineMoveSpeed;
			switch (MoveSys.MovementData.SplineMoveSpeed)
			{
			case EAIMoveSpeedType.SPRINT:
				triggerID = EBUStateTrigger.AIInputSprint;
				break;
			case EAIMoveSpeedType.RUN:
				triggerID = EBUStateTrigger.AIInputRun;
				break;
			case EAIMoveSpeedType.JOG:
				triggerID = EBUStateTrigger.AIInputWalk;
				break;
			}
		}
		evtCollection.Evt_UnitStateTrigger.Invoke(triggerID, -1f);
		if (num == (float)componentByClass.GetNumberOfSplinePoints() - 1f)
		{
			num -= 0.001f;
		}
		FVector safeNormal = componentByClass.GetDirectionAtSplineInputKey(num, ESplineCoordinateSpace.World).GetSafeNormal();
		FVector locationAtSplineInputKey = componentByClass.GetLocationAtSplineInputKey(num, ESplineCoordinateSpace.World);
		if (location.Vector_Distance(locationAtSplineInputKey) > 5000.0)
		{
			TriggerNpcResetLocationGuarantee(locationAtSplineInputKey, OwnerCharacter);
		}
		FVector safeNormal2 = componentByClass.GetRightVectorAtSplineInputKey(num, ESplineCoordinateSpace.World).GetSafeNormal();
		FVector fVector = (BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter) - locationAtSplineInputKey).ProjectOnTo(safeNormal2);
		float mappedRangeValueClamped = FMath.GetMappedRangeValueClamped(new FVector2D(0.0, OwnerCharacter.CapsuleComponent.GetScaledCapsuleRadius() * 2f), new FVector2D(0.0, 0.6000000238418579), fVector.Size());
		FVector fVector2 = ((FVector.DotProduct(safeNormal2, fVector.GetSafeNormal()) >= 0f) ? (-safeNormal2) : safeNormal2);
		safeNormal += fVector2 * mappedRangeValueClamped;
		float unitSpeedRateByMoveSpeedType = AIFuncLibForCS.GetUnitSpeedRateByMoveSpeedType(OwnerCharacter, CurrentMoveSpeedType);
		ChangeToTargetSpeed(unitSpeedRateByMoveSpeedType);
		evtCollection.Evt_SetMovementInput.Invoke(safeNormal.GetSafeNormal(), 1f, BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(OwnerCharacter));
		if (location == MoveSys.MovementData.NpcLastLocation)
		{
			MoveSys.MovementData.NpcStuckTimer += DeltaTime;
			if (MoveSys.MovementData.NpcStuckTimer > 3f)
			{
				MoveSys.MovementData.NpcStuckTimer = 0f;
				TriggerNpcResetLocationGuarantee(locationAtSplineInputKey, OwnerCharacter);
			}
		}
		else
		{
			MoveSys.MovementData.NpcStuckTimer = 0f;
		}
		MoveSys.MovementData.NpcLastLocation = location;
		MakeNoise();
	}

	private void TriggerNpcResetLocationGuarantee(FVector SplinePointLoc, ACharacter NpcActor)
	{
		SplinePointLoc.Z += NpcActor.CapsuleComponent.GetScaledCapsuleHalfHeight();
		NpcActor.SetActorLocation(SplinePointLoc, bSweep: false, out var _, bTeleport: true);
	}

	public override EBGUMoveMode GetMoveMode()
	{
		return EBGUMoveMode.NpcGuideSplineMove;
	}
}
