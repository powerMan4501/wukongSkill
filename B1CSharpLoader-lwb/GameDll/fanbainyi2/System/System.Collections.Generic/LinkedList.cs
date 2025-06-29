using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Threading;

namespace System.Collections.Generic;

[Serializable]
[ComVisible(false)]
[DebuggerTypeProxy(typeof(System_CollectionDebugView<>))]
[DebuggerDisplay("Count = {Count}")]
[global::__DynamicallyInvokable]
public class LinkedList<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
{
	[Serializable]
	[global::__DynamicallyInvokable]
	public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback
	{
		private LinkedList<T> list;

		private LinkedListNode<T> node;

		private int version;

		private T current;

		private int index;

		private SerializationInfo siInfo;

		private const string LinkedListName = "LinkedList";

		private const string CurrentValueName = "Current";

		private const string VersionName = "Version";

		private const string IndexName = "Index";

		[global::__DynamicallyInvokable]
		public T Current
		{
			[global::__DynamicallyInvokable]
			get
			{
				return current;
			}
		}

		[global::__DynamicallyInvokable]
		object IEnumerator.Current
		{
			[global::__DynamicallyInvokable]
			get
			{
				if (index == 0 || index == list.Count + 1)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumOpCantHappen);
				}
				return current;
			}
		}

		internal Enumerator(LinkedList<T> list)
		{
			this.list = list;
			version = list.version;
			node = list.head;
			current = default(T);
			index = 0;
			siInfo = null;
		}

		internal Enumerator(SerializationInfo info, StreamingContext context)
		{
			siInfo = info;
			list = null;
			version = 0;
			node = null;
			current = default(T);
			index = 0;
		}

		[global::__DynamicallyInvokable]
		public bool MoveNext()
		{
			if (version != list.version)
			{
				throw new InvalidOperationException(SR.GetString("InvalidOperation_EnumFailedVersion"));
			}
			if (node == null)
			{
				index = list.Count + 1;
				return false;
			}
			index++;
			current = node.item;
			node = node.next;
			if (node == list.head)
			{
				node = null;
			}
			return true;
		}

		[global::__DynamicallyInvokable]
		void IEnumerator.Reset()
		{
			if (version != list.version)
			{
				throw new InvalidOperationException(SR.GetString("InvalidOperation_EnumFailedVersion"));
			}
			current = default(T);
			node = list.head;
			index = 0;
		}

		[global::__DynamicallyInvokable]
		public void Dispose()
		{
		}

		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("LinkedList", list);
			info.AddValue("Version", version);
			info.AddValue("Current", current);
			info.AddValue("Index", index);
		}

		void IDeserializationCallback.OnDeserialization(object sender)
		{
			if (list != null)
			{
				return;
			}
			if (siInfo == null)
			{
				throw new SerializationException(SR.GetString("Serialization_InvalidOnDeser"));
			}
			list = (LinkedList<T>)siInfo.GetValue("LinkedList", typeof(LinkedList<T>));
			version = siInfo.GetInt32("Version");
			current = (T)siInfo.GetValue("Current", typeof(T));
			index = siInfo.GetInt32("Index");
			if (list.siInfo != null)
			{
				list.OnDeserialization(sender);
			}
			if (index == list.Count + 1)
			{
				node = null;
			}
			else
			{
				node = list.First;
				if (node != null && index != 0)
				{
					for (int i = 0; i < index; i++)
					{
						node = node.next;
					}
					if (node == list.First)
					{
						node = null;
					}
				}
			}
			siInfo = null;
		}
	}

	internal LinkedListNode<T> head;

	internal int count;

	internal int version;

	private object _syncRoot;

	private SerializationInfo siInfo;

	private const string VersionName = "Version";

	private const string CountName = "Count";

	private const string ValuesName = "Data";

	[global::__DynamicallyInvokable]
	public int Count
	{
		[global::__DynamicallyInvokable]
		get
		{
			return count;
		}
	}

	[global::__DynamicallyInvokable]
	public LinkedListNode<T> First
	{
		[global::__DynamicallyInvokable]
		get
		{
			return head;
		}
	}

	[global::__DynamicallyInvokable]
	public LinkedListNode<T> Last
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (head != null)
			{
				return head.prev;
			}
			return null;
		}
	}

	[global::__DynamicallyInvokable]
	bool ICollection<T>.IsReadOnly
	{
		[global::__DynamicallyInvokable]
		get
		{
			return false;
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
			if (_syncRoot == null)
			{
				Interlocked.CompareExchange<object>(ref _syncRoot, new object(), (object)null);
			}
			return _syncRoot;
		}
	}

	[global::__DynamicallyInvokable]
	public LinkedList()
	{
	}

	[global::__DynamicallyInvokable]
	public LinkedList(IEnumerable<T> collection)
	{
		if (collection == null)
		{
			throw new ArgumentNullException("collection");
		}
		foreach (T item in collection)
		{
			AddLast(item);
		}
	}

	protected LinkedList(SerializationInfo info, StreamingContext context)
	{
		siInfo = info;
	}

	[global::__DynamicallyInvokable]
	void ICollection<T>.Add(T value)
	{
		AddLast(value);
	}

	[global::__DynamicallyInvokable]
	public LinkedListNode<T> AddAfter(LinkedListNode<T> node, T value)
	{
		ValidateNode(node);
		LinkedListNode<T> linkedListNode = new LinkedListNode<T>(node.list, value);
		InternalInsertNodeBefore(node.next, linkedListNode);
		return linkedListNode;
	}

	[global::__DynamicallyInvokable]
	public void AddAfter(LinkedListNode<T> node, LinkedListNode<T> newNode)
	{
		ValidateNode(node);
		ValidateNewNode(newNode);
		InternalInsertNodeBefore(node.next, newNode);
		newNode.list = this;
	}

	[global::__DynamicallyInvokable]
	public LinkedListNode<T> AddBefore(LinkedListNode<T> node, T value)
	{
		ValidateNode(node);
		LinkedListNode<T> linkedListNode = new LinkedListNode<T>(node.list, value);
		InternalInsertNodeBefore(node, linkedListNode);
		if (node == head)
		{
			head = linkedListNode;
		}
		return linkedListNode;
	}

	[global::__DynamicallyInvokable]
	public void AddBefore(LinkedListNode<T> node, LinkedListNode<T> newNode)
	{
		ValidateNode(node);
		ValidateNewNode(newNode);
		InternalInsertNodeBefore(node, newNode);
		newNode.list = this;
		if (node == head)
		{
			head = newNode;
		}
	}

	[global::__DynamicallyInvokable]
	public LinkedListNode<T> AddFirst(T value)
	{
		LinkedListNode<T> linkedListNode = new LinkedListNode<T>(this, value);
		if (head == null)
		{
			InternalInsertNodeToEmptyList(linkedListNode);
		}
		else
		{
			InternalInsertNodeBefore(head, linkedListNode);
			head = linkedListNode;
		}
		return linkedListNode;
	}

	[global::__DynamicallyInvokable]
	public void AddFirst(LinkedListNode<T> node)
	{
		ValidateNewNode(node);
		if (head == null)
		{
			InternalInsertNodeToEmptyList(node);
		}
		else
		{
			InternalInsertNodeBefore(head, node);
			head = node;
		}
		node.list = this;
	}

	[global::__DynamicallyInvokable]
	public LinkedListNode<T> AddLast(T value)
	{
		LinkedListNode<T> linkedListNode = new LinkedListNode<T>(this, value);
		if (head == null)
		{
			InternalInsertNodeToEmptyList(linkedListNode);
		}
		else
		{
			InternalInsertNodeBefore(head, linkedListNode);
		}
		return linkedListNode;
	}

	[global::__DynamicallyInvokable]
	public void AddLast(LinkedListNode<T> node)
	{
		ValidateNewNode(node);
		if (head == null)
		{
			InternalInsertNodeToEmptyList(node);
		}
		else
		{
			InternalInsertNodeBefore(head, node);
		}
		node.list = this;
	}

	[global::__DynamicallyInvokable]
	public void Clear()
	{
		LinkedListNode<T> next = head;
		while (next != null)
		{
			LinkedListNode<T> linkedListNode = next;
			next = next.Next;
			linkedListNode.Invalidate();
		}
		head = null;
		count = 0;
		version++;
	}

	[global::__DynamicallyInvokable]
	public bool Contains(T value)
	{
		return Find(value) != null;
	}

	[global::__DynamicallyInvokable]
	public void CopyTo(T[] array, int index)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (index < 0 || index > array.Length)
		{
			throw new ArgumentOutOfRangeException("index", SR.GetString("IndexOutOfRange", index));
		}
		if (array.Length - index < Count)
		{
			throw new ArgumentException(SR.GetString("Arg_InsufficientSpace"));
		}
		LinkedListNode<T> next = head;
		if (next != null)
		{
			do
			{
				array[index++] = next.item;
				next = next.next;
			}
			while (next != head);
		}
	}

	[global::__DynamicallyInvokable]
	public LinkedListNode<T> Find(T value)
	{
		LinkedListNode<T> next = head;
		EqualityComparer<T> equalityComparer = EqualityComparer<T>.Default;
		if (next != null)
		{
			if (value != null)
			{
				do
				{
					if (equalityComparer.Equals(next.item, value))
					{
						return next;
					}
					next = next.next;
				}
				while (next != head);
			}
			else
			{
				do
				{
					if (next.item == null)
					{
						return next;
					}
					next = next.next;
				}
				while (next != head);
			}
		}
		return null;
	}

	[global::__DynamicallyInvokable]
	public LinkedListNode<T> FindLast(T value)
	{
		if (head == null)
		{
			return null;
		}
		LinkedListNode<T> prev = head.prev;
		LinkedListNode<T> linkedListNode = prev;
		EqualityComparer<T> equalityComparer = EqualityComparer<T>.Default;
		if (linkedListNode != null)
		{
			if (value != null)
			{
				do
				{
					if (equalityComparer.Equals(linkedListNode.item, value))
					{
						return linkedListNode;
					}
					linkedListNode = linkedListNode.prev;
				}
				while (linkedListNode != prev);
			}
			else
			{
				do
				{
					if (linkedListNode.item == null)
					{
						return linkedListNode;
					}
					linkedListNode = linkedListNode.prev;
				}
				while (linkedListNode != prev);
			}
		}
		return null;
	}

	[global::__DynamicallyInvokable]
	public Enumerator GetEnumerator()
	{
		return new Enumerator(this);
	}

	[global::__DynamicallyInvokable]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return GetEnumerator();
	}

	[global::__DynamicallyInvokable]
	public bool Remove(T value)
	{
		LinkedListNode<T> linkedListNode = Find(value);
		if (linkedListNode != null)
		{
			InternalRemoveNode(linkedListNode);
			return true;
		}
		return false;
	}

	[global::__DynamicallyInvokable]
	public void Remove(LinkedListNode<T> node)
	{
		ValidateNode(node);
		InternalRemoveNode(node);
	}

	[global::__DynamicallyInvokable]
	public void RemoveFirst()
	{
		if (head == null)
		{
			throw new InvalidOperationException(SR.GetString("LinkedListEmpty"));
		}
		InternalRemoveNode(head);
	}

	[global::__DynamicallyInvokable]
	public void RemoveLast()
	{
		if (head == null)
		{
			throw new InvalidOperationException(SR.GetString("LinkedListEmpty"));
		}
		InternalRemoveNode(head.prev);
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		info.AddValue("Version", version);
		info.AddValue("Count", count);
		if (count != 0)
		{
			T[] array = new T[Count];
			CopyTo(array, 0);
			info.AddValue("Data", array, typeof(T[]));
		}
	}

	public virtual void OnDeserialization(object sender)
	{
		if (siInfo == null)
		{
			return;
		}
		int @int = siInfo.GetInt32("Version");
		if (siInfo.GetInt32("Count") != 0)
		{
			T[] array = (T[])siInfo.GetValue("Data", typeof(T[]));
			if (array == null)
			{
				throw new SerializationException(SR.GetString("Serialization_MissingValues"));
			}
			for (int i = 0; i < array.Length; i++)
			{
				AddLast(array[i]);
			}
		}
		else
		{
			head = null;
		}
		version = @int;
		siInfo = null;
	}

	private void InternalInsertNodeBefore(LinkedListNode<T> node, LinkedListNode<T> newNode)
	{
		newNode.next = node;
		newNode.prev = node.prev;
		node.prev.next = newNode;
		node.prev = newNode;
		version++;
		count++;
	}

	private void InternalInsertNodeToEmptyList(LinkedListNode<T> newNode)
	{
		newNode.next = newNode;
		newNode.prev = newNode;
		head = newNode;
		version++;
		count++;
	}

	internal void InternalRemoveNode(LinkedListNode<T> node)
	{
		if (node.next == node)
		{
			head = null;
		}
		else
		{
			node.next.prev = node.prev;
			node.prev.next = node.next;
			if (head == node)
			{
				head = node.next;
			}
		}
		node.Invalidate();
		count--;
		version++;
	}

	internal void ValidateNewNode(LinkedListNode<T> node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (node.list != null)
		{
			throw new InvalidOperationException(SR.GetString("LinkedListNodeIsAttached"));
		}
	}

	internal void ValidateNode(LinkedListNode<T> node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (node.list != this)
		{
			throw new InvalidOperationException(SR.GetString("ExternalLinkedListNode"));
		}
	}

	[global::__DynamicallyInvokable]
	void ICollection.CopyTo(Array array, int index)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (array.Rank != 1)
		{
			throw new ArgumentException(SR.GetString("Arg_MultiRank"));
		}
		if (array.GetLowerBound(0) != 0)
		{
			throw new ArgumentException(SR.GetString("Arg_NonZeroLowerBound"));
		}
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index", SR.GetString("IndexOutOfRange", index));
		}
		if (array.Length - index < Count)
		{
			throw new ArgumentException(SR.GetString("Arg_InsufficientSpace"));
		}
		if (array is T[] array2)
		{
			CopyTo(array2, index);
			return;
		}
		Type elementType = array.GetType().GetElementType();
		Type typeFromHandle = typeof(T);
		if (!elementType.IsAssignableFrom(typeFromHandle) && !typeFromHandle.IsAssignableFrom(elementType))
		{
			throw new ArgumentException(SR.GetString("Invalid_Array_Type"));
		}
		if (!(array is object[] array3))
		{
			throw new ArgumentException(SR.GetString("Invalid_Array_Type"));
		}
		LinkedListNode<T> next = head;
		try
		{
			if (next != null)
			{
				do
				{
					array3[index++] = next.item;
					next = next.next;
				}
				while (next != head);
			}
		}
		catch (ArrayTypeMismatchException)
		{
			throw new ArgumentException(SR.GetString("Invalid_Array_Type"));
		}
	}

	[global::__DynamicallyInvokable]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
