using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
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

[MonitoringDescription("ProcessDesc")]
[DefaultEvent("Exited")]
[DefaultProperty("StartInfo")]
[Designer("System.Diagnostics.Design.ProcessDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[HostProtection(SecurityAction.LinkDemand, SharedState = true, Synchronization = true, ExternalProcessMgmt = true, SelfAffectingProcessMgmt = true)]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class Process : Component
{
	private enum StreamReadMode
	{
		undefined,
		syncMode,
		asyncMode
	}

	private enum State
	{
		HaveId = 1,
		IsLocal = 2,
		IsNt = 4,
		HaveProcessInfo = 8,
		Exited = 16,
		Associated = 32,
		IsWin2k = 64,
		HaveNtProcessInfo = 12
	}

	private bool haveProcessId;

	private int processId;

	private bool haveProcessHandle;

	private SafeProcessHandle m_processHandle;

	private bool isRemoteMachine;

	private string machineName;

	private ProcessInfo processInfo;

	private int m_processAccess;

	private ProcessThreadCollection threads;

	private ProcessModuleCollection modules;

	private bool haveMainWindow;

	private IntPtr mainWindowHandle;

	private string mainWindowTitle;

	private bool haveWorkingSetLimits;

	private IntPtr minWorkingSet;

	private IntPtr maxWorkingSet;

	private bool haveProcessorAffinity;

	private IntPtr processorAffinity;

	private bool havePriorityClass;

	private ProcessPriorityClass priorityClass;

	private ProcessStartInfo startInfo;

	private bool watchForExit;

	private bool watchingForExit;

	private EventHandler onExited;

	private bool exited;

	private int exitCode;

	private bool signaled;

	private DateTime exitTime;

	private bool haveExitTime;

	private bool responding;

	private bool haveResponding;

	private bool priorityBoostEnabled;

	private bool havePriorityBoostEnabled;

	private bool raisedOnExited;

	private RegisteredWaitHandle registeredWaitHandle;

	private WaitHandle waitHandle;

	private ISynchronizeInvoke synchronizingObject;

	private StreamReader standardOutput;

	private StreamWriter standardInput;

	private StreamReader standardError;

	private OperatingSystem operatingSystem;

	private bool disposed;

	private static object s_CreateProcessLock = new object();

	private StreamReadMode outputStreamReadMode;

	private StreamReadMode errorStreamReadMode;

	internal AsyncStreamReader output;

	internal AsyncStreamReader error;

	internal bool pendingOutputRead;

	internal bool pendingErrorRead;

	private static SafeFileHandle InvalidPipeHandle = new SafeFileHandle(IntPtr.Zero, ownsHandle: false);

	internal static TraceSwitch processTracing = null;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessAssociated")]
	private bool Associated
	{
		get
		{
			if (!haveProcessId)
			{
				return haveProcessHandle;
			}
			return true;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessBasePriority")]
	public int BasePriority
	{
		get
		{
			EnsureState(State.HaveProcessInfo);
			return processInfo.basePriority;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessExitCode")]
	public int ExitCode
	{
		get
		{
			EnsureState(State.Exited);
			return exitCode;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessTerminated")]
	public bool HasExited
	{
		get
		{
			if (!exited)
			{
				EnsureState(State.Associated);
				SafeProcessHandle safeProcessHandle = null;
				try
				{
					safeProcessHandle = GetProcessHandle(1049600, throwIfExited: false);
					int num;
					if (safeProcessHandle.IsInvalid)
					{
						exited = true;
					}
					else if (Microsoft.Win32.NativeMethods.GetExitCodeProcess(safeProcessHandle, out num) && num != 259)
					{
						exited = true;
						exitCode = num;
					}
					else
					{
						if (!signaled)
						{
							ProcessWaitHandle processWaitHandle = null;
							try
							{
								processWaitHandle = new ProcessWaitHandle(safeProcessHandle);
								signaled = processWaitHandle.WaitOne(0, exitContext: false);
							}
							finally
							{
								processWaitHandle?.Close();
							}
						}
						if (signaled)
						{
							if (!Microsoft.Win32.NativeMethods.GetExitCodeProcess(safeProcessHandle, out num))
							{
								throw new Win32Exception();
							}
							exited = true;
							exitCode = num;
						}
					}
				}
				finally
				{
					ReleaseProcessHandle(safeProcessHandle);
				}
				if (exited)
				{
					RaiseOnExited();
				}
			}
			return exited;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessExitTime")]
	public DateTime ExitTime
	{
		get
		{
			if (!haveExitTime)
			{
				EnsureState((State)20);
				exitTime = GetProcessTimes().ExitTime;
				haveExitTime = true;
			}
			return exitTime;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessHandle")]
	public IntPtr Handle
	{
		get
		{
			EnsureState(State.Associated);
			return OpenProcessHandle(m_processAccess).DangerousGetHandle();
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public SafeProcessHandle SafeHandle
	{
		get
		{
			EnsureState(State.Associated);
			return OpenProcessHandle(m_processAccess);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessHandleCount")]
	public int HandleCount
	{
		get
		{
			EnsureState(State.HaveProcessInfo);
			return processInfo.handleCount;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessId")]
	public int Id
	{
		get
		{
			EnsureState(State.HaveId);
			return processId;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessMachineName")]
	public string MachineName
	{
		get
		{
			EnsureState(State.Associated);
			return machineName;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessMainWindowHandle")]
	public IntPtr MainWindowHandle
	{
		get
		{
			if (!haveMainWindow)
			{
				EnsureState((State)3);
				mainWindowHandle = ProcessManager.GetMainWindowHandle(processId);
				if (mainWindowHandle != (IntPtr)0)
				{
					haveMainWindow = true;
				}
				else
				{
					EnsureState(State.HaveProcessInfo);
				}
			}
			return mainWindowHandle;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessMainWindowTitle")]
	public string MainWindowTitle
	{
		get
		{
			if (mainWindowTitle == null)
			{
				IntPtr intPtr = MainWindowHandle;
				if (intPtr == (IntPtr)0)
				{
					mainWindowTitle = string.Empty;
				}
				else
				{
					int capacity = Microsoft.Win32.NativeMethods.GetWindowTextLength(new HandleRef(this, intPtr)) * 2;
					StringBuilder stringBuilder = new StringBuilder(capacity);
					Microsoft.Win32.NativeMethods.GetWindowText(new HandleRef(this, intPtr), stringBuilder, stringBuilder.Capacity);
					mainWindowTitle = stringBuilder.ToString();
				}
			}
			return mainWindowTitle;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessMainModule")]
	public ProcessModule MainModule
	{
		get
		{
			if (OperatingSystem.Platform == PlatformID.Win32NT)
			{
				EnsureState((State)3);
				ModuleInfo firstModuleInfo = NtProcessManager.GetFirstModuleInfo(processId);
				return new ProcessModule(firstModuleInfo);
			}
			ProcessModuleCollection processModuleCollection = Modules;
			EnsureState(State.HaveProcessInfo);
			foreach (ProcessModule item in processModuleCollection)
			{
				if (item.moduleInfo.Id == processInfo.mainModuleId)
				{
					return item;
				}
			}
			return null;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessMaxWorkingSet")]
	public IntPtr MaxWorkingSet
	{
		get
		{
			EnsureWorkingSetLimits();
			return maxWorkingSet;
		}
		set
		{
			SetWorkingSetLimits(null, value);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessMinWorkingSet")]
	public IntPtr MinWorkingSet
	{
		get
		{
			EnsureWorkingSetLimits();
			return minWorkingSet;
		}
		set
		{
			SetWorkingSetLimits(value, null);
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessModules")]
	public ProcessModuleCollection Modules
	{
		get
		{
			if (modules == null)
			{
				EnsureState((State)3);
				ModuleInfo[] moduleInfos = ProcessManager.GetModuleInfos(processId);
				ProcessModule[] array = new ProcessModule[moduleInfos.Length];
				for (int i = 0; i < moduleInfos.Length; i++)
				{
					array[i] = new ProcessModule(moduleInfos[i]);
				}
				ProcessModuleCollection processModuleCollection = new ProcessModuleCollection(array);
				modules = processModuleCollection;
			}
			return modules;
		}
	}

	[Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.NonpagedSystemMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessNonpagedSystemMemorySize")]
	public int NonpagedSystemMemorySize
	{
		get
		{
			EnsureState(State.HaveNtProcessInfo);
			return (int)processInfo.poolNonpagedBytes;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessNonpagedSystemMemorySize")]
	[ComVisible(false)]
	public long NonpagedSystemMemorySize64
	{
		get
		{
			EnsureState(State.HaveNtProcessInfo);
			return processInfo.poolNonpagedBytes;
		}
	}

	[Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.PagedMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessPagedMemorySize")]
	public int PagedMemorySize
	{
		get
		{
			EnsureState(State.HaveNtProcessInfo);
			return (int)processInfo.pageFileBytes;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessPagedMemorySize")]
	[ComVisible(false)]
	public long PagedMemorySize64
	{
		get
		{
			EnsureState(State.HaveNtProcessInfo);
			return processInfo.pageFileBytes;
		}
	}

	[Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.PagedSystemMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessPagedSystemMemorySize")]
	public int PagedSystemMemorySize
	{
		get
		{
			EnsureState(State.HaveNtProcessInfo);
			return (int)processInfo.poolPagedBytes;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessPagedSystemMemorySize")]
	[ComVisible(false)]
	public long PagedSystemMemorySize64
	{
		get
		{
			EnsureState(State.HaveNtProcessInfo);
			return processInfo.poolPagedBytes;
		}
	}

	[Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.PeakPagedMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessPeakPagedMemorySize")]
	public int PeakPagedMemorySize
	{
		get
		{
			EnsureState(State.HaveNtProcessInfo);
			return (int)processInfo.pageFileBytesPeak;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessPeakPagedMemorySize")]
	[ComVisible(false)]
	public long PeakPagedMemorySize64
	{
		get
		{
			EnsureState(State.HaveNtProcessInfo);
			return processInfo.pageFileBytesPeak;
		}
	}

	[Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.PeakWorkingSet64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessPeakWorkingSet")]
	public int PeakWorkingSet
	{
		get
		{
			EnsureState(State.HaveNtProcessInfo);
			return (int)processInfo.workingSetPeak;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessPeakWorkingSet")]
	[ComVisible(false)]
	public long PeakWorkingSet64
	{
		get
		{
			EnsureState(State.HaveNtProcessInfo);
			return processInfo.workingSetPeak;
		}
	}

	[Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.PeakVirtualMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessPeakVirtualMemorySize")]
	public int PeakVirtualMemorySize
	{
		get
		{
			EnsureState(State.HaveNtProcessInfo);
			return (int)processInfo.virtualBytesPeak;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessPeakVirtualMemorySize")]
	[ComVisible(false)]
	public long PeakVirtualMemorySize64
	{
		get
		{
			EnsureState(State.HaveNtProcessInfo);
			return processInfo.virtualBytesPeak;
		}
	}

	private OperatingSystem OperatingSystem
	{
		get
		{
			if (operatingSystem == null)
			{
				operatingSystem = Environment.OSVersion;
			}
			return operatingSystem;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessPriorityBoostEnabled")]
	public bool PriorityBoostEnabled
	{
		get
		{
			EnsureState(State.IsNt);
			if (!havePriorityBoostEnabled)
			{
				SafeProcessHandle handle = null;
				try
				{
					handle = GetProcessHandle(1024);
					bool disabled = false;
					if (!Microsoft.Win32.NativeMethods.GetProcessPriorityBoost(handle, out disabled))
					{
						throw new Win32Exception();
					}
					priorityBoostEnabled = !disabled;
					havePriorityBoostEnabled = true;
				}
				finally
				{
					ReleaseProcessHandle(handle);
				}
			}
			return priorityBoostEnabled;
		}
		set
		{
			EnsureState(State.IsNt);
			SafeProcessHandle handle = null;
			try
			{
				handle = GetProcessHandle(512);
				if (!Microsoft.Win32.NativeMethods.SetProcessPriorityBoost(handle, !value))
				{
					throw new Win32Exception();
				}
				priorityBoostEnabled = value;
				havePriorityBoostEnabled = true;
			}
			finally
			{
				ReleaseProcessHandle(handle);
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessPriorityClass")]
	public ProcessPriorityClass PriorityClass
	{
		get
		{
			if (!havePriorityClass)
			{
				SafeProcessHandle handle = null;
				try
				{
					handle = GetProcessHandle(1024);
					int num = Microsoft.Win32.NativeMethods.GetPriorityClass(handle);
					if (num == 0)
					{
						throw new Win32Exception();
					}
					priorityClass = (ProcessPriorityClass)num;
					havePriorityClass = true;
				}
				finally
				{
					ReleaseProcessHandle(handle);
				}
			}
			return priorityClass;
		}
		set
		{
			if (!Enum.IsDefined(typeof(ProcessPriorityClass), value))
			{
				throw new InvalidEnumArgumentException("value", (int)value, typeof(ProcessPriorityClass));
			}
			if ((value & (ProcessPriorityClass)49152) != 0 && (OperatingSystem.Platform != PlatformID.Win32NT || OperatingSystem.Version.Major < 5))
			{
				throw new PlatformNotSupportedException(SR.GetString("PriorityClassNotSupported"), null);
			}
			SafeProcessHandle handle = null;
			try
			{
				handle = GetProcessHandle(512);
				if (!Microsoft.Win32.NativeMethods.SetPriorityClass(handle, (int)value))
				{
					throw new Win32Exception();
				}
				priorityClass = value;
				havePriorityClass = true;
			}
			finally
			{
				ReleaseProcessHandle(handle);
			}
		}
	}

	[Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.PrivateMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessPrivateMemorySize")]
	public int PrivateMemorySize
	{
		get
		{
			EnsureState(State.HaveNtProcessInfo);
			return (int)processInfo.privateBytes;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessPrivateMemorySize")]
	[ComVisible(false)]
	public long PrivateMemorySize64
	{
		get
		{
			EnsureState(State.HaveNtProcessInfo);
			return processInfo.privateBytes;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessPrivilegedProcessorTime")]
	public TimeSpan PrivilegedProcessorTime
	{
		get
		{
			EnsureState(State.IsNt);
			return GetProcessTimes().PrivilegedProcessorTime;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessProcessName")]
	public string ProcessName
	{
		get
		{
			EnsureState(State.HaveProcessInfo);
			string processName = processInfo.processName;
			if (processName.Length == 15 && ProcessManager.IsNt && ProcessManager.IsOSOlderThanXP && !isRemoteMachine)
			{
				try
				{
					string moduleName = MainModule.ModuleName;
					if (moduleName != null)
					{
						processInfo.processName = Path.ChangeExtension(Path.GetFileName(moduleName), null);
					}
				}
				catch (Exception)
				{
				}
			}
			return processInfo.processName;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessProcessorAffinity")]
	public IntPtr ProcessorAffinity
	{
		get
		{
			if (!haveProcessorAffinity)
			{
				SafeProcessHandle handle = null;
				try
				{
					handle = GetProcessHandle(1024);
					if (!Microsoft.Win32.NativeMethods.GetProcessAffinityMask(handle, out var processMask, out var _))
					{
						throw new Win32Exception();
					}
					processorAffinity = processMask;
				}
				finally
				{
					ReleaseProcessHandle(handle);
				}
				haveProcessorAffinity = true;
			}
			return processorAffinity;
		}
		set
		{
			SafeProcessHandle handle = null;
			try
			{
				handle = GetProcessHandle(512);
				if (!Microsoft.Win32.NativeMethods.SetProcessAffinityMask(handle, value))
				{
					throw new Win32Exception();
				}
				processorAffinity = value;
				haveProcessorAffinity = true;
			}
			finally
			{
				ReleaseProcessHandle(handle);
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessResponding")]
	public bool Responding
	{
		get
		{
			if (!haveResponding)
			{
				IntPtr intPtr = MainWindowHandle;
				if (intPtr == (IntPtr)0)
				{
					responding = true;
				}
				else
				{
					responding = Microsoft.Win32.NativeMethods.SendMessageTimeout(new HandleRef(this, intPtr), 0, IntPtr.Zero, IntPtr.Zero, 2, 5000, out var _) != (IntPtr)0;
				}
			}
			return responding;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessSessionId")]
	public int SessionId
	{
		get
		{
			EnsureState(State.HaveNtProcessInfo);
			return processInfo.sessionId;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[MonitoringDescription("ProcessStartInfo")]
	public ProcessStartInfo StartInfo
	{
		get
		{
			if (startInfo == null)
			{
				startInfo = new ProcessStartInfo(this);
			}
			return startInfo;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			startInfo = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessStartTime")]
	public DateTime StartTime
	{
		get
		{
			EnsureState(State.IsNt);
			return GetProcessTimes().StartTime;
		}
	}

	[Browsable(false)]
	[DefaultValue(null)]
	[MonitoringDescription("ProcessSynchronizingObject")]
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

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessThreads")]
	public ProcessThreadCollection Threads
	{
		get
		{
			if (threads == null)
			{
				EnsureState(State.HaveProcessInfo);
				int count = processInfo.threadInfoList.Count;
				ProcessThread[] array = new ProcessThread[count];
				for (int i = 0; i < count; i++)
				{
					array[i] = new ProcessThread(isRemoteMachine, (ThreadInfo)processInfo.threadInfoList[i]);
				}
				ProcessThreadCollection processThreadCollection = new ProcessThreadCollection(array);
				threads = processThreadCollection;
			}
			return threads;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessTotalProcessorTime")]
	public TimeSpan TotalProcessorTime
	{
		get
		{
			EnsureState(State.IsNt);
			return GetProcessTimes().TotalProcessorTime;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessUserProcessorTime")]
	public TimeSpan UserProcessorTime
	{
		get
		{
			EnsureState(State.IsNt);
			return GetProcessTimes().UserProcessorTime;
		}
	}

	[Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.VirtualMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessVirtualMemorySize")]
	public int VirtualMemorySize
	{
		get
		{
			EnsureState(State.HaveNtProcessInfo);
			return (int)processInfo.virtualBytes;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessVirtualMemorySize")]
	[ComVisible(false)]
	public long VirtualMemorySize64
	{
		get
		{
			EnsureState(State.HaveNtProcessInfo);
			return processInfo.virtualBytes;
		}
	}

	[Browsable(false)]
	[DefaultValue(false)]
	[MonitoringDescription("ProcessEnableRaisingEvents")]
	public bool EnableRaisingEvents
	{
		get
		{
			return watchForExit;
		}
		set
		{
			if (value == watchForExit)
			{
				return;
			}
			if (Associated)
			{
				if (value)
				{
					OpenProcessHandle();
					EnsureWatchingForExit();
				}
				else
				{
					StopWatchingForExit();
				}
			}
			watchForExit = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessStandardInput")]
	public StreamWriter StandardInput
	{
		get
		{
			if (standardInput == null)
			{
				throw new InvalidOperationException(SR.GetString("CantGetStandardIn"));
			}
			return standardInput;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessStandardOutput")]
	public StreamReader StandardOutput
	{
		get
		{
			if (standardOutput == null)
			{
				throw new InvalidOperationException(SR.GetString("CantGetStandardOut"));
			}
			if (outputStreamReadMode == StreamReadMode.undefined)
			{
				outputStreamReadMode = StreamReadMode.syncMode;
			}
			else if (outputStreamReadMode != StreamReadMode.syncMode)
			{
				throw new InvalidOperationException(SR.GetString("CantMixSyncAsyncOperation"));
			}
			return standardOutput;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessStandardError")]
	public StreamReader StandardError
	{
		get
		{
			if (standardError == null)
			{
				throw new InvalidOperationException(SR.GetString("CantGetStandardError"));
			}
			if (errorStreamReadMode == StreamReadMode.undefined)
			{
				errorStreamReadMode = StreamReadMode.syncMode;
			}
			else if (errorStreamReadMode != StreamReadMode.syncMode)
			{
				throw new InvalidOperationException(SR.GetString("CantMixSyncAsyncOperation"));
			}
			return standardError;
		}
	}

	[Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.WorkingSet64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessWorkingSet")]
	public int WorkingSet
	{
		get
		{
			EnsureState(State.HaveNtProcessInfo);
			return (int)processInfo.workingSet;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("ProcessWorkingSet")]
	[ComVisible(false)]
	public long WorkingSet64
	{
		get
		{
			EnsureState(State.HaveNtProcessInfo);
			return processInfo.workingSet;
		}
	}

	[Browsable(true)]
	[MonitoringDescription("ProcessAssociated")]
	public event DataReceivedEventHandler OutputDataReceived;

	[Browsable(true)]
	[MonitoringDescription("ProcessAssociated")]
	public event DataReceivedEventHandler ErrorDataReceived;

	[Category("Behavior")]
	[MonitoringDescription("ProcessExited")]
	public event EventHandler Exited
	{
		add
		{
			onExited = (EventHandler)Delegate.Combine(onExited, value);
		}
		remove
		{
			onExited = (EventHandler)Delegate.Remove(onExited, value);
		}
	}

	public Process()
	{
		machineName = ".";
		outputStreamReadMode = StreamReadMode.undefined;
		errorStreamReadMode = StreamReadMode.undefined;
		m_processAccess = 2035711;
	}

	private Process(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo)
	{
		this.processInfo = processInfo;
		this.machineName = machineName;
		this.isRemoteMachine = isRemoteMachine;
		this.processId = processId;
		haveProcessId = true;
		outputStreamReadMode = StreamReadMode.undefined;
		errorStreamReadMode = StreamReadMode.undefined;
		m_processAccess = 2035711;
	}

	private ProcessThreadTimes GetProcessTimes()
	{
		ProcessThreadTimes processThreadTimes = new ProcessThreadTimes();
		SafeProcessHandle safeProcessHandle = null;
		try
		{
			int access = 1024;
			if (EnvironmentHelpers.IsWindowsVistaOrAbove())
			{
				access = 4096;
			}
			safeProcessHandle = GetProcessHandle(access, throwIfExited: false);
			if (safeProcessHandle.IsInvalid)
			{
				throw new InvalidOperationException(SR.GetString("ProcessHasExited", processId.ToString(CultureInfo.CurrentCulture)));
			}
			if (!Microsoft.Win32.NativeMethods.GetProcessTimes(safeProcessHandle, out processThreadTimes.create, out processThreadTimes.exit, out processThreadTimes.kernel, out processThreadTimes.user))
			{
				throw new Win32Exception();
			}
			return processThreadTimes;
		}
		finally
		{
			ReleaseProcessHandle(safeProcessHandle);
		}
	}

	public bool CloseMainWindow()
	{
		IntPtr intPtr = MainWindowHandle;
		if (intPtr == (IntPtr)0)
		{
			return false;
		}
		int windowLong = Microsoft.Win32.NativeMethods.GetWindowLong(new HandleRef(this, intPtr), -16);
		if ((windowLong & 0x8000000) != 0)
		{
			return false;
		}
		Microsoft.Win32.NativeMethods.PostMessage(new HandleRef(this, intPtr), 16, IntPtr.Zero, IntPtr.Zero);
		return true;
	}

	private void ReleaseProcessHandle(SafeProcessHandle handle)
	{
		if (handle != null && (!haveProcessHandle || handle != m_processHandle))
		{
			handle.Close();
		}
	}

	private void CompletionCallback(object context, bool wasSignaled)
	{
		StopWatchingForExit();
		RaiseOnExited();
	}

	protected override void Dispose(bool disposing)
	{
		if (!disposed)
		{
			if (disposing)
			{
				Close();
			}
			disposed = true;
			base.Dispose(disposing);
		}
	}

	public void Close()
	{
		if (Associated)
		{
			if (haveProcessHandle)
			{
				StopWatchingForExit();
				m_processHandle.Close();
				m_processHandle = null;
				haveProcessHandle = false;
			}
			haveProcessId = false;
			isRemoteMachine = false;
			machineName = ".";
			raisedOnExited = false;
			standardOutput = null;
			standardInput = null;
			standardError = null;
			output = null;
			error = null;
			Refresh();
		}
	}

	private void EnsureState(State state)
	{
		if ((state & State.IsWin2k) != 0 && (OperatingSystem.Platform != PlatformID.Win32NT || OperatingSystem.Version.Major < 5))
		{
			throw new PlatformNotSupportedException(SR.GetString("Win2kRequired"));
		}
		if ((state & State.IsNt) != 0 && OperatingSystem.Platform != PlatformID.Win32NT)
		{
			throw new PlatformNotSupportedException(SR.GetString("WinNTRequired"));
		}
		if ((state & State.Associated) != 0 && !Associated)
		{
			throw new InvalidOperationException(SR.GetString("NoAssociatedProcess"));
		}
		if ((state & State.HaveId) != 0 && !haveProcessId)
		{
			if (!haveProcessHandle)
			{
				EnsureState(State.Associated);
				throw new InvalidOperationException(SR.GetString("ProcessIdRequired"));
			}
			SetProcessId(ProcessManager.GetProcessIdFromHandle(m_processHandle));
		}
		if ((state & State.IsLocal) != 0 && isRemoteMachine)
		{
			throw new NotSupportedException(SR.GetString("NotSupportedRemote"));
		}
		if ((state & State.HaveProcessInfo) != 0 && processInfo == null)
		{
			if ((state & State.HaveId) == 0)
			{
				EnsureState(State.HaveId);
			}
			processInfo = ProcessManager.GetProcessInfo(processId, machineName);
			if (processInfo == null)
			{
				throw new InvalidOperationException(SR.GetString("NoProcessInfo"));
			}
		}
		if ((state & State.Exited) != 0)
		{
			if (!HasExited)
			{
				throw new InvalidOperationException(SR.GetString("WaitTillExit"));
			}
			if (!haveProcessHandle)
			{
				throw new InvalidOperationException(SR.GetString("NoProcessHandle"));
			}
		}
	}

	private void EnsureWatchingForExit()
	{
		if (watchingForExit)
		{
			return;
		}
		lock (this)
		{
			if (!watchingForExit)
			{
				watchingForExit = true;
				try
				{
					waitHandle = new ProcessWaitHandle(m_processHandle);
					registeredWaitHandle = ThreadPool.RegisterWaitForSingleObject(waitHandle, CompletionCallback, null, -1, executeOnlyOnce: true);
					return;
				}
				catch
				{
					watchingForExit = false;
					throw;
				}
			}
		}
	}

	private void EnsureWorkingSetLimits()
	{
		EnsureState(State.IsNt);
		if (haveWorkingSetLimits)
		{
			return;
		}
		SafeProcessHandle handle = null;
		try
		{
			handle = GetProcessHandle(1024);
			if (!Microsoft.Win32.NativeMethods.GetProcessWorkingSetSize(handle, out var min, out var max))
			{
				throw new Win32Exception();
			}
			minWorkingSet = min;
			maxWorkingSet = max;
			haveWorkingSetLimits = true;
		}
		finally
		{
			ReleaseProcessHandle(handle);
		}
	}

	public static void EnterDebugMode()
	{
		if (ProcessManager.IsNt)
		{
			SetPrivilege("SeDebugPrivilege", 2);
		}
	}

	private static void SetPrivilege(string privilegeName, int attrib)
	{
		IntPtr TokenHandle = (IntPtr)0;
		Microsoft.Win32.NativeMethods.LUID lpLuid = default(Microsoft.Win32.NativeMethods.LUID);
		IntPtr currentProcess = Microsoft.Win32.NativeMethods.GetCurrentProcess();
		if (!Microsoft.Win32.NativeMethods.OpenProcessToken(new HandleRef(null, currentProcess), 32, out TokenHandle))
		{
			throw new Win32Exception();
		}
		try
		{
			if (!Microsoft.Win32.NativeMethods.LookupPrivilegeValue(null, privilegeName, out lpLuid))
			{
				throw new Win32Exception();
			}
			Microsoft.Win32.NativeMethods.TokenPrivileges tokenPrivileges = new Microsoft.Win32.NativeMethods.TokenPrivileges();
			tokenPrivileges.Luid = lpLuid;
			tokenPrivileges.Attributes = attrib;
			Microsoft.Win32.NativeMethods.AdjustTokenPrivileges(new HandleRef(null, TokenHandle), DisableAllPrivileges: false, tokenPrivileges, 0, IntPtr.Zero, IntPtr.Zero);
			if (Marshal.GetLastWin32Error() != 0)
			{
				throw new Win32Exception();
			}
		}
		finally
		{
			Microsoft.Win32.SafeNativeMethods.CloseHandle(TokenHandle);
		}
	}

	public static void LeaveDebugMode()
	{
		if (ProcessManager.IsNt)
		{
			SetPrivilege("SeDebugPrivilege", 0);
		}
	}

	public static Process GetProcessById(int processId, string machineName)
	{
		if (!ProcessManager.IsProcessRunning(processId, machineName))
		{
			throw new ArgumentException(SR.GetString("MissingProccess", processId.ToString(CultureInfo.CurrentCulture)));
		}
		return new Process(machineName, ProcessManager.IsRemoteMachine(machineName), processId, null);
	}

	public static Process GetProcessById(int processId)
	{
		return GetProcessById(processId, ".");
	}

	public static Process[] GetProcessesByName(string processName)
	{
		return GetProcessesByName(processName, ".");
	}

	public static Process[] GetProcessesByName(string processName, string machineName)
	{
		if (processName == null)
		{
			processName = string.Empty;
		}
		Process[] processes = GetProcesses(machineName);
		ArrayList arrayList = new ArrayList();
		for (int i = 0; i < processes.Length; i++)
		{
			if (string.Equals(processName, processes[i].ProcessName, StringComparison.OrdinalIgnoreCase))
			{
				arrayList.Add(processes[i]);
			}
			else
			{
				processes[i].Dispose();
			}
		}
		Process[] array = new Process[arrayList.Count];
		arrayList.CopyTo(array, 0);
		return array;
	}

	public static Process[] GetProcesses()
	{
		return GetProcesses(".");
	}

	public static Process[] GetProcesses(string machineName)
	{
		bool flag = ProcessManager.IsRemoteMachine(machineName);
		ProcessInfo[] processInfos = ProcessManager.GetProcessInfos(machineName);
		Process[] array = new Process[processInfos.Length];
		for (int i = 0; i < processInfos.Length; i++)
		{
			ProcessInfo processInfo = processInfos[i];
			array[i] = new Process(machineName, flag, processInfo.processId, processInfo);
		}
		return array;
	}

	public static Process GetCurrentProcess()
	{
		return new Process(".", isRemoteMachine: false, Microsoft.Win32.NativeMethods.GetCurrentProcessId(), null);
	}

	protected void OnExited()
	{
		EventHandler eventHandler = onExited;
		if (eventHandler != null)
		{
			if (SynchronizingObject != null && SynchronizingObject.InvokeRequired)
			{
				SynchronizingObject.BeginInvoke(eventHandler, new object[2]
				{
					this,
					EventArgs.Empty
				});
			}
			else
			{
				eventHandler(this, EventArgs.Empty);
			}
		}
	}

	private SafeProcessHandle GetProcessHandle(int access, bool throwIfExited)
	{
		if (haveProcessHandle)
		{
			if (throwIfExited)
			{
				ProcessWaitHandle processWaitHandle = null;
				try
				{
					processWaitHandle = new ProcessWaitHandle(m_processHandle);
					if (processWaitHandle.WaitOne(0, exitContext: false))
					{
						if (haveProcessId)
						{
							throw new InvalidOperationException(SR.GetString("ProcessHasExited", processId.ToString(CultureInfo.CurrentCulture)));
						}
						throw new InvalidOperationException(SR.GetString("ProcessHasExitedNoId"));
					}
				}
				finally
				{
					processWaitHandle?.Close();
				}
			}
			return m_processHandle;
		}
		EnsureState((State)3);
		SafeProcessHandle invalidHandle = SafeProcessHandle.InvalidHandle;
		invalidHandle = ProcessManager.OpenProcess(processId, access, throwIfExited);
		if (throwIfExited && (access & 0x400) != 0 && Microsoft.Win32.NativeMethods.GetExitCodeProcess(invalidHandle, out exitCode) && exitCode != 259)
		{
			throw new InvalidOperationException(SR.GetString("ProcessHasExited", processId.ToString(CultureInfo.CurrentCulture)));
		}
		return invalidHandle;
	}

	private SafeProcessHandle GetProcessHandle(int access)
	{
		return GetProcessHandle(access, throwIfExited: true);
	}

	private SafeProcessHandle OpenProcessHandle()
	{
		return OpenProcessHandle(2035711);
	}

	private SafeProcessHandle OpenProcessHandle(int access)
	{
		if (!haveProcessHandle)
		{
			if (disposed)
			{
				throw new ObjectDisposedException(GetType().Name);
			}
			SetProcessHandle(GetProcessHandle(access));
		}
		return m_processHandle;
	}

	private void RaiseOnExited()
	{
		if (raisedOnExited)
		{
			return;
		}
		lock (this)
		{
			if (!raisedOnExited)
			{
				raisedOnExited = true;
				OnExited();
			}
		}
	}

	public void Refresh()
	{
		processInfo = null;
		threads = null;
		modules = null;
		mainWindowTitle = null;
		exited = false;
		signaled = false;
		haveMainWindow = false;
		haveWorkingSetLimits = false;
		haveProcessorAffinity = false;
		havePriorityClass = false;
		haveExitTime = false;
		haveResponding = false;
		havePriorityBoostEnabled = false;
	}

	private void SetProcessHandle(SafeProcessHandle processHandle)
	{
		m_processHandle = processHandle;
		haveProcessHandle = true;
		if (watchForExit)
		{
			EnsureWatchingForExit();
		}
	}

	private void SetProcessId(int processId)
	{
		this.processId = processId;
		haveProcessId = true;
	}

	private void SetWorkingSetLimits(object newMin, object newMax)
	{
		EnsureState(State.IsNt);
		SafeProcessHandle handle = null;
		try
		{
			handle = GetProcessHandle(1280);
			if (!Microsoft.Win32.NativeMethods.GetProcessWorkingSetSize(handle, out var min, out var max))
			{
				throw new Win32Exception();
			}
			if (newMin != null)
			{
				min = (IntPtr)newMin;
			}
			if (newMax != null)
			{
				max = (IntPtr)newMax;
			}
			if ((long)min > (long)max)
			{
				if (newMin != null)
				{
					throw new ArgumentException(SR.GetString("BadMinWorkset"));
				}
				throw new ArgumentException(SR.GetString("BadMaxWorkset"));
			}
			if (!Microsoft.Win32.NativeMethods.SetProcessWorkingSetSize(handle, min, max))
			{
				throw new Win32Exception();
			}
			if (!Microsoft.Win32.NativeMethods.GetProcessWorkingSetSize(handle, out min, out max))
			{
				throw new Win32Exception();
			}
			minWorkingSet = min;
			maxWorkingSet = max;
			haveWorkingSetLimits = true;
		}
		finally
		{
			ReleaseProcessHandle(handle);
		}
	}

	public bool Start()
	{
		Close();
		ProcessStartInfo processStartInfo = StartInfo;
		if (processStartInfo.FileName.Length == 0)
		{
			throw new InvalidOperationException(SR.GetString("FileNameMissing"));
		}
		if (processStartInfo.UseShellExecute)
		{
			return StartWithShellExecuteEx(processStartInfo);
		}
		return StartWithCreateProcess(processStartInfo);
	}

	private static void CreatePipeWithSecurityAttributes(out SafeFileHandle hReadPipe, out SafeFileHandle hWritePipe, Microsoft.Win32.NativeMethods.SECURITY_ATTRIBUTES lpPipeAttributes, int nSize)
	{
		if (!Microsoft.Win32.NativeMethods.CreatePipe(out hReadPipe, out hWritePipe, lpPipeAttributes, nSize) || hReadPipe.IsInvalid || hWritePipe.IsInvalid)
		{
			throw new Win32Exception();
		}
	}

	private void CreatePipe(out SafeFileHandle parentHandle, out SafeFileHandle childHandle, bool parentInputs)
	{
		Microsoft.Win32.NativeMethods.SECURITY_ATTRIBUTES sECURITY_ATTRIBUTES = new Microsoft.Win32.NativeMethods.SECURITY_ATTRIBUTES();
		sECURITY_ATTRIBUTES.bInheritHandle = true;
		SafeFileHandle hReadPipe = null;
		try
		{
			if (parentInputs)
			{
				CreatePipeWithSecurityAttributes(out childHandle, out hReadPipe, sECURITY_ATTRIBUTES, 0);
			}
			else
			{
				CreatePipeWithSecurityAttributes(out hReadPipe, out childHandle, sECURITY_ATTRIBUTES, 0);
			}
			if (!Microsoft.Win32.NativeMethods.DuplicateHandle(new HandleRef(this, Microsoft.Win32.NativeMethods.GetCurrentProcess()), (SafeHandle)hReadPipe, new HandleRef(this, Microsoft.Win32.NativeMethods.GetCurrentProcess()), out parentHandle, 0, bInheritHandle: false, 2))
			{
				throw new Win32Exception();
			}
		}
		finally
		{
			if (hReadPipe != null && !hReadPipe.IsInvalid)
			{
				hReadPipe.Close();
			}
		}
	}

	private static StringBuilder BuildCommandLine(string executableFileName, string arguments)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string text = executableFileName.Trim();
		bool flag = text.StartsWith("\"", StringComparison.Ordinal) && text.EndsWith("\"", StringComparison.Ordinal);
		if (!flag)
		{
			stringBuilder.Append("\"");
		}
		stringBuilder.Append(text);
		if (!flag)
		{
			stringBuilder.Append("\"");
		}
		if (!string.IsNullOrEmpty(arguments))
		{
			stringBuilder.Append(" ");
			stringBuilder.Append(arguments);
		}
		return stringBuilder;
	}

	private bool StartWithCreateProcess(ProcessStartInfo startInfo)
	{
		if (startInfo.StandardOutputEncoding != null && !startInfo.RedirectStandardOutput)
		{
			throw new InvalidOperationException(SR.GetString("StandardOutputEncodingNotAllowed"));
		}
		if (startInfo.StandardErrorEncoding != null && !startInfo.RedirectStandardError)
		{
			throw new InvalidOperationException(SR.GetString("StandardErrorEncodingNotAllowed"));
		}
		if (disposed)
		{
			throw new ObjectDisposedException(GetType().Name);
		}
		StringBuilder stringBuilder = BuildCommandLine(startInfo.FileName, startInfo.Arguments);
		Microsoft.Win32.NativeMethods.STARTUPINFO sTARTUPINFO = new Microsoft.Win32.NativeMethods.STARTUPINFO();
		Microsoft.Win32.SafeNativeMethods.PROCESS_INFORMATION pROCESS_INFORMATION = new Microsoft.Win32.SafeNativeMethods.PROCESS_INFORMATION();
		SafeProcessHandle safeProcessHandle = new SafeProcessHandle();
		SafeThreadHandle safeThreadHandle = new SafeThreadHandle();
		int num = 0;
		SafeFileHandle parentHandle = null;
		SafeFileHandle parentHandle2 = null;
		SafeFileHandle parentHandle3 = null;
		GCHandle gCHandle = default(GCHandle);
		lock (s_CreateProcessLock)
		{
			try
			{
				if (startInfo.RedirectStandardInput || startInfo.RedirectStandardOutput || startInfo.RedirectStandardError)
				{
					if (startInfo.RedirectStandardInput)
					{
						CreatePipe(out parentHandle, out sTARTUPINFO.hStdInput, parentInputs: true);
					}
					else
					{
						sTARTUPINFO.hStdInput = new SafeFileHandle(Microsoft.Win32.NativeMethods.GetStdHandle(-10), ownsHandle: false);
					}
					if (startInfo.RedirectStandardOutput)
					{
						CreatePipe(out parentHandle2, out sTARTUPINFO.hStdOutput, parentInputs: false);
					}
					else
					{
						sTARTUPINFO.hStdOutput = new SafeFileHandle(Microsoft.Win32.NativeMethods.GetStdHandle(-11), ownsHandle: false);
					}
					if (startInfo.RedirectStandardError)
					{
						CreatePipe(out parentHandle3, out sTARTUPINFO.hStdError, parentInputs: false);
					}
					else
					{
						sTARTUPINFO.hStdError = new SafeFileHandle(Microsoft.Win32.NativeMethods.GetStdHandle(-12), ownsHandle: false);
					}
					sTARTUPINFO.dwFlags = 256;
				}
				int num2 = 0;
				if (startInfo.CreateNoWindow)
				{
					num2 |= 0x8000000;
				}
				IntPtr intPtr = (IntPtr)0;
				if (startInfo.environmentVariables != null)
				{
					bool unicode = false;
					if (ProcessManager.IsNt)
					{
						num2 |= 0x400;
						unicode = true;
					}
					byte[] value = EnvironmentBlock.ToByteArray(startInfo.environmentVariables, unicode);
					gCHandle = GCHandle.Alloc(value, GCHandleType.Pinned);
					intPtr = gCHandle.AddrOfPinnedObject();
				}
				string text = startInfo.WorkingDirectory;
				if (text == string.Empty)
				{
					text = Environment.CurrentDirectory;
				}
				if (startInfo.UserName.Length != 0)
				{
					if (startInfo.Password != null && startInfo.PasswordInClearText != null)
					{
						throw new ArgumentException(SR.GetString("CantSetDuplicatePassword"));
					}
					Microsoft.Win32.NativeMethods.LogonFlags logonFlags = (Microsoft.Win32.NativeMethods.LogonFlags)0;
					if (startInfo.LoadUserProfile)
					{
						logonFlags = Microsoft.Win32.NativeMethods.LogonFlags.LOGON_WITH_PROFILE;
					}
					IntPtr intPtr2 = IntPtr.Zero;
					try
					{
						intPtr2 = ((startInfo.Password != null) ? Marshal.SecureStringToCoTaskMemUnicode(startInfo.Password) : ((startInfo.PasswordInClearText == null) ? Marshal.StringToCoTaskMemUni(string.Empty) : Marshal.StringToCoTaskMemUni(startInfo.PasswordInClearText)));
						RuntimeHelpers.PrepareConstrainedRegions();
						bool flag;
						try
						{
						}
						finally
						{
							flag = Microsoft.Win32.NativeMethods.CreateProcessWithLogonW(startInfo.UserName, startInfo.Domain, intPtr2, logonFlags, null, stringBuilder, num2, intPtr, text, sTARTUPINFO, pROCESS_INFORMATION);
							if (!flag)
							{
								num = Marshal.GetLastWin32Error();
							}
							if (pROCESS_INFORMATION.hProcess != (IntPtr)0 && pROCESS_INFORMATION.hProcess != Microsoft.Win32.NativeMethods.INVALID_HANDLE_VALUE)
							{
								safeProcessHandle.InitialSetHandle(pROCESS_INFORMATION.hProcess);
							}
							if (pROCESS_INFORMATION.hThread != (IntPtr)0 && pROCESS_INFORMATION.hThread != Microsoft.Win32.NativeMethods.INVALID_HANDLE_VALUE)
							{
								safeThreadHandle.InitialSetHandle(pROCESS_INFORMATION.hThread);
							}
						}
						if (!flag)
						{
							if (num == 193 || num == 216)
							{
								throw new Win32Exception(num, SR.GetString("InvalidApplication"));
							}
							throw new Win32Exception(num);
						}
					}
					finally
					{
						if (intPtr2 != IntPtr.Zero)
						{
							Marshal.ZeroFreeCoTaskMemUnicode(intPtr2);
						}
					}
				}
				else
				{
					RuntimeHelpers.PrepareConstrainedRegions();
					bool flag;
					try
					{
					}
					finally
					{
						flag = Microsoft.Win32.NativeMethods.CreateProcess(null, stringBuilder, null, null, bInheritHandles: true, num2, intPtr, text, sTARTUPINFO, pROCESS_INFORMATION);
						if (!flag)
						{
							num = Marshal.GetLastWin32Error();
						}
						if (pROCESS_INFORMATION.hProcess != (IntPtr)0 && pROCESS_INFORMATION.hProcess != Microsoft.Win32.NativeMethods.INVALID_HANDLE_VALUE)
						{
							safeProcessHandle.InitialSetHandle(pROCESS_INFORMATION.hProcess);
						}
						if (pROCESS_INFORMATION.hThread != (IntPtr)0 && pROCESS_INFORMATION.hThread != Microsoft.Win32.NativeMethods.INVALID_HANDLE_VALUE)
						{
							safeThreadHandle.InitialSetHandle(pROCESS_INFORMATION.hThread);
						}
					}
					if (!flag)
					{
						if (num == 193 || num == 216)
						{
							throw new Win32Exception(num, SR.GetString("InvalidApplication"));
						}
						throw new Win32Exception(num);
					}
				}
			}
			finally
			{
				if (gCHandle.IsAllocated)
				{
					gCHandle.Free();
				}
				sTARTUPINFO.Dispose();
			}
		}
		if (startInfo.RedirectStandardInput)
		{
			standardInput = new StreamWriter(new FileStream(parentHandle, FileAccess.Write, 4096, isAsync: false), Console.InputEncoding, 4096);
			standardInput.AutoFlush = true;
		}
		if (startInfo.RedirectStandardOutput)
		{
			Encoding encoding = ((startInfo.StandardOutputEncoding != null) ? startInfo.StandardOutputEncoding : Console.OutputEncoding);
			standardOutput = new StreamReader(new FileStream(parentHandle2, FileAccess.Read, 4096, isAsync: false), encoding, detectEncodingFromByteOrderMarks: true, 4096);
		}
		if (startInfo.RedirectStandardError)
		{
			Encoding encoding2 = ((startInfo.StandardErrorEncoding != null) ? startInfo.StandardErrorEncoding : Console.OutputEncoding);
			standardError = new StreamReader(new FileStream(parentHandle3, FileAccess.Read, 4096, isAsync: false), encoding2, detectEncodingFromByteOrderMarks: true, 4096);
		}
		bool result = false;
		if (!safeProcessHandle.IsInvalid)
		{
			SetProcessHandle(safeProcessHandle);
			SetProcessId(pROCESS_INFORMATION.dwProcessId);
			safeThreadHandle.Close();
			result = true;
		}
		return result;
	}

	private bool StartWithShellExecuteEx(ProcessStartInfo startInfo)
	{
		if (disposed)
		{
			throw new ObjectDisposedException(GetType().Name);
		}
		if (!string.IsNullOrEmpty(startInfo.UserName) || startInfo.Password != null)
		{
			throw new InvalidOperationException(SR.GetString("CantStartAsUser"));
		}
		if (startInfo.RedirectStandardInput || startInfo.RedirectStandardOutput || startInfo.RedirectStandardError)
		{
			throw new InvalidOperationException(SR.GetString("CantRedirectStreams"));
		}
		if (startInfo.StandardErrorEncoding != null)
		{
			throw new InvalidOperationException(SR.GetString("StandardErrorEncodingNotAllowed"));
		}
		if (startInfo.StandardOutputEncoding != null)
		{
			throw new InvalidOperationException(SR.GetString("StandardOutputEncodingNotAllowed"));
		}
		if (startInfo.environmentVariables != null)
		{
			throw new InvalidOperationException(SR.GetString("CantUseEnvVars"));
		}
		Microsoft.Win32.NativeMethods.ShellExecuteInfo shellExecuteInfo = new Microsoft.Win32.NativeMethods.ShellExecuteInfo();
		shellExecuteInfo.fMask = 64;
		if (startInfo.ErrorDialog)
		{
			shellExecuteInfo.hwnd = startInfo.ErrorDialogParentHandle;
		}
		else
		{
			shellExecuteInfo.fMask |= 1024;
		}
		switch (startInfo.WindowStyle)
		{
		case ProcessWindowStyle.Hidden:
			shellExecuteInfo.nShow = 0;
			break;
		case ProcessWindowStyle.Minimized:
			shellExecuteInfo.nShow = 2;
			break;
		case ProcessWindowStyle.Maximized:
			shellExecuteInfo.nShow = 3;
			break;
		default:
			shellExecuteInfo.nShow = 1;
			break;
		}
		try
		{
			if (startInfo.FileName.Length != 0)
			{
				shellExecuteInfo.lpFile = Marshal.StringToHGlobalAuto(startInfo.FileName);
			}
			if (startInfo.Verb.Length != 0)
			{
				shellExecuteInfo.lpVerb = Marshal.StringToHGlobalAuto(startInfo.Verb);
			}
			if (startInfo.Arguments.Length != 0)
			{
				shellExecuteInfo.lpParameters = Marshal.StringToHGlobalAuto(startInfo.Arguments);
			}
			if (startInfo.WorkingDirectory.Length != 0)
			{
				shellExecuteInfo.lpDirectory = Marshal.StringToHGlobalAuto(startInfo.WorkingDirectory);
			}
			shellExecuteInfo.fMask |= 256;
			ShellExecuteHelper shellExecuteHelper = new ShellExecuteHelper(shellExecuteInfo);
			int num;
			if (!shellExecuteHelper.ShellExecuteOnSTAThread())
			{
				num = shellExecuteHelper.ErrorCode;
				if (num == 0)
				{
					long num2 = (long)shellExecuteInfo.hInstApp;
					long num3 = num2 - 2;
					if ((ulong)num3 <= 6uL)
					{
						switch (num3)
						{
						case 0L:
							goto IL_023b;
						case 1L:
							goto IL_023f;
						case 3L:
							goto IL_0243;
						case 6L:
							goto IL_0247;
						case 2L:
						case 4L:
						case 5L:
							goto IL_0268;
						}
					}
					long num4 = num2 - 26;
					if ((ulong)num4 > 6uL)
					{
						goto IL_0268;
					}
					switch (num4)
					{
					case 2L:
					case 3L:
					case 4L:
						break;
					case 0L:
						goto IL_0253;
					case 5L:
						goto IL_0258;
					case 6L:
						goto IL_0260;
					default:
						goto IL_0268;
					}
					num = 1156;
				}
				goto IL_0274;
			}
			goto end_IL_0124;
			IL_0260:
			num = 1157;
			goto IL_0274;
			IL_0274:
			if (num == 193 || num == 216)
			{
				throw new Win32Exception(num, SR.GetString("InvalidApplication"));
			}
			throw new Win32Exception(num);
			IL_023f:
			num = 3;
			goto IL_0274;
			IL_023b:
			num = 2;
			goto IL_0274;
			IL_0247:
			num = 8;
			goto IL_0274;
			IL_0243:
			num = 5;
			goto IL_0274;
			IL_0268:
			num = (int)shellExecuteInfo.hInstApp;
			goto IL_0274;
			IL_0258:
			num = 1155;
			goto IL_0274;
			IL_0253:
			num = 32;
			goto IL_0274;
			end_IL_0124:;
		}
		finally
		{
			if (shellExecuteInfo.lpFile != (IntPtr)0)
			{
				Marshal.FreeHGlobal(shellExecuteInfo.lpFile);
			}
			if (shellExecuteInfo.lpVerb != (IntPtr)0)
			{
				Marshal.FreeHGlobal(shellExecuteInfo.lpVerb);
			}
			if (shellExecuteInfo.lpParameters != (IntPtr)0)
			{
				Marshal.FreeHGlobal(shellExecuteInfo.lpParameters);
			}
			if (shellExecuteInfo.lpDirectory != (IntPtr)0)
			{
				Marshal.FreeHGlobal(shellExecuteInfo.lpDirectory);
			}
		}
		if (shellExecuteInfo.hProcess != (IntPtr)0)
		{
			SafeProcessHandle processHandle = new SafeProcessHandle(shellExecuteInfo.hProcess);
			SetProcessHandle(processHandle);
			return true;
		}
		return false;
	}

	public static Process Start(string fileName, string userName, SecureString password, string domain)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName);
		processStartInfo.UserName = userName;
		processStartInfo.Password = password;
		processStartInfo.Domain = domain;
		processStartInfo.UseShellExecute = false;
		return Start(processStartInfo);
	}

	public static Process Start(string fileName, string arguments, string userName, SecureString password, string domain)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName, arguments);
		processStartInfo.UserName = userName;
		processStartInfo.Password = password;
		processStartInfo.Domain = domain;
		processStartInfo.UseShellExecute = false;
		return Start(processStartInfo);
	}

	public static Process Start(string fileName)
	{
		return Start(new ProcessStartInfo(fileName));
	}

	public static Process Start(string fileName, string arguments)
	{
		return Start(new ProcessStartInfo(fileName, arguments));
	}

	public static Process Start(ProcessStartInfo startInfo)
	{
		Process process = new Process();
		if (startInfo == null)
		{
			throw new ArgumentNullException("startInfo");
		}
		process.StartInfo = startInfo;
		if (process.Start())
		{
			return process;
		}
		return null;
	}

	public void Kill()
	{
		SafeProcessHandle safeProcessHandle = null;
		try
		{
			safeProcessHandle = GetProcessHandle(1);
			if (!Microsoft.Win32.NativeMethods.TerminateProcess(safeProcessHandle, -1))
			{
				throw new Win32Exception();
			}
		}
		finally
		{
			ReleaseProcessHandle(safeProcessHandle);
		}
	}

	private void StopWatchingForExit()
	{
		if (!watchingForExit)
		{
			return;
		}
		lock (this)
		{
			if (watchingForExit)
			{
				watchingForExit = false;
				registeredWaitHandle.Unregister(null);
				waitHandle.Close();
				waitHandle = null;
				registeredWaitHandle = null;
			}
		}
	}

	public override string ToString()
	{
		if (Associated)
		{
			string text = string.Empty;
			try
			{
				text = ProcessName;
			}
			catch (PlatformNotSupportedException)
			{
			}
			if (text.Length != 0)
			{
				return string.Format(CultureInfo.CurrentCulture, "{0} ({1})", new object[2]
				{
					base.ToString(),
					text
				});
			}
			return base.ToString();
		}
		return base.ToString();
	}

	public bool WaitForExit(int milliseconds)
	{
		SafeProcessHandle safeProcessHandle = null;
		ProcessWaitHandle processWaitHandle = null;
		bool flag;
		try
		{
			safeProcessHandle = GetProcessHandle(1048576, throwIfExited: false);
			if (safeProcessHandle.IsInvalid)
			{
				flag = true;
			}
			else
			{
				processWaitHandle = new ProcessWaitHandle(safeProcessHandle);
				if (processWaitHandle.WaitOne(milliseconds, exitContext: false))
				{
					flag = true;
					signaled = true;
				}
				else
				{
					flag = false;
					signaled = false;
				}
			}
		}
		finally
		{
			processWaitHandle?.Close();
			if (output != null && milliseconds == -1)
			{
				output.WaitUtilEOF();
			}
			if (error != null && milliseconds == -1)
			{
				error.WaitUtilEOF();
			}
			ReleaseProcessHandle(safeProcessHandle);
		}
		if (flag && watchForExit)
		{
			RaiseOnExited();
		}
		return flag;
	}

	public void WaitForExit()
	{
		WaitForExit(-1);
	}

	public bool WaitForInputIdle(int milliseconds)
	{
		SafeProcessHandle handle = null;
		try
		{
			handle = GetProcessHandle(1049600);
			return Microsoft.Win32.NativeMethods.WaitForInputIdle(handle, milliseconds) switch
			{
				0 => true, 
				258 => false, 
				_ => throw new InvalidOperationException(SR.GetString("InputIdleUnkownError")), 
			};
		}
		finally
		{
			ReleaseProcessHandle(handle);
		}
	}

	public bool WaitForInputIdle()
	{
		return WaitForInputIdle(int.MaxValue);
	}

	[ComVisible(false)]
	public void BeginOutputReadLine()
	{
		if (outputStreamReadMode == StreamReadMode.undefined)
		{
			outputStreamReadMode = StreamReadMode.asyncMode;
		}
		else if (outputStreamReadMode != StreamReadMode.asyncMode)
		{
			throw new InvalidOperationException(SR.GetString("CantMixSyncAsyncOperation"));
		}
		if (pendingOutputRead)
		{
			throw new InvalidOperationException(SR.GetString("PendingAsyncOperation"));
		}
		pendingOutputRead = true;
		if (output == null)
		{
			if (standardOutput == null)
			{
				throw new InvalidOperationException(SR.GetString("CantGetStandardOut"));
			}
			Stream baseStream = standardOutput.BaseStream;
			output = new AsyncStreamReader(this, baseStream, OutputReadNotifyUser, standardOutput.CurrentEncoding);
		}
		output.BeginReadLine();
	}

	[ComVisible(false)]
	public void BeginErrorReadLine()
	{
		if (errorStreamReadMode == StreamReadMode.undefined)
		{
			errorStreamReadMode = StreamReadMode.asyncMode;
		}
		else if (errorStreamReadMode != StreamReadMode.asyncMode)
		{
			throw new InvalidOperationException(SR.GetString("CantMixSyncAsyncOperation"));
		}
		if (pendingErrorRead)
		{
			throw new InvalidOperationException(SR.GetString("PendingAsyncOperation"));
		}
		pendingErrorRead = true;
		if (error == null)
		{
			if (standardError == null)
			{
				throw new InvalidOperationException(SR.GetString("CantGetStandardError"));
			}
			Stream baseStream = standardError.BaseStream;
			error = new AsyncStreamReader(this, baseStream, ErrorReadNotifyUser, standardError.CurrentEncoding);
		}
		error.BeginReadLine();
	}

	[ComVisible(false)]
	public void CancelOutputRead()
	{
		if (output != null)
		{
			output.CancelOperation();
			pendingOutputRead = false;
			return;
		}
		throw new InvalidOperationException(SR.GetString("NoAsyncOperation"));
	}

	[ComVisible(false)]
	public void CancelErrorRead()
	{
		if (error != null)
		{
			error.CancelOperation();
			pendingErrorRead = false;
			return;
		}
		throw new InvalidOperationException(SR.GetString("NoAsyncOperation"));
	}

	internal void OutputReadNotifyUser(string data)
	{
		DataReceivedEventHandler dataReceivedEventHandler = this.OutputDataReceived;
		if (dataReceivedEventHandler != null)
		{
			DataReceivedEventArgs e = new DataReceivedEventArgs(data);
			if (SynchronizingObject != null && SynchronizingObject.InvokeRequired)
			{
				SynchronizingObject.Invoke(dataReceivedEventHandler, new object[2] { this, e });
			}
			else
			{
				dataReceivedEventHandler(this, e);
			}
		}
	}

	internal void ErrorReadNotifyUser(string data)
	{
		DataReceivedEventHandler dataReceivedEventHandler = this.ErrorDataReceived;
		if (dataReceivedEventHandler != null)
		{
			DataReceivedEventArgs e = new DataReceivedEventArgs(data);
			if (SynchronizingObject != null && SynchronizingObject.InvokeRequired)
			{
				SynchronizingObject.Invoke(dataReceivedEventHandler, new object[2] { this, e });
			}
			else
			{
				dataReceivedEventHandler(this, e);
			}
		}
	}
}
