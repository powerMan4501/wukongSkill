namespace System.Threading;

internal class SparselyPopulatedArray<T> where T : class
{
	private readonly SparselyPopulatedArrayFragment<T> m_head;

	private volatile SparselyPopulatedArrayFragment<T> m_tail;

	internal SparselyPopulatedArrayFragment<T> Tail => m_tail;

	internal SparselyPopulatedArray(int initialSize)
	{
		m_head = (m_tail = new SparselyPopulatedArrayFragment<T>(initialSize));
	}

	internal SparselyPopulatedArrayAddInfo<T> Add(T element)
	{
		while (true)
		{
			SparselyPopulatedArrayFragment<T> sparselyPopulatedArrayFragment = m_tail;
			while (sparselyPopulatedArrayFragment.m_next != null)
			{
				sparselyPopulatedArrayFragment = (m_tail = sparselyPopulatedArrayFragment.m_next);
			}
			for (SparselyPopulatedArrayFragment<T> sparselyPopulatedArrayFragment2 = sparselyPopulatedArrayFragment; sparselyPopulatedArrayFragment2 != null; sparselyPopulatedArrayFragment2 = sparselyPopulatedArrayFragment2.m_prev)
			{
				if (sparselyPopulatedArrayFragment2.m_freeCount < 1)
				{
					sparselyPopulatedArrayFragment2.m_freeCount--;
				}
				if (sparselyPopulatedArrayFragment2.m_freeCount > 0 || sparselyPopulatedArrayFragment2.m_freeCount < -10)
				{
					int length = sparselyPopulatedArrayFragment2.Length;
					int num = (length - sparselyPopulatedArrayFragment2.m_freeCount) % length;
					if (num < 0)
					{
						num = 0;
						sparselyPopulatedArrayFragment2.m_freeCount--;
					}
					for (int i = 0; i < length; i++)
					{
						int num2 = (num + i) % length;
						if (sparselyPopulatedArrayFragment2.m_elements[num2] == null && Interlocked.CompareExchange(ref sparselyPopulatedArrayFragment2.m_elements[num2], element, null) == null)
						{
							int num3 = sparselyPopulatedArrayFragment2.m_freeCount - 1;
							sparselyPopulatedArrayFragment2.m_freeCount = ((num3 > 0) ? num3 : 0);
							return new SparselyPopulatedArrayAddInfo<T>(sparselyPopulatedArrayFragment2, num2);
						}
					}
				}
			}
			SparselyPopulatedArrayFragment<T> sparselyPopulatedArrayFragment3 = new SparselyPopulatedArrayFragment<T>((sparselyPopulatedArrayFragment.m_elements.Length == 4096) ? 4096 : (sparselyPopulatedArrayFragment.m_elements.Length * 2), sparselyPopulatedArrayFragment);
			if (Interlocked.CompareExchange(ref sparselyPopulatedArrayFragment.m_next, sparselyPopulatedArrayFragment3, null) == null)
			{
				m_tail = sparselyPopulatedArrayFragment3;
			}
		}
	}
}
