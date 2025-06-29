using System;

namespace UnrealEngine.Runtime;

public class WaitForMillisecondsRealtime : WaitForRealtime
{
	public uint Milliseconds => (uint)base.Time.TotalMilliseconds;

	public WaitForMillisecondsRealtime(uint milliseconds)
		: base(TimeSpan.FromMilliseconds(milliseconds))
	{
	}

	public WaitForMillisecondsRealtime(double milliseconds)
		: base(TimeSpan.FromMilliseconds(milliseconds))
	{
	}
}
