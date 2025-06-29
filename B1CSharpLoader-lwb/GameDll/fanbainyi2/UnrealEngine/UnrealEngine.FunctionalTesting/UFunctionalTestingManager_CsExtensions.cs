using UnrealEngine.Engine;

namespace UnrealEngine.FunctionalTesting;

public static class UFunctionalTestingManager_CsExtensions
{
	public static bool RunAllFunctionalTests(this UWorld WorldContextObject, bool bNewLog = true, bool bRunLooped = false, string FailedTestsReproString = null)
	{
		return UFunctionalTestingManager.RunAllFunctionalTests(WorldContextObject, bNewLog, bRunLooped, FailedTestsReproString);
	}
}
