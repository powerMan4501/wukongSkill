using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;

namespace System.Collections;

[Serializable]
[DebuggerTypeProxy(typeof(SortedListDebugView))]
[DebuggerDisplay("Count = {Count}")]
[ComVisible(true)]
public class SortedList : IDictionary, ICollection, IEnumerable, ICloneable
{
	[Serializable]
	private class SyncSortedList : SortedList
	{
		private SortedList _list;

		private object _root;

		public override int Count
		{
			get
			{
				lock (_root)
				{
					return _list.Count;
				}
			}
		}

		public override object SyncRoot => _root;

		public override bool IsReadOnly => _list.IsReadOnly;

		public override bool IsFixedSize => _list.IsFixedSize;

		public override bool IsSynchronized => true;

		public override object this[object key]
		{
			get
			{
				lock (_root)
				{
					return _list[key];
				}
			}
			set
			{
				lock (_root)
				{
					_list[key] = value;
				}
			}
		}

		public override int Capacity
		{
			get
			{
				lock (_root)
				{
					return _list.Capacity;
				}
			}
		}

		internal SyncSortedList(SortedList list)
		{
			_list = list;
			_root = list.SyncRoot;
		}

		public override void Add(object key, object value)
		{
			lock (_root)
			{
				_list.Add(key, value);
			}
		}

		public override void Clear()
		{
			lock (_root)
			{
				_list.Clear();
			}
		}

		public override object Clone()
		{
			lock (_root)
			{
				return _list.Clone();
			}
		}

		public override bool Contains(object key)
		{
			lock (_root)
			{
				return _list.Contains(key);
			}
		}

		public override bool ContainsKey(object key)
		{
			lock (_root)
			{
				return _list.ContainsKey(key);
			}
		}

		public override bool ContainsValue(object key)
		{
			lock (_root)
			{
				return _list.ContainsValue(key);
			}
		}

		public override void CopyTo(Array array, int index)
		{
			lock (_root)
			{
				_list.CopyTo(array, index);
			}
		}

		public override object GetByIndex(int index)
		{
			lock (_root)
			{
				return _list.GetByIndex(index);
			}
		}

		public override IDictionaryEnumerator GetEnumerator()
		{
			lock (_root)
			{
				return _list.GetEnumerator();
			}
		}

		public override object GetKey(int index)
		{
			lock (_root)
			{
				return _list.GetKey(index);
			}
		}

		public override IList GetKeyList()
		{
			lock (_root)
			{
				return _list.GetKeyList();
			}
		}

		public override IList GetValueList()
		{
			lock (_root)
			{
				return _list.GetValueList();
			}
		}

		public override int IndexOfKey(object key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key", Environment.GetResourceString("ArgumentNull_Key"));
			}
			lock (_root)
			{
				return _list.IndexOfKey(key);
			}
		}

		public override int IndexOfValue(object value)
		{
			lock (_root)
			{
				return _list.IndexOfValue(value);
			}
		}

		public override void RemoveAt(int index)
		{
			lock (_root)
			{
				_list.RemoveAt(index);
			}
		}

		public override void Remove(object key)
		{
			lock (_root)
			{
				_list.Remove(key);
			}
		}

		public override void SetByIndex(int index, object value)
		{
			lock (_root)
			{
				_list.SetByIndex(index, value);
			}
		}

		internal override KeyValuePairs[] ToKeyValuePairsArray()
		{
			return _list.ToKeyValuePairsArray();
		}

