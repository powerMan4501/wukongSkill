using System.Security;

namespace System.Threading;

internal static class ThreadPoolGlobals
{
	public static uint tpQuantum;

	public static int processorCount;

	public static bool tpHosted;

	public static volatile bool vmTpInitialized;

	public static bool enableWorkerTracking;

	[SecurityCritical]
	public static ThreadPoolWorkQueue workQueue;

	[SecuritySafeCritical]
	static ThreadPoolGlobals()
	{
		tpQuantum = 30u;
		processorCount = Environment.ProcessorCount;
		tpHosted = ThreadPool.IsThreadPoolHosted();
		workQueue = new ThreadPoolWorkQueue();
	}
}
