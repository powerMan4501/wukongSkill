using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Diagnostics;

internal static class NtProcessManager
{
	private enum ValueId
	{
		Unknown = -1,
		HandleCount,
		PoolPagedBytes,
		PoolNonpagedBytes,
		ElapsedTime,
		VirtualBytesPeak,
		VirtualBytes,
		PrivateBytes,
		PageFileBytes,
		PageFileBytesPeak,
		WorkingSetPeak,
		WorkingSet,
		ThreadId,
		ProcessId,
		BasePriority,
		CurrentPriority,
		UserTime,
		PrivilegedTime,
		StartAddress,
		ThreadState,
		ThreadWaitReason
	}

	private const int ProcessPerfCounterId = 230;

	private const int ThreadPerfCounterId = 232;

	private const string PerfCounterQueryString = "230 232";

	internal const int IdleProcessID = 0;

	private static Hashtable valueIds;

	internal static int SystemProcessID
	{
		get
		{
			if (ProcessManager.IsOSOlderThanXP)
			{
				return 8;
			}
			return 4;
		}
	}

	static NtProcessManager()
	{
		valueIds = new Hashtable();
		valueIds.Add("Handle Count", ValueId.HandleCount);
		valueIds.Add("Pool Paged Bytes", ValueId.PoolPagedBytes);
		valueIds.Add("Pool Nonpaged Bytes", ValueId.PoolNonpagedBytes);
		valueIds.Add("Elapsed Time", ValueId.ElapsedTime);
		valueIds.Add("Virtual Bytes Peak", ValueId.VirtualBytesPeak);
		valueIds.Add("Virtual Bytes", ValueId.VirtualBytes);
		valueIds.Add("Private Bytes", ValueId.PrivateBytes);
		valueIds.Add("Page File Bytes", ValueId.PageFileBytes);
		valueIds.Add("Page File Bytes Peak", ValueId.PageFileBytesPeak);
		valueIds.Add("Working Set Peak", ValueId.WorkingSetPeak);
		valueIds.Add("Working Set", ValueId.WorkingSet);
		valueIds.Add("ID Thread", ValueId.ThreadId);
		valueIds.Add("ID Process", ValueId.ProcessId);
		valueIds.Add("Priority Base", ValueId.BasePriority);
		valueIds.Add("Priority Current", ValueId.CurrentPriority);
		valueIds.Add("% User Time", ValueId.UserTime);
		valueIds.Add("% Privileged Time", ValueId.PrivilegedTime);
		valueIds.Add("Start Address", ValueId.StartAddress);
		valueIds.Add("Thread State", ValueId.ThreadState);
		valueIds.Add("Thread Wait Reason", ValueId.ThreadWaitReason);
	}

	public static int[] GetProcessIds(string machineName, bool isRemoteMachine)
	{
		ProcessInfo[] processInfos = GetProcessInfos(machineName, isRemoteMachine);
		int[] array = new int[processInfos.Length];
		for (int i = 0; i < processInfos.Length; i++)
		{
			array[i] = processInfos[i].processId;
		}
		return array;
	}

	public static int[] GetProcessIds()
	{
		int[] array = new int[256];
		int needed;
		while (true)
		{
			if (!Microsoft.Win32.NativeMethods.EnumProcesses(array, array.Length * 4, out needed))
			{
				throw new Win32Exception();
			}
			if (needed != array.Length * 4)
			{
				break;
			}
			array = new int[array.Length * 2];
		}
		int[] array2 = new int[needed / 4];
		Array.Copy(array, array2, array2.Length);
		return array2;
	}

	public static ModuleInfo[] GetModuleInfos(int processId)
	{
		return GetModuleInfos(processId, firstModuleOnly: false);
	}

	public static ModuleInfo GetFirstModuleInfo(int processId)
	{
		ModuleInfo[] moduleInfos = GetModuleInfos(processId, firstModuleOnly: true);
		if (moduleInfos.Length == 0)
		{
			return null;
		}
		return moduleInfos[0];
	}