		public override void TrimToSize()
		{
			lock (_root)
			{
				_list.TrimToSize();
			}
		}
	}

	[Serializable]
	private class SortedListEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable
	{
		private SortedList sortedList;

		private object key;

		private object value;

		private int index;

		private int startIndex;

		private int endIndex;

		private int version;

		private bool current;

		private int getObjectRetType;

		internal const int Keys = 1;

		internal const int Values = 2;

		internal const int DictEntry = 3;

		public virtual object Key
		{
			get
			{
				if (version != sortedList.version)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumFailedVersion"));
				}
				if (!current)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumOpCantHappen"));
				}
				return key;
			}
		}

		public virtual DictionaryEntry Entry
		{
			get
			{
				if (version != sortedList.version)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumFailedVersion"));
				}
				if (!current)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumOpCantHappen"));
				}
				return new DictionaryEntry(key, value);
			}
		}

		public virtual object Current
		{
			get
			{
				if (!current)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumOpCantHappen"));
				}
				if (getObjectRetType == 1)
				{
					return key;
				}
				if (getObjectRetType == 2)
				{
					return value;
				}
				return new DictionaryEntry(key, value);
			}
		}

		public virtual object Value
		{
			get
			{
				if (version != sortedList.version)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumFailedVersion"));
				}
				if (!current)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumOpCantHappen"));
				}
				return value;
			}
		}

		internal SortedListEnumerator(SortedList sortedList, int index, int count, int getObjRetType)
		{
			this.sortedList = sortedList;
			this.index = index;
			startIndex = index;
			endIndex = index + count;
			version = sortedList.version;
			getObjectRetType = getObjRetType;
			current = false;
		}

		public object Clone()
		{
			return MemberwiseClone();
		}

		public virtual bool MoveNext()
		{
			if (version != sortedList.version)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumFailedVersion"));
			}
			if (index < endIndex)
			{
				key = sortedList.keys[index];
				value = sortedList.values[index];
				index++;
				current = true;
				return true;
			}
			key = null;
			value = null;
			current = false;
			return false;
		}

		public virtual void Reset()
		{
			if (version != sortedList.version)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumFailedVersion"));
			}
			index = startIndex;
			current = false;
			key = null;
			value = null;
		}
	}

	[Serializable]
	private class KeyList : IList, ICollection, IEnumerable
	{
		private SortedList sortedList;

		public virtual int Count => sortedList._size;

		public virtual bool IsReadOnly => true;

		public virtual bool IsFixedSize => true;

		public virtual bool IsSynchronized => sortedList.IsSynchronized;

		public virtual object SyncRoot => sortedList.SyncRoot;

		public virtual object this[int index]
		{
			get
			{
				return sortedList.GetKey(index);
			}
			set
			{
				throw new NotSupportedException(Environment.GetResourceString("NotSupported_KeyCollectionSet"));
			}
		}

		internal KeyList(SortedList sortedList)
		{
			this.sortedList = sortedList;
		}

		public virtual int Add(object key)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_SortedListNestedWrite"));
		}

		public virtual void Clear()
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_SortedListNestedWrite"));
		}

		public virtual bool Contains(object key)
		{
			return sortedList.Contains(key);
		}

		public virtual void CopyTo(Array array, int arrayIndex)
		{
			if (array != null && array.Rank != 1)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_RankMultiDimNotSupported"));
			}
			Array.Copy(sortedList.keys, 0, array, arrayIndex, sortedList.Count);
		}

		public virtual void Insert(int index, object value)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_SortedListNestedWrite"));
		}

		public virtual IEnumerator GetEnumerator()
		{
			return new SortedListEnumerator(sortedList, 0, sortedList.Count, 1);
		}

		public virtual int IndexOf(object key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key", Environment.GetResourceString("ArgumentNull_Key"));
			}
			int num = Array.BinarySearch(sortedList.keys, 0, sortedList.Count, key, sortedList.comparer);
			if (num >= 0)
			{
				return num;
			}
			return -1;
		}

		public virtual void Remove(object key)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_SortedListNestedWrite"));
		}

		public virtual void RemoveAt(int index)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_SortedListNestedWrite"));
		}
	}

	[Serializable]
	private class ValueList : IList, ICollection, IEnumerable
	{
		private SortedList sortedList;

		public virtual int Count => sortedList._size;

		public virtual bool IsReadOnly => true;

		public virtual bool IsFixedSize => true;

		public virtual bool IsSynchronized => sortedList.IsSynchronized;

		public virtual object SyncRoot => sortedList.SyncRoot;

		public virtual object this[int index]
		{
			get
			{
				return sortedList.GetByIndex(index);
			}
			set
			{
				throw new NotSupportedException(Environment.GetResourceString("NotSupported_SortedListNestedWrite"));
			}
		}

		internal ValueList(SortedList sortedList)
		{
			this.sortedList = sortedList;
		}

		public virtual int Add(object key)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_SortedListNestedWrite"));
		}

		public virtual void Clear()
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_SortedListNestedWrite"));
		}

		public virtual bool Contains(object value)
		{
			return sortedList.ContainsValue(value);
		}

		public virtual void CopyTo(Array array, int arrayIndex)
		{
			if (array != null && array.Rank != 1)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_RankMultiDimNotSupported"));
			}
			Array.Copy(sortedList.values, 0, array, arrayIndex, sortedList.Count);
		}

		public virtual void Insert(int index, object value)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_SortedListNestedWrite"));
		}

		public virtual IEnumerator GetEnumerator()
		{
			return new SortedListEnumerator(sortedList, 0, sortedList.Count, 2);
		}

		public virtual int IndexOf(object value)
		{
			return Array.IndexOf(sortedList.values, value, 0, sortedList.Count);
		}

		public virtual void Remove(object value)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_SortedListNestedWrite"));
		}

		public virtual void RemoveAt(int index)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_SortedListNestedWrite"));
		}
	}

	internal class SortedListDebugView
	{
		private SortedList sortedList;

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public KeyValuePairs[] Items => sortedList.ToKeyValuePairsArray();

		public SortedListDebugView(SortedList sortedList)
		{
			if (sortedList == null)
			{
				throw new ArgumentNullException("sortedList");
			}
			this.sortedList = sortedList;
		}
	}

	private object[] keys;

	private object[] values;

	private int _size;

	private int version;

	private IComparer comparer;

	private KeyList keyList;

	private ValueList valueList;

	[NonSerialized]
	private object _syncRoot;

	private const int _defaultCapacity = 16;

	private static object[] emptyArray = EmptyArray<object>.Value;

	public virtual int Capacity
	{
		get
		{
			return keys.Length;
		}
		set
		{
			if (value < Count)
			{
				throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("ArgumentOutOfRange_SmallCapacity"));
			}
			if (value == keys.Length)
			{
				return;
			}
			if (value > 0)
			{
				object[] destinationArray = new object[value];
				object[] destinationArray2 = new object[value];
				if (_size > 0)
				{
					Array.Copy(keys, 0, destinationArray, 0, _size);
					Array.Copy(values, 0, destinationArray2, 0, _size);
				}
				keys = destinationArray;
				values = destinationArray2;
			}
			else
			{
				keys = emptyArray;
				values = emptyArray;
			}
		}
	}

	public virtual int Count => _size;

	public virtual ICollection Keys => GetKeyList();

	public virtual ICollection Values => GetValueList();

	public virtual bool IsReadOnly => false;

	public virtual bool IsFixedSize => false;

	public virtual bool IsSynchronized => false;

	public virtual object SyncRoot
	{
		get
		{
			if (_syncRoot == null)
			{
				Interlocked.CompareExchange<object>(ref _syncRoot, new object(), (object)null);
			}
			return _syncRoot;
		}
	}

	public virtual object this[object key]
	{
		get
		{
			int num = IndexOfKey(key);
			if (num >= 0)
			{
				return values[num];
			}
			return null;
		}
		set
		{
			if (key == null)
			{
				throw new ArgumentNullException("key", Environment.GetResourceString("ArgumentNull_Key"));
			}
			int num = Array.BinarySearch(keys, 0, _size, key, comparer);
			if (num >= 0)
			{
				values[num] = value;
				version++;
			}
			else
			{
				Insert(~num, key, value);
			}
		}
	}

	public SortedList()
	{
		Init();
	}

	private void Init()
	{
		keys = emptyArray;
		values = emptyArray;
		_size = 0;
		comparer = new Comparer(CultureInfo.CurrentCulture);
	}

	public SortedList(int initialCapacity)
	{
		if (initialCapacity < 0)
		{
			throw new ArgumentOutOfRangeException("initialCapacity", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		keys = new object[initialCapacity];
		values = new object[initialCapacity];
		comparer = new Comparer(CultureInfo.CurrentCulture);
	}

	public SortedList(IComparer comparer)
		: this()
	{
		if (comparer != null)
		{
			this.comparer = comparer;
		}
	}

	public SortedList(IComparer comparer, int capacity)
		: this(comparer)
	{
		Capacity = capacity;
	}

	public SortedList(IDictionary d)
		: this(d, null)
	{
	}

	public SortedList(IDictionary d, IComparer comparer)
		: this(comparer, d?.Count ?? 0)
	{
		if (d == null)
		{
			throw new ArgumentNullException("d", Environment.GetResourceString("ArgumentNull_Dictionary"));
		}
		d.Keys.CopyTo(keys, 0);
		d.Values.CopyTo(values, 0);
		Array.Sort(keys, values, comparer);
		_size = d.Count;
	}

	public virtual void Add(object key, object value)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key", Environment.GetResourceString("ArgumentNull_Key"));
		}
		int num = Array.BinarySearch(keys, 0, _size, key, comparer);
		if (num >= 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_AddingDuplicate__", GetKey(num), key));
		}
		Insert(~num, key, value);
	}

	public virtual void Clear()
	{
		version++;
		Array.Clear(keys, 0, _size);
		Array.Clear(values, 0, _size);
		_size = 0;
	}

	public virtual object Clone()
	{
		SortedList sortedList = new SortedList(_size);
		Array.Copy(keys, 0, sortedList.keys, 0, _size);
		Array.Copy(values, 0, sortedList.values, 0, _size);
		sortedList._size = _size;
		sortedList.version = version;
		sortedList.comparer = comparer;
		return sortedList;
	}

	public virtual bool Contains(object key)
	{
		return IndexOfKey(key) >= 0;
	}

	public virtual bool ContainsKey(object key)
	{
		return IndexOfKey(key) >= 0;
	}

	public virtual bool ContainsValue(object value)
	{
		return IndexOfValue(value) >= 0;
	}

	public virtual void CopyTo(Array array, int arrayIndex)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array", Environment.GetResourceString("ArgumentNull_Array"));
		}
		if (array.Rank != 1)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_RankMultiDimNotSupported"));
		}
		if (arrayIndex < 0)
		{
			throw new ArgumentOutOfRangeException("arrayIndex", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (array.Length - arrayIndex < Count)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_ArrayPlusOffTooSmall"));
		}
		for (int i = 0; i < Count; i++)
		{
			DictionaryEntry dictionaryEntry = new DictionaryEntry(keys[i], values[i]);
			array.SetValue(dictionaryEntry, i + arrayIndex);
		}
	}

	internal virtual KeyValuePairs[] ToKeyValuePairsArray()
	{
		KeyValuePairs[] array = new KeyValuePairs[Count];
		for (int i = 0; i < Count; i++)
		{
			array[i] = new KeyValuePairs(keys[i], values[i]);
		}
		return array;
	}

	private void EnsureCapacity(int min)
	{
		int num = ((keys.Length == 0) ? 16 : (keys.Length * 2));
		if ((uint)num > 2146435071u)
		{
			num = 2146435071;
		}
		if (num < min)
		{
			num = min;
		}
		Capacity = num;
	}

	public virtual object GetByIndex(int index)
	{
		if (index < 0 || index >= Count)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		return values[index];
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new SortedListEnumerator(this, 0, _size, 3);
	}

	public virtual IDictionaryEnumerator GetEnumerator()
	{
		return new SortedListEnumerator(this, 0, _size, 3);
	}

	public virtual object GetKey(int index)
	{
		if (index < 0 || index >= Count)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		return keys[index];
	}

	public virtual IList GetKeyList()
	{
		if (keyList == null)
		{
			keyList = new KeyList(this);
		}
		return keyList;
	}

	public virtual IList GetValueList()
	{
		if (valueList == null)
		{
			valueList = new ValueList(this);
		}
		return valueList;
	}

	public virtual int IndexOfKey(object key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key", Environment.GetResourceString("ArgumentNull_Key"));
		}
		int num = Array.BinarySearch(keys, 0, _size, key, comparer);
		if (num < 0)
		{
			return -1;
		}
		return num;
	}

	public virtual int IndexOfValue(object value)
	{
		return Array.IndexOf(values, value, 0, _size);
	}

	private void Insert(int index, object key, object value)
	{
		if (_size == keys.Length)
		{
			EnsureCapacity(_size + 1);
		}
		if (index < _size)
		{
			Array.Copy(keys, index, keys, index + 1, _size - index);
			Array.Copy(values, index, values, index + 1, _size - index);
		}
		keys[index] = key;
		values[index] = value;
		_size++;
		version++;
	}

	public virtual void RemoveAt(int index)
	{
		if (index < 0 || index >= Count)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		_size--;
		if (index < _size)
		{
			Array.Copy(keys, index + 1, keys, index, _size - index);
			Array.Copy(values, index + 1, values, index, _size - index);
		}
		keys[_size] = null;
		values[_size] = null;
		version++;
	}

	public virtual void Remove(object key)
	{
		int num = IndexOfKey(key);
		if (num >= 0)
		{
			RemoveAt(num);
		}
	}

	public virtual void SetByIndex(int index, object value)
	{
		if (index < 0 || index >= Count)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		values[index] = value;
		version++;
	}

	[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
	public static SortedList Synchronized(SortedList list)
	{
		if (list == null)
		{
			throw new ArgumentNullException("list");
		}
		return new SyncSortedList(list);
	}

	public virtual void TrimToSize()
	{
		Capacity = _size;
	}
}
