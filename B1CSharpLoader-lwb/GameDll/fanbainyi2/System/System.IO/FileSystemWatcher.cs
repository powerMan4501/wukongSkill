using System.ComponentModel;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.IO;

[DefaultEvent("Changed")]
[IODescription("FileSystemWatcherDesc")]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class FileSystemWatcher : Component, ISupportInitialize
{
	private sealed class FSWAsyncResult : IAsyncResult
	{
		internal int session;

		internal byte[] buffer;

		public bool IsCompleted
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public WaitHandle AsyncWaitHandle
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public object AsyncState
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public bool CompletedSynchronously
		{
			get
			{
				throw new NotImplementedException();
			}
		}
	}

	private string directory;

	private string filter;

	private SafeFileHandle directoryHandle;

	private const NotifyFilters defaultNotifyFilters = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite;

	private NotifyFilters notifyFilters = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite;

	private bool includeSubdirectories;

	private bool enabled;

	private bool initializing;

	private int internalBufferSize = 8192;

	private WaitForChangedResult changedResult;

	private bool isChanged;

	private ISynchronizeInvoke synchronizingObject;

	private bool readGranted;

	private bool disposed;

	private int currentSession;

	private FileSystemEventHandler onChangedHandler;

	private FileSystemEventHandler onCreatedHandler;

	private FileSystemEventHandler onDeletedHandler;

	private RenamedEventHandler onRenamedHandler;

	private ErrorEventHandler onErrorHandler;

	private bool stopListening;

	private bool runOnce;

	private static readonly char[] wildcards;

	private static int notifyFiltersValidMask;

	[DefaultValue(NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite)]
	[IODescription("FSW_ChangedFilter")]
	public NotifyFilters NotifyFilter
	{
		get
		{
			return notifyFilters;
		}
		set
		{
			if (((uint)value & (uint)(~notifyFiltersValidMask)) != 0)
			{
				throw new InvalidEnumArgumentException("value", (int)value, typeof(NotifyFilters));
			}
			if (notifyFilters != value)
			{
				notifyFilters = value;
				Restart();
			}
		}
	}

	[DefaultValue(false)]
	[IODescription("FSW_Enabled")]
	public bool EnableRaisingEvents
	{
		get
		{
			return enabled;
		}
		set
		{
			if (enabled == value)
			{
				return;
			}
			enabled = value;
			if (!IsSuspended())
			{
				if (enabled)
				{
					StartRaisingEvents();
				}
				else
				{
					StopRaisingEvents();
				}
			}
		}
	}

	[DefaultValue("*.*")]
	[IODescription("FSW_Filter")]
	[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[SettingsBindable(true)]
	public string Filter
	{
		get
		{
			return filter;
		}
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				value = "*.*";
			}
			if (string.Compare(filter, value, StringComparison.OrdinalIgnoreCase) != 0)
			{
				filter = value;
			}
		}
	}

	[DefaultValue(false)]
	[IODescription("FSW_IncludeSubdirectories")]
	public bool IncludeSubdirectories
	{
		get
		{
			return includeSubdirectories;
		}
		set
		{
			if (includeSubdirectories != value)
			{
				includeSubdirectories = value;
				Restart();
			}
		}
	}

	[Browsable(false)]
	[DefaultValue(8192)]
	public int InternalBufferSize
	{
		get
		{
			return internalBufferSize;
		}
		set
		{
			if (internalBufferSize != value)
			{
				if (value < 4096)
				{
					value = 4096;
				}
				internalBufferSize = value;
				Restart();
			}
		}
	}

	private bool IsHandleInvalid
	{
		get
		{
			if (directoryHandle != null)
			{
				return directoryHandle.IsInvalid;
			}
			return true;
		}
	}

	[DefaultValue("")]
	[IODescription("FSW_Path")]
	[Editor("System.Diagnostics.Design.FSWPathEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[SettingsBindable(true)]
	public string Path
	{
		get
		{
			return directory;
		}
		set
		{
			value = ((value == null) ? string.Empty : value);
			if (string.Compare(directory, value, StringComparison.OrdinalIgnoreCase) == 0)
			{
				return;
			}
			if (base.DesignMode)
			{
				if (value.IndexOfAny(wildcards) != -1 || value.IndexOfAny(System.IO.Path.GetInvalidPathChars()) != -1)
				{
					throw new ArgumentException(SR.GetString("InvalidDirName", value));
				}
			}
			else if (!Directory.Exists(value))
			{
				throw new ArgumentException(SR.GetString("InvalidDirName", value));
			}
			directory = value;
			readGranted = false;
			Restart();
		}
	}

	[Browsable(false)]
	public override ISite Site
	{
		get
		{
			return base.Site;
		}
		set
		{
			base.Site = value;
			if (Site != null && Site.DesignMode)
			{
				EnableRaisingEvents = true;
			}
		}
	}

	[Browsable(false)]
	[DefaultValue(null)]
	[IODescription("FSW_SynchronizingObject")]
	public ISynchronizeInvoke SynchronizingObject
	{
		get
		{
			if (synchronizingObject == null && base.DesignMode)
			{
				IDesignerHost designerHost = (IDesignerHost)GetService(typeof(IDesignerHost));
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

	[IODescription("FSW_Changed")]
	public event FileSystemEventHandler Changed
	{
		add
		{
			onChangedHandler = (FileSystemEventHandler)Delegate.Combine(onChangedHandler, value);
		}
		remove
		{
			onChangedHandler = (FileSystemEventHandler)Delegate.Remove(onChangedHandler, value);
		}
	}

	[IODescription("FSW_Created")]
	public event FileSystemEventHandler Created
	{
		add
		{
			onCreatedHandler = (FileSystemEventHandler)Delegate.Combine(onCreatedHandler, value);
		}
		remove
		{
			onCreatedHandler = (FileSystemEventHandler)Delegate.Remove(onCreatedHandler, value);
		}
	}

	[IODescription("FSW_Deleted")]
	public event FileSystemEventHandler Deleted
	{
		add
		{
			onDeletedHandler = (FileSystemEventHandler)Delegate.Combine(onDeletedHandler, value);
		}
		remove
		{
			onDeletedHandler = (FileSystemEventHandler)Delegate.Remove(onDeletedHandler, value);
		}
	}

	[Browsable(false)]
	public event ErrorEventHandler Error
	{
		add
		{
			onErrorHandler = (ErrorEventHandler)Delegate.Combine(onErrorHandler, value);
		}
		remove
		{
			onErrorHandler = (ErrorEventHandler)Delegate.Remove(onErrorHandler, value);
		}
	}

	[IODescription("FSW_Renamed")]
	public event RenamedEventHandler Renamed
	{
		add
		{
			onRenamedHandler = (RenamedEventHandler)Delegate.Combine(onRenamedHandler, value);
		}
		remove
		{
			onRenamedHandler = (RenamedEventHandler)Delegate.Remove(onRenamedHandler, value);
		}
	}

	static FileSystemWatcher()
	{
		wildcards = new char[2] { '?', '*' };
		notifyFiltersValidMask = 0;
		foreach (int value in Enum.GetValues(typeof(NotifyFilters)))
		{
			notifyFiltersValidMask |= value;
		}
	}

	public FileSystemWatcher()
	{
		directory = string.Empty;
		filter = "*.*";
	}

	public FileSystemWatcher(string path)
		: this(path, "*.*")
	{
	}

	public FileSystemWatcher(string path, string filter)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (filter == null)
		{
			throw new ArgumentNullException("filter");
		}
		if (path.Length == 0 || !Directory.Exists(path))
		{
			throw new ArgumentException(SR.GetString("InvalidDirName", path));
		}
		directory = path;
		this.filter = filter;
	}

	public void BeginInit()
	{
		bool flag = enabled;
		StopRaisingEvents();
		enabled = flag;
		initializing = true;
	}

	private unsafe void CompletionStatusChanged(uint errorCode, uint numBytes, NativeOverlapped* overlappedPointer)
	{
		Overlapped overlapped = Overlapped.Unpack(overlappedPointer);
		FSWAsyncResult fSWAsyncResult = (FSWAsyncResult)overlapped.AsyncResult;
		try
		{
			if (stopListening)
			{
				return;
			}
			lock (this)
			{
				switch (errorCode)
				{
				case 995u:
					break;
				default:
					OnError(new ErrorEventArgs(new Win32Exception((int)errorCode)));
					EnableRaisingEvents = false;
					break;
				case 0u:
				{
					if (fSWAsyncResult.session != currentSession)
					{
						break;
					}
					if (numBytes == 0)
					{
						NotifyInternalBufferOverflowEvent();
						break;
					}
					int num = 0;
					string text = null;
					string text2 = null;
					int num2;
					do
					{
						int num3;
						fixed (byte* buffer = fSWAsyncResult.buffer)
						{
							num2 = *(int*)(buffer + num);
							num3 = ((int*)(buffer + num))[1];
							int num4 = ((int*)(buffer + num))[2];
							text2 = new string((char*)(buffer + num) + 6, 0, num4 / 2);
						}
						switch (num3)
						{
						case 4:
							text = text2;
							break;
						case 5:
							if (text != null)
							{
								NotifyRenameEventArgs(WatcherChangeTypes.Renamed, text2, text);
								text = null;
							}
							else
							{
								NotifyRenameEventArgs(WatcherChangeTypes.Renamed, text2, text);
								text = null;
							}
							break;
						default:
							if (text != null)
							{
								NotifyRenameEventArgs(WatcherChangeTypes.Renamed, null, text);
								text = null;
							}
							NotifyFileSystemEventArgs(num3, text2);
							break;
						}
						num += num2;
					}
					while (num2 != 0);
					if (text != null)
					{
						NotifyRenameEventArgs(WatcherChangeTypes.Renamed, null, text);
						text = null;
					}
					break;
				}
				}
			}
		}
		finally
		{
			Overlapped.Free(overlappedPointer);
			if (!stopListening && !runOnce)
			{
				Monitor(fSWAsyncResult.buffer);
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				StopRaisingEvents();
				onChangedHandler = null;
				onCreatedHandler = null;
				onDeletedHandler = null;
				onRenamedHandler = null;
				onErrorHandler = null;
				readGranted = false;
			}
			else
			{
				stopListening = true;
				if (!IsHandleInvalid)
				{
					directoryHandle.Close();
				}
			}
		}
		finally
		{
			disposed = true;
			base.Dispose(disposing);
		}
	}

	public void EndInit()
	{
		initializing = false;
		if (directory.Length != 0 && enabled)
		{
			StartRaisingEvents();
		}
	}

	private bool IsSuspended()
	{
		if (!initializing)
		{
			return base.DesignMode;
		}
		return true;
	}

	private bool MatchPattern(string relativePath)
	{
		string fileName = System.IO.Path.GetFileName(relativePath);
		if (fileName != null)
		{
			return PatternMatcher.StrictMatchPattern(filter.ToUpper(CultureInfo.InvariantCulture), fileName.ToUpper(CultureInfo.InvariantCulture));
		}
		return false;
	}

	private unsafe void Monitor(byte[] buffer)
	{
		if (!enabled || IsHandleInvalid)
		{
			return;
		}
		Overlapped overlapped = new Overlapped();
		if (buffer == null)
		{
			try
			{
				buffer = new byte[internalBufferSize];
			}
			catch (OutOfMemoryException)
			{
				throw new OutOfMemoryException(SR.GetString("BufferSizeTooLarge", internalBufferSize.ToString(CultureInfo.CurrentCulture)));
			}
		}
		FSWAsyncResult fSWAsyncResult = new FSWAsyncResult();
		fSWAsyncResult.session = currentSession;
		fSWAsyncResult.buffer = buffer;
		overlapped.AsyncResult = fSWAsyncResult;
		NativeOverlapped* ptr = overlapped.Pack(CompletionStatusChanged, buffer);
		bool flag = false;
		try
		{
			if (IsHandleInvalid)
			{
				return;
			}
			fixed (byte* ptr2 = buffer)
			{
				flag = Microsoft.Win32.UnsafeNativeMethods.ReadDirectoryChangesW(directoryHandle, new HandleRef(this, (IntPtr)ptr2), internalBufferSize, includeSubdirectories ? 1 : 0, (int)notifyFilters, out var _, ptr, Microsoft.Win32.NativeMethods.NullHandleRef);
			}
		}
		catch (ObjectDisposedException)
		{
		}
		catch (ArgumentNullException)
		{
		}
		finally
		{
			if (!flag)
			{
				Overlapped.Free(ptr);
				if (!IsHandleInvalid)
				{
					OnError(new ErrorEventArgs(new Win32Exception()));
				}
			}
		}
	}

	private void NotifyFileSystemEventArgs(int action, string name)
	{
		if (MatchPattern(name))
		{
			switch (action)
			{
			case 1:
				OnCreated(new FileSystemEventArgs(WatcherChangeTypes.Created, directory, name));
				break;
			case 2:
				OnDeleted(new FileSystemEventArgs(WatcherChangeTypes.Deleted, directory, name));
				break;
			case 3:
				OnChanged(new FileSystemEventArgs(WatcherChangeTypes.Changed, directory, name));
				break;
			}
		}
	}

	private void NotifyInternalBufferOverflowEvent()
	{
		InternalBufferOverflowException exception = new InternalBufferOverflowException(SR.GetString("FSW_BufferOverflow", directory));
		ErrorEventArgs e = new ErrorEventArgs(exception);
		OnError(e);
	}

	private void NotifyRenameEventArgs(WatcherChangeTypes action, string name, string oldName)
	{
		if (MatchPattern(name) || MatchPattern(oldName))
		{
			RenamedEventArgs e = new RenamedEventArgs(action, directory, name, oldName);
			OnRenamed(e);
		}
	}

	protected void OnChanged(FileSystemEventArgs e)
	{
		FileSystemEventHandler fileSystemEventHandler = onChangedHandler;
		if (fileSystemEventHandler != null)
		{
			if (SynchronizingObject != null && SynchronizingObject.InvokeRequired)
			{
				SynchronizingObject.BeginInvoke(fileSystemEventHandler, new object[2] { this, e });
			}
			else
			{
				fileSystemEventHandler(this, e);
			}
		}
	}

	protected void OnCreated(FileSystemEventArgs e)
	{
		FileSystemEventHandler fileSystemEventHandler = onCreatedHandler;
		if (fileSystemEventHandler != null)
		{
			if (SynchronizingObject != null && SynchronizingObject.InvokeRequired)
			{
				SynchronizingObject.BeginInvoke(fileSystemEventHandler, new object[2] { this, e });
			}
			else
			{
				fileSystemEventHandler(this, e);
			}
		}
	}

	protected void OnDeleted(FileSystemEventArgs e)
	{
		FileSystemEventHandler fileSystemEventHandler = onDeletedHandler;
		if (fileSystemEventHandler != null)
		{
			if (SynchronizingObject != null && SynchronizingObject.InvokeRequired)
			{
				SynchronizingObject.BeginInvoke(fileSystemEventHandler, new object[2] { this, e });
			}
			else
			{
				fileSystemEventHandler(this, e);
			}
		}
	}

	protected void OnError(ErrorEventArgs e)
	{
		ErrorEventHandler errorEventHandler = onErrorHandler;
		if (errorEventHandler != null)
		{
			if (SynchronizingObject != null && SynchronizingObject.InvokeRequired)
			{
				SynchronizingObject.BeginInvoke(errorEventHandler, new object[2] { this, e });
			}
			else
			{
				errorEventHandler(this, e);
			}
		}
	}

	private void OnInternalFileSystemEventArgs(object sender, FileSystemEventArgs e)
	{
		lock (this)
		{
			if (!isChanged)
			{
				changedResult = new WaitForChangedResult(e.ChangeType, e.Name, timedOut: false);
				isChanged = true;
				System.Threading.Monitor.Pulse(this);
			}
		}
	}

	private void OnInternalRenameEventArgs(object sender, RenamedEventArgs e)
	{
		lock (this)
		{
			if (!isChanged)
			{
				changedResult = new WaitForChangedResult(e.ChangeType, e.Name, e.OldName, timedOut: false);
				isChanged = true;
				System.Threading.Monitor.Pulse(this);
			}
		}
	}

	protected void OnRenamed(RenamedEventArgs e)
	{
		RenamedEventHandler renamedEventHandler = onRenamedHandler;
		if (renamedEventHandler != null)
		{
			if (SynchronizingObject != null && SynchronizingObject.InvokeRequired)
			{
				SynchronizingObject.BeginInvoke(renamedEventHandler, new object[2] { this, e });
			}
			else
			{
				renamedEventHandler(this, e);
			}
		}
	}

	private void Restart()
	{
		if (!IsSuspended() && enabled)
		{
			StopRaisingEvents();
			StartRaisingEvents();
		}
	}

	private void StartRaisingEvents()
	{
		if (disposed)
		{
			throw new ObjectDisposedException(GetType().Name);
		}
		try
		{
			new EnvironmentPermission(PermissionState.Unrestricted).Assert();
			if (Environment.OSVersion.Platform != PlatformID.Win32NT)
			{
				throw new PlatformNotSupportedException(SR.GetString("WinNTRequired"));
			}
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
		if (IsSuspended())
		{
			enabled = true;
			return;
		}
		if (!readGranted)
		{
			string fullPath = System.IO.Path.GetFullPath(directory);
			FileIOPermission fileIOPermission = new FileIOPermission(FileIOPermissionAccess.Read, fullPath);
			fileIOPermission.Demand();
			readGranted = true;
		}
		if (IsHandleInvalid)
		{
			directoryHandle = Microsoft.Win32.NativeMethods.CreateFile(directory, 1, 7, null, 3, 1107296256, new SafeFileHandle(IntPtr.Zero, ownsHandle: false));
			if (IsHandleInvalid)
			{
				throw new FileNotFoundException(SR.GetString("FSW_IOError", directory));
			}
			stopListening = false;
			Interlocked.Increment(ref currentSession);
			SecurityPermission securityPermission = new SecurityPermission(PermissionState.Unrestricted);
			securityPermission.Assert();
			try
			{
				ThreadPool.BindHandle(directoryHandle);
			}
			finally
			{
				CodeAccessPermission.RevertAssert();
			}
			enabled = true;
			Monitor(null);
		}
	}

	private void StopRaisingEvents()
	{
		if (IsSuspended())
		{
			enabled = false;
		}
		else if (!IsHandleInvalid)
		{
			stopListening = true;
			directoryHandle.Close();
			directoryHandle = null;
			Interlocked.Increment(ref currentSession);
			enabled = false;
		}
	}

	public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType)
	{
		return WaitForChanged(changeType, -1);
	}

	public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType, int timeout)
	{
		FileSystemEventHandler value = OnInternalFileSystemEventArgs;
		RenamedEventHandler value2 = OnInternalRenameEventArgs;
		isChanged = false;
		changedResult = WaitForChangedResult.TimedOutResult;
		if ((changeType & WatcherChangeTypes.Created) != 0)
		{
			Created += value;
		}
		if ((changeType & WatcherChangeTypes.Deleted) != 0)
		{
			Deleted += value;
		}
		if ((changeType & WatcherChangeTypes.Changed) != 0)
		{
			Changed += value;
		}
		if ((changeType & WatcherChangeTypes.Renamed) != 0)
		{
			Renamed += value2;
		}
		bool enableRaisingEvents = EnableRaisingEvents;
		if (!enableRaisingEvents)
		{
			runOnce = true;
			EnableRaisingEvents = true;
		}
		WaitForChangedResult timedOutResult = WaitForChangedResult.TimedOutResult;
		lock (this)
		{
			if (timeout == -1)
			{
				while (!isChanged)
				{
					System.Threading.Monitor.Wait(this);
				}
			}
			else
			{
				System.Threading.Monitor.Wait(this, timeout, exitContext: true);
			}
			timedOutResult = changedResult;
		}
		EnableRaisingEvents = enableRaisingEvents;
		runOnce = false;
		if ((changeType & WatcherChangeTypes.Created) != 0)
		{
			Created -= value;
		}
		if ((changeType & WatcherChangeTypes.Deleted) != 0)
		{
			Deleted -= value;
		}
		if ((changeType & WatcherChangeTypes.Changed) != 0)
		{
			Changed -= value;
		}
		if ((changeType & WatcherChangeTypes.Renamed) != 0)
		{
			Renamed -= value2;
		}
		return timedOutResult;
	}
}
