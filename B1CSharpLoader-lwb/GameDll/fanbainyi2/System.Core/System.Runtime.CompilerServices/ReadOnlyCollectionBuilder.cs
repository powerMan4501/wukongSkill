using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using System.Threading;

namespace System.Runtime.CompilerServices;

[Serializable]
public sealed class ReadOnlyCollectionBuilder<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection
{
	[Serializable]
	private class Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private readonly ReadOnlyCollectionBuilder<T> _builder;

		private readonly int _version;

		private int _index;

		private T _current;

		public T Current => _current;

		object IEnumerator.Current
		{
			get
			{
				if (_index == 0 || _index > _builder._size)
				{
					throw Error.EnumerationIsDone();
				}
				return _current;
			}
		}

		internal Enumerator(ReadOnlyCollectionBuilder<T> builder)
		{
			_builder = builder;
			_version = builder._version;
			_index = 0;
			_current = default(T);
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public bool MoveNext()
		{
			if (_version == _builder._version)
			{
				if (_index < _builder._size)
				{
					_current = _builder._items[_index++];
					return true;
				}
				_index = _builder._size + 1;
				_current = default(T);
				return false;
			}
			throw Error.CollectionModifiedWhileEnumerating();
		}

		void IEnumerator.Reset()
		{
			if (_version != _builder._version)
			{
				throw Error.CollectionModifiedWhileEnumerating();
			}
			_index = 0;
			_current = default(T);
		}
	}

	private const int DefaultCapacity = 4;

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
			ContractUtils.Requires(value >= _size, "value");
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

	public T this[int index]
	{
		get
		{
			ContractUtils.Requires(index < _size, "index");
			return _items[index];
		}
		set
		{
			ContractUtils.Requires(index < _size, "index");
			_items[index] = value;
			_version++;
		}
	}

	bool ICollection<T>.IsReadOnly => false;

	bool IList.IsReadOnly => false;

	bool IList.IsFixedSize => false;

	object IList.this[int index]
	{
		get
		{
			return this[index];
		}
		set
		{
			ValidateNullValue(value, "value");
			try
			{
				this[index] = (T)value;
			}
			catch (InvalidCastException)
			{
				ThrowInvalidTypeException(value, "value");
			}
		}
	}

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

	public ReadOnlyCollectionBuilder()
	{
		_items = _emptyArray;
	}

	public ReadOnlyCollectionBuilder(int capacity)
	{
		ContractUtils.Requires(capacity >= 0, "capacity");
		_items = new T[capacity];
	}

	public ReadOnlyCollectionBuilder(IEnumerable<T> collection)
	{
		ContractUtils.Requires(collection != null, "collection");
		if (collection is ICollection<T> { Count: var count } collection2)
		{
			_items = new T[count];
			collection2.CopyTo(_items, 0);
			_size = count;
			return;
		}
		_size = 0;
		_items = new T[4];
		foreach (T item in collection)
		{
			Add(item);
		}
	}

	public int IndexOf(T item)
	{
		return Array.IndexOf(_items, item, 0, _size);
	}

	public void Insert(int index, T item)
	{
		ContractUtils.Requires(index <= _size, "index");
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

	public void RemoveAt(int index)
	{
		ContractUtils.Requires(index >= 0 && index < _size, "index");
		_size--;
		if (index < _size)
		{
			Array.Copy(_items, index + 1, _items, index, _size - index);
		}
		_items[_size] = default(T);
		_version++;
	}

	public void Add(T item)
	{
		if (_size == _items.Length)
		{
			EnsureCapacity(_size + 1);
		}
		_items[_size++] = item;
		_version++;
	}

	public void Clear()
	{
		if (_size > 0)
		{
			Array.Clear(_items, 0, _size);
			_size = 0;
		}
		_version++;
	}

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

	public void CopyTo(T[] array, int arrayIndex)
	{
		Array.Copy(_items, 0, array, arrayIndex, _size);
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

	public IEnumerator<T> GetEnumerator()
	{
		return new Enumerator(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	int IList.Add(object value)
	{
		ValidateNullValue(value, "value");
		try
		{
			Add((T)value);
		}
		catch (InvalidCastException)
		{
			ThrowInvalidTypeException(value, "value");
		}
		return Count - 1;
	}

	bool IList.Contains(object value)
	{
		if (IsCompatibleObject(value))
		{
			return Contains((T)value);
		}
		return false;
	}

	int IList.IndexOf(object value)
	{
		if (IsCompatibleObject(value))
		{
			return IndexOf((T)value);
		}
		return -1;
	}

	void IList.Insert(int index, object value)
	{
		ValidateNullValue(value, "value");
		try
		{
			Insert(index, (T)value);
		}
		catch (InvalidCastException)
		{
			ThrowInvalidTypeException(value, "value");
		}
	}

	void IList.Remove(object value)
	{
		if (IsCompatibleObject(value))
		{
			Remove((T)value);
		}
	}

	void ICollection.CopyTo(Array array, int index)
	{
		ContractUtils.RequiresNotNull(array, "array");
		ContractUtils.Requires(array.Rank == 1, "array");
		Array.Copy(_items, 0, array, index, _size);
	}

	public void Reverse()
	{
		Reverse(0, Count);
	}

	public void Reverse(int index, int count)
	{
		ContractUtils.Requires(index >= 0, "index");
		ContractUtils.Requires(count >= 0, "count");
		Array.Reverse(_items, index, count);
		_version++;
	}

	public T[] ToArray()
	{
		T[] array = new T[_size];
		Array.Copy(_items, 0, array, 0, _size);
		return array;
	}

	public ReadOnlyCollection<T> ToReadOnlyCollection()
	{
		T[] list = ((_size != _items.Length) ? ToArray() : _items);
		_items = _emptyArray;
		_size = 0;
		_version++;
		return new TrueReadOnlyCollection<T>(list);
	}

	private void EnsureCapacity(int min)
	{
		if (_items.Length < min)
		{
			int num = 4;
			if (_items.Length != 0)
			{
				num = _items.Length * 2;
			}
			if (num < min)
			{
				num = min;
			}
			Capacity = num;
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

	private static void ValidateNullValue(object value, string argument)
	{
		if (value == null && default(T) != null)
		{
			throw new ArgumentException(Strings.InvalidNullValue(typeof(T)), argument);
		}
	}

	private static void ThrowInvalidTypeException(object value, string argument)
	{
		throw new ArgumentException(Strings.InvalidObjectType((value != null) ? ((object)value.GetType()) : ((object)"null"), typeof(T)), argument);
	}
}
