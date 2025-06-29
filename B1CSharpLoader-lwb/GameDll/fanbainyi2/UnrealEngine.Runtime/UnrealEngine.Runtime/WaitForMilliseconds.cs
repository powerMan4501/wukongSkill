using System;

namespace UnrealEngine.Runtime;

public class WaitForMilliseconds : WaitFor
{
	public uint Milliseconds => (uint)base.Time.TotalMilliseconds;

	public WaitForMilliseconds(double milliseconds)
		: base(TimeSpan.FromMilliseconds(milliseconds))
	{
	}

	public WaitForMilliseconds(uint milliseconds)
		: base(TimeSpan.FromMilliseconds(milliseconds))
	{
	}
}
