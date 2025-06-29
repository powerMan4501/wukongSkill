using System.Threading;

namespace System.Linq.Parallel;

internal class PipelineSpoolingTask<TInputOutput, TIgnoreKey> : SpoolingTaskBase
{
	private QueryOperatorEnumerator<TInputOutput, TIgnoreKey> m_source;

	private AsynchronousChannel<TInputOutput> m_destination;

	internal PipelineSpoolingTask(int taskIndex, QueryTaskGroupState groupState, QueryOperatorEnumerator<TInputOutput, TIgnoreKey> source, AsynchronousChannel<TInputOutput> destination)
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
		AsynchronousChannel<TInputOutput> destination = m_destination;
		CancellationToken mergedCancellationToken = m_groupState.CancellationState.MergedCancellationToken;
		while (source.MoveNext(ref currentElement, ref currentKey) && !mergedCancellationToken.IsCancellationRequested)
		{
			destination.Enqueue(currentElement);
		}
		destination.FlushBuffers();
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
