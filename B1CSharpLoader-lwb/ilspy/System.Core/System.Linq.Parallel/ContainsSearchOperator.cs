using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class ContainsSearchOperator<TInput> : UnaryQueryOperator<TInput, bool>
{
	private class ContainsSearchOperatorEnumerator<TKey> : QueryOperatorEnumerator<bool, int>
	{
		private readonly QueryOperatorEnumerator<TInput, TKey> m_source;

		private readonly TInput m_searchValue;

		private readonly IEqualityComparer<TInput> m_comparer;

		private readonly int m_partitionIndex;

		private readonly Shared<bool> m_resultFoundFlag;

		private CancellationToken m_cancellationToken;

		internal ContainsSearchOperatorEnumerator(QueryOperatorEnumerator<TInput, TKey> source, TInput searchValue, IEqualityComparer<TInput> comparer, int partitionIndex, Shared<bool> resultFoundFlag, CancellationToken cancellationToken)
		{
			m_source = source;
			m_searchValue = searchValue;
			m_comparer = comparer;
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
				currentElement = false;
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
					if (m_comparer.Equals(currentElement2, m_searchValue))
					{
						m_resultFoundFlag.Value = true;
						currentElement = true;
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

	private readonly TInput m_searchValue;

	private readonly IEqualityComparer<TInput> m_comparer;

	internal override bool LimitsParallelism => false;

	internal ContainsSearchOperator(IEnumerable<TInput> child, TInput searchValue, IEqualityComparer<TInput> comparer)
		: base(child)
	{
		m_searchValue = searchValue;
		if (comparer == null)
		{
			m_comparer = EqualityComparer<TInput>.Default;
		}
		else
		{
			m_comparer = comparer;
		}
	}

	internal bool Aggregate()
	{
		using (IEnumerator<bool> enumerator = GetEnumerator(ParallelMergeOptions.FullyBuffered, suppressOrderPreservation: true))
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current)
				{
					return true;
				}
			}
		}
		return false;
	}

	internal override QueryResults<bool> Open(QuerySettings settings, bool preferStriping)
	{
		QueryResults<TInput> childQueryResults = base.Child.Open(settings, preferStriping);
		return new UnaryQueryOperatorResults(childQueryResults, this, settings, preferStriping);
	}

	internal override void WrapPartitionedStream<TKey>(PartitionedStream<TInput, TKey> inputStream, IPartitionedStreamRecipient<bool> recipient, bool preferStriping, QuerySettings settings)
	{
		int partitionCount = inputStream.PartitionCount;
		PartitionedStream<bool, int> partitionedStream = new PartitionedStream<bool, int>(partitionCount, Util.GetDefaultComparer<int>(), OrdinalIndexState.Correct);
		Shared<bool> resultFoundFlag = new Shared<bool>(value: false);
		for (int i = 0; i < partitionCount; i++)
		{
			partitionedStream[i] = new ContainsSearchOperatorEnumerator<TKey>(inputStream[i], m_searchValue, m_comparer, i, resultFoundFlag, settings.CancellationState.MergedCancellationToken);
		}
		recipient.Receive(partitionedStream);
	}

	internal override IEnumerable<bool> AsSequentialQuery(CancellationToken token)
	{
		throw new NotSupportedException();
	}
}
