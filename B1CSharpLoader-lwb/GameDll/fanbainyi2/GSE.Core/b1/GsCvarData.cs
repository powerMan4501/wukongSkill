using System;
using UnrealEngine.Runtime;

namespace b1;

public class GsCvarData
{
	private IntPtr DataAddr;

	private IConsoleVariable CvarCache;

	public unsafe int GetValueInGameThread()
	{
		int* ptr = (int*)(void*)DataAddr;
		return *ptr;
	}

	public void SetInt(int Value, EConsoleVariableFlags ConsoleVariableFlags = EConsoleVariableFlags.SetByGameOverride)
	{
		CvarCache.Set(Value, ConsoleVariableFlags);
	}

	public void SetString(string Value, EConsoleVariableFlags ConsoleVariableFlags = EConsoleVariableFlags.SetByGameOverride)
	{
		CvarCache.Set(Value, ConsoleVariableFlags);
	}

	public string GetString()
	{
		return CvarCache.GetString();
	}

	public GsCvarData(IConsoleVariable Cvar)
	{
		DataAddr = GsCvarFuncLib.GSVar_GetData(Cvar.Address);
		CvarCache = Cvar;
	}

	public static GsCvarData FindByString(string CVarName)
	{
		IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable(CVarName);
		if (consoleVariable != null)
		{
			return new GsCvarData(consoleVariable);
		}
		return null;
	}
}
