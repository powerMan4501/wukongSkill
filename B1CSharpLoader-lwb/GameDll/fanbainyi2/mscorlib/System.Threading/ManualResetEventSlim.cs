using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Threading;

[ComVisible(false)]
[DebuggerDisplay("Set = {IsSet}")]
[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public class ManualResetEventSlim : IDisposable
{
	private const int DEFAULT_SPIN_SP = 1;

	private const int DEFAULT_SPIN_MP = 10;

	private volatile object m_lock;

	private volatile ManualResetEvent m_eventObj;

	private volatile int m_combinedState;

	private const int SignalledState_BitMask = int.MinValue;

	private const int SignalledState_ShiftCount = 31;

	private const int Dispose_BitMask = 1073741824;

	private const int SpinCountState_BitMask = 1073217536;

	private const int SpinCountState_ShiftCount = 19;

	private const int SpinCountState_MaxValue = 2047;

	private const int NumWaitersState_BitMask = 524287;

	private const int NumWaitersState_ShiftCount = 0;

	private const int NumWaitersState_MaxValue = 524287;

	private static Action<object> s_cancellationTokenCallback = CancellationTokenCallback;

	[__DynamicallyInvokable]
	public WaitHandle WaitHandle
	{
		[__DynamicallyInvokable]
		get
		{
			ThrowIfDisposed();
			if (m_eventObj == null)
			{
				LazyInitializeEvent();
			}
			return m_eventObj;
		}
	}

	[__DynamicallyInvokable]
	public bool IsSet
	{
		[__DynamicallyInvokable]
		get
		{
			return ExtractStatePortion(m_combinedState, int.MinValue) != 0;
		}
		private set
		{
			UpdateStateAtomically((value ? 1 : 0) << 31, int.MinValue);
		}
	}

	[__DynamicallyInvokable]
	public int SpinCount
	{
		[__DynamicallyInvokable]
		get
		{
			return ExtractStatePortionAndShiftRight(m_combinedState, 1073217536, 19);
		}
		private set
		{
			m_combinedState = (m_combinedState & -1073217537) | (value << 19);
		}
	}

	private int Waiters
	{
		get
		{
			return ExtractStatePortionAndShiftRight(m_combinedState, 524287, 0);
		}
		set
		{
			if (value >= 524287)
			{
				throw new InvalidOperationException(string.Format(Environment.GetResourceString("ManualResetEventSlim_ctor_TooManyWaiters"), 524287));
			}
			UpdateStateAtomically(value, 524287);
		}
	}

	[__DynamicallyInvokable]
	public ManualResetEventSlim()
		: this(initialState: false)
	{
	}

	[__DynamicallyInvokable]
	public ManualResetEventSlim(bool initialState)
	{
		Initialize(initialState, 10);
	}

	[__DynamicallyInvokable]
	public ManualResetEventSlim(bool initialState, int spinCount)
	{
		if (spinCount < 0)
		{
			throw new ArgumentOutOfRangeException("spinCount");
		}
		if (spinCount > 2047)
		{
			throw new ArgumentOutOfRangeException("spinCount", string.Format(Environment.GetResourceString("ManualResetEventSlim_ctor_SpinCountOutOfRange"), 2047));
		}
		Initialize(initialState, spinCount);
	}

	private void Initialize(bool initialState, int spinCount)
	{
		m_combinedState = (initialState ? int.MinValue : 0);
		SpinCount = (PlatformHelper.IsSingleProcessor ? 1 : spinCount);
	}

	private void EnsureLockObjectCreated()
	{
		if (m_lock == null)
		{
			object value = new object();
			Interlocked.CompareExchange(ref m_lock, value, null);
		}
	}

	private bool LazyInitializeEvent()
	{
		bool isSet = IsSet;
		ManualResetEvent manualResetEvent = new ManualResetEvent(isSet);
		if (Interlocked.CompareExchange(ref m_eventObj, manualResetEvent, null) != null)
		{
			manualResetEvent.Close();
			return false;
		}
		bool isSet2 = IsSet;
		if (isSet2 != isSet)
		{
			lock (manualResetEvent)
			{
				if (m_eventObj == manualResetEvent)
				{
					manualResetEvent.Set();
				}
			}
		}
		return true;
	}

	[__DynamicallyInvokable]
	public void Set()
	{
		Set(duringCancellation: false);
	}

	private void Set(bool duringCancellation)
	{
		IsSet = true;
		if (Waiters > 0)
		{
			lock (m_lock)
			{
				Monitor.PulseAll(m_lock);
			}
		}
		ManualResetEvent eventObj = m_eventObj;
		if (eventObj == null || duringCancellation)
		{
			return;
		}
		lock (eventObj)
		{
			if (m_eventObj != null)
			{
				m_eventObj.Set();
			}
		}
	}

	[__DynamicallyInvokable]
	public void Reset()
	{
		ThrowIfDisposed();
		if (m_eventObj != null)
		{
			m_eventObj.Reset();
		}
		IsSet = false;
	}

	[__DynamicallyInvokable]
	public void Wait()
	{
		Wait(-1, default(CancellationToken));
	}

	[__DynamicallyInvokable]
	public void Wait(CancellationToken cancellationToken)
	{
		Wait(-1, cancellationToken);
	}

	[__DynamicallyInvokable]
	public bool Wait(TimeSpan timeout)
	{
		long num = (long)timeout.TotalMilliseconds;
		if (num < -1 || num > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("timeout");
		}
		return Wait((int)num, default(CancellationToken));
	}

	[__DynamicallyInvokable]
	public bool Wait(TimeSpan timeout, CancellationToken cancellationToken)
	{
		long num = (long)timeout.TotalMilliseconds;
		if (num < -1 || num > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("timeout");
		}
		return Wait((int)num, cancellationToken);
	}

	[__DynamicallyInvokable]
	public bool Wait(int millisecondsTimeout)
	{
		return Wait(millisecondsTimeout, default(CancellationToken));
	}

	[__DynamicallyInvokable]
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
	{
		ThrowIfDisposed();
		cancellationToken.ThrowIfCancellationRequested();
		if (millisecondsTimeout < -1)
		{
			throw new ArgumentOutOfRangeException("millisecondsTimeout");
		}
		if (!IsSet)
		{
			if (millisecondsTimeout == 0)
			{
				return false;
			}
			uint startTime = 0u;
			bool flag = false;
			int num = millisecondsTimeout;
			if (millisecondsTimeout != -1)
			{
				startTime = TimeoutHelper.GetTime();
				flag = true;
			}
			int num2 = 10;
			int num3 = 5;
			int num4 = 20;
			int spinCount = SpinCount;
			for (int i = 0; i < spinCount; i++)
			{
				if (IsSet)
				{
					return true;
				}
				if (i < num2)
				{
					if (i == num2 / 2)
					{
						Thread.Yield();
					}
					else
					{
						Thread.SpinWait(4 << i);
					}
				}
				else if (i % num4 == 0)
				{
					Thread.Sleep(1);
				}
				else if (i % num3 == 0)
				{
					Thread.Sleep(0);
				}
				else
				{
					Thread.Yield();
				}
				if (i >= 100 && i % 10 == 0)
				{
					cancellationToken.ThrowIfCancellationRequested();
				}
			}
			EnsureLockObjectCreated();
			using (cancellationToken.InternalRegisterWithoutEC(s_cancellationTokenCallback, this))
			{
				lock (m_lock)
				{
					while (!IsSet)
					{
						cancellationToken.ThrowIfCancellationRequested();
						if (flag)
						{
							num = TimeoutHelper.UpdateTimeOut(startTime, millisecondsTimeout);
							if (num <= 0)
							{
								return false;
							}
						}
						Waiters++;
						if (IsSet)
						{
							Waiters--;
							return true;
						}
						try
						{
							if (!Monitor.Wait(m_lock, num))
							{
								return false;
							}
						}
						finally
						{
							Waiters--;
						}
					}
				}
			}
		}
		return true;
	}

	[__DynamicallyInvokable]
	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[__DynamicallyInvokable]
	protected virtual void Dispose(bool disposing)
	{
		if ((m_combinedState & 0x40000000) != 0)
		{
			return;
		}
		m_combinedState |= 1073741824;
		if (!disposing)
		{
			return;
		}
		ManualResetEvent eventObj = m_eventObj;
		if (eventObj == null)
		{
			return;
		}
		lock (eventObj)
		{
			eventObj.Close();
			m_eventObj = null;
		}
	}

	private void ThrowIfDisposed()
	{
		if ((m_combinedState & 0x40000000) != 0)
		{
			throw new ObjectDisposedException(Environment.GetResourceString("ManualResetEventSlim_Disposed"));
		}
	}

	private static void CancellationTokenCallback(object obj)
	{
		ManualResetEventSlim manualResetEventSlim = obj as ManualResetEventSlim;
		lock (manualResetEventSlim.m_lock)
		{
			Monitor.PulseAll(manualResetEventSlim.m_lock);
		}
	}

	private void UpdateStateAtomically(int newBits, int updateBitsMask)
	{
		SpinWait spinWait = default(SpinWait);
		while (true)
		{
			int combinedState = m_combinedState;
			int value = (combinedState & ~updateBitsMask) | newBits;
			if (Interlocked.CompareExchange(ref m_combinedState, value, combinedState) == combinedState)
			{
				break;
			}
			spinWait.SpinOnce();
		}
	}

	private static int ExtractStatePortionAndShiftRight(int state, int mask, int rightBitShiftCount)
	{
		return (state & mask) >>> rightBitShiftCount;
	}

	private static int ExtractStatePortion(int state, int mask)
	{
		return state & mask;
	}
}
