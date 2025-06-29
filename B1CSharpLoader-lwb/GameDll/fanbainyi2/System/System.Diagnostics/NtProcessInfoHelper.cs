using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32;

namespace System.Diagnostics;

internal static class NtProcessInfoHelper
{
	[StructLayout(LayoutKind.Sequential)]
	internal class SystemProcessInformation
	{
		internal uint NextEntryOffset;

		internal uint NumberOfThreads;

		private long SpareLi1;

		private long SpareLi2;

		private long SpareLi3;

		private long CreateTime;

		private long UserTime;

		private long KernelTime;

		internal ushort NameLength;

		internal ushort MaximumNameLength;

		internal IntPtr NamePtr;

		internal int BasePriority;

		internal IntPtr UniqueProcessId;

		internal IntPtr InheritedFromUniqueProcessId;

		internal uint HandleCount;

		internal uint SessionId;

		internal UIntPtr PageDirectoryBase;

		internal UIntPtr PeakVirtualSize;

		internal UIntPtr VirtualSize;

		internal uint PageFaultCount;

		internal UIntPtr PeakWorkingSetSize;

		internal UIntPtr WorkingSetSize;

		internal UIntPtr QuotaPeakPagedPoolUsage;

		internal UIntPtr QuotaPagedPoolUsage;

		internal UIntPtr QuotaPeakNonPagedPoolUsage;

		internal UIntPtr QuotaNonPagedPoolUsage;

		internal UIntPtr PagefileUsage;

		internal UIntPtr PeakPagefileUsage;

		internal UIntPtr PrivatePageCount;

		private long ReadOperationCount;

		private long WriteOperationCount;

		private long OtherOperationCount;

		private long ReadTransferCount;

		private long WriteTransferCount;

		private long OtherTransferCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal class SystemThreadInformation
	{
		private long KernelTime;

		private long UserTime;

		private long CreateTime;

		private uint WaitTime;

		internal IntPtr StartAddress;

		internal IntPtr UniqueProcess;

		internal IntPtr UniqueThread;

		internal int Priority;

		internal int BasePriority;

		internal uint ContextSwitches;

		internal uint ThreadState;

		internal uint WaitReason;
	}

	private const int DefaultCachedBufferSize = 131072;

	private static long[] CachedBuffer;

	private static int GetNewBufferSize(int existingBufferSize, int requiredSize)
	{
		if (requiredSize == 0)
		{
			int num = existingBufferSize * 2;
			if (num < existingBufferSize)
			{
				throw new OutOfMemoryException();
			}
			return num;
		}
		int num2 = requiredSize + 10240;
		if (num2 < requiredSize)
		{
			throw new OutOfMemoryException();
		}
		return num2;
	}

	public static ProcessInfo[] GetProcessInfos(Predicate<int> processIdFilter = null)
	{
		int returnedSize = 0;
		GCHandle gCHandle = default(GCHandle);
		int num = 131072;
		long[] array = Interlocked.Exchange(ref CachedBuffer, null);
		try
		{
			int num2;
			do
			{
				if (array == null)
				{
					array = new long[(num + 7) / 8];
				}
				else
				{
					num = array.Length * 8;
				}
				gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
				num2 = Microsoft.Win32.NativeMethods.NtQuerySystemInformation(5, gCHandle.AddrOfPinnedObject(), num, out returnedSize);
				if (num2 == -1073741820)
				{
					if (gCHandle.IsAllocated)
					{
						gCHandle.Free();
					}
					array = null;
					num = GetNewBufferSize(num, returnedSize);
				}
			}
			while (num2 == -1073741820);
			if (num2 < 0)
			{
				throw new InvalidOperationException(SR.GetString("CouldntGetProcessInfos"), new Win32Exception(num2));
			}
			return GetProcessInfos(gCHandle.AddrOfPinnedObject(), processIdFilter);
		}
		finally
		{
			Interlocked.Exchange(ref CachedBuffer, array);
			if (gCHandle.IsAllocated)
			{
				gCHandle.Free();
			}
		}
	}

