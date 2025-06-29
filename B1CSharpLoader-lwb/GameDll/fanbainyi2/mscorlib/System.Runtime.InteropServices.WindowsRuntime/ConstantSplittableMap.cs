using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Runtime.InteropServices.WindowsRuntime;

[Serializable]
[DebuggerDisplay("Count = {Count}")]
internal sealed class ConstantSplittableMap<TKey, TValue> : IMapView<TKey, TValue>, IIterable<IKeyValuePair<TKey, TValue>>, IEnumerable<IKeyValuePair<TKey, TValue>>, IEnumerable
{
	private class KeyValuePairComparator : IComparer<KeyValuePair<TKey, TValue>>
	{
		private static readonly IComparer<TKey> keyComparator = Comparer<TKey>.Default;

		public int Compare(KeyValuePair<TKey, TValue> x, KeyValuePair<TKey, TValue> y)
		{
			return keyComparator.Compare(x.Key, y.Key);
		}
	}

	[Serializable]
	internal struct IKeyValuePairEnumerator : IEnumerator<IKeyValuePair<TKey, TValue>>, IDisposable, IEnumerator
	{
		private KeyValuePair<TKey, TValue>[] _array;

		private int _start;

		private int _end;

		private int _current;

		public IKeyValuePair<TKey, TValue> Current
		{
			get
			{
				if (_current < _start)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumNotStarted"));
				}
				if (_current > _end)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumEnded"));
				}
				return new CLRIKeyValuePairImpl<TKey, TValue>(ref _array[_current]);
			}
		}

		object IEnumerator.Current => Current;

		internal IKeyValuePairEnumerator(KeyValuePair<TKey, TValue>[] items, int first, int end)
		{
			_array = items;
			_start = first;
			_end = end;
			_current = _start - 1;
		}

		public bool MoveNext()
		{
			if (_current < _end)
			{
				_current++;
				return true;
			}
			return false;
		}

		void IEnumerator.Reset()
		{
			_current = _start - 1;
		}

		public void Dispose()
		{
		}
	}

	private static readonly KeyValuePairComparator keyValuePairComparator = new KeyValuePairComparator();

	private readonly KeyValuePair<TKey, TValue>[] items;

	private readonly int firstItemIndex;

	private readonly int lastItemIndex;

	public int Count => lastItemIndex - firstItemIndex + 1;

	public uint Size => (uint)(lastItemIndex - firstItemIndex + 1);

	public TValue this[TKey key] => Lookup(key);

	public IEnumerable<TKey> Keys
	{
		get
		{
			throw new NotImplementedException("NYI");
		}
	}

	public IEnumerable<TValue> Values
	{
		get
		{
			throw new NotImplementedException("NYI");
		}
	}

	internal ConstantSplittableMap(IReadOnlyDictionary<TKey, TValue> data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		firstItemIndex = 0;
		lastItemIndex = data.Count - 1;
		items = CreateKeyValueArray(data.Count, data.GetEnumerator());
	}

	internal ConstantSplittableMap(IMapView<TKey, TValue> data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (int.MaxValue < data.Size)
		{
			Exception ex = new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CollectionBackingDictionaryTooLarge"));
			ex.SetErrorCode(-2147483637);
			throw ex;
		}
		int size = (int)data.Size;
		firstItemIndex = 0;
		lastItemIndex = size - 1;
		items = CreateKeyValueArray(size, data.GetEnumerator());
	}

	private ConstantSplittableMap(KeyValuePair<TKey, TValue>[] items, int firstItemIndex, int lastItemIndex)
	{
		this.items = items;
		this.firstItemIndex = firstItemIndex;
		this.lastItemIndex = lastItemIndex;
	}

	private KeyValuePair<TKey, TValue>[] CreateKeyValueArray(int count, IEnumerator<KeyValuePair<TKey, TValue>> data)
	{
		KeyValuePair<TKey, TValue>[] array = new KeyValuePair<TKey, TValue>[count];
		int num = 0;
		while (data.MoveNext())
		{
			array[num++] = data.Current;
		}
		Array.Sort(array, keyValuePairComparator);
		return array;
	}

	private KeyValuePair<TKey, TValue>[] CreateKeyValueArray(int count, IEnumerator<IKeyValuePair<TKey, TValue>> data)
	{
		KeyValuePair<TKey, TValue>[] array = new KeyValuePair<TKey, TValue>[count];
		int num = 0;
		while (data.MoveNext())
		{
			IKeyValuePair<TKey, TValue> current = data.Current;
			array[num++] = new KeyValuePair<TKey, TValue>(current.Key, current.Value);
		}
		Array.Sort(array, keyValuePairComparator);
		return array;
	}

	public TValue Lookup(TKey key)
	{
		if (!TryGetValue(key, out var value))
		{
			Exception ex = new KeyNotFoundException(Environment.GetResourceString("Arg_KeyNotFound"));
			ex.SetErrorCode(-2147483637);
			throw ex;
		}
		return value;
	}

	public bool HasKey(TKey key)
	{
		TValue value;
		return TryGetValue(key, out value);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<IKeyValuePair<TKey, TValue>>)this).GetEnumerator();
	}

	public IIterator<IKeyValuePair<TKey, TValue>> First()
	{
		return new EnumeratorToIteratorAdapter<IKeyValuePair<TKey, TValue>>(GetEnumerator());
	}

	public IEnumerator<IKeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return new IKeyValuePairEnumerator(items, firstItemIndex, lastItemIndex);
	}

	public void Split(out IMapView<TKey, TValue> firstPartition, out IMapView<TKey, TValue> secondPartition)
	{
		if (Count < 2)
		{
			firstPartition = null;
			secondPartition = null;
		}
		else
		{
			int num = (int)(((long)firstItemIndex + (long)lastItemIndex) / 2);
			firstPartition = new ConstantSplittableMap<TKey, TValue>(items, firstItemIndex, num);
			secondPartition = new ConstantSplittableMap<TKey, TValue>(items, num + 1, lastItemIndex);
		}
	}

	public bool ContainsKey(TKey key)
	{
		KeyValuePair<TKey, TValue> value = new KeyValuePair<TKey, TValue>(key, default(TValue));
		int num = Array.BinarySearch(items, firstItemIndex, Count, value, keyValuePairComparator);
		return num >= 0;
	}

	public bool TryGetValue(TKey key, out TValue value)
	{
		KeyValuePair<TKey, TValue> value2 = new KeyValuePair<TKey, TValue>(key, default(TValue));
		int num = Array.BinarySearch(items, firstItemIndex, Count, value2, keyValuePairComparator);
		if (num < 0)
		{
			value = default(TValue);
			return false;
		}
		value = items[num].Value;
		return true;
	}
}
