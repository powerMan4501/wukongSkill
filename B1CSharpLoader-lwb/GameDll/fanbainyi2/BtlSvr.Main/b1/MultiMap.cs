using System.Collections.Generic;

namespace b1;

public class MultiMap<T1, T2> : Dictionary<T1, List<T2>>
{
	public void Add(T1 InKey, T2 InValue)
	{
		if (ContainsKey(InKey))
		{
			if (base[InKey].Contains(InValue))
			{
				return;
			}
		}
		else
		{
			Add(InKey, new List<T2>());
		}
		base[InKey].Add(InValue);
	}

	public List<T2> MultiFind(T1 InKey)
	{
		if (!ContainsKey(InKey))
		{
			Add(InKey, new List<T2>());
		}
		return base[InKey];
	}

	public void Remove(T1 InKey, T2 InValue)
	{
		if (ContainsKey(InKey))
		{
			base[InKey].Remove(InValue);
			if (base[InKey].Count == 0)
			{
				Remove(InKey);
			}
		}
	}
}
