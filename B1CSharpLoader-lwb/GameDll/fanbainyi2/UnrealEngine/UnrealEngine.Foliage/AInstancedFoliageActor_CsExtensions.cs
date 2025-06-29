using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Foliage;

public static class AInstancedFoliageActor_CsExtensions
{
	public static void RemoveAllInstances(this UWorld WorldContextObject, UFoliageType InFoliageType)
	{
		AInstancedFoliageActor.RemoveAllInstances(WorldContextObject, InFoliageType);
	}

	public static void AddInstances(this UWorld WorldContextObject, UFoliageType InFoliageType, List<FTransform> InTransforms)
	{
		AInstancedFoliageActor.AddInstances(WorldContextObject, InFoliageType, InTransforms);
	}
}
