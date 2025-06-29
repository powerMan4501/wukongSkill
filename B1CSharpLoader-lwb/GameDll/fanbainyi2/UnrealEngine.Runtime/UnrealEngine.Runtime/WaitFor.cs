using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class WaitFor : ComparableYieldInstruction<WaitFor>
{
	private float startTimeSeconds;

	private float endTimeSeconds;

	private IntPtr worldAddress;

	public override bool KeepWaiting => endTimeSeconds > WorldTimeHelper.GetTimeSecondsChecked(worldAddress);

	public TimeSpan Time { get; internal set; }

	public WaitFor(TimeSpan time)
	{
		Time = time;
	}

	public override void OnBegin()
	{
		UObject uObject = base.Owner.Owner as UObject;
		if (uObject != null && uObject.Address != IntPtr.Zero)
		{
			worldAddress = Native_UObject.GetWorld(uObject.Address);
		}
		startTimeSeconds = WorldTimeHelper.GetTimeSecondsChecked(worldAddress);
		endTimeSeconds = (float)((double)startTimeSeconds + Time.TotalSeconds);
	}

	public override int CompareTo(WaitFor other)
	{
		return endTimeSeconds.CompareTo(other.endTimeSeconds);
	}
}
