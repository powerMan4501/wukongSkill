using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ManualSplineMoveCompImpl")]
public class BUS_ManualSplineMoveCompImpl : UActorCompBaseUObj
{
	private BUC_ManualSplineMoveData ManualSplineMoveData;

	private IBUC_TickRateData TickRateData;

	private IBUC_MovementData MovementData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_PropMgrData PropMgrData;

	private IBUC_ABPCharacterData ChrData;

	private IBUC_MagicallyChangeData MagicallyChangeData;

	private IBPC_PlayerTagData PlayerTagData;

	private const ECollisionChannel AirWallChannel = ECollisionChannel.ECC_GameTraceChannel16;

	private const int ManualSplineMoveWithSpecialAnimationBuffID = 319;

	private static bool OnCollisionEndOverlap_IsValid;

	private static IntPtr OnCollisionEndOverlap_FunctionAddress;

	private static int OnCollisionEndOverlap_ParamsSize;

	private static bool OnCollisionEndOverlap_OverlappedComponent_IsValid;

	private static int OnCollisionEndOverlap_OverlappedComponent_Offset;

	private static bool OnCollisionEndOverlap_OtherActor_IsValid;

	private static int OnCollisionEndOverlap_OtherActor_Offset;

	private static bool OnCollisionEndOverlap_OtherComp_IsValid;

	private static int OnCollisionEndOverlap_OtherComp_Offset;

	private static bool OnCollisionEndOverlap_OtherBodyIndex_IsValid;

	private static int OnCollisionEndOverlap_OtherBodyIndex_Offset;

	private static bool OnCollisionBeginOverlap_IsValid;

	private static IntPtr OnCollisionBeginOverlap_FunctionAddress;

	private static int OnCollisionBeginOverlap_ParamsSize;

	private static bool OnCollisionBeginOverlap_OverlappedComponent_IsValid;

	private static int OnCollisionBeginOverlap_OverlappedComponent_Offset;

	private static bool OnCollisionBeginOverlap_OtherActor_IsValid;

	private static int OnCollisionBeginOverlap_OtherActor_Offset;

	private static bool OnCollisionBeginOverlap_OtherComp_IsValid;

	private static int OnCollisionBeginOverlap_OtherComp_Offset;

	private static bool OnCollisionBeginOverlap_OtherBodyIndex_IsValid;

	private static int OnCollisionBeginOverlap_OtherBodyIndex_Offset;

	private static bool OnCollisionBeginOverlap_bFromSweep_IsValid;

	private static int OnCollisionBeginOverlap_bFromSweep_Offset;

	private static FFieldAddress OnCollisionBeginOverlap_bFromSweep_PropertyAddress;

	private static bool OnCollisionBeginOverlap_SweepResult_IsValid;

	private static int OnCollisionBeginOverlap_SweepResult_Offset;

	private static FFieldAddress OnCollisionBeginOverlap_SweepResult_PropertyAddress;

	public override void OnAttach()
	{
		ManualSplineMoveData = RequireWritableData<BUC_ManualSplineMoveData>();
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
		MovementData = RequireReadOnlyData<IBUC_MovementData, BUC_MovementData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		PropMgrData = RequireReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>();
		ChrData = RequireReadOnlyData<IBUC_ABPCharacterData, BUC_ABPCharacterData>();
		MagicallyChangeData = RequireReadOnlyData<IBUC_MagicallyChangeData, BUC_MagicallyChangeData>();
		PlayerTagData = RequireReadOnlyControledPlayerStateData<IBPC_PlayerTagData, BPC_PlayerTagData>();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(this);
		bUS_GSEventCollection.Evt_BeginManualSplineMoveWithSpecialAnimation += new Del_BeginManualSplineMoveWithSpecialAnimation(OnBeginManualSplineMoveWithSpecialAnimation);
		bUS_GSEventCollection.Evt_PlayMontageCallback += new Del_PlayMontageCallback(OnPlayMontageCallback);
		bUS_GSEventCollection.Evt_TriggerSplineMoveDBC += new Del_Void(OnTriggerSplineMoveDBC);
	}

