using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_LandingComp : UActorCompBaseCS
{
	private BUC_LandingData LandingData { get; set; }

	private IBUC_TargetInfoData TargetInfoData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		LandingData = RequireWritableData<BUC_LandingData>();
		TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		base.BUSEventCollection.Evt_OnAddAvailableLandingPoints += new Del_Void_VectorList(OnAddAvailableLandingPoints);
		base.BUSEventCollection.Evt_OnRemoveAvailableLandingPoints += new Del_Void_VectorList(OnRemoveAvailableLandingPoints);
		base.BUSEventCollection.Evt_OnTryCatchLandingPoint += new Del_QueryConditionWithId(OnTryCatchLandingPoint);
	}

	private void OnTryCatchLandingPoint(EFindSceneItemWay FindSceneItemWay, QueryBestLocationCondition Condition, int DataID)
	{
		bool bUseCompositeV = FindSceneItemWay == EFindSceneItemWay.CompositeV2;
		AActor aActor = GetOwner();
		if (FindSceneItemWay == EFindSceneItemWay.FindFurthestToTarget || FindSceneItemWay == EFindSceneItemWay.FindNearestToTarget)
		{
			aActor = TargetInfoData.GetSkillBaseTarget()?.LockTargetActor;
		}
		if (aActor == null)
		{
			return;
		}
		List<FVector> Locations = new List<FVector>();
		List<FRotator> Rotations = new List<FRotator>();
		foreach (FVector landingPoint in LandingData.LandingPoints)
		{
			Locations.Add(landingPoint);
			Rotations.Add(FRotator.ZeroRotator);
		}
		if (BGU_SelectTargetUtil.QueryBestLocationByCondition(aActor, in Locations, in Rotations, bUseCompositeV, Condition, out var BestIndex) && BestIndex >= 0 && Locations.Count > BestIndex)
		{
			List<FVector> list = new List<FVector>();
			list.Add(Locations[BestIndex]);
			base.BUSEventCollection.Evt_AddPointsToQuene.Invoke(DataID, list, bClearTheReqQuene: true);
		}
	}

	private void OnAddAvailableLandingPoints(List<FVector> Points)
	{
		foreach (FVector Point in Points)
		{
			LandingData.LandingPoints.Add(Point);
		}
	}

	private void OnRemoveAvailableLandingPoints(List<FVector> Points)
	{
		foreach (FVector Point in Points)
		{
			LandingData.LandingPoints.Remove(Point);
		}
	}
}
