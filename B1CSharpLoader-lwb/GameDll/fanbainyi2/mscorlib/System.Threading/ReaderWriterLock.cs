using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace System.Threading;

[ComVisible(true)]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public sealed class ReaderWriterLock : CriticalFinalizerObject
{
	private IntPtr _hWriterEvent;

	private IntPtr _hReaderEvent;

	private IntPtr _hObjectHandle;

	private int _dwState;

	private int _dwULockID;

	private int _dwLLockID;

	private int _dwWriterID;

	private int _dwWriterSeqNum;

	private short _wWriterLevel;

	public bool IsReaderLockHeld
	{
		[SecuritySafeCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return PrivateGetIsReaderLockHeld();
		}
	}

	public bool IsWriterLockHeld
	{
		[SecuritySafeCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return PrivateGetIsWriterLockHeld();
		}
	}

	public int WriterSeqNum
	{
		[SecuritySafeCritical]
		get
		{
			return PrivateGetWriterSeqNum();
		}
	}

	[SecuritySafeCritical]
	public ReaderWriterLock()
	{
		PrivateInitialize();
	}

	[SecuritySafeCritical]
	~ReaderWriterLock()
	{
		PrivateDestruct();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern void AcquireReaderLockInternal(int millisecondsTimeout);

	[SecuritySafeCritical]
	public void AcquireReaderLock(int millisecondsTimeout)
	{
		AcquireReaderLockInternal(millisecondsTimeout);
	}

	[SecuritySafeCritical]
	public void AcquireReaderLock(TimeSpan timeout)
	{
		long num = (long)timeout.TotalMilliseconds;
		if (num < -1 || num > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		AcquireReaderLockInternal((int)num);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern void AcquireWriterLockInternal(int millisecondsTimeout);

	[SecuritySafeCritical]
	public void AcquireWriterLock(int millisecondsTimeout)
	{
		AcquireWriterLockInternal(millisecondsTimeout);
	}

	[SecuritySafeCritical]
	public void AcquireWriterLock(TimeSpan timeout)
	{
		long num = (long)timeout.TotalMilliseconds;
		if (num < -1 || num > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		AcquireWriterLockInternal((int)num);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private extern void ReleaseReaderLockInternal();

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public void ReleaseReaderLock()
	{
		ReleaseReaderLockInternal();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private extern void ReleaseWriterLockInternal();

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public void ReleaseWriterLock()
	{
		ReleaseWriterLockInternal();
	}

	[SecuritySafeCritical]
	public LockCookie UpgradeToWriterLock(int millisecondsTimeout)
	{
		LockCookie result = default(LockCookie);
		FCallUpgradeToWriterLock(ref result, millisecondsTimeout);
		return result;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern void FCallUpgradeToWriterLock(ref LockCookie result, int millisecondsTimeout);

	public LockCookie UpgradeToWriterLock(TimeSpan timeout)
	{
		long num = (long)timeout.TotalMilliseconds;
		if (num < -1 || num > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		return UpgradeToWriterLock((int)num);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern void DowngradeFromWriterLockInternal(ref LockCookie lockCookie);

	[SecuritySafeCritical]
	public void DowngradeFromWriterLock(ref LockCookie lockCookie)
	{
		DowngradeFromWriterLockInternal(ref lockCookie);
	}

	[SecuritySafeCritical]
	public LockCookie ReleaseLock()
	{
		LockCookie result = default(LockCookie);
		FCallReleaseLock(ref result);
		return result;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern void FCallReleaseLock(ref LockCookie result);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern void RestoreLockInternal(ref LockCookie lockCookie);

	[SecuritySafeCritical]
	public void RestoreLock(ref LockCookie lockCookie)
	{
		RestoreLockInternal(ref lockCookie);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private extern bool PrivateGetIsReaderLockHeld();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private extern bool PrivateGetIsWriterLockHeld();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern int PrivateGetWriterSeqNum();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	public extern bool AnyWritersSince(int seqNum);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern void PrivateInitialize();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern void PrivateDestruct();
}
