using System.Collections.Generic;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_TouchWallFeedbackComp : UActorCompBaseCS
{
	private BUC_TouchWallFeedbackData TouchWallFeedbackData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_BattleStateData BattleStateData;

	private IBUC_JumpData JumpData;

	public override void OnAttach()
	{
		TouchWallFeedbackData = RequireWritableData<BUC_TouchWallFeedbackData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		BattleStateData = RequireReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>();
		JumpData = RequireReadOnlyData<IBUC_JumpData, b1.BUC_JumpData>();
	}

	public override void PreBeginPlay()
	{
		if (TouchWallFeedbackData.TraceLength <= 0f)
		{
			BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				TouchWallFeedbackData.TraceLength = bGUCharacterCS.CapsuleComponent.GetScaledCapsuleRadius() + 20f;
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (CheckCanTick())
		{
			WallCheck();
		}
	}

	public bool CheckCanTick()
	{
		if (Owner.GetVelocity().Size() < TouchWallFeedbackData.SpeedThreshold)
		{
			return false;
		}
		return true;
	}

	private void WallCheck()
	{
		if (Owner as ACharacter == null)
		{
			return;
		}
		FVector lineTraceDir_SafeNormal2D = GetLineTraceDir_SafeNormal2D();
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		FVector endTrace = fVector + lineTraceDir_SafeNormal2D * TouchWallFeedbackData.TraceLength;
		List<EObjectTypeQuery> list = new List<EObjectTypeQuery>();
		list.Add(EObjectTypeQuery.ObjectTypeQuery15);
		if (UBGUSelectUtil.LineTraceForObjects(Owner, fVector, endTrace, list, TouchWallFeedbackData.EnableDebug, out var HitResult) > 0)
		{
			if (CheckCanTrigger_HitDynamicObstacleWall(HitResult.HitActor))
			{
				OnHitDynamicObstacleWall(HitResult);
			}
			else if (CheckCanTrigger_HitCliffWall(HitResult.HitActor))
			{
				OnHitCliffWall(HitResult);
			}
		}
	}

	private FVector GetLineTraceDir_SafeNormal2D()
	{
		if (OwnerAsCharacterCS.CharacterMovement.IsFalling())
		{
			return Owner.GetVelocity().GetSafeNormal2D();
		}
		return OwnerAsCharacterCS.CharacterMovement.GetCurrentAcceleration().GetSafeNormal2D();
	}

	public bool CheckCanTrigger_HitDynamicObstacleWall(AActor HitActor)
	{
		BGU_QuestActor bGU_QuestActor = HitActor as BGU_QuestActor;
		if (bGU_QuestActor == null)
		{
			return false;
		}
		if (bGU_QuestActor.QuestActorType != EQuestActorType.DynamicObstacle)
		{
			return false;
		}
		if (Owner.World.GetTimeSeconds() - TouchWallFeedbackData.HitDynamicObstacle_LastTime < TouchWallFeedbackData.HitDynamicObstacle_ProtectTime)
		{
			return false;
		}
		return true;
	}

	public bool CheckCanTrigger_HitCliffWall(AActor HitActor)
	{
		if (Owner.GetVelocity().Size() < TouchWallFeedbackData.CliffUnbalance_SpeedThreshold)
		{
			return false;
		}
		if (!HitActor.ActorHasTag(B1GlobalFNames.CliffAirWall))
		{
			return false;
		}
		if (HitActor.ActorHasTag(B1GlobalFNames.CliffAirWall_DisableUnbalance))
		{
			return false;
		}
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (bGUCharacterCS == null || bGUCharacterCS.CharacterMovement.IsFalling())
		{
			return false;
		}
		if (JumpData != null && JumpData.IsInJump())
		{
			return false;
		}
		if (UnitStateData != null && (UnitStateData.HasState(EBGUUnitState.Attacking) || UnitStateData.HasState(EBGUUnitState.Beatback)))
		{
			return false;
		}
		if (BattleStateData != null && BattleStateData.PlayerHasBeTarget())
		{
			return false;
		}
		if (SimpleStateData != null && SimpleStateData.HasSimpleState(EBGUSimpleState.CloudMove))
		{
			return false;
		}
		return true;
	}

	private void OnHitCliffWall(FHitResultSimple ResultSimple)
	{
		FVector hitLocation = ResultSimple.HitLocation;
		FVector hitImpactNormal = ResultSimple.HitImpactNormal;
		FVector actorForwardVector = Owner.GetActorForwardVector();
		FVector2D v = new FVector2D(hitImpactNormal.GetSafeNormal2D());
		FVector2D v2 = new FVector2D(actorForwardVector.GetSafeNormal2D());
		float num = MathLib.DegAcos(MathLib.DotProduct2D(v, v2));
		DrawDebug(hitLocation, hitImpactNormal, num);
		UAnimMontage uAnimMontage = null;
		if (num <= 45f)
		{
			uAnimMontage = TouchWallFeedbackData.UnbalanceAMConfig.CliffUnbalance_B;
		}
		else if (num >= 135f)
		{
			uAnimMontage = TouchWallFeedbackData.UnbalanceAMConfig.CliffUnbalance_F;
		}
		else
		{
			FVector2D v3 = new FVector2D(Owner.GetActorRightVector());
			uAnimMontage = ((!(MathLib.DotProduct2D(v, v3) > 0f)) ? TouchWallFeedbackData.UnbalanceAMConfig.CliffUnbalance_R : TouchWallFeedbackData.UnbalanceAMConfig.CliffUnbalance_L);
		}
		if (uAnimMontage != null)
		{
			PlayPerformMontage(uAnimMontage, "CliffUnbalance");
			_ = TouchWallFeedbackData.EnableDebug;
		}
		else
		{
			_ = TouchWallFeedbackData.EnableDebug;
		}
	}

	private void OnHitDynamicObstacleWall(FHitResultSimple ResultSimple)
	{
		b1.IBUC_QuestDynamicObstacleData readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.IBUC_QuestDynamicObstacleData, BUC_QuestDynamicObstacleData>(ResultSimple.HitActor as BGU_QuestActor);
		if (readOnlyData == null)
		{
			return;
		}
		int performID = readOnlyData.PerformID;
		int actorResID = BGU_DataUtil.GetActorResID(Owner);
		string unitDynamicObstaclePerformanceConfigPath = BGW_GameDB.GetUnitDynamicObstaclePerformanceConfigPath(performID, actorResID);
		if (string.IsNullOrEmpty(unitDynamicObstaclePerformanceConfigPath))
		{
			return;
		}
		BGWDataAsset_UnitDynamicObstaclePerformanceConfig bGWDataAsset_UnitDynamicObstaclePerformanceConfig = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<BGWDataAsset_UnitDynamicObstaclePerformanceConfig>(unitDynamicObstaclePerformanceConfigPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Low);
		if (bGWDataAsset_UnitDynamicObstaclePerformanceConfig == null)
		{
			return;
		}
		TouchWallFeedbackData.HitDynamicObstacle_LastTime = Owner.World.GetTimeSeconds();
		FVector hitLocation = ResultSimple.HitLocation;
		FVector hitImpactNormal = ResultSimple.HitImpactNormal;
		if (!bGWDataAsset_UnitDynamicObstaclePerformanceConfig.bDontPlayDBC)
		{
			BGWDataAsset_B1DBC bGWDataAsset_B1DBC = BGW_PreloadAssetMgr.Get(Owner).UnitDynamicObstacle_DefaultDBC;
			if (bGWDataAsset_UnitDynamicObstaclePerformanceConfig.OverrideDBC != null)
			{
				bGWDataAsset_B1DBC = bGWDataAsset_UnitDynamicObstaclePerformanceConfig.OverrideDBC;
			}
			if (bGWDataAsset_B1DBC != null)
			{
				FTransform spawnTransform = default(FTransform);
				spawnTransform.SetLocation(hitLocation);
				spawnTransform.SetRotation(hitImpactNormal.ToOrientationQuat());
				spawnTransform.SetScale3D(FVector.OneVector);
				base.BUSEventCollection.Evt_RequestSpawnFXByDispConfigDA.Invoke(bGWDataAsset_B1DBC, out var _, null, NeedSetSpawnTransform: true, spawnTransform);
			}
		}
		if (!CanPlayHitDOMontage())
		{
			return;
		}
		FVector actorForwardVector = Owner.GetActorForwardVector();
		FVector2D v = new FVector2D(hitImpactNormal.GetSafeNormal2D());
		FVector2D v2 = new FVector2D(actorForwardVector.GetSafeNormal2D());
		float num = MathLib.DegAcos(MathLib.DotProduct2D(v, v2));
		DrawDebug(hitLocation, hitImpactNormal, num);
		UAnimMontage uAnimMontage = null;
		List<UAnimMontage> list = new List<UAnimMontage>();
		ESkillDirection eSkillDirection = ESkillDirection.None;
		switch (bGWDataAsset_UnitDynamicObstaclePerformanceConfig.PerformAMType)
		{
		case EUnitDynamicObstaclePerformAMType.OnlyFront:
			eSkillDirection = ESkillDirection.Forward;
			break;
		case EUnitDynamicObstaclePerformAMType.FrontAndBehind:
		{
			float f_DegLine_FBMode = bGWDataAsset_UnitDynamicObstaclePerformanceConfig.F_DegLine_FBMode;
			eSkillDirection = ((!(num <= f_DegLine_FBMode / 2f)) ? ESkillDirection.Forward : ESkillDirection.Backward);
			break;
		}
		case EUnitDynamicObstaclePerformAMType.FourDir:
		{
			float f_DegLine_4DirMode = bGWDataAsset_UnitDynamicObstaclePerformanceConfig.F_DegLine_4DirMode;
			float b_DegLine_4DirMode = bGWDataAsset_UnitDynamicObstaclePerformanceConfig.B_DegLine_4DirMode;
			if (num <= f_DegLine_4DirMode / 2f)
			{
				eSkillDirection = ESkillDirection.Backward;
				break;
			}
			if (num >= 180f - b_DegLine_4DirMode / 2f)
			{
				eSkillDirection = ESkillDirection.Forward;
				break;
			}
			FVector2D v3 = new FVector2D(Owner.GetActorRightVector());
			eSkillDirection = ((!(MathLib.DotProduct2D(v, v3) > 0f)) ? ESkillDirection.Right : ESkillDirection.Left);
			break;
		}
		}
		switch (eSkillDirection)
		{
		case ESkillDirection.Forward:
			list = bGWDataAsset_UnitDynamicObstaclePerformanceConfig.AM_F_List.ToList();
			break;
		case ESkillDirection.Backward:
			list = bGWDataAsset_UnitDynamicObstaclePerformanceConfig.AM_B_List.ToList();
			break;
		case ESkillDirection.Left:
			list = bGWDataAsset_UnitDynamicObstaclePerformanceConfig.AM_L_List.ToList();
			break;
		case ESkillDirection.Right:
			list = bGWDataAsset_UnitDynamicObstaclePerformanceConfig.AM_R_List.ToList();
			break;
		}
		if (list.Count > 0)
		{
			int index = FMath.RandRange(0, list.Count - 1);
			uAnimMontage = list[index];
		}
		if (uAnimMontage != null)
		{
			if (bGWDataAsset_UnitDynamicObstaclePerformanceConfig.bNeedRot)
			{
				MakeRotate(hitImpactNormal.GetSafeNormal2D(), eSkillDirection);
			}
			PlayPerformMontage(uAnimMontage, "OnHitDynamicObstacleWall");
		}
	}

	private bool CanPlayHitDOMontage()
	{
		if (OwnerAsCharacterCS == null || OwnerAsCharacterCS.CharacterMovement.IsFalling())
		{
			return false;
		}
		if (UnitStateData != null && (UnitStateData.HasState(EBGUUnitState.Attacking) || UnitStateData.HasState(EBGUUnitState.Beatback)))
		{
			return false;
		}
		if (BattleStateData != null && BattleStateData.PlayerHasBeTarget())
		{
			return false;
		}
		if (SimpleStateData != null && SimpleStateData.HasSimpleState(EBGUSimpleState.CloudMove))
		{
			return false;
		}
		return true;
	}

	private void DrawDebug(FVector HitPosition, FVector HitNormal, float AbsDegValue)
	{
	}

	private void MakeRotate(FVector NormalVector2D, ESkillDirection Dir)
	{
		FRotator newRotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(Owner);
		switch (Dir)
		{
		case ESkillDirection.Forward:
			newRotation = (-NormalVector2D).Conv_VectorToRotator();
			break;
		case ESkillDirection.Backward:
			newRotation = NormalVector2D.Conv_VectorToRotator();
			break;
		case ESkillDirection.Right:
		case ESkillDirection.Left:
		{
			FVector inVec = FVector.CrossProduct(NormalVector2D, BGUFuncLibActorTransformCS.BGUGetActorUpVector(Owner));
			if (MathLib.DotProduct2D(NormalVector2D.Conv_VectorToVector2D(), BGUFuncLibActorTransformCS.BGUGetActorForwardVector(Owner).Conv_VectorToVector2D()) < 0f)
			{
				inVec *= -1.0;
			}
			newRotation = inVec.Conv_VectorToRotator();
			break;
		}
		}
		newRotation.Pitch = 0f;
		newRotation.Roll = 0f;
		BGUFuncLibActorTransformCS.BGUSetActorRotation(Owner, newRotation, bTeleportPhysics: false);
	}

	private void PlayPerformMontage(UAnimMontage AM, string SkillBreakReason)
	{
		ACharacter aCharacter = Owner as ACharacter;
		if (!(aCharacter == null) && !(AM == null))
		{
			aCharacter.StopAnimMontage(null);
			BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, AM, FName.None);
			base.BUSEventCollection?.Evt_UnitTryBreakSkill.Invoke(SkillBreakReason);
			float sequenceLength = AM.SequenceLength;
			UGSE_AnimFuncLib.AnimMontageGetBlendInAndOutTime(AM, out var BlendInTime, out var BlendOutTime);
			sequenceLength -= BlendInTime + BlendOutTime;
			base.BUSEventCollection?.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.Beatback, sequenceLength, NeedForceUpdate: true);
		}
	}
}
