using System.Collections.Generic;

namespace System.Linq.Parallel;

internal sealed class SynchronousChannel<T>
{
	private Queue<T> m_queue;

	internal int Count => m_queue.Count;

	internal SynchronousChannel()
	{
	}

	internal void Init()
	{
		m_queue = new Queue<T>();
	}

	internal void Enqueue(T item)
	{
		m_queue.Enqueue(item);
	}

	internal T Dequeue()
	{
		return m_queue.Dequeue();
	}

	internal void SetDone()
	{
	}

	internal void CopyTo(T[] array, int arrayIndex)
	{
		m_queue.CopyTo(array, arrayIndex);
	}
}
