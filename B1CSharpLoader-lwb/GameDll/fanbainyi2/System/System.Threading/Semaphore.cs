using System.IO.Ports;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Threading;

[ComVisible(false)]
[global::__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public sealed class Semaphore : WaitHandle
{
	private new enum OpenExistingResult
	{
		Success,
		NameNotFound,
		PathNotFound,
		NameInvalid
	}

	private const int MAX_PATH = 260;

	[SecuritySafeCritical]
	[global::__DynamicallyInvokable]
	public Semaphore(int initialCount, int maximumCount)
		: this(initialCount, maximumCount, null)
	{
	}

	[global::__DynamicallyInvokable]
	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public Semaphore(int initialCount, int maximumCount, string name)
	{
		if (initialCount < 0)
		{
			throw new ArgumentOutOfRangeException("initialCount", SR.GetString("ArgumentOutOfRange_NeedNonNegNumRequired"));
		}
		if (maximumCount < 1)
		{
			throw new ArgumentOutOfRangeException("maximumCount", SR.GetString("ArgumentOutOfRange_NeedPosNum"));
		}
		if (initialCount > maximumCount)
		{
			throw new ArgumentException(SR.GetString("Argument_SemaphoreInitialMaximum"));
		}
		if (name != null && 260 < name.Length)
		{
			throw new ArgumentException(SR.GetString("Argument_WaitHandleNameTooLong"));
		}
		SafeWaitHandle safeWaitHandle = Microsoft.Win32.SafeNativeMethods.CreateSemaphore(null, initialCount, maximumCount, name);
		if (safeWaitHandle.IsInvalid)
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (name != null && name.Length != 0 && 6 == lastWin32Error)
			{
				throw new WaitHandleCannotBeOpenedException(SR.GetString("WaitHandleCannotBeOpenedException_InvalidHandle", name));
			}
			InternalResources.WinIOError();
		}
		base.SafeWaitHandle = safeWaitHandle;
	}

	[global::__DynamicallyInvokable]
	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public Semaphore(int initialCount, int maximumCount, string name, out bool createdNew)
		: this(initialCount, maximumCount, name, out createdNew, null)
	{
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public unsafe Semaphore(int initialCount, int maximumCount, string name, out bool createdNew, SemaphoreSecurity semaphoreSecurity)
	{
		if (initialCount < 0)
		{
			throw new ArgumentOutOfRangeException("initialCount", SR.GetString("ArgumentOutOfRange_NeedNonNegNumRequired"));
		}
		if (maximumCount < 1)
		{
			throw new ArgumentOutOfRangeException("maximumCount", SR.GetString("ArgumentOutOfRange_NeedNonNegNumRequired"));
		}
		if (initialCount > maximumCount)
		{
			throw new ArgumentException(SR.GetString("Argument_SemaphoreInitialMaximum"));
		}
		if (name != null && 260 < name.Length)
		{
			throw new ArgumentException(SR.GetString("Argument_WaitHandleNameTooLong"));
		}
		SafeWaitHandle safeWaitHandle;
		if (semaphoreSecurity != null)
		{
			Microsoft.Win32.NativeMethods.SECURITY_ATTRIBUTES sECURITY_ATTRIBUTES = null;
			sECURITY_ATTRIBUTES = new Microsoft.Win32.NativeMethods.SECURITY_ATTRIBUTES();
			sECURITY_ATTRIBUTES.nLength = Marshal.SizeOf((object)sECURITY_ATTRIBUTES);
			fixed (byte* securityDescriptorBinaryForm = semaphoreSecurity.GetSecurityDescriptorBinaryForm())
			{
				sECURITY_ATTRIBUTES.lpSecurityDescriptor = new SafeLocalMemHandle((IntPtr)securityDescriptorBinaryForm, ownsHandle: false);
				safeWaitHandle = Microsoft.Win32.SafeNativeMethods.CreateSemaphore(sECURITY_ATTRIBUTES, initialCount, maximumCount, name);
			}
		}
		else
		{
			safeWaitHandle = Microsoft.Win32.SafeNativeMethods.CreateSemaphore(null, initialCount, maximumCount, name);
		}
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (safeWaitHandle.IsInvalid)
		{
			if (name != null && name.Length != 0 && 6 == lastWin32Error)
			{
				throw new WaitHandleCannotBeOpenedException(SR.GetString("WaitHandleCannotBeOpenedException_InvalidHandle", name));
			}
			InternalResources.WinIOError();
		}
		createdNew = lastWin32Error != 183;
		base.SafeWaitHandle = safeWaitHandle;
	}

	private Semaphore(SafeWaitHandle handle)
	{
		base.SafeWaitHandle = handle;
	}

	[global::__DynamicallyInvokable]
	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public static Semaphore OpenExisting(string name)
	{
		return OpenExisting(name, SemaphoreRights.Modify | SemaphoreRights.Synchronize);
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public static Semaphore OpenExisting(string name, SemaphoreRights rights)
	{
		Semaphore result;
		switch (OpenExistingWorker(name, rights, out result))
		{
		case OpenExistingResult.NameNotFound:
			throw new WaitHandleCannotBeOpenedException();
		case OpenExistingResult.NameInvalid:
			throw new WaitHandleCannotBeOpenedException(SR.GetString("WaitHandleCannotBeOpenedException_InvalidHandle", name));
		case OpenExistingResult.PathNotFound:
			InternalResources.WinIOError(3, string.Empty);
			return result;
		default:
			return result;
		}
	}

	[global::__DynamicallyInvokable]
	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public static bool TryOpenExisting(string name, out Semaphore result)
	{
		return OpenExistingWorker(name, SemaphoreRights.Modify | SemaphoreRights.Synchronize, out result) == OpenExistingResult.Success;
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public static bool TryOpenExisting(string name, SemaphoreRights rights, out Semaphore result)
	{
		return OpenExistingWorker(name, rights, out result) == OpenExistingResult.Success;
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	private static OpenExistingResult OpenExistingWorker(string name, SemaphoreRights rights, out Semaphore result)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException(SR.GetString("InvalidNullEmptyArgument", "name"), "name");
		}
		if (name != null && 260 < name.Length)
		{
			throw new ArgumentException(SR.GetString("Argument_WaitHandleNameTooLong"));
		}
		result = null;
		SafeWaitHandle safeWaitHandle = Microsoft.Win32.SafeNativeMethods.OpenSemaphore((int)rights, inheritHandle: false, name);
		if (safeWaitHandle.IsInvalid)
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (2 == lastWin32Error || 123 == lastWin32Error)
			{
				return OpenExistingResult.NameNotFound;
			}
			if (3 == lastWin32Error)
			{
				return OpenExistingResult.PathNotFound;
			}
			if (name != null && name.Length != 0 && 6 == lastWin32Error)
			{
				return OpenExistingResult.NameInvalid;
			}
			InternalResources.WinIOError();
		}
		result = new Semaphore(safeWaitHandle);
		return OpenExistingResult.Success;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[PrePrepareMethod]
	[global::__DynamicallyInvokable]
	public int Release()
	{
		return Release(1);
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[global::__DynamicallyInvokable]
	public int Release(int releaseCount)
	{
		if (releaseCount < 1)
		{
			throw new ArgumentOutOfRangeException("releaseCount", SR.GetString("ArgumentOutOfRange_NeedNonNegNumRequired"));
		}
		if (!Microsoft.Win32.SafeNativeMethods.ReleaseSemaphore(base.SafeWaitHandle, releaseCount, out var previousCount))
		{
			throw new SemaphoreFullException();
		}
		return previousCount;
	}

	public SemaphoreSecurity GetAccessControl()
	{
		return new SemaphoreSecurity(base.SafeWaitHandle, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group);
	}

	public void SetAccessControl(SemaphoreSecurity semaphoreSecurity)
	{
		if (semaphoreSecurity == null)
		{
			throw new ArgumentNullException("semaphoreSecurity");
		}
		semaphoreSecurity.Persist(base.SafeWaitHandle);
	}
}
