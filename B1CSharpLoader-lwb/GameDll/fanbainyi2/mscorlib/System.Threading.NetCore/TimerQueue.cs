using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32;

namespace System.Threading.NetCore;

internal class TimerQueue
{
	private readonly int m_id;

	[SecurityCritical]
	private System.Threading.TimerQueue.AppDomainTimerSafeHandle m_appDomainTimer;

	private bool m_isAppDomainTimerScheduled;

	private long m_currentAppDomainTimerStartTicks;

	private uint m_currentAppDomainTimerDuration;

	private TimerQueueTimer m_shortTimers;

	private TimerQueueTimer m_longTimers;

	private long m_currentAbsoluteThreshold = TickCount64 + 333;

	private const int ShortTimersThresholdMilliseconds = 333;

	private long m_pauseTicks;

	[ThreadStatic]
	private static List<TimerQueueTimer> t_timersToQueueToFire;

	public static TimerQueue[] Instances { get; } = CreateTimerQueues();

	private static long TickCount64
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
				return (long)(UnbiasedTime / 10000);
			}
			return Environment.TickCount64;
		}
	}

	private TimerQueue(int id)
	{
		m_id = id;
	}

	private static TimerQueue[] CreateTimerQueues()
	{
		TimerQueue[] array = new TimerQueue[Environment.ProcessorCount];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = new TimerQueue(i);
		}
		return array;
	}

	[SecuritySafeCritical]
	private bool EnsureAppDomainTimerFiresBy(uint requestedDuration)
	{
		uint num = Math.Min(requestedDuration, 268435455u);
		if (m_isAppDomainTimerScheduled)
		{
			long num2 = TickCount64 - m_currentAppDomainTimerStartTicks;
			if (num2 >= m_currentAppDomainTimerDuration)
			{
				return true;
			}
			uint num3 = m_currentAppDomainTimerDuration - (uint)(int)num2;
			if (num >= num3)
			{
				return true;
			}
		}
		if (m_pauseTicks != 0L)
		{
			return true;
		}
		if (m_appDomainTimer == null || m_appDomainTimer.IsInvalid)
		{
			m_appDomainTimer = System.Threading.TimerQueue.CreateAppDomainTimer(num, m_id);
			if (!m_appDomainTimer.IsInvalid)
			{
				m_isAppDomainTimerScheduled = true;
				m_currentAppDomainTimerStartTicks = TickCount64;
				m_currentAppDomainTimerDuration = num;
				return true;
			}
			return false;
		}
		if (System.Threading.TimerQueue.ChangeAppDomainTimer(m_appDomainTimer, num))
		{
			m_isAppDomainTimerScheduled = true;
			m_currentAppDomainTimerStartTicks = TickCount64;
			m_currentAppDomainTimerDuration = num;
			return true;
		}
		return false;
	}

	[SecuritySafeCritical]
	internal static void AppDomainTimerCallback(int id)
	{
		Instances[id].FireNextTimers();
	}

	[SecurityCritical]
	internal static void PauseAll()
	{
		TimerQueue[] instances = Instances;
		foreach (TimerQueue timerQueue in instances)
		{
			timerQueue.Pause();
		}
	}

	[SecurityCritical]
	internal static void ResumeAll()
	{
		TimerQueue[] instances = Instances;
		foreach (TimerQueue timerQueue in instances)
		{
			timerQueue.Resume();
		}
	}

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
				m_pauseTicks = TickCount64;
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
				long pauseTicks = m_pauseTicks;
				m_pauseTicks = 0L;
				long tickCount = TickCount64;
				long num = tickCount - pauseTicks;
				bool flag = false;
				uint num2 = uint.MaxValue;
				TimerQueueTimer timerQueueTimer = m_shortTimers;
				for (int i = 0; i < 2; i++)
				{
					while (timerQueueTimer != null)
					{
						TimerQueueTimer next = timerQueueTimer.m_next;
						long num3 = ((num > tickCount - timerQueueTimer.m_startTicks) ? (tickCount - timerQueueTimer.m_startTicks) : (pauseTicks - timerQueueTimer.m_startTicks));
						timerQueueTimer.m_dueTime = ((timerQueueTimer.m_dueTime > num3) ? (timerQueueTimer.m_dueTime - (uint)(int)num3) : 0u);
						timerQueueTimer.m_startTicks = tickCount;
						if (timerQueueTimer.m_dueTime < num2)
						{
							flag = true;
							num2 = timerQueueTimer.m_dueTime;
						}
						if (!timerQueueTimer.m_short && timerQueueTimer.m_dueTime <= 333)
						{
							MoveTimerToCorrectList(timerQueueTimer, shortList: true);
						}
						timerQueueTimer = next;
					}
					if (i != 0)
					{
						continue;
					}
					long num4 = m_currentAbsoluteThreshold - tickCount;
					if (num4 > 0)
					{
						if (m_shortTimers == null && m_longTimers != null)
						{
							num2 = (uint)((int)num4 + 1);
							flag = true;
						}
						break;
					}
					timerQueueTimer = m_longTimers;
					m_currentAbsoluteThreshold = tickCount + 333;
				}
				if (flag)
				{
					EnsureAppDomainTimerFiresBy(num2);
				}
			}
		}
	}

	[SecuritySafeCritical]
	private void FireNextTimers()
	{
		TimerQueueTimer timerQueueTimer = null;
		List<TimerQueueTimer> list = t_timersToQueueToFire;
		if (list == null)
		{
			list = (t_timersToQueueToFire = new List<TimerQueueTimer>());
		}
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
				long tickCount = TickCount64;
				TimerQueueTimer timerQueueTimer2 = m_shortTimers;
				for (int i = 0; i < 2; i++)
				{
					while (timerQueueTimer2 != null)
					{
						TimerQueueTimer next = timerQueueTimer2.m_next;
						long num2 = tickCount - timerQueueTimer2.m_startTicks;
						long num3 = timerQueueTimer2.m_dueTime - num2;
						if (num3 <= 0)
						{
							if (timerQueueTimer2.m_period != uint.MaxValue)
							{
								timerQueueTimer2.m_startTicks = tickCount;
								long num4 = num2 - timerQueueTimer2.m_dueTime;
								timerQueueTimer2.m_dueTime = ((num4 >= timerQueueTimer2.m_period) ? 1u : (timerQueueTimer2.m_period - (uint)(int)num4));
								if (timerQueueTimer2.m_dueTime < num)
								{
									flag = true;
									num = timerQueueTimer2.m_dueTime;
								}
								bool flag2 = tickCount + timerQueueTimer2.m_dueTime - m_currentAbsoluteThreshold <= 0;
								if (timerQueueTimer2.m_short != flag2)
								{
									MoveTimerToCorrectList(timerQueueTimer2, flag2);
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
								list.Add(timerQueueTimer2);
							}
						}
						else
						{
							if (num3 < num)
							{
								flag = true;
								num = (uint)num3;
							}
							if (!timerQueueTimer2.m_short && num3 <= 333)
							{
								MoveTimerToCorrectList(timerQueueTimer2, shortList: true);
							}
						}
						timerQueueTimer2 = next;
					}
					if (i != 0)
					{
						continue;
					}
					long num5 = m_currentAbsoluteThreshold - tickCount;
					if (num5 > 0)
					{
						if (m_shortTimers == null && m_longTimers != null)
						{
							num = (uint)((int)num5 + 1);
							flag = true;
						}
						break;
					}
					timerQueueTimer2 = m_longTimers;
					m_currentAbsoluteThreshold = tickCount + 333;
				}
				if (flag)
				{
					EnsureAppDomainTimerFiresBy(num);
				}
			}
		}
		if (list.Count != 0)
		{
			foreach (TimerQueueTimer item in list)
			{
				ThreadPool.UnsafeQueueCustomWorkItem(item, forceGlobal: true);
			}
			list.Clear();
		}
		timerQueueTimer?.Fire();
	}

	public bool UpdateTimer(TimerQueueTimer timer, uint dueTime, uint period)
	{
		long tickCount = TickCount64;
		long num = tickCount + dueTime;
		bool flag = m_currentAbsoluteThreshold - num >= 0;
		if (timer.m_dueTime == uint.MaxValue)
		{
			timer.m_short = flag;
			LinkTimer(timer);
		}
		else if (timer.m_short != flag)
		{
			UnlinkTimer(timer);
			timer.m_short = flag;
			LinkTimer(timer);
		}
		timer.m_dueTime = dueTime;
		timer.m_period = ((period == 0) ? uint.MaxValue : period);
		timer.m_startTicks = tickCount;
		return EnsureAppDomainTimerFiresBy(dueTime);
	}

	public void MoveTimerToCorrectList(TimerQueueTimer timer, bool shortList)
	{
		UnlinkTimer(timer);
		timer.m_short = shortList;
		LinkTimer(timer);
	}

	private void LinkTimer(TimerQueueTimer timer)
	{
		timer.m_next = (timer.m_short ? m_shortTimers : m_longTimers);
		if (timer.m_next != null)
		{
			timer.m_next.m_prev = timer;
		}
		timer.m_prev = null;
		if (timer.m_short)
		{
			m_shortTimers = timer;
		}
		else
		{
			m_longTimers = timer;
		}
	}

	private void UnlinkTimer(TimerQueueTimer timer)
	{
		TimerQueueTimer next = timer.m_next;
		if (next != null)
		{
			next.m_prev = timer.m_prev;
		}
		if (m_shortTimers == timer)
		{
			m_shortTimers = next;
		}
		else if (m_longTimers == timer)
		{
			m_longTimers = next;
		}
		next = timer.m_prev;
		if (next != null)
		{
			next.m_next = timer.m_next;
		}
	}

	public void DeleteTimer(TimerQueueTimer timer)
	{
		if (timer.m_dueTime != uint.MaxValue)
		{
			UnlinkTimer(timer);
			timer.m_prev = null;
			timer.m_next = null;
			timer.m_dueTime = uint.MaxValue;
			timer.m_period = uint.MaxValue;
			timer.m_startTicks = 0L;
			timer.m_short = false;
		}
	}
}
