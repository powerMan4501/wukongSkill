using System;
using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using b1.Plugins.AkAudio;
using BtlB1;
using BtlShare;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.PhysicsCore;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_CloudMoveComp : UActorCompBaseCS
{
	private BUC_CloudMoveData CloudMoveData;

	private IBUC_PropMgrData PropMgrData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_ABPJumpV2Data AnimHumanoidJumpV2Data;

	private IBUC_ABPCharacterData CharacterData;

	private IBUC_SpeedCtrlData SpeedCtrlData;

	private IBUC_SkillInstsData SkillInstsData;

	private IBUC_ABPBasicData ABPBasicData;

	private IBUC_MovementData MovementData;

	private b1.IBUC_AnimNotifyAndStateData AnimNotifyAndStateData;

	private BUS_DispLibEventCollection DispLibEventCollection;

	private const float epsilon = 1f;

	public override void OnAttach()
	{
		DispLibEventCollection = BUS_DispLibEventCollection.Get(this);
		CloudMoveData = RequireWritableData<BUC_CloudMoveData>();
		PropMgrData = RequireReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		AnimHumanoidJumpV2Data = RequireReadOnlyData<IBUC_ABPJumpV2Data, BUC_ABPJumpV2Data>();
		CharacterData = RequireReadOnlyData<IBUC_ABPCharacterData, BUC_ABPCharacterData>();
		SpeedCtrlData = RequireReadOnlyData<IBUC_SpeedCtrlData, BUC_SpeedCtrlData>();
		SkillInstsData = RequireReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>();
		ABPBasicData = RequireReadOnlyData<IBUC_ABPBasicData, BUC_ABPBasicData>();
		MovementData = RequireReadOnlyData<IBUC_MovementData, BUC_MovementData>();
		AnimNotifyAndStateData = RequireReadOnlyData<b1.IBUC_AnimNotifyAndStateData, BUC_AnimNotifyAndStateData>();
		CloudMoveData.PreloadAssetMgr = BGW_PreloadAssetMgr.Get(Owner);
		base.BUSEventCollection.Evt_SetForbidEnableCloudMove += new Del_Void_Bool(OnSetForbidEnableCloudMove);
		base.BUSEventCollection.Evt_SetForbidDisableCloudMove += new Del_Void_Bool(OnSetForbidDisableCloudMove);
		base.BUSEventCollection.Evt_ToggleCloudMove += new Del_Void(OnToggleCloudMove);
		base.BUSEventCollection.Evt_ResetActorStatusAfterAll += new Del_Void_ResetActorReason(OnResetActorStatusAfterAll);
		base.BUSEventCollection.Evt_OnLanded += new Del_Void(OnLanded);
		base.BUSEventCollection.Evt_OnSkillEnd += new Del_Void_Int(OnSkillEnd);
		base.BUSEventCollection.Evt_PostCloudMoveAkEvent += new Del_PostCloudMoveAkEvent(PostCloudMoveAkEvent);
		base.BUSEventCollection.Evt_SetCloudMoveEnabled += new Del_Void_Bool(SetCloudMoveEnabled);
		base.BUSEventCollection.Evt_SetCloudMoveEnabledSafety += new Del_Void_Bool(SetCloudMoveEnabledSafety);
		base.BUSEventCollection.Evt_BreakCloudMove += new Del_Void_Int(OnBreakCloudMove);
		base.BUSEventCollection.Evt_SetAutoCloudMove += new Del_SetAutoCloudMove(SetAutoCloudMove);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_TriggerResetAllActors = (BGW_EventCollection.Del_TriggerResetAllActors)Delegate.Combine(bGWEventCollection.Evt_TriggerResetAllActors, new BGW_EventCollection.Del_TriggerResetAllActors(OnTriggerResetAllActors));
	}

	public override void OnBeginPlay()
	{
		UpdateHeightLimitLandscapeReader();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		SetCloudMoveEnabledSafety(bIsEnabled: false);
		SetCloudMoveEnabled(bIsEnabled: false);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_TriggerResetAllActors = (BGW_EventCollection.Del_TriggerResetAllActors)Delegate.Remove(bGWEventCollection.Evt_TriggerResetAllActors, new BGW_EventCollection.Del_TriggerResetAllActors(OnTriggerResetAllActors));
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (CloudMoveData.CloudSkillCooldownTime > 0f)
		{
			CloudMoveData.CloudSkillCooldownTime -= DeltaTime;
		}
		if (CloudMoveData.ForbidEnableCloudMove && CloudMoveData.IsCloudMoveEnabled)
		{
			OnToggleCloudMove();
		}
		if (CloudMoveData.IsCloudMoveEnabled)
		{
			BGWDataAsset_CloudMoveConfig cloudMoveConfig = CloudMoveData.CloudMoveConfig;
			UpdateHeightLimit(cloudMoveConfig);
			UpdateCloudMoveEffect(cloudMoveConfig);
			UpdateCloudEffectDBC(cloudMoveConfig, DeltaTime);
			UpdateGroundEffectDBC(cloudMoveConfig, DeltaTime);
			UpdateCloudAudioRTPC();
			UpdateAutoCloudMove();
		}
	}

	private void OnTriggerResetAllActors(EResetActorReason ResetReason)
	{
		SetCloudMoveEnabledSafety(bIsEnabled: false);
	}

	private void UpdateHeightLimit(BGWDataAsset_CloudMoveConfig CloudMoveConfig)
	{
		UpdateCurrentPositionHeightLimit();
		UpdateHeightLimitCamera(CloudMoveConfig);
	}

	private void UpdateCurrentPositionHeightLimit()
	{
		FVector worldPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		CloudMoveData.CurrentPositionHeightLimit = float.MaxValue;
		if (CloudMoveData.HeightLimitLandscapeReaderActor != null)
		{
			CloudMoveData.CurrentPositionHeightLimit = CloudMoveData.HeightLimitLandscapeReaderActor.LandscapeReader.SampleHeightData(worldPos, ESampleType.Bilinear);
		}
	}

	private void UpdateHeightLimitLandscapeReader()
	{
		if (!(CloudMoveData.HeightLimitLandscapeReaderActor == null))
		{
			return;
		}
		BGULandscapeReaderActor[] allActorsOfClass = Owner.World.GetAllActorsOfClass<BGULandscapeReaderActor>();
		foreach (BGULandscapeReaderActor bGULandscapeReaderActor in allActorsOfClass)
		{
			if (bGULandscapeReaderActor.ActorHasTag(B1GlobalFNames.CloudMoveHeightLimit))
			{
				CloudMoveData.HeightLimitLandscapeReaderActor = bGULandscapeReaderActor;
				break;
			}
		}
	}

	private void UpdateHeightLimitCamera(BGWDataAsset_CloudMoveConfig CloudMoveConfig)
	{
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		float num = CloudMoveData.CurrentPositionHeightLimit - CloudMoveConfig.HeightLimitThreshold;
		if (CloudMoveConfig.HeightLimitMaxPitchCurve != null)
		{
			if (fVector.Z > num)
			{
				float p = FMath.Clamp(CloudMoveConfig.HeightLimitMaxPitchCurve.GetFloatValue((fVector.Z - num) / CloudMoveConfig.HeightLimitThreshold), -90f, 90f);
				base.BUSEventCollection.Evt_Camera_SetCloudMoveCameraPitchLimit.Invoke(p);
			}
			else
			{
				base.BUSEventCollection.Evt_Camera_SetCloudMoveCameraPitchLimit.Invoke(90f);
			}
		}
	}

	private void UpdateCloudEffectDBC(BGWDataAsset_CloudMoveConfig CloudMoveConfig, float DeltaTime)
	{
		if (CloudMoveData.RequestIdCloudEffectDBC < 0 || CloudMoveData.IsGettingOffCloud || !(OwnerAsCharacterCS.GetCurrentMontage() == null))
		{
			return;
		}
		FVector socketLocation = OwnerAsCharacterCS.Mesh.GetSocketLocation(B1GlobalFNames.foot_l);
		FVector socketLocation2 = OwnerAsCharacterCS.Mesh.GetSocketLocation(B1GlobalFNames.foot_r);
		if (DispLibEventCollection == null || !DispLibEventCollection.Evt_RequestGetFirstDBCNiagaraTransform(CloudMoveData.RequestIdCloudEffectDBC, out var ResTransform))
		{
			return;
		}
		FVector location = ResTransform.GetLocation();
		FRotator current = ResTransform.Rotator();
		float num = CharacterData.Velocity.Size();
		float mappedSpeed3D = ABPBasicData.GetMappedSpeed3D();
		FRotator target;
		if (num > 1f)
		{
			FVector a = (socketLocation - socketLocation2).ProjectVectorOnToPlane(OwnerAsCharacterCS.Mesh.GetRightVector());
			if (a.Dot_VectorVector(OwnerAsCharacterCS.Mesh.GetForwardVector()) < 0.0)
			{
				a *= -1.0;
			}
			target = a.Rotation();
		}
		else
		{
			target = OwnerAsCharacterCS.Mesh.GetWorldRotation();
		}
		target = FMath.RInterpTo(current, target, DeltaTime, CloudMoveConfig.CloudEffectDBC_RotateLerpSpeedCurve.GetFloatValue(mappedSpeed3D));
		FVector target2 = ((CloudMoveConfig.CloudEffectDBC != null && CloudMoveConfig.CloudEffectDBC.PlayAdvanceNiagara.Count > 0) ? target.RotateVector(CloudMoveConfig.CloudEffectDBC.PlayAdvanceNiagara[0].AttachedTargetLocationOffset) : FVector.ZeroVector);
		target2 += target.RotateVector(CloudMoveConfig.CloudEffectDBC_OffsetCurve.GetVectorValue(mappedSpeed3D));
		if (num > 1f)
		{
			target2 += (socketLocation + socketLocation2) / 2.0;
		}
		else
		{
			target2 += OwnerAsCharacterCS.Mesh.GetSocketLocation(B1GlobalFNames.root);
		}
		target2 = FMath.VInterpTo(location, target2, DeltaTime, CloudMoveConfig.CloudEffectDBC_LocationLerpSpeedCurve.GetFloatValue(mappedSpeed3D));
		SetCloudEffectTransform(new FTransform(target, target2, FVector.OneVector));
		DispLibEventCollection.Evt_RequestSetDBCNiagaraFloatParam(CloudMoveData.RequestIdCloudEffectDBC, B1GlobalFNames.CharacterVelocity, num);
		DispLibEventCollection.Evt_RequestSetDBCNiagaraFloatParam(CloudMoveData.RequestIdCloudEffectDBC, B1GlobalFNames.RunVeclocityMax, SpeedCtrlData.GetMoveSpeedNormal());
		DispLibEventCollection.Evt_RequestSetDBCNiagaraFloatParam(CloudMoveData.RequestIdCloudEffectDBC, B1GlobalFNames.RushVelocityMax, SpeedCtrlData.GetMoveSpeedFast());
	}

	private void SetCloudEffectTransform(in FTransform Transform)
	{
		if (CloudMoveData.RequestIdCloudEffectDBC >= 0)
		{
			DispLibEventCollection?.Evt_RequestSetDBCEffectsTransform(CloudMoveData.RequestIdCloudEffectDBC, new DBCTransformParam(Transform), OnlySetFX: false, ForceDetachAndSet: true);
		}
	}

	private void UpdateCloudMoveEffect(BGWDataAsset_CloudMoveConfig CloudMoveConfig)
	{
		if (CloudMoveData.IsCloudMoveEnabled && CharacterData.Velocity.Size() > CloudMoveConfig.RushEffectSpeed && UnitStateData.HasState(EBGUUnitState.Sprinting))
		{
			if (CloudMoveData.RushEffectEnabled)
			{
				return;
			}
			CloudMoveData.RushEffectEnabled = true;
			foreach (int rushEffectBuff in CloudMoveConfig.RushEffectBuffList)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(rushEffectBuff, Owner, Owner, -1f, EBuffSourceType.CloudMove);
			}
			GetCloudAkComp().PostAkEvent(CloudMoveData.CloudMoveConfig.RushAkEvent, 0, null, "CloudMoveRushEvent");
		}
		else
		{
			if (!CloudMoveData.RushEffectEnabled)
			{
				return;
			}
			CloudMoveData.RushEffectEnabled = false;
			foreach (int rushEffectBuff2 in CloudMoveConfig.RushEffectBuffList)
			{
				base.BUSEventCollection.Evt_BuffRemove.Invoke(rushEffectBuff2, EBuffEffectTriggerType.None, -1);
			}
		}
	}

	private void UpdateGroundEffectDBC(BGWDataAsset_CloudMoveConfig CloudMoveConfig, float DeltaTime)
	{
		if (CloudMoveData.IsCloudMoveEnabled && CharacterData.Velocity.Size() > CloudMoveConfig.GroundEffectSpeed)
		{
			if (CloudMoveConfig.GroundEffects.Count > 0)
			{
				if (CloudMoveData.NewEffectIntervalTime >= 0f)
				{
					CloudMoveData.NewEffectIntervalTime -= DeltaTime;
				}
				FVector actorLocation = Owner.GetActorLocation();
				FVector end = actorLocation - CloudMoveConfig.GroundEffectDistance * FVector.UpVector;
				CloudMoveData.LineTraceReqID = b1.BGS_LineTraceMgr.RequestNewUniqueID_Sync();
				base.BGSEventCollection.Evt_RequestAsyncLineTrace_ByChannelSingle.Invoke(CloudMoveData.LineTraceReqID, actorLocation, end, ECollisionChannel.ECC_GameTraceChannel7, null, bTraceComplex: true, ASyncLineTraceFinish_CallBack_GroundEffect, bDebug: true);
			}
		}
		else
		{
			DestroyCloudMoveDBC(ref CloudMoveData.CurrentGroundEffectReqID);
		}
	}

	private void UpdateCloudAudioRTPC()
	{
		if (CloudMoveData.bIsPlayingCloudAudio)
		{
			GetCloudAkComp().SetRTPCValue(null, ABPBasicData.GetMappedSpeed3D(), 0, "Player_Mvmt_Mapped_Speed");
		}
		GetCloudAkComp().SetRTPCValue(null, MovementData.VelocityAccelerationDegree, 0, "Player_Mvmt_VelocityAccelerationDegree");
	}

	private void UpdateAutoCloudMove()
	{
		if (CloudMoveData.bIsAutoCloudMoveEnabled)
		{
			if (CloudMoveData.IsCloudMoveEnabled)
			{
				base.BUSEventCollection.Evt_Camera_EnableAutoMoveTrail.Invoke((CloudMoveData.AutoMoveTargetLocation - BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner)).GetSafeNormal());
			}
			if (!CloudMoveData.IsCloudMoveEnabled || (CloudMoveData.AutoMoveTargetLocation - BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner)).Size() < CloudMoveData.AutoMoveAcceptRadius)
			{
				SetIsAutoCloudMoveEnabled(IsEnabled: false);
				base.BUSEventCollection.Evt_Camera_DisableAutoMoveTrail.Invoke();
			}
		}
	}

	private void ASyncLineTraceFinish_CallBack_GroundEffect(Result_LineTrace Result)
	{
		if (CloudMoveData.LineTraceReqID == Result.ReqID)
		{
			if (Result.HitResults.Count == 0)
			{
				DestroyCloudMoveDBC(ref CloudMoveData.CurrentGroundEffectReqID);
			}
			else if (CloudMoveData.IsCloudMoveEnabled)
			{
				FHitResult hitResult = Result.HitResults[0];
				UpdateGroundEffectImpl(hitResult);
			}
		}
	}

	private void UpdateGroundEffectImpl(FHitResult hitResult)
	{
		UPhysicalMaterial uPhysicalMaterial = hitResult.PhysMaterial.Get();
		ESceneItemSurfaceType eSceneItemSurfaceType = (ESceneItemSurfaceType)((!(uPhysicalMaterial == null)) ? uPhysicalMaterial.SurfaceType : EPhysicalSurface.SurfaceType_Default);
		FVector actorLocation = Owner.GetActorLocation();
		FTransform fTransform = new FTransform(translation: new FVector(actorLocation.X, actorLocation.Y, hitResult.ImpactPoint.Z), rotation: Owner.GetActorRotation());
		BGWDataAsset_CloudMoveConfig cloudMoveConfig = CloudMoveData.CloudMoveConfig;
		if ((cloudMoveConfig.GroundEffectInterval >= 0f && CloudMoveData.NewEffectIntervalTime <= 0f) || CloudMoveData.CurrentGroundEffectReqID < 0 || eSceneItemSurfaceType != CloudMoveData.CurrentSurfaceType)
		{
			DestroyCloudMoveDBC(ref CloudMoveData.CurrentGroundEffectReqID);
			if (cloudMoveConfig.GroundEffects.TryGetValue(eSceneItemSurfaceType, out var value))
			{
				BGWDataAsset_B1DBC bGWDataAsset_B1DBC = ((CharacterData.Velocity.Size() > SpeedCtrlData.GetMoveSpeedNormal()) ? value.RushEffectDBC : value.RunEffectDBC);
				if (bGWDataAsset_B1DBC != null)
				{
					base.BUSEventCollection.Evt_RequestSpawnFXByDispConfigDA.Invoke(bGWDataAsset_B1DBC, out var RequestID, null, NeedSetSpawnTransform: true, fTransform);
					CloudMoveData.CurrentGroundEffectReqID = RequestID;
					CloudMoveData.NewEffectIntervalTime = cloudMoveConfig.GroundEffectInterval;
				}
			}
			CloudMoveData.CurrentSurfaceType = eSceneItemSurfaceType;
		}
		else if (CloudMoveData.CurrentGroundEffectReqID > 0)
		{
			DispLibEventCollection?.Evt_RequestSetDBCEffectsTransform(CloudMoveData.CurrentGroundEffectReqID, new DBCTransformParam(fTransform), OnlySetFX: false, ForceDetachAndSet: true);
		}
	}

	private void OnResetActorStatusAfterAll(EResetActorReason ResetReason)
	{
	}

	private void SetCloudMoveEnabled(bool bIsEnabled)
	{
		if (CloudMoveData.IsCloudMoveEnabled != bIsEnabled)
		{
			CloudMoveData.CloudSkillCooldownTime = CloudMoveData.CloudMoveConfig.CloudSkillCooldownTime;
			if (bIsEnabled)
			{
				BeginCloudMove();
			}
			else
			{
				StopCloudMove();
			}
		}
	}

	private void SetCloudMoveEnabledSafety(bool bIsEnabled)
	{
		if (bIsEnabled)
		{
			if (!CloudMoveData.bIsPlayingCloudAudio)
			{
				PostCloudMoveAkEvent(bIsStop: false, CloudMoveData.CloudMoveConfig.CloudAkEventBegin);
			}
		}
		else if (CloudMoveData.bIsPlayingCloudAudio)
		{
			PostCloudMoveAkEvent(bIsStop: true, CloudMoveData.CloudMoveConfig.CloudAkEventStop);
		}
		if (CloudMoveData.IsCloudMoveEnabled != bIsEnabled)
		{
			if (bIsEnabled)
			{
				base.BUSEventCollection.Evt_SetCloudMoveEnabled.Invoke(P1: true);
				CloudMoveData.IsGettingOffCloud = false;
			}
			else
			{
				base.BUSEventCollection.Evt_SetCloudMoveEnabled.Invoke(P1: false);
			}
		}
	}

	private void OnSetForbidEnableCloudMove(bool bIsForbid)
	{
		if (bIsForbid)
		{
			CloudMoveData.ForbidEnableCloudMoveCount++;
		}
		else
		{
			CloudMoveData.ForbidEnableCloudMoveCount--;
		}
		CloudMoveData.ForbidEnableCloudMove = CloudMoveData.ForbidEnableCloudMoveCount > 0;
	}

	private void OnSetForbidDisableCloudMove(bool bIsForbid)
	{
		if (bIsForbid)
		{
			CloudMoveData.ForbidDisableCloudMoveCount++;
		}
		else
		{
			CloudMoveData.ForbidDisableCloudMoveCount--;
		}
		CloudMoveData.ForbidDisableCloudMove = CloudMoveData.ForbidDisableCloudMoveCount > 0;
	}

	private void OnToggleCloudMove()
	{
		if (CloudMoveData.CloudSkillCooldownTime > 0f || (CloudMoveData.ForbidEnableCloudMove && !CloudMoveData.IsCloudMoveEnabled) || (CloudMoveData.ForbidDisableCloudMove && CloudMoveData.IsCloudMoveEnabled))
		{
			return;
		}
		int skillID = 0;
		FVector velocity = Owner.GetVelocity();
		bool flag = velocity.Size() > 20f;
		BGWDataAsset_CloudMoveConfig cloudMoveConfig = CloudMoveData.CloudMoveConfig;
		if (!CloudMoveData.IsCloudMoveEnabled)
		{
			if (OwnerAsCharacterCS.CharacterMovement.MovementMode != EMovementMode.MOVE_Falling)
			{
				skillID = ((flag && !UnitStateData.HasState(EBGUUnitState.Walking)) ? ((!UnitStateData.HasState(EBGUUnitState.Sprinting)) ? cloudMoveConfig.CloudSkill_Ride_Run : cloudMoveConfig.CloudSkill_Ride_Sprint) : cloudMoveConfig.CloudSkill_Ride_Walk);
			}
			else
			{
				FVector actorLocation = OwnerAsCharacterCS.GetActorLocation();
				FVector end = actorLocation - FVector.UpVector * cloudMoveConfig.CloudSkill_Ride_Fall_MinHeight;
				if (!USystemLibrary.LineTraceSingleByProfile(OwnerAsCharacterCS, actorLocation, end, B1GlobalFNames.Pawn, bTraceComplex: true, null, EDrawDebugTrace.None, out var _, bIgnoreSelf: true, FLinearColor.White, FLinearColor.Red, 0f))
				{
					skillID = cloudMoveConfig.CloudSkill_Ride_Fall;
				}
			}
		}
		else
		{
			if (CloudMoveData.bIsAutoCloudMoveEnabled)
			{
				return;
			}
			bool flag2 = (CloudMoveData.bIsCloudFallInLowAirArea = CheckIsCloudFallLowAir());
			bool flag4 = flag2;
			float num = FRotator.NormalizeAxis(velocity.Rotation().Pitch);
			skillID = ((velocity.Size() > SpeedCtrlData.GetMoveSpeedNormal() + 20f) ? ((!flag) ? (flag4 ? cloudMoveConfig.CloudSkill_GetOff_Rush_Low_Forward : cloudMoveConfig.CloudSkill_GetOff_Rush_High_Forward) : ((num > 10f) ? (flag4 ? cloudMoveConfig.CloudSkill_GetOff_Rush_Low_Upward : cloudMoveConfig.CloudSkill_GetOff_Rush_High_Upward) : ((!(num < -10f)) ? (flag4 ? cloudMoveConfig.CloudSkill_GetOff_Rush_Low_Forward : cloudMoveConfig.CloudSkill_GetOff_Rush_High_Forward) : (flag4 ? cloudMoveConfig.CloudSkill_GetOff_Rush_Low_Downward : cloudMoveConfig.CloudSkill_GetOff_Rush_High_Downward)))) : ((!(velocity.Size() > SpeedCtrlData.GetMoveSpeedSlow() + 20f)) ? (flag4 ? cloudMoveConfig.CloudSkill_GetOff_Walk_Low : cloudMoveConfig.CloudSkill_GetOff_Walk_High) : ((!flag) ? (flag4 ? cloudMoveConfig.CloudSkill_GetOff_Run_Low_Forward : cloudMoveConfig.CloudSkill_GetOff_Run_High_Forward) : ((num > 10f) ? (flag4 ? cloudMoveConfig.CloudSkill_GetOff_Run_Low_Upward : cloudMoveConfig.CloudSkill_GetOff_Run_High_Upward) : ((!(num < -10f)) ? (flag4 ? cloudMoveConfig.CloudSkill_GetOff_Run_Low_Forward : cloudMoveConfig.CloudSkill_GetOff_Run_High_Forward) : (flag4 ? cloudMoveConfig.CloudSkill_GetOff_Run_Low_Downward : cloudMoveConfig.CloudSkill_GetOff_Run_High_Downward))))));
		}
		TryCastCloudMoveSkill(skillID);
	}

	private bool TryCastCloudMoveSkill(int SkillID, bool ForceSuccess = false)
	{
		bool flag = false;
		if (SkillID > 0)
		{
			CloudMoveData.CloudMoveSkillCasted = true;
			bool isCloudMoveEnabled = CloudMoveData.IsCloudMoveEnabled;
			FCastSkillInfo cSI = new FCastSkillInfo(SkillID, ECastSkillSourceType.CloudMove);
			cSI.NeedCheckSkillCanCast = !ForceSuccess;
			base.BUSEventCollection.Evt_UnitCastSkillTry.Invoke(cSI);
			flag = SkillInstsData.GetLastSkillCastResult() == ECastSkillResult.CSR_OK;
			if (flag)
			{
				CloudMoveData.IsGettingOffCloud = isCloudMoveEnabled;
				if (CloudMoveData.RequestIdCloudEffectDBC >= 0 && DispLibEventCollection != null && DispLibEventCollection.Evt_RequestGetFirstDBCNiagaraTransform(CloudMoveData.RequestIdCloudEffectDBC, out var ResTransform))
				{
					SetCloudEffectTransform(in ResTransform);
				}
			}
		}
		return flag;
	}

	private bool CheckIsCloudFallLowAir()
	{
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner) - new FVector(0.0, 0.0, OwnerAsCharacterCS.CapsuleComponent.GetScaledCapsuleHalfHeight());
		FVector end = fVector - new FVector(0.0, 0.0, AnimHumanoidJumpV2Data.HeightDividingLine_Mid);
		FHitResult OutHit;
		return USystemLibrary.LineTraceSingleByProfile(Owner, fVector, end, B1GlobalFNames.Pawn, bTraceComplex: true, new List<AActor> { Owner }, EDrawDebugTrace.None, out OutHit, bIgnoreSelf: true, FLinearColor.Red, FLinearColor.Blue, 2f);
	}

	private void OnSkillEnd(int SkillID)
	{
		if (CloudMoveData.CloudMoveSkillCasted)
		{
			if (CloudMoveData.CloudSkillList_Ride.Contains(SkillID))
			{
				SetCloudMoveEnabledSafety(bIsEnabled: true);
			}
			if (CloudMoveData.CloudSkillList_GetOff.Contains(SkillID))
			{
				SetCloudMoveEnabledSafety(bIsEnabled: false);
			}
		}
	}

	private void BeginCloudMove()
	{
		if (CloudMoveData.IsCloudMoveEnabled)
		{
			return;
		}
		BGWDataAsset_CloudMoveConfig cloudMoveConfig = CloudMoveData.CloudMoveConfig;
		CloudMoveData.IsCloudMoveEnabled = true;
		base.BUSEventCollection.Evt_ClearCameraLock.Invoke();
		SetCloudMoveCVarEnable(bIsEnabled: true);
		ModifyLevelStreamingDistance(bIsInCloud: true);
		foreach (int item in cloudMoveConfig.CloudMoveBuffId)
		{
			base.BUSEventCollection.Evt_BuffAdd.Invoke(item, Owner, Owner, -1f, EBuffSourceType.CloudMove);
		}
		if (cloudMoveConfig != null && cloudMoveConfig.CloudEffectDBC != null)
		{
			base.BUSEventCollection.Evt_RequestSpawnFXByDispConfigDA.Invoke(cloudMoveConfig.CloudEffectDBC, out var RequestID);
			CloudMoveData.RequestIdCloudEffectDBC = RequestID;
		}
		if (CloudMoveData.MovementModeHandleID == 0)
		{
			base.BUSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 5, 0u, 0u, bSetDefaultProperty: false, "CloudMoveComp");
			CloudMoveData.MovementModeHandleID = PropMgrData.GetLastHandleID();
		}
		else
		{
			base.BUSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 5, CloudMoveData.MovementModeHandleID, 0u, bSetDefaultProperty: false, "CloudMoveComp");
		}
		base.BUSEventCollection.Evt_SetStringProperty.Invoke(EPropType.Capsule_CollisionProfileName, "FlyingPawn");
		CloudMoveData.CapsuleCollisionProfileHandleID = PropMgrData.GetLastHandleID();
		if (CloudMoveData.EnableIKHandleID == 0)
		{
			base.BUSEventCollection.Evt_SetBoolBoolProperty.Invoke(EPropType.Mesh_EnableFootIK, Value1: false, Value2: false);
			CloudMoveData.EnableIKHandleID = PropMgrData.GetLastHandleID();
		}
		else
		{
			base.BUSEventCollection.Evt_SetBoolBoolProperty.Invoke(EPropType.Mesh_EnableFootIK, Value1: false, Value2: false, CloudMoveData.EnableIKHandleID);
		}
		base.BUSEventCollection.Evt_SetParkourMoveEnabled.Invoke(P1: false);
		base.BGWEventCollection.Evt_SetCloudInputEnable(P1: true);
		base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.CloudMove);
		base.BUSEventCollection.Evt_ClearFallingHeight.Invoke();
		base.BUSEventCollection.Evt_Camera_SetCloudMoveCameraPitchLimit.Invoke(90f);
		base.BUSEventCollection.Evt_Camera_SetCloudMoveCameraPitchLimitEnabled.Invoke(P1: true);
		base.BGSEventCollection.Evt_BGS_OnCloudMoveBegin.Invoke();
		CloudMoveData.bCloudFall = false;
		CloudMoveData.CloudBreakAnimId = -1;
	}

	private void StopCloudMove()
	{
		if (!CloudMoveData.IsCloudMoveEnabled)
		{
			return;
		}
		CloudMoveData.IsCloudMoveEnabled = false;
		SetCloudMoveCVarEnable(bIsEnabled: false);
		ModifyLevelStreamingDistance(bIsInCloud: false);
		BGWDataAsset_CloudMoveConfig cloudMoveConfig = CloudMoveData.CloudMoveConfig;
		foreach (int item in cloudMoveConfig.CloudMoveBuffId)
		{
			base.BUSEventCollection.Evt_BuffRemove.Invoke(item, EBuffEffectTriggerType.None, 1);
		}
		UpdateCloudMoveEffect(cloudMoveConfig);
		UpdateAutoCloudMove();
		DestroyCloudMoveDBC(ref CloudMoveData.RequestIdCloudEffectDBC);
		DestroyCloudMoveDBC(ref CloudMoveData.CurrentGroundEffectReqID);
		base.BUSEventCollection.Evt_ResetProperty.Invoke(CloudMoveData.MovementModeHandleID);
		CloudMoveData.MovementModeHandleID = 0u;
		base.BUSEventCollection.Evt_ResetProperty.Invoke(CloudMoveData.CapsuleCollisionProfileHandleID);
		CloudMoveData.CapsuleCollisionProfileHandleID = 0u;
		if (CloudMoveData.EnableIKHandleID != 0)
		{
			base.BUSEventCollection.Evt_ResetProperty.Invoke(CloudMoveData.EnableIKHandleID);
			CloudMoveData.EnableIKHandleID = 0u;
		}
		base.BUSEventCollection.Evt_SetParkourMoveEnabled.Invoke(P1: true);
		base.BGWEventCollection.Evt_SetCloudInputEnable(P1: false);
		base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.CloudMove, IsRemove: true);
		base.BUSEventCollection.Evt_Camera_SetCloudMoveCameraPitchLimit.Invoke(90f);
		base.BUSEventCollection.Evt_Camera_SetCloudMoveCameraPitchLimitEnabled.Invoke(P1: false);
		base.BGSEventCollection.Evt_BGS_OnCloudMoveEnded.Invoke();
		int num = UBGUFunctionLibraryForCS.BGUGetCurActiveMontageInstID(OwnerAsCharacterCS.Mesh.GetAnimInstance());
		if (num != -1 && CloudMoveData.CloudSkillList_GetOff.Contains(AnimNotifyAndStateData.FindBindingSkillID(num)))
		{
			OwnerAsCharacterCS.StopAnimMontage(null);
			base.BUSEventCollection.Evt_UnitTryBreakSkill.Invoke("筋斗云下云状态切换，结束下云技能");
		}
		CloudMoveData.bCloudFall = OwnerAsCharacterCS.CharacterMovement.MovementMode != EMovementMode.MOVE_Walking;
	}

	private void OnBreakCloudMove(int BreakAnimId)
	{
		if (!CloudMoveData.IsCloudMoveEnabled)
		{
			return;
		}
		BGWDataAsset_CloudMoveConfig cloudMoveConfig = CloudMoveData.CloudMoveConfig;
		CloudMoveData.CloudBreakAnimId = (cloudMoveConfig.CloudSkill_BreakSkills.ContainsKey(BreakAnimId) ? BreakAnimId : 0);
		CloudMoveData.bIsCloudFallInLowAirArea = CheckIsCloudFallLowAir();
		if (cloudMoveConfig.CloudSkill_BreakSkills.TryGetValue(CloudMoveData.CloudBreakAnimId, out var value))
		{
			int num = (CloudMoveData.bIsCloudFallInLowAirArea ? value.BreakSkill_Low : value.BreakSkill_High);
			if (num > 0 && TryCastCloudMoveSkill(num, ForceSuccess: true))
			{
				return;
			}
		}
		SetCloudMoveEnabledSafety(bIsEnabled: false);
	}

	private void OnLanded()
	{
		CloudMoveData.bCloudFall = false;
	}

	private UAkComponent GetCloudAkComp()
	{
		if (CloudMoveData.CloudAkComp == null)
		{
			BGWDataAsset_CloudMoveConfig cloudMoveConfig = CloudMoveData.CloudMoveConfig;
			UAkComponent uAkComponent = UGSE_ActorFuncLib.AddComponentByClass(Owner, UClass.GetClass<UAkComponent>(), bManualAttachment: false, FTransform.Identity, bDeferredFinish: false) as UAkComponent;
			if (cloudMoveConfig.CloudEffectDBC != null && cloudMoveConfig.CloudEffectDBC.PlayNiagara.Count > 0)
			{
				uAkComponent.AttachTo(OwnerAsCharacterCS.Mesh, cloudMoveConfig.CloudEffectDBC.PlayNiagara[0].AttachedTargetSocketName, EAttachLocation.SnapToTarget, bWeldSimulatedBodies: false);
			}
			CloudMoveData.CloudAkComp = uAkComponent;
		}
		return CloudMoveData.CloudAkComp;
	}

	private void PostCloudMoveAkEvent(bool bIsStop, UAkAudioEvent AkEvent)
	{
		if (!(AkEvent == null))
		{
			FOnAkPostEventCallback postEventCallback = new FOnAkPostEventCallback();
			GetCloudAkComp().PostAkEvent(AkEvent, 0, postEventCallback, "CloudMoveEvent");
			CloudMoveData.bIsPlayingCloudAudio = !bIsStop;
		}
	}

	private void SetIsAutoCloudMoveEnabled(bool IsEnabled)
	{
		if (CloudMoveData.bIsAutoCloudMoveEnabled != IsEnabled)
		{
			CloudMoveData.bIsAutoCloudMoveEnabled = IsEnabled;
			if (IsEnabled)
			{
				base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.IgnoreMoveInput);
				base.BUSEventCollection.Evt_SetPressedSprinting.Invoke(P1: true);
				base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AIInputSprint, -1f);
			}
			else
			{
				base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.BreakSprint, -1f);
				base.BUSEventCollection.Evt_SetPressedSprinting.Invoke(P1: false);
				base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.IgnoreMoveInput, IsRemove: true);
			}
		}
	}

	private void SetAutoCloudMove(FVector TargetLocation, float AcceptRadius)
	{
		SetIsAutoCloudMoveEnabled(IsEnabled: true);
		CloudMoveData.AutoMoveTargetLocation = TargetLocation;
		CloudMoveData.AutoMoveAcceptRadius = AcceptRadius;
	}

	private void DestroyCloudMoveDBC(ref int EffectReqID)
	{
		if (EffectReqID >= 0)
		{
			base.BUSEventCollection.Evt_RequestDestroyByFXRequestID.Invoke(EffectReqID);
			EffectReqID = -1;
		}
	}

	private void SetCloudMoveCVarEnable(bool bIsEnabled)
	{
		if (bIsEnabled == CloudMoveData.CloudMoveCVarHandles.Count > 0)
		{
			return;
		}
		if (bIsEnabled)
		{
			CreateCloudMoveCVarHandle("r.FidelityFX.FI.Enabled", 0f);
			CreateCloudMoveCVarHandle("grass.TickInterval", 2f);
			CreateCloudMoveCVarHandle("r.AOGlobalDistanceField.FastCameraMode", 1f);
			CreateCloudMoveCVarHandle("r.LumenScene.GlobalSDF.ClipmapExtent", 2000f);
			CreateCloudMoveCVarHandle("r.LumenScene.FastCameraMode", 1f);
			CreateCloudMoveCVarHandle("r.FreezeShadowFOV", 65f);
			return;
		}
		foreach (int value2 in CloudMoveData.CloudMoveCVarHandles.Values)
		{
			CVarFuncLib.DestroyHandle(value2);
		}
		CloudMoveData.CloudMoveCVarHandles.Clear();
		void CreateCloudMoveCVarHandle(string CVar, float Value)
		{
			if (!CloudMoveData.CloudMoveCVarHandles.TryGetValue(CVar, out var value))
			{
				value = CVarFuncLib.CreateHandle(CVar);
			}
			if (value >= 0)
			{
				CloudMoveData.CloudMoveCVarHandles[CVar] = value;
				CVarFuncLib.SetByHandle(value, Value);
			}
		}
	}

	private void ModifyLevelStreamingDistance(bool bIsInCloud)
	{
	}
}
