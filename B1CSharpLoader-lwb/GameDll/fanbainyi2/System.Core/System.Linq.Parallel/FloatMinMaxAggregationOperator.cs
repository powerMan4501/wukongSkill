using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class FloatMinMaxAggregationOperator : InlinedAggregationOperator<float, float, float>
{
	private class FloatMinMaxAggregationOperatorEnumerator<TKey> : InlinedAggregationOperatorEnumerator<float>
	{
		private QueryOperatorEnumerator<float, TKey> m_source;

		private int m_sign;

		internal FloatMinMaxAggregationOperatorEnumerator(QueryOperatorEnumerator<float, TKey> source, int partitionIndex, int sign, CancellationToken cancellationToken)
			: base(partitionIndex, cancellationToken)
		{
			m_source = source;
			m_sign = sign;
		}

		protected override bool MoveNextCore(ref float currentElement)
		{
			QueryOperatorEnumerator<float, TKey> source = m_source;
			TKey currentKey = default(TKey);
			if (source.MoveNext(ref currentElement, ref currentKey))
			{
				int num = 0;
				if (m_sign == -1)
				{
					float currentElement2 = 0f;
					while (source.MoveNext(ref currentElement2, ref currentKey))
					{
						if ((num++ & 0x3F) == 0)
						{
							CancellationState.ThrowIfCanceled(m_cancellationToken);
						}
						if (currentElement2 < currentElement || float.IsNaN(currentElement2))
						{
							currentElement = currentElement2;
						}
					}
				}
				else
				{
					float currentElement3 = 0f;
					while (source.MoveNext(ref currentElement3, ref currentKey))
					{
						if ((num++ & 0x3F) == 0)
						{
							CancellationState.ThrowIfCanceled(m_cancellationToken);
						}
						if (currentElement3 > currentElement || float.IsNaN(currentElement))
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

	internal FloatMinMaxAggregationOperator(IEnumerable<float> child, int sign)
		: base(child)
	{
		m_sign = sign;
	}

	protected override float InternalAggregate(ref Exception singularExceptionToThrow)
	{
		using IEnumerator<float> enumerator = GetEnumerator(ParallelMergeOptions.FullyBuffered, suppressOrderPreservation: true);
		if (!enumerator.MoveNext())
		{
			singularExceptionToThrow = new InvalidOperationException(SR.GetString("NoElements"));
			return 0f;
		}
		float num = enumerator.Current;
		if (m_sign == -1)
		{
			while (enumerator.MoveNext())
			{
				float current = enumerator.Current;
				if (current < num || float.IsNaN(current))
				{
					num = current;
				}
			}
		}
		else
		{
			while (enumerator.MoveNext())
			{
				float current2 = enumerator.Current;
				if (current2 > num || float.IsNaN(num))
				{
					num = current2;
				}
			}
		}
		return num;
	}

	protected override QueryOperatorEnumerator<float, int> CreateEnumerator<TKey>(int index, int count, QueryOperatorEnumerator<float, TKey> source, object sharedData, CancellationToken cancellationToken)
	{
		return new FloatMinMaxAggregationOperatorEnumerator<TKey>(source, index, m_sign, cancellationToken);
	}
}
