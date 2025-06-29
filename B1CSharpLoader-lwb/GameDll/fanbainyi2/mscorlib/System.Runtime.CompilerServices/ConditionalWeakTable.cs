using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.CompilerServices;

[ComVisible(false)]
[__DynamicallyInvokable]
public sealed class ConditionalWeakTable<TKey, TValue> where TKey : class where TValue : class
{
	[__DynamicallyInvokable]
	public delegate TValue CreateValueCallback(TKey key);

	private struct Entry
	{
		public DependentHandle depHnd;

		public int hashCode;

		public int next;
	}

	private int[] _buckets;

	private Entry[] _entries;

	private int _freeList;

	private const int _initialCapacity = 5;

	private readonly object _lock;

	private bool _invalid;

	internal ICollection<TKey> Keys
	{
		[SecuritySafeCritical]
		get
		{
			List<TKey> list = new List<TKey>();
			lock (_lock)
			{
				for (int i = 0; i < _buckets.Length; i++)
				{
					for (int num = _buckets[i]; num != -1; num = _entries[num].next)
					{
						TKey val = (TKey)_entries[num].depHnd.GetPrimary();
						if (val != null)
						{
							list.Add(val);
						}
					}
				}
				return list;
			}
		}
	}

	internal ICollection<TValue> Values
	{
		[SecuritySafeCritical]
		get
		{
			List<TValue> list = new List<TValue>();
			lock (_lock)
			{
				for (int i = 0; i < _buckets.Length; i++)
				{
					for (int num = _buckets[i]; num != -1; num = _entries[num].next)
					{
						object primary = null;
						object secondary = null;
						_entries[num].depHnd.GetPrimaryAndSecondary(out primary, out secondary);
						if (primary != null)
						{
							list.Add((TValue)secondary);
						}
					}
				}
				return list;
			}
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public ConditionalWeakTable()
	{
		_buckets = new int[0];
		_entries = new Entry[0];
		_freeList = -1;
		_lock = new object();
		Resize();
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public bool TryGetValue(TKey key, out TValue value)
	{
		if (key == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
		}
		lock (_lock)
		{
			VerifyIntegrity();
			return TryGetValueWorker(key, out value);
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public void Add(TKey key, TValue value)
	{
		if (key == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
		}
		lock (_lock)
		{
			VerifyIntegrity();
			_invalid = true;
			int num = FindEntry(key);
			if (num != -1)
			{
				_invalid = false;
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_AddingDuplicate);
			}
			CreateEntry(key, value);
			_invalid = false;
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public bool Remove(TKey key)
	{
		if (key == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
		}
		lock (_lock)
		{
			VerifyIntegrity();
			_invalid = true;
			int num = RuntimeHelpers.GetHashCode(key) & 0x7FFFFFFF;
			int num2 = num % _buckets.Length;
			int num3 = -1;
			for (int num4 = _buckets[num2]; num4 != -1; num4 = _entries[num4].next)
			{
				if (_entries[num4].hashCode == num && _entries[num4].depHnd.GetPrimary() == key)
				{
					if (num3 == -1)
					{
						_buckets[num2] = _entries[num4].next;
					}
					else
					{
						_entries[num3].next = _entries[num4].next;
					}
					_entries[num4].depHnd.Free();
					_entries[num4].next = _freeList;
					_freeList = num4;
					_invalid = false;
					return true;
				}
				num3 = num4;
			}
			_invalid = false;
			return false;
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public TValue GetValue(TKey key, CreateValueCallback createValueCallback)
	{
		if (createValueCallback == null)
		{
			throw new ArgumentNullException("createValueCallback");
		}
		if (TryGetValue(key, out var value))
		{
			return value;
		}
		TValue val = createValueCallback(key);
		lock (_lock)
		{
			VerifyIntegrity();
			_invalid = true;
			if (TryGetValueWorker(key, out value))
			{
				_invalid = false;
				return value;
			}
			CreateEntry(key, val);
			_invalid = false;
			return val;
		}
	}

	[__DynamicallyInvokable]
	public TValue GetOrCreateValue(TKey key)
	{
		return GetValue(key, (TKey k) => Activator.CreateInstance<TValue>());
	}

	[SecuritySafeCritical]
	[FriendAccessAllowed]
	internal TKey FindEquivalentKeyUnsafe(TKey key, out TValue value)
	{
		lock (_lock)
		{
			for (int i = 0; i < _buckets.Length; i++)
			{
				for (int num = _buckets[i]; num != -1; num = _entries[num].next)
				{
					_entries[num].depHnd.GetPrimaryAndSecondary(out var primary, out var secondary);
					if (object.Equals(primary, key))
					{
						value = (TValue)secondary;
						return (TKey)primary;
					}
				}
			}
		}
		value = null;
		return null;
	}

	[SecuritySafeCritical]
	internal void Clear()
	{
		lock (_lock)
		{
			for (int i = 0; i < _buckets.Length; i++)
			{
				_buckets[i] = -1;
			}
			int j;
			for (j = 0; j < _entries.Length; j++)
			{
				if (_entries[j].depHnd.IsAllocated)
				{
					_entries[j].depHnd.Free();
				}
				_entries[j].next = j - 1;
			}
			_freeList = j - 1;
		}
	}

	[SecurityCritical]
	private bool TryGetValueWorker(TKey key, out TValue value)
	{
		int num = FindEntry(key);
		if (num != -1)
		{
			object primary = null;
			object secondary = null;
			_entries[num].depHnd.GetPrimaryAndSecondary(out primary, out secondary);
			if (primary != null)
			{
				value = (TValue)secondary;
				return true;
			}
		}
		value = null;
		return false;
	}

	[SecurityCritical]
	private void CreateEntry(TKey key, TValue value)
	{
		if (_freeList == -1)
		{
			Resize();
		}
		int num = RuntimeHelpers.GetHashCode(key) & 0x7FFFFFFF;
		int num2 = num % _buckets.Length;
		int freeList = _freeList;
		_freeList = _entries[freeList].next;
		_entries[freeList].hashCode = num;
		_entries[freeList].depHnd = new DependentHandle(key, value);
		_entries[freeList].next = _buckets[num2];
		_buckets[num2] = freeList;
	}

	[SecurityCritical]
	private void Resize()
	{
		int num = _buckets.Length;
		bool flag = false;
		int i;
		for (i = 0; i < _entries.Length; i++)
		{
			if (_entries[i].depHnd.IsAllocated && _entries[i].depHnd.GetPrimary() == null)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			num = HashHelpers.GetPrime((_buckets.Length == 0) ? 6 : (_buckets.Length * 2));
		}
		int num2 = -1;
		int[] array = new int[num];
		for (int j = 0; j < num; j++)
		{
			array[j] = -1;
		}
		Entry[] array2 = new Entry[num];
		for (i = 0; i < _entries.Length; i++)
		{
			DependentHandle depHnd = _entries[i].depHnd;
			if (depHnd.IsAllocated && depHnd.GetPrimary() != null)
			{
				int num3 = _entries[i].hashCode % num;
				array2[i].depHnd = depHnd;
				array2[i].hashCode = _entries[i].hashCode;
				array2[i].next = array[num3];
				array[num3] = i;
			}
			else
			{
				_entries[i].depHnd.Free();
				array2[i].depHnd = default(DependentHandle);
				array2[i].next = num2;
				num2 = i;
			}
		}
		for (; i != array2.Length; i++)
		{
			array2[i].depHnd = default(DependentHandle);
			array2[i].next = num2;
			num2 = i;
		}
		_buckets = array;
		_entries = array2;
		_freeList = num2;
	}

	[SecurityCritical]
	private int FindEntry(TKey key)
	{
		int num = RuntimeHelpers.GetHashCode(key) & 0x7FFFFFFF;
		for (int num2 = _buckets[num % _buckets.Length]; num2 != -1; num2 = _entries[num2].next)
		{
			if (_entries[num2].hashCode == num && _entries[num2].depHnd.GetPrimary() == key)
			{
				return num2;
			}
		}
		return -1;
	}

	private void VerifyIntegrity()
	{
		if (_invalid)
		{
			throw new InvalidOperationException(Environment.GetResourceString("CollectionCorrupted"));
		}
	}

	[SecuritySafeCritical]
	~ConditionalWeakTable()
	{
		if (Environment.HasShutdownStarted || _lock == null)
		{
			return;
		}
		lock (_lock)
		{
			if (!_invalid)
			{
				Entry[] entries = _entries;
				_invalid = true;
				_entries = null;
				_buckets = null;
				int i = 0;
				for (; i < entries.Length; i++)
				{
					entries[i].depHnd.Free();
				}
			}
		}
	}
}
