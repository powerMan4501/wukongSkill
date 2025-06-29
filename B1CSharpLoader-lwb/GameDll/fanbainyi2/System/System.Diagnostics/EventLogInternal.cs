using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Diagnostics;

internal class EventLogInternal : IDisposable, ISupportInitialize
{
	private class LogListeningInfo
	{
		public EventLogInternal handleOwner;

		public RegisteredWaitHandle registeredWaitHandle;

		public WaitHandle waitHandle;

		public ArrayList listeningComponents = new ArrayList();
	}

	private EventLogEntryCollection entriesCollection;

	internal string logName;

	private int lastSeenCount;

	internal readonly string machineName;

	internal EntryWrittenEventHandler onEntryWrittenHandler;

	private SafeEventLogReadHandle readHandle;

	internal readonly string sourceName;

	private SafeEventLogWriteHandle writeHandle;

	private string logDisplayName;

	private const int BUF_SIZE = 40000;

	private int bytesCached;

	private byte[] cache;

	private int firstCachedEntry = -1;

	private int lastSeenEntry;

	private int lastSeenPos;

	private ISynchronizeInvoke synchronizingObject;

	private readonly EventLog parent;

	private const string EventLogKey = "SYSTEM\\CurrentControlSet\\Services\\EventLog";

	internal const string DllName = "EventLogMessages.dll";

	private const string eventLogMutexName = "netfxeventlog.1.0";

	private const int SecondsPerDay = 86400;

	private const int DefaultMaxSize = 524288;

	private const int DefaultRetention = 604800;

	private const int Flag_notifying = 1;

	private const int Flag_forwards = 2;

	private const int Flag_initializing = 4;

	internal const int Flag_monitoring = 8;

	private const int Flag_registeredAsListener = 16;

	private const int Flag_writeGranted = 32;

	private const int Flag_disposed = 256;

	private const int Flag_sourceVerified = 512;

	private BitVector32 boolFlags;

	private Hashtable messageLibraries;

	private static readonly Hashtable listenerInfos = new Hashtable(StringComparer.OrdinalIgnoreCase);

	private object m_InstanceLockObject;

	private static object s_InternalSyncObject;

	private object InstanceLockObject
	{
		get
		{
			if (m_InstanceLockObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange(ref m_InstanceLockObject, value, null);
			}
			return m_InstanceLockObject;
		}
	}

	private static object InternalSyncObject
	{
		get
		{
			if (s_InternalSyncObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange(ref s_InternalSyncObject, value, null);
			}
			return s_InternalSyncObject;
		}
	}

