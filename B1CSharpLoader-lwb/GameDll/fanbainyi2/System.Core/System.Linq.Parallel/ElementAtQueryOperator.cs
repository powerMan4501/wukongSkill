using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class ElementAtQueryOperator<TSource> : UnaryQueryOperator<TSource, TSource>
{
	private class ElementAtQueryOperatorEnumerator : QueryOperatorEnumerator<TSource, int>
	{
		private QueryOperatorEnumerator<TSource, int> m_source;

		private int m_index;

		private Shared<bool> m_resultFoundFlag;

		private CancellationToken m_cancellationToken;

		internal ElementAtQueryOperatorEnumerator(QueryOperatorEnumerator<TSource, int> source, int index, Shared<bool> resultFoundFlag, CancellationToken cancellationToken)
		{
			m_source = source;
			m_index = index;
			m_resultFoundFlag = resultFoundFlag;
			m_cancellationToken = cancellationToken;
		}

		internal override bool MoveNext(ref TSource currentElement, ref int currentKey)
		{
			int num = 0;
			while (m_source.MoveNext(ref currentElement, ref currentKey))
			{
				if ((num++ & 0x3F) == 0)
				{
					CancellationState.ThrowIfCanceled(m_cancellationToken);
				}
				if (m_resultFoundFlag.Value)
				{
					break;
				}
				if (currentKey == m_index)
				{
					m_resultFoundFlag.Value = true;
					return true;
				}
			}
			return false;
		}

		protected override void Dispose(bool disposing)
		{
			m_source.Dispose();
		}
	}

	private readonly int m_index;

	private readonly bool m_prematureMerge;

	private readonly bool m_limitsParallelism;

	internal override bool LimitsParallelism => m_limitsParallelism;

	internal ElementAtQueryOperator(IEnumerable<TSource> child, int index)
		: base(child)
	{
		m_index = index;
		OrdinalIndexState ordinalIndexState = base.Child.OrdinalIndexState;
		if (ordinalIndexState.IsWorseThan(OrdinalIndexState.Correct))
		{
			m_prematureMerge = true;
			m_limitsParallelism = ordinalIndexState != OrdinalIndexState.Shuffled;
		}
	}

	internal override QueryResults<TSource> Open(QuerySettings settings, bool preferStriping)
	{
		QueryResults<TSource> childQueryResults = base.Child.Open(settings, preferStriping: false);
		return new UnaryQueryOperatorResults(childQueryResults, this, settings, preferStriping);
	}

	internal override void WrapPartitionedStream<TKey>(PartitionedStream<TSource, TKey> inputStream, IPartitionedStreamRecipient<TSource> recipient, bool preferStriping, QuerySettings settings)
	{
		int partitionCount = inputStream.PartitionCount;
		PartitionedStream<TSource, int> partitionedStream = ((!m_prematureMerge) ? ((PartitionedStream<TSource, int>)(object)inputStream) : QueryOperator<TSource>.ExecuteAndCollectResults(inputStream, partitionCount, base.Child.OutputOrdered, preferStriping, settings).GetPartitionedStream());
		Shared<bool> resultFoundFlag = new Shared<bool>(value: false);
		PartitionedStream<TSource, int> partitionedStream2 = new PartitionedStream<TSource, int>(partitionCount, Util.GetDefaultComparer<int>(), OrdinalIndexState.Correct);
		for (int i = 0; i < partitionCount; i++)
		{
			partitionedStream2[i] = new ElementAtQueryOperatorEnumerator(partitionedStream[i], m_index, resultFoundFlag, settings.CancellationState.MergedCancellationToken);
		}
		recipient.Receive(partitionedStream2);
	}

	internal override IEnumerable<TSource> AsSequentialQuery(CancellationToken token)
	{
		throw new NotSupportedException();
	}

	internal bool Aggregate(out TSource result, bool withDefaultValue)
	{
		if (LimitsParallelism && base.SpecifiedQuerySettings.WithDefaults().ExecutionMode.Value != ParallelExecutionMode.ForceParallelism)
		{
			CancellationState cancellationState = base.SpecifiedQuerySettings.CancellationState;
			if (withDefaultValue)
			{
				IEnumerable<TSource> source = base.Child.AsSequentialQuery(cancellationState.ExternalCancellationToken);
				IEnumerable<TSource> source2 = CancellableEnumerable.Wrap(source, cancellationState.ExternalCancellationToken);
				result = ExceptionAggregator.WrapEnumerable(source2, cancellationState).ElementAtOrDefault(m_index);
			}
			else
			{
				IEnumerable<TSource> source3 = base.Child.AsSequentialQuery(cancellationState.ExternalCancellationToken);
				IEnumerable<TSource> source4 = CancellableEnumerable.Wrap(source3, cancellationState.ExternalCancellationToken);
				result = ExceptionAggregator.WrapEnumerable(source4, cancellationState).ElementAt(m_index);
			}
			return true;
		}
		using (IEnumerator<TSource> enumerator = GetEnumerator(ParallelMergeOptions.FullyBuffered))
		{
			if (enumerator.MoveNext())
			{
				TSource current = enumerator.Current;
				result = current;
				return true;
			}
		}
		result = default(TSource);
		return false;
	}
}
