using System.Collections;
using System.Collections.Generic;

namespace System.Linq.Parallel;

internal class ListChunk<TInputOutput> : IEnumerable<TInputOutput>, IEnumerable
{
	internal TInputOutput[] m_chunk;

	private int m_chunkCount;

	private ListChunk<TInputOutput> m_nextChunk;

	private ListChunk<TInputOutput> m_tailChunk;

	internal ListChunk<TInputOutput> Next => m_nextChunk;

	internal int Count => m_chunkCount;

	internal ListChunk(int size)
	{
		m_chunk = new TInputOutput[size];
		m_chunkCount = 0;
		m_tailChunk = this;
	}

	internal void Add(TInputOutput e)
	{
		ListChunk<TInputOutput> listChunk = m_tailChunk;
		if (listChunk.m_chunkCount == listChunk.m_chunk.Length)
		{
			m_tailChunk = new ListChunk<TInputOutput>(listChunk.m_chunkCount * 2);
			listChunk = (listChunk.m_nextChunk = m_tailChunk);
		}
		listChunk.m_chunk[listChunk.m_chunkCount++] = e;
	}

	public IEnumerator<TInputOutput> GetEnumerator()
	{
		for (ListChunk<TInputOutput> curr = this; curr != null; curr = curr.m_nextChunk)
		{
			for (int i = 0; i < curr.m_chunkCount; i++)
			{
				yield return curr.m_chunk[i];
			}
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<TInputOutput>)this).GetEnumerator();
	}
}
