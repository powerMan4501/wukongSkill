using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

public static class UPawnAction_CsExtensions
{
	public static UPawnAction CreateActionInstance(this UWorld WorldContextObject, TSubclassOf<UPawnAction> ActionClass)
	{
		return UPawnAction.CreateActionInstance(WorldContextObject, ActionClass);
	}
}
