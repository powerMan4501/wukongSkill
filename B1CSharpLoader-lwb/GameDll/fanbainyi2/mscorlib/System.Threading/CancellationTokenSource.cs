using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Threading;

[ComVisible(false)]
[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public class CancellationTokenSource : IDisposable
{
	private static readonly CancellationTokenSource _staticSource_Set = new CancellationTokenSource(set: true);

	private static readonly CancellationTokenSource _staticSource_NotCancelable = new CancellationTokenSource(set: false);

	private static readonly int s_nLists = ((PlatformHelper.ProcessorCount > 24) ? 24 : PlatformHelper.ProcessorCount);

	private volatile ManualResetEvent m_kernelEvent;

	private volatile SparselyPopulatedArray<CancellationCallbackInfo>[] m_registeredCallbacksLists;

	private const int CANNOT_BE_CANCELED = 0;

	private const int NOT_CANCELED = 1;

	private const int NOTIFYING = 2;

	private const int NOTIFYINGCOMPLETE = 3;

	private volatile int m_state;

	private volatile int m_threadIDExecutingCallbacks = -1;

	private bool m_disposed;

	private CancellationTokenRegistration[] m_linkingRegistrations;

	private static readonly Action<object> s_LinkedTokenCancelDelegate = LinkedTokenCancelDelegate;

	private volatile CancellationCallbackInfo m_executingCallback;

	private volatile Timer m_timer;

	private static readonly TimerCallback s_timerCallback = TimerCallbackLogic;

	[__DynamicallyInvokable]
	public bool IsCancellationRequested
	{
		[__DynamicallyInvokable]
		get
		{
			return m_state >= 2;
		}
	}

	internal bool IsCancellationCompleted => m_state == 3;

	internal bool IsDisposed => m_disposed;

	internal int ThreadIDExecutingCallbacks
	{
		get
		{
			return m_threadIDExecutingCallbacks;
		}
		set
		{
			m_threadIDExecutingCallbacks = value;
		}
	}

	[__DynamicallyInvokable]
	public CancellationToken Token
	{
		[__DynamicallyInvokable]
		get
		{
			ThrowIfDisposed();
			return new CancellationToken(this);
		}
	}

	internal bool CanBeCanceled => m_state != 0;

	internal WaitHandle WaitHandle
	{
		get
		{
			ThrowIfDisposed();
			if (m_kernelEvent != null)
			{
				return m_kernelEvent;
			}
			ManualResetEvent manualResetEvent = new ManualResetEvent(initialState: false);
			if (Interlocked.CompareExchange(ref m_kernelEvent, manualResetEvent, null) != null)
			{
				((IDisposable)manualResetEvent).Dispose();
			}
			if (IsCancellationRequested)
			{
				m_kernelEvent.Set();
			}
			return m_kernelEvent;
		}
	}

	internal CancellationCallbackInfo ExecutingCallback => m_executingCallback;

	private static void LinkedTokenCancelDelegate(object source)
	{
		CancellationTokenSource cancellationTokenSource = source as CancellationTokenSource;
		cancellationTokenSource.Cancel();
	}

	[__DynamicallyInvokable]
	public CancellationTokenSource()
	{
		m_state = 1;
	}

	private CancellationTokenSource(bool set)
	{
		m_state = (set ? 3 : 0);
	}

	[__DynamicallyInvokable]
	public CancellationTokenSource(TimeSpan delay)
	{
		long num = (long)delay.TotalMilliseconds;
		if (num < -1 || num > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("delay");
		}
		InitializeWithTimer((int)num);
	}

	[__DynamicallyInvokable]
	public CancellationTokenSource(int millisecondsDelay)
	{
		if (millisecondsDelay < -1)
		{
			throw new ArgumentOutOfRangeException("millisecondsDelay");
		}
		InitializeWithTimer(millisecondsDelay);
	}

	private void InitializeWithTimer(int millisecondsDelay)
	{
		m_state = 1;
		m_timer = new Timer(s_timerCallback, this, millisecondsDelay, -1);
	}

	[__DynamicallyInvokable]
	public void Cancel()
	{
		Cancel(throwOnFirstException: false);
	}

	[__DynamicallyInvokable]
	public void Cancel(bool throwOnFirstException)
	{
		ThrowIfDisposed();
		NotifyCancellation(throwOnFirstException);
	}

	[__DynamicallyInvokable]
	public void CancelAfter(TimeSpan delay)
	{
		long num = (long)delay.TotalMilliseconds;
		if (num < -1 || num > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("delay");
		}
		CancelAfter((int)num);
	}

	[__DynamicallyInvokable]
	public void CancelAfter(int millisecondsDelay)
	{
		ThrowIfDisposed();
		if (millisecondsDelay < -1)
		{
			throw new ArgumentOutOfRangeException("millisecondsDelay");
		}
		if (IsCancellationRequested)
		{
			return;
		}
		if (m_timer == null)
		{
			Timer timer = new Timer(s_timerCallback, this, -1, -1);
			if (Interlocked.CompareExchange(ref m_timer, timer, null) != null)
			{
				timer.Dispose();
			}
		}
		try
		{
			m_timer.Change(millisecondsDelay, -1);
		}
		catch (ObjectDisposedException)
		{
		}
	}

	private static void TimerCallbackLogic(object obj)
	{
		CancellationTokenSource cancellationTokenSource = (CancellationTokenSource)obj;
		if (cancellationTokenSource.IsDisposed)
		{
			return;
		}
		try
		{
			cancellationTokenSource.Cancel();
		}
		catch (ObjectDisposedException)
		{
			if (!cancellationTokenSource.IsDisposed)
			{
				throw;
			}
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
		if (!disposing || m_disposed)
		{
			return;
		}
		if (m_timer != null)
		{
			m_timer.Dispose();
		}
		CancellationTokenRegistration[] linkingRegistrations = m_linkingRegistrations;
		if (linkingRegistrations != null)
		{
			m_linkingRegistrations = null;
			for (int i = 0; i < linkingRegistrations.Length; i++)
			{
				linkingRegistrations[i].Dispose();
			}
		}
		m_registeredCallbacksLists = null;
		if (m_kernelEvent != null)
		{
			m_kernelEvent.Close();
			m_kernelEvent = null;
		}
		m_disposed = true;
	}

	internal void ThrowIfDisposed()
	{
		if (m_disposed)
		{
			ThrowObjectDisposedException();
		}
	}

	private static void ThrowObjectDisposedException()
	{
		throw new ObjectDisposedException(null, Environment.GetResourceString("CancellationTokenSource_Disposed"));
	}

	internal static CancellationTokenSource InternalGetStaticSource(bool set)
	{
		if (!set)
		{
			return _staticSource_NotCancelable;
		}
		return _staticSource_Set;
	}

	internal CancellationTokenRegistration InternalRegister(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext)
	{
		if (AppContextSwitches.ThrowExceptionIfDisposedCancellationTokenSource)
		{
			ThrowIfDisposed();
		}
		if (!IsCancellationRequested)
		{
			if (m_disposed && !AppContextSwitches.ThrowExceptionIfDisposedCancellationTokenSource)
			{
				return default(CancellationTokenRegistration);
			}
			int num = Thread.CurrentThread.ManagedThreadId % s_nLists;
			CancellationCallbackInfo cancellationCallbackInfo = new CancellationCallbackInfo(callback, stateForCallback, targetSyncContext, executionContext, this);
			SparselyPopulatedArray<CancellationCallbackInfo>[] array = m_registeredCallbacksLists;
			if (array == null)
			{
				SparselyPopulatedArray<CancellationCallbackInfo>[] array2 = new SparselyPopulatedArray<CancellationCallbackInfo>[s_nLists];
				array = Interlocked.CompareExchange(ref m_registeredCallbacksLists, array2, null);
				if (array == null)
				{
					array = array2;
				}
			}
			SparselyPopulatedArray<CancellationCallbackInfo> sparselyPopulatedArray = Volatile.Read(ref array[num]);
			if (sparselyPopulatedArray == null)
			{
				SparselyPopulatedArray<CancellationCallbackInfo> value = new SparselyPopulatedArray<CancellationCallbackInfo>(4);
				Interlocked.CompareExchange(ref array[num], value, null);
				sparselyPopulatedArray = array[num];
			}
			SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo = sparselyPopulatedArray.Add(cancellationCallbackInfo);
			CancellationTokenRegistration result = new CancellationTokenRegistration(cancellationCallbackInfo, registrationInfo);
			if (!IsCancellationRequested)
			{
				return result;
			}
			if (!result.TryDeregister())
			{
				return result;
			}
		}
		callback(stateForCallback);
		return default(CancellationTokenRegistration);
	}

	private void NotifyCancellation(bool throwOnFirstException)
	{
		if (!IsCancellationRequested && Interlocked.CompareExchange(ref m_state, 2, 1) == 1)
		{
			m_timer?.Dispose();
			ThreadIDExecutingCallbacks = Thread.CurrentThread.ManagedThreadId;
			if (m_kernelEvent != null)
			{
				m_kernelEvent.Set();
			}
			ExecuteCallbackHandlers(throwOnFirstException);
		}
	}

	private void ExecuteCallbackHandlers(bool throwOnFirstException)
	{
		List<Exception> list = null;
		SparselyPopulatedArray<CancellationCallbackInfo>[] registeredCallbacksLists = m_registeredCallbacksLists;
		if (registeredCallbacksLists == null)
		{
			Interlocked.Exchange(ref m_state, 3);
			return;
		}
		try
		{
			for (int i = 0; i < registeredCallbacksLists.Length; i++)
			{
				SparselyPopulatedArray<CancellationCallbackInfo> sparselyPopulatedArray = Volatile.Read(ref registeredCallbacksLists[i]);
				if (sparselyPopulatedArray == null)
				{
					continue;
				}
				for (SparselyPopulatedArrayFragment<CancellationCallbackInfo> sparselyPopulatedArrayFragment = sparselyPopulatedArray.Tail; sparselyPopulatedArrayFragment != null; sparselyPopulatedArrayFragment = sparselyPopulatedArrayFragment.Prev)
				{
					for (int num = sparselyPopulatedArrayFragment.Length - 1; num >= 0; num--)
					{
						m_executingCallback = sparselyPopulatedArrayFragment[num];
						if (m_executingCallback != null)
						{
							CancellationCallbackCoreWorkArguments cancellationCallbackCoreWorkArguments = new CancellationCallbackCoreWorkArguments(sparselyPopulatedArrayFragment, num);
							try
							{
								if (m_executingCallback.TargetSyncContext != null)
								{
									m_executingCallback.TargetSyncContext.Send(CancellationCallbackCoreWork_OnSyncContext, cancellationCallbackCoreWorkArguments);
									ThreadIDExecutingCallbacks = Thread.CurrentThread.ManagedThreadId;
								}
								else
								{
									CancellationCallbackCoreWork(cancellationCallbackCoreWorkArguments);
								}
							}
							catch (Exception item)
							{
								if (throwOnFirstException)
								{
									throw;
								}
								if (list == null)
								{
									list = new List<Exception>();
								}
								list.Add(item);
							}
						}
					}
				}
			}
		}
		finally
		{
			m_state = 3;
			m_executingCallback = null;
			Thread.MemoryBarrier();
		}
		if (list == null)
		{
			return;
		}
		throw new AggregateException(list);
	}

	private void CancellationCallbackCoreWork_OnSyncContext(object obj)
	{
		CancellationCallbackCoreWork((CancellationCallbackCoreWorkArguments)obj);
	}

	private void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args)
	{
		CancellationCallbackInfo cancellationCallbackInfo = args.m_currArrayFragment.SafeAtomicRemove(args.m_currArrayIndex, m_executingCallback);
		if (cancellationCallbackInfo == m_executingCallback)
		{
			if (cancellationCallbackInfo.TargetExecutionContext != null)
			{
				cancellationCallbackInfo.CancellationTokenSource.ThreadIDExecutingCallbacks = Thread.CurrentThread.ManagedThreadId;
			}
			cancellationCallbackInfo.ExecuteCallback();
		}
	}

	[__DynamicallyInvokable]
	public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2)
	{
		CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
		bool canBeCanceled = token2.CanBeCanceled;
		if (token1.CanBeCanceled)
		{
			cancellationTokenSource.m_linkingRegistrations = new CancellationTokenRegistration[(!canBeCanceled) ? 1 : 2];
			cancellationTokenSource.m_linkingRegistrations[0] = token1.InternalRegisterWithoutEC(s_LinkedTokenCancelDelegate, cancellationTokenSource);
		}
		if (canBeCanceled)
		{
			int num = 1;
			if (cancellationTokenSource.m_linkingRegistrations == null)
			{
				cancellationTokenSource.m_linkingRegistrations = new CancellationTokenRegistration[1];
				num = 0;
			}
			cancellationTokenSource.m_linkingRegistrations[num] = token2.InternalRegisterWithoutEC(s_LinkedTokenCancelDelegate, cancellationTokenSource);
		}
		return cancellationTokenSource;
	}

	[__DynamicallyInvokable]
	public static CancellationTokenSource CreateLinkedTokenSource(params CancellationToken[] tokens)
	{
		if (tokens == null)
		{
			throw new ArgumentNullException("tokens");
		}
		if (tokens.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("CancellationToken_CreateLinkedToken_TokensIsEmpty"));
		}
		CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
		cancellationTokenSource.m_linkingRegistrations = new CancellationTokenRegistration[tokens.Length];
		for (int i = 0; i < tokens.Length; i++)
		{
			if (tokens[i].CanBeCanceled)
			{
				cancellationTokenSource.m_linkingRegistrations[i] = tokens[i].InternalRegisterWithoutEC(s_LinkedTokenCancelDelegate, cancellationTokenSource);
			}
		}
		return cancellationTokenSource;
	}

	internal void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo)
	{
		SpinWait spinWait = default(SpinWait);
		while (ExecutingCallback == callbackInfo)
		{
			spinWait.SpinOnce();
		}
	}
}
