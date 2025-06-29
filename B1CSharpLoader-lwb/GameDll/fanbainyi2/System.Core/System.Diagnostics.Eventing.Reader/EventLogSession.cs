using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using Microsoft.Win32;

namespace System.Diagnostics.Eventing.Reader;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class EventLogSession : IDisposable
{
	internal EventLogHandle renderContextHandleSystem = EventLogHandle.Zero;

	internal EventLogHandle renderContextHandleUser = EventLogHandle.Zero;

	private object syncObject;

	private string server;

	private string user;

	private string domain;

	private SessionAuthentication logOnType;

	private EventLogHandle handle = EventLogHandle.Zero;

	private static EventLogSession globalSession = new EventLogSession();

	internal EventLogHandle Handle => handle;

	public static EventLogSession GlobalSession => globalSession;

	[SecuritySafeCritical]
	internal void SetupSystemContext()
	{
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		if (!renderContextHandleSystem.IsInvalid)
		{
			return;
		}
		lock (syncObject)
		{
			if (renderContextHandleSystem.IsInvalid)
			{
				renderContextHandleSystem = NativeWrapper.EvtCreateRenderContext(0, null, Microsoft.Win32.UnsafeNativeMethods.EvtRenderContextFlags.EvtRenderContextSystem);
			}
		}
	}

	[SecuritySafeCritical]
	internal void SetupUserContext()
	{
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		lock (syncObject)
		{
			if (renderContextHandleUser.IsInvalid)
			{
				renderContextHandleUser = NativeWrapper.EvtCreateRenderContext(0, null, Microsoft.Win32.UnsafeNativeMethods.EvtRenderContextFlags.EvtRenderContextUser);
			}
		}
	}

	[SecurityCritical]
	public EventLogSession()
	{
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		syncObject = new object();
	}

	public EventLogSession(string server)
		: this(server, null, null, null, SessionAuthentication.Default)
	{
	}

	[SecurityCritical]
	public EventLogSession(string server, string domain, string user, SecureString password, SessionAuthentication logOnType)
	{
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		if (server == null)
		{
			server = "localhost";
		}
		syncObject = new object();
		this.server = server;
		this.domain = domain;
		this.user = user;
		this.logOnType = logOnType;
		Microsoft.Win32.UnsafeNativeMethods.EvtRpcLogin login = new Microsoft.Win32.UnsafeNativeMethods.EvtRpcLogin
		{
			Server = this.server,
			User = this.user,
			Domain = this.domain,
			Flags = (int)this.logOnType,
			Password = CoTaskMemUnicodeSafeHandle.Zero
		};
		try
		{
			if (password != null)
			{
				login.Password.SetMemory(Marshal.SecureStringToCoTaskMemUnicode(password));
			}
			handle = NativeWrapper.EvtOpenSession(Microsoft.Win32.UnsafeNativeMethods.EvtLoginClass.EvtRpcLogin, ref login, 0, 0);
		}
		finally
		{
			login.Password.Close();
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[SecuritySafeCritical]
	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (this == globalSession)
			{
				throw new InvalidOperationException();
			}
			EventLogPermissionHolder.GetEventLogPermission().Demand();
		}
		if (renderContextHandleSystem != null && !renderContextHandleSystem.IsInvalid)
		{
			renderContextHandleSystem.Dispose();
		}
		if (renderContextHandleUser != null && !renderContextHandleUser.IsInvalid)
		{
			renderContextHandleUser.Dispose();
		}
		if (handle != null && !handle.IsInvalid)
		{
			handle.Dispose();
		}
	}

	public void CancelCurrentOperations()
	{
		NativeWrapper.EvtCancel(handle);
	}

	[SecurityCritical]
	public IEnumerable<string> GetProviderNames()
	{
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		List<string> list = new List<string>(100);
		using EventLogHandle eventLogHandle = NativeWrapper.EvtOpenProviderEnum(Handle, 0);
		bool finish = false;
		do
		{
			string item = NativeWrapper.EvtNextPublisherId(eventLogHandle, ref finish);
			if (!finish)
			{
				list.Add(item);
			}
		}
		while (!finish);
		return list;
	}

	[SecurityCritical]
	public IEnumerable<string> GetLogNames()
	{
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		List<string> list = new List<string>(100);
		using EventLogHandle eventLogHandle = NativeWrapper.EvtOpenChannelEnum(Handle, 0);
		bool finish = false;
		do
		{
			string item = NativeWrapper.EvtNextChannelPath(eventLogHandle, ref finish);
			if (!finish)
			{
				list.Add(item);
			}
		}
		while (!finish);
		return list;
	}

	public EventLogInformation GetLogInformation(string logName, PathType pathType)
	{
		if (logName == null)
		{
			throw new ArgumentNullException("logName");
		}
		return new EventLogInformation(this, logName, pathType);
	}

	public void ExportLog(string path, PathType pathType, string query, string targetFilePath)
	{
		ExportLog(path, pathType, query, targetFilePath, tolerateQueryErrors: false);
	}

	public void ExportLog(string path, PathType pathType, string query, string targetFilePath, bool tolerateQueryErrors)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (targetFilePath == null)
		{
			throw new ArgumentNullException("targetFilePath");
		}
		Microsoft.Win32.UnsafeNativeMethods.EvtExportLogFlags evtExportLogFlags = pathType switch
		{
			PathType.LogName => Microsoft.Win32.UnsafeNativeMethods.EvtExportLogFlags.EvtExportLogChannelPath, 
			PathType.FilePath => Microsoft.Win32.UnsafeNativeMethods.EvtExportLogFlags.EvtExportLogFilePath, 
			_ => throw new ArgumentOutOfRangeException("pathType"), 
		};
		if (!tolerateQueryErrors)
		{
			NativeWrapper.EvtExportLog(Handle, path, query, targetFilePath, (int)evtExportLogFlags);
		}
		else
		{
			NativeWrapper.EvtExportLog(Handle, path, query, targetFilePath, (int)(evtExportLogFlags | Microsoft.Win32.UnsafeNativeMethods.EvtExportLogFlags.EvtExportLogTolerateQueryErrors));
		}
	}

	public void ExportLogAndMessages(string path, PathType pathType, string query, string targetFilePath)
	{
		ExportLogAndMessages(path, pathType, query, targetFilePath, tolerateQueryErrors: false, CultureInfo.CurrentCulture);
	}

	public void ExportLogAndMessages(string path, PathType pathType, string query, string targetFilePath, bool tolerateQueryErrors, CultureInfo targetCultureInfo)
	{
		if (targetCultureInfo == null)
		{
			targetCultureInfo = CultureInfo.CurrentCulture;
		}
		ExportLog(path, pathType, query, targetFilePath, tolerateQueryErrors);
		NativeWrapper.EvtArchiveExportedLog(Handle, targetFilePath, targetCultureInfo.LCID, 0);
	}

	public void ClearLog(string logName)
	{
		ClearLog(logName, null);
	}

	public void ClearLog(string logName, string backupPath)
	{
		if (logName == null)
		{
			throw new ArgumentNullException("logName");
		}
		NativeWrapper.EvtClearLog(Handle, logName, backupPath, 0);
	}
}
