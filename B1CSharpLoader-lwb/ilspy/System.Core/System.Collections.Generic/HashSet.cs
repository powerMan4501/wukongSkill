using System.Diagnostics;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace System.Collections.Generic;

[Serializable]
[DebuggerTypeProxy(typeof(HashSetDebugView<>))]
[DebuggerDisplay("Count = {Count}")]
[global::__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class HashSet<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ISerializable, IDeserializationCallback, ISet<T>, IReadOnlyCollection<T>
{
	internal struct ElementCount
	{
		internal int uniqueCount;

		internal int unfoundCount;
	}

	internal struct Slot
	{
		internal int hashCode;

		internal int next;

		internal T value;
	}

	[Serializable]
	[global::__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private HashSet<T> set;

		private int index;

		private int version;

		private T current;

		[global::__DynamicallyInvokable]
		public T Current
		{
			[global::__DynamicallyInvokable]
			get
			{
				return current;
			}
		}

		[global::__DynamicallyInvokable]
		object IEnumerator.Current
		{
			[global::__DynamicallyInvokable]
			get
			{
				if (index == 0 || index == set.m_lastIndex + 1)
				{
					throw new InvalidOperationException(System.SR.GetString("InvalidOperation_EnumOpCantHappen"));
				}
				return Current;
			}
		}

		internal Enumerator(HashSet<T> set)
		{
			this.set = set;
			index = 0;
			version = set.m_version;
			current = default(T);
		}

		[global::__DynamicallyInvokable]
		public void Dispose()
		{
		}

		[global::__DynamicallyInvokable]
		public bool MoveNext()
		{
			if (version != set.m_version)
			{
				throw new InvalidOperationException(System.SR.GetString("InvalidOperation_EnumFailedVersion"));
			}
			while (index < set.m_lastIndex)
			{
				if (set.m_slots[index].hashCode >= 0)
				{
					current = set.m_slots[index].value;
					index++;
					return true;
				}
				index++;
			}
			index = set.m_lastIndex + 1;
			current = default(T);
			return false;
		}

		[global::__DynamicallyInvokable]
		void IEnumerator.Reset()
		{
			if (version != set.m_version)
			{
				throw new InvalidOperationException(System.SR.GetString("InvalidOperation_EnumFailedVersion"));
			}
			index = 0;
			current = default(T);
		}
	}

	private const int Lower31BitMask = int.MaxValue;

	private const int StackAllocThreshold = 100;

	private const int ShrinkThreshold = 3;

	private const string CapacityName = "Capacity";

	private const string ElementsName = "Elements";

	private const string ComparerName = "Comparer";

	private const string VersionName = "Version";

	private int[] m_buckets;

	private Slot[] m_slots;

	private int m_count;

	private int m_lastIndex;

	private int m_freeList;

	private IEqualityComparer<T> m_comparer;

	private int m_version;

	private SerializationInfo m_siInfo;

	[global::__DynamicallyInvokable]
	public int Count
	{
		[global::__DynamicallyInvokable]
		get
		{
			return m_count;
		}
	}

	[global::__DynamicallyInvokable]
	bool ICollection<T>.IsReadOnly
	{
		[global::__DynamicallyInvokable]
		get
		{
			return false;
		}
	}

	[global::__DynamicallyInvokable]
	public IEqualityComparer<T> Comparer
	{
		[global::__DynamicallyInvokable]
		get
		{
			return m_comparer;
		}
	}

	[global::__DynamicallyInvokable]
	public HashSet()
		: this((IEqualityComparer<T>)EqualityComparer<T>.Default)
	{
	}

	public HashSet(int capacity)
		: this(capacity, (IEqualityComparer<T>)EqualityComparer<T>.Default)
	{
	}

	[global::__DynamicallyInvokable]
	public HashSet(IEqualityComparer<T> comparer)
	{
		if (comparer == null)
		{
			comparer = EqualityComparer<T>.Default;
		}
		m_comparer = comparer;
		m_lastIndex = 0;
		m_count = 0;
		m_freeList = -1;
		m_version = 0;
	}

	[global::__DynamicallyInvokable]
	public HashSet(IEnumerable<T> collection)
		: this(collection, (IEqualityComparer<T>)EqualityComparer<T>.Default)
	{
	}

	[global::__DynamicallyInvokable]
	public HashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer)
		: this(comparer)
	{
		if (collection == null)
		{
			throw new ArgumentNullException("collection");
		}
		if (collection is HashSet<T> hashSet && AreEqualityComparersEqual(this, hashSet))
		{
			CopyFrom(hashSet);
			return;
		}
		Initialize((collection is ICollection<T> collection2) ? collection2.Count : 0);
		UnionWith(collection);
		if (m_count > 0 && m_slots.Length / m_count > 3)
		{
			TrimExcess();
		}
	}

	private void CopyFrom(HashSet<T> source)
	{
		int count = source.m_count;
		if (count == 0)
		{
			return;
		}
		int num = source.m_buckets.Length;
		int num2 = HashHelpers.ExpandPrime(count + 1);
		if (num2 >= num)
		{
			m_buckets = (int[])source.m_buckets.Clone();
			m_slots = (Slot[])source.m_slots.Clone();
			m_lastIndex = source.m_lastIndex;
			m_freeList = source.m_freeList;
		}
		else
		{
			int lastIndex = source.m_lastIndex;
			Slot[] slots = source.m_slots;
			Initialize(count);
			int num3 = 0;
			for (int i = 0; i < lastIndex; i++)
			{
				int hashCode = slots[i].hashCode;
				if (hashCode >= 0)
				{
					AddValue(num3, hashCode, slots[i].value);
					num3++;
				}
			}
			m_lastIndex = num3;
		}
		m_count = count;
	}

	protected HashSet(SerializationInfo info, StreamingContext context)
	{
		m_siInfo = info;
	}

	public HashSet(int capacity, IEqualityComparer<T> comparer)
		: this(comparer)
	{
		if (capacity < 0)
		{
			throw new ArgumentOutOfRangeException("capacity");
		}
		if (capacity > 0)
		{
			Initialize(capacity);
		}
	}

	[global::__DynamicallyInvokable]
	void ICollection<T>.Add(T item)
	{
		AddIfNotPresent(item);
	}

	[global::__DynamicallyInvokable]
	public void Clear()
	{
		if (m_lastIndex > 0)
		{
			Array.Clear(m_slots, 0, m_lastIndex);
			Array.Clear(m_buckets, 0, m_buckets.Length);
			m_lastIndex = 0;
			m_count = 0;
			m_freeList = -1;
		}
		m_version++;
	}

	[global::__DynamicallyInvokable]
	public bool Contains(T item)
	{
		if (m_buckets != null)
		{
			int num = InternalGetHashCode(item);
			for (int num2 = m_buckets[num % m_buckets.Length] - 1; num2 >= 0; num2 = m_slots[num2].next)
			{
				if (m_slots[num2].hashCode == num && m_comparer.Equals(m_slots[num2].value, item))
				{
					return true;
				}
			}
		}
		return false;
	}

	[global::__DynamicallyInvokable]
	public void CopyTo(T[] array, int arrayIndex)
	{
		CopyTo(array, arrayIndex, m_count);
	}

	[global::__DynamicallyInvokable]
	public bool Remove(T item)
	{
		if (m_buckets != null)
		{
			int num = InternalGetHashCode(item);
			int num2 = num % m_buckets.Length;
			int num3 = -1;
			for (int num4 = m_buckets[num2] - 1; num4 >= 0; num4 = m_slots[num4].next)
			{
				if (m_slots[num4].hashCode == num && m_comparer.Equals(m_slots[num4].value, item))
				{
					if (num3 < 0)
					{
						m_buckets[num2] = m_slots[num4].next + 1;
					}
					else
					{
						m_slots[num3].next = m_slots[num4].next;
					}
					m_slots[num4].hashCode = -1;
					m_slots[num4].value = default(T);
					m_slots[num4].next = m_freeList;
					m_count--;
					m_version++;
					if (m_count == 0)
					{
						m_lastIndex = 0;
						m_freeList = -1;
					}
					else
					{
						m_freeList = num4;
					}
					return true;
				}
				num3 = num4;
			}
		}
		return false;
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

	[SecurityCritical]
	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		info.AddValue("Version", m_version);
		info.AddValue("Comparer", HashHelpers.GetEqualityComparerForSerialization(m_comparer), typeof(IEqualityComparer<T>));
		info.AddValue("Capacity", (m_buckets != null) ? m_buckets.Length : 0);
		if (m_buckets != null)
		{
			T[] array = new T[m_count];
			CopyTo(array);
			info.AddValue("Elements", array, typeof(T[]));
		}
	}

	public virtual void OnDeserialization(object sender)
	{
		if (m_siInfo == null)
		{
			return;
		}
		int @int = m_siInfo.GetInt32("Capacity");
		m_comparer = (IEqualityComparer<T>)m_siInfo.GetValue("Comparer", typeof(IEqualityComparer<T>));
		m_freeList = -1;
		if (@int != 0)
		{
			m_buckets = new int[@int];
			m_slots = new Slot[@int];
			T[] array = (T[])m_siInfo.GetValue("Elements", typeof(T[]));
			if (array == null)
			{
				throw new SerializationException(System.SR.GetString("Serialization_MissingKeys"));
			}
			for (int i = 0; i < array.Length; i++)
			{
				AddIfNotPresent(array[i]);
			}
		}
		else
		{
			m_buckets = null;
		}
		m_version = m_siInfo.GetInt32("Version");
		m_siInfo = null;
	}

	[global::__DynamicallyInvokable]
	public bool Add(T item)
	{
		return AddIfNotPresent(item);
	}

	public bool TryGetValue(T equalValue, out T actualValue)
	{
		if (m_buckets != null)
		{
			int num = InternalIndexOf(equalValue);
			if (num >= 0)
			{
				actualValue = m_slots[num].value;
				return true;
			}
		}
		actualValue = default(T);
		return false;
	}

	[global::__DynamicallyInvokable]
	public void UnionWith(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		foreach (T item in other)
		{
			AddIfNotPresent(item);
		}
	}

	[global::__DynamicallyInvokable]
	public void IntersectWith(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (m_count == 0)
		{
			return;
		}
		if (other is ICollection<T> collection)
		{
			if (collection.Count == 0)
			{
				Clear();
				return;
			}
			if (other is HashSet<T> hashSet && AreEqualityComparersEqual(this, hashSet))
			{
				IntersectWithHashSetWithSameEC(hashSet);
				return;
			}
		}
		IntersectWithEnumerable(other);
	}

	[global::__DynamicallyInvokable]
	public void ExceptWith(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (m_count == 0)
		{
			return;
		}
		if (other == this)
		{
			Clear();
			return;
		}
		foreach (T item in other)
		{
			Remove(item);
		}
	}

	[global::__DynamicallyInvokable]
	public void SymmetricExceptWith(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (m_count == 0)
		{
			UnionWith(other);
		}
		else if (other == this)
		{
			Clear();
		}
		else if (other is HashSet<T> hashSet && AreEqualityComparersEqual(this, hashSet))
		{
			SymmetricExceptWithUniqueHashSet(hashSet);
		}
		else
		{
			SymmetricExceptWithEnumerable(other);
		}
	}

	[global::__DynamicallyInvokable]
	public bool IsSubsetOf(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (m_count == 0)
		{
			return true;
		}
		if (other is HashSet<T> hashSet && AreEqualityComparersEqual(this, hashSet))
		{
			if (m_count > hashSet.Count)
			{
				return false;
			}
			return IsSubsetOfHashSetWithSameEC(hashSet);
		}
		ElementCount elementCount = CheckUniqueAndUnfoundElements(other, returnIfUnfound: false);
		if (elementCount.uniqueCount == m_count)
		{
			return elementCount.unfoundCount >= 0;
		}
		return false;
	}

	[global::__DynamicallyInvokable]
	public bool IsProperSubsetOf(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (other is ICollection<T> collection)
		{
			if (m_count == 0)
			{
				return collection.Count > 0;
			}
			if (other is HashSet<T> hashSet && AreEqualityComparersEqual(this, hashSet))
			{
				if (m_count >= hashSet.Count)
				{
					return false;
				}
				return IsSubsetOfHashSetWithSameEC(hashSet);
			}
		}
		ElementCount elementCount = CheckUniqueAndUnfoundElements(other, returnIfUnfound: false);
		if (elementCount.uniqueCount == m_count)
		{
			return elementCount.unfoundCount > 0;
		}
		return false;
	}

	[global::__DynamicallyInvokable]
	public bool IsSupersetOf(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (other is ICollection<T> collection)
		{
			if (collection.Count == 0)
			{
				return true;
			}
			if (other is HashSet<T> hashSet && AreEqualityComparersEqual(this, hashSet) && hashSet.Count > m_count)
			{
				return false;
			}
		}
		return ContainsAllElements(other);
	}

	[global::__DynamicallyInvokable]
	public bool IsProperSupersetOf(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (m_count == 0)
		{
			return false;
		}
		if (other is ICollection<T> collection)
		{
			if (collection.Count == 0)
			{
				return true;
			}
			if (other is HashSet<T> hashSet && AreEqualityComparersEqual(this, hashSet))
			{
				if (hashSet.Count >= m_count)
				{
					return false;
				}
				return ContainsAllElements(hashSet);
			}
		}
		ElementCount elementCount = CheckUniqueAndUnfoundElements(other, returnIfUnfound: true);
		if (elementCount.uniqueCount < m_count)
		{
			return elementCount.unfoundCount == 0;
		}
		return false;
	}

	[global::__DynamicallyInvokable]
	public bool Overlaps(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (m_count == 0)
		{
			return false;
		}
		foreach (T item in other)
		{
			if (Contains(item))
			{
				return true;
			}
		}
		return false;
	}

	[global::__DynamicallyInvokable]
	public bool SetEquals(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (other is HashSet<T> hashSet && AreEqualityComparersEqual(this, hashSet))
		{
			if (m_count != hashSet.Count)
			{
				return false;
			}
			return ContainsAllElements(hashSet);
		}
		if (other is ICollection<T> collection && m_count == 0 && collection.Count > 0)
		{
			return false;
		}
		ElementCount elementCount = CheckUniqueAndUnfoundElements(other, returnIfUnfound: true);
		if (elementCount.uniqueCount == m_count)
		{
			return elementCount.unfoundCount == 0;
		}
		return false;
	}

	[global::__DynamicallyInvokable]
	public void CopyTo(T[] array)
	{
		CopyTo(array, 0, m_count);
	}

	[global::__DynamicallyInvokable]
	public void CopyTo(T[] array, int arrayIndex, int count)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (arrayIndex < 0)
		{
			throw new ArgumentOutOfRangeException("arrayIndex", System.SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", System.SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (arrayIndex > array.Length || count > array.Length - arrayIndex)
		{
			throw new ArgumentException(System.SR.GetString("Arg_ArrayPlusOffTooSmall"));
		}
		int num = 0;
		for (int i = 0; i < m_lastIndex; i++)
		{
			if (num >= count)
			{
				break;
			}
			if (m_slots[i].hashCode >= 0)
			{
				array[arrayIndex + num] = m_slots[i].value;
				num++;
			}
		}
	}

	[global::__DynamicallyInvokable]
	public int RemoveWhere(Predicate<T> match)
	{
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		int num = 0;
		for (int i = 0; i < m_lastIndex; i++)
		{
			if (m_slots[i].hashCode >= 0)
			{
				T value = m_slots[i].value;
				if (match(value) && Remove(value))
				{
					num++;
				}
			}
		}
		return num;
	}

	[global::__DynamicallyInvokable]
	public void TrimExcess()
	{
		if (m_count == 0)
		{
			m_buckets = null;
			m_slots = null;
			m_version++;
			return;
		}
		int prime = HashHelpers.GetPrime(m_count);
		Slot[] array = new Slot[prime];
		int[] array2 = new int[prime];
		int num = 0;
		for (int i = 0; i < m_lastIndex; i++)
		{
			if (m_slots[i].hashCode >= 0)
			{
				array[num] = m_slots[i];
				int num2 = array[num].hashCode % prime;
				array[num].next = array2[num2] - 1;
				array2[num2] = num + 1;
				num++;
			}
		}
		m_lastIndex = num;
		m_slots = array;
		m_buckets = array2;
		m_freeList = -1;
	}

	public static IEqualityComparer<HashSet<T>> CreateSetComparer()
	{
		return new HashSetEqualityComparer<T>();
	}

	private void Initialize(int capacity)
	{
		int prime = HashHelpers.GetPrime(capacity);
		m_buckets = new int[prime];
		m_slots = new Slot[prime];
	}

	private void IncreaseCapacity()
	{
		int num = HashHelpers.ExpandPrime(m_count);
		if (num <= m_count)
		{
			throw new ArgumentException(System.SR.GetString("Arg_HSCapacityOverflow"));
		}
		SetCapacity(num, forceNewHashCodes: false);
	}

	private void SetCapacity(int newSize, bool forceNewHashCodes)
	{
		Slot[] array = new Slot[newSize];
		if (m_slots != null)
		{
			Array.Copy(m_slots, 0, array, 0, m_lastIndex);
		}
		if (forceNewHashCodes)
		{
			for (int i = 0; i < m_lastIndex; i++)
			{
				if (array[i].hashCode != -1)
				{
					array[i].hashCode = InternalGetHashCode(array[i].value);
				}
			}
		}
		int[] array2 = new int[newSize];
		for (int j = 0; j < m_lastIndex; j++)
		{
			int num = array[j].hashCode % newSize;
			array[j].next = array2[num] - 1;
			array2[num] = j + 1;
		}
		m_slots = array;
		m_buckets = array2;
	}

	private bool AddIfNotPresent(T value)
	{
		if (m_buckets == null)
		{
			Initialize(0);
		}
		int num = InternalGetHashCode(value);
		int num2 = num % m_buckets.Length;
		int num3 = 0;
		for (int num4 = m_buckets[num % m_buckets.Length] - 1; num4 >= 0; num4 = m_slots[num4].next)
		{
			if (m_slots[num4].hashCode == num && m_comparer.Equals(m_slots[num4].value, value))
			{
				return false;
			}
			num3++;
		}
		int num5;
		if (m_freeList >= 0)
		{
			num5 = m_freeList;
			m_freeList = m_slots[num5].next;
		}
		else
		{
			if (m_lastIndex == m_slots.Length)
			{
				IncreaseCapacity();
				num2 = num % m_buckets.Length;
			}
			num5 = m_lastIndex;
			m_lastIndex++;
		}
		m_slots[num5].hashCode = num;
		m_slots[num5].value = value;
		m_slots[num5].next = m_buckets[num2] - 1;
		m_buckets[num2] = num5 + 1;
		m_count++;
		m_version++;
		if (num3 > 100 && HashHelpers.IsWellKnownEqualityComparer(m_comparer))
		{
			m_comparer = (IEqualityComparer<T>)HashHelpers.GetRandomizedEqualityComparer(m_comparer);
			SetCapacity(m_buckets.Length, forceNewHashCodes: true);
		}
		return true;
	}

	private void AddValue(int index, int hashCode, T value)
	{
		int num = hashCode % m_buckets.Length;
		m_slots[index].hashCode = hashCode;
		m_slots[index].value = value;
		m_slots[index].next = m_buckets[num] - 1;
		m_buckets[num] = index + 1;
	}

	private bool ContainsAllElements(IEnumerable<T> other)
	{
		foreach (T item in other)
		{
			if (!Contains(item))
			{
				return false;
			}
		}
		return true;
	}

	private bool IsSubsetOfHashSetWithSameEC(HashSet<T> other)
	{
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				T current = enumerator.Current;
				if (!other.Contains(current))
				{
					return false;
				}
			}
		}
		return true;
	}

	private void IntersectWithHashSetWithSameEC(HashSet<T> other)
	{
		for (int i = 0; i < m_lastIndex; i++)
		{
			if (m_slots[i].hashCode >= 0)
			{
				T value = m_slots[i].value;
				if (!other.Contains(value))
				{
					Remove(value);
				}
			}
		}
	}

	[SecuritySafeCritical]
	private unsafe void IntersectWithEnumerable(IEnumerable<T> other)
	{
		int lastIndex = m_lastIndex;
		int num = System.Collections.Generic.BitHelper.ToIntArrayLength(lastIndex);
		System.Collections.Generic.BitHelper bitHelper;
		if (num <= 100)
		{
			int* bitArrayPtr = stackalloc int[num];
			bitHelper = new System.Collections.Generic.BitHelper(bitArrayPtr, num);
		}
		else
		{
			int[] bitArray = new int[num];
			bitHelper = new System.Collections.Generic.BitHelper(bitArray, num);
		}
		foreach (T item in other)
		{
			int num2 = InternalIndexOf(item);
			if (num2 >= 0)
			{
				bitHelper.MarkBit(num2);
			}
		}
		for (int i = 0; i < lastIndex; i++)
		{
			if (m_slots[i].hashCode >= 0 && !bitHelper.IsMarked(i))
			{
				Remove(m_slots[i].value);
			}
		}
	}

	private int InternalIndexOf(T item)
	{
		int num = InternalGetHashCode(item);
		for (int num2 = m_buckets[num % m_buckets.Length] - 1; num2 >= 0; num2 = m_slots[num2].next)
		{
			if (m_slots[num2].hashCode == num && m_comparer.Equals(m_slots[num2].value, item))
			{
				return num2;
			}
		}
		return -1;
	}

	private void SymmetricExceptWithUniqueHashSet(HashSet<T> other)
	{
		foreach (T item in other)
		{
			if (!Remove(item))
			{
				AddIfNotPresent(item);
			}
		}
	}

	[SecuritySafeCritical]
	private unsafe void SymmetricExceptWithEnumerable(IEnumerable<T> other)
	{
		int lastIndex = m_lastIndex;
		int num = System.Collections.Generic.BitHelper.ToIntArrayLength(lastIndex);
		System.Collections.Generic.BitHelper bitHelper;
		System.Collections.Generic.BitHelper bitHelper2;
		if (num <= 50)
		{
			int* bitArrayPtr = stackalloc int[num];
			bitHelper = new System.Collections.Generic.BitHelper(bitArrayPtr, num);
			int* bitArrayPtr2 = stackalloc int[num];
			bitHelper2 = new System.Collections.Generic.BitHelper(bitArrayPtr2, num);
		}
		else
		{
			int[] bitArray = new int[num];
			bitHelper = new System.Collections.Generic.BitHelper(bitArray, num);
			int[] bitArray2 = new int[num];
			bitHelper2 = new System.Collections.Generic.BitHelper(bitArray2, num);
		}
		foreach (T item in other)
		{
			int location = 0;
			if (AddOrGetLocation(item, out location))
			{
				bitHelper2.MarkBit(location);
			}
			else if (location < lastIndex && !bitHelper2.IsMarked(location))
			{
				bitHelper.MarkBit(location);
			}
		}
		for (int i = 0; i < lastIndex; i++)
		{
			if (bitHelper.IsMarked(i))
			{
				Remove(m_slots[i].value);
			}
		}
	}

	private bool AddOrGetLocation(T value, out int location)
	{
		int num = InternalGetHashCode(value);
		int num2 = num % m_buckets.Length;
		for (int num3 = m_buckets[num % m_buckets.Length] - 1; num3 >= 0; num3 = m_slots[num3].next)
		{
			if (m_slots[num3].hashCode == num && m_comparer.Equals(m_slots[num3].value, value))
			{
				location = num3;
				return false;
			}
		}
		int num4;
		if (m_freeList >= 0)
		{
			num4 = m_freeList;
			m_freeList = m_slots[num4].next;
		}
		else
		{
			if (m_lastIndex == m_slots.Length)
			{
				IncreaseCapacity();
				num2 = num % m_buckets.Length;
			}
			num4 = m_lastIndex;
			m_lastIndex++;
		}
		m_slots[num4].hashCode = num;
		m_slots[num4].value = value;
		m_slots[num4].next = m_buckets[num2] - 1;
		m_buckets[num2] = num4 + 1;
		m_count++;
		m_version++;
		location = num4;
		return true;
	}

	[SecuritySafeCritical]
	private unsafe ElementCount CheckUniqueAndUnfoundElements(IEnumerable<T> other, bool returnIfUnfound)
	{
		ElementCount result = default(ElementCount);
		if (m_count == 0)
		{
			int num = 0;
			using (IEnumerator<T> enumerator = other.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					T current = enumerator.Current;
					num++;
				}
			}
			result.uniqueCount = 0;
			result.unfoundCount = num;
			return result;
		}
		int lastIndex = m_lastIndex;
		int num2 = System.Collections.Generic.BitHelper.ToIntArrayLength(lastIndex);
		System.Collections.Generic.BitHelper bitHelper;
		if (num2 <= 100)
		{
			int* bitArrayPtr = stackalloc int[num2];
			bitHelper = new System.Collections.Generic.BitHelper(bitArrayPtr, num2);
		}
		else
		{
			int[] bitArray = new int[num2];
			bitHelper = new System.Collections.Generic.BitHelper(bitArray, num2);
		}
		int num3 = 0;
		int num4 = 0;
		foreach (T item in other)
		{
			int num5 = InternalIndexOf(item);
			if (num5 >= 0)
			{
				if (!bitHelper.IsMarked(num5))
				{
					bitHelper.MarkBit(num5);
					num4++;
				}
			}
			else
			{
				num3++;
				if (returnIfUnfound)
				{
					break;
				}
			}
		}
		result.uniqueCount = num4;
		result.unfoundCount = num3;
		return result;
	}

	internal T[] ToArray()
	{
		T[] array = new T[Count];
		CopyTo(array);
		return array;
	}

	internal static bool HashSetEquals(HashSet<T> set1, HashSet<T> set2, IEqualityComparer<T> comparer)
	{
		if (set1 == null)
		{
			return set2 == null;
		}
		if (set2 == null)
		{
			return false;
		}
		if (AreEqualityComparersEqual(set1, set2))
		{
			if (set1.Count != set2.Count)
			{
				return false;
			}
			foreach (T item in set2)
			{
				if (!set1.Contains(item))
				{
					return false;
				}
			}
			return true;
		}
		foreach (T item2 in set2)
		{
			bool flag = false;
			foreach (T item3 in set1)
			{
				if (comparer.Equals(item2, item3))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return false;
			}
		}
		return true;
	}

	private static bool AreEqualityComparersEqual(HashSet<T> set1, HashSet<T> set2)
	{
		return set1.Comparer.Equals(set2.Comparer);
	}

	private int InternalGetHashCode(T item)
	{
		if (item == null)
		{
			return 0;
		}
		return m_comparer.GetHashCode(item) & 0x7FFFFFFF;
	}
}