	public override void OnBeginPlay()
	{
		FUStPlayerCommDesc playerCommDesc = BGW_GameDB.GetPlayerCommDesc(GetActorResID(), Owner);
		if (playerCommDesc == null)
		{
			return;
		}
		ManualSplineMoveData.MaxInputAngle = playerCommDesc.ManualSplineMoveMaxInputAngle;
		ManualSplineMoveData.CameraTraceVelocitySpeedRate = playerCommDesc.ManualSplineMoveCameraTraceSpeedRate;
		ManualSplineMoveData.CameraPauseTime = playerCommDesc.ManualSplineMoveCameraPauseTime;
		ManualSplineMoveData.MaxInputAngleCosValue = FMath.Cos(FMath.DegreesToRadians(ManualSplineMoveData.MaxInputAngle));
		if (!(ManualSplineMoveData.MaxInputAngle > 0f) || !(GetOwner() is ACharacter aCharacter))
		{
			return;
		}
		UBGUFunctionLibraryForCS.BGUBindOnComponentBeginOverlapEvent(aCharacter.CapsuleComponent, this, B1GlobalFNames.OnCollisionBeginOverlap);
		UBGUFunctionLibraryForCS.BGUBindOnComponentEndOverlapEvent(aCharacter.CapsuleComponent, this, B1GlobalFNames.OnCollisionEndOverlap);
		aCharacter.CapsuleComponent.GetOverlappingComponents(out var OutOverlappingComponents);
		foreach (UPrimitiveComponent item in OutOverlappingComponents)
		{
			OnCollisionBeginOverlap(aCharacter.CapsuleComponent, item.GetOwner(), item, 0, bFromSweep: false, default(FHitResult));
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		if (ManualSplineMoveData.MaxInputAngle > 0f && GetOwner() is ACharacter aCharacter)
		{
			UBGUFunctionLibraryForCS.BGUUnBindOnComponentBeginOverlapEvent(aCharacter.CapsuleComponent, this, B1GlobalFNames.OnCollisionBeginOverlap);
			UBGUFunctionLibraryForCS.BGUUnBindOnComponentEndOverlapEvent(aCharacter.CapsuleComponent, this, B1GlobalFNames.OnCollisionEndOverlap);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		switch (ManualSplineMoveData.CurrentManualSplineMoveType)
		{
		case EManualSplineMoveType.OnlyMove:
			TickOnlyMove(DeltaTime);
			break;
		case EManualSplineMoveType.MoveWithSpecialAnimation:
			TickMoveWithSpecialAnimation(DeltaTime);
			break;
		}
	}

	private void TickOnlyMove(float DeltaTime)
	{
		if (!(ManualSplineMoveData.MaxInputAngle <= 0f) && !(ManualSplineMoveData.SplineComp == null))
		{
			UpdateCurSplineInputKey();
			if (TickRateData.CanTickFor200msInterval(out var _, out var _, out var _, out var _, out var _))
			{
				UpdateOverlappedManualSplineMoveState();
			}
		}
	}

	private void TickMoveWithSpecialAnimation(float DeltaTime)
	{
		if (ManualSplineMoveData.SplineComp == null)
		{
			return;
		}
		bool flag = ManualSplineMoveData.CurrentManualSplineMoveStage != EManualSplineMoveStage.None && ManualSplineMoveData.CurrentManualSplineMoveStage != EManualSplineMoveStage.End;
		if (flag)
		{
			UpdateCurSplineInputKey();
			UpdateManualSplineMoveDirection();
			UpdateRotationBlend(DeltaTime);
		}
		if (!UnitStateData.HasState(EBGUUnitState.Attacking) && !UnitStateData.HasState(EBGUUnitState.Beatback) && (PlayerTagData == null || !PlayerTagData.HasTag(EBGPPlayerTag.Transforming)) && !MagicallyChangeData.IsDurMagicallyChange() && TickRateData.CanTickFor200msInterval(out var _, out var _, out var _, out var _, out var _))
		{
			if (flag)
			{
				UpdateEndManualSplineMoveState();
			}
			else
			{
				UpdateOverlappedManualSplineMoveState();
			}
		}
	}

	private void OnBeginManualSplineMoveWithSpecialAnimation(USplineComponent TargetSpline, BGWDataAsset_ManualSplineMoveAnimConfig MoveAnimConfig)
	{
		BeginManualSplineMoveWithSpecialAnimation(TargetSpline, MoveAnimConfig, EManualSplineMoveTriggerType.Manual);
	}

	private void BeginManualSplineMoveWithSpecialAnimation(USplineComponent TargetSpline, BGWDataAsset_ManualSplineMoveAnimConfig MoveAnimConfig, EManualSplineMoveTriggerType TriggerType)
	{
		ManualSplineMoveData.SplineComp = TargetSpline;
		ManualSplineMoveData.MoveAnimConfig = MoveAnimConfig;
		ManualSplineMoveData.TriggerType = TriggerType;
		ManualSplineMoveData.CurrentManualSplineMoveType = EManualSplineMoveType.MoveWithSpecialAnimation;
		ManualSplineMoveData.DirectionType = MoveAnimConfig.DirectionType;
		ManualSplineMoveData.LockDirectionDeltaAngle = MoveAnimConfig.LockDirectionDeltaAngle;
		ManualSplineMoveData.SplineMoveMaxSpeed = MoveAnimConfig.MaxWalkSpeed;
		ManualSplineMoveData.SplineMoveMaxAcceleration = MoveAnimConfig.MaxAcceleration;
		ManualSplineMoveData.bManualSplineMoving = true;
		ManualSplineMoveData.bBeginWithSplineDirection = IsBeginWithSplineDirection(TargetSpline);
		ManualSplineMoveData.bMoveForward = true;
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(this);
		bool flag = false;
		if (!ManualSplineMoveData.MoveAnimConfig.AMBeginMove.IsNullOrDestroyed())
		{
			BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, ManualSplineMoveData.MoveAnimConfig.AMBeginMove, FName.None, EMontageBindReason.ManualSplineMove);
			bUS_GSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AttackStateBegin, -1f);
			bUS_GSEventCollection.Evt_SetSplineMoveAnimConfig.Invoke(ManualSplineMoveData.MoveAnimConfig);
			flag = true;
		}
		bUS_GSEventCollection.Evt_BuffAdd.Invoke(319, Owner, Owner, 0f, EBuffSourceType.ManualSplineMove);
		bUS_GSEventCollection.Evt_SetIsEnableCollisionHitMove.Invoke(IsEnableCollisionHitMove: false, ECollisionHitMoveEnableReqType.ManualSplineMove);
		Dictionary<ECollisionChannel, ECollisionResponseType> value = new Dictionary<ECollisionChannel, ECollisionResponseType> { 
		{
			ECollisionChannel.ECC_GameTraceChannel16,
			ECollisionResponseType.ECR_Ignore
		} };
		if (ManualSplineMoveData.CollisionResponseHandleID == 0)
		{
			bUS_GSEventCollection.Evt_SetCollisionResponseProperty.Invoke(EPropType.Capsule_CollisionResponseToChannels, value);
			ManualSplineMoveData.CollisionResponseHandleID = PropMgrData.GetLastHandleID();
		}
		else
		{
			bUS_GSEventCollection.Evt_SetCollisionResponseProperty.Invoke(EPropType.Capsule_CollisionResponseToChannels, value, ManualSplineMoveData.CollisionResponseHandleID);
		}
		ManualSplineMoveData.CurrentManualSplineMoveStage = (flag ? EManualSplineMoveStage.Begin : EManualSplineMoveStage.Moving);
		SetCameraBlockEnable(bEnabled: false);
	}

