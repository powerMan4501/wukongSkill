using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Diagnostics;

[HostProtection(SecurityAction.LinkDemand, Synchronization = true, SharedState = true)]
internal sealed class SharedPerformanceCounter
{
	private class FileMapping
	{
		internal int FileMappingSize;

		private SafeFileMapViewHandle fileViewAddress;

		private SafeFileMappingHandle fileMappingHandle;

		internal IntPtr FileViewAddress
		{
			get
			{
				if (fileViewAddress.IsInvalid)
				{
					throw new InvalidOperationException(SR.GetString("SharedMemoryGhosted"));
				}
				return fileViewAddress.DangerousGetHandle();
			}
		}

		public FileMapping(string fileMappingName, int fileMappingSize, int initialOffset)
		{
			Initialize(fileMappingName, fileMappingSize, initialOffset);
		}

		private unsafe void Initialize(string fileMappingName, int fileMappingSize, int initialOffset)
		{
			SharedUtils.CheckEnvironment();
			SafeLocalMemHandle pSecurityDescriptor = null;
			new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Assert();
			try
			{
				string stringSecurityDescriptor = "D:(A;OICI;FRFWGRGW;;;AU)(A;OICI;FRFWGRGW;;;S-1-5-33)";
				if (!SafeLocalMemHandle.ConvertStringSecurityDescriptorToSecurityDescriptor(stringSecurityDescriptor, 1, out pSecurityDescriptor, IntPtr.Zero))
				{
					throw new InvalidOperationException(SR.GetString("SetSecurityDescriptorFailed"));
				}
				Microsoft.Win32.NativeMethods.SECURITY_ATTRIBUTES sECURITY_ATTRIBUTES = new Microsoft.Win32.NativeMethods.SECURITY_ATTRIBUTES();
				sECURITY_ATTRIBUTES.lpSecurityDescriptor = pSecurityDescriptor;
				sECURITY_ATTRIBUTES.bInheritHandle = false;
				int num = 14;
				int num2 = 0;
				bool flag = false;
				while (!flag && num > 0)
				{
					fileMappingHandle = Microsoft.Win32.NativeMethods.CreateFileMapping((IntPtr)(-1), sECURITY_ATTRIBUTES, 4, 0, fileMappingSize, fileMappingName);
					if (Marshal.GetLastWin32Error() != 5 || !fileMappingHandle.IsInvalid)
					{
						flag = true;
						continue;
					}
					fileMappingHandle.SetHandleAsInvalid();
					fileMappingHandle = Microsoft.Win32.NativeMethods.OpenFileMapping(2, bInheritHandle: false, fileMappingName);
					if (Marshal.GetLastWin32Error() != 2 || !fileMappingHandle.IsInvalid)
					{
						flag = true;
						continue;
					}
					num--;
					if (num2 == 0)
					{
						num2 = 10;
						continue;
					}
					Thread.Sleep(num2);
					num2 *= 2;
				}
				if (fileMappingHandle.IsInvalid)
				{
					throw new InvalidOperationException(SR.GetString("CantCreateFileMapping"));
				}
				fileViewAddress = SafeFileMapViewHandle.MapViewOfFile(fileMappingHandle, 2, 0, 0, UIntPtr.Zero);
				if (fileViewAddress.IsInvalid)
				{
					throw new InvalidOperationException(SR.GetString("CantMapFileView"));
				}
				Microsoft.Win32.NativeMethods.MEMORY_BASIC_INFORMATION buffer = default(Microsoft.Win32.NativeMethods.MEMORY_BASIC_INFORMATION);
				if (Microsoft.Win32.NativeMethods.VirtualQuery(fileViewAddress, ref buffer, (IntPtr)sizeof(Microsoft.Win32.NativeMethods.MEMORY_BASIC_INFORMATION)) == IntPtr.Zero)
				{
					throw new InvalidOperationException(SR.GetString("CantGetMappingSize"));
				}
				FileMappingSize = (int)(uint)buffer.RegionSize;
			}
			finally
			{
				pSecurityDescriptor?.Close();
				CodeAccessPermission.RevertAssert();
			}
			Microsoft.Win32.SafeNativeMethods.InterlockedCompareExchange(fileViewAddress.DangerousGetHandle(), initialOffset, 0);
		}
	}

	private struct CategoryEntry
	{
		public int SpinLock;

		public int CategoryNameHashCode;

		public int CategoryNameOffset;

		public int FirstInstanceOffset;

		public int NextCategoryOffset;

		public int IsConsistent;
	}

	private struct InstanceEntry
	{
		public int SpinLock;

		public int InstanceNameHashCode;

		public int InstanceNameOffset;

		public int RefCount;

		public int FirstCounterOffset;

		public int NextInstanceOffset;
	}

	private struct CounterEntry
	{
		public int SpinLock;

		public int CounterNameHashCode;

		public int CounterNameOffset;

		public int LifetimeOffset;

		public long Value;

		public int NextCounterOffset;

		public int padding2;
	}

	private struct CounterEntryMisaligned
	{
		public int SpinLock;

		public int CounterNameHashCode;

		public int CounterNameOffset;

		public int LifetimeOffset;

		public int Value_lo;

		public int Value_hi;

		public int NextCounterOffset;

		public int padding2;
	}

	private struct ProcessLifetimeEntry
	{
		public int LifetimeType;

		public int ProcessId;

		public long StartupTime;
	}

	private class CategoryData
	{
		public FileMapping FileMapping;

		public bool EnableReuse;

		public bool UseUniqueSharedMemory;

		public string FileMappingName;

		public string MutexName;

		public ArrayList CounterNames;
	}

	private const int MaxSpinCount = 5000;

	internal const int DefaultCountersFileMappingSize = 524288;

	internal const int MaxCountersFileMappingSize = 33554432;

	internal const int MinCountersFileMappingSize = 32768;

	internal const int InstanceNameMaxLength = 127;

	internal const int InstanceNameSlotSize = 256;

	internal const string SingleInstanceName = "systemdiagnosticssharedsingleinstance";

	internal const string DefaultFileMappingName = "netfxcustomperfcounters.1.0";

	internal static readonly int SingleInstanceHashCode = GetWstrHashCode("systemdiagnosticssharedsingleinstance");

	private static Hashtable categoryDataTable = new Hashtable(StringComparer.Ordinal);

	private static readonly int CategoryEntrySize = Marshal.SizeOf(typeof(CategoryEntry));

	private static readonly int InstanceEntrySize = Marshal.SizeOf(typeof(InstanceEntry));

	private static readonly int CounterEntrySize = Marshal.SizeOf(typeof(CounterEntry));

