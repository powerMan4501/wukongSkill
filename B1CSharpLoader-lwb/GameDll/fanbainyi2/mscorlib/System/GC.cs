using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

namespace System;

[__DynamicallyInvokable]
public static class GC
{
	private enum StartNoGCRegionStatus
	{
		Succeeded,
		NotEnoughMemory,
		AmountTooLarge,
		AlreadyInProgress
	}

	private enum EndNoGCRegionStatus
	{
		Succeeded,
		NotInProgress,
		GCInduced,
		AllocationExceeded
	}

	[__DynamicallyInvokable]
	public static int MaxGeneration
	{
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get
		{
			return GetMaxGeneration();
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern int GetGCLatencyMode();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern int SetGCLatencyMode(int newLatencyMode);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern int _StartNoGCRegion(long totalSize, bool lohSizeKnown, long lohSize, bool disallowFullBlockingGC);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern int _EndNoGCRegion();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern int GetLOHCompactionMode();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void SetLOHCompactionMode(int newLOHCompactionyMode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern int GetGenerationWR(IntPtr handle);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern long GetTotalMemory();

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void _Collect(int generation, int mode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern int GetMaxGeneration();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static extern int _CollectionCount(int generation, int getSpecialGCCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool IsServerGC();

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void _AddMemoryPressure(ulong bytesAllocated);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void _RemoveMemoryPressure(ulong bytesAllocated);

	[SecurityCritical]
	[__DynamicallyInvokable]
	public static void AddMemoryPressure(long bytesAllocated)
	{
		if (bytesAllocated <= 0)
		{
			throw new ArgumentOutOfRangeException("bytesAllocated", Environment.GetResourceString("ArgumentOutOfRange_NeedPosNum"));
		}
		if (4 == IntPtr.Size && bytesAllocated > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("pressure", Environment.GetResourceString("ArgumentOutOfRange_MustBeNonNegInt32"));
		}
		_AddMemoryPressure((ulong)bytesAllocated);
	}

	[SecurityCritical]
	[__DynamicallyInvokable]
	public static void RemoveMemoryPressure(long bytesAllocated)
	{
		if (bytesAllocated <= 0)
		{
			throw new ArgumentOutOfRangeException("bytesAllocated", Environment.GetResourceString("ArgumentOutOfRange_NeedPosNum"));
		}
		if (4 == IntPtr.Size && bytesAllocated > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("bytesAllocated", Environment.GetResourceString("ArgumentOutOfRange_MustBeNonNegInt32"));
		}
		_RemoveMemoryPressure((ulong)bytesAllocated);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	public static extern int GetGeneration(object obj);

	[__DynamicallyInvokable]
	public static void Collect(int generation)
	{
		Collect(generation, GCCollectionMode.Default);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static void Collect()
	{
		_Collect(-1, 2);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static void Collect(int generation, GCCollectionMode mode)
	{
		Collect(generation, mode, blocking: true);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static void Collect(int generation, GCCollectionMode mode, bool blocking)
	{
		Collect(generation, mode, blocking, compacting: false);
	}

	[SecuritySafeCritical]
	public static void Collect(int generation, GCCollectionMode mode, bool blocking, bool compacting)
	{
		if (generation < 0)
		{
			throw new ArgumentOutOfRangeException("generation", Environment.GetResourceString("ArgumentOutOfRange_GenericPositive"));
		}
		if (mode < GCCollectionMode.Default || mode > GCCollectionMode.Optimized)
		{
			throw new ArgumentOutOfRangeException(Environment.GetResourceString("ArgumentOutOfRange_Enum"));
		}
		int num = 0;
		if (mode == GCCollectionMode.Optimized)
		{
			num |= 4;
		}
		if (compacting)
		{
			num |= 8;
		}
		if (blocking)
		{
			num |= 2;
		}
		else if (!compacting)
		{
			num |= 1;
		}
		_Collect(generation, num);
	}

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[__DynamicallyInvokable]
	public static int CollectionCount(int generation)
	{
		if (generation < 0)
		{
			throw new ArgumentOutOfRangeException("generation", Environment.GetResourceString("ArgumentOutOfRange_GenericPositive"));
		}
		return _CollectionCount(generation, 0);
	}

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static int CollectionCount(int generation, bool getSpecialGCCount)
	{
		if (generation < 0)
		{
			throw new ArgumentOutOfRangeException("generation", Environment.GetResourceString("ArgumentOutOfRange_GenericPositive"));
		}
		return _CollectionCount(generation, getSpecialGCCount ? 1 : 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[__DynamicallyInvokable]
	public static void KeepAlive(object obj)
	{
	}

	[SecuritySafeCritical]
	public static int GetGeneration(WeakReference wo)
	{
		int generationWR = GetGenerationWR(wo.m_handle);
		KeepAlive(wo);
		return generationWR;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void _WaitForPendingFinalizers();

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static void WaitForPendingFinalizers()
	{
		_WaitForPendingFinalizers();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static extern void _SuppressFinalize(object o);

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[__DynamicallyInvokable]
	public static void SuppressFinalize(object obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		_SuppressFinalize(obj);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void _ReRegisterForFinalize(object o);

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static void ReRegisterForFinalize(object obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		_ReRegisterForFinalize(obj);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static long GetTotalMemory(bool forceFullCollection)
	{
		long totalMemory = GetTotalMemory();
		if (!forceFullCollection)
		{
			return totalMemory;
		}
		int num = 20;
		long num2 = totalMemory;
		float num3;
		do
		{
			WaitForPendingFinalizers();
			Collect();
			totalMemory = num2;
			num2 = GetTotalMemory();
			num3 = (float)(num2 - totalMemory) / (float)totalMemory;
		}
		while (num-- > 0 && (!(-0.05 < (double)num3) || !((double)num3 < 0.05)));
		return num2;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern long _GetAllocatedBytesForCurrentThread();

	[SecuritySafeCritical]
	public static long GetAllocatedBytesForCurrentThread()
	{
		return _GetAllocatedBytesForCurrentThread();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern bool _RegisterForFullGCNotification(int maxGenerationPercentage, int largeObjectHeapPercentage);

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern bool _CancelFullGCNotification();

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern int _WaitForFullGCApproach(int millisecondsTimeout);

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern int _WaitForFullGCComplete(int millisecondsTimeout);

	[SecurityCritical]
	public static void RegisterForFullGCNotification(int maxGenerationThreshold, int largeObjectHeapThreshold)
	{
		if (maxGenerationThreshold <= 0 || maxGenerationThreshold >= 100)
		{
			throw new ArgumentOutOfRangeException("maxGenerationThreshold", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("ArgumentOutOfRange_Bounds_Lower_Upper"), 1, 99));
		}
		if (largeObjectHeapThreshold <= 0 || largeObjectHeapThreshold >= 100)
		{
			throw new ArgumentOutOfRangeException("largeObjectHeapThreshold", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("ArgumentOutOfRange_Bounds_Lower_Upper"), 1, 99));
		}
		if (!_RegisterForFullGCNotification(maxGenerationThreshold, largeObjectHeapThreshold))
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NotWithConcurrentGC"));
		}
	}

	[SecurityCritical]
	public static void CancelFullGCNotification()
	{
		if (!_CancelFullGCNotification())
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NotWithConcurrentGC"));
		}
	}

	[SecurityCritical]
	public static GCNotificationStatus WaitForFullGCApproach()
	{
		return (GCNotificationStatus)_WaitForFullGCApproach(-1);
	}

	[SecurityCritical]
	public static GCNotificationStatus WaitForFullGCApproach(int millisecondsTimeout)
	{
		if (millisecondsTimeout < -1)
		{
			throw new ArgumentOutOfRangeException("millisecondsTimeout", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		return (GCNotificationStatus)_WaitForFullGCApproach(millisecondsTimeout);
	}

	[SecurityCritical]
	public static GCNotificationStatus WaitForFullGCComplete()
	{
		return (GCNotificationStatus)_WaitForFullGCComplete(-1);
	}

	[SecurityCritical]
	public static GCNotificationStatus WaitForFullGCComplete(int millisecondsTimeout)
	{
		if (millisecondsTimeout < -1)
		{
			throw new ArgumentOutOfRangeException("millisecondsTimeout", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		return (GCNotificationStatus)_WaitForFullGCComplete(millisecondsTimeout);
	}

	[SecurityCritical]
	private static bool StartNoGCRegionWorker(long totalSize, bool hasLohSize, long lohSize, bool disallowFullBlockingGC)
	{
		return (StartNoGCRegionStatus)_StartNoGCRegion(totalSize, hasLohSize, lohSize, disallowFullBlockingGC) switch
		{
			StartNoGCRegionStatus.AmountTooLarge => throw new ArgumentOutOfRangeException("totalSize", "totalSize is too large. For more information about setting the maximum size, see \"Latency Modes\" in http://go.microsoft.com/fwlink/?LinkId=522706"), 
			StartNoGCRegionStatus.AlreadyInProgress => throw new InvalidOperationException("The NoGCRegion mode was already in progress"), 
			StartNoGCRegionStatus.NotEnoughMemory => false, 
			_ => true, 
		};
	}

	[SecurityCritical]
	public static bool TryStartNoGCRegion(long totalSize)
	{
		return StartNoGCRegionWorker(totalSize, hasLohSize: false, 0L, disallowFullBlockingGC: false);
	}

	[SecurityCritical]
	public static bool TryStartNoGCRegion(long totalSize, long lohSize)
	{
		return StartNoGCRegionWorker(totalSize, hasLohSize: true, lohSize, disallowFullBlockingGC: false);
	}

	[SecurityCritical]
	public static bool TryStartNoGCRegion(long totalSize, bool disallowFullBlockingGC)
	{
		return StartNoGCRegionWorker(totalSize, hasLohSize: false, 0L, disallowFullBlockingGC);
	}

	[SecurityCritical]
	public static bool TryStartNoGCRegion(long totalSize, long lohSize, bool disallowFullBlockingGC)
	{
		return StartNoGCRegionWorker(totalSize, hasLohSize: true, lohSize, disallowFullBlockingGC);
	}

	[SecurityCritical]
	private static EndNoGCRegionStatus EndNoGCRegionWorker()
	{
		return (EndNoGCRegionStatus)_EndNoGCRegion() switch
		{
			EndNoGCRegionStatus.NotInProgress => throw new InvalidOperationException("NoGCRegion mode must be set"), 
			EndNoGCRegionStatus.GCInduced => throw new InvalidOperationException("Garbage collection was induced in NoGCRegion mode"), 
			EndNoGCRegionStatus.AllocationExceeded => throw new InvalidOperationException("Allocated memory exceeds specified memory for NoGCRegion mode"), 
			_ => EndNoGCRegionStatus.Succeeded, 
		};
	}

	[SecurityCritical]
	public static void EndNoGCRegion()
	{
		EndNoGCRegionWorker();
	}
}
