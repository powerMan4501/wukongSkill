using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Net;

[FriendAccessAllowed]
internal class RtcState
{
	[FriendAccessAllowed]
	internal enum ControlChannelTriggerStatus
	{
		Invalid,
		SoftwareSlotAllocated,
		HardwareSlotAllocated,
		PolicyError,
		SystemError,
		TransportDisconnected,
		ServiceUnavailable
	}

	internal byte[] inputData;

	internal byte[] outputData;

	internal ManualResetEvent connectComplete;

	internal ManualResetEvent flushComplete;

	internal int result;

	private int isAborted;

	internal bool IsAborted => isAborted != 0;

	internal RtcState()
	{
		connectComplete = new ManualResetEvent(initialState: false);
		flushComplete = new ManualResetEvent(initialState: false);
	}

	internal void Abort()
	{
		Interlocked.Exchange(ref isAborted, 1);
		connectComplete.Set();
		flushComplete.Set();
	}

	internal bool IsEnabled()
	{
		ControlChannelTriggerStatus controlChannelTriggerStatus = (ControlChannelTriggerStatus)BitConverter.ToInt32(outputData, 0);
		if (result == 0)
		{
			if (controlChannelTriggerStatus != ControlChannelTriggerStatus.SoftwareSlotAllocated)
			{
				return controlChannelTriggerStatus == ControlChannelTriggerStatus.HardwareSlotAllocated;
			}
			return true;
		}
		return false;
	}
}
