using System;
using System.Collections.Generic;

namespace b1;

public interface IBUC_TickRateData
{
	bool bEnableUROFromConfig { get; }

	bool bIsOptimizing { get; }

	float AccumulatedDeltaTime { get; }

	bool bTickEvenWhenPaused { get; }

	bool bDisableLineTraceOptimization { get; }

	bool TROHelper_CanTickThisFrame { get; }

	float TROHelper_DeltaTime { get; }

	IntervalDel<float, float, float, float, float, bool> FuncCanTickFor100msInterval { get; }

	IntervalDel<float, float, float, float, float, bool> FuncCanTickFor200msInterval { get; }

	IntervalDel<float, float, float, float, float, bool> FuncCanTickFor500msInterval { get; }

	IntervalDel<float, float, float, float, float, bool> FuncCanTickFor1000msInterval { get; }

	Func<bool> FuncCanTickFor1000Distance { get; }

	Func<bool> FuncCanTickFor3000Distance { get; }

	Func<bool> FuncCanTickFor6000Distance { get; }

	Func<bool> FuncCanTickFor10000Distance { get; }

	UnorderedDict<Func<bool>, IntervalDel<float, float, float, float, float, bool>> Funcs { get; }

	IntervalDel<float, float, float, float, float, bool> ElseIntervalFunc { get; }

	Dictionary<IntervalDel<float, float, float, float, float, bool>, int> IntervalDic { get; }

	bool CanTickFor100msInterval(out float AccumulatedDeltaTime, out float DifferenceTimeToLast100ms, out float DifferenceTimeToLast200ms, out float DifferenceTimeToLast500ms, out float DifferenceTimeToLast1000ms);

	bool CanTickFor200msInterval(out float AccumulatedDeltaTime, out float DifferenceTimeToLast100ms, out float DifferenceTimeToLast200ms, out float DifferenceTimeToLast500ms, out float DifferenceTimeToLast1000ms);

	bool CanTickFor500msInterval(out float AccumulatedDeltaTime, out float DifferenceTimeToLast100ms, out float DifferenceTimeToLast200ms, out float DifferenceTimeToLast500ms, out float DifferenceTimeToLast1000ms);

	bool CanTickFor1000msInterval(out float AccumulatedDeltaTime, out float DifferenceTimeToLast100ms, out float DifferenceTimeToLast200ms, out float DifferenceTimeToLast500msout, out float DifferenceTimeToLast1000ms);

	bool CanTickFor1000Distance();

	bool CanTickFor3000Distance();

	bool CanTickFor6000Distance();

	bool CanTickFor10000Distance();

	float GetDistanceToPlayer();
}
