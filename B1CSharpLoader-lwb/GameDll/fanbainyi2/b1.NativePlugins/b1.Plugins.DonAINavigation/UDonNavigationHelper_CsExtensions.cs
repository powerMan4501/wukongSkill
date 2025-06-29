using UnrealEngine.Engine;

namespace b1.Plugins.DonAINavigation;

public static class UDonNavigationHelper_CsExtensions
{
	public static ADonNavigationManager DonNavigationManager(this UWorld WorldContextObject)
	{
		return UDonNavigationHelper.DonNavigationManager(WorldContextObject);
	}
}