	private static ModuleInfo[] GetModuleInfos(int processId, bool firstModuleOnly)
	{
		if (processId == SystemProcessID || processId == 0)
		{
			throw new Win32Exception(-2147467259, SR.GetString("EnumProcessModuleFailed"));
		}
		SafeProcessHandle safeProcessHandle = SafeProcessHandle.InvalidHandle;
		try
		{
			safeProcessHandle = ProcessManager.OpenProcess(processId, 1040, throwIfExited: true);
			IntPtr[] array = new IntPtr[64];
			GCHandle gCHandle = default(GCHandle);
			int needed = 0;
			while (true)
			{
				bool flag = false;
				try
				{
					gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
					flag = Microsoft.Win32.NativeMethods.EnumProcessModules(safeProcessHandle, gCHandle.AddrOfPinnedObject(), array.Length * IntPtr.Size, ref needed);
					if (!flag)
					{
						bool Wow64Process = false;
						bool Wow64Process2 = false;
						if (!ProcessManager.IsOSOlderThanXP)
						{
							SafeProcessHandle safeProcessHandle2 = SafeProcessHandle.InvalidHandle;
							try
							{
								safeProcessHandle2 = ProcessManager.OpenProcess(Microsoft.Win32.NativeMethods.GetCurrentProcessId(), 1024, throwIfExited: true);
								if (!Microsoft.Win32.SafeNativeMethods.IsWow64Process(safeProcessHandle2, ref Wow64Process))
								{
									throw new Win32Exception();
								}
								if (!Microsoft.Win32.SafeNativeMethods.IsWow64Process(safeProcessHandle, ref Wow64Process2))
								{
									throw new Win32Exception();
								}
								if (Wow64Process && !Wow64Process2)
								{
									throw new Win32Exception(299, SR.GetString("EnumProcessModuleFailedDueToWow"));
								}
							}
							finally
							{
								if (safeProcessHandle2 != SafeProcessHandle.InvalidHandle)
								{
									safeProcessHandle2.Close();
								}
							}
						}
						for (int i = 0; i < 50; i++)
						{
							flag = Microsoft.Win32.NativeMethods.EnumProcessModules(safeProcessHandle, gCHandle.AddrOfPinnedObject(), array.Length * IntPtr.Size, ref needed);
							if (flag)
							{
								break;
							}
							Thread.Sleep(1);
						}
					}
				}
				finally
				{
					gCHandle.Free();
				}
				if (!flag)
				{
					throw new Win32Exception();
				}
				needed /= IntPtr.Size;
				if (needed <= array.Length)
				{
					break;
				}
				array = new IntPtr[array.Length * 2];
			}
			ArrayList arrayList = new ArrayList();
			for (int j = 0; j < needed; j++)
			{
				try
				{
					ModuleInfo moduleInfo = new ModuleInfo();
					IntPtr handle = array[j];
					Microsoft.Win32.NativeMethods.NtModuleInfo ntModuleInfo = new Microsoft.Win32.NativeMethods.NtModuleInfo();
					if (!Microsoft.Win32.NativeMethods.GetModuleInformation(safeProcessHandle, new HandleRef(null, handle), ntModuleInfo, Marshal.SizeOf((object)ntModuleInfo)))
					{
						throw new Win32Exception();
					}
					moduleInfo.sizeOfImage = ntModuleInfo.SizeOfImage;
					moduleInfo.entryPoint = ntModuleInfo.EntryPoint;
					moduleInfo.baseOfDll = ntModuleInfo.BaseOfDll;
					StringBuilder stringBuilder = new StringBuilder(1024);
					if (Microsoft.Win32.NativeMethods.GetModuleBaseName(safeProcessHandle, new HandleRef(null, handle), stringBuilder, stringBuilder.Capacity * 2) == 0)
					{
						throw new Win32Exception();
					}
					moduleInfo.baseName = stringBuilder.ToString();
					StringBuilder stringBuilder2 = new StringBuilder(1024);
					if (Microsoft.Win32.NativeMethods.GetModuleFileNameEx(safeProcessHandle, new HandleRef(null, handle), stringBuilder2, stringBuilder2.Capacity * 2) == 0)
					{
						throw new Win32Exception();
					}
					moduleInfo.fileName = stringBuilder2.ToString();
					if (string.Compare(moduleInfo.fileName, "\\SystemRoot\\System32\\smss.exe", StringComparison.OrdinalIgnoreCase) == 0)
					{
						moduleInfo.fileName = Path.Combine(Environment.SystemDirectory, "smss.exe");
					}
					if (moduleInfo.fileName != null && moduleInfo.fileName.Length >= 4 && moduleInfo.fileName.StartsWith("\\\\?\\", StringComparison.Ordinal))
					{
						moduleInfo.fileName = moduleInfo.fileName.Substring(4);
					}
					arrayList.Add(moduleInfo);
				}
				catch (Win32Exception ex)
				{
					if (ex.NativeErrorCode != 6 && ex.NativeErrorCode != 299)
					{
						throw;
					}
				}
				if (firstModuleOnly)
				{
					break;
				}
			}
			ModuleInfo[] array2 = new ModuleInfo[arrayList.Count];
			arrayList.CopyTo(array2, 0);
			return array2;
		}
		finally
		{
			if (!safeProcessHandle.IsInvalid)
			{
				safeProcessHandle.Close();
			}
		}
	}

