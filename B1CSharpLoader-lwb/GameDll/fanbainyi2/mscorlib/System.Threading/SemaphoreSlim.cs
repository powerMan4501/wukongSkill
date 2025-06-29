using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace System.Threading;

[ComVisible(false)]
[DebuggerDisplay("Current Count = {m_currentCount}")]
[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public class SemaphoreSlim : IDisposable
{
	private sealed class TaskNode : Task<bool>, IThreadPoolWorkItem
	{
		internal TaskNode Prev;

		internal TaskNode Next;

		internal TaskNode()
		{
		}

		[SecurityCritical]
		void IThreadPoolWorkItem.ExecuteWorkItem()
		{
			bool flag = TrySetResult(result: true);
		}

		[SecurityCritical]
		void IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae)
		{
		}
	}

	private volatile int m_currentCount;

	private readonly int m_maxCount;

	private volatile int m_waitCount;

	private object m_lockObj;

	private volatile ManualResetEvent m_waitHandle;

	private TaskNode m_asyncHead;

	private TaskNode m_asyncTail;

	private static readonly Task<bool> s_trueTask = new Task<bool>(canceled: false, result: true, (TaskCreationOptions)16384, default(CancellationToken));

	private const int NO_MAXIMUM = int.MaxValue;

	private static Action<object> s_cancellationTokenCanceledEventHandler = CancellationTokenCanceledEventHandler;

	[__DynamicallyInvokable]
	public int CurrentCount
	{
		[__DynamicallyInvokable]
		get
		{
			return m_currentCount;
		}
	}

	[__DynamicallyInvokable]
	public WaitHandle AvailableWaitHandle
	{
		[__DynamicallyInvokable]
		get
		{
			CheckDispose();
			if (m_waitHandle != null)
			{
				return m_waitHandle;
			}
			lock (m_lockObj)
			{
				if (m_waitHandle == null)
				{
					m_waitHandle = new ManualResetEvent(m_currentCount != 0);
				}
			}
			return m_waitHandle;
		}
	}

	[__DynamicallyInvokable]
	public SemaphoreSlim(int initialCount)
		: this(initialCount, int.MaxValue)
	{
	}

	[__DynamicallyInvokable]
	public SemaphoreSlim(int initialCount, int maxCount)
	{
		if (initialCount < 0 || initialCount > maxCount)
		{
			throw new ArgumentOutOfRangeException("initialCount", initialCount, GetResourceString("SemaphoreSlim_ctor_InitialCountWrong"));
		}
		if (maxCount <= 0)
		{
			throw new ArgumentOutOfRangeException("maxCount", maxCount, GetResourceString("SemaphoreSlim_ctor_MaxCountWrong"));
		}
		m_maxCount = maxCount;
		m_lockObj = new object();
		m_currentCount = initialCount;
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
			throw new ArgumentOutOfRangeException("timeout", timeout, GetResourceString("SemaphoreSlim_Wait_TimeoutWrong"));
		}
		return Wait((int)timeout.TotalMilliseconds, default(CancellationToken));
	}

	[__DynamicallyInvokable]
	public bool Wait(TimeSpan timeout, CancellationToken cancellationToken)
	{
		long num = (long)timeout.TotalMilliseconds;
		if (num < -1 || num > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("timeout", timeout, GetResourceString("SemaphoreSlim_Wait_TimeoutWrong"));
		}
		return Wait((int)timeout.TotalMilliseconds, cancellationToken);
	}

	[__DynamicallyInvokable]
	public bool Wait(int millisecondsTimeout)
	{
		return Wait(millisecondsTimeout, default(CancellationToken));
	}

	[__DynamicallyInvokable]
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
	{
		CheckDispose();
		if (millisecondsTimeout < -1)
		{
			throw new ArgumentOutOfRangeException("totalMilliSeconds", millisecondsTimeout, GetResourceString("SemaphoreSlim_Wait_TimeoutWrong"));
		}
		cancellationToken.ThrowIfCancellationRequested();
		uint startTime = 0u;
		if (millisecondsTimeout != -1 && millisecondsTimeout > 0)
		{
			startTime = TimeoutHelper.GetTime();
		}
		bool flag = false;
		Task<bool> task = null;
		bool lockTaken = false;
		CancellationTokenRegistration cancellationTokenRegistration = cancellationToken.InternalRegisterWithoutEC(s_cancellationTokenCanceledEventHandler, this);
		try
		{
			SpinWait spinWait = default(SpinWait);
			while (m_currentCount == 0 && !spinWait.NextSpinWillYield)
			{
				spinWait.SpinOnce();
			}
			try
			{
			}
			finally
			{
				Monitor.Enter(m_lockObj, ref lockTaken);
				if (lockTaken)
				{
					m_waitCount++;
				}
			}
			if (m_asyncHead != null)
			{
				task = WaitAsync(millisecondsTimeout, cancellationToken);
			}
			else
			{
				OperationCanceledException ex = null;
				if (m_currentCount == 0)
				{
					if (millisecondsTimeout == 0)
					{
						return false;
					}
					try
					{
						flag = WaitUntilCountOrTimeout(millisecondsTimeout, startTime, cancellationToken);
					}
					catch (OperationCanceledException ex2)
					{
						ex = ex2;
					}
				}
				if (m_currentCount > 0)
				{
					flag = true;
					m_currentCount--;
				}
				else if (ex != null)
				{
					throw ex;
				}
				if (m_waitHandle != null && m_currentCount == 0)
				{
					m_waitHandle.Reset();
				}
			}
		}
		finally
		{
			if (lockTaken)
			{
				m_waitCount--;
				Monitor.Exit(m_lockObj);
			}
			cancellationTokenRegistration.Dispose();
		}
		return task?.GetAwaiter().GetResult() ?? flag;
	}

	private bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken)
	{
		int num = -1;
		while (m_currentCount == 0)
		{
			cancellationToken.ThrowIfCancellationRequested();
			if (millisecondsTimeout != -1)
			{
				num = TimeoutHelper.UpdateTimeOut(startTime, millisecondsTimeout);
				if (num <= 0)
				{
					return false;
				}
			}
			if (!Monitor.Wait(m_lockObj, num))
			{
				return false;
			}
		}
		return true;
	}

	[__DynamicallyInvokable]
	public Task WaitAsync()
	{
		return WaitAsync(-1, default(CancellationToken));
	}

	[__DynamicallyInvokable]
	public Task WaitAsync(CancellationToken cancellationToken)
	{
		return WaitAsync(-1, cancellationToken);
	}

	[__DynamicallyInvokable]
	public Task<bool> WaitAsync(int millisecondsTimeout)
	{
		return WaitAsync(millisecondsTimeout, default(CancellationToken));
	}

	[__DynamicallyInvokable]
	public Task<bool> WaitAsync(TimeSpan timeout)
	{
		return WaitAsync(timeout, default(CancellationToken));
	}

	[__DynamicallyInvokable]
	public Task<bool> WaitAsync(TimeSpan timeout, CancellationToken cancellationToken)
	{
		long num = (long)timeout.TotalMilliseconds;
		if (num < -1 || num > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("timeout", timeout, GetResourceString("SemaphoreSlim_Wait_TimeoutWrong"));
		}
		return WaitAsync((int)timeout.TotalMilliseconds, cancellationToken);
	}

	[__DynamicallyInvokable]
	public Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken)
	{
		CheckDispose();
		if (millisecondsTimeout < -1)
		{
			throw new ArgumentOutOfRangeException("totalMilliSeconds", millisecondsTimeout, GetResourceString("SemaphoreSlim_Wait_TimeoutWrong"));
		}
		if (cancellationToken.IsCancellationRequested)
		{
			return Task.FromCancellation<bool>(cancellationToken);
		}
		lock (m_lockObj)
		{
			if (m_currentCount > 0)
			{
				m_currentCount--;
				if (m_waitHandle != null && m_currentCount == 0)
				{
					m_waitHandle.Reset();
				}
				return s_trueTask;
			}
			TaskNode taskNode = CreateAndAddAsyncWaiter();
			return (millisecondsTimeout == -1 && !cancellationToken.CanBeCanceled) ? taskNode : WaitUntilCountOrTimeoutAsync(taskNode, millisecondsTimeout, cancellationToken);
		}
	}

	private TaskNode CreateAndAddAsyncWaiter()
	{
		TaskNode taskNode = new TaskNode();
		if (m_asyncHead == null)
		{
			m_asyncHead = taskNode;
			m_asyncTail = taskNode;
		}
		else
		{
			m_asyncTail.Next = taskNode;
			taskNode.Prev = m_asyncTail;
			m_asyncTail = taskNode;
		}
		return taskNode;
	}

	private bool RemoveAsyncWaiter(TaskNode task)
	{
		bool result = m_asyncHead == task || task.Prev != null;
		if (task.Next != null)
		{
			task.Next.Prev = task.Prev;
		}
		if (task.Prev != null)
		{
			task.Prev.Next = task.Next;
		}
		if (m_asyncHead == task)
		{
			m_asyncHead = task.Next;
		}
		if (m_asyncTail == task)
		{
			m_asyncTail = task.Prev;
		}
		task.Next = (task.Prev = null);
		return result;
	}

	private async Task<bool> WaitUntilCountOrTimeoutAsync(TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken)
	{
		using (CancellationTokenSource cts = (cancellationToken.CanBeCanceled ? CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, default(CancellationToken)) : new CancellationTokenSource()))
		{
			Task<Task> task = Task.WhenAny(asyncWaiter, Task.Delay(millisecondsTimeout, cts.Token));
			if (asyncWaiter == await task.ConfigureAwait(continueOnCapturedContext: false))
			{
				cts.Cancel();
				return true;
			}
		}
		lock (m_lockObj)
		{
			if (RemoveAsyncWaiter(asyncWaiter))
			{
				cancellationToken.ThrowIfCancellationRequested();
				return false;
			}
		}
		return await asyncWaiter.ConfigureAwait(continueOnCapturedContext: false);
	}

	[__DynamicallyInvokable]
	public int Release()
	{
		return Release(1);
	}

	[__DynamicallyInvokable]
	public int Release(int releaseCount)
	{
		CheckDispose();
		if (releaseCount < 1)
		{
			throw new ArgumentOutOfRangeException("releaseCount", releaseCount, GetResourceString("SemaphoreSlim_Release_CountWrong"));
		}
		int num;
		lock (m_lockObj)
		{
			int currentCount = m_currentCount;
			num = currentCount;
			if (m_maxCount - currentCount < releaseCount)
			{
				throw new SemaphoreFullException();
			}
			currentCount += releaseCount;
			int waitCount = m_waitCount;
			if (currentCount == 1 || waitCount == 1)
			{
				Monitor.Pulse(m_lockObj);
			}
			else if (waitCount > 1)
			{
				Monitor.PulseAll(m_lockObj);
			}
			if (m_asyncHead != null)
			{
				int num2 = currentCount - waitCount;
				while (num2 > 0 && m_asyncHead != null)
				{
					currentCount--;
					num2--;
					TaskNode asyncHead = m_asyncHead;
					RemoveAsyncWaiter(asyncHead);
					QueueWaiterTask(asyncHead);
				}
			}
			m_currentCount = currentCount;
			if (m_waitHandle != null && num == 0 && currentCount > 0)
			{
				m_waitHandle.Set();
			}
		}
		return num;
	}

	[SecuritySafeCritical]
	private static void QueueWaiterTask(TaskNode waiterTask)
	{
		ThreadPool.UnsafeQueueCustomWorkItem(waiterTask, forceGlobal: false);
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
			if (m_waitHandle != null)
			{
				m_waitHandle.Close();
				m_waitHandle = null;
			}
			m_lockObj = null;
			m_asyncHead = null;
			m_asyncTail = null;
		}
	}

	private static void CancellationTokenCanceledEventHandler(object obj)
	{
		SemaphoreSlim semaphoreSlim = obj as SemaphoreSlim;
		lock (semaphoreSlim.m_lockObj)
		{
			Monitor.PulseAll(semaphoreSlim.m_lockObj);
		}
	}

	private void CheckDispose()
	{
		if (m_lockObj == null)
		{
			throw new ObjectDisposedException(null, GetResourceString("SemaphoreSlim_Disposed"));
		}
	}

	private static string GetResourceString(string str)
	{
		return Environment.GetResourceString(str);
	}
}
