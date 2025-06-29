using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class NullableDoubleSumAggregationOperator : InlinedAggregationOperator<double?, double?, double?>
{
	private class NullableDoubleSumAggregationOperatorEnumerator<TKey> : InlinedAggregationOperatorEnumerator<double?>
	{
		private readonly QueryOperatorEnumerator<double?, TKey> m_source;

		internal NullableDoubleSumAggregationOperatorEnumerator(QueryOperatorEnumerator<double?, TKey> source, int partitionIndex, CancellationToken cancellationToken)
			: base(partitionIndex, cancellationToken)
		{
			m_source = source;
		}

		protected override bool MoveNextCore(ref double? currentElement)
		{
			double? currentElement2 = null;
			TKey currentKey = default(TKey);
			QueryOperatorEnumerator<double?, TKey> source = m_source;
			if (source.MoveNext(ref currentElement2, ref currentKey))
			{
				double num = 0.0;
				int num2 = 0;
				do
				{
					if ((num2++ & 0x3F) == 0)
					{
						CancellationState.ThrowIfCanceled(m_cancellationToken);
					}
					num += currentElement2.GetValueOrDefault();
				}
				while (source.MoveNext(ref currentElement2, ref currentKey));
				currentElement = num;
				return true;
			}
			return false;
		}

		protected override void Dispose(bool disposing)
		{
			m_source.Dispose();
		}
	}

	internal NullableDoubleSumAggregationOperator(IEnumerable<double?> child)
		: base(child)
	{
	}

	protected override double? InternalAggregate(ref Exception singularExceptionToThrow)
	{
		using IEnumerator<double?> enumerator = GetEnumerator(ParallelMergeOptions.FullyBuffered, suppressOrderPreservation: true);
		double num = 0.0;
		while (enumerator.MoveNext())
		{
			num += enumerator.Current.GetValueOrDefault();
		}
		return num;
	}

	protected override QueryOperatorEnumerator<double?, int> CreateEnumerator<TKey>(int index, int count, QueryOperatorEnumerator<double?, TKey> source, object sharedData, CancellationToken cancellationToken)
	{
		return new NullableDoubleSumAggregationOperatorEnumerator<TKey>(source, index, cancellationToken);
	}
}
