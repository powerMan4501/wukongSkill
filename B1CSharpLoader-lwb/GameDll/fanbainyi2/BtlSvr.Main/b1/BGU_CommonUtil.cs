using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class BGU_CommonUtil
{
	public static bool IsValidTarget(AActor SelfActor, AActor TargetActor)
	{
		if (TargetActor == null)
		{
			return false;
		}
		if (SelfActor != TargetActor && !BGUFunctionLibraryCS.BGUIsUnitDead(TargetActor) && BGUFunctionLibraryCS.BGUIsEnemyTeam(SelfActor, TargetActor))
		{
			return true;
		}
		return false;
	}

	public static bool IsSkillInCoolDown(int SkillID, AActor CastActor)
	{
		if (CastActor.IsNullOrDestroyed())
		{
			return true;
		}
		IBUC_SkillInstsData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>(CastActor);
		if (unPersistentReadOnlyData == null)
		{
			return true;
		}
		if (BGW_LogUtil.LogIfNull(BGW_GameDB.GetSkillSDesc(SkillID, CastActor), "Find GetSkillSDesc failed! SkillID: {0}", SkillID))
		{
			return true;
		}
		return !unPersistentReadOnlyData.GetSkillCanCastByCDCondition(SkillID);
	}

	public static bool IsWithBuff(AActor OwnerActor, int BuffID)
	{
		if (OwnerActor == null)
		{
			return false;
		}
		BuffInstData BuffData;
		return BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(OwnerActor)?.GetBuffInstData(BuffID, out BuffData) ?? false;
	}

	public static float GetBuffLeftTime(AActor OwnerActor, int BuffID)
	{
		BUC_BuffData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(OwnerActor);
		if (readOnlyData == null)
		{
			return 0f;
		}
		if (!readOnlyData.GetBuffInstData(BuffID, out var BuffData))
		{
			return 0f;
		}
		return BuffData.LeftTime;
	}

	public static bool IsNeedMoveAttackRoateToTarget(AActor MySelf, AActor TargetActor)
	{
		if (TargetActor == null || MySelf == null)
		{
			return false;
		}
		FVector actorForwardVector = MySelf.GetActorForwardVector();
		FVector a = BGUFuncLibActorTransformCS.BGUGetActorLocation(TargetActor) - BGUFuncLibActorTransformCS.BGUGetActorLocation(MySelf);
		a.Normalize();
		if ((float)UMathLibrary.DegAcos((float)a.Dot_VectorVector(actorForwardVector)) >= BMGlobalConf.PlayerMoveAttackForceRoateAngleMinValue)
		{
			return true;
		}
		return false;
	}

	public static ECanCastSkillResult CheckSkillCanCast(AActor SkillCaster, int OriginSkillID, int InSkillID)
	{
		return GSSkillCastChecker.Get().CheckSkillCastable(SkillCaster, OriginSkillID, InSkillID);
	}

	public static long GetSkillCanCastResults(AActor SkillCaster, int OriginSkillID, int InSkillID, bool AISkipStateJudge = false, bool NeedGetComboTarget = false, bool NeedCheckComboForAI = false, FVector ComboTargetPosition = default(FVector), bool UsePursuitAnyWhere = false, bool UseComboCondition = false)
	{
		return GSSkillCastChecker.Get().QuerySkillCanCast(SkillCaster, OriginSkillID, InSkillID, AISkipStateJudge, NeedCheckComboForAI, NeedGetComboTarget, ComboTargetPosition, UsePursuitAnyWhere, UseComboCondition);
	}

	public static bool GetCurrentPlayer(UObject WorldContextObject, out ACharacter Player)
	{
		Player = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContextObject)?.GetControlledPawn() as ACharacter;
		if (Player == null)
		{
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(WorldContextObject, UClass.GetClass<BGUCharacterCS>());
			for (int i = 0; i < allActorsOfClass.Length; i++)
			{
				BGUCharacterCS bGUCharacterCS = allActorsOfClass[i] as BGUCharacterCS;
				if (!(bGUCharacterCS != null))
				{
					continue;
				}
				AActor cameraViewTarget = UGSE_CameraUtilFuncLib.GetCameraViewTarget(UGSE_EngineFuncLib.GetLocalPlayerCameraManager(WorldContextObject));
				AController controller = bGUCharacterCS.GetController();
				if (controller != null)
				{
					AActor viewTarget = controller.GetViewTarget();
					if (cameraViewTarget != null && viewTarget != null && cameraViewTarget.GetUniqueID() == viewTarget.GetUniqueID())
					{
						Player = bGUCharacterCS;
						break;
					}
				}
			}
		}
		return Player != null;
	}

	public static bool HasDamageSkillEffect(List<int> SkillEffects)
	{
		bool result = false;
		foreach (int SkillEffect in SkillEffects)
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(SkillEffect, null);
			if (skillEffectDesc != null && skillEffectDesc.EffectType == EBuffAndSkillEffectType.SkillDamage)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	public static void DrawSkillEffectArea(AActor Owner, AActor TargetBase, ERangeType RangeType, IList<int> Params)
	{
		if (TargetBase == null)
		{
			return;
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(TargetBase);
		FVector actorForwardVector = TargetBase.GetActorForwardVector();
		switch (RangeType)
		{
		case ERangeType.Circle:
			if (Params.Count >= 1 && (float)Params[0] > 0f)
			{
				UBGUFunctionLibraryForCS.BGUDrawDebugCircle(Owner.World, fVector, Params[0]);
			}
			break;
		case ERangeType.Rect:
			if (Params.Count >= 2 && (float)Params[0] > 0f && (float)Params[1] > 0f)
			{
				UBGUFunctionLibraryForCS.BGUDrawDebugRect(Owner.World, fVector, actorForwardVector, Params[0], Params[1]);
			}
			break;
		case ERangeType.ForwardRect:
			if (Params.Count >= 2 && (float)Params[0] > 0f && (float)Params[1] > 0f)
			{
				UBGUFunctionLibraryForCS.BGUDrawDebugRect(Owner.World, fVector + actorForwardVector * Params[1] / 2.0, actorForwardVector, Params[0], Params[1]);
			}
			break;
		case ERangeType.Ring:
			if (Params.Count >= 4)
			{
				UBGUFunctionLibraryForCS.BGUDrawDebugCircle(Owner.World, fVector, Params[0]);
				UBGUFunctionLibraryForCS.BGUDrawDebugCircle(Owner.World, fVector, Params[1]);
				FVector fVector2 = BGUFuncLibNonRuntime.BGW_VectorRotationByAngle2D(Params[2], Owner.GetActorForwardVector());
				FVector fVector3 = BGUFuncLibNonRuntime.BGW_VectorRotationByAngle2D(Params[3], Owner.GetActorForwardVector());
				UBGUFunctionLibraryForCS.BGUDrawLineArrowEx(Owner.World, BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner), BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner) + fVector2 * Params[1], 100f, FColor.Blue, IsPersistentLines: false, 0.5f);
				UBGUFunctionLibraryForCS.BGUDrawLineArrowEx(Owner.World, BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner), BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner) + fVector3 * Params[1], 100f, FColor.Blue, IsPersistentLines: false, 0.5f);
			}
			break;
		case ERangeType.Cylinder:
		case ERangeType.Sphere:
		case ERangeType.Sector:
			break;
		}
	}

	public static bool IsInFsmState(AActor Unit, EBGUFSMStateName StateName)
	{
		return BGU_DataUtil.GetReadOnlyData<IBUC_FsmData, BUC_FsmData>(Unit)?.IsInFsmState(StateName) ?? false;
	}

	public static bool IsInFsmState(AActor Unit, FGameplayTag StateTag)
	{
		return BGU_DataUtil.GetReadOnlyData<IBUC_FsmData, BUC_FsmData>(Unit)?.IsInFsmState(StateTag) ?? false;
	}
}
