using System.Threading;

namespace System.Linq.Parallel;

internal class StopAndGoSpoolingTask<TInputOutput, TIgnoreKey> : SpoolingTaskBase
{
	private QueryOperatorEnumerator<TInputOutput, TIgnoreKey> m_source;

	private SynchronousChannel<TInputOutput> m_destination;

	internal StopAndGoSpoolingTask(int taskIndex, QueryTaskGroupState groupState, QueryOperatorEnumerator<TInputOutput, TIgnoreKey> source, SynchronousChannel<TInputOutput> destination)
		: base(taskIndex, groupState)
	{
		m_source = source;
		m_destination = destination;
	}

	protected override void SpoolingWork()
	{
		TInputOutput currentElement = default(TInputOutput);
		TIgnoreKey currentKey = default(TIgnoreKey);
		QueryOperatorEnumerator<TInputOutput, TIgnoreKey> source = m_source;
		SynchronousChannel<TInputOutput> destination = m_destination;
		CancellationToken mergedCancellationToken = m_groupState.CancellationState.MergedCancellationToken;
		destination.Init();
		while (source.MoveNext(ref currentElement, ref currentKey) && !mergedCancellationToken.IsCancellationRequested)
		{
			destination.Enqueue(currentElement);
		}
	}

	protected override void SpoolingFinally()
	{
		base.SpoolingFinally();
		if (m_destination != null)
		{
			m_destination.SetDone();
		}
		m_source.Dispose();
	}
}
