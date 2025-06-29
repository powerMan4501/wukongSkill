using System.IO;
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
public class EventWaitHandle : WaitHandle
{
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public EventWaitHandle(bool initialState, EventResetMode mode)
		: this(initialState, mode, null)
	{
	}

	[SecurityCritical]
	[__DynamicallyInvokable]
	public EventWaitHandle(bool initialState, EventResetMode mode, string name)
	{
		if (name != null && 260 < name.Length)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WaitHandleNameTooLong", name));
		}
		SafeWaitHandle safeWaitHandle = null;
		safeWaitHandle = mode switch
		{
			EventResetMode.ManualReset => Win32Native.CreateEvent(null, isManualReset: true, initialState, name), 
			EventResetMode.AutoReset => Win32Native.CreateEvent(null, isManualReset: false, initialState, name), 
			_ => throw new ArgumentException(Environment.GetResourceString("Argument_InvalidFlag", name)), 
		};
		if (safeWaitHandle.IsInvalid)
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			safeWaitHandle.SetHandleAsInvalid();
			if (name != null && name.Length != 0 && 6 == lastWin32Error)
			{
				throw new WaitHandleCannotBeOpenedException(Environment.GetResourceString("Threading.WaitHandleCannotBeOpenedException_InvalidHandle", name));
			}
			__Error.WinIOError(lastWin32Error, name);
		}
		SetHandleInternal(safeWaitHandle);
	}

	[SecurityCritical]
	[__DynamicallyInvokable]
	public EventWaitHandle(bool initialState, EventResetMode mode, string name, out bool createdNew)
		: this(initialState, mode, name, out createdNew, null)
	{
	}

	[SecurityCritical]
	public unsafe EventWaitHandle(bool initialState, EventResetMode mode, string name, out bool createdNew, EventWaitHandleSecurity eventSecurity)
	{
		if (name != null && 260 < name.Length)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WaitHandleNameTooLong", name));
		}
		Win32Native.SECURITY_ATTRIBUTES sECURITY_ATTRIBUTES = null;
		if (eventSecurity != null)
		{
			sECURITY_ATTRIBUTES = new Win32Native.SECURITY_ATTRIBUTES();
			sECURITY_ATTRIBUTES.nLength = Marshal.SizeOf(sECURITY_ATTRIBUTES);
			byte[] securityDescriptorBinaryForm = eventSecurity.GetSecurityDescriptorBinaryForm();
			byte* ptr = stackalloc byte[(int)(uint)securityDescriptorBinaryForm.Length];
			Buffer.Memcpy(ptr, 0, securityDescriptorBinaryForm, 0, securityDescriptorBinaryForm.Length);
			sECURITY_ATTRIBUTES.pSecurityDescriptor = ptr;
		}
		SafeWaitHandle safeWaitHandle = null;
		safeWaitHandle = Win32Native.CreateEvent(sECURITY_ATTRIBUTES, mode switch
		{
			EventResetMode.ManualReset => true, 
			EventResetMode.AutoReset => false, 
			_ => throw new ArgumentException(Environment.GetResourceString("Argument_InvalidFlag", name)), 
		}, initialState, name);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (safeWaitHandle.IsInvalid)
		{
			safeWaitHandle.SetHandleAsInvalid();
			if (name != null && name.Length != 0 && 6 == lastWin32Error)
			{
				throw new WaitHandleCannotBeOpenedException(Environment.GetResourceString("Threading.WaitHandleCannotBeOpenedException_InvalidHandle", name));
			}
			__Error.WinIOError(lastWin32Error, name);
		}
		createdNew = lastWin32Error != 183;
		SetHandleInternal(safeWaitHandle);
	}

	[SecurityCritical]
	private EventWaitHandle(SafeWaitHandle handle)
	{
		SetHandleInternal(handle);
	}

	[SecurityCritical]
	[__DynamicallyInvokable]
	public static EventWaitHandle OpenExisting(string name)
	{
		return OpenExisting(name, EventWaitHandleRights.Modify | EventWaitHandleRights.Synchronize);
	}

	[SecurityCritical]
	public static EventWaitHandle OpenExisting(string name, EventWaitHandleRights rights)
	{
		EventWaitHandle result;
		switch (OpenExistingWorker(name, rights, out result))
		{
		case OpenExistingResult.NameNotFound:
			throw new WaitHandleCannotBeOpenedException();
		case OpenExistingResult.NameInvalid:
			throw new WaitHandleCannotBeOpenedException(Environment.GetResourceString("Threading.WaitHandleCannotBeOpenedException_InvalidHandle", name));
		case OpenExistingResult.PathNotFound:
			__Error.WinIOError(3, "");
			return result;
		default:
			return result;
		}
	}

	[SecurityCritical]
	[__DynamicallyInvokable]
	public static bool TryOpenExisting(string name, out EventWaitHandle result)
	{
		return OpenExistingWorker(name, EventWaitHandleRights.Modify | EventWaitHandleRights.Synchronize, out result) == OpenExistingResult.Success;
	}

	[SecurityCritical]
	public static bool TryOpenExisting(string name, EventWaitHandleRights rights, out EventWaitHandle result)
	{
		return OpenExistingWorker(name, rights, out result) == OpenExistingResult.Success;
	}

	[SecurityCritical]
	private static OpenExistingResult OpenExistingWorker(string name, EventWaitHandleRights rights, out EventWaitHandle result)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name", Environment.GetResourceString("ArgumentNull_WithParamName"));
		}
		if (name.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyName"), "name");
		}
		if (name != null && 260 < name.Length)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WaitHandleNameTooLong", name));
		}
		result = null;
		SafeWaitHandle safeWaitHandle = Win32Native.OpenEvent((int)rights, inheritHandle: false, name);
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
			__Error.WinIOError(lastWin32Error, "");
		}
		result = new EventWaitHandle(safeWaitHandle);
		return OpenExistingResult.Success;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public bool Reset()
	{
		bool flag = Win32Native.ResetEvent(safeWaitHandle);
		if (!flag)
		{
			__Error.WinIOError();
		}
		return flag;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public bool Set()
	{
		bool flag = Win32Native.SetEvent(safeWaitHandle);
		if (!flag)
		{
			__Error.WinIOError();
		}
		return flag;
	}

	[SecuritySafeCritical]
	public EventWaitHandleSecurity GetAccessControl()
	{
		return new EventWaitHandleSecurity(safeWaitHandle, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group);
	}

	[SecuritySafeCritical]
	public void SetAccessControl(EventWaitHandleSecurity eventSecurity)
	{
		if (eventSecurity == null)
		{
			throw new ArgumentNullException("eventSecurity");
		}
		eventSecurity.Persist(safeWaitHandle);
	}
}
