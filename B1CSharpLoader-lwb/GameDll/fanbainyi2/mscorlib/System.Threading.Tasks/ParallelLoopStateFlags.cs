namespace System.Threading.Tasks;

internal class ParallelLoopStateFlags
{
	internal static int PLS_NONE;

	internal static int PLS_EXCEPTIONAL = 1;

	internal static int PLS_BROKEN = 2;

	internal static int PLS_STOPPED = 4;

	internal static int PLS_CANCELED = 8;

	private volatile int m_LoopStateFlags = PLS_NONE;

	internal int LoopStateFlags => m_LoopStateFlags;

	internal bool AtomicLoopStateUpdate(int newState, int illegalStates)
	{
		int oldState = 0;
		return AtomicLoopStateUpdate(newState, illegalStates, ref oldState);
	}

	internal bool AtomicLoopStateUpdate(int newState, int illegalStates, ref int oldState)
	{
		SpinWait spinWait = default(SpinWait);
		while (true)
		{
			oldState = m_LoopStateFlags;
			if ((oldState & illegalStates) != 0)
			{
				return false;
			}
			if (Interlocked.CompareExchange(ref m_LoopStateFlags, oldState | newState, oldState) == oldState)
			{
				break;
			}
			spinWait.SpinOnce();
		}
		return true;
	}

	internal void SetExceptional()
	{
		AtomicLoopStateUpdate(PLS_EXCEPTIONAL, PLS_NONE);
	}

	internal void Stop()
	{
		if (!AtomicLoopStateUpdate(PLS_STOPPED, PLS_BROKEN))
		{
			throw new InvalidOperationException(Environment.GetResourceString("ParallelState_Stop_InvalidOperationException_StopAfterBreak"));
		}
	}

	internal bool Cancel()
	{
		return AtomicLoopStateUpdate(PLS_CANCELED, PLS_NONE);
	}
}
