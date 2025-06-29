using System;

namespace UnrealEngine.Runtime;

public class WaitForRealtime : ComparableYieldInstruction<WaitForRealtime>
{
	private TimeSpan startTime;

	private TimeSpan endTime;

	public override bool KeepWaiting => endTime > EngineLoop.Time;

	public TimeSpan Time { get; internal set; }

	public WaitForRealtime(TimeSpan time)
	{
		Time = time;
	}

	public override void OnBegin()
	{
		startTime = EngineLoop.Time;
		endTime = startTime + Time;
	}

	public override int CompareTo(WaitForRealtime other)
	{
		return endTime.CompareTo(other.endTime);
	}
}
