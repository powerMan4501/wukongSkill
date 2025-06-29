using System.Collections.Generic;

namespace b1.AutoQA;

public static class ListExtensions
{
	public static void AddUnique<T>(this IList<T> list, T item)
	{
		if (!list.Contains(item))
		{
			list.Add(item);
		}
	}
}
