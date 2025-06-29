using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

public static class UAchievementLibrary_CsExtensions
{
	public static void GetCachedAchievementProgress(this UWorld WorldContextObject, APlayerController PlayerController, FName AchievementID, out bool bFoundID, out float Progress)
	{
		UAchievementLibrary.GetCachedAchievementProgress(WorldContextObject, PlayerController, AchievementID, out bFoundID, out Progress);
	}

	public static void GetCachedAchievementDescription(this UWorld WorldContextObject, APlayerController PlayerController, FName AchievementID, out bool bFoundID, out FText Title, out FText LockedDescription, out FText UnlockedDescription, out bool bHidden)
	{
		UAchievementLibrary.GetCachedAchievementDescription(WorldContextObject, PlayerController, AchievementID, out bFoundID, out Title, out LockedDescription, out UnlockedDescription, out bHidden);
	}
}
