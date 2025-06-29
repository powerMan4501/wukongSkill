using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Util;

public class GSETimeUtil
{
	private static bool IsNeedTimeMark = false;

	private static bool IsNeedTimeMarkStep = false;

	private static Stack<Tuple<int, string>> TimeMarkData = new Stack<Tuple<int, string>>();

	private static Stack<Tuple<int, string>> TimeMarkStepData = new Stack<Tuple<int, string>>();

	public static int GetTimeMarkInUS()
	{
		UGameplayStatics.GetAccurateRealTime(out var Seconds, out var PartialSeconds);
		return (int)(((float)(Seconds % 100) + PartialSeconds) * 1000000f);
	}

	public static float GetCurrentTime(UObject uObject)
	{
		return UGameplayStatics.GetTimeSeconds(uObject);
	}

	[Conditional("DEBUG")]
	public static void ESetTimeMarkCtrl(bool _IsNeedTimeMarkStep, bool _IsNeedTimeMark)
	{
		IsNeedTimeMark = _IsNeedTimeMark;
		IsNeedTimeMarkStep = _IsNeedTimeMarkStep;
	}

	[Conditional("DEBUG")]
	public static void ETimeMarkStep(string StepName)
	{
		if (DebugConfig.SimTimeMarkStep)
		{
			int timeMarkInUS = GetTimeMarkInUS();
			TimeMarkStepData.Push(new Tuple<int, string>(timeMarkInUS, StepName));
		}
	}

	[Conditional("DEBUG")]
	public static void ETimeMarkStepManualEnd(int TimeMarkUs = 0)
	{
		if (DebugConfig.SimTimeMarkStep)
		{
			if (TimeMarkUs == 0)
			{
				TimeMarkUs = GetTimeMarkInUS();
			}
			if (TimeMarkStepData.Count != 0)
			{
				Tuple<int, string> tuple = TimeMarkStepData.Pop();
				_ = tuple.Item1;
			}
		}
	}

	[Conditional("DEBUG")]
	public static void ETimeMarkStart(string TimeMarkName)
	{
		if (DebugConfig.SimTimeMarkBase)
		{
			int timeMarkInUS = GetTimeMarkInUS();
			TimeMarkData.Push(new Tuple<int, string>(timeMarkInUS, TimeMarkName));
		}
	}

	[Conditional("DEBUG")]
	public static void ETimeMarkEnd()
	{
		if (DebugConfig.SimTimeMarkBase)
		{
			int timeMarkInUS = GetTimeMarkInUS();
			if (TimeMarkData.Count > 0)
			{
				Tuple<int, string> tuple = TimeMarkData.Pop();
				_ = tuple.Item1;
			}
		}
	}
}
