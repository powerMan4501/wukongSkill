using System.Diagnostics;
using System.Security.Permissions;

namespace System.Threading.Tasks;

[DebuggerDisplay("ShouldExitCurrentIteration = {ShouldExitCurrentIteration}")]
[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public class ParallelLoopState
{
	private ParallelLoopStateFlags m_flagsBase;

	internal virtual bool InternalShouldExitCurrentIteration
	{
		get
		{
			throw new NotSupportedException(Environment.GetResourceString("ParallelState_NotSupportedException_UnsupportedMethod"));
		}
	}

	[__DynamicallyInvokable]
	public bool ShouldExitCurrentIteration
	{
		[__DynamicallyInvokable]
		get
		{
			return InternalShouldExitCurrentIteration;
		}
	}

	[__DynamicallyInvokable]
	public bool IsStopped
	{
		[__DynamicallyInvokable]
		get
		{
			return (m_flagsBase.LoopStateFlags & ParallelLoopStateFlags.PLS_STOPPED) != 0;
		}
	}

	[__DynamicallyInvokable]
	public bool IsExceptional
	{
		[__DynamicallyInvokable]
		get
		{
			return (m_flagsBase.LoopStateFlags & ParallelLoopStateFlags.PLS_EXCEPTIONAL) != 0;
		}
	}

	internal virtual long? InternalLowestBreakIteration
	{
		get
		{
			throw new NotSupportedException(Environment.GetResourceString("ParallelState_NotSupportedException_UnsupportedMethod"));
		}
	}

	[__DynamicallyInvokable]
	public long? LowestBreakIteration
	{
		[__DynamicallyInvokable]
		get
		{
			return InternalLowestBreakIteration;
		}
	}

	internal ParallelLoopState(ParallelLoopStateFlags fbase)
	{
		m_flagsBase = fbase;
	}

	[__DynamicallyInvokable]
	public void Stop()
	{
		m_flagsBase.Stop();
	}

	internal virtual void InternalBreak()
	{
		throw new NotSupportedException(Environment.GetResourceString("ParallelState_NotSupportedException_UnsupportedMethod"));
	}

	[__DynamicallyInvokable]
	public void Break()
	{
		InternalBreak();
	}

	internal static void Break(int iteration, ParallelLoopStateFlags32 pflags)
	{
		int oldState = ParallelLoopStateFlags.PLS_NONE;
		if (!pflags.AtomicLoopStateUpdate(ParallelLoopStateFlags.PLS_BROKEN, ParallelLoopStateFlags.PLS_STOPPED | ParallelLoopStateFlags.PLS_EXCEPTIONAL | ParallelLoopStateFlags.PLS_CANCELED, ref oldState))
		{
			if ((oldState & ParallelLoopStateFlags.PLS_STOPPED) != 0)
			{
				throw new InvalidOperationException(Environment.GetResourceString("ParallelState_Break_InvalidOperationException_BreakAfterStop"));
			}
			return;
		}
		int lowestBreakIteration = pflags.m_lowestBreakIteration;
		if (iteration >= lowestBreakIteration)
		{
			return;
		}
		SpinWait spinWait = default(SpinWait);
		while (Interlocked.CompareExchange(ref pflags.m_lowestBreakIteration, iteration, lowestBreakIteration) != lowestBreakIteration)
		{
			spinWait.SpinOnce();
			lowestBreakIteration = pflags.m_lowestBreakIteration;
			if (iteration > lowestBreakIteration)
			{
				break;
			}
		}
	}

	internal static void Break(long iteration, ParallelLoopStateFlags64 pflags)
	{
		int oldState = ParallelLoopStateFlags.PLS_NONE;
		if (!pflags.AtomicLoopStateUpdate(ParallelLoopStateFlags.PLS_BROKEN, ParallelLoopStateFlags.PLS_STOPPED | ParallelLoopStateFlags.PLS_EXCEPTIONAL | ParallelLoopStateFlags.PLS_CANCELED, ref oldState))
		{
			if ((oldState & ParallelLoopStateFlags.PLS_STOPPED) != 0)
			{
				throw new InvalidOperationException(Environment.GetResourceString("ParallelState_Break_InvalidOperationException_BreakAfterStop"));
			}
			return;
		}
		long lowestBreakIteration = pflags.LowestBreakIteration;
		if (iteration >= lowestBreakIteration)
		{
			return;
		}
		SpinWait spinWait = default(SpinWait);
		while (Interlocked.CompareExchange(ref pflags.m_lowestBreakIteration, iteration, lowestBreakIteration) != lowestBreakIteration)
		{
			spinWait.SpinOnce();
			lowestBreakIteration = pflags.LowestBreakIteration;
			if (iteration > lowestBreakIteration)
			{
				break;
			}
		}
	}
}
