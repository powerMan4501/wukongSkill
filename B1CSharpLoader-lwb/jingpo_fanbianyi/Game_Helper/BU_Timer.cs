using System;
using System.Collections.Generic;
using System.Linq;

namespace Game_Helper;

public class BU_Timer : BaseGameHelper
{
	public class TimerInfo
	{
		public int Id;

		public float DelayTime;

		public float CurrentlyTime;

		public bool IsLoop;

		public bool IsPause;

		public Action action;

		public TimerInfo(int id, bool loop = false)
		{
			Id = id;
			IsLoop = loop;
			CurrentlyTime = 0f;
			IsPause = false;
		}

		public int GetID()
		{
			return Id;
		}
	}

	public Dictionary<int, TimerInfo> _Dic = new Dictionary<int, TimerInfo>();

	public List<int> _Keys = new List<int>();

	private static int _ID = 1000;

	public bool IsRuning { get; set; }

	public static int Add(float delay, Action action, int id = -1, bool isloop = false)
	{
		if (id == -1)
		{
			id = _ID;
		}
		TimerInfo timerInfo = new TimerInfo(id, isloop);
		timerInfo.DelayTime = delay;
		timerInfo.action = action;
		Tools.bU_Timer._Dic.Add(timerInfo.Id, timerInfo);
		_ID++;
		return timerInfo.Id;
	}

	public static void PauseByID(int key)
	{
		if (Tools.bU_Timer._Dic.TryGetValue(key, out var value))
		{
			value.IsPause = true;
		}
	}

	public static void PauseAll()
	{
		Tools.bU_Timer._Keys.Clear();
		Tools.bU_Timer._Keys = Tools.bU_Timer._Dic.Keys.ToList();
		foreach (int key in Tools.bU_Timer._Keys)
		{
			if (Tools.bU_Timer._Dic.TryGetValue(key, out var value))
			{
				value.IsPause = true;
			}
		}
	}

	public static void StartByID(int key)
	{
		if (Tools.bU_Timer._Dic.TryGetValue(key, out var value))
		{
			value.IsPause = false;
		}
	}

	public static void StartAll()
	{
		Tools.bU_Timer._Keys.Clear();
		Tools.bU_Timer._Keys = Tools.bU_Timer._Dic.Keys.ToList();
		foreach (int key in Tools.bU_Timer._Keys)
		{
			if (Tools.bU_Timer._Dic.TryGetValue(key, out var value))
			{
				value.IsPause = false;
			}
		}
	}

	public static void RemoveByID(int key)
	{
		if (Tools.bU_Timer._Dic.TryGetValue(key, out var _))
		{
			Tools.bU_Timer._Dic.Remove(key);
		}
	}

	public static void RemoveAll()
	{
		Tools.bU_Timer._Dic.Clear();
	}

	public void OnInitialize()
	{
	}

	public void OnTick(float DeltTime, int TickGroup)
	{
		if (!IsRuning)
		{
			return;
		}
		_Keys.Clear();
		_Keys = _Dic.Keys.ToList();
		foreach (int key in Tools.bU_Timer._Keys)
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

	public void StartRun()
	{
		IsRuning = true;
	}

	public void StopRun()
	{
		RemoveAll();
		IsRuning = false;
	}
}
