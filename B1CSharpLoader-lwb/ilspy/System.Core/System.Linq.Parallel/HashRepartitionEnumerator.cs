using System.Threading;

namespace System.Linq.Parallel;

internal class HashRepartitionEnumerator<TInputOutput, THashKey, TIgnoreKey> : QueryOperatorEnumerator<Pair<TInputOutput, THashKey>, int>
{
	private class Mutables
	{
		internal int m_currentBufferIndex;

		internal ListChunk<Pair<TInputOutput, THashKey>> m_currentBuffer;

		internal int m_currentIndex;

		internal Mutables()
		{
			m_currentBufferIndex = -1;
		}
	}

	private const int ENUMERATION_NOT_STARTED = -1;

	private readonly int m_partitionCount;

	private readonly int m_partitionIndex;

	private readonly Func<TInputOutput, THashKey> m_keySelector;

	private readonly HashRepartitionStream<TInputOutput, THashKey, int> m_repartitionStream;

	private readonly ListChunk<Pair<TInputOutput, THashKey>>[,] m_valueExchangeMatrix;

	private readonly QueryOperatorEnumerator<TInputOutput, TIgnoreKey> m_source;

	private CountdownEvent m_barrier;

	private readonly CancellationToken m_cancellationToken;

	private Mutables m_mutables;

	internal HashRepartitionEnumerator(QueryOperatorEnumerator<TInputOutput, TIgnoreKey> source, int partitionCount, int partitionIndex, Func<TInputOutput, THashKey> keySelector, HashRepartitionStream<TInputOutput, THashKey, int> repartitionStream, CountdownEvent barrier, ListChunk<Pair<TInputOutput, THashKey>>[,] valueExchangeMatrix, CancellationToken cancellationToken)
	{
		m_source = source;
		m_partitionCount = partitionCount;
		m_partitionIndex = partitionIndex;
		m_keySelector = keySelector;
		m_repartitionStream = repartitionStream;
		m_barrier = barrier;
		m_valueExchangeMatrix = valueExchangeMatrix;
		m_cancellationToken = cancellationToken;
	}

	internal override bool MoveNext(ref Pair<TInputOutput, THashKey> currentElement, ref int currentKey)
	{
		if (m_partitionCount == 1)
		{
			TIgnoreKey currentKey2 = default(TIgnoreKey);
			TInputOutput currentElement2 = default(TInputOutput);
			if (m_source.MoveNext(ref currentElement2, ref currentKey2))
			{
				currentElement = new Pair<TInputOutput, THashKey>(currentElement2, (m_keySelector == null) ? default(THashKey) : m_keySelector(currentElement2));
				return true;
			}
			return false;
		}
		Mutables mutables = m_mutables;
		if (mutables == null)
		{
			mutables = (m_mutables = new Mutables());
		}
		if (mutables.m_currentBufferIndex == -1)
		{
			EnumerateAndRedistributeElements();
		}
		while (mutables.m_currentBufferIndex < m_partitionCount)
		{
			if (mutables.m_currentBuffer != null)
			{
				if (++mutables.m_currentIndex < mutables.m_currentBuffer.Count)
				{
					currentElement = mutables.m_currentBuffer.m_chunk[mutables.m_currentIndex];
					return true;
				}
				mutables.m_currentIndex = -1;
				mutables.m_currentBuffer = mutables.m_currentBuffer.Next;
				continue;
			}
			if (mutables.m_currentBufferIndex == m_partitionIndex)
			{
				m_barrier.Wait(m_cancellationToken);
				mutables.m_currentBufferIndex = -1;
			}
			mutables.m_currentBufferIndex++;
			mutables.m_currentIndex = -1;
			if (mutables.m_currentBufferIndex == m_partitionIndex)
			{
				mutables.m_currentBufferIndex++;
			}
			if (mutables.m_currentBufferIndex < m_partitionCount)
			{
				mutables.m_currentBuffer = m_valueExchangeMatrix[mutables.m_currentBufferIndex, m_partitionIndex];
			}
		}
		return false;
	}

	private void EnumerateAndRedistributeElements()
	{
		Mutables mutables = m_mutables;
		ListChunk<Pair<TInputOutput, THashKey>>[] array = new ListChunk<Pair<TInputOutput, THashKey>>[m_partitionCount];
		TInputOutput currentElement = default(TInputOutput);
		TIgnoreKey currentKey = default(TIgnoreKey);
		int num = 0;
		while (m_source.MoveNext(ref currentElement, ref currentKey))
		{
			if ((num++ & 0x3F) == 0)
			{
				CancellationState.ThrowIfCanceled(m_cancellationToken);
			}
			THashKey val = default(THashKey);
			int num2;
			if (m_keySelector != null)
			{
				val = m_keySelector(currentElement);
				num2 = m_repartitionStream.GetHashCode(val) % m_partitionCount;
			}
			else
			{
				num2 = m_repartitionStream.GetHashCode(currentElement) % m_partitionCount;
			}
			ListChunk<Pair<TInputOutput, THashKey>> listChunk = array[num2];
			if (listChunk == null)
			{
				listChunk = (array[num2] = new ListChunk<Pair<TInputOutput, THashKey>>(128));
			}
			listChunk.Add(new Pair<TInputOutput, THashKey>(currentElement, val));
		}
		for (int i = 0; i < m_partitionCount; i++)
		{
			m_valueExchangeMatrix[m_partitionIndex, i] = array[i];
		}
		m_barrier.Signal();
		mutables.m_currentBufferIndex = m_partitionIndex;
		mutables.m_currentBuffer = array[m_partitionIndex];
		mutables.m_currentIndex = -1;
	}

	protected override void Dispose(bool disposed)
	{
		if (m_barrier != null)
		{
			if (m_mutables == null || m_mutables.m_currentBufferIndex == -1)
			{
				m_barrier.Signal();
				m_barrier = null;
			}
			m_source.Dispose();
		}
	}
}
