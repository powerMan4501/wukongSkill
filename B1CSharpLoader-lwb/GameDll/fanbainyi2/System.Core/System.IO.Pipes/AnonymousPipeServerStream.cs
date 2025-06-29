using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Pipes;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class AnonymousPipeServerStream : PipeStream
{
	private SafePipeHandle m_clientHandle;

	private bool m_clientHandleExposed;

	public SafePipeHandle ClientSafePipeHandle
	{
		[SecurityCritical]
		get
		{
			m_clientHandleExposed = true;
			return m_clientHandle;
		}
	}

	public override PipeTransmissionMode TransmissionMode
	{
		[SecurityCritical]
		get
		{
			return PipeTransmissionMode.Byte;
		}
	}

	public override PipeTransmissionMode ReadMode
	{
		[SecurityCritical]
		set
		{
			CheckPipePropertyOperations();
			switch (value)
			{
			default:
				throw new ArgumentOutOfRangeException("value", System.SR.GetString("ArgumentOutOfRange_TransmissionModeByteOrMsg"));
			case PipeTransmissionMode.Message:
				throw new NotSupportedException(System.SR.GetString("NotSupported_AnonymousPipeMessagesNotSupported"));
			case PipeTransmissionMode.Byte:
				break;
			}
		}
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public AnonymousPipeServerStream()
		: this(PipeDirection.Out, HandleInheritability.None, 0, null)
	{
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public AnonymousPipeServerStream(PipeDirection direction)
		: this(direction, HandleInheritability.None, 0)
	{
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public AnonymousPipeServerStream(PipeDirection direction, HandleInheritability inheritability)
		: this(direction, inheritability, 0)
	{
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public AnonymousPipeServerStream(PipeDirection direction, HandleInheritability inheritability, int bufferSize)
		: base(direction, bufferSize)
	{
		if (direction == PipeDirection.InOut)
		{
			throw new NotSupportedException(System.SR.GetString("NotSupported_AnonymousPipeUnidirectional"));
		}
		if (inheritability < HandleInheritability.None || inheritability > HandleInheritability.Inheritable)
		{
			throw new ArgumentOutOfRangeException("inheritability", System.SR.GetString("ArgumentOutOfRange_HandleInheritabilityNoneOrInheritable"));
		}
		Microsoft.Win32.UnsafeNativeMethods.SECURITY_ATTRIBUTES secAttrs = PipeStream.GetSecAttrs(inheritability);
		Create(direction, secAttrs, bufferSize);
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public AnonymousPipeServerStream(PipeDirection direction, HandleInheritability inheritability, int bufferSize, PipeSecurity pipeSecurity)
		: base(direction, bufferSize)
	{
		if (direction == PipeDirection.InOut)
		{
			throw new NotSupportedException(System.SR.GetString("NotSupported_AnonymousPipeUnidirectional"));
		}
		if (inheritability < HandleInheritability.None || inheritability > HandleInheritability.Inheritable)
		{
			throw new ArgumentOutOfRangeException("inheritability", System.SR.GetString("ArgumentOutOfRange_HandleInheritabilityNoneOrInheritable"));
		}
		object pinningHandle;
		Microsoft.Win32.UnsafeNativeMethods.SECURITY_ATTRIBUTES secAttrs = PipeStream.GetSecAttrs(inheritability, pipeSecurity, out pinningHandle);
		try
		{
			Create(direction, secAttrs, bufferSize);
		}
		finally
		{
			if (pinningHandle != null)
			{
				((GCHandle)pinningHandle).Free();
			}
		}
	}

	~AnonymousPipeServerStream()
	{
		Dispose(disposing: false);
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public AnonymousPipeServerStream(PipeDirection direction, SafePipeHandle serverSafePipeHandle, SafePipeHandle clientSafePipeHandle)
		: base(direction, 0)
	{
		if (direction == PipeDirection.InOut)
		{
			throw new NotSupportedException(System.SR.GetString("NotSupported_AnonymousPipeUnidirectional"));
		}
		if (serverSafePipeHandle == null)
		{
			throw new ArgumentNullException("serverSafePipeHandle");
		}
		if (clientSafePipeHandle == null)
		{
			throw new ArgumentNullException("clientSafePipeHandle");
		}
		if (serverSafePipeHandle.IsInvalid)
		{
			throw new ArgumentException(System.SR.GetString("Argument_InvalidHandle"), "serverSafePipeHandle");
		}
		if (clientSafePipeHandle.IsInvalid)
		{
			throw new ArgumentException(System.SR.GetString("Argument_InvalidHandle"), "clientSafePipeHandle");
		}
		if (Microsoft.Win32.UnsafeNativeMethods.GetFileType(serverSafePipeHandle) != 3)
		{
			throw new IOException(System.SR.GetString("IO_IO_InvalidPipeHandle"));
		}
		if (Microsoft.Win32.UnsafeNativeMethods.GetFileType(clientSafePipeHandle) != 3)
		{
			throw new IOException(System.SR.GetString("IO_IO_InvalidPipeHandle"));
		}
		InitializeHandle(serverSafePipeHandle, isExposed: true, isAsync: false);
		m_clientHandle = clientSafePipeHandle;
		m_clientHandleExposed = true;
		base.State = PipeState.Connected;
	}

	[SecurityCritical]
	public string GetClientHandleAsString()
	{
		m_clientHandleExposed = true;
		return m_clientHandle.DangerousGetHandle().ToString();
	}

	[SecurityCritical]
	public void DisposeLocalCopyOfClientHandle()
	{
		if (m_clientHandle != null && !m_clientHandle.IsClosed)
		{
			m_clientHandle.Dispose();
		}
	}

	[SecurityCritical]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (!m_clientHandleExposed && m_clientHandle != null && !m_clientHandle.IsClosed)
			{
				m_clientHandle.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[SecurityCritical]
	private void Create(PipeDirection direction, Microsoft.Win32.UnsafeNativeMethods.SECURITY_ATTRIBUTES secAttrs, int bufferSize)
	{
		if (!((direction != PipeDirection.In) ? Microsoft.Win32.UnsafeNativeMethods.CreatePipe(out m_clientHandle, out var hWritePipe, secAttrs, bufferSize) : Microsoft.Win32.UnsafeNativeMethods.CreatePipe(out hWritePipe, out m_clientHandle, secAttrs, bufferSize)))
		{
			__Error.WinIOError(Marshal.GetLastWin32Error(), string.Empty);
		}
		if (!Microsoft.Win32.UnsafeNativeMethods.DuplicateHandle(Microsoft.Win32.UnsafeNativeMethods.GetCurrentProcess(), hWritePipe, Microsoft.Win32.UnsafeNativeMethods.GetCurrentProcess(), out var lpTargetHandle, 0u, bInheritHandle: false, 2u))
		{
			__Error.WinIOError(Marshal.GetLastWin32Error(), string.Empty);
		}
		hWritePipe.Dispose();
		InitializeHandle(lpTargetHandle, isExposed: false, isAsync: false);
		base.State = PipeState.Connected;
	}
}
