namespace System.Threading.Tasks;

internal class ParallelLoopStateFlags64 : ParallelLoopStateFlags
{
	internal long m_lowestBreakIteration = long.MaxValue;

	internal long LowestBreakIteration
	{
		get
		{
			if (IntPtr.Size >= 8)
			{
				return m_lowestBreakIteration;
			}
			return Interlocked.Read(ref m_lowestBreakIteration);
		}
	}

	internal long? NullableLowestBreakIteration
	{
		get
		{
			if (m_lowestBreakIteration == long.MaxValue)
			{
				return null;
			}
			if (IntPtr.Size >= 8)
			{
				return m_lowestBreakIteration;
			}
			return Interlocked.Read(ref m_lowestBreakIteration);
		}
	}

	internal bool ShouldExitLoop(long CallerIteration)
	{
		int loopStateFlags = base.LoopStateFlags;
		if (loopStateFlags != ParallelLoopStateFlags.PLS_NONE)
		{
			if ((loopStateFlags & (ParallelLoopStateFlags.PLS_EXCEPTIONAL | ParallelLoopStateFlags.PLS_STOPPED | ParallelLoopStateFlags.PLS_CANCELED)) == 0)
			{
				if ((loopStateFlags & ParallelLoopStateFlags.PLS_BROKEN) != 0)
				{
					return CallerIteration > LowestBreakIteration;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	internal bool ShouldExitLoop()
	{
		int loopStateFlags = base.LoopStateFlags;
		if (loopStateFlags != ParallelLoopStateFlags.PLS_NONE)
		{
			return (loopStateFlags & (ParallelLoopStateFlags.PLS_EXCEPTIONAL | ParallelLoopStateFlags.PLS_CANCELED)) != 0;
		}
		return false;
	}
}