	private static ProcessInfo[] GetProcessInfos(IntPtr dataPtr, Predicate<int> processIdFilter)
	{
		Hashtable hashtable = new Hashtable(60);
		long num = 0L;
		while (true)
		{
			IntPtr intPtr = (IntPtr)((long)dataPtr + num);
			SystemProcessInformation systemProcessInformation = new SystemProcessInformation();
			Marshal.PtrToStructure(intPtr, (object)systemProcessInformation);
			int num2 = systemProcessInformation.UniqueProcessId.ToInt32();
			if (processIdFilter == null || processIdFilter(num2))
			{
				ProcessInfo processInfo = new ProcessInfo();
				processInfo.processId = num2;
				processInfo.handleCount = (int)systemProcessInformation.HandleCount;
				processInfo.sessionId = (int)systemProcessInformation.SessionId;
				processInfo.poolPagedBytes = (long)(ulong)systemProcessInformation.QuotaPagedPoolUsage;
				processInfo.poolNonpagedBytes = (long)(ulong)systemProcessInformation.QuotaNonPagedPoolUsage;
				processInfo.virtualBytes = (long)(ulong)systemProcessInformation.VirtualSize;
				processInfo.virtualBytesPeak = (long)(ulong)systemProcessInformation.PeakVirtualSize;
				processInfo.workingSetPeak = (long)(ulong)systemProcessInformation.PeakWorkingSetSize;
				processInfo.workingSet = (long)(ulong)systemProcessInformation.WorkingSetSize;
				processInfo.pageFileBytesPeak = (long)(ulong)systemProcessInformation.PeakPagefileUsage;
				processInfo.pageFileBytes = (long)(ulong)systemProcessInformation.PagefileUsage;
				processInfo.privateBytes = (long)(ulong)systemProcessInformation.PrivatePageCount;
				processInfo.basePriority = systemProcessInformation.BasePriority;
				if (systemProcessInformation.NamePtr == IntPtr.Zero)
				{
					if (processInfo.processId == NtProcessManager.SystemProcessID)
					{
						processInfo.processName = "System";
					}
					else if (processInfo.processId == 0)
					{
						processInfo.processName = "Idle";
					}
					else
					{
						processInfo.processName = processInfo.processId.ToString(CultureInfo.InvariantCulture);
					}
				}
				else
				{
					string text = GetProcessShortName(Marshal.PtrToStringUni(systemProcessInformation.NamePtr, systemProcessInformation.NameLength / 2));
					if (ProcessManager.IsOSOlderThanXP && text.Length == 15)
					{
						if (text.EndsWith(".", StringComparison.OrdinalIgnoreCase))
						{
							text = text.Substring(0, 14);
						}
						else if (text.EndsWith(".e", StringComparison.OrdinalIgnoreCase))
						{
							text = text.Substring(0, 13);
						}
						else if (text.EndsWith(".ex", StringComparison.OrdinalIgnoreCase))
						{
							text = text.Substring(0, 12);
						}
					}
					processInfo.processName = text;
				}
				hashtable[processInfo.processId] = processInfo;
				intPtr = (IntPtr)((long)intPtr + Marshal.SizeOf((object)systemProcessInformation));
				for (int i = 0; i < systemProcessInformation.NumberOfThreads; i++)
				{
					SystemThreadInformation systemThreadInformation = new SystemThreadInformation();
					Marshal.PtrToStructure(intPtr, (object)systemThreadInformation);
					ThreadInfo threadInfo = new ThreadInfo();
					threadInfo.processId = (int)systemThreadInformation.UniqueProcess;
					threadInfo.threadId = (int)systemThreadInformation.UniqueThread;
					threadInfo.basePriority = systemThreadInformation.BasePriority;
					threadInfo.currentPriority = systemThreadInformation.Priority;
					threadInfo.startAddress = systemThreadInformation.StartAddress;
					threadInfo.threadState = (ThreadState)systemThreadInformation.ThreadState;
					threadInfo.threadWaitReason = NtProcessManager.GetThreadWaitReason((int)systemThreadInformation.WaitReason);
					processInfo.threadInfoList.Add(threadInfo);
					intPtr = (IntPtr)((long)intPtr + Marshal.SizeOf((object)systemThreadInformation));
				}
			}
			if (systemProcessInformation.NextEntryOffset == 0)
			{
				break;
			}
			num += systemProcessInformation.NextEntryOffset;
		}
		ProcessInfo[] array = new ProcessInfo[hashtable.Values.Count];
		hashtable.Values.CopyTo(array, 0);
		return array;
	}

	internal static string GetProcessShortName(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			return string.Empty;
		}
		int num = -1;
		int num2 = -1;
		for (int i = 0; i < name.Length; i++)
		{
			if (name[i] == '\\')
			{
				num = i;
			}
			else if (name[i] == '.')
			{
				num2 = i;
			}
		}
		if (num2 == -1)
		{
			num2 = name.Length - 1;
		}
		else
		{
			string b = name.Substring(num2);
			num2 = ((!string.Equals(".exe", b, StringComparison.OrdinalIgnoreCase)) ? (name.Length - 1) : (num2 - 1));
		}
		num = ((num != -1) ? (num + 1) : 0);
		return name.Substring(num, num2 - num + 1);
	}
}
