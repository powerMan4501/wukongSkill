using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Diagnostics;

[Designer("System.Diagnostics.Design.ProcessThreadDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HostProtection(SecurityAction.LinkDemand, SelfAffectingProcessMgmt = true, SelfAffectingThreading = true)]
public class ProcessThread : Component
{
	private enum State
	{
		IsLocal = 2,
		IsNt = 4
	}

	private ThreadInfo threadInfo;

	private bool isRemoteMachine;

	private bool priorityBoostEnabled;

	private bool havePriorityBoostEnabled;

	private ThreadPriorityLevel priorityLevel;

	private bool havePriorityLevel;

	[MonitoringDescription("ThreadBasePriority")]
	public int BasePriority => threadInfo.basePriority;

	[MonitoringDescription("ThreadCurrentPriority")]
	public int CurrentPriority => threadInfo.currentPriority;

	[MonitoringDescription("ThreadId")]
	public int Id => threadInfo.threadId;

	[Browsable(false)]
	public int IdealProcessor
	{
		set
		{
			SafeThreadHandle handle = null;
			try
			{
				handle = OpenThreadHandle(32);
				if (Microsoft.Win32.NativeMethods.SetThreadIdealProcessor(handle, value) < 0)
				{
					throw new Win32Exception();
				}
			}
			finally
			{
				CloseThreadHandle(handle);
			}
		}
	}

	[MonitoringDescription("ThreadPriorityBoostEnabled")]
	public bool PriorityBoostEnabled
	{
		get
		{
			if (!havePriorityBoostEnabled)
			{
				SafeThreadHandle handle = null;
				try
				{
					handle = OpenThreadHandle(64);
					bool disabled = false;
					if (!Microsoft.Win32.NativeMethods.GetThreadPriorityBoost(handle, out disabled))
					{
						throw new Win32Exception();
					}
					priorityBoostEnabled = !disabled;
					havePriorityBoostEnabled = true;
				}
				finally
				{
					CloseThreadHandle(handle);
				}
			}
			return priorityBoostEnabled;
		}
		set
		{
			SafeThreadHandle handle = null;
			try
			{
				handle = OpenThreadHandle(32);
				if (!Microsoft.Win32.NativeMethods.SetThreadPriorityBoost(handle, !value))
				{
					throw new Win32Exception();
				}
				priorityBoostEnabled = value;
				havePriorityBoostEnabled = true;
			}
			finally
			{
				CloseThreadHandle(handle);
			}
		}
	}

	[MonitoringDescription("ThreadPriorityLevel")]
	public ThreadPriorityLevel PriorityLevel
	{
		get
		{
			if (!havePriorityLevel)
			{
				SafeThreadHandle handle = null;
				try
				{
					handle = OpenThreadHandle(64);
					int threadPriority = Microsoft.Win32.NativeMethods.GetThreadPriority(handle);
					if (threadPriority == int.MaxValue)
					{
						throw new Win32Exception();
					}
					priorityLevel = (ThreadPriorityLevel)threadPriority;
					havePriorityLevel = true;
				}
				finally
				{
					CloseThreadHandle(handle);
				}
			}
			return priorityLevel;
		}
		set
		{
			SafeThreadHandle handle = null;
			try
			{
				handle = OpenThreadHandle(32);
				if (!Microsoft.Win32.NativeMethods.SetThreadPriority(handle, (int)value))
				{
					throw new Win32Exception();
				}
				priorityLevel = value;
			}
			finally
			{
				CloseThreadHandle(handle);
			}
		}
	}

	[MonitoringDescription("ThreadPrivilegedProcessorTime")]
	public TimeSpan PrivilegedProcessorTime
	{
		get
		{
			EnsureState(State.IsNt);
			return GetThreadTimes().PrivilegedProcessorTime;
		}
	}

	[MonitoringDescription("ThreadStartAddress")]
	public IntPtr StartAddress
	{
		get
		{
			EnsureState(State.IsNt);
			return threadInfo.startAddress;
		}
	}

	[MonitoringDescription("ThreadStartTime")]
	public DateTime StartTime
	{
		get
		{
			EnsureState(State.IsNt);
			return GetThreadTimes().StartTime;
		}
	}

	[MonitoringDescription("ThreadThreadState")]
	public ThreadState ThreadState
	{
		get
		{
			EnsureState(State.IsNt);
			return threadInfo.threadState;
		}
	}

	[MonitoringDescription("ThreadTotalProcessorTime")]
	public TimeSpan TotalProcessorTime
	{
		get
		{
			EnsureState(State.IsNt);
			return GetThreadTimes().TotalProcessorTime;
		}
	}

	[MonitoringDescription("ThreadUserProcessorTime")]
	public TimeSpan UserProcessorTime
	{
		get
		{
			EnsureState(State.IsNt);
			return GetThreadTimes().UserProcessorTime;
		}
	}

	[MonitoringDescription("ThreadWaitReason")]
	public ThreadWaitReason WaitReason
	{
		get
		{
			EnsureState(State.IsNt);
			if (threadInfo.threadState != ThreadState.Wait)
			{
				throw new InvalidOperationException(SR.GetString("WaitReasonUnavailable"));
			}
			return threadInfo.threadWaitReason;
		}
	}

	[Browsable(false)]
	public IntPtr ProcessorAffinity
	{
		set
		{
			SafeThreadHandle handle = null;
			try
			{
				handle = OpenThreadHandle(96);
				if (Microsoft.Win32.NativeMethods.SetThreadAffinityMask(handle, new HandleRef(this, value)) == IntPtr.Zero)
				{
					throw new Win32Exception();
				}
			}
			finally
			{
				CloseThreadHandle(handle);
			}
		}
	}

	internal ProcessThread(bool isRemoteMachine, ThreadInfo threadInfo)
	{
		this.isRemoteMachine = isRemoteMachine;
		this.threadInfo = threadInfo;
		GC.SuppressFinalize(this);
	}

	private static void CloseThreadHandle(SafeThreadHandle handle)
	{
		handle?.Close();
	}

	private void EnsureState(State state)
	{
		if ((state & State.IsLocal) != 0 && isRemoteMachine)
		{
			throw new NotSupportedException(SR.GetString("NotSupportedRemoteThread"));
		}
		if ((state & State.IsNt) != 0 && Environment.OSVersion.Platform != PlatformID.Win32NT)
		{
			throw new PlatformNotSupportedException(SR.GetString("WinNTRequired"));
		}
	}

	private SafeThreadHandle OpenThreadHandle(int access)
	{
		EnsureState(State.IsLocal);
		return ProcessManager.OpenThread(threadInfo.threadId, access);
	}

	public void ResetIdealProcessor()
	{
		IdealProcessor = 32;
	}

	private ProcessThreadTimes GetThreadTimes()
	{
		ProcessThreadTimes processThreadTimes = new ProcessThreadTimes();
		SafeThreadHandle handle = null;
		try
		{
			handle = OpenThreadHandle(64);
			if (!Microsoft.Win32.NativeMethods.GetThreadTimes(handle, out processThreadTimes.create, out processThreadTimes.exit, out processThreadTimes.kernel, out processThreadTimes.user))
			{
				throw new Win32Exception();
			}
			return processThreadTimes;
		}
		finally
		{
			CloseThreadHandle(handle);
		}
	}
}