	private static readonly int ProcessLifetimeEntrySize = Marshal.SizeOf(typeof(ProcessLifetimeEntry));

	private static long LastInstanceLifetimeSweepTick;

	private const long InstanceLifetimeSweepWindow = 300000000L;

	private static volatile ProcessData procData;

	internal int InitialOffset = 4;

	private CategoryData categoryData;

	private long baseAddress;

	private unsafe CounterEntry* counterEntryPointer;

	private string categoryName;

	private int categoryNameHashCode;

	private int thisInstanceOffset = -1;

	private static ProcessData ProcessData
	{
		get
		{
			if (procData == null)
			{
				new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Assert();
				try
				{
					int currentProcessId = Microsoft.Win32.NativeMethods.GetCurrentProcessId();
					long creation = -1L;
					using (SafeProcessHandle safeProcessHandle = SafeProcessHandle.OpenProcess(1024, inherit: false, currentProcessId))
					{
						if (!safeProcessHandle.IsInvalid)
						{
							Microsoft.Win32.NativeMethods.GetProcessTimes(safeProcessHandle, out creation, out var exit, out exit, out exit);
						}
					}
					procData = new ProcessData(currentProcessId, creation);
				}
				finally
				{
					CodeAccessPermission.RevertAssert();
				}
			}
			return procData;
		}
	}

	private FileMapping FileView => categoryData.FileMapping;

	internal unsafe long Value
	{
		get
		{
			if (counterEntryPointer == null)
			{
				return 0L;
			}
			return GetValue(counterEntryPointer);
		}
		set
		{
			if (counterEntryPointer != null)
			{
				SetValue(counterEntryPointer, value);
			}
		}
	}

	internal SharedPerformanceCounter(string catName, string counterName, string instanceName)
		: this(catName, counterName, instanceName, PerformanceCounterInstanceLifetime.Global)
	{
	}

	internal unsafe SharedPerformanceCounter(string catName, string counterName, string instanceName, PerformanceCounterInstanceLifetime lifetime)
	{
		categoryName = catName;
		categoryNameHashCode = GetWstrHashCode(categoryName);
		categoryData = GetCategoryData();
		if (categoryData.UseUniqueSharedMemory)
		{
			if (instanceName != null && instanceName.Length > 127)
			{
				throw new InvalidOperationException(SR.GetString("InstanceNameTooLong"));
			}
		}
		else if (lifetime != PerformanceCounterInstanceLifetime.Global)
		{
			throw new InvalidOperationException(SR.GetString("ProcessLifetimeNotValidInGlobal"));
		}
		if (counterName != null && instanceName != null && categoryData.CounterNames.Contains(counterName))
		{
			counterEntryPointer = GetCounter(counterName, instanceName, categoryData.EnableReuse, lifetime);
		}
	}

	private unsafe int CalculateAndAllocateMemory(int totalSize, out int alignmentAdjustment)
	{
		alignmentAdjustment = 0;
		int num;
		int num2;
		do
		{
			num = *(int*)baseAddress;
			ResolveOffset(num, 0);
			num2 = CalculateMemory(num, totalSize, out alignmentAdjustment);
			int num3 = (int)(baseAddress + num2) & 7;
			int num4 = (8 - num3) & 7;
			num2 += num4;
		}
		while (Microsoft.Win32.SafeNativeMethods.InterlockedCompareExchange((IntPtr)baseAddress, num2, num) != num);
		return num;
	}

	private int CalculateMemory(int oldOffset, int totalSize, out int alignmentAdjustment)
	{
		int num = CalculateMemoryNoBoundsCheck(oldOffset, totalSize, out alignmentAdjustment);
		if (num > FileView.FileMappingSize || num < 0)
		{
			throw new InvalidOperationException(SR.GetString("CountersOOM"));
		}
		return num;
	}

	private int CalculateMemoryNoBoundsCheck(int oldOffset, int totalSize, out int alignmentAdjustment)
	{
		int num = totalSize;
		Thread.MemoryBarrier();
		int num2 = (int)(baseAddress + oldOffset) & 7;
		alignmentAdjustment = (8 - num2) & 7;
		num += alignmentAdjustment;
		return oldOffset + num;
	}

	private unsafe int CreateCategory(CategoryEntry* lastCategoryPointer, int instanceNameHashCode, string instanceName, PerformanceCounterInstanceLifetime lifetime)
	{
		int num = 0;
		int num2 = (categoryName.Length + 1) * 2;
		int num3 = CategoryEntrySize + InstanceEntrySize + CounterEntrySize * categoryData.CounterNames.Count + num2;
		for (int i = 0; i < categoryData.CounterNames.Count; i++)
		{
			num3 += (((string)categoryData.CounterNames[i]).Length + 1) * 2;
		}
		int num4;
		int num5;
		int alignmentAdjustment;
		if (categoryData.UseUniqueSharedMemory)
		{
			num4 = 256;
			num3 += ProcessLifetimeEntrySize + num4;
			num5 = *(int*)baseAddress;
			num = CalculateMemory(num5, num3, out alignmentAdjustment);
			if (num5 == InitialOffset)
			{
				lastCategoryPointer->IsConsistent = 0;
			}
		}
		else
		{
			num4 = (instanceName.Length + 1) * 2;
			num3 += num4;
			num5 = CalculateAndAllocateMemory(num3, out alignmentAdjustment);
		}
		long num6 = ResolveOffset(num5, num3 + alignmentAdjustment);
		CategoryEntry* ptr;
		InstanceEntry* ptr2;
		if (num5 == InitialOffset)
		{
			ptr = (CategoryEntry*)num6;
			num6 += CategoryEntrySize + alignmentAdjustment;
			ptr2 = (InstanceEntry*)num6;
		}
		else
		{
			num6 += alignmentAdjustment;
			ptr = (CategoryEntry*)num6;
			num6 += CategoryEntrySize;
			ptr2 = (InstanceEntry*)num6;
		}
		num6 += InstanceEntrySize;
		CounterEntry* ptr3 = (CounterEntry*)num6;
		num6 += CounterEntrySize * categoryData.CounterNames.Count;
		if (categoryData.UseUniqueSharedMemory)
		{
			ProcessLifetimeEntry* ptr4 = (ProcessLifetimeEntry*)num6;
			num6 += ProcessLifetimeEntrySize;
			ptr3->LifetimeOffset = (int)((long)ptr4 - baseAddress);
			PopulateLifetimeEntry(ptr4, lifetime);
		}
		ptr->CategoryNameHashCode = categoryNameHashCode;
		ptr->NextCategoryOffset = 0;
		ptr->FirstInstanceOffset = (int)((long)ptr2 - baseAddress);
		ptr->CategoryNameOffset = (int)(num6 - baseAddress);
		SafeMarshalCopy(categoryName, (IntPtr)num6);
		num6 += num2;
		ptr2->InstanceNameHashCode = instanceNameHashCode;
		ptr2->NextInstanceOffset = 0;
		ptr2->FirstCounterOffset = (int)((long)ptr3 - baseAddress);
		ptr2->RefCount = 1;
		ptr2->InstanceNameOffset = (int)(num6 - baseAddress);
		SafeMarshalCopy(instanceName, (IntPtr)num6);
		num6 += num4;
		string text = (string)categoryData.CounterNames[0];
		ptr3->CounterNameHashCode = GetWstrHashCode(text);
		SetValue(ptr3, 0L);
		ptr3->CounterNameOffset = (int)(num6 - baseAddress);
		SafeMarshalCopy(text, (IntPtr)num6);
		num6 += (text.Length + 1) * 2;
		for (int j = 1; j < categoryData.CounterNames.Count; j++)
		{
			CounterEntry* ptr5 = ptr3;
			text = (string)categoryData.CounterNames[j];
			ptr3++;
			ptr3->CounterNameHashCode = GetWstrHashCode(text);
			SetValue(ptr3, 0L);
			ptr3->CounterNameOffset = (int)(num6 - baseAddress);
			SafeMarshalCopy(text, (IntPtr)num6);
			num6 += (text.Length + 1) * 2;
			ptr5->NextCounterOffset = (int)((long)ptr3 - baseAddress);
		}
		int num7 = (int)((long)ptr - baseAddress);
		lastCategoryPointer->IsConsistent = 0;
		if (num7 != InitialOffset)
		{
			lastCategoryPointer->NextCategoryOffset = num7;
		}
		if (categoryData.UseUniqueSharedMemory)
		{
			*(int*)baseAddress = num;
			lastCategoryPointer->IsConsistent = 1;
		}
		return num7;
	}

