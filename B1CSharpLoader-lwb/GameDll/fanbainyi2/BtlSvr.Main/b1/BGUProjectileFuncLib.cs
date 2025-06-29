using System.Collections.Generic;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal static class BGUProjectileFuncLib
{
	public static void SelectMultiTarget(AActor Caster, out List<AActor> TargetList, FProjectileMulTargetRule FilterRule)
	{
		TargetList = new List<AActor>();
		BGUCharacterCS bGUCharacterCS = Caster as BGUCharacterCS;
		if (bGUCharacterCS == null || !FilterRule.RuleValidate())
		{
			return;
		}
		int num = FilterRule.MaxTargetNum;
		AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(Caster);
		if (!aActor.IsNullOrDestroyed())
		{
			TargetList.Add(aActor);
			num--;
		}
		UBGUSelectUtil.SphereOverlapBGUCharacters(Caster, BGUFuncLibActorTransformCS.BGUGetActorLocation(Caster), FilterRule.MaxDistance, out var OutArray);
		FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(Caster);
		FVector actorForwardVector = Caster.GetActorForwardVector();
		for (int i = 0; i < OutArray.Count; i++)
		{
			BGUCharacterCS bGUCharacterCS2 = OutArray[i] as BGUCharacterCS;
			if (bGUCharacterCS2.IsNullOrDestroyed() || (aActor != null && aActor == bGUCharacterCS2) || BGUFunctionLibraryCS.BGUIsUnitDead(bGUCharacterCS2) || !BGUFunctionLibraryCS.BGUIsEnemyTeam(bGUCharacterCS, bGUCharacterCS2) || BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS2, EBGUSimpleState.CantBeLock))
			{
				OutArray.RemoveAt(i);
				i--;
				continue;
			}
			FVector v2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(OutArray[i]);
			FVector.Dist2D(v, v2);
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(OutArray[i]) - BGUFuncLibActorTransformCS.BGUGetActorLocation(Caster);
			if (MathLib.Abs(UBUS_UtilComm.CalcDegreeFromVectorsProjectInXYPlane(actorForwardVector.GetSafeNormal2D(), fVector.GetSafeNormal2D())) > FilterRule.HalfAngle)
			{
				OutArray.RemoveAt(i);
				i--;
			}
		}
		for (int j = 0; j < num; j++)
		{
			if (OutArray.Count < 1)
			{
				break;
			}
			int index = 0;
			float num2 = FVector.Dist2D(v, BGUFuncLibActorTransformCS.BGUGetActorLocation(OutArray[0]));
			for (int k = 1; k < OutArray.Count; k++)
			{
				if (FVector.Dist2D(v, BGUFuncLibActorTransformCS.BGUGetActorLocation(OutArray[k])) < num2)
				{
					index = k;
				}
			}
			TargetList.Add(OutArray[index]);
			OutArray.RemoveAt(index);
		}
	}

	public static List<FVector> GetPointsInRangeArea(FRangePointSetRule RangePointSetRule, FVector Center)
	{
		List<FVector> list = new List<FVector>();
		switch (RangePointSetRule.RangePointSetType)
		{
		case ERangePointSetType.CircleRandom:
			list = GetPointsInCircle(Center, RangePointSetRule.CircleRadius, RangePointSetRule.MatrixDensity);
			break;
		case ERangePointSetType.DonutRandom:
			list = GetPointsInDount(Center, RangePointSetRule.CircleRadius, RangePointSetRule.InnerCircleRadius, RangePointSetRule.MatrixDensity);
			break;
		}
		if (RangePointSetRule.Noise != FVector.ZeroVector)
		{
			for (int i = 0; i < list.Count; i++)
			{
				list[i] += new FVector(FMath.FRandRange(0f - RangePointSetRule.Noise.X, RangePointSetRule.Noise.X), FMath.FRandRange(0f - RangePointSetRule.Noise.Y, RangePointSetRule.Noise.Y), FMath.FRandRange(0f - RangePointSetRule.Noise.Z, RangePointSetRule.Noise.Z));
			}
		}
		return list;
	}

	public static List<FVector> GetPointsInCircle(FVector CircleCenter, float CircleRadius, int PosDensity)
	{
		List<FVector> list = new List<FVector>();
		if (PosDensity <= 1)
		{
			return list;
		}
		FVector fVector = new FVector(-PosDensity / 2, -PosDensity / 2, 0.0);
		float num = 2f * CircleRadius / (float)(PosDensity - 1);
		for (int i = 0; i < PosDensity; i++)
		{
			for (int j = 0; j < PosDensity; j++)
			{
				FVector fVector2 = fVector + new FVector(i, j, 0.0);
				if (fVector2.Size2D() * num <= CircleRadius)
				{
					list.Add(fVector2 * num + CircleCenter);
				}
			}
		}
		return list;
	}

	public static List<FVector> GetPointsInDount(FVector CircleCenter, float OuterCircleRadius, float InnerCircleRadius, int PosDensity)
	{
		List<FVector> list = new List<FVector>();
		if (PosDensity <= 1)
		{
			return list;
		}
		FVector fVector = new FVector(-PosDensity / 2, -PosDensity / 2, 0.0);
		float num = 2f * OuterCircleRadius / (float)(PosDensity - 1);
		for (int i = 0; i < PosDensity; i++)
		{
			for (int j = 0; j < PosDensity; j++)
			{
				FVector fVector2 = fVector + new FVector(i, j, 0.0);
				float num2 = fVector2.Size2D() * num;
				if (num2 <= OuterCircleRadius && num2 >= InnerCircleRadius)
				{
					list.Add(fVector2 * num + CircleCenter);
				}
			}
		}
		return list;
	}

	public static void UpdateBulletSkillAffectArea(AActor Owner, BGUProjectileBaseActor ProjectileActor, FGSProjectileSpawnInfo SpawnBulletInfo, AActor Target)
	{
		FUStProjectileCommDesc projectileCommDesc = BGW_GameDB.GetProjectileCommDesc(SpawnBulletInfo.ProjectileID, Owner);
		if (projectileCommDesc == null || ProjectileActor.IsNullOrDestroyed() || Target.IsNullOrDestroyed())
		{
			return;
		}
		FUStBulletAffectArea bulletSkillArea = projectileCommDesc.BulletSkillArea;
		if (bulletSkillArea == null || bulletSkillArea.AreaType == EBulletAreaType.None)
		{
			return;
		}
		FRoundParam roundParam = default(FRoundParam);
		FRectParam fRectParam = default(FRectParam);
		float projectileLifeTime = projectileCommDesc.ProjectileLifeTime;
		if (projectileLifeTime == -1f)
		{
			return;
		}
		switch (bulletSkillArea.AreaType)
		{
		case EBulletAreaType.Round:
			roundParam.Radius = bulletSkillArea.AreaFloatParams[0];
			break;
		case EBulletAreaType.Rectange:
			fRectParam.Height = bulletSkillArea.AreaFloatParams[0];
			fRectParam.Width = bulletSkillArea.AreaFloatParams[1];
			fRectParam.Yaw = BGUFuncLibActorTransformCS.BGUGetActorRotation(ProjectileActor).Yaw;
			break;
		}
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		AFSkillArea aFSkillArea = UObject.NewObject<AFSkillArea>();
		aFSkillArea.ExecuteTime = bGUCharacterCS.World.GetTimeSeconds();
		aFSkillArea.TeamID = bGUCharacterCS.GetTeamIDInCS();
		aFSkillArea.RoundParam = roundParam;
		aFSkillArea.DurationTime = projectileLifeTime;
		switch (BGW_GameDB.GetProjectileMoveDesc(SpawnBulletInfo.ProjectileID).ProjectileMoveModeType)
		{
		case EBulletOrMagicFieldMoveModeType.ManualCurveMoveMode:
			aFSkillArea.BaseLoc = BGUFuncLibActorTransformCS.BGUGetActorLocation(Target);
			break;
		case EBulletOrMagicFieldMoveModeType.StraightMode:
			aFSkillArea.BaseLoc = BGUFuncLibActorTransformCS.BGUGetActorLocation(ProjectileActor) + ProjectileActor.GetActorForwardVector() * fRectParam.Height * 0.5;
			break;
		default:
			aFSkillArea.BaseLoc = BGUFuncLibActorTransformCS.BGUGetActorLocation(Target);
			break;
		}
		BGUCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(bGUCharacterCS);
		for (int i = 0; i < allActorsOfClass.Length; i++)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(allActorsOfClass[i]);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_OnGenerateSkillFeature.Invoke(aFSkillArea);
			}
		}
	}
}
