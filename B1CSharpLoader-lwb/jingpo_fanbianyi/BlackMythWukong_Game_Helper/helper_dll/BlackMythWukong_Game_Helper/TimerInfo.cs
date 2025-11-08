using System;

namespace BlackMythWukong_Game_Helper;

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
