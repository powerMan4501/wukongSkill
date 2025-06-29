using System.Diagnostics;

namespace b1;

public static class GSEMacro
{
	[Conditional("NEVER_COMPILE")]
	public static void TODO(string msg)
	{
	}
}
