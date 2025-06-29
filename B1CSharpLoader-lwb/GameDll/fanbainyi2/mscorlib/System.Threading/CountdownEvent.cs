using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Threading;

[ComVisible(false)]
[DebuggerDisplay("Initial Count={InitialCount}, Current Count={CurrentCount}")]
[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public class CountdownEvent : IDisposable
{
	private int m_initialCount;

	private volatile int m_currentCount;

	private ManualResetEventSlim m_event;

	private volatile bool m_disposed;

	[__DynamicallyInvokable]
	public int CurrentCount
	{
		[__DynamicallyInvokable]
		get
		{
			int currentCount = m_currentCount;
			if (currentCount >= 0)
			{
				return currentCount;
			}
			return 0;
		}
	}

	[__DynamicallyInvokable]
	public int InitialCount
	{
		[__DynamicallyInvokable]
		get
		{
			return m_initialCount;
		}
	}

	[__DynamicallyInvokable]
	public bool IsSet
	{
		[__DynamicallyInvokable]
		get
		{
			return m_currentCount <= 0;
		}
	}

	[__DynamicallyInvokable]
	public WaitHandle WaitHandle
	{
		[__DynamicallyInvokable]
		get
		{
			ThrowIfDisposed();
			return m_event.WaitHandle;
		}
	}

	[__DynamicallyInvokable]
	public CountdownEvent(int initialCount)
	{
		if (initialCount < 0)
		{
			throw new ArgumentOutOfRangeException("initialCount");
		}
		m_initialCount = initialCount;
		m_currentCount = initialCount;
		m_event = new ManualResetEventSlim();
		if (initialCount == 0)
		{
			m_event.Set();
		}
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
		if (disposing)
		{
			m_event.Dispose();
			m_disposed = true;
		}
	}

	[__DynamicallyInvokable]
	public bool Signal()
	{
		ThrowIfDisposed();
		if (m_currentCount <= 0)
		{
			throw new InvalidOperationException(Environment.GetResourceString("CountdownEvent_Decrement_BelowZero"));
		}
		int num = Interlocked.Decrement(ref m_currentCount);
		if (num == 0)
		{
			m_event.Set();
			return true;
		}
		if (num < 0)
		{
			throw new InvalidOperationException(Environment.GetResourceString("CountdownEvent_Decrement_BelowZero"));
		}
		return false;
	}

	[__DynamicallyInvokable]
	public bool Signal(int signalCount)
	{
		if (signalCount <= 0)
		{
			throw new ArgumentOutOfRangeException("signalCount");
		}
		ThrowIfDisposed();
		SpinWait spinWait = default(SpinWait);
		int currentCount;
		while (true)
		{
			currentCount = m_currentCount;
			if (currentCount < signalCount)
			{
				throw new InvalidOperationException(Environment.GetResourceString("CountdownEvent_Decrement_BelowZero"));
			}
			if (Interlocked.CompareExchange(ref m_currentCount, currentCount - signalCount, currentCount) == currentCount)
			{
				break;
			}
			spinWait.SpinOnce();
		}
		if (currentCount == signalCount)
		{
			m_event.Set();
			return true;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public void AddCount()
	{
		AddCount(1);
	}

	[__DynamicallyInvokable]
	public bool TryAddCount()
	{
		return TryAddCount(1);
	}

	[__DynamicallyInvokable]
	public void AddCount(int signalCount)
	{
		if (!TryAddCount(signalCount))
		{
			throw new InvalidOperationException(Environment.GetResourceString("CountdownEvent_Increment_AlreadyZero"));
		}
	}

	[__DynamicallyInvokable]
	public bool TryAddCount(int signalCount)
	{
		if (signalCount <= 0)
		{
			throw new ArgumentOutOfRangeException("signalCount");
		}
		ThrowIfDisposed();
		SpinWait spinWait = default(SpinWait);
		while (true)
		{
			int currentCount = m_currentCount;
			if (currentCount <= 0)
			{
				return false;
			}
			if (currentCount > int.MaxValue - signalCount)
			{
				throw new InvalidOperationException(Environment.GetResourceString("CountdownEvent_Increment_AlreadyMax"));
			}
			if (Interlocked.CompareExchange(ref m_currentCount, currentCount + signalCount, currentCount) == currentCount)
			{
				break;
			}
			spinWait.SpinOnce();
		}
		return true;
	}

	[__DynamicallyInvokable]
	public void Reset()
	{
		Reset(m_initialCount);
	}

	[__DynamicallyInvokable]
	public void Reset(int count)
	{
		ThrowIfDisposed();
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		m_currentCount = count;
		m_initialCount = count;
		if (count == 0)
		{
			m_event.Set();
		}
		else
		{
			m_event.Reset();
		}
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
		if (millisecondsTimeout < -1)
		{
			throw new ArgumentOutOfRangeException("millisecondsTimeout");
		}
		ThrowIfDisposed();
		cancellationToken.ThrowIfCancellationRequested();
		bool flag = IsSet;
		if (!flag)
		{
			flag = m_event.Wait(millisecondsTimeout, cancellationToken);
		}
		return flag;
	}

	private void ThrowIfDisposed()
	{
		if (m_disposed)
		{
			throw new ObjectDisposedException("CountdownEvent");
		}
	}
}
