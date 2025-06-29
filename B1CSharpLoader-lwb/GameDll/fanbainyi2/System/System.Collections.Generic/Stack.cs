using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.Collections.Generic;

[Serializable]
[DebuggerTypeProxy(typeof(System_StackDebugView<>))]
[DebuggerDisplay("Count = {Count}")]
[ComVisible(false)]
[global::__DynamicallyInvokable]
public class Stack<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
{
	[Serializable]
	[global::__DynamicallyInvokable]
	public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private Stack<T> _stack;

		private int _index;

		private int _version;

		private T currentElement;

		[global::__DynamicallyInvokable]
		public T Current
		{
			[global::__DynamicallyInvokable]
			get
			{
				if (_index == -2)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumNotStarted);
				}
				if (_index == -1)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumEnded);
				}
				return currentElement;
			}
		}

		[global::__DynamicallyInvokable]
		object IEnumerator.Current
		{
			[global::__DynamicallyInvokable]
			get
			{
				if (_index == -2)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumNotStarted);
				}
				if (_index == -1)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumEnded);
				}
				return currentElement;
			}
		}

		internal Enumerator(Stack<T> stack)
		{
			_stack = stack;
			_version = _stack._version;
			_index = -2;
			currentElement = default(T);
		}

		[global::__DynamicallyInvokable]
		public void Dispose()
		{
			_index = -1;
		}

		[global::__DynamicallyInvokable]
		public bool MoveNext()
		{
			if (_version != _stack._version)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
			}
			bool flag;
			if (_index == -2)
			{
				_index = _stack._size - 1;
				flag = _index >= 0;
				if (flag)
				{
					currentElement = _stack._array[_index];
				}
				return flag;
			}
			if (_index == -1)
			{
				return false;
			}
			flag = --_index >= 0;
			if (flag)
			{
				currentElement = _stack._array[_index];
			}
			else
			{
				currentElement = default(T);
			}
			return flag;
		}

		[global::__DynamicallyInvokable]
		void IEnumerator.Reset()
		{
			if (_version != _stack._version)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
			}
			_index = -2;
			currentElement = default(T);
		}
	}

	private T[] _array;

	private int _size;

	private int _version;

	[NonSerialized]
	private object _syncRoot;

	private const int _defaultCapacity = 4;

	private static T[] _emptyArray = new T[0];

	[global::__DynamicallyInvokable]
	public int Count
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _size;
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
	public Stack()
	{
		_array = _emptyArray;
		_size = 0;
		_version = 0;
	}

	[global::__DynamicallyInvokable]
	public Stack(int capacity)
	{
		if (capacity < 0)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.capacity, ExceptionResource.ArgumentOutOfRange_NeedNonNegNumRequired);
		}
		_array = new T[capacity];
		_size = 0;
		_version = 0;
	}

	[global::__DynamicallyInvokable]
	public Stack(IEnumerable<T> collection)
	{
		if (collection == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.collection);
		}
		if (collection is ICollection<T> { Count: var count } collection2)
		{
			_array = new T[count];
			collection2.CopyTo(_array, 0);
			_size = count;
			return;
		}
		_size = 0;
		_array = new T[4];
		foreach (T item in collection)
		{
			Push(item);
		}
	}

	[global::__DynamicallyInvokable]
	public void Clear()
	{
		Array.Clear(_array, 0, _size);
		_size = 0;
		_version++;
	}

	[global::__DynamicallyInvokable]
	public bool Contains(T item)
	{
		int size = _size;
		EqualityComparer<T> equalityComparer = EqualityComparer<T>.Default;
		while (size-- > 0)
		{
			if (item == null)
			{
				if (_array[size] == null)
				{
					return true;
				}
			}
			else if (_array[size] != null && equalityComparer.Equals(_array[size], item))
			{
				return true;
			}
		}
		return false;
	}

	[global::__DynamicallyInvokable]
	public void CopyTo(T[] array, int arrayIndex)
	{
		if (array == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
		}
		if (arrayIndex < 0 || arrayIndex > array.Length)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.arrayIndex, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
		}
		if (array.Length - arrayIndex < _size)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
		}
		Array.Copy(_array, 0, array, arrayIndex, _size);
		Array.Reverse(array, arrayIndex, _size);
	}

	[global::__DynamicallyInvokable]
	void ICollection.CopyTo(Array array, int arrayIndex)
	{
		if (array == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
		}
		if (array.Rank != 1)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
		}
		if (array.GetLowerBound(0) != 0)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NonZeroLowerBound);
		}
		if (arrayIndex < 0 || arrayIndex > array.Length)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.arrayIndex, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
		}
		if (array.Length - arrayIndex < _size)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
		}
		try
		{
			Array.Copy(_array, 0, array, arrayIndex, _size);
			Array.Reverse(array, arrayIndex, _size);
		}
		catch (ArrayTypeMismatchException)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
		}
	}

	[global::__DynamicallyInvokable]
	public Enumerator GetEnumerator()
	{
		return new Enumerator(this);
	}

	[global::__DynamicallyInvokable]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return new Enumerator(this);
	}

	[global::__DynamicallyInvokable]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new Enumerator(this);
	}

	[global::__DynamicallyInvokable]
	public void TrimExcess()
	{
		int num = (int)((double)_array.Length * 0.9);
		if (_size < num)
		{
			T[] array = new T[_size];
			Array.Copy(_array, 0, array, 0, _size);
			_array = array;
			_version++;
		}
	}

	[global::__DynamicallyInvokable]
	public T Peek()
	{
		if (_size == 0)
		{
			ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EmptyStack);
		}
		return _array[_size - 1];
	}

	[global::__DynamicallyInvokable]
	public T Pop()
	{
		if (_size == 0)
		{
			ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EmptyStack);
		}
		_version++;
		T result = _array[--_size];
		_array[_size] = default(T);
		return result;
	}

	[global::__DynamicallyInvokable]
	public void Push(T item)
	{
		if (_size == _array.Length)
		{
			T[] array = new T[(_array.Length == 0) ? 4 : (2 * _array.Length)];
			Array.Copy(_array, 0, array, 0, _size);
			_array = array;
		}
		_array[_size++] = item;
		_version++;
	}

	[global::__DynamicallyInvokable]
	public T[] ToArray()
	{
		T[] array = new T[_size];
		for (int i = 0; i < _size; i++)
		{
			array[i] = _array[_size - i - 1];
		}
		return array;
	}
}
