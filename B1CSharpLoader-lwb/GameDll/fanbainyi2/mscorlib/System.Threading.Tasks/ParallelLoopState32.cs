namespace System.Threading.Tasks;

internal class ParallelLoopState32 : ParallelLoopState
{
	private ParallelLoopStateFlags32 m_sharedParallelStateFlags;

	private int m_currentIteration;

	internal int CurrentIteration
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

	internal ParallelLoopState32(ParallelLoopStateFlags32 sharedParallelStateFlags)
		: base(sharedParallelStateFlags)
	{
		m_sharedParallelStateFlags = sharedParallelStateFlags;
	}

	internal override void InternalBreak()
	{
		ParallelLoopState.Break(CurrentIteration, m_sharedParallelStateFlags);
	}
}
