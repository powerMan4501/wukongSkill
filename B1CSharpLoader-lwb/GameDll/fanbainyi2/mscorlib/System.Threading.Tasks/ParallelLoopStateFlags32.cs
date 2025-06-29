namespace System.Threading.Tasks;

internal class ParallelLoopStateFlags32 : ParallelLoopStateFlags
{
	internal volatile int m_lowestBreakIteration = int.MaxValue;

	internal int LowestBreakIteration => m_lowestBreakIteration;

	internal long? NullableLowestBreakIteration
	{
		get
		{
			if (m_lowestBreakIteration == int.MaxValue)
			{
				return null;
			}
			long location = m_lowestBreakIteration;
			if (IntPtr.Size >= 8)
			{
				return location;
			}
			return Interlocked.Read(ref location);
		}
	}

	internal bool ShouldExitLoop(int CallerIteration)
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
