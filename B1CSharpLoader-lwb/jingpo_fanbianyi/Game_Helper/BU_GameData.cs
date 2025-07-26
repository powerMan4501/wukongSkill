using System.Collections.Generic;

namespace Game_Helper;

public class BU_GameData
{
	private Dictionary<int, object> _DictData;

	private static BU_GameData _instance;

	public T CreateObject<T>() where T : class, new()
	{
		T val = new T { };
		int typeIndex;
		_DictData[typeIndex] = val;
		return val;
	}

	public T GetObject<T>() where T : class, new()
	{
		if (_DictData.TryGetValue(BU_TypeManager.GetTypeIndex(typeof(T)), out var value))
		{
			return value as T;
		}
		return value as T;
	}

	public static BU_GameData Get()
	{
		if (_instance == null)
		{
			_instance = new BU_GameData();
		}
		return _instance;
	}

	public static void Init()
	{
		_instance = null;
	}

	private BU_GameData()
	{
		_DictData = new Dictionary<int, object>();
	}
}
