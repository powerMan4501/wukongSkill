namespace System.Linq.Parallel;

internal class GrowingArray<T>
{
	private T[] m_array;

	private int m_count;

	private const int DEFAULT_ARRAY_SIZE = 1024;

	internal T[] InternalArray => m_array;

	internal int Count => m_count;

	internal GrowingArray()
	{
		m_array = new T[1024];
		m_count = 0;
	}

	internal void Add(T element)
	{
		if (m_count >= m_array.Length)
		{
			GrowArray(2 * m_array.Length);
		}
		m_array[m_count++] = element;
	}

	private void GrowArray(int newSize)
	{
		T[] array = new T[newSize];
		m_array.CopyTo(array, 0);
		m_array = array;
	}

	internal void CopyFrom(T[] otherArray, int otherCount)
	{
		if (m_count + otherCount > m_array.Length)
		{
			GrowArray(m_count + otherCount);
		}
		Array.Copy(otherArray, 0, m_array, m_count, otherCount);
		m_count += otherCount;
	}
}
