using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal class QueryExecutionOption<TSource> : QueryOperator<TSource>
{
	private QueryOperator<TSource> m_child;

	private OrdinalIndexState m_indexState;

	internal override OrdinalIndexState OrdinalIndexState => m_indexState;

	internal override bool LimitsParallelism => m_child.LimitsParallelism;

	internal QueryExecutionOption(QueryOperator<TSource> source, QuerySettings settings)
		: base(source.OutputOrdered, settings.Merge(source.SpecifiedQuerySettings))
	{
		m_child = source;
		m_indexState = m_child.OrdinalIndexState;
	}

	internal override QueryResults<TSource> Open(QuerySettings settings, bool preferStriping)
	{
		return m_child.Open(settings, preferStriping);
	}

	internal override IEnumerable<TSource> AsSequentialQuery(CancellationToken token)
	{
		return m_child.AsSequentialQuery(token);
	}
}
