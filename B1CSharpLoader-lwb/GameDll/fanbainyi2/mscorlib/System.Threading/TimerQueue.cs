using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.NetCore;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Threading;

internal class TimerQueue
{
	[SecurityCritical]
	internal class AppDomainTimerSafeHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		public AppDomainTimerSafeHandle()
			: base(ownsHandle: true)
		{
		}

		[SecurityCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		protected override bool ReleaseHandle()
		{
			return DeleteAppDomainTimer(handle);
		}
	}

	private static TimerQueue s_queue = new TimerQueue();

	[SecurityCritical]
	private AppDomainTimerSafeHandle m_appDomainTimer;

	private bool m_isAppDomainTimerScheduled;

	private int m_currentAppDomainTimerStartTicks;

	private uint m_currentAppDomainTimerDuration;

	private TimerQueueTimer m_timers;

	private volatile int m_pauseTicks;

	private static WaitCallback s_fireQueuedTimerCompletion;

	public static TimerQueue Instance => s_queue;

	private static int TickCount
	{
		[SecuritySafeCritical]
		get
		{
			if (Environment.IsWindows8OrAbove)
			{
				if (!Win32Native.QueryUnbiasedInterruptTime(out var UnbiasedTime))
				{
					throw Marshal.GetExceptionForHR(Marshal.GetLastWin32Error());
				}
				return (int)(UnbiasedTime / 10000);
			}
			return Environment.TickCount;
		}
	}

	private TimerQueue()
	{
	}

	[SecuritySafeCritical]
	private bool EnsureAppDomainTimerFiresBy(uint requestedDuration)
	{
		uint num = Math.Min(requestedDuration, 268435455u);
		if (m_isAppDomainTimerScheduled)
		{
			uint num2 = (uint)(TickCount - m_currentAppDomainTimerStartTicks);
			if (num2 >= m_currentAppDomainTimerDuration)
			{
				return true;
			}
			uint num3 = m_currentAppDomainTimerDuration - num2;
			if (num >= num3)
			{
				return true;
			}
		}
		if (m_pauseTicks != 0)
		{
			return true;
		}
		if (m_appDomainTimer == null || m_appDomainTimer.IsInvalid)
		{
			m_appDomainTimer = CreateAppDomainTimer(num, 0);
			if (!m_appDomainTimer.IsInvalid)
			{
				m_isAppDomainTimerScheduled = true;
				m_currentAppDomainTimerStartTicks = TickCount;
				m_currentAppDomainTimerDuration = num;
				return true;
			}
			return false;
		}
		if (ChangeAppDomainTimer(m_appDomainTimer, num))
		{
			m_isAppDomainTimerScheduled = true;
			m_currentAppDomainTimerStartTicks = TickCount;
			m_currentAppDomainTimerDuration = num;
			return true;
		}
		return false;
	}

