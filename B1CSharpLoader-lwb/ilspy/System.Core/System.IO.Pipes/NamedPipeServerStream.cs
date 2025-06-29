using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Pipes;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class NamedPipeServerStream : PipeStream
{
	internal class ExecuteHelper
	{
		internal PipeStreamImpersonationWorker m_userCode;

		internal SafePipeHandle m_handle;

		internal bool m_mustRevert;

		internal int m_impersonateErrorCode;

		internal int m_revertImpersonateErrorCode;

		[SecurityCritical]
		internal ExecuteHelper(PipeStreamImpersonationWorker userCode, SafePipeHandle handle)
		{
			m_userCode = userCode;
			m_handle = handle;
		}
	}

	public const int MaxAllowedServerInstances = -1;

	[SecurityCritical]
	private static readonly IOCompletionCallback WaitForConnectionCallback;

	private static RuntimeHelpers.TryCode tryCode;

	private static RuntimeHelpers.CleanupCode cleanupCode;

	[SecurityCritical]
	static unsafe NamedPipeServerStream()
	{
		WaitForConnectionCallback = AsyncWaitForConnectionCallback;
		tryCode = ImpersonateAndTryCode;
		cleanupCode = RevertImpersonationOnBackout;
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeServerStream(string pipeName)
		: this(pipeName, PipeDirection.InOut, 1, PipeTransmissionMode.Byte, PipeOptions.None, 0, 0, null, HandleInheritability.None, (PipeAccessRights)0)
	{
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeServerStream(string pipeName, PipeDirection direction)
		: this(pipeName, direction, 1, PipeTransmissionMode.Byte, PipeOptions.None, 0, 0, null, HandleInheritability.None, (PipeAccessRights)0)
	{
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances)
		: this(pipeName, direction, maxNumberOfServerInstances, PipeTransmissionMode.Byte, PipeOptions.None, 0, 0, null, HandleInheritability.None, (PipeAccessRights)0)
	{
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode)
		: this(pipeName, direction, maxNumberOfServerInstances, transmissionMode, PipeOptions.None, 0, 0, null, HandleInheritability.None, (PipeAccessRights)0)
	{
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options)
		: this(pipeName, direction, maxNumberOfServerInstances, transmissionMode, options, 0, 0, null, HandleInheritability.None, (PipeAccessRights)0)
	{
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize)
		: this(pipeName, direction, maxNumberOfServerInstances, transmissionMode, options, inBufferSize, outBufferSize, null, HandleInheritability.None, (PipeAccessRights)0)
	{
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize, PipeSecurity pipeSecurity)
		: this(pipeName, direction, maxNumberOfServerInstances, transmissionMode, options, inBufferSize, outBufferSize, pipeSecurity, HandleInheritability.None, (PipeAccessRights)0)
	{
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize, PipeSecurity pipeSecurity, HandleInheritability inheritability)
		: this(pipeName, direction, maxNumberOfServerInstances, transmissionMode, options, inBufferSize, outBufferSize, pipeSecurity, inheritability, (PipeAccessRights)0)
	{
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize, PipeSecurity pipeSecurity, HandleInheritability inheritability, PipeAccessRights additionalAccessRights)
		: base(direction, transmissionMode, outBufferSize)
	{
		if (pipeName == null)
		{
			throw new ArgumentNullException("pipeName");
		}
		if (pipeName.Length == 0)
		{
			throw new ArgumentException(System.SR.GetString("Argument_NeedNonemptyPipeName"));
		}
		if ((options & (PipeOptions)1073741823) != PipeOptions.None)
		{
			throw new ArgumentOutOfRangeException("options", System.SR.GetString("ArgumentOutOfRange_OptionsInvalid"));
		}
		if (inBufferSize < 0)
		{
			throw new ArgumentOutOfRangeException("inBufferSize", System.SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if ((maxNumberOfServerInstances < 1 || maxNumberOfServerInstances > 254) && maxNumberOfServerInstances != -1)
		{
			throw new ArgumentOutOfRangeException("maxNumberOfServerInstances", System.SR.GetString("ArgumentOutOfRange_MaxNumServerInstances"));
		}
		if (inheritability < HandleInheritability.None || inheritability > HandleInheritability.Inheritable)
		{
			throw new ArgumentOutOfRangeException("inheritability", System.SR.GetString("ArgumentOutOfRange_HandleInheritabilityNoneOrInheritable"));
		}
		if ((additionalAccessRights & ~(PipeAccessRights.ChangePermissions | PipeAccessRights.TakeOwnership | PipeAccessRights.AccessSystemSecurity)) != 0)
		{
			throw new ArgumentOutOfRangeException("additionalAccessRights", System.SR.GetString("ArgumentOutOfRange_AdditionalAccessLimited"));
		}
		if (Environment.OSVersion.Platform == PlatformID.Win32Windows)
		{
			throw new PlatformNotSupportedException(System.SR.GetString("PlatformNotSupported_NamedPipeServers"));
		}
		string fullPath = Path.GetFullPath("\\\\.\\pipe\\" + pipeName);
		if (string.Compare(fullPath, "\\\\.\\pipe\\anonymous", StringComparison.OrdinalIgnoreCase) == 0)
		{
			throw new ArgumentOutOfRangeException("pipeName", System.SR.GetString("ArgumentOutOfRange_AnonymousReserved"));
		}
		object pinningHandle = null;
		Microsoft.Win32.UnsafeNativeMethods.SECURITY_ATTRIBUTES secAttrs = PipeStream.GetSecAttrs(inheritability, pipeSecurity, out pinningHandle);
		try
		{
			Create(fullPath, direction, maxNumberOfServerInstances, transmissionMode, options, inBufferSize, outBufferSize, additionalAccessRights, secAttrs);
		}
		finally
		{
			if (pinningHandle != null)
			{
				((GCHandle)pinningHandle).Free();
			}
		}
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeServerStream(PipeDirection direction, bool isAsync, bool isConnected, SafePipeHandle safePipeHandle)
		: base(direction, PipeTransmissionMode.Byte, 0)
	{
		if (safePipeHandle == null)
		{
			throw new ArgumentNullException("safePipeHandle");
		}
		if (safePipeHandle.IsInvalid)
		{
			throw new ArgumentException(System.SR.GetString("Argument_InvalidHandle"), "safePipeHandle");
		}
		if (Microsoft.Win32.UnsafeNativeMethods.GetFileType(safePipeHandle) != 3)
		{
			throw new IOException(System.SR.GetString("IO_IO_InvalidPipeHandle"));
		}
		InitializeHandle(safePipeHandle, isExposed: true, isAsync);
		if (isConnected)
		{
			base.State = PipeState.Connected;
		}
	}

	~NamedPipeServerStream()
	{
		Dispose(disposing: false);
	}

	[SecurityCritical]
	private void Create(string fullPipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize, PipeAccessRights rights, Microsoft.Win32.UnsafeNativeMethods.SECURITY_ATTRIBUTES secAttrs)
	{
		int openMode = (int)((uint)direction | (uint)((maxNumberOfServerInstances == 1) ? 524288 : 0) | (uint)options) | (int)rights;
		int pipeMode = ((int)transmissionMode << 2) | ((int)transmissionMode << 1);
		if (maxNumberOfServerInstances == -1)
		{
			maxNumberOfServerInstances = 255;
		}
		SafePipeHandle safePipeHandle = Microsoft.Win32.UnsafeNativeMethods.CreateNamedPipe(fullPipeName, openMode, pipeMode, maxNumberOfServerInstances, outBufferSize, inBufferSize, 0, secAttrs);
		if (safePipeHandle.IsInvalid)
		{
			__Error.WinIOError(Marshal.GetLastWin32Error(), string.Empty);
		}
		InitializeHandle(safePipeHandle, isExposed: false, (options & PipeOptions.Asynchronous) != 0);
	}

	[SecurityCritical]
	public void WaitForConnection()
	{
		CheckConnectOperationsServer();
		if (base.IsAsync)
		{
			IAsyncResult asyncResult = BeginWaitForConnection(null, null);
			EndWaitForConnection(asyncResult);
			return;
		}
		if (!Microsoft.Win32.UnsafeNativeMethods.ConnectNamedPipe(base.InternalHandle, Microsoft.Win32.UnsafeNativeMethods.NULL))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error != 535)
			{
				__Error.WinIOError(lastWin32Error, string.Empty);
			}
			if (lastWin32Error == 535 && base.State == PipeState.Connected)
			{
				throw new InvalidOperationException(System.SR.GetString("InvalidOperation_PipeAlreadyConnected"));
			}
		}
		base.State = PipeState.Connected;
	}

	public Task WaitForConnectionAsync(CancellationToken cancellationToken)
	{
		if (cancellationToken.IsCancellationRequested)
		{
			return Task.FromCancellation(cancellationToken);
		}
		if (!base.IsAsync)
		{
			return Task.Factory.StartNew(WaitForConnection, cancellationToken);
		}
		IOCancellationHelper state = (cancellationToken.CanBeCanceled ? new IOCancellationHelper(cancellationToken) : null);
		return Task.Factory.FromAsync(BeginWaitForConnection, EndWaitForConnection, state);
	}

	public Task WaitForConnectionAsync()
	{
		return WaitForConnectionAsync(CancellationToken.None);
	}

	[SecurityCritical]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public unsafe IAsyncResult BeginWaitForConnection(AsyncCallback callback, object state)
	{
		CheckConnectOperationsServer();
		if (!base.IsAsync)
		{
			throw new InvalidOperationException(System.SR.GetString("InvalidOperation_PipeNotAsync"));
		}
		PipeAsyncResult pipeAsyncResult = new PipeAsyncResult();
		pipeAsyncResult._handle = base.InternalHandle;
		pipeAsyncResult._userCallback = callback;
		pipeAsyncResult._userStateObject = state;
		IOCancellationHelper iOCancellationHelper = state as IOCancellationHelper;
		ManualResetEvent waitHandle = new ManualResetEvent(initialState: false);
		pipeAsyncResult._waitHandle = waitHandle;
		Overlapped overlapped = new Overlapped(0, 0, IntPtr.Zero, pipeAsyncResult);
		NativeOverlapped* ptr = (pipeAsyncResult._overlapped = overlapped.Pack(WaitForConnectionCallback, null));
		if (!Microsoft.Win32.UnsafeNativeMethods.ConnectNamedPipe(base.InternalHandle, ptr))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error == 997)
			{
				iOCancellationHelper?.AllowCancellation(base.InternalHandle, ptr);
				return pipeAsyncResult;
			}
			Overlapped.Free(ptr);
			pipeAsyncResult._overlapped = null;
			if (lastWin32Error == 535)
			{
				if (base.State == PipeState.Connected)
				{
					throw new InvalidOperationException(System.SR.GetString("InvalidOperation_PipeAlreadyConnected"));
				}
				pipeAsyncResult.CallUserCallback();
				return pipeAsyncResult;
			}
			__Error.WinIOError(lastWin32Error, string.Empty);
		}
		iOCancellationHelper?.AllowCancellation(base.InternalHandle, ptr);
		return pipeAsyncResult;
	}

	[SecurityCritical]
	public void EndWaitForConnection(IAsyncResult asyncResult)
	{
		CheckConnectOperationsServer();
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (!base.IsAsync)
		{
			throw new InvalidOperationException(System.SR.GetString("InvalidOperation_PipeNotAsync"));
		}
		PipeAsyncResult pipeAsyncResult = asyncResult as PipeAsyncResult;
		if (pipeAsyncResult == null)
		{
			__Error.WrongAsyncResult();
		}
		if (1 == Interlocked.CompareExchange(ref pipeAsyncResult._EndXxxCalled, 1, 0))
		{
			__Error.EndWaitForConnectionCalledTwice();
		}
		IOCancellationHelper iOCancellationHelper = pipeAsyncResult.AsyncState as IOCancellationHelper;
		iOCancellationHelper?.SetOperationCompleted();
		WaitHandle waitHandle = pipeAsyncResult._waitHandle;
		if (waitHandle != null)
		{
			try
			{
				waitHandle.WaitOne();
			}
			finally
			{
				waitHandle.Close();
			}
		}
		if (pipeAsyncResult._errorCode != 0)
		{
			if (pipeAsyncResult._errorCode == 995)
			{
				iOCancellationHelper?.ThrowIOOperationAborted();
			}
			__Error.WinIOError(pipeAsyncResult._errorCode, string.Empty);
		}
		base.State = PipeState.Connected;
	}

	[SecurityCritical]
	public void Disconnect()
	{
		CheckDisconnectOperations();
		if (!Microsoft.Win32.UnsafeNativeMethods.DisconnectNamedPipe(base.InternalHandle))
		{
			__Error.WinIOError(Marshal.GetLastWin32Error(), string.Empty);
		}
		base.State = PipeState.Disconnected;
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
	public void RunAsClient(PipeStreamImpersonationWorker impersonationWorker)
	{
		CheckWriteOperations();
		ExecuteHelper executeHelper = new ExecuteHelper(impersonationWorker, base.InternalHandle);
		RuntimeHelpers.ExecuteCodeWithGuaranteedCleanup(tryCode, cleanupCode, executeHelper);
		if (executeHelper.m_impersonateErrorCode != 0)
		{
			WinIOError(executeHelper.m_impersonateErrorCode);
		}
		else if (executeHelper.m_revertImpersonateErrorCode != 0)
		{
			WinIOError(executeHelper.m_revertImpersonateErrorCode);
		}
	}

	[SecurityCritical]
	private static void ImpersonateAndTryCode(object helper)
	{
		ExecuteHelper executeHelper = (ExecuteHelper)helper;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			if (Microsoft.Win32.UnsafeNativeMethods.ImpersonateNamedPipeClient(executeHelper.m_handle))
			{
				executeHelper.m_mustRevert = true;
			}
			else
			{
				executeHelper.m_impersonateErrorCode = Marshal.GetLastWin32Error();
			}
		}
		if (executeHelper.m_mustRevert)
		{
			executeHelper.m_userCode();
		}
	}

	[SecurityCritical]
	[PrePrepareMethod]
	private static void RevertImpersonationOnBackout(object helper, bool exceptionThrown)
	{
		ExecuteHelper executeHelper = (ExecuteHelper)helper;
		if (executeHelper.m_mustRevert && !Microsoft.Win32.UnsafeNativeMethods.RevertToSelf())
		{
			executeHelper.m_revertImpersonateErrorCode = Marshal.GetLastWin32Error();
		}
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
	public string GetImpersonationUserName()
	{
		CheckWriteOperations();
		StringBuilder stringBuilder = new StringBuilder(514);
		if (!Microsoft.Win32.UnsafeNativeMethods.GetNamedPipeHandleState(base.InternalHandle, Microsoft.Win32.UnsafeNativeMethods.NULL, Microsoft.Win32.UnsafeNativeMethods.NULL, Microsoft.Win32.UnsafeNativeMethods.NULL, Microsoft.Win32.UnsafeNativeMethods.NULL, stringBuilder, stringBuilder.Capacity))
		{
			WinIOError(Marshal.GetLastWin32Error());
		}
		return stringBuilder.ToString();
	}

	[SecurityCritical]
	private unsafe static void AsyncWaitForConnectionCallback(uint errorCode, uint numBytes, NativeOverlapped* pOverlapped)
	{
		Overlapped overlapped = Overlapped.Unpack(pOverlapped);
		PipeAsyncResult pipeAsyncResult = (PipeAsyncResult)overlapped.AsyncResult;
		Overlapped.Free(pOverlapped);
		pipeAsyncResult._overlapped = null;
		if (errorCode == 535)
		{
			errorCode = 0u;
		}
		pipeAsyncResult._errorCode = (int)errorCode;
		pipeAsyncResult._completedSynchronously = false;
		pipeAsyncResult._isComplete = true;
		ManualResetEvent waitHandle = pipeAsyncResult._waitHandle;
		if (waitHandle != null && !waitHandle.Set())
		{
			__Error.WinIOError();
		}
		pipeAsyncResult._userCallback?.Invoke(pipeAsyncResult);
	}

	[SecurityCritical]
	private void CheckConnectOperationsServer()
	{
		if (base.InternalHandle == null)
		{
			throw new InvalidOperationException(System.SR.GetString("InvalidOperation_PipeHandleNotSet"));
		}
		if (base.State == PipeState.Closed)
		{
			__Error.PipeNotOpen();
		}
		if (base.InternalHandle.IsClosed)
		{
			__Error.PipeNotOpen();
		}
		if (base.State == PipeState.Broken)
		{
			throw new IOException(System.SR.GetString("IO_IO_PipeBroken"));
		}
	}

	[SecurityCritical]
	private void CheckDisconnectOperations()
	{
		if (base.State == PipeState.WaitingToConnect)
		{
			throw new InvalidOperationException(System.SR.GetString("InvalidOperation_PipeNotYetConnected"));
		}
		if (base.State == PipeState.Disconnected)
		{
			throw new InvalidOperationException(System.SR.GetString("InvalidOperation_PipeAlreadyDisconnected"));
		}
		if (base.InternalHandle == null)
		{
			throw new InvalidOperationException(System.SR.GetString("InvalidOperation_PipeHandleNotSet"));
		}
		if (base.State == PipeState.Closed)
		{
			__Error.PipeNotOpen();
		}
		if (base.InternalHandle.IsClosed)
		{
			__Error.PipeNotOpen();
		}
	}
}
