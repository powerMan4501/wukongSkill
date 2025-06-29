using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Threading;

namespace System.Collections.Specialized;

[Serializable]
public class OrderedDictionary : IOrderedDictionary, IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback
{
	private class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private int _objectReturnType;

		internal const int Keys = 1;

		internal const int Values = 2;

		internal const int DictionaryEntry = 3;

		private IEnumerator arrayEnumerator;

		public object Current
		{
			get
			{
				if (_objectReturnType == 1)
				{
					return ((DictionaryEntry)arrayEnumerator.Current).Key;
				}
				if (_objectReturnType == 2)
				{
					return ((DictionaryEntry)arrayEnumerator.Current).Value;
				}
				return Entry;
			}
		}

		public DictionaryEntry Entry => new DictionaryEntry(((DictionaryEntry)arrayEnumerator.Current).Key, ((DictionaryEntry)arrayEnumerator.Current).Value);

		public object Key => ((DictionaryEntry)arrayEnumerator.Current).Key;

		public object Value => ((DictionaryEntry)arrayEnumerator.Current).Value;

		internal OrderedDictionaryEnumerator(ArrayList array, int objectReturnType)
		{
			arrayEnumerator = array.GetEnumerator();
			_objectReturnType = objectReturnType;
		}

		public bool MoveNext()
		{
			return arrayEnumerator.MoveNext();
		}

