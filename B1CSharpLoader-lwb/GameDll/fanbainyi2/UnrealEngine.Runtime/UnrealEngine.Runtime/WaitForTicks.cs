namespace UnrealEngine.Runtime;

public class WaitForTicks : WaitForExactTick
{
	private ulong ticks;

	public ulong Ticks
	{
		get
		{
			return ticks;
		}
		set
		{
			ticks = value;
			UpdateRelativeTick(value);
		}
	}

	public WaitForTicks(ulong ticks)
		: base(ticks, relative: true)
	{
		this.ticks = ticks;
	}

	internal WaitForTicks PoolNew(ulong ticks)
	{
		Ticks = ticks;
		return this;
	}
}
