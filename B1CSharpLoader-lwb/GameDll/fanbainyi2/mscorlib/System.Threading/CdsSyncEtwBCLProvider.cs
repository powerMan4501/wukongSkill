using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Threading;

[FriendAccessAllowed]
[EventSource(Name = "System.Threading.SynchronizationEventSource", Guid = "EC631D38-466B-4290-9306-834971BA0217", LocalizationResources = "mscorlib")]
internal sealed class CdsSyncEtwBCLProvider : EventSource
{
	public static CdsSyncEtwBCLProvider Log = new CdsSyncEtwBCLProvider();

	private const EventKeywords ALL_KEYWORDS = EventKeywords.All;

	private const int SPINLOCK_FASTPATHFAILED_ID = 1;

	private const int SPINWAIT_NEXTSPINWILLYIELD_ID = 2;

	private const int BARRIER_PHASEFINISHED_ID = 3;

	private CdsSyncEtwBCLProvider()
	{
	}

	[Event(1, Level = EventLevel.Warning)]
	public void SpinLock_FastPathFailed(int ownerID)
	{
		if (IsEnabled(EventLevel.Warning, EventKeywords.All))
		{
			WriteEvent(1, ownerID);
		}
	}

	[Event(2, Level = EventLevel.Informational)]
	public void SpinWait_NextSpinWillYield()
	{
		if (IsEnabled(EventLevel.Informational, EventKeywords.All))
		{
			WriteEvent(2);
		}
	}

	[SecuritySafeCritical]
	[Event(3, Level = EventLevel.Verbose, Version = 1)]
	public unsafe void Barrier_PhaseFinished(bool currentSense, long phaseNum)
	{
		if (IsEnabled(EventLevel.Verbose, EventKeywords.All))
		{
			EventData* ptr = stackalloc EventData[2];
			int num = (currentSense ? 1 : 0);
			ptr->Size = 4;
			ptr->DataPointer = (IntPtr)(&num);
			ptr[1].Size = 8;
			ptr[1].DataPointer = (IntPtr)(&phaseNum);
			WriteEventCore(3, 2, ptr);
		}
	}
}
