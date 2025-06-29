using System.Collections.Generic;

namespace System.Linq.Parallel;

internal class RangeEnumerable : ParallelQuery<int>, IParallelPartitionable<int>
{
	private class RangeEnumerator : QueryOperatorEnumerator<int, int>
	{
		private readonly int m_from;

		private readonly int m_count;

		private readonly int m_initialIndex;

		private Shared<int> m_currentCount;

		internal RangeEnumerator(int from, int count, int initialIndex)
		{
			m_from = from;
			m_count = count;
			m_initialIndex = initialIndex;
		}

		internal override bool MoveNext(ref int currentElement, ref int currentKey)
		{
			if (m_currentCount == null)
			{
				m_currentCount = new Shared<int>(-1);
			}
			int num = m_currentCount.Value + 1;
			if (num < m_count)
			{
				m_currentCount.Value = num;
				currentElement = num + m_from;
				currentKey = num + m_initialIndex;
				return true;
			}
			return false;
		}

		internal override void Reset()
		{
			m_currentCount = null;
		}
	}

	private int m_from;

	private int m_count;

	internal RangeEnumerable(int from, int count)
		: base(QuerySettings.Empty)
	{
		m_from = from;
		m_count = count;
	}

	public QueryOperatorEnumerator<int, int>[] GetPartitions(int partitionCount)
	{
		int num = m_count / partitionCount;
		int num2 = m_count % partitionCount;
		int num3 = 0;
		QueryOperatorEnumerator<int, int>[] array = new QueryOperatorEnumerator<int, int>[partitionCount];
		for (int i = 0; i < partitionCount; i++)
		{
			int num4 = ((i < num2) ? (num + 1) : num);
			array[i] = new RangeEnumerator(m_from + num3, num4, num3);
			num3 += num4;
		}
		return array;
	}

	public override IEnumerator<int> GetEnumerator()
	{
		return new RangeEnumerator(m_from, m_count, 0).AsClassicEnumerator();
	}
}
