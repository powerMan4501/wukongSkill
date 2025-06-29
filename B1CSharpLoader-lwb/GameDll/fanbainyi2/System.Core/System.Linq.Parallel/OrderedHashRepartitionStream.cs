using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal class OrderedHashRepartitionStream<TInputOutput, THashKey, TOrderKey> : HashRepartitionStream<TInputOutput, THashKey, TOrderKey>
{
	internal OrderedHashRepartitionStream(PartitionedStream<TInputOutput, TOrderKey> inputStream, Func<TInputOutput, THashKey> hashKeySelector, IEqualityComparer<THashKey> hashKeyComparer, IEqualityComparer<TInputOutput> elementComparer, CancellationToken cancellationToken)
		: base(inputStream.PartitionCount, inputStream.KeyComparer, hashKeyComparer, elementComparer)
	{
		QueryOperatorEnumerator<Pair<TInputOutput, THashKey>, TOrderKey>[] partitions = new OrderedHashRepartitionEnumerator<TInputOutput, THashKey, TOrderKey>[inputStream.PartitionCount];
		m_partitions = partitions;
		CountdownEvent barrier = new CountdownEvent(inputStream.PartitionCount);
		ListChunk<Pair<TInputOutput, THashKey>>[,] valueExchangeMatrix = new ListChunk<Pair<TInputOutput, THashKey>>[inputStream.PartitionCount, inputStream.PartitionCount];
		ListChunk<TOrderKey>[,] keyExchangeMatrix = new ListChunk<TOrderKey>[inputStream.PartitionCount, inputStream.PartitionCount];
		for (int i = 0; i < inputStream.PartitionCount; i++)
		{
			m_partitions[i] = new OrderedHashRepartitionEnumerator<TInputOutput, THashKey, TOrderKey>(inputStream[i], inputStream.PartitionCount, i, hashKeySelector, this, barrier, valueExchangeMatrix, keyExchangeMatrix, cancellationToken);
		}
	}
}
