using System.Diagnostics;

namespace System.Collections.Generic;

[Serializable]
[DebuggerTypeProxy(typeof(System_DictionaryDebugView<, >))]
[DebuggerDisplay("Count = {Count}")]
[global::__DynamicallyInvokable]
public class SortedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
{
	[global::__DynamicallyInvokable]
	public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator
	{
		private SortedSet<KeyValuePair<TKey, TValue>>.Enumerator treeEnum;

		private int getEnumeratorRetType;

		internal const int KeyValuePair = 1;

		internal const int DictEntry = 2;

		[global::__DynamicallyInvokable]
		public KeyValuePair<TKey, TValue> Current
		{
			[global::__DynamicallyInvokable]
			get
			{
				return treeEnum.Current;
			}
		}

		internal bool NotStartedOrEnded => treeEnum.NotStartedOrEnded;

		[global::__DynamicallyInvokable]
		object IEnumerator.Current
		{
			[global::__DynamicallyInvokable]
			get
			{
				if (NotStartedOrEnded)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumOpCantHappen);
				}
				if (getEnumeratorRetType == 2)
				{
					return new DictionaryEntry(Current.Key, Current.Value);
				}
				return new KeyValuePair<TKey, TValue>(Current.Key, Current.Value);
			}
		}

		[global::__DynamicallyInvokable]
		object IDictionaryEnumerator.Key
		{
			[global::__DynamicallyInvokable]
			get
			{
				if (NotStartedOrEnded)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumOpCantHappen);
				}
				return Current.Key;
			}
		}

		[global::__DynamicallyInvokable]
		object IDictionaryEnumerator.Value
		{
			[global::__DynamicallyInvokable]
			get
			{
				if (NotStartedOrEnded)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumOpCantHappen);
				}
				return Current.Value;
			}
		}

		[global::__DynamicallyInvokable]
		DictionaryEntry IDictionaryEnumerator.Entry
		{
			[global::__DynamicallyInvokable]
			get
			{
				if (NotStartedOrEnded)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumOpCantHappen);
				}
				return new DictionaryEntry(Current.Key, Current.Value);
			}
		}

		internal Enumerator(SortedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
		{
			treeEnum = dictionary._set.GetEnumerator();
			this.getEnumeratorRetType = getEnumeratorRetType;
		}

		[global::__DynamicallyInvokable]
		public bool MoveNext()
		{
			return treeEnum.MoveNext();
		}

		[global::__DynamicallyInvokable]
		public void Dispose()
		{
			treeEnum.Dispose();
		}

		internal void Reset()
		{
			treeEnum.Reset();
		}

		[global::__DynamicallyInvokable]
		void IEnumerator.Reset()
		{
			treeEnum.Reset();
		}
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(System_DictionaryKeyCollectionDebugView<, >))]
	[DebuggerDisplay("Count = {Count}")]
	[global::__DynamicallyInvokable]
	public sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
	{
		[global::__DynamicallyInvokable]
		public struct Enumerator : IEnumerator<TKey>, IDisposable, IEnumerator
		{
			private SortedDictionary<TKey, TValue>.Enumerator dictEnum;

			[global::__DynamicallyInvokable]
			public TKey Current
			{
				[global::__DynamicallyInvokable]
				get
				{
					return dictEnum.Current.Key;
				}
			}

			[global::__DynamicallyInvokable]
			object IEnumerator.Current
			{
				[global::__DynamicallyInvokable]
				get
				{
					if (dictEnum.NotStartedOrEnded)
					{
						ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumOpCantHappen);
					}
					return Current;
				}
			}

			internal Enumerator(SortedDictionary<TKey, TValue> dictionary)
			{
				dictEnum = dictionary.GetEnumerator();
			}

			[global::__DynamicallyInvokable]
			public void Dispose()
			{
				dictEnum.Dispose();
			}

			[global::__DynamicallyInvokable]
			public bool MoveNext()
			{
				return dictEnum.MoveNext();
			}

			[global::__DynamicallyInvokable]
			void IEnumerator.Reset()
			{
				dictEnum.Reset();
			}
		}

		private SortedDictionary<TKey, TValue> dictionary;

		[global::__DynamicallyInvokable]
		public int Count
		{
			[global::__DynamicallyInvokable]
			get
			{
				return dictionary.Count;
			}
		}

		[global::__DynamicallyInvokable]
		bool ICollection<TKey>.IsReadOnly
		{
			[global::__DynamicallyInvokable]
			get
			{
				return true;
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
				return ((ICollection)dictionary).SyncRoot;
			}
		}

		[global::__DynamicallyInvokable]
		public KeyCollection(SortedDictionary<TKey, TValue> dictionary)
		{
			if (dictionary == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.dictionary);
			}
			this.dictionary = dictionary;
		}

		[global::__DynamicallyInvokable]
		public Enumerator GetEnumerator()
		{
			return new Enumerator(dictionary);
		}

		[global::__DynamicallyInvokable]
		IEnumerator<TKey> IEnumerable<TKey>.GetEnumerator()
		{
			return new Enumerator(dictionary);
		}

		[global::__DynamicallyInvokable]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new Enumerator(dictionary);
		}

		[global::__DynamicallyInvokable]
		public void CopyTo(TKey[] array, int index)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (index < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			if (array.Length - index < Count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
			}
			dictionary._set.InOrderTreeWalk(delegate(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
			{
				array[index++] = node.Item.Key;
				return true;
			});
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
			if (index < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.arrayIndex, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
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
			object[] objects = (object[])array;
			if (objects == null)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
			}
			try
			{
				dictionary._set.InOrderTreeWalk(delegate(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
				{
					objects[index++] = node.Item.Key;
					return true;
				});
			}
			catch (ArrayTypeMismatchException)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
			}
		}

		[global::__DynamicallyInvokable]
		void ICollection<TKey>.Add(TKey item)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_KeyCollectionSet);
		}

		[global::__DynamicallyInvokable]
		void ICollection<TKey>.Clear()
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_KeyCollectionSet);
		}

		[global::__DynamicallyInvokable]
		bool ICollection<TKey>.Contains(TKey item)
		{
			return dictionary.ContainsKey(item);
		}

		[global::__DynamicallyInvokable]
		bool ICollection<TKey>.Remove(TKey item)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_KeyCollectionSet);
			return false;
		}
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(System_DictionaryValueCollectionDebugView<, >))]
	[DebuggerDisplay("Count = {Count}")]
	[global::__DynamicallyInvokable]
	public sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
	{
		[global::__DynamicallyInvokable]
		public struct Enumerator : IEnumerator<TValue>, IDisposable, IEnumerator
		{
			private SortedDictionary<TKey, TValue>.Enumerator dictEnum;

			[global::__DynamicallyInvokable]
			public TValue Current
			{
				[global::__DynamicallyInvokable]
				get
				{
					return dictEnum.Current.Value;
				}
			}

			[global::__DynamicallyInvokable]
			object IEnumerator.Current
			{
				[global::__DynamicallyInvokable]
				get
				{
					if (dictEnum.NotStartedOrEnded)
					{
						ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumOpCantHappen);
					}
					return Current;
				}
			}

			internal Enumerator(SortedDictionary<TKey, TValue> dictionary)
			{
				dictEnum = dictionary.GetEnumerator();
			}

			[global::__DynamicallyInvokable]
			public void Dispose()
			{
				dictEnum.Dispose();
			}

			[global::__DynamicallyInvokable]
			public bool MoveNext()
			{
				return dictEnum.MoveNext();
			}

			[global::__DynamicallyInvokable]
			void IEnumerator.Reset()
			{
				dictEnum.Reset();
			}
		}

		private SortedDictionary<TKey, TValue> dictionary;

		[global::__DynamicallyInvokable]
		public int Count
		{
			[global::__DynamicallyInvokable]
			get
			{
				return dictionary.Count;
			}
		}

		[global::__DynamicallyInvokable]
		bool ICollection<TValue>.IsReadOnly
		{
			[global::__DynamicallyInvokable]
			get
			{
				return true;
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
				return ((ICollection)dictionary).SyncRoot;
			}
		}

		[global::__DynamicallyInvokable]
		public ValueCollection(SortedDictionary<TKey, TValue> dictionary)
		{
			if (dictionary == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.dictionary);
			}
			this.dictionary = dictionary;
		}

		[global::__DynamicallyInvokable]
		public Enumerator GetEnumerator()
		{
			return new Enumerator(dictionary);
		}

		[global::__DynamicallyInvokable]
		IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator()
		{
			return new Enumerator(dictionary);
		}

		[global::__DynamicallyInvokable]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new Enumerator(dictionary);
		}

		[global::__DynamicallyInvokable]
		public void CopyTo(TValue[] array, int index)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (index < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			if (array.Length - index < Count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
			}
			dictionary._set.InOrderTreeWalk(delegate(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
			{
				array[index++] = node.Item.Value;
				return true;
			});
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
			if (index < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.arrayIndex, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
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
			object[] objects = (object[])array;
			if (objects == null)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
			}
			try
			{
				dictionary._set.InOrderTreeWalk(delegate(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
				{
					objects[index++] = node.Item.Value;
					return true;
				});
			}
			catch (ArrayTypeMismatchException)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
			}
		}

		[global::__DynamicallyInvokable]
		void ICollection<TValue>.Add(TValue item)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ValueCollectionSet);
		}

		[global::__DynamicallyInvokable]
		void ICollection<TValue>.Clear()
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ValueCollectionSet);
		}

		[global::__DynamicallyInvokable]
		bool ICollection<TValue>.Contains(TValue item)
		{
			return dictionary.ContainsValue(item);
		}

		[global::__DynamicallyInvokable]
		bool ICollection<TValue>.Remove(TValue item)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ValueCollectionSet);
			return false;
		}
	}

	[Serializable]
	internal class KeyValuePairComparer : Comparer<KeyValuePair<TKey, TValue>>
	{
		internal IComparer<TKey> keyComparer;

		public KeyValuePairComparer(IComparer<TKey> keyComparer)
		{
			if (keyComparer == null)
			{
				this.keyComparer = Comparer<TKey>.Default;
			}
			else
			{
				this.keyComparer = keyComparer;
			}
		}

		public override int Compare(KeyValuePair<TKey, TValue> x, KeyValuePair<TKey, TValue> y)
		{
			return keyComparer.Compare(x.Key, y.Key);
		}
	}

	[NonSerialized]
	private KeyCollection keys;

	[NonSerialized]
	private ValueCollection values;

	private TreeSet<KeyValuePair<TKey, TValue>> _set;

	[global::__DynamicallyInvokable]
	bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly
	{
		[global::__DynamicallyInvokable]
		get
		{
			return false;
		}
	}

	[global::__DynamicallyInvokable]
	public TValue this[TKey key]
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (key == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
			}
			SortedSet<KeyValuePair<TKey, TValue>>.Node node = _set.FindNode(new KeyValuePair<TKey, TValue>(key, default(TValue)));
			if (node == null)
			{
				ThrowHelper.ThrowKeyNotFoundException();
			}
			return node.Item.Value;
		}
		[global::__DynamicallyInvokable]
		set
		{
			if (key == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
			}
			SortedSet<KeyValuePair<TKey, TValue>>.Node node = _set.FindNode(new KeyValuePair<TKey, TValue>(key, default(TValue)));
			if (node == null)
			{
				_set.Add(new KeyValuePair<TKey, TValue>(key, value));
				return;
			}
			node.Item = new KeyValuePair<TKey, TValue>(node.Item.Key, value);
			_set.UpdateVersion();
		}
	}

	[global::__DynamicallyInvokable]
	public int Count
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _set.Count;
		}
	}

	[global::__DynamicallyInvokable]
	public IComparer<TKey> Comparer
	{
		[global::__DynamicallyInvokable]
		get
		{
			return ((KeyValuePairComparer)_set.Comparer).keyComparer;
		}
	}

	[global::__DynamicallyInvokable]
	public KeyCollection Keys
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (keys == null)
			{
				keys = new KeyCollection(this);
			}
			return keys;
		}
	}

	[global::__DynamicallyInvokable]
	ICollection<TKey> IDictionary<TKey, TValue>.Keys
	{
		[global::__DynamicallyInvokable]
		get
		{
			return Keys;
		}
	}

	[global::__DynamicallyInvokable]
	IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys
	{
		[global::__DynamicallyInvokable]
		get
		{
			return Keys;
		}
	}

	[global::__DynamicallyInvokable]
	public ValueCollection Values
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (values == null)
			{
				values = new ValueCollection(this);
			}
			return values;
		}
	}

	[global::__DynamicallyInvokable]
	ICollection<TValue> IDictionary<TKey, TValue>.Values
	{
		[global::__DynamicallyInvokable]
		get
		{
			return Values;
		}
	}

	[global::__DynamicallyInvokable]
	IEnumerable<TValue> IReadOnlyDictionary<TKey, TValue>.Values
	{
		[global::__DynamicallyInvokable]
		get
		{
			return Values;
		}
	}

	[global::__DynamicallyInvokable]
	bool IDictionary.IsFixedSize
	{
		[global::__DynamicallyInvokable]
		get
		{
			return false;
		}
	}

	[global::__DynamicallyInvokable]
	bool IDictionary.IsReadOnly
	{
		[global::__DynamicallyInvokable]
		get
		{
			return false;
		}
	}

	[global::__DynamicallyInvokable]
	ICollection IDictionary.Keys
	{
		[global::__DynamicallyInvokable]
		get
		{
			return Keys;
		}
	}

	[global::__DynamicallyInvokable]
	ICollection IDictionary.Values
	{
		[global::__DynamicallyInvokable]
		get
		{
			return Values;
		}
	}

	[global::__DynamicallyInvokable]
	object IDictionary.this[object key]
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (IsCompatibleKey(key) && TryGetValue((TKey)key, out var value))
			{
				return value;
			}
			return null;
		}
		[global::__DynamicallyInvokable]
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
			return ((ICollection)_set).SyncRoot;
		}
	}

	[global::__DynamicallyInvokable]
	public SortedDictionary()
		: this((IComparer<TKey>)null)
	{
	}

	[global::__DynamicallyInvokable]
	public SortedDictionary(IDictionary<TKey, TValue> dictionary)
		: this(dictionary, (IComparer<TKey>)null)
	{
	}

	[global::__DynamicallyInvokable]
	public SortedDictionary(IDictionary<TKey, TValue> dictionary, IComparer<TKey> comparer)
	{
		if (dictionary == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.dictionary);
		}
		_set = new TreeSet<KeyValuePair<TKey, TValue>>(new KeyValuePairComparer(comparer));
		foreach (KeyValuePair<TKey, TValue> item in dictionary)
		{
			_set.Add(item);
		}
	}

	[global::__DynamicallyInvokable]
	public SortedDictionary(IComparer<TKey> comparer)
	{
		_set = new TreeSet<KeyValuePair<TKey, TValue>>(new KeyValuePairComparer(comparer));
	}

	[global::__DynamicallyInvokable]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair)
	{
		_set.Add(keyValuePair);
	}

	[global::__DynamicallyInvokable]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair)
	{
		SortedSet<KeyValuePair<TKey, TValue>>.Node node = _set.FindNode(keyValuePair);
		if (node == null)
		{
			return false;
		}
		if (keyValuePair.Value == null)
		{
			return node.Item.Value == null;
		}
		return EqualityComparer<TValue>.Default.Equals(node.Item.Value, keyValuePair.Value);
	}

	[global::__DynamicallyInvokable]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair)
	{
		SortedSet<KeyValuePair<TKey, TValue>>.Node node = _set.FindNode(keyValuePair);
		if (node == null)
		{
			return false;
		}
		if (EqualityComparer<TValue>.Default.Equals(node.Item.Value, keyValuePair.Value))
		{
			_set.Remove(keyValuePair);
			return true;
		}
		return false;
	}

	[global::__DynamicallyInvokable]
	public void Add(TKey key, TValue value)
	{
		if (key == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
		}
		_set.Add(new KeyValuePair<TKey, TValue>(key, value));
	}

	[global::__DynamicallyInvokable]
	public void Clear()
	{
		_set.Clear();
	}

	[global::__DynamicallyInvokable]
	public bool ContainsKey(TKey key)
	{
		if (key == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
		}
		return _set.Contains(new KeyValuePair<TKey, TValue>(key, default(TValue)));
	}

	[global::__DynamicallyInvokable]
	public bool ContainsValue(TValue value)
	{
		bool found = false;
		if (value == null)
		{
			_set.InOrderTreeWalk(delegate(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
			{
				if (node.Item.Value == null)
				{
					found = true;
					return false;
				}
				return true;
			});
		}
		else
		{
			EqualityComparer<TValue> valueComparer = EqualityComparer<TValue>.Default;
			_set.InOrderTreeWalk(delegate(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
			{
				if (valueComparer.Equals(node.Item.Value, value))
				{
					found = true;
					return false;
				}
				return true;
			});
		}
		return found;
	}

	[global::__DynamicallyInvokable]
	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
	{
		_set.CopyTo(array, index);
	}

	[global::__DynamicallyInvokable]
	public Enumerator GetEnumerator()
	{
		return new Enumerator(this, 1);
	}

	[global::__DynamicallyInvokable]
	IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
	{
		return new Enumerator(this, 1);
	}

	[global::__DynamicallyInvokable]
	public bool Remove(TKey key)
	{
		if (key == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
		}
		return _set.Remove(new KeyValuePair<TKey, TValue>(key, default(TValue)));
	}

	[global::__DynamicallyInvokable]
	public bool TryGetValue(TKey key, out TValue value)
	{
		if (key == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
		}
		SortedSet<KeyValuePair<TKey, TValue>>.Node node = _set.FindNode(new KeyValuePair<TKey, TValue>(key, default(TValue)));
		if (node == null)
		{
			value = default(TValue);
			return false;
		}
		value = node.Item.Value;
		return true;
	}

	[global::__DynamicallyInvokable]
	void ICollection.CopyTo(Array array, int index)
	{
		((ICollection)_set).CopyTo(array, index);
	}

	[global::__DynamicallyInvokable]
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

	[global::__DynamicallyInvokable]
	bool IDictionary.Contains(object key)
	{
		if (IsCompatibleKey(key))
		{
			return ContainsKey((TKey)key);
		}
		return false;
	}

	private static bool IsCompatibleKey(object key)
	{
		if (key == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
		}
		return key is TKey;
	}

	[global::__DynamicallyInvokable]
	IDictionaryEnumerator IDictionary.GetEnumerator()
	{
		return new Enumerator(this, 2);
	}

	[global::__DynamicallyInvokable]
	void IDictionary.Remove(object key)
	{
		if (IsCompatibleKey(key))
		{
			Remove((TKey)key);
		}
	}

	[global::__DynamicallyInvokable]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new Enumerator(this, 1);
	}
}
