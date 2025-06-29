using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.CompilerServices;

[ComVisible(false)]
internal struct DependentHandle
{
	private IntPtr _handle;

	public bool IsAllocated => _handle != (IntPtr)0;

	[SecurityCritical]
	public DependentHandle(object primary, object secondary)
	{
		IntPtr dependentHandle = (IntPtr)0;
		nInitialize(primary, secondary, out dependentHandle);
		_handle = dependentHandle;
	}

	[SecurityCritical]
	public object GetPrimary()
	{
		nGetPrimary(_handle, out var primary);
		return primary;
	}

	[SecurityCritical]
	public void GetPrimaryAndSecondary(out object primary, out object secondary)
	{
		nGetPrimaryAndSecondary(_handle, out primary, out secondary);
	}

	[SecurityCritical]
	public void Free()
	{
		if (_handle != (IntPtr)0)
		{
			IntPtr handle = _handle;
			_handle = (IntPtr)0;
			nFree(handle);
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void nInitialize(object primary, object secondary, out IntPtr dependentHandle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void nGetPrimary(IntPtr dependentHandle, out object primary);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void nGetPrimaryAndSecondary(IntPtr dependentHandle, out object primary, out object secondary);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void nFree(IntPtr dependentHandle);
}
