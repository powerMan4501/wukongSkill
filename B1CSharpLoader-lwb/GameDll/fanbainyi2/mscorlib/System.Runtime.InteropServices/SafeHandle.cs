using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Security.Permissions;

namespace System.Runtime.InteropServices;

[SecurityCritical]
[__DynamicallyInvokable]
[SecurityPermission(SecurityAction.InheritanceDemand, UnmanagedCode = true)]
public abstract class SafeHandle : CriticalFinalizerObject, IDisposable
{
	protected IntPtr handle;

	private int _state;

	private bool _ownsHandle;

	private bool _fullyInitialized;

	[__DynamicallyInvokable]
	public bool IsClosed
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[__DynamicallyInvokable]
		get
		{
			return (_state & 1) == 1;
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
	protected SafeHandle(IntPtr invalidHandleValue, bool ownsHandle)
	{
		handle = invalidHandleValue;
		_state = 4;
		_ownsHandle = ownsHandle;
		if (!ownsHandle)
		{
			GC.SuppressFinalize(this);
		}
		_fullyInitialized = true;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	~SafeHandle()
	{
		Dispose(disposing: false);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private extern void InternalFinalize();

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	protected void SetHandle(IntPtr handle)
	{
		this.handle = handle;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public IntPtr DangerousGetHandle()
	{
		return handle;
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
		if (disposing)
		{
			InternalDispose();
		}
		else
		{
			InternalFinalize();
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private extern void InternalDispose();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[__DynamicallyInvokable]
	public extern void SetHandleAsInvalid();

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[__DynamicallyInvokable]
	protected abstract bool ReleaseHandle();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[__DynamicallyInvokable]
	public extern void DangerousAddRef(ref bool success);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[__DynamicallyInvokable]
	public extern void DangerousRelease();
}
