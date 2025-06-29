using System.Collections.Generic;
using System.Linq.Expressions;

namespace System.Dynamic.Utils;

internal static class Helpers
{
	internal static T CommonNode<T>(T first, T second, Func<T, T> parent) where T : class
	{
		EqualityComparer<T> equalityComparer = EqualityComparer<T>.Default;
		if (equalityComparer.Equals(first, second))
		{
			return first;
		}
		Set<T> set = new Set<T>(equalityComparer);
		for (T val = first; val != null; val = parent(val))
		{
			set.Add(val);
		}
		for (T val2 = second; val2 != null; val2 = parent(val2))
		{
			if (set.Contains(val2))
			{
				return val2;
			}
		}
		return null;
	}

	internal static void IncrementCount<T>(T key, Dictionary<T, int> dict)
	{
		dict.TryGetValue(key, out var value);
		dict[key] = value + 1;
	}
}
