using System.Collections.Generic;
using System.Diagnostics;

namespace b1.Profile;

public static class GSE_ProfileUtil
{
	public static class EProfileTag
	{
		public const int NoFilter = 1;

		public const int ECSCompStart = 2;

		public const int ECSCompTick = 4;

		public const int ECSCompTickWithGroup = 8;

		public const int ECSCompLateTick = 16;

		public const int UITick = 32;
	}

	public static bool sOpenProfiler = true;

	public static bool sOpenProfileBeginPlay = true;

	public static int sProfileTagFilter = int.MaxValue;

	public static int ProfileCount = 0;

	private static Dictionary<string, int> sProfileStatIdDic = new Dictionary<string, int>();

	private static Dictionary<string, int> sTickProfileStatIdDic = new Dictionary<string, int>();

	private static Dictionary<string, int> sLateTickProfileStatIdDic = new Dictionary<string, int>();

	private static Dictionary<string, Dictionary<int, int>> sTickWithGroupProfileStatIdDic = new Dictionary<string, Dictionary<int, int>>();

	private static Dictionary<string, int> sUITickProfileStatIdDic = new Dictionary<string, int>();

	private static Dictionary<int, string> sTickGroupMaskDic = new Dictionary<int, string>();

	private static Stack<int> SProfileTag = new Stack<int>();

	private static Stack<string> SProfileName = new Stack<string>();

	private static Dictionary<int, string> sProfileTagName = new Dictionary<int, string>
	{
		{ 4, ".OnTick" },
		{ 16, ".OnLateTick" },
		{ 8, ".OnTickWithGroup" },
		{ 32, ".OnTick" }
	};

	private static Dictionary<int, Dictionary<string, int>> sProfileTagStatIdDic = new Dictionary<int, Dictionary<string, int>>
	{
		{ 4, sTickProfileStatIdDic },
		{ 16, sLateTickProfileStatIdDic },
		{ 32, sUITickProfileStatIdDic }
	};

	public static void RegisterTickGroupMaskDic(int TickGroup, string TickGroupMaskName)
	{
		if (!sTickGroupMaskDic.ContainsKey(TickGroup))
		{
			sTickGroupMaskDic.Add(TickGroup, TickGroupMaskName);
		}
	}

	[Conditional("WITH_PROFILE")]
	public static void ProfileBegin(string Name, int ProfileTag = 1)
	{
		SProfileTag.Push(ProfileTag);
		SProfileName.Push(Name);
		if (!sOpenProfiler || (sProfileTagFilter & ProfileTag) == 0)
		{
			return;
		}
		ProfileCount++;
		if (sProfileTagName.TryGetValue(ProfileTag, out var value))
		{
			Dictionary<string, int> dictionary = sProfileTagStatIdDic[ProfileTag];
			if (!dictionary.TryGetValue(Name, out var value2))
			{
				value2 = ProfilerFuncLib.CreateStatID(Name + value);
				dictionary.Add(Name, value2);
			}
			ProfilerFuncLib.BeginSampleWithStatID(value2);
		}
		else
		{
			if (!sProfileStatIdDic.TryGetValue(Name, out var value3))
			{
				value3 = ProfilerFuncLib.CreateStatID(Name);
				sProfileStatIdDic.Add(Name, value3);
			}
			ProfilerFuncLib.BeginSampleWithStatID(value3);
		}
	}

	[Conditional("WITH_PROFILE")]
	public static void ProfileEnd()
	{
		int num = SProfileTag.Pop();
		SProfileName.Pop();
		if (sOpenProfiler && (sProfileTagFilter & num) != 0)
		{
			ProfilerFuncLib.EndSample();
		}
	}

	[Conditional("WITH_PROFILE")]
	public static void ProfileBegin(string Name, int TickGroup, int ProfileTag)
	{
		SProfileTag.Push(ProfileTag);
		if (sOpenProfiler && (sProfileTagFilter & ProfileTag & 8) != 0 && sTickGroupMaskDic.TryGetValue(TickGroup, out var value))
		{
			int value3;
			if (!sTickWithGroupProfileStatIdDic.TryGetValue(Name, out var value2))
			{
				string statName = $"{Name}{sProfileTagName[8]}({value})";
				value3 = ProfilerFuncLib.CreateStatID(statName);
				value2 = new Dictionary<int, int>();
				value2.Add(TickGroup, value3);
				sTickWithGroupProfileStatIdDic.Add(Name, value2);
			}
			else if (!value2.TryGetValue(TickGroup, out value3))
			{
				string statName2 = $"{Name}{sProfileTagName[8]}({value})";
				value3 = ProfilerFuncLib.CreateStatID(statName2);
				value2.Add(TickGroup, value3);
			}
			ProfilerFuncLib.BeginSampleWithStatID(value3);
		}
	}
}
