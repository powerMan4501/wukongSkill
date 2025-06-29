using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security;
using System.Security.Permissions;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Threading;

[ComVisible(true)]
[__DynamicallyInvokable]
public abstract class WaitHandle : MarshalByRefObject, IDisposable
{
	internal enum OpenExistingResult
	{
		Success,
		NameNotFound,
		PathNotFound,
		NameInvalid
	}

	[__DynamicallyInvokable]
	public const int WaitTimeout = 258;

	private const int MAX_WAITHANDLES = 64;

	private IntPtr waitHandle;

	[SecurityCritical]
	internal volatile SafeWaitHandle safeWaitHandle;

	internal bool hasThreadAffinity;

	protected static readonly IntPtr InvalidHandle = GetInvalidHandle();

	private const int WAIT_OBJECT_0 = 0;

	private const int WAIT_ABANDONED = 128;

	private const int WAIT_FAILED = int.MaxValue;

	private const int ERROR_TOO_MANY_POSTS = 298;

	[Obsolete("Use the SafeWaitHandle property instead.")]
	public virtual IntPtr Handle
	{
		[SecuritySafeCritical]
		get
		{
			if (safeWaitHandle != null)
			{
				return safeWaitHandle.DangerousGetHandle();
			}
			return InvalidHandle;
		}
		[SecurityCritical]
		[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		set
		{
			if (value == InvalidHandle)
			{
				if (safeWaitHandle != null)
				{
					safeWaitHandle.SetHandleAsInvalid();
					safeWaitHandle = null;
				}
			}
			else
			{
				safeWaitHandle = new SafeWaitHandle(value, ownsHandle: true);
			}
			waitHandle = value;
		}
	}

	public SafeWaitHandle SafeWaitHandle
	{
		[SecurityCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		get
		{
			if (safeWaitHandle == null)
			{
				safeWaitHandle = new SafeWaitHandle(InvalidHandle, ownsHandle: false);
			}
			return safeWaitHandle;
		}
		[SecurityCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		set
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				if (value == null)
				{
					safeWaitHandle = null;
					waitHandle = InvalidHandle;
				}
				else
				{
					safeWaitHandle = value;
					waitHandle = safeWaitHandle.DangerousGetHandle();
				}
			}
		}
	}

	[SecuritySafeCritical]
	private static IntPtr GetInvalidHandle()
	{
		return Win32Native.INVALID_HANDLE_VALUE;
	}

	[__DynamicallyInvokable]
	protected WaitHandle()
	{
		Init();
	}

	[SecuritySafeCritical]
	private void Init()
	{
		safeWaitHandle = null;
		waitHandle = InvalidHandle;
		hasThreadAffinity = false;
	}

	[SecurityCritical]
	internal void SetHandleInternal(SafeWaitHandle handle)
	{
		safeWaitHandle = handle;
		waitHandle = handle.DangerousGetHandle();
	}

	public virtual bool WaitOne(int millisecondsTimeout, bool exitContext)
	{
		if (millisecondsTimeout < -1)
		{
			throw new ArgumentOutOfRangeException("millisecondsTimeout", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		return WaitOne((long)millisecondsTimeout, exitContext);
	}

	public virtual bool WaitOne(TimeSpan timeout, bool exitContext)
	{
		long num = (long)timeout.TotalMilliseconds;
		if (-1 > num || int.MaxValue < num)
		{
			throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		return WaitOne(num, exitContext);
	}

	[__DynamicallyInvokable]
	public virtual bool WaitOne()
	{
		return WaitOne(-1, exitContext: false);
	}

	[__DynamicallyInvokable]
	public virtual bool WaitOne(int millisecondsTimeout)
	{
		return WaitOne(millisecondsTimeout, exitContext: false);
	}

	[__DynamicallyInvokable]
	public virtual bool WaitOne(TimeSpan timeout)
	{
		return WaitOne(timeout, exitContext: false);
	}

	[SecuritySafeCritical]
	private bool WaitOne(long timeout, bool exitContext)
	{
		return InternalWaitOne(safeWaitHandle, timeout, hasThreadAffinity, exitContext);
	}

	[SecurityCritical]
	internal static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext)
	{
		if (waitableSafeHandle == null)
		{
			throw new ObjectDisposedException(null, Environment.GetResourceString("ObjectDisposed_Generic"));
		}
		int num = WaitOneNative(waitableSafeHandle, (uint)millisecondsTimeout, hasThreadAffinity, exitContext);
		if (AppDomainPauseManager.IsPaused)
		{
			AppDomainPauseManager.ResumeEvent.WaitOneWithoutFAS();
		}
		if (num == 128)
		{
			ThrowAbandonedMutexException();
		}
		return num != 258;
	}

	[SecurityCritical]
	internal bool WaitOneWithoutFAS()
	{
		if (safeWaitHandle == null)
		{
			throw new ObjectDisposedException(null, Environment.GetResourceString("ObjectDisposed_Generic"));
		}
		long num = -1L;
		int num2 = WaitOneNative(safeWaitHandle, (uint)num, hasThreadAffinity, exitContext: false);
		if (num2 == 128)
		{
			ThrowAbandonedMutexException();
		}
		return num2 != 258;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	private static extern int WaitMultiple(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll);

	[SecuritySafeCritical]
	public static bool WaitAll(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext)
	{
		if (waitHandles == null)
		{
			throw new ArgumentNullException(Environment.GetResourceString("ArgumentNull_Waithandles"));
		}
		if (waitHandles.Length == 0)
		{
			throw new ArgumentNullException(Environment.GetResourceString("Argument_EmptyWaithandleArray"));
		}
		if (waitHandles.Length > 64)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_MaxWaitHandles"));
		}
		if (-1 > millisecondsTimeout)
		{
			throw new ArgumentOutOfRangeException("millisecondsTimeout", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		WaitHandle[] array = new WaitHandle[waitHandles.Length];
		for (int i = 0; i < waitHandles.Length; i++)
		{
			WaitHandle waitHandle = waitHandles[i];
			if (waitHandle == null)
			{
				throw new ArgumentNullException(Environment.GetResourceString("ArgumentNull_ArrayElement"));
			}
			if (RemotingServices.IsTransparentProxy(waitHandle))
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_WaitOnTransparentProxy"));
			}
			array[i] = waitHandle;
		}
		int num = WaitMultiple(array, millisecondsTimeout, exitContext, WaitAll: true);
		if (AppDomainPauseManager.IsPaused)
		{
			AppDomainPauseManager.ResumeEvent.WaitOneWithoutFAS();
		}
		if (128 <= num && 128 + array.Length > num)
		{
			ThrowAbandonedMutexException();
		}
		GC.KeepAlive(array);
		return num != 258;
	}

	public static bool WaitAll(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext)
	{
		long num = (long)timeout.TotalMilliseconds;
		if (-1 > num || int.MaxValue < num)
		{
			throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		return WaitAll(waitHandles, (int)num, exitContext);
	}

	[__DynamicallyInvokable]
	public static bool WaitAll(WaitHandle[] waitHandles)
	{
		return WaitAll(waitHandles, -1, exitContext: true);
	}

	[__DynamicallyInvokable]
	public static bool WaitAll(WaitHandle[] waitHandles, int millisecondsTimeout)
	{
		return WaitAll(waitHandles, millisecondsTimeout, exitContext: true);
	}

	[__DynamicallyInvokable]
	public static bool WaitAll(WaitHandle[] waitHandles, TimeSpan timeout)
	{
		return WaitAll(waitHandles, timeout, exitContext: true);
	}

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext)
	{
		if (waitHandles == null)
		{
			throw new ArgumentNullException(Environment.GetResourceString("ArgumentNull_Waithandles"));
		}
		if (waitHandles.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyWaithandleArray"));
		}
		if (64 < waitHandles.Length)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_MaxWaitHandles"));
		}
		if (-1 > millisecondsTimeout)
		{
			throw new ArgumentOutOfRangeException("millisecondsTimeout", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		WaitHandle[] array = new WaitHandle[waitHandles.Length];
		for (int i = 0; i < waitHandles.Length; i++)
		{
			WaitHandle waitHandle = waitHandles[i];
			if (waitHandle == null)
			{
				throw new ArgumentNullException(Environment.GetResourceString("ArgumentNull_ArrayElement"));
			}
			if (RemotingServices.IsTransparentProxy(waitHandle))
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_WaitOnTransparentProxy"));
			}
			array[i] = waitHandle;
		}
		int num = WaitMultiple(array, millisecondsTimeout, exitContext, WaitAll: false);
		if (AppDomainPauseManager.IsPaused)
		{
			AppDomainPauseManager.ResumeEvent.WaitOneWithoutFAS();
		}
		if (128 <= num && 128 + array.Length > num)
		{
			int num2 = num - 128;
			if (0 <= num2 && num2 < array.Length)
			{
				ThrowAbandonedMutexException(num2, array[num2]);
			}
			else
			{
				ThrowAbandonedMutexException();
			}
		}
		GC.KeepAlive(array);
		return num;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext)
	{
		long num = (long)timeout.TotalMilliseconds;
		if (-1 > num || int.MaxValue < num)
		{
			throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		return WaitAny(waitHandles, (int)num, exitContext);
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[__DynamicallyInvokable]
	public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout)
	{
		return WaitAny(waitHandles, timeout, exitContext: true);
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[__DynamicallyInvokable]
	public static int WaitAny(WaitHandle[] waitHandles)
	{
		return WaitAny(waitHandles, -1, exitContext: true);
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[__DynamicallyInvokable]
	public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout)
	{
		return WaitAny(waitHandles, millisecondsTimeout, exitContext: true);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern int SignalAndWaitOne(SafeWaitHandle waitHandleToSignal, SafeWaitHandle waitHandleToWaitOn, int millisecondsTimeout, bool hasThreadAffinity, bool exitContext);

	public static bool SignalAndWait(WaitHandle toSignal, WaitHandle toWaitOn)
	{
		return SignalAndWait(toSignal, toWaitOn, -1, exitContext: false);
	}

	public static bool SignalAndWait(WaitHandle toSignal, WaitHandle toWaitOn, TimeSpan timeout, bool exitContext)
	{
		long num = (long)timeout.TotalMilliseconds;
		if (-1 > num || int.MaxValue < num)
		{
			throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		return SignalAndWait(toSignal, toWaitOn, (int)num, exitContext);
	}

	[SecuritySafeCritical]
	public static bool SignalAndWait(WaitHandle toSignal, WaitHandle toWaitOn, int millisecondsTimeout, bool exitContext)
	{
		if (toSignal == null)
		{
			throw new ArgumentNullException("toSignal");
		}
		if (toWaitOn == null)
		{
			throw new ArgumentNullException("toWaitOn");
		}
		if (-1 > millisecondsTimeout)
		{
			throw new ArgumentOutOfRangeException("millisecondsTimeout", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		int num = SignalAndWaitOne(toSignal.safeWaitHandle, toWaitOn.safeWaitHandle, millisecondsTimeout, toWaitOn.hasThreadAffinity, exitContext);
		if (int.MaxValue != num && toSignal.hasThreadAffinity)
		{
			Thread.EndCriticalRegion();
			Thread.EndThreadAffinity();
		}
		if (128 == num)
		{
			ThrowAbandonedMutexException();
		}
		if (298 == num)
		{
			throw new InvalidOperationException(Environment.GetResourceString("Threading.WaitHandleTooManyPosts"));
		}
		if (num == 0)
		{
			return true;
		}
		return false;
	}

	private static void ThrowAbandonedMutexException()
	{
		throw new AbandonedMutexException();
	}

	private static void ThrowAbandonedMutexException(int location, WaitHandle handle)
	{
		throw new AbandonedMutexException(location, handle);
	}

	public virtual void Close()
	{
		Dispose(explicitDisposing: true);
		GC.SuppressFinalize(this);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	protected virtual void Dispose(bool explicitDisposing)
	{
		if (safeWaitHandle != null)
		{
			safeWaitHandle.Close();
		}
	}

	[__DynamicallyInvokable]
	public void Dispose()
	{
		Dispose(explicitDisposing: true);
		GC.SuppressFinalize(this);
	}
}
