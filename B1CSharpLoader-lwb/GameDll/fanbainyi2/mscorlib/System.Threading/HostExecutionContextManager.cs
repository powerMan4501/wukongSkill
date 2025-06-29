using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Threading;

public class HostExecutionContextManager
{
	private static volatile bool _fIsHostedChecked;

	private static volatile bool _fIsHosted;

	private static HostExecutionContextManager _hostExecutionContextManager;

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static extern bool HostSecurityManagerPresent();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern int ReleaseHostSecurityContext(IntPtr context);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern int CloneHostSecurityContext(SafeHandle context, SafeHandle clonedContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern int CaptureHostSecurityContext(SafeHandle capturedContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static extern int SetHostSecurityContext(SafeHandle context, bool fReturnPrevious, SafeHandle prevContext);

	[SecurityCritical]
	internal static bool CheckIfHosted()
	{
		if (!_fIsHostedChecked)
		{
			_fIsHosted = HostSecurityManagerPresent();
			_fIsHostedChecked = true;
		}
		return _fIsHosted;
	}

	[SecuritySafeCritical]
	public virtual HostExecutionContext Capture()
	{
		HostExecutionContext result = null;
		if (CheckIfHosted())
		{
			IUnknownSafeHandle unknownSafeHandle = new IUnknownSafeHandle();
			result = new HostExecutionContext(unknownSafeHandle);
			CaptureHostSecurityContext(unknownSafeHandle);
		}
		return result;
	}

	[SecurityCritical]
	public virtual object SetHostExecutionContext(HostExecutionContext hostExecutionContext)
	{
		if (hostExecutionContext == null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NotNewCaptureContext"));
		}
		HostExecutionContextSwitcher hostExecutionContextSwitcher = new HostExecutionContextSwitcher();
		ExecutionContext executionContext = (hostExecutionContextSwitcher.executionContext = Thread.CurrentThread.GetMutableExecutionContext());
		hostExecutionContextSwitcher.currentHostContext = hostExecutionContext;
		hostExecutionContextSwitcher.previousHostContext = null;
		if (CheckIfHosted() && hostExecutionContext.State is IUnknownSafeHandle)
		{
			IUnknownSafeHandle unknownSafeHandle = new IUnknownSafeHandle();
			hostExecutionContextSwitcher.previousHostContext = new HostExecutionContext(unknownSafeHandle);
			IUnknownSafeHandle context = (IUnknownSafeHandle)hostExecutionContext.State;
			SetHostSecurityContext(context, fReturnPrevious: true, unknownSafeHandle);
		}
		executionContext.HostExecutionContext = hostExecutionContext;
		return hostExecutionContextSwitcher;
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public virtual void Revert(object previousState)
	{
		if (!(previousState is HostExecutionContextSwitcher hostExecutionContextSwitcher))
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CannotOverrideSetWithoutRevert"));
		}
		ExecutionContext mutableExecutionContext = Thread.CurrentThread.GetMutableExecutionContext();
		if (mutableExecutionContext != hostExecutionContextSwitcher.executionContext)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CannotUseSwitcherOtherThread"));
		}
		hostExecutionContextSwitcher.executionContext = null;
		HostExecutionContext hostExecutionContext = mutableExecutionContext.HostExecutionContext;
		if (hostExecutionContext != hostExecutionContextSwitcher.currentHostContext)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CannotUseSwitcherOtherThread"));
		}
		HostExecutionContext previousHostContext = hostExecutionContextSwitcher.previousHostContext;
		if (CheckIfHosted() && previousHostContext != null && previousHostContext.State is IUnknownSafeHandle)
		{
			IUnknownSafeHandle context = (IUnknownSafeHandle)previousHostContext.State;
			SetHostSecurityContext(context, fReturnPrevious: false, null);
		}
		mutableExecutionContext.HostExecutionContext = previousHostContext;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SecurityCritical]
	internal static HostExecutionContext CaptureHostExecutionContext()
	{
		HostExecutionContext result = null;
		HostExecutionContextManager currentHostExecutionContextManager = GetCurrentHostExecutionContextManager();
		if (currentHostExecutionContextManager != null)
		{
			result = currentHostExecutionContextManager.Capture();
		}
		return result;
	}

	[SecurityCritical]
	internal static object SetHostExecutionContextInternal(HostExecutionContext hostContext)
	{
		HostExecutionContextManager currentHostExecutionContextManager = GetCurrentHostExecutionContextManager();
		object result = null;
		if (currentHostExecutionContextManager != null)
		{
			result = currentHostExecutionContextManager.SetHostExecutionContext(hostContext);
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static HostExecutionContextManager GetCurrentHostExecutionContextManager()
	{
		return AppDomainManager.CurrentAppDomainManager?.HostExecutionContextManager;
	}

	internal static HostExecutionContextManager GetInternalHostExecutionContextManager()
	{
		if (_hostExecutionContextManager == null)
		{
			_hostExecutionContextManager = new HostExecutionContextManager();
		}
		return _hostExecutionContextManager;
	}
}
