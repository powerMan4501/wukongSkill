namespace b1;

public struct NativeMultiHashMapIterator<TKey> where TKey : struct
{
	internal TKey key;

	internal int NextEntryIndex;

	internal int EntryIndex;
}
