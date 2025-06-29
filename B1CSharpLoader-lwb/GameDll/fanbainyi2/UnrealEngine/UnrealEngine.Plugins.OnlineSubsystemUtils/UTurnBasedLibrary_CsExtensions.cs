using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

public static class UTurnBasedLibrary_CsExtensions
{
	public static void RegisterTurnBasedMatchInterfaceObject(this UWorld WorldContextObject, APlayerController PlayerController, UObject Object)
	{
		UTurnBasedLibrary.RegisterTurnBasedMatchInterfaceObject(WorldContextObject, PlayerController, Object);
	}

	public static void GetPlayerDisplayName(this UWorld WorldContextObject, APlayerController PlayerController, string MatchID, int PlayerIndex, out string PlayerDisplayName)
	{
		UTurnBasedLibrary.GetPlayerDisplayName(WorldContextObject, PlayerController, MatchID, PlayerIndex, out PlayerDisplayName);
	}

	public static void GetMyPlayerIndex(this UWorld WorldContextObject, APlayerController PlayerController, string MatchID, out int PlayerIndex)
	{
		UTurnBasedLibrary.GetMyPlayerIndex(WorldContextObject, PlayerController, MatchID, out PlayerIndex);
	}

	public static void GetIsMyTurn(this UWorld WorldContextObject, APlayerController PlayerController, string MatchID, out bool bIsMyTurn)
	{
		UTurnBasedLibrary.GetIsMyTurn(WorldContextObject, PlayerController, MatchID, out bIsMyTurn);
	}
}
