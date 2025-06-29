using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Threading;

[ComVisible(true)]
[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public sealed class Mutex : WaitHandle
{
	internal class MutexTryCodeHelper
	{
		private bool m_initiallyOwned;

		private MutexCleanupInfo m_cleanupInfo;

		internal bool m_newMutex;

		private string m_name;

		[SecurityCritical]
		private Win32Native.SECURITY_ATTRIBUTES m_secAttrs;

		private Mutex m_mutex;

		[SecurityCritical]
		[PrePrepareMethod]
		internal MutexTryCodeHelper(bool initiallyOwned, MutexCleanupInfo cleanupInfo, string name, Win32Native.SECURITY_ATTRIBUTES secAttrs, Mutex mutex)
		{
			m_initiallyOwned = initiallyOwned;
			m_cleanupInfo = cleanupInfo;
			m_name = name;
			m_secAttrs = secAttrs;
			m_mutex = mutex;
		}

		[SecurityCritical]
		[PrePrepareMethod]
		internal void MutexTryCode(object userData)
		{
			SafeWaitHandle mutexHandle = null;
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				if (m_initiallyOwned)
				{
					m_cleanupInfo.inCriticalRegion = true;
					Thread.BeginThreadAffinity();
					Thread.BeginCriticalRegion();
				}
			}
			int num = 0;
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				num = CreateMutexHandle(m_initiallyOwned, m_name, m_secAttrs, out mutexHandle);
			}
			if (mutexHandle.IsInvalid)
			{
				mutexHandle.SetHandleAsInvalid();
				if (m_name != null && m_name.Length != 0 && 6 == num)
				{
					throw new WaitHandleCannotBeOpenedException(Environment.GetResourceString("Threading.WaitHandleCannotBeOpenedException_InvalidHandle", m_name));
				}
				__Error.WinIOError(num, m_name);
			}
			m_newMutex = num != 183;
			m_mutex.SetHandleInternal(mutexHandle);
			m_mutex.hasThreadAffinity = true;
		}
	}

	internal class MutexCleanupInfo
	{
		[SecurityCritical]
		internal SafeWaitHandle mutexHandle;

		internal bool inCriticalRegion;

		[SecurityCritical]
		internal MutexCleanupInfo(SafeWaitHandle mutexHandle, bool inCriticalRegion)
		{
			this.mutexHandle = mutexHandle;
			this.inCriticalRegion = inCriticalRegion;
		}
	}

	private static bool dummyBool;

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[__DynamicallyInvokable]
	public Mutex(bool initiallyOwned, string name, out bool createdNew)
		: this(initiallyOwned, name, out createdNew, (MutexSecurity)null)
	{
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public unsafe Mutex(bool initiallyOwned, string name, out bool createdNew, MutexSecurity mutexSecurity)
	{
		if (name != null && 260 < name.Length)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WaitHandleNameTooLong", name));
		}
		Win32Native.SECURITY_ATTRIBUTES sECURITY_ATTRIBUTES = null;
		if (mutexSecurity != null)
		{
			sECURITY_ATTRIBUTES = new Win32Native.SECURITY_ATTRIBUTES();
			sECURITY_ATTRIBUTES.nLength = Marshal.SizeOf(sECURITY_ATTRIBUTES);
			byte[] securityDescriptorBinaryForm = mutexSecurity.GetSecurityDescriptorBinaryForm();
			byte* ptr = stackalloc byte[(int)(uint)securityDescriptorBinaryForm.Length];
			Buffer.Memcpy(ptr, 0, securityDescriptorBinaryForm, 0, securityDescriptorBinaryForm.Length);
			sECURITY_ATTRIBUTES.pSecurityDescriptor = ptr;
		}
		CreateMutexWithGuaranteedCleanup(initiallyOwned, name, out createdNew, sECURITY_ATTRIBUTES);
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal Mutex(bool initiallyOwned, string name, out bool createdNew, Win32Native.SECURITY_ATTRIBUTES secAttrs)
	{
		if (name != null && 260 < name.Length)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WaitHandleNameTooLong", name));
		}
		CreateMutexWithGuaranteedCleanup(initiallyOwned, name, out createdNew, secAttrs);
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal void CreateMutexWithGuaranteedCleanup(bool initiallyOwned, string name, out bool createdNew, Win32Native.SECURITY_ATTRIBUTES secAttrs)
	{
		RuntimeHelpers.CleanupCode backoutCode = MutexCleanupCode;
		MutexCleanupInfo mutexCleanupInfo = new MutexCleanupInfo(null, inCriticalRegion: false);
		MutexTryCodeHelper mutexTryCodeHelper = new MutexTryCodeHelper(initiallyOwned, mutexCleanupInfo, name, secAttrs, this);
		RuntimeHelpers.TryCode code = mutexTryCodeHelper.MutexTryCode;
		RuntimeHelpers.ExecuteCodeWithGuaranteedCleanup(code, backoutCode, mutexCleanupInfo);
		createdNew = mutexTryCodeHelper.m_newMutex;
	}

	[SecurityCritical]
	[PrePrepareMethod]
	private void MutexCleanupCode(object userData, bool exceptionThrown)
	{
		MutexCleanupInfo mutexCleanupInfo = (MutexCleanupInfo)userData;
		if (hasThreadAffinity)
		{
			return;
		}
		if (mutexCleanupInfo.mutexHandle != null && !mutexCleanupInfo.mutexHandle.IsInvalid)
		{
			if (mutexCleanupInfo.inCriticalRegion)
			{
				Win32Native.ReleaseMutex(mutexCleanupInfo.mutexHandle);
			}
			mutexCleanupInfo.mutexHandle.Dispose();
		}
		if (mutexCleanupInfo.inCriticalRegion)
		{
			Thread.EndCriticalRegion();
			Thread.EndThreadAffinity();
		}
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[__DynamicallyInvokable]
	public Mutex(bool initiallyOwned, string name)
		: this(initiallyOwned, name, out dummyBool)
	{
	}

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[__DynamicallyInvokable]
	public Mutex(bool initiallyOwned)
		: this(initiallyOwned, null, out dummyBool)
	{
	}

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[__DynamicallyInvokable]
	public Mutex()
		: this(initiallyOwned: false, null, out dummyBool)
	{
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	private Mutex(SafeWaitHandle handle)
	{
		SetHandleInternal(handle);
		hasThreadAffinity = true;
	}

	[SecurityCritical]
	[__DynamicallyInvokable]
	public static Mutex OpenExisting(string name)
	{
		return OpenExisting(name, MutexRights.Modify | MutexRights.Synchronize);
	}

	[SecurityCritical]
	public static Mutex OpenExisting(string name, MutexRights rights)
	{
		Mutex result;
		switch (OpenExistingWorker(name, rights, out result))
		{
		case OpenExistingResult.NameNotFound:
			throw new WaitHandleCannotBeOpenedException();
		case OpenExistingResult.NameInvalid:
			throw new WaitHandleCannotBeOpenedException(Environment.GetResourceString("Threading.WaitHandleCannotBeOpenedException_InvalidHandle", name));
		case OpenExistingResult.PathNotFound:
			__Error.WinIOError(3, name);
			return result;
		default:
			return result;
		}
	}

	[SecurityCritical]
	[__DynamicallyInvokable]
	public static bool TryOpenExisting(string name, out Mutex result)
	{
		return OpenExistingWorker(name, MutexRights.Modify | MutexRights.Synchronize, out result) == OpenExistingResult.Success;
	}

	[SecurityCritical]
	public static bool TryOpenExisting(string name, MutexRights rights, out Mutex result)
	{
		return OpenExistingWorker(name, rights, out result) == OpenExistingResult.Success;
	}

	[SecurityCritical]
	private static OpenExistingResult OpenExistingWorker(string name, MutexRights rights, out Mutex result)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name", Environment.GetResourceString("ArgumentNull_WithParamName"));
		}
		if (name.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyName"), "name");
		}
		if (260 < name.Length)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WaitHandleNameTooLong", name));
		}
		result = null;
		SafeWaitHandle safeWaitHandle = Win32Native.OpenMutex((int)rights, inheritHandle: false, name);
		int num = 0;
		if (safeWaitHandle.IsInvalid)
		{
			num = Marshal.GetLastWin32Error();
			if (2 == num || 123 == num)
			{
				return OpenExistingResult.NameNotFound;
			}
			if (3 == num)
			{
				return OpenExistingResult.PathNotFound;
			}
			if (name != null && name.Length != 0 && 6 == num)
			{
				return OpenExistingResult.NameInvalid;
			}
			__Error.WinIOError(num, name);
		}
		result = new Mutex(safeWaitHandle);
		return OpenExistingResult.Success;
	}

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[__DynamicallyInvokable]
	public void ReleaseMutex()
	{
		if (Win32Native.ReleaseMutex(safeWaitHandle))
		{
			Thread.EndCriticalRegion();
			Thread.EndThreadAffinity();
			return;
		}
		throw new ApplicationException(Environment.GetResourceString("Arg_SynchronizationLockException"));
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	private static int CreateMutexHandle(bool initiallyOwned, string name, Win32Native.SECURITY_ATTRIBUTES securityAttribute, out SafeWaitHandle mutexHandle)
	{
		bool flag = false;
		int num;
		while (true)
		{
			mutexHandle = Win32Native.CreateMutex(securityAttribute, initiallyOwned, name);
			num = Marshal.GetLastWin32Error();
			if (!mutexHandle.IsInvalid || num != 5)
			{
				break;
			}
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				try
				{
				}
				finally
				{
					Thread.BeginThreadAffinity();
					flag = true;
				}
				mutexHandle = Win32Native.OpenMutex(1048577, inheritHandle: false, name);
				num = (mutexHandle.IsInvalid ? Marshal.GetLastWin32Error() : 183);
			}
			finally
			{
				if (flag)
				{
					Thread.EndThreadAffinity();
				}
			}
			if (num != 2)
			{
				if (num == 0)
				{
					num = 183;
				}
				break;
			}
		}
		return num;
	}

	[SecuritySafeCritical]
	public MutexSecurity GetAccessControl()
	{
		return new MutexSecurity(safeWaitHandle, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group);
	}

	[SecuritySafeCritical]
	public void SetAccessControl(MutexSecurity mutexSecurity)
	{
		if (mutexSecurity == null)
		{
			throw new ArgumentNullException("mutexSecurity");
		}
		mutexSecurity.Persist(safeWaitHandle);
	}
}
