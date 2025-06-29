using System.Collections.Generic;

namespace b1;

public static class GCFriendlyListCopyHelper
{
	public static void DoCopy<T>(List<T> source, List<T> dest)
	{
		dest.Clear();
		for (int i = 0; i < source.Count; i++)
		{
			dest.Add(source[i]);
		}
	}

	public static void DoCopy<K, T>(Dictionary<K, T> source, List<T> dest)
	{
		dest.Clear();
		foreach (KeyValuePair<K, T> item in source)
		{
			dest.Add(item.Value);
		}
	}
}
