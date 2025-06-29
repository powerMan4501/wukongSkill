using UnrealEngine.Runtime;

namespace b1;

public static class ConsoleCommandUtil
{
	public static int SafeGetConsoleVariableIntValue(string Name, int DefaultValue = 0)
	{
		IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable(Name);
		if (consoleVariable != null)
		{
			return consoleVariable.GetInt();
		}
		return DefaultValue;
	}
}
