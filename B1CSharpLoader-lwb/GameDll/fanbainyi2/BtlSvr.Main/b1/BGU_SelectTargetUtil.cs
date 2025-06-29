using System;
using System.Collections.Generic;
using System.Linq;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class BGU_SelectTargetUtil
{
	public static FVector GetAutoLockCompPositionByTag(AActor TargetActor, string MatchCompName, List<string> CompTags, out bool FoundComp)
	{
		FoundComp = false;
		if (TargetActor == null)
		{
			return FVector.ZeroVector;
		}
		IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(TargetActor);
		List<UActorComponent> list = new List<UActorComponent>();
		foreach (string CompTag in CompTags)
		{
			foreach (UActorComponent item in TargetActor.GetComponentsByTag(UClass.GetClass<USceneComponent>(), new FName(CompTag)))
			{
				list.Add(item);
			}
		}
		FVector result = BGUFuncLibActorTransformCS.BGUGetActorLocation(TargetActor);
		if (list.Count > 0)
		{
			foreach (UActorComponent item2 in list)
			{
				USceneComponent uSceneComponent = item2 as USceneComponent;
				if (!(uSceneComponent == null))
				{
					string name = uSceneComponent.GetName();
					if ((readOnlyData == null || !readOnlyData.DisabledAutoLockSceneComp.Contains(name)) && name.Equals(MatchCompName))
					{
						FoundComp = true;
						result = uSceneComponent.GetWorldLocation();
						break;
					}
				}
			}
		}
		return result;
	}

	public static void UpdateAutoLockPointInfoByTargetActor(AActor SelfActor, ref UnitLockTargetInfo BestLockTargetInfo, FVector MyPos, FRotator MyDir, float AngleMax, float AngleScoreRating, float DistScoreRating, float HeightScoreRating, float Z_Limit, List<string> CompTags, float RangeDist = 0f, float PelvisExtraScore = 0f, bool bPreferPelvis = false)
	{
		if (BestLockTargetInfo == null)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = SelfActor as BGUCharacterCS;
		if (bGUCharacterCS.IsNullOrDestroyed() || BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(SelfActor) == null)
		{
			return;
		}
		AActor lockTargetActor = BestLockTargetInfo.LockTargetActor;
		BGUCharacterCS bGUCharacterCS2 = lockTargetActor as BGUCharacterCS;
		IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(lockTargetActor);
		if (lockTargetActor == null || readOnlyData == null || BGUFunctionLibraryCS.BGUIsUnitDead(lockTargetActor))
		{
			return;
		}
		FVector b = MyDir.Vector();
		b.Z = 0f;
		float num = -999999f;
		foreach (string CompTag in CompTags)
		{
			List<UActorComponent> componentsByTag = lockTargetActor.GetComponentsByTag(UClass.GetClass<USceneComponent>(), new FName(CompTag));
			if (componentsByTag.Count <= 0)
			{
				continue;
			}
			foreach (UActorComponent item in componentsByTag)
			{
				USceneComponent uSceneComponent = item as USceneComponent;
				if (uSceneComponent == null)
				{
					continue;
				}
				string name = uSceneComponent.GetName();
				if (readOnlyData.DisabledAutoLockSceneComp.Contains(name))
				{
					continue;
				}
				FVector worldLocation = uSceneComponent.GetWorldLocation();
				FVector fVector = worldLocation - MyPos;
				fVector.Z = 0f;
				float num2 = bGUCharacterCS.Mesh.GetSocketLocation(B1GlobalFNames.pelvis).Z - worldLocation.Z;
				if (Z_Limit != 0f && FMath.Abs(num2) > Z_Limit)
				{
					continue;
				}
				float num3 = fVector.CosineAngle2D(b);
				if (!(num3 < FMath.Cos(FMath.DegreesToRadians(AngleMax * 0.5f))))
				{
					float num4 = (0f - FVector.Dist2D(MyPos, worldLocation)) * DistScoreRating + num2 * HeightScoreRating + num3 * AngleScoreRating;
					if (num4 > num)
					{
						BestLockTargetInfo.LockTargetSceneCompName = name;
						BestLockTargetInfo.LockTargetType = ELockTargetType.SceneComp;
						num = num4;
					}
				}
			}
		}
		if (!bPreferPelvis || !(bGUCharacterCS2 != null) || !(bGUCharacterCS2.Mesh != null) || !bGUCharacterCS2.Mesh.DoesSocketExist(B1GlobalFNames.pelvis))
		{
			return;
		}
		USceneComponent SocketOwnerComp;
		FVector location = BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, lockTargetActor, B1GlobalFNames.pelvis, out SocketOwnerComp).GetLocation();
		float z = bGUCharacterCS.Mesh.GetSocketLocation(B1GlobalFNames.pelvis).Z;
		float num5 = FVector.Dist2D(MyPos, location);
		if (num5 > RangeDist)
		{
			return;
		}
		float num6 = z - location.Z;
		if (Z_Limit == 0f || !(FMath.Abs(num6) > Z_Limit))
		{
			FVector safeNormal2D = (location - MyPos).GetSafeNormal2D();
			float num7 = 0f;
			num7 = safeNormal2D.CosineAngle2D(b);
			if (!(num7 < FMath.Cos(FMath.DegreesToRadians(AngleMax * 0.5f))) && (0f - num5) * DistScoreRating + num6 * HeightScoreRating + num7 * AngleScoreRating + PelvisExtraScore > num)
			{
				BestLockTargetInfo.LockTargetSceneCompName = "";
				BestLockTargetInfo.LockTargetType = ELockTargetType.SkeletonSocket;
				BestLockTargetInfo.LockTargetSkeletonSocketName = B1GlobalFNames.pelvis.ToString();
			}
		}
	}

	public static UnitLockTargetInfo SelectAutoLockTargetInRange(AActor SelfActor, FRotator MyDir, EBSelectTargetRangeType RangeType, float FirstFilterMaxRange, float AngleMax, float DistScoreRating, float HeightScoreRating, float AngleScoreRating, float AutoPointZ_Limit, float PreferActorDistTolerance = 0f, bool PreferElite = false, float PelvisExtraScore = 0f, bool PreferPelvisPoint = false)
	{
		UnitLockTargetInfo result = new UnitLockTargetInfo();
		if (SelfActor == null)
		{
			return result;
		}
		ABGUCharacter aBGUCharacter = SelfActor as ABGUCharacter;
		if (aBGUCharacter == null)
		{
			return result;
		}
		IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(SelfActor);
		if (readOnlyData == null)
		{
			return result;
		}
		UnitLockTargetInfo targetInfo = readOnlyData.GetTargetInfo();
		AActor lockTargetActor = targetInfo.LockTargetActor;
		if (lockTargetActor != null && targetInfo.LockTargetWayType != ELockTargetWayType.Auto && !BGUFunctionLibraryCS.BGUHasUnitState(lockTargetActor, EBGUUnitState.Dead) && !BGUFunctionLibraryCS.BGUHasUnitSimpleState(lockTargetActor, EBGUSimpleState.PendingDeathInAnimationSyncing))
		{
			result = targetInfo;
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(aBGUCharacter);
		FVector b = MyDir.Vector();
		b.Z = 0f;
		BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_SmartCastSkillData, b1.BUC_SmartCastSkillData>(SelfActor);
		IBPC_InputData playerControlReadonlyData = BGU_DataUtil.GetPlayerControlReadonlyData<IBPC_InputData, BPC_InputData>(SelfActor.GetInstigatorController() as APlayerController);
		APlayerCameraManager localPlayerCameraManager = UGSE_EngineFuncLib.GetLocalPlayerCameraManager(SelfActor);
		FVector forwardVector = localPlayerCameraManager.GetCameraRotation().GetForwardVector();
		FRotator cameraRotation = localPlayerCameraManager.GetCameraRotation();
		forwardVector.Z = 0f;
		float num = 0f;
		float num2 = 0f;
		FVector fVector2 = FVector.ZeroVector;
		if (playerControlReadonlyData != null)
		{
			num = playerControlReadonlyData.GetInputValue(GSBattleActionEn.MoveForward);
			num2 = playerControlReadonlyData.GetInputValue(GSBattleActionEn.MoveSideways);
			fVector2 = new FVector(num, num2, 0.0).GetSafeNormal2D().RotateAngleAxis(cameraRotation.Yaw, FVector.UpVector);
		}
		UBGUSelectUtil.SphereOverlapBGUCharacters(aBGUCharacter, fVector, FirstFilterMaxRange, out var OutArray, ECollisionChannel.ECC_PhysicsBody);
		float num3 = -999999f;
		Dictionary<ABGUCharacter, float> dictionary = new Dictionary<ABGUCharacter, float>();
		for (int i = 0; i < OutArray.Count; i++)
		{
			if (!(OutArray[i] is BGUCharacterCS bGUCharacterCS) || bGUCharacterCS == aBGUCharacter || BGUFunctionLibraryCS.BGUIsUnitDead(bGUCharacterCS) || BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS, EBGUSimpleState.CantBeBaseTarget) || BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS, EBGUSimpleState.CantBeAutoLockTarget) || !BGUFunctionLibraryCS.BGUIsEnemyTeam(aBGUCharacter, bGUCharacterCS))
			{
				continue;
			}
			IBUC_TargetInfoData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(bGUCharacterCS);
			List<UActorComponent> componentsByTag = bGUCharacterCS.GetComponentsByTag(UClass.GetClass<USceneComponent>(), B1GlobalFNames.AutoLockPoint);
			foreach (UActorComponent item in bGUCharacterCS.GetComponentsByTag(UClass.GetClass<USceneComponent>(), B1GlobalFNames.AutoLockPoint_SP))
			{
				componentsByTag.Add(item);
			}
			FVector fVector3 = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS);
			FVector fVector4 = fVector3 - fVector;
			float num4 = -1f;
			fVector4.Z = 0f;
			float z = aBGUCharacter.Mesh.GetSocketLocation(B1GlobalFNames.pelvis).Z;
			if (lockTargetActor != null && lockTargetActor == bGUCharacterCS && (targetInfo.LockTargetWayType != ELockTargetWayType.Auto || fVector2 == FVector.ZeroVector))
			{
				result = targetInfo;
				float num5 = -999999f;
				foreach (UActorComponent item2 in componentsByTag)
				{
					USceneComponent uSceneComponent = item2 as USceneComponent;
					if (uSceneComponent == null)
					{
						continue;
					}
					string name = uSceneComponent.GetName();
					if (readOnlyData2 != null && readOnlyData2.DisabledAutoLockSceneComp.Contains(name))
					{
						continue;
					}
					fVector3 = uSceneComponent.GetWorldLocation();
					float num6 = z - fVector3.Z;
					if (AutoPointZ_Limit != 0f && FMath.Abs(num6) > AutoPointZ_Limit)
					{
						continue;
					}
					float num7 = FVector.Dist2D(fVector, fVector3);
					if (num7 > FirstFilterMaxRange + PreferActorDistTolerance)
					{
						continue;
					}
					FVector fVector5 = fVector3 - fVector;
					float num8 = 0f;
					num8 = ((!(fVector2 != FVector.ZeroVector)) ? fVector5.CosineAngle2D(b) : fVector5.CosineAngle2D(fVector2));
					if (!(fVector5.CosineAngle2D(b) < FMath.Cos(FMath.DegreesToRadians(AngleMax * 0.5f))))
					{
						num4 = (0f - num7) * DistScoreRating + num6 * HeightScoreRating + num8 * AngleScoreRating;
						if (num4 > num5)
						{
							result = new UnitLockTargetInfo(bGUCharacterCS, ETargetSourceType.None, ELockTargetWayType.Auto, name);
							num5 = num4;
						}
					}
				}
				break;
			}
			if (componentsByTag.Count > 0)
			{
				foreach (UActorComponent item3 in componentsByTag)
				{
					USceneComponent uSceneComponent2 = item3 as USceneComponent;
					if (uSceneComponent2 == null)
					{
						continue;
					}
					string name2 = uSceneComponent2.GetName();
					if (readOnlyData2 != null && readOnlyData2.DisabledAutoLockSceneComp.Contains(name2))
					{
						continue;
					}
					fVector3 = uSceneComponent2.GetWorldLocation();
					float num9 = z - fVector3.Z;
					if (AutoPointZ_Limit != 0f && FMath.Abs(num9) > AutoPointZ_Limit)
					{
						continue;
					}
					float num10 = FVector.Dist2D(fVector, fVector3);
					if (num10 > FirstFilterMaxRange)
					{
						continue;
					}
					FVector fVector6 = fVector3 - fVector;
					float num11 = 0f;
					num11 = ((!(fVector2 != FVector.ZeroVector)) ? fVector6.CosineAngle2D(b) : fVector6.CosineAngle2D(fVector2));
					if (!(fVector6.CosineAngle2D(b) < FMath.Cos(FMath.DegreesToRadians(AngleMax * 0.5f))))
					{
						num4 = (0f - num10) * DistScoreRating + num9 * HeightScoreRating + num11 * AngleScoreRating;
						if (num4 > num3)
						{
							result = new UnitLockTargetInfo(bGUCharacterCS, ETargetSourceType.None, ELockTargetWayType.Auto, name2);
							num3 = num4;
						}
					}
				}
			}
			else
			{
				float num12 = FVector.Dist2D(fVector, fVector3);
				if (num12 > FirstFilterMaxRange)
				{
					continue;
				}
				FVector safeNormal2D = (fVector3 - fVector).GetSafeNormal2D();
				float num13 = 0f;
				num13 = ((!(fVector2 != FVector.ZeroVector)) ? safeNormal2D.CosineAngle2D(b) : safeNormal2D.CosineAngle2D(fVector2));
				if (safeNormal2D.CosineAngle2D(b) < FMath.Cos(FMath.DegreesToRadians(AngleMax * 0.5f)))
				{
					continue;
				}
				float num14 = z - fVector3.Z;
				if (AutoPointZ_Limit != 0f && FMath.Abs(num14) > AutoPointZ_Limit)
				{
					continue;
				}
				num4 = (0f - num12) * DistScoreRating + num14 * HeightScoreRating + num13 * AngleScoreRating;
				if (num4 > num3)
				{
					result = new UnitLockTargetInfo(bGUCharacterCS, ETargetSourceType.None, ELockTargetWayType.Auto);
					num3 = num4;
				}
			}
			if (PreferElite)
			{
				FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(bGUCharacterCS.GetResID());
				if (unitCommDesc != null && unitCommDesc.IsElite == EGSYesNo.Yes)
				{
					if (dictionary.Count > 0)
					{
						if (dictionary.Values.ElementAt(0) > num4)
						{
							dictionary.Clear();
							dictionary[bGUCharacterCS] = num4;
						}
					}
					else
					{
						dictionary[bGUCharacterCS] = num4;
					}
				}
			}
			if (!PreferPelvisPoint || !(bGUCharacterCS.Mesh != null) || !bGUCharacterCS.Mesh.DoesSocketExist(B1GlobalFNames.pelvis))
			{
				continue;
			}
			USceneComponent SocketOwnerComp;
			FVector location = BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, bGUCharacterCS, B1GlobalFNames.pelvis, out SocketOwnerComp).GetLocation();
			float num15 = FVector.Dist2D(fVector, location);
			if (num15 > FirstFilterMaxRange)
			{
				continue;
			}
			float num16 = z - location.Z;
			if (AutoPointZ_Limit != 0f && FMath.Abs(num16) > AutoPointZ_Limit)
			{
				continue;
			}
			FVector safeNormal2D2 = (location - fVector).GetSafeNormal2D();
			float num17 = 0f;
			num17 = ((!(fVector2 != FVector.ZeroVector)) ? safeNormal2D2.CosineAngle2D(b) : safeNormal2D2.CosineAngle2D(fVector2));
			if (!(safeNormal2D2.CosineAngle2D(b) < FMath.Cos(FMath.DegreesToRadians(AngleMax * 0.5f))))
			{
				num4 = (0f - num15) * DistScoreRating + num16 * HeightScoreRating + num17 * AngleScoreRating + PelvisExtraScore;
				if (num4 > num3)
				{
					result = new UnitLockTargetInfo(bGUCharacterCS, ETargetSourceType.None, ELockTargetWayType.Auto, "", B1GlobalFNames.pelvis.ToString());
					num3 = num4;
				}
			}
		}
		if (PreferElite && dictionary.Count > 0)
		{
			result = new UnitLockTargetInfo(dictionary.Keys.ElementAt(0), ETargetSourceType.None, ELockTargetWayType.Auto);
		}
		return result;
	}

	public static FVector GetTargetPositionByTargetInfo(in UnitLockTargetInfo TargetInfo, out bool FoundComp, bool EnableAutoLockPoint = true, string TraceSocket = "")
	{
		return GetTargetPositionByTargetInfo(in TargetInfo, new List<string> { "AutoLockPoint" }, out FoundComp, EnableAutoLockPoint, TraceSocket);
	}

	public static FVector GetTargetPositionByTargetInfo(in UnitLockTargetInfo TargetInfo, List<string> CompsTag, out bool FoundComp, bool EnableAutoLockPoint = true, string TraceSocket = "")
	{
		FoundComp = false;
		if (TargetInfo.LockTargetActor == null)
		{
			return FVector.ZeroVector;
		}
		AActor lockTargetActor = TargetInfo.LockTargetActor;
		FVector result = BGUFuncLibActorTransformCS.BGUGetActorLocation(lockTargetActor);
		if (lockTargetActor is ACharacter aCharacter && aCharacter.Mesh != null)
		{
			if (TraceSocket.Length > 0)
			{
				return aCharacter.Mesh.GetSocketLocation(new FName(TraceSocket));
			}
			switch (TargetInfo.LockTargetType)
			{
			case ELockTargetType.Actor:
				if (aCharacter.Mesh.DoesSocketExist(B1GlobalFNames.CAMERA_LOCK))
				{
					result = aCharacter.Mesh.GetSocketLocation(B1GlobalFNames.CAMERA_LOCK);
				}
				break;
			case ELockTargetType.SceneComp:
				if (EnableAutoLockPoint)
				{
					result = GetAutoLockCompPositionByTag(lockTargetActor, TargetInfo.LockTargetSceneCompName, CompsTag, out FoundComp);
				}
				break;
			case ELockTargetType.SkeletonSocket:
				result = aCharacter.Mesh.GetSocketLocation(new FName(TargetInfo.LockTargetSkeletonSocketName));
				break;
			}
		}
		return result;
	}

	public static bool QueryBestLocationByCondition(AActor Querier, in List<FVector> Locations, in List<FRotator> Rotations, bool bUseCompositeV2, QueryBestLocationCondition Condition, out int BestIndex)
	{
		BestIndex = -1;
		int count = Locations.Count;
		if (count <= 0)
		{
			return false;
		}
		float[] array = new float[count];
		float[] array2 = new float[count];
		int[] array3 = new int[count];
		float num = float.MaxValue;
		float num2 = -1f;
		float num3 = float.MaxValue;
		float num4 = -1f;
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Querier);
		if (Condition.EnableDistanceScope)
		{
			num = Condition.MinDistance;
			num2 = Condition.MaxDistance;
		}
		if (Condition.EnableAngleScope)
		{
			num3 = Condition.MinAngle;
			num4 = Condition.MaxAngle;
		}
		for (int i = 0; i < count; i++)
		{
			FVector fVector2 = Locations[i];
			FRotator fRotator = Rotations[i];
			if (bUseCompositeV2)
			{
				float num5 = FVector.Dist2D(fVector2, fVector);
				array[i] = Math.Abs(Condition.BestLandingDistance - num5) * Condition.DistanceCoefficient;
				FVector2D safeNormal = Querier.GetActorForwardVector().Conv_VectorToVector2D().GetSafeNormal();
				FVector2D safeNormal2 = (fVector2 - fVector).Conv_VectorToVector2D().GetSafeNormal();
				float num6 = MathLib.DotProduct2D(safeNormal, safeNormal2);
				array2[i] = (num6 + 1f) * Condition.AngleCoefficient;
			}
			else
			{
				if (MathLib.Abs(Condition.DistanceWeight) > 1E-08f)
				{
					float num7 = FVector.Distance(fVector2, fVector);
					if (!Condition.EnableDistanceScope)
					{
						num = Math.Min(num, num7);
						num2 = Math.Max(num2, num7);
					}
					array[i] = num7;
				}
				if (MathLib.Abs(Condition.AngleWeight) > 1E-08f)
				{
					FVector2D safeNormal3 = Querier.GetActorForwardVector().Conv_VectorToVector2D().GetSafeNormal();
					FVector2D safeNormal4 = (fVector2 - fVector).Conv_VectorToVector2D().GetSafeNormal();
					float num8 = MathLib.DegAcos(MathLib.DotProduct2D(safeNormal3, safeNormal4));
					float num9 = 0f;
					if (Condition.bConsiderTargetAngle)
					{
						FVector2D v = safeNormal4;
						safeNormal4 = fRotator.Vector().Conv_VectorToVector2D().GetSafeNormal();
						num9 = MathLib.DegAcos(MathLib.DotProduct2D(v, safeNormal4));
					}
					float num10 = MathLib.ClampAxis(num8 + num9);
					if (!Condition.EnableAngleScope)
					{
						num3 = Math.Min(num3, num10);
						num4 = Math.Max(num4, num10);
					}
					array2[i] = num10;
				}
			}
			if (MathLib.Abs(Condition.LineTraceWeight) > 1E-08f)
			{
				List<EObjectTypeQuery> objectTypes = new List<EObjectTypeQuery> { UBGUFunctionLibraryForCS.ConvertToObjectType(ECollisionChannel.ECC_Visibility) };
				array3[i] = UBGUSelectUtil.LineTraceForObjects(Querier, fVector, fVector2, objectTypes, bDebug: false, out var _);
			}
		}
		float num11 = num2 - num;
		float num12 = num4 - num3;
		float num13 = -1f;
		if (bUseCompositeV2)
		{
			for (int j = 0; j < count; j++)
			{
				float num14 = array[j] + array2[j];
				if (num14 > num13)
				{
					num13 = num14;
					BestIndex = j;
				}
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				float num15 = 0f;
				float num16 = 0f;
				float num17 = array[k];
				if (num17 < num || num17 > num2)
				{
					num16 = 0f;
				}
				else if (num11 > 0f)
				{
					num16 = (num17 - num) / num11;
					if (Condition.DistanceWeight < 0f)
					{
						num16 -= 1f;
					}
				}
				num15 += num16 * Condition.DistanceWeight;
				float num18 = 0f;
				float num19 = array2[k];
				if (Condition.EnableAngleScope && (num19 < num3 || num19 > num4))
				{
					num18 = 0f;
				}
				else if (num12 > 0f)
				{
					num18 = (array2[k] - num3) / num12;
					if (Condition.AngleWeight < 0f)
					{
						num18 -= 1f;
					}
				}
				else if (num12 == 0f)
				{
					num18 = ((Condition.AngleWeight > 0f) ? 1 : (-1));
				}
				num15 += num18 * Condition.AngleWeight;
				float num20 = array3[k];
				if (Condition.LineTraceWeight < 0f)
				{
					num20 -= 1f;
				}
				num15 += num20 * Condition.LineTraceWeight;
				if (num15 > num13)
				{
					num13 = num15;
					BestIndex = k;
				}
			}
		}
		if (num13 == 0f || BestIndex < 0)
		{
			return false;
		}
		return true;
	}

	public static ABGUCharacter FindTargetInDist(ABGUCharacter MyActor, FVector RefPos, List<ABGUCharacter> TargetList)
	{
		ABGUCharacter result = null;
		float num = 1E+09f;
		for (int i = 0; i < TargetList.Count; i++)
		{
			ABGUCharacter aBGUCharacter = TargetList[i];
			if (BGU_CommonUtil.IsValidTarget(MyActor, aBGUCharacter))
			{
				FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(aBGUCharacter);
				float num2 = FVector.Dist(RefPos, v);
				if (num > num2)
				{
					num = num2;
					result = aBGUCharacter;
				}
			}
		}
		return result;
	}

	public static UnitLockTargetInfo FindTargetWithBestDensity(AActor SelfActor, float FirstFilterMaxRange, float DensityRange)
	{
		UnitLockTargetInfo result = new UnitLockTargetInfo();
		ABGUCharacter aBGUCharacter = SelfActor as ABGUCharacter;
		if (aBGUCharacter.IsNullOrDestroyed())
		{
			return result;
		}
		int num = 0;
		UBGUSelectUtil.SphereOverlapBGUCharacters(aBGUCharacter, BGUFuncLibActorTransformCS.BGUGetActorLocation(aBGUCharacter), FirstFilterMaxRange, out var OutArray);
		foreach (ABGUCharacter item in OutArray)
		{
			if (!(item != aBGUCharacter) || BGUFunctionLibraryCS.BGUIsUnitDead(item) || !BGUFunctionLibraryCS.BGUIsEnemyTeam(aBGUCharacter, item))
			{
				continue;
			}
			UBGUSelectUtil.SphereOverlapBGUCharacters(item, BGUFuncLibActorTransformCS.BGUGetActorLocation(item), DensityRange, out var OutArray2);
			for (int num2 = OutArray2.Count - 1; num2 >= 0; num2--)
			{
				if (!BGUFunctionLibraryCS.BGUIsEnemyTeam(aBGUCharacter, OutArray2[num2]))
				{
					OutArray2.RemoveAt(num2);
				}
			}
			if (OutArray2.Count >= num)
			{
				num = OutArray2.Count + 1;
				result = new UnitLockTargetInfo(item, ETargetSourceType.None, ELockTargetWayType.Auto);
			}
		}
		return result;
	}
}
