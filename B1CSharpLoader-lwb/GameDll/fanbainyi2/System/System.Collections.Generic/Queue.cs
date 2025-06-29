using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.Collections.Generic;

[Serializable]
[DebuggerTypeProxy(typeof(System_QueueDebugView<>))]
[DebuggerDisplay("Count = {Count}")]
[ComVisible(false)]
[global::__DynamicallyInvokable]
public class Queue<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
{
	[Serializable]
	[global::__DynamicallyInvokable]
	public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private Queue<T> _q;

		private int _index;

		private int _version;

		private T _currentElement;

		[global::__DynamicallyInvokable]
		public T Current
		{
			[global::__DynamicallyInvokable]
			get
			{
				if (_index < 0)
				{
					if (_index == -1)
					{
						ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumNotStarted);
					}
					else
					{
						ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumEnded);
					}
				}
				return _currentElement;
			}
		}

		[global::__DynamicallyInvokable]
		object IEnumerator.Current
		{
			[global::__DynamicallyInvokable]
			get
			{
				if (_index < 0)
				{
					if (_index == -1)
					{
						ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumNotStarted);
					}
					else
					{
						ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumEnded);
					}
				}
				return _currentElement;
			}
		}

		internal Enumerator(Queue<T> q)
		{
			_q = q;
			_version = _q._version;
			_index = -1;
			_currentElement = default(T);
		}

		[global::__DynamicallyInvokable]
		public void Dispose()
		{
			_index = -2;
			_currentElement = default(T);
		}

		[global::__DynamicallyInvokable]
		public bool MoveNext()
		{
			if (_version != _q._version)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
			}
			if (_index == -2)
			{
				return false;
			}
			_index++;
			if (_index == _q._size)
			{
				_index = -2;
				_currentElement = default(T);
				return false;
			}
			_currentElement = _q.GetElement(_index);
			return true;
		}

		[global::__DynamicallyInvokable]
		void IEnumerator.Reset()
		{
			if (_version != _q._version)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
			}
			_index = -1;
			_currentElement = default(T);
		}
	}

	private T[] _array;

	private int _head;

	private int _tail;

	private int _size;

	private int _version;

	[NonSerialized]
	private object _syncRoot;

	private const int _MinimumGrow = 4;

	private const int _ShrinkThreshold = 32;

	private const int _GrowFactor = 200;

	private const int _DefaultCapacity = 4;

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
	public Queue()
	{
		_array = _emptyArray;
	}

	[global::__DynamicallyInvokable]
	public Queue(int capacity)
	{
		if (capacity < 0)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.capacity, ExceptionResource.ArgumentOutOfRange_NeedNonNegNumRequired);
		}
		_array = new T[capacity];
		_head = 0;
		_tail = 0;
		_size = 0;
	}

	[global::__DynamicallyInvokable]
	public Queue(IEnumerable<T> collection)
	{
		if (collection == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.collection);
		}
		_array = new T[4];
		_size = 0;
		_version = 0;
		foreach (T item in collection)
		{
			Enqueue(item);
		}
	}

	[global::__DynamicallyInvokable]
	public void Clear()
	{
		if (_head < _tail)
		{
			Array.Clear(_array, _head, _size);
		}
		else
		{
			Array.Clear(_array, _head, _array.Length - _head);
			Array.Clear(_array, 0, _tail);
		}
		_head = 0;
		_tail = 0;
		_size = 0;
		_version++;
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
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.arrayIndex, ExceptionResource.ArgumentOutOfRange_Index);
		}
		int num = array.Length;
		if (num - arrayIndex < _size)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
		}
		int num2 = ((num - arrayIndex < _size) ? (num - arrayIndex) : _size);
		if (num2 != 0)
		{
			int num3 = ((_array.Length - _head < num2) ? (_array.Length - _head) : num2);
			Array.Copy(_array, _head, array, arrayIndex, num3);
			num2 -= num3;
			if (num2 > 0)
			{
				Array.Copy(_array, 0, array, arrayIndex + _array.Length - _head, num2);
			}
		}
	}

	[global::__DynamicallyInvokable]
	void ICollection.CopyTo(Array array, int index)
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
		int length = array.Length;
		if (index < 0 || index > length)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_Index);
		}
		if (length - index < _size)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
		}
		int num = ((length - index < _size) ? (length - index) : _size);
		if (num == 0)
		{
			return;
		}
		try
		{
			int num2 = ((_array.Length - _head < num) ? (_array.Length - _head) : num);
			Array.Copy(_array, _head, array, index, num2);
			num -= num2;
			if (num > 0)
			{
				Array.Copy(_array, 0, array, index + _array.Length - _head, num);
			}
		}
		catch (ArrayTypeMismatchException)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
		}
	}

	[global::__DynamicallyInvokable]
	public void Enqueue(T item)
	{
		if (_size == _array.Length)
		{
			int num = (int)((long)_array.Length * 200L / 100);
			if (num < _array.Length + 4)
			{
				num = _array.Length + 4;
			}
			SetCapacity(num);
		}
		_array[_tail] = item;
		_tail = (_tail + 1) % _array.Length;
		_size++;
		_version++;
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
	public T Dequeue()
	{
		if (_size == 0)
		{
			ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EmptyQueue);
		}
		T result = _array[_head];
		_array[_head] = default(T);
		_head = (_head + 1) % _array.Length;
		_size--;
		_version++;
		return result;
	}

	[global::__DynamicallyInvokable]
	public T Peek()
	{
		if (_size == 0)
		{
			ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EmptyQueue);
		}
		return _array[_head];
	}

	[global::__DynamicallyInvokable]
	public bool Contains(T item)
	{
		int num = _head;
		int size = _size;
		EqualityComparer<T> equalityComparer = EqualityComparer<T>.Default;
		while (size-- > 0)
		{
			if (item == null)
			{
				if (_array[num] == null)
				{
					return true;
				}
			}
			else if (_array[num] != null && equalityComparer.Equals(_array[num], item))
			{
				return true;
			}
			num = (num + 1) % _array.Length;
		}
		return false;
	}

	internal T GetElement(int i)
	{
		return _array[(_head + i) % _array.Length];
	}

	[global::__DynamicallyInvokable]
	public T[] ToArray()
	{
		T[] array = new T[_size];
		if (_size == 0)
		{
			return array;
		}
		if (_head < _tail)
		{
			Array.Copy(_array, _head, array, 0, _size);
		}
		else
		{
			Array.Copy(_array, _head, array, 0, _array.Length - _head);
			Array.Copy(_array, 0, array, _array.Length - _head, _tail);
		}
		return array;
	}

	private void SetCapacity(int capacity)
	{
		T[] array = new T[capacity];
		if (_size > 0)
		{
			if (_head < _tail)
			{
				Array.Copy(_array, _head, array, 0, _size);
			}
			else
			{
				Array.Copy(_array, _head, array, 0, _array.Length - _head);
				Array.Copy(_array, 0, array, _array.Length - _head, _tail);
			}
		}
		_array = array;
		_head = 0;
		_tail = ((_size != capacity) ? _size : 0);
		_version++;
	}

	[global::__DynamicallyInvokable]
	public void TrimExcess()
	{
		int num = (int)((double)_array.Length * 0.9);
		if (_size < num)
		{
			SetCapacity(_size);
		}
	}
}
