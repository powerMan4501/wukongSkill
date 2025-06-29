using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.Versioning;
using System.Threading;

namespace System.Collections.Generic;

[Serializable]
[DebuggerTypeProxy(typeof(Mscorlib_CollectionDebugView<>))]
[DebuggerDisplay("Count = {Count}")]
[__DynamicallyInvokable]
public class List<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Serializable]
	internal class SynchronizedList : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		private List<T> _list;

		private object _root;

		public int Count
		{
			get
			{
				lock (_root)
				{
					return _list.Count;
				}
			}
		}

		public bool IsReadOnly => ((ICollection<T>)_list).IsReadOnly;

		public T this[int index]
		{
			get
			{
				lock (_root)
				{
					return _list[index];
				}
			}
			set
			{
				lock (_root)
				{
					_list[index] = value;
				}
			}
		}

		internal SynchronizedList(List<T> list)
		{
			_list = list;
			_root = ((ICollection)list).SyncRoot;
		}

		public void Add(T item)
		{
			lock (_root)
			{
				_list.Add(item);
			}
		}

		public void Clear()
		{
			lock (_root)
			{
				_list.Clear();
			}
		}

		public bool Contains(T item)
		{
			lock (_root)
			{
				return _list.Contains(item);
			}
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
			lock (_root)
			{
				_list.CopyTo(array, arrayIndex);
			}
		}

		public bool Remove(T item)
		{
			lock (_root)
			{
				return _list.Remove(item);
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			lock (_root)
			{
				return _list.GetEnumerator();
			}
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			lock (_root)
			{
				return ((IEnumerable<T>)_list).GetEnumerator();
			}
		}

		public int IndexOf(T item)
		{
			lock (_root)
			{
				return _list.IndexOf(item);
			}
		}

		public void Insert(int index, T item)
		{
			lock (_root)
			{
				_list.Insert(index, item);
			}
		}

		public void RemoveAt(int index)
		{
			lock (_root)
			{
				_list.RemoveAt(index);
			}
		}
	}

	[Serializable]
	[__DynamicallyInvokable]
	public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private List<T> list;

		private int index;

		private int version;

		private T current;

		[__DynamicallyInvokable]
		public T Current
		{
			[__DynamicallyInvokable]
			get
			{
				return current;
			}
		}

		[__DynamicallyInvokable]
		object IEnumerator.Current
		{
			[__DynamicallyInvokable]
			get
			{
				if (index == 0 || index == list._size + 1)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumOpCantHappen);
				}
				return Current;
			}
		}

		internal Enumerator(List<T> list)
		{
			this.list = list;
			index = 0;
			version = list._version;
			current = default(T);
		}

		[__DynamicallyInvokable]
		public void Dispose()
		{
		}

		[__DynamicallyInvokable]
		public bool MoveNext()
		{
			List<T> list = this.list;
			if (version == list._version && (uint)index < (uint)list._size)
			{
				current = list._items[index];
				index++;
				return true;
			}
			return MoveNextRare();
		}

		private bool MoveNextRare()
		{
			if (version != list._version)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
			}
			index = list._size + 1;
			current = default(T);
			return false;
		}

		[__DynamicallyInvokable]
		void IEnumerator.Reset()
		{
			if (version != list._version)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
			}
			index = 0;
			current = default(T);
		}
	}

	private const int _defaultCapacity = 4;

	private T[] _items;

	private int _size;

	private int _version;

	[NonSerialized]
	private object _syncRoot;

	private static readonly T[] _emptyArray = new T[0];

	[__DynamicallyInvokable]
	public int Capacity
	{
		[__DynamicallyInvokable]
		get
		{
			return _items.Length;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value < _size)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value, ExceptionResource.ArgumentOutOfRange_SmallCapacity);
			}
			if (value == _items.Length)
			{
				return;
			}
			if (value > 0)
			{
				T[] array = new T[value];
				if (_size > 0)
				{
					Array.Copy(_items, 0, array, 0, _size);
				}
				_items = array;
			}
			else
			{
				_items = _emptyArray;
			}
		}
	}

	[__DynamicallyInvokable]
	public int Count
	{
		[__DynamicallyInvokable]
		get
		{
			return _size;
		}
	}

	[__DynamicallyInvokable]
	bool IList.IsFixedSize
	{
		[__DynamicallyInvokable]
		get
		{
			return false;
		}
	}

	[__DynamicallyInvokable]
	bool ICollection<T>.IsReadOnly
	{
		[__DynamicallyInvokable]
		get
		{
			return false;
		}
	}

	[__DynamicallyInvokable]
	bool IList.IsReadOnly
	{
		[__DynamicallyInvokable]
		get
		{
			return false;
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
			if (_syncRoot == null)
			{
				Interlocked.CompareExchange<object>(ref _syncRoot, new object(), (object)null);
			}
			return _syncRoot;
		}
	}

	[__DynamicallyInvokable]
	public T this[int index]
	{
		[__DynamicallyInvokable]
		get
		{
			if ((uint)index >= (uint)_size)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			return _items[index];
		}
		[__DynamicallyInvokable]
		set
		{
			if ((uint)index >= (uint)_size)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			_items[index] = value;
			_version++;
		}
	}

	[__DynamicallyInvokable]
	object IList.this[int index]
	{
		[__DynamicallyInvokable]
		get
		{
			return this[index];
		}
		[__DynamicallyInvokable]
		set
		{
			ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(value, ExceptionArgument.value);
			try
			{
				this[index] = (T)value;
			}
			catch (InvalidCastException)
			{
				ThrowHelper.ThrowWrongValueTypeArgumentException(value, typeof(T));
			}
		}
	}

	[__DynamicallyInvokable]
	public List()
	{
		_items = _emptyArray;
	}

	[__DynamicallyInvokable]
	public List(int capacity)
	{
		if (capacity < 0)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.capacity, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
		}
		if (capacity == 0)
		{
			_items = _emptyArray;
		}
		else
		{
			_items = new T[capacity];
		}
	}

	[__DynamicallyInvokable]
	public List(IEnumerable<T> collection)
	{
		if (collection == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.collection);
		}
		if (collection is ICollection<T> { Count: var count } collection2)
		{
			if (count == 0)
			{
				_items = _emptyArray;
				return;
			}
			_items = new T[count];
			collection2.CopyTo(_items, 0);
			_size = count;
			return;
		}
		_size = 0;
		_items = _emptyArray;
		foreach (T item in collection)
		{
			Add(item);
		}
	}

	private static bool IsCompatibleObject(object value)
	{
		if (!(value is T))
		{
			if (value == null)
			{
				return default(T) == null;
			}
			return false;
		}
		return true;
	}

	[__DynamicallyInvokable]
	public void Add(T item)
	{
		if (_size == _items.Length)
		{
			EnsureCapacity(_size + 1);
		}
		_items[_size++] = item;
		_version++;
	}

	[__DynamicallyInvokable]
	int IList.Add(object item)
	{
		ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(item, ExceptionArgument.item);
		try
		{
			Add((T)item);
		}
		catch (InvalidCastException)
		{
			ThrowHelper.ThrowWrongValueTypeArgumentException(item, typeof(T));
		}
		return Count - 1;
	}

	[__DynamicallyInvokable]
	public void AddRange(IEnumerable<T> collection)
	{
		InsertRange(_size, collection);
	}

	[__DynamicallyInvokable]
	public ReadOnlyCollection<T> AsReadOnly()
	{
		return new ReadOnlyCollection<T>(this);
	}

	[__DynamicallyInvokable]
	public int BinarySearch(int index, int count, T item, IComparer<T> comparer)
	{
		if (index < 0)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
		}
		if (count < 0)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
		}
		if (_size - index < count)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
		}
		return Array.BinarySearch(_items, index, count, item, comparer);
	}

	[__DynamicallyInvokable]
	public int BinarySearch(T item)
	{
		return BinarySearch(0, Count, item, null);
	}

	[__DynamicallyInvokable]
	public int BinarySearch(T item, IComparer<T> comparer)
	{
		return BinarySearch(0, Count, item, comparer);
	}

	[__DynamicallyInvokable]
	public void Clear()
	{
		if (_size > 0)
		{
			Array.Clear(_items, 0, _size);
			_size = 0;
		}
		_version++;
	}

	[__DynamicallyInvokable]
	public bool Contains(T item)
	{
		if (item == null)
		{
			for (int i = 0; i < _size; i++)
			{
				if (_items[i] == null)
				{
					return true;
				}
			}
			return false;
		}
		EqualityComparer<T> equalityComparer = EqualityComparer<T>.Default;
		for (int j = 0; j < _size; j++)
		{
			if (equalityComparer.Equals(_items[j], item))
			{
				return true;
			}
		}
		return false;
	}

	[__DynamicallyInvokable]
	bool IList.Contains(object item)
	{
		if (IsCompatibleObject(item))
		{
			return Contains((T)item);
		}
		return false;
	}

	public List<TOutput> ConvertAll<TOutput>(Converter<T, TOutput> converter)
	{
		if (converter == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.converter);
		}
		List<TOutput> list = new List<TOutput>(_size);
		for (int i = 0; i < _size; i++)
		{
			list._items[i] = converter(_items[i]);
		}
		list._size = _size;
		return list;
	}

	[__DynamicallyInvokable]
	public void CopyTo(T[] array)
	{
		CopyTo(array, 0);
	}

	[__DynamicallyInvokable]
	void ICollection.CopyTo(Array array, int arrayIndex)
	{
		if (array != null && array.Rank != 1)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
		}
		try
		{
			Array.Copy(_items, 0, array, arrayIndex, _size);
		}
		catch (ArrayTypeMismatchException)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
		}
	}

	[__DynamicallyInvokable]
	public void CopyTo(int index, T[] array, int arrayIndex, int count)
	{
		if (_size - index < count)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
		}
		Array.Copy(_items, index, array, arrayIndex, count);
	}

	[__DynamicallyInvokable]
	public void CopyTo(T[] array, int arrayIndex)
	{
		Array.Copy(_items, 0, array, arrayIndex, _size);
	}

	private void EnsureCapacity(int min)
	{
		if (_items.Length < min)
		{
			int num = ((_items.Length == 0) ? 4 : (_items.Length * 2));
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
	}

	[__DynamicallyInvokable]
	public bool Exists(Predicate<T> match)
	{
		return FindIndex(match) != -1;
	}

	[__DynamicallyInvokable]
	public T Find(Predicate<T> match)
	{
		if (match == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
		}
		for (int i = 0; i < _size; i++)
		{
			if (match(_items[i]))
			{
				return _items[i];
			}
		}
		return default(T);
	}

	[__DynamicallyInvokable]
	public List<T> FindAll(Predicate<T> match)
	{
		if (match == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
		}
		List<T> list = new List<T>();
		for (int i = 0; i < _size; i++)
		{
			if (match(_items[i]))
			{
				list.Add(_items[i]);
			}
		}
		return list;
	}

	[__DynamicallyInvokable]
	public int FindIndex(Predicate<T> match)
	{
		return FindIndex(0, _size, match);
	}

	[__DynamicallyInvokable]
	public int FindIndex(int startIndex, Predicate<T> match)
	{
		return FindIndex(startIndex, _size - startIndex, match);
	}

	[__DynamicallyInvokable]
	public int FindIndex(int startIndex, int count, Predicate<T> match)
	{
		if ((uint)startIndex > (uint)_size)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
		}
		if (count < 0 || startIndex > _size - count)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_Count);
		}
		if (match == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
		}
		int num = startIndex + count;
		for (int i = startIndex; i < num; i++)
		{
			if (match(_items[i]))
			{
				return i;
			}
		}
		return -1;
	}

	[__DynamicallyInvokable]
	public T FindLast(Predicate<T> match)
	{
		if (match == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
		}
		for (int num = _size - 1; num >= 0; num--)
		{
			if (match(_items[num]))
			{
				return _items[num];
			}
		}
		return default(T);
	}

	[__DynamicallyInvokable]
	public int FindLastIndex(Predicate<T> match)
	{
		return FindLastIndex(_size - 1, _size, match);
	}

	[__DynamicallyInvokable]
	public int FindLastIndex(int startIndex, Predicate<T> match)
	{
		return FindLastIndex(startIndex, startIndex + 1, match);
	}

	[__DynamicallyInvokable]
	public int FindLastIndex(int startIndex, int count, Predicate<T> match)
	{
		if (match == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
		}
		if (_size == 0)
		{
			if (startIndex != -1)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
			}
		}
		else if ((uint)startIndex >= (uint)_size)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
		}
		if (count < 0 || startIndex - count + 1 < 0)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_Count);
		}
		int num = startIndex - count;
		for (int num2 = startIndex; num2 > num; num2--)
		{
			if (match(_items[num2]))
			{
				return num2;
			}
		}
		return -1;
	}

	[__DynamicallyInvokable]
	public void ForEach(Action<T> action)
	{
		if (action == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
		}
		int version = _version;
		for (int i = 0; i < _size; i++)
		{
			if (version != _version && BinaryCompatibility.TargetsAtLeast_Desktop_V4_5)
			{
				break;
			}
			action(_items[i]);
		}
		if (version != _version && BinaryCompatibility.TargetsAtLeast_Desktop_V4_5)
		{
			ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
		}
	}

	[__DynamicallyInvokable]
	public Enumerator GetEnumerator()
	{
		return new Enumerator(this);
	}

	[__DynamicallyInvokable]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return new Enumerator(this);
	}

	[__DynamicallyInvokable]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new Enumerator(this);
	}

	[__DynamicallyInvokable]
	public List<T> GetRange(int index, int count)
	{
		if (index < 0)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
		}
		if (count < 0)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
		}
		if (_size - index < count)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
		}
		List<T> list = new List<T>(count);
		Array.Copy(_items, index, list._items, 0, count);
		list._size = count;
		return list;
	}

	[__DynamicallyInvokable]
	public int IndexOf(T item)
	{
		return Array.IndexOf(_items, item, 0, _size);
	}

	[__DynamicallyInvokable]
	int IList.IndexOf(object item)
	{
		if (IsCompatibleObject(item))
		{
			return IndexOf((T)item);
		}
		return -1;
	}

	[__DynamicallyInvokable]
	public int IndexOf(T item, int index)
	{
		if (index > _size)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_Index);
		}
		return Array.IndexOf(_items, item, index, _size - index);
	}

	[__DynamicallyInvokable]
	public int IndexOf(T item, int index, int count)
	{
		if (index > _size)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_Index);
		}
		if (count < 0 || index > _size - count)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_Count);
		}
		return Array.IndexOf(_items, item, index, count);
	}

	[__DynamicallyInvokable]
	public void Insert(int index, T item)
	{
		if ((uint)index > (uint)_size)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_ListInsert);
		}
		if (_size == _items.Length)
		{
			EnsureCapacity(_size + 1);
		}
		if (index < _size)
		{
			Array.Copy(_items, index, _items, index + 1, _size - index);
		}
		_items[index] = item;
		_size++;
		_version++;
	}

	[__DynamicallyInvokable]
	void IList.Insert(int index, object item)
	{
		ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(item, ExceptionArgument.item);
		try
		{
			Insert(index, (T)item);
		}
		catch (InvalidCastException)
		{
			ThrowHelper.ThrowWrongValueTypeArgumentException(item, typeof(T));
		}
	}

	[__DynamicallyInvokable]
	public void InsertRange(int index, IEnumerable<T> collection)
	{
		if (collection == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.collection);
		}
		if ((uint)index > (uint)_size)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_Index);
		}
		if (collection is ICollection<T> { Count: var count } collection2)
		{
			if (count > 0)
			{
				EnsureCapacity(_size + count);
				if (index < _size)
				{
					Array.Copy(_items, index, _items, index + count, _size - index);
				}
				if (this == collection2)
				{
					Array.Copy(_items, 0, _items, index, index);
					Array.Copy(_items, index + count, _items, index * 2, _size - index);
				}
				else
				{
					T[] array = new T[count];
					collection2.CopyTo(array, 0);
					array.CopyTo(_items, index);
				}
				_size += count;
			}
		}
		else
		{
			using IEnumerator<T> enumerator = collection.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Insert(index++, enumerator.Current);
			}
		}
		_version++;
	}

	[__DynamicallyInvokable]
	public int LastIndexOf(T item)
	{
		if (_size == 0)
		{
			return -1;
		}
		return LastIndexOf(item, _size - 1, _size);
	}

	[__DynamicallyInvokable]
	public int LastIndexOf(T item, int index)
	{
		if (index >= _size)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_Index);
		}
		return LastIndexOf(item, index, index + 1);
	}

	[__DynamicallyInvokable]
	public int LastIndexOf(T item, int index, int count)
	{
		if (Count != 0 && index < 0)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
		}
		if (Count != 0 && count < 0)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
		}
		if (_size == 0)
		{
			return -1;
		}
		if (index >= _size)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_BiggerThanCollection);
		}
		if (count > index + 1)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_BiggerThanCollection);
		}
		return Array.LastIndexOf(_items, item, index, count);
	}

	[__DynamicallyInvokable]
	public bool Remove(T item)
	{
		int num = IndexOf(item);
		if (num >= 0)
		{
			RemoveAt(num);
			return true;
		}
		return false;
	}

	[__DynamicallyInvokable]
	void IList.Remove(object item)
	{
		if (IsCompatibleObject(item))
		{
			Remove((T)item);
		}
	}

	[__DynamicallyInvokable]
	public int RemoveAll(Predicate<T> match)
	{
		if (match == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
		}
		int i;
		for (i = 0; i < _size && !match(_items[i]); i++)
		{
		}
		if (i >= _size)
		{
			return 0;
		}
		int j = i + 1;
		while (j < _size)
		{
			for (; j < _size && match(_items[j]); j++)
			{
			}
			if (j < _size)
			{
				_items[i++] = _items[j++];
			}
		}
		Array.Clear(_items, i, _size - i);
		int result = _size - i;
		_size = i;
		_version++;
		return result;
	}

	[__DynamicallyInvokable]
	public void RemoveAt(int index)
	{
		if ((uint)index >= (uint)_size)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		_size--;
		if (index < _size)
		{
			Array.Copy(_items, index + 1, _items, index, _size - index);
		}
		_items[_size] = default(T);
		_version++;
	}

	[__DynamicallyInvokable]
	public void RemoveRange(int index, int count)
	{
		if (index < 0)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
		}
		if (count < 0)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
		}
		if (_size - index < count)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
		}
		if (count > 0)
		{
			int size = _size;
			_size -= count;
			if (index < _size)
			{
				Array.Copy(_items, index + count, _items, index, _size - index);
			}
			Array.Clear(_items, _size, count);
			_version++;
		}
	}

	[__DynamicallyInvokable]
	public void Reverse()
	{
		Reverse(0, Count);
	}

	[__DynamicallyInvokable]
	public void Reverse(int index, int count)
	{
		if (index < 0)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
		}
		if (count < 0)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
		}
		if (_size - index < count)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
		}
		Array.Reverse(_items, index, count);
		_version++;
	}

	[__DynamicallyInvokable]
	public void Sort()
	{
		Sort(0, Count, null);
	}

	[__DynamicallyInvokable]
	public void Sort(IComparer<T> comparer)
	{
		Sort(0, Count, comparer);
	}

	[__DynamicallyInvokable]
	public void Sort(int index, int count, IComparer<T> comparer)
	{
		if (index < 0)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
		}
		if (count < 0)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
		}
		if (_size - index < count)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
		}
		Array.Sort(_items, index, count, comparer);
		_version++;
	}

	[__DynamicallyInvokable]
	public void Sort(Comparison<T> comparison)
	{
		if (comparison == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
		}
		if (_size > 0)
		{
			IComparer<T> comparer = new Array.FunctorComparer<T>(comparison);
			Array.Sort(_items, 0, _size, comparer);
		}
	}

	[__DynamicallyInvokable]
	public T[] ToArray()
	{
		T[] array = new T[_size];
		Array.Copy(_items, 0, array, 0, _size);
		return array;
	}

	[__DynamicallyInvokable]
	public void TrimExcess()
	{
		int num = (int)((double)_items.Length * 0.9);
		if (_size < num)
		{
			Capacity = _size;
		}
	}

	[__DynamicallyInvokable]
	public bool TrueForAll(Predicate<T> match)
	{
		if (match == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
		}
		for (int i = 0; i < _size; i++)
		{
			if (!match(_items[i]))
			{
				return false;
			}
		}
		return true;
	}

	internal static IList<T> Synchronized(List<T> list)
	{
		return new SynchronizedList(list);
	}
}