	private bool IsBeginWithSplineDirection(USplineComponent TargetSpline)
	{
		if (TargetSpline == null)
		{
			return false;
		}
		FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner());
		FVector locationAtSplineInputKey = TargetSpline.GetLocationAtSplineInputKey(0f, ESplineCoordinateSpace.World);
		FVector locationAtSplineInputKey2 = TargetSpline.GetLocationAtSplineInputKey(TargetSpline.GetNumberOfSplinePoints() - 1, ESplineCoordinateSpace.World);
		return FVector.Dist(v, locationAtSplineInputKey) <= FVector.Dist(v, locationAtSplineInputKey2);
	}

	private void OnPlayMontageCallback(EMontageBindReason Reason, UAnimMontage Montage, EMontageCallbackState State)
	{
		if (Reason != EMontageBindReason.ManualSplineMove)
		{
			return;
		}
		switch (State)
		{
		case EMontageCallbackState.OnBlendOut:
		case EMontageCallbackState.OnInterrupted:
			if (Montage == ManualSplineMoveData.MoveAnimConfig.AMBeginMove)
			{
				ManualSplineMoveData.CurrentManualSplineMoveStage = EManualSplineMoveStage.Moving;
			}
			if (Montage == ManualSplineMoveData.MoveAnimConfig.AMEndMoveForward || Montage == ManualSplineMoveData.MoveAnimConfig.AMEndMoveBackward)
			{
				ResetManualSplineMoveWithSpecialAnimData();
			}
			break;
		case EMontageCallbackState.OnStarted:
			if (Montage == ManualSplineMoveData.MoveAnimConfig.AMBeginMove)
			{
				ManualSplineMoveData.RotationBlendTimer = ManualSplineMoveData.MoveAnimConfig.RotationBlendTime;
			}
			break;
		}
	}

	private void ResetManualSplineMoveWithSpecialAnimData()
	{
		SetCameraBlockEnable(bEnabled: true);
		ManualSplineMoveData.bManualSplineMoving = false;
		ManualSplineMoveData.RotationBlendTimer = 0f;
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(this);
		bUS_GSEventCollection.Evt_BuffRemove.Invoke(319, EBuffEffectTriggerType.None, 1);
		bUS_GSEventCollection.Evt_ResetIsEnableCollisionHitMove.Invoke(ECollisionHitMoveEnableReqType.ManualSplineMove);
		bUS_GSEventCollection.Evt_ResetProperty.Invoke(ManualSplineMoveData.CollisionResponseHandleID);
		ManualSplineMoveData.CollisionResponseHandleID = 0u;
		ManualSplineMoveData.TriggerType = EManualSplineMoveTriggerType.None;
		ManualSplineMoveData.CurrentManualSplineMoveStage = EManualSplineMoveStage.None;
		if (!ManualSplineMoveData.IsOverlapedVolume())
		{
			ManualSplineMoveData.SplineComp = null;
			ManualSplineMoveData.CurrentManualSplineMoveType = EManualSplineMoveType.None;
		}
	}

	private void UpdateCurSplineInputKey()
	{
		USplineComponent splineComp = ManualSplineMoveData.SplineComp;
		ManualSplineMoveData.CurSplineInputKey = splineComp.FindInputKeyClosestToWorldLocation(BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner()));
		if (ManualSplineMoveData.CurSplineInputKey == (float)splineComp.GetNumberOfSplinePoints() - 1f)
		{
			ManualSplineMoveData.CurSplineInputKey -= 0.001f;
		}
	}

	private void UpdateManualSplineMoveDirection()
	{
		USplineComponent splineComp = ManualSplineMoveData.SplineComp;
		ManualSplineMoveData.CurSplineMoveForwardDir = splineComp.GetDirectionAtSplineInputKey(ManualSplineMoveData.CurSplineInputKey, ESplineCoordinateSpace.World).GetSafeNormal();
		ManualSplineMoveData.CurSplineMoveForwardDir = (ManualSplineMoveData.bBeginWithSplineDirection ? ManualSplineMoveData.CurSplineMoveForwardDir : (-ManualSplineMoveData.CurSplineMoveForwardDir));
		if (!ChrData.MoveAcceleration.IsZero())
		{
			ManualSplineMoveData.bMoveForward = FVector.DotProduct(ChrData.MoveAcceleration.GetSafeNormal(), ManualSplineMoveData.CurSplineMoveForwardDir) >= 0f;
		}
	}

	private void UpdateRotationBlend(float DeltaTime)
	{
		if (!(ManualSplineMoveData.RotationBlendTimer <= 0f))
		{
			ManualSplineMoveData.RotationBlendTimer -= DeltaTime;
			if (ManualSplineMoveData.RotationBlendTimer <= 0f)
			{
				ManualSplineMoveData.RotationBlendTimer = 0f;
			}
			float rotationBlendTime = ManualSplineMoveData.MoveAnimConfig.RotationBlendTime;
			if (!(rotationBlendTime <= 0f))
			{
				float alpha = (rotationBlendTime - ManualSplineMoveData.RotationBlendTimer) / rotationBlendTime;
				FRotator newRotation = UMathLibrary.RLerp(BGUFuncLibActorTransformCS.BGUGetActorRotation(Owner), ManualSplineMoveData.CurSplineMoveForwardDir.GetSafeNormal2D().Rotation(), alpha, bShortestPath: true);
				BGUFuncLibActorTransformCS.BGUSetActorRotation(Owner, newRotation, bTeleportPhysics: false);
			}
		}
	}

	private void UpdateOverlappedManualSplineMoveState()
	{
		if (ManualSplineMoveData.TriggerType != EManualSplineMoveTriggerType.None && ManualSplineMoveData.TriggerType != EManualSplineMoveTriggerType.Overlap)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(this);
		bool flag = ShouldEnterOverlappedManualSplineMove();
		if (!ManualSplineMoveData.bManualSplineMoving && flag)
		{
			if (ManualSplineMoveData.CurrentManualSplineMoveType == EManualSplineMoveType.OnlyMove)
			{
				ManualSplineMoveData.bManualSplineMoving = true;
				ManualSplineMoveData.TriggerType = EManualSplineMoveTriggerType.Overlap;
				ManualSplineMoveData.CurrentManualSplineMoveStage = EManualSplineMoveStage.Moving;
				bUS_GSEventCollection.Evt_SetTraceVelocityCameraInfo.Invoke(bUseTraceVelocityCamera: true, ManualSplineMoveData.CameraTraceVelocitySpeedRate, bOnlyYaw: true, 90f, ManualSplineMoveData.CameraPauseTime);
			}
			else
			{
				BeginManualSplineMoveWithSpecialAnimation(ManualSplineMoveData.SplineComp, ManualSplineMoveData.MoveAnimConfig, EManualSplineMoveTriggerType.Overlap);
			}
		}
		if (ManualSplineMoveData.bManualSplineMoving && !flag)
		{
			if (ManualSplineMoveData.CurrentManualSplineMoveType == EManualSplineMoveType.OnlyMove)
			{
				ManualSplineMoveData.bManualSplineMoving = false;
				ManualSplineMoveData.TriggerType = EManualSplineMoveTriggerType.None;
				ManualSplineMoveData.CurrentManualSplineMoveStage = EManualSplineMoveStage.None;
				bUS_GSEventCollection.Evt_SetTraceVelocityCameraInfo.Invoke(bUseTraceVelocityCamera: false, 0f);
			}
			else
			{
				EndManualSplineMoveWithSpecialAnimation();
			}
		}
	}

	private void UpdateEndManualSplineMoveState()
	{
		if (ManualSplineMoveData.TriggerType == EManualSplineMoveTriggerType.Manual)
		{
			USplineComponent splineComp = ManualSplineMoveData.SplineComp;
			float num;
			FVector a;
			if (ManualSplineMoveData.bBeginWithSplineDirection)
			{
				num = (ManualSplineMoveData.bMoveForward ? ((float)splineComp.GetNumberOfSplinePoints() - 1.001f) : 0f);
				a = (ManualSplineMoveData.bMoveForward ? splineComp.GetDirectionAtSplineInputKey(num, ESplineCoordinateSpace.World) : (-splineComp.GetDirectionAtSplineInputKey(num, ESplineCoordinateSpace.World)));
			}
			else
			{
				num = (ManualSplineMoveData.bMoveForward ? 0f : ((float)splineComp.GetNumberOfSplinePoints() - 1.001f));
				a = (ManualSplineMoveData.bMoveForward ? (-splineComp.GetDirectionAtSplineInputKey(num, ESplineCoordinateSpace.World)) : splineComp.GetDirectionAtSplineInputKey(num, ESplineCoordinateSpace.World));
			}
			a.Normalize();
			FVector b = BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner()) - splineComp.GetLocationAtSplineInputKey(num, ESplineCoordinateSpace.World);
			b.Normalize();
			if (FMath.Abs(ManualSplineMoveData.CurSplineInputKey - num) <= 0.1f && FVector.DotProduct(a, b) >= 0f && !ChrData.MoveAcceleration.IsZero() && FMath.Abs(ChrData.MoveAcceleration.Rotation().NormalizedDeltaRotator(a.Rotation()).Yaw) <= 10f)
			{
				EndManualSplineMoveWithSpecialAnimation();
			}
		}
	}

	private void EndManualSplineMoveWithSpecialAnimation()
	{
		bool flag = false;
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(this);
		if (ManualSplineMoveData.bMoveForward)
		{
			if (!ManualSplineMoveData.MoveAnimConfig.AMEndMoveForward.IsNullOrDestroyed())
			{
				BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, ManualSplineMoveData.MoveAnimConfig.AMEndMoveForward, FName.None, EMontageBindReason.ManualSplineMove);
				bUS_GSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AttackStateBegin, -1f);
				flag = true;
			}
		}
		else if (!ManualSplineMoveData.MoveAnimConfig.AMEndMoveBackward.IsNullOrDestroyed())
		{
			BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, ManualSplineMoveData.MoveAnimConfig.AMEndMoveBackward, FName.None, EMontageBindReason.ManualSplineMove);
			bUS_GSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AttackStateBegin, -1f);
			flag = true;
		}
		if (flag)
		{
			ManualSplineMoveData.CurrentManualSplineMoveStage = EManualSplineMoveStage.End;
		}
		else
		{
			ResetManualSplineMoveWithSpecialAnimData();
		}
	}

	private bool ShouldEnterOverlappedManualSplineMove()
	{
		if (!(GetOwner() is ACharacter ownerChr))
		{
			return false;
		}
		if (ManualSplineMoveData.SplineComp == null)
		{
			return false;
		}
		if (!ManualSplineMoveData.IsOverlapedVolume())
		{
			return false;
		}
		if (ManualSplineMoveData.CurrentManualSplineMoveType != EManualSplineMoveType.OnlyMove)
		{
			return true;
		}
		FVector safeNormal2D = MovementData.GetCurrentWorldInputVec(ownerChr).GetSafeNormal2D();
		FVector safeNormal2D2 = ManualSplineMoveData.SplineComp.GetDirectionAtSplineInputKey(ManualSplineMoveData.CurSplineInputKey, ESplineCoordinateSpace.World).GetSafeNormal2D();
		if (!(FVector.DotProduct(safeNormal2D, safeNormal2D2) >= ManualSplineMoveData.MaxInputAngleCosValue))
		{
			return FVector.DotProduct(safeNormal2D, -safeNormal2D2) >= ManualSplineMoveData.MaxInputAngleCosValue;
		}
		return true;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_ManualSplineMoveCompImpl:OnCollisionBeginOverlap")]
	private void OnCollisionBeginOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
	{
		USplineComponent uSplineComponent = CheckAndReturnTargetSpline(OtherActor);
		if (uSplineComponent == null)
		{
			return;
		}
		ManualSplineMoveData.OverlapCount++;
		ManualSplineMoveData.SplineComp = uSplineComponent;
		if (OtherActor is BGUManualSplineMoveVolume)
		{
			b1.IBUC_ManualSplineMoveVolumeData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_ManualSplineMoveVolumeData, BUC_ManualSplineMoveVolumeData>(OtherActor);
			if (unPersistentReadOnlyData != null)
			{
				BGWDataAsset_ManualSplineMoveAnimConfig bGWDataAsset_ManualSplineMoveAnimConfig = (IsBeginWithSplineDirection(uSplineComponent) ? unPersistentReadOnlyData.ForwardSplineAnimConfig : unPersistentReadOnlyData.ReverseSplineAnimConfig);
				if (bGWDataAsset_ManualSplineMoveAnimConfig != null)
				{
					ManualSplineMoveData.CurrentManualSplineMoveType = EManualSplineMoveType.MoveWithSpecialAnimation;
					ManualSplineMoveData.MoveAnimConfig = bGWDataAsset_ManualSplineMoveAnimConfig;
					return;
				}
			}
		}
		ManualSplineMoveData.CurrentManualSplineMoveType = EManualSplineMoveType.OnlyMove;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_ManualSplineMoveCompImpl:OnCollisionEndOverlap")]
	private void OnCollisionEndOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
	{
		if (!ManualSplineMoveData.IsOverlapedVolume())
		{
			return;
		}
		USplineComponent uSplineComponent = CheckAndReturnTargetSpline(OtherActor);
		if (uSplineComponent == null)
		{
			return;
		}
		ManualSplineMoveData.OverlapCount--;
		if (!(uSplineComponent != ManualSplineMoveData.SplineComp))
		{
			ManualSplineMoveData.SplineComp = null;
			UpdateOverlappedManualSplineMoveState();
			if (ManualSplineMoveData.CurrentManualSplineMoveType == EManualSplineMoveType.OnlyMove)
			{
				ManualSplineMoveData.CurrentManualSplineMoveType = EManualSplineMoveType.None;
			}
		}
	}

	private USplineComponent CheckAndReturnTargetSpline(AActor OverlappedActor)
	{
		if (!OverlappedActor.ActorHasTag(B1GlobalFNames.ManualSplineMoveOverlapVolume))
		{
			return null;
		}
		AActor attachParentActor = OverlappedActor.GetAttachParentActor();
		if (attachParentActor == null)
		{
			return null;
		}
		return attachParentActor.GetComponentByClass<USplineComponent>();
	}

	private void OnTriggerSplineMoveDBC()
	{
		BGWDataAsset_B1DBC bGWDataAsset_B1DBC = null;
		switch (ManualSplineMoveData.CurrentManualSplineMoveStage)
		{
		case EManualSplineMoveStage.Begin:
			bGWDataAsset_B1DBC = ManualSplineMoveData.MoveAnimConfig.BeginMoveDBC;
			break;
		case EManualSplineMoveStage.Moving:
			bGWDataAsset_B1DBC = ManualSplineMoveData.MoveAnimConfig.MovingDBC;
			break;
		case EManualSplineMoveStage.End:
			bGWDataAsset_B1DBC = ManualSplineMoveData.MoveAnimConfig.EndMoveDBC;
			break;
		}
		if (!(bGWDataAsset_B1DBC == null))
		{
			BUS_EventCollectionCS.Get(this).Evt_RequestSpawnFXByDispConfigDA.Invoke(bGWDataAsset_B1DBC, out var _);
		}
	}

	private void SetCameraBlockEnable(bool bEnabled)
	{
		if (ManualSplineMoveData.SplineComp == null)
		{
			return;
		}
		foreach (UStaticMeshComponent item in ManualSplineMoveData.SplineComp.GetOwner().GetComponentsByTag(UClass.GetClass<UStaticMeshComponent>(), B1GlobalFNames.CameraBlock))
		{
			item?.SetCollisionEnabled(bEnabled ? ECollisionEnabled.QueryAndPhysics : ECollisionEnabled.NoCollision);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_ManualSplineMoveCompImpl:OnCollisionEndOverlap")]
	private static void OnCollisionEndOverlap__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_ManualSplineMoveCompImpl bUS_ManualSplineMoveCompImpl = GCHelper.Find<BUS_ManualSplineMoveCompImpl>(obj);
		UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OverlappedComponent_Offset));
		AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OtherActor_Offset));
		UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OtherComp_Offset));
		int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OtherBodyIndex_Offset));
		bUS_ManualSplineMoveCompImpl.OnCollisionEndOverlap(overlappedComponent, otherActor, otherComp, otherBodyIndex);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_ManualSplineMoveCompImpl:OnCollisionBeginOverlap")]
	private static void OnCollisionBeginOverlap__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_ManualSplineMoveCompImpl bUS_ManualSplineMoveCompImpl = GCHelper.Find<BUS_ManualSplineMoveCompImpl>(obj);
		UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OverlappedComponent_Offset));
		AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OtherActor_Offset));
		UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OtherComp_Offset));
		int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OtherBodyIndex_Offset));
		bool bFromSweep = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_bFromSweep_Offset), 0, OnCollisionBeginOverlap_bFromSweep_PropertyAddress.Address);
		FHitResult sweepResult = FHitResult.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_SweepResult_Offset));
		bUS_ManualSplineMoveCompImpl.OnCollisionBeginOverlap(overlappedComponent, otherActor, otherComp, otherBodyIndex, bFromSweep, sweepResult);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUS_ManualSplineMoveCompImpl");
		OnCollisionEndOverlap_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnCollisionEndOverlap");
		OnCollisionEndOverlap_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCollisionEndOverlap_FunctionAddress);
		OnCollisionEndOverlap_OverlappedComponent_Offset = NativeReflection.GetPropertyOffset(OnCollisionEndOverlap_FunctionAddress, "OverlappedComponent");
		OnCollisionEndOverlap_OverlappedComponent_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionEndOverlap_FunctionAddress, "OverlappedComponent", Classes.FObjectProperty);
		OnCollisionEndOverlap_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnCollisionEndOverlap_FunctionAddress, "OtherActor");
		OnCollisionEndOverlap_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionEndOverlap_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		OnCollisionEndOverlap_OtherComp_Offset = NativeReflection.GetPropertyOffset(OnCollisionEndOverlap_FunctionAddress, "OtherComp");
		OnCollisionEndOverlap_OtherComp_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionEndOverlap_FunctionAddress, "OtherComp", Classes.FObjectProperty);
		OnCollisionEndOverlap_OtherBodyIndex_Offset = NativeReflection.GetPropertyOffset(OnCollisionEndOverlap_FunctionAddress, "OtherBodyIndex");
		OnCollisionEndOverlap_OtherBodyIndex_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionEndOverlap_FunctionAddress, "OtherBodyIndex", Classes.FIntProperty);
		OnCollisionEndOverlap_IsValid = OnCollisionEndOverlap_FunctionAddress != IntPtr.Zero && OnCollisionEndOverlap_OverlappedComponent_IsValid && OnCollisionEndOverlap_OtherActor_IsValid && OnCollisionEndOverlap_OtherComp_IsValid && OnCollisionEndOverlap_OtherBodyIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_ManualSplineMoveCompImpl:OnCollisionEndOverlap", OnCollisionEndOverlap_IsValid);
		OnCollisionBeginOverlap_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnCollisionBeginOverlap");
		OnCollisionBeginOverlap_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCollisionBeginOverlap_FunctionAddress);
		OnCollisionBeginOverlap_OverlappedComponent_Offset = NativeReflection.GetPropertyOffset(OnCollisionBeginOverlap_FunctionAddress, "OverlappedComponent");
		OnCollisionBeginOverlap_OverlappedComponent_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionBeginOverlap_FunctionAddress, "OverlappedComponent", Classes.FObjectProperty);
		OnCollisionBeginOverlap_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnCollisionBeginOverlap_FunctionAddress, "OtherActor");
		OnCollisionBeginOverlap_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionBeginOverlap_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		OnCollisionBeginOverlap_OtherComp_Offset = NativeReflection.GetPropertyOffset(OnCollisionBeginOverlap_FunctionAddress, "OtherComp");
		OnCollisionBeginOverlap_OtherComp_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionBeginOverlap_FunctionAddress, "OtherComp", Classes.FObjectProperty);
		OnCollisionBeginOverlap_OtherBodyIndex_Offset = NativeReflection.GetPropertyOffset(OnCollisionBeginOverlap_FunctionAddress, "OtherBodyIndex");
		OnCollisionBeginOverlap_OtherBodyIndex_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionBeginOverlap_FunctionAddress, "OtherBodyIndex", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OnCollisionBeginOverlap_bFromSweep_PropertyAddress, OnCollisionBeginOverlap_FunctionAddress, "bFromSweep");
		OnCollisionBeginOverlap_bFromSweep_Offset = NativeReflection.GetPropertyOffset(OnCollisionBeginOverlap_FunctionAddress, "bFromSweep");
		OnCollisionBeginOverlap_bFromSweep_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionBeginOverlap_FunctionAddress, "bFromSweep", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OnCollisionBeginOverlap_SweepResult_PropertyAddress, OnCollisionBeginOverlap_FunctionAddress, "SweepResult");
		OnCollisionBeginOverlap_SweepResult_Offset = NativeReflection.GetPropertyOffset(OnCollisionBeginOverlap_FunctionAddress, "SweepResult");
		OnCollisionBeginOverlap_SweepResult_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionBeginOverlap_FunctionAddress, "SweepResult", Classes.FStructProperty);
		OnCollisionBeginOverlap_IsValid = OnCollisionBeginOverlap_FunctionAddress != IntPtr.Zero && OnCollisionBeginOverlap_OverlappedComponent_IsValid && OnCollisionBeginOverlap_OtherActor_IsValid && OnCollisionBeginOverlap_OtherComp_IsValid && OnCollisionBeginOverlap_OtherBodyIndex_IsValid && OnCollisionBeginOverlap_bFromSweep_IsValid && OnCollisionBeginOverlap_SweepResult_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_ManualSplineMoveCompImpl:OnCollisionBeginOverlap", OnCollisionBeginOverlap_IsValid);
	}

	static BUS_ManualSplineMoveCompImpl()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ManualSplineMoveCompImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ManualSplineMoveCompImpl));
	}
}
