using System.Collections.Generic;
using System.Threading;

namespace System.Dynamic.Utils;

internal class CacheDict<TKey, TValue>
{
	internal class Entry
	{
		internal readonly int hash;

		internal readonly TKey key;

		internal readonly TValue value;

		internal Entry(int hash, TKey key, TValue value)
		{
			this.hash = hash;
			this.key = key;
			this.value = value;
		}
	}

	protected readonly int mask;

	protected readonly Entry[] entries;

	internal TValue this[TKey key]
	{
		get
		{
			if (TryGetValue(key, out var value))
			{
				return value;
			}
			throw new KeyNotFoundException();
		}
		set
		{
			Add(key, value);
		}
	}

	internal CacheDict(int size)
	{
		int num = AlignSize(size);
		mask = num - 1;
		entries = new Entry[num];
	}

	private static int AlignSize(int size)
	{
		size--;
		size |= size >> 1;
		size |= size >> 2;
		size |= size >> 4;
		size |= size >> 8;
		size |= size >> 16;
		return size + 1;
	}

	internal bool TryGetValue(TKey key, out TValue value)
	{
		int hashCode = key.GetHashCode();
		int num = hashCode & mask;
		Entry entry = Volatile.Read(ref entries[num]);
		if (entry != null && entry.hash == hashCode && entry.key.Equals(key))
		{
			value = entry.value;
			return true;
		}
		value = default(TValue);
		return false;
	}

	internal void Add(TKey key, TValue value)
	{
		int hashCode = key.GetHashCode();
		int num = hashCode & mask;
		Entry entry = Volatile.Read(ref entries[num]);
		if (entry == null || entry.hash != hashCode || !entry.key.Equals(key))
		{
			Volatile.Write(ref entries[num], new Entry(hashCode, key, value));
		}
	}
}
