namespace System.Linq.Parallel;

internal struct Pair<T, U>
{
	internal T m_first;

	internal U m_second;

	public T First
	{
		get
		{
			return m_first;
		}
		set
		{
			m_first = value;
		}
	}

	public U Second
	{
		get
		{
			return m_second;
		}
		set
		{
			m_second = value;
		}
	}

	public Pair(T first, U second)
	{
		m_first = first;
		m_second = second;
	}
}
