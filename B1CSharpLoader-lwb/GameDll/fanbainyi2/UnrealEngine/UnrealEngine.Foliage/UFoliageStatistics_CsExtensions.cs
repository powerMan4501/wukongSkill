using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Foliage;

public static class UFoliageStatistics_CsExtensions
{
	public static int FoliageOverlappingSphereCount(this UWorld WorldContextObject, UStaticMesh StaticMesh, FVector CenterPosition, float Radius)
	{
		return UFoliageStatistics.FoliageOverlappingSphereCount(WorldContextObject, StaticMesh, CenterPosition, Radius);
	}

	public static void FoliageOverlappingBoxTransforms(this UWorld WorldContextObject, UStaticMesh StaticMesh, FBox Box, out List<FTransform> OutTransforms)
	{
		UFoliageStatistics.FoliageOverlappingBoxTransforms(WorldContextObject, StaticMesh, Box, out OutTransforms);
	}

	public static int FoliageOverlappingBoxCount(this UWorld WorldContextObject, UStaticMesh StaticMesh, FBox Box)
	{
		return UFoliageStatistics.FoliageOverlappingBoxCount(WorldContextObject, StaticMesh, Box);
	}
}
