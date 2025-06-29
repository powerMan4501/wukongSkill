using System.Collections.Generic;

namespace System.Linq.Parallel;

internal class FixedMaxHeap<TElement>
{
	private TElement[] m_elements;

	private int m_count;

	private IComparer<TElement> m_comparer;

	internal int Count => m_count;

	internal int Size => m_elements.Length;

	internal TElement MaxValue
	{
		get
		{
			if (m_count == 0)
			{
				throw new InvalidOperationException(SR.GetString("NoElements"));
			}
			return m_elements[0];
		}
	}

	internal FixedMaxHeap(int maximumSize)
		: this(maximumSize, (IComparer<TElement>)Util.GetDefaultComparer<TElement>())
	{
	}

	internal FixedMaxHeap(int maximumSize, IComparer<TElement> comparer)
	{
		m_elements = new TElement[maximumSize];
		m_comparer = comparer;
	}

	internal void Clear()
	{
		m_count = 0;
	}

	internal bool Insert(TElement e)
	{
		if (m_count < m_elements.Length)
		{
			m_elements[m_count] = e;
			m_count++;
			HeapifyLastLeaf();
			return true;
		}
		if (m_comparer.Compare(e, m_elements[0]) < 0)
		{
			m_elements[0] = e;
			HeapifyRoot();
			return true;
		}
		return false;
	}

	internal void ReplaceMax(TElement newValue)
	{
		m_elements[0] = newValue;
		HeapifyRoot();
	}

	internal void RemoveMax()
	{
		m_count--;
		if (m_count > 0)
		{
			m_elements[0] = m_elements[m_count];
			HeapifyRoot();
		}
	}

	private void Swap(int i, int j)
	{
		TElement val = m_elements[i];
		m_elements[i] = m_elements[j];
		m_elements[j] = val;
	}

	private void HeapifyRoot()
	{
		int num = 0;
		int count = m_count;
		while (num < count)
		{
			int num2 = (num + 1) * 2 - 1;
			int num3 = num2 + 1;
			if (num2 < count && m_comparer.Compare(m_elements[num], m_elements[num2]) < 0)
			{
				if (num3 < count && m_comparer.Compare(m_elements[num2], m_elements[num3]) < 0)
				{
					Swap(num, num3);
					num = num3;
				}
				else
				{
					Swap(num, num2);
					num = num2;
				}
			}
			else
			{
				if (num3 >= count || m_comparer.Compare(m_elements[num], m_elements[num3]) >= 0)
				{
					break;
				}
				Swap(num, num3);
				num = num3;
			}
		}
	}

	private void HeapifyLastLeaf()
	{
		int num = m_count - 1;
		while (num > 0)
		{
			int num2 = (num + 1) / 2 - 1;
			if (m_comparer.Compare(m_elements[num], m_elements[num2]) > 0)
			{
				Swap(num, num2);
				num = num2;
				continue;
			}
			break;
		}
	}
}
