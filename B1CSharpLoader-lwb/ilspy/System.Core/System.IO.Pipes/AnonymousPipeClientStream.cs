using System.Security;
using System.Security.Permissions;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Pipes;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class AnonymousPipeClientStream : PipeStream
{
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
	public AnonymousPipeClientStream(string pipeHandleAsString)
		: this(PipeDirection.In, pipeHandleAsString)
	{
	}

	[SecurityCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public AnonymousPipeClientStream(PipeDirection direction, string pipeHandleAsString)
		: base(direction, 0)
	{
		if (direction == PipeDirection.InOut)
		{
			throw new NotSupportedException(System.SR.GetString("NotSupported_AnonymousPipeUnidirectional"));
		}
		if (pipeHandleAsString == null)
		{
			throw new ArgumentNullException("pipeHandleAsString");
		}
		long result = 0L;
		if (!long.TryParse(pipeHandleAsString, out result))
		{
			throw new ArgumentException(System.SR.GetString("Argument_InvalidHandle"), "pipeHandleAsString");
		}
		SafePipeHandle safePipeHandle = new SafePipeHandle((IntPtr)result, ownsHandle: true);
		if (safePipeHandle.IsInvalid)
		{
			throw new ArgumentException(System.SR.GetString("Argument_InvalidHandle"), "pipeHandleAsString");
		}
		Init(direction, safePipeHandle);
	}

	[SecurityCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public AnonymousPipeClientStream(PipeDirection direction, SafePipeHandle safePipeHandle)
		: base(direction, 0)
	{
		if (direction == PipeDirection.InOut)
		{
			throw new NotSupportedException(System.SR.GetString("NotSupported_AnonymousPipeUnidirectional"));
		}
		if (safePipeHandle == null)
		{
			throw new ArgumentNullException("safePipeHandle");
		}
		if (safePipeHandle.IsInvalid)
		{
			throw new ArgumentException(System.SR.GetString("Argument_InvalidHandle"), "safePipeHandle");
		}
		Init(direction, safePipeHandle);
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	private void Init(PipeDirection direction, SafePipeHandle safePipeHandle)
	{
		if (Microsoft.Win32.UnsafeNativeMethods.GetFileType(safePipeHandle) != 3)
		{
			throw new IOException(System.SR.GetString("IO_IO_InvalidPipeHandle"));
		}
		InitializeHandle(safePipeHandle, isExposed: true, isAsync: false);
		base.State = PipeState.Connected;
	}

	~AnonymousPipeClientStream()
	{
		Dispose(disposing: false);
	}
}