	public static int GetProcessIdFromHandle(SafeProcessHandle processHandle)
	{
		Microsoft.Win32.NativeMethods.NtProcessBasicInfo ntProcessBasicInfo = new Microsoft.Win32.NativeMethods.NtProcessBasicInfo();
		int num = Microsoft.Win32.NativeMethods.NtQueryInformationProcess(processHandle, 0, ntProcessBasicInfo, Marshal.SizeOf((object)ntProcessBasicInfo), null);
		if (num != 0)
		{
			throw new InvalidOperationException(SR.GetString("CantGetProcessId"), new Win32Exception(num));
		}
		return ntProcessBasicInfo.UniqueProcessId.ToInt32();
	}

	public static ProcessInfo[] GetProcessInfos(string machineName, bool isRemoteMachine)
	{
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
		PerformanceCounterLib performanceCounterLib = null;
		try
		{
			performanceCounterLib = PerformanceCounterLib.GetPerformanceCounterLib(machineName, new CultureInfo(9));
			return GetProcessInfos(performanceCounterLib);
		}
		catch (Exception ex)
		{
			if (isRemoteMachine)
			{
				throw new InvalidOperationException(SR.GetString("CouldntConnectToRemoteMachine"), ex);
			}
			throw ex;
		}
	}

	private static ProcessInfo[] GetProcessInfos(PerformanceCounterLib library)
	{
		ProcessInfo[] array = new ProcessInfo[0];
		byte[] array2 = null;
		int num = 5;
		while (array.Length == 0 && num != 0)
		{
			try
			{
				array2 = library.GetPerformanceData("230 232");
				array = GetProcessInfos(library, 230, 232, array2);
			}
			catch (Exception innerException)
			{
				throw new InvalidOperationException(SR.GetString("CouldntGetProcessInfos"), innerException);
			}
			num--;
		}
		if (array.Length == 0)
		{
			throw new InvalidOperationException(SR.GetString("ProcessDisabled"));
		}
		return array;
	}

