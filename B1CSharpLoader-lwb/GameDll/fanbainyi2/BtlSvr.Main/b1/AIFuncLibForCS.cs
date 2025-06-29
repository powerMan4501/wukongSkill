using System.Collections.Generic;
using System.Linq;
using BtlShare;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.NavigationSystem;
using UnrealEngine.Runtime;

namespace b1;

public class AIFuncLibForCS
{
	public static bool CompareValue(float Ori, float Target, EValueCompareType CompareType)
	{
		return CompareType switch
		{
			EValueCompareType.IsEqualTo => Ori == Target, 
			EValueCompareType.IsNotEqualTo => Ori != Target, 
			EValueCompareType.IsGreaterThan => Ori > Target, 
			EValueCompareType.IsGreaterThanOrEqualTo => Ori >= Target, 
			EValueCompareType.IsLessThan => Ori < Target, 
			EValueCompareType.IsLessThanOrEqualTo => Ori <= Target, 
			_ => false, 
		};
	}

	public static float ActorDistance(AActor Actor1, AActor Actor2)
	{
		if (Actor1 != null && Actor2 != null)
		{
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Actor1);
			FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(Actor2);
			return (fVector - fVector2).Size2D();
		}
		return 0f;
	}

	public static void GetTurnAngle(AActor OwnerCharacter, FVector TargetPos, out float AbsDegValue, out bool IsClockwise)
	{
		FVector actorForwardVector = OwnerCharacter.GetActorForwardVector();
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter);
		FVector2D a = new FVector2D(actorForwardVector);
		FVector2D a2 = new FVector2D(TargetPos - fVector);
		a = a.NormalSafe2D();
		a2 = a2.NormalSafe2D();
		float a3 = MathLib.DotProduct2D(a, a2);
		AbsDegValue = MathLib.DegAcos(a3);
		IsClockwise = BGU_MoveUtil.IsRotateClockwise(a, a2);
	}

	public static float GetTurnSpeed(AActor OwnerActor, float AbsRotateAngle)
	{
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(BGU_DataUtil.GetActorResID(OwnerActor));
		if (unitCommDesc != null)
		{
			if (AbsRotateAngle <= 90f)
			{
				return unitCommDesc.TurnSpeed;
			}
			return unitCommDesc.BigTurnSpeed;
		}
		return 0f;
	}

	public static void PrintDebugMessage(AActor OwnerActor, string Title, string DebugMessage, EBattleInfoType InfoType = EBattleInfoType.AINode)
	{
		if (DebugConfig.IsOpenBattleInfoTool && !(OwnerActor == null))
		{
			BGUFunctionLibraryCS.LogBattleInfo(OwnerActor, InfoType, "<character>" + OwnerActor.GetName().ConvertLongGuid2DisplayGuid() + "</><effect>【" + Title + "】</><action>" + DebugMessage + "</>");
		}
	}

	public static int GetTurnSkillIDByAngle(AActor OwnerActor, float Angle, bool IsClockwise)
	{
		int result = 0;
		IBUC_SkillInstsData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>(OwnerActor);
		if (readOnlyData != null)
		{
			result = (IsClockwise ? ((!(Angle <= 135f)) ? readOnlyData.GetTurnSkillID(TurnSkillType.RightBig) : readOnlyData.GetTurnSkillID(TurnSkillType.RightSmall)) : ((!(Angle <= 135f)) ? readOnlyData.GetTurnSkillID(TurnSkillType.LeftBig) : readOnlyData.GetTurnSkillID(TurnSkillType.LeftSmall)));
		}
		return result;
	}

	public static int GetMoveSkillIDByAngle(AActor OwnerActor, float Angle, bool IsClockwise)
	{
		int result = 0;
		IBUC_SkillInstsData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>(OwnerActor);
		if (readOnlyData != null)
		{
			result = (IsClockwise ? ((!(Angle <= 135f)) ? readOnlyData.GetMoveSkillID(TurnSkillType.RightBig) : readOnlyData.GetMoveSkillID(TurnSkillType.RightSmall)) : ((!(Angle <= 135f)) ? readOnlyData.GetMoveSkillID(TurnSkillType.LeftBig) : readOnlyData.GetMoveSkillID(TurnSkillType.LeftSmall)));
		}
		return result;
	}

	public static float GetUnitSpeedRateByMoveSpeedType(AActor Unit, EAIMoveSpeedType AIMoveSpeedType)
	{
		float result = 0f;
		if (Unit != null)
		{
			IBUC_SpeedCtrlData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_SpeedCtrlData, BUC_SpeedCtrlData>(Unit);
			if (unPersistentReadOnlyData != null)
			{
				float moveSpeedSlow = unPersistentReadOnlyData.GetMoveSpeedSlow();
				float moveSpeedNormal = unPersistentReadOnlyData.GetMoveSpeedNormal();
				float moveSpeedFast = unPersistentReadOnlyData.GetMoveSpeedFast();
				switch (AIMoveSpeedType)
				{
				case EAIMoveSpeedType.JOG:
					result = moveSpeedSlow / moveSpeedFast;
					break;
				case EAIMoveSpeedType.RUN:
					result = moveSpeedNormal / moveSpeedFast;
					break;
				case EAIMoveSpeedType.SPRINT:
					result = moveSpeedFast / moveSpeedFast;
					break;
				}
			}
		}
		return result;
	}

	private static bool CheckPointInSector(FVector Point, FVector BaseLoc, FVector BaseDir, float MinR, float MaxR, float LeftAngle, float RightAngle)
	{
		FVector x = Point - BaseLoc;
		if (x.Size() < MinR || x.Size() > MaxR)
		{
			return false;
		}
		FRotator fRotator = MathLib.MakeRotFromX(BaseDir);
		FRotator fRotator2 = MathLib.MakeRotFromX(x);
		float num = fRotator.Yaw - fRotator2.Yaw;
		if (num < LeftAngle || num > RightAngle)
		{
			return false;
		}
		return true;
	}

	public static bool CheckPointInSkillArea(FVector Point, BGUCharacterCS Character, bool IsEnemy)
	{
		IBUC_GOAPData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_GOAPData, BUC_GOAPData>(Character);
		IBGC_TeamRelationData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_TeamRelationData, BGC_TeamRelationData>(Character);
		List<TStrongObjectPtr<AFSkillArea>> skillAreaFeatureList = readOnlyData.GetSkillAreaFeatureList();
		bool flag = false;
		foreach (TStrongObjectPtr<AFSkillArea> item in skillAreaFeatureList)
		{
			if (IsEnemy)
			{
				if (!gameStateReadonlyData.IsEnemyTeam(item.Get().TeamID, Character.GetTeamIDInCS()))
				{
					continue;
				}
			}
			else if (gameStateReadonlyData.IsEnemyTeam(item.Get().TeamID, Character.GetTeamIDInCS()))
			{
				continue;
			}
			if (item.Get().RectParam.Height > 0f && item.Get().RectParam.Width > 0f)
			{
				FTransform t = new FTransform(new FRotator(0.0, item.Get().RectParam.Yaw + item.Get().RectParam.RotateAngle, 0.0), item.Get().BaseLoc);
				FVector fVector = MathLib.InverseTransformLocation(t, Point);
				if (fVector.X < item.Get().RectParam.Height && MathLib.Abs(fVector.Y) < item.Get().RectParam.Width / 2f)
				{
					flag = true;
					break;
				}
			}
			if (item.Get().SectorParam.MinR >= 0f && item.Get().SectorParam.MaxR - item.Get().SectorParam.MinR > 0f && item.Get().SectorParam.RightAngle - item.Get().SectorParam.LeftAngle > 0f)
			{
				flag = CheckPointInSector(Point, item.Get().BaseLoc, item.Get().SectorParam.BaseDir, item.Get().SectorParam.MinR, item.Get().SectorParam.MaxR, item.Get().SectorParam.LeftAngle, item.Get().SectorParam.RightAngle);
				if (flag)
				{
					break;
				}
			}
			if (item.Get().RoundParam.Radius > 0f)
			{
				FVector baseLoc = item.Get().BaseLoc;
				baseLoc.Z = 0f;
				Point.Z = 0f;
				flag = FVector.Dist(baseLoc, Point) < item.Get().RoundParam.Radius;
				if (flag)
				{
					break;
				}
			}
		}
		return flag;
	}

	public static List<FVector> CheckPointsByTests(List<FVector> PointList, AIFeatureTestInfo FeatureTestInfo, AIPointTestInfo PointTestInfo, AActor CenterActor, AActor FeatureActor, EAIRequestType AIRequestType)
	{
		List<FCheckAngleTest> list = null;
		List<EPointTestType> list2 = null;
		FDistanceTest distanceTest = default(FDistanceTest);
		if (FeatureTestInfo != null)
		{
			list = FeatureTestInfo.CheckAngleTestList.ToList();
			distanceTest = FeatureTestInfo.DistanceTest;
			list2 = FeatureTestInfo.FeatureTestList.ToList();
		}
		if (PointTestInfo != null)
		{
			list = PointTestInfo.CheckAngleTestList.ToList();
			distanceTest = PointTestInfo.DistanceTest;
			list2 = PointTestInfo.PointTestList.ToList();
		}
		List<FVector> list3 = PointList;
		List<FVector> list4 = list3;
		int num = 0;
		using List<EPointTestType>.Enumerator enumerator = list2.GetEnumerator();
		while (enumerator.MoveNext())
		{
			switch (enumerator.Current)
			{
			case EPointTestType.CheckAngle:
				list4 = TestPointsByCheckAngle(list3, list[num], CenterActor, FeatureActor);
				num++;
				break;
			case EPointTestType.SkillArea:
				list4 = TestPointsBySkillArea(list3, CenterActor);
				break;
			case EPointTestType.Distance:
				list4 = TestPointByDistance(list3, CenterActor, distanceTest, FeatureActor);
				break;
			case EPointTestType.SkillCastRange:
				list4 = TestPointsBySkillCastRange(list3, CenterActor, FeatureActor, AIRequestType);
				break;
			case EPointTestType.CharacterBlock:
				list4 = TestPointsByCharacterBlock(list3, CenterActor);
				break;
			case EPointTestType.NavPathExist:
				list4 = TestPointsByNavPathExist(list3, CenterActor);
				break;
			case EPointTestType.Visible:
				list4 = TestPointsByVisible(list3, CenterActor, FeatureActor);
				break;
			case EPointTestType.Height:
				list4 = TestPointsByHeight(list3, CenterActor, FeatureActor);
				break;
			}
			list3 = list4;
		}
		return list4;
	}

	public static ERequestTestResult RequestFeatureTest(AIRequestBase Request, AActor CenterActor, out AActor SelectedActor)
	{
		if (CenterActor.IsNullOrDestroyed())
		{
			SelectedActor = null;
			return ERequestTestResult.SelectFaild;
		}
		SelectedActor = null;
		IBUC_AIAttentionData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AIAttentionData, BUC_AIAttentionData>(CenterActor);
		List<AttentionFeatureBase> list = new List<AttentionFeatureBase>();
		AIFeatureTestInfo featureTestInfo = Request.FeatureTestInfo;
		for (int i = 0; i < featureTestInfo.RequiredFeatureList.Count; i++)
		{
			AttentionFeatureBase featureByType = unPersistentReadOnlyData.GetFeatureByType(featureTestInfo.RequiredFeatureList[i]);
			if (i >= featureTestInfo.InverseList.Count || !featureTestInfo.InverseList[i])
			{
				if (featureByType == null)
				{
					return ERequestTestResult.FeatureNotFound;
				}
				list.Add(featureByType);
			}
			else if (featureByType != null)
			{
				return ERequestTestResult.FeatureNotFound;
			}
		}
		List<AActor> list2 = new List<AActor>();
		foreach (AttentionFeatureBase item in list)
		{
			list2.AddRange(GetActorsByFeature(item));
		}
		if (list2.Count == 0)
		{
			return ERequestTestResult.NoNeedToTest;
		}
		List<AActor> list3 = CheckTargetsByTests(list2, Request.FeatureTestInfo, CenterActor, Request.AIRequestType);
		if (list3.Count == 0)
		{
			return ERequestTestResult.SelectFaild;
		}
		SelectedActor = list3[0];
		return ERequestTestResult.SelectSuccess;
	}

	public static ERequestTestResult RequestPointTest(AIRequestBase Request, AActor CenterActor, out FVector SelectedPoint)
	{
		SelectedPoint = default(FVector);
		if (!Request.IsNeedSelectPoint)
		{
			return ERequestTestResult.NoNeedToTest;
		}
		FVector centerPoint = default(FVector);
		if (Request.PointTestInfo.PointGenBaseType == EPointGenBaseType.Feature)
		{
			centerPoint = BGUFuncLibActorTransformCS.BGUGetActorLocation(Request.FeatureActor);
		}
		else if (Request.PointTestInfo.PointGenBaseType == EPointGenBaseType.OwnCharacter)
		{
			centerPoint = BGUFuncLibActorTransformCS.BGUGetActorLocation(CenterActor);
		}
		List<FVector> list = CheckPointsByTests(GenerateRingPoints(Request.PointTestInfo.RingPointGenerate, centerPoint), null, Request.PointTestInfo, CenterActor, Request.FeatureActor, Request.AIRequestType);
		if (list.Count == 0)
		{
			return ERequestTestResult.SelectFaild;
		}
		if (Request.PointTestInfo.IsRandom)
		{
			SelectedPoint = list[MathLib.RandomIntInRange(0, list.Count - 1)];
		}
		else
		{
			SelectedPoint = list[0];
		}
		return ERequestTestResult.SelectSuccess;
	}

	public static List<AActor> GetActorsByFeature(AttentionFeatureBase InputFeature)
	{
		List<AActor> list = new List<AActor>();
		switch (InputFeature.FeatureType)
		{
		case EAIAttentionFeatureType.AttackableEnemy:
			list.AddRange((InputFeature as AFAttackableEnemy).EnemyActors);
			break;
		case EAIAttentionFeatureType.NearestEnemy:
			list.Add((InputFeature as AFNearestEnemy).EnemyCharacter);
			break;
		}
		return list;
	}

	public static List<AActor> CheckTargetsByTests(List<AActor> FeatureActorList, AIFeatureTestInfo FeatureTestInfo, AActor CenterActor, EAIRequestType AIRequestType)
	{
		List<AActor> list = new List<AActor>();
		List<FVector> list2 = new List<FVector>();
		foreach (AActor FeatureActor in FeatureActorList)
		{
			list2.Add(BGUFuncLibActorTransformCS.BGUGetActorLocation(FeatureActor));
		}
		List<FVector> list3 = CheckPointsByTests(list2, FeatureTestInfo, null, CenterActor, null, AIRequestType);
		for (int i = 0; i < list2.Count; i++)
		{
			for (int j = 0; j < list3.Count; j++)
			{
				if (list2[i].EqualEqual_VectorVector(list3[j]))
				{
					list.Add(FeatureActorList[i]);
				}
			}
		}
		return list;
	}

	private static List<FVector> TestPointsByHeight(List<FVector> PointList, AActor CenterActor, AActor FeatureActor)
	{
		List<FVector> list = new List<FVector>();
		foreach (FVector Point in PointList)
		{
			if (MathLib.Abs(BGUFuncLibActorTransformCS.BGUGetActorLocation(FeatureActor).Z - BGUFuncLibActorTransformCS.BGUGetActorLocation(CenterActor).Z) < 60f)
			{
				list.Add(Point);
			}
		}
		return list;
	}

	private static List<FVector> TestPointsByVisible(List<FVector> PointList, AActor CenterActor, AActor FeatureActor)
	{
		List<FVector> list = new List<FVector>();
		foreach (FVector Point in PointList)
		{
			FHitResultSimple HitResult;
			int num = ((!FeatureActor.IsNullOrDestroyed()) ? UBGUSelectUtil.LineTraceSimple(CenterActor, BGUFuncLibActorTransformCS.BGUGetActorLocation(FeatureActor), Point, ETraceTypeQuery.TraceTypeQuery1, bDebug: false, out HitResult, null) : UBGUSelectUtil.LineTraceSimple(CenterActor, BGUFuncLibActorTransformCS.BGUGetActorLocation(CenterActor), Point, ETraceTypeQuery.TraceTypeQuery1, bDebug: false, out HitResult, null));
			if (num <= 0)
			{
				list.Add(Point);
			}
		}
		return list;
	}

	private static List<FVector> TestPointsBySkillCastRange(List<FVector> PointList, AActor CenterActor, AActor FeatureActor, EAIRequestType AIRequestType)
	{
		List<FVector> list = new List<FVector>();
		if (FeatureActor.IsNullOrDestroyed())
		{
			return list;
		}
		IBUC_AIAttentionData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AIAttentionData, BUC_AIAttentionData>(CenterActor);
		Dictionary<int, List<BaseActionMsg>> validSkillBADic = unPersistentReadOnlyData.GetValidSkillBADic();
		Dictionary<EAIBasicActionType, EAIRequestType> bA2ReqDic = unPersistentReadOnlyData.GetBA2ReqDic();
		foreach (FVector Point in PointList)
		{
			float num = FVector.Dist2D(Point, BGUFuncLibActorTransformCS.BGUGetActorLocation(FeatureActor));
			foreach (KeyValuePair<int, List<BaseActionMsg>> item in validSkillBADic)
			{
				foreach (BaseActionMsg item2 in item.Value)
				{
					if ((bA2ReqDic[item2.AIBasicActionType] == EAIRequestType.DirDamage || bA2ReqDic[item2.AIBasicActionType] == EAIRequestType.MoveSkill) && num > item2.MinRange && num < item2.MaxRange)
					{
						list.Add(Point);
						break;
					}
				}
			}
		}
		return list;
	}

	private static List<FVector> TestPointByDistance(List<FVector> PointList, AActor CenterActor, FDistanceTest DistanceTest, AActor FeatureActor)
	{
		AActor centerActor = null;
		if (DistanceTest.DisBaseType == EDisTestBaseType.Feature)
		{
			if (FeatureActor.IsNullOrDestroyed())
			{
				return new List<FVector>();
			}
			centerActor = FeatureActor;
		}
		else if (DistanceTest.DisBaseType == EDisTestBaseType.OwnCharacter)
		{
			centerActor = CenterActor;
		}
		if (DistanceTest.DisTestType == EDisTestFilterType.DTF_Max)
		{
			return TestPointsByMaxDistance(PointList, centerActor);
		}
		return TestPointsByMinDistance(PointList, centerActor);
	}

	private static List<FVector> TestPointsByMaxDistance(List<FVector> PointList, AActor CenterActor)
	{
		List<FVector> list = new List<FVector>();
		float num = 0f;
		FVector item = default(FVector);
		foreach (FVector Point in PointList)
		{
			float num2 = FVector.Dist2D(Point, BGUFuncLibActorTransformCS.BGUGetActorLocation(CenterActor));
			if (num2 > num)
			{
				num = num2;
				item = Point;
			}
		}
		if (!item.IsZero())
		{
			list.Add(item);
		}
		return list;
	}

	private static List<FVector> TestPointsByMinDistance(List<FVector> PointList, AActor CenterActor)
	{
		List<FVector> list = new List<FVector>();
		float num = 999999f;
		FVector item = default(FVector);
		foreach (FVector Point in PointList)
		{
			float num2 = FVector.Dist2D(Point, BGUFuncLibActorTransformCS.BGUGetActorLocation(CenterActor));
			if (num2 < num)
			{
				num = num2;
				item = Point;
			}
		}
		if (!item.IsZero())
		{
			list.Add(item);
		}
		return list;
	}

	private static List<FVector> TestPointsBySkillArea(List<FVector> PointList, AActor CenterActor)
	{
		List<FVector> list = new List<FVector>();
		BGUCharacterCS bGUCharacterCS = CenterActor as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return list;
		}
		foreach (FVector Point in PointList)
		{
			if (!CheckPointInSkillArea(Point, bGUCharacterCS, IsEnemy: true))
			{
				list.Add(Point);
			}
		}
		return list;
	}

	private static List<FVector> TestPointsByNavPathExist(List<FVector> PointList, AActor CenterActor)
	{
		List<FVector> list = new List<FVector>();
		foreach (FVector Point in PointList)
		{
			if (UNavigationSystemV1.ProjectPointToNavigation(CenterActor, Point, out var _, null, null, new FVector(0.0, 0.0, 0.0)) && FindPathToLocation(CenterActor, BGUFuncLibActorTransformCS.BGUGetActorLocation(CenterActor), Point).Count != 0)
			{
				list.Add(Point);
			}
		}
		return list;
	}

	private static List<FVector> TestPointsByCharacterBlock(List<FVector> PointList, AActor CenterActor)
	{
		List<FVector> list = new List<FVector>();
		ABGUCharacter[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<ABGUCharacter>(CenterActor);
		foreach (FVector Point in PointList)
		{
			bool flag = false;
			ABGUCharacter[] array = allActorsOfClass;
			foreach (ABGUCharacter aBGUCharacter in array)
			{
				if (!(aBGUCharacter == CenterActor) && FVector.Dist2D(Point, BGUFuncLibActorTransformCS.BGUGetActorLocation(aBGUCharacter)) < 150f)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				list.Add(Point);
			}
		}
		return list;
	}

	public static List<FVector> TestPointsByCheckAngle(List<FVector> PointList, FCheckAngleTest InAngleTest, AActor CenterActor, AActor FeatureActor)
	{
		List<FVector> list = new List<FVector>();
		if (FeatureActor.IsNullOrDestroyed())
		{
			return list;
		}
		FVector x = default(FVector);
		switch (InAngleTest.AngleBaseType)
		{
		case EAngleBaseType.Self2Target:
			x = BGUFuncLibActorTransformCS.BGUGetActorLocation(FeatureActor) - BGUFuncLibActorTransformCS.BGUGetActorLocation(CenterActor);
			break;
		case EAngleBaseType.Target2Self:
			x = BGUFuncLibActorTransformCS.BGUGetActorLocation(CenterActor) - BGUFuncLibActorTransformCS.BGUGetActorLocation(FeatureActor);
			break;
		case EAngleBaseType.SelfXAxis:
			x = CenterActor.GetActorForwardVector();
			break;
		}
		foreach (FVector Point in PointList)
		{
			FVector x2 = Point - BGUFuncLibActorTransformCS.BGUGetActorLocation(CenterActor);
			if (x2.IsZero())
			{
				list.Add(Point);
				continue;
			}
			FRotator fRotator = MathLib.MakeRotFromX(x);
			FRotator fRotator2 = MathLib.MakeRotFromX(x2);
			float num = fRotator.Yaw - fRotator2.Yaw;
			if (num > InAngleTest.LeftAngle && num < InAngleTest.RightAngle)
			{
				list.Add(Point);
			}
		}
		return list;
	}

	public static List<FVector> GenerateRingPoints(FRingPointGenerate InGenerate, FVector CenterPoint)
	{
		List<FVector> list = new List<FVector>();
		float num = (InGenerate.MaxR - InGenerate.MinR) / (float)InGenerate.RingNum;
		float num2 = 360f / (float)InGenerate.PointNumPerRing;
		FVector fVector = new FVector(1.0, 0.0, 0.0);
		FVector axis = new FVector(0.0, 0.0, 1.0);
		for (float num3 = 0f; num3 <= 360f; num3 += num2)
		{
			FVector safeNormal = fVector.RotateAngleAxis(num3, axis).GetSafeNormal();
			for (int i = 0; i < InGenerate.RingNum; i++)
			{
				FVector item = CenterPoint + safeNormal * (InGenerate.MinR + (float)i * num);
				list.Add(item);
			}
		}
		return list;
	}

	public static BaseActionMsg GetBaseActionMsg(AActor OwnActor, EAIBasicActionType BAType, FVector FeatureLoc = default(FVector))
	{
		if (OwnActor.IsNullOrDestroyed())
		{
			return null;
		}
		Dictionary<int, List<BaseActionMsg>> validSkillBADic = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AIAttentionData, BUC_AIAttentionData>(OwnActor).GetValidSkillBADic();
		float num = FVector.Dist2D(BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnActor), FeatureLoc);
		foreach (KeyValuePair<int, List<BaseActionMsg>> item in validSkillBADic)
		{
			foreach (BaseActionMsg item2 in item.Value)
			{
				if ((FeatureLoc.IsZero() || (!(num < item2.MinRange) && !(num > item2.MaxRange))) && item2.AIBasicActionType == BAType)
				{
					return item2;
				}
			}
		}
		return null;
	}

	public static List<FVector> FindPathToLocation(AActor OwnerActor, FVector StartLoc, FVector TargetLoc)
	{
		return UNavigationSystemV1.FindPathToLocationSynchronously(OwnerActor.World, StartLoc, TargetLoc, null, null).PathPoints.ToList();
	}
}
