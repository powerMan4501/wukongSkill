using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Principal;

[ComVisible(true)]
public class WindowsImpersonationContext : IDisposable
{
	[SecurityCritical]
	private SafeAccessTokenHandle m_safeTokenHandle = SafeAccessTokenHandle.InvalidHandle;

	private WindowsIdentity m_wi;

	private FrameSecurityDescriptor m_fsd;

	[SecurityCritical]
	private WindowsImpersonationContext()
	{
	}

	[SecurityCritical]
	internal WindowsImpersonationContext(SafeAccessTokenHandle safeTokenHandle, WindowsIdentity wi, bool isImpersonating, FrameSecurityDescriptor fsd)
	{
		if (safeTokenHandle.IsInvalid)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidImpersonationToken"));
		}
		if (isImpersonating)
		{
			if (!Win32Native.DuplicateHandle(Win32Native.GetCurrentProcess(), safeTokenHandle, Win32Native.GetCurrentProcess(), ref m_safeTokenHandle, 0u, bInheritHandle: true, 2u))
			{
				throw new SecurityException(Win32Native.GetMessage(Marshal.GetLastWin32Error()));
			}
			m_wi = wi;
		}
		m_fsd = fsd;
	}

	[SecuritySafeCritical]
	public void Undo()
	{
		int num = 0;
		if (m_safeTokenHandle.IsInvalid)
		{
			num = Win32.RevertToSelf();
			if (num < 0)
			{
				Environment.FailFast(Win32Native.GetMessage(num));
			}
		}
		else
		{
			num = Win32.RevertToSelf();
			if (num < 0)
			{
				Environment.FailFast(Win32Native.GetMessage(num));
			}
			num = Win32.ImpersonateLoggedOnUser(m_safeTokenHandle);
			if (num < 0)
			{
				throw new SecurityException(Win32Native.GetMessage(num));
			}
		}
		WindowsIdentity.UpdateThreadWI(m_wi);
		if (m_fsd != null)
		{
			m_fsd.SetTokenHandles(null, null);
		}
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[HandleProcessCorruptedStateExceptions]
	internal bool UndoNoThrow()
	{
		bool flag = false;
		try
		{
			int num = 0;
			if (m_safeTokenHandle.IsInvalid)
			{
				num = Win32.RevertToSelf();
				if (num < 0)
				{
					Environment.FailFast(Win32Native.GetMessage(num));
				}
			}
			else
			{
				num = Win32.RevertToSelf();
				if (num >= 0)
				{
					num = Win32.ImpersonateLoggedOnUser(m_safeTokenHandle);
				}
				else
				{
					Environment.FailFast(Win32Native.GetMessage(num));
				}
			}
			flag = num >= 0;
			if (m_fsd != null)
			{
				m_fsd.SetTokenHandles(null, null);
			}
		}
		catch (Exception exception)
		{
			if (!AppContextSwitches.UseLegacyExecutionContextBehaviorUponUndoFailure)
			{
				Environment.FailFast(Environment.GetResourceString("ExecutionContext_UndoFailed"), exception);
			}
			flag = false;
		}
		return flag;
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && m_safeTokenHandle != null && !m_safeTokenHandle.IsClosed)
		{
			Undo();
			m_safeTokenHandle.Dispose();
		}
	}

	[ComVisible(false)]
	public void Dispose()
	{
		Dispose(disposing: true);
	}
}
