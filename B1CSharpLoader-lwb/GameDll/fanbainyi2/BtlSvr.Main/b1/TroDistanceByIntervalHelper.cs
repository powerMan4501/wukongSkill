using System;
using System.Collections.Generic;

namespace b1;

internal static class TroDistanceByIntervalHelper
{
	public static readonly int Distance1000 = 1000;

	public static readonly int Distance3000 = 3000;

	public static readonly int Distance6000 = 6000;

	public static readonly int Distance10000 = 10000;

	public static readonly int Interval100 = 100;

	public static readonly int Interval200 = 200;

	public static readonly int Interval500 = 500;

	public static readonly int Interval1000 = 1000;

	public static TroDistanceByIntervalConfig TROConfig = new TroDistanceByIntervalConfig(new Dictionary<int, int>
	{
		{ 1000, 100 },
		{ 3000, 200 },
		{ 6000, 500 },
		{ 10000, 1000 }
	}, 1000);

	public static bool EvaluateTick(float DeltaTime, IBUC_TickRateData TickRateData, ref int LastActiveInterval, ref bool bShouldAccumulateDeltaTimeNextFrame, ref float TimeToAccumulate, out float AccumulatedDeltaTime)
	{
		bool flag = false;
		AccumulatedDeltaTime = DeltaTime;
		TickRateData.Funcs.BeginItr();
		bool flag2 = false;
		Func<bool> oKey;
		IntervalDel<float, float, float, float, float, bool> oVal;
		while (TickRateData.Funcs.NextItr(out oKey, out oVal))
		{
			if (!oKey())
			{
				continue;
			}
			if (oVal == null)
			{
				flag = true;
				flag2 = true;
				break;
			}
			if (bShouldAccumulateDeltaTimeNextFrame)
			{
				TimeToAccumulate += DeltaTime;
			}
			flag = oVal(out var AccumulatedDeltaTime2, out var DifferenceTime, out var DifferenceTime2, out var DifferenceTime3, out var DifferenceTime4);
			if (flag)
			{
				if (bShouldAccumulateDeltaTimeNextFrame)
				{
					bShouldAccumulateDeltaTimeNextFrame = false;
					AccumulatedDeltaTime = TimeToAccumulate;
					TimeToAccumulate = 0f;
				}
				else if (LastActiveInterval != TickRateData.IntervalDic[oVal])
				{
					if (LastActiveInterval == Interval100)
					{
						AccumulatedDeltaTime = DifferenceTime;
					}
					else if (LastActiveInterval == Interval200)
					{
						AccumulatedDeltaTime = DifferenceTime2;
					}
					else if (LastActiveInterval == Interval500)
					{
						AccumulatedDeltaTime = DifferenceTime3;
					}
					else if (LastActiveInterval == Interval1000)
					{
						AccumulatedDeltaTime = DifferenceTime4;
					}
					LastActiveInterval = TickRateData.IntervalDic[oVal];
				}
				else
				{
					AccumulatedDeltaTime = AccumulatedDeltaTime2;
				}
			}
			flag2 = true;
			break;
		}
		if (!flag2)
		{
			if (TickRateData.ElseIntervalFunc != null)
			{
				flag = TickRateData.ElseIntervalFunc(out var AccumulatedDeltaTime3, out var DifferenceTime5, out var DifferenceTime6, out var DifferenceTime7, out var DifferenceTime8);
				if (flag)
				{
					if (LastActiveInterval != TickRateData.IntervalDic[TickRateData.ElseIntervalFunc])
					{
						if (LastActiveInterval == Interval100)
						{
							AccumulatedDeltaTime = DifferenceTime5;
						}
						else if (LastActiveInterval == Interval200)
						{
							AccumulatedDeltaTime = DifferenceTime6;
						}
						else if (LastActiveInterval == Interval500)
						{
							AccumulatedDeltaTime = DifferenceTime7;
						}
						else if (LastActiveInterval == Interval1000)
						{
							AccumulatedDeltaTime = DifferenceTime8;
						}
						LastActiveInterval = TickRateData.IntervalDic[TickRateData.ElseIntervalFunc];
					}
					else
					{
						AccumulatedDeltaTime = AccumulatedDeltaTime3;
					}
				}
			}
			else
			{
				LastActiveInterval = 0;
				bShouldAccumulateDeltaTimeNextFrame = true;
			}
		}
		return flag;
	}
}
