using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class SortQueryOperator<TInputOutput, TSortKey> : UnaryQueryOperator<TInputOutput, TInputOutput>, IOrderedEnumerable<TInputOutput>, IEnumerable<TInputOutput>, IEnumerable
{
	private readonly Func<TInputOutput, TSortKey> m_keySelector;

	private readonly IComparer<TSortKey> m_comparer;

	internal Func<TInputOutput, TSortKey> KeySelector => m_keySelector;

	internal IComparer<TSortKey> KeyComparer => m_comparer;

	internal override bool LimitsParallelism => false;

	internal SortQueryOperator(IEnumerable<TInputOutput> source, Func<TInputOutput, TSortKey> keySelector, IComparer<TSortKey> comparer, bool descending)
		: base(source, outputOrdered: true)
	{
		m_keySelector = keySelector;
		if (comparer == null)
		{
			m_comparer = Util.GetDefaultComparer<TSortKey>();
		}
		else
		{
			m_comparer = comparer;
		}
		if (descending)
		{
			m_comparer = new ReverseComparer<TSortKey>(m_comparer);
		}
		SetOrdinalIndexState(OrdinalIndexState.Shuffled);
	}

	IOrderedEnumerable<TInputOutput> IOrderedEnumerable<TInputOutput>.CreateOrderedEnumerable<TKey2>(Func<TInputOutput, TKey2> key2Selector, IComparer<TKey2> key2Comparer, bool descending)
	{
		key2Comparer = key2Comparer ?? Util.GetDefaultComparer<TKey2>();
		if (descending)
		{
			key2Comparer = new ReverseComparer<TKey2>(key2Comparer);
		}
		IComparer<Pair<TSortKey, TKey2>> comparer = new PairComparer<TSortKey, TKey2>(m_comparer, key2Comparer);
		Func<TInputOutput, Pair<TSortKey, TKey2>> keySelector = (TInputOutput elem) => new Pair<TSortKey, TKey2>(m_keySelector(elem), key2Selector(elem));
		return new SortQueryOperator<TInputOutput, Pair<TSortKey, TKey2>>(base.Child, keySelector, comparer, descending: false);
	}

	internal override QueryResults<TInputOutput> Open(QuerySettings settings, bool preferStriping)
	{
		QueryResults<TInputOutput> childQueryResults = base.Child.Open(settings, preferStriping: false);
		return new SortQueryOperatorResults<TInputOutput, TSortKey>(childQueryResults, this, settings, preferStriping);
	}

	internal override void WrapPartitionedStream<TKey>(PartitionedStream<TInputOutput, TKey> inputStream, IPartitionedStreamRecipient<TInputOutput> recipient, bool preferStriping, QuerySettings settings)
	{
		PartitionedStream<TInputOutput, TSortKey> partitionedStream = new PartitionedStream<TInputOutput, TSortKey>(inputStream.PartitionCount, m_comparer, OrdinalIndexState);
		for (int i = 0; i < partitionedStream.PartitionCount; i++)
		{
			partitionedStream[i] = new SortQueryOperatorEnumerator<TInputOutput, TKey, TSortKey>(inputStream[i], m_keySelector, m_comparer);
		}
		recipient.Receive(partitionedStream);
	}

	internal override IEnumerable<TInputOutput> AsSequentialQuery(CancellationToken token)
	{
		IEnumerable<TInputOutput> source = CancellableEnumerable.Wrap(base.Child.AsSequentialQuery(token), token);
		return source.OrderBy(m_keySelector, m_comparer);
	}
}
