using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Security.Permissions;

namespace System.Runtime.InteropServices;

[SecurityCritical]
[__DynamicallyInvokable]
[SecurityPermission(SecurityAction.InheritanceDemand, UnmanagedCode = true)]
public abstract class CriticalHandle : CriticalFinalizerObject, IDisposable
{
	protected IntPtr handle;

	private bool _isClosed;

	[__DynamicallyInvokable]
	public bool IsClosed
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[__DynamicallyInvokable]
		get
		{
			return _isClosed;
		}
	}

	[__DynamicallyInvokable]
	public abstract bool IsInvalid
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[__DynamicallyInvokable]
		get;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	protected CriticalHandle(IntPtr invalidHandleValue)
	{
		handle = invalidHandleValue;
		_isClosed = false;
	}

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[__DynamicallyInvokable]
	~CriticalHandle()
	{
		Dispose(disposing: false);
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private void Cleanup()
	{
		if (IsClosed)
		{
			return;
		}
		_isClosed = true;
		if (!IsInvalid)
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!ReleaseHandle())
			{
				FireCustomerDebugProbe();
			}
			Marshal.SetLastWin32Error(lastWin32Error);
			GC.SuppressFinalize(this);
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private extern void FireCustomerDebugProbe();

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	protected void SetHandle(IntPtr handle)
	{
		this.handle = handle;
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public void Close()
	{
		Dispose(disposing: true);
	}

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[__DynamicallyInvokable]
	public void Dispose()
	{
		Dispose(disposing: true);
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[__DynamicallyInvokable]
	protected virtual void Dispose(bool disposing)
	{
		Cleanup();
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[__DynamicallyInvokable]
	public void SetHandleAsInvalid()
	{
		_isClosed = true;
		GC.SuppressFinalize(this);
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[__DynamicallyInvokable]
	protected abstract bool ReleaseHandle();
}
