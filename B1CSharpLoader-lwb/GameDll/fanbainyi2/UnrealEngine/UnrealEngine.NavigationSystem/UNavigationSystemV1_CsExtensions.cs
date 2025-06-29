using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.NavigationSystem;

public static class UNavigationSystemV1_CsExtensions
{
	public static bool NavigationRaycast(this UWorld WorldContextObject, FVector RayStart, FVector RayEnd, out FVector HitLocation, TSubclassOf<UNavigationQueryFilter> FilterClass, AController Querier)
	{
		return UNavigationSystemV1.NavigationRaycast(WorldContextObject, RayStart, RayEnd, out HitLocation, FilterClass, Querier);
	}

	public static bool ProjectPointToNavigation(this UWorld WorldContextObject, FVector Point, out FVector ProjectedLocation, ANavigationData NavData, TSubclassOf<UNavigationQueryFilter> FilterClass, FVector QueryExtent)
	{
		return UNavigationSystemV1.ProjectPointToNavigation(WorldContextObject, Point, out ProjectedLocation, NavData, FilterClass, QueryExtent);
	}

	public static bool GetRandomReachablePointInRadius(this UWorld WorldContextObject, FVector Origin, out FVector RandomLocation, float Radius, ANavigationData NavData, TSubclassOf<UNavigationQueryFilter> FilterClass)
	{
		return UNavigationSystemV1.GetRandomReachablePointInRadius(WorldContextObject, Origin, out RandomLocation, Radius, NavData, FilterClass);
	}

	public static bool GetRandomPointInNavigableRadius(this UWorld WorldContextObject, FVector Origin, out FVector RandomLocation, float Radius, ANavigationData NavData, TSubclassOf<UNavigationQueryFilter> FilterClass)
	{
		return UNavigationSystemV1.GetRandomPointInNavigableRadius(WorldContextObject, Origin, out RandomLocation, Radius, NavData, FilterClass);
	}

	public static bool GetRandomLocationInNavigableRadius(this UWorld WorldContextObject, FVector Origin, out FVector RandomLocation, float Radius, ANavigationData NavData, TSubclassOf<UNavigationQueryFilter> FilterClass)
	{
		return UNavigationSystemV1.GetRandomLocationInNavigableRadius(WorldContextObject, Origin, out RandomLocation, Radius, NavData, FilterClass);
	}

	public static bool IsNavigationBeingBuiltOrLocked(this UWorld WorldContextObject)
	{
		return UNavigationSystemV1.IsNavigationBeingBuiltOrLocked(WorldContextObject);
	}

	public static bool IsNavigationBeingBuilt(this UWorld WorldContextObject)
	{
		return UNavigationSystemV1.IsNavigationBeingBuilt(WorldContextObject);
	}

	public static ENavigationQueryResult GetPathLength(this UWorld WorldContextObject, FVector PathStart, FVector PathEnd, out float PathLength, ANavigationData NavData, TSubclassOf<UNavigationQueryFilter> FilterClass)
	{
		return UNavigationSystemV1.GetPathLength(WorldContextObject, PathStart, PathEnd, out PathLength, NavData, FilterClass);
	}

	public static ENavigationQueryResult GetPathCost(this UWorld WorldContextObject, FVector PathStart, FVector PathEnd, out float PathCost, ANavigationData NavData, TSubclassOf<UNavigationQueryFilter> FilterClass)
	{
		return UNavigationSystemV1.GetPathCost(WorldContextObject, PathStart, PathEnd, out PathCost, NavData, FilterClass);
	}

	public static UNavigationSystemV1 GetNavigationSystem(this UWorld WorldContextObject)
	{
		return UNavigationSystemV1.GetNavigationSystem(WorldContextObject);
	}

	public static UNavigationPath FindPathToLocationSynchronously(this UWorld WorldContextObject, FVector PathStart, FVector PathEnd, AActor PathfindingContext, TSubclassOf<UNavigationQueryFilter> FilterClass)
	{
		return UNavigationSystemV1.FindPathToLocationSynchronously(WorldContextObject, PathStart, PathEnd, PathfindingContext, FilterClass);
	}

	public static UNavigationPath FindPathToActorSynchronously(this UWorld WorldContextObject, FVector PathStart, AActor GoalActor, float TetherDistance, AActor PathfindingContext, TSubclassOf<UNavigationQueryFilter> FilterClass)
	{
		return UNavigationSystemV1.FindPathToActorSynchronously(WorldContextObject, PathStart, GoalActor, TetherDistance, PathfindingContext, FilterClass);
	}

	public static int FindNearestPoly(this UWorld WorldContextObject, FVector Loc, FVector Extent, ANavigationData NavData, TSubclassOf<UNavigationQueryFilter> FilterClass)
	{
		return UNavigationSystemV1.FindNearestPoly(WorldContextObject, Loc, Extent, NavData, FilterClass);
	}
}