	private unsafe int CreateInstance(CategoryEntry* categoryPointer, int instanceNameHashCode, string instanceName, PerformanceCounterInstanceLifetime lifetime)
	{
		int num = InstanceEntrySize + CounterEntrySize * categoryData.CounterNames.Count;
		int num2 = 0;
		int num3;
		int alignmentAdjustment;
		int num4;
		if (categoryData.UseUniqueSharedMemory)
		{
			num3 = 256;
			num += ProcessLifetimeEntrySize + num3;
			num4 = *(int*)baseAddress;
			num2 = CalculateMemory(num4, num, out alignmentAdjustment);
		}
		else
		{
			num3 = (instanceName.Length + 1) * 2;
			num += num3;
			for (int i = 0; i < categoryData.CounterNames.Count; i++)
			{
				num += (((string)categoryData.CounterNames[i]).Length + 1) * 2;
			}
			num4 = CalculateAndAllocateMemory(num, out alignmentAdjustment);
		}
		num4 += alignmentAdjustment;
		long num5 = ResolveOffset(num4, num);
		InstanceEntry* ptr = (InstanceEntry*)num5;
		num5 += InstanceEntrySize;
		CounterEntry* ptr2 = (CounterEntry*)num5;
		num5 += CounterEntrySize * categoryData.CounterNames.Count;
		if (categoryData.UseUniqueSharedMemory)
		{
			ProcessLifetimeEntry* ptr3 = (ProcessLifetimeEntry*)num5;
			num5 += ProcessLifetimeEntrySize;
			ptr2->LifetimeOffset = (int)((long)ptr3 - baseAddress);
			PopulateLifetimeEntry(ptr3, lifetime);
		}
		ptr->InstanceNameHashCode = instanceNameHashCode;
		ptr->NextInstanceOffset = 0;
		ptr->FirstCounterOffset = (int)((long)ptr2 - baseAddress);
		ptr->RefCount = 1;
		ptr->InstanceNameOffset = (int)(num5 - baseAddress);
		SafeMarshalCopy(instanceName, (IntPtr)num5);
		num5 += num3;
		if (categoryData.UseUniqueSharedMemory)
		{
			InstanceEntry* ptr4 = (InstanceEntry*)ResolveOffset(categoryPointer->FirstInstanceOffset, InstanceEntrySize);
			CounterEntry* ptr5 = (CounterEntry*)ResolveOffset(ptr4->FirstCounterOffset, CounterEntrySize);
			ptr2->CounterNameHashCode = ptr5->CounterNameHashCode;
			SetValue(ptr2, 0L);
			ptr2->CounterNameOffset = ptr5->CounterNameOffset;
			for (int j = 1; j < categoryData.CounterNames.Count; j++)
			{
				CounterEntry* ptr6 = ptr2;
				ptr2++;
				ptr5 = (CounterEntry*)ResolveOffset(ptr5->NextCounterOffset, CounterEntrySize);
				ptr2->CounterNameHashCode = ptr5->CounterNameHashCode;
				SetValue(ptr2, 0L);
				ptr2->CounterNameOffset = ptr5->CounterNameOffset;
				ptr6->NextCounterOffset = (int)((long)ptr2 - baseAddress);
			}
		}
		else
		{
			CounterEntry* ptr7 = null;
			for (int k = 0; k < categoryData.CounterNames.Count; k++)
			{
				string text = (string)categoryData.CounterNames[k];
				ptr2->CounterNameHashCode = GetWstrHashCode(text);
				ptr2->CounterNameOffset = (int)(num5 - baseAddress);
				SafeMarshalCopy(text, (IntPtr)num5);
				num5 += (text.Length + 1) * 2;
				SetValue(ptr2, 0L);
				if (k != 0)
				{
					ptr7->NextCounterOffset = (int)((long)ptr2 - baseAddress);
				}
				ptr7 = ptr2;
				ptr2++;
			}
		}
		int firstInstanceOffset = (int)((long)ptr - baseAddress);
		categoryPointer->IsConsistent = 0;
		ptr->NextInstanceOffset = categoryPointer->FirstInstanceOffset;
		categoryPointer->FirstInstanceOffset = firstInstanceOffset;
		if (categoryData.UseUniqueSharedMemory)
		{
			*(int*)baseAddress = num2;
			categoryPointer->IsConsistent = 1;
		}
		return num4;
	}

