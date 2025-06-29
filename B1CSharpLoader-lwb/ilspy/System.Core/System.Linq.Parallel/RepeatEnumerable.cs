using System.Collections.Generic;

namespace System.Linq.Parallel;

internal class RepeatEnumerable<TResult> : ParallelQuery<TResult>, IParallelPartitionable<TResult>
{
	private class RepeatEnumerator : QueryOperatorEnumerator<TResult, int>
	{
		private readonly TResult m_element;

		private readonly int m_count;

		private readonly int m_indexOffset;

		private Shared<int> m_currentIndex;

		internal RepeatEnumerator(TResult element, int count, int indexOffset)
		{
			m_element = element;
			m_count = count;
			m_indexOffset = indexOffset;
		}

		internal override bool MoveNext(ref TResult currentElement, ref int currentKey)
		{
			if (m_currentIndex == null)
			{
				m_currentIndex = new Shared<int>(-1);
			}
			if (m_currentIndex.Value < m_count - 1)
			{
				m_currentIndex.Value++;
				currentElement = m_element;
				currentKey = m_currentIndex.Value + m_indexOffset;
				return true;
			}
			return false;
		}

		internal override void Reset()
		{
			m_currentIndex = null;
		}
	}

	private TResult m_element;

	private int m_count;

	internal RepeatEnumerable(TResult element, int count)
		: base(QuerySettings.Empty)
	{
		m_element = element;
		m_count = count;
	}

	public QueryOperatorEnumerator<TResult, int>[] GetPartitions(int partitionCount)
	{
		int num = (m_count + partitionCount - 1) / partitionCount;
		QueryOperatorEnumerator<TResult, int>[] array = new QueryOperatorEnumerator<TResult, int>[partitionCount];
		int num2 = 0;
		int num3 = 0;
		while (num2 < partitionCount)
		{
			if (num3 + num > m_count)
			{
				array[num2] = new RepeatEnumerator(m_element, (num3 < m_count) ? (m_count - num3) : 0, num3);
			}
			else
			{
				array[num2] = new RepeatEnumerator(m_element, num, num3);
			}
			num2++;
			num3 += num;
		}
		return array;
	}

	public override IEnumerator<TResult> GetEnumerator()
	{
		return new RepeatEnumerator(m_element, m_count, 0).AsClassicEnumerator();
	}
}
