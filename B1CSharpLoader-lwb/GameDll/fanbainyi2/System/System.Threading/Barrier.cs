using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace System.Threading;

[ComVisible(false)]
[DebuggerDisplay("Participant Count={ParticipantCount},Participants Remaining={ParticipantsRemaining}")]
[global::__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public class Barrier : IDisposable
{
	private volatile int m_currentTotalCount;

	private const int CURRENT_MASK = 2147418112;

	private const int TOTAL_MASK = 32767;

	private const int SENSE_MASK = int.MinValue;

	private const int MAX_PARTICIPANTS = 32767;

	private long m_currentPhase;

	private bool m_disposed;

	private ManualResetEventSlim m_oddEvent;

	private ManualResetEventSlim m_evenEvent;

	private ExecutionContext m_ownerThreadContext;

	[SecurityCritical]
	private static ContextCallback s_invokePostPhaseAction;

	private Action<Barrier> m_postPhaseAction;

	private Exception m_exception;

	private int m_actionCallerID;

	[global::__DynamicallyInvokable]
	public int ParticipantsRemaining
	{
		[global::__DynamicallyInvokable]
		get
		{
			int currentTotalCount = m_currentTotalCount;
			int num = currentTotalCount & 0x7FFF;
			int num2 = (currentTotalCount & 0x7FFF0000) >> 16;
			return num - num2;
		}
	}

	[global::__DynamicallyInvokable]
	public int ParticipantCount
	{
		[global::__DynamicallyInvokable]
		get
		{
			return m_currentTotalCount & 0x7FFF;
		}
	}

	[global::__DynamicallyInvokable]
	public long CurrentPhaseNumber
	{
		[global::__DynamicallyInvokable]
		get
		{
			return Volatile.Read(ref m_currentPhase);
		}
		internal set
		{
			Volatile.Write(ref m_currentPhase, value);
		}
	}

	[global::__DynamicallyInvokable]
	public Barrier(int participantCount)
		: this(participantCount, null)
	{
	}

	[global::__DynamicallyInvokable]
	public Barrier(int participantCount, Action<Barrier> postPhaseAction)
	{
		if (participantCount < 0 || participantCount > 32767)
		{
			throw new ArgumentOutOfRangeException("participantCount", participantCount, SR.GetString("Barrier_ctor_ArgumentOutOfRange"));
		}
		m_currentTotalCount = participantCount;
		m_postPhaseAction = postPhaseAction;
		m_oddEvent = new ManualResetEventSlim(initialState: true);
		m_evenEvent = new ManualResetEventSlim(initialState: false);
		if (postPhaseAction != null && !ExecutionContext.IsFlowSuppressed())
		{
			m_ownerThreadContext = ExecutionContext.Capture();
		}
		m_actionCallerID = 0;
	}

	private void GetCurrentTotal(int currentTotal, out int current, out int total, out bool sense)
	{
		total = currentTotal & 0x7FFF;
		current = (currentTotal & 0x7FFF0000) >> 16;
		sense = (currentTotal & int.MinValue) == 0;
	}

	private bool SetCurrentTotal(int currentTotal, int current, int total, bool sense)
	{
		int num = (current << 16) | total;
		if (!sense)
		{
			num |= int.MinValue;
		}
		return Interlocked.CompareExchange(ref m_currentTotalCount, num, currentTotal) == currentTotal;
	}

	[global::__DynamicallyInvokable]
	public long AddParticipant()
	{
		try
		{
			return AddParticipants(1);
		}
		catch (ArgumentOutOfRangeException)
		{
			throw new InvalidOperationException(SR.GetString("Barrier_AddParticipants_Overflow_ArgumentOutOfRange"));
		}
	}

	[global::__DynamicallyInvokable]
	public long AddParticipants(int participantCount)
	{
		ThrowIfDisposed();
		if (participantCount < 1)
		{
			throw new ArgumentOutOfRangeException("participantCount", participantCount, SR.GetString("Barrier_AddParticipants_NonPositive_ArgumentOutOfRange"));
		}
		if (participantCount > 32767)
		{
			throw new ArgumentOutOfRangeException("participantCount", SR.GetString("Barrier_AddParticipants_Overflow_ArgumentOutOfRange"));
		}
		if (m_actionCallerID != 0 && Thread.CurrentThread.ManagedThreadId == m_actionCallerID)
		{
			throw new InvalidOperationException(SR.GetString("Barrier_InvalidOperation_CalledFromPHA"));
		}
		SpinWait spinWait = default(SpinWait);
		long num = 0L;
		bool sense;
		while (true)
		{
			int currentTotalCount = m_currentTotalCount;
			GetCurrentTotal(currentTotalCount, out var current, out var total, out sense);
			if (participantCount + total > 32767)
			{
				throw new ArgumentOutOfRangeException("participantCount", SR.GetString("Barrier_AddParticipants_Overflow_ArgumentOutOfRange"));
			}
			if (SetCurrentTotal(currentTotalCount, current, total + participantCount, sense))
			{
				break;
			}
			spinWait.SpinOnce();
		}
		long currentPhaseNumber = CurrentPhaseNumber;
		num = ((sense != (currentPhaseNumber % 2 == 0)) ? (currentPhaseNumber + 1) : currentPhaseNumber);
		if (num != currentPhaseNumber)
		{
			if (sense)
			{
				m_oddEvent.Wait();
			}
			else
			{
				m_evenEvent.Wait();
			}
		}
		else if (sense && m_evenEvent.IsSet)
		{
			m_evenEvent.Reset();
		}
		else if (!sense && m_oddEvent.IsSet)
		{
			m_oddEvent.Reset();
		}
		return num;
	}

	[global::__DynamicallyInvokable]
	public void RemoveParticipant()
	{
		RemoveParticipants(1);
	}

	[global::__DynamicallyInvokable]
	public void RemoveParticipants(int participantCount)
	{
		ThrowIfDisposed();
		if (participantCount < 1)
		{
			throw new ArgumentOutOfRangeException("participantCount", participantCount, SR.GetString("Barrier_RemoveParticipants_NonPositive_ArgumentOutOfRange"));
		}
		if (m_actionCallerID != 0 && Thread.CurrentThread.ManagedThreadId == m_actionCallerID)
		{
			throw new InvalidOperationException(SR.GetString("Barrier_InvalidOperation_CalledFromPHA"));
		}
		SpinWait spinWait = default(SpinWait);
		while (true)
		{
			int currentTotalCount = m_currentTotalCount;
			GetCurrentTotal(currentTotalCount, out var current, out var total, out var sense);
			if (total < participantCount)
			{
				throw new ArgumentOutOfRangeException("participantCount", SR.GetString("Barrier_RemoveParticipants_ArgumentOutOfRange"));
			}
			if (total - participantCount < current)
			{
				throw new InvalidOperationException(SR.GetString("Barrier_RemoveParticipants_InvalidOperation"));
			}
			int num = total - participantCount;
			if (num > 0 && current == num)
			{
				if (SetCurrentTotal(currentTotalCount, 0, total - participantCount, !sense))
				{
					FinishPhase(sense);
					break;
				}
			}
			else if (SetCurrentTotal(currentTotalCount, current, total - participantCount, sense))
			{
				break;
			}
			spinWait.SpinOnce();
		}
	}

	[global::__DynamicallyInvokable]
	public void SignalAndWait()
	{
		SignalAndWait(default(CancellationToken));
	}

	[global::__DynamicallyInvokable]
	public void SignalAndWait(CancellationToken cancellationToken)
	{
		SignalAndWait(-1, cancellationToken);
	}

	[global::__DynamicallyInvokable]
	public bool SignalAndWait(TimeSpan timeout)
	{
		return SignalAndWait(timeout, default(CancellationToken));
	}

	[global::__DynamicallyInvokable]
	public bool SignalAndWait(TimeSpan timeout, CancellationToken cancellationToken)
	{
		long num = (long)timeout.TotalMilliseconds;
		if (num < -1 || num > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("timeout", timeout, SR.GetString("Barrier_SignalAndWait_ArgumentOutOfRange"));
		}
		return SignalAndWait((int)timeout.TotalMilliseconds, cancellationToken);
	}

	[global::__DynamicallyInvokable]
	public bool SignalAndWait(int millisecondsTimeout)
	{
		return SignalAndWait(millisecondsTimeout, default(CancellationToken));
	}

	[global::__DynamicallyInvokable]
	public bool SignalAndWait(int millisecondsTimeout, CancellationToken cancellationToken)
	{
		ThrowIfDisposed();
		cancellationToken.ThrowIfCancellationRequested();
		if (millisecondsTimeout < -1)
		{
			throw new ArgumentOutOfRangeException("millisecondsTimeout", millisecondsTimeout, SR.GetString("Barrier_SignalAndWait_ArgumentOutOfRange"));
		}
		if (m_actionCallerID != 0 && Thread.CurrentThread.ManagedThreadId == m_actionCallerID)
		{
			throw new InvalidOperationException(SR.GetString("Barrier_InvalidOperation_CalledFromPHA"));
		}
		SpinWait spinWait = default(SpinWait);
		int current;
		int total;
		bool sense;
		long currentPhaseNumber;
		while (true)
		{
			int currentTotalCount = m_currentTotalCount;
			GetCurrentTotal(currentTotalCount, out current, out total, out sense);
			currentPhaseNumber = CurrentPhaseNumber;
			if (total == 0)
			{
				throw new InvalidOperationException(SR.GetString("Barrier_SignalAndWait_InvalidOperation_ZeroTotal"));
			}
			if (current == 0 && sense != (CurrentPhaseNumber % 2 == 0))
			{
				throw new InvalidOperationException(SR.GetString("Barrier_SignalAndWait_InvalidOperation_ThreadsExceeded"));
			}
			if (current + 1 == total)
			{
				if (SetCurrentTotal(currentTotalCount, 0, total, !sense))
				{
					if (CdsSyncEtwBCLProvider.Log.IsEnabled())
					{
						CdsSyncEtwBCLProvider.Log.Barrier_PhaseFinished(sense, CurrentPhaseNumber);
					}
					FinishPhase(sense);
					return true;
				}
			}
			else if (SetCurrentTotal(currentTotalCount, current + 1, total, sense))
			{
				break;
			}
			spinWait.SpinOnce();
		}
		ManualResetEventSlim currentPhaseEvent = (sense ? m_evenEvent : m_oddEvent);
		bool flag = false;
		bool flag2 = false;
		try
		{
			flag2 = DiscontinuousWait(currentPhaseEvent, millisecondsTimeout, cancellationToken, currentPhaseNumber);
		}
		catch (OperationCanceledException)
		{
			flag = true;
		}
		catch (ObjectDisposedException)
		{
			if (currentPhaseNumber >= CurrentPhaseNumber)
			{
				throw;
			}
			flag2 = true;
		}
		if (!flag2)
		{
			spinWait.Reset();
			while (true)
			{
				int currentTotalCount = m_currentTotalCount;
				GetCurrentTotal(currentTotalCount, out current, out total, out var sense2);
				if (currentPhaseNumber < CurrentPhaseNumber || sense != sense2)
				{
					break;
				}
				if (SetCurrentTotal(currentTotalCount, current - 1, total, sense))
				{
					if (flag)
					{
						throw new OperationCanceledException(SR.GetString("Common_OperationCanceled"), cancellationToken);
					}
					return false;
				}
				spinWait.SpinOnce();
			}
			WaitCurrentPhase(currentPhaseEvent, currentPhaseNumber);
		}
		if (m_exception != null)
		{
			throw new BarrierPostPhaseException(m_exception);
		}
		return true;
	}

	[SecuritySafeCritical]
	private void FinishPhase(bool observedSense)
	{
		if (m_postPhaseAction != null)
		{
			try
			{
				m_actionCallerID = Thread.CurrentThread.ManagedThreadId;
				if (m_ownerThreadContext != null)
				{
					ExecutionContext ownerThreadContext = m_ownerThreadContext;
					m_ownerThreadContext = m_ownerThreadContext.CreateCopy();
					ContextCallback callback = InvokePostPhaseAction;
					ExecutionContext.Run(ownerThreadContext, callback, this);
					ownerThreadContext.Dispose();
				}
				else
				{
					m_postPhaseAction(this);
				}
				m_exception = null;
				return;
			}
			catch (Exception exception)
			{
				m_exception = exception;
				return;
			}
			finally
			{
				m_actionCallerID = 0;
				SetResetEvents(observedSense);
				if (m_exception != null)
				{
					throw new BarrierPostPhaseException(m_exception);
				}
			}
		}
		SetResetEvents(observedSense);
	}

	[SecurityCritical]
	private static void InvokePostPhaseAction(object obj)
	{
		Barrier barrier = (Barrier)obj;
		barrier.m_postPhaseAction(barrier);
	}

	private void SetResetEvents(bool observedSense)
	{
		CurrentPhaseNumber++;
		if (observedSense)
		{
			m_oddEvent.Reset();
			m_evenEvent.Set();
		}
		else
		{
			m_evenEvent.Reset();
			m_oddEvent.Set();
		}
	}

	private void WaitCurrentPhase(ManualResetEventSlim currentPhaseEvent, long observedPhase)
	{
		SpinWait spinWait = default(SpinWait);
		while (!currentPhaseEvent.IsSet && CurrentPhaseNumber - observedPhase <= 1)
		{
			spinWait.SpinOnce();
		}
	}

	private bool DiscontinuousWait(ManualResetEventSlim currentPhaseEvent, int totalTimeout, CancellationToken token, long observedPhase)
	{
		int num = 100;
		int num2 = 10000;
		while (observedPhase == CurrentPhaseNumber)
		{
			int num3 = ((totalTimeout == -1) ? num : Math.Min(num, totalTimeout));
			if (currentPhaseEvent.Wait(num3, token))
			{
				return true;
			}
			if (totalTimeout != -1)
			{
				totalTimeout -= num3;
				if (totalTimeout <= 0)
				{
					return false;
				}
			}
			num = ((num >= num2) ? num2 : Math.Min(num << 1, num2));
		}
		WaitCurrentPhase(currentPhaseEvent, observedPhase);
		return true;
	}

	[global::__DynamicallyInvokable]
	public void Dispose()
	{
		if (m_actionCallerID != 0 && Thread.CurrentThread.ManagedThreadId == m_actionCallerID)
		{
			throw new InvalidOperationException(SR.GetString("Barrier_InvalidOperation_CalledFromPHA"));
		}
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[global::__DynamicallyInvokable]
	protected virtual void Dispose(bool disposing)
	{
		if (m_disposed)
		{
			return;
		}
		if (disposing)
		{
			m_oddEvent.Dispose();
			m_evenEvent.Dispose();
			if (m_ownerThreadContext != null)
			{
				m_ownerThreadContext.Dispose();
				m_ownerThreadContext = null;
			}
		}
		m_disposed = true;
	}

	private void ThrowIfDisposed()
	{
		if (m_disposed)
		{
			throw new ObjectDisposedException("Barrier", SR.GetString("Barrier_Dispose"));
		}
	}
}
