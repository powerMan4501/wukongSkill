using System.Collections.Generic;
using UnrealEngine.Engine;

namespace UnrealEngine.Plugins.ActorLayerUtilities;

public static class ULayersBlueprintLibrary_CsExtensions
{
	public static List<AActor> GetActors(this UWorld WorldContextObject, FActorLayer ActorLayer)
	{
		return ULayersBlueprintLibrary.GetActors(WorldContextObject, ActorLayer);
	}
}
