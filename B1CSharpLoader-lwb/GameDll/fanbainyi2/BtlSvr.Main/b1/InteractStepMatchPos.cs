using System.Collections.Generic;
using b1.BGW;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class InteractStepMatchPos : InteractStepBase
{
	private int DUMMY_WAIT_FRAME;

	private int DummyMeshTimer;

	private readonly float BLACK_OUT_TIME = 0.1f;

	public float BlackOutTimer;

	private BUC_MovementModes MoveMode;

	public InteractStepMatchPos()
	{
		StateName = PlayerInteractState.MatchPos;
		TimeOut = 5f;
	}

	public override void StepBegin()
	{
		base.StepBegin();
		AActor aActor = EntitySharedRefFuncLib.Actor(Context.PlayerInteractData.BestInteractEntityRef);
		if (aActor.IsNullOrDestroyed())
		{
			return;
		}
		BUS_EventCollectionCS.Get(Context.OwnerController.GetControlledPawn()).Evt_StartInteract.Invoke();
		if (Context.PlayerInteractData.InteractActionDesc.MatchingPosType == EMatchingPosType.None)
		{
			StepFinish();
			return;
		}
		Context.TargetInteractData.bIsInteracting = true;
		Context.TargetInteractData.InteractUIState = EInteractUIState.Invisiable;
		BUS_EventCollectionCS.Get(Context.OwnerController.GetControlledPawn()).Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.IgnoreAllInput);
		if (Context.PlayerInteractData.InteractActionDesc != null && Context.PlayerInteractData.InteractActionDesc.NeedBlackOut == EGSYesNo.Yes)
		{
			BlackOutTimer = 0f;
			BGW_EventCollection.Get(Context.OwnerController).Evt_ActiveBlackOut(IsActive: true);
		}
		else if (Context.PlayerInteractData.InteractActionDesc.MatchingPosType == EMatchingPosType.OnlyRotation)
		{
			APawn controlledPawn = Context.OwnerController.GetControlledPawn();
			MoveMode = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_MovementModes>(controlledPawn);
			BUS_EventCollectionCS.Get(controlledPawn)?.Evt_ActorRotateToTarget.Invoke(aActor, 200f);
		}
		else
		{
			CalcMatchingPosition();
		}
	}

	private void CalcMatchingPosition()
	{
		AActor aActor = EntitySharedRefFuncLib.Actor(Context.PlayerInteractData.BestInteractEntityRef);
		if (Context.PlayerInteractData.InteractActionDesc != null && Context.PlayerInteractData.InteractActionDesc.InteractAction == EInteractAction.DummyMeshAnim)
		{
			FName fName = new FName(Context.PlayerInteractData.InteractActionDesc.ParamsString[1]);
			BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, aActor, fName, out var SocketOwnerComp);
			USkeletalMeshComponent uSkeletalMeshComponent = SocketOwnerComp as USkeletalMeshComponent;
			if (uSkeletalMeshComponent != null)
			{
				UAnimationAsset animation = BGW_PreloadAssetMgr.Get(Context.OwnerController).TryGetCachedResourceObj<UAnimationAsset>(Context.PlayerInteractData.InteractActionDesc.ParamsString[2], ELoadResourceType.SyncLoadAndCache);
				uSkeletalMeshComponent.SetAnimationMode(EAnimationMode.AnimationSingleNode);
				uSkeletalMeshComponent.SetAnimation(animation);
				UGSE_AnimFuncLib.TickAnimationAndRefreshBone_SkeletalMesh(uSkeletalMeshComponent);
				Context.PlayerInteractData.MatchingPointDummyMesh = uSkeletalMeshComponent;
				Context.PlayerInteractData.MatchingPointDummyMeshSocket = fName;
				return;
			}
		}
		USceneComponent uSceneComponent = null;
		List<UActorComponent> list = aActor.GetComponentsByTag(Tag: new FName(Context.PlayerInteractData.InteractActionDesc.MathchingPointCompTag), ComponentClass: UClass.GetClass<USceneComponent>());
		if (list.Count != 0)
		{
			uSceneComponent = list[0] as USceneComponent;
		}
		USceneComponent uSceneComponent2 = null;
		List<UActorComponent> componentsByTag = aActor.GetComponentsByTag(UClass.GetClass<USceneComponent>(), B1GlobalFNames.GSInteractRangeAnchor);
		if (componentsByTag.Count != 0)
		{
			uSceneComponent2 = componentsByTag[0] as USceneComponent;
		}
		if (!(uSceneComponent != null))
		{
			return;
		}
		if (Context.PlayerInteractData.InteractActionDesc.IsMatchingPointTraceToPlayer == EGSYesNo.Yes)
		{
			FTransform fTransform = ((uSceneComponent2 != null) ? uSceneComponent2.GetWorldTransform() : BGUFuncLibActorTransformCS.BGUGetActorTransform(aActor));
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Context.OwnerController.GetControlledPawn());
			FVector location = fTransform.GetLocation();
			FVector worldLocation = uSceneComponent.GetWorldLocation();
			FVector relativeLocation = uSceneComponent.RelativeLocation;
			FRotator relativeRotation = uSceneComponent.RelativeRotation;
			FVector2D unit2TargetDir = new FVector2D(fVector - location);
			FVector2D unitRotateAimDir = new FVector2D(worldLocation - location);
			float num = BGU_MoveUtil.GetRotateAngle2D(unitRotateAimDir, unit2TargetDir);
			if (!BGU_MoveUtil.IsRotateClockwise(unitRotateAimDir, unit2TargetDir))
			{
				num *= -1f;
			}
			relativeLocation = relativeLocation.RotateAngleAxis(num, new FVector(0.0, 0.0, 1.0));
			relativeRotation.Yaw += num;
			uSceneComponent.SetRelativeLocation(relativeLocation, bSweep: false, out var SweepHitResult, bTeleport: false);
			uSceneComponent.SetRelativeRotation(relativeRotation, bSweep: false, out SweepHitResult, bTeleport: false);
		}
		TriggerMatchingPosition(uSceneComponent.GetWorldTransform(), Context.PlayerInteractData.InteractActionDesc);
	}

	public override void OnTick(float DeltaTime)
	{
		base.OnTick(DeltaTime);
		BlackOutTimer += DeltaTime;
		if (BlackOutTimer >= BLACK_OUT_TIME && Context.PlayerInteractData.InteractActionDesc != null && Context.PlayerInteractData.InteractActionDesc.NeedBlackOut == EGSYesNo.Yes)
		{
			CalcMatchingPosition();
		}
		if (Context.PlayerInteractData.InteractActionDesc.MatchingPosType == EMatchingPosType.OnlyRotation)
		{
			if (MoveMode == null)
			{
				TriggerFinish(InteractStepResult.Failure);
			}
			if (!(MoveMode.ActiveMover is BGU_StandAndRotateMoveMode))
			{
				TriggerFinish(InteractStepResult.Success);
			}
		}
		else
		{
			if (!(Context.PlayerInteractData.MatchingPointDummyMesh != null))
			{
				return;
			}
			if (DummyMeshTimer < DUMMY_WAIT_FRAME)
			{
				DummyMeshTimer++;
				return;
			}
			DummyMeshTimer = 0;
			USkeletalMeshComponent matchingPointDummyMesh = Context.PlayerInteractData.MatchingPointDummyMesh;
			Context.PlayerInteractData.MatchingPointDummyMesh = null;
			if (ECSExtension.ToActor(Context.PlayerInteractData.CurrentInteractingEntityRef) == null)
			{
				TriggerFinish(InteractStepResult.Failure);
			}
			else
			{
				TriggerMatchingPosition(matchingPointDummyMesh.GetSocketTransform(Context.PlayerInteractData.MatchingPointDummyMeshSocket), Context.PlayerInteractData.InteractActionDesc);
			}
		}
	}

	private void TriggerMatchingPosition(FTransform TargetTrans, in FUStInteractionMappingDesc InteractActionDesc)
	{
		if (!Context.OwnerController.IsNullOrDestroyed() && !Context.OwnerController.GetControlledPawn().IsNullOrDestroyed())
		{
			TargetTrans.SetScale3D(Context.OwnerController.GetControlledPawn().GetActorScale3D());
		}
		else
		{
			TargetTrans.SetScale3D(new FVector(1f));
		}
		Context.PlayerInteractData.MatchingPosTargetTransform = TargetTrans;
		FMatchingPositionMoveParam Param = new FMatchingPositionMoveParam
		{
			MatchingPosType = InteractActionDesc.MatchingPosType,
			TargetTrans = Context.PlayerInteractData.MatchingPosTargetTransform,
			MoveSpeedType = (EAIMoveSpeedType)InteractActionDesc.MatchingPosMoveSpeedType,
			bFacingTargetRotation = (InteractActionDesc.MatchingPosFacingTarget == EGSYesNo.Yes),
			bIncludeSelfRadius = false,
			AcceptableRadius = InteractActionDesc.AcceptableRadius,
			InterpMoveTime = InteractActionDesc.InterpMoveTime
		};
		if (InteractActionDesc.InteractAction == EInteractAction.RebirthPoint && Param.InterpMoveTime > 0f)
		{
			Param.InterpMoveCallbackFunc = OnInteractMatchingPosFinish;
		}
		else
		{
			Param.AIPathMoveCallbackFunc = OnInteractMatchingPosFinish;
		}
		BUS_EventCollectionCS.Get(Context.OwnerController.GetControlledPawn()).Evt_MatchingPositionMove.Invoke(in Param);
	}

	private void OnInteractMatchingPosFinish(bool bSuccess)
	{
		if (!bSuccess)
		{
			ACharacter aCharacter = Context.OwnerController.GetControlledPawn() as ACharacter;
			if (!aCharacter.IsNullOrDestroyed())
			{
				FTransform matchingPosTargetTransform = Context.PlayerInteractData.MatchingPosTargetTransform;
				FVector location = Context.PlayerInteractData.MatchingPosTargetTransform.GetLocation();
				UCapsuleComponent capsuleComponent = aCharacter.CapsuleComponent;
				float scaledCapsuleHalfHeight = capsuleComponent.GetScaledCapsuleHalfHeight();
				float scaledCapsuleRadius = capsuleComponent.GetScaledCapsuleRadius();
				FVector start = location + FVector.UpVector * scaledCapsuleHalfHeight * 2.0;
				FVector end = location - FVector.UpVector * scaledCapsuleHalfHeight * 2.0;
				if (UGSE_TraceFuncLib.CharacterCapsuleTraceSingleByProfile(aCharacter, start, end, scaledCapsuleRadius, scaledCapsuleHalfHeight, B1GlobalFNames.Pawn, bTraceComplex: false, aCharacter, out var OutHitLocation))
				{
					location = OutHitLocation;
					location.Z += 2.4f;
					matchingPosTargetTransform.SetLocation(location);
				}
				BUS_EventCollectionCS.Get(aCharacter).Evt_SetActorTransform.Invoke(matchingPosTargetTransform, bSweep: false, bTeleport: true);
			}
		}
		StepFinish();
	}

	public override void StepFinish()
	{
		base.StepFinish();
		BGUFunctionLibraryCS.BGUAIChangeToTargetSpeedRate(Context.OwnerController.GetControlledPawn(), EAIMoveSpeedType.RUN);
		if (!BGW_LogUtil.LogIfNull(ECSExtension.ToActor(Context.PlayerInteractData.CurrentInteractingEntityRef), "Interact target {0} is null!!!", Context.PlayerInteractData.CurrentInteractingEntityRef))
		{
			if (Context.PlayerInteractData.InteractActionDesc != null && Context.PlayerInteractData.InteractActionDesc.NeedBlackOut == EGSYesNo.Yes)
			{
				BGW_EventCollection.Get(Context.OwnerController).Evt_ActiveBlackOut(IsActive: false);
			}
			TriggerFinish(InteractStepResult.Success);
		}
	}

	protected override void OnTimeOut()
	{
		base.OnTimeOut();
		if (Context.PlayerInteractData != null && Context.PlayerInteractData.InteractActionDesc != null && Context.PlayerInteractData.InteractActionDesc.MatchingPosType != EMatchingPosType.OnlyRotation && Context.PlayerInteractData.MatchingPosTargetTransform.Translation != FVector.ZeroVector)
		{
			BUS_EventCollectionCS.Get(Context.OwnerController.GetControlledPawn()).Evt_TeleportMoveByTrans.Invoke(Context.PlayerInteractData.MatchingPosTargetTransform);
		}
		StepFinish();
	}
}
