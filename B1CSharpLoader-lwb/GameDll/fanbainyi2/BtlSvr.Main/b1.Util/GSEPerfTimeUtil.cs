using System;
using System.Collections.Generic;

namespace b1.Util;

public class GSEPerfTimeUtil
{
	private static int PerfTimeLevel = 0;

	private static List<Stack<Tuple<int, string>>> PerfTimeDataList = new List<Stack<Tuple<int, string>>>();

	public static void Init()
	{
		PerfTimeDataList.Clear();
	}

	public static void SetPerfLevel(int PerfLevel)
	{
		PerfTimeLevel = PerfLevel;
	}

	public static int GetPerfLevel()
	{
		return PerfTimeLevel;
	}

	public static void Start(string Name, out int PERFID)
	{
		if (PerfTimeLevel == 0)
		{
			PERFID = 0;
			return;
		}
		string text = "";
		text = ((PerfTimeDataList.Count == 0) ? Name : (PerfTimeDataList[PerfTimeDataList.Count - 1].Peek().Item2 + "." + Name));
		PerfTimeDataList.Add(new Stack<Tuple<int, string>>());
		PERFID = PerfTimeDataList.Count;
		int timeMarkInUS = GSETimeUtil.GetTimeMarkInUS();
		PerfTimeDataList[PERFID - 1].Push(new Tuple<int, string>(timeMarkInUS, text));
	}

	private static void EndOne(ref Stack<Tuple<int, string>> EndData, int TimeMark, int PerfID)
	{
		Tuple<int, string> tuple = EndData.Pop();
		_ = tuple.Item1;
		_ = tuple.Item2;
	}

	public static void End(int PERFID, int TimeMark = 0)
	{
		if (PERFID >= PerfTimeLevel && PerfTimeLevel >= 0)
		{
			return;
		}
		if (PERFID > PerfTimeDataList.Count)
		{
			BGW_LogUtil.LogError($"Invalid PFID:{PERFID} PerfTimeDataCount:{PerfTimeDataList.Count} Must StepStart First!!");
			return;
		}
		if (TimeMark == 0)
		{
			TimeMark = GSETimeUtil.GetTimeMarkInUS();
		}
		if (PERFID > PerfTimeDataList.Count)
		{
			return;
		}
		for (int num = PerfTimeDataList.Count; num >= PERFID; num--)
		{
			Stack<Tuple<int, string>> EndData = PerfTimeDataList[num - 1];
			do
			{
				EndOne(ref EndData, TimeMark, num);
			}
			while (EndData.Count > 0);
		}
		int count = PerfTimeDataList.Count - PERFID + 1;
		PerfTimeDataList.RemoveRange(PERFID - 1, count);
	}

	public static void Doing(int PERFID, string Name)
	{
		if (PERFID >= PerfTimeLevel && PerfTimeLevel >= 0)
		{
			return;
		}
		if (PERFID > PerfTimeDataList.Count)
		{
			BGW_LogUtil.LogError($"Invalid PFID:{PERFID} PerfTimeDataCount:{PerfTimeDataList.Count} Name:{Name} Must StepStart First!!");
			return;
		}
		int timeMarkInUS = GSETimeUtil.GetTimeMarkInUS();
		if (PERFID < PerfTimeDataList.Count)
		{
			End(PERFID + 1, timeMarkInUS);
		}
		Stack<Tuple<int, string>> EndData = PerfTimeDataList[PERFID - 1];
		if (EndData.Count > 1)
		{
			EndOne(ref EndData, timeMarkInUS, PERFID);
		}
		string item = EndData.Peek().Item2 + "." + Name;
		EndData.Push(new Tuple<int, string>(timeMarkInUS, item));
	}
}
