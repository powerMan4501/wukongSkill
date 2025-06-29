namespace System.Runtime.CompilerServices;

public static class RuntimeFeature
{
	public const string PortablePdb = "PortablePdb";

	public static bool IsSupported(string feature)
	{
		if (feature == "PortablePdb")
		{
			return !AppContextSwitches.IgnorePortablePDBsInStackTraces;
		}
		return false;
	}
}
