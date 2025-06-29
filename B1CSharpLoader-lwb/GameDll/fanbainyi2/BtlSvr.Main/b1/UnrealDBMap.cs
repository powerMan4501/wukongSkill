using System.Collections.Generic;

namespace b1;

public class UnrealDBMap<TValue, TStruct> where TValue : class, IUnrealDBItem<TStruct>, new()
{
	private Dictionary<int, TValue> CacheMap = new Dictionary<int, TValue>();

	private TValue InvalidItem = new TValue();

	public TValue FindByID(int ResID)
	{
		if (CacheMap.TryGetValue(ResID, out var value))
		{
			return value;
		}
		return null;
	}

	public Dictionary<int, TValue> GetAll()
	{
		return CacheMap;
	}

	public void Reset()
	{
		CacheMap.Clear();
		foreach (KeyValuePair<int, TStruct> allDatum in InvalidItem.GetAllData())
		{
			TValue val = new TValue();
			val.SetVal(allDatum.Value);
			CacheMap.Add(allDatum.Key, val);
		}
	}
}