	private static ProcessInfo[] GetProcessInfos(PerformanceCounterLib library, int processIndex, int threadIndex, byte[] data)
	{
		Hashtable hashtable = new Hashtable();
		ArrayList arrayList = new ArrayList();
		GCHandle gCHandle = default(GCHandle);
		try
		{
			gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
			IntPtr intPtr = gCHandle.AddrOfPinnedObject();
			Microsoft.Win32.NativeMethods.PERF_DATA_BLOCK.ValidateBeforeRead(intPtr, data.Length, intPtr);
			Microsoft.Win32.NativeMethods.PERF_DATA_BLOCK pERF_DATA_BLOCK = new Microsoft.Win32.NativeMethods.PERF_DATA_BLOCK();
			Marshal.PtrToStructure(intPtr, (object)pERF_DATA_BLOCK);
			pERF_DATA_BLOCK.Validate(data.Length);
			IntPtr intPtr2 = (IntPtr)((long)intPtr + pERF_DATA_BLOCK.HeaderLength);
			Microsoft.Win32.NativeMethods.PERF_INSTANCE_DEFINITION pERF_INSTANCE_DEFINITION = new Microsoft.Win32.NativeMethods.PERF_INSTANCE_DEFINITION();
			Microsoft.Win32.NativeMethods.PERF_COUNTER_BLOCK pERF_COUNTER_BLOCK = new Microsoft.Win32.NativeMethods.PERF_COUNTER_BLOCK();
			for (int i = 0; i < pERF_DATA_BLOCK.NumObjectTypes; i++)
			{
				Microsoft.Win32.NativeMethods.PERF_OBJECT_TYPE.ValidateBeforeRead(intPtr, data.Length, intPtr2);
				Microsoft.Win32.NativeMethods.PERF_OBJECT_TYPE pERF_OBJECT_TYPE = new Microsoft.Win32.NativeMethods.PERF_OBJECT_TYPE();
				Marshal.PtrToStructure(intPtr2, (object)pERF_OBJECT_TYPE);
				pERF_OBJECT_TYPE.Validate(data.Length - (int)((long)intPtr2 - (long)intPtr));
				IntPtr intPtr3 = (IntPtr)((long)intPtr2 + pERF_OBJECT_TYPE.DefinitionLength);
				IntPtr intPtr4 = (IntPtr)((long)intPtr2 + pERF_OBJECT_TYPE.HeaderLength);
				ArrayList arrayList2 = new ArrayList();
				for (int j = 0; j < pERF_OBJECT_TYPE.NumCounters; j++)
				{
					Microsoft.Win32.NativeMethods.PERF_COUNTER_DEFINITION.ValidateBeforeRead(intPtr, data.Length, intPtr4);
					Microsoft.Win32.NativeMethods.PERF_COUNTER_DEFINITION pERF_COUNTER_DEFINITION = new Microsoft.Win32.NativeMethods.PERF_COUNTER_DEFINITION();
					Marshal.PtrToStructure(intPtr4, (object)pERF_COUNTER_DEFINITION);
					pERF_COUNTER_DEFINITION.Validate(data.Length - (int)((long)intPtr4 - (long)intPtr));
					string counterName = library.GetCounterName(pERF_COUNTER_DEFINITION.CounterNameTitleIndex);
					if (pERF_OBJECT_TYPE.ObjectNameTitleIndex == processIndex)
					{
						pERF_COUNTER_DEFINITION.CounterNameTitlePtr = (int)GetValueId(counterName);
					}
					else if (pERF_OBJECT_TYPE.ObjectNameTitleIndex == threadIndex)
					{
						pERF_COUNTER_DEFINITION.CounterNameTitlePtr = (int)GetValueId(counterName);
					}
					arrayList2.Add(pERF_COUNTER_DEFINITION);
					intPtr4 = (IntPtr)((long)intPtr4 + pERF_COUNTER_DEFINITION.ByteLength);
				}
				Microsoft.Win32.NativeMethods.PERF_COUNTER_DEFINITION[] array = new Microsoft.Win32.NativeMethods.PERF_COUNTER_DEFINITION[arrayList2.Count];
				arrayList2.CopyTo(array, 0);
				for (int k = 0; k < pERF_OBJECT_TYPE.NumInstances; k++)
				{
					Microsoft.Win32.NativeMethods.PERF_INSTANCE_DEFINITION.ValidateBeforeRead(intPtr, data.Length, intPtr3);
					Marshal.PtrToStructure(intPtr3, (object)pERF_INSTANCE_DEFINITION);
					pERF_INSTANCE_DEFINITION.Validate(data.Length - (int)((long)intPtr3 - (long)intPtr));
					IntPtr ptr = (IntPtr)((long)intPtr3 + pERF_INSTANCE_DEFINITION.NameOffset);
					string text = Marshal.PtrToStringUni(ptr);
					if (text.Equals("_Total"))
					{
						continue;
					}
					IntPtr intPtr5 = (IntPtr)((long)intPtr3 + pERF_INSTANCE_DEFINITION.ByteLength);
					Microsoft.Win32.NativeMethods.PERF_COUNTER_BLOCK.ValidateBeforeRead(intPtr, data.Length, intPtr5);
					Marshal.PtrToStructure(intPtr5, (object)pERF_COUNTER_BLOCK);
					pERF_COUNTER_BLOCK.Validate(data.Length - (int)((long)intPtr5 - (long)intPtr));
					if (pERF_OBJECT_TYPE.ObjectNameTitleIndex == processIndex)
					{
						ProcessInfo processInfo = GetProcessInfo(pERF_OBJECT_TYPE, (IntPtr)((long)intPtr3 + pERF_INSTANCE_DEFINITION.ByteLength), array);
						if ((processInfo.processId != 0 || string.Compare(text, "Idle", StringComparison.OrdinalIgnoreCase) == 0) && hashtable[processInfo.processId] == null)
						{
							string text2 = text;
							if (text2.Length == 15)
							{
								if (text.EndsWith(".", StringComparison.Ordinal))
								{
									text2 = text.Substring(0, 14);
								}
								else if (text.EndsWith(".e", StringComparison.Ordinal))
								{
									text2 = text.Substring(0, 13);
								}
								else if (text.EndsWith(".ex", StringComparison.Ordinal))
								{
									text2 = text.Substring(0, 12);
								}
							}
							processInfo.processName = text2;
							hashtable.Add(processInfo.processId, processInfo);
						}
					}
					else if (pERF_OBJECT_TYPE.ObjectNameTitleIndex == threadIndex)
					{
						ThreadInfo threadInfo = GetThreadInfo(pERF_OBJECT_TYPE, (IntPtr)((long)intPtr3 + pERF_INSTANCE_DEFINITION.ByteLength), array);
						if (threadInfo.threadId != 0)
						{
							arrayList.Add(threadInfo);
						}
					}
					intPtr3 = (IntPtr)((long)intPtr3 + pERF_INSTANCE_DEFINITION.ByteLength + pERF_COUNTER_BLOCK.ByteLength);
				}
				intPtr2 = (IntPtr)((long)intPtr2 + pERF_OBJECT_TYPE.TotalByteLength);
			}
		}
		finally
		{
			if (gCHandle.IsAllocated)
			{
				gCHandle.Free();
			}
		}
		for (int l = 0; l < arrayList.Count; l++)
		{
			ThreadInfo threadInfo2 = (ThreadInfo)arrayList[l];
			((ProcessInfo)hashtable[threadInfo2.processId])?.threadInfoList.Add(threadInfo2);
		}
		ProcessInfo[] array2 = new ProcessInfo[hashtable.Values.Count];
		hashtable.Values.CopyTo(array2, 0);
		return array2;
	}

