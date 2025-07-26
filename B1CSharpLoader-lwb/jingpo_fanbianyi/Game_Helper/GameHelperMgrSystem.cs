using System.Collections.Generic;
using System.Linq;
using b1;

namespace Game_Helper;

public class GameHelperMgrSystem : GameStateSystemBase
{
	private BU_GameData GameData;

	private Dictionary<SystemType, BaseGameHelper> _Dic = new Dictionary<SystemType, BaseGameHelper>();

	private List<SystemType> _keys = new List<SystemType>();

	public override void OnAttach()
	{
		GameData = BU_GameData.Get();
		Tools.BU_UIGameHelper = AddSystem(SystemType.UIGameHelper, new BU_UIGameHelper());
		Tools.buffRun = GameData.GetObject<BuffRun>();
		Tools.bU_Timer = AddSystem(SystemType.BU_Timer, GameData.GetObject<BU_Timer>());
		Tools.BU_PlayerTransSystem = AddSystem(SystemType.BU_PlayerTransSystem, GameData.GetObject<BU_PlayerTransSystem>());
		Tools.BU_PlayerTransSysemA = AddSystem(SystemType.BU_PlayerTransSysemA, GameData.GetObject<BU_PlayerTransSysemA>());
	}

	public override void OnBeginPlay()
	{
		((UActorCompBaseCS)this).OnBeginPlay();
		((UActorCompBaseCS)this).SetCanTick(true);
		Tools.buffRun.Init();
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		_keys.Clear();
		_keys = _Dic.Keys.ToList();
		foreach (SystemType key in _keys)
		{
			if (_Dic.TryGetValue(key, out var value) && value.IsRuning)
			{
				value.OnTick(DeltaTime, TickGroup);
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public T AddSystem<T>(SystemType systemType, T baseGameHelper) where T : BaseGameHelper, new()
	{
		if (_Dic.TryGetValue(systemType, out var value))
		{
			return (T)value;
		}
		T val = baseGameHelper;
		if (val == null)
		{
			val = new T();
		}
		val.OnInitialize();
		_Dic[systemType] = val;
		val.StartRun();
		return val;
	}

	public void RunSystem(SystemType systemType)
	{
		if (_Dic.TryGetValue(systemType, out var value))
		{
			value.StartRun();
		}
	}

	public void StopSystem(SystemType systemType)
	{
		if (_Dic.TryGetValue(systemType, out var value))
		{
			value.StopRun();
		}
	}

	public void StopAll()
	{
		List<SystemType> list = _Dic.Keys.ToList();
		foreach (SystemType item in list)
		{
			StopSystem(item);
		}
	}

	public BaseGameHelper GetGameHelper(SystemType systemType)
	{
		if (_Dic.TryGetValue(systemType, out var value))
		{
			return value;
		}
		return null;
	}
}
