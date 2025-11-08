using System.Collections.Generic;

namespace BlackMythWukong_Game_Helper;

public class NameCN
{
	private Dictionary<string, Name> Dic_;

	public NameCN()
	{
		Dic_ = new Dictionary<string, Name>();
	}

	public Name CN(string key)
	{
		if (!Dic_.TryGetValue(key, out var value))
		{
			return null;
		}
		return value;
	}

	public void Add(List<Name> list)
	{
		for (int i = 0; i < list.Count; i++)
		{
			Dic_[list[i].Key] = list[i];
		}
	}
}
