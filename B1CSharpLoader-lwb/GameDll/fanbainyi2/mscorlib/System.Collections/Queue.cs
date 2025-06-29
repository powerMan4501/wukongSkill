using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;

namespace System.Collections;

[Serializable]
[DebuggerTypeProxy(typeof(QueueDebugView))]
[DebuggerDisplay("Count = {Count}")]
[ComVisible(true)]
public class Queue : ICollection, IEnumerable, ICloneable
{
	[Serializable]
	private class SynchronizedQueue : Queue
	{
		private Queue _q;

		private object root;

		public override bool IsSynchronized => true;

		public override object SyncRoot => root;

		public override int Count
		{
			get
			{
				lock (root)
				{
					return _q.Count;
				}
			}
		}

		internal SynchronizedQueue(Queue q)
		{
			_q = q;
			root = _q.SyncRoot;
		}

		public override void Clear()
		{
			lock (root)
			{
				_q.Clear();
			}
		}

		public override object Clone()
		{
			lock (root)
			{
				return new SynchronizedQueue((Queue)_q.Clone());
			}
		}

		public override bool Contains(object obj)
		{
			lock (root)
			{
				return _q.Contains(obj);
			}
		}

		public override void CopyTo(Array array, int arrayIndex)
		{
			lock (root)
			{
				_q.CopyTo(array, arrayIndex);
			}
		}

		public override void Enqueue(object value)
		{
			lock (root)
			{
				_q.Enqueue(value);
			}
		}

		public override object Dequeue()
		{
			lock (root)
			{
				return _q.Dequeue();
			}
		}

		public override IEnumerator GetEnumerator()
		{
			lock (root)
			{
				return _q.GetEnumerator();
			}
		}

		public override object Peek()
		{
			lock (root)
			{
				return _q.Peek();
			}
		}

		public override object[] ToArray()
		{
			lock (root)
			{
				return _q.ToArray();
			}
		}

		public override void TrimToSize()
		{
			lock (root)
			{
				_q.TrimToSize();
			}
		}
	}

	[Serializable]
	private class QueueEnumerator : IEnumerator, ICloneable
	{
		private Queue _q;

		private int _index;

		private int _version;

		private object currentElement;

		public virtual object Current
		{
			get
			{
				if (currentElement == _q._array)
				{
					if (_index == 0)
					{
						throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumNotStarted"));
					}
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumEnded"));
				}
				return currentElement;
			}
		}

		internal QueueEnumerator(Queue q)
		{
			_q = q;
			_version = _q._version;
			_index = 0;
			currentElement = _q._array;
			if (_q._size == 0)
			{
				_index = -1;
			}
		}

		public object Clone()
		{
			return MemberwiseClone();
		}

		public virtual bool MoveNext()
		{
			if (_version != _q._version)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumFailedVersion"));
			}
			if (_index < 0)
			{
				currentElement = _q._array;
				return false;
			}
			currentElement = _q.GetElement(_index);
			_index++;
			if (_index == _q._size)
			{
				_index = -1;
			}
			return true;
		}

		public virtual void Reset()
		{
			if (_version != _q._version)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumFailedVersion"));
			}
			if (_q._size == 0)
			{
				_index = -1;
			}
			else
			{
				_index = 0;
			}
			currentElement = _q._array;
		}
	}

	internal class QueueDebugView
	{
		private Queue queue;

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public object[] Items => queue.ToArray();

		public QueueDebugView(Queue queue)
		{
			if (queue == null)
			{
				throw new ArgumentNullException("queue");
			}
			this.queue = queue;
		}
	}

	private object[] _array;

	private int _head;

	private int _tail;

	private int _size;

	private int _growFactor;

	private int _version;

	[NonSerialized]
	private object _syncRoot;

	private const int _MinimumGrow = 4;

	private const int _ShrinkThreshold = 32;

	public virtual int Count => _size;

	public virtual bool IsSynchronized => false;

	public virtual object SyncRoot
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

	public Queue()
		: this(32, 2f)
	{
	}

	public Queue(int capacity)
		: this(capacity, 2f)
	{
	}

	public Queue(int capacity, float growFactor)
	{
		if (capacity < 0)
		{
			throw new ArgumentOutOfRangeException("capacity", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (!((double)growFactor >= 1.0) || !((double)growFactor <= 10.0))
		{
			throw new ArgumentOutOfRangeException("growFactor", Environment.GetResourceString("ArgumentOutOfRange_QueueGrowFactor", 1, 10));
		}
		_array = new object[capacity];
		_head = 0;
		_tail = 0;
		_size = 0;
		_growFactor = (int)(growFactor * 100f);
	}

	public Queue(ICollection col)
		: this(col?.Count ?? 32)
	{
		if (col == null)
		{
			throw new ArgumentNullException("col");
		}
		IEnumerator enumerator = col.GetEnumerator();
		while (enumerator.MoveNext())
		{
			Enqueue(enumerator.Current);
		}
	}

	public virtual object Clone()
	{
		Queue queue = new Queue(_size);
		queue._size = _size;
		int size = _size;
		int num = ((_array.Length - _head < size) ? (_array.Length - _head) : size);
		Array.Copy(_array, _head, queue._array, 0, num);
		size -= num;
		if (size > 0)
		{
			Array.Copy(_array, 0, queue._array, _array.Length - _head, size);
		}
		queue._version = _version;
		return queue;
	}

	public virtual void Clear()
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

	public virtual void CopyTo(Array array, int index)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (array.Rank != 1)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_RankMultiDimNotSupported"));
		}
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		int length = array.Length;
		if (length - index < _size)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		int size = _size;
		if (size != 0)
		{
			int num = ((_array.Length - _head < size) ? (_array.Length - _head) : size);
			Array.Copy(_array, _head, array, index, num);
			size -= num;
			if (size > 0)
			{
				Array.Copy(_array, 0, array, index + _array.Length - _head, size);
			}
		}
	}

	public virtual void Enqueue(object obj)
	{
		if (_size == _array.Length)
		{
			int num = (int)((long)_array.Length * (long)_growFactor / 100);
			if (num < _array.Length + 4)
			{
				num = _array.Length + 4;
			}
			SetCapacity(num);
		}
		_array[_tail] = obj;
		_tail = (_tail + 1) % _array.Length;
		_size++;
		_version++;
	}

	public virtual IEnumerator GetEnumerator()
	{
		return new QueueEnumerator(this);
	}

	public virtual object Dequeue()
	{
		if (Count == 0)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EmptyQueue"));
		}
		object result = _array[_head];
		_array[_head] = null;
		_head = (_head + 1) % _array.Length;
		_size--;
		_version++;
		return result;
	}

	public virtual object Peek()
	{
		if (Count == 0)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EmptyQueue"));
		}
		return _array[_head];
	}

	[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
	public static Queue Synchronized(Queue queue)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		return new SynchronizedQueue(queue);
	}

	public virtual bool Contains(object obj)
	{
		int num = _head;
		int size = _size;
		while (size-- > 0)
		{
			if (obj == null)
			{
				if (_array[num] == null)
				{
					return true;
				}
			}
			else if (_array[num] != null && _array[num].Equals(obj))
			{
				return true;
			}
			num = (num + 1) % _array.Length;
		}
		return false;
	}

	internal object GetElement(int i)
	{
		return _array[(_head + i) % _array.Length];
	}

	public virtual object[] ToArray()
	{
		object[] array = new object[_size];
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
		object[] array = new object[capacity];
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

	public virtual void TrimToSize()
	{
		SetCapacity(_size);
	}
}