	private static ThreadInfo GetThreadInfo(Microsoft.Win32.NativeMethods.PERF_OBJECT_TYPE type, IntPtr instancePtr, Microsoft.Win32.NativeMethods.PERF_COUNTER_DEFINITION[] counters)
	{
		ThreadInfo threadInfo = new ThreadInfo();
		foreach (Microsoft.Win32.NativeMethods.PERF_COUNTER_DEFINITION pERF_COUNTER_DEFINITION in counters)
		{
			long num = ReadCounterValue(pERF_COUNTER_DEFINITION.CounterType, (IntPtr)((long)instancePtr + pERF_COUNTER_DEFINITION.CounterOffset));
			switch ((ValueId)pERF_COUNTER_DEFINITION.CounterNameTitlePtr)
			{
			case ValueId.ProcessId:
				threadInfo.processId = (int)num;
				break;
			case ValueId.ThreadId:
				threadInfo.threadId = (int)num;
				break;
			case ValueId.BasePriority:
				threadInfo.basePriority = (int)num;
				break;
			case ValueId.CurrentPriority:
				threadInfo.currentPriority = (int)num;
				break;
			case ValueId.StartAddress:
				threadInfo.startAddress = (IntPtr)num;
				break;
			case ValueId.ThreadState:
				threadInfo.threadState = (ThreadState)num;
				break;
			case ValueId.ThreadWaitReason:
				threadInfo.threadWaitReason = GetThreadWaitReason((int)num);
				break;
			}
		}
		return threadInfo;
	}

