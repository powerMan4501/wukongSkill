using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCModMatScalabilityManager
{
	public int CurTickLastRealTickParamEventIndex;

	public int CurScalabilityLoopCount = 1;

	public bool EnableModMatScalability { get; private set; } = true;

	public bool Enable { get; private set; }

	public int MaxAllowRealTickParamEventCount { get; private set; } = 15;

	public DBCModMatScalabilityManager()
	{
		IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable("b.DBC.EnableModMatScalability");
		if (consoleVariable != null && consoleVariable.GetInt() > 0)
		{
			EnableModMatScalability = true;
		}
		else
		{
			EnableModMatScalability = false;
		}
		Enable = false;
	}

	public bool SetActiveModMatScalability(bool Active)
	{
		if (!EnableModMatScalability)
		{
			Enable = false;
		}
		else
		{
			Enable = Active;
		}
		return Enable;
	}
}
