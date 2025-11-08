using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackMythWukong_Game_Helper;

public class BU_TimerSystem : SystemBase
{
	public Dictionary<int, TimerInfo> _Dic = new Dictionary<int, TimerInfo>();

	public List<int> _Keys = new List<int>();

	private static int _ID = 1000;

	public int Add(float delay, Action action, int id = -1, bool isloop = false)
	{
		if (id == -1)
		{
			id = _ID;
		}
		if (HasTimerByID(id))
		{
			return 0;
		}
		TimerInfo timerInfo = new TimerInfo(id, isloop);
		timerInfo.DelayTime = delay / 1000f;
		timerInfo.action = action;
		_Dic.Add(timerInfo.Id, timerInfo);
		_ID++;
		return timerInfo.Id;
	}

	public void PauseByID(int key)
	{
		if (_Dic.TryGetValue(key, out var value))
		{
			value.IsPause = true;
		}
	}

	public void PauseAll()
	{
		_Keys.Clear();
		_Keys = _Dic.Keys.ToList();
		foreach (int key in _Keys)
		{
			if (_Dic.TryGetValue(key, out var value))
			{
				value.IsPause = true;
			}
		}
	}

	public void StartByID(int key)
	{
		if (_Dic.TryGetValue(key, out var value))
		{
			value.IsPause = false;
		}
	}

	public void StartAll()
	{
		_Keys.Clear();
		_Keys = _Dic.Keys.ToList();
		foreach (int key in _Keys)
		{
			if (_Dic.TryGetValue(key, out var value))
			{
				value.IsPause = false;
			}
		}
	}

	public void RemoveByID(int key)
	{
		if (_Dic.TryGetValue(key, out var _))
		{
			_Dic.Remove(key);
		}
	}

	public void RemoveAll()
	{
		_Dic.Clear();
		_ID = 1000;
	}

	public bool HasTimerByID(int id)
	{
		return _Dic.ContainsKey(id);
	}

	public override void OnAttach()
	{
		SetRun(isRun: true);
	}

	public override void OnBeginPlay()
	{
	}

	public override void OnTick(float DeltTime, int TickGroup)
	{
		if (!IsRun)
		{
			return;
		}
		_Keys.Clear();
		_Keys = _Dic.Keys.ToList();
		foreach (int key in _Keys)
		{
			if (!_Dic.TryGetValue(key, out var value) || value.IsPause)
			{
				continue;
			}
			value.CurrentlyTime += DeltTime;
			if (value.CurrentlyTime > value.DelayTime)
			{
				value.action();
				if (value.IsLoop)
				{
					value.CurrentlyTime = 0f;
				}
				else
				{
					_Dic.Remove(key);
				}
			}
		}
	}
}
