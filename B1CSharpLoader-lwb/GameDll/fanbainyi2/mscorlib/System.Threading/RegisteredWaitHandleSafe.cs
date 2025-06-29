using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32;

namespace System.Threading;

internal sealed class RegisteredWaitHandleSafe : CriticalFinalizerObject
{
	private IntPtr registeredWaitHandle;

	private WaitHandle m_internalWaitObject;

	private bool bReleaseNeeded;

	private volatile int m_lock;

	private static IntPtr InvalidHandle
	{
		[SecuritySafeCritical]
		get
		{
			return Win32Native.INVALID_HANDLE_VALUE;
		}
	}

	internal RegisteredWaitHandleSafe()
	{
		registeredWaitHandle = InvalidHandle;
	}

	internal IntPtr GetHandle()
	{
		return registeredWaitHandle;
	}

	internal void SetHandle(IntPtr handle)
	{
		registeredWaitHandle = handle;
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal void SetWaitObject(WaitHandle waitObject)
	{
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			m_internalWaitObject = waitObject;
			if (waitObject != null)
			{
				m_internalWaitObject.SafeWaitHandle.DangerousAddRef(ref bReleaseNeeded);
			}
		}
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal bool Unregister(WaitHandle waitObject)
	{
		bool flag = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			bool flag2 = false;
			do
			{
				if (Interlocked.CompareExchange(ref m_lock, 1, 0) == 0)
				{
					flag2 = true;
					try
					{
						if (ValidHandle())
						{
							flag = UnregisterWaitNative(GetHandle(), waitObject?.SafeWaitHandle);
							if (flag)
							{
								if (bReleaseNeeded)
								{
									m_internalWaitObject.SafeWaitHandle.DangerousRelease();
									bReleaseNeeded = false;
								}
								SetHandle(InvalidHandle);
								m_internalWaitObject = null;
								GC.SuppressFinalize(this);
							}
						}
					}
					finally
					{
						m_lock = 0;
					}
				}
				Thread.SpinWait(1);
			}
			while (!flag2);
		}
		return flag;
	}

	private bool ValidHandle()
	{
		if (registeredWaitHandle != InvalidHandle)
		{
			return registeredWaitHandle != IntPtr.Zero;
		}
		return false;
	}

	[SecuritySafeCritical]
	~RegisteredWaitHandleSafe()
	{
		if (Interlocked.CompareExchange(ref m_lock, 1, 0) != 0)
		{
			return;
		}
		try
		{
			if (ValidHandle())
			{
				WaitHandleCleanupNative(registeredWaitHandle);
				if (bReleaseNeeded)
				{
					m_internalWaitObject.SafeWaitHandle.DangerousRelease();
					bReleaseNeeded = false;
				}
				SetHandle(InvalidHandle);
				m_internalWaitObject = null;
			}
		}
		finally
		{
			m_lock = 0;
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void WaitHandleCleanupNative(IntPtr handle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern bool UnregisterWaitNative(IntPtr handle, SafeHandle waitObject);
}
