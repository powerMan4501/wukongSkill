using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Threading;

namespace System.Collections.Concurrent;

[Serializable]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(SystemCollectionsConcurrent_ProducerConsumerCollectionDebugView<>))]
[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public class ConcurrentStack<T> : IProducerConsumerCollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
{
	private class Node
	{
		internal readonly T m_value;

		internal Node m_next;

		internal Node(T value)
		{
			m_value = value;
			m_next = null;
		}
	}

	[NonSerialized]
	private volatile Node m_head;

	private T[] m_serializationArray;

	private const int BACKOFF_MAX_YIELDS = 8;

	[__DynamicallyInvokable]
	public bool IsEmpty
	{
		[__DynamicallyInvokable]
		get
		{
			return m_head == null;
		}
	}

	[__DynamicallyInvokable]
	public int Count
	{
		[__DynamicallyInvokable]
		get
		{
			int num = 0;
			for (Node node = m_head; node != null; node = node.m_next)
			{
				num++;
			}
			return num;
		}
	}

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
	public ConcurrentStack()
	{
	}

	[__DynamicallyInvokable]
	public ConcurrentStack(IEnumerable<T> collection)
	{
		if (collection == null)
		{
			throw new ArgumentNullException("collection");
		}
		InitializeFromCollection(collection);
	}

	private void InitializeFromCollection(IEnumerable<T> collection)
	{
		Node node = null;
		foreach (T item in collection)
		{
			Node node2 = new Node(item);
			node2.m_next = node;
			node = node2;
		}
		m_head = node;
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext context)
	{
		m_serializationArray = ToArray();
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext context)
	{
		Node node = null;
		Node head = null;
		for (int i = 0; i < m_serializationArray.Length; i++)
		{
			Node node2 = new Node(m_serializationArray[i]);
			if (node == null)
			{
				head = node2;
			}
			else
			{
				node.m_next = node2;
			}
			node = node2;
		}
		m_head = head;
		m_serializationArray = null;
	}

	[__DynamicallyInvokable]
	public void Clear()
	{
		m_head = null;
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
	public void CopyTo(T[] array, int index)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		ToList().CopyTo(array, index);
	}

	[__DynamicallyInvokable]
	public void Push(T item)
	{
		Node node = new Node(item);
		node.m_next = m_head;
		if (Interlocked.CompareExchange(ref m_head, node, node.m_next) != node.m_next)
		{
			PushCore(node, node);
		}
	}

	[__DynamicallyInvokable]
	public void PushRange(T[] items)
	{
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		PushRange(items, 0, items.Length);
	}

	[__DynamicallyInvokable]
	public void PushRange(T[] items, int startIndex, int count)
	{
		ValidatePushPopRangeInput(items, startIndex, count);
		if (count != 0)
		{
			Node node2;
			Node node = (node2 = new Node(items[startIndex]));
			for (int i = startIndex + 1; i < startIndex + count; i++)
			{
				Node node3 = new Node(items[i]);
				node3.m_next = node;
				node = node3;
			}
			node2.m_next = m_head;
			if (Interlocked.CompareExchange(ref m_head, node, node2.m_next) != node2.m_next)
			{
				PushCore(node, node2);
			}
		}
	}

	private void PushCore(Node head, Node tail)
	{
		SpinWait spinWait = default(SpinWait);
		do
		{
			spinWait.SpinOnce();
			tail.m_next = m_head;
		}
		while (Interlocked.CompareExchange(ref m_head, head, tail.m_next) != tail.m_next);
		if (CDSCollectionETWBCLProvider.Log.IsEnabled())
		{
			CDSCollectionETWBCLProvider.Log.ConcurrentStack_FastPushFailed(spinWait.Count);
		}
	}

	private void ValidatePushPopRangeInput(T[] items, int startIndex, int count)
	{
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ConcurrentStack_PushPopRange_CountOutOfRange"));
		}
		int num = items.Length;
		if (startIndex >= num || startIndex < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ConcurrentStack_PushPopRange_StartOutOfRange"));
		}
		if (num - count < startIndex)
		{
			throw new ArgumentException(Environment.GetResourceString("ConcurrentStack_PushPopRange_InvalidCount"));
		}
	}

	[__DynamicallyInvokable]
	bool IProducerConsumerCollection<T>.TryAdd(T item)
	{
		Push(item);
		return true;
	}

	[__DynamicallyInvokable]
	public bool TryPeek(out T result)
	{
		Node head = m_head;
		if (head == null)
		{
			result = default(T);
			return false;
		}
		result = head.m_value;
		return true;
	}

	[__DynamicallyInvokable]
	public bool TryPop(out T result)
	{
		Node head = m_head;
		if (head == null)
		{
			result = default(T);
			return false;
		}
		if (Interlocked.CompareExchange(ref m_head, head.m_next, head) == head)
		{
			result = head.m_value;
			return true;
		}
		return TryPopCore(out result);
	}

	[__DynamicallyInvokable]
	public int TryPopRange(T[] items)
	{
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		return TryPopRange(items, 0, items.Length);
	}

	[__DynamicallyInvokable]
	public int TryPopRange(T[] items, int startIndex, int count)
	{
		ValidatePushPopRangeInput(items, startIndex, count);
		if (count == 0)
		{
			return 0;
		}
		Node poppedHead;
		int num = TryPopCore(count, out poppedHead);
		if (num > 0)
		{
			CopyRemovedItems(poppedHead, items, startIndex, num);
		}
		return num;
	}

	private bool TryPopCore(out T result)
	{
		if (TryPopCore(1, out var poppedHead) == 1)
		{
			result = poppedHead.m_value;
			return true;
		}
		result = default(T);
		return false;
	}

	private int TryPopCore(int count, out Node poppedHead)
	{
		SpinWait spinWait = default(SpinWait);
		int num = 1;
		Random random = new Random(Environment.TickCount & 0x7FFFFFFF);
		Node head;
		int i;
		while (true)
		{
			head = m_head;
			if (head == null)
			{
				if (count == 1 && CDSCollectionETWBCLProvider.Log.IsEnabled())
				{
					CDSCollectionETWBCLProvider.Log.ConcurrentStack_FastPopFailed(spinWait.Count);
				}
				poppedHead = null;
				return 0;
			}
			Node node = head;
			for (i = 1; i < count; i++)
			{
				if (node.m_next == null)
				{
					break;
				}
				node = node.m_next;
			}
			if (Interlocked.CompareExchange(ref m_head, node.m_next, head) == head)
			{
				break;
			}
			for (int j = 0; j < num; j++)
			{
				spinWait.SpinOnce();
			}
			num = (spinWait.NextSpinWillYield ? random.Next(1, 8) : (num * 2));
		}
		if (count == 1 && CDSCollectionETWBCLProvider.Log.IsEnabled())
		{
			CDSCollectionETWBCLProvider.Log.ConcurrentStack_FastPopFailed(spinWait.Count);
		}
		poppedHead = head;
		return i;
	}

	private void CopyRemovedItems(Node head, T[] collection, int startIndex, int nodesCount)
	{
		Node node = head;
		for (int i = startIndex; i < startIndex + nodesCount; i++)
		{
			collection[i] = node.m_value;
			node = node.m_next;
		}
	}

	[__DynamicallyInvokable]
	bool IProducerConsumerCollection<T>.TryTake(out T item)
	{
		return TryPop(out item);
	}

	[__DynamicallyInvokable]
	public T[] ToArray()
	{
		return ToList().ToArray();
	}

	private List<T> ToList()
	{
		List<T> list = new List<T>();
		for (Node node = m_head; node != null; node = node.m_next)
		{
			list.Add(node.m_value);
		}
		return list;
	}

	[__DynamicallyInvokable]
	public IEnumerator<T> GetEnumerator()
	{
		return GetEnumerator(m_head);
	}

	private IEnumerator<T> GetEnumerator(Node head)
	{
		for (Node current = head; current != null; current = current.m_next)
		{
			yield return current.m_value;
		}
	}

	[__DynamicallyInvokable]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<T>)this).GetEnumerator();
	}
}
