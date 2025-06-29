namespace System.Collections.Immutable;

internal static class ImmutableArray
{
	public static ImmutableArray<T>.Builder CreateBuilder<T>(int capacity)
	{
		return new ImmutableArray<T>.Builder(capacity);
	}
}
internal struct ImmutableArray<T>
{
	public sealed class Builder
	{
		private T[] _elements;

		private int _count;

		public int Count => _count;

		public int Capacity => _elements.Length;

		public T this[int index]
		{
			get
			{
				if (index >= Count)
				{
					throw new IndexOutOfRangeException();
				}
				return _elements[index];
			}
			set
			{
				if (index >= Count)
				{
					throw new IndexOutOfRangeException();
				}
				_elements[index] = value;
			}
		}

		internal Builder(int capacity)
		{
			_elements = new T[capacity];
			_count = 0;
		}

		internal Builder()
			: this(8)
		{
		}

		public ImmutableArray<T> MoveToImmutable()
		{
			if (Capacity != Count)
			{
				throw new InvalidOperationException();
			}
			T[] elements = _elements;
			_elements = ImmutableArray<T>.Empty._array;
			_count = 0;
			return new ImmutableArray<T>(elements);
		}

		public void Add(T item)
		{
			EnsureCapacity(Count + 1);
			_elements[_count++] = item;
		}

		private void EnsureCapacity(int capacity)
		{
			if (_elements.Length < capacity)
			{
				int newSize = Math.Max(_elements.Length * 2, capacity);
				Array.Resize(ref _elements, newSize);
			}
		}
	}

	private readonly T[] _array;

	public static ImmutableArray<T> Empty = new ImmutableArray<T>(new T[0]);

	public bool IsDefault => _array == null;

	public int Length => _array.Length;

	public T this[int index] => _array[index];

	public T[] UnderlyingArray => _array;

	public ImmutableArray(T[] array)
	{
		_array = array;
	}

	public T FirstOrDefault(Func<T, bool> predicate)
	{
		T[] array = _array;
		foreach (T val in array)
		{
			if (predicate(val))
			{
				return val;
			}
		}
		return default(T);
	}

	public void CopyTo(int sourceIndex, T[] destination, int destinationIndex, int length)
	{
		Array.Copy(_array, sourceIndex, destination, destinationIndex, length);
	}
}