		public void Reset()
		{
			arrayEnumerator.Reset();
		}
	}

	private class OrderedDictionaryKeyValueCollection : ICollection, IEnumerable
	{
		private ArrayList _objects;

		private bool isKeys;

		int ICollection.Count => _objects.Count;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => _objects.SyncRoot;

		public OrderedDictionaryKeyValueCollection(ArrayList array, bool isKeys)
		{
			_objects = array;
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
				throw new ArgumentOutOfRangeException("index");
			}
			foreach (object @object in _objects)
			{
				array.SetValue(isKeys ? ((DictionaryEntry)@object).Key : ((DictionaryEntry)@object).Value, index);
				index++;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new OrderedDictionaryEnumerator(_objects, isKeys ? 1 : 2);
		}
	}

	private ArrayList _objectsArray;

	private Hashtable _objectsTable;

	private int _initialCapacity;

	private IEqualityComparer _comparer;

	private bool _readOnly;

	private object _syncRoot;

	private SerializationInfo _siInfo;

	private const string KeyComparerName = "KeyComparer";

	private const string ArrayListName = "ArrayList";

	private const string ReadOnlyName = "ReadOnly";

	private const string InitCapacityName = "InitialCapacity";

	public int Count => objectsArray.Count;

	bool IDictionary.IsFixedSize => _readOnly;

	public bool IsReadOnly => _readOnly;

	bool ICollection.IsSynchronized => false;

	public ICollection Keys => new OrderedDictionaryKeyValueCollection(objectsArray, isKeys: true);

	private ArrayList objectsArray
	{
		get
		{
			if (_objectsArray == null)
			{
				_objectsArray = new ArrayList(_initialCapacity);
			}
			return _objectsArray;
		}
	}

	private Hashtable objectsTable
	{
		get
		{
			if (_objectsTable == null)
			{
				_objectsTable = new Hashtable(_initialCapacity, _comparer);
			}
			return _objectsTable;
		}
	}

	object ICollection.SyncRoot
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

	public object this[int index]
	{
		get
		{
			return ((DictionaryEntry)objectsArray[index]).Value;
		}
		set
		{
			if (_readOnly)
			{
				throw new NotSupportedException(SR.GetString("OrderedDictionary_ReadOnly"));
			}
			if (index < 0 || index >= objectsArray.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			object key = ((DictionaryEntry)objectsArray[index]).Key;
			objectsArray[index] = new DictionaryEntry(key, value);
			objectsTable[key] = value;
		}
	}

	public object this[object key]
	{
		get
		{
			return objectsTable[key];
		}
		set
		{
			if (_readOnly)
			{
				throw new NotSupportedException(SR.GetString("OrderedDictionary_ReadOnly"));
			}
			if (objectsTable.Contains(key))
			{
				objectsTable[key] = value;
				objectsArray[IndexOfKey(key)] = new DictionaryEntry(key, value);
			}
			else
			{
				Add(key, value);
			}
		}
	}

	public ICollection Values => new OrderedDictionaryKeyValueCollection(objectsArray, isKeys: false);

	public OrderedDictionary()
		: this(0)
	{
	}

	public OrderedDictionary(int capacity)
		: this(capacity, null)
	{
	}

	public OrderedDictionary(IEqualityComparer comparer)
		: this(0, comparer)
	{
	}

	public OrderedDictionary(int capacity, IEqualityComparer comparer)
	{
		_initialCapacity = capacity;
		_comparer = comparer;
	}

	private OrderedDictionary(OrderedDictionary dictionary)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		_readOnly = true;
		_objectsArray = dictionary._objectsArray;
		_objectsTable = dictionary._objectsTable;
		_comparer = dictionary._comparer;
		_initialCapacity = dictionary._initialCapacity;
	}

	protected OrderedDictionary(SerializationInfo info, StreamingContext context)
	{
		_siInfo = info;
	}

	public void Add(object key, object value)
	{
		if (_readOnly)
		{
			throw new NotSupportedException(SR.GetString("OrderedDictionary_ReadOnly"));
		}
		objectsTable.Add(key, value);
		objectsArray.Add(new DictionaryEntry(key, value));
	}

	public void Clear()
	{
		if (_readOnly)
		{
			throw new NotSupportedException(SR.GetString("OrderedDictionary_ReadOnly"));
		}
		objectsTable.Clear();
		objectsArray.Clear();
	}

	public OrderedDictionary AsReadOnly()
	{
		return new OrderedDictionary(this);
	}

	public bool Contains(object key)
	{
		return objectsTable.Contains(key);
	}

	public void CopyTo(Array array, int index)
	{
		objectsTable.CopyTo(array, index);
	}

	private int IndexOfKey(object key)
	{
		for (int i = 0; i < objectsArray.Count; i++)
		{
			object key2 = ((DictionaryEntry)objectsArray[i]).Key;
			if (_comparer != null)
			{
				if (_comparer.Equals(key2, key))
				{
					return i;
				}
			}
			else if (key2.Equals(key))
			{
				return i;
			}
		}
		return -1;
	}

	public void Insert(int index, object key, object value)
	{
		if (_readOnly)
		{
			throw new NotSupportedException(SR.GetString("OrderedDictionary_ReadOnly"));
		}
		if (index > Count || index < 0)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		objectsTable.Add(key, value);
		objectsArray.Insert(index, new DictionaryEntry(key, value));
	}

	protected virtual void OnDeserialization(object sender)
	{
		if (_siInfo == null)
		{
			throw new SerializationException(SR.GetString("Serialization_InvalidOnDeser"));
		}
		_comparer = (IEqualityComparer)_siInfo.GetValue("KeyComparer", typeof(IEqualityComparer));
		_readOnly = _siInfo.GetBoolean("ReadOnly");
		_initialCapacity = _siInfo.GetInt32("InitialCapacity");
		object[] array = (object[])_siInfo.GetValue("ArrayList", typeof(object[]));
		if (array == null)
		{
			return;
		}
		object[] array2 = array;
		foreach (object obj in array2)
		{
			DictionaryEntry dictionaryEntry;
			try
			{
				dictionaryEntry = (DictionaryEntry)obj;
			}
			catch
			{
				throw new SerializationException(SR.GetString("OrderedDictionary_SerializationMismatch"));
			}
			objectsArray.Add(dictionaryEntry);
			objectsTable.Add(dictionaryEntry.Key, dictionaryEntry.Value);
		}
	}

	public void RemoveAt(int index)
	{
		if (_readOnly)
		{
			throw new NotSupportedException(SR.GetString("OrderedDictionary_ReadOnly"));
		}
		if (index >= Count || index < 0)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		object key = ((DictionaryEntry)objectsArray[index]).Key;
		objectsArray.RemoveAt(index);
		objectsTable.Remove(key);
	}

	public void Remove(object key)
	{
		if (_readOnly)
		{
			throw new NotSupportedException(SR.GetString("OrderedDictionary_ReadOnly"));
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		int num = IndexOfKey(key);
		if (num >= 0)
		{
			objectsTable.Remove(key);
			objectsArray.RemoveAt(num);
		}
	}

	public virtual IDictionaryEnumerator GetEnumerator()
	{
		return new OrderedDictionaryEnumerator(objectsArray, 3);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new OrderedDictionaryEnumerator(objectsArray, 3);
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		info.AddValue("KeyComparer", _comparer, typeof(IEqualityComparer));
		info.AddValue("ReadOnly", _readOnly);
		info.AddValue("InitialCapacity", _initialCapacity);
		object[] array = new object[Count];
		_objectsArray.CopyTo(array);
		info.AddValue("ArrayList", array);
	}

	void IDeserializationCallback.OnDeserialization(object sender)
	{
		OnDeserialization(sender);
	}
}
