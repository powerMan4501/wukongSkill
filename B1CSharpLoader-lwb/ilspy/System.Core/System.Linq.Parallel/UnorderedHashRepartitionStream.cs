using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal class UnorderedHashRepartitionStream<TInputOutput, THashKey, TIgnoreKey> : HashRepartitionStream<TInputOutput, THashKey, int>
{
	internal UnorderedHashRepartitionStream(PartitionedStream<TInputOutput, TIgnoreKey> inputStream, Func<TInputOutput, THashKey> keySelector, IEqualityComparer<THashKey> keyComparer, IEqualityComparer<TInputOutput> elementComparer, CancellationToken cancellationToken)
		: base(inputStream.PartitionCount, (IComparer<int>)Util.GetDefaultComparer<int>(), keyComparer, elementComparer)
	{
		QueryOperatorEnumerator<Pair<TInputOutput, THashKey>, int>[] partitions = new HashRepartitionEnumerator<TInputOutput, THashKey, TIgnoreKey>[inputStream.PartitionCount];
		m_partitions = partitions;
		CountdownEvent barrier = new CountdownEvent(inputStream.PartitionCount);
		ListChunk<Pair<TInputOutput, THashKey>>[,] valueExchangeMatrix = new ListChunk<Pair<TInputOutput, THashKey>>[inputStream.PartitionCount, inputStream.PartitionCount];
		for (int i = 0; i < inputStream.PartitionCount; i++)
		{
			m_partitions[i] = new HashRepartitionEnumerator<TInputOutput, THashKey, TIgnoreKey>(inputStream[i], inputStream.PartitionCount, i, keySelector, this, barrier, valueExchangeMatrix, cancellationToken);
		}
	}
}