	internal static ThreadWaitReason GetThreadWaitReason(int value)
	{
		switch (value)
		{
		case 0:
		case 7:
			return ThreadWaitReason.Executive;
		case 1:
		case 8:
			return ThreadWaitReason.FreePage;
		case 2:
		case 9:
			return ThreadWaitReason.PageIn;
		case 3:
		case 10:
			return ThreadWaitReason.SystemAllocation;
		case 4:
		case 11:
			return ThreadWaitReason.ExecutionDelay;
		case 5:
		case 12:
			return ThreadWaitReason.Suspended;
		case 6:
		case 13:
			return ThreadWaitReason.UserRequest;
		case 14:
			return ThreadWaitReason.EventPairHigh;
		case 15:
			return ThreadWaitReason.EventPairLow;
		case 16:
			return ThreadWaitReason.LpcReceive;
		case 17:
			return ThreadWaitReason.LpcReply;
		case 18:
			return ThreadWaitReason.VirtualMemory;
		case 19:
			return ThreadWaitReason.PageOut;
		default:
			return ThreadWaitReason.Unknown;
		}
	}

	private static ProcessInfo GetProcessInfo(Microsoft.Win32.NativeMethods.PERF_OBJECT_TYPE type, IntPtr instancePtr, Microsoft.Win32.NativeMethods.PERF_COUNTER_DEFINITION[] counters)
	{
		ProcessInfo processInfo = new ProcessInfo();
		foreach (Microsoft.Win32.NativeMethods.PERF_COUNTER_DEFINITION pERF_COUNTER_DEFINITION in counters)
		{
			long num = ReadCounterValue(pERF_COUNTER_DEFINITION.CounterType, (IntPtr)((long)instancePtr + pERF_COUNTER_DEFINITION.CounterOffset));
			switch ((ValueId)pERF_COUNTER_DEFINITION.CounterNameTitlePtr)
			{
			case ValueId.ProcessId:
				processInfo.processId = (int)num;
				break;
			case ValueId.HandleCount:
				processInfo.handleCount = (int)num;
				break;
			case ValueId.PoolPagedBytes:
				processInfo.poolPagedBytes = num;
				break;
			case ValueId.PoolNonpagedBytes:
				processInfo.poolNonpagedBytes = num;
				break;
			case ValueId.VirtualBytes:
				processInfo.virtualBytes = num;
				break;
			case ValueId.VirtualBytesPeak:
				processInfo.virtualBytesPeak = num;
				break;
			case ValueId.WorkingSetPeak:
				processInfo.workingSetPeak = num;
				break;
			case ValueId.WorkingSet:
				processInfo.workingSet = num;
				break;
			case ValueId.PageFileBytesPeak:
				processInfo.pageFileBytesPeak = num;
				break;
			case ValueId.PageFileBytes:
				processInfo.pageFileBytes = num;
				break;
			case ValueId.PrivateBytes:
				processInfo.privateBytes = num;
				break;
			case ValueId.BasePriority:
				processInfo.basePriority = (int)num;
				break;
			}
		}
		return processInfo;
	}

	private static ValueId GetValueId(string counterName)
	{
		if (counterName != null)
		{
			object obj = valueIds[counterName];
			if (obj != null)
			{
				return (ValueId)obj;
			}
		}
		return ValueId.Unknown;
	}

	private static long ReadCounterValue(int counterType, IntPtr dataPtr)
	{
		if ((counterType & 0x100) != 0)
		{
			return Marshal.ReadInt64(dataPtr);
		}
		return Marshal.ReadInt32(dataPtr);
	}
}
