using System;

namespace b1.GSMUICore.Event;

public class GSMUIEventExecFunc : GSMUIEventBase
{
	private readonly Action ExecFunc;

	public GSMUIEventExecFunc(Action InFunc)
		: base("GSMUIEventExecFunc")
	{
		ExecFunc = InFunc;
	}

	protected override GSMUITickableStat DoTickImpl(float DeltaTime)
	{
		ExecFunc();
		return GSMUITickableStat.IDLE;
	}
}
