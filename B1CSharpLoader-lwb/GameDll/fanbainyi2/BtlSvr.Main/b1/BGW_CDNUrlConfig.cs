namespace b1;

public static class BGW_CDNUrlConfig
{
	private static string BaseUrl => DebugConfig.GSSdkCDNRootUrlList;

	public static string CDNRootUrl => BaseUrl + "/" + BGW_LocalDevEnvUtils.GetBuildBranch();

	public static string CDNScriptDllUrl => CDNRootUrl + "/PBTable/ScriptDll";

	public static string CDNConfigUrl => CDNRootUrl + "/PBTable/CDNConfig/GlobalConfig.cfg";

	public static string CDNProtoCryptTokenUrl => CDNRootUrl + "/ProtoCryptToken.txt";
}
