using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.NavigationSystem;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_EscapeComp : UActorCompBaseCS
{
	public override void OnAttach()
	{
		base.BUSEventCollection.Evt_EscapeAfterDeath += new Del_EscapeAfterDeath(OnEscapeAfterDeath);
	}

	private void OnEscapeAfterDeath(string SplineActorTag)
	{
		Owner.World.GetAllActorsOfClassWithTag(UClass.GetClass<BGUSplineActor>(), new FName(SplineActorTag), out var OutActors);
		if (OutActors.Count == 0)
		{
			return;
		}
		BGUSplineActor bGUSplineActor = OutActors[0] as BGUSplineActor;
		if (!(bGUSplineActor == null))
		{
			USplineComponent splineComp = bGUSplineActor.SplineComp;
			if (!(splineComp == null))
			{
				GenerateSplinePoints(splineComp, SplineActorTag);
				base.BUSEventCollection?.Evt_UnitDead.Invoke(null, EDeadReason.OnlyDestroyUnit);
			}
		}
	}

	private void GenerateSplinePoints(USplineComponent SplineComp, string SplineActorTag)
	{
		List<FVector> list = new List<FVector>();
		int numberOfSplinePoints = SplineComp.GetNumberOfSplinePoints();
		FVector startLoc = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		int num = 0;
		while (num < numberOfSplinePoints)
		{
			FVector fVector = default(FVector);
			List<FVector> list2 = new List<FVector>();
			while (list2.Count == 0)
			{
				if (num >= numberOfSplinePoints)
				{
					BGW_LogUtil.LogError("Unable to find path to the last spline point!");
					break;
				}
				fVector = SplineComp.GetLocationAtSplinePoint(num++, ESplineCoordinateSpace.World);
				list2 = FindPathToLocation(Owner, startLoc, fVector);
			}
			if (num < numberOfSplinePoints - 1)
			{
				list2.RemoveAt(list2.Count - 1);
			}
			list.AddRange(list2);
			startLoc = fVector;
		}
		SplineComp.ClearSplinePoints();
		SplineComp.SetSplinePoints(list, ESplineCoordinateSpace.World);
	}

	private List<FVector> FindPathToLocation(AActor OwnerActor, FVector StartLoc, FVector TargetLoc)
	{
		return UNavigationSystemV1.FindPathToLocationSynchronously(OwnerActor.World, StartLoc, TargetLoc, null, null).PathPoints.ToList();
	}
}
