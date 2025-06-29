namespace System.Linq.Parallel;

internal class ForAllSpoolingTask<TInputOutput, TIgnoreKey> : SpoolingTaskBase
{
	private QueryOperatorEnumerator<TInputOutput, TIgnoreKey> m_source;

	internal ForAllSpoolingTask(int taskIndex, QueryTaskGroupState groupState, QueryOperatorEnumerator<TInputOutput, TIgnoreKey> source)
		: base(taskIndex, groupState)
	{
		m_source = source;
	}

	protected override void SpoolingWork()
	{
		TInputOutput currentElement = default(TInputOutput);
		TIgnoreKey currentKey = default(TIgnoreKey);
		while (m_source.MoveNext(ref currentElement, ref currentKey))
		{
		}
	}

	protected override void SpoolingFinally()
	{
		base.SpoolingFinally();
		m_source.Dispose();
	}
}
