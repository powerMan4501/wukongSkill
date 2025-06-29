using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Threading;

namespace System.Collections.Concurrent;

[Serializable]
[ComVisible(false)]
[DebuggerTypeProxy(typeof(Mscorlib_DictionaryDebugView<, >))]
[DebuggerDisplay("Count = {Count}")]
[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public class ConcurrentDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
{
	private class Tables
	{
		internal readonly Node[] m_buckets;

		internal readonly object[] m_locks;

		internal volatile int[] m_countPerLock;

		internal readonly IEqualityComparer<TKey> m_comparer;

		internal Tables(Node[] buckets, object[] locks, int[] countPerLock, IEqualityComparer<TKey> comparer)
		{
			m_buckets = buckets;
			m_locks = locks;
			m_countPerLock = countPerLock;
			m_comparer = comparer;
		}
	}

	private class Node
	{
		internal TKey m_key;

		internal TValue m_value;

		internal volatile Node m_next;

		internal int m_hashcode;

		internal Node(TKey key, TValue value, int hashcode, Node next)
		{
			m_key = key;
			m_value = value;
			m_next = next;
			m_hashcode = hashcode;
		}
	}

	private class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private IEnumerator<KeyValuePair<TKey, TValue>> m_enumerator;

		public DictionaryEntry Entry => new DictionaryEntry(m_enumerator.Current.Key, m_enumerator.Current.Value);

		public object Key => m_enumerator.Current.Key;

		public object Value => m_enumerator.Current.Value;

		public object Current => Entry;

		internal DictionaryEnumerator(ConcurrentDictionary<TKey, TValue> dictionary)
		{
			m_enumerator = dictionary.GetEnumerator();
		}

		public bool MoveNext()
		{
			return m_enumerator.MoveNext();
		}

		public void Reset()
		{
			m_enumerator.Reset();
		}
	}

	[NonSerialized]
	private volatile Tables m_tables;

	internal IEqualityComparer<TKey> m_comparer;

	[NonSerialized]
	private readonly bool m_growLockArray;

	[OptionalField]
	private int m_keyRehashCount;

	[NonSerialized]
	private int m_budget;

	private KeyValuePair<TKey, TValue>[] m_serializationArray;

	private int m_serializationConcurrencyLevel;

	private int m_serializationCapacity;

	private const int DEFAULT_CAPACITY = 31;

	private const int MAX_LOCK_NUMBER = 1024;

	private static readonly bool s_isValueWriteAtomic = IsValueWriteAtomic();

	[__DynamicallyInvokable]
	public TValue this[TKey key]
	{
		[__DynamicallyInvokable]
		get
		{
			if (!TryGetValue(key, out var value))
			{
				throw new KeyNotFoundException();
			}
			return value;
		}
		[__DynamicallyInvokable]
		set
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			TryAddInternal(key, value, updateIfExists: true, acquireLock: true, out var _);
		}
	}

	[__DynamicallyInvokable]
	public int Count
	{
		[__DynamicallyInvokable]
		get
		{
			int locksAcquired = 0;
			try
			{
				AcquireAllLocks(ref locksAcquired);
				return GetCountInternal();
			}
			finally
			{
				ReleaseLocks(0, locksAcquired);
			}
		}
	}

	[__DynamicallyInvokable]
	public bool IsEmpty
	{
		[__DynamicallyInvokable]
		get
		{
			int locksAcquired = 0;
			try
			{
				AcquireAllLocks(ref locksAcquired);
				for (int i = 0; i < m_tables.m_countPerLock.Length; i++)
				{
					if (m_tables.m_countPerLock[i] != 0)
					{
						return false;
					}
				}
			}
			finally
			{
				ReleaseLocks(0, locksAcquired);
			}
			return true;
		}
	}

	[__DynamicallyInvokable]
	public ICollection<TKey> Keys
	{
		[__DynamicallyInvokable]
		get
		{
			return GetKeys();
		}
	}

	[__DynamicallyInvokable]
	IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys
	{
		[__DynamicallyInvokable]
		get
		{
			return GetKeys();
		}
	}

	[__DynamicallyInvokable]
	public ICollection<TValue> Values
	{
		[__DynamicallyInvokable]
		get
		{
			return GetValues();
		}
	}

	[__DynamicallyInvokable]
	IEnumerable<TValue> IReadOnlyDictionary<TKey, TValue>.Values
	{
		[__DynamicallyInvokable]
		get
		{
			return GetValues();
		}
	}

	[__DynamicallyInvokable]
	bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly
	{
		[__DynamicallyInvokable]
		get
		{
			return false;
		}
	}

	[__DynamicallyInvokable]
	bool IDictionary.IsFixedSize
	{
		[__DynamicallyInvokable]
		get
		{
			return false;
		}
	}

	[__DynamicallyInvokable]
	bool IDictionary.IsReadOnly
	{
		[__DynamicallyInvokable]
		get
		{
			return false;
		}
	}

	[__DynamicallyInvokable]
	ICollection IDictionary.Keys
	{
		[__DynamicallyInvokable]
		get
		{
			return GetKeys();
		}
	}

	[__DynamicallyInvokable]
	ICollection IDictionary.Values
	{
		[__DynamicallyInvokable]
		get
		{
			return GetValues();
		}
	}

	[__DynamicallyInvokable]
	object IDictionary.this[object key]
	{
		[__DynamicallyInvokable]
		get
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			if (key is TKey && TryGetValue((TKey)key, out var value))
			{
				return value;
			}
			return null;
		}
		[__DynamicallyInvokable]
		set
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			if (!(key is TKey))
			{
				throw new ArgumentException(GetResource("ConcurrentDictionary_TypeOfKeyIncorrect"));
			}
			if (!(value is TValue))
			{
				throw new ArgumentException(GetResource("ConcurrentDictionary_TypeOfValueIncorrect"));
			}
			this[(TKey)key] = (TValue)value;
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
			throw new NotSupportedException(Environment.GetResourceString("ConcurrentCollection_SyncRoot_NotSupported"));
		}
	}

	private static int DefaultConcurrencyLevel => PlatformHelper.ProcessorCount;

	private static bool IsValueWriteAtomic()
	{
		Type typeFromHandle = typeof(TValue);
		if (typeFromHandle.IsClass)
		{
			return true;
		}
		switch (Type.GetTypeCode(typeFromHandle))
		{
		case TypeCode.Boolean:
		case TypeCode.Char:
		case TypeCode.SByte:
		case TypeCode.Byte:
		case TypeCode.Int16:
		case TypeCode.UInt16:
		case TypeCode.Int32:
		case TypeCode.UInt32:
		case TypeCode.Single:
			return true;
		case TypeCode.Int64:
		case TypeCode.UInt64:
		case TypeCode.Double:
			return IntPtr.Size == 8;
		default:
			return false;
		}
	}

	[__DynamicallyInvokable]
	public ConcurrentDictionary()
		: this(DefaultConcurrencyLevel, 31, growLockArray: true, (IEqualityComparer<TKey>)EqualityComparer<TKey>.Default)
	{
	}

	[__DynamicallyInvokable]
	public ConcurrentDictionary(int concurrencyLevel, int capacity)
		: this(concurrencyLevel, capacity, growLockArray: false, (IEqualityComparer<TKey>)EqualityComparer<TKey>.Default)
	{
	}

	[__DynamicallyInvokable]
	public ConcurrentDictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection)
		: this(collection, (IEqualityComparer<TKey>)EqualityComparer<TKey>.Default)
	{
	}

	[__DynamicallyInvokable]
	public ConcurrentDictionary(IEqualityComparer<TKey> comparer)
		: this(DefaultConcurrencyLevel, 31, growLockArray: true, comparer)
	{
	}

	[__DynamicallyInvokable]
	public ConcurrentDictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection, IEqualityComparer<TKey> comparer)
		: this(comparer)
	{
		if (collection == null)
		{
			throw new ArgumentNullException("collection");
		}
		InitializeFromCollection(collection);
	}

	[__DynamicallyInvokable]
	public ConcurrentDictionary(int concurrencyLevel, IEnumerable<KeyValuePair<TKey, TValue>> collection, IEqualityComparer<TKey> comparer)
		: this(concurrencyLevel, 31, growLockArray: false, comparer)
	{
		if (collection == null)
		{
			throw new ArgumentNullException("collection");
		}
		if (comparer == null)
		{
			throw new ArgumentNullException("comparer");
		}
		InitializeFromCollection(collection);
	}

	private void InitializeFromCollection(IEnumerable<KeyValuePair<TKey, TValue>> collection)
	{
		foreach (KeyValuePair<TKey, TValue> item in collection)
		{
			if (item.Key == null)
			{
				throw new ArgumentNullException("key");
			}
			if (!TryAddInternal(item.Key, item.Value, updateIfExists: false, acquireLock: false, out var _))
			{
				throw new ArgumentException(GetResource("ConcurrentDictionary_SourceContainsDuplicateKeys"));
			}
		}
		if (m_budget == 0)
		{
			m_budget = m_tables.m_buckets.Length / m_tables.m_locks.Length;
		}
	}

	[__DynamicallyInvokable]
	public ConcurrentDictionary(int concurrencyLevel, int capacity, IEqualityComparer<TKey> comparer)
		: this(concurrencyLevel, capacity, growLockArray: false, comparer)
	{
	}

	internal ConcurrentDictionary(int concurrencyLevel, int capacity, bool growLockArray, IEqualityComparer<TKey> comparer)
	{
		if (concurrencyLevel < 1)
		{
			throw new ArgumentOutOfRangeException("concurrencyLevel", GetResource("ConcurrentDictionary_ConcurrencyLevelMustBePositive"));
		}
		if (capacity < 0)
		{
			throw new ArgumentOutOfRangeException("capacity", GetResource("ConcurrentDictionary_CapacityMustNotBeNegative"));
		}
		if (comparer == null)
		{
			throw new ArgumentNullException("comparer");
		}
		if (capacity < concurrencyLevel)
		{
			capacity = concurrencyLevel;
		}
		object[] array = new object[concurrencyLevel];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = new object();
		}
		int[] countPerLock = new int[array.Length];
		Node[] array2 = new Node[capacity];
		m_tables = new Tables(array2, array, countPerLock, comparer);
		m_growLockArray = growLockArray;
		m_budget = array2.Length / array.Length;
	}

	[__DynamicallyInvokable]
	public bool TryAdd(TKey key, TValue value)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		TValue resultingValue;
		return TryAddInternal(key, value, updateIfExists: false, acquireLock: true, out resultingValue);
	}

	[__DynamicallyInvokable]
	public bool ContainsKey(TKey key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		TValue value;
		return TryGetValue(key, out value);
	}

	[__DynamicallyInvokable]
	public bool TryRemove(TKey key, out TValue value)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return TryRemoveInternal(key, out value, matchValue: false, default(TValue));
	}

	private bool TryRemoveInternal(TKey key, out TValue value, bool matchValue, TValue oldValue)
	{
		while (true)
		{
			Tables tables = m_tables;
			IEqualityComparer<TKey> comparer = tables.m_comparer;
			GetBucketAndLockNo(comparer.GetHashCode(key), out var bucketNo, out var lockNo, tables.m_buckets.Length, tables.m_locks.Length);
			lock (tables.m_locks[lockNo])
			{
				if (tables != m_tables)
				{
					continue;
				}
				Node node = null;
				for (Node node2 = tables.m_buckets[bucketNo]; node2 != null; node2 = node2.m_next)
				{
					if (comparer.Equals(node2.m_key, key))
					{
						if (matchValue && !EqualityComparer<TValue>.Default.Equals(oldValue, node2.m_value))
						{
							value = default(TValue);
							return false;
						}
						if (node == null)
						{
							Volatile.Write(ref tables.m_buckets[bucketNo], node2.m_next);
						}
						else
						{
							node.m_next = node2.m_next;
						}
						value = node2.m_value;
						tables.m_countPerLock[lockNo]--;
						return true;
					}
					node = node2;
				}
				break;
			}
		}
		value = default(TValue);
		return false;
	}

	[__DynamicallyInvokable]
	public bool TryGetValue(TKey key, out TValue value)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		Tables tables = m_tables;
		IEqualityComparer<TKey> comparer = tables.m_comparer;
		GetBucketAndLockNo(comparer.GetHashCode(key), out var bucketNo, out var _, tables.m_buckets.Length, tables.m_locks.Length);
		for (Node node = Volatile.Read(ref tables.m_buckets[bucketNo]); node != null; node = node.m_next)
		{
			if (comparer.Equals(node.m_key, key))
			{
				value = node.m_value;
				return true;
			}
		}
		value = default(TValue);
		return false;
	}

	[__DynamicallyInvokable]
	public bool TryUpdate(TKey key, TValue newValue, TValue comparisonValue)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IEqualityComparer<TValue> equalityComparer = EqualityComparer<TValue>.Default;
		while (true)
		{
			Tables tables = m_tables;
			IEqualityComparer<TKey> comparer = tables.m_comparer;
			int hashCode = comparer.GetHashCode(key);
			GetBucketAndLockNo(hashCode, out var bucketNo, out var lockNo, tables.m_buckets.Length, tables.m_locks.Length);
			lock (tables.m_locks[lockNo])
			{
				if (tables != m_tables)
				{
					continue;
				}
				Node node = null;
				for (Node node2 = tables.m_buckets[bucketNo]; node2 != null; node2 = node2.m_next)
				{
					if (comparer.Equals(node2.m_key, key))
					{
						if (equalityComparer.Equals(node2.m_value, comparisonValue))
						{
							if (s_isValueWriteAtomic)
							{
								node2.m_value = newValue;
							}
							else
							{
								Node node3 = new Node(node2.m_key, newValue, hashCode, node2.m_next);
								if (node == null)
								{
									tables.m_buckets[bucketNo] = node3;
								}
								else
								{
									node.m_next = node3;
								}
							}
							return true;
						}
						return false;
					}
					node = node2;
				}
				return false;
			}
		}
	}

	[__DynamicallyInvokable]
	public void Clear()
	{
		int locksAcquired = 0;
		try
		{
			AcquireAllLocks(ref locksAcquired);
			Tables tables = (m_tables = new Tables(new Node[31], m_tables.m_locks, new int[m_tables.m_countPerLock.Length], m_tables.m_comparer));
			m_budget = Math.Max(1, tables.m_buckets.Length / tables.m_locks.Length);
		}
		finally
		{
			ReleaseLocks(0, locksAcquired);
		}
	}

	[__DynamicallyInvokable]
	void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index", GetResource("ConcurrentDictionary_IndexIsNegative"));
		}
		int locksAcquired = 0;
		try
		{
			AcquireAllLocks(ref locksAcquired);
			int num = 0;
			for (int i = 0; i < m_tables.m_locks.Length; i++)
			{
				if (num < 0)
				{
					break;
				}
				num += m_tables.m_countPerLock[i];
			}
			if (array.Length - num < index || num < 0)
			{
				throw new ArgumentException(GetResource("ConcurrentDictionary_ArrayNotLargeEnough"));
			}
			CopyToPairs(array, index);
		}
		finally
		{
			ReleaseLocks(0, locksAcquired);
		}
	}

	[__DynamicallyInvokable]
	public KeyValuePair<TKey, TValue>[] ToArray()
	{
		int locksAcquired = 0;
		checked
		{
			try
			{
				AcquireAllLocks(ref locksAcquired);
				int num = 0;
				for (int i = 0; i < m_tables.m_locks.Length; i++)
				{
					num += m_tables.m_countPerLock[i];
				}
				if (num == 0)
				{
					return Array.Empty<KeyValuePair<TKey, TValue>>();
				}
				KeyValuePair<TKey, TValue>[] array = new KeyValuePair<TKey, TValue>[num];
				CopyToPairs(array, 0);
				return array;
			}
			finally
			{
				ReleaseLocks(0, locksAcquired);
			}
		}
	}

	private void CopyToPairs(KeyValuePair<TKey, TValue>[] array, int index)
	{
		Node[] buckets = m_tables.m_buckets;
		for (int i = 0; i < buckets.Length; i++)
		{
			for (Node node = buckets[i]; node != null; node = node.m_next)
			{
				array[index] = new KeyValuePair<TKey, TValue>(node.m_key, node.m_value);
				index++;
			}
		}
	}

	private void CopyToEntries(DictionaryEntry[] array, int index)
	{
		Node[] buckets = m_tables.m_buckets;
		for (int i = 0; i < buckets.Length; i++)
		{
			for (Node node = buckets[i]; node != null; node = node.m_next)
			{
				array[index] = new DictionaryEntry(node.m_key, node.m_value);
				index++;
			}
		}
	}

	private void CopyToObjects(object[] array, int index)
	{
		Node[] buckets = m_tables.m_buckets;
		for (int i = 0; i < buckets.Length; i++)
		{
			for (Node node = buckets[i]; node != null; node = node.m_next)
			{
				array[index] = new KeyValuePair<TKey, TValue>(node.m_key, node.m_value);
				index++;
			}
		}
	}

	[__DynamicallyInvokable]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		Node[] buckets = m_tables.m_buckets;
		for (int i = 0; i < buckets.Length; i++)
		{
			for (Node current = Volatile.Read(ref buckets[i]); current != null; current = current.m_next)
			{
				yield return new KeyValuePair<TKey, TValue>(current.m_key, current.m_value);
			}
		}
	}

	private bool TryAddInternal(TKey key, TValue value, bool updateIfExists, bool acquireLock, out TValue resultingValue)
	{
		Tables tables;
		IEqualityComparer<TKey> comparer;
		bool flag;
		bool flag2;
		while (true)
		{
			tables = m_tables;
			comparer = tables.m_comparer;
			int hashCode = comparer.GetHashCode(key);
			GetBucketAndLockNo(hashCode, out var bucketNo, out var lockNo, tables.m_buckets.Length, tables.m_locks.Length);
			flag = false;
			bool lockTaken = false;
			flag2 = false;
			try
			{
				if (acquireLock)
				{
					Monitor.Enter(tables.m_locks[lockNo], ref lockTaken);
				}
				if (tables != m_tables)
				{
					continue;
				}
				int num = 0;
				Node node = null;
				for (Node node2 = tables.m_buckets[bucketNo]; node2 != null; node2 = node2.m_next)
				{
					if (comparer.Equals(node2.m_key, key))
					{
						if (updateIfExists)
						{
							if (s_isValueWriteAtomic)
							{
								node2.m_value = value;
							}
							else
							{
								Node node3 = new Node(node2.m_key, value, hashCode, node2.m_next);
								if (node == null)
								{
									tables.m_buckets[bucketNo] = node3;
								}
								else
								{
									node.m_next = node3;
								}
							}
							resultingValue = value;
						}
						else
						{
							resultingValue = node2.m_value;
						}
						return false;
					}
					node = node2;
					num++;
				}
				if (num > 100 && HashHelpers.IsWellKnownEqualityComparer(comparer))
				{
					flag = true;
					flag2 = true;
				}
				Volatile.Write(ref tables.m_buckets[bucketNo], new Node(key, value, hashCode, tables.m_buckets[bucketNo]));
				checked
				{
					tables.m_countPerLock[lockNo]++;
					if (tables.m_countPerLock[lockNo] > m_budget)
					{
						flag = true;
					}
					break;
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(tables.m_locks[lockNo]);
				}
			}
		}
		if (flag)
		{
			if (flag2)
			{
				GrowTable(tables, (IEqualityComparer<TKey>)HashHelpers.GetRandomizedEqualityComparer(comparer), regenerateHashKeys: true, m_keyRehashCount);
			}
			else
			{
				GrowTable(tables, tables.m_comparer, regenerateHashKeys: false, m_keyRehashCount);
			}
		}
		resultingValue = value;
		return true;
	}

	private int GetCountInternal()
	{
		int num = 0;
		for (int i = 0; i < m_tables.m_countPerLock.Length; i++)
		{
			num += m_tables.m_countPerLock[i];
		}
		return num;
	}

	[__DynamicallyInvokable]
	public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (valueFactory == null)
		{
			throw new ArgumentNullException("valueFactory");
		}
		if (TryGetValue(key, out var value))
		{
			return value;
		}
		TryAddInternal(key, valueFactory(key), updateIfExists: false, acquireLock: true, out value);
		return value;
	}

	[__DynamicallyInvokable]
	public TValue GetOrAdd(TKey key, TValue value)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		TryAddInternal(key, value, updateIfExists: false, acquireLock: true, out var resultingValue);
		return resultingValue;
	}

	public TValue GetOrAdd<TArg>(TKey key, Func<TKey, TArg, TValue> valueFactory, TArg factoryArgument)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (valueFactory == null)
		{
			throw new ArgumentNullException("valueFactory");
		}
		if (!TryGetValue(key, out var value))
		{
			TryAddInternal(key, valueFactory(key, factoryArgument), updateIfExists: false, acquireLock: true, out value);
		}
		return value;
	}

	public TValue AddOrUpdate<TArg>(TKey key, Func<TKey, TArg, TValue> addValueFactory, Func<TKey, TValue, TArg, TValue> updateValueFactory, TArg factoryArgument)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (addValueFactory == null)
		{
			throw new ArgumentNullException("addValueFactory");
		}
		if (updateValueFactory == null)
		{
			throw new ArgumentNullException("updateValueFactory");
		}
		TValue resultingValue;
		while (true)
		{
			if (TryGetValue(key, out var value))
			{
				TValue val = updateValueFactory(key, value, factoryArgument);
				if (TryUpdate(key, val, value))
				{
					return val;
				}
			}
			else if (TryAddInternal(key, addValueFactory(key, factoryArgument), updateIfExists: false, acquireLock: true, out resultingValue))
			{
				break;
			}
		}
		return resultingValue;
	}

	[__DynamicallyInvokable]
	public TValue AddOrUpdate(TKey key, Func<TKey, TValue> addValueFactory, Func<TKey, TValue, TValue> updateValueFactory)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (addValueFactory == null)
		{
			throw new ArgumentNullException("addValueFactory");
		}
		if (updateValueFactory == null)
		{
			throw new ArgumentNullException("updateValueFactory");
		}
		TValue resultingValue;
		while (true)
		{
			if (TryGetValue(key, out var value))
			{
				TValue val = updateValueFactory(key, value);
				if (TryUpdate(key, val, value))
				{
					return val;
				}
			}
			else
			{
				TValue val = addValueFactory(key);
				if (TryAddInternal(key, val, updateIfExists: false, acquireLock: true, out resultingValue))
				{
					break;
				}
			}
		}
		return resultingValue;
	}

	[__DynamicallyInvokable]
	public TValue AddOrUpdate(TKey key, TValue addValue, Func<TKey, TValue, TValue> updateValueFactory)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (updateValueFactory == null)
		{
			throw new ArgumentNullException("updateValueFactory");
		}
		TValue resultingValue;
		while (true)
		{
			if (TryGetValue(key, out var value))
			{
				TValue val = updateValueFactory(key, value);
				if (TryUpdate(key, val, value))
				{
					return val;
				}
			}
			else if (TryAddInternal(key, addValue, updateIfExists: false, acquireLock: true, out resultingValue))
			{
				break;
			}
		}
		return resultingValue;
	}

	[__DynamicallyInvokable]
	void IDictionary<TKey, TValue>.Add(TKey key, TValue value)
	{
		if (!TryAdd(key, value))
		{
			throw new ArgumentException(GetResource("ConcurrentDictionary_KeyAlreadyExisted"));
		}
	}

	[__DynamicallyInvokable]
	bool IDictionary<TKey, TValue>.Remove(TKey key)
	{
		TValue value;
		return TryRemove(key, out value);
	}

	[__DynamicallyInvokable]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair)
	{
		((IDictionary<TKey, TValue>)this).Add(keyValuePair.Key, keyValuePair.Value);
	}

	[__DynamicallyInvokable]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair)
	{
		if (!TryGetValue(keyValuePair.Key, out var value))
		{
			return false;
		}
		return EqualityComparer<TValue>.Default.Equals(value, keyValuePair.Value);
	}

	[__DynamicallyInvokable]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair)
	{
		if (keyValuePair.Key == null)
		{
			throw new ArgumentNullException(GetResource("ConcurrentDictionary_ItemKeyIsNull"));
		}
		TValue value;
		return TryRemoveInternal(keyValuePair.Key, out value, matchValue: true, keyValuePair.Value);
	}

	[__DynamicallyInvokable]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	[__DynamicallyInvokable]
	void IDictionary.Add(object key, object value)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!(key is TKey))
		{
			throw new ArgumentException(GetResource("ConcurrentDictionary_TypeOfKeyIncorrect"));
		}
		TValue value2;
		try
		{
			value2 = (TValue)value;
		}
		catch (InvalidCastException)
		{
			throw new ArgumentException(GetResource("ConcurrentDictionary_TypeOfValueIncorrect"));
		}
		((IDictionary<TKey, TValue>)this).Add((TKey)key, value2);
	}

	[__DynamicallyInvokable]
	bool IDictionary.Contains(object key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (key is TKey)
		{
			return ContainsKey((TKey)key);
		}
		return false;
	}

	[__DynamicallyInvokable]
	IDictionaryEnumerator IDictionary.GetEnumerator()
	{
		return new DictionaryEnumerator(this);
	}

	[__DynamicallyInvokable]
	void IDictionary.Remove(object key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (key is TKey)
		{
			TryRemove((TKey)key, out var _);
		}
	}

	[__DynamicallyInvokable]
	void ICollection.CopyTo(Array array, int index)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index", GetResource("ConcurrentDictionary_IndexIsNegative"));
		}
		int locksAcquired = 0;
		try
		{
			AcquireAllLocks(ref locksAcquired);
			Tables tables = m_tables;
			int num = 0;
			for (int i = 0; i < tables.m_locks.Length; i++)
			{
				if (num < 0)
				{
					break;
				}
				num += tables.m_countPerLock[i];
			}
			if (array.Length - num < index || num < 0)
			{
				throw new ArgumentException(GetResource("ConcurrentDictionary_ArrayNotLargeEnough"));
			}
			if (array is KeyValuePair<TKey, TValue>[] array2)
			{
				CopyToPairs(array2, index);
				return;
			}
			if (array is DictionaryEntry[] array3)
			{
				CopyToEntries(array3, index);
				return;
			}
			if (array is object[] array4)
			{
				CopyToObjects(array4, index);
				return;
			}
			throw new ArgumentException(GetResource("ConcurrentDictionary_ArrayIncorrectType"), "array");
		}
		finally
		{
			ReleaseLocks(0, locksAcquired);
		}
	}

	private void GrowTable(Tables tables, IEqualityComparer<TKey> newComparer, bool regenerateHashKeys, int rehashCount)
	{
		int locksAcquired = 0;
		try
		{
			AcquireLocks(0, 1, ref locksAcquired);
			if (regenerateHashKeys && rehashCount == m_keyRehashCount)
			{
				tables = m_tables;
			}
			else
			{
				if (tables != m_tables)
				{
					return;
				}
				long num = 0L;
				for (int i = 0; i < tables.m_countPerLock.Length; i++)
				{
					num += tables.m_countPerLock[i];
				}
				if (num < tables.m_buckets.Length / 4)
				{
					m_budget = 2 * m_budget;
					if (m_budget < 0)
					{
						m_budget = int.MaxValue;
					}
					return;
				}
			}
			int j = 0;
			bool flag = false;
			try
			{
				for (j = checked(tables.m_buckets.Length * 2 + 1); j % 3 == 0 || j % 5 == 0 || j % 7 == 0; j = checked(j + 2))
				{
				}
				if (j > 2146435071)
				{
					flag = true;
				}
			}
			catch (OverflowException)
			{
				flag = true;
			}
			if (flag)
			{
				j = 2146435071;
				m_budget = int.MaxValue;
			}
			AcquireLocks(1, tables.m_locks.Length, ref locksAcquired);
			object[] array = tables.m_locks;
			if (m_growLockArray && tables.m_locks.Length < 1024)
			{
				array = new object[tables.m_locks.Length * 2];
				Array.Copy(tables.m_locks, array, tables.m_locks.Length);
				for (int k = tables.m_locks.Length; k < array.Length; k++)
				{
					array[k] = new object();
				}
			}
			Node[] array2 = new Node[j];
			int[] array3 = new int[array.Length];
			for (int l = 0; l < tables.m_buckets.Length; l++)
			{
				Node node = tables.m_buckets[l];
				checked
				{
					while (node != null)
					{
						Node next = node.m_next;
						int hashcode = node.m_hashcode;
						if (regenerateHashKeys)
						{
							hashcode = newComparer.GetHashCode(node.m_key);
						}
						GetBucketAndLockNo(hashcode, out var bucketNo, out var lockNo, array2.Length, array.Length);
						array2[bucketNo] = new Node(node.m_key, node.m_value, hashcode, array2[bucketNo]);
						array3[lockNo]++;
						node = next;
					}
				}
			}
			if (regenerateHashKeys)
			{
				m_keyRehashCount++;
			}
			m_budget = Math.Max(1, array2.Length / array.Length);
			m_tables = new Tables(array2, array, array3, newComparer);
		}
		finally
		{
			ReleaseLocks(0, locksAcquired);
		}
	}

	private void GetBucketAndLockNo(int hashcode, out int bucketNo, out int lockNo, int bucketCount, int lockCount)
	{
		bucketNo = (hashcode & 0x7FFFFFFF) % bucketCount;
		lockNo = bucketNo % lockCount;
	}

	private void AcquireAllLocks(ref int locksAcquired)
	{
		if (CDSCollectionETWBCLProvider.Log.IsEnabled())
		{
			CDSCollectionETWBCLProvider.Log.ConcurrentDictionary_AcquiringAllLocks(m_tables.m_buckets.Length);
		}
		AcquireLocks(0, 1, ref locksAcquired);
		AcquireLocks(1, m_tables.m_locks.Length, ref locksAcquired);
	}

	private void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired)
	{
		object[] locks = m_tables.m_locks;
		for (int i = fromInclusive; i < toExclusive; i++)
		{
			bool lockTaken = false;
			try
			{
				Monitor.Enter(locks[i], ref lockTaken);
			}
			finally
			{
				if (lockTaken)
				{
					locksAcquired++;
				}
			}
		}
	}

	private void ReleaseLocks(int fromInclusive, int toExclusive)
	{
		for (int i = fromInclusive; i < toExclusive; i++)
		{
			Monitor.Exit(m_tables.m_locks[i]);
		}
	}

	private ReadOnlyCollection<TKey> GetKeys()
	{
		int locksAcquired = 0;
		try
		{
			AcquireAllLocks(ref locksAcquired);
			int countInternal = GetCountInternal();
			if (countInternal < 0)
			{
				throw new OutOfMemoryException();
			}
			List<TKey> list = new List<TKey>(countInternal);
			for (int i = 0; i < m_tables.m_buckets.Length; i++)
			{
				for (Node node = m_tables.m_buckets[i]; node != null; node = node.m_next)
				{
					list.Add(node.m_key);
				}
			}
			return new ReadOnlyCollection<TKey>(list);
		}
		finally
		{
			ReleaseLocks(0, locksAcquired);
		}
	}

	private ReadOnlyCollection<TValue> GetValues()
	{
		int locksAcquired = 0;
		try
		{
			AcquireAllLocks(ref locksAcquired);
			int countInternal = GetCountInternal();
			if (countInternal < 0)
			{
				throw new OutOfMemoryException();
			}
			List<TValue> list = new List<TValue>(countInternal);
			for (int i = 0; i < m_tables.m_buckets.Length; i++)
			{
				for (Node node = m_tables.m_buckets[i]; node != null; node = node.m_next)
				{
					list.Add(node.m_value);
				}
			}
			return new ReadOnlyCollection<TValue>(list);
		}
		finally
		{
			ReleaseLocks(0, locksAcquired);
		}
	}

	[Conditional("DEBUG")]
	private void Assert(bool condition)
	{
	}

	private string GetResource(string key)
	{
		return Environment.GetResourceString(key);
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext context)
	{
		Tables tables = m_tables;
		m_serializationArray = ToArray();
		m_serializationConcurrencyLevel = tables.m_locks.Length;
		m_serializationCapacity = tables.m_buckets.Length;
		m_comparer = (IEqualityComparer<TKey>)HashHelpers.GetEqualityComparerForSerialization(tables.m_comparer);
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext context)
	{
		KeyValuePair<TKey, TValue>[] serializationArray = m_serializationArray;
		Node[] buckets = new Node[m_serializationCapacity];
		int[] countPerLock = new int[m_serializationConcurrencyLevel];
		object[] array = new object[m_serializationConcurrencyLevel];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = new object();
		}
		m_tables = new Tables(buckets, array, countPerLock, m_comparer);
		InitializeFromCollection(serializationArray);
		m_serializationArray = null;
	}
}
