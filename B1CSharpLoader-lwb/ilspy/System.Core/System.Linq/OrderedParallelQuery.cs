using System.Collections.Generic;
using System.Linq.Parallel;

namespace System.Linq;

[global::__DynamicallyInvokable]
public class OrderedParallelQuery<TSource> : ParallelQuery<TSource>
{
	private QueryOperator<TSource> m_sortOp;

	internal QueryOperator<TSource> SortOperator => m_sortOp;

	internal IOrderedEnumerable<TSource> OrderedEnumerable => (IOrderedEnumerable<TSource>)m_sortOp;

	internal OrderedParallelQuery(QueryOperator<TSource> sortOp)
		: base(sortOp.SpecifiedQuerySettings)
	{
		m_sortOp = sortOp;
	}

	[global::__DynamicallyInvokable]
	public override IEnumerator<TSource> GetEnumerator()
	{
		return m_sortOp.GetEnumerator();
	}
}
