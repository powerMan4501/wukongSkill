using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Threading;

namespace System.Collections.Concurrent;

[Serializable]
[ComVisible(false)]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(SystemCollectionsConcurrent_ProducerConsumerCollectionDebugView<>))]
[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public class ConcurrentQueue<T> : IProducerConsumerCollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
{
	private class Segment
	{
		internal volatile T[] m_array;

		internal volatile VolatileBool[] m_state;

		private volatile Segment m_next;

		internal readonly long m_index;

		private volatile int m_low;

		private volatile int m_high;

		private volatile ConcurrentQueue<T> m_source;

		internal Segment Next => m_next;

		internal bool IsEmpty => Low > High;

		internal int Low => Math.Min(m_low, 32);

		internal int High => Math.Min(m_high, 31);

		internal Segment(long index, ConcurrentQueue<T> source)
		{
			m_array = new T[32];
			m_state = new VolatileBool[32];
			m_high = -1;
			m_index = index;
			m_source = source;
		}

		internal void UnsafeAdd(T value)
		{
			m_high++;
			m_array[m_high] = value;
			m_state[m_high].m_value = true;
		}

		internal Segment UnsafeGrow()
		{
			return m_next = new Segment(m_index + 1, m_source);
		}

		internal void Grow()
		{
			Segment next = new Segment(m_index + 1, m_source);
			m_next = next;
			m_source.m_tail = m_next;
		}

		internal bool TryAppend(T value)
		{
			if (m_high >= 31)
			{
				return false;
			}
			int num = 32;
			try
			{
			}
			finally
			{
				num = Interlocked.Increment(ref m_high);
				if (num <= 31)
				{
					m_array[num] = value;
					m_state[num].m_value = true;
				}
				if (num == 31)
				{
					Grow();
				}
			}
			return num <= 31;
		}

		internal bool TryRemove(out T result)
		{
			SpinWait spinWait = default(SpinWait);
			int low = Low;
			int high = High;
			while (low <= high)
			{
				if (Interlocked.CompareExchange(ref m_low, low + 1, low) == low)
				{
					SpinWait spinWait2 = default(SpinWait);
					while (!m_state[low].m_value)
					{
						spinWait2.SpinOnce();
					}
					result = m_array[low];
					if (m_source.m_numSnapshotTakers <= 0)
					{
						m_array[low] = default(T);
					}
					if (low + 1 >= 32)
					{
						spinWait2 = default(SpinWait);
						while (m_next == null)
						{
							spinWait2.SpinOnce();
						}
						m_source.m_head = m_next;
					}
					return true;
				}
				spinWait.SpinOnce();
				low = Low;
				high = High;
			}
			result = default(T);
			return false;
		}

		internal bool TryPeek(out T result)
		{
			result = default(T);
			int low = Low;
			if (low > High)
			{
				return false;
			}
			SpinWait spinWait = default(SpinWait);
			while (!m_state[low].m_value)
			{
				spinWait.SpinOnce();
			}
			result = m_array[low];
			return true;
		}

		internal void AddToList(List<T> list, int start, int end)
		{
			for (int i = start; i <= end; i++)
			{
				SpinWait spinWait = default(SpinWait);
				while (!m_state[i].m_value)
				{
					spinWait.SpinOnce();
				}
				list.Add(m_array[i]);
			}
		}
	}

	[NonSerialized]
	private volatile Segment m_head;

	[NonSerialized]
	private volatile Segment m_tail;

	private T[] m_serializationArray;

	private const int SEGMENT_SIZE = 32;

	[NonSerialized]
	internal volatile int m_numSnapshotTakers;

	[__DynamicallyInvokable]
	bool ICollection.IsSynchronized
	{
		[__DynamicallyInvokable]
		get
		{
			return false;
		}
	}

	[__DynamicallyInvokable]
	object ICollection.SyncRoot
	{
		[__DynamicallyInvokable]
		get
		{
			throw new NotSupportedException(Environment.GetResourceString("ConcurrentCollection_SyncRoot_NotSupported"));
		}
	}

	[__DynamicallyInvokable]
	public bool IsEmpty
	{
		[__DynamicallyInvokable]
		get
		{
			Segment head = m_head;
			if (!head.IsEmpty)
			{
				return false;
			}
			if (head.Next == null)
			{
				return true;
			}
			SpinWait spinWait = default(SpinWait);
			while (head.IsEmpty)
			{
				if (head.Next == null)
				{
					return true;
				}
				spinWait.SpinOnce();
				head = m_head;
			}
			return false;
		}
	}

	[__DynamicallyInvokable]
	public int Count
	{
		[__DynamicallyInvokable]
		get
		{
			GetHeadTailPositions(out var head, out var tail, out var headLow, out var tailHigh);
			if (head == tail)
			{
				return tailHigh - headLow + 1;
			}
			int num = 32 - headLow;
			num += 32 * (int)(tail.m_index - head.m_index - 1);
			return num + (tailHigh + 1);
		}
	}

	[__DynamicallyInvokable]
	public ConcurrentQueue()
	{
		m_head = (m_tail = new Segment(0L, this));
	}

	private void InitializeFromCollection(IEnumerable<T> collection)
	{
		Segment segment = (m_head = new Segment(0L, this));
		int num = 0;
		foreach (T item in collection)
		{
			segment.UnsafeAdd(item);
			num++;
			if (num >= 32)
			{
				segment = segment.UnsafeGrow();
				num = 0;
			}
		}
		m_tail = segment;
	}

	[__DynamicallyInvokable]
	public ConcurrentQueue(IEnumerable<T> collection)
	{
		if (collection == null)
		{
			throw new ArgumentNullException("collection");
		}
		InitializeFromCollection(collection);
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext context)
	{
		m_serializationArray = ToArray();
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext context)
	{
		InitializeFromCollection(m_serializationArray);
		m_serializationArray = null;
	}

	[__DynamicallyInvokable]
	void ICollection.CopyTo(Array array, int index)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		((ICollection)ToList()).CopyTo(array, index);
	}

	[__DynamicallyInvokable]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<T>)this).GetEnumerator();
	}

	[__DynamicallyInvokable]
	bool IProducerConsumerCollection<T>.TryAdd(T item)
	{
		Enqueue(item);
		return true;
	}

	[__DynamicallyInvokable]
	bool IProducerConsumerCollection<T>.TryTake(out T item)
	{
		return TryDequeue(out item);
	}

	[__DynamicallyInvokable]
	public T[] ToArray()
	{
		return ToList().ToArray();
	}

	private List<T> ToList()
	{
		Interlocked.Increment(ref m_numSnapshotTakers);
		List<T> list = new List<T>();
		try
		{
			GetHeadTailPositions(out var head, out var tail, out var headLow, out var tailHigh);
			if (head == tail)
			{
				head.AddToList(list, headLow, tailHigh);
			}
			else
			{
				head.AddToList(list, headLow, 31);
				for (Segment next = head.Next; next != tail; next = next.Next)
				{
					next.AddToList(list, 0, 31);
				}
				tail.AddToList(list, 0, tailHigh);
			}
		}
		finally
		{
			Interlocked.Decrement(ref m_numSnapshotTakers);
		}
		return list;
	}

	private void GetHeadTailPositions(out Segment head, out Segment tail, out int headLow, out int tailHigh)
	{
		head = m_head;
		tail = m_tail;
		headLow = head.Low;
		tailHigh = tail.High;
		SpinWait spinWait = default(SpinWait);
		while (head != m_head || tail != m_tail || headLow != head.Low || tailHigh != tail.High || head.m_index > tail.m_index)
		{
			spinWait.SpinOnce();
			head = m_head;
			tail = m_tail;
			headLow = head.Low;
			tailHigh = tail.High;
		}
	}

	[__DynamicallyInvokable]
	public void CopyTo(T[] array, int index)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		ToList().CopyTo(array, index);
	}

	[__DynamicallyInvokable]
	public IEnumerator<T> GetEnumerator()
	{
		Interlocked.Increment(ref m_numSnapshotTakers);
		GetHeadTailPositions(out var head, out var tail, out var headLow, out var tailHigh);
		return GetEnumerator(head, tail, headLow, tailHigh);
	}

	private IEnumerator<T> GetEnumerator(Segment head, Segment tail, int headLow, int tailHigh)
	{
		try
		{
			SpinWait spin = default(SpinWait);
			if (head == tail)
			{
				for (int i = headLow; i <= tailHigh; i++)
				{
					spin.Reset();
					while (!head.m_state[i].m_value)
					{
						spin.SpinOnce();
					}
					yield return head.m_array[i];
				}
				yield break;
			}
			for (int i = headLow; i < 32; i++)
			{
				spin.Reset();
				while (!head.m_state[i].m_value)
				{
					spin.SpinOnce();
				}
				yield return head.m_array[i];
			}
			for (Segment curr = head.Next; curr != tail; curr = curr.Next)
			{
				for (int i = 0; i < 32; i++)
				{
					spin.Reset();
					while (!curr.m_state[i].m_value)
					{
						spin.SpinOnce();
					}
					yield return curr.m_array[i];
				}
			}
			for (int i = 0; i <= tailHigh; i++)
			{
				spin.Reset();
				while (!tail.m_state[i].m_value)
				{
					spin.SpinOnce();
				}
				yield return tail.m_array[i];
			}
		}
		finally
		{
			Interlocked.Decrement(ref m_numSnapshotTakers);
		}
	}

	[__DynamicallyInvokable]
	public void Enqueue(T item)
	{
		SpinWait spinWait = default(SpinWait);
		while (true)
		{
			Segment tail = m_tail;
			if (tail.TryAppend(item))
			{
				break;
			}
			spinWait.SpinOnce();
		}
	}

	[__DynamicallyInvokable]
	public bool TryDequeue(out T result)
	{
		while (!IsEmpty)
		{
			Segment head = m_head;
			if (head.TryRemove(out result))
			{
				return true;
			}
		}
		result = default(T);
		return false;
	}

	[__DynamicallyInvokable]
	public bool TryPeek(out T result)
	{
		Interlocked.Increment(ref m_numSnapshotTakers);
		while (!IsEmpty)
		{
			Segment head = m_head;
			if (head.TryPeek(out result))
			{
				Interlocked.Decrement(ref m_numSnapshotTakers);
				return true;
			}
		}
		result = default(T);
		Interlocked.Decrement(ref m_numSnapshotTakers);
		return false;
	}
}
