using System;
using System.Collections.Generic;
using b1.ECS;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_TickRateData : IBUC_TickRateData, IPersistentECSData
{
	public bool bEnableUROLastFrame;

	public float CppTickCullDistance;

	public static BUC_TickRateData TRODisabledVersion = CreateTickRateData_TRODisabled;

	public static BUC_TickRateData TickDisabledVersion = CreateTickRateData_TickDisabled;

	public float TickInterval_100ms = FMath.RandRange(0f, 0.1f);

	public float TickInterval_200ms = FMath.RandRange(0f, 0.2f);

	public float TickInterval_500ms = FMath.RandRange(0f, 0.5f);

	public float TickInterval_1000ms = FMath.RandRange(0f, 1f);

	public float TickInterval_100ms_200;

	public float TickInterval_100ms_500;

	public float TickInterval_100ms_1000;

	public float TickInterval_200ms_100;

	public float TickInterval_200ms_500;

	public float TickInterval_200ms_1000;

	public float TickInterval_500ms_100;

	public float TickInterval_500ms_200;

	public float TickInterval_500ms_1000;

	public float TickInterval_1000ms_100;

	public float TickInterval_1000ms_200;

	public float TickInterval_1000ms_500;

	public bool bCanTickFor100ms;

	public bool bCanTickFor200ms;

	public bool bCanTickFor500ms;

	public bool bCanTickFor1000ms;

	public bool HasActivateOnceForOnLineTmp;

	public bool TROHelper_CanTickThisFrame { get; set; }

	public float TROHelper_DeltaTime { get; set; }

	public int Tick1000Count { get; set; }

	public bool bIsInTick { get; set; }

	public bool bIsPlayer { get; set; }

	public bool bTickEvenWhenPaused { get; set; }

	public bool bIsOnLine { get; set; }

	public bool bEnableUROFromConfig { get; set; }

	public bool bIsOptimizing { get; set; }

	public bool bDisableLineTraceOptimization { get; set; }

	public bool bCanTickForCS { get; set; }

	public float DistanceToPlayer { get; set; }

	public bool bWasLastOptimized { get; set; }

	public bool bNeedDisableEndPhysicsTick { get; set; }

	public float AccumulatedDeltaTime { get; set; }

	public float LocalScreenPercentageUpdateTimer { get; set; }

	public EUnitBodyType UnitBodyType { get; internal set; }

	private static BUC_TickRateData CreateTickRateData_TRODisabled => new BUC_TickRateData
	{
		AccumulatedDeltaTime = 0f
	};

	private static BUC_TickRateData CreateTickRateData_TickDisabled => new BUC_TickRateData
	{
		AccumulatedDeltaTime = -1f
	};

	public IntervalDel<float, float, float, float, float, bool> FuncCanTickFor100msInterval { get; set; }

	public IntervalDel<float, float, float, float, float, bool> FuncCanTickFor200msInterval { get; set; }

	public IntervalDel<float, float, float, float, float, bool> FuncCanTickFor500msInterval { get; set; }

	public IntervalDel<float, float, float, float, float, bool> FuncCanTickFor1000msInterval { get; set; }

	public Func<bool> FuncCanTickFor1000Distance { get; set; }

	public Func<bool> FuncCanTickFor3000Distance { get; set; }

	public Func<bool> FuncCanTickFor6000Distance { get; set; }

	public Func<bool> FuncCanTickFor10000Distance { get; set; }

	public UnorderedDict<Func<bool>, IntervalDel<float, float, float, float, float, bool>> Funcs { get; set; } = new UnorderedDict<Func<bool>, IntervalDel<float, float, float, float, float, bool>>();

	public IntervalDel<float, float, float, float, float, bool> ElseIntervalFunc { get; set; }

	public Dictionary<IntervalDel<float, float, float, float, float, bool>, int> IntervalDic { get; set; } = new Dictionary<IntervalDel<float, float, float, float, float, bool>, int>();

	public BUC_TickRateData()
	{
		FuncCanTickFor100msInterval = CanTickFor100msInterval;
		FuncCanTickFor200msInterval = CanTickFor200msInterval;
		FuncCanTickFor500msInterval = CanTickFor500msInterval;
		FuncCanTickFor1000msInterval = CanTickFor1000msInterval;
		FuncCanTickFor1000Distance = CanTickFor1000Distance;
		FuncCanTickFor3000Distance = CanTickFor3000Distance;
		FuncCanTickFor6000Distance = CanTickFor6000Distance;
		FuncCanTickFor10000Distance = CanTickFor10000Distance;
	}

	public void InitFuncs()
	{
		IntervalDic.Clear();
		IntervalDic.Add(FuncCanTickFor100msInterval, b1.TroDistanceByIntervalHelper.Interval100);
		IntervalDic.Add(FuncCanTickFor200msInterval, b1.TroDistanceByIntervalHelper.Interval200);
		IntervalDic.Add(FuncCanTickFor500msInterval, b1.TroDistanceByIntervalHelper.Interval500);
		IntervalDic.Add(FuncCanTickFor1000msInterval, b1.TroDistanceByIntervalHelper.Interval1000);
		Funcs.Clear();
		foreach (KeyValuePair<int, int> item in b1.TroDistanceByIntervalHelper.TROConfig.DistanceToIntervalDic)
		{
			if (item.Key == b1.TroDistanceByIntervalHelper.Distance1000)
			{
				if (item.Value == b1.TroDistanceByIntervalHelper.Interval100)
				{
					Funcs.Set(FuncCanTickFor1000Distance, FuncCanTickFor100msInterval);
				}
				else if (item.Value == b1.TroDistanceByIntervalHelper.Interval200)
				{
					Funcs.Set(FuncCanTickFor1000Distance, FuncCanTickFor200msInterval);
				}
				else if (item.Value == b1.TroDistanceByIntervalHelper.Interval500)
				{
					Funcs.Set(FuncCanTickFor1000Distance, FuncCanTickFor500msInterval);
				}
				else if (item.Value == b1.TroDistanceByIntervalHelper.Interval1000)
				{
					Funcs.Set(FuncCanTickFor1000Distance, FuncCanTickFor1000msInterval);
				}
				else if (item.Value == 0)
				{
					Funcs.Set(FuncCanTickFor1000Distance, null);
				}
			}
			else if (item.Key == b1.TroDistanceByIntervalHelper.Distance3000)
			{
				if (item.Value == b1.TroDistanceByIntervalHelper.Interval100)
				{
					Funcs.Set(FuncCanTickFor3000Distance, FuncCanTickFor100msInterval);
				}
				else if (item.Value == b1.TroDistanceByIntervalHelper.Interval200)
				{
					Funcs.Set(FuncCanTickFor3000Distance, FuncCanTickFor200msInterval);
				}
				else if (item.Value == b1.TroDistanceByIntervalHelper.Interval500)
				{
					Funcs.Set(FuncCanTickFor3000Distance, FuncCanTickFor500msInterval);
				}
				else if (item.Value == b1.TroDistanceByIntervalHelper.Interval1000)
				{
					Funcs.Set(FuncCanTickFor3000Distance, FuncCanTickFor1000msInterval);
				}
				else if (item.Value == 0)
				{
					Funcs.Set(FuncCanTickFor1000Distance, null);
				}
			}
			else if (item.Key == b1.TroDistanceByIntervalHelper.Distance6000)
			{
				if (item.Value == b1.TroDistanceByIntervalHelper.Interval100)
				{
					Funcs.Set(FuncCanTickFor6000Distance, FuncCanTickFor100msInterval);
				}
				else if (item.Value == b1.TroDistanceByIntervalHelper.Interval200)
				{
					Funcs.Set(FuncCanTickFor6000Distance, FuncCanTickFor200msInterval);
				}
				else if (item.Value == b1.TroDistanceByIntervalHelper.Interval500)
				{
					Funcs.Set(FuncCanTickFor6000Distance, FuncCanTickFor500msInterval);
				}
				else if (item.Value == b1.TroDistanceByIntervalHelper.Interval1000)
				{
					Funcs.Set(FuncCanTickFor6000Distance, FuncCanTickFor1000msInterval);
				}
				else if (item.Value == 0)
				{
					Funcs.Set(FuncCanTickFor1000Distance, null);
				}
			}
			else if (item.Key == b1.TroDistanceByIntervalHelper.Distance10000)
			{
				if (item.Value == b1.TroDistanceByIntervalHelper.Interval100)
				{
					Funcs.Set(FuncCanTickFor10000Distance, FuncCanTickFor100msInterval);
				}
				else if (item.Value == b1.TroDistanceByIntervalHelper.Interval200)
				{
					Funcs.Set(FuncCanTickFor10000Distance, FuncCanTickFor200msInterval);
				}
				else if (item.Value == b1.TroDistanceByIntervalHelper.Interval500)
				{
					Funcs.Set(FuncCanTickFor10000Distance, FuncCanTickFor500msInterval);
				}
				else if (item.Value == b1.TroDistanceByIntervalHelper.Interval1000)
				{
					Funcs.Set(FuncCanTickFor10000Distance, FuncCanTickFor1000msInterval);
				}
				else if (item.Value == 0)
				{
					Funcs.Set(FuncCanTickFor1000Distance, null);
				}
			}
		}
		int elseInterval = b1.TroDistanceByIntervalHelper.TROConfig.ElseInterval;
		if (elseInterval != 0)
		{
			if (elseInterval == b1.TroDistanceByIntervalHelper.Interval100)
			{
				ElseIntervalFunc = FuncCanTickFor100msInterval;
			}
			else if (elseInterval == b1.TroDistanceByIntervalHelper.Interval200)
			{
				ElseIntervalFunc = FuncCanTickFor200msInterval;
			}
			else if (elseInterval == b1.TroDistanceByIntervalHelper.Interval500)
			{
				ElseIntervalFunc = FuncCanTickFor500msInterval;
			}
			else if (elseInterval == b1.TroDistanceByIntervalHelper.Interval1000)
			{
				ElseIntervalFunc = FuncCanTickFor1000msInterval;
			}
		}
	}

	public bool CanTickFor100msInterval(out float AccumulatedDeltaTime, out float DifferenceTimeToLast100ms, out float DifferenceTimeToLast200ms, out float DifferenceTimeToLast500ms, out float DifferenceTimeToLast1000ms)
	{
		AccumulatedDeltaTime = TickInterval_100ms;
		DifferenceTimeToLast100ms = 0f;
		DifferenceTimeToLast200ms = TickInterval_100ms_200;
		DifferenceTimeToLast500ms = TickInterval_100ms_500;
		DifferenceTimeToLast1000ms = TickInterval_100ms_1000;
		return bCanTickFor100ms;
	}

	public bool CanTickFor200msInterval(out float AccumulatedDeltaTime, out float DifferenceTimeToLast100ms, out float DifferenceTimeToLast200ms, out float DifferenceTimeToLast500ms, out float DifferenceTimeToLast1000ms)
	{
		AccumulatedDeltaTime = TickInterval_200ms;
		DifferenceTimeToLast100ms = TickInterval_200ms_100;
		DifferenceTimeToLast200ms = 0f;
		DifferenceTimeToLast500ms = TickInterval_200ms_500;
		DifferenceTimeToLast1000ms = TickInterval_200ms_1000;
		return bCanTickFor200ms;
	}

	public bool CanTickFor500msInterval(out float AccumulatedDeltaTime, out float DifferenceTimeToLast100ms, out float DifferenceTimeToLast200ms, out float DifferenceTimeToLast500ms, out float DifferenceTimeToLast1000ms)
	{
		AccumulatedDeltaTime = TickInterval_500ms;
		DifferenceTimeToLast100ms = TickInterval_500ms_100;
		DifferenceTimeToLast200ms = TickInterval_500ms_200;
		DifferenceTimeToLast500ms = 0f;
		DifferenceTimeToLast1000ms = TickInterval_500ms_1000;
		return bCanTickFor500ms;
	}

	public bool CanTickFor1000msInterval(out float AccumulatedDeltaTime, out float DifferenceTimeToLast100ms, out float DifferenceTimeToLast200ms, out float DifferenceTimeToLast500ms, out float DifferenceTimeToLast1000ms)
	{
		AccumulatedDeltaTime = TickInterval_1000ms;
		DifferenceTimeToLast100ms = TickInterval_1000ms_100;
		DifferenceTimeToLast200ms = TickInterval_1000ms_200;
		DifferenceTimeToLast500ms = TickInterval_1000ms_500;
		DifferenceTimeToLast1000ms = 0f;
		return bCanTickFor1000ms;
	}

	public bool CanTickFor1000Distance()
	{
		return DistanceToPlayer < 1000f;
	}

	public bool CanTickFor3000Distance()
	{
		return DistanceToPlayer < 3000f;
	}

	public bool CanTickFor6000Distance()
	{
		return DistanceToPlayer < 6000f;
	}

	public bool CanTickFor10000Distance()
	{
		return DistanceToPlayer < 10000f;
	}

	public float GetDistanceToPlayer()
	{
		return DistanceToPlayer;
	}
}