	private unsafe int CreateCounter(CounterEntry* lastCounterPointer, int counterNameHashCode, string counterName)
	{
		int num = (counterName.Length + 1) * 2;
		int num2 = sizeof(CounterEntry) + num;
		int num3 = CalculateAndAllocateMemory(num2, out var alignmentAdjustment);
		num3 += alignmentAdjustment;
		long num4 = ResolveOffset(num3, num2);
		CounterEntry* ptr = (CounterEntry*)num4;
		num4 += sizeof(CounterEntry);
		ptr->CounterNameOffset = (int)(num4 - baseAddress);
		ptr->CounterNameHashCode = counterNameHashCode;
		ptr->NextCounterOffset = 0;
		SetValue(ptr, 0L);
		SafeMarshalCopy(counterName, (IntPtr)num4);
		lastCounterPointer->NextCounterOffset = (int)((long)ptr - baseAddress);
		return num3;
	}

	private unsafe static void PopulateLifetimeEntry(ProcessLifetimeEntry* lifetimeEntry, PerformanceCounterInstanceLifetime lifetime)
	{
		if (lifetime == PerformanceCounterInstanceLifetime.Process)
		{
			lifetimeEntry->LifetimeType = 1;
			lifetimeEntry->ProcessId = ProcessData.ProcessId;
			lifetimeEntry->StartupTime = ProcessData.StartupTime;
		}
		else
		{
			lifetimeEntry->ProcessId = 0;
			lifetimeEntry->StartupTime = 0L;
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	private unsafe static void WaitAndEnterCriticalSection(int* spinLockPointer, out bool taken)
	{
		WaitForCriticalSection(spinLockPointer);
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			int num = Interlocked.CompareExchange(ref *spinLockPointer, 1, 0);
			taken = num == 0;
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	private unsafe static void WaitForCriticalSection(int* spinLockPointer)
	{
		int num = 5000;
		while (num > 0 && *spinLockPointer != 0)
		{
			if (*spinLockPointer != 0)
			{
				Thread.Sleep(1);
			}
			num--;
		}
		if (num == 0 && *spinLockPointer != 0)
		{
			*spinLockPointer = 0;
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private unsafe static void ExitCriticalSection(int* spinLockPointer)
	{
		*spinLockPointer = 0;
	}

	internal static int GetWstrHashCode(string wstr)
	{
		uint num = 5381u;
		for (uint num2 = 0u; num2 < wstr.Length; num2++)
		{
			num = ((num << 5) + num) ^ wstr[(int)num2];
		}
		return (int)num;
	}

	private unsafe int GetStringLength(char* startChar)
	{
		char* ptr = startChar;
		for (ulong num = (ulong)(baseAddress + FileView.FileMappingSize); (ulong)ptr < num - 2; ptr++)
		{
			if (*ptr == '\0')
			{
				return (int)(ptr - startChar);
			}
		}
		throw new InvalidOperationException(SR.GetString("MappingCorrupted"));
	}

	private unsafe bool StringEquals(string stringA, int offset)
	{
		char* ptr = (char*)ResolveOffset(offset, 0);
		ulong num = (ulong)(baseAddress + FileView.FileMappingSize);
		int i;
		for (i = 0; i < stringA.Length; i++)
		{
			if ((ulong)(ptr + i) > num - 2)
			{
				throw new InvalidOperationException(SR.GetString("MappingCorrupted"));
			}
			if (stringA[i] != ptr[i])
			{
				return false;
			}
		}
		if ((ulong)(ptr + i) > num - 2)
		{
			throw new InvalidOperationException(SR.GetString("MappingCorrupted"));
		}
		return ptr[i] == '\0';
	}

	private unsafe CategoryData GetCategoryData()
	{
		CategoryData categoryData = (CategoryData)categoryDataTable[categoryName];
		if (categoryData == null)
		{
			lock (categoryDataTable)
			{
				categoryData = (CategoryData)categoryDataTable[categoryName];
				if (categoryData == null)
				{
					categoryData = new CategoryData();
					categoryData.FileMappingName = "netfxcustomperfcounters.1.0";
					categoryData.MutexName = categoryName;
					RegistryPermission registryPermission = new RegistryPermission(PermissionState.Unrestricted);
					registryPermission.Assert();
					RegistryKey registryKey = null;
					try
					{
						registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\" + categoryName + "\\Performance");
						object value = registryKey.GetValue("CategoryOptions");
						if (value != null)
						{
							int num = (int)value;
							categoryData.EnableReuse = (num & 1) != 0;
							if ((num & 2) != 0)
							{
								categoryData.UseUniqueSharedMemory = true;
								InitialOffset = 8;
								categoryData.FileMappingName = "netfxcustomperfcounters.1.0" + categoryName;
							}
						}
						object value2 = registryKey.GetValue("FileMappingSize");
						int num2;
						if (value2 != null && categoryData.UseUniqueSharedMemory)
						{
							num2 = (int)value2;
							if (num2 < 32768)
							{
								num2 = 32768;
							}
							if (num2 > 33554432)
							{
								num2 = 33554432;
							}
						}
						else
						{
							num2 = GetFileMappingSizeFromConfig();
							if (categoryData.UseUniqueSharedMemory)
							{
								num2 >>= 2;
							}
						}
						object value3 = registryKey.GetValue("Counter Names");
						if (value3 is byte[] array)
						{
							ArrayList arrayList = new ArrayList();
							fixed (byte* value4 = array)
							{
								int num3 = 0;
								for (int i = 0; i < array.Length - 1; i += 2)
								{
									if (array[i] == 0 && array[i + 1] == 0 && num3 != i)
									{
										string text = new string((sbyte*)value4, num3, i - num3, Encoding.Unicode);
										arrayList.Add(text.ToLowerInvariant());
										num3 = i + 2;
									}
								}
							}
							categoryData.CounterNames = arrayList;
						}
						else
						{
							string[] array2 = (string[])value3;
							for (int j = 0; j < array2.Length; j++)
							{
								array2[j] = array2[j].ToLowerInvariant();
							}
							categoryData.CounterNames = new ArrayList(array2);
						}
						if (SharedUtils.CurrentEnvironment == 1)
						{
							categoryData.FileMappingName = "Global\\" + categoryData.FileMappingName;
							categoryData.MutexName = "Global\\" + categoryName;
						}
						categoryData.FileMapping = new FileMapping(categoryData.FileMappingName, num2, InitialOffset);
						categoryDataTable[categoryName] = categoryData;
					}
					finally
					{
						registryKey?.Close();
						CodeAccessPermission.RevertAssert();
					}
				}
			}
		}
		baseAddress = (long)categoryData.FileMapping.FileViewAddress;
		if (categoryData.UseUniqueSharedMemory)
		{
			InitialOffset = 8;
		}
		return categoryData;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int GetFileMappingSizeFromConfig()
	{
		return DiagnosticsConfiguration.PerfomanceCountersFileMappingSize;
	}

	private static void RemoveCategoryData(string categoryName)
	{
		lock (categoryDataTable)
		{
			categoryDataTable.Remove(categoryName);
		}
	}

	private unsafe CounterEntry* GetCounter(string counterName, string instanceName, bool enableReuse, PerformanceCounterInstanceLifetime lifetime)
	{
		int wstrHashCode = GetWstrHashCode(counterName);
		int instanceNameHashCode;
		if (instanceName != null && instanceName.Length != 0)
		{
			instanceNameHashCode = GetWstrHashCode(instanceName);
		}
		else
		{
			instanceNameHashCode = SingleInstanceHashCode;
			instanceName = "systemdiagnosticssharedsingleinstance";
		}
		Mutex mutex = null;
		CounterEntry* ptr = null;
		InstanceEntry* ptr2 = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			SharedUtils.EnterMutexWithoutGlobal(categoryData.MutexName, ref mutex);
			bool flag = false;
			CategoryEntry* ptr3 = default(CategoryEntry*);
			while (!FindCategory(&ptr3))
			{
				bool taken;
				if (categoryData.UseUniqueSharedMemory)
				{
					taken = true;
				}
				else
				{
					WaitAndEnterCriticalSection(&ptr3->SpinLock, out taken);
				}
				if (!taken)
				{
					continue;
				}
				int offset;
				try
				{
					offset = CreateCategory(ptr3, instanceNameHashCode, instanceName, lifetime);
				}
				finally
				{
					if (!categoryData.UseUniqueSharedMemory)
					{
						ExitCriticalSection(&ptr3->SpinLock);
					}
				}
				ptr3 = (CategoryEntry*)ResolveOffset(offset, CategoryEntrySize);
				ptr2 = (InstanceEntry*)ResolveOffset(ptr3->FirstInstanceOffset, InstanceEntrySize);
				flag = FindCounter(wstrHashCode, counterName, ptr2, &ptr);
				return ptr;
			}
			bool foundFreeInstance;
			while (!FindInstance(instanceNameHashCode, instanceName, ptr3, &ptr2, activateUnusedInstances: true, lifetime, out foundFreeInstance))
			{
				InstanceEntry* ptr4 = ptr2;
				bool taken2;
				if (categoryData.UseUniqueSharedMemory)
				{
					taken2 = true;
				}
				else
				{
					WaitAndEnterCriticalSection(&ptr4->SpinLock, out taken2);
				}
				if (!taken2)
				{
					continue;
				}
				try
				{
					bool flag2 = false;
					if (enableReuse && foundFreeInstance)
					{
						flag2 = TryReuseInstance(instanceNameHashCode, instanceName, ptr3, &ptr2, lifetime, ptr4);
					}
					if (!flag2)
					{
						int offset2 = CreateInstance(ptr3, instanceNameHashCode, instanceName, lifetime);
						ptr2 = (InstanceEntry*)ResolveOffset(offset2, InstanceEntrySize);
						flag = FindCounter(wstrHashCode, counterName, ptr2, &ptr);
						return ptr;
					}
				}
				finally
				{
					if (!categoryData.UseUniqueSharedMemory)
					{
						ExitCriticalSection(&ptr4->SpinLock);
					}
				}
			}
			if (categoryData.UseUniqueSharedMemory)
			{
				flag = FindCounter(wstrHashCode, counterName, ptr2, &ptr);
				return ptr;
			}
			while (!FindCounter(wstrHashCode, counterName, ptr2, &ptr))
			{
				WaitAndEnterCriticalSection(&ptr->SpinLock, out var taken3);
				if (taken3)
				{
					try
					{
						int offset3 = CreateCounter(ptr, wstrHashCode, counterName);
						return (CounterEntry*)ResolveOffset(offset3, CounterEntrySize);
					}
					finally
					{
						ExitCriticalSection(&ptr->SpinLock);
					}
				}
			}
			return ptr;
		}
		finally
		{
			try
			{
				if (ptr != null && ptr2 != null)
				{
					thisInstanceOffset = ResolveAddress((long)ptr2, InstanceEntrySize);
				}
			}
			catch (InvalidOperationException)
			{
				thisInstanceOffset = -1;
			}
			if (mutex != null)
			{
				mutex.ReleaseMutex();
				mutex.Close();
			}
		}
	}

	private unsafe bool FindCategory(CategoryEntry** returnCategoryPointerReference)
	{
		CategoryEntry* ptr = (CategoryEntry*)ResolveOffset(InitialOffset, CategoryEntrySize);
		CategoryEntry* ptr2 = ptr;
		CategoryEntry* ptr3 = ptr;
		while (true)
		{
			if (ptr2->IsConsistent == 0)
			{
				Verify(ptr2);
			}
			if (ptr2->CategoryNameHashCode == categoryNameHashCode && StringEquals(categoryName, ptr2->CategoryNameOffset))
			{
				*returnCategoryPointerReference = ptr2;
				return true;
			}
			ptr3 = ptr2;
			if (ptr2->NextCategoryOffset == 0)
			{
				break;
			}
			ptr2 = (CategoryEntry*)ResolveOffset(ptr2->NextCategoryOffset, CategoryEntrySize);
		}
		*returnCategoryPointerReference = ptr3;
		return false;
	}

	private unsafe bool FindCounter(int counterNameHashCode, string counterName, InstanceEntry* instancePointer, CounterEntry** returnCounterPointerReference)
	{
		CounterEntry* ptr = (CounterEntry*)ResolveOffset(instancePointer->FirstCounterOffset, CounterEntrySize);
		CounterEntry* ptr2 = ptr;
		while (true)
		{
			if (ptr->CounterNameHashCode == counterNameHashCode && StringEquals(counterName, ptr->CounterNameOffset))
			{
				*returnCounterPointerReference = ptr;
				return true;
			}
			ptr2 = ptr;
			if (ptr->NextCounterOffset == 0)
			{
				break;
			}
			ptr = (CounterEntry*)ResolveOffset(ptr->NextCounterOffset, CounterEntrySize);
		}
		*returnCounterPointerReference = ptr2;
		return false;
	}

	private unsafe bool FindInstance(int instanceNameHashCode, string instanceName, CategoryEntry* categoryPointer, InstanceEntry** returnInstancePointerReference, bool activateUnusedInstances, PerformanceCounterInstanceLifetime lifetime, out bool foundFreeInstance)
	{
		InstanceEntry* ptr = (InstanceEntry*)ResolveOffset(categoryPointer->FirstInstanceOffset, InstanceEntrySize);
		InstanceEntry* ptr2 = ptr;
		foundFreeInstance = false;
		if (ptr->InstanceNameHashCode == SingleInstanceHashCode)
		{
			if (StringEquals("systemdiagnosticssharedsingleinstance", ptr->InstanceNameOffset))
			{
				if (instanceName != "systemdiagnosticssharedsingleinstance")
				{
					throw new InvalidOperationException(SR.GetString("SingleInstanceOnly", categoryName));
				}
			}
			else if (instanceName == "systemdiagnosticssharedsingleinstance")
			{
				throw new InvalidOperationException(SR.GetString("MultiInstanceOnly", categoryName));
			}
		}
		else if (instanceName == "systemdiagnosticssharedsingleinstance")
		{
			throw new InvalidOperationException(SR.GetString("MultiInstanceOnly", categoryName));
		}
		bool flag = activateUnusedInstances;
		if (activateUnusedInstances)
		{
			int totalSize = InstanceEntrySize + ProcessLifetimeEntrySize + 256 + CounterEntrySize * categoryData.CounterNames.Count;
			int oldOffset = *(int*)baseAddress;
			int alignmentAdjustment;
			int num = CalculateMemoryNoBoundsCheck(oldOffset, totalSize, out alignmentAdjustment);
			if (num <= FileView.FileMappingSize && num >= 0)
			{
				long num2 = DateTime.Now.Ticks - Volatile.Read(ref LastInstanceLifetimeSweepTick);
				if (num2 < 300000000)
				{
					flag = false;
				}
			}
		}
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Assert();
		try
		{
			while (true)
			{
				bool flag2 = false;
				if (flag && ptr->RefCount != 0)
				{
					flag2 = true;
					VerifyLifetime(ptr);
				}
				if (ptr->InstanceNameHashCode == instanceNameHashCode && StringEquals(instanceName, ptr->InstanceNameOffset))
				{
					*returnInstancePointerReference = ptr;
					CounterEntry* ptr3 = (CounterEntry*)ResolveOffset(ptr->FirstCounterOffset, CounterEntrySize);
					ProcessLifetimeEntry* ptr4 = (ProcessLifetimeEntry*)((!categoryData.UseUniqueSharedMemory) ? 0u : ResolveOffset(ptr3->LifetimeOffset, ProcessLifetimeEntrySize));
					if (!flag2 && ptr->RefCount != 0)
					{
						VerifyLifetime(ptr);
					}
					if (ptr->RefCount != 0)
					{
						if (ptr4 != null && ptr4->ProcessId != 0)
						{
							if (lifetime != PerformanceCounterInstanceLifetime.Process)
							{
								throw new InvalidOperationException(SR.GetString("CantConvertProcessToGlobal"));
							}
							if (ProcessData.ProcessId != ptr4->ProcessId)
							{
								throw new InvalidOperationException(SR.GetString("InstanceAlreadyExists", instanceName));
							}
							if (ptr4->StartupTime != -1 && ProcessData.StartupTime != -1 && ProcessData.StartupTime != ptr4->StartupTime)
							{
								throw new InvalidOperationException(SR.GetString("InstanceAlreadyExists", instanceName));
							}
						}
						else if (lifetime == PerformanceCounterInstanceLifetime.Process)
						{
							throw new InvalidOperationException(SR.GetString("CantConvertGlobalToProcess"));
						}
						return true;
					}
					if (activateUnusedInstances)
					{
						Mutex mutex = null;
						RuntimeHelpers.PrepareConstrainedRegions();
						try
						{
							SharedUtils.EnterMutexWithoutGlobal(categoryData.MutexName, ref mutex);
							ClearCounterValues(ptr);
							if (ptr4 != null)
							{
								PopulateLifetimeEntry(ptr4, lifetime);
							}
							ptr->RefCount = 1;
							return true;
						}
						finally
						{
							if (mutex != null)
							{
								mutex.ReleaseMutex();
								mutex.Close();
							}
						}
					}
					return false;
				}
				if (ptr->RefCount == 0)
				{
					foundFreeInstance = true;
				}
				ptr2 = ptr;
				if (ptr->NextInstanceOffset == 0)
				{
					break;
				}
				ptr = (InstanceEntry*)ResolveOffset(ptr->NextInstanceOffset, InstanceEntrySize);
			}
			*returnInstancePointerReference = ptr2;
			return false;
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
			if (flag)
			{
				Volatile.Write(ref LastInstanceLifetimeSweepTick, DateTime.Now.Ticks);
			}
		}
	}

	private unsafe bool TryReuseInstance(int instanceNameHashCode, string instanceName, CategoryEntry* categoryPointer, InstanceEntry** returnInstancePointerReference, PerformanceCounterInstanceLifetime lifetime, InstanceEntry* lockInstancePointer)
	{
		InstanceEntry* ptr = (InstanceEntry*)ResolveOffset(categoryPointer->FirstInstanceOffset, InstanceEntrySize);
		InstanceEntry* ptr2 = ptr;
		while (true)
		{
			if (ptr->RefCount == 0)
			{
				long num;
				bool flag;
				if (categoryData.UseUniqueSharedMemory)
				{
					num = ResolveOffset(ptr->InstanceNameOffset, 256);
					flag = true;
				}
				else
				{
					num = ResolveOffset(ptr->InstanceNameOffset, 0);
					int stringLength = GetStringLength((char*)num);
					flag = stringLength == instanceName.Length;
				}
				bool flag2 = lockInstancePointer == ptr || categoryData.UseUniqueSharedMemory;
				if (flag)
				{
					bool taken;
					if (flag2)
					{
						taken = true;
					}
					else
					{
						WaitAndEnterCriticalSection(&ptr->SpinLock, out taken);
					}
					if (taken)
					{
						try
						{
							SafeMarshalCopy(instanceName, (IntPtr)num);
							ptr->InstanceNameHashCode = instanceNameHashCode;
							*returnInstancePointerReference = ptr;
							ClearCounterValues(*returnInstancePointerReference);
							if (categoryData.UseUniqueSharedMemory)
							{
								CounterEntry* ptr3 = (CounterEntry*)ResolveOffset(ptr->FirstCounterOffset, CounterEntrySize);
								ProcessLifetimeEntry* lifetimeEntry = (ProcessLifetimeEntry*)ResolveOffset(ptr3->LifetimeOffset, ProcessLifetimeEntrySize);
								PopulateLifetimeEntry(lifetimeEntry, lifetime);
							}
							(*returnInstancePointerReference)->RefCount = 1;
							return true;
						}
						finally
						{
							if (!flag2)
							{
								ExitCriticalSection(&ptr->SpinLock);
							}
						}
					}
				}
			}
			ptr2 = ptr;
			if (ptr->NextInstanceOffset == 0)
			{
				break;
			}
			ptr = (InstanceEntry*)ResolveOffset(ptr->NextInstanceOffset, InstanceEntrySize);
		}
		*returnInstancePointerReference = ptr2;
		return false;
	}

	private unsafe void Verify(CategoryEntry* currentCategoryPointer)
	{
		if (!categoryData.UseUniqueSharedMemory)
		{
			return;
		}
		Mutex mutex = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			SharedUtils.EnterMutexWithoutGlobal(categoryData.MutexName, ref mutex);
			VerifyCategory(currentCategoryPointer);
		}
		finally
		{
			if (mutex != null)
			{
				mutex.ReleaseMutex();
				mutex.Close();
			}
		}
	}

	private unsafe void VerifyCategory(CategoryEntry* currentCategoryPointer)
	{
		int num = *(int*)baseAddress;
		ResolveOffset(num, 0);
		int num2 = ResolveAddress((long)currentCategoryPointer, CategoryEntrySize);
		if (num2 >= num)
		{
			currentCategoryPointer->SpinLock = 0;
			currentCategoryPointer->CategoryNameHashCode = 0;
			currentCategoryPointer->CategoryNameOffset = 0;
			currentCategoryPointer->FirstInstanceOffset = 0;
			currentCategoryPointer->NextCategoryOffset = 0;
			currentCategoryPointer->IsConsistent = 0;
			return;
		}
		if (currentCategoryPointer->NextCategoryOffset > num)
		{
			currentCategoryPointer->NextCategoryOffset = 0;
		}
		else if (currentCategoryPointer->NextCategoryOffset != 0)
		{
			VerifyCategory((CategoryEntry*)ResolveOffset(currentCategoryPointer->NextCategoryOffset, CategoryEntrySize));
		}
		if (currentCategoryPointer->FirstInstanceOffset != 0)
		{
			if (currentCategoryPointer->FirstInstanceOffset > num)
			{
				InstanceEntry* ptr = (InstanceEntry*)ResolveOffset(currentCategoryPointer->FirstInstanceOffset, InstanceEntrySize);
				currentCategoryPointer->FirstInstanceOffset = ptr->NextInstanceOffset;
				if (currentCategoryPointer->FirstInstanceOffset > num)
				{
					currentCategoryPointer->FirstInstanceOffset = 0;
				}
			}
			if (currentCategoryPointer->FirstInstanceOffset != 0)
			{
				VerifyInstance((InstanceEntry*)ResolveOffset(currentCategoryPointer->FirstInstanceOffset, InstanceEntrySize));
			}
		}
		currentCategoryPointer->IsConsistent = 1;
	}

	private unsafe void VerifyInstance(InstanceEntry* currentInstancePointer)
	{
		int num = *(int*)baseAddress;
		ResolveOffset(num, 0);
		if (currentInstancePointer->NextInstanceOffset > num)
		{
			currentInstancePointer->NextInstanceOffset = 0;
		}
		else if (currentInstancePointer->NextInstanceOffset != 0)
		{
			VerifyInstance((InstanceEntry*)ResolveOffset(currentInstancePointer->NextInstanceOffset, InstanceEntrySize));
		}
	}

	private unsafe void VerifyLifetime(InstanceEntry* currentInstancePointer)
	{
		CounterEntry* ptr = (CounterEntry*)ResolveOffset(currentInstancePointer->FirstCounterOffset, CounterEntrySize);
		if (ptr->LifetimeOffset == 0)
		{
			return;
		}
		ProcessLifetimeEntry* ptr2 = (ProcessLifetimeEntry*)ResolveOffset(ptr->LifetimeOffset, ProcessLifetimeEntrySize);
		if (ptr2->LifetimeType != 1)
		{
			return;
		}
		int processId = ptr2->ProcessId;
		long startupTime = ptr2->StartupTime;
		if (processId == 0)
		{
			return;
		}
		if (processId == ProcessData.ProcessId)
		{
			if (ProcessData.StartupTime != -1 && startupTime != -1 && ProcessData.StartupTime != startupTime)
			{
				currentInstancePointer->RefCount = 0;
			}
			return;
		}
		using (SafeProcessHandle safeProcessHandle = SafeProcessHandle.OpenProcess(1024, inherit: false, processId))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error == 87 && safeProcessHandle.IsInvalid)
			{
				currentInstancePointer->RefCount = 0;
				return;
			}
			if (!safeProcessHandle.IsInvalid && startupTime != -1 && Microsoft.Win32.NativeMethods.GetProcessTimes(safeProcessHandle, out var creation, out var exit, out exit, out exit) && creation != startupTime)
			{
				currentInstancePointer->RefCount = 0;
				return;
			}
		}
		using SafeProcessHandle safeProcessHandle2 = SafeProcessHandle.OpenProcess(1048576, inherit: false, processId);
		if (safeProcessHandle2.IsInvalid)
		{
			return;
		}
		using ProcessWaitHandle processWaitHandle = new ProcessWaitHandle(safeProcessHandle2);
		if (processWaitHandle.WaitOne(0, exitContext: false))
		{
			currentInstancePointer->RefCount = 0;
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal unsafe long IncrementBy(long value)
	{
		if (counterEntryPointer == null)
		{
			return 0L;
		}
		CounterEntry* counterEntry = counterEntryPointer;
		return AddToValue(counterEntry, value);
	}

	internal unsafe long Increment()
	{
		if (counterEntryPointer == null)
		{
			return 0L;
		}
		return IncrementUnaligned(counterEntryPointer);
	}

	internal unsafe long Decrement()
	{
		if (counterEntryPointer == null)
		{
			return 0L;
		}
		return DecrementUnaligned(counterEntryPointer);
	}

	internal static void RemoveAllInstances(string categoryName)
	{
		SharedPerformanceCounter sharedPerformanceCounter = new SharedPerformanceCounter(categoryName, null, null);
		sharedPerformanceCounter.RemoveAllInstances();
		RemoveCategoryData(categoryName);
	}

	private unsafe void RemoveAllInstances()
	{
		CategoryEntry* ptr = default(CategoryEntry*);
		if (!FindCategory(&ptr))
		{
			return;
		}
		InstanceEntry* ptr2 = (InstanceEntry*)ResolveOffset(ptr->FirstInstanceOffset, InstanceEntrySize);
		Mutex mutex = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			SharedUtils.EnterMutexWithoutGlobal(categoryData.MutexName, ref mutex);
			while (true)
			{
				RemoveOneInstance(ptr2, clearValue: true);
				if (ptr2->NextInstanceOffset != 0)
				{
					ptr2 = (InstanceEntry*)ResolveOffset(ptr2->NextInstanceOffset, InstanceEntrySize);
					continue;
				}
				break;
			}
		}
		finally
		{
			if (mutex != null)
			{
				mutex.ReleaseMutex();
				mutex.Close();
			}
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal unsafe void RemoveInstance(string instanceName, PerformanceCounterInstanceLifetime instanceLifetime)
	{
		if (instanceName == null || instanceName.Length == 0)
		{
			return;
		}
		int wstrHashCode = GetWstrHashCode(instanceName);
		CategoryEntry* categoryPointer = default(CategoryEntry*);
		if (!FindCategory(&categoryPointer))
		{
			return;
		}
		InstanceEntry* ptr = null;
		bool flag = false;
		Mutex mutex = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			SharedUtils.EnterMutexWithoutGlobal(categoryData.MutexName, ref mutex);
			if (thisInstanceOffset != -1)
			{
				try
				{
					ptr = (InstanceEntry*)ResolveOffset(thisInstanceOffset, InstanceEntrySize);
					if (ptr->InstanceNameHashCode == wstrHashCode && StringEquals(instanceName, ptr->InstanceNameOffset))
					{
						flag = true;
						CounterEntry* ptr2 = (CounterEntry*)ResolveOffset(ptr->FirstCounterOffset, CounterEntrySize);
						if (categoryData.UseUniqueSharedMemory)
						{
							ProcessLifetimeEntry* ptr3 = (ProcessLifetimeEntry*)ResolveOffset(ptr2->LifetimeOffset, ProcessLifetimeEntrySize);
							if (ptr3 != null && ptr3->LifetimeType == 1 && ptr3->ProcessId != 0)
							{
								flag = flag && instanceLifetime == PerformanceCounterInstanceLifetime.Process;
								flag &= ProcessData.ProcessId == ptr3->ProcessId;
								if (ptr3->StartupTime != -1 && ProcessData.StartupTime != -1)
								{
									flag &= ProcessData.StartupTime == ptr3->StartupTime;
								}
							}
							else
							{
								flag = flag && instanceLifetime != PerformanceCounterInstanceLifetime.Process;
							}
						}
					}
				}
				catch (InvalidOperationException)
				{
					flag = false;
				}
				if (!flag)
				{
					thisInstanceOffset = -1;
				}
			}
			if ((flag || FindInstance(wstrHashCode, instanceName, categoryPointer, &ptr, activateUnusedInstances: false, instanceLifetime, out var _)) && ptr != null)
			{
				RemoveOneInstance(ptr, clearValue: false);
			}
		}
		finally
		{
			if (mutex != null)
			{
				mutex.ReleaseMutex();
				mutex.Close();
			}
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	private unsafe void RemoveOneInstance(InstanceEntry* instancePointer, bool clearValue)
	{
		bool taken = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			if (!categoryData.UseUniqueSharedMemory)
			{
				while (!taken)
				{
					WaitAndEnterCriticalSection(&instancePointer->SpinLock, out taken);
				}
			}
			instancePointer->RefCount = 0;
			if (clearValue)
			{
				ClearCounterValues(instancePointer);
			}
		}
		finally
		{
			if (taken)
			{
				ExitCriticalSection(&instancePointer->SpinLock);
			}
		}
	}

	private unsafe void ClearCounterValues(InstanceEntry* instancePointer)
	{
		CounterEntry* ptr = null;
		if (instancePointer->FirstCounterOffset != 0)
		{
			ptr = (CounterEntry*)ResolveOffset(instancePointer->FirstCounterOffset, CounterEntrySize);
		}
		while (ptr != null)
		{
			SetValue(ptr, 0L);
			ptr = (CounterEntry*)((ptr->NextCounterOffset == 0) ? 0u : ResolveOffset(ptr->NextCounterOffset, CounterEntrySize));
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private unsafe static long AddToValue(CounterEntry* counterEntry, long addend)
	{
		if (IsMisaligned(counterEntry))
		{
			ulong num = (uint)((CounterEntryMisaligned*)counterEntry)->Value_hi;
			num <<= 32;
			num |= (uint)((CounterEntryMisaligned*)counterEntry)->Value_lo;
			num += (ulong)addend;
			((CounterEntryMisaligned*)counterEntry)->Value_hi = (int)(num >> 32);
			((CounterEntryMisaligned*)counterEntry)->Value_lo = (int)(num & 0xFFFFFFFFu);
			return (long)num;
		}
		return Interlocked.Add(ref counterEntry->Value, addend);
	}

	private unsafe static long DecrementUnaligned(CounterEntry* counterEntry)
	{
		if (IsMisaligned(counterEntry))
		{
			return AddToValue(counterEntry, -1L);
		}
		return Interlocked.Decrement(ref counterEntry->Value);
	}

	private unsafe static long GetValue(CounterEntry* counterEntry)
	{
		if (IsMisaligned(counterEntry))
		{
			ulong num = (uint)((CounterEntryMisaligned*)counterEntry)->Value_hi;
			num <<= 32;
			return (long)(num | (uint)((CounterEntryMisaligned*)counterEntry)->Value_lo);
		}
		return counterEntry->Value;
	}

	private unsafe static long IncrementUnaligned(CounterEntry* counterEntry)
	{
		if (IsMisaligned(counterEntry))
		{
			return AddToValue(counterEntry, 1L);
		}
		return Interlocked.Increment(ref counterEntry->Value);
	}

	private unsafe static void SetValue(CounterEntry* counterEntry, long value)
	{
		if (IsMisaligned(counterEntry))
		{
			((CounterEntryMisaligned*)counterEntry)->Value_lo = (int)(value & 0xFFFFFFFFu);
			((CounterEntryMisaligned*)counterEntry)->Value_hi = (int)(value >> 32);
		}
		else
		{
			counterEntry->Value = value;
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private unsafe static bool IsMisaligned(CounterEntry* counterEntry)
	{
		return ((ulong)counterEntry & 7uL) != 0;
	}

	private long ResolveOffset(int offset, int sizeToRead)
	{
		if (offset > FileView.FileMappingSize - sizeToRead || offset < 0)
		{
			throw new InvalidOperationException(SR.GetString("MappingCorrupted"));
		}
		return baseAddress + offset;
	}

	private int ResolveAddress(long address, int sizeToRead)
	{
		int num = (int)(address - baseAddress);
		if (num > FileView.FileMappingSize - sizeToRead || num < 0)
		{
			throw new InvalidOperationException(SR.GetString("MappingCorrupted"));
		}
		return num;
	}

	private static void SafeMarshalCopy(string str, IntPtr nativePointer)
	{
		char[] array = new char[str.Length + 1];
		str.CopyTo(0, array, 0, str.Length);
		array[str.Length] = '\0';
		Marshal.Copy(array, 0, nativePointer, array.Length);
	}
}
