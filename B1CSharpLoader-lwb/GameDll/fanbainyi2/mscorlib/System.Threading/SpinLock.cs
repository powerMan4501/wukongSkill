using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Threading;

[ComVisible(false)]
[DebuggerTypeProxy(typeof(SystemThreading_SpinLockDebugView))]
[DebuggerDisplay("IsHeld = {IsHeld}")]
[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public struct SpinLock
{
	internal class SystemThreading_SpinLockDebugView
	{
		private SpinLock m_spinLock;

		public bool? IsHeldByCurrentThread
		{
			get
			{
				try
				{
					return m_spinLock.IsHeldByCurrentThread;
				}
				catch (InvalidOperationException)
				{
					return null;
				}
			}
		}

		public int? OwnerThreadID
		{
			get
			{
				if (m_spinLock.IsThreadOwnerTrackingEnabled)
				{
					return m_spinLock.m_owner;
				}
				return null;
			}
		}

		public bool IsHeld => m_spinLock.IsHeld;

		public SystemThreading_SpinLockDebugView(SpinLock spinLock)
		{
			m_spinLock = spinLock;
		}
	}

	private volatile int m_owner;

	private const int SPINNING_FACTOR = 100;

	private const int SLEEP_ONE_FREQUENCY = 40;

	private const int SLEEP_ZERO_FREQUENCY = 10;

	private const int TIMEOUT_CHECK_FREQUENCY = 10;

	private const int LOCK_ID_DISABLE_MASK = int.MinValue;

	private const int LOCK_ANONYMOUS_OWNED = 1;

	private const int WAITERS_MASK = 2147483646;

	private const int ID_DISABLED_AND_ANONYMOUS_OWNED = -2147483647;

	private const int LOCK_UNOWNED = 0;

	private static int MAXIMUM_WAITERS = 2147483646;

	[__DynamicallyInvokable]
	public bool IsHeld
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[__DynamicallyInvokable]
		get
		{
			if (IsThreadOwnerTrackingEnabled)
			{
				return m_owner != 0;
			}
			return (m_owner & 1) != 0;
		}
	}

	[__DynamicallyInvokable]
	public bool IsHeldByCurrentThread
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[__DynamicallyInvokable]
		get
		{
			if (!IsThreadOwnerTrackingEnabled)
			{
				throw new InvalidOperationException(Environment.GetResourceString("SpinLock_IsHeldByCurrentThread"));
			}
			return (m_owner & 0x7FFFFFFF) == Thread.CurrentThread.ManagedThreadId;
		}
	}

	[__DynamicallyInvokable]
	public bool IsThreadOwnerTrackingEnabled
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[__DynamicallyInvokable]
		get
		{
			return (m_owner & int.MinValue) == 0;
		}
	}

	[__DynamicallyInvokable]
	public SpinLock(bool enableThreadOwnerTracking)
	{
		m_owner = 0;
		if (!enableThreadOwnerTracking)
		{
			m_owner |= int.MinValue;
		}
	}

	[__DynamicallyInvokable]
	public void Enter(ref bool lockTaken)
	{
		Thread.BeginCriticalRegion();
		int owner = m_owner;
		if (lockTaken || (owner & -2147483647) != int.MinValue || Interlocked.CompareExchange(ref m_owner, owner | 1, owner, ref lockTaken) != owner)
		{
			ContinueTryEnter(-1, ref lockTaken);
		}
	}

	[__DynamicallyInvokable]
	public void TryEnter(ref bool lockTaken)
	{
		TryEnter(0, ref lockTaken);
	}

	[__DynamicallyInvokable]
	public void TryEnter(TimeSpan timeout, ref bool lockTaken)
	{
		long num = (long)timeout.TotalMilliseconds;
		if (num < -1 || num > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("timeout", timeout, Environment.GetResourceString("SpinLock_TryEnter_ArgumentOutOfRange"));
		}
		TryEnter((int)timeout.TotalMilliseconds, ref lockTaken);
	}

	[__DynamicallyInvokable]
	public void TryEnter(int millisecondsTimeout, ref bool lockTaken)
	{
		Thread.BeginCriticalRegion();
		int owner = m_owner;
		if (((millisecondsTimeout < -1) | lockTaken) || (owner & -2147483647) != int.MinValue || Interlocked.CompareExchange(ref m_owner, owner | 1, owner, ref lockTaken) != owner)
		{
			ContinueTryEnter(millisecondsTimeout, ref lockTaken);
		}
	}

	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken)
	{
		Thread.EndCriticalRegion();
		if (lockTaken)
		{
			lockTaken = false;
			throw new ArgumentException(Environment.GetResourceString("SpinLock_TryReliableEnter_ArgumentException"));
		}
		if (millisecondsTimeout < -1)
		{
			throw new ArgumentOutOfRangeException("millisecondsTimeout", millisecondsTimeout, Environment.GetResourceString("SpinLock_TryEnter_ArgumentOutOfRange"));
		}
		uint startTime = 0u;
		if (millisecondsTimeout != -1 && millisecondsTimeout != 0)
		{
			startTime = TimeoutHelper.GetTime();
		}
		if (CdsSyncEtwBCLProvider.Log.IsEnabled())
		{
			CdsSyncEtwBCLProvider.Log.SpinLock_FastPathFailed(m_owner);
		}
		if (IsThreadOwnerTrackingEnabled)
		{
			ContinueTryEnterWithThreadTracking(millisecondsTimeout, startTime, ref lockTaken);
			return;
		}
		int num = int.MaxValue;
		int owner = m_owner;
		if ((owner & 1) == 0)
		{
			Thread.BeginCriticalRegion();
			if (Interlocked.CompareExchange(ref m_owner, owner | 1, owner, ref lockTaken) == owner)
			{
				return;
			}
			Thread.EndCriticalRegion();
		}
		else if ((owner & 0x7FFFFFFE) != MAXIMUM_WAITERS)
		{
			num = (Interlocked.Add(ref m_owner, 2) & 0x7FFFFFFE) >> 1;
		}
		if (millisecondsTimeout == 0 || (millisecondsTimeout != -1 && TimeoutHelper.UpdateTimeOut(startTime, millisecondsTimeout) <= 0))
		{
			DecrementWaiters();
			return;
		}
		int processorCount = PlatformHelper.ProcessorCount;
		if (num < processorCount)
		{
			int num2 = 1;
			for (int i = 1; i <= num * 100; i++)
			{
				Thread.SpinWait((num + i) * 100 * num2);
				if (num2 < processorCount)
				{
					num2++;
				}
				owner = m_owner;
				if ((owner & 1) == 0)
				{
					Thread.BeginCriticalRegion();
					int value = (((owner & 0x7FFFFFFE) == 0) ? (owner | 1) : ((owner - 2) | 1));
					if (Interlocked.CompareExchange(ref m_owner, value, owner, ref lockTaken) == owner)
					{
						return;
					}
					Thread.EndCriticalRegion();
				}
			}
		}
		if (millisecondsTimeout != -1 && TimeoutHelper.UpdateTimeOut(startTime, millisecondsTimeout) <= 0)
		{
			DecrementWaiters();
			return;
		}
		int num3 = 0;
		while (true)
		{
			owner = m_owner;
			if ((owner & 1) == 0)
			{
				Thread.BeginCriticalRegion();
				int value2 = (((owner & 0x7FFFFFFE) == 0) ? (owner | 1) : ((owner - 2) | 1));
				if (Interlocked.CompareExchange(ref m_owner, value2, owner, ref lockTaken) == owner)
				{
					return;
				}
				Thread.EndCriticalRegion();
			}
			if (num3 % 40 == 0)
			{
				Thread.Sleep(1);
			}
			else if (num3 % 10 == 0)
			{
				Thread.Sleep(0);
			}
			else
			{
				Thread.Yield();
			}
			if (num3 % 10 == 0 && millisecondsTimeout != -1 && TimeoutHelper.UpdateTimeOut(startTime, millisecondsTimeout) <= 0)
			{
				break;
			}
			num3++;
		}
		DecrementWaiters();
	}

	private void DecrementWaiters()
	{
		SpinWait spinWait = default(SpinWait);
		while (true)
		{
			int owner = m_owner;
			if ((owner & 0x7FFFFFFE) != 0 && Interlocked.CompareExchange(ref m_owner, owner - 2, owner) != owner)
			{
				spinWait.SpinOnce();
				continue;
			}
			break;
		}
	}

	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken)
	{
		int num = 0;
		int managedThreadId = Thread.CurrentThread.ManagedThreadId;
		if (m_owner == managedThreadId)
		{
			throw new LockRecursionException(Environment.GetResourceString("SpinLock_TryEnter_LockRecursionException"));
		}
		SpinWait spinWait = default(SpinWait);
		while (true)
		{
			spinWait.SpinOnce();
			if (m_owner == num)
			{
				Thread.BeginCriticalRegion();
				if (Interlocked.CompareExchange(ref m_owner, managedThreadId, num, ref lockTaken) == num)
				{
					break;
				}
				Thread.EndCriticalRegion();
			}
			switch (millisecondsTimeout)
			{
			case -1:
				continue;
			case 0:
				return;
			}
			if (spinWait.NextSpinWillYield && TimeoutHelper.UpdateTimeOut(startTime, millisecondsTimeout) <= 0)
			{
				return;
			}
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[__DynamicallyInvokable]
	public void Exit()
	{
		if ((m_owner & int.MinValue) == 0)
		{
			ExitSlowPath(useMemoryBarrier: true);
		}
		else
		{
			Interlocked.Decrement(ref m_owner);
		}
		Thread.EndCriticalRegion();
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[__DynamicallyInvokable]
	public void Exit(bool useMemoryBarrier)
	{
		if ((m_owner & int.MinValue) != 0 && !useMemoryBarrier)
		{
			int owner = m_owner;
			m_owner = owner & -2;
		}
		else
		{
			ExitSlowPath(useMemoryBarrier);
		}
		Thread.EndCriticalRegion();
	}

	private void ExitSlowPath(bool useMemoryBarrier)
	{
		bool flag = (m_owner & int.MinValue) == 0;
		if (flag && !IsHeldByCurrentThread)
		{
			throw new SynchronizationLockException(Environment.GetResourceString("SpinLock_Exit_SynchronizationLockException"));
		}
		if (useMemoryBarrier)
		{
			if (flag)
			{
				Interlocked.Exchange(ref m_owner, 0);
			}
			else
			{
				Interlocked.Decrement(ref m_owner);
			}
		}
		else if (flag)
		{
			m_owner = 0;
		}
		else
		{
			int owner = m_owner;
			m_owner = owner & -2;
		}
	}
}