	public EventLogEntryCollection Entries
	{
		get
		{
			string text = machineName;
			EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Administer, text);
			eventLogPermission.Demand();
			if (entriesCollection == null)
			{
				entriesCollection = new EventLogEntryCollection(this);
			}
			return entriesCollection;
		}
	}

	internal int EntryCount
	{
		get
		{
			if (!IsOpenForRead)
			{
				OpenForRead(machineName);
			}
			if (!Microsoft.Win32.UnsafeNativeMethods.GetNumberOfEventLogRecords(readHandle, out var count))
			{
				throw SharedUtils.CreateSafeWin32Exception();
			}
			return count;
		}
	}

	private bool IsOpen
	{
		get
		{
			if (readHandle == null)
			{
				return writeHandle != null;
			}
			return true;
		}
	}

	private bool IsOpenForRead => readHandle != null;

	private bool IsOpenForWrite => writeHandle != null;

	public string LogDisplayName
	{
		get
		{
			if (logDisplayName != null)
			{
				return logDisplayName;
			}
			string text = machineName;
			if (GetLogName(text) != null)
			{
				EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Administer, text);
				eventLogPermission.Demand();
				SharedUtils.CheckEnvironment();
				PermissionSet permissionSet = EventLog._UnsafeGetAssertPermSet();
				permissionSet.Assert();
				RegistryKey registryKey = null;
				try
				{
					registryKey = GetLogRegKey(text, writable: false);
					if (registryKey == null)
					{
						throw new InvalidOperationException(SR.GetString("MissingLog", GetLogName(text), text));
					}
					string text2 = (string)registryKey.GetValue("DisplayNameFile");
					if (text2 == null)
					{
						logDisplayName = GetLogName(text);
					}
					else
					{
						int messageNum = (int)registryKey.GetValue("DisplayNameID");
						logDisplayName = FormatMessageWrapper(text2, (uint)messageNum, null);
						if (logDisplayName == null)
						{
							logDisplayName = GetLogName(text);
						}
					}
				}
				finally
				{
					registryKey?.Close();
					CodeAccessPermission.RevertAssert();
				}
			}
			return logDisplayName;
		}
	}

	public string Log
	{
		get
		{
			string currentMachineName = machineName;
			if (logName == null || logName.Length == 0)
			{
				EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Administer, currentMachineName);
				eventLogPermission.Demand();
			}
			return GetLogName(currentMachineName);
		}
	}

	public string MachineName
	{
		get
		{
			string result = machineName;
			EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Write, result);
			eventLogPermission.Demand();
			return result;
		}
	}

	[ComVisible(false)]
	public long MaximumKilobytes
	{
		get
		{
			string currentMachineName = machineName;
			EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Administer, currentMachineName);
			eventLogPermission.Demand();
			object logRegValue = GetLogRegValue(currentMachineName, "MaxSize");
			if (logRegValue != null)
			{
				int num = (int)logRegValue;
				return (uint)num / 1024u;
			}
			return 512L;
		}
		set
		{
			string currentMachineName = machineName;
			EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Administer, currentMachineName);
			eventLogPermission.Demand();
			if (value < 64 || value > 4194240 || value % 64 != 0L)
			{
				throw new ArgumentOutOfRangeException("MaximumKilobytes", SR.GetString("MaximumKilobytesOutOfRange"));
			}
			PermissionSet permissionSet = EventLog._UnsafeGetAssertPermSet();
			permissionSet.Assert();
			long num = value * 1024;
			int num2 = (int)num;
			using RegistryKey registryKey = GetLogRegKey(currentMachineName, writable: true);
			registryKey.SetValue("MaxSize", num2, RegistryValueKind.DWord);
		}
	}

	internal Hashtable MessageLibraries
	{
		get
		{
			if (messageLibraries == null)
			{
				messageLibraries = new Hashtable(StringComparer.OrdinalIgnoreCase);
			}
			return messageLibraries;
		}
	}

	[ComVisible(false)]
	public OverflowAction OverflowAction
	{
		get
		{
			string currentMachineName = machineName;
			EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Administer, currentMachineName);
			eventLogPermission.Demand();
			object logRegValue = GetLogRegValue(currentMachineName, "Retention");
			if (logRegValue != null)
			{
				return (int)logRegValue switch
				{
					0 => OverflowAction.OverwriteAsNeeded, 
					-1 => OverflowAction.DoNotOverwrite, 
					_ => OverflowAction.OverwriteOlder, 
				};
			}
			return OverflowAction.OverwriteOlder;
		}
	}

	[ComVisible(false)]
	public int MinimumRetentionDays
	{
		get
		{
			string currentMachineName = machineName;
			EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Administer, currentMachineName);
			eventLogPermission.Demand();
			object logRegValue = GetLogRegValue(currentMachineName, "Retention");
			if (logRegValue != null)
			{
				int num = (int)logRegValue;
				if (num == 0 || num == -1)
				{
					return num;
				}
				return (int)((double)num / 86400.0);
			}
			return 7;
		}
	}

	public bool EnableRaisingEvents
	{
		get
		{
			string text = machineName;
			EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Write, text);
			eventLogPermission.Demand();
			return boolFlags[8];
		}
		set
		{
			string currentMachineName = machineName;
			EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Write, currentMachineName);
			eventLogPermission.Demand();
			if (parent.ComponentDesignMode)
			{
				boolFlags[8] = value;
			}
			else if (value)
			{
				StartRaisingEvents(currentMachineName, GetLogName(currentMachineName));
			}
			else
			{
				StopRaisingEvents(GetLogName(currentMachineName));
			}
		}
	}

	private int OldestEntryNumber
	{
		get
		{
			if (!IsOpenForRead)
			{
				OpenForRead(machineName);
			}
			if (!Microsoft.Win32.UnsafeNativeMethods.GetOldestEventLogRecord(readHandle, out var number))
			{
				throw SharedUtils.CreateSafeWin32Exception();
			}
			if (number == 0)
			{
				return 1;
			}
			return number;
		}
	}

	internal SafeEventLogReadHandle ReadHandle
	{
		get
		{
			if (!IsOpenForRead)
			{
				OpenForRead(machineName);
			}
			return readHandle;
		}
	}

	public ISynchronizeInvoke SynchronizingObject
	{
		[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
		get
		{
			string text = machineName;
			EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Write, text);
			eventLogPermission.Demand();
			if (synchronizingObject == null && parent.ComponentDesignMode)
			{
				IDesignerHost designerHost = (IDesignerHost)parent.ComponentGetService(typeof(IDesignerHost));
				if (designerHost != null)
				{
					object rootComponent = designerHost.RootComponent;
					if (rootComponent != null && rootComponent is ISynchronizeInvoke)
					{
						synchronizingObject = (ISynchronizeInvoke)rootComponent;
					}
				}
			}
			return synchronizingObject;
		}
		set
		{
			synchronizingObject = value;
		}
	}

	public string Source
	{
		get
		{
			string text = machineName;
			EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Write, text);
			eventLogPermission.Demand();
			return sourceName;
		}
	}

	public event EntryWrittenEventHandler EntryWritten
	{
		add
		{
			string text = machineName;
			EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Administer, text);
			eventLogPermission.Demand();
			onEntryWrittenHandler = (EntryWrittenEventHandler)Delegate.Combine(onEntryWrittenHandler, value);
		}
		remove
		{
			string text = machineName;
			EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Administer, text);
			eventLogPermission.Demand();
			onEntryWrittenHandler = (EntryWrittenEventHandler)Delegate.Remove(onEntryWrittenHandler, value);
		}
	}

	public EventLogInternal()
		: this("", ".", "", null)
	{
	}

	public EventLogInternal(string logName)
		: this(logName, ".", "", null)
	{
	}

	public EventLogInternal(string logName, string machineName)
		: this(logName, machineName, "", null)
	{
	}

	public EventLogInternal(string logName, string machineName, string source)
		: this(logName, machineName, source, null)
	{
	}

	public EventLogInternal(string logName, string machineName, string source, EventLog parent)
	{
		if (logName == null)
		{
			throw new ArgumentNullException("logName");
		}
		if (!ValidLogName(logName, ignoreEmpty: true))
		{
			throw new ArgumentException(SR.GetString("BadLogName"));
		}
		if (!SyntaxCheck.CheckMachineName(machineName))
		{
			throw new ArgumentException(SR.GetString("InvalidParameter", "machineName", machineName));
		}
		EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Write, machineName);
		eventLogPermission.Demand();
		this.machineName = machineName;
		this.logName = logName;
		sourceName = source;
		readHandle = null;
		writeHandle = null;
		boolFlags[2] = true;
		this.parent = parent;
	}

	private string GetLogName(string currentMachineName)
	{
		if ((logName == null || logName.Length == 0) && sourceName != null && sourceName.Length != 0)
		{
			EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Write, currentMachineName);
			eventLogPermission.Demand();
			logName = EventLog._InternalLogNameFromSourceName(sourceName, currentMachineName);
		}
		return logName;
	}

	[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
	private static void AddListenerComponent(EventLogInternal component, string compMachineName, string compLogName)
	{
		lock (InternalSyncObject)
		{
			LogListeningInfo logListeningInfo = (LogListeningInfo)listenerInfos[compLogName];
			if (logListeningInfo != null)
			{
				logListeningInfo.listeningComponents.Add(component);
				return;
			}
			logListeningInfo = new LogListeningInfo();
			logListeningInfo.listeningComponents.Add(component);
			logListeningInfo.handleOwner = new EventLogInternal(compLogName, compMachineName);
			logListeningInfo.waitHandle = new AutoResetEvent(initialState: false);
			if (!Microsoft.Win32.UnsafeNativeMethods.NotifyChangeEventLog(logListeningInfo.handleOwner.ReadHandle, logListeningInfo.waitHandle.SafeWaitHandle))
			{
				throw new InvalidOperationException(SR.GetString("CantMonitorEventLog"), SharedUtils.CreateSafeWin32Exception());
			}
			logListeningInfo.registeredWaitHandle = ThreadPool.RegisterWaitForSingleObject(logListeningInfo.waitHandle, StaticCompletionCallback, logListeningInfo, -1, executeOnlyOnce: false);
			listenerInfos[compLogName] = logListeningInfo;
		}
	}

	public void BeginInit()
	{
		string currentMachineName = machineName;
		EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Write, currentMachineName);
		eventLogPermission.Demand();
		if (boolFlags[4])
		{
			throw new InvalidOperationException(SR.GetString("InitTwice"));
		}
		boolFlags[4] = true;
		if (boolFlags[8])
		{
			StopListening(GetLogName(currentMachineName));
		}
	}

	public void Clear()
	{
		string currentMachineName = machineName;
		EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Administer, currentMachineName);
		eventLogPermission.Demand();
		if (!IsOpenForRead)
		{
			OpenForRead(currentMachineName);
		}
		if (!Microsoft.Win32.UnsafeNativeMethods.ClearEventLog(readHandle, Microsoft.Win32.NativeMethods.NullHandleRef))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error != 2)
			{
				throw SharedUtils.CreateSafeWin32Exception();
			}
		}
		Reset(currentMachineName);
	}

	public void Close()
	{
		Close(machineName);
	}

	private void Close(string currentMachineName)
	{
		EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Write, currentMachineName);
		eventLogPermission.Demand();
		if (readHandle != null)
		{
			try
			{
				readHandle.Close();
			}
			catch (IOException)
			{
				throw SharedUtils.CreateSafeWin32Exception();
			}
			readHandle = null;
		}
		if (writeHandle != null)
		{
			try
			{
				writeHandle.Close();
			}
			catch (IOException)
			{
				throw SharedUtils.CreateSafeWin32Exception();
			}
			writeHandle = null;
		}
		if (boolFlags[8])
		{
			StopRaisingEvents(GetLogName(currentMachineName));
		}
		if (messageLibraries != null)
		{
			foreach (Microsoft.Win32.SafeHandles.SafeLibraryHandle value in messageLibraries.Values)
			{
				value.Close();
			}
			messageLibraries = null;
		}
		boolFlags[512] = false;
	}

	private void CompletionCallback(object context)
	{
		if (boolFlags[256])
		{
			return;
		}
		lock (InstanceLockObject)
		{
			if (boolFlags[1])
			{
				return;
			}
			boolFlags[1] = true;
		}
		int i = lastSeenCount;
		try
		{
			int oldestEntryNumber = OldestEntryNumber;
			int num = EntryCount + oldestEntryNumber;
			if (lastSeenCount < oldestEntryNumber || lastSeenCount > num)
			{
				lastSeenCount = oldestEntryNumber;
				i = lastSeenCount;
			}
			while (i < num)
			{
				for (; i < num; i++)
				{
					EventLogEntry entryWithOldest = GetEntryWithOldest(i);
					if (SynchronizingObject != null && SynchronizingObject.InvokeRequired)
					{
						SynchronizingObject.BeginInvoke(onEntryWrittenHandler, new object[2]
						{
							this,
							new EntryWrittenEventArgs(entryWithOldest)
						});
					}
					else
					{
						onEntryWrittenHandler(this, new EntryWrittenEventArgs(entryWithOldest));
					}
				}
				oldestEntryNumber = OldestEntryNumber;
				num = EntryCount + oldestEntryNumber;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			int num2 = EntryCount + OldestEntryNumber;
			if (i > num2)
			{
				lastSeenCount = num2;
			}
			else
			{
				lastSeenCount = i;
			}
		}
		catch (Win32Exception)
		{
		}
		lock (InstanceLockObject)
		{
			boolFlags[1] = false;
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	internal void Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				if (IsOpen)
				{
					Close();
				}
				if (readHandle != null)
				{
					readHandle.Close();
					readHandle = null;
				}
				if (writeHandle != null)
				{
					writeHandle.Close();
					writeHandle = null;
				}
			}
		}
		finally
		{
			messageLibraries = null;
			boolFlags[256] = true;
		}
	}

	public void EndInit()
	{
		string currentMachineName = machineName;
		EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Write, currentMachineName);
		eventLogPermission.Demand();
		boolFlags[4] = false;
		if (boolFlags[8])
		{
			StartListening(currentMachineName, GetLogName(currentMachineName));
		}
	}

	internal string FormatMessageWrapper(string dllNameList, uint messageNum, string[] insertionStrings)
	{
		if (dllNameList == null)
		{
			return null;
		}
		if (insertionStrings == null)
		{
			insertionStrings = new string[0];
		}
		string[] array = dllNameList.Split(';');
		string[] array2 = array;
		foreach (string text in array2)
		{
			if (text == null || text.Length == 0)
			{
				continue;
			}
			Microsoft.Win32.SafeHandles.SafeLibraryHandle safeLibraryHandle = null;
			if (IsOpen)
			{
				safeLibraryHandle = MessageLibraries[text] as Microsoft.Win32.SafeHandles.SafeLibraryHandle;
				if (safeLibraryHandle == null || safeLibraryHandle.IsInvalid)
				{
					safeLibraryHandle = Microsoft.Win32.SafeHandles.SafeLibraryHandle.LoadLibraryEx(text, IntPtr.Zero, 2);
					MessageLibraries[text] = safeLibraryHandle;
				}
			}
			else
			{
				safeLibraryHandle = Microsoft.Win32.SafeHandles.SafeLibraryHandle.LoadLibraryEx(text, IntPtr.Zero, 2);
			}
			if (safeLibraryHandle.IsInvalid)
			{
				continue;
			}
			string text2 = null;
			try
			{
				text2 = EventLog.TryFormatMessage(safeLibraryHandle, messageNum, insertionStrings);
			}
			finally
			{
				if (!IsOpen)
				{
					safeLibraryHandle.Close();
				}
			}
			if (text2 != null)
			{
				return text2;
			}
		}
		return null;
	}

	internal EventLogEntry[] GetAllEntries()
	{
		string currentMachineName = machineName;
		if (!IsOpenForRead)
		{
			OpenForRead(currentMachineName);
		}
		EventLogEntry[] array = new EventLogEntry[EntryCount];
		int num = 0;
		int oldestEntryNumber = OldestEntryNumber;
		int num2 = 0;
		while (num < array.Length)
		{
			byte[] array2 = new byte[40000];
			if (!Microsoft.Win32.UnsafeNativeMethods.ReadEventLog(readHandle, 6, oldestEntryNumber + num, array2, array2.Length, out var bytesRead, out var minNumOfBytesNeeded))
			{
				num2 = Marshal.GetLastWin32Error();
				if (num2 != 122 && num2 != 1503)
				{
					break;
				}
				if (num2 == 1503)
				{
					Reset(currentMachineName);
				}
				else if (minNumOfBytesNeeded > array2.Length)
				{
					array2 = new byte[minNumOfBytesNeeded];
				}
				if (!Microsoft.Win32.UnsafeNativeMethods.ReadEventLog(readHandle, 6, oldestEntryNumber + num, array2, array2.Length, out bytesRead, out minNumOfBytesNeeded))
				{
					break;
				}
				num2 = 0;
			}
			array[num] = new EventLogEntry(array2, 0, this);
			int num3 = IntFrom(array2, 0);
			num++;
			while (num3 < bytesRead && num < array.Length)
			{
				array[num] = new EventLogEntry(array2, num3, this);
				num3 += IntFrom(array2, num3);
				num++;
			}
		}
		if (num != array.Length)
		{
			if (num2 != 0)
			{
				throw new InvalidOperationException(SR.GetString("CantRetrieveEntries"), SharedUtils.CreateSafeWin32Exception(num2));
			}
			throw new InvalidOperationException(SR.GetString("CantRetrieveEntries"));
		}
		return array;
	}

	private int GetCachedEntryPos(int entryIndex)
	{
		if (cache == null || (boolFlags[2] && entryIndex < firstCachedEntry) || (!boolFlags[2] && entryIndex > firstCachedEntry) || firstCachedEntry == -1)
		{
			return -1;
		}
		while (lastSeenEntry < entryIndex)
		{
			lastSeenEntry++;
			if (boolFlags[2])
			{
				lastSeenPos = GetNextEntryPos(lastSeenPos);
				if (lastSeenPos >= bytesCached)
				{
					break;
				}
			}
			else
			{
				lastSeenPos = GetPreviousEntryPos(lastSeenPos);
				if (lastSeenPos < 0)
				{
					break;
				}
			}
		}
		while (lastSeenEntry > entryIndex)
		{
			lastSeenEntry--;
			if (boolFlags[2])
			{
				lastSeenPos = GetPreviousEntryPos(lastSeenPos);
				if (lastSeenPos < 0)
				{
					break;
				}
			}
			else
			{
				lastSeenPos = GetNextEntryPos(lastSeenPos);
				if (lastSeenPos >= bytesCached)
				{
					break;
				}
			}
		}
		if (lastSeenPos >= bytesCached)
		{
			lastSeenPos = GetPreviousEntryPos(lastSeenPos);
			if (boolFlags[2])
			{
				lastSeenEntry--;
			}
			else
			{
				lastSeenEntry++;
			}
			return -1;
		}
		if (lastSeenPos < 0)
		{
			lastSeenPos = 0;
			if (boolFlags[2])
			{
				lastSeenEntry++;
			}
			else
			{
				lastSeenEntry--;
			}
			return -1;
		}
		return lastSeenPos;
	}

	internal EventLogEntry GetEntryAt(int index)
	{
		EventLogEntry entryAtNoThrow = GetEntryAtNoThrow(index);
		if (entryAtNoThrow == null)
		{
			throw new ArgumentException(SR.GetString("IndexOutOfBounds", index.ToString(CultureInfo.CurrentCulture)));
		}
		return entryAtNoThrow;
	}

	internal EventLogEntry GetEntryAtNoThrow(int index)
	{
		if (!IsOpenForRead)
		{
			OpenForRead(machineName);
		}
		if (index < 0 || index >= EntryCount)
		{
			return null;
		}
		index += OldestEntryNumber;
		EventLogEntry result = null;
		try
		{
			result = GetEntryWithOldest(index);
		}
		catch (InvalidOperationException)
		{
		}
		return result;
	}

	private EventLogEntry GetEntryWithOldest(int index)
	{
		EventLogEntry eventLogEntry = null;
		int cachedEntryPos = GetCachedEntryPos(index);
		if (cachedEntryPos >= 0)
		{
			return new EventLogEntry(cache, cachedEntryPos, this);
		}
		string currentMachineName = machineName;
		int num = 0;
		if (GetCachedEntryPos(index + 1) < 0)
		{
			num = 6;
			boolFlags[2] = true;
		}
		else
		{
			num = 10;
			boolFlags[2] = false;
		}
		cache = new byte[40000];
		int bytesRead;
		int minNumOfBytesNeeded;
		bool flag = Microsoft.Win32.UnsafeNativeMethods.ReadEventLog(readHandle, num, index, cache, cache.Length, out bytesRead, out minNumOfBytesNeeded);
		if (!flag)
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error == 122 || lastWin32Error == 1503)
			{
				if (lastWin32Error == 1503)
				{
					byte[] array = cache;
					Reset(currentMachineName);
					cache = array;
				}
				else if (minNumOfBytesNeeded > cache.Length)
				{
					cache = new byte[minNumOfBytesNeeded];
				}
				flag = Microsoft.Win32.UnsafeNativeMethods.ReadEventLog(readHandle, 6, index, cache, cache.Length, out bytesRead, out minNumOfBytesNeeded);
			}
			if (!flag)
			{
				throw new InvalidOperationException(SR.GetString("CantReadLogEntryAt", index.ToString(CultureInfo.CurrentCulture)), SharedUtils.CreateSafeWin32Exception());
			}
		}
		bytesCached = bytesRead;
		firstCachedEntry = index;
		lastSeenEntry = index;
		lastSeenPos = 0;
		return new EventLogEntry(cache, 0, this);
	}

	internal static RegistryKey GetEventLogRegKey(string machine, bool writable)
	{
		RegistryKey registryKey = null;
		try
		{
			registryKey = ((!machine.Equals(".")) ? RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, machine) : Registry.LocalMachine);
			if (registryKey != null)
			{
				return registryKey.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\EventLog", writable);
			}
		}
		finally
		{
			registryKey?.Close();
		}
		return null;
	}

	private RegistryKey GetLogRegKey(string currentMachineName, bool writable)
	{
		string text = GetLogName(currentMachineName);
		if (!ValidLogName(text, ignoreEmpty: false))
		{
			throw new InvalidOperationException(SR.GetString("BadLogName"));
		}
		RegistryKey registryKey = null;
		RegistryKey registryKey2 = null;
		try
		{
			registryKey = GetEventLogRegKey(currentMachineName, writable: false);
			if (registryKey == null)
			{
				throw new InvalidOperationException(SR.GetString("RegKeyMissingShort", "SYSTEM\\CurrentControlSet\\Services\\EventLog", currentMachineName));
			}
			registryKey2 = registryKey.OpenSubKey(text, writable);
			if (registryKey2 == null)
			{
				throw new InvalidOperationException(SR.GetString("MissingLog", text, currentMachineName));
			}
			return registryKey2;
		}
		finally
		{
			registryKey?.Close();
		}
	}

	private object GetLogRegValue(string currentMachineName, string valuename)
	{
		PermissionSet permissionSet = EventLog._UnsafeGetAssertPermSet();
		permissionSet.Assert();
		RegistryKey registryKey = null;
		try
		{
			registryKey = GetLogRegKey(currentMachineName, writable: false);
			if (registryKey == null)
			{
				throw new InvalidOperationException(SR.GetString("MissingLog", GetLogName(currentMachineName), currentMachineName));
			}
			return registryKey.GetValue(valuename);
		}
		finally
		{
			registryKey?.Close();
			CodeAccessPermission.RevertAssert();
		}
	}

	private int GetNextEntryPos(int pos)
	{
		return pos + IntFrom(cache, pos);
	}

	private int GetPreviousEntryPos(int pos)
	{
		return pos - IntFrom(cache, pos - 4);
	}

	internal static string GetDllPath(string machineName)
	{
		return Path.Combine(SharedUtils.GetLatestBuildDllDirectory(machineName), "EventLogMessages.dll");
	}

	private static int IntFrom(byte[] buf, int offset)
	{
		return (-16777216 & (buf[offset + 3] << 24)) | (0xFF0000 & (buf[offset + 2] << 16)) | (0xFF00 & (buf[offset + 1] << 8)) | (0xFF & buf[offset]);
	}

	[ComVisible(false)]
	public void ModifyOverflowPolicy(OverflowAction action, int retentionDays)
	{
		string currentMachineName = machineName;
		EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Administer, currentMachineName);
		eventLogPermission.Demand();
		if (action < OverflowAction.DoNotOverwrite || action > OverflowAction.OverwriteOlder)
		{
			throw new InvalidEnumArgumentException("action", (int)action, typeof(OverflowAction));
		}
		long num = (long)action;
		if (action == OverflowAction.OverwriteOlder)
		{
			if (retentionDays < 1 || retentionDays > 365)
			{
				throw new ArgumentOutOfRangeException(SR.GetString("RentionDaysOutOfRange"));
			}
			num = (long)retentionDays * 86400L;
		}
		PermissionSet permissionSet = EventLog._UnsafeGetAssertPermSet();
		permissionSet.Assert();
		using RegistryKey registryKey = GetLogRegKey(currentMachineName, writable: true);
		registryKey.SetValue("Retention", num, RegistryValueKind.DWord);
	}

	private void OpenForRead(string currentMachineName)
	{
		EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Administer, currentMachineName);
		eventLogPermission.Demand();
		if (boolFlags[256])
		{
			throw new ObjectDisposedException(GetType().Name);
		}
		string text = GetLogName(currentMachineName);
		if (text == null || text.Length == 0)
		{
			throw new ArgumentException(SR.GetString("MissingLogProperty"));
		}
		if (!EventLog.Exists(text, currentMachineName))
		{
			throw new InvalidOperationException(SR.GetString("LogDoesNotExists", text, currentMachineName));
		}
		SharedUtils.CheckEnvironment();
		lastSeenEntry = 0;
		lastSeenPos = 0;
		bytesCached = 0;
		firstCachedEntry = -1;
		SafeEventLogReadHandle safeEventLogReadHandle = SafeEventLogReadHandle.OpenEventLog(currentMachineName, text);
		if (safeEventLogReadHandle.IsInvalid)
		{
			Win32Exception innerException = null;
			if (Marshal.GetLastWin32Error() != 0)
			{
				innerException = SharedUtils.CreateSafeWin32Exception();
			}
			throw new InvalidOperationException(SR.GetString("CantOpenLog", text.ToString(), currentMachineName), innerException);
		}
		readHandle = safeEventLogReadHandle;
	}

	private void OpenForWrite(string currentMachineName)
	{
		if (boolFlags[256])
		{
			throw new ObjectDisposedException(GetType().Name);
		}
		if (sourceName == null || sourceName.Length == 0)
		{
			throw new ArgumentException(SR.GetString("NeedSourceToOpen"));
		}
		SharedUtils.CheckEnvironment();
		SafeEventLogWriteHandle safeEventLogWriteHandle = SafeEventLogWriteHandle.RegisterEventSource(currentMachineName, sourceName);
		if (safeEventLogWriteHandle.IsInvalid)
		{
			Win32Exception innerException = null;
			if (Marshal.GetLastWin32Error() != 0)
			{
				innerException = SharedUtils.CreateSafeWin32Exception();
			}
			throw new InvalidOperationException(SR.GetString("CantOpenLogAccess", sourceName), innerException);
		}
		writeHandle = safeEventLogWriteHandle;
	}

	[ComVisible(false)]
	public void RegisterDisplayName(string resourceFile, long resourceId)
	{
		string currentMachineName = machineName;
		EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Administer, currentMachineName);
		eventLogPermission.Demand();
		PermissionSet permissionSet = EventLog._UnsafeGetAssertPermSet();
		permissionSet.Assert();
		using RegistryKey registryKey = GetLogRegKey(currentMachineName, writable: true);
		registryKey.SetValue("DisplayNameFile", resourceFile, RegistryValueKind.ExpandString);
		registryKey.SetValue("DisplayNameID", resourceId, RegistryValueKind.DWord);
	}

	private void Reset(string currentMachineName)
	{
		bool isOpenForRead = IsOpenForRead;
		bool isOpenForWrite = IsOpenForWrite;
		bool value = boolFlags[8];
		bool flag = boolFlags[16];
		Close(currentMachineName);
		cache = null;
		if (isOpenForRead)
		{
			OpenForRead(currentMachineName);
		}
		if (isOpenForWrite)
		{
			OpenForWrite(currentMachineName);
		}
		if (flag)
		{
			StartListening(currentMachineName, GetLogName(currentMachineName));
		}
		boolFlags[8] = value;
	}

	[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
	private static void RemoveListenerComponent(EventLogInternal component, string compLogName)
	{
		lock (InternalSyncObject)
		{
			LogListeningInfo logListeningInfo = (LogListeningInfo)listenerInfos[compLogName];
			logListeningInfo.listeningComponents.Remove(component);
			if (logListeningInfo.listeningComponents.Count == 0)
			{
				logListeningInfo.handleOwner.Dispose();
				logListeningInfo.registeredWaitHandle.Unregister(logListeningInfo.waitHandle);
				logListeningInfo.waitHandle.Close();
				listenerInfos[compLogName] = null;
			}
		}
	}

	[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
	private void StartListening(string currentMachineName, string currentLogName)
	{
		lastSeenCount = EntryCount + OldestEntryNumber;
		AddListenerComponent(this, currentMachineName, currentLogName);
		boolFlags[16] = true;
	}

	private void StartRaisingEvents(string currentMachineName, string currentLogName)
	{
		if (!boolFlags[4] && !boolFlags[8] && !parent.ComponentDesignMode)
		{
			StartListening(currentMachineName, currentLogName);
		}
		boolFlags[8] = true;
	}

	private static void StaticCompletionCallback(object context, bool wasSignaled)
	{
		LogListeningInfo logListeningInfo = (LogListeningInfo)context;
		if (logListeningInfo == null)
		{
			return;
		}
		EventLogInternal[] array;
		lock (InternalSyncObject)
		{
			array = (EventLogInternal[])logListeningInfo.listeningComponents.ToArray(typeof(EventLogInternal));
		}
		for (int i = 0; i < array.Length; i++)
		{
			try
			{
				if (array[i] != null)
				{
					array[i].CompletionCallback(null);
				}
			}
			catch (ObjectDisposedException)
			{
			}
		}
	}

	[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
	private void StopListening(string currentLogName)
	{
		RemoveListenerComponent(this, currentLogName);
		boolFlags[16] = false;
	}

	private void StopRaisingEvents(string currentLogName)
	{
		if (!boolFlags[4] && boolFlags[8] && !parent.ComponentDesignMode)
		{
			StopListening(currentLogName);
		}
		boolFlags[8] = false;
	}

	private static bool CharIsPrintable(char c)
	{
		UnicodeCategory unicodeCategory = char.GetUnicodeCategory(c);
		if (unicodeCategory == UnicodeCategory.Control && unicodeCategory != UnicodeCategory.Format && unicodeCategory != UnicodeCategory.LineSeparator && unicodeCategory != UnicodeCategory.ParagraphSeparator)
		{
			return unicodeCategory == UnicodeCategory.OtherNotAssigned;
		}
		return true;
	}

	internal static bool ValidLogName(string logName, bool ignoreEmpty)
	{
		if (logName.Length == 0 && !ignoreEmpty)
		{
			return false;
		}
		foreach (char c in logName)
		{
			if (!CharIsPrintable(c) || c == '\\' || c == '*' || c == '?')
			{
				return false;
			}
		}
		return true;
	}

	private void VerifyAndCreateSource(string sourceName, string currentMachineName)
	{
		if (boolFlags[512])
		{
			return;
		}
		if (!EventLog.SourceExists(sourceName, currentMachineName, wantToCreate: true))
		{
			Mutex mutex = null;
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				SharedUtils.EnterMutex("netfxeventlog.1.0", ref mutex);
				if (!EventLog.SourceExists(sourceName, currentMachineName, wantToCreate: true))
				{
					if (GetLogName(currentMachineName) == null)
					{
						logName = "Application";
					}
					EventLog.CreateEventSource(new EventSourceCreationData(sourceName, GetLogName(currentMachineName), currentMachineName));
					Reset(currentMachineName);
				}
				else
				{
					string text = EventLog.LogNameFromSourceName(sourceName, currentMachineName);
					string text2 = GetLogName(currentMachineName);
					if (text != null && text2 != null && string.Compare(text, text2, StringComparison.OrdinalIgnoreCase) != 0)
					{
						throw new ArgumentException(SR.GetString("LogSourceMismatch", Source.ToString(), text2, text));
					}
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
		else
		{
			EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Write, currentMachineName);
			eventLogPermission.Demand();
			string text3 = EventLog._InternalLogNameFromSourceName(sourceName, currentMachineName);
			string text4 = GetLogName(currentMachineName);
			if (text3 != null && text4 != null && string.Compare(text3, text4, StringComparison.OrdinalIgnoreCase) != 0)
			{
				throw new ArgumentException(SR.GetString("LogSourceMismatch", Source.ToString(), text4, text3));
			}
		}
		boolFlags[512] = true;
	}

	public void WriteEntry(string message)
	{
		WriteEntry(message, EventLogEntryType.Information, 0, 0, null);
	}

	public void WriteEntry(string message, EventLogEntryType type)
	{
		WriteEntry(message, type, 0, 0, null);
	}

	public void WriteEntry(string message, EventLogEntryType type, int eventID)
	{
		WriteEntry(message, type, eventID, 0, null);
	}

	public void WriteEntry(string message, EventLogEntryType type, int eventID, short category)
	{
		WriteEntry(message, type, eventID, category, null);
	}

	public void WriteEntry(string message, EventLogEntryType type, int eventID, short category, byte[] rawData)
	{
		if (eventID < 0 || eventID > 65535)
		{
			throw new ArgumentException(SR.GetString("EventID", eventID, 0, 65535));
		}
		if (Source.Length == 0)
		{
			throw new ArgumentException(SR.GetString("NeedSourceToWrite"));
		}
		if (!Enum.IsDefined(typeof(EventLogEntryType), type))
		{
			throw new InvalidEnumArgumentException("type", (int)type, typeof(EventLogEntryType));
		}
		string currentMachineName = machineName;
		if (!boolFlags[32])
		{
			EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Write, currentMachineName);
			eventLogPermission.Demand();
			boolFlags[32] = true;
		}
		VerifyAndCreateSource(sourceName, currentMachineName);
		InternalWriteEvent((uint)eventID, (ushort)category, type, new string[1] { message }, rawData, currentMachineName);
	}

	[ComVisible(false)]
	public void WriteEvent(EventInstance instance, params object[] values)
	{
		WriteEvent(instance, null, values);
	}

	[ComVisible(false)]
	public void WriteEvent(EventInstance instance, byte[] data, params object[] values)
	{
		if (instance == null)
		{
			throw new ArgumentNullException("instance");
		}
		if (Source.Length == 0)
		{
			throw new ArgumentException(SR.GetString("NeedSourceToWrite"));
		}
		string currentMachineName = machineName;
		if (!boolFlags[32])
		{
			EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Write, currentMachineName);
			eventLogPermission.Demand();
			boolFlags[32] = true;
		}
		VerifyAndCreateSource(Source, currentMachineName);
		string[] array = null;
		if (values != null)
		{
			array = new string[values.Length];
			for (int i = 0; i < values.Length; i++)
			{
				if (values[i] != null)
				{
					array[i] = values[i].ToString();
				}
				else
				{
					array[i] = string.Empty;
				}
			}
		}
		InternalWriteEvent((uint)instance.InstanceId, (ushort)instance.CategoryId, instance.EntryType, array, data, currentMachineName);
	}

	private void InternalWriteEvent(uint eventID, ushort category, EventLogEntryType type, string[] strings, byte[] rawData, string currentMachineName)
	{
		if (strings == null)
		{
			strings = new string[0];
		}
		if (strings.Length >= 256)
		{
			throw new ArgumentException(SR.GetString("TooManyReplacementStrings"));
		}
		for (int i = 0; i < strings.Length; i++)
		{
			if (strings[i] == null)
			{
				strings[i] = string.Empty;
			}
			if (strings[i].Length > 32766)
			{
				throw new ArgumentException(SR.GetString("LogEntryTooLong"));
			}
		}
		if (rawData == null)
		{
			rawData = new byte[0];
		}
		if (Source.Length == 0)
		{
			throw new ArgumentException(SR.GetString("NeedSourceToWrite"));
		}
		if (!IsOpenForWrite)
		{
			OpenForWrite(currentMachineName);
		}
		IntPtr[] array = new IntPtr[strings.Length];
		GCHandle[] array2 = new GCHandle[strings.Length];
		GCHandle gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
		try
		{
			for (int j = 0; j < strings.Length; j++)
			{
				array2[j] = GCHandle.Alloc(strings[j], GCHandleType.Pinned);
				array[j] = array2[j].AddrOfPinnedObject();
			}
			byte[] userSID = null;
			if (!Microsoft.Win32.UnsafeNativeMethods.ReportEvent(writeHandle, (short)type, category, eventID, userSID, (short)strings.Length, rawData.Length, new HandleRef(this, gCHandle.AddrOfPinnedObject()), rawData))
			{
				throw SharedUtils.CreateSafeWin32Exception();
			}
		}
		finally
		{
			for (int k = 0; k < strings.Length; k++)
			{
				if (array2[k].IsAllocated)
				{
					array2[k].Free();
				}
			}
			gCHandle.Free();
		}
	}
}
