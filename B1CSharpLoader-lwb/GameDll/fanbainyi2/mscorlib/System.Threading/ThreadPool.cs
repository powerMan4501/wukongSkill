using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security;
using System.Security.Permissions;

namespace System.Threading;

[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public static class ThreadPool
{
	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public static bool SetMaxThreads(int workerThreads, int completionPortThreads)
	{
		return SetMaxThreadsNative(workerThreads, completionPortThreads);
	}

	[SecuritySafeCritical]
	public static void GetMaxThreads(out int workerThreads, out int completionPortThreads)
	{
		GetMaxThreadsNative(out workerThreads, out completionPortThreads);
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public static bool SetMinThreads(int workerThreads, int completionPortThreads)
	{
		return SetMinThreadsNative(workerThreads, completionPortThreads);
	}

	[SecuritySafeCritical]
	public static void GetMinThreads(out int workerThreads, out int completionPortThreads)
	{
		GetMinThreadsNative(out workerThreads, out completionPortThreads);
	}

	[SecuritySafeCritical]
	public static void GetAvailableThreads(out int workerThreads, out int completionPortThreads)
	{
		GetAvailableThreadsNative(out workerThreads, out completionPortThreads);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[CLSCompliant(false)]
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RegisterWaitForSingleObject(waitObject, callBack, state, millisecondsTimeOutInterval, executeOnlyOnce, ref stackMark, compressStack: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	[CLSCompliant(false)]
	public static RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RegisterWaitForSingleObject(waitObject, callBack, state, millisecondsTimeOutInterval, executeOnlyOnce, ref stackMark, compressStack: false);
	}

	[SecurityCritical]
	private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack)
	{
		if (RemotingServices.IsTransparentProxy(waitObject))
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_WaitOnTransparentProxy"));
		}
		RegisteredWaitHandle registeredWaitHandle = new RegisteredWaitHandle();
		if (callBack != null)
		{
			_ThreadPoolWaitOrTimerCallback threadPoolWaitOrTimerCallback = new _ThreadPoolWaitOrTimerCallback(callBack, state, compressStack, ref stackMark);
			state = threadPoolWaitOrTimerCallback;
			registeredWaitHandle.SetWaitObject(waitObject);
			IntPtr handle = RegisterWaitForSingleObjectNative(waitObject, state, millisecondsTimeOutInterval, executeOnlyOnce, registeredWaitHandle, ref stackMark, compressStack);
			registeredWaitHandle.SetHandle(handle);
			return registeredWaitHandle;
		}
		throw new ArgumentNullException("WaitOrTimerCallback");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce)
	{
		if (millisecondsTimeOutInterval < -1)
		{
			throw new ArgumentOutOfRangeException("millisecondsTimeOutInterval", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RegisterWaitForSingleObject(waitObject, callBack, state, (uint)millisecondsTimeOutInterval, executeOnlyOnce, ref stackMark, compressStack: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	public static RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce)
	{
		if (millisecondsTimeOutInterval < -1)
		{
			throw new ArgumentOutOfRangeException("millisecondsTimeOutInterval", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RegisterWaitForSingleObject(waitObject, callBack, state, (uint)millisecondsTimeOutInterval, executeOnlyOnce, ref stackMark, compressStack: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, long millisecondsTimeOutInterval, bool executeOnlyOnce)
	{
		if (millisecondsTimeOutInterval < -1)
		{
			throw new ArgumentOutOfRangeException("millisecondsTimeOutInterval", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RegisterWaitForSingleObject(waitObject, callBack, state, (uint)millisecondsTimeOutInterval, executeOnlyOnce, ref stackMark, compressStack: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	public static RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, long millisecondsTimeOutInterval, bool executeOnlyOnce)
	{
		if (millisecondsTimeOutInterval < -1)
		{
			throw new ArgumentOutOfRangeException("millisecondsTimeOutInterval", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RegisterWaitForSingleObject(waitObject, callBack, state, (uint)millisecondsTimeOutInterval, executeOnlyOnce, ref stackMark, compressStack: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce)
	{
		long num = (long)timeout.TotalMilliseconds;
		if (num < -1)
		{
			throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		if (num > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("ArgumentOutOfRange_LessEqualToIntegerMaxVal"));
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RegisterWaitForSingleObject(waitObject, callBack, state, (uint)num, executeOnlyOnce, ref stackMark, compressStack: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	public static RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce)
	{
		long num = (long)timeout.TotalMilliseconds;
		if (num < -1)
		{
			throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		if (num > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("ArgumentOutOfRange_LessEqualToIntegerMaxVal"));
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RegisterWaitForSingleObject(waitObject, callBack, state, (uint)num, executeOnlyOnce, ref stackMark, compressStack: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static bool QueueUserWorkItem(WaitCallback callBack, object state)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return QueueUserWorkItemHelper(callBack, state, ref stackMark, compressStack: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static bool QueueUserWorkItem(WaitCallback callBack)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return QueueUserWorkItemHelper(callBack, null, ref stackMark, compressStack: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return QueueUserWorkItemHelper(callBack, state, ref stackMark, compressStack: false);
	}

	[SecurityCritical]
	private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, ref StackCrawlMark stackMark, bool compressStack)
	{
		bool flag = true;
		if (callBack != null)
		{
			EnsureVMInitialized();
			try
			{
			}
			finally
			{
				QueueUserWorkItemCallback callback = new QueueUserWorkItemCallback(callBack, state, compressStack, ref stackMark);
				ThreadPoolGlobals.workQueue.Enqueue(callback, forceGlobal: true);
				flag = true;
			}
			return flag;
		}
		throw new ArgumentNullException("WaitCallback");
	}

	[SecurityCritical]
	internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal)
	{
		EnsureVMInitialized();
		try
		{
		}
		finally
		{
			ThreadPoolGlobals.workQueue.Enqueue(workItem, forceGlobal);
		}
	}

	[SecurityCritical]
	internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem)
	{
		if (!ThreadPoolGlobals.vmTpInitialized)
		{
			return false;
		}
		return ThreadPoolGlobals.workQueue.LocalFindAndPop(workItem);
	}

	[SecurityCritical]
	internal static IEnumerable<IThreadPoolWorkItem> GetQueuedWorkItems()
	{
		return EnumerateQueuedWorkItems(ThreadPoolWorkQueue.allThreadQueues.Current, ThreadPoolGlobals.workQueue.queueTail);
	}

	internal static IEnumerable<IThreadPoolWorkItem> EnumerateQueuedWorkItems(ThreadPoolWorkQueue.WorkStealingQueue[] wsQueues, ThreadPoolWorkQueue.QueueSegment globalQueueTail)
	{
		if (wsQueues != null)
		{
			foreach (ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue in wsQueues)
			{
				if (workStealingQueue == null || workStealingQueue.m_array == null)
				{
					continue;
				}
				IThreadPoolWorkItem[] items = workStealingQueue.m_array;
				foreach (IThreadPoolWorkItem threadPoolWorkItem in items)
				{
					if (threadPoolWorkItem != null)
					{
						yield return threadPoolWorkItem;
					}
				}
			}
		}
		if (globalQueueTail == null)
		{
			yield break;
		}
		for (ThreadPoolWorkQueue.QueueSegment segment = globalQueueTail; segment != null; segment = segment.Next)
		{
			IThreadPoolWorkItem[] items = segment.nodes;
			foreach (IThreadPoolWorkItem threadPoolWorkItem2 in items)
			{
				if (threadPoolWorkItem2 != null)
				{
					yield return threadPoolWorkItem2;
				}
			}
		}
	}

	[SecurityCritical]
	internal static IEnumerable<IThreadPoolWorkItem> GetLocallyQueuedWorkItems()
	{
		return EnumerateQueuedWorkItems(new ThreadPoolWorkQueue.WorkStealingQueue[1] { ThreadPoolWorkQueueThreadLocals.threadLocals.workStealingQueue }, null);
	}

	[SecurityCritical]
	internal static IEnumerable<IThreadPoolWorkItem> GetGloballyQueuedWorkItems()
	{
		return EnumerateQueuedWorkItems(null, ThreadPoolGlobals.workQueue.queueTail);
	}

	private static object[] ToObjectArray(IEnumerable<IThreadPoolWorkItem> workitems)
	{
		int num = 0;
		foreach (IThreadPoolWorkItem workitem in workitems)
		{
			num++;
		}
		object[] array = new object[num];
		num = 0;
		foreach (IThreadPoolWorkItem workitem2 in workitems)
		{
			if (num < array.Length)
			{
				array[num] = workitem2;
			}
			num++;
		}
		return array;
	}

	[SecurityCritical]
	internal static object[] GetQueuedWorkItemsForDebugger()
	{
		return ToObjectArray(GetQueuedWorkItems());
	}

	[SecurityCritical]
	internal static object[] GetGloballyQueuedWorkItemsForDebugger()
	{
		return ToObjectArray(GetGloballyQueuedWorkItems());
	}

	[SecurityCritical]
	internal static object[] GetLocallyQueuedWorkItemsForDebugger()
	{
		return ToObjectArray(GetLocallyQueuedWorkItems());
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern bool RequestWorkerThread();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private unsafe static extern bool PostQueuedCompletionStatus(NativeOverlapped* overlapped);

	[SecurityCritical]
	[CLSCompliant(false)]
	public unsafe static bool UnsafeQueueNativeOverlapped(NativeOverlapped* overlapped)
	{
		return PostQueuedCompletionStatus(overlapped);
	}

	[SecurityCritical]
	private static void EnsureVMInitialized()
	{
		if (!ThreadPoolGlobals.vmTpInitialized)
		{
			InitializeVMTp(ref ThreadPoolGlobals.enableWorkerTracking);
			ThreadPoolGlobals.vmTpInitialized = true;
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern bool SetMinThreadsNative(int workerThreads, int completionPortThreads);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern bool SetMaxThreadsNative(int workerThreads, int completionPortThreads);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void GetMinThreadsNative(out int workerThreads, out int completionPortThreads);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void GetMaxThreadsNative(out int workerThreads, out int completionPortThreads);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void GetAvailableThreadsNative(out int workerThreads, out int completionPortThreads);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool NotifyWorkItemComplete();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void ReportThreadStatus(bool isWorking);

	[SecuritySafeCritical]
	internal static void NotifyWorkItemProgress()
	{
		if (!ThreadPoolGlobals.vmTpInitialized)
		{
			InitializeVMTp(ref ThreadPoolGlobals.enableWorkerTracking);
		}
		NotifyWorkItemProgressNative();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void NotifyWorkItemProgressNative();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool IsThreadPoolHosted();

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void InitializeVMTp(ref bool enableWorkerTracking);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern IntPtr RegisterWaitForSingleObjectNative(WaitHandle waitHandle, object state, uint timeOutInterval, bool executeOnlyOnce, RegisteredWaitHandle registeredWaitHandle, ref StackCrawlMark stackMark, bool compressStack);

	[SecuritySafeCritical]
	[Obsolete("ThreadPool.BindHandle(IntPtr) has been deprecated.  Please use ThreadPool.BindHandle(SafeHandle) instead.", false)]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public static bool BindHandle(IntPtr osHandle)
	{
		return BindIOCompletionCallbackNative(osHandle);
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public static bool BindHandle(SafeHandle osHandle)
	{
		if (osHandle == null)
		{
			throw new ArgumentNullException("osHandle");
		}
		bool flag = false;
		bool success = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			osHandle.DangerousAddRef(ref success);
			return BindIOCompletionCallbackNative(osHandle.DangerousGetHandle());
		}
		finally
		{
			if (success)
			{
				osHandle.DangerousRelease();
			}
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	private static extern bool BindIOCompletionCallbackNative(IntPtr fileHandle);
}
