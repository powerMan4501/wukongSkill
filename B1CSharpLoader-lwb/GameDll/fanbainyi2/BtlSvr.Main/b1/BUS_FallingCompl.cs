using System.Collections.Generic;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.GameplayCameras;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_FallingCompl : UActorCompBaseCS
{
	private BUC_FallingData FallingData;

	private IBUC_ABPJumpV2Data AnimHumanoidJumpV2Data;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_EnvironmentInteractionMgrData SurfaceData;

	private FName LeftFootFrontSocket;

	private FName RightFootFrontSocket;

	public override void OnAttach()
	{
		FallingData = RequireWritableData<BUC_FallingData>();
		AnimHumanoidJumpV2Data = RequireReadOnlyData<IBUC_ABPJumpV2Data, BUC_ABPJumpV2Data>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		SurfaceData = RequireReadOnlyData<IBUC_EnvironmentInteractionMgrData, BUC_EnvironmentInteractionMgrData>();
		if (base.BUSEventCollection != null)
		{
			base.BUSEventCollection.Evt_FallingStart += new Del_Void(FallingStart);
			base.BUSEventCollection.Evt_OnLeaveFalling += new Del_Void(OnLeaveFalling);
			base.BUSEventCollection.Evt_OnLanded += new Del_Void(OnLanded);
			base.BUSEventCollection.Evt_PauseSafeFallingCheck += new Del_Void_Bool(PauseSafeFallingCheck);
			base.BUSEventCollection.Evt_CastDodgeSkillSuccess += new Del_Void(CastDodgeSkillSuccess);
			base.BUSEventCollection.Evt_UpdateSafeLandFlag += new Del_Void_Bool(UpdateSafeLandFlag);
			base.BUSEventCollection.Evt_TeleportFinish += new Del_Void(ClearFallingHeight);
			base.BUSEventCollection.Evt_ClearFallingHeight += new Del_Void(ClearFallingHeight);
			base.BUSEventCollection.Evt_Active_StopMontageWhenLand += new Del_Void_Bool(Active_StopMontageWhenLand);
			if (Owner is BGUPlayerCharacterCS)
			{
				base.BUSEventCollection.Evt_UnitCastSkillSuccess += new Del_UnitCastSkillSuccess(OnCastSkillSuccess);
			}
		}
	}

	public override void OnBeginPlay()
	{
		InitData();
	}

	private void InitData()
	{
		int actorResID = GetActorResID();
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(actorResID);
		if (unitCommDesc != null)
		{
			LeftFootFrontSocket = new FName(unitCommDesc.LeftFootFrontSocket);
			RightFootFrontSocket = new FName(unitCommDesc.RightFootFrontSocket);
		}
		FUStPlayerCommDesc playerCommDesc = BGW_GameDB.GetPlayerCommDesc(actorResID, Owner);
		if (playerCommDesc != null)
		{
			FallingData.FallingAttackProtectTime = playerCommDesc.AirAtkFallingProtectTime;
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		SafeFallingTimerTick(DeltaTime);
		FallingAttackProtectTimer_Tick(DeltaTime);
		FloorDistanceCheck();
	}

	private void SafeFallingTimerTick(float DeltaTime)
	{
		if (!FallingData.bPauseSafeFallingCheck && !(FallingData.FallingTimer < 0f) && GSGameplayCVar.CVar_EnableFallingOverTime.GetValueInGameThread() != 0 && CanCostFallingDmg() && !(OwnerAsCharacterCS.CharacterMovement.GravityScale <= 0f) && !(OwnerAsCharacterCS.CharacterMovement.Velocity.Z > 0f))
		{
			FallingData.FallingTimer -= DeltaTime;
			if (FallingData.FallingTimer < 0f)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DamageCalc, $"<character>{Owner?.GetName()}</><action>坠落时间超过：{FallingData.FallingSafeTime}秒</><action>直接触发死亡</>");
				Wrapper_SkillDamage_OverTime();
				OnFallDead(EFallDeadType.OverSafeTimeDead);
				ClearFallingTimer();
			}
		}
	}

	private void PauseSafeFallingCheck(bool bPause)
	{
		FallingData.bPauseSafeFallingCheck = bPause;
	}

	private void OnLanded()
	{
		ClearSkillInAirRecord();
		StopMontageWhenLand();
		ClearFallingTimer();
		FallingAttackProtectTimer_Clear();
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (bGUCharacterCS.IsNullOrDestroyed())
		{
			return;
		}
		UBGUCharacterMovementComponent uBGUCharacterMovementComponent = bGUCharacterCS.CharacterMovement as UBGUCharacterMovementComponent;
		if (uBGUCharacterMovementComponent == null)
		{
			return;
		}
		float num = uBGUCharacterMovementComponent.GetTopZInFalling() - bGUCharacterCS.GetActorLocation().Z;
		if (num > 1f)
		{
			bool num2 = BGUFunctionLibraryCS.BGUHasUnitState(Owner, EBGUUnitState.Dead) || BGUFunctionLibraryCS.BGUHasUnitSimpleState(Owner, EBGUSimpleState.PendingDeathInAnimationSyncing);
			EFallHeightType_V2 eFallHeightType_V = EFallHeightType_V2.FallHeight_Little;
			eFallHeightType_V = ((!(num <= AnimHumanoidJumpV2Data.TriggerLandHeight)) ? ((num <= AnimHumanoidJumpV2Data.HeightDividingLine_Low) ? EFallHeightType_V2.FallHeight_Low : ((!(num <= AnimHumanoidJumpV2Data.HeightDividingLine_Mid)) ? EFallHeightType_V2.FallHeight_High : EFallHeightType_V2.FallHeight_Mid)) : EFallHeightType_V2.FallHeight_Little);
			base.BUSEventCollection.Evt_NotifyAnimFallHeight.Invoke(num);
			if (CanCostFallingDmg() && !DebugConfig.EnablePlaneMoveMode && num >= FallingData.CostDMG_StartHeight)
			{
				float num3 = FMath.Min((num - FallingData.CostDMG_StartHeight) * FallingData.OverHeight_DmgAdditive_INV10000 / 100f + FallingData.BaseDmg_INV10000, FallingData.FallDmg_DmgMax_INV10000);
				if (FallingData.DodgeSuccess_InFalling)
				{
					num3 *= FallingData.Dodge_DmgMul;
					if (DebugConfig.IsOpenBattleInfoTool)
					{
						BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DamageCalc, $"<character>{Owner?.GetName()}</><action>落地前翻滚成功，</><action>最终坠落伤害 * </><damage>{FallingData.Dodge_DmgMul}</>");
					}
				}
				if (num3 > 0f)
				{
					Wrapper_SkillDamage(num3, out var _);
					if (DebugConfig.IsOpenBattleInfoTool)
					{
						BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DamageCalc, $"<character>{Owner?.GetName()}</><action>坠落高度：{num}</><action>造成了</><damage>{num3}</><action>万分比伤害</>");
					}
				}
			}
			bool flag = BGUFunctionLibraryCS.BGUHasUnitState(Owner, EBGUUnitState.Dead) || BGUFunctionLibraryCS.BGUHasUnitSimpleState(Owner, EBGUSimpleState.PendingDeathInAnimationSyncing);
			if (!num2 && flag)
			{
				OnFallDead(EFallDeadType.FallLandDead);
				eFallHeightType_V = EFallHeightType_V2.FallHeight_Dead;
			}
			if (!flag)
			{
				LandDisp_WithoutDead(eFallHeightType_V);
			}
		}
		uBGUCharacterMovementComponent.ClearTopZInFalling();
		ClearFloorDistanceData();
		FallingData.DodgeSuccess_InFalling = false;
	}

	private void ClearFallingHeight()
	{
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			UBGUCharacterMovementComponent uBGUCharacterMovementComponent = bGUCharacterCS.CharacterMovement as UBGUCharacterMovementComponent;
			if (uBGUCharacterMovementComponent != null)
			{
				uBGUCharacterMovementComponent.ClearTopZInFalling();
			}
		}
	}

	private bool CanCostFallingDmg()
	{
		if (UnitStateData.HasState(EBGUUnitState.Teleporting))
		{
			return false;
		}
		if (FallingData.bInSafeLandVolume)
		{
			return false;
		}
		return true;
	}

	private void OnFallDead(EFallDeadType DeadType)
	{
		if (DeadType == EFallDeadType.OverSafeTimeDead)
		{
			base.BUSEventCollection?.Evt_SetPhysAnimSetting.Invoke(EPhysAnimType.Death);
		}
	}

	private void Wrapper_SkillDamage(float TargetHpMaxRatio, out float FinalDamageRatio)
	{
		float num = BGW_GameDB.GetPlayerCommDesc(BGU_DataUtil.GetActorResID(Owner), Owner)?.FallingDamageMultiplier ?? 1f;
		FinalDamageRatio = TargetHpMaxRatio * num;
		base.BUSEventCollection?.Evt_TriggerNormalDamageEffect.Invoke(null, new FSkillDamageConfig
		{
			DamageCalcType = EDamageCalcType.HPMaxRatioAbs,
			HPMaxINV10000Damage_Abs = FinalDamageRatio,
			DamageImmueLevel = 2,
			DmgReason = EDamageReason.FallDmg
		}, default(FEffectInstReq), new FBattleAttrSnapShot(null));
	}

	private void Wrapper_SkillDamage_OverTime()
	{
		base.BUSEventCollection?.Evt_TriggerNormalDamageEffect.Invoke(null, new FSkillDamageConfig
		{
			DamageCalcType = EDamageCalcType.HPMaxRatioAbs,
			HPMaxINV10000Damage_Abs = 999999f,
			DamageImmueLevel = 2,
			DmgReason = EDamageReason.FallDmg
		}, default(FEffectInstReq), new FBattleAttrSnapShot(null));
	}

	private void FallingStart()
	{
		FallingAttackProtectTimer_StartTick();
		if (Owner is BGUPlayerCharacterCS && !(FallingData.FallingSafeTime <= 0f))
		{
			FallingData.FallingTimer = FallingData.FallingSafeTime;
		}
	}

	private void OnLeaveFalling()
	{
		ClearFallingTimer();
	}

	private void ClearFallingTimer()
	{
		FallingData.FallingTimer = -1f;
	}

	private void FallingAttackProtectTimer_StartTick()
	{
		FallingData.FallingAttackProtectTimer = FallingData.FallingAttackProtectTime;
	}

	private void FallingAttackProtectTimer_Tick(float DeltaTime)
	{
		if (FallingData.FallingAttackProtectTimer > 0f)
		{
			FallingData.FallingAttackProtectTimer -= DeltaTime;
		}
	}

	private void FallingAttackProtectTimer_Clear()
	{
		FallingData.FallingAttackProtectTimer = -1f;
	}

	private void FloorDistanceCheck()
	{
		if (!FallingData.EnableDodge_InFalling && !FallingData.EnableFloorDistanceCheck)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		UBGUCharacterMovementComponent uBGUCharacterMovementComponent = bGUCharacterCS.CharacterMovement as UBGUCharacterMovementComponent;
		if (!(uBGUCharacterMovementComponent == null) && uBGUCharacterMovementComponent.IsFalling())
		{
			float scaledCapsuleHalfHeight = bGUCharacterCS.CapsuleComponent.GetScaledCapsuleHalfHeight();
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner) - BGUFuncLibActorTransformCS.BGUGetActorUpVector(Owner) * scaledCapsuleHalfHeight;
			FVector end = fVector - FVector.UpVector * 500.0;
			if (USystemLibrary.LineTraceSingleByProfile(Owner, fVector, end, B1GlobalFNames.Pawn, bTraceComplex: true, new List<AActor>(), EDrawDebugTrace.None, out var OutHit, bIgnoreSelf: true, FLinearColor.Red, FLinearColor.Blue, 2f))
			{
				FallingData.FloorDistance = OutHit.Distance;
			}
			else
			{
				FallingData.FloorDistance = float.MaxValue;
			}
		}
	}

	private void ClearFloorDistanceData()
	{
		FallingData.FloorDistance = 0f;
	}

	private void CastDodgeSkillSuccess()
	{
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			UBGUCharacterMovementComponent uBGUCharacterMovementComponent = bGUCharacterCS.CharacterMovement as UBGUCharacterMovementComponent;
			if (!(uBGUCharacterMovementComponent == null) && uBGUCharacterMovementComponent.IsFalling())
			{
				FallingData.DodgeSuccess_InFalling = true;
			}
		}
	}

	private void UpdateSafeLandFlag(bool _bInSafeLandVolume)
	{
		FallingData.bInSafeLandVolume = _bInSafeLandVolume;
	}

	private void OnCastSkillSuccess(int MappingSkillID, int OriSkillID, ECastSkillSourceType SourceType)
	{
		if (FallingData.SkillInAirRecordList.ContainsKey(MappingSkillID))
		{
			FallingData.SkillInAirRecordList[MappingSkillID]++;
		}
		else
		{
			FallingData.SkillInAirRecordList[MappingSkillID] = 1;
		}
	}

	private void ClearSkillInAirRecord()
	{
		FallingData.SkillInAirRecordList.Clear();
	}

	private void Active_StopMontageWhenLand(bool bActive)
	{
		FallingData.bActive_StopMontageWhenLand = bActive;
	}

	private void StopMontageWhenLand()
	{
		if (FallingData.bActive_StopMontageWhenLand)
		{
			OwnerAsCharacterCS.StopAnimMontage(null);
		}
	}

	private void LandDisp_WithoutDead(EFallHeightType_V2 FallHeightType)
	{
		switch (FallHeightType)
		{
		case EFallHeightType_V2.FallHeight_Low:
			TriggerLandFX(EFallHeightType_V2.FallHeight_Low);
			break;
		case EFallHeightType_V2.FallHeight_Mid:
			TriggerLandFX(EFallHeightType_V2.FallHeight_Mid);
			TriggerLandCamShake(EFallHeightType_V2.FallHeight_Mid);
			break;
		case EFallHeightType_V2.FallHeight_High:
			TriggerLandFX(EFallHeightType_V2.FallHeight_High);
			TriggerLandCamShake(EFallHeightType_V2.FallHeight_High);
			break;
		case EFallHeightType_V2.FallHeight_Little:
		case EFallHeightType_V2.FallHeight_Dead:
			break;
		}
	}

	private void TriggerLandCamShake(EFallHeightType_V2 FallHeightType)
	{
		TSubclassOf<UMatineeCameraShake> tSubclassOf = null;
		switch (FallHeightType)
		{
		case EFallHeightType_V2.FallHeight_Mid:
			tSubclassOf = FallingData.LandCamShakeConfig.CameraShake_Mid;
			break;
		case EFallHeightType_V2.FallHeight_High:
			tSubclassOf = FallingData.LandCamShakeConfig.CameraShake_High;
			break;
		case EFallHeightType_V2.FallHeight_Dead:
			tSubclassOf = FallingData.LandCamShakeConfig.CameraShake_Dead;
			break;
		}
		if (!(tSubclassOf == null))
		{
			UBUS_UtilComm.PlayCameraShakeByClass(Owner, tSubclassOf.Value);
		}
	}

	private void TriggerLandFX(EFallHeightType_V2 FallHeightType)
	{
		if (SurfaceData == null)
		{
			return;
		}
		base.BUSEventCollection?.Evt_ForceUpdateSurfaceType.Invoke();
		ESceneItemSurfaceType resultSurfaceType = SurfaceData.ResultSurfaceType;
		FUStUnitFootstepDesc unitFootstepDesc = BGW_GameDB.GetUnitFootstepDesc(BGU_DataUtil.GetActorResID(Owner) * 100 + (int)resultSurfaceType);
		if (unitFootstepDesc == null)
		{
			return;
		}
		string text = string.Empty;
		switch (FallHeightType)
		{
		case EFallHeightType_V2.FallHeight_Low:
			text = unitFootstepDesc.LittleFallLandFXPath;
			break;
		case EFallHeightType_V2.FallHeight_Mid:
			text = unitFootstepDesc.MiddleFallLandFXPath;
			break;
		case EFallHeightType_V2.FallHeight_High:
			text = unitFootstepDesc.HighFallLandFXPath;
			break;
		}
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		switch (unitFootstepDesc.LandFXPlayType)
		{
		case ELandFXPlayType.JustOnRoot:
		{
			FName SocketName = B1GlobalFNames.root;
			FTransform spawnTransform3 = BGUFuncLibComponentCS.BGUGetSocketTransform(OwnerAsCharacterCS.Mesh, ref SocketName);
			spawnTransform3.SetScale3D(FVector.OneVector);
			if (resultSurfaceType == ESceneItemSurfaceType.BloodSurface || resultSurfaceType == ESceneItemSurfaceType.WaterSurface)
			{
				FVector translation3 = spawnTransform3.Translation;
				translation3.Z = SurfaceData.PhySurfaceHitPoint.Z;
				spawnTransform3.SetLocation(translation3);
			}
			base.BUSEventCollection.Evt_RequestSpawnFXByDispConfig.Invoke(text, out var _, null, NeedSetSpawnTransform: true, spawnTransform3);
			break;
		}
		case ELandFXPlayType.LeftAndRightFoot:
		{
			FRotator rotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(Owner);
			FTransform spawnTransform = new FTransform(rotation, BGUFuncLibComponentCS.BGUGetSocketLocation(OwnerAsCharacterCS.Mesh, ref LeftFootFrontSocket));
			FTransform spawnTransform2 = new FTransform(rotation, BGUFuncLibComponentCS.BGUGetSocketLocation(OwnerAsCharacterCS.Mesh, ref RightFootFrontSocket));
			if (resultSurfaceType == ESceneItemSurfaceType.BloodSurface || resultSurfaceType == ESceneItemSurfaceType.WaterSurface)
			{
				FVector translation = spawnTransform.Translation;
				translation.Z = SurfaceData.PhySurfaceHitPoint.Z;
				spawnTransform.SetLocation(translation);
				FVector translation2 = spawnTransform2.Translation;
				translation2.Z = SurfaceData.PhySurfaceHitPoint.Z;
				spawnTransform2.SetLocation(translation2);
			}
			base.BUSEventCollection.Evt_RequestSpawnFXByDispConfig.Invoke(text, out var _, null, NeedSetSpawnTransform: true, spawnTransform);
			base.BUSEventCollection.Evt_RequestSpawnFXByDispConfig.Invoke(text, out var _, null, NeedSetSpawnTransform: true, spawnTransform2);
			break;
		}
		}
	}
}
