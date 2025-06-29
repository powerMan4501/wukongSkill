using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class AssociativeAggregationOperator<TInput, TIntermediate, TOutput> : UnaryQueryOperator<TInput, TIntermediate>
{
	private class AssociativeAggregationOperatorEnumerator<TKey> : QueryOperatorEnumerator<TIntermediate, int>
	{
		private readonly QueryOperatorEnumerator<TInput, TKey> m_source;

		private readonly AssociativeAggregationOperator<TInput, TIntermediate, TOutput> m_reduceOperator;

		private readonly int m_partitionIndex;

		private readonly CancellationToken m_cancellationToken;

		private bool m_accumulated;

		internal AssociativeAggregationOperatorEnumerator(QueryOperatorEnumerator<TInput, TKey> source, AssociativeAggregationOperator<TInput, TIntermediate, TOutput> reduceOperator, int partitionIndex, CancellationToken cancellationToken)
		{
			m_source = source;
			m_reduceOperator = reduceOperator;
			m_partitionIndex = partitionIndex;
			m_cancellationToken = cancellationToken;
		}

		internal override bool MoveNext(ref TIntermediate currentElement, ref int currentKey)
		{
			if (m_accumulated)
			{
				return false;
			}
			m_accumulated = true;
			bool flag = false;
			TIntermediate val = default(TIntermediate);
			if (m_reduceOperator.m_seedIsSpecified)
			{
				val = ((m_reduceOperator.m_seedFactory == null) ? m_reduceOperator.m_seed : m_reduceOperator.m_seedFactory());
			}
			else
			{
				TInput currentElement2 = default(TInput);
				TKey currentKey2 = default(TKey);
				if (!m_source.MoveNext(ref currentElement2, ref currentKey2))
				{
					return false;
				}
				flag = true;
				val = (TIntermediate)(object)currentElement2;
			}
			TInput currentElement3 = default(TInput);
			TKey currentKey3 = default(TKey);
			int num = 0;
			while (m_source.MoveNext(ref currentElement3, ref currentKey3))
			{
				if ((num++ & 0x3F) == 0)
				{
					CancellationState.ThrowIfCanceled(m_cancellationToken);
				}
				flag = true;
				val = m_reduceOperator.m_intermediateReduce(val, currentElement3);
			}
			if (flag)
			{
				currentElement = val;
				currentKey = m_partitionIndex;
				return true;
			}
			return false;
		}

		protected override void Dispose(bool disposing)
		{
			m_source.Dispose();
		}
	}

	private readonly TIntermediate m_seed;

	private readonly bool m_seedIsSpecified;

	private readonly bool m_throwIfEmpty;

	private Func<TIntermediate, TInput, TIntermediate> m_intermediateReduce;

	private Func<TIntermediate, TIntermediate, TIntermediate> m_finalReduce;

	private Func<TIntermediate, TOutput> m_resultSelector;

	private Func<TIntermediate> m_seedFactory;

	internal override bool LimitsParallelism => false;

	internal AssociativeAggregationOperator(IEnumerable<TInput> child, TIntermediate seed, Func<TIntermediate> seedFactory, bool seedIsSpecified, Func<TIntermediate, TInput, TIntermediate> intermediateReduce, Func<TIntermediate, TIntermediate, TIntermediate> finalReduce, Func<TIntermediate, TOutput> resultSelector, bool throwIfEmpty, QueryAggregationOptions options)
		: base(child)
	{
		m_seed = seed;
		m_seedFactory = seedFactory;
		m_seedIsSpecified = seedIsSpecified;
		m_intermediateReduce = intermediateReduce;
		m_finalReduce = finalReduce;
		m_resultSelector = resultSelector;
		m_throwIfEmpty = throwIfEmpty;
	}

	internal TOutput Aggregate()
	{
		TIntermediate val = default(TIntermediate);
		bool flag = false;
		using (IEnumerator<TIntermediate> enumerator = GetEnumerator(ParallelMergeOptions.FullyBuffered, suppressOrderPreservation: true))
		{
			while (enumerator.MoveNext())
			{
				if (flag)
				{
					try
					{
						val = m_finalReduce(val, enumerator.Current);
					}
					catch (ThreadAbortException)
					{
						throw;
					}
					catch (Exception ex2)
					{
						throw new AggregateException(ex2);
					}
				}
				else
				{
					val = enumerator.Current;
					flag = true;
				}
			}
			if (!flag)
			{
				if (m_throwIfEmpty)
				{
					throw new InvalidOperationException(SR.GetString("NoElements"));
				}
				val = ((m_seedFactory == null) ? m_seed : m_seedFactory());
			}
		}
		try
		{
			return m_resultSelector(val);
		}
		catch (ThreadAbortException)
		{
			throw;
		}
		catch (Exception ex4)
		{
			throw new AggregateException(ex4);
		}
	}

	internal override QueryResults<TIntermediate> Open(QuerySettings settings, bool preferStriping)
	{
		QueryResults<TInput> childQueryResults = base.Child.Open(settings, preferStriping);
		return new UnaryQueryOperatorResults(childQueryResults, this, settings, preferStriping);
	}

	internal override void WrapPartitionedStream<TKey>(PartitionedStream<TInput, TKey> inputStream, IPartitionedStreamRecipient<TIntermediate> recipient, bool preferStriping, QuerySettings settings)
	{
		int partitionCount = inputStream.PartitionCount;
		PartitionedStream<TIntermediate, int> partitionedStream = new PartitionedStream<TIntermediate, int>(partitionCount, Util.GetDefaultComparer<int>(), OrdinalIndexState.Correct);
		for (int i = 0; i < partitionCount; i++)
		{
			partitionedStream[i] = new AssociativeAggregationOperatorEnumerator<TKey>(inputStream[i], this, i, settings.CancellationState.MergedCancellationToken);
		}
		recipient.Receive(partitionedStream);
	}

	internal override IEnumerable<TIntermediate> AsSequentialQuery(CancellationToken token)
	{
		throw new NotSupportedException();
	}
}
