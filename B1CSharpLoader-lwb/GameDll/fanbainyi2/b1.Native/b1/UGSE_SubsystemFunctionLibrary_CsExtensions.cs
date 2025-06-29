using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class UGSE_SubsystemFunctionLibrary_CsExtensions
{
	public static UWorldSubsystem GetWorldSubsystem(this UWorld ContextObject, TSubclassOf<UWorldSubsystem> Class)
	{
		return UGSE_SubsystemFunctionLibrary.GetWorldSubsystem(ContextObject, Class);
	}

	public static ULocalPlayerSubsystem GetLocalPlayerSubsystem(this UWorld ContextObject, TSubclassOf<ULocalPlayerSubsystem> Class)
	{
		return UGSE_SubsystemFunctionLibrary.GetLocalPlayerSubsystem(ContextObject, Class);
	}

	public static UGameInstanceSubsystem GetGameInstanceSubsystem(this UWorld ContextObject, TSubclassOf<UGameInstanceSubsystem> Class)
	{
		return UGSE_SubsystemFunctionLibrary.GetGameInstanceSubsystem(ContextObject, Class);
	}
}
