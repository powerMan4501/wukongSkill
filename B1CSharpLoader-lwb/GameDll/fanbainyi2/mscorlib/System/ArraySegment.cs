using System.Collections;
using System.Collections.Generic;

namespace System;

[Serializable]
[__DynamicallyInvokable]
public struct ArraySegment<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Serializable]
	private sealed class ArraySegmentEnumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private T[] _array;

		private int _start;

		private int _end;

		private int _current;

		public T Current
		{
			get
			{
				if (_current < _start)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumNotStarted"));
				}
				if (_current >= _end)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumEnded"));
				}
				return _array[_current];
			}
		}

		object IEnumerator.Current => Current;

		internal ArraySegmentEnumerator(ArraySegment<T> arraySegment)
		{
			_array = arraySegment._array;
			_start = arraySegment._offset;
			_end = _start + arraySegment._count;
			_current = _start - 1;
		}

		public bool MoveNext()
		{
			if (_current < _end)
			{
				_current++;
				return _current < _end;
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

	private T[] _array;

	private int _offset;

	private int _count;

	[__DynamicallyInvokable]
	public T[] Array
	{
		[__DynamicallyInvokable]
		get
		{
			return _array;
		}
	}

	[__DynamicallyInvokable]
	public int Offset
	{
		[__DynamicallyInvokable]
		get
		{
			return _offset;
		}
	}

	[__DynamicallyInvokable]
	public int Count
	{
		[__DynamicallyInvokable]
		get
		{
			return _count;
		}
	}

	[__DynamicallyInvokable]
	T IList<T>.this[int index]
	{
		[__DynamicallyInvokable]
		get
		{
			if (_array == null)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NullArray"));
			}
			if (index < 0 || index >= _count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return _array[_offset + index];
		}
		[__DynamicallyInvokable]
		set
		{
			if (_array == null)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NullArray"));
			}
			if (index < 0 || index >= _count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			_array[_offset + index] = value;
		}
	}

	[__DynamicallyInvokable]
	T IReadOnlyList<T>.this[int index]
	{
		[__DynamicallyInvokable]
		get
		{
			if (_array == null)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NullArray"));
			}
			if (index < 0 || index >= _count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return _array[_offset + index];
		}
	}

	[__DynamicallyInvokable]
	bool ICollection<T>.IsReadOnly
	{
		[__DynamicallyInvokable]
		get
		{
			return true;
		}
	}

	[__DynamicallyInvokable]
	public ArraySegment(T[] array)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		_array = array;
		_offset = 0;
		_count = array.Length;
	}

	[__DynamicallyInvokable]
	public ArraySegment(T[] array, int offset, int count)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (array.Length - offset < count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		_array = array;
		_offset = offset;
		_count = count;
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		if (_array != null)
		{
			return _array.GetHashCode() ^ _offset ^ _count;
		}
		return 0;
	}

	[__DynamicallyInvokable]
	public override bool Equals(object obj)
	{
		if (obj is ArraySegment<T>)
		{
			return Equals((ArraySegment<T>)obj);
		}
		return false;
	}

	[__DynamicallyInvokable]
	public bool Equals(ArraySegment<T> obj)
	{
		if (obj._array == _array && obj._offset == _offset)
		{
			return obj._count == _count;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public static bool operator ==(ArraySegment<T> a, ArraySegment<T> b)
	{
		return a.Equals(b);
	}

	[__DynamicallyInvokable]
	public static bool operator !=(ArraySegment<T> a, ArraySegment<T> b)
	{
		return !(a == b);
	}

	[__DynamicallyInvokable]
	int IList<T>.IndexOf(T item)
	{
		if (_array == null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NullArray"));
		}
		int num = System.Array.IndexOf(_array, item, _offset, _count);
		if (num < 0)
		{
			return -1;
		}
		return num - _offset;
	}

	[__DynamicallyInvokable]
	void IList<T>.Insert(int index, T item)
	{
		throw new NotSupportedException();
	}

	[__DynamicallyInvokable]
	void IList<T>.RemoveAt(int index)
	{
		throw new NotSupportedException();
	}

	[__DynamicallyInvokable]
	void ICollection<T>.Add(T item)
	{
		throw new NotSupportedException();
	}

	[__DynamicallyInvokable]
	void ICollection<T>.Clear()
	{
		throw new NotSupportedException();
	}

	[__DynamicallyInvokable]
	bool ICollection<T>.Contains(T item)
	{
		if (_array == null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NullArray"));
		}
		int num = System.Array.IndexOf(_array, item, _offset, _count);
		return num >= 0;
	}

	[__DynamicallyInvokable]
	void ICollection<T>.CopyTo(T[] array, int arrayIndex)
	{
		if (_array == null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NullArray"));
		}
		System.Array.Copy(_array, _offset, array, arrayIndex, _count);
	}

	[__DynamicallyInvokable]
	bool ICollection<T>.Remove(T item)
	{
		throw new NotSupportedException();
	}

	[__DynamicallyInvokable]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		if (_array == null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NullArray"));
		}
		return new ArraySegmentEnumerator(this);
	}

	[__DynamicallyInvokable]
	IEnumerator IEnumerable.GetEnumerator()
	{
		if (_array == null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NullArray"));
		}
		return new ArraySegmentEnumerator(this);
	}
}
