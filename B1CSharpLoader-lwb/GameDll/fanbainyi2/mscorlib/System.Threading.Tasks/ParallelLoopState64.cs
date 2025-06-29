namespace System.Threading.Tasks;

internal class ParallelLoopState64 : ParallelLoopState
{
	private ParallelLoopStateFlags64 m_sharedParallelStateFlags;

	private long m_currentIteration;

	internal long CurrentIteration
	{
		get
		{
			return m_currentIteration;
		}
		set
		{
			m_currentIteration = value;
		}
	}

	internal override bool InternalShouldExitCurrentIteration => m_sharedParallelStateFlags.ShouldExitLoop(CurrentIteration);

	internal override long? InternalLowestBreakIteration => m_sharedParallelStateFlags.NullableLowestBreakIteration;

	internal ParallelLoopState64(ParallelLoopStateFlags64 sharedParallelStateFlags)
		: base(sharedParallelStateFlags)
	{
		m_sharedParallelStateFlags = sharedParallelStateFlags;
	}

	internal override void InternalBreak()
	{
		ParallelLoopState.Break(CurrentIteration, m_sharedParallelStateFlags);
	}
}
