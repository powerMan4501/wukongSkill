using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class AnyAllSearchOperator<TInput> : UnaryQueryOperator<TInput, bool>
{
	private class AnyAllSearchOperatorEnumerator<TKey> : QueryOperatorEnumerator<bool, int>
	{
		private readonly QueryOperatorEnumerator<TInput, TKey> m_source;

		private readonly Func<TInput, bool> m_predicate;

		private readonly bool m_qualification;

		private readonly int m_partitionIndex;

		private readonly Shared<bool> m_resultFoundFlag;

		private readonly CancellationToken m_cancellationToken;

		internal AnyAllSearchOperatorEnumerator(QueryOperatorEnumerator<TInput, TKey> source, bool qualification, Func<TInput, bool> predicate, int partitionIndex, Shared<bool> resultFoundFlag, CancellationToken cancellationToken)
		{
			m_source = source;
			m_qualification = qualification;
			m_predicate = predicate;
			m_partitionIndex = partitionIndex;
			m_resultFoundFlag = resultFoundFlag;
			m_cancellationToken = cancellationToken;
		}

		internal override bool MoveNext(ref bool currentElement, ref int currentKey)
		{
			if (m_resultFoundFlag.Value)
			{
				return false;
			}
			TInput currentElement2 = default(TInput);
			TKey currentKey2 = default(TKey);
			if (m_source.MoveNext(ref currentElement2, ref currentKey2))
			{
				currentElement = !m_qualification;
				currentKey = m_partitionIndex;
				int num = 0;
				do
				{
					if ((num++ & 0x3F) == 0)
					{
						CancellationState.ThrowIfCanceled(m_cancellationToken);
					}
					if (m_resultFoundFlag.Value)
					{
						return false;
					}
					if (m_predicate(currentElement2) == m_qualification)
					{
						m_resultFoundFlag.Value = true;
						currentElement = m_qualification;
						break;
					}
				}
				while (m_source.MoveNext(ref currentElement2, ref currentKey2));
				return true;
			}
			return false;
		}

		protected override void Dispose(bool disposing)
		{
			m_source.Dispose();
		}
	}

	private readonly Func<TInput, bool> m_predicate;

	private readonly bool m_qualification;

	internal override bool LimitsParallelism => false;

	internal AnyAllSearchOperator(IEnumerable<TInput> child, bool qualification, Func<TInput, bool> predicate)
		: base(child)
	{
		m_qualification = qualification;
		m_predicate = predicate;
	}

	internal bool Aggregate()
	{
		using (IEnumerator<bool> enumerator = GetEnumerator(ParallelMergeOptions.FullyBuffered, suppressOrderPreservation: true))
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current == m_qualification)
				{
					return m_qualification;
				}
			}
		}
		return !m_qualification;
	}

	internal override QueryResults<bool> Open(QuerySettings settings, bool preferStriping)
	{
		QueryResults<TInput> childQueryResults = base.Child.Open(settings, preferStriping);
		return new UnaryQueryOperatorResults(childQueryResults, this, settings, preferStriping);
	}

	internal override void WrapPartitionedStream<TKey>(PartitionedStream<TInput, TKey> inputStream, IPartitionedStreamRecipient<bool> recipient, bool preferStriping, QuerySettings settings)
	{
		Shared<bool> resultFoundFlag = new Shared<bool>(value: false);
		int partitionCount = inputStream.PartitionCount;
		PartitionedStream<bool, int> partitionedStream = new PartitionedStream<bool, int>(partitionCount, Util.GetDefaultComparer<int>(), OrdinalIndexState.Correct);
		for (int i = 0; i < partitionCount; i++)
		{
			partitionedStream[i] = new AnyAllSearchOperatorEnumerator<TKey>(inputStream[i], m_qualification, m_predicate, i, resultFoundFlag, settings.CancellationState.MergedCancellationToken);
		}
		recipient.Receive(partitionedStream);
	}

	internal override IEnumerable<bool> AsSequentialQuery(CancellationToken token)
	{
		throw new NotSupportedException();
	}
}
