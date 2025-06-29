using UnrealEngine.Runtime;

namespace b1;

public static class GSVersionUtil
{
	public static string GetAppVersion()
	{
		UGSVersionSettings uGSVersionSettings = UObject.GetDefault<UGSVersionSettings>();
		if (uGSVersionSettings != null)
		{
			return uGSVersionSettings.AppVersion;
		}
		return "";
	}

	public static int GetBuildRevision()
	{
		UGSVersionSettings uGSVersionSettings = UObject.GetDefault<UGSVersionSettings>();
		if (uGSVersionSettings != null)
		{
			return uGSVersionSettings.Revision;
		}
		return 0;
	}

	public static string GetAppVersionWithRevision()
	{
		UGSVersionSettings uGSVersionSettings = UObject.GetDefault<UGSVersionSettings>();
		if (uGSVersionSettings != null)
		{
			return $"{uGSVersionSettings.AppVersion}.{uGSVersionSettings.Revision}";
		}
		return "";
	}
}
