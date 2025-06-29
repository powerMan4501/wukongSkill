namespace System.Threading;

internal struct SparselyPopulatedArrayAddInfo<T> where T : class
{
	private SparselyPopulatedArrayFragment<T> m_source;

	private int m_index;

	internal SparselyPopulatedArrayFragment<T> Source => m_source;

	internal int Index => m_index;

	internal SparselyPopulatedArrayAddInfo(SparselyPopulatedArrayFragment<T> source, int index)
	{
		m_source = source;
		m_index = index;
	}
}
