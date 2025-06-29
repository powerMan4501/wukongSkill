using System.Diagnostics.Tracing;
using System.Security;
using Microsoft.Win32;

namespace System.Threading;

internal sealed class TimerQueueTimer
{
	internal TimerQueueTimer m_next;

	internal TimerQueueTimer m_prev;

	internal int m_startTicks;

	internal uint m_dueTime;

	internal uint m_period;

	private readonly TimerCallback m_timerCallback;

	private readonly object m_state;

	private readonly ExecutionContext m_executionContext;

	private int m_callbacksRunning;

	private volatile bool m_canceled;

	private volatile WaitHandle m_notifyWhenNoCallbacksRunning;

	[SecurityCritical]
	private static ContextCallback s_callCallbackInContext;

	[SecurityCritical]
	internal TimerQueueTimer(TimerCallback timerCallback, object state, uint dueTime, uint period, ref StackCrawlMark stackMark)
	{
		m_timerCallback = timerCallback;
		m_state = state;
		m_dueTime = uint.MaxValue;
		m_period = uint.MaxValue;
		if (!ExecutionContext.IsFlowSuppressed())
		{
			m_executionContext = ExecutionContext.Capture(ref stackMark, ExecutionContext.CaptureOptions.IgnoreSyncCtx | ExecutionContext.CaptureOptions.OptimizeDefaultCase);
		}
		if (dueTime != uint.MaxValue)
		{
			Change(dueTime, period);
		}
	}

	internal bool Change(uint dueTime, uint period)
	{
		bool result;
		lock (TimerQueue.Instance)
		{
			if (m_canceled)
			{
				throw new ObjectDisposedException(null, Environment.GetResourceString("ObjectDisposed_Generic"));
			}
			try
			{
			}
			finally
			{
				m_period = period;
				if (dueTime == uint.MaxValue)
				{
					TimerQueue.Instance.DeleteTimer(this);
					result = true;
				}
				else
				{
					if (FrameworkEventSource.IsInitialized && FrameworkEventSource.Log.IsEnabled(EventLevel.Informational, (EventKeywords)16L))
					{
						FrameworkEventSource.Log.ThreadTransferSendObj(this, 1, string.Empty, multiDequeues: true);
					}
					result = TimerQueue.Instance.UpdateTimer(this, dueTime, period);
				}
			}
		}
		return result;
	}

	public void Close()
	{
		lock (TimerQueue.Instance)
		{
			try
			{
			}
			finally
			{
				if (!m_canceled)
				{
					m_canceled = true;
					TimerQueue.Instance.DeleteTimer(this);
				}
			}
		}
	}

	public bool Close(WaitHandle toSignal)
	{
		bool flag = false;
		bool result;
		lock (TimerQueue.Instance)
		{
			try
			{
			}
			finally
			{
				if (m_canceled)
				{
					result = false;
				}
				else
				{
					m_canceled = true;
					m_notifyWhenNoCallbacksRunning = toSignal;
					TimerQueue.Instance.DeleteTimer(this);
					if (m_callbacksRunning == 0)
					{
						flag = true;
					}
					result = true;
				}
			}
		}
		if (flag)
		{
			SignalNoCallbacksRunning();
		}
		return result;
	}

	internal void Fire()
	{
		bool flag = false;
		lock (TimerQueue.Instance)
		{
			try
			{
			}
			finally
			{
				flag = m_canceled;
				if (!flag)
				{
					m_callbacksRunning++;
				}
			}
		}
		if (flag)
		{
			return;
		}
		CallCallback();
		bool flag2 = false;
		lock (TimerQueue.Instance)
		{
			try
			{
			}
			finally
			{
				m_callbacksRunning--;
				if (m_canceled && m_callbacksRunning == 0 && m_notifyWhenNoCallbacksRunning != null)
				{
					flag2 = true;
				}
			}
		}
		if (flag2)
		{
			SignalNoCallbacksRunning();
		}
	}

	[SecuritySafeCritical]
	internal void SignalNoCallbacksRunning()
	{
		Win32Native.SetEvent(m_notifyWhenNoCallbacksRunning.SafeWaitHandle);
	}

	[SecuritySafeCritical]
	internal void CallCallback()
	{
		if (FrameworkEventSource.IsInitialized && FrameworkEventSource.Log.IsEnabled(EventLevel.Informational, (EventKeywords)16L))
		{
			FrameworkEventSource.Log.ThreadTransferReceiveObj(this, 1, string.Empty);
		}
		if (m_executionContext == null)
		{
			m_timerCallback(m_state);
			return;
		}
		using ExecutionContext executionContext = (m_executionContext.IsPreAllocatedDefault ? m_executionContext : m_executionContext.CreateCopy());
		ContextCallback callback = CallCallbackInContext;
		ExecutionContext.Run(executionContext, callback, this, preserveSyncCtx: true);
	}

	[SecurityCritical]
	private static void CallCallbackInContext(object state)
	{
		TimerQueueTimer timerQueueTimer = (TimerQueueTimer)state;
		timerQueueTimer.m_timerCallback(timerQueueTimer.m_state);
	}
}
