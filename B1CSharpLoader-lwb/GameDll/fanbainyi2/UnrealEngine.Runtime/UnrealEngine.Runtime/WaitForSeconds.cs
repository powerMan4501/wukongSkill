using System;

namespace UnrealEngine.Runtime;

public class WaitForSeconds : WaitFor
{
	public double Seconds => base.Time.TotalSeconds;

	public WaitForSeconds(uint seconds)
		: base(TimeSpan.FromSeconds(seconds))
	{
	}

	public WaitForSeconds(double seconds)
		: base(TimeSpan.FromSeconds(seconds))
	{
	}
}
