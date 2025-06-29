using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal sealed class MapToCollectionAdapter
{
	private MapToCollectionAdapter()
	{
	}

	[SecurityCritical]
	internal int Count<K, V>()
	{
		object obj = JitHelpers.UnsafeCast<object>(this);
		if (obj is IMap<K, V> { Size: var size })
		{
			if (int.MaxValue < size)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CollectionBackingDictionaryTooLarge"));
			}
			return (int)size;
		}
		IVector<KeyValuePair<K, V>> vector = JitHelpers.UnsafeCast<IVector<KeyValuePair<K, V>>>(this);
		uint size2 = vector.Size;
		if (int.MaxValue < size2)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CollectionBackingListTooLarge"));
		}
		return (int)size2;
	}

	[SecurityCritical]
	internal bool IsReadOnly<K, V>()
	{
		return false;
	}

	[SecurityCritical]
	internal void Add<K, V>(KeyValuePair<K, V> item)
	{
		object obj = JitHelpers.UnsafeCast<object>(this);
		if (obj is IDictionary<K, V> dictionary)
		{
			dictionary.Add(item.Key, item.Value);
			return;
		}
		IVector<KeyValuePair<K, V>> vector = JitHelpers.UnsafeCast<IVector<KeyValuePair<K, V>>>(this);
		vector.Append(item);
	}

	[SecurityCritical]
	internal void Clear<K, V>()
	{
		object obj = JitHelpers.UnsafeCast<object>(this);
		if (obj is IMap<K, V> map)
		{
			map.Clear();
			return;
		}
		IVector<KeyValuePair<K, V>> vector = JitHelpers.UnsafeCast<IVector<KeyValuePair<K, V>>>(this);
		vector.Clear();
	}

	[SecurityCritical]
	internal bool Contains<K, V>(KeyValuePair<K, V> item)
	{
		object obj = JitHelpers.UnsafeCast<object>(this);
		if (obj is IDictionary<K, V> dictionary)
		{
			if (!dictionary.TryGetValue(item.Key, out var value))
			{
				return false;
			}
			return EqualityComparer<V>.Default.Equals(value, item.Value);
		}
		IVector<KeyValuePair<K, V>> vector = JitHelpers.UnsafeCast<IVector<KeyValuePair<K, V>>>(this);
		uint index;
		return vector.IndexOf(item, out index);
	}

	[SecurityCritical]
	internal void CopyTo<K, V>(KeyValuePair<K, V>[] array, int arrayIndex)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (arrayIndex < 0)
		{
			throw new ArgumentOutOfRangeException("arrayIndex");
		}
		if (array.Length <= arrayIndex && Count<K, V>() > 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_IndexOutOfArrayBounds"));
		}
		if (array.Length - arrayIndex < Count<K, V>())
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InsufficientSpaceToCopyCollection"));
		}
		IIterable<KeyValuePair<K, V>> iterable = JitHelpers.UnsafeCast<IIterable<KeyValuePair<K, V>>>(this);
		foreach (KeyValuePair<K, V> item in iterable)
		{
			array[arrayIndex++] = item;
		}
	}

	[SecurityCritical]
	internal bool Remove<K, V>(KeyValuePair<K, V> item)
	{
		object obj = JitHelpers.UnsafeCast<object>(this);
		if (obj is IDictionary<K, V> dictionary)
		{
			return dictionary.Remove(item.Key);
		}
		IVector<KeyValuePair<K, V>> vector = JitHelpers.UnsafeCast<IVector<KeyValuePair<K, V>>>(this);
		if (!vector.IndexOf(item, out var index))
		{
			return false;
		}
		if (int.MaxValue < index)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CollectionBackingListTooLarge"));
		}
		VectorToListAdapter.RemoveAtHelper(vector, index);
		return true;
	}
}
