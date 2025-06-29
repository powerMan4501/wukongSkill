using System.Diagnostics.Tracing;
using System.Security;
using Microsoft.Win32;

namespace System.Threading.NetCore;

internal sealed class TimerQueueTimer : IThreadPoolWorkItem
{
	private readonly TimerQueue m_associatedTimerQueue;

	internal TimerQueueTimer m_next;

	internal TimerQueueTimer m_prev;

	internal bool m_short;

	internal long m_startTicks;

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

	[SecuritySafeCritical]
	internal TimerQueueTimer(TimerCallback timerCallback, object state, uint dueTime, uint period, bool flowExecutionContext, ref StackCrawlMark stackMark)
	{
		m_timerCallback = timerCallback;
		m_state = state;
		m_dueTime = uint.MaxValue;
		m_period = uint.MaxValue;
		if (flowExecutionContext)
		{
			m_executionContext = ExecutionContext.Capture(ref stackMark, ExecutionContext.CaptureOptions.IgnoreSyncCtx | ExecutionContext.CaptureOptions.OptimizeDefaultCase);
		}
		m_associatedTimerQueue = TimerQueue.Instances[Thread.GetCurrentProcessorId() % TimerQueue.Instances.Length];
		if (dueTime != uint.MaxValue)
		{
			Change(dueTime, period);
		}
	}

	internal bool Change(uint dueTime, uint period)
	{
		bool result;
		lock (m_associatedTimerQueue)
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
					m_associatedTimerQueue.DeleteTimer(this);
					result = true;
				}
				else
				{
					if (FrameworkEventSource.IsInitialized && FrameworkEventSource.Log.IsEnabled(EventLevel.Informational, (EventKeywords)16L))
					{
						FrameworkEventSource.Log.ThreadTransferSendObj(this, 1, string.Empty, multiDequeues: true);
					}
					result = m_associatedTimerQueue.UpdateTimer(this, dueTime, period);
				}
			}
		}
		return result;
	}

	public void Close()
	{
		lock (m_associatedTimerQueue)
		{
			try
			{
			}
			finally
			{
				if (!m_canceled)
				{
					m_canceled = true;
					m_associatedTimerQueue.DeleteTimer(this);
				}
			}
		}
	}

	public bool Close(WaitHandle toSignal)
	{
		bool flag = false;
		bool result;
		lock (m_associatedTimerQueue)
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
					m_associatedTimerQueue.DeleteTimer(this);
					flag = m_callbacksRunning == 0;
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

	[SecurityCritical]
	void IThreadPoolWorkItem.ExecuteWorkItem()
	{
		Fire();
	}

	[SecurityCritical]
	void IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae)
	{
	}

	internal void Fire()
	{
		bool flag = false;
		lock (m_associatedTimerQueue)
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
		lock (m_associatedTimerQueue)
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
		ExecutionContext executionContext = m_executionContext;
		if (executionContext == null)
		{
			m_timerCallback(m_state);
			return;
		}
		using (executionContext = (executionContext.IsPreAllocatedDefault ? executionContext : executionContext.CreateCopy()))
		{
			ContextCallback contextCallback = s_callCallbackInContext;
			if (contextCallback == null)
			{
				contextCallback = (s_callCallbackInContext = CallCallbackInContext);
			}
			ExecutionContext.Run(executionContext, s_callCallbackInContext, this, preserveSyncCtx: true);
		}
	}

	[SecurityCritical]
	private static void CallCallbackInContext(object state)
	{
		TimerQueueTimer timerQueueTimer = (TimerQueueTimer)state;
		timerQueueTimer.m_timerCallback(timerQueueTimer.m_state);
	}
}
