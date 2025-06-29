using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace System.Collections;

[Serializable]
[DebuggerTypeProxy(typeof(HashtableDebugView))]
[DebuggerDisplay("Count = {Count}")]
[ComVisible(true)]
public class Hashtable : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, ICloneable
{
	private struct bucket
	{
		public object key;

		public object val;

		public int hash_coll;
	}

	[Serializable]
	private class KeyCollection : ICollection, IEnumerable
	{
		private Hashtable _hashtable;

		public virtual bool IsSynchronized => _hashtable.IsSynchronized;

		public virtual object SyncRoot => _hashtable.SyncRoot;

		public virtual int Count => _hashtable.count;

		internal KeyCollection(Hashtable hashtable)
		{
			_hashtable = hashtable;
		}

		public virtual void CopyTo(Array array, int arrayIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (array.Rank != 1)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_RankMultiDimNotSupported"));
			}
			if (arrayIndex < 0)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
			}
			if (array.Length - arrayIndex < _hashtable.count)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_ArrayPlusOffTooSmall"));
			}
			_hashtable.CopyKeys(array, arrayIndex);
		}

		public virtual IEnumerator GetEnumerator()
		{
			return new HashtableEnumerator(_hashtable, 1);
		}
	}

	[Serializable]
	private class ValueCollection : ICollection, IEnumerable
	{
		private Hashtable _hashtable;

		public virtual bool IsSynchronized => _hashtable.IsSynchronized;

		public virtual object SyncRoot => _hashtable.SyncRoot;

		public virtual int Count => _hashtable.count;

		internal ValueCollection(Hashtable hashtable)
		{
			_hashtable = hashtable;
		}

		public virtual void CopyTo(Array array, int arrayIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (array.Rank != 1)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_RankMultiDimNotSupported"));
			}
			if (arrayIndex < 0)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
			}
			if (array.Length - arrayIndex < _hashtable.count)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_ArrayPlusOffTooSmall"));
			}
			_hashtable.CopyValues(array, arrayIndex);
		}

		public virtual IEnumerator GetEnumerator()
		{
			return new HashtableEnumerator(_hashtable, 2);
		}
	}

	[Serializable]
	private class SyncHashtable : Hashtable, IEnumerable
	{
		protected Hashtable _table;

		public override int Count => _table.Count;

		public override bool IsReadOnly => _table.IsReadOnly;

		public override bool IsFixedSize => _table.IsFixedSize;

		public override bool IsSynchronized => true;

		public override object this[object key]
		{
			get
			{
				return _table[key];
			}
			set
			{
				lock (_table.SyncRoot)
				{
					_table[key] = value;
				}
			}
		}

		public override object SyncRoot => _table.SyncRoot;

		public override ICollection Keys
		{
			get
			{
				lock (_table.SyncRoot)
				{
					return _table.Keys;
				}
			}
		}

		public override ICollection Values
		{
			get
			{
				lock (_table.SyncRoot)
				{
					return _table.Values;
				}
			}
		}

		internal SyncHashtable(Hashtable table)
			: base(trash: false)
		{
			_table = table;
		}

		internal SyncHashtable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			_table = (Hashtable)info.GetValue("ParentTable", typeof(Hashtable));
			if (_table == null)
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_InsufficientState"));
			}
		}

		[SecurityCritical]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			lock (_table.SyncRoot)
			{
				info.AddValue("ParentTable", _table, typeof(Hashtable));
			}
		}

		public override void Add(object key, object value)
		{
			lock (_table.SyncRoot)
			{
				_table.Add(key, value);
			}
		}

		public override void Clear()
		{
			lock (_table.SyncRoot)
			{
				_table.Clear();
			}
		}

		public override bool Contains(object key)
		{
			return _table.Contains(key);
		}

		public override bool ContainsKey(object key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key", Environment.GetResourceString("ArgumentNull_Key"));
			}
			return _table.ContainsKey(key);
		}

		public override bool ContainsValue(object key)
		{
			lock (_table.SyncRoot)
			{
				return _table.ContainsValue(key);
			}
		}

		public override void CopyTo(Array array, int arrayIndex)
		{
			lock (_table.SyncRoot)
			{
				_table.CopyTo(array, arrayIndex);
			}
		}

		public override object Clone()
		{
			lock (_table.SyncRoot)
			{
				return Synchronized((Hashtable)_table.Clone());
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return _table.GetEnumerator();
		}

		public override IDictionaryEnumerator GetEnumerator()
		{
			return _table.GetEnumerator();
		}

		public override void Remove(object key)
		{
			lock (_table.SyncRoot)
			{
				_table.Remove(key);
			}
		}

		public override void OnDeserialization(object sender)
		{
		}

		internal override KeyValuePairs[] ToKeyValuePairsArray()
		{
			return _table.ToKeyValuePairsArray();
		}
	}

	[Serializable]
	private class HashtableEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable
	{
		private Hashtable hashtable;

		private int bucket;

		private int version;

		private bool current;

		private int getObjectRetType;

		private object currentKey;

		private object currentValue;

		internal const int Keys = 1;

		internal const int Values = 2;

		internal const int DictEntry = 3;

		public virtual object Key
		{
			get
			{
				if (!current)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumNotStarted"));
				}
				return currentKey;
			}
		}

		public virtual DictionaryEntry Entry
		{
			get
			{
				if (!current)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumOpCantHappen"));
				}
				return new DictionaryEntry(currentKey, currentValue);
			}
		}

		public virtual object Current
		{
			get
			{
				if (!current)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumOpCantHappen"));
				}
				if (getObjectRetType == 1)
				{
					return currentKey;
				}
				if (getObjectRetType == 2)
				{
					return currentValue;
				}
				return new DictionaryEntry(currentKey, currentValue);
			}
		}

		public virtual object Value
		{
			get
			{
				if (!current)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumOpCantHappen"));
				}
				return currentValue;
			}
		}

		internal HashtableEnumerator(Hashtable hashtable, int getObjRetType)
		{
			this.hashtable = hashtable;
			bucket = hashtable.buckets.Length;
			version = hashtable.version;
			current = false;
			getObjectRetType = getObjRetType;
		}

		public object Clone()
		{
			return MemberwiseClone();
		}

		public virtual bool MoveNext()
		{
			if (version != hashtable.version)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumFailedVersion"));
			}
			while (bucket > 0)
			{
				bucket--;
				object key = hashtable.buckets[bucket].key;
				if (key != null && key != hashtable.buckets)
				{
					currentKey = key;
					currentValue = hashtable.buckets[bucket].val;
					current = true;
					return true;
				}
			}
			current = false;
			return false;
		}

		public virtual void Reset()
		{
			if (version != hashtable.version)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumFailedVersion"));
			}
			current = false;
			bucket = hashtable.buckets.Length;
			currentKey = null;
			currentValue = null;
		}
	}

	internal class HashtableDebugView
	{
		private Hashtable hashtable;

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public KeyValuePairs[] Items => hashtable.ToKeyValuePairsArray();

		public HashtableDebugView(Hashtable hashtable)
		{
			if (hashtable == null)
			{
				throw new ArgumentNullException("hashtable");
			}
			this.hashtable = hashtable;
		}
	}

	internal const int HashPrime = 101;

	private const int InitialSize = 3;

	private const string LoadFactorName = "LoadFactor";

	private const string VersionName = "Version";

	private const string ComparerName = "Comparer";

	private const string HashCodeProviderName = "HashCodeProvider";

	private const string HashSizeName = "HashSize";

	private const string KeysName = "Keys";

	private const string ValuesName = "Values";

	private const string KeyComparerName = "KeyComparer";

	private bucket[] buckets;

	private int count;

	private int occupancy;

	private int loadsize;

	private float loadFactor;

	private volatile int version;

	private volatile bool isWriterInProgress;

	private ICollection keys;

	private ICollection values;

	private IEqualityComparer _keycomparer;

	private object _syncRoot;

	[Obsolete("Please use EqualityComparer property.")]
	protected IHashCodeProvider hcp
	{
		get
		{
			if (_keycomparer is CompatibleComparer)
			{
				return ((CompatibleComparer)_keycomparer).HashCodeProvider;
			}
			if (_keycomparer == null)
			{
				return null;
			}
			throw new ArgumentException(Environment.GetResourceString("Arg_CannotMixComparisonInfrastructure"));
		}
		set
		{
			if (_keycomparer is CompatibleComparer)
			{
				CompatibleComparer compatibleComparer = (CompatibleComparer)_keycomparer;
				_keycomparer = new CompatibleComparer(compatibleComparer.Comparer, value);
				return;
			}
			if (_keycomparer == null)
			{
				_keycomparer = new CompatibleComparer(null, value);
				return;
			}
			throw new ArgumentException(Environment.GetResourceString("Arg_CannotMixComparisonInfrastructure"));
		}
	}

	[Obsolete("Please use KeyComparer properties.")]
	protected IComparer comparer
	{
		get
		{
			if (_keycomparer is CompatibleComparer)
			{
				return ((CompatibleComparer)_keycomparer).Comparer;
			}
			if (_keycomparer == null)
			{
				return null;
			}
			throw new ArgumentException(Environment.GetResourceString("Arg_CannotMixComparisonInfrastructure"));
		}
		set
		{
			if (_keycomparer is CompatibleComparer)
			{
				CompatibleComparer compatibleComparer = (CompatibleComparer)_keycomparer;
				_keycomparer = new CompatibleComparer(value, compatibleComparer.HashCodeProvider);
				return;
			}
			if (_keycomparer == null)
			{
				_keycomparer = new CompatibleComparer(value, null);
				return;
			}
			throw new ArgumentException(Environment.GetResourceString("Arg_CannotMixComparisonInfrastructure"));
		}
	}

	protected IEqualityComparer EqualityComparer => _keycomparer;

	public virtual object this[object key]
	{
		get
		{
			if (key == null)
			{
				throw new ArgumentNullException("key", Environment.GetResourceString("ArgumentNull_Key"));
			}
			bucket[] array = buckets;
			uint seed;
			uint incr;
			uint num = InitHash(key, array.Length, out seed, out incr);
			int num2 = 0;
			int num3 = (int)(seed % (uint)array.Length);
			bucket bucket;
			do
			{
				int num4 = 0;
				int num5;
				do
				{
					num5 = version;
					bucket = array[num3];
					if (++num4 % 8 == 0)
					{
						Thread.Sleep(1);
					}
				}
				while (isWriterInProgress || num5 != version);
				if (bucket.key == null)
				{
					return null;
				}
				if ((bucket.hash_coll & 0x7FFFFFFF) == num && KeyEquals(bucket.key, key))
				{
					return bucket.val;
				}
				num3 = (int)((num3 + incr) % (uint)array.Length);
			}
			while (bucket.hash_coll < 0 && ++num2 < array.Length);
			return null;
		}
		set
		{
			Insert(key, value, add: false);
		}
	}

	public virtual bool IsReadOnly => false;

	public virtual bool IsFixedSize => false;

	public virtual bool IsSynchronized => false;

	public virtual ICollection Keys
	{
		get
		{
			if (keys == null)
			{
				keys = new KeyCollection(this);
			}
			return keys;
		}
	}

	public virtual ICollection Values
	{
		get
		{
			if (values == null)
			{
				values = new ValueCollection(this);
			}
			return values;
		}
	}

	public virtual object SyncRoot
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

	public virtual int Count => count;

	internal Hashtable(bool trash)
	{
	}

	public Hashtable()
		: this(0, 1f)
	{
	}

	public Hashtable(int capacity)
		: this(capacity, 1f)
	{
	}

	public Hashtable(int capacity, float loadFactor)
	{
		if (capacity < 0)
		{
			throw new ArgumentOutOfRangeException("capacity", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (!(loadFactor >= 0.1f) || !(loadFactor <= 1f))
		{
			throw new ArgumentOutOfRangeException("loadFactor", Environment.GetResourceString("ArgumentOutOfRange_HashtableLoadFactor", 0.1, 1.0));
		}
		this.loadFactor = 0.72f * loadFactor;
		double num = (float)capacity / this.loadFactor;
		if (num > 2147483647.0)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_HTCapacityOverflow"));
		}
		int num2 = ((num > 3.0) ? HashHelpers.GetPrime((int)num) : 3);
		buckets = new bucket[num2];
		loadsize = (int)(this.loadFactor * (float)num2);
		isWriterInProgress = false;
	}

	[Obsolete("Please use Hashtable(int, float, IEqualityComparer) instead.")]
	public Hashtable(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer)
		: this(capacity, loadFactor)
	{
		if (hcp == null && comparer == null)
		{
			_keycomparer = null;
		}
		else
		{
			_keycomparer = new CompatibleComparer(comparer, hcp);
		}
	}

	public Hashtable(int capacity, float loadFactor, IEqualityComparer equalityComparer)
		: this(capacity, loadFactor)
	{
		_keycomparer = equalityComparer;
	}

	[Obsolete("Please use Hashtable(IEqualityComparer) instead.")]
	public Hashtable(IHashCodeProvider hcp, IComparer comparer)
		: this(0, 1f, hcp, comparer)
	{
	}

	public Hashtable(IEqualityComparer equalityComparer)
		: this(0, 1f, equalityComparer)
	{
	}

	[Obsolete("Please use Hashtable(int, IEqualityComparer) instead.")]
	public Hashtable(int capacity, IHashCodeProvider hcp, IComparer comparer)
		: this(capacity, 1f, hcp, comparer)
	{
	}

	public Hashtable(int capacity, IEqualityComparer equalityComparer)
		: this(capacity, 1f, equalityComparer)
	{
	}

	public Hashtable(IDictionary d)
		: this(d, 1f)
	{
	}

	public Hashtable(IDictionary d, float loadFactor)
		: this(d, loadFactor, null)
	{
	}

	[Obsolete("Please use Hashtable(IDictionary, IEqualityComparer) instead.")]
	public Hashtable(IDictionary d, IHashCodeProvider hcp, IComparer comparer)
		: this(d, 1f, hcp, comparer)
	{
	}

	public Hashtable(IDictionary d, IEqualityComparer equalityComparer)
		: this(d, 1f, equalityComparer)
	{
	}

	[Obsolete("Please use Hashtable(IDictionary, float, IEqualityComparer) instead.")]
	public Hashtable(IDictionary d, float loadFactor, IHashCodeProvider hcp, IComparer comparer)
		: this(d?.Count ?? 0, loadFactor, hcp, comparer)
	{
		if (d == null)
		{
			throw new ArgumentNullException("d", Environment.GetResourceString("ArgumentNull_Dictionary"));
		}
		IDictionaryEnumerator enumerator = d.GetEnumerator();
		while (enumerator.MoveNext())
		{
			Add(enumerator.Key, enumerator.Value);
		}
	}

	public Hashtable(IDictionary d, float loadFactor, IEqualityComparer equalityComparer)
		: this(d?.Count ?? 0, loadFactor, equalityComparer)
	{
		if (d == null)
		{
			throw new ArgumentNullException("d", Environment.GetResourceString("ArgumentNull_Dictionary"));
		}
		IDictionaryEnumerator enumerator = d.GetEnumerator();
		while (enumerator.MoveNext())
		{
			Add(enumerator.Key, enumerator.Value);
		}
	}

	protected Hashtable(SerializationInfo info, StreamingContext context)
	{
		HashHelpers.SerializationInfoTable.Add(this, info);
	}

	private uint InitHash(object key, int hashsize, out uint seed, out uint incr)
	{
		uint result = (seed = (uint)(GetHash(key) & 0x7FFFFFFF));
		incr = 1 + seed * 101 % (uint)(hashsize - 1);
		return result;
	}

	public virtual void Add(object key, object value)
	{
		Insert(key, value, add: true);
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public virtual void Clear()
	{
		if (count != 0 || occupancy != 0)
		{
			Thread.BeginCriticalRegion();
			isWriterInProgress = true;
			for (int i = 0; i < buckets.Length; i++)
			{
				buckets[i].hash_coll = 0;
				buckets[i].key = null;
				buckets[i].val = null;
			}
			count = 0;
			occupancy = 0;
			UpdateVersion();
			isWriterInProgress = false;
			Thread.EndCriticalRegion();
		}
	}

	public virtual object Clone()
	{
		bucket[] array = buckets;
		Hashtable hashtable = new Hashtable(count, _keycomparer);
		hashtable.version = version;
		hashtable.loadFactor = loadFactor;
		hashtable.count = 0;
		int num = array.Length;
		while (num > 0)
		{
			num--;
			object key = array[num].key;
			if (key != null && key != array)
			{
				hashtable[key] = array[num].val;
			}
		}
		return hashtable;
	}

	public virtual bool Contains(object key)
	{
		return ContainsKey(key);
	}

	public virtual bool ContainsKey(object key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key", Environment.GetResourceString("ArgumentNull_Key"));
		}
		bucket[] array = buckets;
		uint seed;
		uint incr;
		uint num = InitHash(key, array.Length, out seed, out incr);
		int num2 = 0;
		int num3 = (int)(seed % (uint)array.Length);
		bucket bucket;
		do
		{
			bucket = array[num3];
			if (bucket.key == null)
			{
				return false;
			}
			if ((bucket.hash_coll & 0x7FFFFFFF) == num && KeyEquals(bucket.key, key))
			{
				return true;
			}
			num3 = (int)((num3 + incr) % (uint)array.Length);
		}
		while (bucket.hash_coll < 0 && ++num2 < array.Length);
		return false;
	}

	public virtual bool ContainsValue(object value)
	{
		if (value == null)
		{
			int num = buckets.Length;
			while (--num >= 0)
			{
				if (buckets[num].key != null && buckets[num].key != buckets && buckets[num].val == null)
				{
					return true;
				}
			}
		}
		else
		{
			int num2 = buckets.Length;
			while (--num2 >= 0)
			{
				object val = buckets[num2].val;
				if (val != null && val.Equals(value))
				{
					return true;
				}
			}
		}
		return false;
	}

	private void CopyKeys(Array array, int arrayIndex)
	{
		bucket[] array2 = buckets;
		int num = array2.Length;
		while (--num >= 0)
		{
			object key = array2[num].key;
			if (key != null && key != buckets)
			{
				array.SetValue(key, arrayIndex++);
			}
		}
	}

	private void CopyEntries(Array array, int arrayIndex)
	{
		bucket[] array2 = buckets;
		int num = array2.Length;
		while (--num >= 0)
		{
			object key = array2[num].key;
			if (key != null && key != buckets)
			{
				DictionaryEntry dictionaryEntry = new DictionaryEntry(key, array2[num].val);
				array.SetValue(dictionaryEntry, arrayIndex++);
			}
		}
	}

	public virtual void CopyTo(Array array, int arrayIndex)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array", Environment.GetResourceString("ArgumentNull_Array"));
		}
		if (array.Rank != 1)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_RankMultiDimNotSupported"));
		}
		if (arrayIndex < 0)
		{
			throw new ArgumentOutOfRangeException("arrayIndex", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (array.Length - arrayIndex < Count)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_ArrayPlusOffTooSmall"));
		}
		CopyEntries(array, arrayIndex);
	}

	internal virtual KeyValuePairs[] ToKeyValuePairsArray()
	{
		KeyValuePairs[] array = new KeyValuePairs[count];
		int num = 0;
		bucket[] array2 = buckets;
		int num2 = array2.Length;
		while (--num2 >= 0)
		{
			object key = array2[num2].key;
			if (key != null && key != buckets)
			{
				array[num++] = new KeyValuePairs(key, array2[num2].val);
			}
		}
		return array;
	}

	private void CopyValues(Array array, int arrayIndex)
	{
		bucket[] array2 = buckets;
		int num = array2.Length;
		while (--num >= 0)
		{
			object key = array2[num].key;
			if (key != null && key != buckets)
			{
				array.SetValue(array2[num].val, arrayIndex++);
			}
		}
	}

	private void expand()
	{
		int newsize = HashHelpers.ExpandPrime(buckets.Length);
		rehash(newsize, forceNewHashCode: false);
	}

	private void rehash()
	{
		rehash(buckets.Length, forceNewHashCode: false);
	}

	private void UpdateVersion()
	{
		version++;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	private void rehash(int newsize, bool forceNewHashCode)
	{
		occupancy = 0;
		bucket[] newBuckets = new bucket[newsize];
		for (int i = 0; i < buckets.Length; i++)
		{
			bucket bucket = buckets[i];
			if (bucket.key != null && bucket.key != buckets)
			{
				int hashcode = (forceNewHashCode ? GetHash(bucket.key) : bucket.hash_coll) & 0x7FFFFFFF;
				putEntry(newBuckets, bucket.key, bucket.val, hashcode);
			}
		}
		Thread.BeginCriticalRegion();
		isWriterInProgress = true;
		buckets = newBuckets;
		loadsize = (int)(loadFactor * (float)newsize);
		UpdateVersion();
		isWriterInProgress = false;
		Thread.EndCriticalRegion();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new HashtableEnumerator(this, 3);
	}

	public virtual IDictionaryEnumerator GetEnumerator()
	{
		return new HashtableEnumerator(this, 3);
	}

	protected virtual int GetHash(object key)
	{
		if (_keycomparer != null)
		{
			return _keycomparer.GetHashCode(key);
		}
		return key.GetHashCode();
	}

	protected virtual bool KeyEquals(object item, object key)
	{
		if (buckets == item)
		{
			return false;
		}
		if (item == key)
		{
			return true;
		}
		if (_keycomparer != null)
		{
			return _keycomparer.Equals(item, key);
		}
		return item?.Equals(key) ?? false;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	private void Insert(object key, object nvalue, bool add)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key", Environment.GetResourceString("ArgumentNull_Key"));
		}
		if (count >= loadsize)
		{
			expand();
		}
		else if (occupancy > loadsize && count > 100)
		{
			rehash();
		}
		uint seed;
		uint incr;
		uint num = InitHash(key, buckets.Length, out seed, out incr);
		int num2 = 0;
		int num3 = -1;
		int num4 = (int)(seed % (uint)buckets.Length);
		do
		{
			if (num3 == -1 && buckets[num4].key == buckets && buckets[num4].hash_coll < 0)
			{
				num3 = num4;
			}
			if (buckets[num4].key == null || (buckets[num4].key == buckets && (buckets[num4].hash_coll & 0x80000000u) == 0L))
			{
				if (num3 != -1)
				{
					num4 = num3;
				}
				Thread.BeginCriticalRegion();
				isWriterInProgress = true;
				buckets[num4].val = nvalue;
				buckets[num4].key = key;
				buckets[num4].hash_coll |= (int)num;
				count++;
				UpdateVersion();
				isWriterInProgress = false;
				Thread.EndCriticalRegion();
				if (num2 > 100 && HashHelpers.IsWellKnownEqualityComparer(_keycomparer) && (_keycomparer == null || !(_keycomparer is RandomizedObjectEqualityComparer)))
				{
					_keycomparer = HashHelpers.GetRandomizedEqualityComparer(_keycomparer);
					rehash(buckets.Length, forceNewHashCode: true);
				}
				return;
			}
			if ((buckets[num4].hash_coll & 0x7FFFFFFF) == num && KeyEquals(buckets[num4].key, key))
			{
				if (add)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_AddingDuplicate__", buckets[num4].key, key));
				}
				Thread.BeginCriticalRegion();
				isWriterInProgress = true;
				buckets[num4].val = nvalue;
				UpdateVersion();
				isWriterInProgress = false;
				Thread.EndCriticalRegion();
				if (num2 > 100 && HashHelpers.IsWellKnownEqualityComparer(_keycomparer) && (_keycomparer == null || !(_keycomparer is RandomizedObjectEqualityComparer)))
				{
					_keycomparer = HashHelpers.GetRandomizedEqualityComparer(_keycomparer);
					rehash(buckets.Length, forceNewHashCode: true);
				}
				return;
			}
			if (num3 == -1 && buckets[num4].hash_coll >= 0)
			{
				buckets[num4].hash_coll |= int.MinValue;
				occupancy++;
			}
			num4 = (int)((num4 + incr) % (uint)buckets.Length);
		}
		while (++num2 < buckets.Length);
		if (num3 != -1)
		{
			Thread.BeginCriticalRegion();
			isWriterInProgress = true;
			buckets[num3].val = nvalue;
			buckets[num3].key = key;
			buckets[num3].hash_coll |= (int)num;
			count++;
			UpdateVersion();
			isWriterInProgress = false;
			Thread.EndCriticalRegion();
			if (buckets.Length > 100 && HashHelpers.IsWellKnownEqualityComparer(_keycomparer) && (_keycomparer == null || !(_keycomparer is RandomizedObjectEqualityComparer)))
			{
				_keycomparer = HashHelpers.GetRandomizedEqualityComparer(_keycomparer);
				rehash(buckets.Length, forceNewHashCode: true);
			}
			return;
		}
		throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_HashInsertFailed"));
	}

	private void putEntry(bucket[] newBuckets, object key, object nvalue, int hashcode)
	{
		uint num = 1 + (uint)(hashcode * 101) % (uint)(newBuckets.Length - 1);
		int num2 = (int)((uint)hashcode % (uint)newBuckets.Length);
		while (newBuckets[num2].key != null && newBuckets[num2].key != buckets)
		{
			if (newBuckets[num2].hash_coll >= 0)
			{
				newBuckets[num2].hash_coll |= int.MinValue;
				occupancy++;
			}
			num2 = (int)((num2 + num) % (uint)newBuckets.Length);
		}
		newBuckets[num2].val = nvalue;
		newBuckets[num2].key = key;
		newBuckets[num2].hash_coll |= hashcode;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public virtual void Remove(object key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key", Environment.GetResourceString("ArgumentNull_Key"));
		}
		uint seed;
		uint incr;
		uint num = InitHash(key, buckets.Length, out seed, out incr);
		int num2 = 0;
		int num3 = (int)(seed % (uint)buckets.Length);
		bucket bucket;
		do
		{
			bucket = buckets[num3];
			if ((bucket.hash_coll & 0x7FFFFFFF) == num && KeyEquals(bucket.key, key))
			{
				Thread.BeginCriticalRegion();
				isWriterInProgress = true;
				buckets[num3].hash_coll &= int.MinValue;
				if (buckets[num3].hash_coll != 0)
				{
					buckets[num3].key = buckets;
				}
				else
				{
					buckets[num3].key = null;
				}
				buckets[num3].val = null;
				count--;
				UpdateVersion();
				isWriterInProgress = false;
				Thread.EndCriticalRegion();
				break;
			}
			num3 = (int)((num3 + incr) % (uint)buckets.Length);
		}
		while (bucket.hash_coll < 0 && ++num2 < buckets.Length);
	}

	[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
	public static Hashtable Synchronized(Hashtable table)
	{
		if (table == null)
		{
			throw new ArgumentNullException("table");
		}
		return new SyncHashtable(table);
	}

	[SecurityCritical]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		lock (SyncRoot)
		{
			int num = version;
			info.AddValue("LoadFactor", loadFactor);
			info.AddValue("Version", version);
			IEqualityComparer equalityComparer = (IEqualityComparer)HashHelpers.GetEqualityComparerForSerialization(_keycomparer);
			if (equalityComparer == null)
			{
				info.AddValue("Comparer", null, typeof(IComparer));
				info.AddValue("HashCodeProvider", null, typeof(IHashCodeProvider));
			}
			else if (equalityComparer is CompatibleComparer)
			{
				CompatibleComparer compatibleComparer = equalityComparer as CompatibleComparer;
				info.AddValue("Comparer", compatibleComparer.Comparer, typeof(IComparer));
				info.AddValue("HashCodeProvider", compatibleComparer.HashCodeProvider, typeof(IHashCodeProvider));
			}
			else
			{
				info.AddValue("KeyComparer", equalityComparer, typeof(IEqualityComparer));
			}
			info.AddValue("HashSize", buckets.Length);
			object[] array = new object[count];
			object[] array2 = new object[count];
			CopyKeys(array, 0);
			CopyValues(array2, 0);
			info.AddValue("Keys", array, typeof(object[]));
			info.AddValue("Values", array2, typeof(object[]));
			if (version != num)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumFailedVersion"));
			}
		}
	}

	public virtual void OnDeserialization(object sender)
	{
		if (buckets != null)
		{
			return;
		}
		HashHelpers.SerializationInfoTable.TryGetValue(this, out var value);
		if (value == null)
		{
			throw new SerializationException(Environment.GetResourceString("Serialization_InvalidOnDeser"));
		}
		int num = 0;
		IComparer comparer = null;
		IHashCodeProvider hashCodeProvider = null;
		object[] array = null;
		object[] array2 = null;
		SerializationInfoEnumerator enumerator = value.GetEnumerator();
		while (enumerator.MoveNext())
		{
			switch (enumerator.Name)
			{
			case "LoadFactor":
				loadFactor = value.GetSingle("LoadFactor");
				break;
			case "HashSize":
				num = value.GetInt32("HashSize");
				break;
			case "KeyComparer":
				_keycomparer = (IEqualityComparer)value.GetValue("KeyComparer", typeof(IEqualityComparer));
				break;
			case "Comparer":
				comparer = (IComparer)value.GetValue("Comparer", typeof(IComparer));
				break;
			case "HashCodeProvider":
				hashCodeProvider = (IHashCodeProvider)value.GetValue("HashCodeProvider", typeof(IHashCodeProvider));
				break;
			case "Keys":
				array = (object[])value.GetValue("Keys", typeof(object[]));
				break;
			case "Values":
				array2 = (object[])value.GetValue("Values", typeof(object[]));
				break;
			}
		}
		loadsize = (int)(loadFactor * (float)num);
		if (_keycomparer == null && (comparer != null || hashCodeProvider != null))
		{
			_keycomparer = new CompatibleComparer(comparer, hashCodeProvider);
		}
		buckets = new bucket[num];
		if (array == null)
		{
			throw new SerializationException(Environment.GetResourceString("Serialization_MissingKeys"));
		}
		if (array2 == null)
		{
			throw new SerializationException(Environment.GetResourceString("Serialization_MissingValues"));
		}
		if (array.Length != array2.Length)
		{
			throw new SerializationException(Environment.GetResourceString("Serialization_KeyValueDifferentSizes"));
		}
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == null)
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_NullKey"));
			}
			Insert(array[i], array2[i], add: true);
		}
		version = value.GetInt32("Version");
		HashHelpers.SerializationInfoTable.Remove(this);
	}
}
