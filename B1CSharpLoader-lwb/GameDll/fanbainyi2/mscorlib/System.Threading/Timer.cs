using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading.NetCore;

namespace System.Threading;

[ComVisible(true)]
[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public sealed class Timer : MarshalByRefObject, IDisposable
{
	internal static readonly bool UseNetCoreTimer = AppContextSwitches.UseNetCoreTimer;

	private const uint MAX_SUPPORTED_TIMEOUT = 4294967294u;

	private TimerHolder m_timer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public Timer(TimerCallback callback, object state, int dueTime, int period)
	{
		if (dueTime < -1)
		{
			throw new ArgumentOutOfRangeException("dueTime", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		if (period < -1)
		{
			throw new ArgumentOutOfRangeException("period", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		TimerSetup(callback, state, (uint)dueTime, (uint)period, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public Timer(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period)
	{
		long num = (long)dueTime.TotalMilliseconds;
		if (num < -1)
		{
			throw new ArgumentOutOfRangeException("dueTm", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		if (num > 4294967294u)
		{
			throw new ArgumentOutOfRangeException("dueTm", Environment.GetResourceString("ArgumentOutOfRange_TimeoutTooLarge"));
		}
		long num2 = (long)period.TotalMilliseconds;
		if (num2 < -1)
		{
			throw new ArgumentOutOfRangeException("periodTm", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		if (num2 > 4294967294u)
		{
			throw new ArgumentOutOfRangeException("periodTm", Environment.GetResourceString("ArgumentOutOfRange_PeriodTooLarge"));
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		TimerSetup(callback, state, (uint)num, (uint)num2, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CLSCompliant(false)]
	[SecuritySafeCritical]
	public Timer(TimerCallback callback, object state, uint dueTime, uint period)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		TimerSetup(callback, state, dueTime, period, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public Timer(TimerCallback callback, object state, long dueTime, long period)
	{
		if (dueTime < -1)
		{
			throw new ArgumentOutOfRangeException("dueTime", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		if (period < -1)
		{
			throw new ArgumentOutOfRangeException("period", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		if (dueTime > 4294967294u)
		{
			throw new ArgumentOutOfRangeException("dueTime", Environment.GetResourceString("ArgumentOutOfRange_TimeoutTooLarge"));
		}
		if (period > 4294967294u)
		{
			throw new ArgumentOutOfRangeException("period", Environment.GetResourceString("ArgumentOutOfRange_PeriodTooLarge"));
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		TimerSetup(callback, state, (uint)dueTime, (uint)period, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public Timer(TimerCallback callback)
	{
		int dueTime = -1;
		int period = -1;
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		TimerSetup(callback, this, (uint)dueTime, (uint)period, ref stackMark);
	}

	[SecurityCritical]
	private void TimerSetup(TimerCallback callback, object state, uint dueTime, uint period, ref StackCrawlMark stackMark)
	{
		if (callback == null)
		{
			throw new ArgumentNullException("TimerCallback");
		}
		object timer = ((!UseNetCoreTimer) ? ((object)new TimerQueueTimer(callback, state, dueTime, period, ref stackMark)) : ((object)new System.Threading.NetCore.TimerQueueTimer(callback, state, dueTime, period, flowExecutionContext: true, ref stackMark)));
		m_timer = new TimerHolder(timer);
	}

	[SecurityCritical]
	internal static void Pause()
	{
		if (UseNetCoreTimer)
		{
			System.Threading.NetCore.TimerQueue.PauseAll();
		}
		else
		{
			TimerQueue.Instance.Pause();
		}
	}

	[SecurityCritical]
	internal static void Resume()
	{
		if (UseNetCoreTimer)
		{
			System.Threading.NetCore.TimerQueue.ResumeAll();
		}
		else
		{
			TimerQueue.Instance.Resume();
		}
	}

	[__DynamicallyInvokable]
	public bool Change(int dueTime, int period)
	{
		if (dueTime < -1)
		{
			throw new ArgumentOutOfRangeException("dueTime", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		if (period < -1)
		{
			throw new ArgumentOutOfRangeException("period", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		return m_timer.Change((uint)dueTime, (uint)period);
	}

	[__DynamicallyInvokable]
	public bool Change(TimeSpan dueTime, TimeSpan period)
	{
		return Change((long)dueTime.TotalMilliseconds, (long)period.TotalMilliseconds);
	}

	[CLSCompliant(false)]
	public bool Change(uint dueTime, uint period)
	{
		return m_timer.Change(dueTime, period);
	}

	public bool Change(long dueTime, long period)
	{
		if (dueTime < -1)
		{
			throw new ArgumentOutOfRangeException("dueTime", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		if (period < -1)
		{
			throw new ArgumentOutOfRangeException("period", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		if (dueTime > 4294967294u)
		{
			throw new ArgumentOutOfRangeException("dueTime", Environment.GetResourceString("ArgumentOutOfRange_TimeoutTooLarge"));
		}
		if (period > 4294967294u)
		{
			throw new ArgumentOutOfRangeException("period", Environment.GetResourceString("ArgumentOutOfRange_PeriodTooLarge"));
		}
		return m_timer.Change((uint)dueTime, (uint)period);
	}

	public bool Dispose(WaitHandle notifyObject)
	{
		if (notifyObject == null)
		{
			throw new ArgumentNullException("notifyObject");
		}
		return m_timer.Close(notifyObject);
	}

	[__DynamicallyInvokable]
	public void Dispose()
	{
		m_timer.Close();
	}

	internal void KeepRootedWhileScheduled()
	{
		GC.SuppressFinalize(m_timer);
	}
}
