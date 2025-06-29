namespace UnrealEngine.Runtime;

public static class GlobalConf
{
	public static string ModulePathFix(string In)
	{
		return In.Replace("BtlSvr-Main", "b1-Managed").Replace("Editor-Main", "b1-Managed");
	}
}