	[SecuritySafeCritical]
	internal static void AppDomainTimerCallback(int id)
	{
		if (Timer.UseNetCoreTimer)
		{
			System.Threading.NetCore.TimerQueue.AppDomainTimerCallback(id);
		}
		else
		{
			Instance.FireNextTimers();
		}
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern AppDomainTimerSafeHandle CreateAppDomainTimer(uint dueTime, int id);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern bool ChangeAppDomainTimer(AppDomainTimerSafeHandle handle, uint dueTime);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static extern bool DeleteAppDomainTimer(IntPtr handle);

	[SecurityCritical]
	internal void Pause()
	{
		lock (this)
		{
			if (m_appDomainTimer != null && !m_appDomainTimer.IsInvalid)
			{
				m_appDomainTimer.Dispose();
				m_appDomainTimer = null;
				m_isAppDomainTimerScheduled = false;
				m_pauseTicks = TickCount;
			}
		}
	}

	[SecurityCritical]
	internal void Resume()
	{
		lock (this)
		{
			try
			{
			}
			finally
			{
				int pauseTicks = m_pauseTicks;
				m_pauseTicks = 0;
				int tickCount = TickCount;
				int num = tickCount - pauseTicks;
				bool flag = false;
				uint num2 = uint.MaxValue;
				for (TimerQueueTimer timerQueueTimer = m_timers; timerQueueTimer != null; timerQueueTimer = timerQueueTimer.m_next)
				{
					uint num3 = (uint)((timerQueueTimer.m_startTicks > pauseTicks) ? (tickCount - timerQueueTimer.m_startTicks) : (pauseTicks - timerQueueTimer.m_startTicks));
					timerQueueTimer.m_dueTime = ((timerQueueTimer.m_dueTime > num3) ? (timerQueueTimer.m_dueTime - num3) : 0u);
					timerQueueTimer.m_startTicks = tickCount;
					if (timerQueueTimer.m_dueTime < num2)
					{
						flag = true;
						num2 = timerQueueTimer.m_dueTime;
					}
				}
				if (flag)
				{
					EnsureAppDomainTimerFiresBy(num2);
				}
			}
		}
	}

	private void FireNextTimers()
	{
		TimerQueueTimer timerQueueTimer = null;
		lock (this)
		{
			try
			{
			}
			finally
			{
				m_isAppDomainTimerScheduled = false;
				bool flag = false;
				uint num = uint.MaxValue;
				int tickCount = TickCount;
				TimerQueueTimer timerQueueTimer2 = m_timers;
				while (timerQueueTimer2 != null)
				{
					uint num2 = (uint)(tickCount - timerQueueTimer2.m_startTicks);
					if (num2 >= timerQueueTimer2.m_dueTime)
					{
						TimerQueueTimer next = timerQueueTimer2.m_next;
						if (timerQueueTimer2.m_period != uint.MaxValue)
						{
							timerQueueTimer2.m_startTicks = tickCount;
							timerQueueTimer2.m_dueTime = timerQueueTimer2.m_period;
							if (timerQueueTimer2.m_dueTime < num)
							{
								flag = true;
								num = timerQueueTimer2.m_dueTime;
							}
						}
						else
						{
							DeleteTimer(timerQueueTimer2);
						}
						if (timerQueueTimer == null)
						{
							timerQueueTimer = timerQueueTimer2;
						}
						else
						{
							QueueTimerCompletion(timerQueueTimer2);
						}
						timerQueueTimer2 = next;
					}
					else
					{
						uint num3 = timerQueueTimer2.m_dueTime - num2;
						if (num3 < num)
						{
							flag = true;
							num = num3;
						}
						timerQueueTimer2 = timerQueueTimer2.m_next;
					}
				}
				if (flag)
				{
					EnsureAppDomainTimerFiresBy(num);
				}
			}
		}
		timerQueueTimer?.Fire();
	}

	[SecuritySafeCritical]
	private static void QueueTimerCompletion(TimerQueueTimer timer)
	{
		WaitCallback callBack = FireQueuedTimerCompletion;
		ThreadPool.UnsafeQueueUserWorkItem(callBack, timer);
	}

	private static void FireQueuedTimerCompletion(object state)
	{
		((TimerQueueTimer)state).Fire();
	}

	public bool UpdateTimer(TimerQueueTimer timer, uint dueTime, uint period)
	{
		if (timer.m_dueTime == uint.MaxValue)
		{
			timer.m_next = m_timers;
			timer.m_prev = null;
			if (timer.m_next != null)
			{
				timer.m_next.m_prev = timer;
			}
			m_timers = timer;
		}
		timer.m_dueTime = dueTime;
		timer.m_period = ((period == 0) ? uint.MaxValue : period);
		timer.m_startTicks = TickCount;
		return EnsureAppDomainTimerFiresBy(dueTime);
	}

	public void DeleteTimer(TimerQueueTimer timer)
	{
		if (timer.m_dueTime != uint.MaxValue)
		{
			if (timer.m_next != null)
			{
				timer.m_next.m_prev = timer.m_prev;
			}
			if (timer.m_prev != null)
			{
				timer.m_prev.m_next = timer.m_next;
			}
			if (m_timers == timer)
			{
				m_timers = timer.m_next;
			}
			timer.m_dueTime = uint.MaxValue;
			timer.m_period = uint.MaxValue;
			timer.m_startTicks = 0;
			timer.m_prev = null;
			timer.m_next = null;
		}
	}
}
