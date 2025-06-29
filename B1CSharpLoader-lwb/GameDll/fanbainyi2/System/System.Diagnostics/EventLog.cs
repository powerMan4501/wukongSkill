using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Diagnostics;

[DefaultEvent("EntryWritten")]
[InstallerType("System.Diagnostics.EventLogInstaller, System.Configuration.Install, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[MonitoringDescription("EventLogDesc")]
public class EventLog : Component, ISupportInitialize
{
	private const string EventLogKey = "SYSTEM\\CurrentControlSet\\Services\\EventLog";

	internal const string DllName = "EventLogMessages.dll";

	private const string eventLogMutexName = "netfxeventlog.1.0";

	private const int DefaultMaxSize = 524288;

	private const int DefaultRetention = 604800;

	private const int SecondsPerDay = 86400;

	private EventLogInternal m_underlyingEventLog;

	private static volatile bool s_CheckedOsVersion;

	private static volatile bool s_SkipRegPatch;

	private static readonly bool s_dontFilterRegKeys = !IsWindowsRS5OrUp() || System.LocalAppContextSwitches.DisableEventLogRegistryKeysFiltering;

	private static bool SkipRegPatch
	{
		get
		{
			if (!s_CheckedOsVersion)
			{
				OperatingSystem oSVersion = Environment.OSVersion;
				s_SkipRegPatch = oSVersion.Platform == PlatformID.Win32NT && oSVersion.Version.Major > 5;
				s_CheckedOsVersion = true;
			}
			return s_SkipRegPatch;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("LogEntries")]
	public EventLogEntryCollection Entries => m_underlyingEventLog.Entries;

	[Browsable(false)]
	public string LogDisplayName => m_underlyingEventLog.LogDisplayName;

	[TypeConverter("System.Diagnostics.Design.LogConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[ReadOnly(true)]
	[MonitoringDescription("LogLog")]
	[DefaultValue("")]
	[SettingsBindable(true)]
	public string Log
	{
		get
		{
			return m_underlyingEventLog.Log;
		}
		set
		{
			EventLogInternal eventLogInternal = new EventLogInternal(value, m_underlyingEventLog.MachineName, m_underlyingEventLog.Source, this);
			EventLogInternal underlyingEventLog = m_underlyingEventLog;
			new EventLogPermission(EventLogPermissionAccess.Write, underlyingEventLog.machineName).Assert();
			if (underlyingEventLog.EnableRaisingEvents)
			{
				eventLogInternal.onEntryWrittenHandler = underlyingEventLog.onEntryWrittenHandler;
				eventLogInternal.EnableRaisingEvents = true;
			}
			m_underlyingEventLog = eventLogInternal;
			underlyingEventLog.Close();
		}
	}

	[ReadOnly(true)]
	[MonitoringDescription("LogMachineName")]
	[DefaultValue(".")]
	[SettingsBindable(true)]
	public string MachineName
	{
		get
		{
			return m_underlyingEventLog.MachineName;
		}
		set
		{
			EventLogInternal eventLogInternal = new EventLogInternal(m_underlyingEventLog.logName, value, m_underlyingEventLog.sourceName, this);
			EventLogInternal underlyingEventLog = m_underlyingEventLog;
			new EventLogPermission(EventLogPermissionAccess.Write, underlyingEventLog.machineName).Assert();
			if (underlyingEventLog.EnableRaisingEvents)
			{
				eventLogInternal.onEntryWrittenHandler = underlyingEventLog.onEntryWrittenHandler;
				eventLogInternal.EnableRaisingEvents = true;
			}
			m_underlyingEventLog = eventLogInternal;
			underlyingEventLog.Close();
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[ComVisible(false)]
	public long MaximumKilobytes
	{
		get
		{
			return m_underlyingEventLog.MaximumKilobytes;
		}
		set
		{
			m_underlyingEventLog.MaximumKilobytes = value;
		}
	}

	[Browsable(false)]
	[ComVisible(false)]
	public OverflowAction OverflowAction => m_underlyingEventLog.OverflowAction;

	[Browsable(false)]
	[ComVisible(false)]
	public int MinimumRetentionDays => m_underlyingEventLog.MinimumRetentionDays;

	internal bool ComponentDesignMode => base.DesignMode;

	[Browsable(false)]
	[MonitoringDescription("LogMonitoring")]
	[DefaultValue(false)]
	public bool EnableRaisingEvents
	{
		get
		{
			return m_underlyingEventLog.EnableRaisingEvents;
		}
		set
		{
			m_underlyingEventLog.EnableRaisingEvents = value;
		}
	}

	[Browsable(false)]
	[DefaultValue(null)]
	[MonitoringDescription("LogSynchronizingObject")]
	public ISynchronizeInvoke SynchronizingObject
	{
		[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
		get
		{
			return m_underlyingEventLog.SynchronizingObject;
		}
		set
		{
			m_underlyingEventLog.SynchronizingObject = value;
		}
	}

	[ReadOnly(true)]
	[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[MonitoringDescription("LogSource")]
	[DefaultValue("")]
	[SettingsBindable(true)]
	public string Source
	{
		get
		{
			return m_underlyingEventLog.Source;
		}
		set
		{
			EventLogInternal eventLogInternal = new EventLogInternal(m_underlyingEventLog.Log, m_underlyingEventLog.MachineName, CheckAndNormalizeSourceName(value), this);
			EventLogInternal underlyingEventLog = m_underlyingEventLog;
			new EventLogPermission(EventLogPermissionAccess.Write, underlyingEventLog.machineName).Assert();
			if (underlyingEventLog.EnableRaisingEvents)
			{
				eventLogInternal.onEntryWrittenHandler = underlyingEventLog.onEntryWrittenHandler;
				eventLogInternal.EnableRaisingEvents = true;
			}
			m_underlyingEventLog = eventLogInternal;
			underlyingEventLog.Close();
		}
	}

	[MonitoringDescription("LogEntryWritten")]
	public event EntryWrittenEventHandler EntryWritten
	{
		add
		{
			m_underlyingEventLog.EntryWritten += value;
		}
		remove
		{
			m_underlyingEventLog.EntryWritten -= value;
		}
	}

	internal static PermissionSet _UnsafeGetAssertPermSet()
	{
		PermissionSet permissionSet = new PermissionSet(PermissionState.None);
		RegistryPermission perm = new RegistryPermission(PermissionState.Unrestricted);
		permissionSet.AddPermission(perm);
		EnvironmentPermission perm2 = new EnvironmentPermission(PermissionState.Unrestricted);
		permissionSet.AddPermission(perm2);
		SecurityPermission perm3 = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
		permissionSet.AddPermission(perm3);
		return permissionSet;
	}

	public EventLog()
		: this("", ".", "")
	{
	}

	public EventLog(string logName)
		: this(logName, ".", "")
	{
	}

	public EventLog(string logName, string machineName)
		: this(logName, machineName, "")
	{
	}

	public EventLog(string logName, string machineName, string source)
	{
		m_underlyingEventLog = new EventLogInternal(logName, machineName, source, this);
	}

	internal object ComponentGetService(Type service)
	{
		return GetService(service);
	}

	public void BeginInit()
	{
		m_underlyingEventLog.BeginInit();
	}

	public void Clear()
	{
		m_underlyingEventLog.Clear();
	}

	public void Close()
	{
		m_underlyingEventLog.Close();
	}

	public static void CreateEventSource(string source, string logName)
	{
		CreateEventSource(new EventSourceCreationData(source, logName, "."));
	}

	[Obsolete("This method has been deprecated.  Please use System.Diagnostics.EventLog.CreateEventSource(EventSourceCreationData sourceData) instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public static void CreateEventSource(string source, string logName, string machineName)
	{
		CreateEventSource(new EventSourceCreationData(source, logName, machineName));
	}

	public static void CreateEventSource(EventSourceCreationData sourceData)
	{
		if (sourceData == null)
		{
			throw new ArgumentNullException("sourceData");
		}
		string text = sourceData.LogName;
		string source = sourceData.Source;
		string machineName = sourceData.MachineName;
		if (!SyntaxCheck.CheckMachineName(machineName))
		{
			throw new ArgumentException(SR.GetString("InvalidParameter", "machineName", machineName));
		}
		if (text == null || text.Length == 0)
		{
			text = "Application";
		}
		if (!ValidLogName(text, ignoreEmpty: false))
		{
			throw new ArgumentException(SR.GetString("BadLogName"));
		}
		if (source == null || source.Length == 0)
		{
			throw new ArgumentException(SR.GetString("MissingParameter", "source"));
		}
		if (source.Length + "SYSTEM\\CurrentControlSet\\Services\\EventLog".Length > 254)
		{
			throw new ArgumentException(SR.GetString("ParameterTooLong", "source", 254 - "SYSTEM\\CurrentControlSet\\Services\\EventLog".Length));
		}
		EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Administer, machineName);
		eventLogPermission.Demand();
		Mutex mutex = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			SharedUtils.EnterMutex("netfxeventlog.1.0", ref mutex);
			if (SourceExists(source, machineName, wantToCreate: true))
			{
				if (".".Equals(machineName))
				{
					throw new ArgumentException(SR.GetString("LocalSourceAlreadyExists", source));
				}
				throw new ArgumentException(SR.GetString("SourceAlreadyExists", source, machineName));
			}
			PermissionSet permissionSet = _UnsafeGetAssertPermSet();
			permissionSet.Assert();
			RegistryKey registryKey = null;
			RegistryKey registryKey2 = null;
			RegistryKey registryKey3 = null;
			RegistryKey registryKey4 = null;
			RegistryKey registryKey5 = null;
			try
			{
				registryKey = ((!(machineName == ".")) ? RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, machineName) : Registry.LocalMachine);
				registryKey2 = registryKey.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\EventLog", writable: true);
				if (registryKey2 == null)
				{
					if (!".".Equals(machineName))
					{
						throw new InvalidOperationException(SR.GetString("RegKeyMissing", "SYSTEM\\CurrentControlSet\\Services\\EventLog", text, source, machineName));
					}
					throw new InvalidOperationException(SR.GetString("LocalRegKeyMissing", "SYSTEM\\CurrentControlSet\\Services\\EventLog", text, source));
				}
				registryKey3 = registryKey2.OpenSubKey(text, writable: true);
				if (registryKey3 == null && text.Length >= 8)
				{
					string strA = text.Substring(0, 8);
					if (string.Compare(strA, "AppEvent", StringComparison.OrdinalIgnoreCase) == 0 || string.Compare(strA, "SecEvent", StringComparison.OrdinalIgnoreCase) == 0 || string.Compare(strA, "SysEvent", StringComparison.OrdinalIgnoreCase) == 0)
					{
						throw new ArgumentException(SR.GetString("InvalidCustomerLogName", text));
					}
					string text2 = FindSame8FirstCharsLog(registryKey2, text);
					if (text2 != null)
					{
						throw new ArgumentException(SR.GetString("DuplicateLogName", text, text2));
					}
				}
				bool flag = registryKey3 == null;
				if (flag)
				{
					if (SourceExists(text, machineName, wantToCreate: true))
					{
						if (".".Equals(machineName))
						{
							throw new ArgumentException(SR.GetString("LocalLogAlreadyExistsAsSource", text));
						}
						throw new ArgumentException(SR.GetString("LogAlreadyExistsAsSource", text, machineName));
					}
					registryKey3 = registryKey2.CreateSubKey(text);
					if (!SkipRegPatch)
					{
						registryKey3.SetValue("Sources", new string[2] { text, source }, RegistryValueKind.MultiString);
					}
					SetSpecialLogRegValues(registryKey3, text);
					registryKey4 = registryKey3.CreateSubKey(text);
					SetSpecialSourceRegValues(registryKey4, sourceData);
				}
				if (!(text != source))
				{
					return;
				}
				if (!flag)
				{
					SetSpecialLogRegValues(registryKey3, text);
					if (!SkipRegPatch)
					{
						if (!(registryKey3.GetValue("Sources") is string[] array))
						{
							registryKey3.SetValue("Sources", new string[2] { text, source }, RegistryValueKind.MultiString);
						}
						else if (Array.IndexOf(array, source) == -1)
						{
							string[] array2 = new string[array.Length + 1];
							Array.Copy(array, array2, array.Length);
							array2[array.Length] = source;
							registryKey3.SetValue("Sources", array2, RegistryValueKind.MultiString);
						}
					}
				}
				registryKey5 = registryKey3.CreateSubKey(source);
				SetSpecialSourceRegValues(registryKey5, sourceData);
			}
			finally
			{
				registryKey?.Close();
				registryKey2?.Close();
				if (registryKey3 != null)
				{
					registryKey3.Flush();
					registryKey3.Close();
				}
				if (registryKey4 != null)
				{
					registryKey4.Flush();
					registryKey4.Close();
				}
				if (registryKey5 != null)
				{
					registryKey5.Flush();
					registryKey5.Close();
				}
				CodeAccessPermission.RevertAssert();
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

	public static void Delete(string logName)
	{
		Delete(logName, ".");
	}

	public static void Delete(string logName, string machineName)
	{
		if (!SyntaxCheck.CheckMachineName(machineName))
		{
			throw new ArgumentException(SR.GetString("InvalidParameterFormat", "machineName"));
		}
		if (logName == null || logName.Length == 0)
		{
			throw new ArgumentException(SR.GetString("NoLogName"));
		}
		if (!ValidLogName(logName, ignoreEmpty: false))
		{
			throw new InvalidOperationException(SR.GetString("BadLogName"));
		}
		EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Administer, machineName);
		eventLogPermission.Demand();
		SharedUtils.CheckEnvironment();
		PermissionSet permissionSet = _UnsafeGetAssertPermSet();
		permissionSet.Assert();
		RegistryKey registryKey = null;
		Mutex mutex = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			SharedUtils.EnterMutex("netfxeventlog.1.0", ref mutex);
			try
			{
				registryKey = GetEventLogRegKey(machineName, writable: true);
				if (registryKey == null)
				{
					throw new InvalidOperationException(SR.GetString("RegKeyNoAccess", "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\EventLog", machineName));
				}
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(logName))
				{
					if (registryKey2 == null)
					{
						throw new InvalidOperationException(SR.GetString("MissingLog", logName, machineName));
					}
					EventLog eventLog = new EventLog(logName, machineName);
					try
					{
						eventLog.Clear();
					}
					finally
					{
						eventLog.Close();
					}
					string text = null;
					try
					{
						text = (string)registryKey2.GetValue("File");
					}
					catch
					{
					}
					if (text != null)
					{
						try
						{
							File.Delete(text);
						}
						catch
						{
						}
					}
				}
				registryKey.DeleteSubKeyTree(logName);
			}
			finally
			{
				registryKey?.Close();
				CodeAccessPermission.RevertAssert();
			}
		}
		finally
		{
			mutex?.ReleaseMutex();
		}
	}

	public static void DeleteEventSource(string source)
	{
		DeleteEventSource(source, ".");
	}

	public static void DeleteEventSource(string source, string machineName)
	{
		if (!SyntaxCheck.CheckMachineName(machineName))
		{
			throw new ArgumentException(SR.GetString("InvalidParameter", "machineName", machineName));
		}
		EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Administer, machineName);
		eventLogPermission.Demand();
		SharedUtils.CheckEnvironment();
		PermissionSet permissionSet = _UnsafeGetAssertPermSet();
		permissionSet.Assert();
		Mutex mutex = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			SharedUtils.EnterMutex("netfxeventlog.1.0", ref mutex);
			RegistryKey registryKey = null;
			using (registryKey = FindSourceRegistration(source, machineName, readOnly: true))
			{
				if (registryKey == null)
				{
					if (machineName == null)
					{
						throw new ArgumentException(SR.GetString("LocalSourceNotRegistered", source));
					}
					throw new ArgumentException(SR.GetString("SourceNotRegistered", source, machineName, "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\EventLog"));
				}
				string name = registryKey.Name;
				int num = name.LastIndexOf('\\');
				if (string.Compare(name, num + 1, source, 0, name.Length - num, StringComparison.Ordinal) == 0)
				{
					throw new InvalidOperationException(SR.GetString("CannotDeleteEqualSource", source));
				}
			}
			try
			{
				registryKey = FindSourceRegistration(source, machineName, readOnly: false);
				registryKey.DeleteSubKeyTree(source);
				if (SkipRegPatch)
				{
					return;
				}
				string[] array = (string[])registryKey.GetValue("Sources");
				ArrayList arrayList = new ArrayList(array.Length - 1);
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] != source)
					{
						arrayList.Add(array[i]);
					}
				}
				string[] array2 = new string[arrayList.Count];
				arrayList.CopyTo(array2);
				registryKey.SetValue("Sources", array2, RegistryValueKind.MultiString);
			}
			finally
			{
				if (registryKey != null)
				{
					registryKey.Flush();
					registryKey.Close();
				}
				CodeAccessPermission.RevertAssert();
			}
		}
		finally
		{
			mutex?.ReleaseMutex();
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (m_underlyingEventLog != null)
		{
			m_underlyingEventLog.Dispose(disposing);
		}
		base.Dispose(disposing);
	}

	public void EndInit()
	{
		m_underlyingEventLog.EndInit();
	}

	public static bool Exists(string logName)
	{
		return Exists(logName, ".");
	}

	public static bool Exists(string logName, string machineName)
	{
		if (!SyntaxCheck.CheckMachineName(machineName))
		{
			throw new ArgumentException(SR.GetString("InvalidParameterFormat", "machineName"));
		}
		EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Administer, machineName);
		eventLogPermission.Demand();
		if (logName == null || logName.Length == 0)
		{
			return false;
		}
		SharedUtils.CheckEnvironment();
		PermissionSet permissionSet = _UnsafeGetAssertPermSet();
		permissionSet.Assert();
		RegistryKey registryKey = null;
		RegistryKey registryKey2 = null;
		try
		{
			registryKey = GetEventLogRegKey(machineName, writable: false);
			if (registryKey == null)
			{
				return false;
			}
			registryKey2 = registryKey.OpenSubKey(logName, writable: false);
			return registryKey2 != null;
		}
		finally
		{
			registryKey?.Close();
			registryKey2?.Close();
			CodeAccessPermission.RevertAssert();
		}
	}

	private static string FindSame8FirstCharsLog(RegistryKey keyParent, string logName)
	{
		string strB = logName.Substring(0, 8);
		string[] subKeyNames = keyParent.GetSubKeyNames();
		foreach (string text in subKeyNames)
		{
			if (text.Length >= 8 && string.Compare(text.Substring(0, 8), strB, StringComparison.OrdinalIgnoreCase) == 0)
			{
				return text;
			}
		}
		return null;
	}

	private static RegistryKey FindSourceRegistration(string source, string machineName, bool readOnly)
	{
		return FindSourceRegistration(source, machineName, readOnly, wantToCreate: false);
	}

	private static RegistryKey FindSourceRegistration(string source, string machineName, bool readOnly, bool wantToCreate)
	{
		if (source != null && source.Length != 0)
		{
			SharedUtils.CheckEnvironment();
			PermissionSet permissionSet = _UnsafeGetAssertPermSet();
			permissionSet.Assert();
			RegistryKey registryKey = null;
			try
			{
				registryKey = GetEventLogRegKey(machineName, !readOnly);
				if (registryKey == null)
				{
					return null;
				}
				StringBuilder stringBuilder = null;
				string[] subKeyNames = registryKey.GetSubKeyNames();
				for (int i = 0; i < subKeyNames.Length; i++)
				{
					RegistryKey registryKey2 = null;
					try
					{
						RegistryKey registryKey3 = registryKey.OpenSubKey(subKeyNames[i], !readOnly);
						if (registryKey3 != null)
						{
							registryKey2 = registryKey3.OpenSubKey(source, !readOnly);
							if (registryKey2 != null)
							{
								return registryKey3;
							}
							registryKey3.Close();
						}
					}
					catch (UnauthorizedAccessException)
					{
						if (stringBuilder == null)
						{
							stringBuilder = new StringBuilder(subKeyNames[i]);
							continue;
						}
						stringBuilder.Append(", ");
						stringBuilder.Append(subKeyNames[i]);
					}
					catch (SecurityException)
					{
						if (stringBuilder == null)
						{
							stringBuilder = new StringBuilder(subKeyNames[i]);
							continue;
						}
						stringBuilder.Append(", ");
						stringBuilder.Append(subKeyNames[i]);
					}
					finally
					{
						registryKey2?.Close();
					}
				}
				if (stringBuilder != null)
				{
					throw new SecurityException(SR.GetString(wantToCreate ? "SomeLogsInaccessibleToCreate" : "SomeLogsInaccessible", stringBuilder.ToString()));
				}
			}
			finally
			{
				registryKey?.Close();
				CodeAccessPermission.RevertAssert();
			}
		}
		return null;
	}

	public static EventLog[] GetEventLogs()
	{
		return GetEventLogs(".");
	}

	public static EventLog[] GetEventLogs(string machineName)
	{
		if (!SyntaxCheck.CheckMachineName(machineName))
		{
			throw new ArgumentException(SR.GetString("InvalidParameter", "machineName", machineName));
		}
		EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Administer, machineName);
		eventLogPermission.Demand();
		SharedUtils.CheckEnvironment();
		string[] array = new string[0];
		PermissionSet permissionSet = _UnsafeGetAssertPermSet();
		permissionSet.Assert();
		RegistryKey registryKey = null;
		try
		{
			registryKey = GetEventLogRegKey(machineName, writable: false);
			if (registryKey == null)
			{
				throw new InvalidOperationException(SR.GetString("RegKeyMissingShort", "SYSTEM\\CurrentControlSet\\Services\\EventLog", machineName));
			}
			array = registryKey.GetSubKeyNames();
		}
		finally
		{
			registryKey?.Close();
			CodeAccessPermission.RevertAssert();
		}
		if (s_dontFilterRegKeys || machineName != ".")
		{
			EventLog[] array2 = new EventLog[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				EventLog eventLog = new EventLog(array[i], machineName);
				array2[i] = eventLog;
			}
			return array2;
		}
		List<EventLog> list = new List<EventLog>(array.Length);
		for (int j = 0; j < array.Length; j++)
		{
			EventLog item = new EventLog(array[j], machineName);
			SafeEventLogReadHandle safeEventLogReadHandle = SafeEventLogReadHandle.OpenEventLog(machineName, array[j]);
			if (!safeEventLogReadHandle.IsInvalid)
			{
				safeEventLogReadHandle.Close();
				list.Add(item);
			}
			else if (Marshal.GetLastWin32Error() != 87)
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	private static bool IsWindowsRS5OrUp()
	{
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Assert();
		Microsoft.Win32.NativeMethods.RTL_OSVERSIONINFOEX lpVersionInformation = default(Microsoft.Win32.NativeMethods.RTL_OSVERSIONINFOEX);
		lpVersionInformation.dwOSVersionInfoSize = (uint)Marshal.SizeOf((object)lpVersionInformation);
		if (Microsoft.Win32.NativeMethods.RtlGetVersion(out lpVersionInformation) == 0 && lpVersionInformation.dwPlatformId == 2)
		{
			if (lpVersionInformation.dwMajorVersion <= 10)
			{
				if (lpVersionInformation.dwMajorVersion == 10)
				{
					if (lpVersionInformation.dwMinorVersion == 0)
					{
						if (lpVersionInformation.dwMinorVersion == 0)
						{
							return lpVersionInformation.dwBuildNumber >= 17763;
						}
						return false;
					}
					return true;
				}
				return false;
			}
			return true;
		}
		return false;
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

	internal static string GetDllPath(string machineName)
	{
		return Path.Combine(SharedUtils.GetLatestBuildDllDirectory(machineName), "EventLogMessages.dll");
	}

	public static bool SourceExists(string source)
	{
		return SourceExists(source, ".");
	}

	public static bool SourceExists(string source, string machineName)
	{
		return SourceExists(source, machineName, wantToCreate: false);
	}

	internal static bool SourceExists(string source, string machineName, bool wantToCreate)
	{
		if (!SyntaxCheck.CheckMachineName(machineName))
		{
			throw new ArgumentException(SR.GetString("InvalidParameter", "machineName", machineName));
		}
		EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Write, machineName);
		eventLogPermission.Demand();
		using RegistryKey registryKey = FindSourceRegistration(source, machineName, readOnly: true, wantToCreate);
		return registryKey != null;
	}

	public static string LogNameFromSourceName(string source, string machineName)
	{
		EventLogPermission eventLogPermission = new EventLogPermission(EventLogPermissionAccess.Administer, machineName);
		eventLogPermission.Demand();
		return _InternalLogNameFromSourceName(source, machineName);
	}

	internal static string _InternalLogNameFromSourceName(string source, string machineName)
	{
		using RegistryKey registryKey = FindSourceRegistration(source, machineName, readOnly: true);
		if (registryKey == null)
		{
			return "";
		}
		string name = registryKey.Name;
		int num = name.LastIndexOf('\\');
		return name.Substring(num + 1);
	}

	[ComVisible(false)]
	public void ModifyOverflowPolicy(OverflowAction action, int retentionDays)
	{
		m_underlyingEventLog.ModifyOverflowPolicy(action, retentionDays);
	}

	[ComVisible(false)]
	public void RegisterDisplayName(string resourceFile, long resourceId)
	{
		m_underlyingEventLog.RegisterDisplayName(resourceFile, resourceId);
	}

	private static void SetSpecialLogRegValues(RegistryKey logKey, string logName)
	{
		if (logKey.GetValue("MaxSize") == null)
		{
			logKey.SetValue("MaxSize", 524288, RegistryValueKind.DWord);
		}
		if (logKey.GetValue("AutoBackupLogFiles") == null)
		{
			logKey.SetValue("AutoBackupLogFiles", 0, RegistryValueKind.DWord);
		}
		if (!SkipRegPatch)
		{
			if (logKey.GetValue("Retention") == null)
			{
				logKey.SetValue("Retention", 604800, RegistryValueKind.DWord);
			}
			if (logKey.GetValue("File") == null)
			{
				string value = ((logName.Length <= 8) ? ("%SystemRoot%\\System32\\config\\" + logName + ".evt") : ("%SystemRoot%\\System32\\config\\" + logName.Substring(0, 8) + ".evt"));
				logKey.SetValue("File", value, RegistryValueKind.ExpandString);
			}
		}
	}

	private static void SetSpecialSourceRegValues(RegistryKey sourceLogKey, EventSourceCreationData sourceData)
	{
		if (string.IsNullOrEmpty(sourceData.MessageResourceFile))
		{
			sourceLogKey.SetValue("EventMessageFile", GetDllPath(sourceData.MachineName), RegistryValueKind.ExpandString);
		}
		else
		{
			sourceLogKey.SetValue("EventMessageFile", FixupPath(sourceData.MessageResourceFile), RegistryValueKind.ExpandString);
		}
		if (!string.IsNullOrEmpty(sourceData.ParameterResourceFile))
		{
			sourceLogKey.SetValue("ParameterMessageFile", FixupPath(sourceData.ParameterResourceFile), RegistryValueKind.ExpandString);
		}
		if (!string.IsNullOrEmpty(sourceData.CategoryResourceFile))
		{
			sourceLogKey.SetValue("CategoryMessageFile", FixupPath(sourceData.CategoryResourceFile), RegistryValueKind.ExpandString);
			sourceLogKey.SetValue("CategoryCount", sourceData.CategoryCount, RegistryValueKind.DWord);
		}
	}

	private static string FixupPath(string path)
	{
		if (path[0] == '%')
		{
			return path;
		}
		return Path.GetFullPath(path);
	}

	internal static string TryFormatMessage(Microsoft.Win32.SafeHandles.SafeLibraryHandle hModule, uint messageNum, string[] insertionStrings)
	{
		if (insertionStrings.Length == 0)
		{
			return UnsafeTryFormatMessage(hModule, messageNum, insertionStrings);
		}
		string text = UnsafeTryFormatMessage(hModule, messageNum, new string[0]);
		if (text == null)
		{
			return null;
		}
		int num = 0;
		for (int i = 0; i < text.Length; i++)
		{
			if (text[i] != '%' || text.Length <= i + 1)
			{
				continue;
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (; i + 1 < text.Length && char.IsDigit(text[i + 1]); i++)
			{
				stringBuilder.Append(text[i + 1]);
			}
			i++;
			if (stringBuilder.Length > 0)
			{
				int result = -1;
				if (int.TryParse(stringBuilder.ToString(), NumberStyles.None, CultureInfo.InvariantCulture, out result))
				{
					num = Math.Max(num, result);
				}
			}
		}
		if (num > insertionStrings.Length)
		{
			string[] array = new string[num];
			Array.Copy(insertionStrings, array, insertionStrings.Length);
			for (int j = insertionStrings.Length; j < array.Length; j++)
			{
				array[j] = "%" + (j + 1);
			}
			insertionStrings = array;
		}
		return UnsafeTryFormatMessage(hModule, messageNum, insertionStrings);
	}

	internal static string UnsafeTryFormatMessage(Microsoft.Win32.SafeHandles.SafeLibraryHandle hModule, uint messageNum, string[] insertionStrings)
	{
		string text = null;
		int num = 0;
		StringBuilder stringBuilder = new StringBuilder(1024);
		int num2 = 10240;
		IntPtr[] array = new IntPtr[insertionStrings.Length];
		GCHandle[] array2 = new GCHandle[insertionStrings.Length];
		GCHandle gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
		if (insertionStrings.Length == 0)
		{
			num2 |= 0x200;
		}
		try
		{
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = GCHandle.Alloc(insertionStrings[i], GCHandleType.Pinned);
				array[i] = array2[i].AddrOfPinnedObject();
			}
			int num3 = 122;
			while (num == 0 && num3 == 122)
			{
				num = Microsoft.Win32.SafeNativeMethods.FormatMessage(num2, hModule, messageNum, 0, stringBuilder, stringBuilder.Capacity, array);
				if (num == 0)
				{
					num3 = Marshal.GetLastWin32Error();
					if (num3 == 122)
					{
						stringBuilder.Capacity *= 2;
					}
				}
			}
		}
		catch
		{
			num = 0;
		}
		finally
		{
			for (int j = 0; j < array2.Length; j++)
			{
				if (array2[j].IsAllocated)
				{
					array2[j].Free();
				}
			}
			gCHandle.Free();
		}
		if (num > 0)
		{
			text = stringBuilder.ToString();
			if (text.Length > 1 && text[text.Length - 1] == '\n')
			{
				text = text.Substring(0, text.Length - 2);
			}
		}
		return text;
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

	public void WriteEntry(string message)
	{
		WriteEntry(message, EventLogEntryType.Information, 0, 0, null);
	}

	public static void WriteEntry(string source, string message)
	{
		WriteEntry(source, message, EventLogEntryType.Information, 0, 0, null);
	}

	public void WriteEntry(string message, EventLogEntryType type)
	{
		WriteEntry(message, type, 0, 0, null);
	}

	public static void WriteEntry(string source, string message, EventLogEntryType type)
	{
		WriteEntry(source, message, type, 0, 0, null);
	}

	public void WriteEntry(string message, EventLogEntryType type, int eventID)
	{
		WriteEntry(message, type, eventID, 0, null);
	}

	public static void WriteEntry(string source, string message, EventLogEntryType type, int eventID)
	{
		WriteEntry(source, message, type, eventID, 0, null);
	}

	public void WriteEntry(string message, EventLogEntryType type, int eventID, short category)
	{
		WriteEntry(message, type, eventID, category, null);
	}

	public static void WriteEntry(string source, string message, EventLogEntryType type, int eventID, short category)
	{
		WriteEntry(source, message, type, eventID, category, null);
	}

	public static void WriteEntry(string source, string message, EventLogEntryType type, int eventID, short category, byte[] rawData)
	{
		using EventLogInternal eventLogInternal = new EventLogInternal("", ".", CheckAndNormalizeSourceName(source));
		eventLogInternal.WriteEntry(message, type, eventID, category, rawData);
	}

	public void WriteEntry(string message, EventLogEntryType type, int eventID, short category, byte[] rawData)
	{
		m_underlyingEventLog.WriteEntry(message, type, eventID, category, rawData);
	}

	[ComVisible(false)]
	public void WriteEvent(EventInstance instance, params object[] values)
	{
		WriteEvent(instance, null, values);
	}

	[ComVisible(false)]
	public void WriteEvent(EventInstance instance, byte[] data, params object[] values)
	{
		m_underlyingEventLog.WriteEvent(instance, data, values);
	}

	public static void WriteEvent(string source, EventInstance instance, params object[] values)
	{
		using EventLogInternal eventLogInternal = new EventLogInternal("", ".", CheckAndNormalizeSourceName(source));
		eventLogInternal.WriteEvent(instance, null, values);
	}

	public static void WriteEvent(string source, EventInstance instance, byte[] data, params object[] values)
	{
		using EventLogInternal eventLogInternal = new EventLogInternal("", ".", CheckAndNormalizeSourceName(source));
		eventLogInternal.WriteEvent(instance, data, values);
	}

	private static string CheckAndNormalizeSourceName(string source)
	{
		if (source == null)
		{
			source = string.Empty;
		}
		if (source.Length + "SYSTEM\\CurrentControlSet\\Services\\EventLog".Length > 254)
		{
			throw new ArgumentException(SR.GetString("ParameterTooLong", "source", 254 - "SYSTEM\\CurrentControlSet\\Services\\EventLog".Length));
		}
		return source;
	}
}
