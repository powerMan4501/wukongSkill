using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;

namespace System;

internal class SizedReference : IDisposable
{
	internal volatile IntPtr _handle;

	public object Target
	{
		[SecuritySafeCritical]
		get
		{
			IntPtr handle = _handle;
			if (handle == IntPtr.Zero)
			{
				return null;
			}
			object targetOfSizedRef = GetTargetOfSizedRef(handle);
			if (!(_handle == IntPtr.Zero))
			{
				return targetOfSizedRef;
			}
			return null;
		}
	}

	public long ApproximateSize
	{
		[SecuritySafeCritical]
		get
		{
			IntPtr handle = _handle;
			if (handle == IntPtr.Zero)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_HandleIsNotInitialized"));
			}
			long approximateSizeOfSizedRef = GetApproximateSizeOfSizedRef(handle);
			if (_handle == IntPtr.Zero)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_HandleIsNotInitialized"));
			}
			return approximateSizeOfSizedRef;
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern IntPtr CreateSizedRef(object o);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void FreeSizedRef(IntPtr h);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern object GetTargetOfSizedRef(IntPtr h);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern long GetApproximateSizeOfSizedRef(IntPtr h);

	[SecuritySafeCritical]
	private void Free()
	{
		IntPtr handle = _handle;
		if (handle != IntPtr.Zero && Interlocked.CompareExchange(ref _handle, IntPtr.Zero, handle) == handle)
		{
			FreeSizedRef(handle);
		}
	}

	[SecuritySafeCritical]
	public SizedReference(object target)
	{
		IntPtr zero = IntPtr.Zero;
		zero = CreateSizedRef(target);
		_handle = zero;
	}

	~SizedReference()
	{
		Free();
	}

	public void Dispose()
	{
		Free();
		GC.SuppressFinalize(this);
	}
}
