using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class OrderingQueryOperator<TSource> : QueryOperator<TSource>
{
	private bool m_orderOn;

	private QueryOperator<TSource> m_child;

	private OrdinalIndexState m_ordinalIndexState;

	internal override bool LimitsParallelism => m_child.LimitsParallelism;

	internal override OrdinalIndexState OrdinalIndexState => m_ordinalIndexState;

	public OrderingQueryOperator(QueryOperator<TSource> child, bool orderOn)
		: base(orderOn, child.SpecifiedQuerySettings)
	{
		m_child = child;
		m_ordinalIndexState = m_child.OrdinalIndexState;
		m_orderOn = orderOn;
	}

	internal override QueryResults<TSource> Open(QuerySettings settings, bool preferStriping)
	{
		return m_child.Open(settings, preferStriping);
	}

	internal override IEnumerator<TSource> GetEnumerator(ParallelMergeOptions? mergeOptions, bool suppressOrderPreservation)
	{
		if (m_child is ScanQueryOperator<TSource> scanQueryOperator)
		{
			return scanQueryOperator.Data.GetEnumerator();
		}
		return base.GetEnumerator(mergeOptions, suppressOrderPreservation);
	}

	internal override IEnumerable<TSource> AsSequentialQuery(CancellationToken token)
	{
		return m_child.AsSequentialQuery(token);
	}
}
