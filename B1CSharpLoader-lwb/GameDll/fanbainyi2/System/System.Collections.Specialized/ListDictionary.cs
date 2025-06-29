using System.Threading;

namespace System.Collections.Specialized;

[Serializable]
public class ListDictionary : IDictionary, ICollection, IEnumerable
{
	private class NodeEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private ListDictionary list;

		private DictionaryNode current;

		private int version;

		private bool start;

		public object Current => Entry;

		public DictionaryEntry Entry
		{
			get
			{
				if (current == null)
				{
					throw new InvalidOperationException(SR.GetString("InvalidOperation_EnumOpCantHappen"));
				}
				return new DictionaryEntry(current.key, current.value);
			}
		}

		public object Key
		{
			get
			{
				if (current == null)
				{
					throw new InvalidOperationException(SR.GetString("InvalidOperation_EnumOpCantHappen"));
				}
				return current.key;
			}
		}

		public object Value
		{
			get
			{
				if (current == null)
				{
					throw new InvalidOperationException(SR.GetString("InvalidOperation_EnumOpCantHappen"));
				}
				return current.value;
			}
		}

		public NodeEnumerator(ListDictionary list)
		{
			this.list = list;
			version = list.version;
			start = true;
			current = null;
		}

		public bool MoveNext()
		{
			if (version != list.version)
			{
				throw new InvalidOperationException(SR.GetString("InvalidOperation_EnumFailedVersion"));
			}
			if (start)
			{
				current = list.head;
				start = false;
			}
			else if (current != null)
			{
				current = current.next;
			}
			return current != null;
		}

