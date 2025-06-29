using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Threading;

namespace System.Collections.Concurrent;

[Serializable]
[ComVisible(false)]
[DebuggerTypeProxy(typeof(SystemThreadingCollection_IProducerConsumerCollectionDebugView<>))]
[DebuggerDisplay("Count = {Count}")]
[global::__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public class ConcurrentBag<T> : IProducerConsumerCollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
{
	[Serializable]
	internal class Node
	{
		public readonly T m_value;

		public Node m_next;

		public Node m_prev;

		public Node(T value)
		{
			m_value = value;
		}
	}

	internal class ThreadLocalList
	{
		internal volatile Node m_head;

		private volatile Node m_tail;

		internal volatile int m_currentOp;

		private int m_count;

		internal int m_stealCount;

		internal volatile ThreadLocalList m_nextList;

		internal bool m_lockTaken;

		internal Thread m_ownerThread;

		internal volatile int m_version;

		internal int Count => m_count - m_stealCount;

		internal ThreadLocalList(Thread ownerThread)
		{
			m_ownerThread = ownerThread;
		}

		internal void Add(T item, bool updateCount)
		{
			Node node;
			checked
			{
				m_count++;
				node = new Node(item);
			}
			if (m_head == null)
			{
				m_head = node;
				m_tail = node;
				m_version++;
			}
			else
			{
				node.m_next = m_head;
				m_head.m_prev = node;
				m_head = node;
			}
			if (updateCount)
			{
				m_count -= m_stealCount;
				m_stealCount = 0;
			}
		}

		internal void Remove(out T result)
		{
			Node head = m_head;
			m_head = m_head.m_next;
			if (m_head != null)
			{
				m_head.m_prev = null;
			}
			else
			{
				m_tail = null;
			}
			m_count--;
			result = head.m_value;
		}

		internal bool Peek(out T result)
		{
			Node head = m_head;
			if (head != null)
			{
				result = head.m_value;
				return true;
			}
			result = default(T);
			return false;
		}

		internal void Steal(out T result, bool remove)
		{
			Node tail = m_tail;
			if (remove)
			{
				m_tail = m_tail.m_prev;
				if (m_tail != null)
				{
					m_tail.m_next = null;
				}
				else
				{
					m_head = null;
				}
				m_stealCount++;
			}
			result = tail.m_value;
		}
	}

	internal enum ListOperation
	{
		None,
		Add,
		Take
	}

	[NonSerialized]
	private ThreadLocal<ThreadLocalList> m_locals;

	[NonSerialized]
	private volatile ThreadLocalList m_headList;

	[NonSerialized]
	private volatile ThreadLocalList m_tailList;

	[NonSerialized]
	private bool m_needSync;

	private T[] m_serializationArray;

	[global::__DynamicallyInvokable]
	public int Count
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (m_headList == null)
			{
				return 0;
			}
			bool lockTaken = false;
			try
			{
				FreezeBag(ref lockTaken);
				return GetCountInternal();
			}
			finally
			{
				UnfreezeBag(lockTaken);
			}
		}
	}

	[global::__DynamicallyInvokable]
	public bool IsEmpty
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (m_headList == null)
			{
				return true;
			}
			bool lockTaken = false;
			try
			{
				FreezeBag(ref lockTaken);
				for (ThreadLocalList threadLocalList = m_headList; threadLocalList != null; threadLocalList = threadLocalList.m_nextList)
				{
					if (threadLocalList.m_head != null)
					{
						return false;
					}
				}
				return true;
			}
			finally
			{
				UnfreezeBag(lockTaken);
			}
		}
	}

	[global::__DynamicallyInvokable]
	bool ICollection.IsSynchronized
	{
		[global::__DynamicallyInvokable]
		get
		{
			return false;
		}
	}

	[global::__DynamicallyInvokable]
	object ICollection.SyncRoot
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw new NotSupportedException(SR.GetString("ConcurrentCollection_SyncRoot_NotSupported"));
		}
	}

	private object GlobalListsLock => m_locals;

	[global::__DynamicallyInvokable]
	public ConcurrentBag()
	{
		Initialize(null);
	}

	[global::__DynamicallyInvokable]
	public ConcurrentBag(IEnumerable<T> collection)
	{
		if (collection == null)
		{
			throw new ArgumentNullException("collection", SR.GetString("ConcurrentBag_Ctor_ArgumentNullException"));
		}
		Initialize(collection);
	}

	private void Initialize(IEnumerable<T> collection)
	{
		m_locals = new ThreadLocal<ThreadLocalList>();
		if (collection == null)
		{
			return;
		}
		ThreadLocalList threadList = GetThreadList(forceCreate: true);
		foreach (T item in collection)
		{
			threadList.Add(item, updateCount: false);
		}
	}

	[global::__DynamicallyInvokable]
	public void Add(T item)
	{
		ThreadLocalList threadList = GetThreadList(forceCreate: true);
		AddInternal(threadList, item);
	}

	private void AddInternal(ThreadLocalList list, T item)
	{
		bool lockTaken = false;
		try
		{
			Interlocked.Exchange(ref list.m_currentOp, 1);
			if (list.Count < 2 || m_needSync)
			{
				list.m_currentOp = 0;
				Monitor.Enter(list, ref lockTaken);
			}
			list.Add(item, lockTaken);
		}
		finally
		{
			list.m_currentOp = 0;
			if (lockTaken)
			{
				Monitor.Exit(list);
			}
		}
	}

	[global::__DynamicallyInvokable]
	bool IProducerConsumerCollection<T>.TryAdd(T item)
	{
		Add(item);
		return true;
	}

	[global::__DynamicallyInvokable]
	public bool TryTake(out T result)
	{
		return TryTakeOrPeek(out result, take: true);
	}

	[global::__DynamicallyInvokable]
	public bool TryPeek(out T result)
	{
		return TryTakeOrPeek(out result, take: false);
	}

	private bool TryTakeOrPeek(out T result, bool take)
	{
		ThreadLocalList threadList = GetThreadList(forceCreate: false);
		if (threadList == null || threadList.Count == 0)
		{
			return Steal(out result, take);
		}
		bool lockTaken = false;
		try
		{
			if (take)
			{
				Interlocked.Exchange(ref threadList.m_currentOp, 2);
				if (threadList.Count <= 2 || m_needSync)
				{
					threadList.m_currentOp = 0;
					Monitor.Enter(threadList, ref lockTaken);
					if (threadList.Count == 0)
					{
						if (lockTaken)
						{
							try
							{
							}
							finally
							{
								lockTaken = false;
								Monitor.Exit(threadList);
							}
						}
						return Steal(out result, take: true);
					}
				}
				threadList.Remove(out result);
			}
			else if (!threadList.Peek(out result))
			{
				return Steal(out result, take: false);
			}
		}
		finally
		{
			threadList.m_currentOp = 0;
			if (lockTaken)
			{
				Monitor.Exit(threadList);
			}
		}
		return true;
	}

	private ThreadLocalList GetThreadList(bool forceCreate)
	{
		ThreadLocalList value = m_locals.Value;
		if (value != null)
		{
			return value;
		}
		if (forceCreate)
		{
			lock (GlobalListsLock)
			{
				if (m_headList == null)
				{
					value = (m_tailList = (m_headList = new ThreadLocalList(Thread.CurrentThread)));
				}
				else
				{
					value = GetUnownedList();
					if (value == null)
					{
						value = new ThreadLocalList(Thread.CurrentThread);
						m_tailList.m_nextList = value;
						m_tailList = value;
					}
				}
				m_locals.Value = value;
				return value;
			}
		}
		return null;
	}

	private ThreadLocalList GetUnownedList()
	{
		for (ThreadLocalList threadLocalList = m_headList; threadLocalList != null; threadLocalList = threadLocalList.m_nextList)
		{
			if (threadLocalList.m_ownerThread.ThreadState == System.Threading.ThreadState.Stopped)
			{
				threadLocalList.m_ownerThread = Thread.CurrentThread;
				return threadLocalList;
			}
		}
		return null;
	}

	private bool Steal(out T result, bool take)
	{
		if (take)
		{
			CDSCollectionETWBCLProvider.Log.ConcurrentBag_TryTakeSteals();
		}
		else
		{
			CDSCollectionETWBCLProvider.Log.ConcurrentBag_TryPeekSteals();
		}
		List<int> list = new List<int>();
		bool flag;
		do
		{
			list.Clear();
			flag = false;
			ThreadLocalList threadLocalList;
			for (threadLocalList = m_headList; threadLocalList != null; threadLocalList = threadLocalList.m_nextList)
			{
				list.Add(threadLocalList.m_version);
				if (threadLocalList.m_head != null && TrySteal(threadLocalList, out result, take))
				{
					return true;
				}
			}
			threadLocalList = m_headList;
			foreach (int item in list)
			{
				if (item != threadLocalList.m_version)
				{
					flag = true;
					if (threadLocalList.m_head != null && TrySteal(threadLocalList, out result, take))
					{
						return true;
					}
				}
				threadLocalList = threadLocalList.m_nextList;
			}
		}
		while (flag);
		result = default(T);
		return false;
	}

	private bool TrySteal(ThreadLocalList list, out T result, bool take)
	{
		lock (list)
		{
			if (CanSteal(list))
			{
				list.Steal(out result, take);
				return true;
			}
			result = default(T);
			return false;
		}
	}

	private bool CanSteal(ThreadLocalList list)
	{
		if (list.Count <= 2 && list.m_currentOp != 0)
		{
			SpinWait spinWait = default(SpinWait);
			while (list.m_currentOp != 0)
			{
				spinWait.SpinOnce();
			}
		}
		if (list.Count > 0)
		{
			return true;
		}
		return false;
	}

	[global::__DynamicallyInvokable]
	public void CopyTo(T[] array, int index)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array", SR.GetString("ConcurrentBag_CopyTo_ArgumentNullException"));
		}
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index", SR.GetString("ConcurrentBag_CopyTo_ArgumentOutOfRangeException"));
		}
		if (m_headList == null)
		{
			return;
		}
		bool lockTaken = false;
		try
		{
			FreezeBag(ref lockTaken);
			ToList().CopyTo(array, index);
		}
		finally
		{
			UnfreezeBag(lockTaken);
		}
	}

	[global::__DynamicallyInvokable]
	void ICollection.CopyTo(Array array, int index)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array", SR.GetString("ConcurrentBag_CopyTo_ArgumentNullException"));
		}
		bool lockTaken = false;
		try
		{
			FreezeBag(ref lockTaken);
			((ICollection)ToList()).CopyTo(array, index);
		}
		finally
		{
			UnfreezeBag(lockTaken);
		}
	}

	[global::__DynamicallyInvokable]
	public T[] ToArray()
	{
		if (m_headList == null)
		{
			return new T[0];
		}
		bool lockTaken = false;
		try
		{
			FreezeBag(ref lockTaken);
			return ToList().ToArray();
		}
		finally
		{
			UnfreezeBag(lockTaken);
		}
	}

	[global::__DynamicallyInvokable]
	public IEnumerator<T> GetEnumerator()
	{
		if (m_headList == null)
		{
			return new List<T>().GetEnumerator();
		}
		bool lockTaken = false;
		try
		{
			FreezeBag(ref lockTaken);
			return ToList().GetEnumerator();
		}
		finally
		{
			UnfreezeBag(lockTaken);
		}
	}

	[global::__DynamicallyInvokable]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext context)
	{
		m_serializationArray = ToArray();
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext context)
	{
		m_locals = new ThreadLocal<ThreadLocalList>();
		ThreadLocalList threadList = GetThreadList(forceCreate: true);
		T[] serializationArray = m_serializationArray;
		foreach (T item in serializationArray)
		{
			threadList.Add(item, updateCount: false);
		}
		m_headList = threadList;
		m_tailList = threadList;
		m_serializationArray = null;
	}

	private void FreezeBag(ref bool lockTaken)
	{
		Monitor.Enter(GlobalListsLock, ref lockTaken);
		m_needSync = true;
		AcquireAllLocks();
		WaitAllOperations();
	}

	private void UnfreezeBag(bool lockTaken)
	{
		ReleaseAllLocks();
		m_needSync = false;
		if (lockTaken)
		{
			Monitor.Exit(GlobalListsLock);
		}
	}

	private void AcquireAllLocks()
	{
		bool lockTaken = false;
		for (ThreadLocalList threadLocalList = m_headList; threadLocalList != null; threadLocalList = threadLocalList.m_nextList)
		{
			try
			{
				Monitor.Enter(threadLocalList, ref lockTaken);
			}
			finally
			{
				if (lockTaken)
				{
					threadLocalList.m_lockTaken = true;
					lockTaken = false;
				}
			}
		}
	}

	private void ReleaseAllLocks()
	{
		for (ThreadLocalList threadLocalList = m_headList; threadLocalList != null; threadLocalList = threadLocalList.m_nextList)
		{
			if (threadLocalList.m_lockTaken)
			{
				threadLocalList.m_lockTaken = false;
				Monitor.Exit(threadLocalList);
			}
		}
	}

	private void WaitAllOperations()
	{
		for (ThreadLocalList threadLocalList = m_headList; threadLocalList != null; threadLocalList = threadLocalList.m_nextList)
		{
			if (threadLocalList.m_currentOp != 0)
			{
				SpinWait spinWait = default(SpinWait);
				while (threadLocalList.m_currentOp != 0)
				{
					spinWait.SpinOnce();
				}
			}
		}
	}

	private int GetCountInternal()
	{
		int num = 0;
		for (ThreadLocalList threadLocalList = m_headList; threadLocalList != null; threadLocalList = threadLocalList.m_nextList)
		{
			num = checked(num + threadLocalList.Count);
		}
		return num;
	}

	private List<T> ToList()
	{
		List<T> list = new List<T>();
		for (ThreadLocalList threadLocalList = m_headList; threadLocalList != null; threadLocalList = threadLocalList.m_nextList)
		{
			for (Node node = threadLocalList.m_head; node != null; node = node.m_next)
			{
				list.Add(node.m_value);
			}
		}
		return list;
	}
}
