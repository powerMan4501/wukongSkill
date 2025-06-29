namespace b1.GSMUICore.Event;

public class GSMUIDelay : GSMUIEventBase
{
	private readonly float Delay;

	public GSMUIDelay(float InDelay)
		: base("GSMUIDelay")
	{
		Delay = InDelay;
	}

	protected override GSMUITickableStat DoTickImpl(float DeltaTime)
	{
		if (RunTime >= Delay)
		{
			return GSMUITickableStat.IDLE;
		}
		return GSMUITickableStat.TICKING;
	}
}
