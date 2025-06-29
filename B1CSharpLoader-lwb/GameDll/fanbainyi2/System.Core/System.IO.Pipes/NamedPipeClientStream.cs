using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Pipes;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class NamedPipeClientStream : PipeStream
{
	private const int CancellationCheckIntervalInMilliseconds = 50;

	private string m_normalizedPipePath;

	private TokenImpersonationLevel m_impersonationLevel;

	private PipeOptions m_pipeOptions;

	private HandleInheritability m_inheritability;

	private int m_access;

	public int NumberOfServerInstances
	{
		[SecurityCritical]
		get
		{
			CheckPipePropertyOperations();
			if (!Microsoft.Win32.UnsafeNativeMethods.GetNamedPipeHandleState(base.InternalHandle, Microsoft.Win32.UnsafeNativeMethods.NULL, out var lpCurInstances, Microsoft.Win32.UnsafeNativeMethods.NULL, Microsoft.Win32.UnsafeNativeMethods.NULL, Microsoft.Win32.UnsafeNativeMethods.NULL, 0))
			{
				WinIOError(Marshal.GetLastWin32Error());
			}
			return lpCurInstances;
		}
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeClientStream(string pipeName)
		: this(".", pipeName, PipeDirection.InOut, PipeOptions.None, TokenImpersonationLevel.None, HandleInheritability.None)
	{
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeClientStream(string serverName, string pipeName)
		: this(serverName, pipeName, PipeDirection.InOut, PipeOptions.None, TokenImpersonationLevel.None, HandleInheritability.None)
	{
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeClientStream(string serverName, string pipeName, PipeDirection direction)
		: this(serverName, pipeName, direction, PipeOptions.None, TokenImpersonationLevel.None, HandleInheritability.None)
	{
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeClientStream(string serverName, string pipeName, PipeDirection direction, PipeOptions options)
		: this(serverName, pipeName, direction, options, TokenImpersonationLevel.None, HandleInheritability.None)
	{
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeClientStream(string serverName, string pipeName, PipeDirection direction, PipeOptions options, TokenImpersonationLevel impersonationLevel)
		: this(serverName, pipeName, direction, options, impersonationLevel, HandleInheritability.None)
	{
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeClientStream(string serverName, string pipeName, PipeDirection direction, PipeOptions options, TokenImpersonationLevel impersonationLevel, HandleInheritability inheritability)
		: base(direction, 0)
	{
		if (pipeName == null)
		{
			throw new ArgumentNullException("pipeName");
		}
		if (serverName == null)
		{
			throw new ArgumentNullException("serverName", System.SR.GetString("ArgumentNull_ServerName"));
		}
		if (pipeName.Length == 0)
		{
			throw new ArgumentException(System.SR.GetString("Argument_NeedNonemptyPipeName"));
		}
		if (serverName.Length == 0)
		{
			throw new ArgumentException(System.SR.GetString("Argument_EmptyServerName"));
		}
		if ((options & (PipeOptions)1073741823) != PipeOptions.None)
		{
			throw new ArgumentOutOfRangeException("options", System.SR.GetString("ArgumentOutOfRange_OptionsInvalid"));
		}
		if (impersonationLevel < TokenImpersonationLevel.None || impersonationLevel > TokenImpersonationLevel.Delegation)
		{
			throw new ArgumentOutOfRangeException("impersonationLevel", System.SR.GetString("ArgumentOutOfRange_ImpersonationInvalid"));
		}
		if (inheritability < HandleInheritability.None || inheritability > HandleInheritability.Inheritable)
		{
			throw new ArgumentOutOfRangeException("inheritability", System.SR.GetString("ArgumentOutOfRange_HandleInheritabilityNoneOrInheritable"));
		}
		m_normalizedPipePath = Path.GetFullPath("\\\\" + serverName + "\\pipe\\" + pipeName);
		if (string.Compare(m_normalizedPipePath, "\\\\.\\pipe\\anonymous", StringComparison.OrdinalIgnoreCase) == 0)
		{
			throw new ArgumentOutOfRangeException("pipeName", System.SR.GetString("ArgumentOutOfRange_AnonymousReserved"));
		}
		m_inheritability = inheritability;
		m_impersonationLevel = impersonationLevel;
		m_pipeOptions = options;
		if ((PipeDirection.In & direction) != 0)
		{
			m_access |= int.MinValue;
		}
		if ((PipeDirection.Out & direction) != 0)
		{
			m_access |= 1073741824;
		}
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeClientStream(string serverName, string pipeName, PipeAccessRights desiredAccessRights, PipeOptions options, TokenImpersonationLevel impersonationLevel, HandleInheritability inheritability)
		: base(DirectionFromRights(desiredAccessRights), 0)
	{
		if (pipeName == null)
		{
			throw new ArgumentNullException("pipeName");
		}
		if (serverName == null)
		{
			throw new ArgumentNullException("serverName", System.SR.GetString("ArgumentNull_ServerName"));
		}
		if (pipeName.Length == 0)
		{
			throw new ArgumentException(System.SR.GetString("Argument_NeedNonemptyPipeName"));
		}
		if (serverName.Length == 0)
		{
			throw new ArgumentException(System.SR.GetString("Argument_EmptyServerName"));
		}
		if ((options & (PipeOptions)1073741823) != PipeOptions.None)
		{
			throw new ArgumentOutOfRangeException("options", System.SR.GetString("ArgumentOutOfRange_OptionsInvalid"));
		}
		if (impersonationLevel < TokenImpersonationLevel.None || impersonationLevel > TokenImpersonationLevel.Delegation)
		{
			throw new ArgumentOutOfRangeException("impersonationLevel", System.SR.GetString("ArgumentOutOfRange_ImpersonationInvalid"));
		}
		if (inheritability < HandleInheritability.None || inheritability > HandleInheritability.Inheritable)
		{
			throw new ArgumentOutOfRangeException("inheritability", System.SR.GetString("ArgumentOutOfRange_HandleInheritabilityNoneOrInheritable"));
		}
		if ((desiredAccessRights & ~(PipeAccessRights.FullControl | PipeAccessRights.AccessSystemSecurity)) != 0)
		{
			throw new ArgumentOutOfRangeException("desiredAccessRights", System.SR.GetString("ArgumentOutOfRange_InvalidPipeAccessRights"));
		}
		m_normalizedPipePath = Path.GetFullPath("\\\\" + serverName + "\\pipe\\" + pipeName);
		if (string.Compare(m_normalizedPipePath, "\\\\.\\pipe\\anonymous", StringComparison.OrdinalIgnoreCase) == 0)
		{
			throw new ArgumentOutOfRangeException("pipeName", System.SR.GetString("ArgumentOutOfRange_AnonymousReserved"));
		}
		m_inheritability = inheritability;
		m_impersonationLevel = impersonationLevel;
		m_pipeOptions = options;
		m_access = (int)desiredAccessRights;
	}

	private static PipeDirection DirectionFromRights(PipeAccessRights rights)
	{
		PipeDirection pipeDirection = (PipeDirection)0;
		if ((rights & PipeAccessRights.ReadData) != 0)
		{
			pipeDirection |= PipeDirection.In;
		}
		if ((rights & PipeAccessRights.WriteData) != 0)
		{
			pipeDirection |= PipeDirection.Out;
		}
		return pipeDirection;
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeClientStream(PipeDirection direction, bool isAsync, bool isConnected, SafePipeHandle safePipeHandle)
		: base(direction, 0)
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

	~NamedPipeClientStream()
	{
		Dispose(disposing: false);
	}

	public void Connect()
	{
		Connect(-1);
	}

	[SecurityCritical]
	public void Connect(int timeout)
	{
		CheckConnectOperationsClient();
		if (timeout < 0 && timeout != -1)
		{
			throw new ArgumentOutOfRangeException("timeout", System.SR.GetString("ArgumentOutOfRange_InvalidTimeout"));
		}
		Microsoft.Win32.UnsafeNativeMethods.SECURITY_ATTRIBUTES secAttrs = PipeStream.GetSecAttrs(m_inheritability);
		int num = (int)m_pipeOptions;
		if (m_impersonationLevel != TokenImpersonationLevel.None)
		{
			num |= 0x100000;
			num |= (int)(m_impersonationLevel - 1) << 16;
		}
		int tickCount = Environment.TickCount;
		int num2 = 0;
		SpinWait spinWait = default(SpinWait);
		do
		{
			if (!Microsoft.Win32.UnsafeNativeMethods.WaitNamedPipe(m_normalizedPipePath, timeout - num2))
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (lastWin32Error == 2)
				{
					spinWait.SpinOnce();
					continue;
				}
				if (lastWin32Error == 0)
				{
					break;
				}
				__Error.WinIOError(lastWin32Error, string.Empty);
			}
			SafePipeHandle safePipeHandle = Microsoft.Win32.UnsafeNativeMethods.CreateNamedPipeClient(m_normalizedPipePath, m_access, FileShare.None, secAttrs, FileMode.Open, num, Microsoft.Win32.UnsafeNativeMethods.NULL);
			if (safePipeHandle.IsInvalid)
			{
				int lastWin32Error2 = Marshal.GetLastWin32Error();
				if (lastWin32Error2 == 231)
				{
					spinWait.SpinOnce();
					continue;
				}
				__Error.WinIOError(lastWin32Error2, string.Empty);
			}
			InitializeHandle(safePipeHandle, isExposed: false, (m_pipeOptions & PipeOptions.Asynchronous) != 0);
			base.State = PipeState.Connected;
			return;
		}
		while (timeout == -1 || (num2 = Environment.TickCount - tickCount) < timeout);
		throw new TimeoutException();
	}

	public Task ConnectAsync()
	{
		return ConnectAsync(-1, CancellationToken.None);
	}

	public Task ConnectAsync(int timeout)
	{
		return ConnectAsync(timeout, CancellationToken.None);
	}

	public Task ConnectAsync(CancellationToken cancellationToken)
	{
		return ConnectAsync(-1, cancellationToken);
	}

	public Task ConnectAsync(int timeout, CancellationToken cancellationToken)
	{
		CheckConnectOperationsClient();
		if (timeout < 0 && timeout != -1)
		{
			throw new ArgumentOutOfRangeException("timeout", System.SR.GetString("ArgumentOutOfRange_InvalidTimeout"));
		}
		if (cancellationToken.IsCancellationRequested)
		{
			return Task.FromCancellation(cancellationToken);
		}
		int startTime = Environment.TickCount;
		return Task.Factory.StartNew(delegate
		{
			ConnectInternal(timeout, cancellationToken, startTime);
		}, cancellationToken);
	}

	[SecuritySafeCritical]
	private void ConnectInternal(int timeout, CancellationToken cancellationToken, int startTime)
	{
		Microsoft.Win32.UnsafeNativeMethods.SECURITY_ATTRIBUTES secAttrs = PipeStream.GetSecAttrs(m_inheritability);
		int num = (int)m_pipeOptions;
		if (m_impersonationLevel != TokenImpersonationLevel.None)
		{
			num |= 0x100000;
			num |= (int)(m_impersonationLevel - 1) << 16;
		}
		int num2 = 0;
		SpinWait spinWait = default(SpinWait);
		do
		{
			cancellationToken.ThrowIfCancellationRequested();
			int num3 = timeout - num2;
			if (Microsoft.Win32.UnsafeNativeMethods.WaitNamedPipe(timeout: (!cancellationToken.CanBeCanceled) ? num3 : Math.Min(50, num3), name: m_normalizedPipePath))
			{
				goto IL_00ad;
			}
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error == 2)
			{
				spinWait.SpinOnce();
				continue;
			}
			if (lastWin32Error == 0)
			{
				if (!cancellationToken.CanBeCanceled)
				{
					break;
				}
				spinWait.SpinOnce();
				continue;
			}
			__Error.WinIOError(lastWin32Error, string.Empty);
			goto IL_00ad;
			IL_00ad:
			SafePipeHandle safePipeHandle = Microsoft.Win32.UnsafeNativeMethods.CreateNamedPipeClient(m_normalizedPipePath, m_access, FileShare.None, secAttrs, FileMode.Open, num, Microsoft.Win32.UnsafeNativeMethods.NULL);
			if (safePipeHandle.IsInvalid)
			{
				int lastWin32Error2 = Marshal.GetLastWin32Error();
				if (lastWin32Error2 == 231)
				{
					spinWait.SpinOnce();
					continue;
				}
				__Error.WinIOError(lastWin32Error2, string.Empty);
			}
			InitializeHandle(safePipeHandle, isExposed: false, (m_pipeOptions & PipeOptions.Asynchronous) != 0);
			base.State = PipeState.Connected;
			return;
		}
		while (timeout == -1 || (num2 = Environment.TickCount - startTime) < timeout);
		throw new TimeoutException();
	}

	[SecurityCritical]
	protected internal override void CheckPipePropertyOperations()
	{
		base.CheckPipePropertyOperations();
		if (base.State == PipeState.WaitingToConnect)
		{
			throw new InvalidOperationException(System.SR.GetString("InvalidOperation_PipeNotYetConnected"));
		}
		if (base.State == PipeState.Broken)
		{
			throw new IOException(System.SR.GetString("IO_IO_PipeBroken"));
		}
	}

	private void CheckConnectOperationsClient()
	{
		if (base.State == PipeState.Connected)
		{
			throw new InvalidOperationException(System.SR.GetString("InvalidOperation_PipeAlreadyConnected"));
		}
		if (base.State == PipeState.Closed)
		{
			__Error.PipeNotOpen();
		}
	}
}
