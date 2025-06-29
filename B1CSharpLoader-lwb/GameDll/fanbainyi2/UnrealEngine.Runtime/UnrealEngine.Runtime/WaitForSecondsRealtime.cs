using System;

namespace UnrealEngine.Runtime;

public class WaitForSecondsRealtime : WaitForRealtime
{
	public double Seconds => base.Time.TotalSeconds;

	public WaitForSecondsRealtime(uint seconds)
		: base(TimeSpan.FromSeconds(seconds))
	{
	}

	public WaitForSecondsRealtime(double seconds)
		: base(TimeSpan.FromSeconds(seconds))
	{
	}
}