		public void Reset()
		{
			if (version != list.version)
			{
				throw new InvalidOperationException(SR.GetString("InvalidOperation_EnumFailedVersion"));
			}
			start = true;
			current = null;
		}
	}

	private class NodeKeyValueCollection : ICollection, IEnumerable
	{
		private class NodeKeyValueEnumerator : IEnumerator
		{
			private ListDictionary list;

			private DictionaryNode current;

			private int version;

			private bool isKeys;

			private bool start;

			public object Current
			{
				get
				{
					if (current == null)
					{
						throw new InvalidOperationException(SR.GetString("InvalidOperation_EnumOpCantHappen"));
					}
					if (!isKeys)
					{
						return current.value;
					}
					return current.key;
				}
			}

			public NodeKeyValueEnumerator(ListDictionary list, bool isKeys)
			{
				this.list = list;
				this.isKeys = isKeys;
				version = list.version;
				start = true;
				current = null;
			}

			public bool MoveNext()
			{
				if (version != list.version)
				{
					throw new InvalidOperationException(SR.GetString("InvalidOperation_EnumFailedVersion"));
				}
				if (start)
				{
					current = list.head;
					start = false;
				}
				else if (current != null)
				{
					current = current.next;
				}
				return current != null;
			}

			public void Reset()
			{
				if (version != list.version)
				{
					throw new InvalidOperationException(SR.GetString("InvalidOperation_EnumFailedVersion"));
				}
				start = true;
				current = null;
			}
		}

		private ListDictionary list;

		private bool isKeys;

		int ICollection.Count
		{
			get
			{
				int num = 0;
				for (DictionaryNode dictionaryNode = list.head; dictionaryNode != null; dictionaryNode = dictionaryNode.next)
				{
					num++;
				}
				return num;
			}
		}

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => list.SyncRoot;

		public NodeKeyValueCollection(ListDictionary list, bool isKeys)
		{
			this.list = list;
			this.isKeys = isKeys;
		}

		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
			}
			for (DictionaryNode dictionaryNode = list.head; dictionaryNode != null; dictionaryNode = dictionaryNode.next)
			{
				array.SetValue(isKeys ? dictionaryNode.key : dictionaryNode.value, index);
				index++;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new NodeKeyValueEnumerator(list, isKeys);
		}
	}

	[Serializable]
	private class DictionaryNode
	{
		public object key;

		public object value;

		public DictionaryNode next;
	}

	private DictionaryNode head;

	private int version;

	private int count;

	private IComparer comparer;

	[NonSerialized]
	private object _syncRoot;

	public object this[object key]
	{
		get
		{
			if (key == null)
			{
				throw new ArgumentNullException("key", SR.GetString("ArgumentNull_Key"));
			}
			DictionaryNode next = head;
			if (comparer == null)
			{
				while (next != null)
				{
					object key2 = next.key;
					if (key2 != null && key2.Equals(key))
					{
						return next.value;
					}
					next = next.next;
				}
			}
			else
			{
				while (next != null)
				{
					object key3 = next.key;
					if (key3 != null && comparer.Compare(key3, key) == 0)
					{
						return next.value;
					}
					next = next.next;
				}
			}
			return null;
		}
		set
		{
			if (key == null)
			{
				throw new ArgumentNullException("key", SR.GetString("ArgumentNull_Key"));
			}
			version++;
			DictionaryNode dictionaryNode = null;
			DictionaryNode next;
			for (next = head; next != null; next = next.next)
			{
				object key2 = next.key;
				if ((comparer == null) ? key2.Equals(key) : (comparer.Compare(key2, key) == 0))
				{
					break;
				}
				dictionaryNode = next;
			}
			if (next != null)
			{
				next.value = value;
				return;
			}
			DictionaryNode dictionaryNode2 = new DictionaryNode();
			dictionaryNode2.key = key;
			dictionaryNode2.value = value;
			if (dictionaryNode != null)
			{
				dictionaryNode.next = dictionaryNode2;
			}
			else
			{
				head = dictionaryNode2;
			}
			count++;
		}
	}

	public int Count => count;

	public ICollection Keys => new NodeKeyValueCollection(this, isKeys: true);

	public bool IsReadOnly => false;

	public bool IsFixedSize => false;

	public bool IsSynchronized => false;

	public object SyncRoot
	{
		get
		{
			if (_syncRoot == null)
			{
				Interlocked.CompareExchange(ref _syncRoot, new object(), null);
			}
			return _syncRoot;
		}
	}

	public ICollection Values => new NodeKeyValueCollection(this, isKeys: false);

	public ListDictionary()
	{
	}

	public ListDictionary(IComparer comparer)
	{
		this.comparer = comparer;
	}

	public void Add(object key, object value)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key", SR.GetString("ArgumentNull_Key"));
		}
		version++;
		DictionaryNode dictionaryNode = null;
		for (DictionaryNode next = head; next != null; next = next.next)
		{
			object key2 = next.key;
			if ((comparer == null) ? key2.Equals(key) : (comparer.Compare(key2, key) == 0))
			{
				throw new ArgumentException(SR.GetString("Argument_AddingDuplicate"));
			}
			dictionaryNode = next;
		}
		DictionaryNode dictionaryNode2 = new DictionaryNode();
		dictionaryNode2.key = key;
		dictionaryNode2.value = value;
		if (dictionaryNode != null)
		{
			dictionaryNode.next = dictionaryNode2;
		}
		else
		{
			head = dictionaryNode2;
		}
		count++;
	}

	public void Clear()
	{
		count = 0;
		head = null;
		version++;
	}

	public bool Contains(object key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key", SR.GetString("ArgumentNull_Key"));
		}
		for (DictionaryNode next = head; next != null; next = next.next)
		{
			object key2 = next.key;
			if ((comparer == null) ? key2.Equals(key) : (comparer.Compare(key2, key) == 0))
			{
				return true;
			}
		}
		return false;
	}

	public void CopyTo(Array array, int index)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index", SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (array.Length - index < count)
		{
			throw new ArgumentException(SR.GetString("Arg_InsufficientSpace"));
		}
		for (DictionaryNode next = head; next != null; next = next.next)
		{
			array.SetValue(new DictionaryEntry(next.key, next.value), index);
			index++;
		}
	}

	public IDictionaryEnumerator GetEnumerator()
	{
		return new NodeEnumerator(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new NodeEnumerator(this);
	}

	public void Remove(object key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key", SR.GetString("ArgumentNull_Key"));
		}
		version++;
		DictionaryNode dictionaryNode = null;
		DictionaryNode next;
		for (next = head; next != null; next = next.next)
		{
			object key2 = next.key;
			if ((comparer == null) ? key2.Equals(key) : (comparer.Compare(key2, key) == 0))
			{
				break;
			}
			dictionaryNode = next;
		}
		if (next != null)
		{
			if (next == head)
			{
				head = next.next;
			}
			else
			{
				dictionaryNode.next = next.next;
			}
			count--;
		}
	}
}
