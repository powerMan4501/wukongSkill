using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class SingleQueryOperator<TSource> : UnaryQueryOperator<TSource, TSource>
{
	private class SingleQueryOperatorEnumerator<TKey> : QueryOperatorEnumerator<TSource, int>
	{
		private QueryOperatorEnumerator<TSource, TKey> m_source;

		private Func<TSource, bool> m_predicate;

		private bool m_alreadySearched;

		private bool m_yieldExtra;

		private Shared<int> m_totalElementCount;

		internal SingleQueryOperatorEnumerator(QueryOperatorEnumerator<TSource, TKey> source, Func<TSource, bool> predicate, Shared<int> totalElementCount)
		{
			m_source = source;
			m_predicate = predicate;
			m_totalElementCount = totalElementCount;
		}

		internal override bool MoveNext(ref TSource currentElement, ref int currentKey)
		{
			if (m_alreadySearched)
			{
				if (m_yieldExtra)
				{
					m_yieldExtra = false;
					currentElement = default(TSource);
					currentKey = 0;
					return true;
				}
				return false;
			}
			bool flag = false;
			TSource currentElement2 = default(TSource);
			TKey currentKey2 = default(TKey);
			while (m_source.MoveNext(ref currentElement2, ref currentKey2))
			{
				if (m_predicate == null || m_predicate(currentElement2))
				{
					Interlocked.Increment(ref m_totalElementCount.Value);
					currentElement = currentElement2;
					currentKey = 0;
					if (flag)
					{
						m_yieldExtra = true;
						break;
					}
					flag = true;
				}
				if (Volatile.Read(ref m_totalElementCount.Value) > 1)
				{
					break;
				}
			}
			m_alreadySearched = true;
			return flag;
		}

		protected override void Dispose(bool disposing)
		{
			m_source.Dispose();
		}
	}

	private readonly Func<TSource, bool> m_predicate;

	internal override bool LimitsParallelism => false;

	internal SingleQueryOperator(IEnumerable<TSource> child, Func<TSource, bool> predicate)
		: base(child)
	{
		m_predicate = predicate;
	}

	internal override QueryResults<TSource> Open(QuerySettings settings, bool preferStriping)
	{
		QueryResults<TSource> childQueryResults = base.Child.Open(settings, preferStriping: false);
		return new UnaryQueryOperatorResults(childQueryResults, this, settings, preferStriping);
	}

	internal override void WrapPartitionedStream<TKey>(PartitionedStream<TSource, TKey> inputStream, IPartitionedStreamRecipient<TSource> recipient, bool preferStriping, QuerySettings settings)
	{
		int partitionCount = inputStream.PartitionCount;
		PartitionedStream<TSource, int> partitionedStream = new PartitionedStream<TSource, int>(partitionCount, Util.GetDefaultComparer<int>(), OrdinalIndexState.Shuffled);
		Shared<int> totalElementCount = new Shared<int>(0);
		for (int i = 0; i < partitionCount; i++)
		{
			partitionedStream[i] = new SingleQueryOperatorEnumerator<TKey>(inputStream[i], m_predicate, totalElementCount);
		}
		recipient.Receive(partitionedStream);
	}

	internal override IEnumerable<TSource> AsSequentialQuery(CancellationToken token)
	{
		throw new NotSupportedException();
	}
}
