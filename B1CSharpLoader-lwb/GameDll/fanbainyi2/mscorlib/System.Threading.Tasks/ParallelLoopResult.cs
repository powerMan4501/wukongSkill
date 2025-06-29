namespace System.Threading.Tasks;

[__DynamicallyInvokable]
public struct ParallelLoopResult
{
	internal bool m_completed;

	internal long? m_lowestBreakIteration;

	[__DynamicallyInvokable]
	public bool IsCompleted
	{
		[__DynamicallyInvokable]
		get
		{
			return m_completed;
		}
	}

	[__DynamicallyInvokable]
	public long? LowestBreakIteration
	{
		[__DynamicallyInvokable]
		get
		{
			return m_lowestBreakIteration;
		}
	}
}
