using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;

namespace System.Collections.Generic;

[Serializable]
[DebuggerTypeProxy(typeof(Mscorlib_DictionaryDebugView<, >))]
[DebuggerDisplay("Count = {Count}")]
[ComVisible(false)]
[__DynamicallyInvokable]
public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, ISerializable, IDeserializationCallback
{
	private struct Entry
	{
		public int hashCode;

		public int next;

		public TKey key;

		public TValue value;
	}

	[Serializable]
	[__DynamicallyInvokable]
	public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator
	{
		private Dictionary<TKey, TValue> dictionary;

		private int version;

		private int index;

		private KeyValuePair<TKey, TValue> current;

		private int getEnumeratorRetType;

		internal const int DictEntry = 1;

		internal const int KeyValuePair = 2;

		[__DynamicallyInvokable]
		public KeyValuePair<TKey, TValue> Current
		{
			[__DynamicallyInvokable]
			get
			{
				return current;
			}
		}

		[__DynamicallyInvokable]
		object IEnumerator.Current
		{
			[__DynamicallyInvokable]
			get
			{
				if (index == 0 || index == dictionary.count + 1)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumOpCantHappen);
				}
				if (getEnumeratorRetType == 1)
				{
					return new DictionaryEntry(current.Key, current.Value);
				}
				return new KeyValuePair<TKey, TValue>(current.Key, current.Value);
			}
		}

		[__DynamicallyInvokable]
		DictionaryEntry IDictionaryEnumerator.Entry
		{
			[__DynamicallyInvokable]
			get
			{
				if (index == 0 || index == dictionary.count + 1)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumOpCantHappen);
				}
				return new DictionaryEntry(current.Key, current.Value);
			}
		}

		[__DynamicallyInvokable]
		object IDictionaryEnumerator.Key
		{
			[__DynamicallyInvokable]
			get
			{
				if (index == 0 || index == dictionary.count + 1)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumOpCantHappen);
				}
				return current.Key;
			}
		}

		[__DynamicallyInvokable]
		object IDictionaryEnumerator.Value
		{
			[__DynamicallyInvokable]
			get
			{
				if (index == 0 || index == dictionary.count + 1)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumOpCantHappen);
				}
				return current.Value;
			}
		}

		internal Enumerator(Dictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
		{
			this.dictionary = dictionary;
			version = dictionary.version;
			index = 0;
			this.getEnumeratorRetType = getEnumeratorRetType;
			current = default(KeyValuePair<TKey, TValue>);
		}

		[__DynamicallyInvokable]
		public bool MoveNext()
		{
			if (version != dictionary.version)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
			}
			while ((uint)index < (uint)dictionary.count)
			{
				if (dictionary.entries[index].hashCode >= 0)
				{
					current = new KeyValuePair<TKey, TValue>(dictionary.entries[index].key, dictionary.entries[index].value);
					index++;
					return true;
				}
				index++;
			}
			index = dictionary.count + 1;
			current = default(KeyValuePair<TKey, TValue>);
			return false;
		}

		[__DynamicallyInvokable]
		public void Dispose()
		{
		}

		[__DynamicallyInvokable]
		void IEnumerator.Reset()
		{
			if (version != dictionary.version)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
			}
			index = 0;
			current = default(KeyValuePair<TKey, TValue>);
		}
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(Mscorlib_DictionaryKeyCollectionDebugView<, >))]
	[DebuggerDisplay("Count = {Count}")]
	[__DynamicallyInvokable]
	public sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
	{
		[Serializable]
		[__DynamicallyInvokable]
		public struct Enumerator : IEnumerator<TKey>, IDisposable, IEnumerator
		{
			private Dictionary<TKey, TValue> dictionary;

			private int index;

			private int version;

			private TKey currentKey;

			[__DynamicallyInvokable]
			public TKey Current
			{
				[__DynamicallyInvokable]
				get
				{
					return currentKey;
				}
			}

			[__DynamicallyInvokable]
			object IEnumerator.Current
			{
				[__DynamicallyInvokable]
				get
				{
					if (index == 0 || index == dictionary.count + 1)
					{
						ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumOpCantHappen);
					}
					return currentKey;
				}
			}

			internal Enumerator(Dictionary<TKey, TValue> dictionary)
			{
				this.dictionary = dictionary;
				version = dictionary.version;
				index = 0;
				currentKey = default(TKey);
			}

			[__DynamicallyInvokable]
			public void Dispose()
			{
			}

			[__DynamicallyInvokable]
			public bool MoveNext()
			{
				if (version != dictionary.version)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
				}
				while ((uint)index < (uint)dictionary.count)
				{
					if (dictionary.entries[index].hashCode >= 0)
					{
						currentKey = dictionary.entries[index].key;
						index++;
						return true;
					}
					index++;
				}
				index = dictionary.count + 1;
				currentKey = default(TKey);
				return false;
			}

			[__DynamicallyInvokable]
			void IEnumerator.Reset()
			{
				if (version != dictionary.version)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
				}
				index = 0;
				currentKey = default(TKey);
			}
		}

		private Dictionary<TKey, TValue> dictionary;

		[__DynamicallyInvokable]
		public int Count
		{
			[__DynamicallyInvokable]
			get
			{
				return dictionary.Count;
			}
		}

		[__DynamicallyInvokable]
		bool ICollection<TKey>.IsReadOnly
		{
			[__DynamicallyInvokable]
			get
			{
				return true;
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
				return ((ICollection)dictionary).SyncRoot;
			}
		}

		[__DynamicallyInvokable]
		public KeyCollection(Dictionary<TKey, TValue> dictionary)
		{
			if (dictionary == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.dictionary);
			}
			this.dictionary = dictionary;
		}

		[__DynamicallyInvokable]
		public Enumerator GetEnumerator()
		{
			return new Enumerator(dictionary);
		}

		[__DynamicallyInvokable]
		public void CopyTo(TKey[] array, int index)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (index < 0 || index > array.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (array.Length - index < dictionary.Count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
			}
			int count = dictionary.count;
			Entry[] entries = dictionary.entries;
			for (int i = 0; i < count; i++)
			{
				if (entries[i].hashCode >= 0)
				{
					array[index++] = entries[i].key;
				}
			}
		}

		[__DynamicallyInvokable]
		void ICollection<TKey>.Add(TKey item)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_KeyCollectionSet);
		}

		[__DynamicallyInvokable]
		void ICollection<TKey>.Clear()
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_KeyCollectionSet);
		}

		[__DynamicallyInvokable]
		bool ICollection<TKey>.Contains(TKey item)
		{
			return dictionary.ContainsKey(item);
		}

		[__DynamicallyInvokable]
		bool ICollection<TKey>.Remove(TKey item)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_KeyCollectionSet);
			return false;
		}

		[__DynamicallyInvokable]
		IEnumerator<TKey> IEnumerable<TKey>.GetEnumerator()
		{
			return new Enumerator(dictionary);
		}

		[__DynamicallyInvokable]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new Enumerator(dictionary);
		}

		[__DynamicallyInvokable]
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
			if (index < 0 || index > array.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (array.Length - index < dictionary.Count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
			}
			if (array is TKey[] array2)
			{
				CopyTo(array2, index);
				return;
			}
			object[] array3 = array as object[];
			if (array3 == null)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
			}
			int count = dictionary.count;
			Entry[] entries = dictionary.entries;
			try
			{
				for (int i = 0; i < count; i++)
				{
					if (entries[i].hashCode >= 0)
					{
						array3[index++] = entries[i].key;
					}
				}
			}
			catch (ArrayTypeMismatchException)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
			}
		}
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(Mscorlib_DictionaryValueCollectionDebugView<, >))]
	[DebuggerDisplay("Count = {Count}")]
	[__DynamicallyInvokable]
	public sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
	{
		[Serializable]
		[__DynamicallyInvokable]
		public struct Enumerator : IEnumerator<TValue>, IDisposable, IEnumerator
		{
			private Dictionary<TKey, TValue> dictionary;

			private int index;

			private int version;

			private TValue currentValue;

			[__DynamicallyInvokable]
			public TValue Current
			{
				[__DynamicallyInvokable]
				get
				{
					return currentValue;
				}
			}

			[__DynamicallyInvokable]
			object IEnumerator.Current
			{
				[__DynamicallyInvokable]
				get
				{
					if (index == 0 || index == dictionary.count + 1)
					{
						ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumOpCantHappen);
					}
					return currentValue;
				}
			}

			internal Enumerator(Dictionary<TKey, TValue> dictionary)
			{
				this.dictionary = dictionary;
				version = dictionary.version;
				index = 0;
				currentValue = default(TValue);
			}

			[__DynamicallyInvokable]
			public void Dispose()
			{
			}

			[__DynamicallyInvokable]
			public bool MoveNext()
			{
				if (version != dictionary.version)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
				}
				while ((uint)index < (uint)dictionary.count)
				{
					if (dictionary.entries[index].hashCode >= 0)
					{
						currentValue = dictionary.entries[index].value;
						index++;
						return true;
					}
					index++;
				}
				index = dictionary.count + 1;
				currentValue = default(TValue);
				return false;
			}

			[__DynamicallyInvokable]
			void IEnumerator.Reset()
			{
				if (version != dictionary.version)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
				}
				index = 0;
				currentValue = default(TValue);
			}
		}

		private Dictionary<TKey, TValue> dictionary;

		[__DynamicallyInvokable]
		public int Count
		{
			[__DynamicallyInvokable]
			get
			{
				return dictionary.Count;
			}
		}

		[__DynamicallyInvokable]
		bool ICollection<TValue>.IsReadOnly
		{
			[__DynamicallyInvokable]
			get
			{
				return true;
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
				return ((ICollection)dictionary).SyncRoot;
			}
		}

		[__DynamicallyInvokable]
		public ValueCollection(Dictionary<TKey, TValue> dictionary)
		{
			if (dictionary == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.dictionary);
			}
			this.dictionary = dictionary;
		}

		[__DynamicallyInvokable]
		public Enumerator GetEnumerator()
		{
			return new Enumerator(dictionary);
		}

		[__DynamicallyInvokable]
		public void CopyTo(TValue[] array, int index)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (index < 0 || index > array.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (array.Length - index < dictionary.Count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
			}
			int count = dictionary.count;
			Entry[] entries = dictionary.entries;
			for (int i = 0; i < count; i++)
			{
				if (entries[i].hashCode >= 0)
				{
					array[index++] = entries[i].value;
				}
			}
		}

		[__DynamicallyInvokable]
		void ICollection<TValue>.Add(TValue item)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ValueCollectionSet);
		}

		[__DynamicallyInvokable]
		bool ICollection<TValue>.Remove(TValue item)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ValueCollectionSet);
			return false;
		}

		[__DynamicallyInvokable]
		void ICollection<TValue>.Clear()
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ValueCollectionSet);
		}

		[__DynamicallyInvokable]
		bool ICollection<TValue>.Contains(TValue item)
		{
			return dictionary.ContainsValue(item);
		}

		[__DynamicallyInvokable]
		IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator()
		{
			return new Enumerator(dictionary);
		}

		[__DynamicallyInvokable]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new Enumerator(dictionary);
		}

		[__DynamicallyInvokable]
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
			if (index < 0 || index > array.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (array.Length - index < dictionary.Count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
			}
			if (array is TValue[] array2)
			{
				CopyTo(array2, index);
				return;
			}
			object[] array3 = array as object[];
			if (array3 == null)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
			}
			int count = dictionary.count;
			Entry[] entries = dictionary.entries;
			try
			{
				for (int i = 0; i < count; i++)
				{
					if (entries[i].hashCode >= 0)
					{
						array3[index++] = entries[i].value;
					}
				}
			}
			catch (ArrayTypeMismatchException)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
			}
		}
	}

	private int[] buckets;

	private Entry[] entries;

	private int count;

	private int version;

	private int freeList;

	private int freeCount;

	private IEqualityComparer<TKey> comparer;

	private KeyCollection keys;

	private ValueCollection values;

	private object _syncRoot;

	private const string VersionName = "Version";

	private const string HashSizeName = "HashSize";

	private const string KeyValuePairsName = "KeyValuePairs";

	private const string ComparerName = "Comparer";

	[__DynamicallyInvokable]
	public IEqualityComparer<TKey> Comparer
	{
		[__DynamicallyInvokable]
		get
		{
			return comparer;
		}
	}

	[__DynamicallyInvokable]
	public int Count
	{
		[__DynamicallyInvokable]
		get
		{
			return count - freeCount;
		}
	}

	[__DynamicallyInvokable]
	public KeyCollection Keys
	{
		[__DynamicallyInvokable]
		get
		{
			if (keys == null)
			{
				keys = new KeyCollection(this);
			}
			return keys;
		}
	}

	[__DynamicallyInvokable]
	ICollection<TKey> IDictionary<TKey, TValue>.Keys
	{
		[__DynamicallyInvokable]
		get
		{
			if (keys == null)
			{
				keys = new KeyCollection(this);
			}
			return keys;
		}
	}

	[__DynamicallyInvokable]
	IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys
	{
		[__DynamicallyInvokable]
		get
		{
			if (keys == null)
			{
				keys = new KeyCollection(this);
			}
			return keys;
		}
	}

	[__DynamicallyInvokable]
	public ValueCollection Values
	{
		[__DynamicallyInvokable]
		get
		{
			if (values == null)
			{
				values = new ValueCollection(this);
			}
			return values;
		}
	}

	[__DynamicallyInvokable]
	ICollection<TValue> IDictionary<TKey, TValue>.Values
	{
		[__DynamicallyInvokable]
		get
		{
			if (values == null)
			{
				values = new ValueCollection(this);
			}
			return values;
		}
	}

	[__DynamicallyInvokable]
	IEnumerable<TValue> IReadOnlyDictionary<TKey, TValue>.Values
	{
		[__DynamicallyInvokable]
		get
		{
			if (values == null)
			{
				values = new ValueCollection(this);
			}
			return values;
		}
	}

	[__DynamicallyInvokable]
	public TValue this[TKey key]
	{
		[__DynamicallyInvokable]
		get
		{
			int num = FindEntry(key);
			if (num >= 0)
			{
				return entries[num].value;
			}
			ThrowHelper.ThrowKeyNotFoundException();
			return default(TValue);
		}
		[__DynamicallyInvokable]
		set
		{
			Insert(key, value, add: false);
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
			if (_syncRoot == null)
			{
				Interlocked.CompareExchange<object>(ref _syncRoot, new object(), (object)null);
			}
			return _syncRoot;
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
			return Keys;
		}
	}

	[__DynamicallyInvokable]
	ICollection IDictionary.Values
	{
		[__DynamicallyInvokable]
		get
		{
			return Values;
		}
	}

	[__DynamicallyInvokable]
	object IDictionary.this[object key]
	{
		[__DynamicallyInvokable]
		get
		{
			if (IsCompatibleKey(key))
			{
				int num = FindEntry((TKey)key);
				if (num >= 0)
				{
					return entries[num].value;
				}
			}
			return null;
		}
		[__DynamicallyInvokable]
		set
		{
			if (key == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
			}
			ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TValue>(value, ExceptionArgument.value);
			try
			{
				TKey key2 = (TKey)key;
				try
				{
					this[key2] = (TValue)value;
				}
				catch (InvalidCastException)
				{
					ThrowHelper.ThrowWrongValueTypeArgumentException(value, typeof(TValue));
				}
			}
			catch (InvalidCastException)
			{
				ThrowHelper.ThrowWrongKeyTypeArgumentException(key, typeof(TKey));
			}
		}
	}

	[__DynamicallyInvokable]
	public Dictionary()
		: this(0, (IEqualityComparer<TKey>)null)
	{
	}

	[__DynamicallyInvokable]
	public Dictionary(int capacity)
		: this(capacity, (IEqualityComparer<TKey>)null)
	{
	}

	[__DynamicallyInvokable]
	public Dictionary(IEqualityComparer<TKey> comparer)
		: this(0, comparer)
	{
	}

	[__DynamicallyInvokable]
	public Dictionary(int capacity, IEqualityComparer<TKey> comparer)
	{
		if (capacity < 0)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.capacity);
		}
		if (capacity > 0)
		{
			Initialize(capacity);
		}
		this.comparer = comparer ?? EqualityComparer<TKey>.Default;
	}

	[__DynamicallyInvokable]
	public Dictionary(IDictionary<TKey, TValue> dictionary)
		: this(dictionary, (IEqualityComparer<TKey>)null)
	{
	}

	[__DynamicallyInvokable]
	public Dictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
		: this(dictionary?.Count ?? 0, comparer)
	{
		if (dictionary == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.dictionary);
		}
		foreach (KeyValuePair<TKey, TValue> item in dictionary)
		{
			Add(item.Key, item.Value);
		}
	}

	protected Dictionary(SerializationInfo info, StreamingContext context)
	{
		HashHelpers.SerializationInfoTable.Add(this, info);
	}

	[__DynamicallyInvokable]
	public void Add(TKey key, TValue value)
	{
		Insert(key, value, add: true);
	}

	[__DynamicallyInvokable]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair)
	{
		Add(keyValuePair.Key, keyValuePair.Value);
	}

	[__DynamicallyInvokable]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair)
	{
		int num = FindEntry(keyValuePair.Key);
		if (num >= 0 && EqualityComparer<TValue>.Default.Equals(entries[num].value, keyValuePair.Value))
		{
			return true;
		}
		return false;
	}

	[__DynamicallyInvokable]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair)
	{
		int num = FindEntry(keyValuePair.Key);
		if (num >= 0 && EqualityComparer<TValue>.Default.Equals(entries[num].value, keyValuePair.Value))
		{
			Remove(keyValuePair.Key);
			return true;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public void Clear()
	{
		if (count > 0)
		{
			for (int i = 0; i < buckets.Length; i++)
			{
				buckets[i] = -1;
			}
			Array.Clear(entries, 0, count);
			freeList = -1;
			count = 0;
			freeCount = 0;
			version++;
		}
	}

	[__DynamicallyInvokable]
	public bool ContainsKey(TKey key)
	{
		return FindEntry(key) >= 0;
	}

	[__DynamicallyInvokable]
	public bool ContainsValue(TValue value)
	{
		if (value == null)
		{
			for (int i = 0; i < count; i++)
			{
				if (entries[i].hashCode >= 0 && entries[i].value == null)
				{
					return true;
				}
			}
		}
		else
		{
			EqualityComparer<TValue> equalityComparer = EqualityComparer<TValue>.Default;
			for (int j = 0; j < count; j++)
			{
				if (entries[j].hashCode >= 0 && equalityComparer.Equals(entries[j].value, value))
				{
					return true;
				}
			}
		}
		return false;
	}

	private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
	{
		if (array == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
		}
		if (index < 0 || index > array.Length)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
		}
		if (array.Length - index < Count)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
		}
		int num = count;
		Entry[] array2 = entries;
		for (int i = 0; i < num; i++)
		{
			if (array2[i].hashCode >= 0)
			{
				array[index++] = new KeyValuePair<TKey, TValue>(array2[i].key, array2[i].value);
			}
		}
	}

	[__DynamicallyInvokable]
	public Enumerator GetEnumerator()
	{
		return new Enumerator(this, 2);
	}

	[__DynamicallyInvokable]
	IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
	{
		return new Enumerator(this, 2);
	}

	[SecurityCritical]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.info);
		}
		info.AddValue("Version", version);
		info.AddValue("Comparer", HashHelpers.GetEqualityComparerForSerialization(comparer), typeof(IEqualityComparer<TKey>));
		info.AddValue("HashSize", (buckets != null) ? buckets.Length : 0);
		if (buckets != null)
		{
			KeyValuePair<TKey, TValue>[] array = new KeyValuePair<TKey, TValue>[Count];
			CopyTo(array, 0);
			info.AddValue("KeyValuePairs", array, typeof(KeyValuePair<TKey, TValue>[]));
		}
	}

	private int FindEntry(TKey key)
	{
		if (key == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
		}
		if (buckets != null)
		{
			int num = comparer.GetHashCode(key) & 0x7FFFFFFF;
			for (int num2 = buckets[num % buckets.Length]; num2 >= 0; num2 = entries[num2].next)
			{
				if (entries[num2].hashCode == num && comparer.Equals(entries[num2].key, key))
				{
					return num2;
				}
			}
		}
		return -1;
	}

	private void Initialize(int capacity)
	{
		int prime = HashHelpers.GetPrime(capacity);
		buckets = new int[prime];
		for (int i = 0; i < buckets.Length; i++)
		{
			buckets[i] = -1;
		}
		entries = new Entry[prime];
		freeList = -1;
	}

	private void Insert(TKey key, TValue value, bool add)
	{
		if (key == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
		}
		if (buckets == null)
		{
			Initialize(0);
		}
		int num = comparer.GetHashCode(key) & 0x7FFFFFFF;
		int num2 = num % buckets.Length;
		int num3 = 0;
		for (int num4 = buckets[num2]; num4 >= 0; num4 = entries[num4].next)
		{
			if (entries[num4].hashCode == num && comparer.Equals(entries[num4].key, key))
			{
				if (add)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_AddingDuplicate);
				}
				entries[num4].value = value;
				version++;
				return;
			}
			num3++;
		}
		int num5;
		if (freeCount > 0)
		{
			num5 = freeList;
			freeList = entries[num5].next;
			freeCount--;
		}
		else
		{
			if (count == entries.Length)
			{
				Resize();
				num2 = num % buckets.Length;
			}
			num5 = count;
			count++;
		}
		entries[num5].hashCode = num;
		entries[num5].next = buckets[num2];
		entries[num5].key = key;
		entries[num5].value = value;
		buckets[num2] = num5;
		version++;
		if (num3 > 100 && HashHelpers.IsWellKnownEqualityComparer(comparer))
		{
			comparer = (IEqualityComparer<TKey>)HashHelpers.GetRandomizedEqualityComparer(comparer);
			Resize(entries.Length, forceNewHashCodes: true);
		}
	}

	public virtual void OnDeserialization(object sender)
	{
		HashHelpers.SerializationInfoTable.TryGetValue(this, out var value);
		if (value == null)
		{
			return;
		}
		int @int = value.GetInt32("Version");
		int int2 = value.GetInt32("HashSize");
		comparer = (IEqualityComparer<TKey>)value.GetValue("Comparer", typeof(IEqualityComparer<TKey>));
		if (int2 != 0)
		{
			buckets = new int[int2];
			for (int i = 0; i < buckets.Length; i++)
			{
				buckets[i] = -1;
			}
			entries = new Entry[int2];
			freeList = -1;
			KeyValuePair<TKey, TValue>[] array = (KeyValuePair<TKey, TValue>[])value.GetValue("KeyValuePairs", typeof(KeyValuePair<TKey, TValue>[]));
			if (array == null)
			{
				ThrowHelper.ThrowSerializationException(ExceptionResource.Serialization_MissingKeys);
			}
			for (int j = 0; j < array.Length; j++)
			{
				if (array[j].Key == null)
				{
					ThrowHelper.ThrowSerializationException(ExceptionResource.Serialization_NullKey);
				}
				Insert(array[j].Key, array[j].Value, add: true);
			}
		}
		else
		{
			buckets = null;
		}
		version = @int;
		HashHelpers.SerializationInfoTable.Remove(this);
	}

	private void Resize()
	{
		Resize(HashHelpers.ExpandPrime(count), forceNewHashCodes: false);
	}

	private void Resize(int newSize, bool forceNewHashCodes)
	{
		int[] array = new int[newSize];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = -1;
		}
		Entry[] array2 = new Entry[newSize];
		Array.Copy(entries, 0, array2, 0, count);
		if (forceNewHashCodes)
		{
			for (int j = 0; j < count; j++)
			{
				if (array2[j].hashCode != -1)
				{
					array2[j].hashCode = comparer.GetHashCode(array2[j].key) & 0x7FFFFFFF;
				}
			}
		}
		for (int k = 0; k < count; k++)
		{
			if (array2[k].hashCode >= 0)
			{
				int num = array2[k].hashCode % newSize;
				array2[k].next = array[num];
				array[num] = k;
			}
		}
		buckets = array;
		entries = array2;
	}

	[__DynamicallyInvokable]
	public bool Remove(TKey key)
	{
		if (key == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
		}
		if (buckets != null)
		{
			int num = comparer.GetHashCode(key) & 0x7FFFFFFF;
			int num2 = num % buckets.Length;
			int num3 = -1;
			for (int num4 = buckets[num2]; num4 >= 0; num4 = entries[num4].next)
			{
				if (entries[num4].hashCode == num && comparer.Equals(entries[num4].key, key))
				{
					if (num3 < 0)
					{
						buckets[num2] = entries[num4].next;
					}
					else
					{
						entries[num3].next = entries[num4].next;
					}
					entries[num4].hashCode = -1;
					entries[num4].next = freeList;
					entries[num4].key = default(TKey);
					entries[num4].value = default(TValue);
					freeList = num4;
					freeCount++;
					version++;
					return true;
				}
				num3 = num4;
			}
		}
		return false;
	}

	[__DynamicallyInvokable]
	public bool TryGetValue(TKey key, out TValue value)
	{
		int num = FindEntry(key);
		if (num >= 0)
		{
			value = entries[num].value;
			return true;
		}
		value = default(TValue);
		return false;
	}

	internal TValue GetValueOrDefault(TKey key)
	{
		int num = FindEntry(key);
		if (num >= 0)
		{
			return entries[num].value;
		}
		return default(TValue);
	}

	[__DynamicallyInvokable]
	void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
	{
		CopyTo(array, index);
	}

	[__DynamicallyInvokable]
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
		if (index < 0 || index > array.Length)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
		}
		if (array.Length - index < Count)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
		}
		if (array is KeyValuePair<TKey, TValue>[] array2)
		{
			CopyTo(array2, index);
			return;
		}
		if (array is DictionaryEntry[])
		{
			DictionaryEntry[] array3 = array as DictionaryEntry[];
			Entry[] array4 = entries;
			for (int i = 0; i < count; i++)
			{
				if (array4[i].hashCode >= 0)
				{
					array3[index++] = new DictionaryEntry(array4[i].key, array4[i].value);
				}
			}
			return;
		}
		object[] array5 = array as object[];
		if (array5 == null)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
		}
		try
		{
			int num = count;
			Entry[] array6 = entries;
			for (int j = 0; j < num; j++)
			{
				if (array6[j].hashCode >= 0)
				{
					array5[index++] = new KeyValuePair<TKey, TValue>(array6[j].key, array6[j].value);
				}
			}
		}
		catch (ArrayTypeMismatchException)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
		}
	}

	[__DynamicallyInvokable]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new Enumerator(this, 2);
	}

	private static bool IsCompatibleKey(object key)
	{
		if (key == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
		}
		return key is TKey;
	}

	[__DynamicallyInvokable]
	void IDictionary.Add(object key, object value)
	{
		if (key == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
		}
		ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TValue>(value, ExceptionArgument.value);
		try
		{
			TKey key2 = (TKey)key;
			try
			{
				Add(key2, (TValue)value);
			}
			catch (InvalidCastException)
			{
				ThrowHelper.ThrowWrongValueTypeArgumentException(value, typeof(TValue));
			}
		}
		catch (InvalidCastException)
		{
			ThrowHelper.ThrowWrongKeyTypeArgumentException(key, typeof(TKey));
		}
	}

	[__DynamicallyInvokable]
	bool IDictionary.Contains(object key)
	{
		if (IsCompatibleKey(key))
		{
			return ContainsKey((TKey)key);
		}
		return false;
	}

	[__DynamicallyInvokable]
	IDictionaryEnumerator IDictionary.GetEnumerator()
	{
		return new Enumerator(this, 1);
	}

	[__DynamicallyInvokable]
	void IDictionary.Remove(object key)
	{
		if (IsCompatibleKey(key))
		{
			Remove((TKey)key);
		}
	}
}
