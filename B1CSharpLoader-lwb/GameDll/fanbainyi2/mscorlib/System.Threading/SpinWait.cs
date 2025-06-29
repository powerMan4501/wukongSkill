using System.Security.Permissions;

namespace System.Threading;

[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public struct SpinWait
{
	internal const int YIELD_THRESHOLD = 10;

	internal const int SLEEP_0_EVERY_HOW_MANY_TIMES = 5;

	internal const int SLEEP_1_EVERY_HOW_MANY_TIMES = 20;

	private int m_count;

	[__DynamicallyInvokable]
	public int Count
	{
		[__DynamicallyInvokable]
		get
		{
			return m_count;
		}
	}

	[__DynamicallyInvokable]
	public bool NextSpinWillYield
	{
		[__DynamicallyInvokable]
		get
		{
			if (m_count <= 10)
			{
				return PlatformHelper.IsSingleProcessor;
			}
			return true;
		}
	}

	[__DynamicallyInvokable]
	public void SpinOnce()
	{
		if (NextSpinWillYield)
		{
			CdsSyncEtwBCLProvider.Log.SpinWait_NextSpinWillYield();
			int num = ((m_count >= 10) ? (m_count - 10) : m_count);
			if (num % 20 == 19)
			{
				Thread.Sleep(1);
			}
			else if (num % 5 == 4)
			{
				Thread.Sleep(0);
			}
			else
			{
				Thread.Yield();
			}
		}
		else
		{
			Thread.SpinWait(4 << m_count);
		}
		m_count = ((m_count == int.MaxValue) ? 10 : (m_count + 1));
	}

	[__DynamicallyInvokable]
	public void Reset()
	{
		m_count = 0;
	}

	[__DynamicallyInvokable]
	public static void SpinUntil(Func<bool> condition)
	{
		SpinUntil(condition, -1);
	}

	[__DynamicallyInvokable]
	public static bool SpinUntil(Func<bool> condition, TimeSpan timeout)
	{
		long num = (long)timeout.TotalMilliseconds;
		if (num < -1 || num > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("timeout", timeout, Environment.GetResourceString("SpinWait_SpinUntil_TimeoutWrong"));
		}
		return SpinUntil(condition, (int)timeout.TotalMilliseconds);
	}

	[__DynamicallyInvokable]
	public static bool SpinUntil(Func<bool> condition, int millisecondsTimeout)
	{
		if (millisecondsTimeout < -1)
		{
			throw new ArgumentOutOfRangeException("millisecondsTimeout", millisecondsTimeout, Environment.GetResourceString("SpinWait_SpinUntil_TimeoutWrong"));
		}
		if (condition == null)
		{
			throw new ArgumentNullException("condition", Environment.GetResourceString("SpinWait_SpinUntil_ArgumentNull"));
		}
		uint num = 0u;
		if (millisecondsTimeout != 0 && millisecondsTimeout != -1)
		{
			num = TimeoutHelper.GetTime();
		}
		SpinWait spinWait = default(SpinWait);
		while (!condition())
		{
			if (millisecondsTimeout == 0)
			{
				return false;
			}
			spinWait.SpinOnce();
			if (millisecondsTimeout != -1 && spinWait.NextSpinWillYield && millisecondsTimeout <= TimeoutHelper.GetTime() - num)
			{
				return false;
			}
		}
		return true;
	}
}
