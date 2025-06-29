using System.Threading;

namespace System.Linq.Parallel;

internal class OrderedHashRepartitionEnumerator<TInputOutput, THashKey, TOrderKey> : QueryOperatorEnumerator<Pair<TInputOutput, THashKey>, TOrderKey>
{
	private class Mutables
	{
		internal int m_currentBufferIndex;

		internal ListChunk<Pair<TInputOutput, THashKey>> m_currentBuffer;

		internal ListChunk<TOrderKey> m_currentKeyBuffer;

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

	private readonly HashRepartitionStream<TInputOutput, THashKey, TOrderKey> m_repartitionStream;

	private readonly ListChunk<Pair<TInputOutput, THashKey>>[,] m_valueExchangeMatrix;

	private readonly ListChunk<TOrderKey>[,] m_keyExchangeMatrix;

	private readonly QueryOperatorEnumerator<TInputOutput, TOrderKey> m_source;

	private CountdownEvent m_barrier;

	private readonly CancellationToken m_cancellationToken;

	private Mutables m_mutables;

	internal OrderedHashRepartitionEnumerator(QueryOperatorEnumerator<TInputOutput, TOrderKey> source, int partitionCount, int partitionIndex, Func<TInputOutput, THashKey> keySelector, OrderedHashRepartitionStream<TInputOutput, THashKey, TOrderKey> repartitionStream, CountdownEvent barrier, ListChunk<Pair<TInputOutput, THashKey>>[,] valueExchangeMatrix, ListChunk<TOrderKey>[,] keyExchangeMatrix, CancellationToken cancellationToken)
	{
		m_source = source;
		m_partitionCount = partitionCount;
		m_partitionIndex = partitionIndex;
		m_keySelector = keySelector;
		m_repartitionStream = repartitionStream;
		m_barrier = barrier;
		m_valueExchangeMatrix = valueExchangeMatrix;
		m_keyExchangeMatrix = keyExchangeMatrix;
		m_cancellationToken = cancellationToken;
	}

	internal override bool MoveNext(ref Pair<TInputOutput, THashKey> currentElement, ref TOrderKey currentKey)
	{
		if (m_partitionCount == 1)
		{
			TInputOutput currentElement2 = default(TInputOutput);
			if (m_source.MoveNext(ref currentElement2, ref currentKey))
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
					currentKey = mutables.m_currentKeyBuffer.m_chunk[mutables.m_currentIndex];
					return true;
				}
				mutables.m_currentIndex = -1;
				mutables.m_currentBuffer = mutables.m_currentBuffer.Next;
				mutables.m_currentKeyBuffer = mutables.m_currentKeyBuffer.Next;
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
				mutables.m_currentKeyBuffer = m_keyExchangeMatrix[mutables.m_currentBufferIndex, m_partitionIndex];
			}
		}
		return false;
	}

	private void EnumerateAndRedistributeElements()
	{
		Mutables mutables = m_mutables;
		ListChunk<Pair<TInputOutput, THashKey>>[] array = new ListChunk<Pair<TInputOutput, THashKey>>[m_partitionCount];
		ListChunk<TOrderKey>[] array2 = new ListChunk<TOrderKey>[m_partitionCount];
		TInputOutput currentElement = default(TInputOutput);
		TOrderKey currentKey = default(TOrderKey);
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
			ListChunk<TOrderKey> listChunk2 = array2[num2];
			if (listChunk == null)
			{
				listChunk = (array[num2] = new ListChunk<Pair<TInputOutput, THashKey>>(128));
				listChunk2 = (array2[num2] = new ListChunk<TOrderKey>(128));
			}
			listChunk.Add(new Pair<TInputOutput, THashKey>(currentElement, val));
			listChunk2.Add(currentKey);
		}
		for (int i = 0; i < m_partitionCount; i++)
		{
			m_valueExchangeMatrix[m_partitionIndex, i] = array[i];
			m_keyExchangeMatrix[m_partitionIndex, i] = array2[i];
		}
		m_barrier.Signal();
		mutables.m_currentBufferIndex = m_partitionIndex;
		mutables.m_currentBuffer = array[m_partitionIndex];
		mutables.m_currentKeyBuffer = array2[m_partitionIndex];
		mutables.m_currentIndex = -1;
	}

	protected override void Dispose(bool disposing)
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
