using System.Collections.Generic;

namespace System.Linq.Parallel;

internal class ArrayMergeHelper<TInputOutput> : IMergeHelper<TInputOutput>
{
	private QueryResults<TInputOutput> m_queryResults;

	private TInputOutput[] m_outputArray;

	private QuerySettings m_settings;

	public ArrayMergeHelper(QuerySettings settings, QueryResults<TInputOutput> queryResults)
	{
		m_settings = settings;
		m_queryResults = queryResults;
		int count = m_queryResults.Count;
		m_outputArray = new TInputOutput[count];
	}

	private void ToArrayElement(int index)
	{
		m_outputArray[index] = m_queryResults[index];
	}

	public void Execute()
	{
		ParallelQuery<int> source = ParallelEnumerable.Range(0, m_queryResults.Count);
		source = new QueryExecutionOption<int>(QueryOperator<int>.AsQueryOperator(source), m_settings);
		source.ForAll(ToArrayElement);
	}

	public IEnumerator<TInputOutput> GetEnumerator()
	{
		return ((IEnumerable<TInputOutput>)GetResultsAsArray()).GetEnumerator();
	}

	public TInputOutput[] GetResultsAsArray()
	{
		return m_outputArray;
	}
}
