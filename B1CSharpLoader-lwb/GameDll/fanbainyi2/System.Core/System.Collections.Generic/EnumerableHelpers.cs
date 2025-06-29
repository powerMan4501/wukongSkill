using System.Linq;

namespace System.Collections.Generic;

internal static class EnumerableHelpers
{
	internal static bool TryGetCount<T>(IEnumerable<T> source, out int count)
	{
		if (source is ICollection<T> collection)
		{
			count = collection.Count;
			return true;
		}
		if (source is IIListProvider<T> iIListProvider)
		{
			count = iIListProvider.GetCount(onlyIfCheap: true);
			return count >= 0;
		}
		count = -1;
		return false;
	}

	internal static void Copy<T>(IEnumerable<T> source, T[] array, int arrayIndex, int count)
	{
		if (source is ICollection<T> collection)
		{
			collection.CopyTo(array, arrayIndex);
		}
		else
		{
			IterativeCopy(source, array, arrayIndex, count);
		}
	}

	internal static void IterativeCopy<T>(IEnumerable<T> source, T[] array, int arrayIndex, int count)
	{
		int num = arrayIndex + count;
		foreach (T item in source)
		{
			array[arrayIndex++] = item;
		}
	}
}
