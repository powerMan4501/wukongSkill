using System;

namespace b1.GSMUICore.Event;

public class GSMUIDelayExec : GSMUIEventBase
{
	private readonly float Delay;

	private readonly Action RunFunc;

	public GSMUIDelayExec(float InDelay, Action InFunc)
		: base("GSMUIDelayExec")
	{
		Delay = InDelay;
		RunFunc = InFunc;
	}

	protected override GSMUITickableStat DoTickImpl(float DeltaTime)
	{
		if (RunTime >= Delay)
		{
			RunFunc?.Invoke();
			return GSMUITickableStat.IDLE;
		}
		return GSMUITickableStat.TICKING;
	}
}
