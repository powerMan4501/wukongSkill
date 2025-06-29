using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;

namespace ILRuntime.Other;

[Serializable]
public sealed class UncheckedList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection
{
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		private UncheckedList<T> list;

		private int index;

		private int version;

		private T current;

		public T Current => current;

		object IEnumerator.Current => Current;

		internal Enumerator(UncheckedList<T> list)
		{
			this.list = list;
			index = 0;
			version = list._version;
			current = default(T);
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			UncheckedList<T> uncheckedList = list;
			if (version == uncheckedList._version && (uint)index < (uint)uncheckedList._size)
			{
				current = uncheckedList._items[index];
				index++;
				return true;
			}
			return MoveNextRare();
		}

		private bool MoveNextRare()
		{
			index = list._size + 1;
			current = default(T);
			return false;
		}

		void IEnumerator.Reset()
		{
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

	public int Capacity
	{
		get
		{
			return _items.Length;
		}
		set
		{
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

	public int Count => _size;

	bool IList.IsFixedSize => false;

	bool ICollection<T>.IsReadOnly => false;

	bool IList.IsReadOnly => false;

	bool ICollection.IsSynchronized => false;

	object ICollection.SyncRoot
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

	public T this[int index]
	{
		get
		{
			return _items[index];
		}
		set
		{
			_items[index] = value;
			_version++;
		}
	}

	object IList.this[int index]
	{
		get
		{
			return this[index];
		}
		set
		{
			try
			{
				this[index] = (T)value;
			}
			catch (InvalidCastException)
			{
			}
		}
	}

	public UncheckedList()
	{
		_items = _emptyArray;
	}

	public UncheckedList(int capacity)
	{
		if (capacity == 0)
		{
			_items = _emptyArray;
		}
		else
		{
			_items = new T[capacity];
		}
	}

	public UncheckedList(IEnumerable<T> collection)
	{
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
		}
		else
		{
			_size = 0;
			_items = _emptyArray;
			AddEnumerable(collection);
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

	public void Add(T item)
	{
		T[] items = _items;
		int size = _size;
		if ((uint)size < (uint)items.Length)
		{
			_size = size + 1;
			items[size] = item;
		}
		else
		{
			AddWithResize(item);
		}
	}

	private void AddWithResize(T item)
	{
		int size = _size;
		EnsureCapacity(size + 1);
		_size = size + 1;
		_items[size] = item;
	}

	int IList.Add(object item)
	{
		try
		{
			Add((T)item);
		}
		catch (InvalidCastException)
		{
		}
		return Count - 1;
	}

	public void AddRange(IEnumerable<T> collection)
	{
		InsertRange(_size, collection);
	}

	public ReadOnlyCollection<T> AsReadOnly()
	{
		return new ReadOnlyCollection<T>(this);
	}

	public int BinarySearch(int index, int count, T item, IComparer<T> comparer)
	{
		if (index < 0)
		{
			return -1;
		}
		return Array.BinarySearch(_items, index, count, item, comparer);
	}

	public int BinarySearch(T item)
	{
		return BinarySearch(0, Count, item, null);
	}

	public int BinarySearch(T item, IComparer<T> comparer)
	{
		return BinarySearch(0, Count, item, comparer);
	}

	public void Clear()
	{
		if (!typeof(T).IsValueType)
		{
			int size = _size;
			_size = 0;
			_version++;
			if (size > 0)
			{
				Array.Clear(_items, 0, size);
			}
		}
		else
		{
			_size = 0;
			_version++;
		}
	}

	public bool Contains(T item)
	{
		if (_size != 0)
		{
			return IndexOf(item) != -1;
		}
		return false;
	}

	bool IList.Contains(object item)
	{
		if (IsCompatibleObject(item))
		{
			return Contains((T)item);
		}
		return false;
	}

	public UncheckedList<TOutput> ConvertAll<TOutput>(Converter<T, TOutput> converter)
	{
		UncheckedList<TOutput> uncheckedList = new UncheckedList<TOutput>(_size);
		for (int i = 0; i < _size; i++)
		{
			uncheckedList._items[i] = converter(_items[i]);
		}
		uncheckedList._size = _size;
		return uncheckedList;
	}

	public void CopyTo(T[] array)
	{
		CopyTo(array, 0);
	}

	void ICollection.CopyTo(Array array, int arrayIndex)
	{
		try
		{
			Array.Copy(_items, 0, array, arrayIndex, _size);
		}
		catch (ArrayTypeMismatchException)
		{
		}
	}

	public void CopyTo(int index, T[] array, int arrayIndex, int count)
	{
		Array.Copy(_items, index, array, arrayIndex, count);
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
		Array.Copy(_items, 0, array, arrayIndex, _size);
	}

	private void EnsureCapacity(int min)
	{
		if (_items.Length < min)
		{
			int num = ((_items.Length == 0) ? 4 : (_items.Length * 2));
			if ((uint)num > 2147483647u)
			{
				num = int.MaxValue;
			}
			if (num < min)
			{
				num = min;
			}
			Capacity = num;
		}
	}

	public bool Exists(Predicate<T> match)
	{
		return FindIndex(match) != -1;
	}

	public T Find(Predicate<T> match)
	{
		for (int i = 0; i < _size; i++)
		{
			if (match(_items[i]))
			{
				return _items[i];
			}
		}
		return default(T);
	}

	public UncheckedList<T> FindAll(Predicate<T> match)
	{
		UncheckedList<T> uncheckedList = new UncheckedList<T>();
		for (int i = 0; i < _size; i++)
		{
			if (match(_items[i]))
			{
				uncheckedList.Add(_items[i]);
			}
		}
		return uncheckedList;
	}

	public int FindIndex(Predicate<T> match)
	{
		return FindIndex(0, _size, match);
	}

	public int FindIndex(int startIndex, Predicate<T> match)
	{
		return FindIndex(startIndex, _size - startIndex, match);
	}

	public int FindIndex(int startIndex, int count, Predicate<T> match)
	{
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

	public T FindLast(Predicate<T> match)
	{
		for (int num = _size - 1; num >= 0; num--)
		{
			if (match(_items[num]))
			{
				return _items[num];
			}
		}
		return default(T);
	}

	public int FindLastIndex(Predicate<T> match)
	{
		return FindLastIndex(_size - 1, _size, match);
	}

	public int FindLastIndex(int startIndex, Predicate<T> match)
	{
		return FindLastIndex(startIndex, startIndex + 1, match);
	}

	public int FindLastIndex(int startIndex, int count, Predicate<T> match)
	{
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

	public void ForEach(Action<T> action)
	{
		int version = _version;
		for (int i = 0; i < _size; i++)
		{
			if (version != _version)
			{
				break;
			}
			action(_items[i]);
		}
	}

	public Enumerator GetEnumerator()
	{
		return new Enumerator(this);
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return new Enumerator(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new Enumerator(this);
	}

	public UncheckedList<T> GetRange(int index, int count)
	{
		UncheckedList<T> uncheckedList = new UncheckedList<T>(count);
		Array.Copy(_items, index, uncheckedList._items, 0, count);
		uncheckedList._size = count;
		return uncheckedList;
	}

	public int IndexOf(T item)
	{
		return Array.IndexOf(_items, item, 0, _size);
	}

	int IList.IndexOf(object item)
	{
		if (IsCompatibleObject(item))
		{
			return IndexOf((T)item);
		}
		return -1;
	}

	public int IndexOf(T item, int index)
	{
		return Array.IndexOf(_items, item, index, _size - index);
	}

	public int IndexOf(T item, int index, int count)
	{
		return Array.IndexOf(_items, item, index, count);
	}

	public void Insert(int index, T item)
	{
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

	void IList.Insert(int index, object item)
	{
		try
		{
			Insert(index, (T)item);
		}
		catch (InvalidCastException)
		{
		}
	}

	public void InsertRange(int index, IEnumerable<T> collection)
	{
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
					collection2.CopyTo(_items, index);
				}
				_size += count;
			}
		}
		else if (index < _size)
		{
			using IEnumerator<T> enumerator = collection.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Insert(index++, enumerator.Current);
			}
		}
		else
		{
			AddEnumerable(collection);
		}
		_version++;
	}

	public int LastIndexOf(T item)
	{
		if (_size == 0)
		{
			return -1;
		}
		return LastIndexOf(item, _size - 1, _size);
	}

	public int LastIndexOf(T item, int index)
	{
		return LastIndexOf(item, index, index + 1);
	}

	public int LastIndexOf(T item, int index, int count)
	{
		if (_size == 0)
		{
			return -1;
		}
		return Array.LastIndexOf(_items, item, index, count);
	}

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

	void IList.Remove(object item)
	{
		if (IsCompatibleObject(item))
		{
			Remove((T)item);
		}
	}

	public int RemoveAll(Predicate<T> match)
	{
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
		if (!typeof(T).IsValueType)
		{
			Array.Clear(_items, i, _size - i);
		}
		int result = _size - i;
		_size = i;
		_version++;
		return result;
	}

	public void RemoveAt(int index)
	{
		_size--;
		if (index < _size)
		{
			Array.Copy(_items, index + 1, _items, index, _size - index);
		}
	}

	public void RemoveRange(int index, int count)
	{
		if (count > 0)
		{
			_ = _size;
			_size -= count;
			if (index < _size)
			{
				Array.Copy(_items, index + count, _items, index, _size - index);
			}
		}
	}

	public void Reverse()
	{
		Reverse(0, Count);
	}

	public void Reverse(int index, int count)
	{
		if (count > 1)
		{
			Array.Reverse((Array)_items, index, count);
		}
		_version++;
	}

	public void Sort()
	{
		Sort(0, Count, null);
	}

	public void Sort(IComparer<T> comparer)
	{
		Sort(0, Count, comparer);
	}

	public void Sort(int index, int count, IComparer<T> comparer)
	{
		if (count > 1)
		{
			Array.Sort(_items, index, count, comparer);
		}
		_version++;
	}

	public void Sort(Comparison<T> comparison)
	{
		throw new NotImplementedException();
	}

	public T[] ToArray()
	{
		if (_size == 0)
		{
			return _emptyArray;
		}
		T[] array = new T[_size];
		Array.Copy(_items, 0, array, 0, _size);
		return array;
	}

	public void TrimExcess()
	{
		int num = (int)((double)_items.Length * 0.9);
		if (_size < num)
		{
			Capacity = _size;
		}
	}

	public bool TrueForAll(Predicate<T> match)
	{
		for (int i = 0; i < _size; i++)
		{
			if (!match(_items[i]))
			{
				return false;
			}
		}
		return true;
	}

	private void AddEnumerable(IEnumerable<T> enumerable)
	{
		using IEnumerator<T> enumerator = enumerable.GetEnumerator();
		_version++;
		while (enumerator.MoveNext())
		{
			T current = enumerator.Current;
			if (_size == _items.Length)
			{
				EnsureCapacity(_size + 1);
			}
			_items[_size++] = current;
		}
	}
}
