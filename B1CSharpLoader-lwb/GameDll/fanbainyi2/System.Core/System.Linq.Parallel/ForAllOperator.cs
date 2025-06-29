using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class ForAllOperator<TInput> : UnaryQueryOperator<TInput, TInput>
{
	private class ForAllEnumerator<TKey> : QueryOperatorEnumerator<TInput, int>
	{
		private readonly QueryOperatorEnumerator<TInput, TKey> m_source;

		private readonly Action<TInput> m_elementAction;

		private CancellationToken m_cancellationToken;

		internal ForAllEnumerator(QueryOperatorEnumerator<TInput, TKey> source, Action<TInput> elementAction, CancellationToken cancellationToken)
		{
			m_source = source;
			m_elementAction = elementAction;
			m_cancellationToken = cancellationToken;
		}

		internal override bool MoveNext(ref TInput currentElement, ref int currentKey)
		{
			TInput currentElement2 = default(TInput);
			TKey currentKey2 = default(TKey);
			int num = 0;
			while (m_source.MoveNext(ref currentElement2, ref currentKey2))
			{
				if ((num++ & 0x3F) == 0)
				{
					CancellationState.ThrowIfCanceled(m_cancellationToken);
				}
				m_elementAction(currentElement2);
			}
			return false;
		}

		protected override void Dispose(bool disposing)
		{
			m_source.Dispose();
		}
	}

	private readonly Action<TInput> m_elementAction;

	internal override bool LimitsParallelism => false;

	internal ForAllOperator(IEnumerable<TInput> child, Action<TInput> elementAction)
		: base(child)
	{
		m_elementAction = elementAction;
	}

	internal void RunSynchronously()
	{
		Shared<bool> topLevelDisposedFlag = new Shared<bool>(value: false);
		CancellationTokenSource topLevelCancellationTokenSource = new CancellationTokenSource();
		QuerySettings querySettings = base.SpecifiedQuerySettings.WithPerExecutionSettings(topLevelCancellationTokenSource, topLevelDisposedFlag).WithDefaults();
		QueryLifecycle.LogicalQueryExecutionBegin(querySettings.QueryId);
		IEnumerator<TInput> openedEnumerator = GetOpenedEnumerator(ParallelMergeOptions.FullyBuffered, suppressOrder: true, forEffect: true, querySettings);
		querySettings.CleanStateAtQueryEnd();
		QueryLifecycle.LogicalQueryExecutionEnd(querySettings.QueryId);
	}

	internal override QueryResults<TInput> Open(QuerySettings settings, bool preferStriping)
	{
		QueryResults<TInput> childQueryResults = base.Child.Open(settings, preferStriping);
		return new UnaryQueryOperatorResults(childQueryResults, this, settings, preferStriping);
	}

	internal override void WrapPartitionedStream<TKey>(PartitionedStream<TInput, TKey> inputStream, IPartitionedStreamRecipient<TInput> recipient, bool preferStriping, QuerySettings settings)
	{
		int partitionCount = inputStream.PartitionCount;
		PartitionedStream<TInput, int> partitionedStream = new PartitionedStream<TInput, int>(partitionCount, Util.GetDefaultComparer<int>(), OrdinalIndexState.Correct);
		for (int i = 0; i < partitionCount; i++)
		{
			partitionedStream[i] = new ForAllEnumerator<TKey>(inputStream[i], m_elementAction, settings.CancellationState.MergedCancellationToken);
		}
		recipient.Receive(partitionedStream);
	}

	internal override IEnumerable<TInput> AsSequentialQuery(CancellationToken token)
	{
		throw new InvalidOperationException();
	}
}
