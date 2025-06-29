using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[DebuggerTypeProxy(typeof(TMapDebugView<, >))]
[DebuggerDisplay("Count = {Count}")]
public class TMapBase<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
{
	public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator
	{
		private int index;

		private TMapBase<TKey, TValue> map;

		public KeyValuePair<TKey, TValue> Current => map.GetAt(index);

		object IEnumerator.Current => Current;

		public Enumerator(TMapBase<TKey, TValue> map)
		{
			this.map = map;
			index = -1;
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			int maxIndex = map.MapHelper.GetMaxIndex();
			while (++index < maxIndex && !map.MapHelper.IsValidIndex(index))
			{
			}
			return index < maxIndex;
		}

		public void Reset()
		{
			index = -1;
		}
	}

	public struct KeyEnumerator : ICollection<TKey>, IEnumerable<TKey>, IEnumerable
	{
		public struct Enumerator : IEnumerator<TKey>, IDisposable, IEnumerator
		{
			private int index;

			private TMapBase<TKey, TValue> map;

			public int Count => map.Count;

			public TKey Current => map.GetAt(index).Key;

			object IEnumerator.Current => Current;

			public Enumerator(TMapBase<TKey, TValue> map)
			{
				this.map = map;
				index = -1;
			}

			public void Dispose()
			{
			}

			public bool MoveNext()
			{
				int maxIndex = map.MapHelper.GetMaxIndex();
				while (++index < maxIndex && !map.MapHelper.IsValidIndex(index))
				{
				}
				return index < maxIndex;
			}

			public void Reset()
			{
				index = -1;
			}
		}

		private TMapBase<TKey, TValue> map;

		public int Count => map.Count;

		public bool IsReadOnly => true;

		public KeyEnumerator(TMapBase<TKey, TValue> map)
		{
			this.map = map;
		}

		public void Add(TKey item)
		{
			throw new NotSupportedException();
		}

		public void Clear()
		{
			throw new NotSupportedException();
		}

		public bool Contains(TKey item)
		{
			return map.ContainsKey(item);
		}

		public void CopyTo(TKey[] array, int arrayIndex)
		{
			int maxIndex = map.MapHelper.GetMaxIndex();
			int num = arrayIndex;
			for (int i = 0; i < maxIndex; i++)
			{
				if (map.MapHelper.IsValidIndex(i))
				{
					array[num++] = map.GetAt(i).Key;
				}
			}
		}

		public bool Remove(TKey item)
		{
			throw new NotSupportedException();
		}

		public Enumerator GetEnumerator()
		{
			return new Enumerator(map);
		}

		IEnumerator<TKey> IEnumerable<TKey>.GetEnumerator()
		{
			return new Enumerator(map);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new Enumerator(map);
		}
	}

	public struct ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable
	{
		public struct Enumerator : IEnumerator<TValue>, IDisposable, IEnumerator
		{
			private int index;

			private TMapBase<TKey, TValue> map;

			public int Count => map.Count;

			public TValue Current => map.GetAt(index).Value;

			object IEnumerator.Current => Current;

			public Enumerator(TMapBase<TKey, TValue> map)
			{
				this.map = map;
				index = -1;
			}

			public void Dispose()
			{
			}

			public bool MoveNext()
			{
				int maxIndex = map.MapHelper.GetMaxIndex();
				while (++index < maxIndex && !map.MapHelper.IsValidIndex(index))
				{
				}
				return index < maxIndex;
			}

			public void Reset()
			{
				index = -1;
			}
		}

		private TMapBase<TKey, TValue> map;

		public int Count => map.Count;

		public bool IsReadOnly => true;

		public ValueCollection(TMapBase<TKey, TValue> map)
		{
			this.map = map;
		}

		public void Add(TValue item)
		{
			throw new NotSupportedException();
		}

		public void Clear()
		{
			throw new NotSupportedException();
		}

		public bool Contains(TValue item)
		{
			return map.ContainsValue(item);
		}

		public void CopyTo(TValue[] array, int arrayIndex)
		{
			int maxIndex = map.MapHelper.GetMaxIndex();
			int num = arrayIndex;
			for (int i = 0; i < maxIndex; i++)
			{
				if (map.MapHelper.IsValidIndex(i))
				{
					array[num++] = map.GetAt(i).Value;
				}
			}
		}

		public bool Remove(TValue item)
		{
			throw new NotSupportedException();
		}

		public Enumerator GetEnumerator()
		{
			return new Enumerator(map);
		}

		IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator()
		{
			return new Enumerator(map);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new Enumerator(map);
		}
	}

	protected readonly UObject Owner;

	protected MarshalingDelegates<TKey>.FromNative KeyFromNative;

	protected MarshalingDelegates<TKey>.ToNative KeyToNative;

	protected MarshalingDelegates<TValue>.FromNative ValueFromNative;

	protected MarshalingDelegates<TValue>.ToNative ValueToNative;

	private readonly FFieldAddress property;

	private unsafe readonly FScriptMap* map;

	protected FScriptMapHelper MapHelper;

	public unsafe int Count => map->Count;

	protected unsafe IntPtr Address => (IntPtr)map;

	public unsafe TMapBase(UObject owner, FFieldAddress mapProperty, IntPtr address, MarshalingDelegates<TKey>.FromNative keyFromNative, MarshalingDelegates<TKey>.ToNative keyToNative, MarshalingDelegates<TValue>.FromNative valueFromNative, MarshalingDelegates<TValue>.ToNative valueToNative)
	{
		property = mapProperty;
		map = (FScriptMap*)(void*)address;
		MapHelper = new FScriptMapHelper(property.Address, address);
		Owner = owner;
		KeyFromNative = keyFromNative;
		KeyToNative = keyToNative;
		ValueFromNative = valueFromNative;
		ValueToNative = valueToNative;
		ContainerHashValidator.Validate(Native_FMapProperty.Get_KeyProp(property.Address));
	}

	[Conditional("DEBUG")]
	protected void CheckOwner()
	{
		if (Owner != null && Owner.IsDestroyed)
		{
			throw new UObjectDestroyedException("Trying to access a TMap which points to memory of a destroyed UObject (" + property.PathName + ")");
		}
	}

	protected void ClearInternal()
	{
		MapHelper.Update(property);
		MapHelper.EmptyValues();
	}

	protected void AddInternal(TKey key, TValue value)
	{
		MapHelper.Update(property);
		MapHelper.AddPair(key, value, KeyToNative, ValueToNative);
	}

	protected bool RemoveInternal(TKey key)
	{
		int num = IndexOf(key);
		if (num >= 0)
		{
			MapHelper.Update(property);
			MapHelper.RemoveAt(num);
			return true;
		}
		return false;
	}

	protected void RemoveAtInternal(int index)
	{
		if (MapHelper.IsValidIndex(index))
		{
			MapHelper.Update(property);
			MapHelper.RemoveAt(index);
		}
	}

	protected bool TryGetInternal(TKey key, out TValue value)
	{
		int num = IndexOf(key);
		if (num >= 0)
		{
			value = GetAt(num).Value;
			return true;
		}
		value = default(TValue);
		return false;
	}

	protected KeyValuePair<TKey, TValue> GetAt(int index)
	{
		if (!MapHelper.IsValidIndex(index))
		{
			throw new IndexOutOfRangeException($"Index {index} is invalid. Indicies aren't necessarily sequential.");
		}
		MapHelper.Update(property);
		if (!MapHelper.GetPairPtr(index, out var keyPtr, out var valuePtr))
		{
			return default(KeyValuePair<TKey, TValue>);
		}
		return new KeyValuePair<TKey, TValue>(KeyFromNative(keyPtr, 0, MapHelper.KeyPropertyAddress), ValueFromNative(valuePtr, 0, MapHelper.ValuePropertyAddress));
	}

	public TValue Get(TKey key)
	{
		int num = IndexOf(key);
		if (num >= 0)
		{
			return GetAt(num).Value;
		}
		return default(TValue);
	}

	public bool ContainsKey(TKey key)
	{
		return IndexOf(key) >= 0;
	}

	public bool ContainsValue(TValue value)
	{
		EqualityComparer<TValue> equalityComparer = EqualityComparer<TValue>.Default;
		int maxIndex = MapHelper.GetMaxIndex();
		for (int i = 0; i < maxIndex; i++)
		{
			if (MapHelper.IsValidIndex(i) && equalityComparer.Equals(GetAt(i).Value, value))
			{
				return true;
			}
		}
		return false;
	}

	protected int IndexOf(TKey key)
	{
		MapHelper.Update(property);
		return MapHelper.FindPairIndex(key, KeyToNative, Owner);
	}

	public Enumerator GetEnumerator()
	{
		return new Enumerator(this);
	}

	IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
	{
		return new Enumerator(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new Enumerator(this);
	}
}
