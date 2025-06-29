using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class DecimalMinMaxAggregationOperator : InlinedAggregationOperator<decimal, decimal, decimal>
{
	private class DecimalMinMaxAggregationOperatorEnumerator<TKey> : InlinedAggregationOperatorEnumerator<decimal>
	{
		private QueryOperatorEnumerator<decimal, TKey> m_source;

		private int m_sign;

		internal DecimalMinMaxAggregationOperatorEnumerator(QueryOperatorEnumerator<decimal, TKey> source, int partitionIndex, int sign, CancellationToken cancellationToken)
			: base(partitionIndex, cancellationToken)
		{
			m_source = source;
			m_sign = sign;
		}

		protected override bool MoveNextCore(ref decimal currentElement)
		{
			QueryOperatorEnumerator<decimal, TKey> source = m_source;
			TKey currentKey = default(TKey);
			if (source.MoveNext(ref currentElement, ref currentKey))
			{
				int num = 0;
				if (m_sign == -1)
				{
					decimal currentElement2 = default(decimal);
					while (source.MoveNext(ref currentElement2, ref currentKey))
					{
						if ((num++ & 0x3F) == 0)
						{
							CancellationState.ThrowIfCanceled(m_cancellationToken);
						}
						if (currentElement2 < currentElement)
						{
							currentElement = currentElement2;
						}
					}
				}
				else
				{
					decimal currentElement3 = default(decimal);
					while (source.MoveNext(ref currentElement3, ref currentKey))
					{
						if ((num++ & 0x3F) == 0)
						{
							CancellationState.ThrowIfCanceled(m_cancellationToken);
						}
						if (currentElement3 > currentElement)
						{
							currentElement = currentElement3;
						}
					}
				}
				return true;
			}
			return false;
		}

		protected override void Dispose(bool disposing)
		{
			m_source.Dispose();
		}
	}

	private readonly int m_sign;

	internal DecimalMinMaxAggregationOperator(IEnumerable<decimal> child, int sign)
		: base(child)
	{
		m_sign = sign;
	}

	protected override decimal InternalAggregate(ref Exception singularExceptionToThrow)
	{
		using IEnumerator<decimal> enumerator = GetEnumerator(ParallelMergeOptions.FullyBuffered, suppressOrderPreservation: true);
		if (!enumerator.MoveNext())
		{
			singularExceptionToThrow = new InvalidOperationException(SR.GetString("NoElements"));
			return 0m;
		}
		decimal num = enumerator.Current;
		if (m_sign == -1)
		{
			while (enumerator.MoveNext())
			{
				decimal current = enumerator.Current;
				if (current < num)
				{
					num = current;
				}
			}
		}
		else
		{
			while (enumerator.MoveNext())
			{
				decimal current2 = enumerator.Current;
				if (current2 > num)
				{
					num = current2;
				}
			}
		}
		return num;
	}

	protected override QueryOperatorEnumerator<decimal, int> CreateEnumerator<TKey>(int index, int count, QueryOperatorEnumerator<decimal, TKey> source, object sharedData, CancellationToken cancellationToken)
	{
		return new DecimalMinMaxAggregationOperatorEnumerator<TKey>(source, index, m_sign, cancellationToken);
	}
}
