using System.Collections.Generic;
using UnrealEngine.Engine;

namespace UnrealEngine.Runtime;

public static class UGameplayTagLibrary_CsExtensions
{
	public static void GetAllActorsOfClassMatchingTagQuery(this UWorld WorldContextObject, TSubclassOf<AActor> ActorClass, FGameplayTagQuery GameplayTagQuery, out List<AActor> OutActors)
	{
		UGameplayTagLibrary.GetAllActorsOfClassMatchingTagQuery(WorldContextObject, ActorClass, GameplayTagQuery, out OutActors);
	}
}
