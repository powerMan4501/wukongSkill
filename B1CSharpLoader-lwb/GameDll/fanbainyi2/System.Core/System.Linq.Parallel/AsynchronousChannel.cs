using System.Threading;

namespace System.Linq.Parallel;

internal sealed class AsynchronousChannel<T> : IDisposable
{
	private T[][] m_buffer;

	private readonly int m_index;

	private volatile int m_producerBufferIndex;

	private volatile int m_consumerBufferIndex;

	private volatile bool m_done;

	private T[] m_producerChunk;

	private int m_producerChunkIndex;

	private T[] m_consumerChunk;

	private int m_consumerChunkIndex;

	private int m_chunkSize;

	private ManualResetEventSlim m_producerEvent;

	private IntValueEvent m_consumerEvent;

	private volatile int m_producerIsWaiting;

	private volatile int m_consumerIsWaiting;

	private CancellationToken m_cancellationToken;

	internal bool IsFull
	{
		get
		{
			int producerBufferIndex = m_producerBufferIndex;
			int consumerBufferIndex = m_consumerBufferIndex;
			if (producerBufferIndex != consumerBufferIndex - 1)
			{
				if (consumerBufferIndex == 0)
				{
					return producerBufferIndex == m_buffer.Length - 1;
				}
				return false;
			}
			return true;
		}
	}

	internal bool IsChunkBufferEmpty => m_producerBufferIndex == m_consumerBufferIndex;

	internal bool IsDone => m_done;

	internal AsynchronousChannel(int index, int chunkSize, CancellationToken cancellationToken, IntValueEvent consumerEvent)
		: this(index, 512, chunkSize, cancellationToken, consumerEvent)
	{
	}

	internal AsynchronousChannel(int index, int capacity, int chunkSize, CancellationToken cancellationToken, IntValueEvent consumerEvent)
	{
		if (chunkSize == 0)
		{
			chunkSize = Scheduling.GetDefaultChunkSize<T>();
		}
		m_index = index;
		m_buffer = new T[capacity + 1][];
		m_producerBufferIndex = 0;
		m_consumerBufferIndex = 0;
		m_producerEvent = new ManualResetEventSlim();
		m_consumerEvent = consumerEvent;
		m_chunkSize = chunkSize;
		m_producerChunk = new T[chunkSize];
		m_producerChunkIndex = 0;
		m_cancellationToken = cancellationToken;
	}

	internal void FlushBuffers()
	{
		FlushCachedChunk();
	}

	internal void SetDone()
	{
		m_done = true;
		lock (this)
		{
			if (m_consumerEvent != null)
			{
				m_consumerEvent.Set(m_index);
			}
		}
	}

	internal void Enqueue(T item)
	{
		int producerChunkIndex = m_producerChunkIndex;
		m_producerChunk[producerChunkIndex] = item;
		if (producerChunkIndex == m_chunkSize - 1)
		{
			EnqueueChunk(m_producerChunk);
			m_producerChunk = new T[m_chunkSize];
		}
		m_producerChunkIndex = (producerChunkIndex + 1) % m_chunkSize;
	}

	private void EnqueueChunk(T[] chunk)
	{
		if (IsFull)
		{
			WaitUntilNonFull();
		}
		int producerBufferIndex = m_producerBufferIndex;
		m_buffer[producerBufferIndex] = chunk;
		Interlocked.Exchange(ref m_producerBufferIndex, (producerBufferIndex + 1) % m_buffer.Length);
		if (m_consumerIsWaiting == 1 && !IsChunkBufferEmpty)
		{
			m_consumerIsWaiting = 0;
			m_consumerEvent.Set(m_index);
		}
	}

	private void WaitUntilNonFull()
	{
		do
		{
			m_producerEvent.Reset();
			Interlocked.Exchange(ref m_producerIsWaiting, 1);
			if (IsFull)
			{
				m_producerEvent.Wait(m_cancellationToken);
			}
			else
			{
				m_producerIsWaiting = 0;
			}
		}
		while (IsFull);
	}

	private void FlushCachedChunk()
	{
		if (m_producerChunk != null && m_producerChunkIndex != 0)
		{
			T[] array = new T[m_producerChunkIndex];
			Array.Copy(m_producerChunk, array, m_producerChunkIndex);
			EnqueueChunk(array);
			m_producerChunk = null;
		}
	}

	internal bool TryDequeue(ref T item)
	{
		if (m_consumerChunk == null)
		{
			if (!TryDequeueChunk(ref m_consumerChunk))
			{
				return false;
			}
			m_consumerChunkIndex = 0;
		}
		item = m_consumerChunk[m_consumerChunkIndex];
		m_consumerChunkIndex++;
		if (m_consumerChunkIndex == m_consumerChunk.Length)
		{
			m_consumerChunk = null;
		}
		return true;
	}

	private bool TryDequeueChunk(ref T[] chunk)
	{
		if (IsChunkBufferEmpty)
		{
			return false;
		}
		chunk = InternalDequeueChunk();
		return true;
	}

	internal bool TryDequeue(ref T item, ref bool isDone)
	{
		isDone = false;
		if (m_consumerChunk == null)
		{
			if (!TryDequeueChunk(ref m_consumerChunk, ref isDone))
			{
				return false;
			}
			m_consumerChunkIndex = 0;
		}
		item = m_consumerChunk[m_consumerChunkIndex];
		m_consumerChunkIndex++;
		if (m_consumerChunkIndex == m_consumerChunk.Length)
		{
			m_consumerChunk = null;
		}
		return true;
	}

	private bool TryDequeueChunk(ref T[] chunk, ref bool isDone)
	{
		isDone = false;
		while (IsChunkBufferEmpty)
		{
			if (IsDone && IsChunkBufferEmpty)
			{
				isDone = true;
				return false;
			}
			Interlocked.Exchange(ref m_consumerIsWaiting, 1);
			if (IsChunkBufferEmpty && !IsDone)
			{
				return false;
			}
			m_consumerIsWaiting = 0;
		}
		chunk = InternalDequeueChunk();
		return true;
	}

	private T[] InternalDequeueChunk()
	{
		int consumerBufferIndex = m_consumerBufferIndex;
		T[] result = m_buffer[consumerBufferIndex];
		m_buffer[consumerBufferIndex] = null;
		Interlocked.Exchange(ref m_consumerBufferIndex, (consumerBufferIndex + 1) % m_buffer.Length);
		if (m_producerIsWaiting == 1 && !IsFull)
		{
			m_producerIsWaiting = 0;
			m_producerEvent.Set();
		}
		return result;
	}

	internal void DoneWithDequeueWait()
	{
		m_consumerIsWaiting = 0;
	}

	public void Dispose()
	{
		lock (this)
		{
			m_producerEvent.Dispose();
			m_producerEvent = null;
			m_consumerEvent = null;
		}
	}
}
