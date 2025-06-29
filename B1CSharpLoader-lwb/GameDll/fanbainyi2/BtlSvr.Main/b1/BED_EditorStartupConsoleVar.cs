using System.Diagnostics;

namespace b1;

public class BED_EditorStartupConsoleVar
{
	[Conditional("WITH_EDITOR")]
	public static void OnStartup()
	{
	}
}
