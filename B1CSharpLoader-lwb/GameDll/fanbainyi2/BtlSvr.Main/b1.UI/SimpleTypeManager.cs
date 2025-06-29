using System;
using System.Collections.Generic;

namespace b1.UI;

public static class SimpleTypeManager
{
	private static int AllocIdx = 1;

	private static Dictionary<Type, int> IndexMap = new Dictionary<Type, int>();

	public static int GetTypeIndex(Type T)
	{
		int value = 0;
		if (IndexMap.TryGetValue(T, out value))
		{
			return value;
		}
		value = AllocIdx++;
		IndexMap[T] = value;
		return value;
	}
}
